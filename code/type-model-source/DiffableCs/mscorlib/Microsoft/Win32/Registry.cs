namespace Microsoft.Win32;

[Token(Token = "0x2000074")]
public static class Registry
{
	[Token(Token = "0x400020A")]
	public static readonly RegistryKey CurrentUser; //Field offset: 0x0
	[Token(Token = "0x400020B")]
	public static readonly RegistryKey LocalMachine; //Field offset: 0x8
	[Token(Token = "0x400020C")]
	public static readonly RegistryKey ClassesRoot; //Field offset: 0x10
	[Token(Token = "0x400020D")]
	public static readonly RegistryKey Users; //Field offset: 0x18
	[Token(Token = "0x400020E")]
	public static readonly RegistryKey PerformanceData; //Field offset: 0x20
	[Token(Token = "0x400020F")]
	public static readonly RegistryKey CurrentConfig; //Field offset: 0x28
	[Obsolete("Use PerformanceData instead")]
	[Token(Token = "0x4000210")]
	public static readonly RegistryKey DynData; //Field offset: 0x30

	[Address(RVA = "0x1E7C260", Offset = "0x1E7B660", Length = "0x1DD")]
	[Token(Token = "0x60001F0")]
	private static Registry() { }

}

