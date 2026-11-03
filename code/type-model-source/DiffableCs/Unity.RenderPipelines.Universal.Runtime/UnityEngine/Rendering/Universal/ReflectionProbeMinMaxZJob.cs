namespace UnityEngine.Rendering.Universal;

[BurstCompile]
[Token(Token = "0x20001B9")]
internal struct ReflectionProbeMinMaxZJob : IJobFor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000978")]
	public Fixed2<float4x4> worldToViews; //Field offset: 0x0
	[FieldOffset(Offset = "0x80")]
	[ReadOnly]
	[Token(Token = "0x4000979")]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[ReadOnly]
	[Token(Token = "0x400097A")]
	public bool reflectionProbeRotation; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400097B")]
	public NativeArray<float2> minMaxZs; //Field offset: 0x98

	[Address(RVA = "0x2DE9DF0", Offset = "0x2DE91F0", Length = "0x46C")]
	[Token(Token = "0x600097F")]
	public override void Execute(int index) { }

}

