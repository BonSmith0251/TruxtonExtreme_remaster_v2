namespace UnityEngine.UIElements;

[Obsolete("UxmlTemplateFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E3")]
public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
{

	[Token(Token = "0x170009BF")]
	public virtual string uxmlName
	{
		[Address(RVA = "0x32C65C0", Offset = "0x32C59C0", Length = "0x2C")]
		[Token(Token = "0x6002512")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170009C0")]
	public virtual string uxmlQualifiedName
	{
		[Address(RVA = "0x32C65F0", Offset = "0x32C59F0", Length = "0x78")]
		[Token(Token = "0x6002513")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x32C6580", Offset = "0x32C5980", Length = "0x39")]
	[Token(Token = "0x6002515")]
	public UxmlTemplateFactory() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6002514")]
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C65C0", Offset = "0x32C59C0", Length = "0x2C")]
	[Token(Token = "0x6002512")]
	public virtual string get_uxmlName() { }

	[Address(RVA = "0x32C65F0", Offset = "0x32C59F0", Length = "0x78")]
	[Token(Token = "0x6002513")]
	public virtual string get_uxmlQualifiedName() { }

}

