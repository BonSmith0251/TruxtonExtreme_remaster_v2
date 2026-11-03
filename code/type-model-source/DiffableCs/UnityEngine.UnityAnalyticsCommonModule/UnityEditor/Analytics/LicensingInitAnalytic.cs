namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000F")]
public class LicensingInitAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002B")]
	public string licensingProtocolVersion; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400002C")]
	public string licensingClientVersion; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002D")]
	public string channelType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400002E")]
	public double initTime; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400002F")]
	public bool isLegacy; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000030")]
	public string sessionId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000031")]
	public string correlationId; //Field offset: 0x60

	[Address(RVA = "0x3477F00", Offset = "0x3477300", Length = "0x64")]
	[Token(Token = "0x6000019")]
	public LicensingInitAnalytic() { }

	[Address(RVA = "0x3477E70", Offset = "0x3477270", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001A")]
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }

}

