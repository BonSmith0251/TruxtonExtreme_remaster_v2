namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200002F")]
public struct ThermalMetrics
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	private WarningLevel <WarningLevel>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BC")]
	private float <TemperatureLevel>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BD")]
	private float <TemperatureTrend>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000072")]
	public float TemperatureLevel
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000153")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000154")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000073")]
	public float TemperatureTrend
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000155")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000156")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000071")]
	public WarningLevel WarningLevel
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000151")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000152")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000153")]
	public float get_TemperatureLevel() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000155")]
	public float get_TemperatureTrend() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000151")]
	public WarningLevel get_WarningLevel() { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000154")]
	public void set_TemperatureLevel(float value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000156")]
	public void set_TemperatureTrend(float value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000152")]
	public void set_WarningLevel(WarningLevel value) { }

}

