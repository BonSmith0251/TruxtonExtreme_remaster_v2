namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000028")]
public interface IPerformanceStatus
{

	[Token(Token = "0x14000007")]
	public event PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent
	{
		[CompilerGenerated]
		[Token(Token = "0x6000132")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x6000133")]
		 remove { } //Length: 0
	}

	[Token(Token = "0x17000061")]
	public FrameTiming FrameTiming
	{
		[Token(Token = "0x6000131")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000060")]
	public PerformanceMetrics PerformanceMetrics
	{
		[Token(Token = "0x6000130")]
		 get { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x6000132")]
	public void add_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

	[Token(Token = "0x6000131")]
	public FrameTiming get_FrameTiming() { }

	[Token(Token = "0x6000130")]
	public PerformanceMetrics get_PerformanceMetrics() { }

	[CompilerGenerated]
	[Token(Token = "0x6000133")]
	public void remove_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

}

