namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000C")]
internal class DevicePerformanceControlImpl : IDevicePerformanceControl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003F")]
	private IDevicePerformanceLevelControl m_PerformanceLevelControl; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000040")]
	private PerformanceControlMode <PerformanceControlMode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000041")]
	private int <CpuLevel>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000042")]
	private int <GpuLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000043")]
	private int <CurrentCpuLevel>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000044")]
	private int <CurrentGpuLevel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000045")]
	private bool <CpuPerformanceBoost>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000046")]
	private bool <GpuPerformanceBoost>k__BackingField; //Field offset: 0x2D

	[Token(Token = "0x17000027")]
	public override int CpuLevel
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007F")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000080")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public override bool CpuPerformanceBoost
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000087")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000088")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000029")]
	public int CurrentCpuLevel
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000083")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000084")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public int CurrentGpuLevel
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000085")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000086")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000028")]
	public override int GpuLevel
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000081")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000082")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	public override bool GpuPerformanceBoost
	{
		[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000089")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600008A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000025")]
	public override int MaxCpuPerformanceLevel
	{
		[Address(RVA = "0x2F977C0", Offset = "0x2F96BC0", Length = "0x4F")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000026")]
	public override int MaxGpuPerformanceLevel
	{
		[Address(RVA = "0x2F97810", Offset = "0x2F96C10", Length = "0x52")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000024")]
	public override PerformanceControlMode PerformanceControlMode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007B")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F97770", Offset = "0x2F96B70", Length = "0x49")]
	[Token(Token = "0x6000078")]
	public DevicePerformanceControlImpl(IDevicePerformanceLevelControl performanceLevelControl) { }

	[Address(RVA = "0x2F97330", Offset = "0x2F96730", Length = "0x2D")]
	[Token(Token = "0x600007A")]
	private int ComputeDelta(int oldLevel, int newLevel) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007F")]
	public override int get_CpuLevel() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000087")]
	public override bool get_CpuPerformanceBoost() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000083")]
	public int get_CurrentCpuLevel() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000085")]
	public int get_CurrentGpuLevel() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000081")]
	public override int get_GpuLevel() { }

	[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000089")]
	public override bool get_GpuPerformanceBoost() { }

	[Address(RVA = "0x2F977C0", Offset = "0x2F96BC0", Length = "0x4F")]
	[Token(Token = "0x600007D")]
	public override int get_MaxCpuPerformanceLevel() { }

	[Address(RVA = "0x2F97810", Offset = "0x2F96C10", Length = "0x52")]
	[Token(Token = "0x600007E")]
	public override int get_MaxGpuPerformanceLevel() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007B")]
	public override PerformanceControlMode get_PerformanceControlMode() { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000080")]
	public override void set_CpuLevel(int value) { }

	[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000088")]
	public override void set_CpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000084")]
	public void set_CurrentCpuLevel(int value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000086")]
	public void set_CurrentGpuLevel(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000082")]
	public override void set_GpuLevel(int value) { }

	[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600008A")]
	public override void set_GpuPerformanceBoost(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	public void set_PerformanceControlMode(PerformanceControlMode value) { }

	[Address(RVA = "0x2F97360", Offset = "0x2F96760", Length = "0x406")]
	[Token(Token = "0x6000079")]
	public bool Update(out PerformanceLevelChangeEventArgs changeArgs) { }

}

