namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200021D")]
public class Texture2DParameter : VolumeParameter<Texture>
{

	[Address(RVA = "0x2C660D0", Offset = "0x2C654D0", Length = "0x5A")]
	[Token(Token = "0x6000F57")]
	public Texture2DParameter(Texture value, bool overrideState = false) { }

	[Address(RVA = "0x2C65FD0", Offset = "0x2C653D0", Length = "0xF4")]
	[Token(Token = "0x6000F58")]
	public virtual int GetHashCode() { }

}

