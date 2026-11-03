namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000010")]
public class CT_UninstallActionList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000052")]
	private CT_CustomInstallAction[] uninstallActionField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000053")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400000C")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B698D0", Offset = "0x2B68CD0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000A3")]
		 add { } //Length: 158
		[Address(RVA = "0x2B69970", Offset = "0x2B68D70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000A4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700003A")]
	[XmlElement("UninstallAction")]
	public CT_CustomInstallAction[] UninstallAction
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69A10", Offset = "0x2B68E10", Length = "0xB9")]
		[Token(Token = "0x60000A2")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000A6")]
	public CT_UninstallActionList() { }

	[Address(RVA = "0x2B698D0", Offset = "0x2B68CD0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000A3")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000A1")]
	public CT_CustomInstallAction[] get_UninstallAction() { }

	[Address(RVA = "0x2B69840", Offset = "0x2B68C40", Length = "0x86")]
	[Token(Token = "0x60000A5")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B69970", Offset = "0x2B68D70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000A4")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B69A10", Offset = "0x2B68E10", Length = "0xB9")]
	[Token(Token = "0x60000A2")]
	public void set_UninstallAction(CT_CustomInstallAction[] value) { }

}

