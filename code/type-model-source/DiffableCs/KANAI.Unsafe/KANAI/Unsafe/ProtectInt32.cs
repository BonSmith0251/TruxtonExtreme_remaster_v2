namespace KANAI.Unsafe;

[Token(Token = "0x2000005")]
public class ProtectInt32
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	private int _value; //Field offset: 0x10

	[Token(Token = "0x17000002")]
	public int KeepValue
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000001")]
	public int Value
	{
		[Address(RVA = "0x1E2A720", Offset = "0x1E29B20", Length = "0x86")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 134
		[Address(RVA = "0x1E2A7B0", Offset = "0x1E29BB0", Length = "0x8F")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 143
	}

	[Address(RVA = "0x1E2A680", Offset = "0x1E29A80", Length = "0x96")]
	[Token(Token = "0x600000F")]
	public ProtectInt32(int v) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000012")]
	public int get_KeepValue() { }

	[Address(RVA = "0x1E2A720", Offset = "0x1E29B20", Length = "0x86")]
	[Token(Token = "0x6000010")]
	public int get_Value() { }

	[Address(RVA = "0x1E2A7B0", Offset = "0x1E29BB0", Length = "0x8F")]
	[Token(Token = "0x6000011")]
	public void set_Value(int value) { }

}

