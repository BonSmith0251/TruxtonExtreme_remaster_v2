namespace UnityEngineInternal.Input;

[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
[Token(Token = "0x2000007")]
internal class NativeInputSystem
{
	[Token(Token = "0x4000018")]
	public static NativeUpdateCallback onUpdate; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	public static Action<NativeInputUpdateType> onBeforeUpdate; //Field offset: 0x8
	[Token(Token = "0x400001A")]
	public static Func<NativeInputUpdateType, Boolean> onShouldRunUpdate; //Field offset: 0x10
	[Token(Token = "0x400001B")]
	private static Action<Int32, String> s_OnDeviceDiscoveredCallback; //Field offset: 0x18

	[NativeProperty(IsThreadSafe = True)]
	[Token(Token = "0x17000003")]
	public static double currentTime
	{
		[Address(RVA = "0x3113760", Offset = "0x3112B60", Length = "0x2A")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 42
	}

	[NativeProperty(IsThreadSafe = True)]
	[Token(Token = "0x17000004")]
	public static double currentTimeOffsetToRealtimeSinceStartup
	{
		[Address(RVA = "0x3113730", Offset = "0x3112B30", Length = "0x2A")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000002")]
	internal static bool hasDeviceDiscoveredCallback
	{
		[Address(RVA = "0x3113810", Offset = "0x3112C10", Length = "0x33")]
		[Token(Token = "0x600000A")]
		internal set { } //Length: 51
	}

	[NativeProperty("NormalizeScrollWheelDelta")]
	[Token(Token = "0x17000005")]
	internal static bool normalizeScrollWheelDelta
	{
		[Address(RVA = "0x3113790", Offset = "0x3112B90", Length = "0x2A")]
		[Token(Token = "0x6000013")]
		internal get { } //Length: 42
		[Address(RVA = "0x3113850", Offset = "0x3112C50", Length = "0x33")]
		[Token(Token = "0x6000014")]
		internal set { } //Length: 51
	}

	[Token(Token = "0x17000001")]
	public static Action<Int32, String> onDeviceDiscovered
	{
		[Address(RVA = "0x31137C0", Offset = "0x3112BC0", Length = "0x4F")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 79
		[Address(RVA = "0x3113890", Offset = "0x3112C90", Length = "0xA8")]
		[Token(Token = "0x6000004")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x3113700", Offset = "0x3112B00", Length = "0x2C")]
	[Token(Token = "0x6000005")]
	private static NativeInputSystem() { }

	[Address(RVA = "0x3113330", Offset = "0x3112730", Length = "0x2A")]
	[FreeFunction("AllocateInputDeviceId")]
	[Token(Token = "0x600000D")]
	public static int AllocateDeviceId() { }

	[Address(RVA = "0x3113760", Offset = "0x3112B60", Length = "0x2A")]
	[Token(Token = "0x600000B")]
	public static double get_currentTime() { }

	[Address(RVA = "0x3113730", Offset = "0x3112B30", Length = "0x2A")]
	[Token(Token = "0x600000C")]
	public static double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[Address(RVA = "0x3113790", Offset = "0x3112B90", Length = "0x2A")]
	[Token(Token = "0x6000013")]
	internal static bool get_normalizeScrollWheelDelta() { }

	[Address(RVA = "0x31137C0", Offset = "0x3112BC0", Length = "0x4F")]
	[Token(Token = "0x6000003")]
	public static Action<Int32, String> get_onDeviceDiscovered() { }

	[Address(RVA = "0x3113360", Offset = "0x3112760", Length = "0x2A")]
	[Token(Token = "0x6000011")]
	public static float GetPollingFrequency() { }

	[Address(RVA = "0x3113390", Offset = "0x3112790", Length = "0x2A")]
	[Token(Token = "0x6000015")]
	internal static float GetScrollWheelDeltaPerTick() { }

	[Address(RVA = "0x31133C0", Offset = "0x31127C0", Length = "0x5E")]
	[Token(Token = "0x600000F")]
	public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) { }

	[Address(RVA = "0x3113420", Offset = "0x3112820", Length = "0x6F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000006")]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[Address(RVA = "0x3113490", Offset = "0x3112890", Length = "0x78")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000008")]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[Address(RVA = "0x3113510", Offset = "0x3112910", Length = "0x92")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[Address(RVA = "0x31135B0", Offset = "0x31129B0", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600000E")]
	public static void QueueInputEvent(IntPtr inputEvent) { }

	[Address(RVA = "0x3113810", Offset = "0x3112C10", Length = "0x33")]
	[Token(Token = "0x600000A")]
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	[Address(RVA = "0x3113850", Offset = "0x3112C50", Length = "0x33")]
	[Token(Token = "0x6000014")]
	internal static void set_normalizeScrollWheelDelta(bool value) { }

	[Address(RVA = "0x3113890", Offset = "0x3112C90", Length = "0xA8")]
	[Token(Token = "0x6000004")]
	public static void set_onDeviceDiscovered(Action<Int32, String> value) { }

	[Address(RVA = "0x31135F0", Offset = "0x31129F0", Length = "0x3A")]
	[Token(Token = "0x6000010")]
	public static void SetPollingFrequency(float hertz) { }

	[Address(RVA = "0x3113630", Offset = "0x3112A30", Length = "0x85")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000009")]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	[Address(RVA = "0x31136C0", Offset = "0x3112AC0", Length = "0x31")]
	[Token(Token = "0x6000012")]
	public static void Update(NativeInputUpdateType updateType) { }

}

