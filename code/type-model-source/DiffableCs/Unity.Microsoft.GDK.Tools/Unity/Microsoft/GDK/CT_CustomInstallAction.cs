namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000011")]
public class CT_CustomInstallAction : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000054")]
	private string fileField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000055")]
	private string nameField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000056")]
	private string argumentsField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000057")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	[Token(Token = "0x1400000D")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B63BA0", Offset = "0x2B62FA0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000AD")]
		 add { } //Length: 158
		[Address(RVA = "0x2B63C40", Offset = "0x2B63040", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000AE")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700003D")]
	[XmlAttribute]
	public string Arguments
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 5
		[Address(RVA = "0x2B63CE0", Offset = "0x2B630E0", Length = "0x58")]
		[Token(Token = "0x60000AC")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700003B")]
	[XmlAttribute]
	public string File
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 5
		[Address(RVA = "0x2B63D40", Offset = "0x2B63140", Length = "0x58")]
		[Token(Token = "0x60000A8")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700003C")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B63DA0", Offset = "0x2B631A0", Length = "0x58")]
		[Token(Token = "0x60000AA")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B0")]
	public CT_CustomInstallAction() { }

	[Address(RVA = "0x2B63BA0", Offset = "0x2B62FA0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000AD")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000AB")]
	public string get_Arguments() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000A7")]
	public string get_File() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000A9")]
	public string get_Name() { }

	[Address(RVA = "0x2B63B10", Offset = "0x2B62F10", Length = "0x86")]
	[Token(Token = "0x60000AF")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B63C40", Offset = "0x2B63040", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000AE")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B63CE0", Offset = "0x2B630E0", Length = "0x58")]
	[Token(Token = "0x60000AC")]
	public void set_Arguments(string value) { }

	[Address(RVA = "0x2B63D40", Offset = "0x2B63140", Length = "0x58")]
	[Token(Token = "0x60000A8")]
	public void set_File(string value) { }

	[Address(RVA = "0x2B63DA0", Offset = "0x2B631A0", Length = "0x58")]
	[Token(Token = "0x60000AA")]
	public void set_Name(string value) { }

}

