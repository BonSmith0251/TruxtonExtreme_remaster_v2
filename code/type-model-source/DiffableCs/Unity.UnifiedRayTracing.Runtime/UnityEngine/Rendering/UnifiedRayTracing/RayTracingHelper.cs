namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000059")]
public static class RayTracingHelper
{
	[Token(Token = "0x40001E3")]
	public const Target ScratchBufferTarget = 16; //Field offset: 0x0

	[Address(RVA = "0x2F63D40", Offset = "0x2F63140", Length = "0x5C")]
	[Token(Token = "0x6000187")]
	public static GraphicsBuffer CreateDispatchIndirectBuffer() { }

	[Address(RVA = "0x2F63ED0", Offset = "0x2F632D0", Length = "0xA7")]
	[Token(Token = "0x6000189")]
	public static GraphicsBuffer CreateScratchBufferForBuild(IRayTracingAccelStruct accelStruct) { }

	[Address(RVA = "0x2F63DA0", Offset = "0x2F631A0", Length = "0x12B")]
	[Token(Token = "0x6000188")]
	public static GraphicsBuffer CreateScratchBufferForBuildAndDispatch(IRayTracingAccelStruct accelStruct, IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth) { }

	[Address(RVA = "0x2F63F80", Offset = "0x2F63380", Length = "0xC4")]
	[Token(Token = "0x600018A")]
	public static GraphicsBuffer CreateScratchBufferForTrace(IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth) { }

	[Address(RVA = "0x2F64050", Offset = "0x2F63450", Length = "0xF1")]
	[Token(Token = "0x600018C")]
	public static void ResizeScratchBufferForBuild(IRayTracingAccelStruct accelStruct, ref GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F64150", Offset = "0x2F63550", Length = "0x110")]
	[Token(Token = "0x600018B")]
	public static void ResizeScratchBufferForTrace(IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth, ref GraphicsBuffer scratchBuffer) { }

}

