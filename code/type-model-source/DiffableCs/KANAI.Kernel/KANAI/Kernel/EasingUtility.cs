namespace KANAI.Kernel;

[Token(Token = "0x2000019")]
public static class EasingUtility
{
	[Token(Token = "0x200001A")]
	internal enum EasingType : int
	{
		None = -1,
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		EaseOutIn = 4,
		EaseInSine = 5,
		EaseOutSine = 6,
		EaseInOutSine = 7,
		EaseOutInSine = 8,
		EaseInOutQubic = 9,
		EaseOutInQubic = 10,
		EaseInOutQuart = 11,
		EaseOutInQuart = 12,
	}


	[Address(RVA = "0x1DE8000", Offset = "0x1DE7400", Length = "0x14")]
	[Token(Token = "0x60000E0")]
	public static float EaseIn(float start, float end, float v) { }

	[Address(RVA = "0x1DE7ED0", Offset = "0x1DE72D0", Length = "0xCA")]
	[Token(Token = "0x60000E3")]
	public static float EaseInBounce01(float v) { }

	[Address(RVA = "0x1DE7FA0", Offset = "0x1DE73A0", Length = "0x5F")]
	[Token(Token = "0x60000E2")]
	public static float EaseInOut(float start, float end, float v) { }

	[Address(RVA = "0x1DE80D0", Offset = "0x1DE74D0", Length = "0x23")]
	[Token(Token = "0x60000E1")]
	public static float EaseOut(float start, float end, float v) { }

	[Address(RVA = "0x1DE8020", Offset = "0x1DE7420", Length = "0xA3")]
	[Token(Token = "0x60000E4")]
	public static float EaseOutBounce01(float v) { }

	[Address(RVA = "0x1DE8100", Offset = "0x1DE7500", Length = "0x4BC")]
	[Token(Token = "0x60000CE")]
	public static float Easing01(float v, EasingType _easingType) { }

	[Address(RVA = "0x1DE85F0", Offset = "0x1DE79F0", Length = "0xC")]
	[Token(Token = "0x60000D0")]
	public static float InCubic01(float v) { }

	[Address(RVA = "0x1DE8600", Offset = "0x1DE7A00", Length = "0x4B")]
	[Token(Token = "0x60000DA")]
	public static float InOutCubic01(float v) { }

	[Address(RVA = "0x1DE8650", Offset = "0x1DE7A50", Length = "0x40")]
	[Token(Token = "0x60000D9")]
	public static float InOutQuad01(float v) { }

	[Address(RVA = "0x1DE8690", Offset = "0x1DE7A90", Length = "0x53")]
	[Token(Token = "0x60000DB")]
	public static float InOutQuart01(float v) { }

	[Address(RVA = "0x1DE86F0", Offset = "0x1DE7AF0", Length = "0x124")]
	[Token(Token = "0x60000D7")]
	public static float InOutSine01(float v) { }

	[Address(RVA = "0x1DE8820", Offset = "0x1DE7C20", Length = "0x5")]
	[Token(Token = "0x60000CF")]
	public static float InQuad01(float v) { }

	[Address(RVA = "0x1DE8830", Offset = "0x1DE7C30", Length = "0x10")]
	[Token(Token = "0x60000D1")]
	public static float InQuart01(float v) { }

	[Address(RVA = "0x1DE8840", Offset = "0x1DE7C40", Length = "0x68")]
	[Token(Token = "0x60000D5")]
	public static float InSine01(float v) { }

	[Address(RVA = "0x1DE88B0", Offset = "0x1DE7CB0", Length = "0x3B")]
	[Token(Token = "0x60000DF")]
	public static float Linear(float start, float end, float v) { }

	[Address(RVA = "0x1DE88F0", Offset = "0x1DE7CF0", Length = "0x22")]
	[Token(Token = "0x60000D3")]
	public static float OutCubic01(float v) { }

	[Address(RVA = "0x1DE8920", Offset = "0x1DE7D20", Length = "0x61")]
	[Token(Token = "0x60000DD")]
	public static float OutInCubic01(float v) { }

	[Address(RVA = "0x1DE8990", Offset = "0x1DE7D90", Length = "0x53")]
	[Token(Token = "0x60000DC")]
	public static float OutInQuad01(float v) { }

	[Address(RVA = "0x1DE89F0", Offset = "0x1DE7DF0", Length = "0x6C")]
	[Token(Token = "0x60000DE")]
	public static float OutInQuart01(float v) { }

	[Address(RVA = "0x1DE8A60", Offset = "0x1DE7E60", Length = "0x10D")]
	[Token(Token = "0x60000D8")]
	public static float OutInSine01(float v) { }

	[Address(RVA = "0x1DE8B70", Offset = "0x1DE7F70", Length = "0x1B")]
	[Token(Token = "0x60000D2")]
	public static float OutQuad01(float v) { }

	[Address(RVA = "0x1DE8B90", Offset = "0x1DE7F90", Length = "0x26")]
	[Token(Token = "0x60000D4")]
	public static float OutQuart01(float v) { }

	[Address(RVA = "0x1DE8BC0", Offset = "0x1DE7FC0", Length = "0x58")]
	[Token(Token = "0x60000D6")]
	public static float OutSine01(float v) { }

	[Address(RVA = "0x1DE8C20", Offset = "0x1DE8020", Length = "0x4D")]
	[Token(Token = "0x60000E5")]
	public static float PinPong(float vrate) { }

}

