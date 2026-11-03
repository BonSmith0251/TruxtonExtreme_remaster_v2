namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000051")]
internal class ContractionComparer : IComparer<Contraction>
{
	[Token(Token = "0x400015D")]
	public static readonly ContractionComparer Instance; //Field offset: 0x0

	[Address(RVA = "0x1E5C1A0", Offset = "0x1E5B5A0", Length = "0x67")]
	[Token(Token = "0x60000B4")]
	private static ContractionComparer() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B3")]
	public ContractionComparer() { }

	[Address(RVA = "0x1E5C0A0", Offset = "0x1E5B4A0", Length = "0xF8")]
	[Token(Token = "0x60000B2")]
	public override int Compare(Contraction c1, Contraction c2) { }

}

