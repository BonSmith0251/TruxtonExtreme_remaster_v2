namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000A")]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000009")]
	public String[] vr_active_controllers; //Field offset: 0x30

	[Address(RVA = "0x34795D0", Offset = "0x34789D0", Length = "0x64")]
	[Token(Token = "0x6000010")]
	public VRDeviceActiveControllersAnalytic() { }

	[Address(RVA = "0x3479540", Offset = "0x3478940", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

}

