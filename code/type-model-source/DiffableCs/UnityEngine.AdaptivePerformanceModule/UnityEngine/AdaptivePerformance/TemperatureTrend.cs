namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000F")]
internal class TemperatureTrend
{
	[Token(Token = "0x4000051")]
	private const int MeasurementTimeframeSeconds = 20; //Field offset: 0x0
	[Token(Token = "0x4000052")]
	private const int UpdateFrequency = 10; //Field offset: 0x0
	[Token(Token = "0x4000053")]
	private const int SamplesCapacity = 200; //Field offset: 0x0
	[Token(Token = "0x4000054")]
	private const double SlopeAtMaxTrend = 0.005; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private bool m_UseProviderTrend; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private double m_SumX; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private double m_SumY; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	private double m_SumXY; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000050")]
	private double m_SumXX; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000055")]
	private Single[] m_TimeStamps; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000056")]
	private Single[] m_Temperature; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000057")]
	private int m_NumValues; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000058")]
	private int m_NextValueIndex; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000059")]
	private int m_OldestValueIndex; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400005A")]
	private float <ThermalTrend>k__BackingField; //Field offset: 0x54

	[Token(Token = "0x1700002E")]
	public private float ThermalTrend
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600009A")]
		 get { } //Length: 6
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600009B")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x2F996A0", Offset = "0x2F98AA0", Length = "0x87")]
	[Token(Token = "0x6000098")]
	public TemperatureTrend(bool useProviderTrend) { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600009A")]
	public float get_ThermalTrend() { }

	[Address(RVA = "0x2F99220", Offset = "0x2F98620", Length = "0xCC")]
	[Token(Token = "0x6000096")]
	private void PopOldestValue() { }

	[Address(RVA = "0x2F992F0", Offset = "0x2F986F0", Length = "0xCA")]
	[Token(Token = "0x6000097")]
	private void PushNewValue(float tempLevel, float timestamp) { }

	[Address(RVA = "0x2F993C0", Offset = "0x2F987C0", Length = "0x1B")]
	[Token(Token = "0x6000099")]
	public void Reset() { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600009B")]
	private void set_ThermalTrend(float value) { }

	[Address(RVA = "0x2F99550", Offset = "0x2F98950", Length = "0x14D")]
	[Token(Token = "0x600009D")]
	public void Update(float temperatureTrendFromProvider, float newTemperatureLevel, bool changed, float newTemperatureTimestamp) { }

	[Address(RVA = "0x2F993E0", Offset = "0x2F987E0", Length = "0x169")]
	[Token(Token = "0x600009C")]
	private void UpdateTrend() { }

}

