namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Extension]
[Token(Token = "0x20002B1")]
internal static class NativeListExtensions
{

	[Address(RVA = "0x88FB00", Offset = "0x88EF00", Length = "0x4C")]
	[Extension]
	[Token(Token = "0x6001328")]
	internal static int LastIndex(ref NativeList<T>& list) { }

	[Address(RVA = "0x88FC60", Offset = "0x88F060", Length = "0x7F")]
	[Extension]
	[Token(Token = "0x6001327")]
	internal static ReadOnlySpan<T> MakeReadOnlySpan(ref NativeList<T>& list, int first, int numElements) { }

}

