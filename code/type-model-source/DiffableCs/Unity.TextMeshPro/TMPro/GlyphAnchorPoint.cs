namespace TMPro;

[Token(Token = "0x2000009")]
public struct GlyphAnchorPoint
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private float m_XCoordinate; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private float m_YCoordinate; //Field offset: 0x4

	[Token(Token = "0x17000001")]
	public float xCoordinate
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6000014")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public float yCoordinate
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6000013")]
	public float get_xCoordinate() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x6000015")]
	public float get_yCoordinate() { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6000014")]
	public void set_xCoordinate(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x6000016")]
	public void set_yCoordinate(float value) { }

}

