namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[RequiredByNativeCode]
[Token(Token = "0x2000186")]
public sealed class RequireComponent : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000624")]
	public Type m_Type0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000625")]
	public Type m_Type1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000626")]
	public Type m_Type2; //Field offset: 0x20

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6001281")]
	public RequireComponent(Type requiredComponent) { }

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x6001282")]
	public RequireComponent(Type requiredComponent, Type requiredComponent2) { }

}

