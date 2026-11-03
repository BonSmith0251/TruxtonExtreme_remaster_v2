namespace UnityEngine.Splines;

[Token(Token = "0x200001C")]
public class SplineIndexAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000043")]
	public readonly string SplineContainerProperty; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x60000A7")]
	public SplineIndexAttribute(string splineContainerProperty) { }

}

