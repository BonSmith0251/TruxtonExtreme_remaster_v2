namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200000D")]
public class CT_FileTypeAssociation : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000042")]
	private string displayNameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000043")]
	private string logoField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000044")]
	private string infoTipField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000045")]
	private CT_FileTypeAssociationEditFlags editFlagsField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000046")]
	private CT_FTASupportedFileTypesFileType[] supportedFileTypesField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000047")]
	private string nameField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000048")]
	private string executableField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000049")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x48

	[Token(Token = "0x14000009")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B66F90", Offset = "0x2B66390", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000089")]
		 add { } //Length: 158
		[Address(RVA = "0x2B67030", Offset = "0x2B66430", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600008A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700002D")]
	public string DisplayName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B670D0", Offset = "0x2B664D0", Length = "0x58")]
		[Token(Token = "0x600007C")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000030")]
	public CT_FileTypeAssociationEditFlags EditFlags
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000081")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67130", Offset = "0x2B66530", Length = "0x58")]
		[Token(Token = "0x6000082")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000033")]
	[XmlAttribute]
	public string Executable
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67190", Offset = "0x2B66590", Length = "0x58")]
		[Token(Token = "0x6000088")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700002F")]
	public string InfoTip
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B671F0", Offset = "0x2B665F0", Length = "0x58")]
		[Token(Token = "0x6000080")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700002E")]
	public string Logo
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67250", Offset = "0x2B66650", Length = "0x58")]
		[Token(Token = "0x600007E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000032")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 5
		[Address(RVA = "0x2B672B0", Offset = "0x2B666B0", Length = "0x58")]
		[Token(Token = "0x6000086")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000031")]
	[XmlArrayItem("FileType", IsNullable = False)]
	public CT_FTASupportedFileTypesFileType[] SupportedFileTypes
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67310", Offset = "0x2B66710", Length = "0x58")]
		[Token(Token = "0x6000084")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600008C")]
	public CT_FileTypeAssociation() { }

	[Address(RVA = "0x2B66F90", Offset = "0x2B66390", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000089")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600007B")]
	public string get_DisplayName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000081")]
	public CT_FileTypeAssociationEditFlags get_EditFlags() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000087")]
	public string get_Executable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600007F")]
	public string get_InfoTip() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600007D")]
	public string get_Logo() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000085")]
	public string get_Name() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000083")]
	public CT_FTASupportedFileTypesFileType[] get_SupportedFileTypes() { }

	[Address(RVA = "0x2B66F00", Offset = "0x2B66300", Length = "0x86")]
	[Token(Token = "0x600008B")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B67030", Offset = "0x2B66430", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600008A")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B670D0", Offset = "0x2B664D0", Length = "0x58")]
	[Token(Token = "0x600007C")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0x2B67130", Offset = "0x2B66530", Length = "0x58")]
	[Token(Token = "0x6000082")]
	public void set_EditFlags(CT_FileTypeAssociationEditFlags value) { }

	[Address(RVA = "0x2B67190", Offset = "0x2B66590", Length = "0x58")]
	[Token(Token = "0x6000088")]
	public void set_Executable(string value) { }

	[Address(RVA = "0x2B671F0", Offset = "0x2B665F0", Length = "0x58")]
	[Token(Token = "0x6000080")]
	public void set_InfoTip(string value) { }

	[Address(RVA = "0x2B67250", Offset = "0x2B66650", Length = "0x58")]
	[Token(Token = "0x600007E")]
	public void set_Logo(string value) { }

	[Address(RVA = "0x2B672B0", Offset = "0x2B666B0", Length = "0x58")]
	[Token(Token = "0x6000086")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2B67310", Offset = "0x2B66710", Length = "0x58")]
	[Token(Token = "0x6000084")]
	public void set_SupportedFileTypes(CT_FTASupportedFileTypesFileType[] value) { }

}

