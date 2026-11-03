namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000C")]
public struct TileData
{
	[Token(Token = "0x400002E")]
	internal static readonly TileData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000028")]
	private int m_Sprite; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000029")]
	private Color m_Color; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002A")]
	private Matrix4x4 m_Transform; //Field offset: 0x14
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400002B")]
	private int m_GameObject; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400002C")]
	private TileFlags m_Flags; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400002D")]
	private ColliderType m_ColliderType; //Field offset: 0x5C

	[Token(Token = "0x1700000D")]
	public ColliderType colliderType
	{
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public Color color
	{
		[Address(RVA = "0x17CB510", Offset = "0x17CA910", Length = "0x8")]
		[Token(Token = "0x6000035")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public TileFlags flags
	{
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public GameObject gameObject
	{
		[Address(RVA = "0x31D0220", Offset = "0x31CF620", Length = "0x84")]
		[Token(Token = "0x6000037")]
		 set { } //Length: 132
	}

	[Token(Token = "0x17000008")]
	public Sprite sprite
	{
		[Address(RVA = "0x31D02B0", Offset = "0x31CF6B0", Length = "0x82")]
		[Token(Token = "0x6000034")]
		 set { } //Length: 130
	}

	[Token(Token = "0x1700000A")]
	public Matrix4x4 transform
	{
		[Address(RVA = "0x31D0340", Offset = "0x31CF740", Length = "0x20")]
		[Token(Token = "0x6000036")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x31D00E0", Offset = "0x31CF4E0", Length = "0x135")]
	[Token(Token = "0x600003B")]
	private static TileData() { }

	[Address(RVA = "0x31CFFB0", Offset = "0x31CF3B0", Length = "0x12B")]
	[Token(Token = "0x600003A")]
	private static TileData CreateDefault() { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x6000039")]
	public void set_colliderType(ColliderType value) { }

	[Address(RVA = "0x17CB510", Offset = "0x17CA910", Length = "0x8")]
	[Token(Token = "0x6000035")]
	public void set_color(Color value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6000038")]
	public void set_flags(TileFlags value) { }

	[Address(RVA = "0x31D0220", Offset = "0x31CF620", Length = "0x84")]
	[Token(Token = "0x6000037")]
	public void set_gameObject(GameObject value) { }

	[Address(RVA = "0x31D02B0", Offset = "0x31CF6B0", Length = "0x82")]
	[Token(Token = "0x6000034")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x31D0340", Offset = "0x31CF740", Length = "0x20")]
	[Token(Token = "0x6000036")]
	public void set_transform(Matrix4x4 value) { }

}

