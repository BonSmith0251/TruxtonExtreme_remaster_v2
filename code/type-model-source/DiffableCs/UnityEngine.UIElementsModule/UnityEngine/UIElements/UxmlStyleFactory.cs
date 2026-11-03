namespace UnityEngine.UIElements;

[Obsolete("UxmlStyleFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E1")]
public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
{

	[Token(Token = "0x170009BD")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x32C6390", Offset = "0x32C5790", Length = "0x2C")]
		[Token(Token = "0x600250D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170009BE")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x32C63C0", Offset = "0x32C57C0", Length = "0x78")]
		[Token(Token = "0x600250E")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x32C6350", Offset = "0x32C5750", Length = "0x39")]
	[Token(Token = "0x6002510")]
	public UxmlStyleFactory() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x600250F")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C6390", Offset = "0x32C5790", Length = "0x2C")]
	[Token(Token = "0x600250D")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x32C63C0", Offset = "0x32C57C0", Length = "0x78")]
	[Token(Token = "0x600250E")]
	public virtual string get_uxmlQualifiedName() { }

}

