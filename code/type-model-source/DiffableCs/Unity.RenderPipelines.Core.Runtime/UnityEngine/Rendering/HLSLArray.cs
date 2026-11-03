namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000176")]
public class HLSLArray : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071B")]
	public int arraySize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400071C")]
	public Type elementType; //Field offset: 0x18

	[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
	[Token(Token = "0x6000B82")]
	public HLSLArray(int arraySize, Type elementType) { }

}

