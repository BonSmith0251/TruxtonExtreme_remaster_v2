namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20001C4")]
public struct TagHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400068F")]
	private uint _tagIndex; //Field offset: 0x0

	[Address(RVA = "0x3072830", Offset = "0x3071C30", Length = "0xAA")]
	[Token(Token = "0x6001412")]
	private static string TagToString(uint tagIndex) { }

	[Address(RVA = "0x30727F0", Offset = "0x3071BF0", Length = "0x40")]
	[Token(Token = "0x6001413")]
	private static void TagToString_Injected(uint tagIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30728E0", Offset = "0x3071CE0", Length = "0x9")]
	[Token(Token = "0x6001411")]
	public virtual string ToString() { }

}

