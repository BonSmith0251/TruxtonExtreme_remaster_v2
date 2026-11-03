namespace Mono;

[Token(Token = "0x2000034")]
internal struct RuntimePropertyHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010B")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x1700000A")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600005A")]
	internal RuntimePropertyHandle(IntPtr v) { }

	[Address(RVA = "0x1E647D0", Offset = "0x1E63BD0", Length = "0xE5")]
	[Token(Token = "0x600005C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600005B")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x600005D")]
	public virtual int GetHashCode() { }

}

