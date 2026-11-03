namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000429")]
internal sealed class SerObjectInfoCache
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010DB")]
	internal string fullTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010DC")]
	internal string assemblyString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010DD")]
	internal bool hasTypeForwardedFrom; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010DE")]
	internal MemberInfo[] memberInfos; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010DF")]
	internal String[] memberNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010E0")]
	internal Type[] memberTypes; //Field offset: 0x38

	[Address(RVA = "0x1F29340", Offset = "0x1F28740", Length = "0x61")]
	[Token(Token = "0x6001F66")]
	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	[Address(RVA = "0x1F293B0", Offset = "0x1F287B0", Length = "0x96")]
	[Token(Token = "0x6001F67")]
	internal SerObjectInfoCache(Type type) { }

}

