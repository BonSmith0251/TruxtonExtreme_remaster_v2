namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000005")]
public class CT_Identity : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000023")]
	private string nameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000024")]
	private string publisherField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000025")]
	private string resourceIdField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000026")]
	private string versionField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000027")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x30

	[Token(Token = "0x14000002")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B67400", Offset = "0x2B66800", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000047")]
		 add { } //Length: 158
		[Address(RVA = "0x2B674A0", Offset = "0x2B668A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000048")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700001D")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67540", Offset = "0x2B66940", Length = "0x58")]
		[Token(Token = "0x6000040")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700001E")]
	[XmlAttribute]
	public string Publisher
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 5
		[Address(RVA = "0x2B675A0", Offset = "0x2B669A0", Length = "0x58")]
		[Token(Token = "0x6000042")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700001F")]
	[XmlAttribute]
	public string ResourceId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67600", Offset = "0x2B66A00", Length = "0x58")]
		[Token(Token = "0x6000044")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000020")]
	[XmlAttribute]
	public string Version
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67660", Offset = "0x2B66A60", Length = "0x58")]
		[Token(Token = "0x6000046")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600004A")]
	public CT_Identity() { }

	[Address(RVA = "0x2B67400", Offset = "0x2B66800", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000047")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600003F")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000041")]
	public string get_Publisher() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000043")]
	public string get_ResourceId() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000045")]
	public string get_Version() { }

	[Address(RVA = "0x2B67370", Offset = "0x2B66770", Length = "0x86")]
	[Token(Token = "0x6000049")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B674A0", Offset = "0x2B668A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000048")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B67540", Offset = "0x2B66940", Length = "0x58")]
	[Token(Token = "0x6000040")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2B675A0", Offset = "0x2B669A0", Length = "0x58")]
	[Token(Token = "0x6000042")]
	public void set_Publisher(string value) { }

	[Address(RVA = "0x2B67600", Offset = "0x2B66A00", Length = "0x58")]
	[Token(Token = "0x6000044")]
	public void set_ResourceId(string value) { }

	[Address(RVA = "0x2B67660", Offset = "0x2B66A60", Length = "0x58")]
	[Token(Token = "0x6000046")]
	public void set_Version(string value) { }

}

