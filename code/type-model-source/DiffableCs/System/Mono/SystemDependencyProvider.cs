namespace Mono;

[Token(Token = "0x2000003")]
internal class SystemDependencyProvider : ISystemDependencyProvider
{
	[Token(Token = "0x4000005")]
	private static SystemDependencyProvider instance; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static object syncRoot; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000004")]
	public SystemCertificateProvider CertificateProvider
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600000E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public static SystemDependencyProvider Instance
	{
		[Address(RVA = "0x22CB390", Offset = "0x22CA790", Length = "0x52")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000003")]
	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600000D")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public X509PalImpl X509Pal
	{
		[Address(RVA = "0x22CB3F0", Offset = "0x22CA7F0", Length = "0x5F")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x22CB270", Offset = "0x22CA670", Length = "0x78")]
	[Token(Token = "0x6000011")]
	private static SystemDependencyProvider() { }

	[Address(RVA = "0x22CB2F0", Offset = "0x22CA6F0", Length = "0x91")]
	[Token(Token = "0x6000010")]
	private SystemDependencyProvider() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600000E")]
	public SystemCertificateProvider get_CertificateProvider() { }

	[Address(RVA = "0x22CB390", Offset = "0x22CA790", Length = "0x52")]
	[Token(Token = "0x600000B")]
	public static SystemDependencyProvider get_Instance() { }

	[Address(RVA = "0x22CB3F0", Offset = "0x22CA7F0", Length = "0x5F")]
	[Token(Token = "0x600000F")]
	public X509PalImpl get_X509Pal() { }

	[Address(RVA = "0x22CB090", Offset = "0x22CA490", Length = "0x1D4")]
	[Token(Token = "0x600000C")]
	internal static void Initialize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600000D")]
	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

}

