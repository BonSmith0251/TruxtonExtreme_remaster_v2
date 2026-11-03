namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000020")]
public class CT_VirtualMachine : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000088")]
	private ST_MemoryConfig xboxOneXTitleMemoryField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000089")]
	private bool xboxOneXTitleMemoryFieldSpecified; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008A")]
	private ST_MemoryConfig xboxAnacondaTitleMemoryField; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400008B")]
	private bool xboxAnacondaTitleMemoryFieldSpecified; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x400008C")]
	private bool sMTEnabledField; //Field offset: 0x1D
	[FieldOffset(Offset = "0x1E")]
	[Token(Token = "0x400008D")]
	private bool sMTEnabledFieldSpecified; //Field offset: 0x1E
	[FieldOffset(Offset = "0x1F")]
	[Token(Token = "0x400008E")]
	private bool requiresEraShimField; //Field offset: 0x1F
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008F")]
	private bool requiresEraShimFieldSpecified; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000090")]
	private ST_ConsoleGeneration xboxCompatibilityField; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000091")]
	private bool xboxCompatibilityFieldSpecified; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000092")]
	private ST_ConsoleGeneration dlcCompatibilityField; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000093")]
	private bool dlcCompatibilityFieldSpecified; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000094")]
	private ST_MemoryConfig xboxLockhartTitleMemoryField; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000095")]
	private bool xboxLockhartTitleMemoryFieldSpecified; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000096")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x40

	[Token(Token = "0x1400001A")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B69B60", Offset = "0x2B68F60", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000135")]
		 add { } //Length: 158
		[Address(RVA = "0x2B69C20", Offset = "0x2B69020", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000136")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000064")]
	public ST_ConsoleGeneration DlcCompatibility
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x600012D")]
		 get { } //Length: 4
		[Address(RVA = "0x2B69D10", Offset = "0x2B69110", Length = "0x4A")]
		[Token(Token = "0x600012E")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000065")]
	[XmlIgnore]
	public bool DlcCompatibilitySpecified
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x600012F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69CC0", Offset = "0x2B690C0", Length = "0x4C")]
		[Token(Token = "0x6000130")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000060")]
	public bool RequiresEraShim
	{
		[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69DB0", Offset = "0x2B691B0", Length = "0x4C")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000061")]
	[XmlIgnore]
	public bool RequiresEraShimSpecified
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69D60", Offset = "0x2B69160", Length = "0x4C")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700005E")]
	public bool SMTEnabled
	{
		[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
		[Token(Token = "0x6000121")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69E50", Offset = "0x2B69250", Length = "0x4C")]
		[Token(Token = "0x6000122")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700005F")]
	[XmlIgnore]
	public bool SMTEnabledSpecified
	{
		[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69E00", Offset = "0x2B69200", Length = "0x4C")]
		[Token(Token = "0x6000124")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700005C")]
	public ST_MemoryConfig XboxAnacondaTitleMemory
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600011D")]
		 get { } //Length: 4
		[Address(RVA = "0x2B69EF0", Offset = "0x2B692F0", Length = "0x4A")]
		[Token(Token = "0x600011E")]
		 set { } //Length: 74
	}

	[Token(Token = "0x1700005D")]
	[XmlIgnore]
	public bool XboxAnacondaTitleMemorySpecified
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x600011F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69EA0", Offset = "0x2B692A0", Length = "0x4C")]
		[Token(Token = "0x6000120")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000062")]
	public ST_ConsoleGeneration XboxCompatibility
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 4
		[Address(RVA = "0x2B69F90", Offset = "0x2B69390", Length = "0x4A")]
		[Token(Token = "0x600012A")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000063")]
	[XmlIgnore]
	public bool XboxCompatibilitySpecified
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600012B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69F40", Offset = "0x2B69340", Length = "0x4C")]
		[Token(Token = "0x600012C")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000066")]
	public ST_MemoryConfig XboxLockhartTitleMemory
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000131")]
		 get { } //Length: 4
		[Address(RVA = "0x2B6A030", Offset = "0x2B69430", Length = "0x4A")]
		[Token(Token = "0x6000132")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000067")]
	[XmlIgnore]
	public bool XboxLockhartTitleMemorySpecified
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000133")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69FE0", Offset = "0x2B693E0", Length = "0x4C")]
		[Token(Token = "0x6000134")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700005A")]
	public ST_MemoryConfig XboxOneXTitleMemory
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000119")]
		 get { } //Length: 85
		[Address(RVA = "0x2B6A0D0", Offset = "0x2B694D0", Length = "0x4A")]
		[Token(Token = "0x600011A")]
		 set { } //Length: 74
	}

	[Token(Token = "0x1700005B")]
	[XmlIgnore]
	public bool XboxOneXTitleMemorySpecified
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x600011B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6A080", Offset = "0x2B69480", Length = "0x4C")]
		[Token(Token = "0x600011C")]
		 set { } //Length: 76
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000138")]
	public CT_VirtualMachine() { }

	[Address(RVA = "0x2B69B60", Offset = "0x2B68F60", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000135")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x600012D")]
	public ST_ConsoleGeneration get_DlcCompatibility() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x600012F")]
	public bool get_DlcCompatibilitySpecified() { }

	[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
	[Token(Token = "0x6000125")]
	public bool get_RequiresEraShim() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000127")]
	public bool get_RequiresEraShimSpecified() { }

	[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
	[Token(Token = "0x6000121")]
	public bool get_SMTEnabled() { }

	[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
	[Token(Token = "0x6000123")]
	public bool get_SMTEnabledSpecified() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600011D")]
	public ST_MemoryConfig get_XboxAnacondaTitleMemory() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x600011F")]
	public bool get_XboxAnacondaTitleMemorySpecified() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000129")]
	public ST_ConsoleGeneration get_XboxCompatibility() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600012B")]
	public bool get_XboxCompatibilitySpecified() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000131")]
	public ST_MemoryConfig get_XboxLockhartTitleMemory() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000133")]
	public bool get_XboxLockhartTitleMemorySpecified() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000119")]
	public ST_MemoryConfig get_XboxOneXTitleMemory() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x600011B")]
	public bool get_XboxOneXTitleMemorySpecified() { }

	[Address(RVA = "0x2B69AD0", Offset = "0x2B68ED0", Length = "0x86")]
	[Token(Token = "0x6000137")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B69C20", Offset = "0x2B69020", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000136")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B69D10", Offset = "0x2B69110", Length = "0x4A")]
	[Token(Token = "0x600012E")]
	public void set_DlcCompatibility(ST_ConsoleGeneration value) { }

	[Address(RVA = "0x2B69CC0", Offset = "0x2B690C0", Length = "0x4C")]
	[Token(Token = "0x6000130")]
	public void set_DlcCompatibilitySpecified(bool value) { }

	[Address(RVA = "0x2B69DB0", Offset = "0x2B691B0", Length = "0x4C")]
	[Token(Token = "0x6000126")]
	public void set_RequiresEraShim(bool value) { }

	[Address(RVA = "0x2B69D60", Offset = "0x2B69160", Length = "0x4C")]
	[Token(Token = "0x6000128")]
	public void set_RequiresEraShimSpecified(bool value) { }

	[Address(RVA = "0x2B69E50", Offset = "0x2B69250", Length = "0x4C")]
	[Token(Token = "0x6000122")]
	public void set_SMTEnabled(bool value) { }

	[Address(RVA = "0x2B69E00", Offset = "0x2B69200", Length = "0x4C")]
	[Token(Token = "0x6000124")]
	public void set_SMTEnabledSpecified(bool value) { }

	[Address(RVA = "0x2B69EF0", Offset = "0x2B692F0", Length = "0x4A")]
	[Token(Token = "0x600011E")]
	public void set_XboxAnacondaTitleMemory(ST_MemoryConfig value) { }

	[Address(RVA = "0x2B69EA0", Offset = "0x2B692A0", Length = "0x4C")]
	[Token(Token = "0x6000120")]
	public void set_XboxAnacondaTitleMemorySpecified(bool value) { }

	[Address(RVA = "0x2B69F90", Offset = "0x2B69390", Length = "0x4A")]
	[Token(Token = "0x600012A")]
	public void set_XboxCompatibility(ST_ConsoleGeneration value) { }

	[Address(RVA = "0x2B69F40", Offset = "0x2B69340", Length = "0x4C")]
	[Token(Token = "0x600012C")]
	public void set_XboxCompatibilitySpecified(bool value) { }

	[Address(RVA = "0x2B6A030", Offset = "0x2B69430", Length = "0x4A")]
	[Token(Token = "0x6000132")]
	public void set_XboxLockhartTitleMemory(ST_MemoryConfig value) { }

	[Address(RVA = "0x2B69FE0", Offset = "0x2B693E0", Length = "0x4C")]
	[Token(Token = "0x6000134")]
	public void set_XboxLockhartTitleMemorySpecified(bool value) { }

	[Address(RVA = "0x2B6A0D0", Offset = "0x2B694D0", Length = "0x4A")]
	[Token(Token = "0x600011A")]
	public void set_XboxOneXTitleMemory(ST_MemoryConfig value) { }

	[Address(RVA = "0x2B6A080", Offset = "0x2B69480", Length = "0x4C")]
	[Token(Token = "0x600011C")]
	public void set_XboxOneXTitleMemorySpecified(bool value) { }

}

