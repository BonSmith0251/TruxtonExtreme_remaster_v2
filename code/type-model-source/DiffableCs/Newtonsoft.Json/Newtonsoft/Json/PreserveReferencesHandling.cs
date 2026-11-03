namespace Newtonsoft.Json;

[Flags]
[Token(Token = "0x2000088")]
public enum PreserveReferencesHandling : int
{
	None = 0,
	Objects = 1,
	Arrays = 2,
	All = 3,
}

