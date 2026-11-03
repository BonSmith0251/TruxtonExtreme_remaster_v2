namespace TMPro;

[Token(Token = "0x200001F")]
public static class TMP_Math
{
	[Token(Token = "0x40000B4")]
	public const float FLOAT_MAX = 32767; //Field offset: 0x0
	[Token(Token = "0x40000B5")]
	public const float FLOAT_MIN = -32767; //Field offset: 0x0
	[Token(Token = "0x40000B6")]
	public const int INT_MAX = 2147483647; //Field offset: 0x0
	[Token(Token = "0x40000B7")]
	public const int INT_MIN = -2147483647; //Field offset: 0x0
	[Token(Token = "0x40000B8")]
	public const float FLOAT_UNSET = -32767; //Field offset: 0x0
	[Token(Token = "0x40000B9")]
	public const int INT_UNSET = -32767; //Field offset: 0x0
	[Token(Token = "0x40000BA")]
	public static Vector2 MAX_16BIT; //Field offset: 0x0
	[Token(Token = "0x40000BB")]
	public static Vector2 MIN_16BIT; //Field offset: 0x8

	[Address(RVA = "0x2EC39A0", Offset = "0x2EC2DA0", Length = "0x5C")]
	[Token(Token = "0x600013B")]
	private static TMP_Math() { }

	[Address(RVA = "0x2EC3950", Offset = "0x2EC2D50", Length = "0x22")]
	[Token(Token = "0x6000139")]
	public static bool Approximately(float a, float b) { }

	[Address(RVA = "0x2EC3980", Offset = "0x2EC2D80", Length = "0x15")]
	[Token(Token = "0x600013A")]
	public static int Mod(int a, int b) { }

}

