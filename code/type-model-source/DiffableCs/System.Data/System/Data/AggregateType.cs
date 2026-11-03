namespace System.Data;

[Token(Token = "0x2000024")]
internal enum AggregateType : int
{
	None = 0,
	Sum = 4,
	Mean = 5,
	Min = 6,
	Max = 7,
	First = 8,
	Count = 9,
	Var = 10,
	StDev = 11,
}

