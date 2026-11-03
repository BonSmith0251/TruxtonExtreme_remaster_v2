namespace Unity.Profiling;

[IgnoredByDeepProfiler]
[Token(Token = "0x2000027")]
[UsedByNativeCode]
public struct ProfilerMarker
{
	[IgnoredByDeepProfiler]
	[Token(Token = "0x2000028")]
	[UsedByNativeCode]
	internal struct AutoScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000049")]
		internal readonly IntPtr m_Ptr; //Field offset: 0x0

		[Address(RVA = "0x2FCECF0", Offset = "0x2FCE0F0", Length = "0x41")]
		[Token(Token = "0x6000076")]
		internal AutoScope(IntPtr markerPtr) { }

		[Address(RVA = "0x2FCECA0", Offset = "0x2FCE0A0", Length = "0x4A")]
		[Token(Token = "0x6000077")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000048")]
	internal readonly IntPtr m_Ptr; //Field offset: 0x0

	[Address(RVA = "0x2FE3F20", Offset = "0x2FE3320", Length = "0x2D")]
	[Token(Token = "0x6000073")]
	public ProfilerMarker(string name) { }

	[Address(RVA = "0x2FE3EF0", Offset = "0x2FE32F0", Length = "0x28")]
	[Token(Token = "0x6000074")]
	public ProfilerMarker(ProfilerCategory category, string name) { }

	[Address(RVA = "0x2FE3EB0", Offset = "0x2FE32B0", Length = "0x3B")]
	[Pure]
	[Token(Token = "0x6000075")]
	public AutoScope Auto() { }

}

