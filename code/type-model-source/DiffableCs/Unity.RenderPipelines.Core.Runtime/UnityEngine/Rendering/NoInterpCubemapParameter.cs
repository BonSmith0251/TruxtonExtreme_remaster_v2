namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000222")]
public class NoInterpCubemapParameter : VolumeParameter<Cubemap>
{

	[Address(RVA = "0x2C631E0", Offset = "0x2C625E0", Length = "0x5A")]
	[Token(Token = "0x6000F61")]
	public NoInterpCubemapParameter(Cubemap value, bool overrideState = false) { }

	[Address(RVA = "0x2C630E0", Offset = "0x2C624E0", Length = "0xF4")]
	[Token(Token = "0x6000F62")]
	public virtual int GetHashCode() { }

}

