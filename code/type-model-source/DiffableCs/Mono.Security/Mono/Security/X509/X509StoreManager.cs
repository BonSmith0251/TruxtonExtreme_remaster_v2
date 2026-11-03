namespace Mono.Security.X509;

[Token(Token = "0x2000019")]
public sealed class X509StoreManager
{
	[Token(Token = "0x4000078")]
	private static string _userPath; //Field offset: 0x0
	[Token(Token = "0x4000079")]
	private static string _localMachinePath; //Field offset: 0x8
	[Token(Token = "0x400007A")]
	private static string _newUserPath; //Field offset: 0x10
	[Token(Token = "0x400007B")]
	private static string _newLocalMachinePath; //Field offset: 0x18
	[Token(Token = "0x400007C")]
	private static X509Stores _userStore; //Field offset: 0x20
	[Token(Token = "0x400007D")]
	private static X509Stores _machineStore; //Field offset: 0x28

	[Token(Token = "0x17000048")]
	public static X509Stores CurrentUser
	{
		[Address(RVA = "0x1E447A0", Offset = "0x1E43BA0", Length = "0x1D6")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 470
	}

	[Token(Token = "0x17000044")]
	internal static string CurrentUserPath
	{
		[Address(RVA = "0x1E44680", Offset = "0x1E43A80", Length = "0x120")]
		[Token(Token = "0x60000DE")]
		internal get { } //Length: 288
	}

	[Token(Token = "0x17000049")]
	public static X509Stores LocalMachine
	{
		[Address(RVA = "0x1E44AB0", Offset = "0x1E43EB0", Length = "0x1E3")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 483
	}

	[Token(Token = "0x17000045")]
	internal static string LocalMachinePath
	{
		[Address(RVA = "0x1E44980", Offset = "0x1E43D80", Length = "0x12D")]
		[Token(Token = "0x60000DF")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x17000046")]
	internal static string NewCurrentUserPath
	{
		[Address(RVA = "0x1E44CA0", Offset = "0x1E440A0", Length = "0x12D")]
		[Token(Token = "0x60000E0")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x17000047")]
	internal static string NewLocalMachinePath
	{
		[Address(RVA = "0x1E44DD0", Offset = "0x1E441D0", Length = "0x12D")]
		[Token(Token = "0x60000E1")]
		internal get { } //Length: 301
	}

	[Token(Token = "0x1700004A")]
	public static X509CertificateCollection TrustedRootCertificates
	{
		[Address(RVA = "0x1E44F00", Offset = "0x1E44300", Length = "0x47F")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 1151
	}

	[Address(RVA = "0x1E447A0", Offset = "0x1E43BA0", Length = "0x1D6")]
	[Token(Token = "0x60000E2")]
	public static X509Stores get_CurrentUser() { }

	[Address(RVA = "0x1E44680", Offset = "0x1E43A80", Length = "0x120")]
	[Token(Token = "0x60000DE")]
	internal static string get_CurrentUserPath() { }

	[Address(RVA = "0x1E44AB0", Offset = "0x1E43EB0", Length = "0x1E3")]
	[Token(Token = "0x60000E3")]
	public static X509Stores get_LocalMachine() { }

	[Address(RVA = "0x1E44980", Offset = "0x1E43D80", Length = "0x12D")]
	[Token(Token = "0x60000DF")]
	internal static string get_LocalMachinePath() { }

	[Address(RVA = "0x1E44CA0", Offset = "0x1E440A0", Length = "0x12D")]
	[Token(Token = "0x60000E0")]
	internal static string get_NewCurrentUserPath() { }

	[Address(RVA = "0x1E44DD0", Offset = "0x1E441D0", Length = "0x12D")]
	[Token(Token = "0x60000E1")]
	internal static string get_NewLocalMachinePath() { }

	[Address(RVA = "0x1E44F00", Offset = "0x1E44300", Length = "0x47F")]
	[Token(Token = "0x60000E4")]
	public static X509CertificateCollection get_TrustedRootCertificates() { }

}

