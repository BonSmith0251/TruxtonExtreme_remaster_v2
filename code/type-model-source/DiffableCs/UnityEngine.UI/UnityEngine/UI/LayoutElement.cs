namespace UnityEngine.UI;

[AddComponentMenu("Layout/Layout Element", 140)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200004D")]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000173")]
	private bool m_IgnoreLayout; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000174")]
	private float m_MinWidth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000175")]
	private float m_MinHeight; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000176")]
	private float m_PreferredWidth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000177")]
	private float m_PreferredHeight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000178")]
	private float m_FlexibleWidth; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000179")]
	private float m_FlexibleHeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400017A")]
	private int m_LayoutPriority; //Field offset: 0x3C

	[Token(Token = "0x170000C5")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 6
		[Address(RVA = "0x3442B20", Offset = "0x3441F20", Length = "0x59")]
		[Token(Token = "0x60002D1")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C4")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 6
		[Address(RVA = "0x3442B80", Offset = "0x3441F80", Length = "0x59")]
		[Token(Token = "0x60002CF")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000BF")]
	public override bool ignoreLayout
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60002C2")]
		 get { } //Length: 5
		[Address(RVA = "0x3442BE0", Offset = "0x3441FE0", Length = "0x59")]
		[Token(Token = "0x60002C3")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C6")]
	public override int layoutPriority
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 4
		[Address(RVA = "0x3442C40", Offset = "0x3442040", Length = "0x56")]
		[Token(Token = "0x60002D3")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000C1")]
	public override float minHeight
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x60002C8")]
		 get { } //Length: 6
		[Address(RVA = "0x3442CA0", Offset = "0x34420A0", Length = "0x59")]
		[Token(Token = "0x60002C9")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C0")]
	public override float minWidth
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x60002C6")]
		 get { } //Length: 6
		[Address(RVA = "0x3442D00", Offset = "0x3442100", Length = "0x59")]
		[Token(Token = "0x60002C7")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C3")]
	public override float preferredHeight
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 6
		[Address(RVA = "0x3442D60", Offset = "0x3442160", Length = "0x59")]
		[Token(Token = "0x60002CD")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000C2")]
	public override float preferredWidth
	{
		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x60002CA")]
		 get { } //Length: 6
		[Address(RVA = "0x3442DC0", Offset = "0x34421C0", Length = "0x59")]
		[Token(Token = "0x60002CB")]
		 set { } //Length: 89
	}

	[Address(RVA = "0x3442AE0", Offset = "0x3441EE0", Length = "0x38")]
	[Token(Token = "0x60002D4")]
	protected LayoutElement() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002C4")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002C5")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x60002D0")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x60002CE")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60002C2")]
	public override bool get_ignoreLayout() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60002D2")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x60002C8")]
	public override float get_minHeight() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x60002C6")]
	public override float get_minWidth() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x60002CC")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x60002CA")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x34429F0", Offset = "0x3441DF0", Length = "0x7")]
	[Token(Token = "0x60002D9")]
	protected virtual void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x34429F0", Offset = "0x3441DF0", Length = "0x7")]
	[Token(Token = "0x60002D8")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x3442A00", Offset = "0x3441E00", Length = "0x1F")]
	[Token(Token = "0x60002D7")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3442A20", Offset = "0x3441E20", Length = "0x1F")]
	[Token(Token = "0x60002D5")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x34429F0", Offset = "0x3441DF0", Length = "0x7")]
	[Token(Token = "0x60002D6")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x3442B20", Offset = "0x3441F20", Length = "0x59")]
	[Token(Token = "0x60002D1")]
	public override void set_flexibleHeight(float value) { }

	[Address(RVA = "0x3442B80", Offset = "0x3441F80", Length = "0x59")]
	[Token(Token = "0x60002CF")]
	public override void set_flexibleWidth(float value) { }

	[Address(RVA = "0x3442BE0", Offset = "0x3441FE0", Length = "0x59")]
	[Token(Token = "0x60002C3")]
	public override void set_ignoreLayout(bool value) { }

	[Address(RVA = "0x3442C40", Offset = "0x3442040", Length = "0x56")]
	[Token(Token = "0x60002D3")]
	public override void set_layoutPriority(int value) { }

	[Address(RVA = "0x3442CA0", Offset = "0x34420A0", Length = "0x59")]
	[Token(Token = "0x60002C9")]
	public override void set_minHeight(float value) { }

	[Address(RVA = "0x3442D00", Offset = "0x3442100", Length = "0x59")]
	[Token(Token = "0x60002C7")]
	public override void set_minWidth(float value) { }

	[Address(RVA = "0x3442D60", Offset = "0x3442160", Length = "0x59")]
	[Token(Token = "0x60002CD")]
	public override void set_preferredHeight(float value) { }

	[Address(RVA = "0x3442DC0", Offset = "0x34421C0", Length = "0x59")]
	[Token(Token = "0x60002CB")]
	public override void set_preferredWidth(float value) { }

	[Address(RVA = "0x3442A40", Offset = "0x3441E40", Length = "0x94")]
	[Token(Token = "0x60002DA")]
	protected void SetDirty() { }

}

