namespace KANAI.UI;

[Token(Token = "0x2000047")]
public class UIText : Text, ITextContext
{
	[Token(Token = "0x40001C7")]
	private static readonly List<Color> _fontColor; //Field offset: 0x0
	[Token(Token = "0x40001C8")]
	private static readonly List<Color32> _outlineColor; //Field offset: 0x8
	[Token(Token = "0x40001C9")]
	private static readonly List<Single> _outlineSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40001C3")]
	private UITextFontColor _textColorId; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40001C4")]
	private UITextOutlineColor _outlineColorId; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40001C5")]
	private UITextOutlineSize _outlineSizeId; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40001C6")]
	private string _localizeKey; //Field offset: 0x120

	[Token(Token = "0x17000037")]
	public UITextFontColor FontColor
	{
		[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700003A")]
	public override string localizeKey
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 8
		[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
		[Token(Token = "0x60001CF")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000038")]
	public UITextOutlineColor OutlineColor
	{
		[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000039")]
	public UITextOutlineSize OutlineSize
	{
		[Address(RVA = "0x1E2A1C0", Offset = "0x1E295C0", Length = "0x7")]
		[Token(Token = "0x60001CD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700003B")]
	public virtual string text
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 8
		[Address(RVA = "0x1E2A1D0", Offset = "0x1E295D0", Length = "0x8")]
		[Token(Token = "0x60001D1")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1E292A0", Offset = "0x1E286A0", Length = "0x188")]
	[Token(Token = "0x60001D3")]
	protected void _Setup() { }

	[Address(RVA = "0x1E29F20", Offset = "0x1E29320", Length = "0x277")]
	[Token(Token = "0x60001D5")]
	private void _updateOutline() { }

	[Address(RVA = "0x1E29430", Offset = "0x1E28830", Length = "0xAD8")]
	[Token(Token = "0x60001DC")]
	private static UIText() { }

	[Address(RVA = "0x1E29F10", Offset = "0x1E29310", Length = "0x7")]
	[Token(Token = "0x60001DB")]
	public UIText() { }

	[Address(RVA = "0x1E28B90", Offset = "0x1E27F90", Length = "0x18F")]
	[Token(Token = "0x60001D2")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
	[Token(Token = "0x60001CB")]
	public UITextFontColor get_FontColor() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60001CE")]
	public override string get_localizeKey() { }

	[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
	[Token(Token = "0x60001CC")]
	public UITextOutlineColor get_OutlineColor() { }

	[Address(RVA = "0x1E2A1C0", Offset = "0x1E295C0", Length = "0x7")]
	[Token(Token = "0x60001CD")]
	public UITextOutlineSize get_OutlineSize() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x60001D0")]
	public virtual string get_text() { }

	[Address(RVA = "0x1E28D20", Offset = "0x1E28120", Length = "0x94")]
	[Token(Token = "0x60001D7")]
	public static Color GetFontColor(UITextFontColor id) { }

	[Address(RVA = "0x1E28DC0", Offset = "0x1E281C0", Length = "0xE8")]
	[Token(Token = "0x60001DA")]
	public static bool GetLocalizeText(string key, out string result) { }

	[Address(RVA = "0x1E28EB0", Offset = "0x1E282B0", Length = "0x77")]
	[Token(Token = "0x60001D8")]
	public static Color32 GetOutlineColor(UITextOutlineColor id) { }

	[Address(RVA = "0x1E28F30", Offset = "0x1E28330", Length = "0x77")]
	[Token(Token = "0x60001D9")]
	public static float GetOutlineSize(UITextOutlineSize id) { }

	[Address(RVA = "0x1E28FB0", Offset = "0x1E283B0", Length = "0x1F8")]
	[Token(Token = "0x60001D6")]
	public static UITextFontColor GetUIColor(Color tcolor) { }

	[Address(RVA = "0x1E291B0", Offset = "0x1E285B0", Length = "0xEA")]
	[Token(Token = "0x60001D4")]
	public void OnUpdate() { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[Token(Token = "0x60001CF")]
	public override void set_localizeKey(string value) { }

	[Address(RVA = "0x1E2A1D0", Offset = "0x1E295D0", Length = "0x8")]
	[Token(Token = "0x60001D1")]
	public virtual void set_text(string value) { }

}

