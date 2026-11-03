namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Mask", 13)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000055")]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000198")]
	private RectTransform m_RectTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000199")]
	private bool m_ShowMaskGraphic; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019A")]
	private Graphic m_Graphic; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019B")]
	private Material m_MaskMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019C")]
	private Material m_UnmaskMaterial; //Field offset: 0x40

	[Token(Token = "0x170000D8")]
	public Graphic graphic
	{
		[Address(RVA = "0x34488B0", Offset = "0x3447CB0", Length = "0x63")]
		[Token(Token = "0x6000341")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000D6")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x3448920", Offset = "0x3447D20", Length = "0x63")]
		[Token(Token = "0x600033E")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000D7")]
	public bool showMaskGraphic
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600033F")]
		 get { } //Length: 5
		[Address(RVA = "0x3448990", Offset = "0x3447D90", Length = "0xDD")]
		[Token(Token = "0x6000340")]
		 set { } //Length: 221
	}

	[Address(RVA = "0x34488A0", Offset = "0x3447CA0", Length = "0xB")]
	[Token(Token = "0x6000342")]
	protected Mask() { }

	[Address(RVA = "0x34488B0", Offset = "0x3447CB0", Length = "0x63")]
	[Token(Token = "0x6000341")]
	public Graphic get_graphic() { }

	[Address(RVA = "0x3448920", Offset = "0x3447D20", Length = "0x63")]
	[Token(Token = "0x600033E")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600033F")]
	public bool get_showMaskGraphic() { }

	[Address(RVA = "0x3447DD0", Offset = "0x34471D0", Length = "0x316")]
	[Token(Token = "0x6000348")]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x34480F0", Offset = "0x34474F0", Length = "0xE2")]
	[Token(Token = "0x6000347")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x34481E0", Offset = "0x34475E0", Length = "0xBD")]
	[Token(Token = "0x6000343")]
	public override bool MaskEnabled() { }

	[Address(RVA = "0x34482A0", Offset = "0x34476A0", Length = "0x361")]
	[Token(Token = "0x6000346")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3448610", Offset = "0x3447A10", Length = "0x285")]
	[Token(Token = "0x6000345")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Not used anymore.")]
	[Token(Token = "0x6000344")]
	public override void OnSiblingGraphicEnabledDisabled() { }

	[Address(RVA = "0x3448990", Offset = "0x3447D90", Length = "0xDD")]
	[Token(Token = "0x6000340")]
	public void set_showMaskGraphic(bool value) { }

}

