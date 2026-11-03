namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000334")]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400085D")]
	public int launch_type; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400085E")]
	public int launch_process_type; //Field offset: 0x34

	[Address(RVA = "0x30958F0", Offset = "0x3094CF0", Length = "0x8F")]
	[Token(Token = "0x60019E1")]
	public UaaLApplicationLaunchAnalytic() { }

	[Address(RVA = "0x3095830", Offset = "0x3094C30", Length = "0xBB")]
	[RequiredByNativeCode]
	[Token(Token = "0x60019E2")]
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }

}

