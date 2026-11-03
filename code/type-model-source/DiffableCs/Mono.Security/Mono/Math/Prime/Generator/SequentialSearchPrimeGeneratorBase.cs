namespace Mono.Math.Prime.Generator;

[Token(Token = "0x200005D")]
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600022C")]
	public SequentialSearchPrimeGeneratorBase() { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000229")]
	public virtual BigInteger GenerateNewPrime(int bits) { }

	[Address(RVA = "0x1E57990", Offset = "0x1E56D90", Length = "0x3CD")]
	[Token(Token = "0x600022A")]
	public override BigInteger GenerateNewPrime(int bits, object context) { }

	[Address(RVA = "0x1E57D80", Offset = "0x1E57180", Length = "0x71")]
	[Token(Token = "0x6000228")]
	protected override BigInteger GenerateSearchBase(int bits, object context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600022B")]
	protected override bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

