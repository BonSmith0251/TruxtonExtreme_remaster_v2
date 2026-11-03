namespace UnityEngine.Rendering;

[Extension]
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBufferExtensions.bindings.h")]
[Token(Token = "0x200038C")]
[UsedByNativeCode]
public static class CommandBufferExtensions
{

	[Address(RVA = "0x3099720", Offset = "0x3098B20", Length = "0xC7")]
	[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchIntoFastMemory")]
	[Token(Token = "0x6001CAC")]
	private static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[Address(RVA = "0x30996B0", Offset = "0x3098AB0", Length = "0x6D")]
	[Token(Token = "0x6001CB0")]
	private static void Internal_SwitchIntoFastMemory_Injected(IntPtr cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[Address(RVA = "0x3099850", Offset = "0x3098C50", Length = "0xB0")]
	[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchOutOfFastMemory")]
	[Token(Token = "0x6001CAD")]
	private static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents) { }

	[Address(RVA = "0x30997F0", Offset = "0x3098BF0", Length = "0x54")]
	[Token(Token = "0x6001CB1")]
	private static void Internal_SwitchOutOfFastMemory_Injected(IntPtr cmd, ref RenderTargetIdentifier rt, bool copyContents) { }

	[Address(RVA = "0x3099910", Offset = "0x3098D10", Length = "0xC7")]
	[Extension]
	[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
	[Token(Token = "0x6001CAE")]
	public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[Address(RVA = "0x30999E0", Offset = "0x3098DE0", Length = "0xB0")]
	[Extension]
	[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
	[Token(Token = "0x6001CAF")]
	public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents) { }

}

