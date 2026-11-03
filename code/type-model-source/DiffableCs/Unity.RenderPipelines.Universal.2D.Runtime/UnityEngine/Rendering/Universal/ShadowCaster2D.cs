namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[MovedFrom(False, "UnityEngine.Experimental.Rendering.Universal", "com.unity.render-pipelines.universal", null)]
[Token(Token = "0x2000067")]
public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000068")]
	public enum ComponentVersions : int
	{
		Version_Unserialized = 0,
		Version_1 = 1,
		Version_2 = 2,
		Version_3 = 3,
		Version_4 = 4,
		Version_5 = 5,
	}

	[Token(Token = "0x200006B")]
	public enum EdgeProcessing : int
	{
		None = 0,
		Clipping = 1,
	}

	[Token(Token = "0x200006A")]
	internal enum ShadowCastingOptions : int
	{
		SelfShadow = 0,
		CastShadow = 1,
		CastAndSelfShadow = 2,
		NoShadow = 3,
	}

	[Token(Token = "0x2000069")]
	public enum ShadowCastingSources : int
	{
		None = 0,
		ShapeEditor = 1,
		ShapeProvider = 2,
	}

	[Token(Token = "0x4000235")]
	private const ComponentVersions k_CurrentComponentVersion = 5; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000236")]
	private ComponentVersions m_ComponentVersion; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000237")]
	private bool m_HasRenderer; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[SerializeField]
	[Token(Token = "0x4000238")]
	private bool m_UseRendererSilhouette; //Field offset: 0x35
	[FieldOffset(Offset = "0x36")]
	[SerializeField]
	[Token(Token = "0x4000239")]
	private bool m_CastsShadows; //Field offset: 0x36
	[FieldOffset(Offset = "0x37")]
	[SerializeField]
	[Token(Token = "0x400023A")]
	private bool m_SelfShadows; //Field offset: 0x37
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x400023B")]
	private float m_AlphaCutoff; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400023C")]
	private Int32[] m_ApplyToSortingLayers; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400023D")]
	private Vector3[] m_ShapePath; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400023E")]
	private int m_ShapePathHash; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400023F")]
	private int m_InstanceId; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000240")]
	private Component m_ShadowShape2DComponent; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeReference]
	[Token(Token = "0x4000241")]
	private ShadowShape2DProvider m_ShadowShape2DProvider; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000242")]
	private ShadowCastingSources m_ShadowCastingSource; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000243")]
	internal ShadowMesh2D m_ShadowMesh; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000244")]
	private ShadowCastingOptions m_CastingOption; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x4000245")]
	internal float m_PreviousTrimEdge; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000246")]
	internal int m_PreviousEdgeProcessing; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x4000247")]
	internal int m_PreviousShadowCastingSource; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000248")]
	internal Component m_PreviousShadowShape2DSource; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000249")]
	internal ShadowCasterGroup2D m_ShadowCasterGroup; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400024A")]
	internal ShadowCasterGroup2D m_PreviousShadowCasterGroup; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400024B")]
	internal bool m_ForceShadowMeshRebuild; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400024C")]
	private int m_PreviousShadowGroup; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400024D")]
	private bool m_PreviousCastsShadows; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400024E")]
	private int m_PreviousPathHash; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400024F")]
	private int m_SpriteMaterialCount; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000250")]
	internal Vector3 m_CachedPosition; //Field offset: 0xB4
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000251")]
	internal Vector3 m_CachedLossyScale; //Field offset: 0xC0
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4000252")]
	internal Quaternion m_CachedRotation; //Field offset: 0xCC
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000253")]
	internal Matrix4x4 m_CachedShadowMatrix; //Field offset: 0xDC
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000254")]
	internal Matrix4x4 m_CachedInverseShadowMatrix; //Field offset: 0x11C
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000255")]
	internal Matrix4x4 m_CachedLocalToWorldMatrix; //Field offset: 0x15C

	[Token(Token = "0x17000085")]
	public float alphaCutoff
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x600027F")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x6000280")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000083")]
	public BoundingSphere boundingSphere
	{
		[Address(RVA = "0x2D3D060", Offset = "0x2D3C460", Length = "0x21")]
		[Token(Token = "0x600027C")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700008C")]
	public ShadowCastingOptions castingOption
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x600028D")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x600028C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700008F")]
	public bool castsShadows
	{
		[Address(RVA = "0x2D3D090", Offset = "0x2D3C490", Length = "0x11")]
		[Token(Token = "0x6000293")]
		 get { } //Length: 17
		[Address(RVA = "0x2D3D140", Offset = "0x2D3C540", Length = "0x3A")]
		[Token(Token = "0x6000292")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000081")]
	internal EdgeProcessing edgeProcessing
	{
		[Address(RVA = "0x2D3D0B0", Offset = "0x2D3C4B0", Length = "0x1A")]
		[Token(Token = "0x6000279")]
		internal get { } //Length: 26
		[Address(RVA = "0x2D3D180", Offset = "0x2D3C580", Length = "0x1A")]
		[Token(Token = "0x600027A")]
		internal set { } //Length: 26
	}

	[Token(Token = "0x17000082")]
	public Mesh mesh
	{
		[Address(RVA = "0x2D3D0D0", Offset = "0x2D3C4D0", Length = "0x1B")]
		[Token(Token = "0x600027B")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700008E")]
	public bool selfShadows
	{
		[Address(RVA = "0x2D3D0F0", Offset = "0x2D3C4F0", Length = "0x11")]
		[Token(Token = "0x6000291")]
		 get { } //Length: 17
		[Address(RVA = "0x2D3D1A0", Offset = "0x2D3C5A0", Length = "0x3B")]
		[Token(Token = "0x6000290")]
		 set { } //Length: 59
	}

	[Token(Token = "0x17000088")]
	internal ShadowCastingSources shadowCastingSource
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6000284")]
		internal get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x6000285")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000089")]
	internal Component shadowShape2DComponent
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000286")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000287")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700008A")]
	internal ShadowShape2DProvider shadowShape2DProvider
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000288")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6000289")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x17000086")]
	public Vector3[] shapePath
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000281")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000087")]
	internal int shapePathHash
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000282")]
		internal get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x6000283")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700008B")]
	internal int spriteMaterialCount
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[Token(Token = "0x600028A")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000084")]
	public float trimEdge
	{
		[Address(RVA = "0x2D3D110", Offset = "0x2D3C510", Length = "0x1C")]
		[Token(Token = "0x600027D")]
		 get { } //Length: 28
		[Address(RVA = "0x2D3D1E0", Offset = "0x2D3C5E0", Length = "0x1C")]
		[Token(Token = "0x600027E")]
		 set { } //Length: 28
	}

	[Obsolete("useRendererSilhoutte is deprecated. Use selfShadows instead. #from(2023.1)")]
	[Token(Token = "0x1700008D")]
	public bool useRendererSilhouette
	{
		[Address(RVA = "0x2D3D130", Offset = "0x2D3C530", Length = "0xE")]
		[Token(Token = "0x600028F")]
		 get { } //Length: 14
		[Address(RVA = "0x2911680", Offset = "0x2910A80", Length = "0x4")]
		[Token(Token = "0x600028E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2D3D030", Offset = "0x2D3C430", Length = "0x29")]
	[Token(Token = "0x600029E")]
	public ShadowCaster2D() { }

	[Address(RVA = "0x2D3BE30", Offset = "0x2D3B230", Length = "0x6B0")]
	[Token(Token = "0x6000298")]
	private void Awake() { }

	[Address(RVA = "0x2D3C4F0", Offset = "0x2D3B8F0", Length = "0x22F")]
	[Token(Token = "0x600028B")]
	internal virtual void CacheValues() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x600027F")]
	public float get_alphaCutoff() { }

	[Address(RVA = "0x2D3D060", Offset = "0x2D3C460", Length = "0x21")]
	[Token(Token = "0x600027C")]
	public BoundingSphere get_boundingSphere() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x600028D")]
	public ShadowCastingOptions get_castingOption() { }

	[Address(RVA = "0x2D3D090", Offset = "0x2D3C490", Length = "0x11")]
	[Token(Token = "0x6000293")]
	public bool get_castsShadows() { }

	[Address(RVA = "0x2D3D0B0", Offset = "0x2D3C4B0", Length = "0x1A")]
	[Token(Token = "0x6000279")]
	internal EdgeProcessing get_edgeProcessing() { }

	[Address(RVA = "0x2D3D0D0", Offset = "0x2D3C4D0", Length = "0x1B")]
	[Token(Token = "0x600027B")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x2D3D0F0", Offset = "0x2D3C4F0", Length = "0x11")]
	[Token(Token = "0x6000291")]
	public bool get_selfShadows() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6000284")]
	internal ShadowCastingSources get_shadowCastingSource() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000286")]
	internal Component get_shadowShape2DComponent() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000288")]
	internal ShadowShape2DProvider get_shadowShape2DProvider() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000281")]
	public Vector3[] get_shapePath() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000282")]
	internal int get_shapePathHash() { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[Token(Token = "0x600028A")]
	internal int get_spriteMaterialCount() { }

	[Address(RVA = "0x2D3D110", Offset = "0x2D3C510", Length = "0x1C")]
	[Token(Token = "0x600027D")]
	public float get_trimEdge() { }

	[Address(RVA = "0x2D3D130", Offset = "0x2D3C530", Length = "0xE")]
	[Token(Token = "0x600028F")]
	public bool get_useRendererSilhouette() { }

	[Address(RVA = "0x2D3C720", Offset = "0x2D3BB20", Length = "0x71")]
	[Token(Token = "0x6000295")]
	internal bool IsLit(Light2D light) { }

	[Address(RVA = "0x2D3C7A0", Offset = "0x2D3BBA0", Length = "0x61")]
	[Token(Token = "0x6000296")]
	internal bool IsShadowedLayer(int layer) { }

	[Address(RVA = "0x2D3C810", Offset = "0x2D3BC10", Length = "0x61")]
	[Token(Token = "0x600029D")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2D3C880", Offset = "0x2D3BC80", Length = "0x8")]
	[Token(Token = "0x600029C")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2D3C890", Offset = "0x2D3BC90", Length = "0x4A")]
	[Token(Token = "0x600029A")]
	protected void OnDisable() { }

	[Address(RVA = "0x2D3C8E0", Offset = "0x2D3BCE0", Length = "0x4D")]
	[Token(Token = "0x6000299")]
	protected void OnEnable() { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x6000280")]
	public void set_alphaCutoff(float value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x600028C")]
	public void set_castingOption(ShadowCastingOptions value) { }

	[Address(RVA = "0x2D3D140", Offset = "0x2D3C540", Length = "0x3A")]
	[Token(Token = "0x6000292")]
	public void set_castsShadows(bool value) { }

	[Address(RVA = "0x2D3D180", Offset = "0x2D3C580", Length = "0x1A")]
	[Token(Token = "0x600027A")]
	internal void set_edgeProcessing(EdgeProcessing value) { }

	[Address(RVA = "0x2D3D1A0", Offset = "0x2D3C5A0", Length = "0x3B")]
	[Token(Token = "0x6000290")]
	public void set_selfShadows(bool value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x6000285")]
	internal void set_shadowCastingSource(ShadowCastingSources value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000287")]
	internal void set_shadowShape2DComponent(Component value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6000289")]
	internal void set_shadowShape2DProvider(ShadowShape2DProvider value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x6000283")]
	internal void set_shapePathHash(int value) { }

	[Address(RVA = "0x2D3D1E0", Offset = "0x2D3C5E0", Length = "0x1C")]
	[Token(Token = "0x600027E")]
	public void set_trimEdge(float value) { }

	[Address(RVA = "0x2911680", Offset = "0x2910A80", Length = "0x4")]
	[Token(Token = "0x600028E")]
	public void set_useRendererSilhouette(bool value) { }

	[Address(RVA = "0x2D3C930", Offset = "0x2D3BD30", Length = "0xD9")]
	[Token(Token = "0x6000294")]
	private static Int32[] SetDefaultSortingLayers() { }

	[Address(RVA = "0x2D3CA10", Offset = "0x2D3BE10", Length = "0x1D2")]
	[Token(Token = "0x6000297")]
	private void SetShadowShape(ShadowMesh2D shadowMesh) { }

	[Address(RVA = "0x2D3CBF0", Offset = "0x2D3BFF0", Length = "0x43E")]
	[Token(Token = "0x600029B")]
	public void Update() { }

}

