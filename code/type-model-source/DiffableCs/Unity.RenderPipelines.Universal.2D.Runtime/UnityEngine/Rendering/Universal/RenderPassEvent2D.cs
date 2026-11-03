namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200004A")]
internal enum RenderPassEvent2D : int
{
	None = -1,
	BeforeRendering = 0,
	BeforeRenderingLayer = 100,
	BeforeRenderingShadows = 200,
	BeforeRenderingNormals = 300,
	BeforeRenderingLights = 400,
	BeforeRenderingSprites = 500,
	AfterRenderingLayer = 600,
	BeforeRenderingPostProcessing = 700,
	AfterRenderingPostProcessing = 800,
	AfterRendering = 900,
}

