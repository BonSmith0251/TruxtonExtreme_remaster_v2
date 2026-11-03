namespace UnityEngine.UI;

[ExecuteAlways]
[Token(Token = "0x2000047")]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	protected float m_Spacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	protected bool m_ChildForceExpandWidth; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	protected bool m_ChildForceExpandHeight; //Field offset: 0x65
	[FieldOffset(Offset = "0x66")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	protected bool m_ChildControlWidth; //Field offset: 0x66
	[FieldOffset(Offset = "0x67")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	protected bool m_ChildControlHeight; //Field offset: 0x67
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000170")]
	protected bool m_ChildScaleWidth; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	[Token(Token = "0x4000171")]
	protected bool m_ChildScaleHeight; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[SerializeField]
	[Token(Token = "0x4000172")]
	protected bool m_ReverseArrangement; //Field offset: 0x6A

	[Token(Token = "0x170000B3")]
	public bool childControlHeight
	{
		[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
		[Token(Token = "0x60002AA")]
		 get { } //Length: 5
		[Address(RVA = "0x34370F0", Offset = "0x34364F0", Length = "0x4D")]
		[Token(Token = "0x60002AB")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B2")]
	public bool childControlWidth
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[Token(Token = "0x60002A8")]
		 get { } //Length: 5
		[Address(RVA = "0x3437140", Offset = "0x3436540", Length = "0x4D")]
		[Token(Token = "0x60002A9")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B1")]
	public bool childForceExpandHeight
	{
		[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
		[Token(Token = "0x60002A6")]
		 get { } //Length: 5
		[Address(RVA = "0x3437190", Offset = "0x3436590", Length = "0x4D")]
		[Token(Token = "0x60002A7")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B0")]
	public bool childForceExpandWidth
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[Token(Token = "0x60002A4")]
		 get { } //Length: 5
		[Address(RVA = "0x34371E0", Offset = "0x34365E0", Length = "0x4D")]
		[Token(Token = "0x60002A5")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B5")]
	public bool childScaleHeight
	{
		[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
		[Token(Token = "0x60002AE")]
		 get { } //Length: 5
		[Address(RVA = "0x3437230", Offset = "0x3436630", Length = "0x4D")]
		[Token(Token = "0x60002AF")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B4")]
	public bool childScaleWidth
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x60002AC")]
		 get { } //Length: 5
		[Address(RVA = "0x3437280", Offset = "0x3436680", Length = "0x4D")]
		[Token(Token = "0x60002AD")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B6")]
	public bool reverseArrangement
	{
		[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
		[Token(Token = "0x60002B0")]
		 get { } //Length: 5
		[Address(RVA = "0x34372D0", Offset = "0x34366D0", Length = "0x4D")]
		[Token(Token = "0x60002B1")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000AF")]
	public float spacing
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x60002A2")]
		 get { } //Length: 6
		[Address(RVA = "0x3437320", Offset = "0x3436720", Length = "0x4D")]
		[Token(Token = "0x60002A3")]
		 set { } //Length: 77
	}

	[Address(RVA = "0x3436280", Offset = "0x3435680", Length = "0xE")]
	[Token(Token = "0x60002B5")]
	protected HorizontalOrVerticalLayoutGroup() { }

	[Address(RVA = "0x3436290", Offset = "0x3435690", Length = "0x3F0")]
	[Token(Token = "0x60002B2")]
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
	[Token(Token = "0x60002AA")]
	public bool get_childControlHeight() { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[Token(Token = "0x60002A8")]
	public bool get_childControlWidth() { }

	[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
	[Token(Token = "0x60002A6")]
	public bool get_childForceExpandHeight() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[Token(Token = "0x60002A4")]
	public bool get_childForceExpandWidth() { }

	[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
	[Token(Token = "0x60002AE")]
	public bool get_childScaleHeight() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x60002AC")]
	public bool get_childScaleWidth() { }

	[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
	[Token(Token = "0x60002B0")]
	public bool get_reverseArrangement() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x60002A2")]
	public float get_spacing() { }

	[Address(RVA = "0x3436690", Offset = "0x3435A90", Length = "0x105")]
	[Token(Token = "0x60002B4")]
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	[Address(RVA = "0x34370F0", Offset = "0x34364F0", Length = "0x4D")]
	[Token(Token = "0x60002AB")]
	public void set_childControlHeight(bool value) { }

	[Address(RVA = "0x3437140", Offset = "0x3436540", Length = "0x4D")]
	[Token(Token = "0x60002A9")]
	public void set_childControlWidth(bool value) { }

	[Address(RVA = "0x3437190", Offset = "0x3436590", Length = "0x4D")]
	[Token(Token = "0x60002A7")]
	public void set_childForceExpandHeight(bool value) { }

	[Address(RVA = "0x34371E0", Offset = "0x34365E0", Length = "0x4D")]
	[Token(Token = "0x60002A5")]
	public void set_childForceExpandWidth(bool value) { }

	[Address(RVA = "0x3437230", Offset = "0x3436630", Length = "0x4D")]
	[Token(Token = "0x60002AF")]
	public void set_childScaleHeight(bool value) { }

	[Address(RVA = "0x3437280", Offset = "0x3436680", Length = "0x4D")]
	[Token(Token = "0x60002AD")]
	public void set_childScaleWidth(bool value) { }

	[Address(RVA = "0x34372D0", Offset = "0x34366D0", Length = "0x4D")]
	[Token(Token = "0x60002B1")]
	public void set_reverseArrangement(bool value) { }

	[Address(RVA = "0x3437320", Offset = "0x3436720", Length = "0x4D")]
	[Token(Token = "0x60002A3")]
	public void set_spacing(float value) { }

	[Address(RVA = "0x34367A0", Offset = "0x3435BA0", Length = "0x949")]
	[Token(Token = "0x60002B3")]
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

