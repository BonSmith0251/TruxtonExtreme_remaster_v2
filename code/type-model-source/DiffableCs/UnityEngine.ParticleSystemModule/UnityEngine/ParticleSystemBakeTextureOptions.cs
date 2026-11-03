namespace UnityEngine;

[Flags]
[Token(Token = "0x2000039")]
public enum ParticleSystemBakeTextureOptions : int
{
	BakeRotationAndScale = 1,
	BakePosition = 2,
	PerVertex = 4,
	PerParticle = 8,
	IncludeParticleIndices = 16,
	Default = 4,
}

