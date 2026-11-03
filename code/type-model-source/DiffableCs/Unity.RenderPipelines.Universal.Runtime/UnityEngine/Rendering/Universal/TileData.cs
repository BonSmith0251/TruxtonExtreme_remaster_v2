namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F3")]
public struct TileData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABE")]
	public uint tileID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000ABF")]
	public uint listBitMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AC0")]
	public uint relLightOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000AC1")]
	public uint unused; //Field offset: 0xC

}

