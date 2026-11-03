using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 12f;
        public float lifetime = 1.5f;
        public int damage = 1;

        void Start() { Destroy(gameObject, lifetime); }

        void Update() { transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World); }

        void OnTriggerEnter2D(Collider2D other)
        {
            var enemy = other.GetComponent<Enemy>();
            if (enemy == null) return;
            enemy.Damage(damage);
            Destroy(gameObject);
        }
    }
}
