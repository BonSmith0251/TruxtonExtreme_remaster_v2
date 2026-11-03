namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200003A")]
public class SerializedTypeRestrictionAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000095")]
	public Type type; //Field offset: 0x10

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000151")]
	public SerializedTypeRestrictionAttribute() { }

}

