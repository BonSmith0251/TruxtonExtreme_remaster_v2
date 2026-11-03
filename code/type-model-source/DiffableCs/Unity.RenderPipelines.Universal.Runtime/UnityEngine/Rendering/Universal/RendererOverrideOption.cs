namespace UnityEngine.Rendering.Universal;

[Obsolete("Renderer override is no longer used, renderers are referenced by index on the pipeline asset. #from(2023.1)")]
[Token(Token = "0x20001CA")]
public enum RendererOverrideOption : int
{
	Custom = 0,
	UsePipelineSettings = 1,
}

