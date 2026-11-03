namespace KANAI.UI;

[Token(Token = "0x200003E")]
public abstract class UISlideSelecter : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000197")]
	protected int _indexNo; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000198")]
	protected int _indexMax; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000199")]
	protected string _textColorTag; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400019A")]
	private UIButton _leftArrow; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400019B")]
	private UIButton _rightArrow; //Field offset: 0x38

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60001B9")]
	protected UISlideSelecter() { }

	[Address(RVA = "0x1E274A0", Offset = "0x1E268A0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x60001BA")]
	private void <Initialize>b__0_0() { }

	[Address(RVA = "0x1E274C0", Offset = "0x1E268C0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x60001BB")]
	private void <Initialize>b__0_1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B0")]
	public override void AddTextLabel(string tstr) { }

	[Address(RVA = "0x1E274E0", Offset = "0x1E268E0", Length = "0x81")]
	[Token(Token = "0x60001AD")]
	public void arrowControl(int t) { }

	[Address(RVA = "0x1E27040", Offset = "0x1E26440", Length = "0x16")]
	[Token(Token = "0x60001B4")]
	public override void DefaultTextColorTag() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x60001B2")]
	public override string GetTextLabel(int tno) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60001B7")]
	public int IndexMax() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60001B6")]
	public int IndexNo() { }

	[Address(RVA = "0x1E27060", Offset = "0x1E26460", Length = "0x156")]
	[Token(Token = "0x60001A9")]
	public override void Initialize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001AE")]
	public override bool IsLoop() { }

	[Address(RVA = "0x1E271C0", Offset = "0x1E265C0", Length = "0x72")]
	[Token(Token = "0x60001AB")]
	public override bool LeftMove(int n = 1) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B1")]
	public override void RestoreText(String[] tstrs) { }

	[Address(RVA = "0x1E27240", Offset = "0x1E26640", Length = "0xCF")]
	[Token(Token = "0x60001AC")]
	public override bool RightMove(int n = 1) { }

	[Token(Token = "0x60001B8")]
	public abstract void Selected(bool isSelect) { }

	[Address(RVA = "0x1E27310", Offset = "0x1E26710", Length = "0xD9")]
	[Token(Token = "0x60001AA")]
	public void SetClickAction(Action leftAct, Action rightAct) { }

	[Address(RVA = "0x1E27410", Offset = "0x1E26810", Length = "0x25")]
	[Token(Token = "0x60001AF")]
	public override void SetIndex(int n) { }

	[Address(RVA = "0x1E273F0", Offset = "0x1E267F0", Length = "0x17")]
	[Token(Token = "0x60001B5")]
	public void SetIndexMax(int n) { }

	[Address(RVA = "0x1E27440", Offset = "0x1E26840", Length = "0x54")]
	[Token(Token = "0x60001B3")]
	public override void SetTextColorTag(string colorTag) { }

}

