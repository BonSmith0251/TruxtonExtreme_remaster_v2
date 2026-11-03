namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200042A")]
internal sealed class TypeInformation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010E1")]
	private string fullTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010E2")]
	private string assemblyString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010E3")]
	private bool hasTypeForwardedFrom; //Field offset: 0x20

	[Token(Token = "0x170003E0")]
	internal string AssemblyString
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001F69")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003DF")]
	internal string FullTypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001F68")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003E1")]
	internal bool HasTypeForwardedFrom
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001F6A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1F29340", Offset = "0x1F28740", Length = "0x61")]
	[Token(Token = "0x6001F6B")]
	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001F69")]
	internal string get_AssemblyString() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001F68")]
	internal string get_FullTypeName() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001F6A")]
	internal bool get_HasTypeForwardedFrom() { }

}

