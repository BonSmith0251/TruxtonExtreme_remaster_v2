namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001CF")]
public class UniversalCameraHistory : ICameraHistoryReadAccess, ICameraHistoryWriteAccess, IPerFrameHistoryAccessTracker, IDisposable
{
	[Token(Token = "0x20001D1")]
	private struct Item
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1B")]
		public ContextItem storage; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A1C")]
		public int requestVersion; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000A1D")]
		public int writeVersion; //Field offset: 0xC

		[Address(RVA = "0x2E070F0", Offset = "0x2E064F0", Length = "0x38")]
		[Token(Token = "0x6000A14")]
		public void Reset() { }

	}

	[Token(Token = "0x20001D0")]
	private static class TypeId
	{
		[Token(Token = "0x4000A1A")]
		public static uint value; //Field offset: 0x0

		[Address(RVA = "0x10DF610", Offset = "0x10DEA10", Length = "0x94")]
		[Token(Token = "0x6000A13")]
		private static TypeId`1() { }

	}

	[Token(Token = "0x4000A14")]
	private const int k_ValidVersionCount = 2; //Field offset: 0x0
	[Token(Token = "0x4000A15")]
	private static uint s_TypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A16")]
	private Item[] m_Items; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A17")]
	private int m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A18")]
	private BufferedRTHandleSystem m_HistoryTextures; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A19")]
	private HistoryRequestDelegate OnGatherHistoryRequests; //Field offset: 0x28

	[Token(Token = "0x14000006")]
	public override event HistoryRequestDelegate OnGatherHistoryRequests
	{
		[Address(RVA = "0x2E0BAF0", Offset = "0x2E0AEF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0A")]
		 add { } //Length: 158
		[Address(RVA = "0x2E0BB90", Offset = "0x2E0AF90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0B")]
		 remove { } //Length: 158
	}

	[Address(RVA = "0x2E0B9D0", Offset = "0x2E0ADD0", Length = "0x116")]
	[Token(Token = "0x6000A0C")]
	internal UniversalCameraHistory() { }

	[Address(RVA = "0x2E0BAF0", Offset = "0x2E0AEF0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0A")]
	public override void add_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	[Address(RVA = "0x2E0B7B0", Offset = "0x2E0ABB0", Length = "0xB3")]
	[Token(Token = "0x6000A0D")]
	public override void Dispose() { }

	[Address(RVA = "0x2E0B870", Offset = "0x2E0AC70", Length = "0x1C")]
	[Token(Token = "0x6000A0E")]
	internal void GatherHistoryRequests() { }

	[Address(RVA = "0x9D54E0", Offset = "0x9D48E0", Length = "0x10C")]
	[Token(Token = "0x6000A06")]
	public override Type GetHistoryForRead() { }

	[Address(RVA = "0x9D55F0", Offset = "0x9D49F0", Length = "0x1E1")]
	[Token(Token = "0x6000A08")]
	public override Type GetHistoryForWrite() { }

	[Address(RVA = "0x9D57E0", Offset = "0x9D4BE0", Length = "0xA4")]
	[Token(Token = "0x6000A07")]
	public override bool IsAccessRequested() { }

	[Address(RVA = "0x2E0B8D0", Offset = "0x2E0ACD0", Length = "0x3A")]
	[Token(Token = "0x6000A10")]
	private bool IsValid(int i) { }

	[Address(RVA = "0x2E0B890", Offset = "0x2E0AC90", Length = "0x3A")]
	[Token(Token = "0x6000A0F")]
	private bool IsValidRequest(int i) { }

	[Address(RVA = "0x9D5890", Offset = "0x9D4C90", Length = "0xB2")]
	[Token(Token = "0x6000A09")]
	public override bool IsWritten() { }

	[Address(RVA = "0x2E0B910", Offset = "0x2E0AD10", Length = "0x95")]
	[Token(Token = "0x6000A11")]
	internal void ReleaseUnusedHistory() { }

	[Address(RVA = "0x2E0BB90", Offset = "0x2E0AF90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0B")]
	public override void remove_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	[Address(RVA = "0x9D5950", Offset = "0x9D4D50", Length = "0x1D5")]
	[Token(Token = "0x6000A05")]
	public override void RequestAccess() { }

	[Address(RVA = "0x2E0B9B0", Offset = "0x2E0ADB0", Length = "0x1E")]
	[Token(Token = "0x6000A12")]
	internal void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight) { }

}

