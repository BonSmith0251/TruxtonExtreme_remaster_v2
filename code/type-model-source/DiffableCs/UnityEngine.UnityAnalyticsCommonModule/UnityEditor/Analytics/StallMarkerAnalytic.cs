namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000021")]
internal class StallMarkerAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005B")]
	public string Name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400005C")]
	public bool HasProgressMarkup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400005D")]
	public double Duration; //Field offset: 0x40

	[Address(RVA = "0x3478DE0", Offset = "0x34781E0", Length = "0x64")]
	[Token(Token = "0x600003C")]
	public StallMarkerAnalytic() { }

	[Address(RVA = "0x3478D50", Offset = "0x3478150", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003D")]
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }

}

