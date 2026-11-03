namespace UnityEngine.Rendering;

[Token(Token = "0x2000144")]
internal static class ProbeVolumeUtil
{

	[Address(RVA = "0x2C30F80", Offset = "0x2C30380", Length = "0x39")]
	[Token(Token = "0x6000ADA")]
	internal static float BrickSize(float minBrickSize, int subdivisionLevel) { }

	[Address(RVA = "0x2C16B00", Offset = "0x2C15F00", Length = "0x21")]
	[Token(Token = "0x6000AD9")]
	internal static int CellSize(int subdivisionLevel) { }

	[Address(RVA = "0x2C30FC0", Offset = "0x2C303C0", Length = "0x3C")]
	[Token(Token = "0x6000ADB")]
	internal static float MaxBrickSize(float minBrickSize, int maxSubDivision) { }

}

