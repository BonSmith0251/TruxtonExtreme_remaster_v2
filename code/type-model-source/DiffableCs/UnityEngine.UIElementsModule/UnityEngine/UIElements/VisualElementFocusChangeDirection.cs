namespace UnityEngine.UIElements;

[Token(Token = "0x200054E")]
public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	[Token(Token = "0x400119C")]
	private static readonly VisualElementFocusChangeDirection s_Left; //Field offset: 0x0
	[Token(Token = "0x400119D")]
	private static readonly VisualElementFocusChangeDirection s_Right; //Field offset: 0x8

	[Token(Token = "0x17000A14")]
	public static FocusChangeDirection left
	{
		[Address(RVA = "0x32CBF30", Offset = "0x32CB330", Length = "0x4E")]
		[Token(Token = "0x60026CE")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000A15")]
	public static FocusChangeDirection right
	{
		[Address(RVA = "0x32CBF80", Offset = "0x32CB380", Length = "0x4F")]
		[Token(Token = "0x60026CF")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x32CBCF0", Offset = "0x32CB0F0", Length = "0x1D8")]
	[Token(Token = "0x60026D1")]
	private static VisualElementFocusChangeDirection() { }

	[Address(RVA = "0x32CBED0", Offset = "0x32CB2D0", Length = "0x57")]
	[Token(Token = "0x60026D0")]
	protected VisualElementFocusChangeDirection(int value) { }

	[Address(RVA = "0x32CBF30", Offset = "0x32CB330", Length = "0x4E")]
	[Token(Token = "0x60026CE")]
	public static FocusChangeDirection get_left() { }

	[Address(RVA = "0x32CBF80", Offset = "0x32CB380", Length = "0x4F")]
	[Token(Token = "0x60026CF")]
	public static FocusChangeDirection get_right() { }

}

