namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x200003F")]
public enum ReadStatus : int
{
	Complete = 0,
	InProgress = 1,
	Failed = 2,
	Truncated = 4,
	Canceled = 5,
}

