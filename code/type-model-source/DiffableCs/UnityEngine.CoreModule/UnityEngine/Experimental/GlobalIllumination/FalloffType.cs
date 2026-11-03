namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x200040C")]
public enum FalloffType : byte
{
	InverseSquared = 0,
	InverseSquaredNoRangeAttenuation = 1,
	Linear = 2,
	Legacy = 3,
	Undefined = 4,
}

