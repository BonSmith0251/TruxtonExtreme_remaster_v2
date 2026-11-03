namespace UnityEngine.Rendering;

[Token(Token = "0x200003E")]
internal struct BinningConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D6")]
	public int viewCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000D7")]
	public bool supportsCrossFade; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40000D8")]
	public bool supportsMotionCheck; //Field offset: 0x5

	[Token(Token = "0x17000021")]
	public int visibilityConfigCount
	{
		[Address(RVA = "0x2CC1230", Offset = "0x2CC0630", Length = "0x21")]
		[Token(Token = "0x600012D")]
		 get { } //Length: 33
	}

	[Address(RVA = "0x2CC1230", Offset = "0x2CC0630", Length = "0x21")]
	[Token(Token = "0x600012D")]
	public int get_visibilityConfigCount() { }

}

