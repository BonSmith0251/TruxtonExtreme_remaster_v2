namespace UnityEngine.UIElements;

[Obsolete("UxmlRootElementFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004DF")]
public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
{

	[Token(Token = "0x170009BB")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x32C5DB0", Offset = "0x32C51B0", Length = "0x2C")]
		[Token(Token = "0x6002508")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170009BC")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x32C5DE0", Offset = "0x32C51E0", Length = "0x78")]
		[Token(Token = "0x6002509")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x32C5D70", Offset = "0x32C5170", Length = "0x39")]
	[Token(Token = "0x600250B")]
	public UxmlRootElementFactory() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x600250A")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C5DB0", Offset = "0x32C51B0", Length = "0x2C")]
	[Token(Token = "0x6002508")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x32C5DE0", Offset = "0x32C51E0", Length = "0x78")]
	[Token(Token = "0x6002509")]
	public virtual string get_uxmlQualifiedName() { }

}

