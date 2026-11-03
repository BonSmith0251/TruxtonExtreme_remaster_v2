namespace UnityEngine;

[Flags]
[Token(Token = "0x20000FF")]
public enum CameraType : int
{
	Game = 1,
	SceneView = 2,
	Preview = 4,
	VR = 8,
	Reflection = 16,
}

