namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000F")]
public struct TileAnimationData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000039")]
	private Sprite[] m_AnimatedSprites; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003A")]
	private float m_AnimationSpeed; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400003B")]
	private float m_AnimationStartTime; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003C")]
	private TileAnimationFlags m_Flags; //Field offset: 0x10

}

