namespace OutGame.UI;

[Token(Token = "0x2000111")]
public class FirstLanguageSelection : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000112")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000496")]
		public int iIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000497")]
		public FirstLanguageSelection <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006E8")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x21F81A0", Offset = "0x21F75A0", Length = "0x2C")]
		[Token(Token = "0x60006E9")]
		internal void <Initialize>b__0() { }

	}

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000493")]
	private PopupButton[] _buttons; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000494")]
	private Area _currentArea; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000495")]
	private bool _isComplate; //Field offset: 0x6C

	[Address(RVA = "0x21E9410", Offset = "0x21E8810", Length = "0xCF")]
	[Token(Token = "0x60006E6")]
	private Area _areaChange(int tstep) { }

	[Address(RVA = "0x21E94E0", Offset = "0x21E88E0", Length = "0x1A8")]
	[Token(Token = "0x60006E5")]
	private bool _buttonUpdate() { }

	[Address(RVA = "0x21E8C30", Offset = "0x21E8030", Length = "0x7")]
	[Token(Token = "0x60006E7")]
	public FirstLanguageSelection() { }

	[Address(RVA = "0x21E8FE0", Offset = "0x21E83E0", Length = "0x2F")]
	[Token(Token = "0x60006E3")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x21E9010", Offset = "0x21E8410", Length = "0x315")]
	[Token(Token = "0x60006E2")]
	public virtual void Initialize() { }

	[Address(RVA = "0x21E9330", Offset = "0x21E8730", Length = "0xDA")]
	[Token(Token = "0x60006E4")]
	private void OnClickButton() { }

}

