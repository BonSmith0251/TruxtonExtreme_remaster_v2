namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000FC")]
public class TLEntryClip : PlayableAsset, ITimelineClipAsset
{
	[Flags]
	[Token(Token = "0x20000FD")]
	internal enum TLClipFlag : int
	{
		None = 0,
		FreshS = 1,
		Parallel = 2,
		ZoneA = 1024,
		ZoneB = 2048,
		ZoneC = 4096,
		ZoneD = 8192,
		ZoneE = 16384,
		ZoneF = 32768,
		ZoneG = 65536,
		ZoneH = 131072,
		ZoneI = 262144,
		ZoneJ = 524288,
		ZoneK = 1048576,
		ZoneL = 2097152,
		Cached = -2147483648,
	}

	[Flags]
	[Token(Token = "0x20000FE")]
	internal enum TLCondition : int
	{
		None = 0,
		NoBomber = 1,
		NoDead = 2,
		Extinction = 4,
		Pipil50 = 8,
	}

	[Flags]
	[Token(Token = "0x20000FF")]
	internal enum TLGameModeFlag : int
	{
		None = 0,
		Tutorial = 1,
		StoryA = 2,
		StoryB = 4,
		StoryC = 8,
		Arcade1 = 32,
		Arcade2 = 64,
		Team = 128,
		Rush = 256,
		Story = 14,
		Arcade = 96,
	}

	[Flags]
	[Token(Token = "0x2000100")]
	internal enum TLWeaponFlag : int
	{
		None = 0,
		normalShot = 1,
		tatsujinBeam = 2,
		thunderLaser = 4,
		goldLaser = 8,
		homingShot = 16,
		growShot = 32,
		blackLaser = 64,
		awakeLv1 = 1048576,
		awakeLv2 = 2097152,
	}

	[Token(Token = "0x40006EE")]
	public static readonly TLClipFlag AllZone; //Field offset: 0x0
	[Token(Token = "0x40006EF")]
	public static readonly TLClipFlag DefaultZone; //Field offset: 0x4
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E9")]
	private double _startTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EA")]
	private double _durationTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40006EB")]
	private GameObject _timelinePrefab; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40006EC")]
	private Vector3 _objectOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006ED")]
	private TLEntryObject _tlobj; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40006F0")]
	private TLClipFlag _clipFlag; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40006F1")]
	private TLCondition _conditionFlag; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40006F2")]
	private TLClipFlag _failedFlag; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40006F3")]
	private TLClipFlag _successedFlag; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40006F4")]
	private TLGameModeFlag _gameModeFlag; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40006F5")]
	private TLWeaponFlag _weaponFlag; //Field offset: 0x5C

	[Token(Token = "0x1700016B")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60007EE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700016F")]
	public TLClipFlag ClipFlag
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60007F7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000171")]
	public TLCondition ConditionFlag
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60007F9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700016D")]
	public double DurationTime
	{
		[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
		[Token(Token = "0x60007F0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000172")]
	public TLClipFlag FailedFlag
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60007FA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000174")]
	public TLGameModeFlag GameModeFlag
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60007FC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000170")]
	public bool IsCached
	{
		[Address(RVA = "0x1D530D0", Offset = "0x1D524D0", Length = "0x7")]
		[Token(Token = "0x60007F8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700016C")]
	public double StartTime
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x60007EF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000173")]
	public TLClipFlag SuccessedFlag
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60007FB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700016E")]
	public GameObject TimelinePrefab
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60007F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000175")]
	public TLWeaponFlag WeaponFlag
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60007FD")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1D53020", Offset = "0x1D52420", Length = "0x4E")]
	[Token(Token = "0x60007FF")]
	private static TLEntryClip() { }

	[Address(RVA = "0x1D53070", Offset = "0x1D52470", Length = "0x51")]
	[Token(Token = "0x60007FE")]
	public TLEntryClip() { }

	[Address(RVA = "0x1D52980", Offset = "0x1D51D80", Length = "0x45B")]
	[Token(Token = "0x60007F1")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007EE")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60007F7")]
	public TLClipFlag get_ClipFlag() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60007F9")]
	public TLCondition get_ConditionFlag() { }

	[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
	[Token(Token = "0x60007F0")]
	public double get_DurationTime() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60007FA")]
	public TLClipFlag get_FailedFlag() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60007FC")]
	public TLGameModeFlag get_GameModeFlag() { }

	[Address(RVA = "0x1D530D0", Offset = "0x1D524D0", Length = "0x7")]
	[Token(Token = "0x60007F8")]
	public bool get_IsCached() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[Token(Token = "0x60007EF")]
	public double get_StartTime() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60007FB")]
	public TLClipFlag get_SuccessedFlag() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007F6")]
	public GameObject get_TimelinePrefab() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60007FD")]
	public TLWeaponFlag get_WeaponFlag() { }

	[Address(RVA = "0x1D52DE0", Offset = "0x1D521E0", Length = "0x1A3")]
	[Token(Token = "0x60007F3")]
	public static TLGameModeFlag GetCurrentMode() { }

	[Address(RVA = "0x1D52F90", Offset = "0x1D52390", Length = "0x4C")]
	[Token(Token = "0x60007F4")]
	private static TLGameModeFlag GetCurrentMode(PlayMode pmode) { }

	[Address(RVA = "0x1D52FE0", Offset = "0x1D523E0", Length = "0x23")]
	[Token(Token = "0x60007F5")]
	private static TLGameModeFlag GetCurrentMode(PlayActor pmode) { }

	[Address(RVA = "0x1D53010", Offset = "0x1D52410", Length = "0xB")]
	[Token(Token = "0x60007F2")]
	public void SetDuration(double ts, double tc) { }

}

