namespace TMPro;

[AddComponentMenu("UI (Canvas)/TextMeshPro - Text (UI)", 11)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000018")]
public class TextMeshProUGUI : TMP_Text, ILayoutElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private sealed class <DelayedGraphicRebuild>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400009C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400009D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400009E")]
		public TextMeshProUGUI <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700002F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600010E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000030")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000110")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600010B")]
		public <DelayedGraphicRebuild>d__18(int <>1__state) { }

		[Address(RVA = "0x2EC5290", Offset = "0x2EC4690", Length = "0xD6")]
		[Token(Token = "0x600010D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600010E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000110")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2EC5370", Offset = "0x2EC4770", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600010F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600010C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <DelayedMaterialRebuild>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400009F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A1")]
		public TextMeshProUGUI <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000031")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000114")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000116")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000111")]
		public <DelayedMaterialRebuild>d__19(int <>1__state) { }

		[Address(RVA = "0x2EC53B0", Offset = "0x2EC47B0", Length = "0xE2")]
		[Token(Token = "0x6000113")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000114")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000116")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2EC54A0", Offset = "0x2EC48A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000115")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000112")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000086")]
	private static ProfilerMarker k_GenerateTextMarker; //Field offset: 0x0
	[Token(Token = "0x4000087")]
	private static ProfilerMarker k_SetArraySizesMarker; //Field offset: 0x8
	[Token(Token = "0x4000088")]
	private static ProfilerMarker k_GenerateTextPhaseIMarker; //Field offset: 0x10
	[Token(Token = "0x4000089")]
	private static ProfilerMarker k_ParseMarkupTextMarker; //Field offset: 0x18
	[Token(Token = "0x400008A")]
	private static ProfilerMarker k_CharacterLookupMarker; //Field offset: 0x20
	[Token(Token = "0x400008B")]
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; //Field offset: 0x28
	[Token(Token = "0x400008C")]
	private static ProfilerMarker k_CalculateVerticesPositionMarker; //Field offset: 0x30
	[Token(Token = "0x400008D")]
	private static ProfilerMarker k_ComputeTextMetricsMarker; //Field offset: 0x38
	[Token(Token = "0x400008E")]
	private static ProfilerMarker k_HandleVisibleCharacterMarker; //Field offset: 0x40
	[Token(Token = "0x400008F")]
	private static ProfilerMarker k_HandleWhiteSpacesMarker; //Field offset: 0x48
	[Token(Token = "0x4000090")]
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; //Field offset: 0x50
	[Token(Token = "0x4000091")]
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; //Field offset: 0x58
	[Token(Token = "0x4000092")]
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; //Field offset: 0x60
	[Token(Token = "0x4000093")]
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; //Field offset: 0x68
	[Token(Token = "0x4000094")]
	private static ProfilerMarker k_HandleCarriageReturnMarker; //Field offset: 0x70
	[Token(Token = "0x4000095")]
	private static ProfilerMarker k_HandleLineTerminationMarker; //Field offset: 0x78
	[Token(Token = "0x4000096")]
	private static ProfilerMarker k_SavePageInfoMarker; //Field offset: 0x80
	[Token(Token = "0x4000097")]
	private static ProfilerMarker k_SaveTextExtentMarker; //Field offset: 0x88
	[Token(Token = "0x4000098")]
	private static ProfilerMarker k_SaveProcessingStatesMarker; //Field offset: 0x90
	[Token(Token = "0x4000099")]
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; //Field offset: 0x98
	[Token(Token = "0x400009A")]
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; //Field offset: 0xA0
	[FieldOffset(Offset = "0x6F0")]
	[Token(Token = "0x4000071")]
	private bool m_isRebuildingLayout; //Field offset: 0x6F0
	[FieldOffset(Offset = "0x6F8")]
	[Token(Token = "0x4000072")]
	private Coroutine m_DelayedGraphicRebuild; //Field offset: 0x6F8
	[FieldOffset(Offset = "0x700")]
	[Token(Token = "0x4000073")]
	private Coroutine m_DelayedMaterialRebuild; //Field offset: 0x700
	[FieldOffset(Offset = "0x708")]
	[Token(Token = "0x4000074")]
	private bool m_ShouldUpdateCulling; //Field offset: 0x708
	[FieldOffset(Offset = "0x70C")]
	[Token(Token = "0x4000075")]
	private Rect m_ClipRect; //Field offset: 0x70C
	[FieldOffset(Offset = "0x71C")]
	[Token(Token = "0x4000076")]
	private bool m_ValidRect; //Field offset: 0x71C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x720")]
	[Token(Token = "0x4000077")]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x720
	[FieldOffset(Offset = "0x728")]
	[SerializeField]
	[Token(Token = "0x4000078")]
	private bool m_hasFontAssetChanged; //Field offset: 0x728
	[FieldOffset(Offset = "0x730")]
	[Token(Token = "0x4000079")]
	protected TMP_SubMeshUI[] m_subTextObjects; //Field offset: 0x730
	[FieldOffset(Offset = "0x738")]
	[Token(Token = "0x400007A")]
	private float m_previousLossyScaleY; //Field offset: 0x738
	[FieldOffset(Offset = "0x740")]
	[Token(Token = "0x400007B")]
	private Vector3[] m_RectTransformCorners; //Field offset: 0x740
	[FieldOffset(Offset = "0x748")]
	[Token(Token = "0x400007C")]
	private CanvasRenderer m_canvasRenderer; //Field offset: 0x748
	[FieldOffset(Offset = "0x750")]
	[Token(Token = "0x400007D")]
	private Canvas m_canvas; //Field offset: 0x750
	[FieldOffset(Offset = "0x758")]
	[Token(Token = "0x400007E")]
	private float m_CanvasScaleFactor; //Field offset: 0x758
	[FieldOffset(Offset = "0x75C")]
	[Token(Token = "0x400007F")]
	private bool m_isFirstAllocation; //Field offset: 0x75C
	[FieldOffset(Offset = "0x760")]
	[Token(Token = "0x4000080")]
	private int m_max_characters; //Field offset: 0x760
	[FieldOffset(Offset = "0x768")]
	[SerializeField]
	[Token(Token = "0x4000081")]
	private Material m_baseMaterial; //Field offset: 0x768
	[FieldOffset(Offset = "0x770")]
	[Token(Token = "0x4000082")]
	private bool m_isScrollRegionSet; //Field offset: 0x770
	[FieldOffset(Offset = "0x774")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private Vector4 m_maskOffset; //Field offset: 0x774
	[FieldOffset(Offset = "0x784")]
	[Token(Token = "0x4000084")]
	private Matrix4x4 m_EnvMapMatrix; //Field offset: 0x784
	[FieldOffset(Offset = "0x7C4")]
	[Token(Token = "0x4000085")]
	private bool m_isRegisteredForEvents; //Field offset: 0x7C4
	[FieldOffset(Offset = "0x7C8")]
	[Token(Token = "0x400009B")]
	private Dictionary<Int32, Int32> materialIndexPairs; //Field offset: 0x7C8

	[Token(Token = "0x14000002")]
	public virtual event Action<TMP_TextInfo> OnPreRenderText
	{
		[Address(RVA = "0x2EA4C60", Offset = "0x2EA4060", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 add { } //Length: 186
		[Address(RVA = "0x2EA4E50", Offset = "0x2EA4250", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1700002B")]
	public virtual bool autoSizeTextContainer
	{
		[Address(RVA = "0x2EA4D20", Offset = "0x2EA4120", Length = "0x8")]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 8
		[Address(RVA = "0x2EA4F10", Offset = "0x2EA4310", Length = "0x81")]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700002D")]
	public CanvasRenderer canvasRenderer
	{
		[Address(RVA = "0x2EA4D30", Offset = "0x2EA4130", Length = "0x99")]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 153
	}

	[Token(Token = "0x1700002E")]
	public Vector4 maskOffset
	{
		[Address(RVA = "0x2EA4DD0", Offset = "0x2EA41D0", Length = "0xE")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 14
		[Address(RVA = "0x2EA4FA0", Offset = "0x2EA43A0", Length = "0x27")]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700002A")]
	public virtual Material materialForRendering
	{
		[Address(RVA = "0x2EA4DE0", Offset = "0x2EA41E0", Length = "0x5D")]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700002C")]
	public virtual Mesh mesh
	{
		[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2EA4640", Offset = "0x2EA3A40", Length = "0x4FE")]
	[Token(Token = "0x600010A")]
	private static TextMeshProUGUI() { }

	[Address(RVA = "0x2EA4B40", Offset = "0x2EA3F40", Length = "0x118")]
	[Token(Token = "0x6000109")]
	public TextMeshProUGUI() { }

	[Address(RVA = "0x2EA4C60", Offset = "0x2EA4060", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2E9AFD0", Offset = "0x2E9A3D0", Length = "0x32A")]
	[Token(Token = "0x60000E3")]
	protected virtual void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C6")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C7")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x2E9B300", Offset = "0x2E9A700", Length = "0x128")]
	[Token(Token = "0x60000DC")]
	public virtual void ClearMesh() { }

	[Address(RVA = "0x2E9B430", Offset = "0x2E9A830", Length = "0x172")]
	[Token(Token = "0x60000FB")]
	public virtual void ComputeMarginSize() { }

	[Address(RVA = "0x2E9B5B0", Offset = "0x2E9A9B0", Length = "0x33F")]
	[Token(Token = "0x60000D5")]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x2E9B8F0", Offset = "0x2E9ACF0", Length = "0x6D")]
	[IteratorStateMachine(typeof(<DelayedGraphicRebuild>d__18))]
	[Token(Token = "0x60000CC")]
	private IEnumerator DelayedGraphicRebuild() { }

	[Address(RVA = "0x2E9B960", Offset = "0x2E9AD60", Length = "0x6D")]
	[IteratorStateMachine(typeof(<DelayedMaterialRebuild>d__19))]
	[Token(Token = "0x60000CD")]
	private IEnumerator DelayedMaterialRebuild() { }

	[Address(RVA = "0x2E9B9D0", Offset = "0x2E9ADD0", Length = "0x109")]
	[Token(Token = "0x6000105")]
	protected virtual void DestroySubMeshObjects() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000EC")]
	private void DisableMasking() { }

	[Address(RVA = "0x2E9BAE0", Offset = "0x2E9AEE0", Length = "0x23C")]
	[Token(Token = "0x60000EB")]
	private void EnableMasking() { }

	[Address(RVA = "0x2E9BD20", Offset = "0x2E9B120", Length = "0xAC")]
	[Token(Token = "0x60000DA")]
	public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[Address(RVA = "0x2E8BE00", Offset = "0x2E8B200", Length = "0xC2C4")]
	[Token(Token = "0x6000102")]
	protected override void GenerateTextMesh() { }

	[Address(RVA = "0x2EA4D20", Offset = "0x2EA4120", Length = "0x8")]
	[Token(Token = "0x60000C2")]
	public virtual bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x2EA4D30", Offset = "0x2EA4130", Length = "0x99")]
	[Token(Token = "0x60000C5")]
	public CanvasRenderer get_canvasRenderer() { }

	[Address(RVA = "0x2EA4DD0", Offset = "0x2EA41D0", Length = "0xE")]
	[Token(Token = "0x60000D2")]
	public Vector4 get_maskOffset() { }

	[Address(RVA = "0x2EA4DE0", Offset = "0x2EA41E0", Length = "0x5D")]
	[Token(Token = "0x60000C1")]
	public virtual Material get_materialForRendering() { }

	[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
	[Token(Token = "0x60000C4")]
	public virtual Mesh get_mesh() { }

	[Address(RVA = "0x2E9C090", Offset = "0x2E9B490", Length = "0x147")]
	[Token(Token = "0x60000E8")]
	private Canvas GetCanvas() { }

	[Address(RVA = "0x2E9BDD0", Offset = "0x2E9B1D0", Length = "0x2B5")]
	[Token(Token = "0x6000107")]
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	[Address(RVA = "0x2E9C1E0", Offset = "0x2E9B5E0", Length = "0x2EC")]
	[Token(Token = "0x6000106")]
	protected virtual Bounds GetCompoundBounds() { }

	[Address(RVA = "0x2E9C4D0", Offset = "0x2E9B8D0", Length = "0x16C")]
	[Token(Token = "0x60000EE")]
	protected virtual Material GetMaterial(Material mat) { }

	[Address(RVA = "0x2E9C640", Offset = "0x2E9BA40", Length = "0x24D")]
	[Token(Token = "0x60000EF")]
	protected virtual Material[] GetMaterials(Material[] mats) { }

	[Address(RVA = "0x2E9C890", Offset = "0x2E9BC90", Length = "0x153")]
	[Token(Token = "0x60000D0")]
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x2E9C9F0", Offset = "0x2E9BDF0", Length = "0x216")]
	[Token(Token = "0x60000F1")]
	protected virtual Material[] GetSharedMaterials() { }

	[Address(RVA = "0x2E9CC10", Offset = "0x2E9C010", Length = "0xA8")]
	[Token(Token = "0x6000103")]
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	[Address(RVA = "0x2E9CCC0", Offset = "0x2E9C0C0", Length = "0xF8")]
	[Token(Token = "0x60000DB")]
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	[Address(RVA = "0x2E9CDC0", Offset = "0x2E9C1C0", Length = "0xDE")]
	[Token(Token = "0x60000D9")]
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x2E9CEA0", Offset = "0x2E9C2A0", Length = "0x110")]
	[Token(Token = "0x60000D8")]
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x2E9CFC0", Offset = "0x2E9C3C0", Length = "0xC9")]
	[Token(Token = "0x6000100")]
	internal virtual void InternalUpdate() { }

	[Address(RVA = "0x2E9D090", Offset = "0x2E9C490", Length = "0x725")]
	[Token(Token = "0x60000E7")]
	protected virtual void LoadFontAsset() { }

	[Address(RVA = "0x2E9D7C0", Offset = "0x2E9CBC0", Length = "0x124")]
	[Token(Token = "0x60000FD")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x2E9D8F0", Offset = "0x2E9CCF0", Length = "0x167")]
	[Token(Token = "0x60000E6")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2E9DA60", Offset = "0x2E9CE60", Length = "0x3F")]
	[Token(Token = "0x60000FC")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x2E9DAA0", Offset = "0x2E9CEA0", Length = "0x189")]
	[Token(Token = "0x60000E5")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2E9DC30", Offset = "0x2E9D030", Length = "0x270")]
	[Token(Token = "0x60000E4")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2E9DEB0", Offset = "0x2E9D2B0", Length = "0x2B7")]
	[Token(Token = "0x6000101")]
	private void OnPreRenderCanvas() { }

	[Address(RVA = "0x2E9E170", Offset = "0x2E9D570", Length = "0x3F4")]
	[Token(Token = "0x60000FF")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2E9E570", Offset = "0x2E9D970", Length = "0x53")]
	[Token(Token = "0x60000FE")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x2E9E5D0", Offset = "0x2E9D9D0", Length = "0xDD")]
	[Token(Token = "0x60000CE")]
	public virtual void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x2E9E6B0", Offset = "0x2E9DAB0", Length = "0x7")]
	[Token(Token = "0x60000D4")]
	public virtual void RecalculateClipping() { }

	[Address(RVA = "0x2EA4E50", Offset = "0x2EA4250", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x2EA4F10", Offset = "0x2EA4310", Length = "0x81")]
	[Token(Token = "0x60000C3")]
	public virtual void set_autoSizeTextContainer(bool value) { }

	[Address(RVA = "0x2EA4FA0", Offset = "0x2EA43A0", Length = "0x27")]
	[Token(Token = "0x60000D3")]
	public void set_maskOffset(Vector4 value) { }

	[Address(RVA = "0x2E9E6C0", Offset = "0x2E9DAC0", Length = "0x137")]
	[Token(Token = "0x6000104")]
	protected virtual void SetActiveSubMeshes(bool state) { }

	[Address(RVA = "0x2E9E800", Offset = "0x2E9DC00", Length = "0x4E")]
	[Token(Token = "0x60000CB")]
	public virtual void SetAllDirty() { }

	[Address(RVA = "0x2E9E850", Offset = "0x2E9DC50", Length = "0x32E1")]
	[Token(Token = "0x60000FA")]
	internal virtual int SetArraySizes(TextProcessingElement[] textProcessingArray) { }

	[Address(RVA = "0x2EA1B40", Offset = "0x2EA0F40", Length = "0x392")]
	[Token(Token = "0x60000F7")]
	protected virtual void SetCulling() { }

	[Address(RVA = "0x2EA1EE0", Offset = "0x2EA12E0", Length = "0x19B")]
	[Token(Token = "0x60000F4")]
	protected virtual void SetFaceColor(Color32 color) { }

	[Address(RVA = "0x2EA2080", Offset = "0x2EA1480", Length = "0xDB")]
	[Token(Token = "0x60000C9")]
	public virtual void SetLayoutDirty() { }

	[Address(RVA = "0x2EA2160", Offset = "0x2EA1560", Length = "0xDC")]
	[Token(Token = "0x60000CA")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x2EA2240", Offset = "0x2EA1640", Length = "0xBB")]
	[Token(Token = "0x60000F9")]
	private void SetMeshArrays(int size) { }

	[Address(RVA = "0x2EA2300", Offset = "0x2EA1700", Length = "0x19B")]
	[Token(Token = "0x60000F5")]
	protected virtual void SetOutlineColor(Color32 color) { }

	[Address(RVA = "0x2EA24A0", Offset = "0x2EA18A0", Length = "0x227")]
	[Token(Token = "0x60000F3")]
	protected virtual void SetOutlineThickness(float thickness) { }

	[Address(RVA = "0x2EA26D0", Offset = "0x2EA1AD0", Length = "0xB5")]
	[Token(Token = "0x60000F8")]
	private void SetPerspectiveCorrection() { }

	[Address(RVA = "0x2EA2790", Offset = "0x2EA1B90", Length = "0xA6")]
	[Token(Token = "0x60000F6")]
	protected virtual void SetShaderDepth() { }

	[Address(RVA = "0x2EA2840", Offset = "0x2EA1C40", Length = "0x56")]
	[Token(Token = "0x60000F0")]
	protected virtual void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x2EA28A0", Offset = "0x2EA1CA0", Length = "0x52F")]
	[Token(Token = "0x60000F2")]
	protected virtual void SetSharedMaterials(Material[] materials) { }

	[Address(RVA = "0x2EA2DD0", Offset = "0x2EA21D0", Length = "0xD9")]
	[Token(Token = "0x60000C8")]
	public virtual void SetVerticesDirty() { }

	[Address(RVA = "0x2EA2EB0", Offset = "0x2EA22B0", Length = "0x306")]
	[Token(Token = "0x60000D6")]
	internal virtual void UpdateCulling() { }

	[Address(RVA = "0x2EA31C0", Offset = "0x2EA25C0", Length = "0x2D8")]
	[Token(Token = "0x60000EA")]
	private void UpdateEnvMapMatrix() { }

	[Address(RVA = "0x2EA34A0", Offset = "0x2EA28A0", Length = "0x14")]
	[Token(Token = "0x60000E2")]
	public void UpdateFontAsset() { }

	[Address(RVA = "0x2EA34C0", Offset = "0x2EA28C0", Length = "0x8E")]
	[Token(Token = "0x60000DF")]
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	[Address(RVA = "0x2EA3550", Offset = "0x2EA2950", Length = "0x498")]
	[Token(Token = "0x60000ED")]
	private void UpdateMask() { }

	[Address(RVA = "0x2EA39F0", Offset = "0x2EA2DF0", Length = "0x15C")]
	[Token(Token = "0x60000D1")]
	protected virtual void UpdateMaterial() { }

	[Address(RVA = "0x2EA3B50", Offset = "0x2EA2F50", Length = "0x123")]
	[Token(Token = "0x60000D7")]
	public virtual void UpdateMeshPadding() { }

	[Address(RVA = "0x2EA3C80", Offset = "0x2EA3080", Length = "0x2AF")]
	[Token(Token = "0x6000108")]
	private void UpdateSDFScale(float scaleDelta) { }

	[Address(RVA = "0x2EA3F30", Offset = "0x2EA3330", Length = "0xF7")]
	[Token(Token = "0x60000CF")]
	private void UpdateSubObjectPivot() { }

	[Address(RVA = "0x2EA4270", Offset = "0x2EA3670", Length = "0x279")]
	[Token(Token = "0x60000E1")]
	public virtual void UpdateVertexData() { }

	[Address(RVA = "0x2EA4030", Offset = "0x2EA3430", Length = "0x23B")]
	[Token(Token = "0x60000E0")]
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[Address(RVA = "0x2EA44F0", Offset = "0x2EA38F0", Length = "0x14D")]
	[Token(Token = "0x60000E9")]
	private void ValidateEnvMapProperty() { }

}

