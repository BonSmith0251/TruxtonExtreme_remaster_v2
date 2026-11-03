namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000D9")]
public class UniversalLightData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E9")]
	public int mainLightIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004EA")]
	public int additionalLightsCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004EB")]
	public int maxPerObjectAdditionalLightsCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004EC")]
	public NativeArray<VisibleLight> visibleLights; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004ED")]
	public bool shadeAdditionalLightsPerVertex; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40004EE")]
	public bool supportsMixedLighting; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x40004EF")]
	public bool reflectionProbeBoxProjection; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x40004F0")]
	public bool reflectionProbeBlending; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004F1")]
	public bool reflectionProbeAtlas; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40004F2")]
	public bool supportsLightLayers; //Field offset: 0x35
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x40004F3")]
	public bool supportsAdditionalLights; //Field offset: 0x36

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005BC")]
	public UniversalLightData() { }

	[Address(RVA = "0x2D94F70", Offset = "0x2D94370", Length = "0x1C")]
	[Token(Token = "0x60005BB")]
	public virtual void Reset() { }

}

