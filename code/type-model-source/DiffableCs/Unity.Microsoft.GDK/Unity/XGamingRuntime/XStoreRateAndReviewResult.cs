namespace Unity.XGamingRuntime;

[Token(Token = "0x2000275")]
public class XStoreRateAndReviewResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A9")]
	internal XStoreRateAndReviewResult interop; //Field offset: 0x10

	[Token(Token = "0x170002CC")]
	public bool WasUpdated
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000D07")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000D08")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xF54310", Offset = "0xF53710", Length = "0x25")]
	[Token(Token = "0x6000D05")]
	internal XStoreRateAndReviewResult(XStoreRateAndReviewResult interop) { }

	[Address(RVA = "0x2B82F80", Offset = "0x2B82380", Length = "0x1B")]
	[Token(Token = "0x6000D06")]
	public XStoreRateAndReviewResult() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000D07")]
	public bool get_WasUpdated() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6000D08")]
	public void set_WasUpdated(bool value) { }

}

