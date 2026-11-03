namespace Unity.Burst;

[Token(Token = "0x2000018")]
internal enum CompilationPriority : int
{
	EagerCompilationSynchronous = 0,
	Asynchronous = 1,
	ILPP = 2,
	EagerCompilationAsynchronous = 3,
}

