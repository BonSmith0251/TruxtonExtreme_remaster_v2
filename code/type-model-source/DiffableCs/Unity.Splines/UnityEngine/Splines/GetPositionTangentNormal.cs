namespace UnityEngine.Splines;

[Token(Token = "0x2000045")]
public struct GetPositionTangentNormal : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000115")]
	public NativeSpline Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000116")]
	[WriteOnly]
	public NativeArray<float3> Positions; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000117")]
	[WriteOnly]
	public NativeArray<float3> Tangents; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000118")]
	[WriteOnly]
	public NativeArray<float3> Normals; //Field offset: 0x68

	[Address(RVA = "0x2E74A70", Offset = "0x2E73E70", Length = "0x12A")]
	[Token(Token = "0x600028A")]
	public override void Execute(int index) { }

}

