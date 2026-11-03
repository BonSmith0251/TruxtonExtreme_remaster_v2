namespace OutGame.UI;

[Token(Token = "0x200015F")]
public class UIShutter : MonoBehaviourSingleton<UIShutter>
{
	[CompilerGenerated]
	[Token(Token = "0x2000162")]
	private struct <closeShutter>d__10 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400063B")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400063C")]
		public UIShutter <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400063D")]
		private Awaiter <>u__1; //Field offset: 0x18

		[Address(RVA = "0x220E460", Offset = "0x220D860", Length = "0x3E7")]
		[Token(Token = "0x60008EB")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008EC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000160")]
	private sealed class <OpenCloseAndWait>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000634")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000635")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000636")]
		public bool isOpen; //Field offset: 0x20

		[Token(Token = "0x170001F0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008E2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001F1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008E4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60008DF")]
		public <OpenCloseAndWait>d__3(int <>1__state) { }

		[Address(RVA = "0x2208000", Offset = "0x2207400", Length = "0x184")]
		[Token(Token = "0x60008E1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008E2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008E4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2208190", Offset = "0x2207590", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60008E3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60008E0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000163")]
	private struct <openShutter>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400063F")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000640")]
		public UIShutter <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000641")]
		public Action gearCallback; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000642")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x220F060", Offset = "0x220E460", Length = "0x8E0")]
		[Token(Token = "0x60008ED")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008EE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000161")]
	private sealed class <WaitMove>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000637")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000638")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000639")]
		private YieldInstruction <twait>5__2; //Field offset: 0x20

		[Token(Token = "0x170001F2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008E8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001F3")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008EA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60008E5")]
		public <WaitMove>d__4(int <>1__state) { }

		[Address(RVA = "0x220A5F0", Offset = "0x22099F0", Length = "0x14A")]
		[Token(Token = "0x60008E7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008E8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008EA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220A740", Offset = "0x2209B40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60008E9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60008E6")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000628")]
	private static readonly int _openDoorAnime; //Field offset: 0x0
	[Token(Token = "0x4000629")]
	private static readonly int _openGearAnime; //Field offset: 0x4
	[Token(Token = "0x400062A")]
	private static readonly int _closeAnime; //Field offset: 0x8
	[Token(Token = "0x400062B")]
	private static readonly float _scale; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400062C")]
	private Transform _top; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400062D")]
	private GameObject[] _shutters; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400062E")]
	private Animator _animator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400062F")]
	private CancellationToken _token; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000630")]
	private int _numObjects; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000631")]
	private bool _isMoving; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x4000632")]
	private bool _isOpen; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x4000633")]
	private bool _isGearLock; //Field offset: 0x46

	[Token(Token = "0x170001EE")]
	public bool IsMoving
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[Token(Token = "0x60008DB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001EF")]
	public bool IsOpen
	{
		[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
		[Token(Token = "0x60008DC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x220FF50", Offset = "0x220F350", Length = "0xBA")]
	[Token(Token = "0x60008DE")]
	private static UIShutter() { }

	[Address(RVA = "0x2210010", Offset = "0x220F410", Length = "0x39")]
	[Token(Token = "0x60008DD")]
	public UIShutter() { }

	[Address(RVA = "0x2210050", Offset = "0x220F450", Length = "0x83")]
	[AsyncStateMachine(typeof(<closeShutter>d__10))]
	[Token(Token = "0x60008D9")]
	private UniTaskVoid closeShutter() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[Token(Token = "0x60008DB")]
	public bool get_IsMoving() { }

	[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
	[Token(Token = "0x60008DC")]
	public bool get_IsOpen() { }

	[Address(RVA = "0x220F960", Offset = "0x220ED60", Length = "0x9B")]
	[Token(Token = "0x60008D1")]
	public static bool IsClose() { }

	[Address(RVA = "0x220FA00", Offset = "0x220EE00", Length = "0xD6")]
	[Token(Token = "0x60008D0")]
	public static void OpenAndCallback(Action tcallback) { }

	[Address(RVA = "0x220FB40", Offset = "0x220EF40", Length = "0xA8")]
	[Token(Token = "0x60008CF")]
	public static bool OpenClose(bool isOpen) { }

	[Address(RVA = "0x220FAE0", Offset = "0x220EEE0", Length = "0x5B")]
	[IteratorStateMachine(typeof(<OpenCloseAndWait>d__3))]
	[Token(Token = "0x60008D2")]
	public static IEnumerator OpenCloseAndWait(bool isOpen) { }

	[Address(RVA = "0x22100F0", Offset = "0x220F4F0", Length = "0xA5")]
	[AsyncStateMachine(typeof(<openShutter>d__9))]
	[Token(Token = "0x60008D8")]
	private UniTaskVoid openShutter(Action gearCallback) { }

	[Address(RVA = "0x220FBF0", Offset = "0x220EFF0", Length = "0x141")]
	[Token(Token = "0x60008D6")]
	private bool OpenShutter(bool isNextOpen, Action callback = null) { }

	[Address(RVA = "0x220FD40", Offset = "0x220F140", Length = "0x44")]
	[Token(Token = "0x60008DA")]
	private void PlayAnimator(int aHash) { }

	[Address(RVA = "0x220FD90", Offset = "0x220F190", Length = "0x74")]
	[Token(Token = "0x60008D7")]
	private void SetDisplay(bool isActive) { }

	[Address(RVA = "0x220FE10", Offset = "0x220F210", Length = "0x4")]
	[Token(Token = "0x60008D5")]
	public void SetGearLock(bool isLock) { }

	[Address(RVA = "0x220FE20", Offset = "0x220F220", Length = "0xD2")]
	[Token(Token = "0x60008D4")]
	public void SetupShutter() { }

	[Address(RVA = "0x220FF00", Offset = "0x220F300", Length = "0x4B")]
	[IteratorStateMachine(typeof(<WaitMove>d__4))]
	[Token(Token = "0x60008D3")]
	public static IEnumerator WaitMove() { }

}

