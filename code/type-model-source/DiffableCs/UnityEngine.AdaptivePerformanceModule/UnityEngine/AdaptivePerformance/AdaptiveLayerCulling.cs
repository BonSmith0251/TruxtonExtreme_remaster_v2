namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000043")]
public class AdaptiveLayerCulling : AdaptivePerformanceScaler
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011F")]
	private Single[] m_defaultDistances; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000120")]
	private Single[] m_scaledDistances; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000121")]
	private bool init; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000122")]
	private Camera m_cachedCamera; //Field offset: 0x58

	[Address(RVA = "0x2F884A0", Offset = "0x2F878A0", Length = "0xCF")]
	[Token(Token = "0x6000208")]
	public AdaptiveLayerCulling() { }

	[Address(RVA = "0x2F880F0", Offset = "0x2F874F0", Length = "0x11A")]
	[Token(Token = "0x6000207")]
	private void AsignDefaultValues() { }

	[Address(RVA = "0x2F88210", Offset = "0x2F87610", Length = "0x93")]
	[Token(Token = "0x6000203")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2F882B0", Offset = "0x2F876B0", Length = "0x8C")]
	[Token(Token = "0x6000204")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x2F88340", Offset = "0x2F87740", Length = "0x7")]
	[Token(Token = "0x6000205")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F88350", Offset = "0x2F87750", Length = "0x140")]
	[Token(Token = "0x6000206")]
	protected virtual void OnLevel() { }

}

