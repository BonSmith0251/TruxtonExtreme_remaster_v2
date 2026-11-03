using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class SpriteFlipbook : MonoBehaviour
    {
        public Sprite[] frames;
        public float fps = 12f;
        public bool destroyAtEnd = true;

        SpriteRenderer sr;
        float t;

        void Awake() { sr = GetComponent<SpriteRenderer>(); }

        void Update()
        {
            if (frames == null || frames.Length == 0 || sr == null) return;
            t += Time.deltaTime;
            int f = (int)(t * fps);
            if (f >= frames.Length)
            {
                if (destroyAtEnd) { Destroy(gameObject); return; }
                f %= frames.Length;
            }
            sr.sprite = frames[f];
        }
    }
}
