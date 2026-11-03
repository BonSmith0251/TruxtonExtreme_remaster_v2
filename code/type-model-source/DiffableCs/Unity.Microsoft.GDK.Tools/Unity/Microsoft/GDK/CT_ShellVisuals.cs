namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x200002A")]
public class CT_ShellVisuals : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C0")]
	private string defaultDisplayNameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C1")]
	private string publisherDisplayNameField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C2")]
	private string storeLogoField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C3")]
	private string square150x150LogoField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C4")]
	private string square44x44LogoField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C5")]
	private string square480x480LogoField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C6")]
	private string descriptionField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000C7")]
	private ST_ForegroundText foregroundTextField; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000C8")]
	private bool foregroundTextFieldSpecified; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000C9")]
	private string backgroundColorField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000CA")]
	private string splashScreenImageField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000CB")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60

	[Token(Token = "0x14000021")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B69300", Offset = "0x2B68700", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000199")]
		 add { } //Length: 158
		[Address(RVA = "0x2B693A0", Offset = "0x2B687A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600019A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700008A")]
	[XmlAttribute]
	public string BackgroundColor
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69440", Offset = "0x2B68840", Length = "0x58")]
		[Token(Token = "0x6000196")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000081")]
	[XmlAttribute]
	public string DefaultDisplayName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 5
		[Address(RVA = "0x2B694A0", Offset = "0x2B688A0", Length = "0x58")]
		[Token(Token = "0x6000184")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000087")]
	[XmlAttribute]
	public string Description
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600018F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69500", Offset = "0x2B68900", Length = "0x58")]
		[Token(Token = "0x6000190")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000088")]
	[XmlAttribute]
	public ST_ForegroundText ForegroundText
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 4
		[Address(RVA = "0x2B695B0", Offset = "0x2B689B0", Length = "0x4A")]
		[Token(Token = "0x6000192")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000089")]
	[XmlIgnore]
	public bool ForegroundTextSpecified
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69560", Offset = "0x2B68960", Length = "0x4C")]
		[Token(Token = "0x6000194")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000082")]
	[XmlAttribute]
	public string PublisherDisplayName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000185")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69600", Offset = "0x2B68A00", Length = "0x58")]
		[Token(Token = "0x6000186")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700008B")]
	[XmlAttribute]
	public string SplashScreenImage
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000197")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69660", Offset = "0x2B68A60", Length = "0x58")]
		[Token(Token = "0x6000198")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000084")]
	[XmlAttribute]
	public string Square150x150Logo
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000189")]
		 get { } //Length: 5
		[Address(RVA = "0x2B696C0", Offset = "0x2B68AC0", Length = "0x58")]
		[Token(Token = "0x600018A")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000085")]
	[XmlAttribute]
	public string Square44x44Logo
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600018B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69720", Offset = "0x2B68B20", Length = "0x58")]
		[Token(Token = "0x600018C")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000086")]
	[XmlAttribute]
	public string Square480x480Logo
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600018D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B69780", Offset = "0x2B68B80", Length = "0x58")]
		[Token(Token = "0x600018E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000083")]
	[XmlAttribute]
	public string StoreLogo
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000187")]
		 get { } //Length: 5
		[Address(RVA = "0x2B697E0", Offset = "0x2B68BE0", Length = "0x58")]
		[Token(Token = "0x6000188")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600019C")]
	public CT_ShellVisuals() { }

	[Address(RVA = "0x2B69300", Offset = "0x2B68700", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000199")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000195")]
	public string get_BackgroundColor() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000183")]
	public string get_DefaultDisplayName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600018F")]
	public string get_Description() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000191")]
	public ST_ForegroundText get_ForegroundText() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x6000193")]
	public bool get_ForegroundTextSpecified() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000185")]
	public string get_PublisherDisplayName() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000197")]
	public string get_SplashScreenImage() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000189")]
	public string get_Square150x150Logo() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600018B")]
	public string get_Square44x44Logo() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600018D")]
	public string get_Square480x480Logo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000187")]
	public string get_StoreLogo() { }

	[Address(RVA = "0x2B69270", Offset = "0x2B68670", Length = "0x86")]
	[Token(Token = "0x600019B")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B693A0", Offset = "0x2B687A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600019A")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B69440", Offset = "0x2B68840", Length = "0x58")]
	[Token(Token = "0x6000196")]
	public void set_BackgroundColor(string value) { }

	[Address(RVA = "0x2B694A0", Offset = "0x2B688A0", Length = "0x58")]
	[Token(Token = "0x6000184")]
	public void set_DefaultDisplayName(string value) { }

	[Address(RVA = "0x2B69500", Offset = "0x2B68900", Length = "0x58")]
	[Token(Token = "0x6000190")]
	public void set_Description(string value) { }

	[Address(RVA = "0x2B695B0", Offset = "0x2B689B0", Length = "0x4A")]
	[Token(Token = "0x6000192")]
	public void set_ForegroundText(ST_ForegroundText value) { }

	[Address(RVA = "0x2B69560", Offset = "0x2B68960", Length = "0x4C")]
	[Token(Token = "0x6000194")]
	public void set_ForegroundTextSpecified(bool value) { }

	[Address(RVA = "0x2B69600", Offset = "0x2B68A00", Length = "0x58")]
	[Token(Token = "0x6000186")]
	public void set_PublisherDisplayName(string value) { }

	[Address(RVA = "0x2B69660", Offset = "0x2B68A60", Length = "0x58")]
	[Token(Token = "0x6000198")]
	public void set_SplashScreenImage(string value) { }

	[Address(RVA = "0x2B696C0", Offset = "0x2B68AC0", Length = "0x58")]
	[Token(Token = "0x600018A")]
	public void set_Square150x150Logo(string value) { }

	[Address(RVA = "0x2B69720", Offset = "0x2B68B20", Length = "0x58")]
	[Token(Token = "0x600018C")]
	public void set_Square44x44Logo(string value) { }

	[Address(RVA = "0x2B69780", Offset = "0x2B68B80", Length = "0x58")]
	[Token(Token = "0x600018E")]
	public void set_Square480x480Logo(string value) { }

	[Address(RVA = "0x2B697E0", Offset = "0x2B68BE0", Length = "0x58")]
	[Token(Token = "0x6000188")]
	public void set_StoreLogo(string value) { }

}

