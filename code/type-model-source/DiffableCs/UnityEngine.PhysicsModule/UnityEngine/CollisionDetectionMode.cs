namespace UnityEngine;

[Token(Token = "0x2000004")]
public enum CollisionDetectionMode : int
{
	Discrete = 0,
	Continuous = 1,
	ContinuousDynamic = 2,
	ContinuousSpeculative = 3,
}

