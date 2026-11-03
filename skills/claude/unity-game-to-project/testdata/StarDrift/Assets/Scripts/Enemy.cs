using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class Enemy : MonoBehaviour
    {
        public int hp = 2;
        public int score = 100;
        [HideInInspector] public float speed = 2f;
        [HideInInspector] public WavePattern pattern;

        float phase;
        float baseX;

        void Start()
        {
            baseX = transform.position.x;
            phase = Random.value * 6.28f;
        }

        void Update()
        {
            var p = transform.position;
            p.y -= speed * Time.deltaTime;
            if (pattern == WavePattern.Sine) p.x = baseX + Mathf.Sin(Time.time * 3f + phase) * 1.5f;
            else if (pattern == WavePattern.Dive) p.y -= speed * 0.5f * Time.deltaTime;
            transform.position = p;
            if (p.y < -7f) Destroy(gameObject);
        }

        public void Damage(int amount)
        {
            hp -= amount;
            if (hp > 0) return;
            var gm = GameManager.Instance;
            if (gm != null)
            {
                gm.AddScore(score);
                gm.Explode(transform.position);
            }
            Destroy(gameObject);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.GetComponent<PlayerShip>();
            if (player == null) return;
            player.Hit();
            Destroy(gameObject);
        }
    }
}
