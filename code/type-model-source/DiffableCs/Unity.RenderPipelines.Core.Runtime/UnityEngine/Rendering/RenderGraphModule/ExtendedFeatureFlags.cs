namespace UnityEngine.Rendering.RenderGraphModule;

[Flags]
[Token(Token = "0x2000268")]
public enum ExtendedFeatureFlags : int
{
	None = 0,
	TileProperties = 1,
	MultiviewRenderRegionsCompatible = 2,
	MultisampledShaderResolve = 4,
}

