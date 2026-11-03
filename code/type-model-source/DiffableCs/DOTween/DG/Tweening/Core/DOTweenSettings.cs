namespace DG.Tweening.Core;

[Token(Token = "0x20000AA")]
public class DOTweenSettings : ScriptableObject
{
	[Token(Token = "0x20000AD")]
	internal class ModulesSetup
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000201")]
		public bool showPanel; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000202")]
		public bool audioEnabled; //Field offset: 0x11
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4000203")]
		public bool physicsEnabled; //Field offset: 0x12
		[FieldOffset(Offset = "0x13")]
		[Token(Token = "0x4000204")]
		public bool physics2DEnabled; //Field offset: 0x13
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000205")]
		public bool spriteEnabled; //Field offset: 0x14
		[FieldOffset(Offset = "0x15")]
		[Token(Token = "0x4000206")]
		public bool uiEnabled; //Field offset: 0x15
		[FieldOffset(Offset = "0x16")]
		[Token(Token = "0x4000207")]
		public bool textMeshProEnabled; //Field offset: 0x16
		[FieldOffset(Offset = "0x17")]
		[Token(Token = "0x4000208")]
		public bool tk2DEnabled; //Field offset: 0x17
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000209")]
		public bool deAudioEnabled; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x400020A")]
		public bool deUnityExtendedEnabled; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x400020B")]
		public bool epoOutlineEnabled; //Field offset: 0x1A

		[Address(RVA = "0x66AC30", Offset = "0x66A030", Length = "0x12")]
		[Token(Token = "0x6000406")]
		public ModulesSetup() { }

	}

	[Token(Token = "0x20000AC")]
	internal class SafeModeOptions
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001FF")]
		public SafeModeLogBehaviour logBehaviour; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000200")]
		public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0x14

		[Address(RVA = "0x672E40", Offset = "0x672240", Length = "0xE")]
		[Token(Token = "0x6000405")]
		public SafeModeOptions() { }

	}

	[Token(Token = "0x20000AB")]
	internal enum SettingsLocation : int
	{
		AssetsDirectory = 0,
		DOTweenDirectory = 1,
		DemigiantDirectory = 2,
	}

	[Token(Token = "0x40001DF")]
	public const string AssetName = "DOTweenSettings"; //Field offset: 0x0
	[Token(Token = "0x40001E0")]
	public const string AssetFullFilename = "DOTweenSettings.asset"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E1")]
	public bool useSafeMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E2")]
	public SafeModeOptions safeModeOptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E3")]
	public float timeScale; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001E4")]
	public bool useSmoothDeltaTime; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E5")]
	public float maxSmoothUnscaledTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001E6")]
	public RewindCallbackMode rewindCallbackMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E7")]
	public bool showUnityEditorReport; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001E8")]
	public LogBehaviour logBehaviour; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E9")]
	public bool drawGizmos; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40001EA")]
	public bool defaultRecyclable; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001EB")]
	public AutoPlay defaultAutoPlay; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EC")]
	public UpdateType defaultUpdateType; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001ED")]
	public bool defaultTimeScaleIndependent; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EE")]
	public Ease defaultEaseType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001EF")]
	public float defaultEaseOvershootOrAmplitude; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F0")]
	public float defaultEasePeriod; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001F1")]
	public bool defaultAutoKill; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001F2")]
	public LoopType defaultLoopType; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001F3")]
	public bool debugMode; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x40001F4")]
	public bool debugStoreTargetId; //Field offset: 0x65
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x40001F5")]
	public bool showPreviewPanel; //Field offset: 0x66
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001F6")]
	public SettingsLocation storeSettingsLocation; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001F7")]
	public ModulesSetup modules; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001F8")]
	public bool createASMDEF; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x40001F9")]
	public bool showPlayingTweens; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x40001FA")]
	public bool showPausedTweens; //Field offset: 0x7A

	[Address(RVA = "0x668810", Offset = "0x667C10", Length = "0xE2")]
	[Token(Token = "0x6000404")]
	public DOTweenSettings() { }

}

