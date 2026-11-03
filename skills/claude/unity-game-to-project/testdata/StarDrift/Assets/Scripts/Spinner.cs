using System.Collections;
using UnityEngine;

namespace StarDrift
{
    public class Spinner : MonoBehaviour
    {
        public Vector3 degreesPerSecond = new Vector3(0f, 20f, 5f);
        void Update() { transform.Rotate(degreesPerSecond * Time.deltaTime); }
    }
}
