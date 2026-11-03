namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000024")]
public struct PerformanceBoostChangeEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000098")]
	private bool <CpuBoost>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000099")]
	private bool <GpuBoost>k__BackingField; //Field offset: 0x1

	[Token(Token = "0x17000058")]
	public bool CpuBoost
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600011C")]
		 get { } //Length: 4
		[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600011D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000059")]
	public bool GpuBoost
	{
		[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600011E")]
		 get { } //Length: 5
		[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600011C")]
	public bool get_CpuBoost() { }

	[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600011E")]
	public bool get_GpuBoost() { }

	[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x600011D")]
	public void set_CpuBoost(bool value) { }

	[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011F")]
	public void set_GpuBoost(bool value) { }

}

