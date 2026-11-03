namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x200000B")]
[UsedByNativeCode]
public enum GlyphPackingMode : int
{
	BestShortSideFit = 0,
	BestLongSideFit = 1,
	BestAreaFit = 2,
	BottomLeftRule = 3,
	ContactPointRule = 4,
}

