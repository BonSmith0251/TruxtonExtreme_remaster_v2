namespace Newtonsoft.Json;

[Flags]
[Token(Token = "0x200008D")]
public enum TypeNameHandling : int
{
	None = 0,
	Objects = 1,
	Arrays = 2,
	All = 3,
	Auto = 4,
}

