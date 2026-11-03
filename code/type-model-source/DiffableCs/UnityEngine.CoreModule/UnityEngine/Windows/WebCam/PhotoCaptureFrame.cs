namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
[Token(Token = "0x2000226")]
public sealed class PhotoCaptureFrame : IDisposable
{
	[Token(Token = "0x2000227")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001792")]
		public static IntPtr ConvertToNative(PhotoCaptureFrame photoCaptureFrame) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000775")]
	private IntPtr m_NativePtr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000776")]
	private int <dataLength>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000777")]
	private bool <hasLocationData>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000778")]
	private CapturePixelFormat <pixelFormat>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700037F")]
	public private int dataLength
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001782")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001783")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000380")]
	private bool hasLocationData
	{
		[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001784")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000381")]
	private CapturePixelFormat pixelFormat
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001785")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x307B240", Offset = "0x307A640", Length = "0x105")]
	[Token(Token = "0x6001789")]
	internal PhotoCaptureFrame(IntPtr nativePtr) { }

	[Address(RVA = "0x307AE60", Offset = "0x307A260", Length = "0x9E")]
	[Token(Token = "0x600178A")]
	private void Cleanup() { }

	[Address(RVA = "0x307AFA0", Offset = "0x307A3A0", Length = "0x53")]
	[Token(Token = "0x600178C")]
	public override void Dispose() { }

	[Address(RVA = "0x307AF40", Offset = "0x307A340", Length = "0x52")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x600178B")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x307AF00", Offset = "0x307A300", Length = "0x33")]
	[Token(Token = "0x6001791")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x307B000", Offset = "0x307A400", Length = "0x57")]
	[Token(Token = "0x600178D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001782")]
	public int get_dataLength() { }

	[Address(RVA = "0x307B0A0", Offset = "0x307A4A0", Length = "0x52")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6001788")]
	private CapturePixelFormat GetCapturePixelFormat() { }

	[Address(RVA = "0x307B060", Offset = "0x307A460", Length = "0x33")]
	[Token(Token = "0x6001790")]
	private static CapturePixelFormat GetCapturePixelFormat_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x307B140", Offset = "0x307A540", Length = "0x52")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6001786")]
	private int GetDataLength() { }

	[Address(RVA = "0x307B100", Offset = "0x307A500", Length = "0x33")]
	[Token(Token = "0x600178E")]
	private static int GetDataLength_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x307B1E0", Offset = "0x307A5E0", Length = "0x52")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6001787")]
	private bool GetHasLocationData() { }

	[Address(RVA = "0x307B1A0", Offset = "0x307A5A0", Length = "0x33")]
	[Token(Token = "0x600178F")]
	private static bool GetHasLocationData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001783")]
	private void set_dataLength(int value) { }

	[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001784")]
	private void set_hasLocationData(bool value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001785")]
	private void set_pixelFormat(CapturePixelFormat value) { }

}

