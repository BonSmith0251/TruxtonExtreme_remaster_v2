namespace UnityEngine.AddressableAssets.Initialization;

[Token(Token = "0x2000066")]
public class ResourceManagerRuntimeData
{
	[Token(Token = "0x4000166")]
	public const string kCatalogAddress = "AddressablesMainContentCatalog"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000167")]
	private string m_buildTarget; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_settingsHash")]
	[SerializeField]
	[Token(Token = "0x4000168")]
	private string m_SettingsHash; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_catalogLocations")]
	[SerializeField]
	[Token(Token = "0x4000169")]
	private List<ResourceLocationData> m_CatalogLocations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_logResourceManagerExceptions")]
	[SerializeField]
	[Token(Token = "0x400016A")]
	private bool m_LogResourceManagerExceptions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_extraInitializationData")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	private List<ObjectInitializationData> m_ExtraInitializationData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	private bool m_DisableCatalogUpdateOnStart; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	private bool m_IsLocalCatalogInBundle; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	private SerializedType m_CertificateHandlerType; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	private string m_AddressablesVersion; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000170")]
	private int m_maxConcurrentWebRequests; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000171")]
	private int m_CatalogRequestsTimeout; //Field offset: 0x6C

	[Token(Token = "0x17000075")]
	public string AddressablesVersion
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000283")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6000284")]
		 set { } //Length: 995
	}

	[Token(Token = "0x1700006D")]
	public string BuildTarget
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000275")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000276")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006F")]
	public List<ResourceLocationData> CatalogLocations
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000279")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000077")]
	public int CatalogRequestsTimeout
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x6000287")]
		 get { } //Length: 4
		[Address(RVA = "0x27B9970", Offset = "0x27B8D70", Length = "0x1D")]
		[Token(Token = "0x6000288")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000074")]
	public Type CertificateHandlerType
	{
		[Address(RVA = "0x27B9960", Offset = "0x27B8D60", Length = "0xB")]
		[Token(Token = "0x6000281")]
		 get { } //Length: 11
		[Address(RVA = "0x27B9990", Offset = "0x27B8D90", Length = "0xC")]
		[Token(Token = "0x6000282")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000072")]
	public bool DisableCatalogUpdateOnStartup
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x600027D")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x600027E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000071")]
	public List<ObjectInitializationData> InitializationObjects
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600027C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000073")]
	public bool IsLocalCatalogInBundle
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x600027F")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[Token(Token = "0x6000280")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000070")]
	public bool LogResourceManagerExceptions
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600027A")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x600027B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000076")]
	public int MaxConcurrentWebRequests
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6000285")]
		 get { } //Length: 4
		[Address(RVA = "0x27B99A0", Offset = "0x27B8DA0", Length = "0x21")]
		[Token(Token = "0x6000286")]
		 set { } //Length: 33
	}

	[Token(Token = "0x1700006E")]
	public string SettingsHash
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000277")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000278")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x27B9890", Offset = "0x27B8C90", Length = "0xC8")]
	[Token(Token = "0x6000289")]
	public ResourceManagerRuntimeData() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000283")]
	public string get_AddressablesVersion() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000275")]
	public string get_BuildTarget() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000279")]
	public List<ResourceLocationData> get_CatalogLocations() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x6000287")]
	public int get_CatalogRequestsTimeout() { }

	[Address(RVA = "0x27B9960", Offset = "0x27B8D60", Length = "0xB")]
	[Token(Token = "0x6000281")]
	public Type get_CertificateHandlerType() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x600027D")]
	public bool get_DisableCatalogUpdateOnStartup() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600027C")]
	public List<ObjectInitializationData> get_InitializationObjects() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[Token(Token = "0x600027F")]
	public bool get_IsLocalCatalogInBundle() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600027A")]
	public bool get_LogResourceManagerExceptions() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6000285")]
	public int get_MaxConcurrentWebRequests() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000277")]
	public string get_SettingsHash() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6000284")]
	public void set_AddressablesVersion(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000276")]
	public void set_BuildTarget(string value) { }

	[Address(RVA = "0x27B9970", Offset = "0x27B8D70", Length = "0x1D")]
	[Token(Token = "0x6000288")]
	public void set_CatalogRequestsTimeout(int value) { }

	[Address(RVA = "0x27B9990", Offset = "0x27B8D90", Length = "0xC")]
	[Token(Token = "0x6000282")]
	public void set_CertificateHandlerType(Type value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x600027E")]
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[Token(Token = "0x6000280")]
	public void set_IsLocalCatalogInBundle(bool value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x600027B")]
	public void set_LogResourceManagerExceptions(bool value) { }

	[Address(RVA = "0x27B99A0", Offset = "0x27B8DA0", Length = "0x21")]
	[Token(Token = "0x6000286")]
	public void set_MaxConcurrentWebRequests(int value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000278")]
	public void set_SettingsHash(string value) { }

}

