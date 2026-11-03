namespace UnityEngine.Splines;

[Token(Token = "0x200001E")]
public class EmbeddedSplineDataFieldsAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004A")]
	public readonly EmbeddedSplineDataField Fields; //Field offset: 0x18

	[Address(RVA = "0x2C5F130", Offset = "0x2C5E530", Length = "0x24")]
	[Token(Token = "0x60000A8")]
	public EmbeddedSplineDataFieldsAttribute(EmbeddedSplineDataField fields) { }

}

