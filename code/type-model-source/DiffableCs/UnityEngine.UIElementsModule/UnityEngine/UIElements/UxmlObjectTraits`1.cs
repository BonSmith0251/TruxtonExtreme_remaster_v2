namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x200050B")]
internal abstract class UxmlObjectTraits : BaseUxmlTraits
{

	[Address(RVA = "0x11E6F90", Offset = "0x11E6390", Length = "0x7")]
	[Token(Token = "0x600258B")]
	protected UxmlObjectTraits`1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600258A")]
	public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

}

