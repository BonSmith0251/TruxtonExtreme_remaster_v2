namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Modules/VR/VRModule.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[Token(Token = "0x2000002")]
public static class XRSettings
{

	[Token(Token = "0x17000001")]
	public static bool enabled
	{
		[Address(RVA = "0x3491380", Offset = "0x3490780", Length = "0x2A")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
		[Token(Token = "0x6000001")]
		 get { } //Length: 42
	}

	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[NativeName("IntermediateEyeTextureDesc")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x17000005")]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		[Address(RVA = "0x34913F0", Offset = "0x34907F0", Length = "0x49")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 73
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x17000004")]
	public static int eyeTextureHeight
	{
		[Address(RVA = "0x3491440", Offset = "0x3490840", Length = "0x2A")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 42
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x17000003")]
	public static int eyeTextureWidth
	{
		[Address(RVA = "0x3491470", Offset = "0x3490870", Length = "0x2A")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 42
	}

	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x17000002")]
	public static bool isDeviceActive
	{
		[Address(RVA = "0x34914A0", Offset = "0x34908A0", Length = "0x2A")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 42
	}

	[NativeName("DeviceName")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x17000006")]
	public static string loadedDeviceName
	{
		[Address(RVA = "0x3491510", Offset = "0x3490910", Length = "0xA4")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000007")]
	public static String[] supportedDevices
	{
		[Address(RVA = "0x34915C0", Offset = "0x34909C0", Length = "0x2A")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3491380", Offset = "0x3490780", Length = "0x2A")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	[Token(Token = "0x6000001")]
	public static bool get_enabled() { }

	[Address(RVA = "0x34913F0", Offset = "0x34907F0", Length = "0x49")]
	[Token(Token = "0x6000005")]
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	[Address(RVA = "0x34913B0", Offset = "0x34907B0", Length = "0x33")]
	[Token(Token = "0x6000008")]
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }

	[Address(RVA = "0x3491440", Offset = "0x3490840", Length = "0x2A")]
	[Token(Token = "0x6000004")]
	public static int get_eyeTextureHeight() { }

	[Address(RVA = "0x3491470", Offset = "0x3490870", Length = "0x2A")]
	[Token(Token = "0x6000003")]
	public static int get_eyeTextureWidth() { }

	[Address(RVA = "0x34914A0", Offset = "0x34908A0", Length = "0x2A")]
	[Token(Token = "0x6000002")]
	public static bool get_isDeviceActive() { }

	[Address(RVA = "0x3491510", Offset = "0x3490910", Length = "0xA4")]
	[Token(Token = "0x6000006")]
	public static string get_loadedDeviceName() { }

	[Address(RVA = "0x34914D0", Offset = "0x34908D0", Length = "0x33")]
	[Token(Token = "0x6000009")]
	private static void get_loadedDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x34915C0", Offset = "0x34909C0", Length = "0x2A")]
	[Token(Token = "0x6000007")]
	public static String[] get_supportedDevices() { }

}

