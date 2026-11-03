namespace UnityEngine.Rendering.Universal;

[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)")]
[Token(Token = "0x20000B4")]
public class XRSystemData : ScriptableObject
{
	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x20000B5")]
	internal sealed class ShaderResources
	{
		[FieldOffset(Offset = "0x10")]
		[Reload("Shaders/XR/XROcclusionMesh.shader", Package::Root (1))]
		[Token(Token = "0x4000399")]
		public Shader xrOcclusionMeshPS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Reload("Shaders/XR/XRMirrorView.shader", Package::Root (1))]
		[Token(Token = "0x400039A")]
		public Shader xrMirrorViewPS; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000441")]
		public ShaderResources() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)")]
	[Token(Token = "0x4000398")]
	public ShaderResources shaders; //Field offset: 0x18

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000440")]
	public XRSystemData() { }

}

