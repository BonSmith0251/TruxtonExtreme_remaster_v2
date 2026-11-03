namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000019")]
internal class PerformanceStateTracker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006B")]
	private Queue<Single> m_Samples; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006C")]
	private int m_SampleCapacity; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400006D")]
	private float <Trend>k__BackingField; //Field offset: 0x1C

	[Token(Token = "0x17000038")]
	public float Trend
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 6
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000B0")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2F98FD0", Offset = "0x2F983D0", Length = "0x89")]
	[Token(Token = "0x60000B1")]
	public PerformanceStateTracker(int sampleCapacity) { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000AF")]
	public float get_Trend() { }

	[Address(RVA = "0x2F8D000", Offset = "0x2F8C400", Length = "0x48")]
	[Token(Token = "0x60000B3")]
	protected override float GetEffectiveTargetFrameRate() { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000B0")]
	public void set_Trend(float value) { }

	[Address(RVA = "0x2F98CE0", Offset = "0x2F980E0", Length = "0x2E2")]
	[Token(Token = "0x60000B2")]
	public StateAction Update() { }

}

