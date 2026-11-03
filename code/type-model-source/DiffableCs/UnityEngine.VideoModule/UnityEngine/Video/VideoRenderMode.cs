namespace UnityEngine.Video;

[RequiredByNativeCode]
[Token(Token = "0x2000004")]
public enum VideoRenderMode : int
{
	CameraFarPlane = 0,
	CameraNearPlane = 1,
	RenderTexture = 2,
	MaterialOverride = 3,
	APIOnly = 4,
}

