namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[RequiredByNativeCode]
[StaticAccessor("GetVFXManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000B")]
public static class VFXManager
{
	[Token(Token = "0x400001C")]
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; //Field offset: 0x0

	[Token(Token = "0x17000003")]
	public static float fixedTimeStep
	{
		[Address(RVA = "0x34819A0", Offset = "0x3480DA0", Length = "0x2A")]
		[Token(Token = "0x600003B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000004")]
	public static float maxDeltaTime
	{
		[Address(RVA = "0x34819D0", Offset = "0x3480DD0", Length = "0x2A")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000005")]
	internal static float maxScrubTime
	{
		[Address(RVA = "0x3481A00", Offset = "0x3480E00", Length = "0x2A")]
		[Token(Token = "0x600003D")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x17000002")]
	internal static ScriptableObject runtimeResources
	{
		[Address(RVA = "0x3481A60", Offset = "0x3480E60", Length = "0x75")]
		[Token(Token = "0x600003A")]
		internal get { } //Length: 117
	}

	[Address(RVA = "0x3481940", Offset = "0x3480D40", Length = "0x54")]
	[Token(Token = "0x6000044")]
	private static VFXManager() { }

	[Address(RVA = "0x34819A0", Offset = "0x3480DA0", Length = "0x2A")]
	[Token(Token = "0x600003B")]
	public static float get_fixedTimeStep() { }

	[Address(RVA = "0x34819D0", Offset = "0x3480DD0", Length = "0x2A")]
	[Token(Token = "0x600003C")]
	public static float get_maxDeltaTime() { }

	[Address(RVA = "0x3481A00", Offset = "0x3480E00", Length = "0x2A")]
	[Token(Token = "0x600003D")]
	internal static float get_maxScrubTime() { }

	[Address(RVA = "0x3481A60", Offset = "0x3480E60", Length = "0x75")]
	[Token(Token = "0x600003A")]
	internal static ScriptableObject get_runtimeResources() { }

	[Address(RVA = "0x3481A30", Offset = "0x3480E30", Length = "0x2A")]
	[Token(Token = "0x6000045")]
	private static IntPtr get_runtimeResources_Injected() { }

	[Address(RVA = "0x3481220", Offset = "0x3480620", Length = "0x104")]
	[Token(Token = "0x6000041")]
	private static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults) { }

	[Address(RVA = "0x34811B0", Offset = "0x34805B0", Length = "0x62")]
	[Token(Token = "0x6000047")]
	private static void Internal_ProcessCameraCommand_Injected(IntPtr cam, IntPtr cmd, in VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults) { }

	[Address(RVA = "0x3481370", Offset = "0x3480770", Length = "0xBC")]
	[Token(Token = "0x6000042")]
	public static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam) { }

	[Address(RVA = "0x3481330", Offset = "0x3480730", Length = "0x33")]
	[Token(Token = "0x6000048")]
	private static VFXCameraBufferTypes IsCameraBufferNeeded_Injected(IntPtr cam) { }

	[Address(RVA = "0x3481480", Offset = "0x3480880", Length = "0x111")]
	[Token(Token = "0x600003E")]
	public static void PrepareCamera(Camera cam) { }

	[Address(RVA = "0x34815A0", Offset = "0x34809A0", Length = "0xCB")]
	[Token(Token = "0x600003F")]
	public static void PrepareCamera(Camera cam, VFXCameraXRSettings camXRSettings) { }

	[Address(RVA = "0x3481430", Offset = "0x3480830", Length = "0x42")]
	[Token(Token = "0x6000046")]
	private static void PrepareCamera_Injected(IntPtr cam, in VFXCameraXRSettings camXRSettings) { }

	[Address(RVA = "0x3481670", Offset = "0x3480A70", Length = "0x141")]
	[Token(Token = "0x6000040")]
	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

	[Address(RVA = "0x3481820", Offset = "0x3480C20", Length = "0x118")]
	[Token(Token = "0x6000043")]
	public static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height) { }

	[Address(RVA = "0x34817C0", Offset = "0x3480BC0", Length = "0x60")]
	[Token(Token = "0x6000049")]
	private static void SetCameraBuffer_Injected(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height) { }

}

