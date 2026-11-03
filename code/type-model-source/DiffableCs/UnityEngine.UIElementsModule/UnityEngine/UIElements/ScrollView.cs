namespace UnityEngine.UIElements;

[Token(Token = "0x2000145")]
public class ScrollView : VisualElement
{
	[CompilerGenerated]
	[Token(Token = "0x200014B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000691")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000692")]
		public static Predicate<VisualElement> <>9__203_0; //Field offset: 0x8

		[Address(RVA = "0x33A79F0", Offset = "0x33A6DF0", Length = "0x67")]
		[Token(Token = "0x6000A23")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A24")]
		public <>c() { }

		[Address(RVA = "0x33A79D0", Offset = "0x33A6DD0", Length = "0x1F")]
		[Token(Token = "0x6000A25")]
		internal bool <ReadSingleLineHeight>b__203_0(VisualElement x) { }

	}

	[Token(Token = "0x2000149")]
	internal enum NestedInteractionKind : int
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2,
	}

	[Token(Token = "0x2000148")]
	internal enum TouchScrollBehavior : int
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	[Token(Token = "0x200014A")]
	public enum TouchScrollingResult : int
	{
		Apply = 0,
		Forward = 1,
		Block = 2,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000146")]
	internal class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{

		[Address(RVA = "0x33A8000", Offset = "0x33A7400", Length = "0x39")]
		[Token(Token = "0x6000A20")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000147")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000679")]
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400067A")]
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400067B")]
		private UxmlBoolAttributeDescription m_ShowHorizontal; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400067C")]
		private UxmlBoolAttributeDescription m_ShowVertical; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400067D")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400067E")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400067F")]
		private UxmlFloatAttributeDescription m_HorizontalPageSize; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000680")]
		private UxmlFloatAttributeDescription m_VerticalPageSize; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000681")]
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000682")]
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000683")]
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000684")]
		private UxmlFloatAttributeDescription m_Elasticity; //Field offset: 0xE0

		[Address(RVA = "0x33AA5E0", Offset = "0x33A99E0", Length = "0x593")]
		[Token(Token = "0x6000A22")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A92B0", Offset = "0x33A86B0", Length = "0xA34")]
		[Token(Token = "0x6000A21")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400062E")]
	internal static readonly BindingId horizontalScrollerVisibilityProperty; //Field offset: 0x0
	[Token(Token = "0x400062F")]
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x98
	[Token(Token = "0x4000630")]
	internal static readonly BindingId scrollOffsetProperty; //Field offset: 0x130
	[Token(Token = "0x4000631")]
	internal static readonly BindingId horizontalPageSizeProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000632")]
	internal static readonly BindingId verticalPageSizeProperty; //Field offset: 0x260
	[Token(Token = "0x4000633")]
	internal static readonly BindingId mouseWheelScrollSizeProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000634")]
	internal static readonly BindingId scrollDecelerationRateProperty; //Field offset: 0x390
	[Token(Token = "0x4000635")]
	internal static readonly BindingId elasticityProperty; //Field offset: 0x428
	[Token(Token = "0x4000636")]
	internal static readonly BindingId touchScrollBehaviorProperty; //Field offset: 0x4C0
	[Token(Token = "0x4000637")]
	internal static readonly BindingId nestedInteractionKindProperty; //Field offset: 0x558
	[Token(Token = "0x4000638")]
	internal static readonly BindingId modeProperty; //Field offset: 0x5F0
	[Token(Token = "0x4000639")]
	internal static readonly BindingId elasticAnimationIntervalMsProperty; //Field offset: 0x688
	[Token(Token = "0x4000648")]
	private static readonly float k_DefaultScrollDecelerationRate; //Field offset: 0x720
	[Token(Token = "0x400064C")]
	private static readonly float k_DefaultElasticity; //Field offset: 0x724
	[Token(Token = "0x4000659")]
	public static readonly string ussClassName; //Field offset: 0x728
	[Token(Token = "0x400065A")]
	public static readonly string viewportUssClassName; //Field offset: 0x730
	[Token(Token = "0x400065B")]
	public static readonly string horizontalVariantViewportUssClassName; //Field offset: 0x738
	[Token(Token = "0x400065C")]
	public static readonly string verticalVariantViewportUssClassName; //Field offset: 0x740
	[Token(Token = "0x400065D")]
	public static readonly string verticalHorizontalVariantViewportUssClassName; //Field offset: 0x748
	[Token(Token = "0x400065E")]
	public static readonly string contentAndVerticalScrollUssClassName; //Field offset: 0x750
	[Token(Token = "0x400065F")]
	public static readonly string contentUssClassName; //Field offset: 0x758
	[Token(Token = "0x4000660")]
	public static readonly string horizontalVariantContentUssClassName; //Field offset: 0x760
	[Token(Token = "0x4000661")]
	public static readonly string verticalVariantContentUssClassName; //Field offset: 0x768
	[Token(Token = "0x4000662")]
	public static readonly string verticalHorizontalVariantContentUssClassName; //Field offset: 0x770
	[Token(Token = "0x4000663")]
	public static readonly string hScrollerUssClassName; //Field offset: 0x778
	[Token(Token = "0x4000664")]
	public static readonly string vScrollerUssClassName; //Field offset: 0x780
	[Token(Token = "0x4000665")]
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x788
	[Token(Token = "0x4000666")]
	public static readonly string verticalVariantUssClassName; //Field offset: 0x790
	[Token(Token = "0x4000667")]
	public static readonly string verticalHorizontalVariantUssClassName; //Field offset: 0x798
	[Token(Token = "0x4000668")]
	public static readonly string scrollVariantUssClassName; //Field offset: 0x7A0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400063A")]
	private VisualElement m_DeferredScrollToElement; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400063B")]
	private IVisualElementScheduledItem m_DeferredScrollTo; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400063C")]
	private int m_FirstLayoutPass; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x400063D")]
	private ScrollerVisibility m_HorizontalScrollerVisibility; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400063E")]
	private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400063F")]
	private long m_ElasticAnimationIntervalMs; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000640")]
	private VisualElement m_AttachedRootVisualContainer; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000641")]
	private float m_SingleLineHeight; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000642")]
	private bool m_SingleLineHeightDirtyFlag; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x2FD")]
	[Token(Token = "0x4000643")]
	internal bool m_MouseWheelScrollSizeIsInline; //Field offset: 0x2FD
	[DontCreateProperty]
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	[Token(Token = "0x4000644")]
	private Vector2 m_ScrollOffset; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000645")]
	private float m_HorizontalPageSize; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000646")]
	private float m_VerticalPageSize; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000647")]
	private float m_MouseWheelScrollSize; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000649")]
	private float m_ScrollDecelerationRate; //Field offset: 0x314
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x400064A")]
	private float k_ScaledPixelsPerPointMultiplier; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x400064B")]
	private float k_TouchScrollInertiaBaseTimeInterval; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x400064D")]
	private float m_Elasticity; //Field offset: 0x320
	[FieldOffset(Offset = "0x324")]
	[Token(Token = "0x400064E")]
	private TouchScrollBehavior m_TouchScrollBehavior; //Field offset: 0x324
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x400064F")]
	private NestedInteractionKind m_NestedInteractionKind; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000650")]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000651")]
	private readonly Scroller <horizontalScroller>k__BackingField; //Field offset: 0x338
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000652")]
	private readonly Scroller <verticalScroller>k__BackingField; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000653")]
	private VisualElement m_ContentContainer; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000654")]
	private VisualElement m_ContentAndVerticalScrollContainer; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000655")]
	private float previousVerticalTouchScrollTimeStamp; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x4000656")]
	private float previousHorizontalTouchScrollTimeStamp; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000657")]
	private float elapsedTimeSinceLastVerticalTouchScroll; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x4000658")]
	private float elapsedTimeSinceLastHorizontalTouchScroll; //Field offset: 0x364
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000669")]
	private ScrollViewMode m_Mode; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x400066A")]
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x400066B")]
	private Vector2 m_StartPosition; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x400066C")]
	private Vector2 m_PointerStartPosition; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x400066D")]
	private Vector2 m_Velocity; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x400066E")]
	private Vector2 m_SpringBackVelocity; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x400066F")]
	private Vector2 m_LowBounds; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000670")]
	private Vector2 m_HighBounds; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000671")]
	private float m_LastVelocityLerpTime; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3AC")]
	[Token(Token = "0x4000672")]
	private bool m_StartedMoving; //Field offset: 0x3AC
	[FieldOffset(Offset = "0x3AD")]
	[Token(Token = "0x4000673")]
	private bool m_TouchPointerMoveAllowed; //Field offset: 0x3AD
	[FieldOffset(Offset = "0x3AE")]
	[Token(Token = "0x4000674")]
	private bool m_TouchStoppedVelocity; //Field offset: 0x3AE
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000675")]
	private VisualElement m_CapturedTarget; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000676")]
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x4000677")]
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; //Field offset: 0x3C0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000678")]
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; //Field offset: 0x3C8

	[Token(Token = "0x170001BF")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x339FE90", Offset = "0x339F290", Length = "0xA")]
		[Token(Token = "0x60009F3")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170001BC")]
	public VisualElement contentViewport
	{
		[Address(RVA = "0x339FEA0", Offset = "0x339F2A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009F0")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001AA")]
	public long elasticAnimationIntervalMs
	{
		[Address(RVA = "0x1665B70", Offset = "0x1664F70", Length = "0xA")]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 10
		[Address(RVA = "0x33A0240", Offset = "0x339F640", Length = "0x148")]
		[Token(Token = "0x60009C8")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x170001B9")]
	public float elasticity
	{
		[Address(RVA = "0x339FEB0", Offset = "0x339F2B0", Length = "0xB")]
		[Token(Token = "0x60009DC")]
		 get { } //Length: 11
		[Address(RVA = "0x33A0390", Offset = "0x339F790", Length = "0x108")]
		[Token(Token = "0x60009DD")]
		 set { } //Length: 264
	}

	[Token(Token = "0x170001B7")]
	private bool hasInertia
	{
		[Address(RVA = "0x339FEC0", Offset = "0x339F2C0", Length = "0x14")]
		[Token(Token = "0x60009D9")]
		private get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170001B2")]
	public float horizontalPageSize
	{
		[Address(RVA = "0x339FEE0", Offset = "0x339F2E0", Length = "0xB")]
		[Token(Token = "0x60009D1")]
		 get { } //Length: 11
		[Address(RVA = "0x33A04A0", Offset = "0x339F8A0", Length = "0xAB")]
		[Token(Token = "0x60009D2")]
		 set { } //Length: 171
	}

	[Token(Token = "0x170001BD")]
	public Scroller horizontalScroller
	{
		[Address(RVA = "0x32A66B0", Offset = "0x32A5AB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009F1")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001A8")]
	public ScrollerVisibility horizontalScrollerVisibility
	{
		[Address(RVA = "0x339FEF0", Offset = "0x339F2F0", Length = "0x9")]
		[Token(Token = "0x60009C3")]
		 get { } //Length: 9
		[Address(RVA = "0x33A0550", Offset = "0x339F950", Length = "0x107")]
		[Token(Token = "0x60009C4")]
		 set { } //Length: 263
	}

	[Token(Token = "0x170001B0")]
	internal bool isHorizontalScrollDisplayed
	{
		[Address(RVA = "0x339FF00", Offset = "0x339F300", Length = "0x61")]
		[Token(Token = "0x60009CE")]
		internal get { } //Length: 97
	}

	[Token(Token = "0x170001AF")]
	internal bool isVerticalScrollDisplayed
	{
		[Address(RVA = "0x339FF70", Offset = "0x339F370", Length = "0x61")]
		[Token(Token = "0x60009CD")]
		internal get { } //Length: 97
	}

	[CreateProperty]
	[Token(Token = "0x170001C0")]
	public ScrollViewMode mode
	{
		[Address(RVA = "0x339FFE0", Offset = "0x339F3E0", Length = "0x7")]
		[Token(Token = "0x60009F6")]
		 get { } //Length: 7
		[Address(RVA = "0x33A0660", Offset = "0x339FA60", Length = "0x93")]
		[Token(Token = "0x60009F7")]
		 set { } //Length: 147
	}

	[CreateProperty]
	[Token(Token = "0x170001B4")]
	public float mouseWheelScrollSize
	{
		[Address(RVA = "0x339FFF0", Offset = "0x339F3F0", Length = "0xB")]
		[Token(Token = "0x60009D5")]
		 get { } //Length: 11
		[Address(RVA = "0x33A0700", Offset = "0x339FB00", Length = "0xC6")]
		[Token(Token = "0x60009D6")]
		 set { } //Length: 198
	}

	[Token(Token = "0x170001AD")]
	internal bool needsHorizontal
	{
		[Address(RVA = "0x33A0000", Offset = "0x339F400", Length = "0x46")]
		[Token(Token = "0x60009CB")]
		internal get { } //Length: 70
	}

	[Token(Token = "0x170001AE")]
	internal bool needsVertical
	{
		[Address(RVA = "0x33A0050", Offset = "0x339F450", Length = "0x46")]
		[Token(Token = "0x60009CC")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 70
	}

	[CreateProperty]
	[Token(Token = "0x170001BB")]
	public NestedInteractionKind nestedInteractionKind
	{
		[Address(RVA = "0x32A6670", Offset = "0x32A5A70", Length = "0x7")]
		[Token(Token = "0x60009E0")]
		 get { } //Length: 7
		[Address(RVA = "0x33A07D0", Offset = "0x339FBD0", Length = "0x7E")]
		[Token(Token = "0x60009E1")]
		 set { } //Length: 126
	}

	[Token(Token = "0x170001B6")]
	internal float scrollableHeight
	{
		[Address(RVA = "0x33A00B0", Offset = "0x339F4B0", Length = "0xA2")]
		[Token(Token = "0x60009D8")]
		internal get { } //Length: 162
	}

	[Token(Token = "0x170001B5")]
	internal float scrollableWidth
	{
		[Address(RVA = "0x33A0160", Offset = "0x339F560", Length = "0xA2")]
		[Token(Token = "0x60009D7")]
		internal get { } //Length: 162
	}

	[CreateProperty]
	[Token(Token = "0x170001B8")]
	public float scrollDecelerationRate
	{
		[Address(RVA = "0x33A00A0", Offset = "0x339F4A0", Length = "0xB")]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 11
		[Address(RVA = "0x33A0850", Offset = "0x339FC50", Length = "0x108")]
		[Token(Token = "0x60009DB")]
		 set { } //Length: 264
	}

	[CreateProperty]
	[Token(Token = "0x170001B1")]
	public Vector2 scrollOffset
	{
		[Address(RVA = "0x1698D90", Offset = "0x1698190", Length = "0x19")]
		[Token(Token = "0x60009CF")]
		 get { } //Length: 25
		[Address(RVA = "0x33A0960", Offset = "0x339FD60", Length = "0x2FC")]
		[Token(Token = "0x60009D0")]
		 set { } //Length: 764
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	[Token(Token = "0x170001AB")]
	public bool showHorizontal
	{
		[Address(RVA = "0x33A0C60", Offset = "0x33A0060", Length = "0x1C")]
		[Token(Token = "0x60009C9")]
		 set { } //Length: 28
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	[Token(Token = "0x170001AC")]
	public bool showVertical
	{
		[Address(RVA = "0x33A0C80", Offset = "0x33A0080", Length = "0x1C")]
		[Token(Token = "0x60009CA")]
		 set { } //Length: 28
	}

	[CreateProperty]
	[Token(Token = "0x170001BA")]
	public TouchScrollBehavior touchScrollBehavior
	{
		[Address(RVA = "0x33A0210", Offset = "0x339F610", Length = "0x9")]
		[Token(Token = "0x60009DE")]
		 get { } //Length: 9
		[Address(RVA = "0x33A0CA0", Offset = "0x33A00A0", Length = "0x10F")]
		[Token(Token = "0x60009DF")]
		 set { } //Length: 271
	}

	[CreateProperty]
	[Token(Token = "0x170001B3")]
	public float verticalPageSize
	{
		[Address(RVA = "0x33A0220", Offset = "0x339F620", Length = "0xB")]
		[Token(Token = "0x60009D3")]
		 get { } //Length: 11
		[Address(RVA = "0x33A0DB0", Offset = "0x33A01B0", Length = "0xAB")]
		[Token(Token = "0x60009D4")]
		 set { } //Length: 171
	}

	[Token(Token = "0x170001BE")]
	public Scroller verticalScroller
	{
		[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009F2")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001A9")]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Address(RVA = "0x33A0230", Offset = "0x339F630", Length = "0x9")]
		[Token(Token = "0x60009C5")]
		 get { } //Length: 9
		[Address(RVA = "0x33A0E60", Offset = "0x33A0260", Length = "0x117")]
		[Token(Token = "0x60009C6")]
		 set { } //Length: 279
	}

	[Address(RVA = "0x339DFD0", Offset = "0x339D3D0", Length = "0xF73")]
	[Token(Token = "0x6000A1D")]
	private static ScrollView() { }

	[Address(RVA = "0x339FE80", Offset = "0x339F280", Length = "0xA")]
	[Token(Token = "0x60009F4")]
	public ScrollView() { }

	[Address(RVA = "0x339EF50", Offset = "0x339E350", Length = "0xF26")]
	[Token(Token = "0x60009F5")]
	public ScrollView(ScrollViewMode scrollViewMode) { }

	[Address(RVA = "0x339D1A0", Offset = "0x339C5A0", Length = "0x30")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1E")]
	private void <.ctor>b__147_0(float value) { }

	[Address(RVA = "0x339D1D0", Offset = "0x339C5D0", Length = "0x30")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1F")]
	private void <.ctor>b__147_1(float value) { }

	[Address(RVA = "0x3398250", Offset = "0x3397650", Length = "0x203")]
	[Token(Token = "0x6000A12")]
	private void AdjustScrollers() { }

	[Address(RVA = "0x3398460", Offset = "0x3397860", Length = "0x307")]
	[Token(Token = "0x6000A07")]
	internal void ApplyScrollInertia() { }

	[Address(RVA = "0x3398770", Offset = "0x3397B70", Length = "0x2E2")]
	[Token(Token = "0x6000A0F")]
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	[Address(RVA = "0x3398A60", Offset = "0x3397E60", Length = "0x174")]
	[Token(Token = "0x6000A04")]
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	[Address(RVA = "0x3398BE0", Offset = "0x3397FE0", Length = "0xF2")]
	[Token(Token = "0x6000A05")]
	private void ComputeInitialSpringBackVelocity() { }

	[Address(RVA = "0x3398CE0", Offset = "0x33980E0", Length = "0x3D1")]
	[Token(Token = "0x6000A0E")]
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	[Address(RVA = "0x33990C0", Offset = "0x33984C0", Length = "0x1D5")]
	[Token(Token = "0x6000A11")]
	private void ExecuteElasticSpringAnimation() { }

	[Address(RVA = "0x339FE90", Offset = "0x339F290", Length = "0xA")]
	[Token(Token = "0x60009F3")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x339FEA0", Offset = "0x339F2A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009F0")]
	public VisualElement get_contentViewport() { }

	[Address(RVA = "0x1665B70", Offset = "0x1664F70", Length = "0xA")]
	[Token(Token = "0x60009C7")]
	public long get_elasticAnimationIntervalMs() { }

	[Address(RVA = "0x339FEB0", Offset = "0x339F2B0", Length = "0xB")]
	[Token(Token = "0x60009DC")]
	public float get_elasticity() { }

	[Address(RVA = "0x339FEC0", Offset = "0x339F2C0", Length = "0x14")]
	[Token(Token = "0x60009D9")]
	private bool get_hasInertia() { }

	[Address(RVA = "0x339FEE0", Offset = "0x339F2E0", Length = "0xB")]
	[Token(Token = "0x60009D1")]
	public float get_horizontalPageSize() { }

	[Address(RVA = "0x32A66B0", Offset = "0x32A5AB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009F1")]
	public Scroller get_horizontalScroller() { }

	[Address(RVA = "0x339FEF0", Offset = "0x339F2F0", Length = "0x9")]
	[Token(Token = "0x60009C3")]
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	[Address(RVA = "0x339FF00", Offset = "0x339F300", Length = "0x61")]
	[Token(Token = "0x60009CE")]
	internal bool get_isHorizontalScrollDisplayed() { }

	[Address(RVA = "0x339FF70", Offset = "0x339F370", Length = "0x61")]
	[Token(Token = "0x60009CD")]
	internal bool get_isVerticalScrollDisplayed() { }

	[Address(RVA = "0x339FFE0", Offset = "0x339F3E0", Length = "0x7")]
	[Token(Token = "0x60009F6")]
	public ScrollViewMode get_mode() { }

	[Address(RVA = "0x339FFF0", Offset = "0x339F3F0", Length = "0xB")]
	[Token(Token = "0x60009D5")]
	public float get_mouseWheelScrollSize() { }

	[Address(RVA = "0x33A0000", Offset = "0x339F400", Length = "0x46")]
	[Token(Token = "0x60009CB")]
	internal bool get_needsHorizontal() { }

	[Address(RVA = "0x33A0050", Offset = "0x339F450", Length = "0x46")]
	[Token(Token = "0x60009CC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool get_needsVertical() { }

	[Address(RVA = "0x32A6670", Offset = "0x32A5A70", Length = "0x7")]
	[Token(Token = "0x60009E0")]
	public NestedInteractionKind get_nestedInteractionKind() { }

	[Address(RVA = "0x33A00B0", Offset = "0x339F4B0", Length = "0xA2")]
	[Token(Token = "0x60009D8")]
	internal float get_scrollableHeight() { }

	[Address(RVA = "0x33A0160", Offset = "0x339F560", Length = "0xA2")]
	[Token(Token = "0x60009D7")]
	internal float get_scrollableWidth() { }

	[Address(RVA = "0x33A00A0", Offset = "0x339F4A0", Length = "0xB")]
	[Token(Token = "0x60009DA")]
	public float get_scrollDecelerationRate() { }

	[Address(RVA = "0x1698D90", Offset = "0x1698190", Length = "0x19")]
	[Token(Token = "0x60009CF")]
	public Vector2 get_scrollOffset() { }

	[Address(RVA = "0x33A0210", Offset = "0x339F610", Length = "0x9")]
	[Token(Token = "0x60009DE")]
	public TouchScrollBehavior get_touchScrollBehavior() { }

	[Address(RVA = "0x33A0220", Offset = "0x339F620", Length = "0xB")]
	[Token(Token = "0x60009D3")]
	public float get_verticalPageSize() { }

	[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009F2")]
	public Scroller get_verticalScroller() { }

	[Address(RVA = "0x33A0230", Offset = "0x339F630", Length = "0x9")]
	[Token(Token = "0x60009C5")]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[Address(RVA = "0x33992A0", Offset = "0x33986A0", Length = "0x65")]
	[Token(Token = "0x60009EF")]
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	[Address(RVA = "0x3399310", Offset = "0x3398710", Length = "0x2E6")]
	[Token(Token = "0x60009ED")]
	private float GetXDeltaOffset(VisualElement child) { }

	[Address(RVA = "0x3399600", Offset = "0x3398A00", Length = "0x2F5")]
	[Token(Token = "0x60009EE")]
	private float GetYDeltaOffset(VisualElement child) { }

	[Address(RVA = "0x3399900", Offset = "0x3398D00", Length = "0x346")]
	[Token(Token = "0x6000A0D")]
	internal void InitTouchScrolling(Vector2 position) { }

	[Address(RVA = "0x3399C50", Offset = "0x3399050", Length = "0x8")]
	[Token(Token = "0x6000A17")]
	private void MarkSingleLineHeightDirty() { }

	[Address(RVA = "0x3399C60", Offset = "0x3399060", Length = "0x4E4")]
	[Token(Token = "0x60009F9")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x339A150", Offset = "0x3399550", Length = "0x4DD")]
	[Token(Token = "0x60009FA")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x339A630", Offset = "0x3399A30", Length = "0x33D")]
	[Token(Token = "0x60009FD")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x339A970", Offset = "0x3399D70", Length = "0xA9")]
	[Token(Token = "0x60009E2")]
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x339AA20", Offset = "0x3399E20", Length = "0x11")]
	[Token(Token = "0x6000A01")]
	private void OnHorizontalScrollerSetValueWithoutNotify(float value) { }

	[Address(RVA = "0x339AA40", Offset = "0x3399E40", Length = "0xAC")]
	[Token(Token = "0x60009FF")]
	private void OnHorizontalSliderViewDataRestored() { }

	[Address(RVA = "0x339AAF0", Offset = "0x3399EF0", Length = "0x6A")]
	[Token(Token = "0x6000A0B")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x339AC50", Offset = "0x339A050", Length = "0xB9")]
	[Token(Token = "0x60009FB")]
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	[Address(RVA = "0x339AB60", Offset = "0x3399F60", Length = "0xE6")]
	[Token(Token = "0x60009FC")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x339AD10", Offset = "0x339A110", Length = "0x22B")]
	[Token(Token = "0x6000A09")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x339AF40", Offset = "0x339A340", Length = "0x25A")]
	[Token(Token = "0x6000A0A")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x339B1A0", Offset = "0x339A5A0", Length = "0xAF")]
	[Token(Token = "0x6000A0C")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x3399C50", Offset = "0x3399050", Length = "0x8")]
	[Token(Token = "0x6000A16")]
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x339B250", Offset = "0x339A650", Length = "0x8")]
	[Token(Token = "0x6000A18")]
	private void OnRootPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x339B800", Offset = "0x339AC00", Length = "0x208")]
	[Token(Token = "0x6000A14")]
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x339B260", Offset = "0x339A660", Length = "0x594")]
	[Token(Token = "0x6000A15")]
	private void OnScrollWheel(WheelEvent evt) { }

	[Address(RVA = "0x339BA10", Offset = "0x339AE10", Length = "0xA9")]
	[Token(Token = "0x60009E3")]
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x339BAC0", Offset = "0x339AEC0", Length = "0x11")]
	[Token(Token = "0x6000A00")]
	private void OnVerticalScrollerSetValueWithoutNotify(float value) { }

	[Address(RVA = "0x339BAE0", Offset = "0x339AEE0", Length = "0xAC")]
	[Token(Token = "0x60009FE")]
	private void OnVerticalSliderViewDataRestored() { }

	[Address(RVA = "0x339BB90", Offset = "0x339AF90", Length = "0xD5")]
	[Token(Token = "0x6000A1C")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x339BC70", Offset = "0x339B070", Length = "0x6A")]
	[Token(Token = "0x60009EC")]
	private void PerformDeferredScrollTo() { }

	[Address(RVA = "0x339BCE0", Offset = "0x339B0E0", Length = "0x1A3")]
	[Token(Token = "0x6000A08")]
	private void PostPointerUpAnimation() { }

	[Address(RVA = "0x339BE90", Offset = "0x339B290", Length = "0x3B7")]
	[Token(Token = "0x6000A19")]
	private void ReadSingleLineHeight() { }

	[Address(RVA = "0x339C250", Offset = "0x339B650", Length = "0xF9")]
	[Token(Token = "0x6000A10")]
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	[Address(RVA = "0x339C350", Offset = "0x339B750", Length = "0xB")]
	[Token(Token = "0x6000A03")]
	private void ResetLayoutPass() { }

	[Address(RVA = "0x339C360", Offset = "0x339B760", Length = "0x11D")]
	[Token(Token = "0x6000A02")]
	private void ScheduleResetLayoutPass() { }

	[Address(RVA = "0x339C480", Offset = "0x339B880", Length = "0x21D")]
	[Token(Token = "0x60009E7")]
	public void ScrollTo(VisualElement child) { }

	[Address(RVA = "0x33A0240", Offset = "0x339F640", Length = "0x148")]
	[Token(Token = "0x60009C8")]
	public void set_elasticAnimationIntervalMs(long value) { }

	[Address(RVA = "0x33A0390", Offset = "0x339F790", Length = "0x108")]
	[Token(Token = "0x60009DD")]
	public void set_elasticity(float value) { }

	[Address(RVA = "0x33A04A0", Offset = "0x339F8A0", Length = "0xAB")]
	[Token(Token = "0x60009D2")]
	public void set_horizontalPageSize(float value) { }

	[Address(RVA = "0x33A0550", Offset = "0x339F950", Length = "0x107")]
	[Token(Token = "0x60009C4")]
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	[Address(RVA = "0x33A0660", Offset = "0x339FA60", Length = "0x93")]
	[Token(Token = "0x60009F7")]
	public void set_mode(ScrollViewMode value) { }

	[Address(RVA = "0x33A0700", Offset = "0x339FB00", Length = "0xC6")]
	[Token(Token = "0x60009D6")]
	public void set_mouseWheelScrollSize(float value) { }

	[Address(RVA = "0x33A07D0", Offset = "0x339FBD0", Length = "0x7E")]
	[Token(Token = "0x60009E1")]
	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	[Address(RVA = "0x33A0850", Offset = "0x339FC50", Length = "0x108")]
	[Token(Token = "0x60009DB")]
	public void set_scrollDecelerationRate(float value) { }

	[Address(RVA = "0x33A0960", Offset = "0x339FD60", Length = "0x2FC")]
	[Token(Token = "0x60009D0")]
	public void set_scrollOffset(Vector2 value) { }

	[Address(RVA = "0x33A0C60", Offset = "0x33A0060", Length = "0x1C")]
	[Token(Token = "0x60009C9")]
	public void set_showHorizontal(bool value) { }

	[Address(RVA = "0x33A0C80", Offset = "0x33A0080", Length = "0x1C")]
	[Token(Token = "0x60009CA")]
	public void set_showVertical(bool value) { }

	[Address(RVA = "0x33A0CA0", Offset = "0x33A00A0", Length = "0x10F")]
	[Token(Token = "0x60009DF")]
	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	[Address(RVA = "0x33A0DB0", Offset = "0x33A01B0", Length = "0xAB")]
	[Token(Token = "0x60009D4")]
	public void set_verticalPageSize(float value) { }

	[Address(RVA = "0x33A0E60", Offset = "0x33A0260", Length = "0x117")]
	[Token(Token = "0x60009C6")]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[Address(RVA = "0x339C6A0", Offset = "0x339BAA0", Length = "0x107")]
	[Token(Token = "0x6000A1B")]
	internal void SetScrollOffsetWithoutNotify(Vector2 value) { }

	[Address(RVA = "0x339C7B0", Offset = "0x339BBB0", Length = "0x48F")]
	[Token(Token = "0x60009F8")]
	private void SetScrollViewMode(ScrollViewMode mode) { }

	[Address(RVA = "0x339CC40", Offset = "0x339C040", Length = "0x6D")]
	[Token(Token = "0x60009E8")]
	private bool ShouldDeferScrollTo() { }

	[Address(RVA = "0x339CCB0", Offset = "0x339C0B0", Length = "0x70")]
	[Token(Token = "0x60009E9")]
	private bool ShouldStopDeferredScrollTo() { }

	[Address(RVA = "0x339CD30", Offset = "0x339C130", Length = "0x1E0")]
	[Token(Token = "0x6000A06")]
	private void SpringBack() { }

	[Address(RVA = "0x339CF10", Offset = "0x339C310", Length = "0x1FE")]
	[Token(Token = "0x60009EA")]
	private void StartDeferredScrollTo(VisualElement target) { }

	[Address(RVA = "0x339D110", Offset = "0x339C510", Length = "0x8E")]
	[Token(Token = "0x60009EB")]
	private void StopDeferredScrollTo() { }

	[Address(RVA = "0x339D200", Offset = "0x339C600", Length = "0x33C")]
	[Token(Token = "0x60009E6")]
	internal void UpdateContentViewTransform() { }

	[Address(RVA = "0x339D540", Offset = "0x339C940", Length = "0x2BD")]
	[Token(Token = "0x6000A1A")]
	private void UpdateElasticBehaviour() { }

	[Address(RVA = "0x339D800", Offset = "0x339CC00", Length = "0x13C")]
	[Token(Token = "0x60009E4")]
	private void UpdateHorizontalSliderPageSize() { }

	[Address(RVA = "0x339D940", Offset = "0x339CD40", Length = "0x54A")]
	[Token(Token = "0x6000A13")]
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	[Address(RVA = "0x339DE90", Offset = "0x339D290", Length = "0x13C")]
	[Token(Token = "0x60009E5")]
	private void UpdateVerticalSliderPageSize() { }

}

