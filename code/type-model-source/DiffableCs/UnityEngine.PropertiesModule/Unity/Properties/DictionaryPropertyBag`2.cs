namespace Unity.Properties;

[Token(Token = "0x2000027")]
public class DictionaryPropertyBag : KeyValueCollectionPropertyBag<Dictionary`2<TKey, TValue>, TKey, TValue>
{

	[Token(Token = "0x17000021")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xDC23F0", Offset = "0xDC17F0", Length = "0x15")]
	[Token(Token = "0x6000097")]
	public DictionaryPropertyBag`2() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000095")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0x17D89F0", Offset = "0x17D7DF0", Length = "0x5D")]
	[Token(Token = "0x6000096")]
	protected virtual Dictionary<TKey, TValue> Instantiate() { }

}

