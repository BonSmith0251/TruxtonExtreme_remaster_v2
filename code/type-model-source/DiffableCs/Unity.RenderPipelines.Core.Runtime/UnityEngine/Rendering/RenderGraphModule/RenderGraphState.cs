namespace UnityEngine.Rendering.RenderGraphModule;

[Flags]
[Token(Token = "0x2000269")]
internal enum RenderGraphState : int
{
	Idle = 0,
	RecordingGraph = 1,
	RecordingPass = 2,
	Executing = 4,
	Active = 7,
}

