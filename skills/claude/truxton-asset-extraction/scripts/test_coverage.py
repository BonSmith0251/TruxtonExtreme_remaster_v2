"""Check coverage accounting using isolated files; never touch game outputs."""
import json
import tempfile
import unittest
from pathlib import Path

from coverage import coverage, identity


def write(path, value):
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(value), encoding="utf-8")


class CoverageTests(unittest.TestCase):
    def test_overlapping_exports_missing_raw_and_unmatched_identity(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            rows = [dict(source="source.bundle", serialized_file="CAB-Abc", path_id=str(pid), type="Mesh")
                    for pid in (9007199254740992, 9007199254740993, -9007199254740993)]
            inventory = root / "inventory.json"
            objects = root / "objects.jsonl"
            write(inventory, dict(counts={"Mesh": 3}, sources=[dict(source="opaque.bundle", error="Unknown header")]))
            objects.write_text("\n".join(json.dumps(r) for r in rows), encoding="utf-8")
            records = [dict(source=r["source"], cab="cab-abc", pathId=r["path_id"], type="Mesh", id=f"{i:024x}")
                       for i, r in enumerate(rows)]
            export_a, export_b = root / "a", root / "b"
            write(export_a / "dependency_graph.json", dict(objects=records, errors=[]))
            write(export_a / "manifest.json", dict(meshes=[dict(id=records[0]["id"])]))
            write(export_a / "raw" / (records[0]["id"] + ".json"), {"m_Name": "mesh"})
            (export_a / "raw" / (records[1]["id"] + ".json")).write_text("invalid JSON", encoding="utf-8")
            unknown = dict(records[0], source="another.bundle")
            write(export_b / "dependency_graph.json", dict(objects=[records[0], unknown], errors=[]))
            write(export_b / "manifest.json", {})
            write(export_b / "raw" / (records[0]["id"] + ".json"), {"m_Name": "mesh"})
            report = coverage(inventory, objects, [export_a, export_b, export_a])
            self.assertEqual(report["totals"]["inventoried"], 3)
            self.assertEqual(report["totals"]["parseable_raw_json"], 1)
            self.assertEqual(report["totals"]["without_selection_raw_json"], 2)
            self.assertEqual(report["totals"]["manifest_representation"], 1)
            self.assertEqual(len(report["output_issues"]), 2)
            self.assertEqual(len(report["export_identities_absent_from_inventory"]), 1)
            self.assertEqual(len(report["source_failures"]), 1)
            self.assertEqual(report["inventory_count_disagreements"], {})
            self.assertEqual(len(report["exports"]), 2)

    def test_duplicate_inventory_and_stale_counts_are_reported(self):
        with tempfile.TemporaryDirectory() as temporary:
            root = Path(temporary)
            write(root / "inventory.json", dict(counts={"Texture2D": 4}, sources=[]))
            row = dict(source="source", serialized_file="CAB", path_id="-1", type="Texture2D")
            (root / "objects.jsonl").write_text((json.dumps(row) + "\n") * 2, encoding="utf-8")
            report = coverage(root / "inventory.json", root / "objects.jsonl", [])
            self.assertEqual(report["duplicate_inventory_records"], 1)
            self.assertEqual(report["totals"]["inventoried"], 1)
            self.assertEqual(report["inventory_count_disagreements"]["Texture2D"], {"inventory": 4, "jsonl": 1})

    def test_identity_precision_and_source_are_preserved(self):
        row = dict(source="A\\B.bundle", cab="CAB-X", pathId="9007199254740993")
        self.assertEqual(identity(row), ("a/b.bundle", "cab-x", "9007199254740993"))
        self.assertNotEqual(identity(row), identity(dict(row, pathId="9007199254740992")))
        self.assertNotEqual(identity(row), identity(dict(row, source="other.bundle")))
        with self.assertRaises(ValueError):
            identity(dict(row, pathId=9007199254740993.0))


if __name__ == "__main__":
    unittest.main()
