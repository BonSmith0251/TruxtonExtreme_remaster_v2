namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200000E")]
[XmlType(AnonymousType = True)]
public class CT_FileTypeAssociationEditFlags : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	private bool openIsSafeField; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400004B")]
	private bool openIsSafeFieldSpecified; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x400004C")]
	private bool alwaysUnsafeField; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x400004D")]
	private bool alwaysUnsafeFieldSpecified; //Field offset: 0x13
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004E")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x18

	[Token(Token = "0x1400000A")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B66C80", Offset = "0x2B66080", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000095")]
		 add { } //Length: 158
		[Address(RVA = "0x2B66D20", Offset = "0x2B66120", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000096")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000036")]
	[XmlAttribute]
	public bool AlwaysUnsafe
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x6000091")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66E10", Offset = "0x2B66210", Length = "0x4C")]
		[Token(Token = "0x6000092")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000037")]
	[XmlIgnore]
	public bool AlwaysUnsafeSpecified
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66DC0", Offset = "0x2B661C0", Length = "0x4C")]
		[Token(Token = "0x6000094")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000034")]
	[XmlAttribute]
	public bool OpenIsSafe
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66EB0", Offset = "0x2B662B0", Length = "0x4C")]
		[Token(Token = "0x600008E")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000035")]
	[XmlIgnore]
	public bool OpenIsSafeSpecified
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66E60", Offset = "0x2B66260", Length = "0x4C")]
		[Token(Token = "0x6000090")]
		 set { } //Length: 76
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000098")]
	public CT_FileTypeAssociationEditFlags() { }

	[Address(RVA = "0x2B66C80", Offset = "0x2B66080", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000095")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x6000091")]
	public bool get_AlwaysUnsafe() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x6000093")]
	public bool get_AlwaysUnsafeSpecified() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x600008D")]
	public bool get_OpenIsSafe() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x600008F")]
	public bool get_OpenIsSafeSpecified() { }

	[Address(RVA = "0x2B66BF0", Offset = "0x2B65FF0", Length = "0x86")]
	[Token(Token = "0x6000097")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B66D20", Offset = "0x2B66120", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000096")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B66E10", Offset = "0x2B66210", Length = "0x4C")]
	[Token(Token = "0x6000092")]
	public void set_AlwaysUnsafe(bool value) { }

	[Address(RVA = "0x2B66DC0", Offset = "0x2B661C0", Length = "0x4C")]
	[Token(Token = "0x6000094")]
	public void set_AlwaysUnsafeSpecified(bool value) { }

	[Address(RVA = "0x2B66EB0", Offset = "0x2B662B0", Length = "0x4C")]
	[Token(Token = "0x600008E")]
	public void set_OpenIsSafe(bool value) { }

	[Address(RVA = "0x2B66E60", Offset = "0x2B66260", Length = "0x4C")]
	[Token(Token = "0x6000090")]
	public void set_OpenIsSafeSpecified(bool value) { }

}

