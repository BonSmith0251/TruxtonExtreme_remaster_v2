namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000219")]
public class Vector4Parameter : VolumeParameter<Vector4>
{

	[Address(RVA = "0x2C683C0", Offset = "0x2C677C0", Length = "0x65")]
	[Token(Token = "0x6000F4F")]
	public Vector4Parameter(Vector4 value, bool overrideState = false) { }

	[Address(RVA = "0x2C54300", Offset = "0x2C53700", Length = "0x62")]
	[Token(Token = "0x6000F50")]
	public virtual void Interp(Vector4 from, Vector4 to, float t) { }

}

