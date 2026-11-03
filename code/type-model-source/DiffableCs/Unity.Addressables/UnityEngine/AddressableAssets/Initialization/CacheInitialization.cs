namespace UnityEngine.AddressableAssets.Initialization;

[Token(Token = "0x200005E")]
public class CacheInitialization : IInitializableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000150")]
		public CacheInitialization <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000151")]
		public string id; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000152")]
		public string data; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000257")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x27B9B10", Offset = "0x27B8F10", Length = "0x14C")]
		[Token(Token = "0x6000258")]
		internal bool <InitializeAsync>b__0() { }

	}

	[Token(Token = "0x200005F")]
	private class CacheInitOp : AsyncOperationBase<Boolean>, IUpdateReceiver
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400014E")]
		private Func<Boolean> m_Callback; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400014F")]
		private bool m_UpdateRequired; //Field offset: 0xA0

		[Address(RVA = "0x27B6F50", Offset = "0x27B6350", Length = "0x40")]
		[Token(Token = "0x6000256")]
		public CacheInitOp() { }

		[Address(RVA = "0x27B6D40", Offset = "0x27B6140", Length = "0xA1")]
		[Token(Token = "0x6000255")]
		protected virtual void Execute() { }

		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6000252")]
		public void Init(Func<Boolean> callback) { }

		[Address(RVA = "0x27B6DF0", Offset = "0x27B61F0", Length = "0x8E")]
		[Token(Token = "0x6000253")]
		protected virtual bool InvokeWaitForCompletion() { }

		[Address(RVA = "0x27B6E80", Offset = "0x27B6280", Length = "0xC4")]
		[Token(Token = "0x6000254")]
		public override void Update(float unscaledDeltaTime) { }

	}


	[Token(Token = "0x17000066")]
	public static string RootPath
	{
		[Address(RVA = "0x27B7300", Offset = "0x27B6700", Length = "0x69")]
		[Token(Token = "0x6000250")]
		 get { } //Length: 105
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000251")]
	public CacheInitialization() { }

	[Address(RVA = "0x27B7300", Offset = "0x27B6700", Length = "0x69")]
	[Token(Token = "0x6000250")]
	public static string get_RootPath() { }

	[Address(RVA = "0x27B71C0", Offset = "0x27B65C0", Length = "0x13B")]
	[Token(Token = "0x600024E")]
	public override bool Initialize(string id, string dataStr) { }

	[Address(RVA = "0x27B7000", Offset = "0x27B6400", Length = "0x1BB")]
	[Token(Token = "0x600024F")]
	public override AsyncOperationHandle<Boolean> InitializeAsync(ResourceManager rm, string id, string data) { }

}

