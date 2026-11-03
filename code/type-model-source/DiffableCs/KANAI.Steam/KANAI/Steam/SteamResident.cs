namespace KANAI.Steam;

[Token(Token = "0x2000004")]
public class SteamResident : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	internal class CallbackWaiter
	{
		[CompilerGenerated]
		[Token(Token = "0x2000006")]
		private struct <WaitResponse>d__4 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400000E")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000010")]
			public CallbackWaiter<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000011")]
			private YieldAwaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1B78700", Offset = "0x1B77B00", Length = "0x440")]
			[Token(Token = "0x6000014")]
			private override void MoveNext() { }

			[Address(RVA = "0x1B78B40", Offset = "0x1B77F40", Length = "0xC3")]
			[DebuggerHidden]
			[Token(Token = "0x6000015")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000B")]
		private readonly Callback<T> m_SteamCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000C")]
		private T m_ResultData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000D")]
		private bool m_CallbackFinished; //Field offset: 0x0

		[Address(RVA = "0x16C42A0", Offset = "0x16C36A0", Length = "0xDB")]
		[Token(Token = "0x6000011")]
		public CallbackWaiter`1() { }

		[Address(RVA = "0x16C4060", Offset = "0x16C3460", Length = "0x130")]
		[Token(Token = "0x6000013")]
		private void OnSteamCallback(T response) { }

		[Address(RVA = "0x16C41A0", Offset = "0x16C35A0", Length = "0xF2")]
		[AsyncStateMachine(typeof(<WaitResponse>d__4))]
		[Token(Token = "0x6000012")]
		public Task<T> WaitResponse() { }

	}

	[Token(Token = "0x2000007")]
	internal class CallResultWaiter
	{
		[CompilerGenerated]
		[Token(Token = "0x2000008")]
		private struct <WaitResponse>d__5 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000016")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000017")]
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
			public AsyncTaskMethodBuilder<ValueTuple`2<T, Boolean>> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000018")]
			public float timeout; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000019")]
			public CallResultWaiter<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400001A")]
			private Stopwatch <stopwatch>5__2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400001B")]
			private YieldAwaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1B793F0", Offset = "0x1B787F0", Length = "0x499")]
			[Token(Token = "0x6000019")]
			private override void MoveNext() { }

			[Address(RVA = "0x1B7A210", Offset = "0x1B79610", Length = "0x95")]
			[DebuggerHidden]
			[Token(Token = "0x600001A")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		private readonly CallResult<T> m_SteamCallResult; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		private T m_ResultData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		private bool m_IOFailure; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000015")]
		private bool m_CallbackFinished; //Field offset: 0x0

		[Address(RVA = "0x16BF760", Offset = "0x16BEB60", Length = "0x2AB")]
		[Token(Token = "0x6000016")]
		public CallResultWaiter`1(SteamAPICall_t apiCall) { }

		[Address(RVA = "0x16BEA20", Offset = "0x16BDE20", Length = "0x5D")]
		[Token(Token = "0x6000018")]
		private void OnSteamCallResult(T response, bool IOFailure) { }

		[Address(RVA = "0x16BED90", Offset = "0x16BE190", Length = "0x10B")]
		[AsyncStateMachine(typeof(<WaitResponse>d__5))]
		[Token(Token = "0x6000017")]
		public Task<ValueTuple`2<T, Boolean>> WaitResponse(float timeout = 0) { }

	}

	[Token(Token = "0x4000006")]
	public const int AppId = 3323490; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	private string <PlayerName>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	private Action m_RequestPauseCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000009")]
	private Callback<GameOverlayActivated_t> m_GameOverlayActivated; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000A")]
	private bool _isSteamInitialized; //Field offset: 0x38

	[Token(Token = "0x17000002")]
	public bool IsInitialized
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000001")]
	public private string PlayerName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000003")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1E15970", Offset = "0x1E14D70", Length = "0x4F")]
	[Token(Token = "0x6000010")]
	public SteamResident() { }

	[Address(RVA = "0x1E151E0", Offset = "0x1E145E0", Length = "0x59")]
	[Token(Token = "0x6000008")]
	private void ConfigAppId(int appId) { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x600000E")]
	public bool get_IsInitialized() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000003")]
	public string get_PlayerName() { }

	[Address(RVA = "0x1E15240", Offset = "0x1E14640", Length = "0x29")]
	[Token(Token = "0x600000B")]
	public ESteamInputType GetControllerVendor(int index) { }

	[Address(RVA = "0x1E15270", Offset = "0x1E14670", Length = "0xB6")]
	[Token(Token = "0x6000009")]
	public string GetLocalPlayerSettingsDirectory() { }

	[Address(RVA = "0x1E15330", Offset = "0x1E14730", Length = "0x1FC")]
	[Token(Token = "0x6000006")]
	public bool Init(Action requestPauseCallback) { }

	[Address(RVA = "0x1E15530", Offset = "0x1E14930", Length = "0x127")]
	[Token(Token = "0x6000005")]
	public static SteamResident Instance() { }

	[Address(RVA = "0x1E15660", Offset = "0x1E14A60", Length = "0x1F")]
	[Token(Token = "0x600000A")]
	public bool IsSteamDeck() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000D")]
	private void OnDestroy() { }

	[Address(RVA = "0x1E15680", Offset = "0x1E14A80", Length = "0x1E")]
	[Token(Token = "0x600000C")]
	private void OnGameOverlayActivated(GameOverlayActivated_t pCallback) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	private void set_PlayerName(string value) { }

	[Address(RVA = "0x1E156A0", Offset = "0x1E14AA0", Length = "0x2B0")]
	[ContextMenu("Test 1")]
	[Token(Token = "0x600000F")]
	public void Test1() { }

	[Address(RVA = "0x1E15960", Offset = "0x1E14D60", Length = "0xE")]
	[Token(Token = "0x6000007")]
	private void Update() { }

}

