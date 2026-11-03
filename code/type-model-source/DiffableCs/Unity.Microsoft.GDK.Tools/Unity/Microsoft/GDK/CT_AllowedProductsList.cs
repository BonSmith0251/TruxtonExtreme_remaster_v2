namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000025")]
public class CT_AllowedProductsList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A4")]
	private String[] allowedProductField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A5")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400001D")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B63910", Offset = "0x2B62D10", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600014D")]
		 add { } //Length: 158
		[Address(RVA = "0x2B639B0", Offset = "0x2B62DB0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600014E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700006D")]
	[XmlElement("AllowedProduct")]
	public String[] AllowedProduct
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B63A50", Offset = "0x2B62E50", Length = "0xB9")]
		[Token(Token = "0x600014C")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000150")]
	public CT_AllowedProductsList() { }

	[Address(RVA = "0x2B63910", Offset = "0x2B62D10", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600014D")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600014B")]
	public String[] get_AllowedProduct() { }

	[Address(RVA = "0x2B63880", Offset = "0x2B62C80", Length = "0x86")]
	[Token(Token = "0x600014F")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B639B0", Offset = "0x2B62DB0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600014E")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B63A50", Offset = "0x2B62E50", Length = "0xB9")]
	[Token(Token = "0x600014C")]
	public void set_AllowedProduct(String[] value) { }

}

