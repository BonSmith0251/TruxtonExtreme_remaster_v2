namespace TMPro;

[Token(Token = "0x2000033")]
public static class TMP_Compatibility
{
	[Token(Token = "0x2000034")]
	internal enum AnchorPositions : int
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
		BaseLine = 9,
		None = 10,
	}


	[Address(RVA = "0x2EAFA90", Offset = "0x2EAEE90", Length = "0xB0")]
	[Token(Token = "0x600017A")]
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }

}

