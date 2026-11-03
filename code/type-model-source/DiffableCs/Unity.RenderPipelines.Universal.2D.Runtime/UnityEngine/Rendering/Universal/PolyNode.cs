namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000009")]
internal class PolyNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	internal PolyNode m_Parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000B")]
	internal List<IntPoint> m_polygon; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000C")]
	internal int m_Index; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000D")]
	internal JoinTypes m_jointype; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000E")]
	internal EndTypes m_endtype; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000F")]
	internal List<PolyNode> m_Childs; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000010")]
	private bool <IsOpen>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000002")]
	public int ChildCount
	{
		[Address(RVA = "0x2D18A20", Offset = "0x2D17E20", Length = "0x3C")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000004")]
	public List<PolyNode> Childs
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public List<IntPoint> Contour
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public bool IsHole
	{
		[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000007")]
	public bool IsOpen
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000005")]
	public PolyNode Parent
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D18960", Offset = "0x2D17D60", Length = "0xBD")]
	[Token(Token = "0x600001B")]
	public PolyNode() { }

	[Address(RVA = "0x2D18780", Offset = "0x2D17B80", Length = "0xDA")]
	[Token(Token = "0x6000013")]
	internal void AddChild(PolyNode Child) { }

	[Address(RVA = "0x2D18A20", Offset = "0x2D17E20", Length = "0x3C")]
	[Token(Token = "0x6000011")]
	public int get_ChildCount() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000016")]
	public List<PolyNode> get_Childs() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000012")]
	public List<IntPoint> get_Contour() { }

	[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
	[Token(Token = "0x6000018")]
	public bool get_IsHole() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	public bool get_IsOpen() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000017")]
	public PolyNode get_Parent() { }

	[Address(RVA = "0x2D188F0", Offset = "0x2D17CF0", Length = "0x6F")]
	[Token(Token = "0x6000014")]
	public PolyNode GetNext() { }

	[Address(RVA = "0x2D18860", Offset = "0x2D17C60", Length = "0x86")]
	[Token(Token = "0x6000015")]
	internal PolyNode GetNextSiblingUp() { }

	[Address(RVA = "0x28A55F0", Offset = "0x28A49F0", Length = "0x1C")]
	[Token(Token = "0x6000010")]
	private bool IsHoleNode() { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600001A")]
	public void set_IsOpen(bool value) { }

}

