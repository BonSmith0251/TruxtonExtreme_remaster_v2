namespace UnityEngine;

[Token(Token = "0x2000091")]
public enum WrapMode : int
{
	Once = 1,
	Loop = 2,
	PingPong = 4,
	Default = 0,
	ClampForever = 8,
	Clamp = 1,
}

