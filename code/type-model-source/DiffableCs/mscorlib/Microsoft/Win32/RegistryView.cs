namespace Microsoft.Win32;

[Token(Token = "0x200007A")]
public enum RegistryView : int
{
	Default = 0,
	Registry64 = 256,
	Registry32 = 512,
}

