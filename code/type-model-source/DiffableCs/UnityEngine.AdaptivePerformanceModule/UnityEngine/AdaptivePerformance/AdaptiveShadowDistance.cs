namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200004A")]
public class AdaptiveShadowDistance : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000129")]
	private float m_DefaultShadowDistance; //Field offset: 0x40

	[Address(RVA = "0x2F9AA80", Offset = "0x2F99E80", Length = "0x7")]
	[Token(Token = "0x600022F")]
	public AdaptiveShadowDistance() { }

	[Address(RVA = "0x2F9AA90", Offset = "0x2F99E90", Length = "0x9A")]
	[Token(Token = "0x600022B")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9AB30", Offset = "0x2F99F30", Length = "0x58")]
	[Token(Token = "0x600022C")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9AB90", Offset = "0x2F99F90", Length = "0x4C")]
	[Token(Token = "0x600022D")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9ABE0", Offset = "0x2F99FE0", Length = "0x7B")]
	[Token(Token = "0x600022E")]
	protected virtual void OnLevel() { }

}

