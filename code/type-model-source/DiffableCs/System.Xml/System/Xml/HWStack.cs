namespace System.Xml;

[DefaultMember("Item")]
[Token(Token = "0x20000B2")]
internal class HWStack : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B0")]
	private Object[] stack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B1")]
	private int growthRate; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004B2")]
	private int used; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B3")]
	private int size; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004B4")]
	private int limit; //Field offset: 0x24

	[Token(Token = "0x170002B5")]
	internal object Item
	{
		[Address(RVA = "0x2536080", Offset = "0x2535480", Length = "0x75")]
		[Token(Token = "0x60009DD")]
		internal get { } //Length: 117
		[Address(RVA = "0x2536100", Offset = "0x2535500", Length = "0xC1")]
		[Token(Token = "0x60009DE")]
		internal set { } //Length: 193
	}

	[Token(Token = "0x170002B6")]
	internal int Length
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60009DF")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x2536000", Offset = "0x2535400", Length = "0x72")]
	[Token(Token = "0x60009D7")]
	internal HWStack(int GrowthRate) { }

	[Address(RVA = "0x2535F80", Offset = "0x2535380", Length = "0x7B")]
	[Token(Token = "0x60009D8")]
	internal HWStack(int GrowthRate, int limit) { }

	[Address(RVA = "0x2535F20", Offset = "0x2535320", Length = "0x59")]
	[Token(Token = "0x60009E0")]
	private HWStack(Object[] stack, int growthRate, int used, int size) { }

	[Address(RVA = "0x2535BD0", Offset = "0x2534FD0", Length = "0x87")]
	[Token(Token = "0x60009DC")]
	internal void AddToTop(object o) { }

	[Address(RVA = "0x2535C60", Offset = "0x2535060", Length = "0x102")]
	[Token(Token = "0x60009E1")]
	public override object Clone() { }

	[Address(RVA = "0x2536080", Offset = "0x2535480", Length = "0x75")]
	[Token(Token = "0x60009DD")]
	internal object get_Item(int index) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60009DF")]
	internal int get_Length() { }

	[Address(RVA = "0x2535D70", Offset = "0x2535170", Length = "0x3A")]
	[Token(Token = "0x60009DB")]
	internal object Peek() { }

	[Address(RVA = "0x2535DB0", Offset = "0x25351B0", Length = "0x3F")]
	[Token(Token = "0x60009DA")]
	internal object Pop() { }

	[Address(RVA = "0x2535DF0", Offset = "0x25351F0", Length = "0x121")]
	[Token(Token = "0x60009D9")]
	internal object Push() { }

	[Address(RVA = "0x2536100", Offset = "0x2535500", Length = "0xC1")]
	[Token(Token = "0x60009DE")]
	internal void set_Item(int index, object value) { }

}

