namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000E")]
public class LicensingErrorAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000026")]
	public string licensingErrorType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000027")]
	public string additionalData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000028")]
	public string errorMessage; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000029")]
	public string correlationId; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400002A")]
	public string sessionId; //Field offset: 0x50

	[Address(RVA = "0x3477E00", Offset = "0x3477200", Length = "0x64")]
	[Token(Token = "0x6000017")]
	public LicensingErrorAnalytic() { }

	[Address(RVA = "0x3477D70", Offset = "0x3477170", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000018")]
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }

}

