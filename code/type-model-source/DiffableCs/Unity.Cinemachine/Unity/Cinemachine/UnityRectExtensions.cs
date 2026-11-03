namespace Unity.Cinemachine;

[Extension]
[Token(Token = "0x20000F6")]
public static class UnityRectExtensions
{

	[Address(RVA = "0x2866AC0", Offset = "0x2865EC0", Length = "0x15A")]
	[Extension]
	[Token(Token = "0x600048F")]
	public static Rect Inflated(Rect r, Vector2 delta) { }

}

