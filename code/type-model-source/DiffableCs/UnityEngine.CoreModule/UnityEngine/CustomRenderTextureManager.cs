namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
[Token(Token = "0x20000D1")]
public static class CustomRenderTextureManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000251")]
	private static Action<CustomRenderTexture> textureLoaded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000252")]
	private static Action<CustomRenderTexture> textureUnloaded; //Field offset: 0x8

	[Address(RVA = "0x2FF1C80", Offset = "0x2FF1080", Length = "0x58")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000612")]
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[Address(RVA = "0x2FF1CE0", Offset = "0x2FF10E0", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000613")]
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

