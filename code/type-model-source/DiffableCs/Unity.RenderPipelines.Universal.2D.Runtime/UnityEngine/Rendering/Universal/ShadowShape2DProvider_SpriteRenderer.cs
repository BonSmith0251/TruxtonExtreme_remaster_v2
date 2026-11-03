namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000073")]
internal class ShadowShape2DProvider_SpriteRenderer : ShadowShape2DProvider
{
	[Token(Token = "0x4000279")]
	private const float k_InitialTrim = 0.05; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027A")]
	private ShadowShape2D m_PersistantShapeData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027B")]
	private SpriteDrawMode m_CurrentDrawMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400027C")]
	private Vector2 m_CurrentDrawModeSize; //Field offset: 0x1C

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002CC")]
	public ShadowShape2DProvider_SpriteRenderer() { }

	[Address(RVA = "0x2D41830", Offset = "0x2D40C30", Length = "0xBB")]
	[Token(Token = "0x60002CB")]
	public virtual void Disabled(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x2D418F0", Offset = "0x2D40CF0", Length = "0xCE")]
	[Token(Token = "0x60002CA")]
	public virtual void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x2D419C0", Offset = "0x2D40DC0", Length = "0x46")]
	[Token(Token = "0x60002C7")]
	public virtual bool IsShapeSource(Component sourceComponent) { }

	[Address(RVA = "0x2D41A10", Offset = "0x2D40E10", Length = "0xC9")]
	[Token(Token = "0x60002C9")]
	public virtual void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x2D41AE0", Offset = "0x2D40EE0", Length = "0x1D7")]
	[Token(Token = "0x60002C8")]
	public virtual void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60002C6")]
	public virtual int Priority() { }

	[Address(RVA = "0x2D41CC0", Offset = "0x2D410C0", Length = "0x43F")]
	[Token(Token = "0x60002C2")]
	private void SetFullRectShapeData(SpriteRenderer spriteRenderer, ShadowShape2D shadowShape2D) { }

	[Address(RVA = "0x2D42100", Offset = "0x2D41500", Length = "0x251")]
	[Token(Token = "0x60002C3")]
	private void SetPersistantShapeData(Sprite sprite, ShadowShape2D shadowShape2D, NativeSlice<Vector3> vertexSlice) { }

	[Address(RVA = "0x2D42360", Offset = "0x2D41760", Length = "0x1DD")]
	[Token(Token = "0x60002C4")]
	private void TryToSetPersistantShapeData(SpriteRenderer spriteRenderer, ShadowShape2D persistantShadowShape, bool force) { }

	[Address(RVA = "0x2D42540", Offset = "0x2D41940", Length = "0x1E")]
	[Token(Token = "0x60002C5")]
	private void UpdatePersistantShapeData(SpriteRenderer spriteRenderer) { }

}

