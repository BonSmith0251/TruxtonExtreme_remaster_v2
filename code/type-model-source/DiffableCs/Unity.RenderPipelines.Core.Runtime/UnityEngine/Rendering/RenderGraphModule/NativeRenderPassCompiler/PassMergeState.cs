namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002BD")]
internal enum PassMergeState : int
{
	None = -1,
	Begin = 0,
	SubPass = 1,
	End = 2,
}

