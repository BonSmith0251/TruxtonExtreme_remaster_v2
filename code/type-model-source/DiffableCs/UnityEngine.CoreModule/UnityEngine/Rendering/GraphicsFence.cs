namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/GPUFence.h")]
[Token(Token = "0x2000376")]
[UsedByNativeCode]
public struct GraphicsFence
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A63")]
	internal IntPtr m_Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A64")]
	internal int m_Version; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A65")]
	internal GraphicsFenceType m_FenceType; //Field offset: 0xC

	[Address(RVA = "0x2F9BA30", Offset = "0x2F9AE30", Length = "0x8")]
	[Token(Token = "0x6001A39")]
	private int GetPlatformNotSupportedVersion() { }

	[Address(RVA = "0x3079030", Offset = "0x3078430", Length = "0x33")]
	[FreeFunction("GPUFenceInternals::GetVersionNumber")]
	[NativeThrows]
	[Token(Token = "0x6001A3A")]
	private static int GetVersionNumber(IntPtr fencePtr) { }

	[Address(RVA = "0x3079070", Offset = "0x3078470", Length = "0xC3")]
	[Token(Token = "0x6001A36")]
	internal void InitPostAllocation() { }

	[Address(RVA = "0x3079140", Offset = "0x3078540", Length = "0x59")]
	[Token(Token = "0x6001A37")]
	internal bool IsFencePending() { }

	[Address(RVA = "0x30791A0", Offset = "0x30785A0", Length = "0x88")]
	[Token(Token = "0x6001A38")]
	internal void Validate() { }

}

