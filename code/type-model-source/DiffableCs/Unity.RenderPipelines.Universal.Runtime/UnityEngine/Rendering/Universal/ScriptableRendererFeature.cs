namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[Token(Token = "0x20000C2")]
public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
{
	[Obsolete("This enum is not used. #from(6000.3)", False)]
	[Token(Token = "0x20000C3")]
	internal enum IntermediateTextureUsage : int
	{
		Unknown = 0,
		Required = 1,
		NotRequired = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400043F")]
	private bool m_Active; //Field offset: 0x18

	[Token(Token = "0x17000130")]
	public bool isActive
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 5
	}

	[Obsolete("This property is not used. #from(6000.3)", False)]
	[Token(Token = "0x17000131")]
	protected override IntermediateTextureUsage useIntermediateTextures
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60004B5")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2C6A050", Offset = "0x2C69450", Length = "0xB")]
	[Token(Token = "0x60004BF")]
	protected ScriptableRendererFeature() { }

	[Token(Token = "0x60004B8")]
	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Token(Token = "0x60004B6")]
	public abstract void Create() { }

	[Address(RVA = "0x2D92300", Offset = "0x2D91700", Length = "0x61")]
	[Token(Token = "0x60004BD")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004BE")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60004B4")]
	public bool get_isActive() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60004B5")]
	protected override IntermediateTextureUsage get_useIntermediateTextures() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004B7")]
	public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	[Address(RVA = "0x2D92370", Offset = "0x2D91770", Length = "0x8F")]
	[Token(Token = "0x60004B9")]
	private void OnEnable() { }

	[Address(RVA = "0x2D92400", Offset = "0x2D91800", Length = "0x8F")]
	[Token(Token = "0x60004BA")]
	private void OnValidate() { }

	[Address(RVA = "0x2D92490", Offset = "0x2D91890", Length = "0xF")]
	[Token(Token = "0x60004BB")]
	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60004BC")]
	public void SetActive(bool active) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60004B3")]
	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

}

