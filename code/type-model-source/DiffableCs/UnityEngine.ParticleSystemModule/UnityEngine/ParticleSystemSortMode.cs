namespace UnityEngine;

[Token(Token = "0x200002E")]
public enum ParticleSystemSortMode : int
{
	None = 0,
	Distance = 1,
	OldestInFront = 2,
	YoungestInFront = 3,
	Depth = 4,
	DistanceReverse = 5,
	DepthReverse = 6,
}

