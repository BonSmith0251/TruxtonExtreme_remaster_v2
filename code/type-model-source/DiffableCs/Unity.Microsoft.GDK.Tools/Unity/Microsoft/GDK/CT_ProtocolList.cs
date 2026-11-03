namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000007")]
public class CT_ProtocolList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002B")]
	private CT_Protocol[] protocolField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002C")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000004")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B680C0", Offset = "0x2B674C0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000055")]
		 add { } //Length: 158
		[Address(RVA = "0x2B68160", Offset = "0x2B67560", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000056")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000023")]
	[XmlElement("Protocol")]
	public CT_Protocol[] Protocol
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 5
		[Address(RVA = "0x2B68200", Offset = "0x2B67600", Length = "0xB9")]
		[Token(Token = "0x6000054")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000058")]
	public CT_ProtocolList() { }

	[Address(RVA = "0x2B680C0", Offset = "0x2B674C0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000055")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000053")]
	public CT_Protocol[] get_Protocol() { }

	[Address(RVA = "0x2B68030", Offset = "0x2B67430", Length = "0x86")]
	[Token(Token = "0x6000057")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B68160", Offset = "0x2B67560", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000056")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B68200", Offset = "0x2B67600", Length = "0xB9")]
	[Token(Token = "0x6000054")]
	public void set_Protocol(CT_Protocol[] value) { }

}

