namespace InGame.Kernel;

[Token(Token = "0x200008D")]
public class InGameRuinManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private struct <_entryRuin>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000484")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000485")]
		public InGameRuinManager <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000486")]
		public PrefabBankValue _ruin; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000487")]
		public Transform _root; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000488")]
		private PrefabBank<IRuinObject> <pbank>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000489")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1D2E230", Offset = "0x1D2D630", Length = "0x456")]
		[Token(Token = "0x6000576")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000577")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008E")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400047A")]
		public InGameRuinManager <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400047B")]
		public PrefabBank<IRuinObject> _aPool; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400047C")]
		public int eIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400047D")]
		public IRuinObject e; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600056E")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x1D2C020", Offset = "0x1D2B420", Length = "0x75")]
		[Token(Token = "0x600056F")]
		internal void <EmitterFrom3D>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008F")]
	private sealed class <LoadPrefabBank>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400047E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400047F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000480")]
		public InGameRuinManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000481")]
		public Dictionary<String, Int32> _dic; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000482")]
		public Transform _root; //Field offset: 0x30

		[Token(Token = "0x17000104")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000573")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000105")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000575")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000570")]
		public <LoadPrefabBank>d__1(int <>1__state) { }

		[Address(RVA = "0x1D28AC0", Offset = "0x1D27EC0", Length = "0x5A0")]
		[Token(Token = "0x6000572")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000573")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000575")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D29380", Offset = "0x1D28780", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000574")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000571")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000476")]
	private Dictionary<String, PrefabBank`1<IRuinObject>> _pools; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000477")]
	private HashSet<IRuinObject> _activeRuins; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000478")]
	private HashSet<IRuinObject> _endRuins; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000479")]
	private bool _isLoadError; //Field offset: 0x28

	[Token(Token = "0x17000103")]
	public bool IsLoadError
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600056C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D24C70", Offset = "0x1D24070", Length = "0x111")]
	[AsyncStateMachine(typeof(<_entryRuin>d__7))]
	[Token(Token = "0x600056B")]
	private UniTask _entryRuin(Transform _root, PrefabBankValue _ruin) { }

	[Address(RVA = "0x1D24BC0", Offset = "0x1D23FC0", Length = "0xA5")]
	[Token(Token = "0x600056D")]
	public InGameRuinManager() { }

	[Address(RVA = "0x1D24010", Offset = "0x1D23410", Length = "0x264")]
	[Token(Token = "0x600056A")]
	public IRuinObject EmitterFrom3D(string rname, Transform root, Vector3 _pos3d, float aliveTime, bool isGround) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600056C")]
	public bool get_IsLoadError() { }

	[Address(RVA = "0x1D24280", Offset = "0x1D23680", Length = "0x6D")]
	[Token(Token = "0x6000564")]
	public void Initialize() { }

	[Address(RVA = "0x1D242F0", Offset = "0x1D236F0", Length = "0x53")]
	[Token(Token = "0x6000569")]
	public bool IsPool(string name) { }

	[Address(RVA = "0x1D24350", Offset = "0x1D23750", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadPrefabBank>d__1))]
	[Token(Token = "0x6000565")]
	public IEnumerator LoadPrefabBank(Dictionary<String, Int32> _dic, Transform _root) { }

	[Address(RVA = "0x1D24400", Offset = "0x1D23800", Length = "0x235")]
	[Token(Token = "0x6000567")]
	public void ResetRuins() { }

	[Address(RVA = "0x1D24640", Offset = "0x1D23A40", Length = "0x1E4")]
	[Token(Token = "0x6000568")]
	public void Terminate() { }

	[Address(RVA = "0x1D24830", Offset = "0x1D23C30", Length = "0x382")]
	[Token(Token = "0x6000566")]
	public void UpdateRuins(float dt) { }

}

