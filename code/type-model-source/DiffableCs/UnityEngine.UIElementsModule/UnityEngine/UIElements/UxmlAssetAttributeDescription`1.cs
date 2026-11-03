namespace UnityEngine.UIElements;

[Token(Token = "0x20004EA")]
public class UxmlAssetAttributeDescription : TypedUxmlAttributeDescription<T>
{

	[Address(RVA = "0x11E2EA0", Offset = "0x11E22A0", Length = "0x9D")]
	[Token(Token = "0x6002521")]
	public UxmlAssetAttributeDescription`1() { }

	[Address(RVA = "0x11E2C40", Offset = "0x11E2040", Length = "0x11C")]
	[Token(Token = "0x6002522")]
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x11E2D60", Offset = "0x11E2160", Length = "0x139")]
	[Token(Token = "0x6002523")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, out T value) { }

}

