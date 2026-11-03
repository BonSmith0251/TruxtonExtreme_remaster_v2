namespace UnityEngine.Android;

[NativeHeader("Modules/AndroidJNI/Public/AndroidApplication.bindings.h")]
[StaticAccessor("AndroidApplication", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000010")]
public static class AndroidApplication
{
	[Token(Token = "0x4000022")]
	private static SynchronizationContext m_MainThreadSynchronizationContext; //Field offset: 0x0
	[Token(Token = "0x4000023")]
	private static AndroidConfiguration m_CurrentConfiguration; //Field offset: 0x8
	[Token(Token = "0x4000024")]
	private static AndroidInsets m_CurrentAndroidInsets; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000025")]
	private static Action<AndroidConfiguration> onConfigurationChanged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000026")]
	private static Action<AndroidInsets> onInsetsChanged; //Field offset: 0x20

	[Token(Token = "0x17000002")]
	internal static IntPtr UnityPlayerRaw
	{
		[Address(RVA = "0x2F9C560", Offset = "0x2F9B960", Length = "0x2A")]
		[ThreadSafe]
		[Token(Token = "0x6000101")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x2F9C2A0", Offset = "0x2F9B6A0", Length = "0xB9")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000102")]
	private static void AcquireMainThreadSynchronizationContext() { }

	[Address(RVA = "0x2F9C360", Offset = "0x2F9B760", Length = "0x5E")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000105")]
	private static void DispatchConfigurationChanged(bool notifySubscribers) { }

	[Address(RVA = "0x2F9C3C0", Offset = "0x2F9B7C0", Length = "0x53")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000108")]
	private static void DispatchInsetsChanged() { }

	[Address(RVA = "0x2F9C560", Offset = "0x2F9B960", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x6000101")]
	internal static IntPtr get_UnityPlayerRaw() { }

	[Address(RVA = "0x2F9C420", Offset = "0x2F9B820", Length = "0x37")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000104")]
	private static AndroidConfiguration GetCurrentConfiguration() { }

	[Address(RVA = "0x2F9C460", Offset = "0x2F9B860", Length = "0x37")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000107")]
	private static AndroidInsets GetCurrentInsets() { }

	[Address(RVA = "0x2F9C4A0", Offset = "0x2F9B8A0", Length = "0x56")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000103")]
	private static void SetCurrentConfiguration(AndroidConfiguration config) { }

	[Address(RVA = "0x2F9C500", Offset = "0x2F9B900", Length = "0x56")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000106")]
	private static void SetCurrentInsets(AndroidInsets insets) { }

}

