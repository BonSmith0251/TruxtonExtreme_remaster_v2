namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000046")]
public class AdaptiveMSAA : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000125")]
	private int m_DefaultAA; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x6000217")]
	public AdaptiveMSAA() { }

	[Address(RVA = "0x2F88800", Offset = "0x2F87C00", Length = "0x90")]
	[Token(Token = "0x6000213")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F888A0", Offset = "0x2F87CA0", Length = "0x92")]
	[Token(Token = "0x6000214")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F88940", Offset = "0x2F87D40", Length = "0x85")]
	[Token(Token = "0x6000215")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F889D0", Offset = "0x2F87DD0", Length = "0xBF")]
	[Token(Token = "0x6000216")]
	protected virtual void OnLevel() { }

}

