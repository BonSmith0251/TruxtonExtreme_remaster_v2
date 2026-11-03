namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Light 2D")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DLightProperties.html")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", "Unity.RenderPipelines.Universal.Runtime", null)]
[Token(Token = "0x2000027")]
public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver
{
	[Token(Token = "0x200002C")]
	private enum ComponentVersions : int
	{
		Version_Unserialized = 0,
		Version_1 = 1,
		Version_2 = 2,
	}

	[Token(Token = "0x2000028")]
	internal enum DeprecatedLightType : int
	{
		Parametric = 0,
	}

	[Token(Token = "0x2000029")]
	internal enum LightType : int
	{
		Parametric = 0,
		Freeform = 1,
		Sprite = 2,
		Point = 3,
		Global = 4,
	}

	[Token(Token = "0x200002A")]
	internal enum NormalMapQuality : int
	{
		Disabled = 2,
		Fast = 0,
		Accurate = 1,
	}

	[Token(Token = "0x200002B")]
	internal enum OverlapOperation : int
	{
		Additive = 0,
		AlphaBlend = 1,
	}

	[Token(Token = "0x40000A5")]
	private const ComponentVersions k_CurrentComponentVersion = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000A6")]
	private ComponentVersions m_ComponentVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40000A7")]
	private LightType m_LightType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_LightOperationIndex")]
	[SerializeField]
	[Token(Token = "0x40000A8")]
	private int m_BlendStyleIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40000A9")]
	private float m_FalloffIntensity; //Field offset: 0x2C
	[ColorUsage(True)]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000AA")]
	private Color m_Color; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000AB")]
	private float m_Intensity; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_LightVolumeOpacity")]
	[SerializeField]
	[Token(Token = "0x40000AC")]
	private float m_LightVolumeIntensity; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_LightVolumeIntensityEnabled")]
	[SerializeField]
	[Token(Token = "0x40000AD")]
	private bool m_LightVolumeEnabled; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000AE")]
	private Int32[] m_ApplyToSortingLayers; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Reload("Textures/2D/Sparkle.png", Package::Root (1))]
	[SerializeField]
	[Token(Token = "0x40000AF")]
	private Sprite m_LightCookieSprite; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("m_LightCookieSprite")]
	[SerializeField]
	[Token(Token = "0x40000B0")]
	private Sprite m_DeprecatedPointLightCookieSprite; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40000B1")]
	private int m_LightOrder; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x40000B2")]
	private bool m_AlphaBlendOnOverlap; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40000B3")]
	private OverlapOperation m_OverlapOperation; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[FormerlySerializedAs("m_PointLightDistance")]
	[SerializeField]
	[Token(Token = "0x40000B4")]
	private float m_NormalMapDistance; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[FormerlySerializedAs("m_PointLightQuality")]
	[SerializeField]
	[Token(Token = "0x40000B5")]
	private NormalMapQuality m_NormalMapQuality; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40000B6")]
	private bool m_UseNormalMap; //Field offset: 0x7C
	[FieldOffset(Offset = "0x7D")]
	[FormerlySerializedAs("m_ShadowIntensityEnabled")]
	[SerializeField]
	[Token(Token = "0x40000B7")]
	private bool m_ShadowsEnabled; //Field offset: 0x7D
	[FieldOffset(Offset = "0x80")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private float m_ShadowIntensity; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40000B9")]
	private float m_ShadowSoftness; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40000BA")]
	private float m_ShadowSoftnessFalloffIntensity; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x40000BB")]
	private bool m_ShadowVolumeIntensityEnabled; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	private float m_ShadowVolumeIntensity; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000BD")]
	private Mesh m_Mesh; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000BE")]
	private LightMeshVertex[] m_Vertices; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000BF")]
	private UInt16[] m_Triangles; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000C0")]
	private int m_PreviousLightCookieSprite; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40000C1")]
	internal Vector3 m_CachedPosition; //Field offset: 0xB4
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000C2")]
	private int m_BatchSlotIndex; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000C3")]
	internal RTHandle m_CookieSpriteTexture; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000C4")]
	internal TextureHandle m_CookieSpriteTextureHandle; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40000C5")]
	private Bounds m_LocalBounds; //Field offset: 0xE0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000C6")]
	private BoundingSphere <boundingSphere>k__BackingField; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000C7")]
	internal bool forceUpdate; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	[Token(Token = "0x40000C8")]
	private float m_PointLightInnerAngle; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000C9")]
	private float m_PointLightOuterAngle; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40000CA")]
	private float m_PointLightInnerRadius; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	private float m_PointLightOuterRadius; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	private int m_ShapeLightParametricSides; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40000CD")]
	private float m_ShapeLightParametricAngleOffset; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[Token(Token = "0x40000CE")]
	private float m_ShapeLightParametricRadius; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	private float m_ShapeLightFalloffSize; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	private Vector2 m_ShapeLightFalloffOffset; //Field offset: 0x12C
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	private Vector3[] m_ShapePath; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000D2")]
	private float m_PreviousShapeLightFalloffSize; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40000D3")]
	private int m_PreviousShapeLightParametricSides; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000D4")]
	private float m_PreviousShapeLightParametricAngleOffset; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40000D5")]
	private float m_PreviousShapeLightParametricRadius; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40000D6")]
	private int m_PreviousShapePathHash; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40000D7")]
	private LightType m_PreviousLightType; //Field offset: 0x154

	[Obsolete("#from(2021.1)")]
	[Token(Token = "0x17000025")]
	public bool alphaBlendOnOverlap
	{
		[Address(RVA = "0x2D25D90", Offset = "0x2D25190", Length = "0x8")]
		[Token(Token = "0x600010C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000F")]
	internal int batchSlotIndex
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[Token(Token = "0x60000E5")]
		internal get { } //Length: 7
		[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
		[Token(Token = "0x60000E6")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	public int blendStyleIndex
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	internal BoundingSphere boundingSphere
	{
		[Address(RVA = "0x2D25DA0", Offset = "0x2D251A0", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x60000E9")]
		internal get { } //Length: 14
		[Address(RVA = "0x2D260B0", Offset = "0x2D254B0", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x60000EA")]
		private set { } //Length: 11
	}

	[Token(Token = "0x1700001C")]
	public Color color
	{
		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 11
		[Address(RVA = "0x2C0B510", Offset = "0x2C0A910", Length = "0x8")]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000023")]
	public float falloffIntensity
	{
		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x6000108")]
		 get { } //Length: 6
		[Address(RVA = "0x2D260C0", Offset = "0x2D254C0", Length = "0x21")]
		[Token(Token = "0x6000109")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000014")]
	internal bool hasCachedMesh
	{
		[Address(RVA = "0x2D25DB0", Offset = "0x2D251B0", Length = "0x3A")]
		[Token(Token = "0x60000EC")]
		internal get { } //Length: 58
	}

	[Token(Token = "0x1700000E")]
	internal UInt16[] indices
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60000E3")]
		internal get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x60000E4")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700001D")]
	public float intensity
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 6
		[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
		[Token(Token = "0x60000FE")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000032")]
	internal bool isPointLight
	{
		[Address(RVA = "0x2D25DF0", Offset = "0x2D251F0", Length = "0x8")]
		[Token(Token = "0x6000136")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000022")]
	public Sprite lightCookieSprite
	{
		[Address(RVA = "0x2D25E30", Offset = "0x2D25230", Length = "0x10")]
		[Token(Token = "0x6000106")]
		 get { } //Length: 16
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000107")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000010")]
	private int lightCookieSpriteInstanceID
	{
		[Address(RVA = "0x2D25E00", Offset = "0x2D25200", Length = "0x26")]
		[Token(Token = "0x60000E7")]
		private get { } //Length: 38
	}

	[Token(Token = "0x17000013")]
	internal Mesh lightMesh
	{
		[Address(RVA = "0x2D25E40", Offset = "0x2D25240", Length = "0xA3")]
		[Token(Token = "0x60000EB")]
		internal get { } //Length: 163
	}

	[Token(Token = "0x17000027")]
	public int lightOrder
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x600010F")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x6000110")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public LightType lightType
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 4
		[Address(RVA = "0x2D260F0", Offset = "0x2D254F0", Length = "0x69")]
		[Token(Token = "0x60000EE")]
		 set { } //Length: 105
	}

	[Token(Token = "0x17000028")]
	public float normalMapDistance
	{
		[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
		[Token(Token = "0x6000111")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000029")]
	public NormalMapQuality normalMapQuality
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public OverlapOperation overlapOperation
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600010D")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[Token(Token = "0x600010E")]
		 set { } //Length: 4
	}

	[Obsolete("pointLightDistance has been changed to normalMapDistance #from(2021.1) #breakingFrom(2021.1)", True)]
	[Token(Token = "0x17000030")]
	public float pointLightDistance
	{
		[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
		[Token(Token = "0x6000134")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700002C")]
	public float pointLightInnerAngle
	{
		[Address(RVA = "0x2D25EF0", Offset = "0x2D252F0", Length = "0x9")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26160", Offset = "0x2D25560", Length = "0x9")]
		[Token(Token = "0x600012D")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002E")]
	public float pointLightInnerRadius
	{
		[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
		[Token(Token = "0x6000130")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26170", Offset = "0x2D25570", Length = "0x9")]
		[Token(Token = "0x6000131")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002D")]
	public float pointLightOuterAngle
	{
		[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
		[Token(Token = "0x600012E")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26180", Offset = "0x2D25580", Length = "0x9")]
		[Token(Token = "0x600012F")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700002F")]
	public float pointLightOuterRadius
	{
		[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26190", Offset = "0x2D25590", Length = "0x9")]
		[Token(Token = "0x6000133")]
		 set { } //Length: 9
	}

	[Obsolete("pointLightQuality has been changed to normalMapQuality #from(2021.1) #breakingFrom(2021.1)", True)]
	[Token(Token = "0x17000031")]
	public NormalMapQuality pointLightQuality
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000135")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public bool renderVolumetricShadows
	{
		[Address(RVA = "0x2D25F30", Offset = "0x2D25330", Length = "0x1E")]
		[Token(Token = "0x6000113")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000017")]
	public float shadowIntensity
	{
		[Address(RVA = "0x5AD610", Offset = "0x5ACA10", Length = "0x9")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 9
		[Address(RVA = "0x2D261A0", Offset = "0x2D255A0", Length = "0x27")]
		[Token(Token = "0x60000F2")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000019")]
	public bool shadowsEnabled
	{
		[Address(RVA = "0x2D25F80", Offset = "0x2D25380", Length = "0x5")]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 5
		[Address(RVA = "0x2D26230", Offset = "0x2D25630", Length = "0x4")]
		[Token(Token = "0x60000F6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public float shadowSoftness
	{
		[Address(RVA = "0x2D25F60", Offset = "0x2D25360", Length = "0x9")]
		[Token(Token = "0x60000F3")]
		 get { } //Length: 9
		[Address(RVA = "0x1DDFDD0", Offset = "0x1DDF1D0", Length = "0x9")]
		[Token(Token = "0x60000F4")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000024")]
	public float shadowSoftnessFalloffIntensity
	{
		[Address(RVA = "0x2D25F50", Offset = "0x2D25350", Length = "0x9")]
		[Token(Token = "0x600010A")]
		 get { } //Length: 9
		[Address(RVA = "0x2D261D0", Offset = "0x2D255D0", Length = "0x27")]
		[Token(Token = "0x600010B")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700001A")]
	public float shadowVolumeIntensity
	{
		[Address(RVA = "0x2D25F70", Offset = "0x2D25370", Length = "0x9")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26200", Offset = "0x2D25600", Length = "0x27")]
		[Token(Token = "0x60000F8")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000036")]
	public float shapeLightFalloffSize
	{
		[Address(RVA = "0x284A2F0", Offset = "0x28496F0", Length = "0x9")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26240", Offset = "0x2D25640", Length = "0x12")]
		[Token(Token = "0x600013C")]
		 set { } //Length: 18
	}

	[Token(Token = "0x17000034")]
	public float shapeLightParametricAngleOffset
	{
		[Address(RVA = "0x2D25F90", Offset = "0x2D25390", Length = "0x9")]
		[Token(Token = "0x6000138")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000035")]
	public internal float shapeLightParametricRadius
	{
		[Address(RVA = "0x2D25FA0", Offset = "0x2D253A0", Length = "0x9")]
		[Token(Token = "0x6000139")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26260", Offset = "0x2D25660", Length = "0x9")]
		[Token(Token = "0x600013A")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x17000033")]
	public int shapeLightParametricSides
	{
		[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
		[Token(Token = "0x6000137")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000037")]
	public internal Vector3[] shapePath
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[Token(Token = "0x600013E")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700002B")]
	public Int32[] targetSortingLayers
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000114")]
		 get { } //Length: 5
		[Address(RVA = "0x2D26270", Offset = "0x2D25670", Length = "0x10A")]
		[Token(Token = "0x6000115")]
		 set { } //Length: 266
	}

	[Token(Token = "0x17000011")]
	internal bool useCookieSprite
	{
		[Address(RVA = "0x2D25FB0", Offset = "0x2D253B0", Length = "0xEB")]
		[Token(Token = "0x60000E8")]
		internal get { } //Length: 235
	}

	[Token(Token = "0x1700000D")]
	internal LightMeshVertex[] vertices
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60000E1")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x60000E2")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700001F")]
	public float volumeIntensity
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000100")]
		 get { } //Length: 6
		[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
		[Token(Token = "0x6000101")]
		 set { } //Length: 6
	}

	[Obsolete("#from(2023.1)")]
	[Token(Token = "0x17000020")]
	public bool volumeIntensityEnabled
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000102")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[Token(Token = "0x6000103")]
		 set { } //Length: 4
	}

	[Obsolete("#from(2021.1)")]
	[Token(Token = "0x1700001E")]
	public float volumeOpacity
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000021")]
	public bool volumetricEnabled
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000104")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[Token(Token = "0x6000105")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001B")]
	public bool volumetricShadowsEnabled
	{
		[Address(RVA = "0x2D260A0", Offset = "0x2D254A0", Length = "0x8")]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 8
		[Address(RVA = "0x2D26380", Offset = "0x2D25780", Length = "0x7")]
		[Token(Token = "0x60000FA")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2D25C00", Offset = "0x2D25000", Length = "0x18B")]
	[Token(Token = "0x6000140")]
	public Light2D() { }

	[Address(RVA = "0x2D24150", Offset = "0x2D23550", Length = "0x113")]
	[Token(Token = "0x6000117")]
	public bool AddTargetSortingLayer(string layerName) { }

	[Address(RVA = "0x2D24270", Offset = "0x2D23670", Length = "0x11E")]
	[Token(Token = "0x6000118")]
	public bool AddTargetSortingLayer(int layerID) { }

	[Address(RVA = "0x2D24390", Offset = "0x2D23790", Length = "0xEC")]
	[Token(Token = "0x6000126")]
	private void Awake() { }

	[Address(RVA = "0x2D24480", Offset = "0x2D23880", Length = "0x45")]
	[Token(Token = "0x600011C")]
	internal void CacheValues() { }

	[Address(RVA = "0x2D25D90", Offset = "0x2D25190", Length = "0x8")]
	[Token(Token = "0x600010C")]
	public bool get_alphaBlendOnOverlap() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[Token(Token = "0x60000E5")]
	internal int get_batchSlotIndex() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60000EF")]
	public int get_blendStyleIndex() { }

	[Address(RVA = "0x2D25DA0", Offset = "0x2D251A0", Length = "0xE")]
	[CompilerGenerated]
	[Token(Token = "0x60000E9")]
	internal BoundingSphere get_boundingSphere() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
	[Token(Token = "0x60000FB")]
	public Color get_color() { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x6000108")]
	public float get_falloffIntensity() { }

	[Address(RVA = "0x2D25DB0", Offset = "0x2D251B0", Length = "0x3A")]
	[Token(Token = "0x60000EC")]
	internal bool get_hasCachedMesh() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60000E3")]
	internal UInt16[] get_indices() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x60000FD")]
	public float get_intensity() { }

	[Address(RVA = "0x2D25DF0", Offset = "0x2D251F0", Length = "0x8")]
	[Token(Token = "0x6000136")]
	internal bool get_isPointLight() { }

	[Address(RVA = "0x2D25E30", Offset = "0x2D25230", Length = "0x10")]
	[Token(Token = "0x6000106")]
	public Sprite get_lightCookieSprite() { }

	[Address(RVA = "0x2D25E00", Offset = "0x2D25200", Length = "0x26")]
	[Token(Token = "0x60000E7")]
	private int get_lightCookieSpriteInstanceID() { }

	[Address(RVA = "0x2D25E40", Offset = "0x2D25240", Length = "0xA3")]
	[Token(Token = "0x60000EB")]
	internal Mesh get_lightMesh() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x600010F")]
	public int get_lightOrder() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60000ED")]
	public LightType get_lightType() { }

	[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
	[Token(Token = "0x6000111")]
	public float get_normalMapDistance() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000112")]
	public NormalMapQuality get_normalMapQuality() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600010D")]
	public OverlapOperation get_overlapOperation() { }

	[Address(RVA = "0x26DE200", Offset = "0x26DD600", Length = "0x6")]
	[Token(Token = "0x6000134")]
	public float get_pointLightDistance() { }

	[Address(RVA = "0x2D25EF0", Offset = "0x2D252F0", Length = "0x9")]
	[Token(Token = "0x600012C")]
	public float get_pointLightInnerAngle() { }

	[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
	[Token(Token = "0x6000130")]
	public float get_pointLightInnerRadius() { }

	[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
	[Token(Token = "0x600012E")]
	public float get_pointLightOuterAngle() { }

	[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
	[Token(Token = "0x6000132")]
	public float get_pointLightOuterRadius() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000135")]
	public NormalMapQuality get_pointLightQuality() { }

	[Address(RVA = "0x2D25F30", Offset = "0x2D25330", Length = "0x1E")]
	[Token(Token = "0x6000113")]
	public bool get_renderVolumetricShadows() { }

	[Address(RVA = "0x5AD610", Offset = "0x5ACA10", Length = "0x9")]
	[Token(Token = "0x60000F1")]
	public float get_shadowIntensity() { }

	[Address(RVA = "0x2D25F80", Offset = "0x2D25380", Length = "0x5")]
	[Token(Token = "0x60000F5")]
	public bool get_shadowsEnabled() { }

	[Address(RVA = "0x2D25F60", Offset = "0x2D25360", Length = "0x9")]
	[Token(Token = "0x60000F3")]
	public float get_shadowSoftness() { }

	[Address(RVA = "0x2D25F50", Offset = "0x2D25350", Length = "0x9")]
	[Token(Token = "0x600010A")]
	public float get_shadowSoftnessFalloffIntensity() { }

	[Address(RVA = "0x2D25F70", Offset = "0x2D25370", Length = "0x9")]
	[Token(Token = "0x60000F7")]
	public float get_shadowVolumeIntensity() { }

	[Address(RVA = "0x284A2F0", Offset = "0x28496F0", Length = "0x9")]
	[Token(Token = "0x600013B")]
	public float get_shapeLightFalloffSize() { }

	[Address(RVA = "0x2D25F90", Offset = "0x2D25390", Length = "0x9")]
	[Token(Token = "0x6000138")]
	public float get_shapeLightParametricAngleOffset() { }

	[Address(RVA = "0x2D25FA0", Offset = "0x2D253A0", Length = "0x9")]
	[Token(Token = "0x6000139")]
	public float get_shapeLightParametricRadius() { }

	[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
	[Token(Token = "0x6000137")]
	public int get_shapeLightParametricSides() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x600013D")]
	public Vector3[] get_shapePath() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000114")]
	public Int32[] get_targetSortingLayers() { }

	[Address(RVA = "0x2D25FB0", Offset = "0x2D253B0", Length = "0xEB")]
	[Token(Token = "0x60000E8")]
	internal bool get_useCookieSprite() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60000E1")]
	internal LightMeshVertex[] get_vertices() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000100")]
	public float get_volumeIntensity() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000102")]
	public bool get_volumeIntensityEnabled() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x60000FF")]
	public float get_volumeOpacity() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000104")]
	public bool get_volumetricEnabled() { }

	[Address(RVA = "0x2D260A0", Offset = "0x2D254A0", Length = "0x8")]
	[Token(Token = "0x60000F9")]
	public bool get_volumetricShadowsEnabled() { }

	[Address(RVA = "0x2D244D0", Offset = "0x2D238D0", Length = "0x176")]
	[Token(Token = "0x6000125")]
	internal Matrix4x4 GetMatrix() { }

	[Address(RVA = "0x2D24650", Offset = "0x2D23A50", Length = "0x127")]
	[Token(Token = "0x600011D")]
	internal int GetTopMostLitLayer() { }

	[Address(RVA = "0x2D24780", Offset = "0x2D23B80", Length = "0x4B")]
	[Token(Token = "0x6000124")]
	internal bool IsLitLayer(int layer) { }

	[Address(RVA = "0x2D247D0", Offset = "0x2D23BD0", Length = "0xC0")]
	[Token(Token = "0x6000116")]
	private bool IsValidLayer(string name) { }

	[Address(RVA = "0x2D248A0", Offset = "0x2D23CA0", Length = "0x35")]
	[Token(Token = "0x6000129")]
	private void LateUpdate() { }

	[Address(RVA = "0x2D248E0", Offset = "0x2D23CE0", Length = "0x8")]
	[Token(Token = "0x600011B")]
	internal void MarkForUpdate() { }

	[Address(RVA = "0x2D248F0", Offset = "0x2D23CF0", Length = "0x7E")]
	[Token(Token = "0x6000120")]
	internal bool NeedsColorIndexBaking() { }

	[Address(RVA = "0x2D24970", Offset = "0x2D23D70", Length = "0x76")]
	[Token(Token = "0x600012B")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x1EE30C0", Offset = "0x1EE24C0", Length = "0x8")]
	[Token(Token = "0x600012A")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2D249F0", Offset = "0x2D23DF0", Length = "0xF1")]
	[Token(Token = "0x6000128")]
	private void OnDisable() { }

	[Address(RVA = "0x2D24AF0", Offset = "0x2D23EF0", Length = "0x168")]
	[Token(Token = "0x6000127")]
	private void OnEnable() { }

	[Address(RVA = "0x2D24D80", Offset = "0x2D24180", Length = "0x113")]
	[Token(Token = "0x6000119")]
	public bool RemoveTargetSortingLayer(string layerName) { }

	[Address(RVA = "0x2D24C60", Offset = "0x2D24060", Length = "0x11E")]
	[Token(Token = "0x600011A")]
	public bool RemoveTargetSortingLayer(int layerID) { }

	[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
	[Token(Token = "0x60000E6")]
	internal void set_batchSlotIndex(int value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60000F0")]
	public void set_blendStyleIndex(int value) { }

	[Address(RVA = "0x2D260B0", Offset = "0x2D254B0", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x60000EA")]
	private void set_boundingSphere(BoundingSphere value) { }

	[Address(RVA = "0x2C0B510", Offset = "0x2C0A910", Length = "0x8")]
	[Token(Token = "0x60000FC")]
	public void set_color(Color value) { }

	[Address(RVA = "0x2D260C0", Offset = "0x2D254C0", Length = "0x21")]
	[Token(Token = "0x6000109")]
	public void set_falloffIntensity(float value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x60000E4")]
	internal void set_indices(UInt16[] value) { }

	[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
	[Token(Token = "0x60000FE")]
	public void set_intensity(float value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000107")]
	public void set_lightCookieSprite(Sprite value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x6000110")]
	public void set_lightOrder(int value) { }

	[Address(RVA = "0x2D260F0", Offset = "0x2D254F0", Length = "0x69")]
	[Token(Token = "0x60000EE")]
	public void set_lightType(LightType value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[Token(Token = "0x600010E")]
	public void set_overlapOperation(OverlapOperation value) { }

	[Address(RVA = "0x2D26160", Offset = "0x2D25560", Length = "0x9")]
	[Token(Token = "0x600012D")]
	public void set_pointLightInnerAngle(float value) { }

	[Address(RVA = "0x2D26170", Offset = "0x2D25570", Length = "0x9")]
	[Token(Token = "0x6000131")]
	public void set_pointLightInnerRadius(float value) { }

	[Address(RVA = "0x2D26180", Offset = "0x2D25580", Length = "0x9")]
	[Token(Token = "0x600012F")]
	public void set_pointLightOuterAngle(float value) { }

	[Address(RVA = "0x2D26190", Offset = "0x2D25590", Length = "0x9")]
	[Token(Token = "0x6000133")]
	public void set_pointLightOuterRadius(float value) { }

	[Address(RVA = "0x2D261A0", Offset = "0x2D255A0", Length = "0x27")]
	[Token(Token = "0x60000F2")]
	public void set_shadowIntensity(float value) { }

	[Address(RVA = "0x2D26230", Offset = "0x2D25630", Length = "0x4")]
	[Token(Token = "0x60000F6")]
	public void set_shadowsEnabled(bool value) { }

	[Address(RVA = "0x1DDFDD0", Offset = "0x1DDF1D0", Length = "0x9")]
	[Token(Token = "0x60000F4")]
	public void set_shadowSoftness(float value) { }

	[Address(RVA = "0x2D261D0", Offset = "0x2D255D0", Length = "0x27")]
	[Token(Token = "0x600010B")]
	public void set_shadowSoftnessFalloffIntensity(float value) { }

	[Address(RVA = "0x2D26200", Offset = "0x2D25600", Length = "0x27")]
	[Token(Token = "0x60000F8")]
	public void set_shadowVolumeIntensity(float value) { }

	[Address(RVA = "0x2D26240", Offset = "0x2D25640", Length = "0x12")]
	[Token(Token = "0x600013C")]
	public void set_shapeLightFalloffSize(float value) { }

	[Address(RVA = "0x2D26260", Offset = "0x2D25660", Length = "0x9")]
	[Token(Token = "0x600013A")]
	internal void set_shapeLightParametricRadius(float value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[Token(Token = "0x600013E")]
	internal void set_shapePath(Vector3[] value) { }

	[Address(RVA = "0x2D26270", Offset = "0x2D25670", Length = "0x10A")]
	[Token(Token = "0x6000115")]
	public void set_targetSortingLayers(Int32[] value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x60000E2")]
	internal void set_vertices(LightMeshVertex[] value) { }

	[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
	[Token(Token = "0x6000101")]
	public void set_volumeIntensity(float value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[Token(Token = "0x6000103")]
	public void set_volumeIntensityEnabled(bool value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[Token(Token = "0x6000105")]
	public void set_volumetricEnabled(bool value) { }

	[Address(RVA = "0x2D26380", Offset = "0x2D25780", Length = "0x7")]
	[Token(Token = "0x60000FA")]
	public void set_volumetricShadowsEnabled(bool value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[Token(Token = "0x600013F")]
	public void SetShapePath(Vector3[] path) { }

	[Address(RVA = "0x2D24EA0", Offset = "0x2D242A0", Length = "0x183")]
	[Token(Token = "0x600011F")]
	internal void UpdateBatchSlotIndex() { }

	[Address(RVA = "0x2D25030", Offset = "0x2D24430", Length = "0x373")]
	[Token(Token = "0x6000123")]
	internal void UpdateBoundingSphere() { }

	[Address(RVA = "0x2D253B0", Offset = "0x2D247B0", Length = "0xB4")]
	[Token(Token = "0x6000121")]
	internal void UpdateCookieSpriteTexture() { }

	[Address(RVA = "0x2D25470", Offset = "0x2D24870", Length = "0x624")]
	[Token(Token = "0x6000122")]
	internal void UpdateMesh(bool forceUpdate = false) { }

	[Address(RVA = "0x2D25AA0", Offset = "0x2D24EA0", Length = "0x15D")]
	[Token(Token = "0x600011E")]
	internal Bounds UpdateSpriteMesh() { }

}

