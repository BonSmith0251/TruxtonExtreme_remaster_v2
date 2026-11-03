namespace UnityEngine.Splines;

[BurstCompile]
[Token(Token = "0x2000044")]
public struct GetPosition : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000113")]
	public NativeSpline Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000114")]
	[WriteOnly]
	public NativeArray<float3> Positions; //Field offset: 0x48

	[Address(RVA = "0x2E74BA0", Offset = "0x2E73FA0", Length = "0xBA")]
	[Token(Token = "0x6000289")]
	public override void Execute(int index) { }

}

