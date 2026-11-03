namespace InGame.Kernel;

[Token(Token = "0x2000096")]
public class InGameStageManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000097")]
	private sealed class <CreateStagePrefab>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B3")]
		public GameObject tobj; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004B4")]
		public Transform _root; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004B5")]
		public InGameStageManager <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004B6")]
		private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x38

		[Token(Token = "0x17000111")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005A1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000112")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005A3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600059E")]
		public <CreateStagePrefab>d__6(int <>1__state) { }

		[Address(RVA = "0x1D45450", Offset = "0x1D44850", Length = "0x1A7")]
		[Token(Token = "0x60005A0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005A3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D45600", Offset = "0x1D44A00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005A2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600059F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000098")]
	private sealed class <LoadStagePrefab>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004B7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B8")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004B9")]
		public InGameStageManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004BA")]
		public string stgname; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004BB")]
		public Transform _root; //Field offset: 0x30

		[Token(Token = "0x17000113")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005A7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000114")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005A9")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60005A4")]
		public <LoadStagePrefab>d__2(int <>1__state) { }

		[Address(RVA = "0x1D461A0", Offset = "0x1D455A0", Length = "0x198")]
		[Token(Token = "0x60005A6")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005A7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005A9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D46340", Offset = "0x1D45740", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005A8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60005A5")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000099")]
	private sealed class <LoadStagePrefab>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004BD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004BE")]
		public InGameStageManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004BF")]
		public AssetReference tstage; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004C0")]
		public Transform _root; //Field offset: 0x30

		[Token(Token = "0x17000115")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005AD")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000116")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005AF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60005AA")]
		public <LoadStagePrefab>d__3(int <>1__state) { }

		[Address(RVA = "0x1D46380", Offset = "0x1D45780", Length = "0x187")]
		[Token(Token = "0x60005AC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005AD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005AF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D46510", Offset = "0x1D45910", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005AE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60005AB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009A")]
	private sealed class <ReleaseStageTimeline>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004C1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004C2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004C3")]
		public InGameStageManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000117")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005B3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000118")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60005B5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60005B0")]
		public <ReleaseStageTimeline>d__5(int <>1__state) { }

		[Address(RVA = "0x1D469D0", Offset = "0x1D45DD0", Length = "0x1DD")]
		[Token(Token = "0x60005B2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005B3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60005B5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D46BB0", Offset = "0x1D45FB0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60005B4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60005B1")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40004AC")]
	public static readonly string _stagePath; //Field offset: 0x0
	[Token(Token = "0x40004AD")]
	private static readonly int StageResidentCode; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004AE")]
	private InGameStage _stageObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004AF")]
	private string _stageLoadPath; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B0")]
	private AssetReference _stageReference; //Field offset: 0x20

	[Token(Token = "0x17000110")]
	public InGameStage StageObject
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600059B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D37BD0", Offset = "0x1D36FD0", Length = "0x78")]
	[Token(Token = "0x600059D")]
	private static InGameStageManager() { }

	[Address(RVA = "0x1D37C50", Offset = "0x1D37050", Length = "0x36")]
	[Token(Token = "0x600059C")]
	public InGameStageManager() { }

	[Address(RVA = "0x1D37880", Offset = "0x1D36C80", Length = "0xA1")]
	[IteratorStateMachine(typeof(<CreateStagePrefab>d__6))]
	[Token(Token = "0x600059A")]
	private IEnumerator CreateStagePrefab(GameObject tobj, Transform _root) { }

	[Address(RVA = "0x1D37930", Offset = "0x1D36D30", Length = "0xB8")]
	[Token(Token = "0x6000598")]
	private void DestroyStageObject() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600059B")]
	public InGameStage get_StageObject() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000594")]
	public void Initialize() { }

	[Address(RVA = "0x1D37AA0", Offset = "0x1D36EA0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadStagePrefab>d__2))]
	[Token(Token = "0x6000596")]
	public IEnumerator LoadStagePrefab(string stgname, Transform _root) { }

	[Address(RVA = "0x1D379F0", Offset = "0x1D36DF0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadStagePrefab>d__3))]
	[Token(Token = "0x6000597")]
	public IEnumerator LoadStagePrefab(AssetReference tstage, Transform _root) { }

	[Address(RVA = "0x1D37B50", Offset = "0x1D36F50", Length = "0x67")]
	[IteratorStateMachine(typeof(<ReleaseStageTimeline>d__5))]
	[Token(Token = "0x6000599")]
	public IEnumerator ReleaseStageTimeline() { }

	[Address(RVA = "0x1D37BC0", Offset = "0x1D36FC0", Length = "0x7")]
	[Token(Token = "0x6000595")]
	public void Terminate() { }

}

