namespace System.Net.Security;

[Token(Token = "0x200031B")]
public enum EncryptionPolicy : int
{
	RequireEncryption = 0,
	AllowNoEncryption = 1,
	NoEncryption = 2,
}

