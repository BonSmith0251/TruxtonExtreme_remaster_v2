namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000047")]
public class AdaptivePhysics : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000126")]
	private float m_fixedDeltaTimeDefault; //Field offset: 0x40

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x600021C")]
	public AdaptivePhysics() { }

	[Address(RVA = "0x2F95160", Offset = "0x2F94560", Length = "0x90")]
	[Token(Token = "0x6000218")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F95200", Offset = "0x2F94600", Length = "0xC")]
	[Token(Token = "0x6000219")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F95210", Offset = "0x2F94610", Length = "0x1B")]
	[Token(Token = "0x600021A")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F95230", Offset = "0x2F94630", Length = "0x4D")]
	[Token(Token = "0x600021B")]
	protected virtual void OnLevel() { }

}

