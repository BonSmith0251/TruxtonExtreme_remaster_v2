namespace UnityEngine;

[NativeContainer]
[NativeHeader("Runtime/Camera/RenderLoops/LightProbeContext.h")]
[StaticAccessor("LightProbeContextWrapper", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20000D4")]
public struct LightProbesQuery : IDisposable
{
	[NativeContainer]
	[Token(Token = "0x20000D5")]
	public struct LightProbesQueryDispose
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400025A")]
		internal IntPtr m_LightProbeContextWrapper; //Field offset: 0x0

		[Address(RVA = "0x2FF8660", Offset = "0x2FF7A60", Length = "0x46")]
		[Token(Token = "0x600062D")]
		public void Dispose() { }

	}

	[Token(Token = "0x20000D6")]
	public struct LightProbesQueryDisposeJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025B")]
		internal LightProbesQueryDispose Data; //Field offset: 0x0

		[Address(RVA = "0x2FF8660", Offset = "0x2FF7A60", Length = "0x46")]
		[Token(Token = "0x600062E")]
		public override void Execute() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000258")]
	internal IntPtr m_LightProbeContextWrapper; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000259")]
	internal Allocator m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x2FF8C60", Offset = "0x2FF8060", Length = "0x53")]
	[Token(Token = "0x6000626")]
	public LightProbesQuery(Allocator allocator) { }

	[Address(RVA = "0x2FF8720", Offset = "0x2FF7B20", Length = "0x28C")]
	[Token(Token = "0x600062B")]
	public void CalculateInterpolatedLightAndOcclusionProbes(NativeArray<Vector3> positions, NativeArray<Int32> tetrahedronIndices, NativeArray<SphericalHarmonicsL2> lightProbes, NativeArray<Vector4> occlusionProbes) { }

	[Address(RVA = "0x2FF86B0", Offset = "0x2FF7AB0", Length = "0x62")]
	[ThreadSafe]
	[Token(Token = "0x600062C")]
	private static void CalculateInterpolatedLightAndOcclusionProbes(IntPtr lightProbeContextWrapper, IntPtr positions, IntPtr tetrahedronIndices, IntPtr lightProbes, IntPtr occlusionProbes, int count) { }

	[Address(RVA = "0x2FF89B0", Offset = "0x2FF7DB0", Length = "0x2A")]
	[Token(Token = "0x6000629")]
	private static IntPtr Create() { }

	[Address(RVA = "0x2FF89E0", Offset = "0x2FF7DE0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600062A")]
	private static void Destroy(IntPtr lightProbeContextWrapper) { }

	[Address(RVA = "0x2FF8A20", Offset = "0x2FF7E20", Length = "0x105")]
	[Token(Token = "0x6000627")]
	public override void Dispose() { }

	[Address(RVA = "0x2FF8B30", Offset = "0x2FF7F30", Length = "0x12B")]
	[Token(Token = "0x6000628")]
	public JobHandle Dispose(JobHandle inputDeps) { }

}

