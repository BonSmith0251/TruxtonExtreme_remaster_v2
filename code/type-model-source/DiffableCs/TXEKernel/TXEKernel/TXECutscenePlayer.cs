namespace TXEKernel;

[Token(Token = "0x2000016")]
public class TXECutscenePlayer : MonoBehaviour, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000018")]
	private sealed class <LoadAsset>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000064")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000065")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000066")]
		public TXECutscenePlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000067")]
		public string cutscenePrefab; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000068")]
		public string superFighterPrefabPath; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000069")]
		public MaterialType materialType; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400006A")]
		public Action onLoaded; //Field offset: 0x40

		[Token(Token = "0x17000010")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000058")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000011")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600005A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000055")]
		public <LoadAsset>d__2(int <>1__state) { }

		[Address(RVA = "0x26E7650", Offset = "0x26E6A50", Length = "0x1D1")]
		[Token(Token = "0x6000057")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000058")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600005A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E7830", Offset = "0x26E6C30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000059")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000056")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private struct <LoadAssetAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006C")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006D")]
		public string cutscenePrefabPath; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400006E")]
		public TXECutscenePlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400006F")]
		public string superFighterPrefabPath; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000070")]
		public MaterialType materialType; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000071")]
		public Action onLoaded; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000072")]
		private AsyncInstantiateOperation<GameObject> <operation>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000073")]
		private Awaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000074")]
		private Awaiter<GameObject> <>u__2; //Field offset: 0x58

		[Address(RVA = "0x26E6D40", Offset = "0x26E6140", Length = "0x8FF")]
		[Token(Token = "0x600005B")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600005C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000017")]
	internal enum Status : int
	{
		None = 0,
		Initialized = 1,
		Loaded = 2,
		Playing = 3,
		Stop = 4,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000059")]
	private Status _state; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005A")]
	private RenderTexture _renderTexture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005B")]
	private GameObject _cutscenePrefab; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400005C")]
	private GameObject _superFighterPrefab; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400005D")]
	private InGamePlayableDirector _playableDirectorObject; //Field offset: 0x40

	[Token(Token = "0x1700000F")]
	public Status State
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000053")]
	public TXECutscenePlayer() { }

	[Address(RVA = "0x253C490", Offset = "0x253B890", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	private void <LoadAssetAsync>b__3_0() { }

	[Address(RVA = "0x26E0860", Offset = "0x26DFC60", Length = "0x1AE")]
	[Token(Token = "0x600004E")]
	public override void Dispose() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000052")]
	public Status get_State() { }

	[Address(RVA = "0x26E0A10", Offset = "0x26DFE10", Length = "0x23")]
	[Token(Token = "0x600004B")]
	public void Initialize(RenderTexture renderTexture) { }

	[Address(RVA = "0x26E0B80", Offset = "0x26DFF80", Length = "0xC6")]
	[IteratorStateMachine(typeof(<LoadAsset>d__2))]
	[Token(Token = "0x600004C")]
	public IEnumerator LoadAsset(string cutscenePrefab, string superFighterPrefabPath, MaterialType materialType, Action onLoaded = null) { }

	[Address(RVA = "0x26E0A40", Offset = "0x26DFE40", Length = "0x13A")]
	[AsyncStateMachine(typeof(<LoadAssetAsync>d__3))]
	[Token(Token = "0x600004D")]
	public UniTask LoadAssetAsync(string cutscenePrefabPath, string superFighterPrefabPath, MaterialType materialType, Action onLoaded = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000050")]
	public void Pause() { }

	[Address(RVA = "0x26E0C50", Offset = "0x26E0050", Length = "0x6B")]
	[Token(Token = "0x600004F")]
	public bool Play(bool isLoop = false) { }

	[Address(RVA = "0x26E0CC0", Offset = "0x26E00C0", Length = "0x2D")]
	[Token(Token = "0x6000051")]
	public void Stop() { }

}

