namespace UnityEngine.Rendering.Universal;

[DisallowMultipleComponent]
[RequireComponent(typeof(Light))]
[Token(Token = "0x20001CC")]
public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
{
	[Token(Token = "0x20001CD")]
	private enum Version : int
	{
		Initial = 0,
		RenderingLayers = 2,
		SoftShadowQuality = 3,
		RenderingLayersMask = 4,
		Count = 5,
	}

	[Token(Token = "0x40009EF")]
	public static readonly int AdditionalLightsShadowResolutionTierCustom; //Field offset: 0x0
	[Token(Token = "0x40009F0")]
	public static readonly int AdditionalLightsShadowResolutionTierLow; //Field offset: 0x4
	[Token(Token = "0x40009F1")]
	public static readonly int AdditionalLightsShadowResolutionTierMedium; //Field offset: 0x8
	[Token(Token = "0x40009F2")]
	public static readonly int AdditionalLightsShadowResolutionTierHigh; //Field offset: 0xC
	[Token(Token = "0x40009F3")]
	public static readonly int AdditionalLightsShadowDefaultResolutionTier; //Field offset: 0x10
	[Token(Token = "0x40009F4")]
	public static readonly int AdditionalLightsShadowDefaultCustomResolution; //Field offset: 0x14
	[Token(Token = "0x40009F6")]
	public static readonly int AdditionalLightsShadowMinimumResolution; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40009EE")]
	[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
	private bool m_UsePipelineSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009F5")]
	private Light m_Light; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40009F7")]
	[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
	private int m_AdditionalLightsShadowResolutionTier; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40009F8")]
	private bool m_CustomShadowLayers; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40009F9")]
	private Vector2 m_LightCookieSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40009FA")]
	private Vector2 m_LightCookieOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40009FB")]
	private SoftShadowQuality m_SoftShadowQuality; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40009FC")]
	private RenderingLayerMask m_RenderingLayersMask; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40009FD")]
	private RenderingLayerMask m_ShadowRenderingLayersMask; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40009FE")]
	private Version m_Version; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Obsolete("This is obsolete, please use m_RenderingLayerMask instead. #from(2023.1)")]
	[SerializeField]
	[Token(Token = "0x40009FF")]
	private LightLayerEnum m_LightLayerMask; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Obsolete("This is obsolete, please use m_RenderingLayerMask instead. #from(2023.1)")]
	[SerializeField]
	[Token(Token = "0x4000A00")]
	private LightLayerEnum m_ShadowLayerMask; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Obsolete("This is obsolete, please use m_RenderingLayersMask instead. #from(6000.2)")]
	[SerializeField]
	[Token(Token = "0x4000A01")]
	private uint m_RenderingLayers; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Obsolete("This is obsolete, please use renderingLayersMask instead. #from(6000.2)")]
	[SerializeField]
	[Token(Token = "0x4000A02")]
	private uint m_ShadowRenderingLayers; //Field offset: 0x64

	[Token(Token = "0x17000255")]
	public int additionalLightsShadowResolutionTier
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60009EF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000256")]
	public bool customShadowLayers
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x60009F0")]
		 get { } //Length: 5
		[Address(RVA = "0x2E0B6A0", Offset = "0x2E0AAA0", Length = "0x10")]
		[Token(Token = "0x60009F1")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000254")]
	internal Light light
	{
		[Address(RVA = "0x2E0B620", Offset = "0x2E0AA20", Length = "0x7E")]
		[Token(Token = "0x60009EE")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x17000258")]
	[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieOffset
	{
		[Address(RVA = "0x2D7E160", Offset = "0x2D7D560", Length = "0x13")]
		[Token(Token = "0x60009F4")]
		 get { } //Length: 19
		[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
		[Token(Token = "0x60009F5")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000257")]
	[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieSize
	{
		[Address(RVA = "0x2E0B600", Offset = "0x2E0AA00", Length = "0x13")]
		[Token(Token = "0x60009F2")]
		 get { } //Length: 19
		[Address(RVA = "0x1BBC1C0", Offset = "0x1BBB5C0", Length = "0x5")]
		[Token(Token = "0x60009F3")]
		 set { } //Length: 5
	}

	[Obsolete("This is obsolete, please use renderingLayerMask instead. #from(2023.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700025C")]
	public LightLayerEnum lightLayerMask
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60009FF")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6000A00")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025A")]
	public RenderingLayerMask renderingLayers
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60009F8")]
		 get { } //Length: 4
		[Address(RVA = "0x2E0B6B0", Offset = "0x2E0AAB0", Length = "0x7D")]
		[Token(Token = "0x60009F9")]
		 set { } //Length: 125
	}

	[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead. #from(2023.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700025D")]
	public LightLayerEnum shadowLayerMask
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x6000A01")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x6000A02")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025B")]
	public RenderingLayerMask shadowRenderingLayers
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 4
		[Address(RVA = "0x2E0B730", Offset = "0x2E0AB30", Length = "0x7B")]
		[Token(Token = "0x60009FB")]
		 set { } //Length: 123
	}

	[Token(Token = "0x17000259")]
	[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
	public SoftShadowQuality softShadowQuality
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60009F6")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x60009F7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000253")]
	public bool usePipelineSettings
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60009EC")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60009ED")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2E0B390", Offset = "0x2E0A790", Length = "0xB6")]
	[Token(Token = "0x6000A04")]
	private static UniversalAdditionalLightData() { }

	[Address(RVA = "0x2E0B450", Offset = "0x2E0A850", Length = "0x1AE")]
	[Token(Token = "0x6000A03")]
	public UniversalAdditionalLightData() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60009EF")]
	public int get_additionalLightsShadowResolutionTier() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x60009F0")]
	public bool get_customShadowLayers() { }

	[Address(RVA = "0x2E0B620", Offset = "0x2E0AA20", Length = "0x7E")]
	[Token(Token = "0x60009EE")]
	internal Light get_light() { }

	[Address(RVA = "0x2D7E160", Offset = "0x2D7D560", Length = "0x13")]
	[Token(Token = "0x60009F4")]
	public Vector2 get_lightCookieOffset() { }

	[Address(RVA = "0x2E0B600", Offset = "0x2E0AA00", Length = "0x13")]
	[Token(Token = "0x60009F2")]
	public Vector2 get_lightCookieSize() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60009FF")]
	public LightLayerEnum get_lightLayerMask() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60009F8")]
	public RenderingLayerMask get_renderingLayers() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x6000A01")]
	public LightLayerEnum get_shadowLayerMask() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60009FA")]
	public RenderingLayerMask get_shadowRenderingLayers() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60009F6")]
	public SoftShadowQuality get_softShadowQuality() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60009EC")]
	public bool get_usePipelineSettings() { }

	[Address(RVA = "0x2E0B6A0", Offset = "0x2E0AAA0", Length = "0x10")]
	[Token(Token = "0x60009F1")]
	public void set_customShadowLayers(bool value) { }

	[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
	[Token(Token = "0x60009F5")]
	public void set_lightCookieOffset(Vector2 value) { }

	[Address(RVA = "0x1BBC1C0", Offset = "0x1BBB5C0", Length = "0x5")]
	[Token(Token = "0x60009F3")]
	public void set_lightCookieSize(Vector2 value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6000A00")]
	public void set_lightLayerMask(LightLayerEnum value) { }

	[Address(RVA = "0x2E0B6B0", Offset = "0x2E0AAB0", Length = "0x7D")]
	[Token(Token = "0x60009F9")]
	public void set_renderingLayers(RenderingLayerMask value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x6000A02")]
	public void set_shadowLayerMask(LightLayerEnum value) { }

	[Address(RVA = "0x2E0B730", Offset = "0x2E0AB30", Length = "0x7B")]
	[Token(Token = "0x60009FB")]
	public void set_shadowRenderingLayers(RenderingLayerMask value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x60009F7")]
	public void set_softShadowQuality(SoftShadowQuality value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60009ED")]
	public void set_usePipelineSettings(bool value) { }

	[Address(RVA = "0x2E0B1A0", Offset = "0x2E0A5A0", Length = "0xC6")]
	[Token(Token = "0x60009FC")]
	private void SyncLightAndShadowLayers() { }

	[Address(RVA = "0x2E0B270", Offset = "0x2E0A670", Length = "0x10B")]
	[Token(Token = "0x60009FE")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2E0B380", Offset = "0x2E0A780", Length = "0xE")]
	[Token(Token = "0x60009FD")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

