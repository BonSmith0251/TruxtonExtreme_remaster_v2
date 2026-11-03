namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000071")]
internal class ShadowShape2DProvider_Collider2D : ShadowShape2DProvider
{
	[Token(Token = "0x2000072")]
	private struct MinMaxBounds
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000277")]
		public Vector3 min; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000278")]
		public Vector3 max; //Field offset: 0xC

		[Address(RVA = "0x2D35870", Offset = "0x2D34C70", Length = "0x54")]
		[Token(Token = "0x60002C1")]
		public MinMaxBounds(ref Bounds bounds) { }

		[Address(RVA = "0x2D35820", Offset = "0x2D34C20", Length = "0x45")]
		[Token(Token = "0x60002C0")]
		public bool Intersects(ref MinMaxBounds bounds) { }

	}

	[Token(Token = "0x400026E")]
	private const float k_InitialTrim = 0.05; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400026F")]
	private List<Bounds> m_ShadowShapeBounds; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000270")]
	private List<MinMaxBounds> m_ShadowShapeMinMaxBounds; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000271")]
	private MinMaxBounds m_ShadowCombinedShapeMinMaxBounds; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000272")]
	private Bounds m_LastWorldCullingBounds; //Field offset: 0x38
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000273")]
	private Matrix4x4 m_LastColliderSpace; //Field offset: 0x50
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000274")]
	private bool m_ShadowDirty; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000275")]
	private uint m_ShadowStateHash; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000276")]
	private PhysicsShapeGroup2D m_ShadowShapeGroup; //Field offset: 0x98

	[Address(RVA = "0x2D41820", Offset = "0x2D40C20", Length = "0xE")]
	[Token(Token = "0x60002BF")]
	public ShadowShape2DProvider_Collider2D() { }

	[Address(RVA = "0x2D3FCF0", Offset = "0x2D3F0F0", Length = "0x1566")]
	[Token(Token = "0x60002B9")]
	private void CalculateShadows(Collider2D collider, ShadowShape2D persistantShapeObject, Bounds worldCullingBounds) { }

	[Address(RVA = "0x2D41260", Offset = "0x2D40660", Length = "0x5D")]
	[Token(Token = "0x60002B8")]
	private static void ClearShapes(ShadowShape2D persistantShapeObject) { }

	[Address(RVA = "0x2D412C0", Offset = "0x2D406C0", Length = "0x111")]
	[Token(Token = "0x60002B6")]
	private static bool CompareApproximately(ref Bounds a, ref Bounds b) { }

	[Address(RVA = "0x2D413E0", Offset = "0x2D407E0", Length = "0x7")]
	[Token(Token = "0x60002BE")]
	public virtual void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x2D413F0", Offset = "0x2D407F0", Length = "0x72")]
	[Token(Token = "0x60002BA")]
	private void Initialize() { }

	[Address(RVA = "0x2D41470", Offset = "0x2D40870", Length = "0x71")]
	[Token(Token = "0x60002BB")]
	public virtual bool IsShapeSource(Component sourceComponent) { }

	[Address(RVA = "0x2D414F0", Offset = "0x2D408F0", Length = "0xB8")]
	[Token(Token = "0x60002BD")]
	public virtual void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape) { }

	[Address(RVA = "0x2D413E0", Offset = "0x2D407E0", Length = "0x7")]
	[Token(Token = "0x60002BC")]
	public virtual void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShapeData) { }

	[Address(RVA = "0x2D415B0", Offset = "0x2D409B0", Length = "0x262")]
	[Token(Token = "0x60002B7")]
	private static void TransformBounds2D(Matrix4x4 transform, ref Bounds bounds) { }

}

