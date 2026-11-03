namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000005")]
public static class DOTweenAsyncExtensions
{
	[Token(Token = "0x2000006")]
	private enum CallbackType : int
	{
		Kill = 0,
		Complete = 1,
		Pause = 2,
		Play = 3,
		Rewind = 4,
		StepComplete = 5,
	}

	[Token(Token = "0x2000007")]
	internal struct TweenAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		private readonly Tween tween; //Field offset: 0x0

		[Token(Token = "0x17000001")]
		public bool IsCompleted
		{
			[Address(RVA = "0x274FB40", Offset = "0x274EF40", Length = "0x15")]
			[Token(Token = "0x600000B")]
			 get { } //Length: 21
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600000C")]
		public TweenAwaiter(Tween tween) { }

		[Address(RVA = "0x274FB40", Offset = "0x274EF40", Length = "0x15")]
		[Token(Token = "0x600000B")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600000D")]
		public TweenAwaiter GetAwaiter() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600000E")]
		public void GetResult() { }

		[Address(RVA = "0x274F9F0", Offset = "0x274EDF0", Length = "0x8")]
		[Token(Token = "0x600000F")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x274FA00", Offset = "0x274EE00", Length = "0x139")]
		[Token(Token = "0x6000010")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000008")]
	private sealed class TweenConfiguredSource : IUniTaskSource, ITaskPoolNode<TweenConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000009")]
		private sealed class <>c
		{
			[Token(Token = "0x4000024")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x2750E80", Offset = "0x2750280", Length = "0x67")]
			[Token(Token = "0x600001D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600001E")]
			public <>c() { }

			[Address(RVA = "0x2750E20", Offset = "0x2750220", Length = "0x5A")]
			[Token(Token = "0x600001F")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000018")]
		private static TaskPool<TweenConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000019")]
		private TweenConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001A")]
		private readonly TweenCallback onCompleteCallbackDelegate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001B")]
		private readonly TweenCallback onUpdateDelegate; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400001C")]
		private Tween tween; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400001D")]
		private TweenCancelBehaviour cancelBehaviour; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400001E")]
		private CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400001F")]
		private CallbackType callbackType; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000020")]
		private bool canceled; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000021")]
		private TweenCallback originalUpdateAction; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000022")]
		private TweenCallback originalCompleteAction; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000023")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x58

		[Token(Token = "0x17000002")]
		public override TweenConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000011")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2750C60", Offset = "0x2750060", Length = "0x100")]
		[Token(Token = "0x6000012")]
		private static TweenConfiguredSource() { }

		[Address(RVA = "0x2750D60", Offset = "0x2750160", Length = "0xBD")]
		[Token(Token = "0x6000013")]
		private TweenConfiguredSource() { }

		[Address(RVA = "0x274FB60", Offset = "0x274EF60", Length = "0x550")]
		[Token(Token = "0x6000014")]
		public static IUniTaskSource Create(Tween tween, TweenCancelBehaviour cancelBehaviour, CancellationToken cancellationToken, CallbackType callbackType, out short token) { }

		[Address(RVA = "0x2750170", Offset = "0x274F570", Length = "0x48")]
		[Token(Token = "0x6000017")]
		private static void DoCancelBeforeCreate(Tween tween, TweenCancelBehaviour tweenCancelBehaviour) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000011")]
		public override TweenConfiguredSource get_NextNode() { }

		[Address(RVA = "0x27501E0", Offset = "0x274F5E0", Length = "0x84")]
		[Token(Token = "0x6000018")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2750270", Offset = "0x274F670", Length = "0x14E")]
		[Token(Token = "0x6000019")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x27503C0", Offset = "0x274F7C0", Length = "0x103")]
		[Token(Token = "0x6000015")]
		private void OnCompleteCallbackDelegate() { }

		[Address(RVA = "0x27504D0", Offset = "0x274F8D0", Length = "0x1D0")]
		[Token(Token = "0x600001B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x27506B0", Offset = "0x274FAB0", Length = "0x1EC")]
		[Token(Token = "0x6000016")]
		private void OnUpdate() { }

		[Address(RVA = "0x27508E0", Offset = "0x274FCE0", Length = "0x2AC")]
		[Token(Token = "0x600001C")]
		private bool TryReturn() { }

		[Address(RVA = "0x2750BB0", Offset = "0x274FFB0", Length = "0xAD")]
		[Token(Token = "0x600001A")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}


	[Address(RVA = "0x274EF70", Offset = "0x274E370", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x6000006")]
	public static UniTask AwaitForComplete(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274F090", Offset = "0x274E490", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x6000007")]
	public static UniTask AwaitForPause(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274F1B0", Offset = "0x274E5B0", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x6000008")]
	public static UniTask AwaitForPlay(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274F2D0", Offset = "0x274E6D0", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x6000009")]
	public static UniTask AwaitForRewind(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274F3F0", Offset = "0x274E7F0", Length = "0x11F")]
	[Extension]
	[Token(Token = "0x600000A")]
	public static UniTask AwaitForStepComplete(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Extension]
	[Token(Token = "0x6000003")]
	public static TweenAwaiter GetAwaiter(Tween tween) { }

	[Address(RVA = "0x274F510", Offset = "0x274E910", Length = "0x11C")]
	[Extension]
	[Token(Token = "0x6000005")]
	public static UniTask ToUniTask(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274F630", Offset = "0x274EA30", Length = "0x119")]
	[Extension]
	[Token(Token = "0x6000004")]
	public static UniTask WithCancellation(Tween tween, CancellationToken cancellationToken) { }

}

