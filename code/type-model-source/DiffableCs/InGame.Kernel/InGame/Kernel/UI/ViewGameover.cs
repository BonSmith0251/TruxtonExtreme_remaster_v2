namespace InGame.Kernel.UI;

[Token(Token = "0x20000C3")]
public class ViewGameover : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000C4")]
	private sealed class <DisplayGameOver>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005C8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005C9")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005CA")]
		public ViewGameover <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005CB")]
		public PlayerControll[] players; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40005CC")]
		public Action callback; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40005CD")]
		private bool <isSkip>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40005CE")]
		private float <ltime>5__3; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40005CF")]
		private float <atime>5__4; //Field offset: 0x40

		[Token(Token = "0x17000145")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000146")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006F6")]
		public <DisplayGameOver>d__1(int <>1__state) { }

		[Address(RVA = "0x1D45900", Offset = "0x1D44D00", Length = "0x560")]
		[Token(Token = "0x60006F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D45E80", Offset = "0x1D45280", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C5")]
	private sealed class <DisplayGameOverArena>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005D0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005D1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005D2")]
		public ViewGameover <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005D3")]
		private float <ltime>5__2; //Field offset: 0x28

		[Token(Token = "0x17000147")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006FF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000148")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000701")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006FC")]
		public <DisplayGameOverArena>d__2(int <>1__state) { }

		[Address(RVA = "0x1D45680", Offset = "0x1D44A80", Length = "0x239")]
		[Token(Token = "0x60006FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006FF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000701")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D458C0", Offset = "0x1D44CC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000700")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40005C2")]
	private static readonly float FadeWaitSeconds; //Field offset: 0x0
	[Token(Token = "0x40005C3")]
	private static readonly float ArenaEndWaitSeconds; //Field offset: 0x4
	[Token(Token = "0x40005C4")]
	private static readonly float FadeoutSeconds; //Field offset: 0x8
	[Token(Token = "0x40005C5")]
	private static readonly float DisplayTimeSeconds; //Field offset: 0xC
	[Token(Token = "0x40005C6")]
	private static readonly Color fadeStart; //Field offset: 0x10
	[Token(Token = "0x40005C7")]
	private static readonly Color fadeEnd; //Field offset: 0x20
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005C0")]
	private GameObject _backgroundItems; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005C1")]
	private UIImage _backgroundFade; //Field offset: 0x28

	[Address(RVA = "0x1D47D70", Offset = "0x1D47170", Length = "0x120")]
	[Token(Token = "0x60006F2")]
	private bool _checkSkip(PlayerControll[] players) { }

	[Address(RVA = "0x1D47C70", Offset = "0x1D47070", Length = "0xF2")]
	[Token(Token = "0x60006F5")]
	private static ViewGameover() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006F4")]
	public ViewGameover() { }

	[Address(RVA = "0x1D47B90", Offset = "0x1D46F90", Length = "0xA1")]
	[IteratorStateMachine(typeof(<DisplayGameOver>d__1))]
	[Token(Token = "0x60006F0")]
	public IEnumerator DisplayGameOver(PlayerControll[] players, Action callback) { }

	[Address(RVA = "0x1D47B20", Offset = "0x1D46F20", Length = "0x67")]
	[IteratorStateMachine(typeof(<DisplayGameOverArena>d__2))]
	[Token(Token = "0x60006F1")]
	public IEnumerator DisplayGameOverArena() { }

	[Address(RVA = "0x1D47EA0", Offset = "0x1D472A0", Length = "0x9E")]
	[Token(Token = "0x60006F3")]
	private void displayItem() { }

	[Address(RVA = "0x1D47C40", Offset = "0x1D47040", Length = "0x20")]
	[Token(Token = "0x60006EF")]
	public void Setup() { }

}

