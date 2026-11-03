namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000215")]
public class Vector2Parameter : VolumeParameter<Vector2>
{

	[Address(RVA = "0x2C682A0", Offset = "0x2C676A0", Length = "0x5E")]
	[Token(Token = "0x6000F49")]
	public Vector2Parameter(Vector2 value, bool overrideState = false) { }

	[Address(RVA = "0x2C5BF40", Offset = "0x2C5B340", Length = "0x46")]
	[Token(Token = "0x6000F4A")]
	public virtual void Interp(Vector2 from, Vector2 to, float t) { }

}

