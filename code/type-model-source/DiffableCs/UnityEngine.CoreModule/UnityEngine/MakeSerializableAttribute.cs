namespace UnityEngine;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
[RequiredByNativeCode]
[Token(Token = "0x20001DB")]
public sealed class MakeSerializableAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006C3")]
	private Type serializableType; //Field offset: 0x10

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[RequiredByNativeCode]
	[Token(Token = "0x60014CB")]
	private Type GetSerializableType() { }

}

