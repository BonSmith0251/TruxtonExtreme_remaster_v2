namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000009")]
public class VRDeviceUserAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000008")]
	public int vr_user_presence; //Field offset: 0x30

	[Address(RVA = "0x34795D0", Offset = "0x34789D0", Length = "0x64")]
	[Token(Token = "0x600000E")]
	public VRDeviceUserAnalytic() { }

	[Address(RVA = "0x3479760", Offset = "0x3478B60", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000D")]
	internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic() { }

}

