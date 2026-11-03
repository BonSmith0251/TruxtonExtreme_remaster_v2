namespace OutGame.Extra;

[Token(Token = "0x200017A")]
public class ModelViewerPresenter : PresenterBasic<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x2000181")]
	private sealed class <_BeginView>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006DA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006DB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006DC")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700020D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000998")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700020E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600099A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000995")]
		public <_BeginView>d__1(int <>1__state) { }

		[Address(RVA = "0x220AB70", Offset = "0x2209F70", Length = "0x2A4")]
		[Token(Token = "0x6000997")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000998")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600099A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220AF10", Offset = "0x220A310", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000999")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000996")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000185")]
	private struct <_decideModel>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006E7")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006E8")]
		public ModelData md; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006E9")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006EA")]
		public bool seFlag; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006EB")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x220D7E0", Offset = "0x220CBE0", Length = "0x318")]
		[Token(Token = "0x60009AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x220A510", Offset = "0x2209910", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60009AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000182")]
	private sealed class <_EndView>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006DD")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006DE")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006DF")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700020F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600099E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000210")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009A0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600099B")]
		public <_EndView>d__4(int <>1__state) { }

		[Address(RVA = "0x220B890", Offset = "0x220AC90", Length = "0x1A3")]
		[Token(Token = "0x600099D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600099E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009A0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220BA40", Offset = "0x220AE40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600099F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600099C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000183")]
	private sealed class <_Initialize>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006E1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006E2")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000211")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009A4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000212")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009A6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60009A1")]
		public <_Initialize>d__0(int <>1__state) { }

		[Address(RVA = "0x220BD40", Offset = "0x220B140", Length = "0x12E")]
		[Token(Token = "0x60009A3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009A4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009A6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220BE70", Offset = "0x220B270", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60009A5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60009A2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000184")]
	private sealed class <_UpdateCoroutine>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E3")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006E4")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006E5")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000213")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009AA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000214")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009AC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60009A7")]
		public <_UpdateCoroutine>d__2(int <>1__state) { }

		[Address(RVA = "0x220C7A0", Offset = "0x220BBA0", Length = "0x8C")]
		[Token(Token = "0x60009A9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009AA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009AC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220C870", Offset = "0x220BC70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60009AB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60009A8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200017E")]
	private sealed class <>c
	{
		[Token(Token = "0x40006D0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40006D1")]
		public static Comparison<ModelData> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x2209F70", Offset = "0x2209370", Length = "0x67")]
		[Token(Token = "0x600098A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600098B")]
		public <>c() { }

		[Address(RVA = "0x2209A80", Offset = "0x2208E80", Length = "0x1F")]
		[Token(Token = "0x600098C")]
		internal int <SetupModel>b__9_0(ModelData a, ModelData b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200017F")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006D2")]
		public ModelData md; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006D3")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600098D")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x2209ED0", Offset = "0x22092D0", Length = "0x28")]
		[Token(Token = "0x600098E")]
		internal void <SetupButton>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000186")]
	private struct <addIcon>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006ED")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006EE")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006EF")]
		public int idx; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006F0")]
		public PopupButton2 button; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006F1")]
		private ModelData <md>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40006F2")]
		private Awaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x220DC20", Offset = "0x220D020", Length = "0x482")]
		[Token(Token = "0x60009AF")]
		private override void MoveNext() { }

		[Address(RVA = "0x220A510", Offset = "0x2209910", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60009B0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000180")]
	private sealed class <SetupModel>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006D4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006D5")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006D6")]
		public ModelViewerPresenter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006D7")]
		private GameSetting <gameSetting>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006D8")]
		private Enemies <enemies>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006D9")]
		private General <general>5__4; //Field offset: 0x38

		[Token(Token = "0x1700020B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000992")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700020C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000994")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600098F")]
		public <SetupModel>d__9(int <>1__state) { }

		[Address(RVA = "0x2208BE0", Offset = "0x2207FE0", Length = "0xB8A")]
		[Token(Token = "0x6000991")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000992")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000994")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2209770", Offset = "0x2208B70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000993")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000990")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200017B")]
	private class ModelData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006BA")]
		public Data edata; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006BB")]
		public int priority; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006BC")]
		public PopupButton2 button; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006BD")]
		public string baseName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006BE")]
		public string modelPath; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006BF")]
		public string iconPath; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006C0")]
		public int myIndex; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40006C1")]
		public bool loadFlg; //Field offset: 0x44

		[Address(RVA = "0x21FDF00", Offset = "0x21FD300", Length = "0x10E")]
		[Token(Token = "0x600097E")]
		public ModelData(Data d, int p, string name, string modelName) { }

	}

	[Token(Token = "0x200017C")]
	private class ModelMan
	{
		[CompilerGenerated]
		[Token(Token = "0x200017D")]
		private struct <load>d__5 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006C9")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40006CA")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40006CB")]
			public ModelMan <>4__this; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40006CC")]
			public ModelData md; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40006CD")]
			private Awaiter <>u__1; //Field offset: 0x28
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x40006CE")]
			private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x40006CF")]
			private Awaiter<GameObject> <>u__2; //Field offset: 0x40

			[Address(RVA = "0x220E850", Offset = "0x220DC50", Length = "0x80C")]
			[Token(Token = "0x6000988")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000989")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006C2")]
		private Transform modelRootTransform; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006C3")]
		private ModelData nowMd; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006C4")]
		private GameObject model; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006C5")]
		private Transform modelTransform; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006C6")]
		private GalleryModelBase script; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006C7")]
		private Vector3 initialAngle; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40006C8")]
		private Vector3 initialScale; //Field offset: 0x44

		[Address(RVA = "0x21FE090", Offset = "0x21FD490", Length = "0xAE")]
		[Token(Token = "0x600097F")]
		public ModelMan() { }

		[Address(RVA = "0x21FE140", Offset = "0x21FD540", Length = "0xBE")]
		[Token(Token = "0x6000982")]
		public void destroy() { }

		[Address(RVA = "0x21FE010", Offset = "0x21FD410", Length = "0x7")]
		[Token(Token = "0x6000980")]
		public override void Dispose() { }

		[Address(RVA = "0x21FE020", Offset = "0x21FD420", Length = "0x63")]
		[Token(Token = "0x6000981")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x21FE200", Offset = "0x21FD600", Length = "0x162")]
		[Token(Token = "0x6000985")]
		private void initAngleScale() { }

		[Address(RVA = "0x21FE370", Offset = "0x21FD770", Length = "0x2F")]
		[Token(Token = "0x6000983")]
		public bool isLoaded(ModelData md) { }

		[Address(RVA = "0x21FE3A0", Offset = "0x21FD7A0", Length = "0x1E4")]
		[AsyncStateMachine(typeof(<load>d__5))]
		[Token(Token = "0x6000984")]
		public UniTask load(ModelData md) { }

		[Address(RVA = "0x21FE590", Offset = "0x21FD990", Length = "0x415")]
		[Token(Token = "0x6000987")]
		public bool padOpe(AppGamePad pad) { }

		[Address(RVA = "0x21FE9B0", Offset = "0x21FDDB0", Length = "0xB3")]
		[Token(Token = "0x6000986")]
		private void resetAngleScale() { }

	}

	[Token(Token = "0x400069C")]
	private static readonly float modelScaleStep; //Field offset: 0x0
	[Token(Token = "0x400069D")]
	private static readonly float modelMinScale; //Field offset: 0x4
	[Token(Token = "0x400069E")]
	private static readonly float modelMaxScale; //Field offset: 0x8
	[Token(Token = "0x400069F")]
	private static readonly float autoModelLoadTime; //Field offset: 0xC
	[Token(Token = "0x40006A0")]
	private static readonly string enemyDatabasePath; //Field offset: 0x10
	[Token(Token = "0x40006B6")]
	private static readonly int _listColumns; //Field offset: 0x18
	[Token(Token = "0x40006B7")]
	private static int _listLines; //Field offset: 0x1C
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40006A1")]
	private RectTransform _contentTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40006A2")]
	private PopupButton2 _iconButton; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40006A3")]
	private FloatingCursor _cursor; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40006A4")]
	private Sprite _invalidIcon; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40006A5")]
	private InGameBGObject _bgViewer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40006A6")]
	private Material[] _playerMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40006A7")]
	private UITextMeshPro _comentaryName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40006A8")]
	private UITextMeshPro _comentaryName2; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40006A9")]
	private RectTransform _comentaryBack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x40006AA")]
	private RectTransform _scrollRectTransform; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40006AB")]
	private ScrollRect _scrollRect; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40006AC")]
	private GridLayoutGroup _gridLayoutGroup; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40006AD")]
	private RectTransform _iconTransform; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40006AE")]
	private List<ModelData> _modelList; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40006AF")]
	private int _modelMax; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40006B0")]
	private int _modelIndex; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40006B1")]
	private ModelMan _modelMan; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40006B2")]
	private InGameBGObject _bgObject; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40006B3")]
	private Camera _viewCamera; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40006B4")]
	private float _cursorWait; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40006B5")]
	private int _listTopIndex; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40006B8")]
	private int _listDispMax; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40006B9")]
	private int _listScroolMargin; //Field offset: 0xE4

	[Address(RVA = "0x21FF5A0", Offset = "0x21FE9A0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__1))]
	[Token(Token = "0x6000967")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x21FF960", Offset = "0x21FED60", Length = "0x17")]
	[Token(Token = "0x6000974")]
	private bool _clamp(ref int val, int min, int max) { }

	[Address(RVA = "0x21FFA30", Offset = "0x21FEE30", Length = "0xDC")]
	[AsyncStateMachine(typeof(<_decideModel>d__13))]
	[Token(Token = "0x6000973")]
	private void _decideModel(ModelData md, bool seFlag = true) { }

	[Address(RVA = "0x21FF610", Offset = "0x21FEA10", Length = "0x67")]
	[IteratorStateMachine(typeof(<_EndView>d__4))]
	[Token(Token = "0x600096A")]
	protected virtual IEnumerator _EndView() { }

	[Address(RVA = "0x21FF680", Offset = "0x21FEA80", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__0))]
	[Token(Token = "0x6000966")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x21FFB10", Offset = "0x21FEF10", Length = "0x23F")]
	[Token(Token = "0x6000975")]
	private void _moveCursor(Size step) { }

	[Address(RVA = "0x21FF760", Offset = "0x21FEB60", Length = "0x10F")]
	[Token(Token = "0x6000969")]
	protected virtual void _Update() { }

	[Address(RVA = "0x21FF6F0", Offset = "0x21FEAF0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_UpdateCoroutine>d__2))]
	[Token(Token = "0x6000968")]
	protected virtual IEnumerator _UpdateCoroutine() { }

	[Address(RVA = "0x21FFD50", Offset = "0x21FF150", Length = "0x106")]
	[Token(Token = "0x6000976")]
	private void _updateIcon(int idx, bool flyFlg) { }

	[Address(RVA = "0x21FF870", Offset = "0x21FEC70", Length = "0xE5")]
	[Token(Token = "0x6000979")]
	private static ModelViewerPresenter() { }

	[Address(RVA = "0x21FF980", Offset = "0x21FED80", Length = "0xA2")]
	[Token(Token = "0x6000978")]
	public ModelViewerPresenter() { }

	[Address(RVA = "0x21FF4A0", Offset = "0x21FE8A0", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x600097A")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x21FF4E0", Offset = "0x21FE8E0", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x600097B")]
	private IEnumerator <>n__1() { }

	[Address(RVA = "0x21FF520", Offset = "0x21FE920", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x600097C")]
	private IEnumerator <>n__2() { }

	[Address(RVA = "0x21FF560", Offset = "0x21FE960", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x600097D")]
	private IEnumerator <>n__3() { }

	[Address(RVA = "0x21FFE60", Offset = "0x21FF260", Length = "0xE3")]
	[AsyncStateMachine(typeof(<addIcon>d__11))]
	[Token(Token = "0x6000971")]
	private void addIcon(int idx, PopupButton2 button) { }

	[Address(RVA = "0x21FEA70", Offset = "0x21FDE70", Length = "0x5A")]
	[Token(Token = "0x600096B")]
	public static bool IsNew() { }

	[Address(RVA = "0x21FEAD0", Offset = "0x21FDED0", Length = "0x198")]
	[Token(Token = "0x6000970")]
	private void ReleseModel() { }

	[Address(RVA = "0x21FEC70", Offset = "0x21FE070", Length = "0x77")]
	[Token(Token = "0x600096E")]
	private void RestreCamera() { }

	[Address(RVA = "0x21FECF0", Offset = "0x21FE0F0", Length = "0x1E7")]
	[Token(Token = "0x6000977")]
	private void Scroll(int nodeIndex) { }

	[Address(RVA = "0x21FEEE0", Offset = "0x21FE2E0", Length = "0x144")]
	[Token(Token = "0x6000972")]
	protected virtual bool Select(AppGamePad pad) { }

	[Address(RVA = "0x21FF030", Offset = "0x21FE430", Length = "0x1ED")]
	[Token(Token = "0x600096C")]
	private void SetupButton() { }

	[Address(RVA = "0x21FF220", Offset = "0x21FE620", Length = "0x20E")]
	[Token(Token = "0x600096D")]
	private void SetupCamera() { }

	[Address(RVA = "0x21FF430", Offset = "0x21FE830", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupModel>d__9))]
	[Token(Token = "0x600096F")]
	private IEnumerator SetupModel() { }

}

