namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200001C")]
[XmlType(AnonymousType = True)]
public class CT_DesktopRegistrationModFolder : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007E")]
	private string nameField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x14000016")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B64EA0", Offset = "0x2B642A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000FF")]
		 add { } //Length: 158
		[Address(RVA = "0x2B64F40", Offset = "0x2B64340", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000100")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000054")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 5
		[Address(RVA = "0x2B64FE0", Offset = "0x2B643E0", Length = "0xB9")]
		[Token(Token = "0x60000FE")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000102")]
	public CT_DesktopRegistrationModFolder() { }

	[Address(RVA = "0x2B64EA0", Offset = "0x2B642A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000FF")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000FD")]
	public string get_Name() { }

	[Address(RVA = "0x2B64E10", Offset = "0x2B64210", Length = "0x86")]
	[Token(Token = "0x6000101")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B64F40", Offset = "0x2B64340", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000100")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B64FE0", Offset = "0x2B643E0", Length = "0xB9")]
	[Token(Token = "0x60000FE")]
	public void set_Name(string value) { }

}

