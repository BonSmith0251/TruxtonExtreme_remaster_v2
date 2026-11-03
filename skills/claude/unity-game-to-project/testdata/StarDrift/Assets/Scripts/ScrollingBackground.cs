using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class ScrollingBackground : MonoBehaviour
    {
        public float speed = 1f;
        public float tileHeight = 10f;
        public Transform[] tiles;

        void Update()
        {
            foreach (var t in tiles)
            {
                if (t == null) continue;
                t.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
                if (t.position.y < -tileHeight) t.Translate(Vector3.up * tileHeight * tiles.Length, Space.World);
            }
        }
    }
}
