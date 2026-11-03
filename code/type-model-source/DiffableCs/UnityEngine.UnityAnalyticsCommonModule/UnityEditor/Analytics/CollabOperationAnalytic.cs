namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000D")]
public class CollabOperationAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000021")]
	public string category; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000022")]
	public string operation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000023")]
	public string result; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000024")]
	public long start_ts; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000025")]
	public long duration; //Field offset: 0x50

	[Address(RVA = "0x3477D00", Offset = "0x3477100", Length = "0x64")]
	[Token(Token = "0x6000015")]
	public CollabOperationAnalytic() { }

	[Address(RVA = "0x3477C70", Offset = "0x3477070", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000016")]
	internal static CollabOperationAnalytic CreateCollabOperationAnalytic() { }

}

