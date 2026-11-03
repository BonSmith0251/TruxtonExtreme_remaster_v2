namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AA")]
internal class BasicNodePool : LinkedPool<BasicNode`1<T>>
{

	[Address(RVA = "0x16B5CA0", Offset = "0x16B50A0", Length = "0xE7")]
	[Token(Token = "0x60028D7")]
	public BasicNodePool`1() { }

	[Address(RVA = "0x16B59E0", Offset = "0x16B4DE0", Length = "0x8D")]
	[Token(Token = "0x60028D6")]
	private static BasicNode<T> Create() { }

	[Address(RVA = "0x16B5C60", Offset = "0x16B5060", Length = "0x39")]
	[Token(Token = "0x60028D5")]
	private static void Reset(BasicNode<T> node) { }

}

