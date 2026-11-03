namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000D")]
internal struct TileDataNative
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002F")]
	private int m_Sprite; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000030")]
	private Color m_Color; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000031")]
	private Matrix4x4 m_Transform; //Field offset: 0x14
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000032")]
	private int m_GameObject; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000033")]
	private TileFlags m_Flags; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000034")]
	private ColliderType m_ColliderType; //Field offset: 0x5C

}

