namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000252")]
[VisibleToOtherModules]
internal struct BlittableArrayWrapper
{
	[Token(Token = "0x2000253")]
	public enum UpdateFlags : int
	{
		NoUpdateNeeded = 0,
		SizeChanged = 1,
		DataIsNativePointer = 2,
		DataIsNativeOwnedMemory = 3,
		DataIsEmpty = 4,
		DataIsNull = 5,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007B7")]
	internal Void* data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007B8")]
	internal int size; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40007B9")]
	internal UpdateFlags updateFlags; //Field offset: 0xC

	[Address(RVA = "0x28CC410", Offset = "0x28CB810", Length = "0xF")]
	[Token(Token = "0x600183A")]
	public BlittableArrayWrapper(Void* data, int size) { }

	[Address(RVA = "0x797DD0", Offset = "0x7971D0", Length = "0x140")]
	[Token(Token = "0x600183B")]
	internal void Unmarshal(ref T[] array) { }

}

