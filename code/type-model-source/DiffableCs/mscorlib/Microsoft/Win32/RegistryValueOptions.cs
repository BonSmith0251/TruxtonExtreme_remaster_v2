namespace Microsoft.Win32;

[Flags]
[Token(Token = "0x2000079")]
public enum RegistryValueOptions : int
{
	None = 0,
	DoNotExpandEnvironmentNames = 1,
}

