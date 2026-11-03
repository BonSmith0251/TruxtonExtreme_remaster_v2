using UnityEngine;

// Keeps the game (and editor play mode) running when its window loses focus. Player Settings "Run In Background" is
// also on; this sets it at start-up too, so it holds even if an open editor writes its old project settings back.
public static class Round1RunInBackground
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Enable(){Application.runInBackground=true;}
}
