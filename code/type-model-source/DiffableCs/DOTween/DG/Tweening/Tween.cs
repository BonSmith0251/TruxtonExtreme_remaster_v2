namespace DG.Tweening;

[Token(Token = "0x200006D")]
public abstract class Tween : ABSSequentiable
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000113")]
	public float timeScale; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000114")]
	public bool isBackwards; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000115")]
	internal bool isInverted; //Field offset: 0x2D
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000116")]
	public object id; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000117")]
	public string stringId; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000118")]
	public int intId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000119")]
	public object target; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400011A")]
	internal UpdateType updateType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400011B")]
	internal bool isIndependentUpdate; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400011C")]
	public TweenCallback onPlay; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400011D")]
	public TweenCallback onPause; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400011E")]
	public TweenCallback onRewind; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400011F")]
	public TweenCallback onUpdate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000120")]
	public TweenCallback onStepComplete; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000121")]
	public TweenCallback onComplete; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000122")]
	public TweenCallback onKill; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000123")]
	public TweenCallback<Int32> onWaypointChange; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000124")]
	internal bool isFrom; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4000125")]
	internal bool isBlendable; //Field offset: 0x99
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4000126")]
	internal bool isRecyclable; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9B")]
	[Token(Token = "0x4000127")]
	internal bool isSpeedBased; //Field offset: 0x9B
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000128")]
	internal bool autoKill; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000129")]
	internal float duration; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400012A")]
	internal int loops; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400012B")]
	internal LoopType loopType; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400012C")]
	internal float delay; //Field offset: 0xAC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400012D")]
	private bool <isRelative>k__BackingField; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400012E")]
	internal Ease easeType; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400012F")]
	internal EaseFunction customEase; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000130")]
	public float easeOvershootOrAmplitude; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000131")]
	public float easePeriod; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000132")]
	public string debugTargetId; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000133")]
	internal Type typeofT1; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000134")]
	internal Type typeofT2; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000135")]
	internal Type typeofTPlugOptions; //Field offset: 0xE0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000136")]
	private bool <active>k__BackingField; //Field offset: 0xE8
	[FieldOffset(Offset = "0xE9")]
	[Token(Token = "0x4000137")]
	internal bool isSequenced; //Field offset: 0xE9
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000138")]
	internal Sequence sequenceParent; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000139")]
	internal int activeId; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x400013A")]
	internal SpecialStartupMode specialStartupMode; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400013B")]
	internal bool creationLocked; //Field offset: 0x100
	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x400013C")]
	internal bool startupDone; //Field offset: 0x101
	[CompilerGenerated]
	[FieldOffset(Offset = "0x102")]
	[Token(Token = "0x400013D")]
	private bool <playedOnce>k__BackingField; //Field offset: 0x102
	[CompilerGenerated]
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400013E")]
	private float <position>k__BackingField; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400013F")]
	internal float fullDuration; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000140")]
	internal int completedLoops; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000141")]
	internal bool isPlaying; //Field offset: 0x110
	[FieldOffset(Offset = "0x111")]
	[Token(Token = "0x4000142")]
	internal bool isComplete; //Field offset: 0x111
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000143")]
	internal float elapsedDelay; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000144")]
	internal bool delayComplete; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000145")]
	internal int miscInt; //Field offset: 0x11C

	[Token(Token = "0x17000005")]
	public internal bool active
	{
		[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000286")]
		 get { } //Length: 8
		[Address(RVA = "0x661760", Offset = "0x660B60", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000287")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000006")]
	public float fullPosition
	{
		[Address(RVA = "0x661670", Offset = "0x660A70", Length = "0x98")]
		[Token(Token = "0x6000288")]
		 get { } //Length: 152
		[Address(RVA = "0x661770", Offset = "0x660B70", Length = "0x22")]
		[Token(Token = "0x6000289")]
		 set { } //Length: 34
	}

	[Token(Token = "0x17000007")]
	public bool hasLoops
	{
		[Address(RVA = "0x661710", Offset = "0x660B10", Length = "0x17")]
		[Token(Token = "0x600028A")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000004")]
	public internal bool isRelative
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000284")]
		 get { } //Length: 8
		[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000285")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000008")]
	public private bool playedOnce
	{
		[Address(RVA = "0x661740", Offset = "0x660B40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600028B")]
		 get { } //Length: 8
		[Address(RVA = "0x6617B0", Offset = "0x660BB0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600028C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000009")]
	public internal float position
	{
		[Address(RVA = "0x661750", Offset = "0x660B50", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600028D")]
		 get { } //Length: 9
		[Address(RVA = "0x6617C0", Offset = "0x660BC0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600028E")]
		internal set { } //Length: 9
	}

	[Address(RVA = "0x661630", Offset = "0x660A30", Length = "0x29")]
	[Token(Token = "0x6000297")]
	protected Tween() { }

	[Token(Token = "0x6000293")]
	internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[Address(RVA = "0x660F10", Offset = "0x660310", Length = "0x3B9")]
	[Token(Token = "0x6000294")]
	internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) { }

	[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000286")]
	public bool get_active() { }

	[Address(RVA = "0x661670", Offset = "0x660A70", Length = "0x98")]
	[Token(Token = "0x6000288")]
	public float get_fullPosition() { }

	[Address(RVA = "0x661710", Offset = "0x660B10", Length = "0x17")]
	[Token(Token = "0x600028A")]
	public bool get_hasLoops() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000284")]
	public bool get_isRelative() { }

	[Address(RVA = "0x661740", Offset = "0x660B40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600028B")]
	public bool get_playedOnce() { }

	[Address(RVA = "0x661750", Offset = "0x660B50", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600028D")]
	public float get_position() { }

	[Address(RVA = "0x94FC80", Offset = "0x94F080", Length = "0x18E")]
	[Token(Token = "0x6000296")]
	internal static bool OnTweenCallback(TweenCallback<T> callback, Tween t, T param) { }

	[Address(RVA = "0x6612D0", Offset = "0x6606D0", Length = "0x1A5")]
	[Token(Token = "0x6000295")]
	internal static bool OnTweenCallback(TweenCallback callback, Tween t) { }

	[Address(RVA = "0x661480", Offset = "0x660880", Length = "0x197")]
	[Token(Token = "0x600028F")]
	internal override void Reset() { }

	[Address(RVA = "0x661760", Offset = "0x660B60", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000287")]
	internal void set_active(bool value) { }

	[Address(RVA = "0x661770", Offset = "0x660B70", Length = "0x22")]
	[Token(Token = "0x6000289")]
	public void set_fullPosition(float value) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000285")]
	internal void set_isRelative(bool value) { }

	[Address(RVA = "0x6617B0", Offset = "0x660BB0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600028C")]
	private void set_playedOnce(bool value) { }

	[Address(RVA = "0x6617C0", Offset = "0x660BC0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600028E")]
	internal void set_position(float value) { }

	[Token(Token = "0x6000292")]
	internal abstract bool Startup() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000291")]
	internal override float UpdateDelay(float elapsed) { }

	[Token(Token = "0x6000290")]
	internal abstract bool Validate() { }

}

