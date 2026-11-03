namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000084")]
internal struct DecalSubDrawCall
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000280")]
	public int start; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000281")]
	public int end; //Field offset: 0x4

	[Token(Token = "0x170000DB")]
	public int count
	{
		[Address(RVA = "0x2D7FF50", Offset = "0x2D7F350", Length = "0x6")]
		[Token(Token = "0x600031E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2D7FF50", Offset = "0x2D7F350", Length = "0x6")]
	[Token(Token = "0x600031E")]
	public int get_count() { }

}

