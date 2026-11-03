namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200000B")]
public class CT_DebugNetworkPortList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003C")]
	private String[] debugNetworkPortField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400003D")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000007")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B641E0", Offset = "0x2B635E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600006D")]
		 add { } //Length: 158
		[Address(RVA = "0x2B64280", Offset = "0x2B63680", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600006E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000029")]
	[XmlElement("DebugNetworkPort")]
	public String[] DebugNetworkPort
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64320", Offset = "0x2B63720", Length = "0xB9")]
		[Token(Token = "0x600006C")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000070")]
	public CT_DebugNetworkPortList() { }

	[Address(RVA = "0x2B641E0", Offset = "0x2B635E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600006D")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600006B")]
	public String[] get_DebugNetworkPort() { }

	[Address(RVA = "0x2B64150", Offset = "0x2B63550", Length = "0x86")]
	[Token(Token = "0x600006F")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B64280", Offset = "0x2B63680", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600006E")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B64320", Offset = "0x2B63720", Length = "0xB9")]
	[Token(Token = "0x600006C")]
	public void set_DebugNetworkPort(String[] value) { }

}

