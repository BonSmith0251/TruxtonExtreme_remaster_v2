namespace Unity.Jobs.LowLevel.Unsafe;

[Token(Token = "0x200001B")]
public enum ScheduleMode : int
{
	Run = 0,
	Batched = 1,
	Parallel = 1,
	Single = 2,
}

