namespace Mono.Security.Interface;

[Token(Token = "0x2000044")]
public sealed class MonoTlsSettings
{
	[Token(Token = "0x40001FA")]
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E8")]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E9")]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EA")]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EB")]
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001EC")]
	private object <UserSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001ED")]
	private String[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EE")]
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EF")]
	private String[] <ClientCertificateIssuers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F0")]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001F1")]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001F2")]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001F3")]
	private bool cloned; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40001F4")]
	private bool checkCertName; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40001F5")]
	private bool checkCertRevocationStatus; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x40001F6")]
	private Nullable<Boolean> useServicePointManagerCallback; //Field offset: 0x73
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x40001F7")]
	private bool skipSystemValidators; //Field offset: 0x75
	[FieldOffset(Offset = "0x76")]
	[Token(Token = "0x40001F8")]
	private bool callbackNeedsChain; //Field offset: 0x76
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001F9")]
	private ICertificateValidator certificateValidator; //Field offset: 0x78

	[Token(Token = "0x1700006F")]
	public bool CallbackNeedsCertificateChain
	{
		[Address(RVA = "0x1E522E0", Offset = "0x1E516E0", Length = "0x5")]
		[Token(Token = "0x6000161")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000073")]
	internal String[] CertificateSearchPaths
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000168")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000169")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000070")]
	public Nullable<DateTime> CertificateValidationTime
	{
		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000162")]
		 get { } //Length: 11
		[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000163")]
		 set { } //Length: 8
	}

	[Obsolete("Do not use outside System.dll!")]
	[Token(Token = "0x1700007A")]
	public ICertificateValidator CertificateValidator
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000075")]
	public String[] ClientCertificateIssuers
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600016C")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600016D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006D")]
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600015D")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600015E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000079")]
	public static MonoTlsSettings DefaultSettings
	{
		[Address(RVA = "0x1E522F0", Offset = "0x1E516F0", Length = "0x87")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000076")]
	public bool DisallowUnauthenticatedCertificateRequest
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600016E")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600016F")]
		 set { } //Length: 4
	}

	[CLSCompliant(False)]
	[Token(Token = "0x17000078")]
	public CipherSuiteCode[] EnabledCiphers
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000172")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000173")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000077")]
	public Nullable<TlsProtocols> EnabledProtocols
	{
		[Address(RVA = "0x1E52380", Offset = "0x1E51780", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000170")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523C0", Offset = "0x1E517C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000171")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600015B")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600015C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000074")]
	internal bool SendCloseNotify
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600016A")]
		internal get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600016B")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000071")]
	public X509CertificateCollection TrustAnchors
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000164")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000165")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000072")]
	public object UserSettings
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000166")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000167")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006E")]
	public Nullable<Boolean> UseServicePointManagerCallback
	{
		[Address(RVA = "0x1E52390", Offset = "0x1E51790", Length = "0x5")]
		[Token(Token = "0x600015F")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523E0", Offset = "0x1E517E0", Length = "0x5")]
		[Token(Token = "0x6000160")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x1E52140", Offset = "0x1E51540", Length = "0x18C")]
	[Token(Token = "0x600017A")]
	private MonoTlsSettings(MonoTlsSettings other) { }

	[Address(RVA = "0x1E522D0", Offset = "0x1E516D0", Length = "0xF")]
	[Token(Token = "0x6000174")]
	public MonoTlsSettings() { }

	[Address(RVA = "0x1E52000", Offset = "0x1E51400", Length = "0x54")]
	[Token(Token = "0x6000179")]
	public MonoTlsSettings Clone() { }

	[Address(RVA = "0x1E51F60", Offset = "0x1E51360", Length = "0x9F")]
	[Obsolete("Do not use outside System.dll!")]
	[Token(Token = "0x6000178")]
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	[Address(RVA = "0x1E52060", Offset = "0x1E51460", Length = "0xD0")]
	[Token(Token = "0x6000176")]
	public static MonoTlsSettings CopyDefaultSettings() { }

	[Address(RVA = "0x1E522E0", Offset = "0x1E516E0", Length = "0x5")]
	[Token(Token = "0x6000161")]
	public bool get_CallbackNeedsCertificateChain() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000168")]
	internal String[] get_CertificateSearchPaths() { }

	[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000162")]
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000177")]
	public ICertificateValidator get_CertificateValidator() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600016C")]
	public String[] get_ClientCertificateIssuers() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600015D")]
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[Address(RVA = "0x1E522F0", Offset = "0x1E516F0", Length = "0x87")]
	[Token(Token = "0x6000175")]
	public static MonoTlsSettings get_DefaultSettings() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600016E")]
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000172")]
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[Address(RVA = "0x1E52380", Offset = "0x1E51780", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000170")]
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600015B")]
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600016A")]
	internal bool get_SendCloseNotify() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000164")]
	public X509CertificateCollection get_TrustAnchors() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000166")]
	public object get_UserSettings() { }

	[Address(RVA = "0x1E52390", Offset = "0x1E51790", Length = "0x5")]
	[Token(Token = "0x600015F")]
	public Nullable<Boolean> get_UseServicePointManagerCallback() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000169")]
	internal void set_CertificateSearchPaths(String[] value) { }

	[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000163")]
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600016D")]
	public void set_ClientCertificateIssuers(String[] value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600015E")]
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600016F")]
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000173")]
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	[Address(RVA = "0x1E523C0", Offset = "0x1E517C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000171")]
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600015C")]
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600016B")]
	internal void set_SendCloseNotify(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000165")]
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000167")]
	public void set_UserSettings(object value) { }

	[Address(RVA = "0x1E523E0", Offset = "0x1E517E0", Length = "0x5")]
	[Token(Token = "0x6000160")]
	public void set_UseServicePointManagerCallback(Nullable<Boolean> value) { }

}

