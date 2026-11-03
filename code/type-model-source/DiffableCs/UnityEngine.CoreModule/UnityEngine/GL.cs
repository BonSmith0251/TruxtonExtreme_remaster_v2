namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/CameraUtil.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000DD")]
public sealed class GL
{

	[Token(Token = "0x17000122")]
	public static Matrix4x4 modelview
	{
		[Address(RVA = "0x2FF2FF0", Offset = "0x2FF23F0", Length = "0x52")]
		[Token(Token = "0x6000673")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000121")]
	public static bool wireframe
	{
		[Address(RVA = "0x2FF2FC0", Offset = "0x2FF23C0", Length = "0x2A")]
		[Token(Token = "0x6000670")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2FF27F0", Offset = "0x2FF1BF0", Length = "0x31")]
	[FreeFunction("GLBegin", ThrowsException = True)]
	[Token(Token = "0x6000678")]
	public static void Begin(int mode) { }

	[Address(RVA = "0x2FF28A0", Offset = "0x2FF1CA0", Length = "0x59")]
	[Token(Token = "0x600067C")]
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Address(RVA = "0x2FF2830", Offset = "0x2FF1C30", Length = "0x61")]
	[Token(Token = "0x600067B")]
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x2FF2900", Offset = "0x2FF1D00", Length = "0x43")]
	[Token(Token = "0x600066F")]
	public static void Color(Color c) { }

	[Address(RVA = "0x2FF2950", Offset = "0x2FF1D50", Length = "0x2A")]
	[FreeFunction("GLEnd")]
	[Token(Token = "0x6000679")]
	public static void End() { }

	[Address(RVA = "0x2FF2980", Offset = "0x2FF1D80", Length = "0x2A")]
	[Token(Token = "0x6000671")]
	public static void Flush() { }

	[Address(RVA = "0x2FF2FC0", Offset = "0x2FF23C0", Length = "0x2A")]
	[Token(Token = "0x6000670")]
	public static bool get_wireframe() { }

	[Address(RVA = "0x2FF2B70", Offset = "0x2FF1F70", Length = "0x69")]
	[FreeFunction("GLGetGPUProjectionMatrix")]
	[Token(Token = "0x6000675")]
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[Address(RVA = "0x2FF2B10", Offset = "0x2FF1F10", Length = "0x53")]
	[Token(Token = "0x6000680")]
	private static void GetGPUProjectionMatrix_Injected(in Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FF2A20", Offset = "0x2FF1E20", Length = "0x64")]
	[FreeFunction]
	[Token(Token = "0x600067A")]
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x2FF29B0", Offset = "0x2FF1DB0", Length = "0x64")]
	[Token(Token = "0x6000681")]
	private static void GLClear_Injected(bool clearDepth, bool clearColor, in Color backgroundColor, float depth) { }

	[Address(RVA = "0x2FF2A90", Offset = "0x2FF1E90", Length = "0x72")]
	[FreeFunction]
	[Token(Token = "0x6000676")]
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	[Address(RVA = "0x2FF2BE0", Offset = "0x2FF1FE0", Length = "0x72")]
	[NativeName("ImmediateColor")]
	[Token(Token = "0x600066E")]
	private static void ImmediateColor(float r, float g, float b, float a) { }

	[Address(RVA = "0x2FF2A90", Offset = "0x2FF1E90", Length = "0x72")]
	[Token(Token = "0x6000677")]
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[Address(RVA = "0x2FF2CA0", Offset = "0x2FF20A0", Length = "0x33")]
	[FreeFunction("GLLoadProjectionMatrixScript")]
	[Token(Token = "0x6000674")]
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[Address(RVA = "0x2FF2C60", Offset = "0x2FF2060", Length = "0x33")]
	[Token(Token = "0x600067F")]
	private static void LoadProjectionMatrix_Injected(in Matrix4x4 mat) { }

	[Address(RVA = "0x2FF2CE0", Offset = "0x2FF20E0", Length = "0x54")]
	[Token(Token = "0x600066D")]
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[Address(RVA = "0x2FF2D40", Offset = "0x2FF2140", Length = "0x65")]
	[NativeName("ImmediateTexCoord")]
	[Token(Token = "0x600066C")]
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	[Address(RVA = "0x2FF2FF0", Offset = "0x2FF23F0", Length = "0x52")]
	[Token(Token = "0x6000673")]
	public static void set_modelview(Matrix4x4 value) { }

	[Address(RVA = "0x2FF2DF0", Offset = "0x2FF21F0", Length = "0x33")]
	[Token(Token = "0x6000672")]
	private static void SetViewMatrix(Matrix4x4 m) { }

	[Address(RVA = "0x2FF2DB0", Offset = "0x2FF21B0", Length = "0x33")]
	[Token(Token = "0x600067E")]
	private static void SetViewMatrix_Injected(in Matrix4x4 m) { }

	[Address(RVA = "0x2FF2E30", Offset = "0x2FF2230", Length = "0x4D")]
	[Token(Token = "0x600066B")]
	public static void TexCoord2(float x, float y) { }

	[Address(RVA = "0x2FF2E80", Offset = "0x2FF2280", Length = "0x5E")]
	[NativeName("ImmediateTexCoordAll")]
	[Token(Token = "0x600066A")]
	public static void TexCoord3(float x, float y, float z) { }

	[Address(RVA = "0x2FF2EE0", Offset = "0x2FF22E0", Length = "0x5E")]
	[NativeName("ImmediateVertex")]
	[Token(Token = "0x6000669")]
	public static void Vertex3(float x, float y, float z) { }

	[Address(RVA = "0x2FF2F80", Offset = "0x2FF2380", Length = "0x33")]
	[FreeFunction("SetGLViewport")]
	[Token(Token = "0x600067D")]
	public static void Viewport(Rect pixelRect) { }

	[Address(RVA = "0x2FF2F40", Offset = "0x2FF2340", Length = "0x33")]
	[Token(Token = "0x6000682")]
	private static void Viewport_Injected(in Rect pixelRect) { }

}

