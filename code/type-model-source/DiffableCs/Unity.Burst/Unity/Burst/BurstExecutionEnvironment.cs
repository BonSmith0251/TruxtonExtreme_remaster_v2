namespace Unity.Burst;

[Token(Token = "0x2000019")]
public enum BurstExecutionEnvironment : int
{
	Default = 0,
	NonDeterministic = 0,
	Deterministic = 1,
}

