namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200016E")]
internal class DecalSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000850")]
	public DecalTechniqueOption technique; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000851")]
	public float maxDrawDistance; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000852")]
	public bool decalLayers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000853")]
	public DBufferSettings dBufferSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000854")]
	public DecalScreenSpaceSettings screenSpaceSettings; //Field offset: 0x28

	[Address(RVA = "0x2DC9810", Offset = "0x2DC8C10", Length = "0xE")]
	[Token(Token = "0x60007EF")]
	public DecalSettings() { }

}

