namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Selectable", 35)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
[Token(Token = "0x2000069")]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[Token(Token = "0x200006B")]
	internal enum SelectionState : int
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	[Token(Token = "0x200006A")]
	internal enum Transition : int
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	[Token(Token = "0x4000207")]
	protected static Selectable[] s_Selectables; //Field offset: 0x0
	[Token(Token = "0x4000208")]
	protected static int s_SelectableCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000209")]
	private bool m_EnableCalled; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	[Token(Token = "0x400020A")]
	private Navigation m_Navigation; //Field offset: 0x28
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("transition")]
	[SerializeField]
	[Token(Token = "0x400020B")]
	private Transition m_Transition; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("colors")]
	[SerializeField]
	[Token(Token = "0x400020C")]
	private ColorBlock m_Colors; //Field offset: 0x54
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	[Token(Token = "0x400020D")]
	private SpriteState m_SpriteState; //Field offset: 0xB0
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	[Token(Token = "0x400020E")]
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400020F")]
	[Tooltip("Can the Selectable be interacted with?")]
	private bool m_Interactable; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	[Token(Token = "0x4000210")]
	private Graphic m_TargetGraphic; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000211")]
	private bool m_GroupsAllowInteraction; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000212")]
	protected int m_CurrentIndex; //Field offset: 0xEC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000213")]
	private bool <isPointerInside>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x4000214")]
	private bool <isPointerDown>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF2")]
	[Token(Token = "0x4000215")]
	private bool <hasSelection>k__BackingField; //Field offset: 0xF2
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000216")]
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xF8

	[Token(Token = "0x17000118")]
	public static int allSelectableCount
	{
		[Address(RVA = "0x3458870", Offset = "0x3457C70", Length = "0x4E")]
		[Token(Token = "0x600042A")]
		 get { } //Length: 78
	}

	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	[Token(Token = "0x17000119")]
	public static List<Selectable> allSelectables
	{
		[Address(RVA = "0x3458950", Offset = "0x3457D50", Length = "0xFF")]
		[Token(Token = "0x600042B")]
		 get { } //Length: 255
	}

	[Token(Token = "0x17000117")]
	public static Selectable[] allSelectablesArray
	{
		[Address(RVA = "0x34588C0", Offset = "0x3457CC0", Length = "0x8F")]
		[Token(Token = "0x6000429")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700011E")]
	public AnimationTriggers animationTriggers
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x6000435")]
		 get { } //Length: 8
		[Address(RVA = "0x3458BE0", Offset = "0x3457FE0", Length = "0x5B")]
		[Token(Token = "0x6000436")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000125")]
	public Animator animator
	{
		[Address(RVA = "0x3458A50", Offset = "0x3457E50", Length = "0x39")]
		[Token(Token = "0x6000444")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700011C")]
	public ColorBlock colors
	{
		[Address(RVA = "0x3458A90", Offset = "0x3457E90", Length = "0x3E")]
		[Token(Token = "0x6000431")]
		 get { } //Length: 62
		[Address(RVA = "0x3458C40", Offset = "0x3458040", Length = "0x9A")]
		[Token(Token = "0x6000432")]
		 set { } //Length: 154
	}

	[Token(Token = "0x17000126")]
	protected SelectionState currentSelectionState
	{
		[Address(RVA = "0x3458AD0", Offset = "0x3457ED0", Length = "0x64")]
		[Token(Token = "0x600044F")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000123")]
	private bool hasSelection
	{
		[Address(RVA = "0x213FE80", Offset = "0x213F280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600043F")]
		private get { } //Length: 8
		[Address(RVA = "0x2140010", Offset = "0x213F410", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000440")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000124")]
	public Image image
	{
		[Address(RVA = "0x3458B40", Offset = "0x3457F40", Length = "0x75")]
		[Token(Token = "0x6000442")]
		 get { } //Length: 117
		[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
		[Token(Token = "0x6000443")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000120")]
	public bool interactable
	{
		[Address(RVA = "0x2490D80", Offset = "0x2490180", Length = "0x8")]
		[Token(Token = "0x6000439")]
		 get { } //Length: 8
		[Address(RVA = "0x3458CE0", Offset = "0x34580E0", Length = "0x168")]
		[Token(Token = "0x600043A")]
		 set { } //Length: 360
	}

	[Token(Token = "0x17000122")]
	private bool isPointerDown
	{
		[Address(RVA = "0x2140000", Offset = "0x213F400", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600043D")]
		private get { } //Length: 8
		[Address(RVA = "0x3458E50", Offset = "0x3458250", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600043E")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000121")]
	private bool isPointerInside
	{
		[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600043B")]
		private get { } //Length: 8
		[Address(RVA = "0x3312AA0", Offset = "0x3311EA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600043C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700011A")]
	public Navigation navigation
	{
		[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
		[Token(Token = "0x600042D")]
		 get { } //Length: 29
		[Address(RVA = "0x3458E60", Offset = "0x3458260", Length = "0x76")]
		[Token(Token = "0x600042E")]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700011D")]
	public SpriteState spriteState
	{
		[Address(RVA = "0x3458BC0", Offset = "0x3457FC0", Length = "0x19")]
		[Token(Token = "0x6000433")]
		 get { } //Length: 25
		[Address(RVA = "0x3458EE0", Offset = "0x34582E0", Length = "0x6E")]
		[Token(Token = "0x6000434")]
		 set { } //Length: 110
	}

	[Token(Token = "0x1700011F")]
	public Graphic targetGraphic
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x6000437")]
		 get { } //Length: 8
		[Address(RVA = "0x3458F50", Offset = "0x3458350", Length = "0x5B")]
		[Token(Token = "0x6000438")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700011B")]
	public Transition transition
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600042F")]
		 get { } //Length: 4
		[Address(RVA = "0x3458FB0", Offset = "0x34583B0", Length = "0x56")]
		[Token(Token = "0x6000430")]
		 set { } //Length: 86
	}

	[Address(RVA = "0x3458660", Offset = "0x3457A60", Length = "0x7E")]
	[Token(Token = "0x6000467")]
	private static Selectable() { }

	[Address(RVA = "0x34586E0", Offset = "0x3457AE0", Length = "0x181")]
	[Token(Token = "0x6000441")]
	protected Selectable() { }

	[Address(RVA = "0x3456000", Offset = "0x3455400", Length = "0xCA")]
	[Token(Token = "0x600042C")]
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	[Address(RVA = "0x34560D0", Offset = "0x34554D0", Length = "0x92")]
	[Token(Token = "0x6000445")]
	protected virtual void Awake() { }

	[Address(RVA = "0x3456170", Offset = "0x3455570", Length = "0x96")]
	[Token(Token = "0x600045B")]
	private void DoSpriteSwap(Sprite newSprite) { }

	[Address(RVA = "0x3456210", Offset = "0x3455610", Length = "0x284")]
	[Token(Token = "0x6000451")]
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x34564A0", Offset = "0x34558A0", Length = "0x6B")]
	[Token(Token = "0x600045F")]
	private void EvaluateAndTransitionToSelectionState() { }

	[Address(RVA = "0x3456890", Offset = "0x3455C90", Length = "0x83B")]
	[Token(Token = "0x6000452")]
	public Selectable FindSelectable(Vector3 dir) { }

	[Address(RVA = "0x3456510", Offset = "0x3455910", Length = "0xDD")]
	[Token(Token = "0x6000458")]
	public override Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x34565F0", Offset = "0x34559F0", Length = "0xDD")]
	[Token(Token = "0x6000455")]
	public override Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x34566D0", Offset = "0x3455AD0", Length = "0xDD")]
	[Token(Token = "0x6000456")]
	public override Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x34567B0", Offset = "0x3455BB0", Length = "0xDD")]
	[Token(Token = "0x6000457")]
	public override Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x3458870", Offset = "0x3457C70", Length = "0x4E")]
	[Token(Token = "0x600042A")]
	public static int get_allSelectableCount() { }

	[Address(RVA = "0x3458950", Offset = "0x3457D50", Length = "0xFF")]
	[Token(Token = "0x600042B")]
	public static List<Selectable> get_allSelectables() { }

	[Address(RVA = "0x34588C0", Offset = "0x3457CC0", Length = "0x8F")]
	[Token(Token = "0x6000429")]
	public static Selectable[] get_allSelectablesArray() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x6000435")]
	public AnimationTriggers get_animationTriggers() { }

	[Address(RVA = "0x3458A50", Offset = "0x3457E50", Length = "0x39")]
	[Token(Token = "0x6000444")]
	public Animator get_animator() { }

	[Address(RVA = "0x3458A90", Offset = "0x3457E90", Length = "0x3E")]
	[Token(Token = "0x6000431")]
	public ColorBlock get_colors() { }

	[Address(RVA = "0x3458AD0", Offset = "0x3457ED0", Length = "0x64")]
	[Token(Token = "0x600044F")]
	protected SelectionState get_currentSelectionState() { }

	[Address(RVA = "0x213FE80", Offset = "0x213F280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600043F")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x3458B40", Offset = "0x3457F40", Length = "0x75")]
	[Token(Token = "0x6000442")]
	public Image get_image() { }

	[Address(RVA = "0x2490D80", Offset = "0x2490180", Length = "0x8")]
	[Token(Token = "0x6000439")]
	public bool get_interactable() { }

	[Address(RVA = "0x2140000", Offset = "0x213F400", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600043D")]
	private bool get_isPointerDown() { }

	[Address(RVA = "0x213FF10", Offset = "0x213F310", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600043B")]
	private bool get_isPointerInside() { }

	[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
	[Token(Token = "0x600042D")]
	public Navigation get_navigation() { }

	[Address(RVA = "0x3458BC0", Offset = "0x3457FC0", Length = "0x19")]
	[Token(Token = "0x6000433")]
	public SpriteState get_spriteState() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x6000437")]
	public Graphic get_targetGraphic() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x600042F")]
	public Transition get_transition() { }

	[Address(RVA = "0x34570D0", Offset = "0x34564D0", Length = "0x247")]
	[Token(Token = "0x6000453")]
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	[Address(RVA = "0x3457320", Offset = "0x3456720", Length = "0x114")]
	[Token(Token = "0x6000450")]
	protected override void InstantClearState() { }

	[Address(RVA = "0x3457440", Offset = "0x3456840", Length = "0x64")]
	[Token(Token = "0x600045D")]
	protected bool IsHighlighted() { }

	[Address(RVA = "0x34574B0", Offset = "0x34568B0", Length = "0x14")]
	[Token(Token = "0x6000448")]
	public override bool IsInteractable() { }

	[Address(RVA = "0x34574D0", Offset = "0x34568D0", Length = "0x4F")]
	[Token(Token = "0x600045E")]
	protected bool IsPressed() { }

	[Address(RVA = "0x3457520", Offset = "0x3456920", Length = "0x9E")]
	[Token(Token = "0x6000454")]
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	[Address(RVA = "0x34575C0", Offset = "0x34569C0", Length = "0x62")]
	[Token(Token = "0x600044E")]
	private void OnApplicationFocus(bool hasFocus) { }

	[Address(RVA = "0x3457630", Offset = "0x3456A30", Length = "0x33")]
	[Token(Token = "0x6000446")]
	protected virtual void OnCanvasGroupChanged() { }

	[Address(RVA = "0x3457670", Offset = "0x3456A70", Length = "0x72")]
	[Token(Token = "0x6000465")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x34576F0", Offset = "0x3456AF0", Length = "0x7")]
	[Token(Token = "0x6000449")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x3457700", Offset = "0x3456B00", Length = "0x1A6")]
	[Token(Token = "0x600044D")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x34578B0", Offset = "0x3456CB0", Length = "0x31F")]
	[Token(Token = "0x600044A")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3457BD0", Offset = "0x3456FD0", Length = "0x122")]
	[Token(Token = "0x6000459")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x3457D00", Offset = "0x3457100", Length = "0x125")]
	[Token(Token = "0x6000460")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x3457E30", Offset = "0x3457230", Length = "0x72")]
	[Token(Token = "0x6000462")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x3457EB0", Offset = "0x34572B0", Length = "0x72")]
	[Token(Token = "0x6000463")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x3457F30", Offset = "0x3457330", Length = "0x2E")]
	[Token(Token = "0x6000461")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x3457F60", Offset = "0x3457360", Length = "0x72")]
	[Token(Token = "0x6000464")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x3457FE0", Offset = "0x34573E0", Length = "0x71")]
	[Token(Token = "0x600044C")]
	private void OnSetProperty() { }

	[Address(RVA = "0x3458060", Offset = "0x3457460", Length = "0x2C")]
	[Token(Token = "0x600044B")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x3458090", Offset = "0x3457490", Length = "0x18E")]
	[Token(Token = "0x6000447")]
	private bool ParentGroupAllowsInteraction() { }

	[Address(RVA = "0x3458220", Offset = "0x3457620", Length = "0xED")]
	[Token(Token = "0x6000466")]
	public override void Select() { }

	[Address(RVA = "0x3458BE0", Offset = "0x3457FE0", Length = "0x5B")]
	[Token(Token = "0x6000436")]
	public void set_animationTriggers(AnimationTriggers value) { }

	[Address(RVA = "0x3458C40", Offset = "0x3458040", Length = "0x9A")]
	[Token(Token = "0x6000432")]
	public void set_colors(ColorBlock value) { }

	[Address(RVA = "0x2140010", Offset = "0x213F410", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000440")]
	private void set_hasSelection(bool value) { }

	[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
	[Token(Token = "0x6000443")]
	public void set_image(Image value) { }

	[Address(RVA = "0x3458CE0", Offset = "0x34580E0", Length = "0x168")]
	[Token(Token = "0x600043A")]
	public void set_interactable(bool value) { }

	[Address(RVA = "0x3458E50", Offset = "0x3458250", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600043E")]
	private void set_isPointerDown(bool value) { }

	[Address(RVA = "0x3312AA0", Offset = "0x3311EA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600043C")]
	private void set_isPointerInside(bool value) { }

	[Address(RVA = "0x3458E60", Offset = "0x3458260", Length = "0x76")]
	[Token(Token = "0x600042E")]
	public void set_navigation(Navigation value) { }

	[Address(RVA = "0x3458EE0", Offset = "0x34582E0", Length = "0x6E")]
	[Token(Token = "0x6000434")]
	public void set_spriteState(SpriteState value) { }

	[Address(RVA = "0x3458F50", Offset = "0x3458350", Length = "0x5B")]
	[Token(Token = "0x6000438")]
	public void set_targetGraphic(Graphic value) { }

	[Address(RVA = "0x3458FB0", Offset = "0x34583B0", Length = "0x56")]
	[Token(Token = "0x6000430")]
	public void set_transition(Transition value) { }

	[Address(RVA = "0x3458310", Offset = "0x3457710", Length = "0xF2")]
	[Token(Token = "0x600045A")]
	private void StartColorTween(Color targetColor, bool instant) { }

	[Address(RVA = "0x3458410", Offset = "0x3457810", Length = "0x24C")]
	[Token(Token = "0x600045C")]
	private void TriggerAnimation(string triggername) { }

}

