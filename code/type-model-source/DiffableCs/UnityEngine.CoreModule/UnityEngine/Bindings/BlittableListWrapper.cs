namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000254")]
[VisibleToOtherModules]
internal struct BlittableListWrapper
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007C1")]
	private BlittableArrayWrapper arrayWrapper; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007C2")]
	private int listSize; //Field offset: 0x10

	[Address(RVA = "0xAEE4F0", Offset = "0xAED8F0", Length = "0xB")]
	[Token(Token = "0x600183C")]
	public BlittableListWrapper(BlittableArrayWrapper arrayWrapper, int listSize) { }

	[Address(RVA = "0x799AB0", Offset = "0x798EB0", Length = "0x204")]
	[Token(Token = "0x600183D")]
	internal void Unmarshal(List<T> list) { }

}

