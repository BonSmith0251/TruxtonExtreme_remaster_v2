namespace UnityEngine.Timeline;

[Token(Token = "0x2000039")]
internal class InfiniteRuntimeClip : RuntimeElement
{
	[Token(Token = "0x400010F")]
	private static readonly long kIntervalEnd; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400010E")]
	private Playable m_Playable; //Field offset: 0x18

	[Token(Token = "0x1700009F")]
	public virtual bool enable
	{
		[Address(RVA = "0x2F2EF70", Offset = "0x2F2E370", Length = "0x79")]
		[Token(Token = "0x6000240")]
		 set { } //Length: 121
	}

	[Token(Token = "0x1700009E")]
	public virtual long intervalEnd
	{
		[Address(RVA = "0x2F2EF20", Offset = "0x2F2E320", Length = "0x4E")]
		[Token(Token = "0x600023F")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700009D")]
	public virtual long intervalStart
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600023E")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2F2EE10", Offset = "0x2F2E210", Length = "0xD3")]
	[Token(Token = "0x6000243")]
	private static InfiniteRuntimeClip() { }

	[Address(RVA = "0x2F2EEF0", Offset = "0x2F2E2F0", Length = "0x29")]
	[Token(Token = "0x600023D")]
	public InfiniteRuntimeClip(Playable playable) { }

	[Address(RVA = "0x2F2ED40", Offset = "0x2F2E140", Length = "0x6D")]
	[Token(Token = "0x6000242")]
	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	[Address(RVA = "0x2F2EDB0", Offset = "0x2F2E1B0", Length = "0x55")]
	[Token(Token = "0x6000241")]
	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	[Address(RVA = "0x2F2EF20", Offset = "0x2F2E320", Length = "0x4E")]
	[Token(Token = "0x600023F")]
	public virtual long get_intervalEnd() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600023E")]
	public virtual long get_intervalStart() { }

	[Address(RVA = "0x2F2EF70", Offset = "0x2F2E370", Length = "0x79")]
	[Token(Token = "0x6000240")]
	public virtual void set_enable(bool value) { }

}

