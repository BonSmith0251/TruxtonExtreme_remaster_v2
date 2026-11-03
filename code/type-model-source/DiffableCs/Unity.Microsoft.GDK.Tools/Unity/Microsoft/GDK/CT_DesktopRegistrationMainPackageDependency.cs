namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200001B")]
[XmlType(AnonymousType = True)]
public class CT_DesktopRegistrationMainPackageDependency : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007C")]
	private string nameField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007D")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000015")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B64C10", Offset = "0x2B64010", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000F9")]
		 add { } //Length: 158
		[Address(RVA = "0x2B64CB0", Offset = "0x2B640B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000FA")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000053")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64D50", Offset = "0x2B64150", Length = "0xB9")]
		[Token(Token = "0x60000F8")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000FC")]
	public CT_DesktopRegistrationMainPackageDependency() { }

	[Address(RVA = "0x2B64C10", Offset = "0x2B64010", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000F9")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000F7")]
	public string get_Name() { }

	[Address(RVA = "0x2B64B80", Offset = "0x2B63F80", Length = "0x86")]
	[Token(Token = "0x60000FB")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B64CB0", Offset = "0x2B640B0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000FA")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B64D50", Offset = "0x2B64150", Length = "0xB9")]
	[Token(Token = "0x60000F8")]
	public void set_Name(string value) { }

}

