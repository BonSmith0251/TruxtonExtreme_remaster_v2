namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002C2")]
internal enum StoreReason : int
{
	InvalidReason = 0,
	StoreImported = 1,
	StoreUsedByLaterPass = 2,
	DiscardImported = 3,
	DiscardUnused = 4,
	DiscardBindMs = 5,
	NoMSAABuffer = 6,
	Count = 7,
}

