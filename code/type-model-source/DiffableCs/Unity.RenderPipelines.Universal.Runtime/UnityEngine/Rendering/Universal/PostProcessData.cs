namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000012")]
public class PostProcessData : ScriptableObject
{
	[CategoryInfo(Name = "R: Default PostProcess Shaders", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[Token(Token = "0x2000013")]
	internal sealed class ShaderResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[FieldOffset(Offset = "0x10")]
		[ResourcePath("Shaders/PostProcessing/StopNaN.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000049")]
		public Shader stopNanPS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[ResourcePath("Shaders/PostProcessing/SubpixelMorphologicalAntialiasing.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004A")]
		public Shader subpixelMorphologicalAntialiasingPS; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[ResourcePath("Shaders/PostProcessing/GaussianDepthOfField.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004B")]
		public Shader gaussianDepthOfFieldPS; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[ResourcePath("Shaders/PostProcessing/BokehDepthOfField.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004C")]
		public Shader bokehDepthOfFieldPS; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[ResourcePath("Shaders/PostProcessing/CameraMotionBlur.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004D")]
		public Shader cameraMotionBlurPS; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[ResourcePath("Shaders/PostProcessing/PaniniProjection.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004E")]
		public Shader paniniProjectionPS; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[ResourcePath("Shaders/PostProcessing/LutBuilderLdr.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x400004F")]
		public Shader lutBuilderLdrPS; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[ResourcePath("Shaders/PostProcessing/LutBuilderHdr.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000050")]
		public Shader lutBuilderHdrPS; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[ResourcePath("Shaders/PostProcessing/Bloom.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000051")]
		public Shader bloomPS; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[ResourcePath("Shaders/PostProcessing/TemporalAA.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000052")]
		public Shader temporalAntialiasingPS; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[ResourcePath("Shaders/PostProcessing/LensFlareDataDriven.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000053")]
		public Shader LensFlareDataDrivenPS; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[ResourcePath("Shaders/PostProcessing/LensFlareScreenSpace.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000054")]
		public Shader LensFlareScreenSpacePS; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[ResourcePath("Shaders/PostProcessing/ScalingSetup.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000055")]
		public Shader scalingSetupPS; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[ResourcePath("Shaders/PostProcessing/EdgeAdaptiveSpatialUpsampling.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000056")]
		public Shader easuPS; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[ResourcePath("Shaders/PostProcessing/UberPost.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000057")]
		public Shader uberPostPS; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[ResourcePath("Shaders/PostProcessing/FinalPost.shader", SearchType::ProjectPath (0))]
		[Token(Token = "0x4000058")]
		public Shader finalPostPassPS; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x4000059")]
		private int m_ShaderResourcesVersion; //Field offset: 0x90

		[Token(Token = "0x17000007")]
		public override bool isAvailableInPlayerBuild
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000038")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000006")]
		public override int version
		{
			[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
			[Token(Token = "0x6000037")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000039")]
		public ShaderResources() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000038")]
		public override bool get_isAvailableInPlayerBuild() { }

		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x6000037")]
		public override int get_version() { }

	}

	[CategoryInfo(Name = "R: Default PostProcess Textures", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	[Token(Token = "0x2000014")]
	internal sealed class TextureResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005A")]
		public Texture2D[] blueNoise16LTex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[ResourcePaths(new IL2CPP_TYPE_STRING[] {"Textures/FilmGrain/Thin01.png", "Textures/FilmGrain/Thin02.png", "Textures/FilmGrain/Medium01.png", "Textures/FilmGrain/Medium02.png", "Textures/FilmGrain/Medium03.png", "Textures/FilmGrain/Medium04.png", "Textures/FilmGrain/Medium05.png", "Textures/FilmGrain/Medium06.png", "Textures/FilmGrain/Large01.png", "Textures/FilmGrain/Large02.png"}, SearchType::ProjectPath (0))]
		[Token(Token = "0x400005B")]
		public Texture2D[] filmGrainTex; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[ResourcePath("Textures/SMAA/AreaTex.tga", SearchType::ProjectPath (0))]
		[Token(Token = "0x400005C")]
		public Texture2D smaaAreaTex; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[ResourcePath("Textures/SMAA/SearchTex.tga", SearchType::ProjectPath (0))]
		[Token(Token = "0x400005D")]
		public Texture2D smaaSearchTex; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x400005E")]
		private int m_TexturesResourcesVersion; //Field offset: 0x30

		[Token(Token = "0x17000009")]
		public override bool isAvailableInPlayerBuild
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600003B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000008")]
		public override int version
		{
			[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
			[Token(Token = "0x600003A")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600003C")]
		public TextureResources() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600003B")]
		public override bool get_isAvailableInPlayerBuild() { }

		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x600003A")]
		public override int get_version() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000047")]
	public ShaderResources shaders; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000048")]
	public TextureResources textures; //Field offset: 0x20

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000036")]
	public PostProcessData() { }

}

