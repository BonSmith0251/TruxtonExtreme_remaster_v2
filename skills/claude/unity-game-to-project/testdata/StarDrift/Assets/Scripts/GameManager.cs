using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace StarDrift
{
    [System.Serializable]
    public class LevelInfo
    {
        public string title;
        public string subtitle;
        public int targetScore;
    }

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public TextAsset levelInfoJson;
        public bool autopilot;
        public AudioClip explodeSfx;
        public GameObject explosionPrefab;

        int score;
        bool over;
        LevelInfo info;
        float smokeSeconds = -1f;
        string smokeOut;
        int errorCount;
        readonly Dictionary<string, int> counters = new Dictionary<string, int>();
        readonly List<string> errors = new List<string>();

        void Awake()
        {
            Instance = this;
            Application.logMessageReceived += OnLog;
            if (levelInfoJson != null) info = JsonUtility.FromJson<LevelInfo>(levelInfoJson.text);

            var args = System.Environment.GetCommandLineArgs();
            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i] == "-smoketest") float.TryParse(args[i + 1], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out smokeSeconds);
                if (args[i] == "-smokeout") smokeOut = args[i + 1];
            }
            if (smokeSeconds > 0) autopilot = true;
        }

        void OnDestroy()
        {
            Application.logMessageReceived -= OnLog;
        }

        void OnLog(string condition, string stack, LogType type)
        {
            if (type == LogType.Error || type == LogType.Exception || type == LogType.Assert)
            {
                errorCount++;
                if (errors.Count < 20) errors.Add(condition);
            }
        }

        public void Count(string key, int amount = 1)
        {
            counters.TryGetValue(key, out var v);
            counters[key] = v + amount;
        }

        public void AddScore(int amount)
        {
            score += amount;
            Count("kills");
        }

        public void Explode(Vector3 at)
        {
            if (explosionPrefab != null) Instantiate(explosionPrefab, at, Quaternion.identity);
            var src = GetComponent<AudioSource>();
            if (src != null && explodeSfx != null) src.PlayOneShot(explodeSfx, 0.6f);
        }

        public void GameOver()
        {
            over = true;
            Count("gameover");
        }

        void Update()
        {
            if (smokeSeconds > 0 && Time.timeSinceLevelLoad >= smokeSeconds)
            {
                WriteSmokeReport();
                smokeSeconds = -1f;
                Application.Quit(0);
            }
        }

        void WriteSmokeReport()
        {
            var sb = new StringBuilder();
            sb.Append("{\n");
            sb.AppendFormat("  \"scene\": \"{0}\",\n", UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            sb.AppendFormat("  \"title\": \"{0}\",\n", info != null ? info.title : "");
            sb.AppendFormat("  \"score\": {0},\n", score);
            sb.AppendFormat("  \"errors\": {0},\n", errorCount);
            sb.Append("  \"counters\": {");
            bool first = true;
            foreach (var kv in counters)
            {
                sb.AppendFormat("{0}\"{1}\": {2}", first ? "" : ", ", kv.Key, kv.Value);
                first = false;
            }
            sb.Append("},\n");
            sb.AppendFormat("  \"renderers\": {0},\n", FindObjectsByType<Renderer>(FindObjectsSortMode.None).Length);
            sb.AppendFormat("  \"behaviours\": {0},\n", FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).Length);
            sb.Append("  \"errorMessages\": [");
            for (int i = 0; i < errors.Count; i++)
                sb.AppendFormat("{0}\"{1}\"", i == 0 ? "" : ", ", errors[i].Replace("\\", "/").Replace("\"", "'").Replace("\n", " "));
            sb.Append("]\n}\n");
            var path = string.IsNullOrEmpty(smokeOut) ? Path.Combine(Application.persistentDataPath, "smoke.json") : smokeOut;
            File.WriteAllText(path, sb.ToString());
            Debug.Log("SMOKE REPORT written to " + path + "\n" + sb);
        }

        void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 400, 24), (info != null ? info.title : "STAR DRIFT") + "   SCORE " + score.ToString("D6"));
            if (over) GUI.Label(new Rect(Screen.width / 2 - 60, Screen.height / 2, 200, 24), "GAME OVER");
        }
    }
}
