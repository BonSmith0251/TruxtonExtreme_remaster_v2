namespace Microsoft.Win32;

[Token(Token = "0x2000075")]
public enum RegistryHive : int
{
	ClassesRoot = -2147483648,
	CurrentUser = -2147483647,
	LocalMachine = -2147483646,
	Users = -2147483645,
	PerformanceData = -2147483644,
	CurrentConfig = -2147483643,
	DynData = -2147483642,
}

