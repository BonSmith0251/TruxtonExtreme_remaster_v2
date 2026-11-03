namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000028")]
public static class EnumeratorAsyncExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <Core>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400008E")]
		public MonoBehaviour coroutineRunner; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400008F")]
		public IEnumerator inner; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000090")]
		public AutoResetUniTaskCompletionSource source; //Field offset: 0x30

		[Token(Token = "0x17000021")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000106")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000022")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000108")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000103")]
		public <Core>d__4(int <>1__state) { }

		[Address(RVA = "0x273A6F0", Offset = "0x2739AF0", Length = "0x74")]
		[Token(Token = "0x6000105")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000106")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000108")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x273A770", Offset = "0x2739B70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000107")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000104")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000029")]
	private sealed class EnumeratorPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<EnumeratorPromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x200002A")]
		private sealed class <>c
		{
			[Token(Token = "0x400007E")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F5F0", Offset = "0x273E9F0", Length = "0x67")]
			[Token(Token = "0x60000EE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60000EF")]
			public <>c() { }

			[Address(RVA = "0x273EBC0", Offset = "0x273DFC0", Length = "0x5A")]
			[Token(Token = "0x60000F0")]
			internal int <.cctor>b__4_0() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200002B")]
		private sealed class <ConsumeEnumerator>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007F")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000080")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000081")]
			public IEnumerator enumerator; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000082")]
			private CustomYieldInstruction <cyi>5__2; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000083")]
			private IEnumerator <innerCoroutine>5__3; //Field offset: 0x30

			[Token(Token = "0x1700001B")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60000F4")]
				private get { } //Length: 5
			}

			[Token(Token = "0x1700001C")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60000F6")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60000F1")]
			public <ConsumeEnumerator>d__19(int <>1__state) { }

			[Address(RVA = "0x2739BD0", Offset = "0x2738FD0", Length = "0x4DC")]
			[Token(Token = "0x60000F3")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F4")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F6")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x273A0D0", Offset = "0x27394D0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60000F5")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60000F2")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200002C")]
		private sealed class <UnwrapWaitAsyncOperation>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000084")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000085")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000086")]
			public AsyncOperation asyncOperation; //Field offset: 0x20

			[Token(Token = "0x1700001D")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60000FA")]
				private get { } //Length: 5
			}

			[Token(Token = "0x1700001E")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x60000FC")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60000F7")]
			public <UnwrapWaitAsyncOperation>d__22(int <>1__state) { }

			[Address(RVA = "0x2741020", Offset = "0x2740420", Length = "0x5F")]
			[Token(Token = "0x60000F9")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000FA")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000FC")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2741080", Offset = "0x2740480", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x60000FB")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60000F8")]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200002D")]
		private sealed class <UnwrapWaitForSeconds>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000087")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000088")]
			private object <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000089")]
			public WaitForSeconds waitForSeconds; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400008A")]
			private float <second>5__2; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x400008B")]
			private float <elapsed>5__3; //Field offset: 0x2C

			[Token(Token = "0x1700001F")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000100")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000020")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x6000102")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x60000FD")]
			public <UnwrapWaitForSeconds>d__21(int <>1__state) { }

			[Address(RVA = "0x27410C0", Offset = "0x27404C0", Length = "0x11D")]
			[Token(Token = "0x60000FF")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000100")]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000102")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x27411E0", Offset = "0x27405E0", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000101")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x60000FE")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x4000075")]
		private static TaskPool<EnumeratorPromise> pool; //Field offset: 0x0
		[Token(Token = "0x400007D")]
		private static readonly FieldInfo waitForSeconds_Seconds; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000076")]
		private EnumeratorPromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000077")]
		private IEnumerator innerEnumerator; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000078")]
		private CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000079")]
		private int initialFrame; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400007A")]
		private bool loopRunning; //Field offset: 0x2C
		[FieldOffset(Offset = "0x2D")]
		[Token(Token = "0x400007B")]
		private bool calledGetResult; //Field offset: 0x2D
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400007C")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x30

		[Token(Token = "0x1700001A")]
		public override EnumeratorPromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60000E1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2734570", Offset = "0x2733970", Length = "0x191")]
		[Token(Token = "0x60000E2")]
		private static EnumeratorPromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000E3")]
		private EnumeratorPromise() { }

		[Address(RVA = "0x2733DB0", Offset = "0x27331B0", Length = "0x67")]
		[IteratorStateMachine(typeof(<ConsumeEnumerator>d__19))]
		[Token(Token = "0x60000EB")]
		private static IEnumerator ConsumeEnumerator(IEnumerator enumerator) { }

		[Address(RVA = "0x2733E20", Offset = "0x2733220", Length = "0x277")]
		[Token(Token = "0x60000E4")]
		public static IUniTaskSource Create(IEnumerator innerEnumerator, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60000E1")]
		public override EnumeratorPromise get_NextNode() { }

		[Address(RVA = "0x27340A0", Offset = "0x27334A0", Length = "0x99")]
		[Token(Token = "0x60000E5")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2734140", Offset = "0x2733540", Length = "0x49")]
		[Token(Token = "0x60000E6")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2734190", Offset = "0x2733590", Length = "0x1A5")]
		[Token(Token = "0x60000E9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2734340", Offset = "0x2733740", Length = "0x70")]
		[Token(Token = "0x60000E8")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x27343B0", Offset = "0x27337B0", Length = "0x9C")]
		[Token(Token = "0x60000EA")]
		private bool TryReturn() { }

		[Address(RVA = "0x2734450", Offset = "0x2733850", Length = "0x3A")]
		[Token(Token = "0x60000E7")]
		public override UniTaskStatus UnsafeGetStatus() { }

		[Address(RVA = "0x2734490", Offset = "0x2733890", Length = "0x67")]
		[IteratorStateMachine(typeof(<UnwrapWaitAsyncOperation>d__22))]
		[Token(Token = "0x60000ED")]
		private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation) { }

		[Address(RVA = "0x2734500", Offset = "0x2733900", Length = "0x67")]
		[IteratorStateMachine(typeof(<UnwrapWaitForSeconds>d__21))]
		[Token(Token = "0x60000EC")]
		private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds) { }

	}


	[Address(RVA = "0x2733A10", Offset = "0x2732E10", Length = "0xA1")]
	[IteratorStateMachine(typeof(<Core>d__4))]
	[Token(Token = "0x60000E0")]
	private static IEnumerator Core(IEnumerator inner, MonoBehaviour coroutineRunner, AutoResetUniTaskCompletionSource source) { }

	[Address(RVA = "0x7E89F0", Offset = "0x7E7DF0", Length = "0x182")]
	[Extension]
	[Token(Token = "0x60000DC")]
	public static Awaiter GetAwaiter(T enumerator) { }

	[Address(RVA = "0x2733C10", Offset = "0x2733010", Length = "0xCB")]
	[Extension]
	[Token(Token = "0x60000DE")]
	public static UniTask ToUniTask(IEnumerator enumerator, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2733AC0", Offset = "0x2732EC0", Length = "0x14E")]
	[Extension]
	[Token(Token = "0x60000DF")]
	public static UniTask ToUniTask(IEnumerator enumerator, MonoBehaviour coroutineRunner) { }

	[Address(RVA = "0x2733CE0", Offset = "0x27330E0", Length = "0xCC")]
	[Extension]
	[Token(Token = "0x60000DD")]
	public static UniTask WithCancellation(IEnumerator enumerator, CancellationToken cancellationToken) { }

}

