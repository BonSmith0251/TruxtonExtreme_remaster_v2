namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200002A")]
public struct FrameTiming
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A6")]
	private float <CurrentFrameTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000A7")]
	private float <AverageFrameTime>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A8")]
	private float <CurrentGpuFrameTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000A9")]
	private float <AverageGpuFrameTime>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AA")]
	private float <CurrentCpuFrameTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000AB")]
	private float <AverageCpuFrameTime>k__BackingField; //Field offset: 0x14

	[Token(Token = "0x1700006D")]
	public float AverageCpuFrameTime
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600014A")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600014B")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000069")]
	public float AverageFrameTime
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000142")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000143")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700006B")]
	public float AverageGpuFrameTime
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000146")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000147")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700006C")]
	public float CurrentCpuFrameTime
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000148")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000149")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000068")]
	public float CurrentFrameTime
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000140")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000141")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700006A")]
	public float CurrentGpuFrameTime
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000144")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000145")]
		 set { } //Length: 6
	}

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600014A")]
	public float get_AverageCpuFrameTime() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000142")]
	public float get_AverageFrameTime() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000146")]
	public float get_AverageGpuFrameTime() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000148")]
	public float get_CurrentCpuFrameTime() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000140")]
	public float get_CurrentFrameTime() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000144")]
	public float get_CurrentGpuFrameTime() { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600014B")]
	public void set_AverageCpuFrameTime(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000143")]
	public void set_AverageFrameTime(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000147")]
	public void set_AverageGpuFrameTime(float value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000149")]
	public void set_CurrentCpuFrameTime(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000141")]
	public void set_CurrentFrameTime(float value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000145")]
	public void set_CurrentGpuFrameTime(float value) { }

}

