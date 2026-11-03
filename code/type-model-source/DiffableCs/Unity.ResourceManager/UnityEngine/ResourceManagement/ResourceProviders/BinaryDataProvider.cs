namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("Binary Data Provider")]
[Token(Token = "0x2000053")]
internal class BinaryDataProvider : ResourceProviderBase
{
	[Token(Token = "0x2000054")]
	public class InternalOp
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E9")]
		private BinaryDataProvider m_Provider; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000EA")]
		private UnityWebRequestAsyncOperation m_RequestOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000EB")]
		private WebRequestQueueOperation m_RequestQueueOperation; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000EC")]
		private ProvideHandle m_PI; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000ED")]
		private bool m_IgnoreFailures; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x40000EE")]
		private bool m_Complete; //Field offset: 0x41
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40000EF")]
		private int m_Timeout; //Field offset: 0x44

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001EB")]
		public InternalOp() { }

		[Address(RVA = "0x2E448B0", Offset = "0x2E43CB0", Length = "0x9C")]
		[CompilerGenerated]
		[Token(Token = "0x60001EC")]
		private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }

		[Address(RVA = "0x2E42800", Offset = "0x2E41C00", Length = "0x95")]
		[Token(Token = "0x60001E8")]
		protected void CompleteOperation(Byte[] data, Exception exception) { }

		[Address(RVA = "0x2E428A0", Offset = "0x2E41CA0", Length = "0xD8")]
		[Token(Token = "0x60001E9")]
		private object ConvertBytes(Byte[] data) { }

		[Address(RVA = "0x2E39370", Offset = "0x2E38770", Length = "0x16")]
		[Token(Token = "0x60001E4")]
		private float GetPercentComplete() { }

		[Address(RVA = "0x2E42FA0", Offset = "0x2E423A0", Length = "0x280")]
		[Token(Token = "0x60001E7")]
		private void RequestOperation_completed(AsyncOperation op) { }

		[Address(RVA = "0x2E434C0", Offset = "0x2E428C0", Length = "0x2A8")]
		[Token(Token = "0x60001EA")]
		protected override void SendWebRequest(string path) { }

		[Address(RVA = "0x2E43AE0", Offset = "0x2E42EE0", Length = "0x49F")]
		[Token(Token = "0x60001E5")]
		public void Start(ProvideHandle provideHandle, BinaryDataProvider rawProvider) { }

		[Address(RVA = "0x2E44AF0", Offset = "0x2E43EF0", Length = "0x6B")]
		[Token(Token = "0x60001E6")]
		private bool WaitForCompletionHandler() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E8")]
	private bool <IgnoreFailures>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700004A")]
	public bool IgnoreFailures
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001DF")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001E0")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001E3")]
	public BinaryDataProvider() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x60001E1")]
	public override object Convert(Type type, Byte[] data) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001DF")]
	public bool get_IgnoreFailures() { }

	[Address(RVA = "0x2E3C4D0", Offset = "0x2E3B8D0", Length = "0x8A")]
	[Token(Token = "0x60001E2")]
	public virtual void Provide(ProvideHandle provideHandle) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001E0")]
	public void set_IgnoreFailures(bool value) { }

}

