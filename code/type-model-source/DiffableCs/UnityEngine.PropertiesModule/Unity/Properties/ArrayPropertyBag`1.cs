namespace Unity.Properties;

[Token(Token = "0x2000025")]
public sealed class ArrayPropertyBag : IndexedCollectionPropertyBag<TElement[], TElement>
{

	[Token(Token = "0x17000020")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600008B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xB0D4D0", Offset = "0xB0C8D0", Length = "0x15")]
	[Token(Token = "0x600008E")]
	public ArrayPropertyBag`1() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600008B")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0xB47FE0", Offset = "0xB473E0", Length = "0x18")]
	[Token(Token = "0x600008D")]
	protected virtual TElement[] Instantiate() { }

	[Address(RVA = "0xB47FA0", Offset = "0xB473A0", Length = "0x36")]
	[Token(Token = "0x600008C")]
	protected virtual TElement[] InstantiateWithCount(int count) { }

}

