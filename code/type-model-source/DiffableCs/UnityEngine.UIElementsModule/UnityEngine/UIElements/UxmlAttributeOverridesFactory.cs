namespace UnityEngine.UIElements;

[Obsolete("UxmlAttributeOverridesFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E5")]
public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
{

	[Token(Token = "0x170009C1")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x32C3650", Offset = "0x32C2A50", Length = "0x2C")]
		[Token(Token = "0x6002517")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170009C2")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x32C3680", Offset = "0x32C2A80", Length = "0x78")]
		[Token(Token = "0x6002518")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x32C3610", Offset = "0x32C2A10", Length = "0x39")]
	[Token(Token = "0x600251A")]
	public UxmlAttributeOverridesFactory() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6002519")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C3650", Offset = "0x32C2A50", Length = "0x2C")]
	[Token(Token = "0x6002517")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x32C3680", Offset = "0x32C2A80", Length = "0x78")]
	[Token(Token = "0x6002518")]
	public virtual string get_uxmlQualifiedName() { }

}

