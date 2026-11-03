namespace Microsoft.Win32;

[Token(Token = "0x2000078")]
public enum RegistryKeyPermissionCheck : int
{
	Default = 0,
	ReadSubTree = 1,
	ReadWriteSubTree = 2,
}

