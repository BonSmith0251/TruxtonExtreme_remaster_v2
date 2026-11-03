namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[RequiredByNativeCode]
[Token(Token = "0x2000189")]
public sealed class ContextMenu : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062C")]
	public readonly string menuItem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062D")]
	public readonly bool validate; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400062E")]
	public readonly int priority; //Field offset: 0x1C

	[Address(RVA = "0x305E0E0", Offset = "0x305D4E0", Length = "0x3D")]
	[Token(Token = "0x6001289")]
	public ContextMenu(string itemName) { }

	[Address(RVA = "0x305E090", Offset = "0x305D490", Length = "0x4B")]
	[Token(Token = "0x600128A")]
	public ContextMenu(string itemName, bool isValidateFunction) { }

	[Address(RVA = "0x305E030", Offset = "0x305D430", Length = "0x54")]
	[Token(Token = "0x600128B")]
	public ContextMenu(string itemName, bool isValidateFunction, int priority) { }

}

