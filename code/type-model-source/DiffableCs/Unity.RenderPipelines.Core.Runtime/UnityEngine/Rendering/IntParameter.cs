namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000201")]
public class IntParameter : VolumeParameter<Int32>
{

	[Address(RVA = "0x2C5F190", Offset = "0x2C5E590", Length = "0x58")]
	[Token(Token = "0x6000F13")]
	public IntParameter(int value, bool overrideState = false) { }

	[Address(RVA = "0x2C5F160", Offset = "0x2C5E560", Length = "0x22")]
	[Token(Token = "0x6000F14")]
	public virtual void Interp(int from, int to, float t) { }

}

