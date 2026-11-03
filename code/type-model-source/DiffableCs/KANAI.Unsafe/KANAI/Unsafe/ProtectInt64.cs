namespace KANAI.Unsafe;

[Token(Token = "0x2000006")]
public class ProtectInt64
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	private long _value; //Field offset: 0x10

	[Token(Token = "0x17000004")]
	public long KeepValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public long Value
	{
		[Address(RVA = "0x1E2A8E0", Offset = "0x1E29CE0", Length = "0x8A")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 138
		[Address(RVA = "0x1E2A970", Offset = "0x1E29D70", Length = "0x93")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 147
	}

	[Address(RVA = "0x1E2A840", Offset = "0x1E29C40", Length = "0x9A")]
	[Token(Token = "0x6000013")]
	public ProtectInt64(long v) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000016")]
	public long get_KeepValue() { }

	[Address(RVA = "0x1E2A8E0", Offset = "0x1E29CE0", Length = "0x8A")]
	[Token(Token = "0x6000014")]
	public long get_Value() { }

	[Address(RVA = "0x1E2A970", Offset = "0x1E29D70", Length = "0x93")]
	[Token(Token = "0x6000015")]
	public void set_Value(long value) { }

}

