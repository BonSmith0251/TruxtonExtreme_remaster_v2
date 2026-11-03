namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000024")]
public class CT_RelatedProductsList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A2")]
	private String[] relatedProductField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A3")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400001C")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B685E0", Offset = "0x2B679E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000147")]
		 add { } //Length: 158
		[Address(RVA = "0x2B68680", Offset = "0x2B67A80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000148")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700006C")]
	[XmlElement("RelatedProduct")]
	public String[] RelatedProduct
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000145")]
		 get { } //Length: 5
		[Address(RVA = "0x2B68720", Offset = "0x2B67B20", Length = "0xB9")]
		[Token(Token = "0x6000146")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600014A")]
	public CT_RelatedProductsList() { }

	[Address(RVA = "0x2B685E0", Offset = "0x2B679E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000147")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000145")]
	public String[] get_RelatedProduct() { }

	[Address(RVA = "0x2B68550", Offset = "0x2B67950", Length = "0x86")]
	[Token(Token = "0x6000149")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B68680", Offset = "0x2B67A80", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000148")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B68720", Offset = "0x2B67B20", Length = "0xB9")]
	[Token(Token = "0x6000146")]
	public void set_RelatedProduct(String[] value) { }

}

