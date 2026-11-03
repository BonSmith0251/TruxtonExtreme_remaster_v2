namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000007")]
public class VRDeviceAnalyticAspect : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000006")]
	public float vr_aspect_ratio; //Field offset: 0x30

	[Address(RVA = "0x34795D0", Offset = "0x34789D0", Length = "0x64")]
	[Token(Token = "0x600000A")]
	public VRDeviceAnalyticAspect() { }

	[Address(RVA = "0x3479640", Offset = "0x3478A40", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000009")]
	internal static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect() { }

}

