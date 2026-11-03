namespace Unity.XGamingRuntime;

[Flags]
[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000261")]
public enum XStoreProductKind : uint
{
	None = 0,
	Consumable = 1,
	Durable = 2,
	Game = 4,
	Pass = 8,
	UnmanagedConsumable = 16,
}

