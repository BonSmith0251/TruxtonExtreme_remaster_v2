namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200004D")]
public class AdaptiveSorting : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012C")]
	private bool m_DefaultSorting; //Field offset: 0x40

	[Address(RVA = "0x2F9AA80", Offset = "0x2F99E80", Length = "0x7")]
	[Token(Token = "0x600023E")]
	public AdaptiveSorting() { }

	[Address(RVA = "0x2F9B0D0", Offset = "0x2F9A4D0", Length = "0x9A")]
	[Token(Token = "0x600023A")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9B170", Offset = "0x2F9A570", Length = "0x93")]
	[Token(Token = "0x600023B")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9B210", Offset = "0x2F9A610", Length = "0x86")]
	[Token(Token = "0x600023C")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9B2A0", Offset = "0x2F9A6A0", Length = "0xC5")]
	[Token(Token = "0x600023D")]
	protected virtual void OnLevel() { }

}

