namespace TXEKernel;

[Token(Token = "0x2000049")]
public class PurchaseManager : SimpleSingleton<PurchaseManager>
{
	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <GetPurchasedList>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D0")]
		public AsyncUniTaskMethodBuilder<List`1<EntitlementLabel>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D1")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x26E4AD0", Offset = "0x26E3ED0", Length = "0x510")]
		[Token(Token = "0x6000264")]
		private override void MoveNext() { }

		[Address(RVA = "0x26E4FF0", Offset = "0x26E43F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000265")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private struct <GetSkuType>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D3")]
		public AsyncUniTaskMethodBuilder<SkuType> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D4")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x26E5A40", Offset = "0x26E4E40", Length = "0x378")]
		[Token(Token = "0x6000266")]
		private override void MoveNext() { }

		[Address(RVA = "0x26E5DC0", Offset = "0x26E51C0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000267")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private struct <ShowStoreForDLC>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D6")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D7")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x26E9610", Offset = "0x26E8A10", Length = "0x296")]
		[Token(Token = "0x6000268")]
		private override void MoveNext() { }

		[Address(RVA = "0x26E98B0", Offset = "0x26E8CB0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000269")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200004B")]
	internal enum EntitlementLabel : int
	{
		Tatsujin = 0,
		TatsujinOh = 1,
		Batsugun = 2,
	}

	[Token(Token = "0x200004C")]
	internal enum ErrorCode : int
	{
		None = 0,
		NetworkError = 1,
		UnknownError = 2,
	}

	[Token(Token = "0x200004A")]
	internal enum SkuType : int
	{
		NotSet = 0,
		Trial = 1,
		Full = 3,
	}

	[Token(Token = "0x40001C0")]
	private static readonly Dictionary<EntitlementLabel, AppId_t> SKUTypeAppIdDict; //Field offset: 0x0
	[Token(Token = "0x40001C1")]
	private static readonly AppId_t FullGameAppId; //Field offset: 0x8
	[Token(Token = "0x40001C2")]
	private static readonly AppId_t TrialAppId; //Field offset: 0xC

	[Address(RVA = "0x26DF240", Offset = "0x26DE640", Length = "0x114")]
	[Token(Token = "0x6000263")]
	private static PurchaseManager() { }

	[Address(RVA = "0x26DF360", Offset = "0x26DE760", Length = "0x39")]
	[Token(Token = "0x6000262")]
	public PurchaseManager() { }

	[Address(RVA = "0x26DEFC0", Offset = "0x26DE3C0", Length = "0xD9")]
	[AsyncStateMachine(typeof(<GetPurchasedList>d__8))]
	[Token(Token = "0x6000260")]
	public UniTask<List`1<EntitlementLabel>> GetPurchasedList() { }

	[Address(RVA = "0x26DF0A0", Offset = "0x26DE4A0", Length = "0xCE")]
	[AsyncStateMachine(typeof(<GetSkuType>d__7))]
	[Token(Token = "0x600025F")]
	public UniTask<SkuType> GetSkuType() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600025E")]
	public void Initialize() { }

	[Address(RVA = "0x26DF170", Offset = "0x26DE570", Length = "0xCE")]
	[AsyncStateMachine(typeof(<ShowStoreForDLC>d__9))]
	[Token(Token = "0x6000261")]
	public UniTask<Boolean> ShowStoreForDLC() { }

}

