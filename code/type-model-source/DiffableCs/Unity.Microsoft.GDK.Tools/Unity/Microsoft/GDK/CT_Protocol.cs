namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000006")]
public class CT_Protocol : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private string nameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000029")]
	private string executableField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002A")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000003")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B68350", Offset = "0x2B67750", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600004F")]
		 add { } //Length: 158
		[Address(RVA = "0x2B683F0", Offset = "0x2B677F0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000050")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000022")]
	[XmlAttribute]
	public string Executable
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B68490", Offset = "0x2B67890", Length = "0x58")]
		[Token(Token = "0x600004E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000021")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B684F0", Offset = "0x2B678F0", Length = "0x58")]
		[Token(Token = "0x600004C")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000052")]
	public CT_Protocol() { }

	[Address(RVA = "0x2B68350", Offset = "0x2B67750", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600004F")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600004D")]
	public string get_Executable() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600004B")]
	public string get_Name() { }

	[Address(RVA = "0x2B682C0", Offset = "0x2B676C0", Length = "0x86")]
	[Token(Token = "0x6000051")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B683F0", Offset = "0x2B677F0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000050")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B68490", Offset = "0x2B67890", Length = "0x58")]
	[Token(Token = "0x600004E")]
	public void set_Executable(string value) { }

	[Address(RVA = "0x2B684F0", Offset = "0x2B678F0", Length = "0x58")]
	[Token(Token = "0x600004C")]
	public void set_Name(string value) { }

}

