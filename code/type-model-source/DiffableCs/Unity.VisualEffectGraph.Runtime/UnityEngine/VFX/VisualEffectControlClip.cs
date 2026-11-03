namespace UnityEngine.VFX;

[Token(Token = "0x2000011")]
internal class VisualEffectControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x2000014")]
	internal struct ClipEvent
	{
		[Token(Token = "0x4000046")]
		public static Color defaultEditorColor; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		public Color editorColor; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000048")]
		public VisualEffectPlayableSerializedEventNoColor enter; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000049")]
		public VisualEffectPlayableSerializedEventNoColor exit; //Field offset: 0x30

		[Address(RVA = "0x2F64D00", Offset = "0x2F64100", Length = "0xAF")]
		[Token(Token = "0x600002A")]
		private static ClipEvent() { }

	}

	[Token(Token = "0x2000013")]
	internal struct PrewarmClipSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		public bool enable; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000043")]
		public uint stepCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000044")]
		public float deltaTime; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000045")]
		public ExposedProperty eventName; //Field offset: 0x10

	}

	[Token(Token = "0x2000012")]
	internal enum ReinitMode : int
	{
		None = 0,
		OnExitClip = 1,
		OnEnterClip = 2,
		OnEnterOrExitClip = 3,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000035")]
	private double <clipStart>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000036")]
	private double <clipEnd>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NotKeyable]
	[Token(Token = "0x4000037")]
	public bool scrubbing; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NotKeyable]
	[Token(Token = "0x4000038")]
	public uint startSeed; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NotKeyable]
	[Token(Token = "0x4000039")]
	public ReinitMode reinit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[NotKeyable]
	[Token(Token = "0x400003A")]
	public PrewarmClipSettings prewarm; //Field offset: 0x38
	[FieldOffset(Offset = "0x50")]
	[NotKeyable]
	[Token(Token = "0x400003B")]
	public List<ClipEvent> clipEvents; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[NotKeyable]
	[Token(Token = "0x400003C")]
	public List<VisualEffectPlayableSerializedEvent> singleEvents; //Field offset: 0x58

	[Token(Token = "0x17000004")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000006")]
	public double clipEnd
	{
		[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		 get { } //Length: 6
		[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public double clipStart
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		 get { } //Length: 6
		[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2F79BB0", Offset = "0x2F78FB0", Length = "0x4AD")]
	[Token(Token = "0x6000029")]
	public VisualEffectControlClip() { }

	[Address(RVA = "0x2F79270", Offset = "0x2F78670", Length = "0x936")]
	[Token(Token = "0x6000028")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000023")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000026")]
	public double get_clipEnd() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	public double get_clipStart() { }

	[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000027")]
	public void set_clipEnd(double value) { }

	[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	public void set_clipStart(double value) { }

}

