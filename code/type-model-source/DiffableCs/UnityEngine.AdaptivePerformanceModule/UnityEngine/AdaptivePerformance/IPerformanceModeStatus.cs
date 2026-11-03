namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000021")]
public interface IPerformanceModeStatus
{

	[Token(Token = "0x14000006")]
	public event PerformanceModeEventHandler PerformanceModeEvent
	{
		[CompilerGenerated]
		[Token(Token = "0x6000116")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x6000117")]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x6000116")]
	public void add_PerformanceModeEvent(PerformanceModeEventHandler value) { }

	[CompilerGenerated]
	[Token(Token = "0x6000117")]
	public void remove_PerformanceModeEvent(PerformanceModeEventHandler value) { }

}

