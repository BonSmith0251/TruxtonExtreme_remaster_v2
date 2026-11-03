namespace System.Reflection;

[Flags]
[Token(Token = "0x20004D4")]
public enum AssemblyNameFlags : int
{
	None = 0,
	PublicKey = 1,
	EnableJITcompileOptimizer = 16384,
	EnableJITcompileTracking = 32768,
	Retargetable = 256,
}

