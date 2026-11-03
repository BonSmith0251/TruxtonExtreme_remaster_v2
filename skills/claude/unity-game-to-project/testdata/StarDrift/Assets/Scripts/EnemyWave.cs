using System.Collections;
using UnityEngine;

namespace StarDrift
{
    [CreateAssetMenu(menuName = "StarDrift/Enemy Wave")]
    public class EnemyWave : ScriptableObject
    {
        public string waveName;
        public int count = 5;
        public float interval = 0.5f;
        public float speed = 2f;
        public Color tint = Color.white;
        public WavePattern pattern;
        public GameObject enemyPrefab;
        public Vector2[] spawnPoints;
    }
}
