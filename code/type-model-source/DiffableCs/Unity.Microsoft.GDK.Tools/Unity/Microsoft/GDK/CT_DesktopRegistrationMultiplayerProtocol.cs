namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200001D")]
[XmlType(AnonymousType = True)]
public class CT_DesktopRegistrationMultiplayerProtocol : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000080")]
	private string executableField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000081")]
	private bool valueField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000082")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x20

	[Token(Token = "0x14000017")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B65130", Offset = "0x2B64530", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000107")]
		 add { } //Length: 158
		[Address(RVA = "0x2B651D0", Offset = "0x2B645D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000108")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000055")]
	[XmlAttribute]
	public string Executable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000103")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65270", Offset = "0x2B64670", Length = "0x58")]
		[Token(Token = "0x6000104")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000056")]
	[XmlText]
	public bool Value
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000105")]
		 get { } //Length: 5
		[Address(RVA = "0x2B652D0", Offset = "0x2B646D0", Length = "0x4C")]
		[Token(Token = "0x6000106")]
		 set { } //Length: 76
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600010A")]
	public CT_DesktopRegistrationMultiplayerProtocol() { }

	[Address(RVA = "0x2B65130", Offset = "0x2B64530", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000107")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000103")]
	public string get_Executable() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000105")]
	public bool get_Value() { }

	[Address(RVA = "0x2B650A0", Offset = "0x2B644A0", Length = "0x86")]
	[Token(Token = "0x6000109")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B651D0", Offset = "0x2B645D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000108")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B65270", Offset = "0x2B64670", Length = "0x58")]
	[Token(Token = "0x6000104")]
	public void set_Executable(string value) { }

	[Address(RVA = "0x2B652D0", Offset = "0x2B646D0", Length = "0x4C")]
	[Token(Token = "0x6000106")]
	public void set_Value(bool value) { }

}

