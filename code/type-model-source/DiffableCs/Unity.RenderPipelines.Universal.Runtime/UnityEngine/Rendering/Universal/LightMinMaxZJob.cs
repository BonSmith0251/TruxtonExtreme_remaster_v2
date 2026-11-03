namespace UnityEngine.Rendering.Universal;

[BurstCompile]
[Token(Token = "0x20001B8")]
internal struct LightMinMaxZJob : IJobFor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000975")]
	public Fixed2<float4x4> worldToViews; //Field offset: 0x0
	[FieldOffset(Offset = "0x80")]
	[ReadOnly]
	[Token(Token = "0x4000976")]
	public NativeArray<VisibleLight> lights; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000977")]
	public NativeArray<float2> minMaxZs; //Field offset: 0x90

	[Address(RVA = "0x2DE8270", Offset = "0x2DE7670", Length = "0x5E6")]
	[Token(Token = "0x600097E")]
	public override void Execute(int index) { }

}

