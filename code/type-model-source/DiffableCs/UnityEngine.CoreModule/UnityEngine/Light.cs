namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000F9")]
public sealed class Light : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A8")]
	private LightShape <shape>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002A9")]
	private int m_BakedIndex; //Field offset: 0x1C

	[Token(Token = "0x170001C0")]
	public Vector2 areaSize
	{
		[Address(RVA = "0x2FF9E00", Offset = "0x2FF9200", Length = "0x87")]
		[Token(Token = "0x6000A76")]
		 get { } //Length: 135
		[Address(RVA = "0x2FFBCA0", Offset = "0x2FFB0A0", Length = "0x80")]
		[Token(Token = "0x6000A77")]
		 set { } //Length: 128
	}

	[Obsolete("light.attenuate was removed; all lights always attenuate now", True)]
	[Token(Token = "0x170001C5")]
	public bool attenuate
	{
		[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
		[Token(Token = "0x6000A8E")]
		 get { } //Length: 5
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A8F")]
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("warning bakedIndex has been removed please use bakingOutput.isBaked instead.", True)]
	[Token(Token = "0x170001BF")]
	public int bakedIndex
	{
		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x6000A74")]
		 get { } //Length: 6
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000A75")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001B0")]
	public LightBakingOutput bakingOutput
	{
		[Address(RVA = "0x2FF9EE0", Offset = "0x2FF92E0", Length = "0x93")]
		[Token(Token = "0x6000A54")]
		 get { } //Length: 147
		[Address(RVA = "0x2FFBD80", Offset = "0x2FFB180", Length = "0x85")]
		[Token(Token = "0x6000A55")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700019F")]
	public float bounceIntensity
	{
		[Address(RVA = "0x2FF9FC0", Offset = "0x2FF93C0", Length = "0x76")]
		[Token(Token = "0x6000A33")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFBE60", Offset = "0x2FFB260", Length = "0x86")]
		[Token(Token = "0x6000A34")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001A4")]
	public Vector4 boundingSphereOverride
	{
		[Address(RVA = "0x2FFA090", Offset = "0x2FF9490", Length = "0x8E")]
		[Token(Token = "0x6000A3D")]
		 get { } //Length: 142
		[Address(RVA = "0x2FFBF40", Offset = "0x2FFB340", Length = "0x85")]
		[Token(Token = "0x6000A3E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700019B")]
	public Color color
	{
		[Address(RVA = "0x2FFA230", Offset = "0x2FF9630", Length = "0x8E")]
		[Token(Token = "0x6000A2B")]
		 get { } //Length: 142
		[Address(RVA = "0x2FFC100", Offset = "0x2FFB500", Length = "0x85")]
		[Token(Token = "0x6000A2C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700019C")]
	public float colorTemperature
	{
		[Address(RVA = "0x2FFA160", Offset = "0x2FF9560", Length = "0x76")]
		[Token(Token = "0x6000A2D")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC020", Offset = "0x2FFB420", Length = "0x86")]
		[Token(Token = "0x6000A2E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001C1")]
	public int commandBufferCount
	{
		[Address(RVA = "0x2FFA300", Offset = "0x2FF9700", Length = "0x76")]
		[Token(Token = "0x6000A86")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001BD")]
	public Texture cookie
	{
		[Address(RVA = "0x2FFA530", Offset = "0x2FF9930", Length = "0x90")]
		[Token(Token = "0x6000A70")]
		 get { } //Length: 144
		[Address(RVA = "0x2FFC350", Offset = "0x2FFB750", Length = "0xBA")]
		[Token(Token = "0x6000A71")]
		 set { } //Length: 186
	}

	[Obsolete("Light.cookieSize has been deprecated. Use Light.cookieSize2D instead.", False)]
	[Token(Token = "0x170001BB")]
	public float cookieSize
	{
		[Address(RVA = "0x2FFA460", Offset = "0x2FF9860", Length = "0x88")]
		[Token(Token = "0x6000A6C")]
		 get { } //Length: 136
		[Address(RVA = "0x2FFC270", Offset = "0x2FFB670", Length = "0x87")]
		[Token(Token = "0x6000A6D")]
		 set { } //Length: 135
	}

	[Token(Token = "0x170001BC")]
	public Vector2 cookieSize2D
	{
		[Address(RVA = "0x2FFA3D0", Offset = "0x2FF97D0", Length = "0x87")]
		[Token(Token = "0x6000A6E")]
		 get { } //Length: 135
		[Address(RVA = "0x2FFC1E0", Offset = "0x2FFB5E0", Length = "0x80")]
		[Token(Token = "0x6000A6F")]
		 set { } //Length: 128
	}

	[Token(Token = "0x170001B1")]
	public int cullingMask
	{
		[Address(RVA = "0x2FFA610", Offset = "0x2FF9A10", Length = "0x76")]
		[Token(Token = "0x6000A56")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC450", Offset = "0x2FFB850", Length = "0x83")]
		[Token(Token = "0x6000A57")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001AE")]
	public float dilatedRange
	{
		[Address(RVA = "0x2FFA6D0", Offset = "0x2FF9AD0", Length = "0x76")]
		[Token(Token = "0x6000A51")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170001A2")]
	public bool enableSpotReflector
	{
		[Address(RVA = "0x2FFA790", Offset = "0x2FF9B90", Length = "0x76")]
		[Token(Token = "0x6000A39")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC530", Offset = "0x2FFB930", Length = "0x86")]
		[Token(Token = "0x6000A3A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001AF")]
	public Flare flare
	{
		[Address(RVA = "0x2FFA850", Offset = "0x2FF9C50", Length = "0x90")]
		[Token(Token = "0x6000A52")]
		 get { } //Length: 144
		[Address(RVA = "0x2FFC610", Offset = "0x2FFBA10", Length = "0xBA")]
		[Token(Token = "0x6000A53")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170001A6")]
	public bool forceVisible
	{
		[Address(RVA = "0x2FFA930", Offset = "0x2FF9D30", Length = "0x76")]
		[Token(Token = "0x6000A41")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC720", Offset = "0x2FFBB20", Length = "0x86")]
		[Token(Token = "0x6000A42")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700019A")]
	public float innerSpotAngle
	{
		[Address(RVA = "0x2FFA9F0", Offset = "0x2FF9DF0", Length = "0x76")]
		[Token(Token = "0x6000A29")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC800", Offset = "0x2FFBC00", Length = "0x86")]
		[Token(Token = "0x6000A2A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700019E")]
	public float intensity
	{
		[Address(RVA = "0x2FFAAB0", Offset = "0x2FF9EB0", Length = "0x76")]
		[Token(Token = "0x6000A31")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFC8E0", Offset = "0x2FFBCE0", Length = "0x86")]
		[Token(Token = "0x6000A32")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001BA")]
	public Single[] layerShadowCullDistances
	{
		[Address(RVA = "0x2FFAB80", Offset = "0x2FF9F80", Length = "0x12A")]
		[FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = False)]
		[Token(Token = "0x6000A6A")]
		 get { } //Length: 298
		[Address(RVA = "0x2FFC9C0", Offset = "0x2FFBDC0", Length = "0x104")]
		[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x6000A6B")]
		 set { } //Length: 260
	}

	[Token(Token = "0x170001B3")]
	public LightShadowCasterMode lightShadowCasterMode
	{
		[Address(RVA = "0x2FFACF0", Offset = "0x2FFA0F0", Length = "0x76")]
		[Token(Token = "0x6000A5A")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCB10", Offset = "0x2FFBF10", Length = "0x83")]
		[Token(Token = "0x6000A5B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001A0")]
	public LightUnit lightUnit
	{
		[Address(RVA = "0x2FFADB0", Offset = "0x2FFA1B0", Length = "0x76")]
		[Token(Token = "0x6000A35")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCBE0", Offset = "0x2FFBFE0", Length = "0x83")]
		[Token(Token = "0x6000A36")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001A1")]
	public float luxAtDistance
	{
		[Address(RVA = "0x2FFAE70", Offset = "0x2FFA270", Length = "0x76")]
		[Token(Token = "0x6000A37")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCCC0", Offset = "0x2FFC0C0", Length = "0x86")]
		[Token(Token = "0x6000A38")]
		 set { } //Length: 134
	}

	[Obsolete("Use QualitySettings.pixelLightCount instead.")]
	[Token(Token = "0x170001C2")]
	public static int pixelLightCount
	{
		[Address(RVA = "0x2FFAEF0", Offset = "0x2FFA2F0", Length = "0x2A")]
		[Token(Token = "0x6000A87")]
		 get { } //Length: 42
		[Address(RVA = "0x2FFCD50", Offset = "0x2FFC150", Length = "0x31")]
		[Token(Token = "0x6000A88")]
		 set { } //Length: 49
	}

	[Token(Token = "0x170001AD")]
	public float range
	{
		[Address(RVA = "0x2FFAF60", Offset = "0x2FFA360", Length = "0x76")]
		[Token(Token = "0x6000A4F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCDE0", Offset = "0x2FFC1E0", Length = "0x86")]
		[Token(Token = "0x6000A50")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001B2")]
	public int renderingLayerMask
	{
		[Address(RVA = "0x2FFB0E0", Offset = "0x2FFA4E0", Length = "0x76")]
		[Token(Token = "0x6000A58")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCF80", Offset = "0x2FFC380", Length = "0x83")]
		[Token(Token = "0x6000A59")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001BE")]
	public LightRenderMode renderMode
	{
		[Address(RVA = "0x2FFB020", Offset = "0x2FFA420", Length = "0x76")]
		[Token(Token = "0x6000A72")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFCEB0", Offset = "0x2FFC2B0", Length = "0x83")]
		[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x6000A73")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001A8")]
	public float shadowBias
	{
		[Address(RVA = "0x2FFB1A0", Offset = "0x2FFA5A0", Length = "0x76")]
		[Token(Token = "0x6000A45")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD060", Offset = "0x2FFC460", Length = "0x86")]
		[Token(Token = "0x6000A46")]
		 set { } //Length: 134
	}

	[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", True)]
	[Token(Token = "0x170001C3")]
	public float shadowConstantBias
	{
		[Address(RVA = "0x2FFB220", Offset = "0x2FFA620", Length = "0x6")]
		[Token(Token = "0x6000A8A")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A8B")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170001A7")]
	public int shadowCustomResolution
	{
		[Address(RVA = "0x2FFB270", Offset = "0x2FFA670", Length = "0x76")]
		[Token(Token = "0x6000A43")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD130", Offset = "0x2FFC530", Length = "0x83")]
		[Token(Token = "0x6000A44")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001AC")]
	public Matrix4x4 shadowMatrixOverride
	{
		[Address(RVA = "0x2FFB340", Offset = "0x2FFA740", Length = "0x9A")]
		[Token(Token = "0x6000A4D")]
		 get { } //Length: 154
		[Address(RVA = "0x2FFD210", Offset = "0x2FFC610", Length = "0x85")]
		[Token(Token = "0x6000A4E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170001AA")]
	public float shadowNearPlane
	{
		[Address(RVA = "0x2FFB420", Offset = "0x2FFA820", Length = "0x76")]
		[Token(Token = "0x6000A49")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD2F0", Offset = "0x2FFC6F0", Length = "0x86")]
		[Token(Token = "0x6000A4A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001A9")]
	public float shadowNormalBias
	{
		[Address(RVA = "0x2FFB4E0", Offset = "0x2FFA8E0", Length = "0x76")]
		[Token(Token = "0x6000A47")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD3D0", Offset = "0x2FFC7D0", Length = "0x86")]
		[Token(Token = "0x6000A48")]
		 set { } //Length: 134
	}

	[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", True)]
	[Token(Token = "0x170001C4")]
	public float shadowObjectSizeBias
	{
		[Address(RVA = "0x2FFB220", Offset = "0x2FFA620", Length = "0x6")]
		[Token(Token = "0x6000A8C")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A8D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170001B6")]
	public LightShadowResolution shadowResolution
	{
		[Address(RVA = "0x2FF9D30", Offset = "0x2FF9130", Length = "0x76")]
		[Token(Token = "0x6000A61")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD460", Offset = "0x2FFC860", Length = "0xDE")]
		[Token(Token = "0x6000A62")]
		 set { } //Length: 222
	}

	[Token(Token = "0x170001B7")]
	private LightShadowResolution ShadowResolution
	{
		[Address(RVA = "0x2FF9D30", Offset = "0x2FF9130", Length = "0x76")]
		[Token(Token = "0x6000A64")]
		private get { } //Length: 118
		[Address(RVA = "0x2FFBBC0", Offset = "0x2FFAFC0", Length = "0x83")]
		[FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x6000A65")]
		private set { } //Length: 131
	}

	[Token(Token = "0x170001B4")]
	public LightShadows shadows
	{
		[Address(RVA = "0x2FFB680", Offset = "0x2FFAA80", Length = "0x76")]
		[NativeMethod("GetShadowType")]
		[Token(Token = "0x6000A5D")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD660", Offset = "0x2FFCA60", Length = "0x83")]
		[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x6000A5E")]
		 set { } //Length: 131
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Shadow softness is removed in Unity 5.0+", True)]
	[Token(Token = "0x170001B8")]
	public float shadowSoftness
	{
		[Address(RVA = "0x2FFB570", Offset = "0x2FFA970", Length = "0xB")]
		[Token(Token = "0x6000A66")]
		 get { } //Length: 11
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A67")]
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Shadow softness is removed in Unity 5.0+", True)]
	[Token(Token = "0x170001B9")]
	public float shadowSoftnessFade
	{
		[Address(RVA = "0x2FFB560", Offset = "0x2FFA960", Length = "0xB")]
		[Token(Token = "0x6000A68")]
		 get { } //Length: 11
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000A69")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170001B5")]
	public float shadowStrength
	{
		[Address(RVA = "0x2FFB5C0", Offset = "0x2FFA9C0", Length = "0x76")]
		[Token(Token = "0x6000A5F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD590", Offset = "0x2FFC990", Length = "0x86")]
		[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
		[Token(Token = "0x6000A60")]
		 set { } //Length: 134
	}

	[Obsolete("This property has been deprecated. Use Light.type instead.")]
	[Token(Token = "0x17000198")]
	public LightShape shape
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A25")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A26")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000199")]
	public float spotAngle
	{
		[Address(RVA = "0x2FFB740", Offset = "0x2FFAB40", Length = "0x76")]
		[Token(Token = "0x6000A27")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD740", Offset = "0x2FFCB40", Length = "0x86")]
		[Token(Token = "0x6000A28")]
		 set { } //Length: 134
	}

	[NativeProperty("LightType")]
	[Token(Token = "0x17000197")]
	public LightType type
	{
		[Address(RVA = "0x2FFB800", Offset = "0x2FFAC00", Length = "0x76")]
		[Token(Token = "0x6000A23")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD810", Offset = "0x2FFCC10", Length = "0x83")]
		[Token(Token = "0x6000A24")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001A3")]
	public bool useBoundingSphereOverride
	{
		[Address(RVA = "0x2FFB8C0", Offset = "0x2FFACC0", Length = "0x76")]
		[Token(Token = "0x6000A3B")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD8F0", Offset = "0x2FFCCF0", Length = "0x86")]
		[Token(Token = "0x6000A3C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700019D")]
	public bool useColorTemperature
	{
		[Address(RVA = "0x2FFB980", Offset = "0x2FFAD80", Length = "0x76")]
		[Token(Token = "0x6000A2F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFD9D0", Offset = "0x2FFCDD0", Length = "0x86")]
		[Token(Token = "0x6000A30")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001AB")]
	public bool useShadowMatrixOverride
	{
		[Address(RVA = "0x2FFBA40", Offset = "0x2FFAE40", Length = "0x76")]
		[Token(Token = "0x6000A4B")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFDAB0", Offset = "0x2FFCEB0", Length = "0x86")]
		[Token(Token = "0x6000A4C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001A5")]
	public bool useViewFrustumForShadowCasterCull
	{
		[Address(RVA = "0x2FFBB00", Offset = "0x2FFAF00", Length = "0x76")]
		[Token(Token = "0x6000A3F")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFDB90", Offset = "0x2FFCF90", Length = "0x86")]
		[Token(Token = "0x6000A40")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000A90")]
	public Light() { }

	[Address(RVA = "0x2FF9350", Offset = "0x2FF8750", Length = "0x10F")]
	[Token(Token = "0x6000A78")]
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FF9240", Offset = "0x2FF8640", Length = "0x10B")]
	[Token(Token = "0x6000A79")]
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	[Address(RVA = "0x2FF8EF0", Offset = "0x2FF82F0", Length = "0x113")]
	[Token(Token = "0x6000A7B")]
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FF9010", Offset = "0x2FF8410", Length = "0x10B")]
	[Token(Token = "0x6000A7C")]
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FF8E30", Offset = "0x2FF8230", Length = "0xB0")]
	[FreeFunction("Light_Bindings::AddCommandBufferAsync", HasExplicitThis = True)]
	[Token(Token = "0x6000A7D")]
	internal void AddCommandBufferAsyncInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FF8DD0", Offset = "0x2FF81D0", Length = "0x60")]
	[Token(Token = "0x6000ADA")]
	private static void AddCommandBufferAsyncInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	[Address(RVA = "0x2FF9180", Offset = "0x2FF8580", Length = "0xB0")]
	[FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6000A7A")]
	internal void AddCommandBufferInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	[Address(RVA = "0x2FF9120", Offset = "0x2FF8520", Length = "0x60")]
	[Token(Token = "0x6000AD9")]
	private static void AddCommandBufferInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer, ShadowMapPass shadowPassMask) { }

	[Address(RVA = "0x2FF9E00", Offset = "0x2FF9200", Length = "0x87")]
	[Token(Token = "0x6000A76")]
	public Vector2 get_areaSize() { }

	[Address(RVA = "0x2FF9DB0", Offset = "0x2FF91B0", Length = "0x42")]
	[Token(Token = "0x6000AD7")]
	private static void get_areaSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000A8E")]
	public bool get_attenuate() { }

	[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
	[Token(Token = "0x6000A74")]
	public int get_bakedIndex() { }

	[Address(RVA = "0x2FF9EE0", Offset = "0x2FF92E0", Length = "0x93")]
	[Token(Token = "0x6000A54")]
	public LightBakingOutput get_bakingOutput() { }

	[Address(RVA = "0x2FF9E90", Offset = "0x2FF9290", Length = "0x42")]
	[Token(Token = "0x6000AC0")]
	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	[Address(RVA = "0x2FF9FC0", Offset = "0x2FF93C0", Length = "0x76")]
	[Token(Token = "0x6000A33")]
	public float get_bounceIntensity() { }

	[Address(RVA = "0x2FF9F80", Offset = "0x2FF9380", Length = "0x33")]
	[Token(Token = "0x6000A9F")]
	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA090", Offset = "0x2FF9490", Length = "0x8E")]
	[Token(Token = "0x6000A3D")]
	public Vector4 get_boundingSphereOverride() { }

	[Address(RVA = "0x2FFA040", Offset = "0x2FF9440", Length = "0x42")]
	[Token(Token = "0x6000AA9")]
	private static void get_boundingSphereOverride_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FFA230", Offset = "0x2FF9630", Length = "0x8E")]
	[Token(Token = "0x6000A2B")]
	public Color get_color() { }

	[Address(RVA = "0x2FFA1E0", Offset = "0x2FF95E0", Length = "0x42")]
	[Token(Token = "0x6000A97")]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FFA160", Offset = "0x2FF9560", Length = "0x76")]
	[Token(Token = "0x6000A2D")]
	public float get_colorTemperature() { }

	[Address(RVA = "0x2FFA120", Offset = "0x2FF9520", Length = "0x33")]
	[Token(Token = "0x6000A99")]
	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA300", Offset = "0x2FF9700", Length = "0x76")]
	[Token(Token = "0x6000A86")]
	public int get_commandBufferCount() { }

	[Address(RVA = "0x2FFA2C0", Offset = "0x2FF96C0", Length = "0x33")]
	[Token(Token = "0x6000ADF")]
	private static int get_commandBufferCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA530", Offset = "0x2FF9930", Length = "0x90")]
	[Token(Token = "0x6000A70")]
	public Texture get_cookie() { }

	[Address(RVA = "0x2FFA4F0", Offset = "0x2FF98F0", Length = "0x33")]
	[Token(Token = "0x6000AD3")]
	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA460", Offset = "0x2FF9860", Length = "0x88")]
	[Token(Token = "0x6000A6C")]
	public float get_cookieSize() { }

	[Address(RVA = "0x2FFA3D0", Offset = "0x2FF97D0", Length = "0x87")]
	[Token(Token = "0x6000A6E")]
	public Vector2 get_cookieSize2D() { }

	[Address(RVA = "0x2FFA380", Offset = "0x2FF9780", Length = "0x42")]
	[Token(Token = "0x6000AD1")]
	private static void get_cookieSize2D_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FFA610", Offset = "0x2FF9A10", Length = "0x76")]
	[Token(Token = "0x6000A56")]
	public int get_cullingMask() { }

	[Address(RVA = "0x2FFA5D0", Offset = "0x2FF99D0", Length = "0x33")]
	[Token(Token = "0x6000AC2")]
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA6D0", Offset = "0x2FF9AD0", Length = "0x76")]
	[Token(Token = "0x6000A51")]
	public float get_dilatedRange() { }

	[Address(RVA = "0x2FFA690", Offset = "0x2FF9A90", Length = "0x33")]
	[Token(Token = "0x6000ABD")]
	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA790", Offset = "0x2FF9B90", Length = "0x76")]
	[Token(Token = "0x6000A39")]
	public bool get_enableSpotReflector() { }

	[Address(RVA = "0x2FFA750", Offset = "0x2FF9B50", Length = "0x33")]
	[Token(Token = "0x6000AA5")]
	private static bool get_enableSpotReflector_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA850", Offset = "0x2FF9C50", Length = "0x90")]
	[Token(Token = "0x6000A52")]
	public Flare get_flare() { }

	[Address(RVA = "0x2FFA810", Offset = "0x2FF9C10", Length = "0x33")]
	[Token(Token = "0x6000ABE")]
	private static IntPtr get_flare_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA930", Offset = "0x2FF9D30", Length = "0x76")]
	[Token(Token = "0x6000A41")]
	public bool get_forceVisible() { }

	[Address(RVA = "0x2FFA8F0", Offset = "0x2FF9CF0", Length = "0x33")]
	[Token(Token = "0x6000AAD")]
	private static bool get_forceVisible_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFA9F0", Offset = "0x2FF9DF0", Length = "0x76")]
	[Token(Token = "0x6000A29")]
	public float get_innerSpotAngle() { }

	[Address(RVA = "0x2FFA9B0", Offset = "0x2FF9DB0", Length = "0x33")]
	[Token(Token = "0x6000A95")]
	private static float get_innerSpotAngle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFAAB0", Offset = "0x2FF9EB0", Length = "0x76")]
	[Token(Token = "0x6000A31")]
	public float get_intensity() { }

	[Address(RVA = "0x2FFAA70", Offset = "0x2FF9E70", Length = "0x33")]
	[Token(Token = "0x6000A9D")]
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFAB80", Offset = "0x2FF9F80", Length = "0x12A")]
	[FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = False)]
	[Token(Token = "0x6000A6A")]
	public Single[] get_layerShadowCullDistances() { }

	[Address(RVA = "0x2FFAB30", Offset = "0x2FF9F30", Length = "0x42")]
	[Token(Token = "0x6000ACF")]
	private static void get_layerShadowCullDistances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FFACF0", Offset = "0x2FFA0F0", Length = "0x76")]
	[Token(Token = "0x6000A5A")]
	public LightShadowCasterMode get_lightShadowCasterMode() { }

	[Address(RVA = "0x2FFACB0", Offset = "0x2FFA0B0", Length = "0x33")]
	[Token(Token = "0x6000AC6")]
	private static LightShadowCasterMode get_lightShadowCasterMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFADB0", Offset = "0x2FFA1B0", Length = "0x76")]
	[Token(Token = "0x6000A35")]
	public LightUnit get_lightUnit() { }

	[Address(RVA = "0x2FFAD70", Offset = "0x2FFA170", Length = "0x33")]
	[Token(Token = "0x6000AA1")]
	private static LightUnit get_lightUnit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFAE70", Offset = "0x2FFA270", Length = "0x76")]
	[Token(Token = "0x6000A37")]
	public float get_luxAtDistance() { }

	[Address(RVA = "0x2FFAE30", Offset = "0x2FFA230", Length = "0x33")]
	[Token(Token = "0x6000AA3")]
	private static float get_luxAtDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFAEF0", Offset = "0x2FFA2F0", Length = "0x2A")]
	[Token(Token = "0x6000A87")]
	public static int get_pixelLightCount() { }

	[Address(RVA = "0x2FFAF60", Offset = "0x2FFA360", Length = "0x76")]
	[Token(Token = "0x6000A4F")]
	public float get_range() { }

	[Address(RVA = "0x2FFAF20", Offset = "0x2FFA320", Length = "0x33")]
	[Token(Token = "0x6000ABB")]
	private static float get_range_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB0E0", Offset = "0x2FFA4E0", Length = "0x76")]
	[Token(Token = "0x6000A58")]
	public int get_renderingLayerMask() { }

	[Address(RVA = "0x2FFB0A0", Offset = "0x2FFA4A0", Length = "0x33")]
	[Token(Token = "0x6000AC4")]
	private static int get_renderingLayerMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB020", Offset = "0x2FFA420", Length = "0x76")]
	[Token(Token = "0x6000A72")]
	public LightRenderMode get_renderMode() { }

	[Address(RVA = "0x2FFAFE0", Offset = "0x2FFA3E0", Length = "0x33")]
	[Token(Token = "0x6000AD5")]
	private static LightRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB1A0", Offset = "0x2FFA5A0", Length = "0x76")]
	[Token(Token = "0x6000A45")]
	public float get_shadowBias() { }

	[Address(RVA = "0x2FFB160", Offset = "0x2FFA560", Length = "0x33")]
	[Token(Token = "0x6000AB1")]
	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB220", Offset = "0x2FFA620", Length = "0x6")]
	[Token(Token = "0x6000A8A")]
	public float get_shadowConstantBias() { }

	[Address(RVA = "0x2FFB270", Offset = "0x2FFA670", Length = "0x76")]
	[Token(Token = "0x6000A43")]
	public int get_shadowCustomResolution() { }

	[Address(RVA = "0x2FFB230", Offset = "0x2FFA630", Length = "0x33")]
	[Token(Token = "0x6000AAF")]
	private static int get_shadowCustomResolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB340", Offset = "0x2FFA740", Length = "0x9A")]
	[Token(Token = "0x6000A4D")]
	public Matrix4x4 get_shadowMatrixOverride() { }

	[Address(RVA = "0x2FFB2F0", Offset = "0x2FFA6F0", Length = "0x42")]
	[Token(Token = "0x6000AB9")]
	private static void get_shadowMatrixOverride_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[Address(RVA = "0x2FFB420", Offset = "0x2FFA820", Length = "0x76")]
	[Token(Token = "0x6000A49")]
	public float get_shadowNearPlane() { }

	[Address(RVA = "0x2FFB3E0", Offset = "0x2FFA7E0", Length = "0x33")]
	[Token(Token = "0x6000AB5")]
	private static float get_shadowNearPlane_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB4E0", Offset = "0x2FFA8E0", Length = "0x76")]
	[Token(Token = "0x6000A47")]
	public float get_shadowNormalBias() { }

	[Address(RVA = "0x2FFB4A0", Offset = "0x2FFA8A0", Length = "0x33")]
	[Token(Token = "0x6000AB3")]
	private static float get_shadowNormalBias_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB220", Offset = "0x2FFA620", Length = "0x6")]
	[Token(Token = "0x6000A8C")]
	public float get_shadowObjectSizeBias() { }

	[Address(RVA = "0x2FF9D30", Offset = "0x2FF9130", Length = "0x76")]
	[Token(Token = "0x6000A61")]
	public LightShadowResolution get_shadowResolution() { }

	[Address(RVA = "0x2FF9D30", Offset = "0x2FF9130", Length = "0x76")]
	[Token(Token = "0x6000A64")]
	private LightShadowResolution get_ShadowResolution() { }

	[Address(RVA = "0x2FF9CF0", Offset = "0x2FF90F0", Length = "0x33")]
	[Token(Token = "0x6000ACD")]
	private static LightShadowResolution get_ShadowResolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB680", Offset = "0x2FFAA80", Length = "0x76")]
	[NativeMethod("GetShadowType")]
	[Token(Token = "0x6000A5D")]
	public LightShadows get_shadows() { }

	[Address(RVA = "0x2FFB640", Offset = "0x2FFAA40", Length = "0x33")]
	[Token(Token = "0x6000AC9")]
	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB570", Offset = "0x2FFA970", Length = "0xB")]
	[Token(Token = "0x6000A66")]
	public float get_shadowSoftness() { }

	[Address(RVA = "0x2FFB560", Offset = "0x2FFA960", Length = "0xB")]
	[Token(Token = "0x6000A68")]
	public float get_shadowSoftnessFade() { }

	[Address(RVA = "0x2FFB5C0", Offset = "0x2FFA9C0", Length = "0x76")]
	[Token(Token = "0x6000A5F")]
	public float get_shadowStrength() { }

	[Address(RVA = "0x2FFB580", Offset = "0x2FFA980", Length = "0x33")]
	[Token(Token = "0x6000ACB")]
	private static float get_shadowStrength_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A25")]
	public LightShape get_shape() { }

	[Address(RVA = "0x2FFB740", Offset = "0x2FFAB40", Length = "0x76")]
	[Token(Token = "0x6000A27")]
	public float get_spotAngle() { }

	[Address(RVA = "0x2FFB700", Offset = "0x2FFAB00", Length = "0x33")]
	[Token(Token = "0x6000A93")]
	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB800", Offset = "0x2FFAC00", Length = "0x76")]
	[Token(Token = "0x6000A23")]
	public LightType get_type() { }

	[Address(RVA = "0x2FFB7C0", Offset = "0x2FFABC0", Length = "0x33")]
	[Token(Token = "0x6000A91")]
	private static LightType get_type_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB8C0", Offset = "0x2FFACC0", Length = "0x76")]
	[Token(Token = "0x6000A3B")]
	public bool get_useBoundingSphereOverride() { }

	[Address(RVA = "0x2FFB880", Offset = "0x2FFAC80", Length = "0x33")]
	[Token(Token = "0x6000AA7")]
	private static bool get_useBoundingSphereOverride_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFB980", Offset = "0x2FFAD80", Length = "0x76")]
	[Token(Token = "0x6000A2F")]
	public bool get_useColorTemperature() { }

	[Address(RVA = "0x2FFB940", Offset = "0x2FFAD40", Length = "0x33")]
	[Token(Token = "0x6000A9B")]
	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFBA40", Offset = "0x2FFAE40", Length = "0x76")]
	[Token(Token = "0x6000A4B")]
	public bool get_useShadowMatrixOverride() { }

	[Address(RVA = "0x2FFBA00", Offset = "0x2FFAE00", Length = "0x33")]
	[Token(Token = "0x6000AB7")]
	private static bool get_useShadowMatrixOverride_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFBB00", Offset = "0x2FFAF00", Length = "0x76")]
	[Token(Token = "0x6000A3F")]
	public bool get_useViewFrustumForShadowCasterCull() { }

	[Address(RVA = "0x2FFBAC0", Offset = "0x2FFAEC0", Length = "0x33")]
	[Token(Token = "0x6000AAB")]
	private static bool get_useViewFrustumForShadowCasterCull_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FF9530", Offset = "0x2FF8930", Length = "0xDE")]
	[Token(Token = "0x6000A84")]
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	[Address(RVA = "0x2FF94A0", Offset = "0x2FF88A0", Length = "0x83")]
	[FreeFunction("Light_Bindings::GetCommandBuffers", HasExplicitThis = True)]
	[Token(Token = "0x6000A85")]
	internal CommandBuffer[] GetCommandBuffersInternal(LightEvent evt) { }

	[Address(RVA = "0x2FF9460", Offset = "0x2FF8860", Length = "0x40")]
	[Token(Token = "0x6000ADE")]
	private static CommandBuffer[] GetCommandBuffersInternal_Injected(IntPtr _unity_self, LightEvent evt) { }

	[Address(RVA = "0x2FF9610", Offset = "0x2FF8A10", Length = "0x3E")]
	[FreeFunction("Light_Bindings::GetLights")]
	[Obsolete("Light.GetLights has been deprecated, use FindObjectsOfType in combination with light.cullingmask/light.type", False)]
	[Token(Token = "0x6000A89")]
	public static Light[] GetLights(LightType type, int layer) { }

	[Address(RVA = "0x2FF9650", Offset = "0x2FF8A50", Length = "0x7D")]
	[Token(Token = "0x6000A63")]
	private static void LogWarningOnlyBuiltIn(string propertyName = "") { }

	[Address(RVA = "0x2FF9790", Offset = "0x2FF8B90", Length = "0xD1")]
	[Token(Token = "0x6000A82")]
	public void RemoveAllCommandBuffers() { }

	[Address(RVA = "0x2FF9710", Offset = "0x2FF8B10", Length = "0x76")]
	[NativeMethod("RemoveAllCommandBuffers")]
	[Token(Token = "0x6000A83")]
	internal void RemoveAllCommandBuffersInternal() { }

	[Address(RVA = "0x2FF96D0", Offset = "0x2FF8AD0", Length = "0x33")]
	[Token(Token = "0x6000ADD")]
	private static void RemoveAllCommandBuffersInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FF9970", Offset = "0x2FF8D70", Length = "0x109")]
	[Token(Token = "0x6000A7E")]
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FF98C0", Offset = "0x2FF8CC0", Length = "0xAE")]
	[NativeMethod("RemoveCommandBuffer")]
	[Token(Token = "0x6000A7F")]
	internal void RemoveCommandBufferInternal(LightEvent evt, CommandBuffer buffer) { }

	[Address(RVA = "0x2FF9870", Offset = "0x2FF8C70", Length = "0x50")]
	[Token(Token = "0x6000ADB")]
	private static void RemoveCommandBufferInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer) { }

	[Address(RVA = "0x2FF9B50", Offset = "0x2FF8F50", Length = "0xDE")]
	[Token(Token = "0x6000A80")]
	public void RemoveCommandBuffers(LightEvent evt) { }

	[Address(RVA = "0x2FF9AC0", Offset = "0x2FF8EC0", Length = "0x83")]
	[NativeMethod("RemoveCommandBuffers")]
	[Token(Token = "0x6000A81")]
	internal void RemoveCommandBuffersInternal(LightEvent evt) { }

	[Address(RVA = "0x2FF9A80", Offset = "0x2FF8E80", Length = "0x40")]
	[Token(Token = "0x6000ADC")]
	private static void RemoveCommandBuffersInternal_Injected(IntPtr _unity_self, LightEvent evt) { }

	[Address(RVA = "0x2FF9C70", Offset = "0x2FF9070", Length = "0x76")]
	[Token(Token = "0x6000A5C")]
	public void Reset() { }

	[Address(RVA = "0x2FF9C30", Offset = "0x2FF9030", Length = "0x33")]
	[Token(Token = "0x6000AC8")]
	private static void Reset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFBCA0", Offset = "0x2FFB0A0", Length = "0x80")]
	[Token(Token = "0x6000A77")]
	public void set_areaSize(Vector2 value) { }

	[Address(RVA = "0x2FFBC50", Offset = "0x2FFB050", Length = "0x42")]
	[Token(Token = "0x6000AD8")]
	private static void set_areaSize_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A8F")]
	public void set_attenuate(bool value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000A75")]
	public void set_bakedIndex(int value) { }

	[Address(RVA = "0x2FFBD80", Offset = "0x2FFB180", Length = "0x85")]
	[Token(Token = "0x6000A55")]
	public void set_bakingOutput(LightBakingOutput value) { }

	[Address(RVA = "0x2FFBD30", Offset = "0x2FFB130", Length = "0x42")]
	[Token(Token = "0x6000AC1")]
	private static void set_bakingOutput_Injected(IntPtr _unity_self, in LightBakingOutput value) { }

	[Address(RVA = "0x2FFBE60", Offset = "0x2FFB260", Length = "0x86")]
	[Token(Token = "0x6000A34")]
	public void set_bounceIntensity(float value) { }

	[Address(RVA = "0x2FFBE10", Offset = "0x2FFB210", Length = "0x43")]
	[Token(Token = "0x6000AA0")]
	private static void set_bounceIntensity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFBF40", Offset = "0x2FFB340", Length = "0x85")]
	[Token(Token = "0x6000A3E")]
	public void set_boundingSphereOverride(Vector4 value) { }

	[Address(RVA = "0x2FFBEF0", Offset = "0x2FFB2F0", Length = "0x42")]
	[Token(Token = "0x6000AAA")]
	private static void set_boundingSphereOverride_Injected(IntPtr _unity_self, in Vector4 value) { }

	[Address(RVA = "0x2FFC100", Offset = "0x2FFB500", Length = "0x85")]
	[Token(Token = "0x6000A2C")]
	public void set_color(Color value) { }

	[Address(RVA = "0x2FFC0B0", Offset = "0x2FFB4B0", Length = "0x42")]
	[Token(Token = "0x6000A98")]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x2FFC020", Offset = "0x2FFB420", Length = "0x86")]
	[Token(Token = "0x6000A2E")]
	public void set_colorTemperature(float value) { }

	[Address(RVA = "0x2FFBFD0", Offset = "0x2FFB3D0", Length = "0x43")]
	[Token(Token = "0x6000A9A")]
	private static void set_colorTemperature_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFC350", Offset = "0x2FFB750", Length = "0xBA")]
	[Token(Token = "0x6000A71")]
	public void set_cookie(Texture value) { }

	[Address(RVA = "0x2FFC300", Offset = "0x2FFB700", Length = "0x42")]
	[Token(Token = "0x6000AD4")]
	private static void set_cookie_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FFC270", Offset = "0x2FFB670", Length = "0x87")]
	[Token(Token = "0x6000A6D")]
	public void set_cookieSize(float value) { }

	[Address(RVA = "0x2FFC1E0", Offset = "0x2FFB5E0", Length = "0x80")]
	[Token(Token = "0x6000A6F")]
	public void set_cookieSize2D(Vector2 value) { }

	[Address(RVA = "0x2FFC190", Offset = "0x2FFB590", Length = "0x42")]
	[Token(Token = "0x6000AD2")]
	private static void set_cookieSize2D_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x2FFC450", Offset = "0x2FFB850", Length = "0x83")]
	[Token(Token = "0x6000A57")]
	public void set_cullingMask(int value) { }

	[Address(RVA = "0x2FFC410", Offset = "0x2FFB810", Length = "0x40")]
	[Token(Token = "0x6000AC3")]
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FFC530", Offset = "0x2FFB930", Length = "0x86")]
	[Token(Token = "0x6000A3A")]
	public void set_enableSpotReflector(bool value) { }

	[Address(RVA = "0x2FFC4E0", Offset = "0x2FFB8E0", Length = "0x42")]
	[Token(Token = "0x6000AA6")]
	private static void set_enableSpotReflector_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFC610", Offset = "0x2FFBA10", Length = "0xBA")]
	[Token(Token = "0x6000A53")]
	public void set_flare(Flare value) { }

	[Address(RVA = "0x2FFC5C0", Offset = "0x2FFB9C0", Length = "0x42")]
	[Token(Token = "0x6000ABF")]
	private static void set_flare_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FFC720", Offset = "0x2FFBB20", Length = "0x86")]
	[Token(Token = "0x6000A42")]
	public void set_forceVisible(bool value) { }

	[Address(RVA = "0x2FFC6D0", Offset = "0x2FFBAD0", Length = "0x42")]
	[Token(Token = "0x6000AAE")]
	private static void set_forceVisible_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFC800", Offset = "0x2FFBC00", Length = "0x86")]
	[Token(Token = "0x6000A2A")]
	public void set_innerSpotAngle(float value) { }

	[Address(RVA = "0x2FFC7B0", Offset = "0x2FFBBB0", Length = "0x43")]
	[Token(Token = "0x6000A96")]
	private static void set_innerSpotAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFC8E0", Offset = "0x2FFBCE0", Length = "0x86")]
	[Token(Token = "0x6000A32")]
	public void set_intensity(float value) { }

	[Address(RVA = "0x2FFC890", Offset = "0x2FFBC90", Length = "0x43")]
	[Token(Token = "0x6000A9E")]
	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFC9C0", Offset = "0x2FFBDC0", Length = "0x104")]
	[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A6B")]
	public void set_layerShadowCullDistances(Single[] value) { }

	[Address(RVA = "0x2FFC970", Offset = "0x2FFBD70", Length = "0x42")]
	[Token(Token = "0x6000AD0")]
	private static void set_layerShadowCullDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x2FFCB10", Offset = "0x2FFBF10", Length = "0x83")]
	[Token(Token = "0x6000A5B")]
	public void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	[Address(RVA = "0x2FFCAD0", Offset = "0x2FFBED0", Length = "0x40")]
	[Token(Token = "0x6000AC7")]
	private static void set_lightShadowCasterMode_Injected(IntPtr _unity_self, LightShadowCasterMode value) { }

	[Address(RVA = "0x2FFCBE0", Offset = "0x2FFBFE0", Length = "0x83")]
	[Token(Token = "0x6000A36")]
	public void set_lightUnit(LightUnit value) { }

	[Address(RVA = "0x2FFCBA0", Offset = "0x2FFBFA0", Length = "0x40")]
	[Token(Token = "0x6000AA2")]
	private static void set_lightUnit_Injected(IntPtr _unity_self, LightUnit value) { }

	[Address(RVA = "0x2FFCCC0", Offset = "0x2FFC0C0", Length = "0x86")]
	[Token(Token = "0x6000A38")]
	public void set_luxAtDistance(float value) { }

	[Address(RVA = "0x2FFCC70", Offset = "0x2FFC070", Length = "0x43")]
	[Token(Token = "0x6000AA4")]
	private static void set_luxAtDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFCD50", Offset = "0x2FFC150", Length = "0x31")]
	[Token(Token = "0x6000A88")]
	public static void set_pixelLightCount(int value) { }

	[Address(RVA = "0x2FFCDE0", Offset = "0x2FFC1E0", Length = "0x86")]
	[Token(Token = "0x6000A50")]
	public void set_range(float value) { }

	[Address(RVA = "0x2FFCD90", Offset = "0x2FFC190", Length = "0x43")]
	[Token(Token = "0x6000ABC")]
	private static void set_range_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFCF80", Offset = "0x2FFC380", Length = "0x83")]
	[Token(Token = "0x6000A59")]
	public void set_renderingLayerMask(int value) { }

	[Address(RVA = "0x2FFCF40", Offset = "0x2FFC340", Length = "0x40")]
	[Token(Token = "0x6000AC5")]
	private static void set_renderingLayerMask_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FFCEB0", Offset = "0x2FFC2B0", Length = "0x83")]
	[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A73")]
	public void set_renderMode(LightRenderMode value) { }

	[Address(RVA = "0x2FFCE70", Offset = "0x2FFC270", Length = "0x40")]
	[Token(Token = "0x6000AD6")]
	private static void set_renderMode_Injected(IntPtr _unity_self, LightRenderMode value) { }

	[Address(RVA = "0x2FFD060", Offset = "0x2FFC460", Length = "0x86")]
	[Token(Token = "0x6000A46")]
	public void set_shadowBias(float value) { }

	[Address(RVA = "0x2FFD010", Offset = "0x2FFC410", Length = "0x43")]
	[Token(Token = "0x6000AB2")]
	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A8B")]
	public void set_shadowConstantBias(float value) { }

	[Address(RVA = "0x2FFD130", Offset = "0x2FFC530", Length = "0x83")]
	[Token(Token = "0x6000A44")]
	public void set_shadowCustomResolution(int value) { }

	[Address(RVA = "0x2FFD0F0", Offset = "0x2FFC4F0", Length = "0x40")]
	[Token(Token = "0x6000AB0")]
	private static void set_shadowCustomResolution_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FFD210", Offset = "0x2FFC610", Length = "0x85")]
	[Token(Token = "0x6000A4E")]
	public void set_shadowMatrixOverride(Matrix4x4 value) { }

	[Address(RVA = "0x2FFD1C0", Offset = "0x2FFC5C0", Length = "0x42")]
	[Token(Token = "0x6000ABA")]
	private static void set_shadowMatrixOverride_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[Address(RVA = "0x2FFD2F0", Offset = "0x2FFC6F0", Length = "0x86")]
	[Token(Token = "0x6000A4A")]
	public void set_shadowNearPlane(float value) { }

	[Address(RVA = "0x2FFD2A0", Offset = "0x2FFC6A0", Length = "0x43")]
	[Token(Token = "0x6000AB6")]
	private static void set_shadowNearPlane_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFD3D0", Offset = "0x2FFC7D0", Length = "0x86")]
	[Token(Token = "0x6000A48")]
	public void set_shadowNormalBias(float value) { }

	[Address(RVA = "0x2FFD380", Offset = "0x2FFC780", Length = "0x43")]
	[Token(Token = "0x6000AB4")]
	private static void set_shadowNormalBias_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A8D")]
	public void set_shadowObjectSizeBias(float value) { }

	[Address(RVA = "0x2FFD460", Offset = "0x2FFC860", Length = "0xDE")]
	[Token(Token = "0x6000A62")]
	public void set_shadowResolution(LightShadowResolution value) { }

	[Address(RVA = "0x2FFBBC0", Offset = "0x2FFAFC0", Length = "0x83")]
	[FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A65")]
	private void set_ShadowResolution(LightShadowResolution value) { }

	[Address(RVA = "0x2FFBB80", Offset = "0x2FFAF80", Length = "0x40")]
	[Token(Token = "0x6000ACE")]
	private static void set_ShadowResolution_Injected(IntPtr _unity_self, LightShadowResolution value) { }

	[Address(RVA = "0x2FFD660", Offset = "0x2FFCA60", Length = "0x83")]
	[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000A5E")]
	public void set_shadows(LightShadows value) { }

	[Address(RVA = "0x2FFD620", Offset = "0x2FFCA20", Length = "0x40")]
	[Token(Token = "0x6000ACA")]
	private static void set_shadows_Injected(IntPtr _unity_self, LightShadows value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A67")]
	public void set_shadowSoftness(float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A69")]
	public void set_shadowSoftnessFade(float value) { }

	[Address(RVA = "0x2FFD590", Offset = "0x2FFC990", Length = "0x86")]
	[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
	[Token(Token = "0x6000A60")]
	public void set_shadowStrength(float value) { }

	[Address(RVA = "0x2FFD540", Offset = "0x2FFC940", Length = "0x43")]
	[Token(Token = "0x6000ACC")]
	private static void set_shadowStrength_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A26")]
	public void set_shape(LightShape value) { }

	[Address(RVA = "0x2FFD740", Offset = "0x2FFCB40", Length = "0x86")]
	[Token(Token = "0x6000A28")]
	public void set_spotAngle(float value) { }

	[Address(RVA = "0x2FFD6F0", Offset = "0x2FFCAF0", Length = "0x43")]
	[Token(Token = "0x6000A94")]
	private static void set_spotAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFD810", Offset = "0x2FFCC10", Length = "0x83")]
	[Token(Token = "0x6000A24")]
	public void set_type(LightType value) { }

	[Address(RVA = "0x2FFD7D0", Offset = "0x2FFCBD0", Length = "0x40")]
	[Token(Token = "0x6000A92")]
	private static void set_type_Injected(IntPtr _unity_self, LightType value) { }

	[Address(RVA = "0x2FFD8F0", Offset = "0x2FFCCF0", Length = "0x86")]
	[Token(Token = "0x6000A3C")]
	public void set_useBoundingSphereOverride(bool value) { }

	[Address(RVA = "0x2FFD8A0", Offset = "0x2FFCCA0", Length = "0x42")]
	[Token(Token = "0x6000AA8")]
	private static void set_useBoundingSphereOverride_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFD9D0", Offset = "0x2FFCDD0", Length = "0x86")]
	[Token(Token = "0x6000A30")]
	public void set_useColorTemperature(bool value) { }

	[Address(RVA = "0x2FFD980", Offset = "0x2FFCD80", Length = "0x42")]
	[Token(Token = "0x6000A9C")]
	private static void set_useColorTemperature_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFDAB0", Offset = "0x2FFCEB0", Length = "0x86")]
	[Token(Token = "0x6000A4C")]
	public void set_useShadowMatrixOverride(bool value) { }

	[Address(RVA = "0x2FFDA60", Offset = "0x2FFCE60", Length = "0x42")]
	[Token(Token = "0x6000AB8")]
	private static void set_useShadowMatrixOverride_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFDB90", Offset = "0x2FFCF90", Length = "0x86")]
	[Token(Token = "0x6000A40")]
	public void set_useViewFrustumForShadowCasterCull(bool value) { }

	[Address(RVA = "0x2FFDB40", Offset = "0x2FFCF40", Length = "0x42")]
	[Token(Token = "0x6000AAC")]
	private static void set_useViewFrustumForShadowCasterCull_Injected(IntPtr _unity_self, bool value) { }

}

