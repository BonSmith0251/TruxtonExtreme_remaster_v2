namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000004")]
[XmlRoot(Namespace = null, IsNullable = False)]
[XmlType(AnonymousType = True)]
public class Game : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private CT_Identity identityField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000007")]
	private CT_ShellVisuals shellVisualsField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	private CT_ResourcesResource[] resourcesField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000009")]
	private CT_ExecutableList executableListField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000A")]
	private string gameOsVersionField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000B")]
	private CT_MediaCapture mediaCaptureField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000C")]
	private string storeIdField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000D")]
	private ST_DeviceFamily targetDeviceFamilyForDLCField; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400000E")]
	private bool targetDeviceFamilyForDLCFieldSpecified; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400000F")]
	private CT_AllowedProductsList allowedProductsField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000010")]
	private CT_RelatedProductsList relatedProductsField; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000011")]
	private CT_PersistentLocalStorage persistentLocalStorageField; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000012")]
	private CT_VirtualMachine virtualMachineField; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000013")]
	private bool mSAFullTrustField; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000014")]
	private bool mSAFullTrustFieldSpecified; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000015")]
	private string mSAAppIdField; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000016")]
	private string titleIdField; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000017")]
	private bool requiresXboxLiveField; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000018")]
	private bool requiresXboxLiveFieldSpecified; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000019")]
	private CT_ExtendedAttributeList extendedAttributeListField; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400001A")]
	private CT_DesktopRegistration desktopRegistrationField; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400001B")]
	private CT_DevelopmentOnly developmentOnlyField; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400001C")]
	private bool advancedUserModelField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400001D")]
	private CT_SaveGameStorage saveGameStorageField; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400001E")]
	private CT_ProtocolList protocolListField; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400001F")]
	private string franchiseGameHubIdField; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000020")]
	private string associatedFranchiseGameHubIdField; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000021")]
	private string configVersionField; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000022")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0xD8

	[Token(Token = "0x14000001")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B6BF90", Offset = "0x2B6B390", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		 add { } //Length: 162
		[Address(RVA = "0x2B6C040", Offset = "0x2B6B440", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600003D")]
		 remove { } //Length: 162
	}

	[DefaultValue(True)]
	[Token(Token = "0x17000017")]
	public bool AdvancedUserModel
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C0F0", Offset = "0x2B6B4F0", Length = "0x4F")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 79
	}

	[Token(Token = "0x1700000A")]
	public CT_AllowedProductsList AllowedProducts
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C140", Offset = "0x2B6B540", Length = "0x58")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700001B")]
	public string AssociatedFranchiseGameHubId
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x6000038")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C1A0", Offset = "0x2B6B5A0", Length = "0x5E")]
		[Token(Token = "0x6000039")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700001C")]
	[XmlAttribute(DataType = "integer")]
	public string configVersion
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x600003A")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6CAA0", Offset = "0x2B6BEA0", Length = "0x5E")]
		[Token(Token = "0x600003B")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000015")]
	public CT_DesktopRegistration DesktopRegistration
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C200", Offset = "0x2B6B600", Length = "0x5E")]
		[Token(Token = "0x600002D")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000016")]
	public CT_DevelopmentOnly DevelopmentOnly
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C260", Offset = "0x2B6B660", Length = "0x5E")]
		[Token(Token = "0x600002F")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000004")]
	public CT_ExecutableList ExecutableList
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C2C0", Offset = "0x2B6B6C0", Length = "0x58")]
		[Token(Token = "0x600000B")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000014")]
	public CT_ExtendedAttributeList ExtendedAttributeList
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C320", Offset = "0x2B6B720", Length = "0x5E")]
		[Token(Token = "0x600002B")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700001A")]
	public string FranchiseGameHubId
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6000036")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C380", Offset = "0x2B6B780", Length = "0x5E")]
		[Token(Token = "0x6000037")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000005")]
	public string GameOsVersion
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C3E0", Offset = "0x2B6B7E0", Length = "0x58")]
		[Token(Token = "0x600000D")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000001")]
	public CT_Identity Identity
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C440", Offset = "0x2B6B840", Length = "0x58")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000006")]
	public CT_MediaCapture MediaCapture
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C5A0", Offset = "0x2B6B9A0", Length = "0x58")]
		[Token(Token = "0x600000F")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000010")]
	public string MSAAppId
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C4A0", Offset = "0x2B6B8A0", Length = "0x58")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700000E")]
	public bool MSAFullTrust
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C550", Offset = "0x2B6B950", Length = "0x4C")]
		[Token(Token = "0x600001F")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700000F")]
	[XmlIgnore]
	public bool MSAFullTrustSpecified
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C500", Offset = "0x2B6B900", Length = "0x4C")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700000C")]
	public CT_PersistentLocalStorage PersistentLocalStorage
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C600", Offset = "0x2B6BA00", Length = "0x58")]
		[Token(Token = "0x600001B")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000019")]
	public CT_ProtocolList ProtocolList
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000034")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C660", Offset = "0x2B6BA60", Length = "0x5E")]
		[Token(Token = "0x6000035")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700000B")]
	public CT_RelatedProductsList RelatedProducts
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C6C0", Offset = "0x2B6BAC0", Length = "0x58")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000012")]
	public bool RequiresXboxLive
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C770", Offset = "0x2B6BB70", Length = "0x4F")]
		[Token(Token = "0x6000027")]
		 set { } //Length: 79
	}

	[Token(Token = "0x17000013")]
	[XmlIgnore]
	public bool RequiresXboxLiveSpecified
	{
		[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C720", Offset = "0x2B6BB20", Length = "0x4F")]
		[Token(Token = "0x6000029")]
		 set { } //Length: 79
	}

	[Token(Token = "0x17000003")]
	[XmlArrayItem("Resource", IsNullable = False)]
	public CT_ResourcesResource[] Resources
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C7C0", Offset = "0x2B6BBC0", Length = "0x58")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000018")]
	public CT_SaveGameStorage SaveGameStorage
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C820", Offset = "0x2B6BC20", Length = "0x5E")]
		[Token(Token = "0x6000033")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000002")]
	public CT_ShellVisuals ShellVisuals
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C880", Offset = "0x2B6BC80", Length = "0x58")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000007")]
	public string StoreId
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C8E0", Offset = "0x2B6BCE0", Length = "0x58")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000008")]
	public ST_DeviceFamily TargetDeviceFamilyForDLC
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 4
		[Address(RVA = "0x2B6C990", Offset = "0x2B6BD90", Length = "0x4A")]
		[Token(Token = "0x6000013")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000009")]
	[XmlIgnore]
	public bool TargetDeviceFamilyForDLCSpecified
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6C940", Offset = "0x2B6BD40", Length = "0x4C")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000011")]
	public string TitleId
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 8
		[Address(RVA = "0x2B6C9E0", Offset = "0x2B6BDE0", Length = "0x5E")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700000D")]
	public CT_VirtualMachine VirtualMachine
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6CA40", Offset = "0x2B6BE40", Length = "0x58")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x2B6BF70", Offset = "0x2B6B370", Length = "0x1D")]
	[Token(Token = "0x6000003")]
	public Game() { }

	[Address(RVA = "0x2B6BF90", Offset = "0x2B6B390", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[Token(Token = "0x6000030")]
	public bool get_AdvancedUserModel() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000016")]
	public CT_AllowedProductsList get_AllowedProducts() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x6000038")]
	public string get_AssociatedFranchiseGameHubId() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x600003A")]
	public string get_configVersion() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600002C")]
	public CT_DesktopRegistration get_DesktopRegistration() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x600002E")]
	public CT_DevelopmentOnly get_DevelopmentOnly() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600000A")]
	public CT_ExecutableList get_ExecutableList() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x600002A")]
	public CT_ExtendedAttributeList get_ExtendedAttributeList() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6000036")]
	public string get_FranchiseGameHubId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600000C")]
	public string get_GameOsVersion() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000004")]
	public CT_Identity get_Identity() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600000E")]
	public CT_MediaCapture get_MediaCapture() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000022")]
	public string get_MSAAppId() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x600001E")]
	public bool get_MSAFullTrust() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x6000020")]
	public bool get_MSAFullTrustSpecified() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600001A")]
	public CT_PersistentLocalStorage get_PersistentLocalStorage() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000034")]
	public CT_ProtocolList get_ProtocolList() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000018")]
	public CT_RelatedProductsList get_RelatedProducts() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000026")]
	public bool get_RequiresXboxLive() { }

	[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
	[Token(Token = "0x6000028")]
	public bool get_RequiresXboxLiveSpecified() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000008")]
	public CT_ResourcesResource[] get_Resources() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6000032")]
	public CT_SaveGameStorage get_SaveGameStorage() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000006")]
	public CT_ShellVisuals get_ShellVisuals() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000010")]
	public string get_StoreId() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000012")]
	public ST_DeviceFamily get_TargetDeviceFamilyForDLC() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x6000014")]
	public bool get_TargetDeviceFamilyForDLCSpecified() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000024")]
	public string get_TitleId() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600001C")]
	public CT_VirtualMachine get_VirtualMachine() { }

	[Address(RVA = "0x2B6BEE0", Offset = "0x2B6B2E0", Length = "0x89")]
	[Token(Token = "0x600003E")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B6C040", Offset = "0x2B6B440", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600003D")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B6C0F0", Offset = "0x2B6B4F0", Length = "0x4F")]
	[Token(Token = "0x6000031")]
	public void set_AdvancedUserModel(bool value) { }

	[Address(RVA = "0x2B6C140", Offset = "0x2B6B540", Length = "0x58")]
	[Token(Token = "0x6000017")]
	public void set_AllowedProducts(CT_AllowedProductsList value) { }

	[Address(RVA = "0x2B6C1A0", Offset = "0x2B6B5A0", Length = "0x5E")]
	[Token(Token = "0x6000039")]
	public void set_AssociatedFranchiseGameHubId(string value) { }

	[Address(RVA = "0x2B6CAA0", Offset = "0x2B6BEA0", Length = "0x5E")]
	[Token(Token = "0x600003B")]
	public void set_configVersion(string value) { }

	[Address(RVA = "0x2B6C200", Offset = "0x2B6B600", Length = "0x5E")]
	[Token(Token = "0x600002D")]
	public void set_DesktopRegistration(CT_DesktopRegistration value) { }

	[Address(RVA = "0x2B6C260", Offset = "0x2B6B660", Length = "0x5E")]
	[Token(Token = "0x600002F")]
	public void set_DevelopmentOnly(CT_DevelopmentOnly value) { }

	[Address(RVA = "0x2B6C2C0", Offset = "0x2B6B6C0", Length = "0x58")]
	[Token(Token = "0x600000B")]
	public void set_ExecutableList(CT_ExecutableList value) { }

	[Address(RVA = "0x2B6C320", Offset = "0x2B6B720", Length = "0x5E")]
	[Token(Token = "0x600002B")]
	public void set_ExtendedAttributeList(CT_ExtendedAttributeList value) { }

	[Address(RVA = "0x2B6C380", Offset = "0x2B6B780", Length = "0x5E")]
	[Token(Token = "0x6000037")]
	public void set_FranchiseGameHubId(string value) { }

	[Address(RVA = "0x2B6C3E0", Offset = "0x2B6B7E0", Length = "0x58")]
	[Token(Token = "0x600000D")]
	public void set_GameOsVersion(string value) { }

	[Address(RVA = "0x2B6C440", Offset = "0x2B6B840", Length = "0x58")]
	[Token(Token = "0x6000005")]
	public void set_Identity(CT_Identity value) { }

	[Address(RVA = "0x2B6C5A0", Offset = "0x2B6B9A0", Length = "0x58")]
	[Token(Token = "0x600000F")]
	public void set_MediaCapture(CT_MediaCapture value) { }

	[Address(RVA = "0x2B6C4A0", Offset = "0x2B6B8A0", Length = "0x58")]
	[Token(Token = "0x6000023")]
	public void set_MSAAppId(string value) { }

	[Address(RVA = "0x2B6C550", Offset = "0x2B6B950", Length = "0x4C")]
	[Token(Token = "0x600001F")]
	public void set_MSAFullTrust(bool value) { }

	[Address(RVA = "0x2B6C500", Offset = "0x2B6B900", Length = "0x4C")]
	[Token(Token = "0x6000021")]
	public void set_MSAFullTrustSpecified(bool value) { }

	[Address(RVA = "0x2B6C600", Offset = "0x2B6BA00", Length = "0x58")]
	[Token(Token = "0x600001B")]
	public void set_PersistentLocalStorage(CT_PersistentLocalStorage value) { }

	[Address(RVA = "0x2B6C660", Offset = "0x2B6BA60", Length = "0x5E")]
	[Token(Token = "0x6000035")]
	public void set_ProtocolList(CT_ProtocolList value) { }

	[Address(RVA = "0x2B6C6C0", Offset = "0x2B6BAC0", Length = "0x58")]
	[Token(Token = "0x6000019")]
	public void set_RelatedProducts(CT_RelatedProductsList value) { }

	[Address(RVA = "0x2B6C770", Offset = "0x2B6BB70", Length = "0x4F")]
	[Token(Token = "0x6000027")]
	public void set_RequiresXboxLive(bool value) { }

	[Address(RVA = "0x2B6C720", Offset = "0x2B6BB20", Length = "0x4F")]
	[Token(Token = "0x6000029")]
	public void set_RequiresXboxLiveSpecified(bool value) { }

	[Address(RVA = "0x2B6C7C0", Offset = "0x2B6BBC0", Length = "0x58")]
	[Token(Token = "0x6000009")]
	public void set_Resources(CT_ResourcesResource[] value) { }

	[Address(RVA = "0x2B6C820", Offset = "0x2B6BC20", Length = "0x5E")]
	[Token(Token = "0x6000033")]
	public void set_SaveGameStorage(CT_SaveGameStorage value) { }

	[Address(RVA = "0x2B6C880", Offset = "0x2B6BC80", Length = "0x58")]
	[Token(Token = "0x6000007")]
	public void set_ShellVisuals(CT_ShellVisuals value) { }

	[Address(RVA = "0x2B6C8E0", Offset = "0x2B6BCE0", Length = "0x58")]
	[Token(Token = "0x6000011")]
	public void set_StoreId(string value) { }

	[Address(RVA = "0x2B6C990", Offset = "0x2B6BD90", Length = "0x4A")]
	[Token(Token = "0x6000013")]
	public void set_TargetDeviceFamilyForDLC(ST_DeviceFamily value) { }

	[Address(RVA = "0x2B6C940", Offset = "0x2B6BD40", Length = "0x4C")]
	[Token(Token = "0x6000015")]
	public void set_TargetDeviceFamilyForDLCSpecified(bool value) { }

	[Address(RVA = "0x2B6C9E0", Offset = "0x2B6BDE0", Length = "0x5E")]
	[Token(Token = "0x6000025")]
	public void set_TitleId(string value) { }

	[Address(RVA = "0x2B6CA40", Offset = "0x2B6BE40", Length = "0x58")]
	[Token(Token = "0x600001D")]
	public void set_VirtualMachine(CT_VirtualMachine value) { }

}

