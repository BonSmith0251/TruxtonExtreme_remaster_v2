namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000016")]
public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken>
{
	[Token(Token = "0x400004C")]
	public static readonly IEqualityComparer<CancellationToken> Default; //Field offset: 0x0

	[Address(RVA = "0x2730780", Offset = "0x272FB80", Length = "0x67")]
	[Token(Token = "0x6000088")]
	private static CancellationTokenEqualityComparer() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000087")]
	public CancellationTokenEqualityComparer() { }

	[Address(RVA = "0x27306D0", Offset = "0x272FAD0", Length = "0x54")]
	[Token(Token = "0x6000085")]
	public override bool Equals(CancellationToken x, CancellationToken y) { }

	[Address(RVA = "0x2730730", Offset = "0x272FB30", Length = "0x4B")]
	[Token(Token = "0x6000086")]
	public override int GetHashCode(CancellationToken obj) { }

}

