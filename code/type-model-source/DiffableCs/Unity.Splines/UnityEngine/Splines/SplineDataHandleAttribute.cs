namespace UnityEngine.Splines;

[AttributeUsage(AttributeTargets::Field (256))]
[Obsolete("Use SplineDataHandles.DataPointHandles instead and EditorTools to interact with SplineData.", False)]
[Token(Token = "0x2000038")]
public abstract class SplineDataHandleAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60001E9")]
	protected SplineDataHandleAttribute() { }

}

