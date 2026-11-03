namespace UnityEngine.Rendering.Universal;

[Obsolete("Moved to GraphicsSettings. #from(2023.3)")]
[Token(Token = "0x20000B7")]
public class UniversalRenderPipelineEditorResources : ScriptableObject
{
	[Obsolete("UniversalRenderPipelineEditorResources.MaterialResources is obsolete GraphicsSettings.TryGetRenderPipelineSettings<UniversalRenderPipelineEditorMaterials>(). #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x20000B9")]
	internal sealed class MaterialResources
	{
		[FieldOffset(Offset = "0x10")]
		[Reload("Runtime/Materials/Lit.mat", Package::Root (1))]
		[Token(Token = "0x40003B7")]
		public Material lit; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Reload("Runtime/Materials/ParticlesUnlit.mat", Package::Root (1))]
		[Token(Token = "0x40003B8")]
		public Material particleLit; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Reload("Runtime/Materials/TerrainLit.mat", Package::Root (1))]
		[Token(Token = "0x40003B9")]
		public Material terrainLit; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Reload("Runtime/Materials/Decal.mat", Package::Root (1))]
		[Token(Token = "0x40003BA")]
		public Material decal; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000468")]
		public MaterialResources() { }

	}

	[Obsolete("UniversalRenderPipelineEditorResources.ShaderResources is obsolete GraphicsSettings.TryGetRenderPipelineSettings<UniversalRenderPipelineEditorShaders>(). #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x20000B8")]
	internal sealed class ShaderResources
	{
		[FieldOffset(Offset = "0x10")]
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractive.shadergraph", Package::Root (1))]
		[Token(Token = "0x40003AF")]
		public Shader autodeskInteractivePS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveTransparent.shadergraph", Package::Root (1))]
		[Token(Token = "0x40003B0")]
		public Shader autodeskInteractiveTransparentPS; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveMasked.shadergraph", Package::Root (1))]
		[Token(Token = "0x40003B1")]
		public Shader autodeskInteractiveMaskedPS; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Reload("Shaders/Terrain/TerrainDetailLit.shader", Package::Root (1))]
		[Token(Token = "0x40003B2")]
		public Shader terrainDetailLitPS; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Reload("Shaders/Terrain/WavingGrass.shader", Package::Root (1))]
		[Token(Token = "0x40003B3")]
		public Shader terrainDetailGrassPS; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Reload("Shaders/Terrain/WavingGrassBillboard.shader", Package::Root (1))]
		[Token(Token = "0x40003B4")]
		public Shader terrainDetailGrassBillboardPS; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Reload("Shaders/Nature/SpeedTree7.shader", Package::Root (1))]
		[Token(Token = "0x40003B5")]
		public Shader defaultSpeedTree7PS; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Reload("Shaders/Nature/SpeedTree8_PBRLit.shadergraph", Package::Root (1))]
		[Token(Token = "0x40003B6")]
		public Shader defaultSpeedTree8PS; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000467")]
		public ShaderResources() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("UniversalRenderPipelineEditorResources.ShaderResources is obsolete GraphicsSettings.TryGetRenderPipelineSettings<UniversalRenderPipelineEditorShaders>(). #from(2023.3)")]
	[Token(Token = "0x40003AD")]
	public ShaderResources shaders; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Obsolete("UniversalRenderPipelineEditorResources.MaterialResources is obsolete GraphicsSettings.TryGetRenderPipelineSettings<UniversalRenderPipelineEditorMaterials>(). #from(2023.3)")]
	[Token(Token = "0x40003AE")]
	public MaterialResources materials; //Field offset: 0x20

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000466")]
	public UniversalRenderPipelineEditorResources() { }

}

