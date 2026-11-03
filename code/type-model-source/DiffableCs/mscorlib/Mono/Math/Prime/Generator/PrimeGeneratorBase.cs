namespace Mono.Math.Prime.Generator;

[Token(Token = "0x2000072")]
internal abstract class PrimeGeneratorBase
{

	[Token(Token = "0x1700002C")]
	public override ConfidenceFactor Confidence
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002D")]
	public override PrimalityTest PrimalityTest
	{
		[Address(RVA = "0x1E77810", Offset = "0x1E76C10", Length = "0x134")]
		[Token(Token = "0x60001E7")]
		 get { } //Length: 308
	}

	[Token(Token = "0x1700002E")]
	public override int TrialDivisionBounds
	{
		[Address(RVA = "0x1E541F0", Offset = "0x1E535F0", Length = "0x6")]
		[Token(Token = "0x60001E8")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001EA")]
	protected PrimeGeneratorBase() { }

	[Token(Token = "0x60001E9")]
	public abstract BigInteger GenerateNewPrime(int bits) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60001E6")]
	public override ConfidenceFactor get_Confidence() { }

	[Address(RVA = "0x1E77810", Offset = "0x1E76C10", Length = "0x134")]
	[Token(Token = "0x60001E7")]
	public override PrimalityTest get_PrimalityTest() { }

	[Address(RVA = "0x1E541F0", Offset = "0x1E535F0", Length = "0x6")]
	[Token(Token = "0x60001E8")]
	public override int get_TrialDivisionBounds() { }

}

