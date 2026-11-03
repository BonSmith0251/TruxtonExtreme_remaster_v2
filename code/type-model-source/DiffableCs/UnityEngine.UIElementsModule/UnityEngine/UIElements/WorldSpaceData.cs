namespace UnityEngine.UIElements;

[Token(Token = "0x200056B")]
internal struct WorldSpaceData
{
	[Token(Token = "0x4001200")]
	public static readonly Bounds k_Empty3DBounds; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001201")]
	public Bounds localBounds3D; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001202")]
	public Bounds localBoundsPicking3D; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001203")]
	public Bounds localBoundsWithoutNested3D; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001204")]
	public Rect boundingBoxWithoutNested; //Field offset: 0x48

	[Address(RVA = "0x32EE3D0", Offset = "0x32ED7D0", Length = "0x1C5")]
	[Token(Token = "0x600277B")]
	private static WorldSpaceData() { }

}

