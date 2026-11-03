namespace KANAI.Unsafe;

[Token(Token = "0x2000008")]
public class ProtectDouble
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000C")]
	private double _value; //Field offset: 0x10

	[Token(Token = "0x17000008")]
	public double KeepValue
	{
		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000007")]
	public double Value
	{
		[Address(RVA = "0x1E2A360", Offset = "0x1E29760", Length = "0x9C")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 156
		[Address(RVA = "0x1E2A400", Offset = "0x1E29800", Length = "0x99")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 153
	}

	[Address(RVA = "0x1E2A2C0", Offset = "0x1E296C0", Length = "0xA0")]
	[Token(Token = "0x600001B")]
	public ProtectDouble(double v) { }

	[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
	[Token(Token = "0x600001E")]
	public double get_KeepValue() { }

	[Address(RVA = "0x1E2A360", Offset = "0x1E29760", Length = "0x9C")]
	[Token(Token = "0x600001C")]
	public double get_Value() { }

	[Address(RVA = "0x1E2A400", Offset = "0x1E29800", Length = "0x99")]
	[Token(Token = "0x600001D")]
	public void set_Value(double value) { }

}

