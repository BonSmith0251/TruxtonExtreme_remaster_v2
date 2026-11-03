namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200004C")]
public class AdaptiveShadowQuality : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012B")]
	private int m_DefaultShadowQualityBias; //Field offset: 0x40

	[Address(RVA = "0x2F9AA80", Offset = "0x2F99E80", Length = "0x7")]
	[Token(Token = "0x6000239")]
	public AdaptiveShadowQuality() { }

	[Address(RVA = "0x2F9AC60", Offset = "0x2F9A060", Length = "0x9A")]
	[Token(Token = "0x6000235")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9AD00", Offset = "0x2F9A100", Length = "0x92")]
	[Token(Token = "0x6000236")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9ADA0", Offset = "0x2F9A1A0", Length = "0x85")]
	[Token(Token = "0x6000237")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9AE30", Offset = "0x2F9A230", Length = "0xCB")]
	[Token(Token = "0x6000238")]
	protected virtual void OnLevel() { }

}

