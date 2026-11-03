namespace UnityEngine.ResourceManagement.Profiling;

[Token(Token = "0x2000077")]
internal interface IProfilerEmitter
{

	[Token(Token = "0x1700007B")]
	public bool IsEnabled
	{
		[Token(Token = "0x6000294")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000295")]
	public void EmitFrameMetaData(Guid id, int tag, Array data) { }

	[Token(Token = "0x6000294")]
	public bool get_IsEnabled() { }

	[Token(Token = "0x6000296")]
	public void InitialiseCallbacks(Action<Single> onLateUpdateDelegate) { }

}

