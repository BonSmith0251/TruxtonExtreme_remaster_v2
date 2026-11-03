namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x2000408")]
public enum ShaderPropertyFlags : int
{
	None = 0,
	HideInInspector = 1,
	PerRendererData = 2,
	NoScaleOffset = 4,
	Normal = 8,
	HDR = 16,
	Gamma = 32,
	NonModifiableTextureData = 64,
	MainTexture = 128,
	MainColor = 256,
	Vector2 = 512,
	Vector3 = 1024,
}

