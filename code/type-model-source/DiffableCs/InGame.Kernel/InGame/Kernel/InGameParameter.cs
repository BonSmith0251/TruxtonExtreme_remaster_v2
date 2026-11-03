namespace InGame.Kernel;

[Token(Token = "0x200007E")]
public static class InGameParameter
{
	[Token(Token = "0x400041C")]
	private static readonly Single[] toleDamageRates; //Field offset: 0x0

	[Address(RVA = "0x1D1ED60", Offset = "0x1D1E160", Length = "0x8C")]
	[Token(Token = "0x60004E6")]
	private static InGameParameter() { }

	[Address(RVA = "0x1D1ECC0", Offset = "0x1D1E0C0", Length = "0x6F")]
	[Token(Token = "0x60004E5")]
	public static float GetDamageRate(toleType tt) { }

	[Address(RVA = "0x1D1ED30", Offset = "0x1D1E130", Length = "0x25")]
	[Token(Token = "0x60004E4")]
	public static float GetScoreRate(toleType tt) { }

}

