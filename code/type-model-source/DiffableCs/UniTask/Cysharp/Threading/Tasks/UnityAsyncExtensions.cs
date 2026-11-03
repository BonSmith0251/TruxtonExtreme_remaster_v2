namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x200013D")]
public static class UnityAsyncExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000153")]
	private struct <WaitAsync>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400051C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400051D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400051E")]
		public PlayerLoopTiming waitTiming; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400051F")]
		public JobHandle jobHandle; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000520")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000521")]
		private Awaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x278D4C0", Offset = "0x278C8C0", Length = "0x1FD")]
		[Token(Token = "0x6000841")]
		private override void MoveNext() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000842")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200014C")]
	internal struct AssetBundleCreateRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000508")]
		private AssetBundleCreateRequest asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000509")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x1700005A")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x6000815")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x6000814")]
		public AssetBundleCreateRequestAwaiter(AssetBundleCreateRequest asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x6000815")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x276ED10", Offset = "0x276E110", Length = "0x71")]
		[Token(Token = "0x6000816")]
		public AssetBundle GetResult() { }

		[Address(RVA = "0x276ED90", Offset = "0x276E190", Length = "0x8")]
		[Token(Token = "0x6000817")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x276EDA0", Offset = "0x276E1A0", Length = "0xD8")]
		[Token(Token = "0x6000818")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x200014D")]
	private sealed class AssetBundleCreateRequestConfiguredSource : IUniTaskSource<AssetBundle>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleCreateRequestConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x200014E")]
		private sealed class <>c
		{
			[Token(Token = "0x4000510")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D290", Offset = "0x278C690", Length = "0x67")]
			[Token(Token = "0x6000824")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000825")]
			public <>c() { }

			[Address(RVA = "0x278CE80", Offset = "0x278C280", Length = "0x5A")]
			[Token(Token = "0x6000826")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x400050A")]
		private static TaskPool<AssetBundleCreateRequestConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400050B")]
		private AssetBundleCreateRequestConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400050C")]
		private AssetBundleCreateRequest asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400050D")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400050E")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400050F")]
		private UniTaskCompletionSourceCore<AssetBundle> core; //Field offset: 0x30

		[Token(Token = "0x1700005B")]
		public override AssetBundleCreateRequestConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000819")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x276F450", Offset = "0x276E850", Length = "0x100")]
		[Token(Token = "0x600081A")]
		private static AssetBundleCreateRequestConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600081B")]
		private AssetBundleCreateRequestConfiguredSource() { }

		[Address(RVA = "0x276EED0", Offset = "0x276E2D0", Length = "0x1F4")]
		[Token(Token = "0x600081C")]
		public static IUniTaskSource<AssetBundle> Create(AssetBundleCreateRequest asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x276F0D0", Offset = "0x276E4D0", Length = "0x8")]
		[Token(Token = "0x600081E")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000819")]
		public override AssetBundleCreateRequestConfiguredSource get_NextNode() { }

		[Address(RVA = "0x276F0E0", Offset = "0x276E4E0", Length = "0x92")]
		[Token(Token = "0x600081D")]
		public override AssetBundle GetResult(short token) { }

		[Address(RVA = "0x276F180", Offset = "0x276E580", Length = "0x49")]
		[Token(Token = "0x600081F")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x276F1D0", Offset = "0x276E5D0", Length = "0x11B")]
		[Token(Token = "0x6000822")]
		public override bool MoveNext() { }

		[Address(RVA = "0x276F2F0", Offset = "0x276E6F0", Length = "0x70")]
		[Token(Token = "0x6000821")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x276F360", Offset = "0x276E760", Length = "0xAF")]
		[Token(Token = "0x6000823")]
		private bool TryReturn() { }

		[Address(RVA = "0x276F410", Offset = "0x276E810", Length = "0x3A")]
		[Token(Token = "0x6000820")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200013E")]
	internal struct AssetBundleRequestAllAssetsAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004DE")]
		private AssetBundleRequest asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004DF")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x17000051")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x60007BC")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x60007BA")]
		public AssetBundleRequestAllAssetsAwaiter(AssetBundleRequest asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x60007BC")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x60007BB")]
		public AssetBundleRequestAllAssetsAwaiter GetAwaiter() { }

		[Address(RVA = "0x276F550", Offset = "0x276E950", Length = "0x71")]
		[Token(Token = "0x60007BD")]
		public Object[] GetResult() { }

		[Address(RVA = "0x276F5D0", Offset = "0x276E9D0", Length = "0x8")]
		[Token(Token = "0x60007BE")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x276F5E0", Offset = "0x276E9E0", Length = "0xD8")]
		[Token(Token = "0x60007BF")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x200013F")]
	private sealed class AssetBundleRequestAllAssetsConfiguredSource : IUniTaskSource<Object[]>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleRequestAllAssetsConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000140")]
		private sealed class <>c
		{
			[Token(Token = "0x40004E6")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D0D0", Offset = "0x278C4D0", Length = "0x67")]
			[Token(Token = "0x60007CB")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60007CC")]
			public <>c() { }

			[Address(RVA = "0x278CF40", Offset = "0x278C340", Length = "0x5A")]
			[Token(Token = "0x60007CD")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x40004E0")]
		private static TaskPool<AssetBundleRequestAllAssetsConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E1")]
		private AssetBundleRequestAllAssetsConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004E2")]
		private AssetBundleRequest asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004E3")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004E4")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004E5")]
		private UniTaskCompletionSourceCore<Object[]> core; //Field offset: 0x30

		[Token(Token = "0x17000052")]
		public override AssetBundleRequestAllAssetsConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60007C0")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x276FC40", Offset = "0x276F040", Length = "0x100")]
		[Token(Token = "0x60007C1")]
		private static AssetBundleRequestAllAssetsConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007C2")]
		private AssetBundleRequestAllAssetsConfiguredSource() { }

		[Address(RVA = "0x276F6C0", Offset = "0x276EAC0", Length = "0x1F4")]
		[Token(Token = "0x60007C3")]
		public static IUniTaskSource<Object[]> Create(AssetBundleRequest asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x276F8C0", Offset = "0x276ECC0", Length = "0x8")]
		[Token(Token = "0x60007C5")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60007C0")]
		public override AssetBundleRequestAllAssetsConfiguredSource get_NextNode() { }

		[Address(RVA = "0x276F8D0", Offset = "0x276ECD0", Length = "0x92")]
		[Token(Token = "0x60007C4")]
		public override Object[] GetResult(short token) { }

		[Address(RVA = "0x276F970", Offset = "0x276ED70", Length = "0x49")]
		[Token(Token = "0x60007C6")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x276F9C0", Offset = "0x276EDC0", Length = "0x11B")]
		[Token(Token = "0x60007C9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x276FAE0", Offset = "0x276EEE0", Length = "0x70")]
		[Token(Token = "0x60007C8")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x276FB50", Offset = "0x276EF50", Length = "0xAF")]
		[Token(Token = "0x60007CA")]
		private bool TryReturn() { }

		[Address(RVA = "0x276FC00", Offset = "0x276F000", Length = "0x3A")]
		[Token(Token = "0x60007C7")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000149")]
	internal struct AssetBundleRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004FF")]
		private AssetBundleRequest asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000500")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x17000058")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x6000802")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x6000801")]
		public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x6000802")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x276FD40", Offset = "0x276F140", Length = "0x71")]
		[Token(Token = "0x6000803")]
		public object GetResult() { }

		[Address(RVA = "0x276FDC0", Offset = "0x276F1C0", Length = "0x8")]
		[Token(Token = "0x6000804")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x276FDD0", Offset = "0x276F1D0", Length = "0xD8")]
		[Token(Token = "0x6000805")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x200014A")]
	private sealed class AssetBundleRequestConfiguredSource : IUniTaskSource<Object>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleRequestConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x200014B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000507")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D370", Offset = "0x278C770", Length = "0x67")]
			[Token(Token = "0x6000811")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000812")]
			public <>c() { }

			[Address(RVA = "0x278CD00", Offset = "0x278C100", Length = "0x5A")]
			[Token(Token = "0x6000813")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000501")]
		private static TaskPool<AssetBundleRequestConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000502")]
		private AssetBundleRequestConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000503")]
		private AssetBundleRequest asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000504")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000505")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000506")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x30

		[Token(Token = "0x17000059")]
		public override AssetBundleRequestConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000806")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2770430", Offset = "0x276F830", Length = "0x100")]
		[Token(Token = "0x6000807")]
		private static AssetBundleRequestConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000808")]
		private AssetBundleRequestConfiguredSource() { }

		[Address(RVA = "0x276FEB0", Offset = "0x276F2B0", Length = "0x1F4")]
		[Token(Token = "0x6000809")]
		public static IUniTaskSource<Object> Create(AssetBundleRequest asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x27700B0", Offset = "0x276F4B0", Length = "0x8")]
		[Token(Token = "0x600080B")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000806")]
		public override AssetBundleRequestConfiguredSource get_NextNode() { }

		[Address(RVA = "0x27700C0", Offset = "0x276F4C0", Length = "0x92")]
		[Token(Token = "0x600080A")]
		public override object GetResult(short token) { }

		[Address(RVA = "0x2770160", Offset = "0x276F560", Length = "0x49")]
		[Token(Token = "0x600080C")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x27701B0", Offset = "0x276F5B0", Length = "0x11B")]
		[Token(Token = "0x600080F")]
		public override bool MoveNext() { }

		[Address(RVA = "0x27702D0", Offset = "0x276F6D0", Length = "0x70")]
		[Token(Token = "0x600080E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2770340", Offset = "0x276F740", Length = "0xAF")]
		[Token(Token = "0x6000810")]
		private bool TryReturn() { }

		[Address(RVA = "0x27703F0", Offset = "0x276F7F0", Length = "0x3A")]
		[Token(Token = "0x600080D")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000141")]
	private sealed class AsyncGPUReadbackRequestAwaiterConfiguredSource : IUniTaskSource<AsyncGPUReadbackRequest>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncGPUReadbackRequestAwaiterConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000142")]
		private sealed class <>c
		{
			[Token(Token = "0x40004EC")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D220", Offset = "0x278C620", Length = "0x67")]
			[Token(Token = "0x60007D9")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60007DA")]
			public <>c() { }

			[Address(RVA = "0x278CEE0", Offset = "0x278C2E0", Length = "0x5A")]
			[Token(Token = "0x60007DB")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x40004E7")]
		private static TaskPool<AsyncGPUReadbackRequestAwaiterConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E8")]
		private AsyncGPUReadbackRequestAwaiterConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004E9")]
		private AsyncGPUReadbackRequest asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004EA")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004EB")]
		private UniTaskCompletionSourceCore<AsyncGPUReadbackRequest> core; //Field offset: 0x30

		[Token(Token = "0x17000053")]
		public override AsyncGPUReadbackRequestAwaiterConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60007CE")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x27770E0", Offset = "0x27764E0", Length = "0x100")]
		[Token(Token = "0x60007CF")]
		private static AsyncGPUReadbackRequestAwaiterConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007D0")]
		private AsyncGPUReadbackRequestAwaiterConfiguredSource() { }

		[Address(RVA = "0x2776890", Offset = "0x2775C90", Length = "0x1C6")]
		[Token(Token = "0x60007D1")]
		public static IUniTaskSource<AsyncGPUReadbackRequest> Create(AsyncGPUReadbackRequest asyncOperation, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x2776A60", Offset = "0x2775E60", Length = "0x1D")]
		[Token(Token = "0x60007D3")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60007CE")]
		public override AsyncGPUReadbackRequestAwaiterConfiguredSource get_NextNode() { }

		[Address(RVA = "0x2776A80", Offset = "0x2775E80", Length = "0xAE")]
		[Token(Token = "0x60007D2")]
		public override AsyncGPUReadbackRequest GetResult(short token) { }

		[Address(RVA = "0x2776B30", Offset = "0x2775F30", Length = "0x14E")]
		[Token(Token = "0x60007D4")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2776C80", Offset = "0x2776080", Length = "0x137")]
		[Token(Token = "0x60007D7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2776DC0", Offset = "0x27761C0", Length = "0x1D0")]
		[Token(Token = "0x60007D6")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2776FA0", Offset = "0x27763A0", Length = "0x90")]
		[Token(Token = "0x60007D8")]
		private bool TryReturn() { }

		[Address(RVA = "0x2777030", Offset = "0x2776430", Length = "0xAD")]
		[Token(Token = "0x60007D5")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000143")]
	internal struct AsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004ED")]
		private AsyncOperation asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004EE")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x17000054")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x60007DD")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x60007DC")]
		public AsyncOperationAwaiter(AsyncOperation asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x60007DD")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x277A590", Offset = "0x2779990", Length = "0x65")]
		[Token(Token = "0x60007DE")]
		public void GetResult() { }

		[Address(RVA = "0x277A600", Offset = "0x2779A00", Length = "0x8")]
		[Token(Token = "0x60007DF")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x277A610", Offset = "0x2779A10", Length = "0xD8")]
		[Token(Token = "0x60007E0")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000144")]
	private sealed class AsyncOperationConfiguredSource : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncOperationConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000145")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F5")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D140", Offset = "0x278C540", Length = "0x67")]
			[Token(Token = "0x60007EB")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60007EC")]
			public <>c() { }

			[Address(RVA = "0x278CD60", Offset = "0x278C160", Length = "0x5A")]
			[Token(Token = "0x60007ED")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x40004EF")]
		private static TaskPool<AsyncOperationConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004F0")]
		private AsyncOperationConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004F1")]
		private AsyncOperation asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F2")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004F3")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004F4")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x30

		[Token(Token = "0x17000055")]
		public override AsyncOperationConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60007E1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x277AC60", Offset = "0x277A060", Length = "0x100")]
		[Token(Token = "0x60007E2")]
		private static AsyncOperationConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007E3")]
		private AsyncOperationConfiguredSource() { }

		[Address(RVA = "0x277A6F0", Offset = "0x2779AF0", Length = "0x1E4")]
		[Token(Token = "0x60007E4")]
		public static IUniTaskSource Create(AsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60007E1")]
		public override AsyncOperationConfiguredSource get_NextNode() { }

		[Address(RVA = "0x277A8E0", Offset = "0x2779CE0", Length = "0x80")]
		[Token(Token = "0x60007E5")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x277A970", Offset = "0x2779D70", Length = "0x49")]
		[Token(Token = "0x60007E6")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x277A9C0", Offset = "0x2779DC0", Length = "0x13D")]
		[Token(Token = "0x60007E9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x277AB00", Offset = "0x2779F00", Length = "0x70")]
		[Token(Token = "0x60007E8")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x277AB70", Offset = "0x2779F70", Length = "0xAF")]
		[Token(Token = "0x60007EA")]
		private bool TryReturn() { }

		[Address(RVA = "0x277AC20", Offset = "0x277A020", Length = "0x3A")]
		[Token(Token = "0x60007E7")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000152")]
	private sealed class JobHandlePromise : IUniTaskSource, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400051A")]
		private JobHandle jobHandle; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400051B")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000840")]
		public JobHandlePromise() { }

		[Address(RVA = "0x2788E30", Offset = "0x2788230", Length = "0x81")]
		[Token(Token = "0x600083A")]
		public static JobHandlePromise Create(JobHandle jobHandle, out short token) { }

		[Address(RVA = "0x2788EC0", Offset = "0x27882C0", Length = "0x49")]
		[Token(Token = "0x600083B")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2788F10", Offset = "0x2788310", Length = "0x49")]
		[Token(Token = "0x600083C")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2788F60", Offset = "0x2788360", Length = "0x107")]
		[Token(Token = "0x600083F")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2789070", Offset = "0x2788470", Length = "0x70")]
		[Token(Token = "0x600083E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x27890E0", Offset = "0x27884E0", Length = "0x3A")]
		[Token(Token = "0x600083D")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000146")]
	internal struct ResourceRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004F6")]
		private ResourceRequest asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004F7")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x17000056")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x60007EF")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x60007EE")]
		public ResourceRequestAwaiter(ResourceRequest asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x60007EF")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x276FD40", Offset = "0x276F140", Length = "0x71")]
		[Token(Token = "0x60007F0")]
		public object GetResult() { }

		[Address(RVA = "0x278A2B0", Offset = "0x27896B0", Length = "0x8")]
		[Token(Token = "0x60007F1")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x278A2C0", Offset = "0x27896C0", Length = "0xD8")]
		[Token(Token = "0x60007F2")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000147")]
	private sealed class ResourceRequestConfiguredSource : IUniTaskSource<Object>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<ResourceRequestConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000148")]
		private sealed class <>c
		{
			[Token(Token = "0x40004FE")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278CFF0", Offset = "0x278C3F0", Length = "0x67")]
			[Token(Token = "0x60007FE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60007FF")]
			public <>c() { }

			[Address(RVA = "0x278CE20", Offset = "0x278C220", Length = "0x5A")]
			[Token(Token = "0x6000800")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x40004F8")]
		private static TaskPool<ResourceRequestConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004F9")]
		private ResourceRequestConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004FA")]
		private ResourceRequest asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004FB")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004FC")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004FD")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x30

		[Token(Token = "0x17000057")]
		public override ResourceRequestConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60007F3")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x278A920", Offset = "0x2789D20", Length = "0x100")]
		[Token(Token = "0x60007F4")]
		private static ResourceRequestConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007F5")]
		private ResourceRequestConfiguredSource() { }

		[Address(RVA = "0x278A3A0", Offset = "0x27897A0", Length = "0x1F4")]
		[Token(Token = "0x60007F6")]
		public static IUniTaskSource<Object> Create(ResourceRequest asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x278A5A0", Offset = "0x27899A0", Length = "0x8")]
		[Token(Token = "0x60007F8")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60007F3")]
		public override ResourceRequestConfiguredSource get_NextNode() { }

		[Address(RVA = "0x278A5B0", Offset = "0x27899B0", Length = "0x92")]
		[Token(Token = "0x60007F7")]
		public override object GetResult(short token) { }

		[Address(RVA = "0x278A650", Offset = "0x2789A50", Length = "0x49")]
		[Token(Token = "0x60007F9")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x278A6A0", Offset = "0x2789AA0", Length = "0x11B")]
		[Token(Token = "0x60007FC")]
		public override bool MoveNext() { }

		[Address(RVA = "0x278A7C0", Offset = "0x2789BC0", Length = "0x70")]
		[Token(Token = "0x60007FB")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x278A830", Offset = "0x2789C30", Length = "0xAF")]
		[Token(Token = "0x60007FD")]
		private bool TryReturn() { }

		[Address(RVA = "0x278A8E0", Offset = "0x2789CE0", Length = "0x3A")]
		[Token(Token = "0x60007FA")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200014F")]
	internal struct UnityWebRequestAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000511")]
		private UnityWebRequestAsyncOperation asyncOperation; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000512")]
		private Action<AsyncOperation> continuationAction; //Field offset: 0x8

		[Token(Token = "0x1700005C")]
		public bool IsCompleted
		{
			[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
			[Token(Token = "0x6000828")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x276EE80", Offset = "0x276E280", Length = "0x29")]
		[Token(Token = "0x6000827")]
		public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation) { }

		[Address(RVA = "0x276EEB0", Offset = "0x276E2B0", Length = "0x1C")]
		[Token(Token = "0x6000828")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x27933D0", Offset = "0x27927D0", Length = "0x140")]
		[Token(Token = "0x6000829")]
		public UnityWebRequest GetResult() { }

		[Address(RVA = "0x2793520", Offset = "0x2792920", Length = "0x8")]
		[Token(Token = "0x600082A")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x2793530", Offset = "0x2792930", Length = "0xD8")]
		[Token(Token = "0x600082B")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000150")]
	private sealed class UnityWebRequestAsyncOperationConfiguredSource : IUniTaskSource<UnityWebRequest>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<UnityWebRequestAsyncOperationConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000151")]
		private sealed class <>c
		{
			[Token(Token = "0x4000519")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x278D1B0", Offset = "0x278C5B0", Length = "0x67")]
			[Token(Token = "0x6000837")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000838")]
			public <>c() { }

			[Address(RVA = "0x278CDC0", Offset = "0x278C1C0", Length = "0x5A")]
			[Token(Token = "0x6000839")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000513")]
		private static TaskPool<UnityWebRequestAsyncOperationConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000514")]
		private UnityWebRequestAsyncOperationConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000515")]
		private UnityWebRequestAsyncOperation asyncOperation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000516")]
		private IProgress<Single> progress; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000517")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000518")]
		private UniTaskCompletionSourceCore<UnityWebRequest> core; //Field offset: 0x30

		[Token(Token = "0x1700005D")]
		public override UnityWebRequestAsyncOperationConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600082C")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2793C50", Offset = "0x2793050", Length = "0x100")]
		[Token(Token = "0x600082D")]
		private static UnityWebRequestAsyncOperationConfiguredSource() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600082E")]
		private UnityWebRequestAsyncOperationConfiguredSource() { }

		[Address(RVA = "0x2793610", Offset = "0x2792A10", Length = "0x1F4")]
		[Token(Token = "0x600082F")]
		public static IUniTaskSource<UnityWebRequest> Create(UnityWebRequestAsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x2793810", Offset = "0x2792C10", Length = "0x8")]
		[Token(Token = "0x6000831")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600082C")]
		public override UnityWebRequestAsyncOperationConfiguredSource get_NextNode() { }

		[Address(RVA = "0x2793820", Offset = "0x2792C20", Length = "0x92")]
		[Token(Token = "0x6000830")]
		public override UnityWebRequest GetResult(short token) { }

		[Address(RVA = "0x27938C0", Offset = "0x2792CC0", Length = "0x49")]
		[Token(Token = "0x6000832")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2793910", Offset = "0x2792D10", Length = "0x1DB")]
		[Token(Token = "0x6000835")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2793AF0", Offset = "0x2792EF0", Length = "0x70")]
		[Token(Token = "0x6000834")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2793B60", Offset = "0x2792F60", Length = "0xAF")]
		[Token(Token = "0x6000836")]
		private bool TryReturn() { }

		[Address(RVA = "0x2793C10", Offset = "0x2793010", Length = "0x3A")]
		[Token(Token = "0x6000833")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}


	[Address(RVA = "0x278D6F0", Offset = "0x278CAF0", Length = "0x82")]
	[Extension]
	[Token(Token = "0x600076B")]
	public static AssetBundleRequestAllAssetsAwaiter AwaitForAllAssets(AssetBundleRequest asyncOperation) { }

	[Address(RVA = "0x278D6C0", Offset = "0x278CAC0", Length = "0x2F")]
	[Extension]
	[Token(Token = "0x600076C")]
	public static UniTask<Object[]> AwaitForAllAssets(AssetBundleRequest asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278D780", Offset = "0x278CB80", Length = "0x378")]
	[Extension]
	[Token(Token = "0x600076D")]
	public static UniTask<Object[]> AwaitForAllAssets(AssetBundleRequest asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x278DB00", Offset = "0x278CF00", Length = "0x7E")]
	[Extension]
	[Token(Token = "0x600078B")]
	public static IAsyncClickEventHandler GetAsyncClickEventHandler(Button button, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278DB80", Offset = "0x278CF80", Length = "0x89")]
	[Extension]
	[Token(Token = "0x600078A")]
	public static IAsyncClickEventHandler GetAsyncClickEventHandler(Button button) { }

	[Address(RVA = "0x278DCB0", Offset = "0x278D0B0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60007A9")]
	public static IAsyncEndEditEventHandler<String> GetAsyncEndEditEventHandler(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278DC10", Offset = "0x278D010", Length = "0x98")]
	[Extension]
	[Token(Token = "0x60007A8")]
	public static IAsyncEndEditEventHandler<String> GetAsyncEndEditEventHandler(InputField inputField) { }

	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", Length = "0x87")]
	[Extension]
	[Token(Token = "0x6000787")]
	public static AsyncUnityEventHandler<T> GetAsyncEventHandler(UnityEvent<T> unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278DD40", Offset = "0x278D140", Length = "0x6D")]
	[Extension]
	[Token(Token = "0x6000784")]
	public static AsyncUnityEventHandler GetAsyncEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E3B0", Offset = "0x278D7B0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000797")]
	public static IAsyncValueChangedEventHandler<Single> GetAsyncValueChangedEventHandler(Scrollbar scrollbar, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E440", Offset = "0x278D840", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000791")]
	public static IAsyncValueChangedEventHandler<Boolean> GetAsyncValueChangedEventHandler(Toggle toggle, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278DE50", Offset = "0x278D250", Length = "0x98")]
	[Extension]
	[Token(Token = "0x6000790")]
	public static IAsyncValueChangedEventHandler<Boolean> GetAsyncValueChangedEventHandler(Toggle toggle) { }

	[Address(RVA = "0x278E1F0", Offset = "0x278D5F0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60007B5")]
	public static IAsyncValueChangedEventHandler<Int32> GetAsyncValueChangedEventHandler(Dropdown dropdown, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E0D0", Offset = "0x278D4D0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60007A3")]
	public static IAsyncValueChangedEventHandler<Single> GetAsyncValueChangedEventHandler(Slider slider, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E320", Offset = "0x278D720", Length = "0x8A")]
	[Extension]
	[Token(Token = "0x600079D")]
	public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(ScrollRect scrollRect, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E030", Offset = "0x278D430", Length = "0x98")]
	[Extension]
	[Token(Token = "0x60007A2")]
	public static IAsyncValueChangedEventHandler<Single> GetAsyncValueChangedEventHandler(Slider slider) { }

	[Address(RVA = "0x278DF90", Offset = "0x278D390", Length = "0x98")]
	[Extension]
	[Token(Token = "0x60007B4")]
	public static IAsyncValueChangedEventHandler<Int32> GetAsyncValueChangedEventHandler(Dropdown dropdown) { }

	[Address(RVA = "0x278E280", Offset = "0x278D680", Length = "0x95")]
	[Extension]
	[Token(Token = "0x600079C")]
	public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(ScrollRect scrollRect) { }

	[Address(RVA = "0x278E160", Offset = "0x278D560", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60007AF")]
	public static IAsyncValueChangedEventHandler<String> GetAsyncValueChangedEventHandler(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278DDB0", Offset = "0x278D1B0", Length = "0x98")]
	[Extension]
	[Token(Token = "0x60007AE")]
	public static IAsyncValueChangedEventHandler<String> GetAsyncValueChangedEventHandler(InputField inputField) { }

	[Address(RVA = "0x278DEF0", Offset = "0x278D2F0", Length = "0x98")]
	[Extension]
	[Token(Token = "0x6000796")]
	public static IAsyncValueChangedEventHandler<Single> GetAsyncValueChangedEventHandler(Scrollbar scrollbar) { }

	[Address(RVA = "0x278E8C0", Offset = "0x278DCC0", Length = "0x82")]
	[Extension]
	[Token(Token = "0x600077D")]
	public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityWebRequestAsyncOperation asyncOperation) { }

	[Address(RVA = "0x278E760", Offset = "0x278DB60", Length = "0xCE")]
	[Extension]
	[Token(Token = "0x600076E")]
	public static Awaiter<AsyncGPUReadbackRequest> GetAwaiter(AsyncGPUReadbackRequest asyncOperation) { }

	[Address(RVA = "0x278E6D0", Offset = "0x278DAD0", Length = "0x82")]
	[Extension]
	[Token(Token = "0x6000777")]
	public static AssetBundleRequestAwaiter GetAwaiter(AssetBundleRequest asyncOperation) { }

	[Address(RVA = "0x278E640", Offset = "0x278DA40", Length = "0x82")]
	[Extension]
	[Token(Token = "0x6000774")]
	public static ResourceRequestAwaiter GetAwaiter(ResourceRequest asyncOperation) { }

	[Address(RVA = "0x278E950", Offset = "0x278DD50", Length = "0x82")]
	[Extension]
	[Token(Token = "0x6000771")]
	public static AsyncOperationAwaiter GetAwaiter(AsyncOperation asyncOperation) { }

	[Address(RVA = "0x278E4D0", Offset = "0x278D8D0", Length = "0x16D")]
	[Extension]
	[Token(Token = "0x6000781")]
	public static Awaiter GetAwaiter(JobHandle jobHandle) { }

	[Address(RVA = "0x278E830", Offset = "0x278DC30", Length = "0x82")]
	[Extension]
	[Token(Token = "0x600077A")]
	public static AssetBundleCreateRequestAwaiter GetAwaiter(AssetBundleCreateRequest asyncOperation) { }

	[Address(RVA = "0x278EA80", Offset = "0x278DE80", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x600078F")]
	public static IUniTaskAsyncEnumerable<AsyncUnit> OnClickAsAsyncEnumerable(Button button, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278E9E0", Offset = "0x278DDE0", Length = "0x98")]
	[Extension]
	[Token(Token = "0x600078E")]
	public static IUniTaskAsyncEnumerable<AsyncUnit> OnClickAsAsyncEnumerable(Button button) { }

	[Address(RVA = "0x278EB10", Offset = "0x278DF10", Length = "0x12D")]
	[Extension]
	[Token(Token = "0x600078C")]
	public static UniTask OnClickAsync(Button button) { }

	[Address(RVA = "0x278EC40", Offset = "0x278E040", Length = "0x123")]
	[Extension]
	[Token(Token = "0x600078D")]
	public static UniTask OnClickAsync(Button button, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278EE00", Offset = "0x278E200", Length = "0x90")]
	[Extension]
	[Token(Token = "0x60007AC")]
	public static IUniTaskAsyncEnumerable<String> OnEndEditAsAsyncEnumerable(InputField inputField) { }

	[Address(RVA = "0x278ED70", Offset = "0x278E170", Length = "0x85")]
	[Extension]
	[Token(Token = "0x60007AD")]
	public static IUniTaskAsyncEnumerable<String> OnEndEditAsAsyncEnumerable(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278EF80", Offset = "0x278E380", Length = "0xE0")]
	[Extension]
	[Token(Token = "0x60007AA")]
	public static UniTask<String> OnEndEditAsync(InputField inputField) { }

	[Address(RVA = "0x278EEA0", Offset = "0x278E2A0", Length = "0xD2")]
	[Extension]
	[Token(Token = "0x60007AB")]
	public static UniTask<String> OnEndEditAsync(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x914090", Offset = "0x913490", Length = "0x7F")]
	[Extension]
	[Token(Token = "0x6000789")]
	public static IUniTaskAsyncEnumerable<T> OnInvokeAsAsyncEnumerable(UnityEvent<T> unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F070", Offset = "0x278E470", Length = "0x7C")]
	[Extension]
	[Token(Token = "0x6000786")]
	public static IUniTaskAsyncEnumerable<AsyncUnit> OnInvokeAsAsyncEnumerable(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9D4CF0", Offset = "0x9D40F0", Length = "0x101")]
	[Extension]
	[Token(Token = "0x6000788")]
	public static UniTask<T> OnInvokeAsync(UnityEvent<T> unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F0F0", Offset = "0x278E4F0", Length = "0x112")]
	[Extension]
	[Token(Token = "0x6000785")]
	public static UniTask OnInvokeAsync(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F2B0", Offset = "0x278E6B0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60007A0")]
	public static IUniTaskAsyncEnumerable<Vector2> OnValueChangedAsAsyncEnumerable(ScrollRect scrollRect) { }

	[Address(RVA = "0x278F210", Offset = "0x278E610", Length = "0x90")]
	[Extension]
	[Token(Token = "0x60007A6")]
	public static IUniTaskAsyncEnumerable<Single> OnValueChangedAsAsyncEnumerable(Slider slider) { }

	[Address(RVA = "0x278F590", Offset = "0x278E990", Length = "0x85")]
	[Extension]
	[Token(Token = "0x60007A7")]
	public static IUniTaskAsyncEnumerable<Single> OnValueChangedAsAsyncEnumerable(Slider slider, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F620", Offset = "0x278EA20", Length = "0x90")]
	[Extension]
	[Token(Token = "0x60007B2")]
	public static IUniTaskAsyncEnumerable<String> OnValueChangedAsAsyncEnumerable(InputField inputField) { }

	[Address(RVA = "0x278F470", Offset = "0x278E870", Length = "0x85")]
	[Extension]
	[Token(Token = "0x60007B3")]
	public static IUniTaskAsyncEnumerable<String> OnValueChangedAsAsyncEnumerable(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F500", Offset = "0x278E900", Length = "0x82")]
	[Extension]
	[Token(Token = "0x60007A1")]
	public static IUniTaskAsyncEnumerable<Vector2> OnValueChangedAsAsyncEnumerable(ScrollRect scrollRect, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F340", Offset = "0x278E740", Length = "0x85")]
	[Extension]
	[Token(Token = "0x600079B")]
	public static IUniTaskAsyncEnumerable<Single> OnValueChangedAsAsyncEnumerable(Scrollbar scrollbar, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F750", Offset = "0x278EB50", Length = "0x85")]
	[Extension]
	[Token(Token = "0x60007B9")]
	public static IUniTaskAsyncEnumerable<Int32> OnValueChangedAsAsyncEnumerable(Dropdown dropdown, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F6C0", Offset = "0x278EAC0", Length = "0x85")]
	[Extension]
	[Token(Token = "0x6000795")]
	public static IUniTaskAsyncEnumerable<Boolean> OnValueChangedAsAsyncEnumerable(Toggle toggle, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F880", Offset = "0x278EC80", Length = "0x90")]
	[Extension]
	[Token(Token = "0x6000794")]
	public static IUniTaskAsyncEnumerable<Boolean> OnValueChangedAsAsyncEnumerable(Toggle toggle) { }

	[Address(RVA = "0x278F3D0", Offset = "0x278E7D0", Length = "0x90")]
	[Extension]
	[Token(Token = "0x60007B8")]
	public static IUniTaskAsyncEnumerable<Int32> OnValueChangedAsAsyncEnumerable(Dropdown dropdown) { }

	[Address(RVA = "0x278F7E0", Offset = "0x278EBE0", Length = "0x90")]
	[Extension]
	[Token(Token = "0x600079A")]
	public static IUniTaskAsyncEnumerable<Single> OnValueChangedAsAsyncEnumerable(Scrollbar scrollbar) { }

	[Address(RVA = "0x2790290", Offset = "0x278F690", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x6000799")]
	public static UniTask<Single> OnValueChangedAsync(Scrollbar scrollbar, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278FF10", Offset = "0x278F310", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x60007B7")]
	public static UniTask<Int32> OnValueChangedAsync(Dropdown dropdown, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278FAD0", Offset = "0x278EED0", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x60007B6")]
	public static UniTask<Int32> OnValueChangedAsync(Dropdown dropdown) { }

	[Address(RVA = "0x278FD50", Offset = "0x278F150", Length = "0xD2")]
	[Extension]
	[Token(Token = "0x60007B1")]
	public static UniTask<String> OnValueChangedAsync(InputField inputField, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278FFE0", Offset = "0x278F3E0", Length = "0xE0")]
	[Extension]
	[Token(Token = "0x60007B0")]
	public static UniTask<String> OnValueChangedAsync(InputField inputField) { }

	[Address(RVA = "0x278FA00", Offset = "0x278EE00", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x60007A5")]
	public static UniTask<Single> OnValueChangedAsync(Slider slider, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278F920", Offset = "0x278ED20", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x6000792")]
	public static UniTask<Boolean> OnValueChangedAsync(Toggle toggle) { }

	[Address(RVA = "0x27900D0", Offset = "0x278F4D0", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x6000798")]
	public static UniTask<Single> OnValueChangedAsync(Scrollbar scrollbar) { }

	[Address(RVA = "0x278FE30", Offset = "0x278F230", Length = "0xDD")]
	[Extension]
	[Token(Token = "0x600079E")]
	public static UniTask<Vector2> OnValueChangedAsync(ScrollRect scrollRect) { }

	[Address(RVA = "0x278FBB0", Offset = "0x278EFB0", Length = "0xCF")]
	[Extension]
	[Token(Token = "0x600079F")]
	public static UniTask<Vector2> OnValueChangedAsync(ScrollRect scrollRect, CancellationToken cancellationToken) { }

	[Address(RVA = "0x278FC80", Offset = "0x278F080", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x6000793")]
	public static UniTask<Boolean> OnValueChangedAsync(Toggle toggle, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27901B0", Offset = "0x278F5B0", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x60007A4")]
	public static UniTask<Single> OnValueChangedAsync(Slider slider) { }

	[Address(RVA = "0x2790360", Offset = "0x278F760", Length = "0x52")]
	[Extension]
	[Token(Token = "0x6000783")]
	public static UniTask StartAsyncCoroutine(MonoBehaviour monoBehaviour, Func<CancellationToken, UniTask> asyncCoroutine) { }

	[Address(RVA = "0x2791170", Offset = "0x2790570", Length = "0xE3")]
	[Extension]
	[Token(Token = "0x6000782")]
	public static UniTask ToUniTask(JobHandle jobHandle, PlayerLoopTiming waitTiming) { }

	[Address(RVA = "0x2791260", Offset = "0x2790660", Length = "0x2C3")]
	[Extension]
	[Token(Token = "0x6000770")]
	public static UniTask<AsyncGPUReadbackRequest> ToUniTask(AsyncGPUReadbackRequest asyncOperation, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2790E40", Offset = "0x2790240", Length = "0x326")]
	[Extension]
	[Token(Token = "0x6000773")]
	public static UniTask ToUniTask(AsyncOperation asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2790740", Offset = "0x278FB40", Length = "0x378")]
	[Extension]
	[Token(Token = "0x600077C")]
	public static UniTask<AssetBundle> ToUniTask(AssetBundleCreateRequest asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x27903C0", Offset = "0x278F7C0", Length = "0x378")]
	[Extension]
	[Token(Token = "0x6000779")]
	public static UniTask<Object> ToUniTask(AssetBundleRequest asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2791530", Offset = "0x2790930", Length = "0x3FE")]
	[Extension]
	[Token(Token = "0x600077F")]
	public static UniTask<UnityWebRequest> ToUniTask(UnityWebRequestAsyncOperation asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2790AC0", Offset = "0x278FEC0", Length = "0x378")]
	[Extension]
	[Token(Token = "0x6000776")]
	public static UniTask<Object> ToUniTask(ResourceRequest asyncOperation, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2791930", Offset = "0x2790D30", Length = "0xEB")]
	[AsyncStateMachine(typeof(<WaitAsync>d__34))]
	[Extension]
	[Token(Token = "0x6000780")]
	public static UniTask WaitAsync(JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2791BA0", Offset = "0x2790FA0", Length = "0x43")]
	[Extension]
	[Token(Token = "0x6000778")]
	public static UniTask<Object> WithCancellation(AssetBundleRequest asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2791B50", Offset = "0x2790F50", Length = "0x43")]
	[Extension]
	[Token(Token = "0x600077B")]
	public static UniTask<AssetBundle> WithCancellation(AssetBundleCreateRequest asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2791AC0", Offset = "0x2790EC0", Length = "0x39")]
	[Extension]
	[Token(Token = "0x6000772")]
	public static UniTask WithCancellation(AsyncOperation asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2791B00", Offset = "0x2790F00", Length = "0x43")]
	[Extension]
	[Token(Token = "0x600077E")]
	public static UniTask<UnityWebRequest> WithCancellation(UnityWebRequestAsyncOperation asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2791A20", Offset = "0x2790E20", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600076F")]
	public static UniTask<AsyncGPUReadbackRequest> WithCancellation(AsyncGPUReadbackRequest asyncOperation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2791A70", Offset = "0x2790E70", Length = "0x43")]
	[Extension]
	[Token(Token = "0x6000775")]
	public static UniTask<Object> WithCancellation(ResourceRequest asyncOperation, CancellationToken cancellationToken) { }

}

