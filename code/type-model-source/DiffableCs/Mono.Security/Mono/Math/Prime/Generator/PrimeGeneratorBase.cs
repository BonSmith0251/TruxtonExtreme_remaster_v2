namespace Mono.Math.Prime.Generator;

[Token(Token = "0x200005C")]
public abstract class PrimeGeneratorBase
{

	[Token(Token = "0x17000087")]
	public override ConfidenceFactor Confidence
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000223")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000088")]
	public override PrimalityTest PrimalityTest
	{
		[Address(RVA = "0x1E540B0", Offset = "0x1E534B0", Length = "0x134")]
		[Token(Token = "0x6000224")]
		 get { } //Length: 308
	}

	[Token(Token = "0x17000089")]
	public override int TrialDivisionBounds
	{
		[Address(RVA = "0x1E541F0", Offset = "0x1E535F0", Length = "0x6")]
		[Token(Token = "0x6000225")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000227")]
	protected PrimeGeneratorBase() { }

	[Token(Token = "0x6000226")]
	public abstract BigInteger GenerateNewPrime(int bits) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000223")]
	public override ConfidenceFactor get_Confidence() { }

	[Address(RVA = "0x1E540B0", Offset = "0x1E534B0", Length = "0x134")]
	[Token(Token = "0x6000224")]
	public override PrimalityTest get_PrimalityTest() { }

	[Address(RVA = "0x1E541F0", Offset = "0x1E535F0", Length = "0x6")]
	[Token(Token = "0x6000225")]
	public override int get_TrialDivisionBounds() { }

}

