namespace TMPro;

[AddComponentMenu("Mesh/TextMeshPro - Text")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x2000017")]
public class TextMeshPro : TMP_Text, ILayoutElement
{
	[Token(Token = "0x400005B")]
	private static ProfilerMarker k_GenerateTextMarker; //Field offset: 0x0
	[Token(Token = "0x400005C")]
	private static ProfilerMarker k_SetArraySizesMarker; //Field offset: 0x8
	[Token(Token = "0x400005D")]
	private static ProfilerMarker k_GenerateTextPhaseIMarker; //Field offset: 0x10
	[Token(Token = "0x400005E")]
	private static ProfilerMarker k_ParseMarkupTextMarker; //Field offset: 0x18
	[Token(Token = "0x400005F")]
	private static ProfilerMarker k_CharacterLookupMarker; //Field offset: 0x20
	[Token(Token = "0x4000060")]
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; //Field offset: 0x28
	[Token(Token = "0x4000061")]
	private static ProfilerMarker k_CalculateVerticesPositionMarker; //Field offset: 0x30
	[Token(Token = "0x4000062")]
	private static ProfilerMarker k_ComputeTextMetricsMarker; //Field offset: 0x38
	[Token(Token = "0x4000063")]
	private static ProfilerMarker k_HandleVisibleCharacterMarker; //Field offset: 0x40
	[Token(Token = "0x4000064")]
	private static ProfilerMarker k_HandleWhiteSpacesMarker; //Field offset: 0x48
	[Token(Token = "0x4000065")]
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; //Field offset: 0x50
	[Token(Token = "0x4000066")]
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; //Field offset: 0x58
	[Token(Token = "0x4000067")]
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; //Field offset: 0x60
	[Token(Token = "0x4000068")]
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; //Field offset: 0x68
	[Token(Token = "0x4000069")]
	private static ProfilerMarker k_HandleCarriageReturnMarker; //Field offset: 0x70
	[Token(Token = "0x400006A")]
	private static ProfilerMarker k_HandleLineTerminationMarker; //Field offset: 0x78
	[Token(Token = "0x400006B")]
	private static ProfilerMarker k_SavePageInfoMarker; //Field offset: 0x80
	[Token(Token = "0x400006C")]
	private static ProfilerMarker k_SaveTextExtentMarker; //Field offset: 0x88
	[Token(Token = "0x400006D")]
	private static ProfilerMarker k_SaveProcessingStatesMarker; //Field offset: 0x90
	[Token(Token = "0x400006E")]
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; //Field offset: 0x98
	[Token(Token = "0x400006F")]
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; //Field offset: 0xA0
	[FieldOffset(Offset = "0x6F0")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	internal int _SortingLayer; //Field offset: 0x6F0
	[FieldOffset(Offset = "0x6F4")]
	[SerializeField]
	[Token(Token = "0x400004C")]
	internal int _SortingLayerID; //Field offset: 0x6F4
	[FieldOffset(Offset = "0x6F8")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	internal int _SortingOrder; //Field offset: 0x6F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x700")]
	[Token(Token = "0x400004E")]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x700
	[FieldOffset(Offset = "0x708")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private bool m_hasFontAssetChanged; //Field offset: 0x708
	[FieldOffset(Offset = "0x70C")]
	[Token(Token = "0x4000050")]
	private float m_previousLossyScaleY; //Field offset: 0x70C
	[FieldOffset(Offset = "0x710")]
	[SerializeField]
	[Token(Token = "0x4000051")]
	private Renderer m_renderer; //Field offset: 0x710
	[FieldOffset(Offset = "0x718")]
	[Token(Token = "0x4000052")]
	private MeshFilter m_meshFilter; //Field offset: 0x718
	[FieldOffset(Offset = "0x720")]
	[Token(Token = "0x4000053")]
	private bool m_isFirstAllocation; //Field offset: 0x720
	[FieldOffset(Offset = "0x724")]
	[Token(Token = "0x4000054")]
	private int m_max_characters; //Field offset: 0x724
	[FieldOffset(Offset = "0x728")]
	[Token(Token = "0x4000055")]
	private int m_max_numberOfLines; //Field offset: 0x728
	[FieldOffset(Offset = "0x730")]
	[Token(Token = "0x4000056")]
	private TMP_SubMesh[] m_subTextObjects; //Field offset: 0x730
	[FieldOffset(Offset = "0x738")]
	[SerializeField]
	[Token(Token = "0x4000057")]
	private MaskingTypes m_maskType; //Field offset: 0x738
	[FieldOffset(Offset = "0x73C")]
	[Token(Token = "0x4000058")]
	private Matrix4x4 m_EnvMapMatrix; //Field offset: 0x73C
	[FieldOffset(Offset = "0x780")]
	[Token(Token = "0x4000059")]
	private Vector3[] m_RectTransformCorners; //Field offset: 0x780
	[FieldOffset(Offset = "0x788")]
	[Token(Token = "0x400005A")]
	private bool m_isRegisteredForEvents; //Field offset: 0x788
	[FieldOffset(Offset = "0x790")]
	[Token(Token = "0x4000070")]
	private Dictionary<Int32, Int32> materialIndexPairs; //Field offset: 0x790

	[Token(Token = "0x14000001")]
	public virtual event Action<TMP_TextInfo> OnPreRenderText
	{
		[Address(RVA = "0x2EAD7E0", Offset = "0x2EACBE0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600008D")]
		 add { } //Length: 186
		[Address(RVA = "0x2EADD10", Offset = "0x2EAD110", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600008E")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x17000023")]
	public virtual bool autoSizeTextContainer
	{
		[Address(RVA = "0x2EA4D20", Offset = "0x2EA4120", Length = "0x8")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 8
		[Address(RVA = "0x2EADDD0", Offset = "0x2EAD1D0", Length = "0x81")]
		[Token(Token = "0x6000079")]
		 set { } //Length: 129
	}

	[Token(Token = "0x17000029")]
	public MaskingTypes maskType
	{
		[Address(RVA = "0x2EAD8A0", Offset = "0x2EACCA0", Length = "0x7")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 7
		[Address(RVA = "0x2EADE60", Offset = "0x2EAD260", Length = "0xE")]
		[Token(Token = "0x6000080")]
		 set { } //Length: 14
	}

	[Token(Token = "0x17000027")]
	public virtual Mesh mesh
	{
		[Address(RVA = "0x2EAD9E0", Offset = "0x2EACDE0", Length = "0xC1")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 193
	}

	[Token(Token = "0x17000028")]
	public MeshFilter meshFilter
	{
		[Address(RVA = "0x2EAD8B0", Offset = "0x2EACCB0", Length = "0x128")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 296
	}

	[Token(Token = "0x17000026")]
	public Renderer renderer
	{
		[Address(RVA = "0x2EADAB0", Offset = "0x2EACEB0", Length = "0x99")]
		[Token(Token = "0x600007C")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000021")]
	public int sortingLayerID
	{
		[Address(RVA = "0x2EADB50", Offset = "0x2EACF50", Length = "0x8B")]
		[Token(Token = "0x6000074")]
		 get { } //Length: 139
		[Address(RVA = "0x2EADE70", Offset = "0x2EAD270", Length = "0x1B1")]
		[Token(Token = "0x6000075")]
		 set { } //Length: 433
	}

	[Token(Token = "0x17000022")]
	public int sortingOrder
	{
		[Address(RVA = "0x2EADBE0", Offset = "0x2EACFE0", Length = "0x8B")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 139
		[Address(RVA = "0x2EAE030", Offset = "0x2EAD430", Length = "0x1B1")]
		[Token(Token = "0x6000077")]
		 set { } //Length: 433
	}

	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	[Token(Token = "0x17000024")]
	public TextContainer textContainer
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000025")]
	public Transform transform
	{
		[Address(RVA = "0x2EADC70", Offset = "0x2EAD070", Length = "0x99")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x2EAD1B0", Offset = "0x2EAC5B0", Length = "0x4FE")]
	[Token(Token = "0x60000C0")]
	private static TextMeshPro() { }

	[Address(RVA = "0x2EAD6B0", Offset = "0x2EACAB0", Length = "0x122")]
	[Token(Token = "0x60000BF")]
	public TextMeshPro() { }

	[Address(RVA = "0x2EAD7E0", Offset = "0x2EACBE0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600008D")]
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2EA4FD0", Offset = "0x2EA43D0", Length = "0x36F")]
	[Token(Token = "0x6000095")]
	protected virtual void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000093")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000094")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x2EA5340", Offset = "0x2EA4740", Length = "0xE3")]
	[Token(Token = "0x600008C")]
	public virtual void ClearMesh(bool updateMesh) { }

	[Address(RVA = "0x2EA5430", Offset = "0x2EA4830", Length = "0x172")]
	[Token(Token = "0x60000AF")]
	public virtual void ComputeMarginSize() { }

	[Address(RVA = "0x2EA55B0", Offset = "0x2EA49B0", Length = "0xD8")]
	[Token(Token = "0x60000AA")]
	private void CreateMaterialInstance() { }

	[Address(RVA = "0x2EA5690", Offset = "0x2EA4A90", Length = "0x109")]
	[Token(Token = "0x60000BA")]
	protected virtual void DestroySubMeshObjects() { }

	[Address(RVA = "0x2EA57A0", Offset = "0x2EA4BA0", Length = "0x247")]
	[Token(Token = "0x60000A0")]
	private void DisableMasking() { }

	[Address(RVA = "0x2EA59F0", Offset = "0x2EA4DF0", Length = "0x133")]
	[Token(Token = "0x600009F")]
	private void EnableMasking() { }

	[Address(RVA = "0x2EA5B30", Offset = "0x2EA4F30", Length = "0x14")]
	[Token(Token = "0x600008A")]
	public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[Address(RVA = "0x2E7FD50", Offset = "0x2E7F150", Length = "0x3F1C")]
	[Token(Token = "0x60000B5")]
	protected override void GenerateTextMesh() { }

	[Address(RVA = "0x2EA4D20", Offset = "0x2EA4120", Length = "0x8")]
	[Token(Token = "0x6000078")]
	public virtual bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x2EAD8A0", Offset = "0x2EACCA0", Length = "0x7")]
	[Token(Token = "0x600007F")]
	public MaskingTypes get_maskType() { }

	[Address(RVA = "0x2EAD9E0", Offset = "0x2EACDE0", Length = "0xC1")]
	[Token(Token = "0x600007D")]
	public virtual Mesh get_mesh() { }

	[Address(RVA = "0x2EAD8B0", Offset = "0x2EACCB0", Length = "0x128")]
	[Token(Token = "0x600007E")]
	public MeshFilter get_meshFilter() { }

	[Address(RVA = "0x2EADAB0", Offset = "0x2EACEB0", Length = "0x99")]
	[Token(Token = "0x600007C")]
	public Renderer get_renderer() { }

	[Address(RVA = "0x2EADB50", Offset = "0x2EACF50", Length = "0x8B")]
	[Token(Token = "0x6000074")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x2EADBE0", Offset = "0x2EACFE0", Length = "0x8B")]
	[Token(Token = "0x6000076")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600007A")]
	public TextContainer get_textContainer() { }

	[Address(RVA = "0x2EADC70", Offset = "0x2EAD070", Length = "0x99")]
	[Token(Token = "0x600007B")]
	public Transform get_transform() { }

	[Address(RVA = "0x2EA5B50", Offset = "0x2EA4F50", Length = "0x2EC")]
	[Token(Token = "0x60000BD")]
	protected virtual Bounds GetCompoundBounds() { }

	[Address(RVA = "0x2EA5E40", Offset = "0x2EA5240", Length = "0x13D")]
	[Token(Token = "0x60000A2")]
	protected virtual Material GetMaterial(Material mat) { }

	[Address(RVA = "0x2EA5F80", Offset = "0x2EA5380", Length = "0x241")]
	[Token(Token = "0x60000A3")]
	protected virtual Material[] GetMaterials(Material[] mats) { }

	[Address(RVA = "0x2EA61D0", Offset = "0x2EA55D0", Length = "0x213")]
	[Token(Token = "0x60000A5")]
	protected virtual Material[] GetSharedMaterials() { }

	[Address(RVA = "0x2EA63F0", Offset = "0x2EA57F0", Length = "0xA8")]
	[Token(Token = "0x60000B6")]
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	[Address(RVA = "0x2EA64A0", Offset = "0x2EA58A0", Length = "0x7D")]
	[Token(Token = "0x600008B")]
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	[Address(RVA = "0x2EA6520", Offset = "0x2EA5920", Length = "0xC9")]
	[Token(Token = "0x60000B3")]
	internal virtual void InternalUpdate() { }

	[Address(RVA = "0x2EA65F0", Offset = "0x2EA59F0", Length = "0x754")]
	[Token(Token = "0x6000099")]
	protected virtual void LoadFontAsset() { }

	[Address(RVA = "0x2EA6D50", Offset = "0x2EA6150", Length = "0xC2")]
	[Token(Token = "0x6000098")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2EA6E20", Offset = "0x2EA6220", Length = "0x22")]
	[Token(Token = "0x60000B0")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x2EA6E50", Offset = "0x2EA6250", Length = "0x9C")]
	[Token(Token = "0x6000097")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2EA6EF0", Offset = "0x2EA62F0", Length = "0xFA")]
	[Token(Token = "0x6000096")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2EA6FF0", Offset = "0x2EA63F0", Length = "0x3B4")]
	[Token(Token = "0x60000B4")]
	private void OnPreRenderObject() { }

	[Address(RVA = "0x2EA73B0", Offset = "0x2EA67B0", Length = "0x1E1")]
	[Token(Token = "0x60000B2")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2EA75A0", Offset = "0x2EA69A0", Length = "0x38")]
	[Token(Token = "0x60000B1")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x2EA75E0", Offset = "0x2EA69E0", Length = "0xDD")]
	[Token(Token = "0x6000087")]
	public virtual void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x2EADD10", Offset = "0x2EAD110", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600008E")]
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2EADDD0", Offset = "0x2EAD1D0", Length = "0x81")]
	[Token(Token = "0x6000079")]
	public virtual void set_autoSizeTextContainer(bool value) { }

	[Address(RVA = "0x2EADE60", Offset = "0x2EAD260", Length = "0xE")]
	[Token(Token = "0x6000080")]
	public void set_maskType(MaskingTypes value) { }

	[Address(RVA = "0x2EADE70", Offset = "0x2EAD270", Length = "0x1B1")]
	[Token(Token = "0x6000075")]
	public void set_sortingLayerID(int value) { }

	[Address(RVA = "0x2EAE030", Offset = "0x2EAD430", Length = "0x1B1")]
	[Token(Token = "0x6000077")]
	public void set_sortingOrder(int value) { }

	[Address(RVA = "0x2EA76C0", Offset = "0x2EA6AC0", Length = "0x137")]
	[Token(Token = "0x60000B8")]
	protected virtual void SetActiveSubMeshes(bool state) { }

	[Address(RVA = "0x2EA7800", Offset = "0x2EA6C00", Length = "0x16A")]
	[Token(Token = "0x60000B9")]
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	[Address(RVA = "0x2E9E800", Offset = "0x2E9DC00", Length = "0x4E")]
	[Token(Token = "0x6000086")]
	public virtual void SetAllDirty() { }

	[Address(RVA = "0x2EA7970", Offset = "0x2EA6D70", Length = "0x3133")]
	[Token(Token = "0x60000AE")]
	internal virtual int SetArraySizes(TextProcessingElement[] textProcessingArray) { }

	[Address(RVA = "0x2EAAAB0", Offset = "0x2EA9EB0", Length = "0x34F")]
	[Token(Token = "0x60000AC")]
	protected virtual void SetCulling() { }

	[Address(RVA = "0x2EAAE00", Offset = "0x2EAA200", Length = "0x189")]
	[Token(Token = "0x60000A8")]
	protected virtual void SetFaceColor(Color32 color) { }

	[Address(RVA = "0x2EAAF90", Offset = "0x2EAA390", Length = "0xC2")]
	[Token(Token = "0x6000084")]
	public virtual void SetLayoutDirty() { }

	[Address(RVA = "0x2EAB200", Offset = "0x2EAA600", Length = "0x94")]
	[Token(Token = "0x6000081")]
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	[Address(RVA = "0x2EAB450", Offset = "0x2EAA850", Length = "0x107")]
	[Token(Token = "0x6000082")]
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	[Address(RVA = "0x2EAB2A0", Offset = "0x2EAA6A0", Length = "0x1A3")]
	[Token(Token = "0x600009C")]
	private void SetMask(MaskingTypes maskType) { }

	[Address(RVA = "0x2EAB170", Offset = "0x2EAA570", Length = "0x8C")]
	[Token(Token = "0x600009D")]
	private void SetMaskCoordinates(Vector4 coords) { }

	[Address(RVA = "0x2EAB060", Offset = "0x2EAA460", Length = "0x109")]
	[Token(Token = "0x600009E")]
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	[Address(RVA = "0x1FCE300", Offset = "0x1FCD700", Length = "0x14")]
	[Token(Token = "0x6000085")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x2EAB560", Offset = "0x2EAA960", Length = "0x234")]
	[Token(Token = "0x60000B7")]
	private void SetMeshFilters(bool state) { }

	[Address(RVA = "0x2EAB7A0", Offset = "0x2EAABA0", Length = "0x189")]
	[Token(Token = "0x60000A9")]
	protected virtual void SetOutlineColor(Color32 color) { }

	[Address(RVA = "0x2EAB930", Offset = "0x2EAAD30", Length = "0x185")]
	[Token(Token = "0x60000A7")]
	protected virtual void SetOutlineThickness(float thickness) { }

	[Address(RVA = "0x2EABAC0", Offset = "0x2EAAEC0", Length = "0xB5")]
	[Token(Token = "0x60000AD")]
	private void SetPerspectiveCorrection() { }

	[Address(RVA = "0x2EABB80", Offset = "0x2EAAF80", Length = "0x3C")]
	[Token(Token = "0x60000AB")]
	protected virtual void SetShaderDepth() { }

	[Address(RVA = "0x2EA2840", Offset = "0x2EA1C40", Length = "0x56")]
	[Token(Token = "0x60000A4")]
	protected virtual void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x2EABBC0", Offset = "0x2EAAFC0", Length = "0x45B")]
	[Token(Token = "0x60000A6")]
	protected virtual void SetSharedMaterials(Material[] materials) { }

	[Address(RVA = "0x2EAC020", Offset = "0x2EAB420", Length = "0xA5")]
	[Token(Token = "0x6000083")]
	public virtual void SetVerticesDirty() { }

	[Address(RVA = "0x2EAC0D0", Offset = "0x2EAB4D0", Length = "0x2E4")]
	[Token(Token = "0x600009B")]
	private void UpdateEnvMapMatrix() { }

	[Address(RVA = "0x2EA34A0", Offset = "0x2EA28A0", Length = "0x14")]
	[Token(Token = "0x6000092")]
	public void UpdateFontAsset() { }

	[Address(RVA = "0x2EAC3C0", Offset = "0x2EAB7C0", Length = "0x1F")]
	[Token(Token = "0x600008F")]
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	[Address(RVA = "0x2EAC3E0", Offset = "0x2EAB7E0", Length = "0x134")]
	[Token(Token = "0x60000A1")]
	private void UpdateMask() { }

	[Address(RVA = "0x2EAC520", Offset = "0x2EAB920", Length = "0x137")]
	[Token(Token = "0x6000088")]
	protected virtual void UpdateMaterial() { }

	[Address(RVA = "0x2EAC660", Offset = "0x2EABA60", Length = "0x123")]
	[Token(Token = "0x6000089")]
	public virtual void UpdateMeshPadding() { }

	[Address(RVA = "0x2EAC790", Offset = "0x2EABB90", Length = "0x20C")]
	[Token(Token = "0x60000BE")]
	private void UpdateSDFScale(float scaleDelta) { }

	[Address(RVA = "0x2EAC9A0", Offset = "0x2EABDA0", Length = "0x143")]
	[Token(Token = "0x60000BB")]
	internal void UpdateSubMeshSortingLayerID(int id) { }

	[Address(RVA = "0x2EACAF0", Offset = "0x2EABEF0", Length = "0x143")]
	[Token(Token = "0x60000BC")]
	internal void UpdateSubMeshSortingOrder(int order) { }

	[Address(RVA = "0x2EACC40", Offset = "0x2EAC040", Length = "0x1E8")]
	[Token(Token = "0x6000090")]
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[Address(RVA = "0x2EACE30", Offset = "0x2EAC230", Length = "0x22C")]
	[Token(Token = "0x6000091")]
	public virtual void UpdateVertexData() { }

	[Address(RVA = "0x2EAD060", Offset = "0x2EAC460", Length = "0x14D")]
	[Token(Token = "0x600009A")]
	private void ValidateEnvMapProperty() { }

}

