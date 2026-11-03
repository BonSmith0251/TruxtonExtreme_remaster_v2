namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000213")]
public class ColorParameter : VolumeParameter<Color>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000997")]
	public bool hdr; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000998")]
	public bool showAlpha; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000999")]
	public bool showEyeDropper; //Field offset: 0x2A

	[Address(RVA = "0x2C54420", Offset = "0x2C53820", Length = "0x6B")]
	[Token(Token = "0x6000F44")]
	public ColorParameter(Color value, bool overrideState = false) { }

	[Address(RVA = "0x2C54370", Offset = "0x2C53770", Length = "0xA6")]
	[Token(Token = "0x6000F45")]
	public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false) { }

	[Address(RVA = "0x2C54300", Offset = "0x2C53700", Length = "0x62")]
	[Token(Token = "0x6000F46")]
	public virtual void Interp(Color from, Color to, float t) { }

}

