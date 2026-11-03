namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000E")]
public struct TileChangeData
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000035")]
	private Vector3Int m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000036")]
	private object m_TileAsset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private Color m_Color; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private Matrix4x4 m_Transform; //Field offset: 0x28

}

