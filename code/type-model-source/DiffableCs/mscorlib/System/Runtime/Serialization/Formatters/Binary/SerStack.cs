namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000431")]
internal sealed class SerStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001156")]
	internal Object[] objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001157")]
	internal string stackId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001158")]
	internal int top; //Field offset: 0x20

	[Address(RVA = "0x1F42490", Offset = "0x1F41890", Length = "0x78")]
	[Token(Token = "0x6001FE1")]
	internal SerStack(string stackId) { }

	[Address(RVA = "0x1F421B0", Offset = "0x1F415B0", Length = "0x90")]
	[Token(Token = "0x6001FE4")]
	internal void IncreaseCapacity() { }

	[Address(RVA = "0x1F42250", Offset = "0x1F41650", Length = "0x8")]
	[Token(Token = "0x6001FE7")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x1F422A0", Offset = "0x1F416A0", Length = "0x37")]
	[Token(Token = "0x6001FE5")]
	internal object Peek() { }

	[Address(RVA = "0x1F42260", Offset = "0x1F41660", Length = "0x3A")]
	[Token(Token = "0x6001FE6")]
	internal object PeekPeek() { }

	[Address(RVA = "0x1F422E0", Offset = "0x1F416E0", Length = "0x73")]
	[Token(Token = "0x6001FE3")]
	internal object Pop() { }

	[Address(RVA = "0x1F42360", Offset = "0x1F41760", Length = "0x125")]
	[Token(Token = "0x6001FE2")]
	internal void Push(object obj) { }

}

