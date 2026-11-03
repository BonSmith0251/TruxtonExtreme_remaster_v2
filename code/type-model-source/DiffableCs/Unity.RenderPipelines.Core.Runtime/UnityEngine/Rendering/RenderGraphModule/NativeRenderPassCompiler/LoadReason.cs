namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002C0")]
internal enum LoadReason : int
{
	InvalidReason = 0,
	LoadImported = 1,
	LoadPreviouslyWritten = 2,
	ClearImported = 3,
	ClearCreated = 4,
	FullyRewritten = 5,
	Count = 6,
}

