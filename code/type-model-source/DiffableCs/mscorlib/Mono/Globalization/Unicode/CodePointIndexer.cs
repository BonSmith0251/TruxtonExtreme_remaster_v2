namespace Mono.Globalization.Unicode;

[Token(Token = "0x200004D")]
internal class CodePointIndexer
{
	[Token(Token = "0x200004E")]
	public struct TableRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000150")]
		public readonly int Start; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000151")]
		public readonly int End; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000152")]
		public readonly int Count; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000153")]
		public readonly int IndexStart; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000154")]
		public readonly int IndexEnd; //Field offset: 0x10

		[Address(RVA = "0x1E6E8F0", Offset = "0x1E6DCF0", Length = "0x1D")]
		[Token(Token = "0x60000AF")]
		public TableRange(int start, int end, int indexStart) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014C")]
	private readonly TableRange[] ranges; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014D")]
	public readonly int TotalCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400014E")]
	private int defaultIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014F")]
	private int defaultCP; //Field offset: 0x20

	[Address(RVA = "0x1E5BEB0", Offset = "0x1E5B2B0", Length = "0x1B3")]
	[Token(Token = "0x60000AD")]
	public CodePointIndexer(Int32[] starts, Int32[] ends, int defaultIndex, int defaultCP) { }

	[Address(RVA = "0x1E5BE30", Offset = "0x1E5B230", Length = "0x76")]
	[Token(Token = "0x60000AE")]
	public int ToIndex(int cp) { }

}

