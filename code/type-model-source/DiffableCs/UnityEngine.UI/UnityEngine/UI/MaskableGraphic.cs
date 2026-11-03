namespace UnityEngine.UI;

[Token(Token = "0x2000056")]
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	[Token(Token = "0x2000057")]
	internal class CullStateChangedEvent : UnityEvent<Boolean>
	{

		[Address(RVA = "0x3435350", Offset = "0x3434750", Length = "0x39")]
		[Token(Token = "0x6000360")]
		public CullStateChangedEvent() { }

	}

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400019D")]
	protected bool m_ShouldRecalculateStencil; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400019E")]
	protected Material m_MaskMaterial; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400019F")]
	private RectMask2D m_ParentMask; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x40001A0")]
	private bool m_Maskable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x40001A1")]
	private bool m_IsMaskingGraphic; //Field offset: 0xC1
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0xC2")]
	[Obsolete("Not used anymore.", True)]
	[Token(Token = "0x40001A2")]
	protected bool m_IncludeForMasking; //Field offset: 0xC2
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40001A3")]
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0xC8
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0xD0")]
	[Obsolete("Not used anymore", True)]
	[Token(Token = "0x40001A4")]
	protected bool m_ShouldRecalculate; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40001A5")]
	protected int m_StencilValue; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001A6")]
	private readonly Vector3[] m_Corners; //Field offset: 0xD8

	[Token(Token = "0x170000DB")]
	public bool isMaskingGraphic
	{
		[Address(RVA = "0x32E5DA0", Offset = "0x32E51A0", Length = "0x8")]
		[Token(Token = "0x600034D")]
		 get { } //Length: 8
		[Address(RVA = "0x3449830", Offset = "0x3448C30", Length = "0xF")]
		[Token(Token = "0x600034E")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170000DA")]
	public bool maskable
	{
		[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
		[Token(Token = "0x600034B")]
		 get { } //Length: 8
		[Address(RVA = "0x3449840", Offset = "0x3448C40", Length = "0x2A")]
		[Token(Token = "0x600034C")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170000D9")]
	public CullStateChangedEvent onCullStateChanged
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x6000349")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[Token(Token = "0x600034A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170000DC")]
	private Rect rootCanvasRect
	{
		[Address(RVA = "0x3449420", Offset = "0x3448820", Length = "0x400")]
		[Token(Token = "0x6000359")]
		private get { } //Length: 1024
	}

	[Address(RVA = "0x3449320", Offset = "0x3448720", Length = "0xF6")]
	[Token(Token = "0x600035E")]
	protected MaskableGraphic() { }

	[Address(RVA = "0x3448A70", Offset = "0x3447E70", Length = "0x183")]
	[Token(Token = "0x6000350")]
	public override void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x32E5DA0", Offset = "0x32E51A0", Length = "0x8")]
	[Token(Token = "0x600034D")]
	public bool get_isMaskingGraphic() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[Token(Token = "0x600034B")]
	public bool get_maskable() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x6000349")]
	public CullStateChangedEvent get_onCullStateChanged() { }

	[Address(RVA = "0x3449420", Offset = "0x3448820", Length = "0x400")]
	[Token(Token = "0x6000359")]
	private Rect get_rootCanvasRect() { }

	[Address(RVA = "0x3448C00", Offset = "0x3448000", Length = "0x15F")]
	[Token(Token = "0x600034F")]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x3448D60", Offset = "0x3448160", Length = "0x51")]
	[Token(Token = "0x6000358")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x3448DC0", Offset = "0x34481C0", Length = "0xB7")]
	[Token(Token = "0x6000355")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3448E80", Offset = "0x3448280", Length = "0x55")]
	[Token(Token = "0x6000354")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3448EE0", Offset = "0x34482E0", Length = "0x51")]
	[Token(Token = "0x6000356")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	[Token(Token = "0x6000357")]
	public override void ParentMaskStateChanged() { }

	[Address(RVA = "0x3448F40", Offset = "0x3448340", Length = "0x22")]
	[Token(Token = "0x600035D")]
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x3448F70", Offset = "0x3448370", Length = "0x7")]
	[Token(Token = "0x600035B")]
	public override void RecalculateClipping() { }

	[Address(RVA = "0x3448F80", Offset = "0x3448380", Length = "0x90")]
	[Token(Token = "0x600035C")]
	public override void RecalculateMasking() { }

	[Address(RVA = "0x3449830", Offset = "0x3448C30", Length = "0xF")]
	[Token(Token = "0x600034E")]
	public void set_isMaskingGraphic(bool value) { }

	[Address(RVA = "0x3449840", Offset = "0x3448C40", Length = "0x2A")]
	[Token(Token = "0x600034C")]
	public void set_maskable(bool value) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[Token(Token = "0x600034A")]
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	[Address(RVA = "0x3449010", Offset = "0x3448410", Length = "0x56")]
	[Token(Token = "0x6000352")]
	public override void SetClipRect(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x3449070", Offset = "0x3448470", Length = "0x38")]
	[Token(Token = "0x6000353")]
	public override void SetClipSoftness(Vector2 clipSoftness) { }

	[Address(RVA = "0x34490B0", Offset = "0x34484B0", Length = "0x7")]
	[Token(Token = "0x600035F")]
	private override GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	[Address(RVA = "0x34490C0", Offset = "0x34484C0", Length = "0x185")]
	[Token(Token = "0x600035A")]
	private void UpdateClipParent() { }

	[Address(RVA = "0x3449250", Offset = "0x3448650", Length = "0xC8")]
	[Token(Token = "0x6000351")]
	private void UpdateCull(bool cull) { }

}

