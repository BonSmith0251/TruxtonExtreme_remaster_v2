namespace System.Xml.Linq;

[Token(Token = "0x2000011")]
internal sealed class XHashtable
{
	[Token(Token = "0x2000012")]
	internal sealed class ExtractKeyDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1BB1770", Offset = "0x1BB0B70", Length = "0x124")]
		[Token(Token = "0x6000087")]
		public ExtractKeyDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000088")]
		public override string Invoke(TValue value) { }

	}

	[Token(Token = "0x2000013")]
	private sealed class XHashtableState
	{
		[Token(Token = "0x2000014")]
		private struct Entry
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000029")]
			public TValue Value; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400002A")]
			public int HashCode; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400002B")]
			public int Next; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		private Int32[] _buckets; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private Entry<TValue>[] _entries; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		private int _numEntries; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		private ExtractKeyDelegate<TValue> _extractKey; //Field offset: 0x0

		[Address(RVA = "0x1550770", Offset = "0x154FB70", Length = "0xC2")]
		[Token(Token = "0x6000089")]
		public XHashtableState(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

		[Address(RVA = "0x154EF10", Offset = "0x154E310", Length = "0x7F")]
		[Token(Token = "0x600008E")]
		private static int ComputeHashCode(string key, int index, int count) { }

		[Address(RVA = "0x154EF90", Offset = "0x154E390", Length = "0x1C8")]
		[Token(Token = "0x600008D")]
		private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }

		[Address(RVA = "0x154FAD0", Offset = "0x154EED0", Length = "0x2F5")]
		[Token(Token = "0x600008A")]
		public XHashtableState<TValue> Resize() { }

		[Address(RVA = "0x1550230", Offset = "0x154F630", Length = "0x257")]
		[Token(Token = "0x600008C")]
		public bool TryAdd(TValue value, out TValue newValue) { }

		[Address(RVA = "0x1550490", Offset = "0x154F890", Length = "0x127")]
		[Token(Token = "0x600008B")]
		public bool TryGetValue(string key, int index, int count, out TValue value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private XHashtableState<TValue> _state; //Field offset: 0x0

	[Address(RVA = "0x1550E90", Offset = "0x1550290", Length = "0x9F")]
	[Token(Token = "0x6000084")]
	public XHashtable`1(ExtractKeyDelegate<TValue> extractKey, int capacity) { }

	[Address(RVA = "0x1550910", Offset = "0x154FD10", Length = "0x117")]
	[Token(Token = "0x6000086")]
	public TValue Add(TValue value) { }

	[Address(RVA = "0x1550C90", Offset = "0x1550090", Length = "0x155")]
	[Token(Token = "0x6000085")]
	public bool TryGetValue(string key, int index, int count, out TValue value) { }

}

