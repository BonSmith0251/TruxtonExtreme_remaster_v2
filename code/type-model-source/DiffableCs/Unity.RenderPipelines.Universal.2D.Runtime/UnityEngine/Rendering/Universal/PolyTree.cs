namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000008")]
internal class PolyTree : PolyNode
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000009")]
	internal List<PolyNode> m_AllPolys; //Field offset: 0x40

	[Token(Token = "0x17000001")]
	public int Total
	{
		[Address(RVA = "0x2D18C40", Offset = "0x2D18040", Length = "0x99")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x2D18BC0", Offset = "0x2D17FC0", Length = "0x77")]
	[Token(Token = "0x600000F")]
	public PolyTree() { }

	[Address(RVA = "0x2D18A60", Offset = "0x2D17E60", Length = "0xE2")]
	[Token(Token = "0x600000C")]
	public void Clear() { }

	[Address(RVA = "0x2D18C40", Offset = "0x2D18040", Length = "0x99")]
	[Token(Token = "0x600000E")]
	public int get_Total() { }

	[Address(RVA = "0x2D18B50", Offset = "0x2D17F50", Length = "0x63")]
	[Token(Token = "0x600000D")]
	public PolyNode GetFirst() { }

}

