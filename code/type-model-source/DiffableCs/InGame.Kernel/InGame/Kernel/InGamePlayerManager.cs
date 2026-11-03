namespace InGame.Kernel;

[Token(Token = "0x2000081")]
public class InGamePlayerManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000083")]
	private sealed class <_loadPlayerPrefab>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400042C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400042D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400042E")]
		public InGamePlayerManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400042F")]
		public string pname; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000430")]
		public int count; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000431")]
		private string <loadPath>5__2; //Field offset: 0x38

		[Token(Token = "0x170000ED")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000509")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000EE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600050B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000506")]
		public <_loadPlayerPrefab>d__6(int <>1__state) { }

		[Address(RVA = "0x1D2EC00", Offset = "0x1D2E000", Length = "0x4A3")]
		[Token(Token = "0x6000508")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000509")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600050B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2F0B0", Offset = "0x1D2E4B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600050A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000507")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000082")]
	private sealed class <LoadPrefabBank>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000427")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000428")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000429")]
		public InGamePlayerManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400042A")]
		public Dictionary<String, Int32> _dic; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400042B")]
		public MonoBehaviour _mono; //Field offset: 0x30

		[Token(Token = "0x170000EB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000503")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000EC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000505")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000500")]
		public <LoadPrefabBank>d__1(int <>1__state) { }

		[Address(RVA = "0x1D29070", Offset = "0x1D28470", Length = "0x2C4")]
		[Token(Token = "0x6000502")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000503")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000505")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D29340", Offset = "0x1D28740", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000504")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000501")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000423")]
	private Dictionary<String, PrefabBank`1<PlayerControll>> _pools; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000424")]
	private Transform _poolRoot; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000425")]
	private PlayerJetColors _jetColors; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000426")]
	private bool _loadError; //Field offset: 0x28

	[Token(Token = "0x170000EA")]
	public bool IsLoadError
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D20F90", Offset = "0x1D20390", Length = "0x94")]
	[IteratorStateMachine(typeof(<_loadPlayerPrefab>d__6))]
	[Token(Token = "0x60004FB")]
	private IEnumerator _loadPlayerPrefab(string pname, int count) { }

	[Address(RVA = "0x1D21030", Offset = "0x1D20430", Length = "0x300")]
	[Token(Token = "0x60004FC")]
	private void _releasePlayerPrefab() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60004FF")]
	public InGamePlayerManager() { }

	[Address(RVA = "0x1D208D0", Offset = "0x1D1FCD0", Length = "0x3F2")]
	[Token(Token = "0x60004F9")]
	public PlayerControll Get(string _name, Transform _root, bool is2Pcolor) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60004FE")]
	public bool get_IsLoadError() { }

	[Address(RVA = "0x1D20CD0", Offset = "0x1D200D0", Length = "0x8A")]
	[Token(Token = "0x60004F5")]
	public void Initialize(Transform poolRoot) { }

	[Address(RVA = "0x1D20D60", Offset = "0x1D20160", Length = "0x53")]
	[Token(Token = "0x60004F8")]
	public bool IsPool(string pname) { }

	[Address(RVA = "0x1D20DC0", Offset = "0x1D201C0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadPrefabBank>d__1))]
	[Token(Token = "0x60004F6")]
	public IEnumerator LoadPrefabBank(Dictionary<String, Int32> _dic, MonoBehaviour _mono) { }

	[Address(RVA = "0x1D20E70", Offset = "0x1D20270", Length = "0xDC")]
	[Token(Token = "0x60004FA")]
	public void Pool(PlayerControll _p) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60004FD")]
	public void SetColors(PlayerJetColors jets) { }

	[Address(RVA = "0x1D20F50", Offset = "0x1D20350", Length = "0x3E")]
	[Token(Token = "0x60004F7")]
	public void Terminate() { }

}

