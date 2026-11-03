namespace KANAI.Unsafe;

[Token(Token = "0x2000007")]
public class ProtectFloat
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private float _value; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public float KeepValue
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public float Value
	{
		[Address(RVA = "0x1E2A540", Offset = "0x1E29940", Length = "0x99")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 153
		[Address(RVA = "0x1E2A5E0", Offset = "0x1E299E0", Length = "0x96")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 150
	}

	[Address(RVA = "0x1E2A4A0", Offset = "0x1E298A0", Length = "0x9D")]
	[Token(Token = "0x6000017")]
	public ProtectFloat(float v) { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x600001A")]
	public float get_KeepValue() { }

	[Address(RVA = "0x1E2A540", Offset = "0x1E29940", Length = "0x99")]
	[Token(Token = "0x6000018")]
	public float get_Value() { }

	[Address(RVA = "0x1E2A5E0", Offset = "0x1E299E0", Length = "0x96")]
	[Token(Token = "0x6000019")]
	public void set_Value(float value) { }

}

