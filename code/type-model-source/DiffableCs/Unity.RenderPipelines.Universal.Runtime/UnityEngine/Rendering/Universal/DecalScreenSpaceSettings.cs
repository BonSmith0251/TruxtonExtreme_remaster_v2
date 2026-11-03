namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200016D")]
internal class DecalScreenSpaceSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400084F")]
	public DecalNormalBlend normalBlend; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007EE")]
	public DecalScreenSpaceSettings() { }

}

