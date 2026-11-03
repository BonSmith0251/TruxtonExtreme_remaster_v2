namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000042")]
public class AdaptiveFramerate : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011D")]
	private int m_DefaultFPS; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400011E")]
	private int m_FirstTimeStart; //Field offset: 0x44

	[Address(RVA = "0x2F87F50", Offset = "0x2F87350", Length = "0x74")]
	[Token(Token = "0x6000202")]
	public AdaptiveFramerate() { }

	[Address(RVA = "0x2F87BB0", Offset = "0x2F86FB0", Length = "0x97")]
	[Token(Token = "0x60001FD")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F87C50", Offset = "0x2F87050", Length = "0x5A")]
	[Token(Token = "0x60001FE")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F87CB0", Offset = "0x2F870B0", Length = "0x76")]
	[Token(Token = "0x60001FF")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F87D30", Offset = "0x2F87130", Length = "0xC6")]
	[Token(Token = "0x6000201")]
	protected virtual void OnLevelDecrease() { }

	[Address(RVA = "0x2F87E00", Offset = "0x2F87200", Length = "0x144")]
	[Token(Token = "0x6000200")]
	protected virtual void OnLevelIncrease() { }

}

