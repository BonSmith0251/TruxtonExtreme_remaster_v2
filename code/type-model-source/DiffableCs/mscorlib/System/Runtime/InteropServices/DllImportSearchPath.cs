namespace System.Runtime.InteropServices;

[Flags]
[Token(Token = "0x2000453")]
public enum DllImportSearchPath : int
{
	UseDllDirectoryForDependencies = 256,
	ApplicationDirectory = 512,
	UserDirectories = 1024,
	System32 = 2048,
	SafeDirectories = 4096,
	AssemblyDirectory = 2,
	LegacyBehavior = 0,
}

