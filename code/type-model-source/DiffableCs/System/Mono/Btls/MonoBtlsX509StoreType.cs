namespace Mono.Btls;

[Token(Token = "0x20000A3")]
internal enum MonoBtlsX509StoreType : int
{
	Custom = 0,
	MachineTrustedRoots = 1,
	MachineIntermediateCA = 2,
	MachineUntrusted = 3,
	UserTrustedRoots = 4,
	UserIntermediateCA = 5,
	UserUntrusted = 6,
}

