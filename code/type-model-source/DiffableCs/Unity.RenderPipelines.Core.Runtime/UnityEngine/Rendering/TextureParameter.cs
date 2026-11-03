namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200021B")]
public class TextureParameter : VolumeParameter<Texture>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400099D")]
	public TextureDimension dimension; //Field offset: 0x20

	[Address(RVA = "0x2C67990", Offset = "0x2C66D90", Length = "0x62")]
	[Token(Token = "0x6000F52")]
	public TextureParameter(Texture value, bool overrideState = false) { }

	[Address(RVA = "0x2C67920", Offset = "0x2C66D20", Length = "0x6B")]
	[Token(Token = "0x6000F53")]
	public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false) { }

	[Address(RVA = "0x2C67820", Offset = "0x2C66C20", Length = "0xF4")]
	[Token(Token = "0x6000F54")]
	public virtual int GetHashCode() { }

}

