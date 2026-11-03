namespace System.Threading;

[Token(Token = "0x2000232")]
internal enum StackCrawlMark : int
{
	LookForMe = 0,
	LookForMyCaller = 1,
	LookForMyCallersCaller = 2,
	LookForThread = 3,
}

