namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000044")]
public class AdaptiveLOD : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000123")]
	private float m_DefaultLodBias; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x600020D")]
	public AdaptiveLOD() { }

	[Address(RVA = "0x2F87FD0", Offset = "0x2F873D0", Length = "0x90")]
	[Token(Token = "0x6000209")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F88070", Offset = "0x2F87470", Length = "0xC")]
	[Token(Token = "0x600020A")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F88080", Offset = "0x2F87480", Length = "0x1B")]
	[Token(Token = "0x600020B")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F880A0", Offset = "0x2F874A0", Length = "0x4A")]
	[Token(Token = "0x600020C")]
	protected virtual void OnLevel() { }

}

