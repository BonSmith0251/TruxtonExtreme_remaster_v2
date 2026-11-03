namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000023")]
public class CT_PersistentLocalStorage : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009D")]
	private string sizeMBField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009E")]
	private string growableToMBField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009F")]
	private bool shareableField; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000A0")]
	private bool shareableFieldSpecified; //Field offset: 0x21
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A1")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	[Token(Token = "0x1400001B")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B67D90", Offset = "0x2B67190", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000141")]
		 add { } //Length: 158
		[Address(RVA = "0x2B67E30", Offset = "0x2B67230", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000142")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000069")]
	[XmlElement(DataType = "integer")]
	public string GrowableToMB
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67ED0", Offset = "0x2B672D0", Length = "0x58")]
		[Token(Token = "0x600013C")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700006A")]
	public bool Shareable
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67F80", Offset = "0x2B67380", Length = "0x4C")]
		[Token(Token = "0x600013E")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700006B")]
	[XmlIgnore]
	public bool ShareableSpecified
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67F30", Offset = "0x2B67330", Length = "0x4C")]
		[Token(Token = "0x6000140")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000068")]
	[XmlElement(DataType = "integer")]
	public string SizeMB
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000139")]
		 get { } //Length: 5
		[Address(RVA = "0x2B67FD0", Offset = "0x2B673D0", Length = "0x58")]
		[Token(Token = "0x600013A")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000144")]
	public CT_PersistentLocalStorage() { }

	[Address(RVA = "0x2B67D90", Offset = "0x2B67190", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000141")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600013B")]
	public string get_GrowableToMB() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600013D")]
	public bool get_Shareable() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x600013F")]
	public bool get_ShareableSpecified() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000139")]
	public string get_SizeMB() { }

	[Address(RVA = "0x2B67D00", Offset = "0x2B67100", Length = "0x86")]
	[Token(Token = "0x6000143")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B67E30", Offset = "0x2B67230", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000142")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B67ED0", Offset = "0x2B672D0", Length = "0x58")]
	[Token(Token = "0x600013C")]
	public void set_GrowableToMB(string value) { }

	[Address(RVA = "0x2B67F80", Offset = "0x2B67380", Length = "0x4C")]
	[Token(Token = "0x600013E")]
	public void set_Shareable(bool value) { }

	[Address(RVA = "0x2B67F30", Offset = "0x2B67330", Length = "0x4C")]
	[Token(Token = "0x6000140")]
	public void set_ShareableSpecified(bool value) { }

	[Address(RVA = "0x2B67FD0", Offset = "0x2B673D0", Length = "0x58")]
	[Token(Token = "0x600013A")]
	public void set_SizeMB(string value) { }

}

