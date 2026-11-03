namespace System.Xml;

[Token(Token = "0x2000038")]
internal enum ElementProperties : uint
{
	DEFAULT = 0,
	URI_PARENT = 1,
	BOOL_PARENT = 2,
	NAME_PARENT = 4,
	EMPTY = 8,
	NO_ENTITIES = 16,
	HEAD = 32,
	BLOCK_WS = 64,
	HAS_NS = 128,
}

