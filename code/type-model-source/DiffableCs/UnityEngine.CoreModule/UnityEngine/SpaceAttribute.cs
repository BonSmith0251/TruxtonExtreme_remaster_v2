namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = True)]
[Token(Token = "0x200016B")]
public class SpaceAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000600")]
	public readonly float height; //Field offset: 0x18

	[Address(RVA = "0x3071900", Offset = "0x3070D00", Length = "0x21")]
	[Token(Token = "0x6001201")]
	public SpaceAttribute() { }

	[Address(RVA = "0x30718D0", Offset = "0x3070CD0", Length = "0x2C")]
	[Token(Token = "0x6001202")]
	public SpaceAttribute(float height) { }

}

