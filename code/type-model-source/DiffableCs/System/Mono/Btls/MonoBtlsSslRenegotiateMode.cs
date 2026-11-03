namespace Mono.Btls;

[Flags]
[Token(Token = "0x200008A")]
internal enum MonoBtlsSslRenegotiateMode : int
{
	NEVER = 0,
	ONCE = 1,
	FREELY = 2,
	IGNORE = 3,
}

