namespace TMPro;

[Token(Token = "0x200000A")]
public struct MarkPositionAdjustment
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	private float m_XPositionAdjustment; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000016")]
	private float m_YPositionAdjustment; //Field offset: 0x4

	[Token(Token = "0x17000003")]
	public float xPositionAdjustment
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6000018")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public float yPositionAdjustment
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x600001A")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x600001B")]
	public MarkPositionAdjustment(float x, float y) { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6000017")]
	public float get_xPositionAdjustment() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x6000019")]
	public float get_yPositionAdjustment() { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6000018")]
	public void set_xPositionAdjustment(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x600001A")]
	public void set_yPositionAdjustment(float value) { }

}

