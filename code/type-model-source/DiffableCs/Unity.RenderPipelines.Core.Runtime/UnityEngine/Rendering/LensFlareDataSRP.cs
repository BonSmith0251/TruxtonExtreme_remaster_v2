namespace UnityEngine.Rendering;

[Token(Token = "0x200015B")]
public sealed class LensFlareDataSRP : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006D8")]
	public LensFlareDataElementSRP[] elements; //Field offset: 0x18

	[Address(RVA = "0x2C2F910", Offset = "0x2C2ED10", Length = "0x28")]
	[Token(Token = "0x6000B45")]
	public LensFlareDataSRP() { }

	[Address(RVA = "0x2C2F8B0", Offset = "0x2C2ECB0", Length = "0x5C")]
	[Token(Token = "0x6000B46")]
	public bool HasAModulateByLightColorElement() { }

}

