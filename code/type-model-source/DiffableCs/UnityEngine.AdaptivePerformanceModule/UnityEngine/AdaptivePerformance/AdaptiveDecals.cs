namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000041")]
public class AdaptiveDecals : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011C")]
	private float m_DefaultDecalsDistance; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x60001FC")]
	public AdaptiveDecals() { }

	[Address(RVA = "0x2F87900", Offset = "0x2F86D00", Length = "0x93")]
	[Token(Token = "0x60001F8")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F879A0", Offset = "0x2F86DA0", Length = "0xA0")]
	[Token(Token = "0x60001F9")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F87A40", Offset = "0x2F86E40", Length = "0x85")]
	[Token(Token = "0x60001FA")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F87AD0", Offset = "0x2F86ED0", Length = "0xD7")]
	[Token(Token = "0x60001FB")]
	protected virtual void OnLevel() { }

}

