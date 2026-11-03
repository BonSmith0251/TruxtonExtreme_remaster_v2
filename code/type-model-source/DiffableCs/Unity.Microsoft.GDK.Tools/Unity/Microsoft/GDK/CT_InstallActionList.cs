namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000013")]
public class CT_InstallActionList : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005A")]
	private CT_CustomInstallAction[] installActionField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005B")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400000F")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B67750", Offset = "0x2B66B50", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000B9")]
		 add { } //Length: 158
		[Address(RVA = "0x2B677F0", Offset = "0x2B66BF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700003F")]
	[XmlElement("InstallAction")]
	public CT_CustomInstallAction[] InstallAction
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67890", Offset = "0x2B66C90", Length = "0xB9")]
		[Token(Token = "0x60000B8")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000BC")]
	public CT_InstallActionList() { }

	[Address(RVA = "0x2B67750", Offset = "0x2B66B50", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000B9")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000B7")]
	public CT_CustomInstallAction[] get_InstallAction() { }

	[Address(RVA = "0x2B676C0", Offset = "0x2B66AC0", Length = "0x86")]
	[Token(Token = "0x60000BB")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B677F0", Offset = "0x2B66BF0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000BA")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B67890", Offset = "0x2B66C90", Length = "0xB9")]
	[Token(Token = "0x60000B8")]
	public void set_InstallAction(CT_CustomInstallAction[] value) { }

}

