namespace DG.Tweening.Core;

[AddComponentMenu(null)]
[Token(Token = "0x20000A3")]
public class DOTweenComponent : MonoBehaviour, IDOTweenInit
{
	[CompilerGenerated]
	[Token(Token = "0x20000A4")]
	private sealed class <WaitForCompletion>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CD")]
		public Tween t; //Field offset: 0x20

		[Token(Token = "0x17000010")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000011")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003E0")]
		public <WaitForCompletion>d__17(int <>1__state) { }

		[Address(RVA = "0x67B180", Offset = "0x67A580", Length = "0x66")]
		[Token(Token = "0x60003E2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B1F0", Offset = "0x67A5F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003E4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003E1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A7")]
	private sealed class <WaitForElapsedLoops>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D5")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D6")]
		public Tween t; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D7")]
		public int elapsedLoops; //Field offset: 0x28

		[Token(Token = "0x17000016")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000017")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003F2")]
		public <WaitForElapsedLoops>d__20(int <>1__state) { }

		[Address(RVA = "0x67B230", Offset = "0x67A630", Length = "0x6B")]
		[Token(Token = "0x60003F4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B2A0", Offset = "0x67A6A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003F6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003F3")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A6")]
	private sealed class <WaitForKill>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D3")]
		public Tween t; //Field offset: 0x20

		[Token(Token = "0x17000014")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003EF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000015")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003EC")]
		public <WaitForKill>d__19(int <>1__state) { }

		[Address(RVA = "0x67B2E0", Offset = "0x67A6E0", Length = "0x5D")]
		[Token(Token = "0x60003EE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003EF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B340", Offset = "0x67A740", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003F0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003ED")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private sealed class <WaitForPosition>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D9")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001DA")]
		public Tween t; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001DB")]
		public float position; //Field offset: 0x28

		[Token(Token = "0x17000018")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FB")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000019")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FD")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003F8")]
		public <WaitForPosition>d__21(int <>1__state) { }

		[Address(RVA = "0x67B380", Offset = "0x67A780", Length = "0x7E")]
		[Token(Token = "0x60003FA")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FD")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B400", Offset = "0x67A800", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003FC")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003F9")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A5")]
	private sealed class <WaitForRewind>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D0")]
		public Tween t; //Field offset: 0x20

		[Token(Token = "0x17000012")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003E9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000013")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003EB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003E6")]
		public <WaitForRewind>d__18(int <>1__state) { }

		[Address(RVA = "0x67B440", Offset = "0x67A840", Length = "0x85")]
		[Token(Token = "0x60003E8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003E9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003EB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B4D0", Offset = "0x67A8D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003EA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003E7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A9")]
	private sealed class <WaitForStart>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001DC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001DD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001DE")]
		public Tween t; //Field offset: 0x20

		[Token(Token = "0x1700001A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000401")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000403")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003FE")]
		public <WaitForStart>d__22(int <>1__state) { }

		[Address(RVA = "0x67B510", Offset = "0x67A910", Length = "0x66")]
		[Token(Token = "0x6000400")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000401")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000403")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x67B580", Offset = "0x67A980", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000402")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003FF")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C4")]
	public int inspectorUpdater; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001C5")]
	private float _unscaledTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C6")]
	private float _unscaledDeltaTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001C7")]
	private bool _paused; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C8")]
	private float _pausedTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001C9")]
	private bool _isQuitting; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40001CA")]
	private bool _duplicateToDestroy; //Field offset: 0x35

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60003DF")]
	public DOTweenComponent() { }

	[Address(RVA = "0x666DE0", Offset = "0x6661E0", Length = "0x20C")]
	[Token(Token = "0x60003CD")]
	private void Awake() { }

	[Address(RVA = "0x666FF0", Offset = "0x6663F0", Length = "0x14E")]
	[Token(Token = "0x60003DD")]
	internal static void Create() { }

	[Address(RVA = "0x667140", Offset = "0x666540", Length = "0x127")]
	[Token(Token = "0x60003DE")]
	internal static void DestroyInstance() { }

	[Address(RVA = "0x667270", Offset = "0x666670", Length = "0x188")]
	[Token(Token = "0x60003D1")]
	private void FixedUpdate() { }

	[Address(RVA = "0x667400", Offset = "0x666800", Length = "0x133")]
	[Token(Token = "0x60003D0")]
	private void LateUpdate() { }

	[Address(RVA = "0x667540", Offset = "0x666940", Length = "0x55")]
	[Token(Token = "0x60003D4")]
	public void OnApplicationPause(bool pauseStatus) { }

	[Address(RVA = "0x6675A0", Offset = "0x6669A0", Length = "0x4C")]
	[Token(Token = "0x60003D5")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x6675F0", Offset = "0x6669F0", Length = "0x668")]
	[Token(Token = "0x60003D3")]
	private void OnDestroy() { }

	[Address(RVA = "0x667C60", Offset = "0x667060", Length = "0x160")]
	[Token(Token = "0x60003D2")]
	private void OnDrawGizmos() { }

	[Address(RVA = "0x667DD0", Offset = "0x6671D0", Length = "0x67")]
	[Token(Token = "0x60003D6")]
	public override IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) { }

	[Address(RVA = "0x667E40", Offset = "0x667240", Length = "0xC1")]
	[Token(Token = "0x60003CE")]
	private void Start() { }

	[Address(RVA = "0x667F10", Offset = "0x667310", Length = "0x390")]
	[Token(Token = "0x60003CF")]
	private void Update() { }

	[Address(RVA = "0x6682A0", Offset = "0x6676A0", Length = "0x67")]
	[Token(Token = "0x60003D7")]
	internal IEnumerator WaitForCompletion(Tween t) { }

	[Address(RVA = "0x668310", Offset = "0x667710", Length = "0x77")]
	[Token(Token = "0x60003DA")]
	internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[Address(RVA = "0x668390", Offset = "0x667790", Length = "0x67")]
	[Token(Token = "0x60003D9")]
	internal IEnumerator WaitForKill(Tween t) { }

	[Address(RVA = "0x668400", Offset = "0x667800", Length = "0x79")]
	[Token(Token = "0x60003DB")]
	internal IEnumerator WaitForPosition(Tween t, float position) { }

	[Address(RVA = "0x668480", Offset = "0x667880", Length = "0x67")]
	[Token(Token = "0x60003D8")]
	internal IEnumerator WaitForRewind(Tween t) { }

	[Address(RVA = "0x6684F0", Offset = "0x6678F0", Length = "0x67")]
	[Token(Token = "0x60003DC")]
	internal IEnumerator WaitForStart(Tween t) { }

}

