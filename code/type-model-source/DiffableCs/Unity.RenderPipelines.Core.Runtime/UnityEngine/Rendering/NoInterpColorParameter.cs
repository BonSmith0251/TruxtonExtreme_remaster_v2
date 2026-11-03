namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000214")]
public class NoInterpColorParameter : VolumeParameter<Color>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400099A")]
	public bool hdr; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400099B")]
	public bool showAlpha; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400099C")]
	public bool showEyeDropper; //Field offset: 0x2A

	[Address(RVA = "0x2C62FC0", Offset = "0x2C623C0", Length = "0x6B")]
	[Token(Token = "0x6000F47")]
	public NoInterpColorParameter(Color value, bool overrideState = false) { }

	[Address(RVA = "0x2C63030", Offset = "0x2C62430", Length = "0xA6")]
	[Token(Token = "0x6000F48")]
	public NoInterpColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false) { }

}

