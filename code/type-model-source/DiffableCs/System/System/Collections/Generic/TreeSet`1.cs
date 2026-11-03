namespace System.Collections.Generic;

[Token(Token = "0x2000200")]
internal sealed class TreeSet : SortedSet<T>
{

	[Address(RVA = "0x109CB00", Offset = "0x109BF00", Length = "0x13")]
	[Token(Token = "0x6000D0F")]
	public TreeSet`1() { }

	[Address(RVA = "0x109CAB0", Offset = "0x109BEB0", Length = "0x14")]
	[Token(Token = "0x6000D10")]
	public TreeSet`1(IComparer<T> comparer) { }

	[Address(RVA = "0x109CAD0", Offset = "0x109BED0", Length = "0x2B")]
	[Token(Token = "0x6000D11")]
	public TreeSet`1(SerializationInfo siInfo, StreamingContext context) { }

	[Address(RVA = "0x109C9D0", Offset = "0x109BDD0", Length = "0xD2")]
	[Token(Token = "0x6000D12")]
	internal virtual bool AddIfNotPresent(T item) { }

}

