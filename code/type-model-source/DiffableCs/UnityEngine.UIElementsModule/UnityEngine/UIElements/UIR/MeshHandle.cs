namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000580")]
internal class MeshHandle : LinkedPoolItem<MeshHandle>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400125F")]
	internal Alloc allocVerts; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001260")]
	internal Alloc allocIndices; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001261")]
	internal uint triangleCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001262")]
	internal Page allocPage; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001263")]
	internal uint allocTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001264")]
	internal uint updateAllocID; //Field offset: 0x5C

	[Address(RVA = "0x32DDE90", Offset = "0x32DD290", Length = "0x39")]
	[Token(Token = "0x6002803")]
	public MeshHandle() { }

}

