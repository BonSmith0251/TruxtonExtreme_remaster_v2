namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("Text Data Provider")]
[Token(Token = "0x200006A")]
public class TextDataProvider : ResourceProviderBase
{
	[Token(Token = "0x200006B")]
	public class InternalOp
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011D")]
		private TextDataProvider m_Provider; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011E")]
		private UnityWebRequestAsyncOperation m_RequestOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011F")]
		private WebRequestQueueOperation m_RequestQueueOperation; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000120")]
		private ProvideHandle m_PI; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000121")]
		private bool m_IgnoreFailures; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x4000122")]
		private bool m_Complete; //Field offset: 0x41
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000123")]
		private int m_Timeout; //Field offset: 0x44

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000267")]
		public InternalOp() { }

		[Address(RVA = "0x2E44950", Offset = "0x2E43D50", Length = "0x9C")]
		[CompilerGenerated]
		[Token(Token = "0x6000268")]
		private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }

		[Address(RVA = "0x2E42760", Offset = "0x2E41B60", Length = "0x97")]
		[Token(Token = "0x6000264")]
		protected void CompleteOperation(string text, Exception exception) { }

		[Address(RVA = "0x2E428A0", Offset = "0x2E41CA0", Length = "0xD8")]
		[Token(Token = "0x6000265")]
		private object ConvertText(string text) { }

		[Address(RVA = "0x2E39370", Offset = "0x2E38770", Length = "0x16")]
		[Token(Token = "0x6000260")]
		private float GetPercentComplete() { }

		[Address(RVA = "0x2E43230", Offset = "0x2E42630", Length = "0x280")]
		[Token(Token = "0x6000263")]
		private void RequestOperation_completed(AsyncOperation op) { }

		[Address(RVA = "0x2E43770", Offset = "0x2E42B70", Length = "0x364")]
		[Token(Token = "0x6000266")]
		protected override void SendWebRequest(string path) { }

		[Address(RVA = "0x2E44490", Offset = "0x2E43890", Length = "0x412")]
		[Token(Token = "0x6000261")]
		public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider) { }

		[Address(RVA = "0x2E44B60", Offset = "0x2E43F60", Length = "0x6B")]
		[Token(Token = "0x6000262")]
		private bool WaitForCompletionHandler() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011C")]
	private bool <IgnoreFailures>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000061")]
	public bool IgnoreFailures
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600025B")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600025C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600025F")]
	public TextDataProvider() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x600025D")]
	public override object Convert(Type type, string text) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600025B")]
	public bool get_IgnoreFailures() { }

	[Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", Length = "0x8A")]
	[Token(Token = "0x600025E")]
	public virtual void Provide(ProvideHandle provideHandle) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600025C")]
	public void set_IgnoreFailures(bool value) { }

}

