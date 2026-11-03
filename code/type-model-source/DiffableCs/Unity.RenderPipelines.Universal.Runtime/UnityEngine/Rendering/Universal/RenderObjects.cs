namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", null, null)]
[Token(Token = "0x200017A")]
[Tooltip("Render Objects simplifies the injection of additional render passes by exposing a selection of commonly used settings.")]
public class RenderObjects : ScriptableRendererFeature
{
	[Token(Token = "0x200017E")]
	internal class CustomCameraSettings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000891")]
		public bool overrideCamera; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000892")]
		public bool restoreCamera; //Field offset: 0x11
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000893")]
		public Vector4 offset; //Field offset: 0x14
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000894")]
		public float cameraFieldOfView; //Field offset: 0x24

		[Address(RVA = "0x2DC97F0", Offset = "0x2DC8BF0", Length = "0x12")]
		[Token(Token = "0x600081C")]
		public CustomCameraSettings() { }

	}

	[Token(Token = "0x200017D")]
	internal class FilterSettings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400088E")]
		public RenderQueueType RenderQueueType; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400088F")]
		public LayerMask LayerMask; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000890")]
		public String[] PassNames; //Field offset: 0x18

		[Address(RVA = "0x2DC9880", Offset = "0x2DC8C80", Length = "0x29")]
		[Token(Token = "0x600081B")]
		public FilterSettings() { }

	}

	[Token(Token = "0x200017B")]
	internal class RenderObjectsSettings
	{
		[Token(Token = "0x200017C")]
		internal enum OverrideMaterialMode : int
		{
			None = 0,
			Material = 1,
			Shader = 2,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400087D")]
		public string passTag; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400087E")]
		public RenderPassEvent Event; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400087F")]
		public FilterSettings filterSettings; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000880")]
		public Material overrideMaterial; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000881")]
		public int overrideMaterialPassIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000882")]
		public Shader overrideShader; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000883")]
		public int overrideShaderPassIndex; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000884")]
		public OverrideMaterialMode overrideMode; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000885")]
		public bool overrideDepthState; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000886")]
		public CompareFunction depthCompareFunction; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000887")]
		public bool enableWrite; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000888")]
		public StencilStateData stencilSettings; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000889")]
		public CustomCameraSettings cameraSettings; //Field offset: 0x60

		[Address(RVA = "0x2DCF580", Offset = "0x2DCE980", Length = "0x12E")]
		[Token(Token = "0x600081A")]
		public RenderObjectsSettings() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400087B")]
	public RenderObjectsSettings settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400087C")]
	private RenderObjectsPass renderObjectsPass; //Field offset: 0x28

	[Address(RVA = "0x2DCFA50", Offset = "0x2DCEE50", Length = "0x17D")]
	[Token(Token = "0x6000819")]
	public RenderObjects() { }

	[Address(RVA = "0x2DCF6B0", Offset = "0x2DCEAB0", Length = "0x91")]
	[Token(Token = "0x6000818")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DCF750", Offset = "0x2DCEB50", Length = "0x2F6")]
	[Token(Token = "0x6000817")]
	public virtual void Create() { }

}

