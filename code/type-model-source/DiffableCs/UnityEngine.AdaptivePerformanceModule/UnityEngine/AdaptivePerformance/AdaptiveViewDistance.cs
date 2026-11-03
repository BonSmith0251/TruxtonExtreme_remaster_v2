namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200004F")]
public class AdaptiveViewDistance : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012D")]
	private float m_DefaultFarClipPlane; //Field offset: 0x40

	[Address(RVA = "0x2F9B820", Offset = "0x2F9AC20", Length = "0xE")]
	[Token(Token = "0x6000248")]
	public AdaptiveViewDistance() { }

	[Address(RVA = "0x2F9B570", Offset = "0x2F9A970", Length = "0x9A")]
	[Token(Token = "0x6000244")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9B610", Offset = "0x2F9AA10", Length = "0x92")]
	[Token(Token = "0x6000245")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9B6B0", Offset = "0x2F9AAB0", Length = "0x81")]
	[Token(Token = "0x6000246")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9B740", Offset = "0x2F9AB40", Length = "0xD3")]
	[Token(Token = "0x6000247")]
	protected virtual void OnLevel() { }

}

