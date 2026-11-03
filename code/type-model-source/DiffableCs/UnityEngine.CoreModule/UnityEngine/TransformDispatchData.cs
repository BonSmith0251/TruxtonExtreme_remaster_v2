namespace UnityEngine;

[Token(Token = "0x200015E")]
internal struct TransformDispatchData : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005E1")]
	public NativeArray<EntityId> transformedID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E2")]
	public NativeArray<EntityId> parentID; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005E3")]
	public NativeArray<Matrix4x4> localToWorldMatrices; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005E4")]
	public NativeArray<Vector3> positions; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005E5")]
	public NativeArray<Quaternion> rotations; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005E6")]
	public NativeArray<Vector3> scales; //Field offset: 0x50

	[Address(RVA = "0x30732B0", Offset = "0x30726B0", Length = "0xAD")]
	[Token(Token = "0x600119F")]
	public override void Dispose() { }

}

