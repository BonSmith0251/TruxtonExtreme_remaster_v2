namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000045")]
public class AdaptiveLut : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000124")]
	private float m_DefaultLutBias; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x6000212")]
	public AdaptiveLut() { }

	[Address(RVA = "0x2F88570", Offset = "0x2F87970", Length = "0x90")]
	[Token(Token = "0x600020E")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F88610", Offset = "0x2F87A10", Length = "0xA0")]
	[Token(Token = "0x600020F")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F886B0", Offset = "0x2F87AB0", Length = "0x85")]
	[Token(Token = "0x6000210")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F88740", Offset = "0x2F87B40", Length = "0xB5")]
	[Token(Token = "0x6000211")]
	protected virtual void OnLevel() { }

}

