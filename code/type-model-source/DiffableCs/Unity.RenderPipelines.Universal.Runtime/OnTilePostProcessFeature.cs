//Type is in global namespace

[DisallowMultipleRendererFeature("On Tile Post Processing (Untethered XR)")]
[Token(Token = "0x2000005")]
public class OnTilePostProcessFeature : ScriptableRendererFeature
{
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private PostProcessData m_PostProcessData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000002")]
	private Shader m_UberPostShader; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000003")]
	private RenderPassEvent postProcessingEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000004")]
	private Material m_OnTilePostProcessMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000005")]
	private ColorGradingLutPass m_ColorGradingLutPass; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000006")]
	private OnTilePostProcessPass m_OnTilePostProcessPass; //Field offset: 0x48

	[Address(RVA = "0x2D5B9E0", Offset = "0x2D5ADE0", Length = "0xE")]
	[Token(Token = "0x600000A")]
	public OnTilePostProcessFeature() { }

	[Address(RVA = "0x2D5B2A0", Offset = "0x2D5A6A0", Length = "0x3E4")]
	[Token(Token = "0x6000008")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D5B690", Offset = "0x2D5AA90", Length = "0x127")]
	[Token(Token = "0x6000006")]
	public virtual void Create() { }

	[Address(RVA = "0x2D5B7C0", Offset = "0x2D5ABC0", Length = "0x11")]
	[Token(Token = "0x6000009")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2D5B7E0", Offset = "0x2D5ABE0", Length = "0x47")]
	[Token(Token = "0x6000007")]
	private bool IsRuntimePlatformUntetheredXR() { }

	[Address(RVA = "0x2D5B830", Offset = "0x2D5AC30", Length = "0x1AB")]
	[Token(Token = "0x6000005")]
	private bool TryLoadResources() { }

}

