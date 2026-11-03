namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000217")]
public class Vector3Parameter : VolumeParameter<Vector3>
{

	[Address(RVA = "0x2C68350", Offset = "0x2C67750", Length = "0x6E")]
	[Token(Token = "0x6000F4C")]
	public Vector3Parameter(Vector3 value, bool overrideState = false) { }

	[Address(RVA = "0x2C68300", Offset = "0x2C67700", Length = "0x49")]
	[Token(Token = "0x6000F4D")]
	public virtual void Interp(Vector3 from, Vector3 to, float t) { }

}

