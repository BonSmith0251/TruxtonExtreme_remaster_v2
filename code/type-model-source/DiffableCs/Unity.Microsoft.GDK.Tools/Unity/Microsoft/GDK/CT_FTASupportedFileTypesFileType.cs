namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200000F")]
[XmlType(AnonymousType = True)]
public class CT_FTASupportedFileTypesFileType : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004F")]
	private string contentTypeField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000050")]
	private string valueField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000051")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x1400000B")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B669F0", Offset = "0x2B65DF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600009D")]
		 add { } //Length: 158
		[Address(RVA = "0x2B66A90", Offset = "0x2B65E90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600009E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000038")]
	[XmlAttribute]
	public string ContentType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000099")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66B30", Offset = "0x2B65F30", Length = "0x58")]
		[Token(Token = "0x600009A")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000039")]
	[XmlText]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66B90", Offset = "0x2B65F90", Length = "0x58")]
		[Token(Token = "0x600009C")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000A0")]
	public CT_FTASupportedFileTypesFileType() { }

	[Address(RVA = "0x2B669F0", Offset = "0x2B65DF0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600009D")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000099")]
	public string get_ContentType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600009B")]
	public string get_Value() { }

	[Address(RVA = "0x2B66960", Offset = "0x2B65D60", Length = "0x86")]
	[Token(Token = "0x600009F")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B66A90", Offset = "0x2B65E90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600009E")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B66B30", Offset = "0x2B65F30", Length = "0x58")]
	[Token(Token = "0x600009A")]
	public void set_ContentType(string value) { }

	[Address(RVA = "0x2B66B90", Offset = "0x2B65F90", Length = "0x58")]
	[Token(Token = "0x600009C")]
	public void set_Value(string value) { }

}

