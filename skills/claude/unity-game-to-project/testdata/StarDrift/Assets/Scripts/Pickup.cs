using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StarDrift
{
    public class Pickup : MonoBehaviour
    {
        public int value = 500;
        public float fallSpeed = 1.5f;

        void Update()
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
            transform.Rotate(0f, 0f, 90f * Time.deltaTime);
            if (transform.position.y < -7f) Destroy(gameObject);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<PlayerShip>() == null) return;
            if (GameManager.Instance != null) { GameManager.Instance.AddScore(value); GameManager.Instance.Count("pickups"); }
            Destroy(gameObject);
        }
    }
}
