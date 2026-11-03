namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200016B")]
internal class DBufferSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400084A")]
	public DecalSurfaceData surfaceData; //Field offset: 0x10

	[Address(RVA = "0x672E40", Offset = "0x672240", Length = "0xE")]
	[Token(Token = "0x60007ED")]
	public DBufferSettings() { }

}

