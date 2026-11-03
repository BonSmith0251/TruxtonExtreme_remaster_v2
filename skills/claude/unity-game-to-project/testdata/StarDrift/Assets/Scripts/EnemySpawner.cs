using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class EnemySpawner : MonoBehaviour
    {
        public EnemyWave[] waves;
        public float startDelay = 0.5f;
        public float wavePause = 1f;
        public bool loop = true;

        IEnumerator Start()
        {
            yield return new WaitForSeconds(startDelay);
            do
            {
                foreach (var wave in waves)
                {
                    if (wave == null || wave.enemyPrefab == null) continue;
                    for (int i = 0; i < wave.count; i++)
                    {
                        var pts = wave.spawnPoints;
                        Vector2 at = pts != null && pts.Length > 0 ? pts[i % pts.Length] : new Vector2(Random.Range(-6f, 6f), 6f);
                        var go = Instantiate(wave.enemyPrefab, at, Quaternion.identity);
                        var e = go.GetComponent<Enemy>();
                        if (e != null) { e.speed = wave.speed; e.pattern = wave.pattern; }
                        var sr = go.GetComponent<SpriteRenderer>();
                        if (sr != null) sr.color = wave.tint;
                        if (GameManager.Instance != null) GameManager.Instance.Count("spawned");
                        yield return new WaitForSeconds(wave.interval);
                    }
                    yield return new WaitForSeconds(wavePause);
                }
            } while (loop);
        }
    }
}
