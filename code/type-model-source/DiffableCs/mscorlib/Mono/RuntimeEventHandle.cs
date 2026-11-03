namespace Mono;

[Token(Token = "0x2000033")]
internal struct RuntimeEventHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010A")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x17000009")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000057")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000056")]
	internal RuntimeEventHandle(IntPtr v) { }

	[Address(RVA = "0x1E64170", Offset = "0x1E63570", Length = "0xE5")]
	[Token(Token = "0x6000058")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000057")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000059")]
	public virtual int GetHashCode() { }

}

