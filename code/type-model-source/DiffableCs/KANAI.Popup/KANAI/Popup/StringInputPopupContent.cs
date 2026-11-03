namespace KANAI.Popup;

[Token(Token = "0x2000036")]
public class StringInputPopupContent : PopupContentBase
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000107")]
	private InputField _stringInput; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000108")]
	private string <InputString>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000109")]
	private bool <IsChange>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400010A")]
	public int MaxString; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400010B")]
	private Func<String, String> <InputFilter>k__BackingField; //Field offset: 0x78

	[Token(Token = "0x1700003C")]
	public private Func<String, String> InputFilter
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000173")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000174")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700003A")]
	public private string InputString
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600016F")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000170")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700003B")]
	public private bool IsChange
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000171")]
		 get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000172")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1E0D610", Offset = "0x1E0CA10", Length = "0x97")]
	[Token(Token = "0x600016E")]
	private void _CheckText(bool isMaxCheck) { }

	[Address(RVA = "0x1E0D6B0", Offset = "0x1E0CAB0", Length = "0x1C")]
	[Token(Token = "0x6000175")]
	public StringInputPopupContent() { }

	[Address(RVA = "0x1E0D510", Offset = "0x1E0C910", Length = "0xF7")]
	[CompilerGenerated]
	[Token(Token = "0x6000176")]
	private void <Initialize>b__0_0(string s) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000173")]
	public Func<String, String> get_InputFilter() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600016F")]
	public string get_InputString() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000171")]
	public bool get_IsChange() { }

	[Address(RVA = "0x1E0CFF0", Offset = "0x1E0C3F0", Length = "0x3AC")]
	[Token(Token = "0x600016A")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E0D3A0", Offset = "0x1E0C7A0", Length = "0x7E")]
	[Token(Token = "0x600016D")]
	public void OnChangeString(bool isMaxCheck) { }

	[Address(RVA = "0x1E0D420", Offset = "0x1E0C820", Length = "0xC9")]
	[Token(Token = "0x600016B")]
	public virtual void OnClickButton(int iButtonID) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000174")]
	private void set_InputFilter(Func<String, String> value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000170")]
	private void set_InputString(string value) { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000172")]
	private void set_IsChange(bool value) { }

	[Address(RVA = "0x1E0D4F0", Offset = "0x1E0C8F0", Length = "0x1E")]
	[Token(Token = "0x600016C")]
	public void SetString(string s) { }

}

