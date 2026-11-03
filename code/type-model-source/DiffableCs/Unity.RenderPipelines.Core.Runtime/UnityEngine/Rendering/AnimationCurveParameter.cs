namespace UnityEngine.Rendering;

[Token(Token = "0x2000225")]
public class AnimationCurveParameter : VolumeParameter<AnimationCurve>
{

	[Address(RVA = "0x2C540A0", Offset = "0x2C534A0", Length = "0x5A")]
	[Token(Token = "0x6000F70")]
	public AnimationCurveParameter(AnimationCurve value, bool overrideState = false) { }

	[Address(RVA = "0x2C53E20", Offset = "0x2C53220", Length = "0xFC")]
	[Token(Token = "0x6000F73")]
	public virtual object Clone() { }

	[Address(RVA = "0x2C53F20", Offset = "0x2C53320", Length = "0x94")]
	[Token(Token = "0x6000F74")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C53FC0", Offset = "0x2C533C0", Length = "0x46")]
	[Token(Token = "0x6000F71")]
	public virtual void Interp(AnimationCurve lhsCurve, AnimationCurve rhsCurve, float t) { }

	[Address(RVA = "0x2C54010", Offset = "0x2C53410", Length = "0x8D")]
	[Token(Token = "0x6000F72")]
	public virtual void SetValue(VolumeParameter parameter) { }

}

