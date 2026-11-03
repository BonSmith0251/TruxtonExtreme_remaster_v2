namespace UnityEngine.Timeline;

[Token(Token = "0x2000041")]
internal class ScheduleRuntimeClip : RuntimeClipBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000122")]
	private TimelineClip m_Clip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000123")]
	private Playable m_Playable; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000124")]
	private Playable m_ParentMixer; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000125")]
	private double m_StartDelay; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000126")]
	private double m_FinishTail; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000127")]
	private bool m_Started; //Field offset: 0x50

	[Token(Token = "0x170000B3")]
	public TimelineClip clip
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600026E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B2")]
	public virtual double duration
	{
		[Address(RVA = "0x2F31080", Offset = "0x2F30480", Length = "0x4A")]
		[Token(Token = "0x600026C")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170000B6")]
	public virtual bool enable
	{
		[Address(RVA = "0x2F31150", Offset = "0x2F30550", Length = "0x123")]
		[Token(Token = "0x6000273")]
		 set { } //Length: 291
	}

	[Token(Token = "0x170000B4")]
	public Playable mixer
	{
		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x600026F")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000B5")]
	public Playable playable
	{
		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[Token(Token = "0x6000270")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000B1")]
	public virtual double start
	{
		[Address(RVA = "0x2F310D0", Offset = "0x2F304D0", Length = "0x7D")]
		[Token(Token = "0x600026B")]
		 get { } //Length: 125
	}

	[Address(RVA = "0x2F30FD0", Offset = "0x2F303D0", Length = "0xA6")]
	[Token(Token = "0x6000271")]
	public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1) { }

	[Address(RVA = "0x2F30B90", Offset = "0x2F2FF90", Length = "0x9F")]
	[Token(Token = "0x6000272")]
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) { }

	[Address(RVA = "0x2F30C30", Offset = "0x2F30030", Length = "0x16")]
	[Token(Token = "0x6000275")]
	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	[Address(RVA = "0x2F30C50", Offset = "0x2F30050", Length = "0x31A")]
	[Token(Token = "0x6000274")]
	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600026E")]
	public TimelineClip get_clip() { }

	[Address(RVA = "0x2F31080", Offset = "0x2F30480", Length = "0x4A")]
	[Token(Token = "0x600026C")]
	public virtual double get_duration() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
	[Token(Token = "0x600026F")]
	public Playable get_mixer() { }

	[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
	[Token(Token = "0x6000270")]
	public Playable get_playable() { }

	[Address(RVA = "0x2F310D0", Offset = "0x2F304D0", Length = "0x7D")]
	[Token(Token = "0x600026B")]
	public virtual double get_start() { }

	[Address(RVA = "0x2F31150", Offset = "0x2F30550", Length = "0x123")]
	[Token(Token = "0x6000273")]
	public virtual void set_enable(bool value) { }

	[Address(RVA = "0x2F30F70", Offset = "0x2F30370", Length = "0x55")]
	[Token(Token = "0x600026D")]
	public void SetTime(double time) { }

}

