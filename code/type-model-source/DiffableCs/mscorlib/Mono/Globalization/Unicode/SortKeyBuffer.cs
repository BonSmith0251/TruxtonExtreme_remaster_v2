namespace Mono.Globalization.Unicode;

[Token(Token = "0x200005C")]
internal class SortKeyBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A1")]
	private Byte[] l1b; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A2")]
	private Byte[] l2b; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A3")]
	private Byte[] l3b; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A4")]
	private Byte[] l4sb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001A5")]
	private Byte[] l4tb; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001A6")]
	private Byte[] l4kb; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A7")]
	private Byte[] l4wb; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A8")]
	private Byte[] l5b; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A9")]
	private string source; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001AA")]
	private int l1; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001AB")]
	private int l2; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001AC")]
	private int l3; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001AD")]
	private int l4s; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001AE")]
	private int l4t; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40001AF")]
	private int l4k; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001B0")]
	private int l4w; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001B1")]
	private int l5; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001B2")]
	private int lcid; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40001B3")]
	private CompareOptions options; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001B4")]
	private bool processLevel2; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x40001B5")]
	private bool frenchSort; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x40001B6")]
	private bool frenchSorted; //Field offset: 0x82

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000104")]
	public SortKeyBuffer(int lcid) { }

	[Address(RVA = "0x1E6D920", Offset = "0x1E6CD20", Length = "0xB5")]
	[Token(Token = "0x600010B")]
	private void AppendBufferPrimitive(byte value, ref Byte[] buf, ref int bidx) { }

	[Address(RVA = "0x1E6D9E0", Offset = "0x1E6CDE0", Length = "0xC8")]
	[Token(Token = "0x6000107")]
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	[Address(RVA = "0x1E6DAB0", Offset = "0x1E6CEB0", Length = "0xC0")]
	[Token(Token = "0x6000108")]
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	[Address(RVA = "0x1E6DB80", Offset = "0x1E6CF80", Length = "0xD1")]
	[Token(Token = "0x600010A")]
	private void AppendLevel5(byte category, byte lv1) { }

	[Address(RVA = "0x1E6DC60", Offset = "0x1E6D060", Length = "0x1E6")]
	[Token(Token = "0x6000109")]
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	[Address(RVA = "0x1E6DE50", Offset = "0x1E6D250", Length = "0x4C")]
	[Token(Token = "0x600010D")]
	private int GetOptimizedLength(Byte[] data, int len, byte defaultValue) { }

	[Address(RVA = "0x1E6DED0", Offset = "0x1E6D2D0", Length = "0x692")]
	[Token(Token = "0x600010E")]
	public SortKey GetResult() { }

	[Address(RVA = "0x1E6DEA0", Offset = "0x1E6D2A0", Length = "0x2E")]
	[Token(Token = "0x600010C")]
	public SortKey GetResultAndReset() { }

	[Address(RVA = "0x1E6E570", Offset = "0x1E6D970", Length = "0x1F4")]
	[Token(Token = "0x6000106")]
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	[Address(RVA = "0x1E6E770", Offset = "0x1E6DB70", Length = "0x19")]
	[Token(Token = "0x6000105")]
	public void Reset() { }

}

