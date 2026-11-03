namespace System.Data;

[Token(Token = "0x200000A")]
internal abstract class AutoIncrementValue
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002C")]
	private bool <Auto>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700002B")]
	internal bool Auto
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	internal abstract object Current
	{
		[Token(Token = "0x600007E")]
		internal get { } //Length: 0
		[Token(Token = "0x600007F")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	internal abstract Type DataType
	{
		[Token(Token = "0x6000084")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700002D")]
	internal abstract long Seed
	{
		[Token(Token = "0x6000080")]
		internal get { } //Length: 0
		[Token(Token = "0x6000081")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700002E")]
	internal abstract long Step
	{
		[Token(Token = "0x6000082")]
		internal get { } //Length: 0
		[Token(Token = "0x6000083")]
		internal set { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000089")]
	protected AutoIncrementValue() { }

	[Address(RVA = "0x22ED700", Offset = "0x22ECB00", Length = "0x136")]
	[Token(Token = "0x6000088")]
	internal AutoIncrementValue Clone() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	internal bool get_Auto() { }

	[Token(Token = "0x600007E")]
	internal abstract object get_Current() { }

	[Token(Token = "0x6000084")]
	internal abstract Type get_DataType() { }

	[Token(Token = "0x6000080")]
	internal abstract long get_Seed() { }

	[Token(Token = "0x6000082")]
	internal abstract long get_Step() { }

	[Token(Token = "0x6000087")]
	internal abstract void MoveAfter() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007D")]
	internal void set_Auto(bool value) { }

	[Token(Token = "0x600007F")]
	internal abstract void set_Current(object value) { }

	[Token(Token = "0x6000081")]
	internal abstract void set_Seed(long value) { }

	[Token(Token = "0x6000083")]
	internal abstract void set_Step(long value) { }

	[Token(Token = "0x6000085")]
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider) { }

	[Token(Token = "0x6000086")]
	internal abstract void SetCurrentAndIncrement(object value) { }

}

