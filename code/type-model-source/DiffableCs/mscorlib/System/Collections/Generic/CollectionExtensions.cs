namespace System.Collections.Generic;

[Extension]
[Token(Token = "0x2000608")]
public static class CollectionExtensions
{

	[Address(RVA = "0x79E640", Offset = "0x79DA40", Length = "0x142")]
	[Extension]
	[Token(Token = "0x6002D13")]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }

	[Address(RVA = "0x79E790", Offset = "0x79DB90", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x6002D14")]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }

}

