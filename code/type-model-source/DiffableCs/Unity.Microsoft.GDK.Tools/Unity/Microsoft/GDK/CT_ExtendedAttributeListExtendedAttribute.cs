namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200001F")]
[XmlType(AnonymousType = True)]
public class CT_ExtendedAttributeListExtendedAttribute : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	private string nameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000086")]
	private string valueField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000087")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000019")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B664D0", Offset = "0x2B658D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000115")]
		 add { } //Length: 158
		[Address(RVA = "0x2B66570", Offset = "0x2B65970", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000116")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000058")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000111")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66610", Offset = "0x2B65A10", Length = "0x58")]
		[Token(Token = "0x6000112")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000059")]
	[XmlAttribute]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000113")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66670", Offset = "0x2B65A70", Length = "0x58")]
		[Token(Token = "0x6000114")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000118")]
	public CT_ExtendedAttributeListExtendedAttribute() { }

	[Address(RVA = "0x2B664D0", Offset = "0x2B658D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000115")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000111")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000113")]
	public string get_Value() { }

	[Address(RVA = "0x2B66440", Offset = "0x2B65840", Length = "0x86")]
	[Token(Token = "0x6000117")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B66570", Offset = "0x2B65970", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000116")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B66610", Offset = "0x2B65A10", Length = "0x58")]
	[Token(Token = "0x6000112")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2B66670", Offset = "0x2B65A70", Length = "0x58")]
	[Token(Token = "0x6000114")]
	public void set_Value(string value) { }

}

