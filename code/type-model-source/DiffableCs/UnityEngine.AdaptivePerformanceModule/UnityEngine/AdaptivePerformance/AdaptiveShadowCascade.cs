namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000049")]
public class AdaptiveShadowCascade : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000128")]
	private int m_DefaultCascadeCount; //Field offset: 0x40

	[Address(RVA = "0x2F9AA80", Offset = "0x2F99E80", Length = "0x7")]
	[Token(Token = "0x600022A")]
	public AdaptiveShadowCascade() { }

	[Address(RVA = "0x2F9A7F0", Offset = "0x2F99BF0", Length = "0x9A")]
	[Token(Token = "0x6000226")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9A890", Offset = "0x2F99C90", Length = "0x92")]
	[Token(Token = "0x6000227")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9A930", Offset = "0x2F99D30", Length = "0x85")]
	[Token(Token = "0x6000228")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9A9C0", Offset = "0x2F99DC0", Length = "0xBF")]
	[Token(Token = "0x6000229")]
	protected virtual void OnLevel() { }

}

