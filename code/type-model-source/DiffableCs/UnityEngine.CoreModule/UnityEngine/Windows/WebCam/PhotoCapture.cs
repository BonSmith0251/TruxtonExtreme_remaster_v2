namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
[StaticAccessor("PhotoCapture", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200021D")]
public class PhotoCapture : IDisposable
{
	[Token(Token = "0x2000225")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001781")]
		public static IntPtr ConvertToNative(PhotoCapture photoCapture) { }

	}

	[Token(Token = "0x200021E")]
	internal enum CaptureResultType : int
	{
		Success = 0,
		UnknownError = 1,
	}

	[Token(Token = "0x2000223")]
	internal sealed class OnCapturedToDiskCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x600177D")]
		public OnCapturedToDiskCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x600177E")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x2000224")]
	internal sealed class OnCapturedToMemoryCallback : MulticastDelegate
	{

		[Address(RVA = "0xF76CF0", Offset = "0xF760F0", Length = "0xA6")]
		[Token(Token = "0x600177F")]
		public OnCapturedToMemoryCallback(object object, IntPtr method) { }

		[Address(RVA = "0xF769C0", Offset = "0xF75DC0", Length = "0x24")]
		[Token(Token = "0x6001780")]
		public override void Invoke(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	}

	[Token(Token = "0x2000220")]
	internal sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x6001777")]
		public OnCaptureResourceCreatedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001778")]
		public override void Invoke(PhotoCapture captureObject) { }

	}

	[Token(Token = "0x2000221")]
	internal sealed class OnPhotoModeStartedCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x6001779")]
		public OnPhotoModeStartedCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x600177A")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x2000222")]
	internal sealed class OnPhotoModeStoppedCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x600177B")]
		public OnPhotoModeStoppedCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x600177C")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x200021F")]
	internal struct PhotoCaptureResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000773")]
		public CaptureResultType resultType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000774")]
		public long hResult; //Field offset: 0x8

	}

	[Token(Token = "0x400076F")]
	private static readonly long HR_SUCCESS; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400076E")]
	internal IntPtr m_NativePtr; //Field offset: 0x10

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x600176C")]
	private PhotoCapture(IntPtr nativeCaptureObject) { }

	[Address(RVA = "0x307B490", Offset = "0x307A890", Length = "0x8A")]
	[Token(Token = "0x6001771")]
	public override void Dispose() { }

	[Address(RVA = "0x307B430", Offset = "0x307A830", Length = "0x52")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[Token(Token = "0x6001772")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x307B3F0", Offset = "0x307A7F0", Length = "0x33")]
	[Token(Token = "0x6001775")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x307B390", Offset = "0x307A790", Length = "0x52")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("DisposeThreaded")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6001774")]
	private void DisposeThreaded_Internal() { }

	[Address(RVA = "0x307B350", Offset = "0x307A750", Length = "0x33")]
	[Token(Token = "0x6001776")]
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x307B520", Offset = "0x307A920", Length = "0x8D")]
	[Token(Token = "0x6001773")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x307B5B0", Offset = "0x307A9B0", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x600176F")]
	private static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult) { }

	[Address(RVA = "0x307B650", Offset = "0x307AA50", Length = "0x1DA")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001770")]
	private static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	[Address(RVA = "0x307B830", Offset = "0x307AC30", Length = "0xA4")]
	[RequiredByNativeCode]
	[Token(Token = "0x600176B")]
	private static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[Address(RVA = "0x307B5B0", Offset = "0x307A9B0", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x600176D")]
	private static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult) { }

	[Address(RVA = "0x307B5B0", Offset = "0x307A9B0", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x600176E")]
	private static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult) { }

	[Address(RVA = "0x307B8E0", Offset = "0x307ACE0", Length = "0x69")]
	[Token(Token = "0x600176A")]
	private static PhotoCaptureResult MakeCaptureResult(long hResult) { }

}

