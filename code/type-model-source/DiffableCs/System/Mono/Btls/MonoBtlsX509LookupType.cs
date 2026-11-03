namespace Mono.Btls;

[Token(Token = "0x200009A")]
internal enum MonoBtlsX509LookupType : int
{
	UNKNOWN = 0,
	FILE = 1,
	HASH_DIR = 2,
	MONO = 3,
}

