namespace UnityEngine.UIElements;

[Token(Token = "0x2000293")]
public class IMGUIContainer : VisualElement, IDisposable
{
	[Token(Token = "0x2000298")]
	private struct GUIGlobals
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4E")]
		public Matrix4x4 matrix; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A4F")]
		public Color color; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A50")]
		public Color contentColor; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A51")]
		public Color backgroundColor; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A52")]
		public bool enabled; //Field offset: 0x70
		[FieldOffset(Offset = "0x71")]
		[Token(Token = "0x4000A53")]
		public bool changed; //Field offset: 0x71
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000A54")]
		public int displayIndex; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A55")]
		public float pixelsPerPoint; //Field offset: 0x78

	}

	[Token(Token = "0x2000297")]
	public struct NotUITKScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4D")]
		private bool wasUITK; //Field offset: 0x0

		[Address(RVA = "0x3406DF0", Offset = "0x34061F0", Length = "0xCB")]
		[Token(Token = "0x6001230")]
		public NotUITKScope() { }

		[Address(RVA = "0x3406D50", Offset = "0x3406150", Length = "0x92")]
		[Token(Token = "0x6001231")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000296")]
	public struct UITKScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4C")]
		private bool wasUITK; //Field offset: 0x0

		[Address(RVA = "0x3410B80", Offset = "0x340FF80", Length = "0xCB")]
		[Token(Token = "0x600122E")]
		public UITKScope() { }

		[Address(RVA = "0x3410AE0", Offset = "0x340FEE0", Length = "0x92")]
		[Token(Token = "0x600122F")]
		public override void Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000294")]
	internal class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{

		[Address(RVA = "0x3411000", Offset = "0x3410400", Length = "0x39")]
		[Token(Token = "0x600122C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000295")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x3411040", Offset = "0x3410440", Length = "0x63")]
		[Token(Token = "0x600122D")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x4000A30")]
	internal static readonly BindingId cullingEnabledProperty; //Field offset: 0x0
	[Token(Token = "0x4000A31")]
	internal static readonly BindingId contextTypeProperty; //Field offset: 0x98
	[Token(Token = "0x4000A43")]
	public static readonly string ussClassName; //Field offset: 0x130
	[Token(Token = "0x4000A44")]
	internal static readonly string ussFoldoutChildDepthClassName; //Field offset: 0x138
	[Token(Token = "0x4000A45")]
	internal static readonly List<String> ussFoldoutChildDepthClassNames; //Field offset: 0x140
	[Token(Token = "0x4000A47")]
	private static readonly ProfilerMarker k_OnGUIMarker; //Field offset: 0x148
	[Token(Token = "0x4000A48")]
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; //Field offset: 0x150
	[Token(Token = "0x4000A49")]
	private static Event s_DefaultMeasureEvent; //Field offset: 0x158
	[Token(Token = "0x4000A4A")]
	private static Event s_MeasureEvent; //Field offset: 0x160
	[Token(Token = "0x4000A4B")]
	private static Event s_CurrentEvent; //Field offset: 0x168
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000A32")]
	private Action m_OnGUIHandler; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000A33")]
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000A34")]
	internal bool useOwnerObjectGUIState; //Field offset: 0x2D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000A35")]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x4000A36")]
	private bool m_CullingEnabled; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2ED")]
	[Token(Token = "0x4000A37")]
	private bool m_IsFocusDelegated; //Field offset: 0x2ED
	[FieldOffset(Offset = "0x2EE")]
	[Token(Token = "0x4000A38")]
	private bool m_RefreshCachedLayout; //Field offset: 0x2EE
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000A39")]
	private LayoutCache m_Cache; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000A3A")]
	private Rect m_CachedClippingRect; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000A3B")]
	private Matrix4x4 m_CachedTransform; //Field offset: 0x308
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000A3C")]
	private ContextType m_ContextType; //Field offset: 0x348
	[FieldOffset(Offset = "0x34C")]
	[Token(Token = "0x4000A3D")]
	private bool lostFocus; //Field offset: 0x34C
	[FieldOffset(Offset = "0x34D")]
	[Token(Token = "0x4000A3E")]
	private bool receivedFocus; //Field offset: 0x34D
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000A3F")]
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000A40")]
	private bool hasFocusableControls; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x4000A41")]
	private int newKeyboardFocusControlID; //Field offset: 0x35C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000A42")]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x4000A46")]
	private GUIGlobals m_GUIGlobals; //Field offset: 0x364

	[Token(Token = "0x17000378")]
	private LayoutCache cache
	{
		[Address(RVA = "0x3403D80", Offset = "0x3403180", Length = "0x7B")]
		[Token(Token = "0x6001209")]
		private get { } //Length: 123
	}

	[Token(Token = "0x1700037D")]
	public virtual bool canGrabFocus
	{
		[Address(RVA = "0x3403E00", Offset = "0x3403200", Length = "0x29")]
		[Token(Token = "0x600120F")]
		 get { } //Length: 41
	}

	[CreateProperty]
	[Token(Token = "0x1700037B")]
	public ContextType contextType
	{
		[Address(RVA = "0x33A7260", Offset = "0x33A6660", Length = "0x7")]
		[Token(Token = "0x600120C")]
		 get { } //Length: 7
		[Address(RVA = "0x3403F80", Offset = "0x3403380", Length = "0x7C")]
		[Token(Token = "0x600120D")]
		 set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x17000377")]
	public bool cullingEnabled
	{
		[Address(RVA = "0x3403E30", Offset = "0x3403230", Length = "0xA")]
		[Token(Token = "0x6001207")]
		 get { } //Length: 10
		[Address(RVA = "0x3404000", Offset = "0x3403400", Length = "0x88")]
		[Token(Token = "0x6001208")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700037C")]
	internal bool focusOnlyIfHasFocusableControls
	{
		[Address(RVA = "0x333D1C0", Offset = "0x333C5C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600120E")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000375")]
	internal ObjectGUIState guiState
	{
		[Address(RVA = "0x3403E40", Offset = "0x3403240", Length = "0xBC")]
		[Token(Token = "0x6001204")]
		internal get { } //Length: 188
	}

	[Token(Token = "0x17000376")]
	internal Rect lastWorldClip
	{
		[Address(RVA = "0x3403F00", Offset = "0x3403300", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x6001205")]
		internal get { } //Length: 14
		[Address(RVA = "0x3404090", Offset = "0x3403490", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6001206")]
		internal set { } //Length: 11
	}

	[Token(Token = "0x1700037A")]
	private float layoutMeasuredHeight
	{
		[Address(RVA = "0x3403F10", Offset = "0x3403310", Length = "0x2C")]
		[Token(Token = "0x600120B")]
		private get { } //Length: 44
	}

	[Token(Token = "0x17000379")]
	private float layoutMeasuredWidth
	{
		[Address(RVA = "0x3403F40", Offset = "0x3403340", Length = "0x2C")]
		[Token(Token = "0x600120A")]
		private get { } //Length: 44
	}

	[Token(Token = "0x17000374")]
	public Action onGUIHandler
	{
		[Address(RVA = "0x3403F70", Offset = "0x3403370", Length = "0xA")]
		[Token(Token = "0x6001202")]
		 get { } //Length: 10
		[Address(RVA = "0x34040A0", Offset = "0x34034A0", Length = "0x64")]
		[Token(Token = "0x6001203")]
		 set { } //Length: 100
	}

	[Address(RVA = "0x34032E0", Offset = "0x34026E0", Length = "0x6F7")]
	[Token(Token = "0x6001210")]
	private static IMGUIContainer() { }

	[Address(RVA = "0x34039E0", Offset = "0x3402DE0", Length = "0x38E")]
	[Token(Token = "0x6001212")]
	public IMGUIContainer(Action onGUIHandler) { }

	[Address(RVA = "0x3403D70", Offset = "0x3403170", Length = "0xA")]
	[Token(Token = "0x6001211")]
	public IMGUIContainer() { }

	[Address(RVA = "0x34030D0", Offset = "0x34024D0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600122B")]
	private void <DoOnGUI>b__61_0() { }

	[Address(RVA = "0x33FF5E0", Offset = "0x33FE9E0", Length = "0x61")]
	[Token(Token = "0x6001229")]
	public override void Dispose() { }

	[Address(RVA = "0x33FF650", Offset = "0x33FEA50", Length = "0x20")]
	[Token(Token = "0x600122A")]
	protected override void Dispose(bool disposeManaged) { }

	[Address(RVA = "0x33FF670", Offset = "0x33FEA70", Length = "0x438")]
	[Token(Token = "0x6001218")]
	private void DoIMGUIRepaint() { }

	[Address(RVA = "0x33FFAB0", Offset = "0x33FEEB0", Length = "0x3F5")]
	[Token(Token = "0x6001226")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x33FFEB0", Offset = "0x33FF2B0", Length = "0x107D")]
	[Token(Token = "0x6001216")]
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	[Address(RVA = "0x3403D80", Offset = "0x3403180", Length = "0x7B")]
	[Token(Token = "0x6001209")]
	private LayoutCache get_cache() { }

	[Address(RVA = "0x3403E00", Offset = "0x3403200", Length = "0x29")]
	[Token(Token = "0x600120F")]
	public virtual bool get_canGrabFocus() { }

	[Address(RVA = "0x33A7260", Offset = "0x33A6660", Length = "0x7")]
	[Token(Token = "0x600120C")]
	public ContextType get_contextType() { }

	[Address(RVA = "0x3403E30", Offset = "0x3403230", Length = "0xA")]
	[Token(Token = "0x6001207")]
	public bool get_cullingEnabled() { }

	[Address(RVA = "0x333D1C0", Offset = "0x333C5C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600120E")]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	[Address(RVA = "0x3403E40", Offset = "0x3403240", Length = "0xBC")]
	[Token(Token = "0x6001204")]
	internal ObjectGUIState get_guiState() { }

	[Address(RVA = "0x3403F00", Offset = "0x3403300", Length = "0xE")]
	[CompilerGenerated]
	[Token(Token = "0x6001205")]
	internal Rect get_lastWorldClip() { }

	[Address(RVA = "0x3403F10", Offset = "0x3403310", Length = "0x2C")]
	[Token(Token = "0x600120B")]
	private float get_layoutMeasuredHeight() { }

	[Address(RVA = "0x3403F40", Offset = "0x3403340", Length = "0x2C")]
	[Token(Token = "0x600120A")]
	private float get_layoutMeasuredWidth() { }

	[Address(RVA = "0x3403F70", Offset = "0x3403370", Length = "0xA")]
	[Token(Token = "0x6001202")]
	public Action get_onGUIHandler() { }

	[Address(RVA = "0x3400F30", Offset = "0x3400330", Length = "0xBA")]
	[Token(Token = "0x6001227")]
	private Rect GetCurrentClipRect() { }

	[Address(RVA = "0x3400FF0", Offset = "0x34003F0", Length = "0x1A8")]
	[Token(Token = "0x6001228")]
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	[Address(RVA = "0x34011A0", Offset = "0x34005A0", Length = "0x5BE")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[Token(Token = "0x6001224")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	[Token(Token = "0x6001223")]
	internal virtual void HandleEventBubbleUpDisabled(EventBase evt) { }

	[Address(RVA = "0x34019D0", Offset = "0x3400DD0", Length = "0x268")]
	[Token(Token = "0x6001220")]
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	[Address(RVA = "0x3401C40", Offset = "0x3401040", Length = "0x5A0")]
	[Token(Token = "0x6001222")]
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	[Address(RVA = "0x3401760", Offset = "0x3400B60", Length = "0x26D")]
	[Token(Token = "0x6001221")]
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	[Address(RVA = "0x34021F0", Offset = "0x34015F0", Length = "0xD3")]
	[Token(Token = "0x600121C")]
	private bool IsContainerCapturingTheMouse() { }

	[Address(RVA = "0x34022D0", Offset = "0x34016D0", Length = "0xE8")]
	[Token(Token = "0x600121F")]
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	[Address(RVA = "0x34023C0", Offset = "0x34017C0", Length = "0x1D8")]
	[Token(Token = "0x600121E")]
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	[Address(RVA = "0x34025A0", Offset = "0x34019A0", Length = "0x1D8")]
	[Token(Token = "0x600121D")]
	private bool IsLocalEvent(EventBase evt) { }

	[Address(RVA = "0x3402780", Offset = "0x3401B80", Length = "0x14")]
	[Token(Token = "0x6001217")]
	public void MarkDirtyLayout() { }

	[Address(RVA = "0x34027A0", Offset = "0x3401BA0", Length = "0x162")]
	[Token(Token = "0x6001213")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x3402910", Offset = "0x3401D10", Length = "0x176")]
	[Token(Token = "0x6001215")]
	private void RestoreGlobals() { }

	[Address(RVA = "0x3402A90", Offset = "0x3401E90", Length = "0x130")]
	[Token(Token = "0x6001214")]
	private void SaveGlobals() { }

	[Address(RVA = "0x3402CB0", Offset = "0x34020B0", Length = "0x293")]
	[Token(Token = "0x6001219")]
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true) { }

	[Address(RVA = "0x3402BD0", Offset = "0x3401FD0", Length = "0xDB")]
	[Token(Token = "0x600121A")]
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	[Address(RVA = "0x3403F80", Offset = "0x3403380", Length = "0x7C")]
	[Token(Token = "0x600120D")]
	public void set_contextType(ContextType value) { }

	[Address(RVA = "0x3404000", Offset = "0x3403400", Length = "0x88")]
	[Token(Token = "0x6001208")]
	public void set_cullingEnabled(bool value) { }

	[Address(RVA = "0x3404090", Offset = "0x3403490", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6001206")]
	internal void set_lastWorldClip(Rect value) { }

	[Address(RVA = "0x34040A0", Offset = "0x34034A0", Length = "0x64")]
	[Token(Token = "0x6001203")]
	public void set_onGUIHandler(Action value) { }

	[Address(RVA = "0x3402F50", Offset = "0x3402350", Length = "0x176")]
	[Token(Token = "0x6001225")]
	private void SetFoldoutDepthClass() { }

	[Address(RVA = "0x34030E0", Offset = "0x34024E0", Length = "0x1F8")]
	[Token(Token = "0x600121B")]
	private bool VerifyBounds(EventBase evt) { }

}

