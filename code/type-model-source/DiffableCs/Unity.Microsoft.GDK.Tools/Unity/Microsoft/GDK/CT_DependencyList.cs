namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000015")]
public class CT_DependencyList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000061")]
	private CT_DependencyListKnownDependency[] knownDependencyField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000062")]
	private CT_DependencyListDependency[] dependencyField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000063")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000011")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B64980", Offset = "0x2B63D80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000CD")]
		 add { } //Length: 158
		[Address(RVA = "0x2B64A20", Offset = "0x2B63E20", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000CE")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000045")]
	[XmlElement("Dependency")]
	public CT_DependencyListDependency[] Dependency
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64AC0", Offset = "0x2B63EC0", Length = "0x58")]
		[Token(Token = "0x60000CC")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000044")]
	[XmlElement("KnownDependency")]
	public CT_DependencyListKnownDependency[] KnownDependency
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64B20", Offset = "0x2B63F20", Length = "0x58")]
		[Token(Token = "0x60000CA")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000D0")]
	public CT_DependencyList() { }

	[Address(RVA = "0x2B64980", Offset = "0x2B63D80", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000CD")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000CB")]
	public CT_DependencyListDependency[] get_Dependency() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000C9")]
	public CT_DependencyListKnownDependency[] get_KnownDependency() { }

	[Address(RVA = "0x2B648F0", Offset = "0x2B63CF0", Length = "0x86")]
	[Token(Token = "0x60000CF")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B64A20", Offset = "0x2B63E20", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B64AC0", Offset = "0x2B63EC0", Length = "0x58")]
	[Token(Token = "0x60000CC")]
	public void set_Dependency(CT_DependencyListDependency[] value) { }

	[Address(RVA = "0x2B64B20", Offset = "0x2B63F20", Length = "0x58")]
	[Token(Token = "0x60000CA")]
	public void set_KnownDependency(CT_DependencyListKnownDependency[] value) { }

}

