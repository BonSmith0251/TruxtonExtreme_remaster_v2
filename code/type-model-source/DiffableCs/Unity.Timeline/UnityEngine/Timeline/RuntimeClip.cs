namespace UnityEngine.Timeline;

[Token(Token = "0x200003E")]
internal class RuntimeClip : RuntimeClipBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011E")]
	private TimelineClip m_Clip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011F")]
	private Playable m_Playable; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000120")]
	private Playable m_ParentMixer; //Field offset: 0x30

	[Token(Token = "0x170000A5")]
	public TimelineClip clip
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000256")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000A4")]
	public virtual double duration
	{
		[Address(RVA = "0x2F309B0", Offset = "0x2F2FDB0", Length = "0x1D")]
		[Token(Token = "0x6000253")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000A8")]
	public virtual bool enable
	{
		[Address(RVA = "0x2F30A00", Offset = "0x2F2FE00", Length = "0x18C")]
		[Token(Token = "0x6000259")]
		 set { } //Length: 396
	}

	[Token(Token = "0x170000A6")]
	public Playable mixer
	{
		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000A7")]
	public Playable playable
	{
		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[Token(Token = "0x6000258")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000A3")]
	public virtual double start
	{
		[Address(RVA = "0x2F309D0", Offset = "0x2F2FDD0", Length = "0x2D")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x2F30920", Offset = "0x2F2FD20", Length = "0x90")]
	[Token(Token = "0x6000254")]
	public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	[Address(RVA = "0x2F302A0", Offset = "0x2F2F6A0", Length = "0x89")]
	[Token(Token = "0x6000255")]
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	[Address(RVA = "0x2F30330", Offset = "0x2F2F730", Length = "0x1CE")]
	[Token(Token = "0x600025D")]
	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	[Address(RVA = "0x2F30500", Offset = "0x2F2F900", Length = "0x355")]
	[Token(Token = "0x600025C")]
	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000256")]
	public TimelineClip get_clip() { }

	[Address(RVA = "0x2F309B0", Offset = "0x2F2FDB0", Length = "0x1D")]
	[Token(Token = "0x6000253")]
	public virtual double get_duration() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
	[Token(Token = "0x6000257")]
	public Playable get_mixer() { }

	[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
	[Token(Token = "0x6000258")]
	public Playable get_playable() { }

	[Address(RVA = "0x2F309D0", Offset = "0x2F2FDD0", Length = "0x2D")]
	[Token(Token = "0x6000252")]
	public virtual double get_start() { }

	[Address(RVA = "0x2F30A00", Offset = "0x2F2FE00", Length = "0x18C")]
	[Token(Token = "0x6000259")]
	public virtual void set_enable(bool value) { }

	[Address(RVA = "0x2F30860", Offset = "0x2F2FC60", Length = "0x55")]
	[Token(Token = "0x600025B")]
	public void SetDuration(double duration) { }

	[Address(RVA = "0x2F308C0", Offset = "0x2F2FCC0", Length = "0x55")]
	[Token(Token = "0x600025A")]
	public void SetTime(double time) { }

}

