namespace Unity.Properties;

[Token(Token = "0x200003F")]
public class ListPropertyBag : IndexedCollectionPropertyBag<List`1<TElement>, TElement>
{

	[Token(Token = "0x17000030")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xB0D4F0", Offset = "0xB0C8F0", Length = "0x14")]
	[Token(Token = "0x60000EE")]
	public ListPropertyBag`1() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60000EB")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0xB0D410", Offset = "0xB0C810", Length = "0x5C")]
	[Token(Token = "0x60000ED")]
	protected virtual List<TElement> Instantiate() { }

	[Address(RVA = "0xB0D330", Offset = "0xB0C730", Length = "0x6A")]
	[Token(Token = "0x60000EC")]
	protected virtual List<TElement> InstantiateWithCount(int count) { }

}

