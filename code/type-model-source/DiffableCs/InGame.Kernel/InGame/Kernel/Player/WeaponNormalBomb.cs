namespace InGame.Kernel.Player;

[Token(Token = "0x2000137")]
public class WeaponNormalBomb : WeaponBaseBomb
{
	[CompilerGenerated]
	[Token(Token = "0x2000139")]
	private struct <_progressBombAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008F4")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008F5")]
		public WeaponNormalBomb <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008F6")]
		public Vector3 epos; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40008F7")]
		public int nlevel; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008F8")]
		private WeaponBombCollision <fired>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008F9")]
		private InGameManager <gm>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008FA")]
		private CancellationToken <ltoken>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40008FB")]
		private CinemachineMan <cm>5__5; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40008FC")]
		private float <shakeTime>5__6; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40008FD")]
		private float <rtime>5__7; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40008FE")]
		private Awaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x1D73E10", Offset = "0x1D73210", Length = "0x7EE")]
		[Token(Token = "0x60009CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60009CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000138")]
	private sealed class <Initialize>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008EB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008EC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008ED")]
		public WeaponNormalBomb <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008EE")]
		public Transform _parent; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008EF")]
		public Transform pool; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008F0")]
		public int _pno; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40008F1")]
		private int <tcnt>5__2; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40008F2")]
		private int <i>5__3; //Field offset: 0x40

		[Token(Token = "0x170001BA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009CA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001BB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009CC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60009C7")]
		public <Initialize>d__0(int <>1__state) { }

		[Address(RVA = "0x1D72C10", Offset = "0x1D72010", Length = "0x365")]
		[Token(Token = "0x60009C9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009CA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009CC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D73950", Offset = "0x1D72D50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60009CB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60009C8")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40008E2")]
	private const int _bombMax = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008E3")]
	private CancellationTokenSource _token; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008E4")]
	private Transform _root; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008E5")]
	private int _bomberSafeCounter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008E6")]
	private PrefabBank<WeaponBombCollision>[] _bombBanks; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008E7")]
	public PrefabBank<WeaponBombCollision> _bombBank; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008E8")]
	private WeaponBombCollision _lastBomb; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40008E9")]
	private GameObject[] _bombBases; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008EA")]
	private ID[] _requestSounds; //Field offset: 0x60

	[Address(RVA = "0x1D75D40", Offset = "0x1D75140", Length = "0xC2")]
	[AsyncStateMachine(typeof(<_progressBombAsync>d__5))]
	[Token(Token = "0x60009C5")]
	private UniTaskVoid _progressBombAsync(Vector3 epos, int nlevel) { }

	[Address(RVA = "0x1D75CA0", Offset = "0x1D750A0", Length = "0xA0")]
	[Token(Token = "0x60009C6")]
	public WeaponNormalBomb() { }

	[Address(RVA = "0x1D75850", Offset = "0x1D74C50", Length = "0x20B")]
	[Token(Token = "0x60009C1")]
	public bool Bomb(int nawakenLevel) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60009C4")]
	public PrefabBank<WeaponBombCollision>[] BombBanks() { }

	[Address(RVA = "0x1D75A60", Offset = "0x1D74E60", Length = "0xB4")]
	[IteratorStateMachine(typeof(<Initialize>d__0))]
	[Token(Token = "0x60009C0")]
	public IEnumerator Initialize(Transform pool, Transform _parent, int _pno) { }

	[Address(RVA = "0x1D75B20", Offset = "0x1D74F20", Length = "0x8A")]
	[Token(Token = "0x60009C2")]
	public bool IsBomb() { }

	[Address(RVA = "0x1D75BB0", Offset = "0x1D74FB0", Length = "0xED")]
	[Token(Token = "0x60009C3")]
	public void Terminate() { }

}

