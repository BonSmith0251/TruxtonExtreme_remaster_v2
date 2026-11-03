namespace System.Data;

[Token(Token = "0x200001E")]
internal sealed class Function
{
	[Token(Token = "0x40000D0")]
	internal static String[] s_functionName; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C9")]
	internal readonly string _name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CA")]
	internal readonly FunctionId _id; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000CB")]
	internal readonly Type _result; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000CC")]
	internal readonly bool _isValidateArguments; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40000CD")]
	internal readonly bool _isVariantArgumentList; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000CE")]
	internal readonly int _argumentCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000CF")]
	internal readonly Type[] _parameters; //Field offset: 0x30

	[Address(RVA = "0x23285E0", Offset = "0x23279E0", Length = "0x786")]
	[Token(Token = "0x60002FB")]
	private static Function() { }

	[Address(RVA = "0x2328D70", Offset = "0x2328170", Length = "0x232")]
	[Token(Token = "0x60002FA")]
	internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

}

