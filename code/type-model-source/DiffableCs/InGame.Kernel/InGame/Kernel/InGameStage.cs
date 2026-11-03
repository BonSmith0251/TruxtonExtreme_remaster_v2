namespace InGame.Kernel;

[Token(Token = "0x2000091")]
public class InGameStage : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <SetupEnemy>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400049F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004A0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004A1")]
		public InGameStage <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004A2")]
		private InGameManager <m>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004A3")]
		private Dictionary<String, Int32> <btDic>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004A4")]
		private Dictionary<String, Int32> <routeDic>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40004A5")]
		private Dictionary<String, Int32> <ruinDic>5__5; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40004A6")]
		private List<IEnumerator> <_quelists>5__6; //Field offset: 0x48

		[Token(Token = "0x1700010C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600058B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700010D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600058D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000588")]
		public <SetupEnemy>d__3(int <>1__state) { }

		[Address(RVA = "0x1D46BF0", Offset = "0x1D45FF0", Length = "0x585")]
		[Token(Token = "0x600058A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600058B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600058D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D47180", Offset = "0x1D46580", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600058C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000589")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000095")]
	private sealed class <SetupStage>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004A7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004A8")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004A9")]
		public InGameStage <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004AA")]
		private InGameManager <m>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004AB")]
		private AsyncInstantiateOperation<GameObject> <op>5__3; //Field offset: 0x30

		[Token(Token = "0x1700010E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000591")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700010F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000593")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600058E")]
		public <SetupStage>d__2(int <>1__state) { }

		[Address(RVA = "0x1D471C0", Offset = "0x1D465C0", Length = "0x4A3")]
		[Token(Token = "0x6000590")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000591")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000593")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D47670", Offset = "0x1D46A70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000592")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600058F")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000093")]
	internal class MaxParticleData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400049D")]
		public string objName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400049E")]
		public int maxCount; //Field offset: 0x18

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x6000587")]
		public MaxParticleData() { }

	}

	[Token(Token = "0x2000092")]
	internal enum StageTypes : int
	{
		type2D = 0,
		typeArena = 1,
	}

	[Token(Token = "0x400048A")]
	private const float _slideRangeBase = 50; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400048B")]
	private StageTypes _stageType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400048C")]
	private PlayStage _stageOrder; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048D")]
	private Camera _stageCamera; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400048E")]
	private PrefabPacks _effects; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400048F")]
	private PrefabPacks _bullets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000490")]
	private InGameBGObject _bg; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000491")]
	private GameObject _ingameCinemachine; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000492")]
	private string _startAreaName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000493")]
	private Transform _stageRoot; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000494")]
	private Transform _cameraFollowTarget; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000495")]
	private bool _isStageRootEnable; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000496")]
	private List<MaxParticleData> maxParticles; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000497")]
	private CinemachineMan _cinemaMan; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000498")]
	private PlayableDirector _stagetl; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000499")]
	private PlayableDirector _mainTL; //Field offset: 0x88

	[Token(Token = "0x17000108")]
	public PrefabPacks Bullets
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000582")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700010A")]
	public Transform DecoyTarget
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000584")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000107")]
	public PrefabPacks Effects
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000581")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000106")]
	public PlayStage StageOrder
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000580")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700010B")]
	public PlayableDirector StageTimeline
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000585")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000109")]
	public string StartAreaName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000583")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D253B0", Offset = "0x1D247B0", Length = "0x36")]
	[Token(Token = "0x6000586")]
	public InGameStage() { }

	[Address(RVA = "0x1D253F0", Offset = "0x1D247F0", Length = "0x172")]
	[Token(Token = "0x600057E")]
	private void changeOverlayCamera() { }

	[Address(RVA = "0x1D25570", Offset = "0x1D24970", Length = "0x90")]
	[Token(Token = "0x600057F")]
	private void changeSystemCamera() { }

	[Address(RVA = "0x1D24D90", Offset = "0x1D24190", Length = "0x186")]
	[Token(Token = "0x600057C")]
	public void EntryStage(Transform pplayer) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000582")]
	public PrefabPacks get_Bullets() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000584")]
	public Transform get_DecoyTarget() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000581")]
	public PrefabPacks get_Effects() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000580")]
	public PlayStage get_StageOrder() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000585")]
	public PlayableDirector get_StageTimeline() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000583")]
	public string get_StartAreaName() { }

	[Address(RVA = "0x1D24F20", Offset = "0x1D24320", Length = "0xF1")]
	[Token(Token = "0x6000578")]
	public void Initialize() { }

	[Address(RVA = "0x1D25020", Offset = "0x1D24420", Length = "0x9B")]
	[Token(Token = "0x600057D")]
	public void RemoveStage() { }

	[Address(RVA = "0x1D250C0", Offset = "0x1D244C0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<SetupEnemy>d__3))]
	[Token(Token = "0x600057B")]
	public IEnumerator SetupEnemy() { }

	[Address(RVA = "0x1D25130", Offset = "0x1D24530", Length = "0x6D")]
	[IteratorStateMachine(typeof(<SetupStage>d__2))]
	[Token(Token = "0x600057A")]
	public IEnumerator SetupStage() { }

	[Address(RVA = "0x1D251A0", Offset = "0x1D245A0", Length = "0x20A")]
	[Token(Token = "0x6000579")]
	public void Terminate() { }

}

