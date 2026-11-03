namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000D")]
internal class GpuTimeProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000047")]
	private FrameTiming[] m_FrameTiming; //Field offset: 0x10

	[Token(Token = "0x1700002D")]
	public float GpuFrameTime
	{
		[Address(RVA = "0x2F978D0", Offset = "0x2F96CD0", Length = "0x69")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 105
	}

	[Address(RVA = "0x2F97870", Offset = "0x2F96C70", Length = "0x55")]
	[Token(Token = "0x600008B")]
	public GpuTimeProvider() { }

	[Address(RVA = "0x2F978D0", Offset = "0x2F96CD0", Length = "0x69")]
	[Token(Token = "0x600008C")]
	public float get_GpuFrameTime() { }

	[Address(RVA = "0x2F97230", Offset = "0x2F96630", Length = "0x13")]
	[Token(Token = "0x600008D")]
	protected override uint GetLatestTimings() { }

	[Address(RVA = "0x2F97250", Offset = "0x2F96650", Length = "0x7")]
	[Token(Token = "0x600008E")]
	public void Measure() { }

}

