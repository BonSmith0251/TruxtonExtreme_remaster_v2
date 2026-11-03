namespace Unity.Burst;

[Token(Token = "0x2000007")]
public enum FloatMode : int
{
	Default = 0,
	Strict = 1,
	Deterministic = 2,
	Fast = 3,
}

