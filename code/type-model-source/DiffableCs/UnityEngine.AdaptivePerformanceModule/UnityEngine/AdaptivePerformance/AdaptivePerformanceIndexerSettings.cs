namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000036")]
public class AdaptivePerformanceIndexerSettings
{
	[Token(Token = "0x40000D4")]
	private const string m_FeatureName = "Indexer"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	[Tooltip("Active")]
	private bool m_Active; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	[Tooltip("Thermal Action Delay")]
	private float m_ThermalActionDelay; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	[Tooltip("Performance Action Delay")]
	private float m_PerformanceActionDelay; //Field offset: 0x18

	[Token(Token = "0x17000084")]
	public bool active
	{
		[Address(RVA = "0x2F896E0", Offset = "0x2F88AE0", Length = "0x7")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000086")]
	public float performanceActionDelay
	{
		[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000085")]
	public float thermalActionDelay
	{
		[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2F896C0", Offset = "0x2F88AC0", Length = "0x19")]
	[Token(Token = "0x6000193")]
	public AdaptivePerformanceIndexerSettings() { }

	[Address(RVA = "0x2F896E0", Offset = "0x2F88AE0", Length = "0x7")]
	[Token(Token = "0x6000190")]
	public bool get_active() { }

	[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
	[Token(Token = "0x6000192")]
	public float get_performanceActionDelay() { }

	[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
	[Token(Token = "0x6000191")]
	public float get_thermalActionDelay() { }

}

