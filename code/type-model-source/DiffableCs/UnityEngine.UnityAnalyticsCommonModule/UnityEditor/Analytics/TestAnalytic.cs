namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000022")]
internal class TestAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005E")]
	public int param; //Field offset: 0x30

	[Address(RVA = "0x34793D0", Offset = "0x34787D0", Length = "0x64")]
	[Token(Token = "0x600003E")]
	public TestAnalytic() { }

	[Address(RVA = "0x3479340", Offset = "0x3478740", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003F")]
	public static TestAnalytic CreateTestAnalytic() { }

}

