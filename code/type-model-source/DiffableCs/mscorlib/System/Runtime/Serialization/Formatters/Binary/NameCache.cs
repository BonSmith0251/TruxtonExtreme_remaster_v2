namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000434")]
internal sealed class NameCache
{
	[Token(Token = "0x400115D")]
	private static ConcurrentDictionary<String, Object> ht; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400115E")]
	private string name; //Field offset: 0x10

	[Address(RVA = "0x1F39490", Offset = "0x1F38890", Length = "0x84")]
	[Token(Token = "0x6001FF8")]
	private static NameCache() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001FF7")]
	public NameCache() { }

	[Address(RVA = "0x1F39340", Offset = "0x1F38740", Length = "0xB5")]
	[Token(Token = "0x6001FF5")]
	internal object GetCachedValue(string name) { }

	[Address(RVA = "0x1F39400", Offset = "0x1F38800", Length = "0x88")]
	[Token(Token = "0x6001FF6")]
	internal void SetCachedValue(object value) { }

}

