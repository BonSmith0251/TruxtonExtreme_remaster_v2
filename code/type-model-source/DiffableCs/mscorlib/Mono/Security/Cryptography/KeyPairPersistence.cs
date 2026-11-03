namespace Mono.Security.Cryptography;

[Token(Token = "0x2000060")]
internal class KeyPairPersistence
{
	[Token(Token = "0x40001BB")]
	private static bool _userPathExists; //Field offset: 0x0
	[Token(Token = "0x40001BC")]
	private static string _userPath; //Field offset: 0x8
	[Token(Token = "0x40001BD")]
	private static bool _machinePathExists; //Field offset: 0x10
	[Token(Token = "0x40001BE")]
	private static string _machinePath; //Field offset: 0x18
	[Token(Token = "0x40001C3")]
	private static object lockobj; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BF")]
	private CspParameters _params; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C0")]
	private string _keyvalue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C1")]
	private string _filename; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C2")]
	private string _container; //Field offset: 0x28

	[Token(Token = "0x1700001E")]
	private bool CanChange
	{
		[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
		[Token(Token = "0x6000138")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000021")]
	private string ContainerName
	{
		[Address(RVA = "0x1E5F310", Offset = "0x1E5E710", Length = "0x149")]
		[Token(Token = "0x600013B")]
		private get { } //Length: 329
	}

	[Token(Token = "0x1700001A")]
	public string Filename
	{
		[Address(RVA = "0x1E5F460", Offset = "0x1E5E860", Length = "0x1AD")]
		[Token(Token = "0x6000126")]
		 get { } //Length: 429
	}

	[Token(Token = "0x1700001B")]
	public string KeyValue
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 5
		[Address(RVA = "0x1E600F0", Offset = "0x1E5F4F0", Length = "0x15")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 21
	}

	[Token(Token = "0x1700001D")]
	private static string MachinePath
	{
		[Address(RVA = "0x1E5F610", Offset = "0x1E5EA10", Length = "0x54F")]
		[Token(Token = "0x600012D")]
		private get { } //Length: 1359
	}

	[Token(Token = "0x1700001F")]
	private bool UseDefaultKeyContainer
	{
		[Address(RVA = "0x1E5FB60", Offset = "0x1E5EF60", Length = "0x1E")]
		[Token(Token = "0x6000139")]
		private get { } //Length: 30
	}

	[Token(Token = "0x17000020")]
	private bool UseMachineKeyStore
	{
		[Address(RVA = "0x1E5FB80", Offset = "0x1E5EF80", Length = "0x1D")]
		[Token(Token = "0x600013A")]
		private get { } //Length: 29
	}

	[Token(Token = "0x1700001C")]
	private static string UserPath
	{
		[Address(RVA = "0x1E5FBA0", Offset = "0x1E5EFA0", Length = "0x54B")]
		[Token(Token = "0x600012C")]
		private get { } //Length: 1355
	}

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x600012E")]
	internal static bool _CanSecure(Char* root) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x6000132")]
	internal static bool _IsMachineProtected(Char* path) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x6000131")]
	internal static bool _IsUserProtected(Char* path) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x6000130")]
	internal static bool _ProtectMachine(Char* path) { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x600012F")]
	internal static bool _ProtectUser(Char* path) { }

	[Address(RVA = "0x1E5F030", Offset = "0x1E5E430", Length = "0x78")]
	[Token(Token = "0x600013F")]
	private static KeyPairPersistence() { }

	[Address(RVA = "0x1E5F1E0", Offset = "0x1E5E5E0", Length = "0x123")]
	[Token(Token = "0x6000124")]
	public KeyPairPersistence(CspParameters parameters) { }

	[Address(RVA = "0x1E5F0B0", Offset = "0x1E5E4B0", Length = "0x12E")]
	[Token(Token = "0x6000125")]
	public KeyPairPersistence(CspParameters parameters, string keyPair) { }

	[Address(RVA = "0x1E5E410", Offset = "0x1E5D810", Length = "0x86")]
	[Token(Token = "0x6000133")]
	private static bool CanSecure(string path) { }

	[Address(RVA = "0x1E5E4A0", Offset = "0x1E5D8A0", Length = "0xAD")]
	[Token(Token = "0x600013C")]
	private CspParameters Copy(CspParameters p) { }

	[Address(RVA = "0x1E5E550", Offset = "0x1E5D950", Length = "0x1B8")]
	[Token(Token = "0x600013D")]
	private void FromXml(string xml) { }

	[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
	[Token(Token = "0x6000138")]
	private bool get_CanChange() { }

	[Address(RVA = "0x1E5F310", Offset = "0x1E5E710", Length = "0x149")]
	[Token(Token = "0x600013B")]
	private string get_ContainerName() { }

	[Address(RVA = "0x1E5F460", Offset = "0x1E5E860", Length = "0x1AD")]
	[Token(Token = "0x6000126")]
	public string get_Filename() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000127")]
	public string get_KeyValue() { }

	[Address(RVA = "0x1E5F610", Offset = "0x1E5EA10", Length = "0x54F")]
	[Token(Token = "0x600012D")]
	private static string get_MachinePath() { }

	[Address(RVA = "0x1E5FB60", Offset = "0x1E5EF60", Length = "0x1E")]
	[Token(Token = "0x6000139")]
	private bool get_UseDefaultKeyContainer() { }

	[Address(RVA = "0x1E5FB80", Offset = "0x1E5EF80", Length = "0x1D")]
	[Token(Token = "0x600013A")]
	private bool get_UseMachineKeyStore() { }

	[Address(RVA = "0x1E5FBA0", Offset = "0x1E5EFA0", Length = "0x54B")]
	[Token(Token = "0x600012C")]
	private static string get_UserPath() { }

	[Address(RVA = "0x1E5E710", Offset = "0x1E5DB10", Length = "0xFB")]
	[Token(Token = "0x6000137")]
	private static bool IsMachineProtected(string path) { }

	[Address(RVA = "0x1E5E810", Offset = "0x1E5DC10", Length = "0xFB")]
	[Token(Token = "0x6000136")]
	private static bool IsUserProtected(string path) { }

	[Address(RVA = "0x1E5E910", Offset = "0x1E5DD10", Length = "0x107")]
	[Token(Token = "0x6000129")]
	public bool Load() { }

	[Address(RVA = "0x1E5EA20", Offset = "0x1E5DE20", Length = "0xFB")]
	[Token(Token = "0x6000135")]
	private static bool ProtectMachine(string path) { }

	[Address(RVA = "0x1E5EB20", Offset = "0x1E5DF20", Length = "0xFB")]
	[Token(Token = "0x6000134")]
	private static bool ProtectUser(string path) { }

	[Address(RVA = "0x1E5EC20", Offset = "0x1E5E020", Length = "0x19")]
	[Token(Token = "0x600012B")]
	public void Remove() { }

	[Address(RVA = "0x1E5EC40", Offset = "0x1E5E040", Length = "0x1C5")]
	[Token(Token = "0x600012A")]
	public void Save() { }

	[Address(RVA = "0x1E600F0", Offset = "0x1E5F4F0", Length = "0x15")]
	[Token(Token = "0x6000128")]
	public void set_KeyValue(string value) { }

	[Address(RVA = "0x1E5EE10", Offset = "0x1E5E210", Length = "0x200")]
	[Token(Token = "0x600013E")]
	private string ToXml() { }

}

