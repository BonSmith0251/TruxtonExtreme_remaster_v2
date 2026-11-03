namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000008")]
public class CT_SaveGameStorage : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002D")]
	private CT_SaveGameStorageNoCodePCRoot noCodePCRootField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002E")]
	private string sCIDField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002F")]
	private string maxUserQuotaField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000030")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	[Token(Token = "0x14000005")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B69010", Offset = "0x2B68410", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		 add { } //Length: 158
		[Address(RVA = "0x2B690B0", Offset = "0x2B684B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000060")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000026")]
	[XmlElement(DataType = "integer")]
	public string MaxUserQuota
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69150", Offset = "0x2B68550", Length = "0x58")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000024")]
	public CT_SaveGameStorageNoCodePCRoot NoCodePCRoot
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 5
		[Address(RVA = "0x2B691B0", Offset = "0x2B685B0", Length = "0x58")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000025")]
	public string SCID
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69210", Offset = "0x2B68610", Length = "0x58")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000062")]
	public CT_SaveGameStorage() { }

	[Address(RVA = "0x2B69010", Offset = "0x2B68410", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600005D")]
	public string get_MaxUserQuota() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000059")]
	public CT_SaveGameStorageNoCodePCRoot get_NoCodePCRoot() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600005B")]
	public string get_SCID() { }

	[Address(RVA = "0x2B68F80", Offset = "0x2B68380", Length = "0x86")]
	[Token(Token = "0x6000061")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B690B0", Offset = "0x2B684B0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000060")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B69150", Offset = "0x2B68550", Length = "0x58")]
	[Token(Token = "0x600005E")]
	public void set_MaxUserQuota(string value) { }

	[Address(RVA = "0x2B691B0", Offset = "0x2B685B0", Length = "0x58")]
	[Token(Token = "0x600005A")]
	public void set_NoCodePCRoot(CT_SaveGameStorageNoCodePCRoot value) { }

	[Address(RVA = "0x2B69210", Offset = "0x2B68610", Length = "0x58")]
	[Token(Token = "0x600005C")]
	public void set_SCID(string value) { }

}

