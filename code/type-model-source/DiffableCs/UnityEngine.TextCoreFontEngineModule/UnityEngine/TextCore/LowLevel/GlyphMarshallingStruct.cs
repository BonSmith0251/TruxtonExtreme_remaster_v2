namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x200000F")]
[UsedByNativeCode]
internal struct GlyphMarshallingStruct
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007A")]
	public uint index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007B")]
	public GlyphMetrics metrics; //Field offset: 0x4
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007C")]
	public GlyphRect glyphRect; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007D")]
	public float scale; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400007E")]
	public int atlasIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007F")]
	public GlyphClassDefinitionType classDefinitionType; //Field offset: 0x30

}

