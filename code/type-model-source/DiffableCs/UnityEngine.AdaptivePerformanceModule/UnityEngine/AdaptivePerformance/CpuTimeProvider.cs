namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000B")]
internal class CpuTimeProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003E")]
	private FrameTiming[] m_FrameTimings; //Field offset: 0x10

	[Token(Token = "0x17000023")]
	public float CpuFrameTime
	{
		[Address(RVA = "0x2F972C0", Offset = "0x2F966C0", Length = "0x6E")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 110
	}

	[Address(RVA = "0x2F97260", Offset = "0x2F96660", Length = "0x55")]
	[Token(Token = "0x6000074")]
	public CpuTimeProvider() { }

	[Address(RVA = "0x2F972C0", Offset = "0x2F966C0", Length = "0x6E")]
	[Token(Token = "0x6000075")]
	public float get_CpuFrameTime() { }

	[Address(RVA = "0x2F97230", Offset = "0x2F96630", Length = "0x13")]
	[Token(Token = "0x6000076")]
	protected override uint GetLatestTimings() { }

	[Address(RVA = "0x2F97250", Offset = "0x2F96650", Length = "0x7")]
	[Token(Token = "0x6000077")]
	public void Measure() { }

}

