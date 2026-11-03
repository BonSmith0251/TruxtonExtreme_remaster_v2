using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class PlayerShip : MonoBehaviour
    {
        public float speed = 6f;
        public GameObject bulletPrefab;
        public AudioClip shootSfx;
        public float fireInterval = 0.15f;
        public Vector2 bounds = new Vector2(8f, 4.5f);
        [SerializeField] int lives = 3;

        float cooldown;
        AudioSource src;

        void Awake() { src = GetComponent<AudioSource>(); }

        void Update()
        {
            var gm = GameManager.Instance;
            bool auto = gm != null && gm.autopilot;
            float h = auto ? Mathf.Sin(Time.time * 1.3f) : Input.GetAxisRaw("Horizontal");
            float v = auto ? Mathf.Cos(Time.time * 0.7f) * 0.5f - 0.3f : Input.GetAxisRaw("Vertical");
            var p = transform.position + new Vector3(h, v, 0f) * speed * Time.deltaTime;
            p.x = Mathf.Clamp(p.x, -bounds.x, bounds.x);
            p.y = Mathf.Clamp(p.y, -bounds.y, bounds.y);
            transform.position = p;

            cooldown -= Time.deltaTime;
            bool fire = auto || Input.GetButton("Fire1") || Input.GetKey(KeyCode.Space);
            if (fire && cooldown <= 0f && bulletPrefab != null)
            {
                cooldown = fireInterval;
                Instantiate(bulletPrefab, transform.position + Vector3.up * 0.6f, Quaternion.identity);
                if (src != null && shootSfx != null) src.PlayOneShot(shootSfx, 0.3f);
                if (gm != null) gm.Count("shots");
            }
        }

        public void Hit()
        {
            lives--;
            var gm = GameManager.Instance;
            if (gm == null) return;
            gm.Count("hits");
            if (lives <= 0) gm.GameOver();
        }
    }
}
