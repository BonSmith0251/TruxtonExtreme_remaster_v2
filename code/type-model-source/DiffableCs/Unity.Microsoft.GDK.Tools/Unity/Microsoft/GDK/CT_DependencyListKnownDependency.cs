namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000016")]
[XmlType(AnonymousType = True)]
public class CT_DependencyListKnownDependency : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000064")]
	private ST_KnownDependency nameField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000065")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000012")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B64700", Offset = "0x2B63B00", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000D3")]
		 add { } //Length: 158
		[Address(RVA = "0x2B647A0", Offset = "0x2B63BA0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000D4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000046")]
	[XmlAttribute]
	public ST_KnownDependency Name
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 85
		[Address(RVA = "0x2B64840", Offset = "0x2B63C40", Length = "0xAB")]
		[Token(Token = "0x60000D2")]
		 set { } //Length: 171
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000D6")]
	public CT_DependencyListKnownDependency() { }

	[Address(RVA = "0x2B64700", Offset = "0x2B63B00", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000D3")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60000D1")]
	public ST_KnownDependency get_Name() { }

	[Address(RVA = "0x2B64670", Offset = "0x2B63A70", Length = "0x86")]
	[Token(Token = "0x60000D5")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B647A0", Offset = "0x2B63BA0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000D4")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B64840", Offset = "0x2B63C40", Length = "0xAB")]
	[Token(Token = "0x60000D2")]
	public void set_Name(ST_KnownDependency value) { }

}

