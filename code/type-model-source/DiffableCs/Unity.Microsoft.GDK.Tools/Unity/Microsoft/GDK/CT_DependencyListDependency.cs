namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000018")]
[XmlType(AnonymousType = True)]
public class CT_DependencyListDependency : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006B")]
	private string nameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006C")]
	private string minVersionField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006D")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000013")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B64470", Offset = "0x2B63870", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000DB")]
		 add { } //Length: 158
		[Address(RVA = "0x2B64510", Offset = "0x2B63910", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000048")]
	[XmlAttribute]
	public string MinVersion
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000D9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B645B0", Offset = "0x2B639B0", Length = "0x58")]
		[Token(Token = "0x60000DA")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000047")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64610", Offset = "0x2B63A10", Length = "0x58")]
		[Token(Token = "0x60000D8")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000DE")]
	public CT_DependencyListDependency() { }

	[Address(RVA = "0x2B64470", Offset = "0x2B63870", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000DB")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000D9")]
	public string get_MinVersion() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000D7")]
	public string get_Name() { }

	[Address(RVA = "0x2B643E0", Offset = "0x2B637E0", Length = "0x86")]
	[Token(Token = "0x60000DD")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B64510", Offset = "0x2B63910", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B645B0", Offset = "0x2B639B0", Length = "0x58")]
	[Token(Token = "0x60000DA")]
	public void set_MinVersion(string value) { }

	[Address(RVA = "0x2B64610", Offset = "0x2B63A10", Length = "0x58")]
	[Token(Token = "0x60000D8")]
	public void set_Name(string value) { }

}

