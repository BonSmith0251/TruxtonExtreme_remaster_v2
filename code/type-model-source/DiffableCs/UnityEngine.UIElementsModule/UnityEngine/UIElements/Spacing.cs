namespace UnityEngine.UIElements;

[Token(Token = "0x20002EA")]
internal struct Spacing
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BE0")]
	public float left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BE1")]
	public float top; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BE2")]
	public float right; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000BE3")]
	public float bottom; //Field offset: 0xC

	[Token(Token = "0x170003F8")]
	public float horizontal
	{
		[Address(RVA = "0x3245700", Offset = "0x3244B00", Length = "0xC")]
		[Token(Token = "0x600145B")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170003F9")]
	public float vertical
	{
		[Address(RVA = "0x3245710", Offset = "0x3244B10", Length = "0xD")]
		[Token(Token = "0x600145C")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x600145D")]
	public Spacing(float left, float top, float right, float bottom) { }

	[Address(RVA = "0x3245700", Offset = "0x3244B00", Length = "0xC")]
	[Token(Token = "0x600145B")]
	public float get_horizontal() { }

	[Address(RVA = "0x3245710", Offset = "0x3244B10", Length = "0xD")]
	[Token(Token = "0x600145C")]
	public float get_vertical() { }

	[Address(RVA = "0x3245720", Offset = "0x3244B20", Length = "0xC6")]
	[Token(Token = "0x600145E")]
	public static Rect op_Subtraction(Rect r, Spacing a) { }

}

