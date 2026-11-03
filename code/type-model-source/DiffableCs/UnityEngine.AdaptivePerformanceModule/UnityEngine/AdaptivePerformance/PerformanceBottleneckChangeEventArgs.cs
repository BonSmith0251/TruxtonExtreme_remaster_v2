namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000022")]
public struct PerformanceBottleneckChangeEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000097")]
	private PerformanceBottleneck <PerformanceBottleneck>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000057")]
	public PerformanceBottleneck PerformanceBottleneck
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000118")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000119")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000118")]
	public PerformanceBottleneck get_PerformanceBottleneck() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000119")]
	public void set_PerformanceBottleneck(PerformanceBottleneck value) { }

}

