namespace System.Data;

[Token(Token = "0x2000062")]
internal enum Nodes : int
{
	Noop = 0,
	Unop = 1,
	UnopSpec = 2,
	Binop = 3,
	BinopSpec = 4,
	Zop = 5,
	Call = 6,
	Const = 7,
	Name = 8,
	Paren = 9,
	Conv = 10,
}

