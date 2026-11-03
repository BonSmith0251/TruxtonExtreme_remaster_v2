namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200001E")]
public abstract class Graphic : UIBehaviour, ICanvasElement
{
	[Token(Token = "0x400006D")]
	protected static Material s_DefaultUI; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	protected static Texture2D s_WhiteTexture; //Field offset: 0x8
	[Token(Token = "0x400007E")]
	protected static Mesh s_Mesh; //Field offset: 0x10
	[Token(Token = "0x400007F")]
	private static readonly VertexHelper s_VertexHelper; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	[Token(Token = "0x400006F")]
	protected Material m_Material; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000070")]
	private Color m_Color; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000071")]
	protected bool m_SkipLayoutUpdate; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000072")]
	protected bool m_SkipMaterialUpdate; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	private bool m_RaycastTarget; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000074")]
	private bool m_RaycastTargetCache; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	private Vector4 m_RaycastPadding; //Field offset: 0x3C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000076")]
	private RectTransform m_RectTransform; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000077")]
	private CanvasRenderer m_CanvasRenderer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000078")]
	private Canvas m_Canvas; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000079")]
	private bool m_VertsDirty; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400007A")]
	private bool m_MaterialDirty; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400007B")]
	protected UnityAction m_OnDirtyLayoutCallback; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400007C")]
	protected UnityAction m_OnDirtyVertsCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400007D")]
	protected UnityAction m_OnDirtyMaterialCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000080")]
	protected Mesh m_CachedMesh; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000081")]
	protected Vector2[] m_CachedUvs; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000082")]
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000083")]
	private bool <useLegacyMeshGeneration>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x1700003C")]
	public Canvas canvas
	{
		[Address(RVA = "0x31E3180", Offset = "0x31E2580", Length = "0x6C")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 108
	}

	[Token(Token = "0x1700003D")]
	public CanvasRenderer canvasRenderer
	{
		[Address(RVA = "0x31E30E0", Offset = "0x31E24E0", Length = "0x9B")]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000036")]
	public override Color color
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 11
		[Address(RVA = "0x31E38B0", Offset = "0x31E2CB0", Length = "0x48")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 72
	}

	[Token(Token = "0x17000035")]
	public static Material defaultGraphicMaterial
	{
		[Address(RVA = "0x31E31F0", Offset = "0x31E25F0", Length = "0xF2")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 242
	}

	[Token(Token = "0x1700003E")]
	public override Material defaultMaterial
	{
		[Address(RVA = "0x31E32F0", Offset = "0x31E26F0", Length = "0x120")]
		[Token(Token = "0x60000FA")]
		 get { } //Length: 288
	}

	[Token(Token = "0x1700003A")]
	public int depth
	{
		[Address(RVA = "0x31E3410", Offset = "0x31E2810", Length = "0x23")]
		[Token(Token = "0x60000F5")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000041")]
	public override Texture mainTexture
	{
		[Address(RVA = "0x31E3440", Offset = "0x31E2840", Length = "0x4F")]
		[Token(Token = "0x60000FE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700003F")]
	public override Material material
	{
		[Address(RVA = "0x31E3660", Offset = "0x31E2A60", Length = "0x83")]
		[Token(Token = "0x60000FB")]
		 get { } //Length: 131
		[Address(RVA = "0x31E3900", Offset = "0x31E2D00", Length = "0x92")]
		[Token(Token = "0x60000FC")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000040")]
	public override Material materialForRendering
	{
		[Address(RVA = "0x31E3490", Offset = "0x31E2890", Length = "0x1CF")]
		[Token(Token = "0x60000FD")]
		 get { } //Length: 463
	}

	[Token(Token = "0x17000038")]
	public Vector4 raycastPadding
	{
		[Address(RVA = "0x31E36F0", Offset = "0x31E2AF0", Length = "0xB")]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 11
		[Address(RVA = "0x31E39A0", Offset = "0x31E2DA0", Length = "0x8")]
		[Token(Token = "0x60000E9")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000037")]
	public override bool raycastTarget
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
		[Address(RVA = "0x31E39B0", Offset = "0x31E2DB0", Length = "0xDB")]
		[Token(Token = "0x60000E7")]
		 set { } //Length: 219
	}

	[Token(Token = "0x1700003B")]
	public override RectTransform rectTransform
	{
		[Address(RVA = "0x31E3700", Offset = "0x31E2B00", Length = "0x55")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000039")]
	protected bool useLegacyMeshGeneration
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60000EB")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000042")]
	protected static Mesh workerMesh
	{
		[Address(RVA = "0x31E3760", Offset = "0x31E2B60", Length = "0x14F")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 335
	}

	[Address(RVA = "0x31E2F40", Offset = "0x31E2340", Length = "0xCB")]
	[Token(Token = "0x600011F")]
	private static Graphic() { }

	[Address(RVA = "0x31E3010", Offset = "0x31E2410", Length = "0xCF")]
	[Token(Token = "0x60000EC")]
	protected Graphic() { }

	[Address(RVA = "0x31DFF60", Offset = "0x31DF360", Length = "0x17F")]
	[Token(Token = "0x60000F8")]
	private void CacheCanvas() { }

	[Address(RVA = "0x31E00E0", Offset = "0x31DF4E0", Length = "0x14")]
	[Token(Token = "0x6000117")]
	private static Color CreateColorFromAlpha(float alpha) { }

	[Address(RVA = "0x31E0100", Offset = "0x31DF500", Length = "0xC9")]
	[Token(Token = "0x6000118")]
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x31E01D0", Offset = "0x31DF5D0", Length = "0x2F1")]
	[Token(Token = "0x6000116")]
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	[Address(RVA = "0x31E04D0", Offset = "0x31DF8D0", Length = "0x40")]
	[Token(Token = "0x6000115")]
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x31E0510", Offset = "0x31DF910", Length = "0x536")]
	[Token(Token = "0x600010A")]
	private void DoLegacyMeshGeneration() { }

	[Address(RVA = "0x31E0A50", Offset = "0x31DFE50", Length = "0x58A")]
	[Token(Token = "0x6000109")]
	private void DoMeshGeneration() { }

	[Address(RVA = "0x31E3180", Offset = "0x31E2580", Length = "0x6C")]
	[Token(Token = "0x60000F7")]
	public Canvas get_canvas() { }

	[Address(RVA = "0x31E30E0", Offset = "0x31E24E0", Length = "0x9B")]
	[Token(Token = "0x60000F9")]
	public CanvasRenderer get_canvasRenderer() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x60000E4")]
	public override Color get_color() { }

	[Address(RVA = "0x31E31F0", Offset = "0x31E25F0", Length = "0xF2")]
	[Token(Token = "0x60000E3")]
	public static Material get_defaultGraphicMaterial() { }

	[Address(RVA = "0x31E32F0", Offset = "0x31E26F0", Length = "0x120")]
	[Token(Token = "0x60000FA")]
	public override Material get_defaultMaterial() { }

	[Address(RVA = "0x31E3410", Offset = "0x31E2810", Length = "0x23")]
	[Token(Token = "0x60000F5")]
	public int get_depth() { }

	[Address(RVA = "0x31E3440", Offset = "0x31E2840", Length = "0x4F")]
	[Token(Token = "0x60000FE")]
	public override Texture get_mainTexture() { }

	[Address(RVA = "0x31E3660", Offset = "0x31E2A60", Length = "0x83")]
	[Token(Token = "0x60000FB")]
	public override Material get_material() { }

	[Address(RVA = "0x31E3490", Offset = "0x31E2890", Length = "0x1CF")]
	[Token(Token = "0x60000FD")]
	public override Material get_materialForRendering() { }

	[Address(RVA = "0x31E36F0", Offset = "0x31E2AF0", Length = "0xB")]
	[Token(Token = "0x60000E8")]
	public Vector4 get_raycastPadding() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x60000E6")]
	public override bool get_raycastTarget() { }

	[Address(RVA = "0x31E3700", Offset = "0x31E2B00", Length = "0x55")]
	[Token(Token = "0x60000F6")]
	public override RectTransform get_rectTransform() { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000EA")]
	protected bool get_useLegacyMeshGeneration() { }

	[Address(RVA = "0x31E3760", Offset = "0x31E2B60", Length = "0x14F")]
	[Token(Token = "0x600010B")]
	protected static Mesh get_workerMesh() { }

	[Address(RVA = "0x31E0FE0", Offset = "0x31E03E0", Length = "0x1E0")]
	[Token(Token = "0x6000114")]
	public Rect GetPixelAdjustedRect() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000106")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000105")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x31E11D0", Offset = "0x31E05D0", Length = "0x11B")]
	[Token(Token = "0x60000F3")]
	protected virtual void OnBeforeTransformParentChanged() { }

	[Address(RVA = "0x31E12F0", Offset = "0x31E06F0", Length = "0x152")]
	[Token(Token = "0x6000102")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x31E1450", Offset = "0x31E0850", Length = "0xC0")]
	[Token(Token = "0x6000103")]
	public override void OnCullingChanged() { }

	[Address(RVA = "0x31E1520", Offset = "0x31E0920", Length = "0x154")]
	[Token(Token = "0x6000101")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x259F1C0", Offset = "0x259E5C0", Length = "0x14")]
	[Token(Token = "0x600010F")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x31E1680", Offset = "0x31E0A80", Length = "0x1B1")]
	[Token(Token = "0x6000100")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x31E1840", Offset = "0x31E0C40", Length = "0x188")]
	[Token(Token = "0x60000FF")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	[Token(Token = "0x600010C")]
	protected override void OnFillVBO(List<UIVertex> vbo) { }

	[Address(RVA = "0x31E1A70", Offset = "0x31E0E70", Length = "0x237")]
	[Token(Token = "0x600010E")]
	protected override void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x31E19D0", Offset = "0x31E0DD0", Length = "0x9D")]
	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	[Token(Token = "0x600010D")]
	protected override void OnPopulateMesh(Mesh m) { }

	[Address(RVA = "0x31E1CB0", Offset = "0x31E10B0", Length = "0xE8")]
	[Token(Token = "0x60000F2")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x31E1DA0", Offset = "0x31E11A0", Length = "0xBC")]
	[Token(Token = "0x60000F4")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x31E1E60", Offset = "0x31E1260", Length = "0x18F")]
	[Token(Token = "0x6000113")]
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	[Address(RVA = "0x31E2580", Offset = "0x31E1980", Length = "0x1A")]
	[Token(Token = "0x6000111")]
	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x31E1FF0", Offset = "0x31E13F0", Length = "0x584")]
	[Token(Token = "0x6000112")]
	protected bool Raycast(Vector2 sp, Camera eventCamera, bool ignoreMasks) { }

	[Address(RVA = "0x31E25A0", Offset = "0x31E19A0", Length = "0xD9")]
	[Token(Token = "0x6000104")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x31E2680", Offset = "0x31E1A80", Length = "0x9F")]
	[Token(Token = "0x6000119")]
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	[Address(RVA = "0x31E2720", Offset = "0x31E1B20", Length = "0xAB")]
	[Token(Token = "0x600011D")]
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	[Address(RVA = "0x31E27D0", Offset = "0x31E1BD0", Length = "0x9F")]
	[Token(Token = "0x600011B")]
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	[Address(RVA = "0x31E38B0", Offset = "0x31E2CB0", Length = "0x48")]
	[Token(Token = "0x60000E5")]
	public override void set_color(Color value) { }

	[Address(RVA = "0x31E3900", Offset = "0x31E2D00", Length = "0x92")]
	[Token(Token = "0x60000FC")]
	public override void set_material(Material value) { }

	[Address(RVA = "0x31E39A0", Offset = "0x31E2DA0", Length = "0x8")]
	[Token(Token = "0x60000E9")]
	public void set_raycastPadding(Vector4 value) { }

	[Address(RVA = "0x31E39B0", Offset = "0x31E2DB0", Length = "0xDB")]
	[Token(Token = "0x60000E7")]
	public override void set_raycastTarget(bool value) { }

	[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60000EB")]
	protected void set_useLegacyMeshGeneration(bool value) { }

	[Address(RVA = "0x31E2870", Offset = "0x31E1C70", Length = "0x6F")]
	[Token(Token = "0x60000ED")]
	public override void SetAllDirty() { }

	[Address(RVA = "0x31E28E0", Offset = "0x31E1CE0", Length = "0xD7")]
	[Token(Token = "0x60000EE")]
	public override void SetLayoutDirty() { }

	[Address(RVA = "0x31E29C0", Offset = "0x31E1DC0", Length = "0xD7")]
	[Token(Token = "0x60000F0")]
	public override void SetMaterialDirty() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000110")]
	public override void SetNativeSize() { }

	[Address(RVA = "0x31E2AA0", Offset = "0x31E1EA0", Length = "0xD3")]
	[Token(Token = "0x60000F1")]
	public void SetRaycastDirty() { }

	[Address(RVA = "0x31E2B80", Offset = "0x31E1F80", Length = "0xD1")]
	[Token(Token = "0x60000EF")]
	public override void SetVerticesDirty() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x6000120")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x31E2C60", Offset = "0x31E2060", Length = "0x9F")]
	[Token(Token = "0x600011A")]
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	[Address(RVA = "0x31E2D00", Offset = "0x31E2100", Length = "0xAB")]
	[Token(Token = "0x600011E")]
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	[Address(RVA = "0x31E2DB0", Offset = "0x31E21B0", Length = "0x9F")]
	[Token(Token = "0x600011C")]
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	[Address(RVA = "0x31E2E50", Offset = "0x31E2250", Length = "0x15")]
	[Token(Token = "0x6000108")]
	protected override void UpdateGeometry() { }

	[Address(RVA = "0x31E2E70", Offset = "0x31E2270", Length = "0xCD")]
	[Token(Token = "0x6000107")]
	protected override void UpdateMaterial() { }

}

