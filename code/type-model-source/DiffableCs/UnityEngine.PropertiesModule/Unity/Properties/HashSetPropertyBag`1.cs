namespace Unity.Properties;

[Token(Token = "0x2000028")]
public class HashSetPropertyBag : SetPropertyBagBase<HashSet`1<TElement>, TElement>
{

	[Token(Token = "0x17000022")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xDC23F0", Offset = "0xDC17F0", Length = "0x15")]
	[Token(Token = "0x600009A")]
	public HashSetPropertyBag`1() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000098")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0x17D89F0", Offset = "0x17D7DF0", Length = "0x5D")]
	[Token(Token = "0x6000099")]
	protected virtual HashSet<TElement> Instantiate() { }

}

