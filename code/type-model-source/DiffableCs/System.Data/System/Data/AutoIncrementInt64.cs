namespace System.Data;

[Token(Token = "0x200000B")]
internal sealed class AutoIncrementInt64 : AutoIncrementValue
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002D")]
	private long _current; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	private long _seed; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002F")]
	private long _step; //Field offset: 0x28

	[Token(Token = "0x17000030")]
	internal virtual object Current
	{
		[Address(RVA = "0x22ED520", Offset = "0x22EC920", Length = "0x23")]
		[Token(Token = "0x600008A")]
		internal get { } //Length: 35
		[Address(RVA = "0x22ED590", Offset = "0x22EC990", Length = "0x45")]
		[Token(Token = "0x600008B")]
		internal set { } //Length: 69
	}

	[Token(Token = "0x17000031")]
	internal virtual Type DataType
	{
		[Address(RVA = "0x22ED550", Offset = "0x22EC950", Length = "0x32")]
		[Token(Token = "0x600008C")]
		internal get { } //Length: 50
	}

	[Token(Token = "0x17000032")]
	internal virtual long Seed
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600008D")]
		internal get { } //Length: 5
		[Address(RVA = "0x22ED5E0", Offset = "0x22EC9E0", Length = "0x8A")]
		[Token(Token = "0x600008E")]
		internal set { } //Length: 138
	}

	[Token(Token = "0x17000033")]
	internal virtual long Step
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600008F")]
		internal get { } //Length: 5
		[Address(RVA = "0x22ED670", Offset = "0x22ECA70", Length = "0x80")]
		[Token(Token = "0x6000090")]
		internal set { } //Length: 128
	}

	[Address(RVA = "0x22ED510", Offset = "0x22EC910", Length = "0xF")]
	[Token(Token = "0x6000095")]
	public AutoIncrementInt64() { }

	[Address(RVA = "0x22ED290", Offset = "0x22EC690", Length = "0xCF")]
	[Token(Token = "0x6000094")]
	private bool BoundaryCheck(BigInteger value) { }

	[Address(RVA = "0x22ED520", Offset = "0x22EC920", Length = "0x23")]
	[Token(Token = "0x600008A")]
	internal virtual object get_Current() { }

	[Address(RVA = "0x22ED550", Offset = "0x22EC950", Length = "0x32")]
	[Token(Token = "0x600008C")]
	internal virtual Type get_DataType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600008D")]
	internal virtual long get_Seed() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600008F")]
	internal virtual long get_Step() { }

	[Address(RVA = "0x22ED360", Offset = "0x22EC760", Length = "0x9")]
	[Token(Token = "0x6000091")]
	internal virtual void MoveAfter() { }

	[Address(RVA = "0x22ED590", Offset = "0x22EC990", Length = "0x45")]
	[Token(Token = "0x600008B")]
	internal virtual void set_Current(object value) { }

	[Address(RVA = "0x22ED5E0", Offset = "0x22EC9E0", Length = "0x8A")]
	[Token(Token = "0x600008E")]
	internal virtual void set_Seed(long value) { }

	[Address(RVA = "0x22ED670", Offset = "0x22ECA70", Length = "0x80")]
	[Token(Token = "0x6000090")]
	internal virtual void set_Step(long value) { }

	[Address(RVA = "0x22ED4A0", Offset = "0x22EC8A0", Length = "0x6B")]
	[Token(Token = "0x6000092")]
	internal virtual void SetCurrent(object value, IFormatProvider formatProvider) { }

	[Address(RVA = "0x22ED370", Offset = "0x22EC770", Length = "0x12D")]
	[Token(Token = "0x6000093")]
	internal virtual void SetCurrentAndIncrement(object value) { }

}

