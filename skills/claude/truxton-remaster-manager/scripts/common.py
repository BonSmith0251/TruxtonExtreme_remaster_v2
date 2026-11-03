"""Shared paths and helpers for the Truxton remaster manager scripts."""
import datetime
import hashlib
import json
import os
from pathlib import Path

DEFAULT_ROOT = r"D:\games\Truxton Extreme"

DEFAULT_ROLES = {
    "pioneer": {
        "skill": "truxton-original-pioneer",
        "tools": "extractor/original-autoplayer",
        "job": "record the original game's behaviour as truxton-track/1",
    },
    "extractor": {
        "skill": "truxton-asset-extraction",
        "specialists": [
            "truxton-md01-manoeuvres",
            "truxton-sa01-left-entry",
            "truxton-sa01-left-flank",
            "truxton-sa01-right-entry",
            "truxton-sa01-right-flank",
            "truxton-sa01-top-entry",
        ],
        "tools": "extractor/UnityProject",
        "job": "update the remaster from pioneer evidence",
    },
    "checker": {
        "skill": "truxton-unity-checker",
        "tools": "extractor/UnityProject Round1Autopilot + Round1*Check.RunBatch",
        "job": "capture the remaster as truxton-track/1 and compare",
    },
    "manager": {"skill": "truxton-remaster-manager"},
}


def root_dir(value=None):
    return Path(value or os.environ.get("TRUXTON_ROOT") or DEFAULT_ROOT)


def manager_dir(root):
    return Path(root) / "extractor" / "manager"


def skill_targets():
    codex = Path(os.environ.get("CODEX_HOME") or Path.home() / ".codex") / "skills"
    claude = Path(os.environ.get("CLAUDE_CONFIG_DIR") or Path.home() / ".claude") / "skills"
    return {"codex": codex, "claude": claude}


def now():
    return datetime.datetime.now().astimezone().isoformat(timespec="seconds")


def tree_hash(path):
    """Hash a skill folder by relative path and content, ignoring caches."""
    path = Path(path)
    if not path.exists():
        return None
    digest = hashlib.sha256()
    for file in sorted(p for p in path.rglob("*") if p.is_file() and "__pycache__" not in p.parts):
        digest.update(file.relative_to(path).as_posix().encode() + b"\0")
        digest.update(hashlib.sha256(file.read_bytes()).digest())
    return digest.hexdigest()


def read_json(path, default=None):
    path = Path(path)
    if not path.exists():
        return default
    return json.loads(path.read_text(encoding="utf-8"))


def write_json(path, data):
    """Write through a temporary file so a reader never sees half a document."""
    path = Path(path)
    path.parent.mkdir(parents=True, exist_ok=True)
    temp = path.with_suffix(path.suffix + ".tmp")
    temp.write_text(json.dumps(data, indent=2, ensure_ascii=False) + "\n", encoding="utf-8")
    os.replace(temp, path)


def frontmatter(skill_md):
    """Return the simple key: value pairs of a SKILL.md frontmatter block."""
    text = Path(skill_md).read_text(encoding="utf-8")
    if not text.startswith("---"):
        return {}
    end = text.find("\n---", 3)
    if end < 0:
        return {}
    fields = {}
    for line in text[3:end].splitlines():
        if ":" in line and not line.startswith((" ", "\t")):
            key, value = line.split(":", 1)
            fields[key.strip()] = value.strip().strip('"')
    return fields
