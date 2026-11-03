namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000028")]
[XmlType(AnonymousType = True)]
public class CT_ExecutableListExecutable : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AF")]
	private string nameField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B0")]
	private ST_DeviceFamily targetDeviceFamilyField; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000B1")]
	private bool targetDeviceFamilyFieldSpecified; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B2")]
	private string idField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B3")]
	private bool isDevOnlyField; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40000B4")]
	private bool isDevOnlyFieldSpecified; //Field offset: 0x29
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B5")]
	private string overrideDisplayNameField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000B6")]
	private string overrideLogoField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000B7")]
	private string overrideSquare480x480LogoField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000B8")]
	private string overrideSquare44x44LogoField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B9")]
	private string overrideSplashScreenImageField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000BA")]
	private string aliasField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BB")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60

	[Token(Token = "0x14000020")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B65C30", Offset = "0x2B65030", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600017F")]
		 add { } //Length: 158
		[Address(RVA = "0x2B65CD0", Offset = "0x2B650D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000180")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000080")]
	[XmlAttribute]
	public string Alias
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600017D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65D70", Offset = "0x2B65170", Length = "0x58")]
		[Token(Token = "0x600017E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000078")]
	[XmlAttribute]
	public string Id
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600016D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65DD0", Offset = "0x2B651D0", Length = "0x58")]
		[Token(Token = "0x600016E")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000079")]
	[XmlAttribute]
	public bool IsDevOnly
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600016F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65E80", Offset = "0x2B65280", Length = "0x4C")]
		[Token(Token = "0x6000170")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700007A")]
	[XmlIgnore]
	public bool IsDevOnlySpecified
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000171")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65E30", Offset = "0x2B65230", Length = "0x4C")]
		[Token(Token = "0x6000172")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000075")]
	[XmlAttribute]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000167")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65ED0", Offset = "0x2B652D0", Length = "0x58")]
		[Token(Token = "0x6000168")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700007B")]
	[XmlAttribute]
	public string OverrideDisplayName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65F30", Offset = "0x2B65330", Length = "0x58")]
		[Token(Token = "0x6000174")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700007C")]
	[XmlAttribute]
	public string OverrideLogo
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65F90", Offset = "0x2B65390", Length = "0x58")]
		[Token(Token = "0x6000176")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700007F")]
	[XmlAttribute]
	public string OverrideSplashScreenImage
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600017B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65FF0", Offset = "0x2B653F0", Length = "0x58")]
		[Token(Token = "0x600017C")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700007E")]
	[XmlAttribute]
	public string OverrideSquare44x44Logo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000179")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66050", Offset = "0x2B65450", Length = "0x58")]
		[Token(Token = "0x600017A")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700007D")]
	[XmlAttribute]
	public string OverrideSquare480x480Logo
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 5
		[Address(RVA = "0x2B660B0", Offset = "0x2B654B0", Length = "0x58")]
		[Token(Token = "0x6000178")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000076")]
	[XmlAttribute]
	public ST_DeviceFamily TargetDeviceFamily
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000169")]
		 get { } //Length: 4
		[Address(RVA = "0x2B66160", Offset = "0x2B65560", Length = "0x4A")]
		[Token(Token = "0x600016A")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000077")]
	[XmlIgnore]
	public bool TargetDeviceFamilySpecified
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x600016B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B66110", Offset = "0x2B65510", Length = "0x4C")]
		[Token(Token = "0x600016C")]
		 set { } //Length: 76
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000182")]
	public CT_ExecutableListExecutable() { }

	[Address(RVA = "0x2B65C30", Offset = "0x2B65030", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600017F")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600017D")]
	public string get_Alias() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600016D")]
	public string get_Id() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600016F")]
	public bool get_IsDevOnly() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x6000171")]
	public bool get_IsDevOnlySpecified() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000167")]
	public string get_Name() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000173")]
	public string get_OverrideDisplayName() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000175")]
	public string get_OverrideLogo() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600017B")]
	public string get_OverrideSplashScreenImage() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000179")]
	public string get_OverrideSquare44x44Logo() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000177")]
	public string get_OverrideSquare480x480Logo() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000169")]
	public ST_DeviceFamily get_TargetDeviceFamily() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x600016B")]
	public bool get_TargetDeviceFamilySpecified() { }

	[Address(RVA = "0x2B65BA0", Offset = "0x2B64FA0", Length = "0x86")]
	[Token(Token = "0x6000181")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B65CD0", Offset = "0x2B650D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000180")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B65D70", Offset = "0x2B65170", Length = "0x58")]
	[Token(Token = "0x600017E")]
	public void set_Alias(string value) { }

	[Address(RVA = "0x2B65DD0", Offset = "0x2B651D0", Length = "0x58")]
	[Token(Token = "0x600016E")]
	public void set_Id(string value) { }

	[Address(RVA = "0x2B65E80", Offset = "0x2B65280", Length = "0x4C")]
	[Token(Token = "0x6000170")]
	public void set_IsDevOnly(bool value) { }

	[Address(RVA = "0x2B65E30", Offset = "0x2B65230", Length = "0x4C")]
	[Token(Token = "0x6000172")]
	public void set_IsDevOnlySpecified(bool value) { }

	[Address(RVA = "0x2B65ED0", Offset = "0x2B652D0", Length = "0x58")]
	[Token(Token = "0x6000168")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2B65F30", Offset = "0x2B65330", Length = "0x58")]
	[Token(Token = "0x6000174")]
	public void set_OverrideDisplayName(string value) { }

	[Address(RVA = "0x2B65F90", Offset = "0x2B65390", Length = "0x58")]
	[Token(Token = "0x6000176")]
	public void set_OverrideLogo(string value) { }

	[Address(RVA = "0x2B65FF0", Offset = "0x2B653F0", Length = "0x58")]
	[Token(Token = "0x600017C")]
	public void set_OverrideSplashScreenImage(string value) { }

	[Address(RVA = "0x2B66050", Offset = "0x2B65450", Length = "0x58")]
	[Token(Token = "0x600017A")]
	public void set_OverrideSquare44x44Logo(string value) { }

	[Address(RVA = "0x2B660B0", Offset = "0x2B654B0", Length = "0x58")]
	[Token(Token = "0x6000178")]
	public void set_OverrideSquare480x480Logo(string value) { }

	[Address(RVA = "0x2B66160", Offset = "0x2B65560", Length = "0x4A")]
	[Token(Token = "0x600016A")]
	public void set_TargetDeviceFamily(ST_DeviceFamily value) { }

	[Address(RVA = "0x2B66110", Offset = "0x2B65510", Length = "0x4C")]
	[Token(Token = "0x600016C")]
	public void set_TargetDeviceFamilySpecified(bool value) { }

}

