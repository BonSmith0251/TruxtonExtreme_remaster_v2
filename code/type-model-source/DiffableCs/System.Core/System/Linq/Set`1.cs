namespace System.Linq;

[Token(Token = "0x2000038")]
internal class Set
{
	[Token(Token = "0x2000039")]
	public struct Slot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A8")]
		internal int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A9")]
		internal TElement value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AA")]
		internal int next; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A3")]
	private Int32[] buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A4")]
	private Slot<TElement>[] slots; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A5")]
	private int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A6")]
	private int freeList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A7")]
	private IEqualityComparer<TElement> comparer; //Field offset: 0x0

	[Address(RVA = "0xF5E050", Offset = "0xF5D450", Length = "0x1D7")]
	[Token(Token = "0x6000166")]
	public Set`1(IEqualityComparer<TElement> comparer) { }

	[Address(RVA = "0xF5D970", Offset = "0xF5CD70", Length = "0x22")]
	[Token(Token = "0x6000167")]
	public bool Add(TElement value) { }

	[Address(RVA = "0xF5D9A0", Offset = "0xF5CDA0", Length = "0x453")]
	[Token(Token = "0x6000168")]
	private bool Find(TElement value, bool add) { }

	[Address(RVA = "0xF5DE00", Offset = "0xF5D200", Length = "0xC5")]
	[Token(Token = "0x600016A")]
	internal int InternalGetHashCode(TElement value) { }

	[Address(RVA = "0xF5DED0", Offset = "0xF5D2D0", Length = "0x176")]
	[Token(Token = "0x6000169")]
	private void Resize() { }

}

