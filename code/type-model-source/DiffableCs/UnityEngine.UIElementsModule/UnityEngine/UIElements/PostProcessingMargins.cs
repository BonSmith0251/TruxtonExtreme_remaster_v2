namespace UnityEngine.UIElements;

[Token(Token = "0x2000257")]
public struct PostProcessingMargins
{
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000912")]
	private float m_Left; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000913")]
	private float m_Top; //Field offset: 0x4
	[DontCreateProperty]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000914")]
	private float m_Right; //Field offset: 0x8
	[DontCreateProperty]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000915")]
	private float m_Bottom; //Field offset: 0xC

	[CreateProperty]
	[Token(Token = "0x170002F9")]
	public float bottom
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6001012")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x6001013")]
		 set { } //Length: 6
	}

	[CreateProperty]
	[Token(Token = "0x170002F6")]
	public float left
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x600100C")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x600100D")]
		 set { } //Length: 5
	}

	[CreateProperty]
	[Token(Token = "0x170002F8")]
	public float right
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x6001010")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x6001011")]
		 set { } //Length: 6
	}

	[CreateProperty]
	[Token(Token = "0x170002F7")]
	public float top
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600100E")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x600100F")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x6001012")]
	public float get_bottom() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x600100C")]
	public float get_left() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x6001010")]
	public float get_right() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x600100E")]
	public float get_top() { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x6001013")]
	public void set_bottom(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x600100D")]
	public void set_left(float value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x6001011")]
	public void set_right(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x600100F")]
	public void set_top(float value) { }

}

