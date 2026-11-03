namespace System.Configuration.Assemblies;

[Token(Token = "0x200059E")]
public enum AssemblyVersionCompatibility : int
{
	SameMachine = 1,
	SameProcess = 2,
	SameDomain = 3,
}

