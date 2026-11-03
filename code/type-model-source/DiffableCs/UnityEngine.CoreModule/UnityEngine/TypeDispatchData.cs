namespace UnityEngine;

[Token(Token = "0x200015D")]
internal struct TypeDispatchData : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005DE")]
	public Object[] changed; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005DF")]
	public NativeArray<EntityId> changedID; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E0")]
	public NativeArray<EntityId> destroyedID; //Field offset: 0x18

	[Address(RVA = "0x3073360", Offset = "0x3072760", Length = "0x5B")]
	[Token(Token = "0x600119E")]
	public override void Dispose() { }

}

