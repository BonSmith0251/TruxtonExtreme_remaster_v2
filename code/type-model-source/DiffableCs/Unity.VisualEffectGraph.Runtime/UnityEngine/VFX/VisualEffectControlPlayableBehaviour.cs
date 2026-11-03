namespace UnityEngine.VFX;

[Token(Token = "0x200002D")]
internal class VisualEffectControlPlayableBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	private double <clipStart>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000086")]
	private double <clipEnd>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000087")]
	private bool <scrubbing>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000088")]
	private bool <reinitEnter>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000089")]
	private bool <reinitExit>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400008A")]
	private uint <startSeed>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008B")]
	private VisualEffectPlayableSerializedEvent[] <events>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008C")]
	private uint <clipEventsCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400008D")]
	private uint <prewarmStepCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008E")]
	private float <prewarmDeltaTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400008F")]
	private ExposedProperty <prewarmEvent>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x1700000C")]
	public double clipEnd
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600006D")]
		 get { } //Length: 6
		[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600006E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	public uint clipEventsCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000079")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public double clipStart
	{
		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600006B")]
		 get { } //Length: 6
		[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600006C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000011")]
	public VisualEffectPlayableSerializedEvent[] events
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000077")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000078")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000014")]
	public float prewarmDeltaTime
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600007D")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600007E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000015")]
	public ExposedProperty prewarmEvent
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600007F")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000080")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000013")]
	public uint prewarmStepCount
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007B")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public bool reinitEnter
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000071")]
		 get { } //Length: 5
		[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000072")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public bool reinitExit
	{
		[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000073")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000074")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public bool scrubbing
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600006F")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000070")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public uint startSeed
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000075")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000076")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000081")]
	public VisualEffectControlPlayableBehaviour() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600006D")]
	public double get_clipEnd() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000079")]
	public uint get_clipEventsCount() { }

	[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600006B")]
	public double get_clipStart() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000077")]
	public VisualEffectPlayableSerializedEvent[] get_events() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600007D")]
	public float get_prewarmDeltaTime() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600007F")]
	public ExposedProperty get_prewarmEvent() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007B")]
	public uint get_prewarmStepCount() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000071")]
	public bool get_reinitEnter() { }

	[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000073")]
	public bool get_reinitExit() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600006F")]
	public bool get_scrubbing() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000075")]
	public uint get_startSeed() { }

	[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600006E")]
	public void set_clipEnd(double value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007A")]
	public void set_clipEventsCount(uint value) { }

	[Address(RVA = "0x28F8980", Offset = "0x28F7D80", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600006C")]
	public void set_clipStart(double value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000078")]
	public void set_events(VisualEffectPlayableSerializedEvent[] value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600007E")]
	public void set_prewarmDeltaTime(float value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000080")]
	public void set_prewarmEvent(ExposedProperty value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	public void set_prewarmStepCount(uint value) { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000072")]
	public void set_reinitEnter(bool value) { }

	[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000074")]
	public void set_reinitExit(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000070")]
	public void set_scrubbing(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000076")]
	public void set_startSeed(uint value) { }

}

