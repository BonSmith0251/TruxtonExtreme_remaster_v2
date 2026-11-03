namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000029")]
public struct PerformanceMetrics
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A0")]
	private int <CurrentCpuLevel>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000A1")]
	private int <CurrentGpuLevel>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A2")]
	private PerformanceBottleneck <PerformanceBottleneck>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000A3")]
	private bool <CpuPerformanceBoost>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40000A4")]
	private bool <GpuPerformanceBoost>k__BackingField; //Field offset: 0xD
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A5")]
	private ClusterInfo <ClusterInfo>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000067")]
	public ClusterInfo ClusterInfo
	{
		[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600013E")]
		 get { } //Length: 19
		[Address(RVA = "0x6620C0", Offset = "0x6614C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x600013F")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000065")]
	public bool CpuPerformanceBoost
	{
		[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600013A")]
		 get { } //Length: 5
		[Address(RVA = "0x2F87380", Offset = "0x2F86780", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600013B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000062")]
	public int CurrentCpuLevel
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000134")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000135")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000063")]
	public int CurrentGpuLevel
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000136")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000137")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000066")]
	public bool GpuPerformanceBoost
	{
		[Address(RVA = "0x2F87360", Offset = "0x2F86760", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600013C")]
		 get { } //Length: 5
		[Address(RVA = "0x2F87390", Offset = "0x2F86790", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600013D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000064")]
	public PerformanceBottleneck PerformanceBottleneck
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000138")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000139")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600013E")]
	public ClusterInfo get_ClusterInfo() { }

	[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600013A")]
	public bool get_CpuPerformanceBoost() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000134")]
	public int get_CurrentCpuLevel() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000136")]
	public int get_CurrentGpuLevel() { }

	[Address(RVA = "0x2F87360", Offset = "0x2F86760", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600013C")]
	public bool get_GpuPerformanceBoost() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000138")]
	public PerformanceBottleneck get_PerformanceBottleneck() { }

	[Address(RVA = "0x6620C0", Offset = "0x6614C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x600013F")]
	public void set_ClusterInfo(ClusterInfo value) { }

	[Address(RVA = "0x2F87380", Offset = "0x2F86780", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600013B")]
	public void set_CpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000135")]
	public void set_CurrentCpuLevel(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000137")]
	public void set_CurrentGpuLevel(int value) { }

	[Address(RVA = "0x2F87390", Offset = "0x2F86790", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600013D")]
	public void set_GpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000139")]
	public void set_PerformanceBottleneck(PerformanceBottleneck value) { }

}

