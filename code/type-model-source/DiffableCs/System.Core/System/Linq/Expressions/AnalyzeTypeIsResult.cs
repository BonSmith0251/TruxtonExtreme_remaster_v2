namespace System.Linq.Expressions;

[Token(Token = "0x2000073")]
internal enum AnalyzeTypeIsResult : int
{
	KnownFalse = 0,
	KnownTrue = 1,
	KnownAssignable = 2,
	Unknown = 3,
}

