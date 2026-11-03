namespace OutGame.PipipruVillage;

[Token(Token = "0x20000F7")]
public class PipiruVillageManager : IDisposable
{
	[Token(Token = "0x20000F8")]
	private enum _requestActionIndex : int
	{
		ResetIndex = 0,
		ScrollIndex = 1,
		AttentionIndex = 2,
		ZoomIndex = 3,
	}

	[CompilerGenerated]
	[Token(Token = "0x20000FA")]
	private struct <_updateAcquire>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003EA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003EB")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003EC")]
		public PipiruVillageManager <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003ED")]
		private float <blinkInterval>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40003EE")]
		private float <blinkEaseTime>5__3; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003EF")]
		private int <loopTime>5__4; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40003F0")]
		private float <delayTime>5__5; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003F1")]
		private bool <isPlayEffect>5__6; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40003F2")]
		private float <endTime>5__7; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003F3")]
		private Awaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21FA8D0", Offset = "0x21F9CD0", Length = "0xB9F")]
		[Token(Token = "0x6000638")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000639")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Flags]
	[Token(Token = "0x20000F9")]
	internal enum RequestActions : int
	{
		Reset = 1,
		Scroll = 2,
		Attention = 4,
		Zoom = 8,
	}

	[Token(Token = "0x40003D0")]
	private static readonly List<Int32> _stageParLevelList; //Field offset: 0x0
	[Token(Token = "0x40003D1")]
	private static readonly int _totalStage; //Field offset: 0x8
	[Token(Token = "0x40003D2")]
	public static readonly int TotalLevels; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D3")]
	private Action OnRequestExit; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003D4")]
	private Action<Int32, RequestActions, Single> OnRequestActions; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D5")]
	private Action<Int32> OnSetStageText; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D6")]
	private int _availableLevel; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003D7")]
	private int _selectLevel; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003D8")]
	private int _prevSelectLevel; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003D9")]
	private float _currentLevel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003DA")]
	private int _prevAvailableLevel; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003DB")]
	private int _playBgmChannel; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003DC")]
	private bool _isAcquire; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40003DD")]
	private bool _isPresentation; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003DE")]
	private PipiruVillageUiView _uiView; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003DF")]
	private CancellationTokenSource _acquireCancellationToken; //Field offset: 0x50

	[Token(Token = "0x14000002")]
	public event Action<Int32, RequestActions, Single> OnRequestActions
	{
		[Address(RVA = "0x21EEA80", Offset = "0x21EDE80", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600062D")]
		 add { } //Length: 172
		[Address(RVA = "0x21EECE0", Offset = "0x21EE0E0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600062E")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000001")]
	public event Action OnRequestExit
	{
		[Address(RVA = "0x21EEB30", Offset = "0x21EDF30", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600062B")]
		 add { } //Length: 158
		[Address(RVA = "0x21EED90", Offset = "0x21EE190", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600062C")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public event Action<Int32> OnSetStageText
	{
		[Address(RVA = "0x21EEBD0", Offset = "0x21EDFD0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600062F")]
		 add { } //Length: 172
		[Address(RVA = "0x21EEE30", Offset = "0x21EE230", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000630")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000172")]
	public int AvailableLevel
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000631")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000174")]
	public int CurrentLevel
	{
		[Address(RVA = "0x21EEC80", Offset = "0x21EE080", Length = "0x55")]
		[Token(Token = "0x6000633")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000176")]
	public int PlayBgmChannel
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000635")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000175")]
	public int PrevAvailableLevel
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000634")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000173")]
	public int SelectLevel
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000632")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x21EE310", Offset = "0x21ED710", Length = "0x1C4")]
	[AsyncStateMachine(typeof(<_updateAcquire>d__12))]
	[Token(Token = "0x6000629")]
	private UniTask _updateAcquire() { }

	[Address(RVA = "0x21EE4E0", Offset = "0x21ED8E0", Length = "0x30A")]
	[Token(Token = "0x600062A")]
	private void _updateCurrentLevel() { }

	[Address(RVA = "0x21EE7F0", Offset = "0x21EDBF0", Length = "0x282")]
	[Token(Token = "0x6000628")]
	private void _updateInput() { }

	[Address(RVA = "0x21EE050", Offset = "0x21ED450", Length = "0x2B1")]
	[Token(Token = "0x6000637")]
	private static PipiruVillageManager() { }

	[Address(RVA = "0x1FF1120", Offset = "0x1FF0520", Length = "0xE")]
	[Token(Token = "0x6000636")]
	public PipiruVillageManager() { }

	[Address(RVA = "0x21EEA80", Offset = "0x21EDE80", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600062D")]
	public void add_OnRequestActions(Action<Int32, RequestActions, Single> value) { }

	[Address(RVA = "0x21EEB30", Offset = "0x21EDF30", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600062B")]
	public void add_OnRequestExit(Action value) { }

	[Address(RVA = "0x21EEBD0", Offset = "0x21EDFD0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600062F")]
	public void add_OnSetStageText(Action<Int32> value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000625")]
	public override void Dispose() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000631")]
	public int get_AvailableLevel() { }

	[Address(RVA = "0x21EEC80", Offset = "0x21EE080", Length = "0x55")]
	[Token(Token = "0x6000633")]
	public int get_CurrentLevel() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000635")]
	public int get_PlayBgmChannel() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000634")]
	public int get_PrevAvailableLevel() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000632")]
	public int get_SelectLevel() { }

	[Address(RVA = "0x21EDBB0", Offset = "0x21ECFB0", Length = "0x1B0")]
	[Token(Token = "0x6000626")]
	public static int GetLevelToStageNum(long level) { }

	[Address(RVA = "0x21EDD70", Offset = "0x21ED170", Length = "0x16F")]
	[Token(Token = "0x6000627")]
	public static ValueTuple<Int32, Int32> GetStageToLevelRange(int stageNum) { }

	[Address(RVA = "0x21EDEE0", Offset = "0x21ED2E0", Length = "0xF4")]
	[Token(Token = "0x6000622")]
	public void Initialize(int availableLevel, int prevAvailableLevel, CancellationTokenSource cancellationToken, bool isFirstView) { }

	[Address(RVA = "0x21EECE0", Offset = "0x21EE0E0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600062E")]
	public void remove_OnRequestActions(Action<Int32, RequestActions, Single> value) { }

	[Address(RVA = "0x21EED90", Offset = "0x21EE190", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600062C")]
	public void remove_OnRequestExit(Action value) { }

	[Address(RVA = "0x21EEE30", Offset = "0x21EE230", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000630")]
	public void remove_OnSetStageText(Action<Int32> value) { }

	[Address(RVA = "0x21EDFE0", Offset = "0x21ED3E0", Length = "0x46")]
	[Token(Token = "0x6000623")]
	public void StartAcquire(PipiruVillageUiView uiView) { }

	[Address(RVA = "0x21EE030", Offset = "0x21ED430", Length = "0x1F")]
	[Token(Token = "0x6000624")]
	public void UpdateContent() { }

}

