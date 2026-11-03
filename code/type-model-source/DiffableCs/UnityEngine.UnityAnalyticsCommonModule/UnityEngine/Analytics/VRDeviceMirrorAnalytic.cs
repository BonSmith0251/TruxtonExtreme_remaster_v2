namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000008")]
public class VRDeviceMirrorAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000007")]
	public bool vr_device_mirror_mode; //Field offset: 0x30

	[Address(RVA = "0x34795D0", Offset = "0x34789D0", Length = "0x64")]
	[Token(Token = "0x600000C")]
	public VRDeviceMirrorAnalytic() { }

	[Address(RVA = "0x34796D0", Offset = "0x3478AD0", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000B")]
	internal static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic() { }

}

