namespace UnityEngine.UIElements;

[Token(Token = "0x20004A0")]
internal class UITKTextHandle : TextHandle
{
	[Token(Token = "0x4000F55")]
	private static TextLib s_TextLib; //Field offset: 0x0
	[Token(Token = "0x4000F5D")]
	internal static readonly float k_MinPadding; //Field offset: 0x8
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000F51")]
	internal ATGTextEventHandler m_ATGTextEventHandler; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000F52")]
	private List<ValueTuple`3<Int32, TagType, String>> m_Links; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000F53")]
	internal Color atgHyperlinkColor; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000F54")]
	private bool uvsAreGenerated; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000F56")]
	private float <LastPixelPerPoint>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000F57")]
	private Nullable<Single> <MeasuredWidth>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000F58")]
	private float <RoundedWidth>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000F59")]
	private Nullable<Single> <ATGMeasuredWidth>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000F5A")]
	private float <ATGRoundedWidth>k__BackingField; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000F5B")]
	internal TextEventHandler m_TextEventHandler; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000F5C")]
	protected TextElement m_TextElement; //Field offset: 0x110

	[Token(Token = "0x17000936")]
	internal Nullable<Single> ATGMeasuredWidth
	{
		[Address(RVA = "0x3296870", Offset = "0x3295C70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022B7")]
		internal get { } //Length: 8
		[Address(RVA = "0x3296B90", Offset = "0x3295F90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022B8")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x17000937")]
	internal float ATGRoundedWidth
	{
		[Address(RVA = "0x661750", Offset = "0x660B50", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022B9")]
		internal get { } //Length: 9
		[Address(RVA = "0x6617C0", Offset = "0x660BC0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022BA")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x17000938")]
	public virtual bool IsPlaceholder
	{
		[Address(RVA = "0x3296880", Offset = "0x3295C80", Length = "0x3E")]
		[Token(Token = "0x60022C9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000933")]
	internal float LastPixelPerPoint
	{
		[Address(RVA = "0x1D41DA0", Offset = "0x1D411A0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022B0")]
		internal get { } //Length: 9
		[Address(RVA = "0x3296BA0", Offset = "0x3295FA0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022B1")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x17000931")]
	private List<ValueTuple`3<Int32, TagType, String>> Links
	{
		[Address(RVA = "0x32968C0", Offset = "0x3295CC0", Length = "0x84")]
		[Token(Token = "0x600229E")]
		private get { } //Length: 132
	}

	[Token(Token = "0x17000934")]
	internal Nullable<Single> MeasuredWidth
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022B3")]
		internal get { } //Length: 8
		[Address(RVA = "0x3296BB0", Offset = "0x3295FB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022B4")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x17000935")]
	internal float RoundedWidth
	{
		[Address(RVA = "0x3296950", Offset = "0x3295D50", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022B5")]
		internal get { } //Length: 9
		[Address(RVA = "0x3296BC0", Offset = "0x3295FC0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60022B6")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x17000932")]
	protected private TextLib textLib
	{
		[Address(RVA = "0x3296960", Offset = "0x3295D60", Length = "0x5E")]
		[Token(Token = "0x60022AC")]
		private get { } //Length: 94
	}

	[Address(RVA = "0x3296760", Offset = "0x3295B60", Length = "0x3A")]
	[Token(Token = "0x60022CB")]
	private static UITKTextHandle() { }

	[Address(RVA = "0x32967A0", Offset = "0x3295BA0", Length = "0xCA")]
	[Token(Token = "0x60022AE")]
	public UITKTextHandle(TextElement te) { }

	[Address(RVA = "0x32935D0", Offset = "0x32929D0", Length = "0x190")]
	[Token(Token = "0x60022C2")]
	public virtual void AddToPermanentCacheAndGenerateMesh() { }

	[Address(RVA = "0x3293400", Offset = "0x3292800", Length = "0x1C1")]
	[Token(Token = "0x60022A6")]
	internal ValueTuple<TagType, String> ATGFindIntersectingLink(Vector2 point) { }

	[Address(RVA = "0x3293760", Offset = "0x3292B60", Length = "0xDE")]
	[Token(Token = "0x60022A1")]
	public void CacheTextGenerationInfo() { }

	[Address(RVA = "0x3293840", Offset = "0x3292C40", Length = "0x2B4")]
	[Token(Token = "0x600229F")]
	private void ComputeNativeTextSize(in string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x3293B00", Offset = "0x3292F00", Length = "0x138")]
	[Token(Token = "0x60022BD")]
	public void ComputeSettingsAndUpdate() { }

	[Address(RVA = "0x3293EE0", Offset = "0x32932E0", Length = "0x1A8")]
	[Token(Token = "0x60022BC")]
	public Vector2 ComputeTextSize(in RenderedText textToMeasure, float width, float height, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x3293C40", Offset = "0x3293040", Length = "0x29F")]
	[Token(Token = "0x60022BB")]
	public Vector2 ComputeTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x3294090", Offset = "0x3293490", Length = "0xA61")]
	[NullableContext(2)]
	[Token(Token = "0x60022A9")]
	internal bool ConvertUssToNativeTextGenerationSettings(string textToMeasure = null, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x3294B00", Offset = "0x3293F00", Length = "0x8B3")]
	[Token(Token = "0x60022C4")]
	internal override bool ConvertUssToTextGenerationSettings(bool populateScreenRect, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x32953C0", Offset = "0x32947C0", Length = "0xA6")]
	[Token(Token = "0x60022A8")]
	internal void EnsureIsReadyForJobs() { }

	[Address(RVA = "0x3296870", Offset = "0x3295C70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022B7")]
	internal Nullable<Single> get_ATGMeasuredWidth() { }

	[Address(RVA = "0x661750", Offset = "0x660B50", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022B9")]
	internal float get_ATGRoundedWidth() { }

	[Address(RVA = "0x3296880", Offset = "0x3295C80", Length = "0x3E")]
	[Token(Token = "0x60022C9")]
	public virtual bool get_IsPlaceholder() { }

	[Address(RVA = "0x1D41DA0", Offset = "0x1D411A0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022B0")]
	internal float get_LastPixelPerPoint() { }

	[Address(RVA = "0x32968C0", Offset = "0x3295CC0", Length = "0x84")]
	[Token(Token = "0x600229E")]
	private List<ValueTuple`3<Int32, TagType, String>> get_Links() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022B3")]
	internal Nullable<Single> get_MeasuredWidth() { }

	[Address(RVA = "0x3296950", Offset = "0x3295D50", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022B5")]
	internal float get_RoundedWidth() { }

	[Address(RVA = "0x3296960", Offset = "0x3295D60", Length = "0x5E")]
	[Token(Token = "0x60022AC")]
	protected private TextLib get_textLib() { }

	[Address(RVA = "0x3295530", Offset = "0x3294930", Length = "0x2E8")]
	[Token(Token = "0x60022AA")]
	private TextAsset GetICUAsset() { }

	[Address(RVA = "0x3295470", Offset = "0x3294870", Length = "0xB9")]
	[Token(Token = "0x60022AB")]
	internal static TextAsset GetICUAssetStaticFalback() { }

	[Address(RVA = "0x3295820", Offset = "0x3294C20", Length = "0x29")]
	[Token(Token = "0x60022AF")]
	protected virtual float GetPixelsPerPoint() { }

	[Address(RVA = "0x3295850", Offset = "0x3294C50", Length = "0xE2")]
	[Token(Token = "0x60022C3")]
	private TextOverflowMode GetTextOverflowMode() { }

	[Address(RVA = "0x3295940", Offset = "0x3294D40", Length = "0x269")]
	[Token(Token = "0x60022C6")]
	internal float GetVertexPadding(FontAsset fontAsset) { }

	[Address(RVA = "0x3295BB0", Offset = "0x3294FB0", Length = "0x14")]
	[Token(Token = "0x60022BE")]
	public void HandleATag() { }

	[Address(RVA = "0x3295BD0", Offset = "0x3294FD0", Length = "0x14")]
	[Token(Token = "0x60022C0")]
	public void HandleLinkAndATagCallbacks() { }

	[Address(RVA = "0x3295BF0", Offset = "0x3294FF0", Length = "0x14")]
	[Token(Token = "0x60022BF")]
	public void HandleLinkTag() { }

	[Address(RVA = "0x32969C0", Offset = "0x3295DC0", Length = "0x1C0")]
	[Token(Token = "0x60022A5")]
	private ValueTuple<Boolean, Boolean> hasLinkAndHyperlink() { }

	[Address(RVA = "0x3295C10", Offset = "0x3295010", Length = "0xA4")]
	[Token(Token = "0x60022A4")]
	public bool HasMissingGlyphs(NativeTextInfo textInfo, ref Dictionary<Int32, HashSet`1<UInt32>>& missingGlyphsPerFontAsset) { }

	[Address(RVA = "0x3295CC0", Offset = "0x32950C0", Length = "0xEE")]
	[Token(Token = "0x60022AD")]
	protected private void InitTextLib() { }

	[Address(RVA = "0x3295DB0", Offset = "0x32951B0", Length = "0x10")]
	[Token(Token = "0x60022C7")]
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	[Address(RVA = "0x3295DC0", Offset = "0x32951C0", Length = "0x50")]
	[Token(Token = "0x60022CA")]
	public bool IsElided() { }

	[Address(RVA = "0x3295E20", Offset = "0x3295220", Length = "0x12C")]
	[Token(Token = "0x60022A3")]
	public void ProcessMeshInfos(NativeTextInfo textInfo, ref List<List`1<List`1<Int32>>>& textElementIndicesByMesh, ref List<Boolean>& hasMultipleColorsByMesh) { }

	[Address(RVA = "0x3295F50", Offset = "0x3295350", Length = "0x13D")]
	[Token(Token = "0x60022C8")]
	internal void ReleaseResourcesIfPossible() { }

	[Address(RVA = "0x3296B90", Offset = "0x3295F90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022B8")]
	internal void set_ATGMeasuredWidth(Nullable<Single> value) { }

	[Address(RVA = "0x6617C0", Offset = "0x660BC0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022BA")]
	internal void set_ATGRoundedWidth(float value) { }

	[Address(RVA = "0x3296BA0", Offset = "0x3295FA0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022B1")]
	internal void set_LastPixelPerPoint(float value) { }

	[Address(RVA = "0x3296BB0", Offset = "0x3295FB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022B4")]
	internal void set_MeasuredWidth(Nullable<Single> value) { }

	[Address(RVA = "0x3296BC0", Offset = "0x3295FC0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60022B6")]
	internal void set_RoundedWidth(float value) { }

	[Address(RVA = "0x3296090", Offset = "0x3295490", Length = "0x17")]
	[Token(Token = "0x60022B2")]
	public virtual void SetDirty() { }

	[Address(RVA = "0x32960B0", Offset = "0x32954B0", Length = "0x188")]
	[Token(Token = "0x60022A2")]
	public void ShapeText() { }

	[Address(RVA = "0x3296240", Offset = "0x3295640", Length = "0x30")]
	[Token(Token = "0x60022C5")]
	internal bool TextLibraryCanElide() { }

	[Address(RVA = "0x3296280", Offset = "0x3295680", Length = "0x7B")]
	[Token(Token = "0x60022A7")]
	internal void UpdateATGTextEventHandler() { }

	[Address(RVA = "0x3296300", Offset = "0x3295700", Length = "0xCF")]
	[Token(Token = "0x60022C1")]
	public void UpdateMesh() { }

	[Address(RVA = "0x32963D0", Offset = "0x32957D0", Length = "0x38A")]
	[Token(Token = "0x60022A0")]
	public ValueTuple<NativeTextInfo, Boolean> UpdateNative(bool generateNativeSettings = true) { }

}

