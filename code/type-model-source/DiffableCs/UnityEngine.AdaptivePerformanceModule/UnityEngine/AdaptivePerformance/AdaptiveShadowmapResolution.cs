namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200004B")]
public class AdaptiveShadowmapResolution : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012A")]
	private float m_DefaultShadowmapResolution; //Field offset: 0x40

	[Address(RVA = "0x2F9AA80", Offset = "0x2F99E80", Length = "0x7")]
	[Token(Token = "0x6000234")]
	public AdaptiveShadowmapResolution() { }

	[Address(RVA = "0x2F9AF00", Offset = "0x2F9A300", Length = "0x9A")]
	[Token(Token = "0x6000230")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F9AFA0", Offset = "0x2F9A3A0", Length = "0x58")]
	[Token(Token = "0x6000231")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F9B000", Offset = "0x2F9A400", Length = "0x4C")]
	[Token(Token = "0x6000232")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F9B050", Offset = "0x2F9A450", Length = "0x7B")]
	[Token(Token = "0x6000233")]
	protected virtual void OnLevel() { }

}

