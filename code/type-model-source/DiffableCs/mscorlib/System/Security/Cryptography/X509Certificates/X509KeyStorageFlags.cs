namespace System.Security.Cryptography.X509Certificates;

[Flags]
[Token(Token = "0x2000335")]
public enum X509KeyStorageFlags : int
{
	DefaultKeySet = 0,
	UserKeySet = 1,
	MachineKeySet = 2,
	Exportable = 4,
	UserProtected = 8,
	PersistKeySet = 16,
	EphemeralKeySet = 32,
}

