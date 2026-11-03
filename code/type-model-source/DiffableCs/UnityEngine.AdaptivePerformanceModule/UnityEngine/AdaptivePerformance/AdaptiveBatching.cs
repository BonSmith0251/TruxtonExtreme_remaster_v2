namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000040")]
public class AdaptiveBatching : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011B")]
	private bool m_DefaultState; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x60001F7")]
	public AdaptiveBatching() { }

	[Address(RVA = "0x2F875F0", Offset = "0x2F869F0", Length = "0x90")]
	[Token(Token = "0x60001F3")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F87690", Offset = "0x2F86A90", Length = "0x93")]
	[Token(Token = "0x60001F4")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F87730", Offset = "0x2F86B30", Length = "0x86")]
	[Token(Token = "0x60001F5")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F877C0", Offset = "0x2F86BC0", Length = "0xC5")]
	[Token(Token = "0x60001F6")]
	protected virtual void OnLevel() { }

}

