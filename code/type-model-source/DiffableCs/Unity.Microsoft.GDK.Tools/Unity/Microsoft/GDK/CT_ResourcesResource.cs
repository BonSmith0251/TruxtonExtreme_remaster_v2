namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200002C")]
[XmlType(AnonymousType = True)]
public class CT_ResourcesResource : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CF")]
	private string languageField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D0")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000022")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B68B00", Offset = "0x2B67F00", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600019F")]
		 add { } //Length: 158
		[Address(RVA = "0x2B68BA0", Offset = "0x2B67FA0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60001A0")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700008C")]
	[XmlAttribute(DataType = "language")]
	public string Language
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600019D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B68C40", Offset = "0x2B68040", Length = "0xB9")]
		[Token(Token = "0x600019E")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001A2")]
	public CT_ResourcesResource() { }

	[Address(RVA = "0x2B68B00", Offset = "0x2B67F00", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600019F")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600019D")]
	public string get_Language() { }

	[Address(RVA = "0x2B68A70", Offset = "0x2B67E70", Length = "0x86")]
	[Token(Token = "0x60001A1")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B68BA0", Offset = "0x2B67FA0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60001A0")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B68C40", Offset = "0x2B68040", Length = "0xB9")]
	[Token(Token = "0x600019E")]
	public void set_Language(string value) { }

}

