namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000F0")]
internal struct BuddyAllocation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000580")]
	public int level; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000581")]
	public int index; //Field offset: 0x4

	[Token(Token = "0x170001BF")]
	public uint2 index2D
	{
		[Address(RVA = "0x2DA7FE0", Offset = "0x2DA73E0", Length = "0xA")]
		[Token(Token = "0x6000679")]
		 get { } //Length: 10
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000678")]
	public BuddyAllocation(int level, int index) { }

	[Address(RVA = "0x2DA7FE0", Offset = "0x2DA73E0", Length = "0xA")]
	[Token(Token = "0x6000679")]
	public uint2 get_index2D() { }

}

