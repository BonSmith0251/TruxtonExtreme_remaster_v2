using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StarDrift
{
    public class TitleScreen : MonoBehaviour
    {
        public string nextScene = "Main";
        public float autoAdvanceSeconds = 2f;
        public string pressStartText = "PRESS SPACE";

        void Update()
        {
            if (Input.anyKeyDown || Time.timeSinceLevelLoad > autoAdvanceSeconds) SceneManager.LoadScene(nextScene);
        }

        void OnGUI()
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height * 0.75f, 200, 24), pressStartText);
        }
    }
}
