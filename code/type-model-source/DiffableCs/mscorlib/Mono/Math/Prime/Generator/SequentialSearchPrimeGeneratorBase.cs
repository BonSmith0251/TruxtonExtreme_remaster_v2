namespace Mono.Math.Prime.Generator;

[Token(Token = "0x2000073")]
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001EF")]
	public SequentialSearchPrimeGeneratorBase() { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x60001EC")]
	public virtual BigInteger GenerateNewPrime(int bits) { }

	[Address(RVA = "0x1E7CB50", Offset = "0x1E7BF50", Length = "0x3CD")]
	[Token(Token = "0x60001ED")]
	public override BigInteger GenerateNewPrime(int bits, object context) { }

	[Address(RVA = "0x1E7CF20", Offset = "0x1E7C320", Length = "0xAD")]
	[Token(Token = "0x60001EB")]
	protected override BigInteger GenerateSearchBase(int bits, object context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001EE")]
	protected override bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

