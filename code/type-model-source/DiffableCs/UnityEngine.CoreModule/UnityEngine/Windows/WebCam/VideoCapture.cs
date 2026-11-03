namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
[StaticAccessor("VideoCaptureBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000228")]
public class VideoCapture : IDisposable
{
	[Token(Token = "0x2000230")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x60017AA")]
		public static IntPtr ConvertToNative(VideoCapture videoCapture) { }

	}

	[Token(Token = "0x2000229")]
	internal enum CaptureResultType : int
	{
		Success = 0,
		UnknownError = 1,
	}

	[Token(Token = "0x200022E")]
	internal sealed class OnStartedRecordingVideoCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x60017A6")]
		public OnStartedRecordingVideoCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x60017A7")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x200022F")]
	internal sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x60017A8")]
		public OnStoppedRecordingVideoCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x60017A9")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x200022B")]
	internal sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x60017A0")]
		public OnVideoCaptureResourceCreatedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60017A1")]
		public override void Invoke(VideoCapture captureObject) { }

	}

	[Token(Token = "0x200022C")]
	internal sealed class OnVideoModeStartedCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x60017A2")]
		public OnVideoModeStartedCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x60017A3")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x200022D")]
	internal sealed class OnVideoModeStoppedCallback : MulticastDelegate
	{

		[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
		[Token(Token = "0x60017A4")]
		public OnVideoModeStoppedCallback(object object, IntPtr method) { }

		[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
		[Token(Token = "0x60017A5")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x200022A")]
	internal struct VideoCaptureResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077E")]
		public CaptureResultType resultType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400077F")]
		public long hResult; //Field offset: 0x8

	}

	[Token(Token = "0x400077A")]
	private static readonly long HR_SUCCESS; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000779")]
	internal IntPtr m_NativePtr; //Field offset: 0x10

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6001795")]
	private VideoCapture(IntPtr nativeCaptureObject) { }

	[Address(RVA = "0x3097990", Offset = "0x3096D90", Length = "0x8A")]
	[Token(Token = "0x600179A")]
	public override void Dispose() { }

	[Address(RVA = "0x3097930", Offset = "0x3096D30", Length = "0x52")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	[Token(Token = "0x600179B")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x30978F0", Offset = "0x3096CF0", Length = "0x33")]
	[Token(Token = "0x600179E")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3097890", Offset = "0x3096C90", Length = "0x52")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x600179D")]
	private void DisposeThreaded_Internal() { }

	[Address(RVA = "0x3097850", Offset = "0x3096C50", Length = "0x33")]
	[Token(Token = "0x600179F")]
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3097A20", Offset = "0x3096E20", Length = "0x8D")]
	[Token(Token = "0x600179C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3097AB0", Offset = "0x3096EB0", Length = "0xA4")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001794")]
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[Address(RVA = "0x3097B60", Offset = "0x3096F60", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001798")]
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult) { }

	[Address(RVA = "0x3097B60", Offset = "0x3096F60", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001799")]
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult) { }

	[Address(RVA = "0x3097B60", Offset = "0x3096F60", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001796")]
	private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult) { }

	[Address(RVA = "0x3097B60", Offset = "0x3096F60", Length = "0x97")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001797")]
	private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult) { }

	[Address(RVA = "0x3097C00", Offset = "0x3097000", Length = "0xB8")]
	[Token(Token = "0x6001793")]
	private static VideoCaptureResult MakeCaptureResult(long hResult) { }

}

