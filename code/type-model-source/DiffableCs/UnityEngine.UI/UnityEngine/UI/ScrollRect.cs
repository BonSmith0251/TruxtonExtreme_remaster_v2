namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Scroll Rect", 37)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[SelectionBase]
[Token(Token = "0x2000065")]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
{
	[Token(Token = "0x2000066")]
	internal enum MovementType : int
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	[Token(Token = "0x2000067")]
	internal enum ScrollbarVisibility : int
	{
		Permanent = 0,
		AutoHide = 1,
		AutoHideAndExpandViewport = 2,
	}

	[Token(Token = "0x2000068")]
	internal class ScrollRectEvent : UnityEvent<Vector2>
	{

		[Address(RVA = "0x344F420", Offset = "0x344E820", Length = "0x39")]
		[Token(Token = "0x6000428")]
		public ScrollRectEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001DA")]
	private RectTransform m_Content; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001DB")]
	private bool m_Horizontal; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	[Token(Token = "0x40001DC")]
	private bool m_Vertical; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40001DD")]
	private MovementType m_MovementType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001DE")]
	private float m_Elasticity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40001DF")]
	private bool m_Inertia; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001E0")]
	private float m_DecelerationRate; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40001E1")]
	private float m_ScrollSensitivity; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001E2")]
	private RectTransform m_Viewport; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40001E3")]
	private Scrollbar m_HorizontalScrollbar; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	private Scrollbar m_VerticalScrollbar; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40001E5")]
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40001E6")]
	private ScrollbarVisibility m_VerticalScrollbarVisibility; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	private float m_HorizontalScrollbarSpacing; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40001E8")]
	private float m_VerticalScrollbarSpacing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40001E9")]
	private ScrollRectEvent m_OnValueChanged; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001EA")]
	private Vector2 m_PointerStartLocalCursor; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001EB")]
	protected Vector2 m_ContentStartPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001EC")]
	private RectTransform m_ViewRect; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001ED")]
	protected Bounds m_ContentBounds; //Field offset: 0x88
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001EE")]
	private Bounds m_ViewBounds; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001EF")]
	private Vector2 m_Velocity; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001F0")]
	private bool m_Dragging; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x40001F1")]
	private bool m_Scrolling; //Field offset: 0xC1
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40001F2")]
	private Vector2 m_PrevPosition; //Field offset: 0xC4
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40001F3")]
	private Bounds m_PrevContentBounds; //Field offset: 0xCC
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40001F4")]
	private Bounds m_PrevViewBounds; //Field offset: 0xE4
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40001F5")]
	private bool m_HasRebuiltLayout; //Field offset: 0xFC
	[FieldOffset(Offset = "0xFD")]
	[Token(Token = "0x40001F6")]
	private bool m_HSliderExpand; //Field offset: 0xFD
	[FieldOffset(Offset = "0xFE")]
	[Token(Token = "0x40001F7")]
	private bool m_VSliderExpand; //Field offset: 0xFE
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40001F8")]
	private float m_HSliderHeight; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40001F9")]
	private float m_VSliderWidth; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40001FA")]
	private RectTransform m_Rect; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001FB")]
	private RectTransform m_HorizontalScrollbarRect; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40001FC")]
	private RectTransform m_VerticalScrollbarRect; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001FD")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001FE")]
	private readonly Vector3[] m_Corners; //Field offset: 0x128

	[Token(Token = "0x170000F8")]
	public RectTransform content
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60003CD")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60003CE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000FE")]
	public float decelerationRate
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x60003D9")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x60003DA")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000FC")]
	public float elasticity
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 6
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[Token(Token = "0x60003D6")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000115")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000418")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000112")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000415")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000F9")]
	public bool horizontal
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60003CF")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x60003D0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010C")]
	public float horizontalNormalizedPosition
	{
		[Address(RVA = "0x3453880", Offset = "0x3452C80", Length = "0x137")]
		[Token(Token = "0x6000406")]
		 get { } //Length: 311
		[Address(RVA = "0x3453DB0", Offset = "0x34531B0", Length = "0x17")]
		[Token(Token = "0x6000407")]
		 set { } //Length: 23
	}

	[Token(Token = "0x17000101")]
	public Scrollbar horizontalScrollbar
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 5
		[Address(RVA = "0x3453DF0", Offset = "0x34531F0", Length = "0x18B")]
		[Token(Token = "0x60003E0")]
		 set { } //Length: 395
	}

	[Token(Token = "0x17000105")]
	public float horizontalScrollbarSpacing
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 6
		[Address(RVA = "0x3453DD0", Offset = "0x34531D0", Length = "0xC")]
		[Token(Token = "0x60003E8")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000103")]
	public ScrollbarVisibility horizontalScrollbarVisibility
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 4
		[Address(RVA = "0x3453DE0", Offset = "0x34531E0", Length = "0xA")]
		[Token(Token = "0x60003E4")]
		 set { } //Length: 10
	}

	[Token(Token = "0x1700010E")]
	private bool hScrollingNeeded
	{
		[Address(RVA = "0x3453800", Offset = "0x3452C00", Length = "0x79")]
		[Token(Token = "0x600040F")]
		private get { } //Length: 121
	}

	[Token(Token = "0x170000FD")]
	public bool inertia
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[Token(Token = "0x60003D8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000116")]
	public override int layoutPriority
	{
		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x6000419")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000113")]
	public override float minHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000416")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000110")]
	public override float minWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000413")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000FB")]
	public MovementType movementType
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60003D4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010B")]
	public Vector2 normalizedPosition
	{
		[Address(RVA = "0x34539C0", Offset = "0x3452DC0", Length = "0x35")]
		[Token(Token = "0x6000404")]
		 get { } //Length: 53
		[Address(RVA = "0x3453F80", Offset = "0x3453380", Length = "0x52")]
		[Token(Token = "0x6000405")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000107")]
	public ScrollRectEvent onValueChanged
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60003EC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000114")]
	public override float preferredHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000417")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000111")]
	public override float preferredWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000414")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700010A")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x3453A00", Offset = "0x3452E00", Length = "0x99")]
		[Token(Token = "0x60003F0")]
		private get { } //Length: 153
	}

	[Token(Token = "0x170000FF")]
	public float scrollSensitivity
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x60003DB")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
		[Token(Token = "0x60003DC")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000109")]
	public Vector2 velocity
	{
		[Address(RVA = "0x3453B20", Offset = "0x3452F20", Length = "0x19")]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 25
		[Address(RVA = "0x3453FE0", Offset = "0x34533E0", Length = "0x8")]
		[Token(Token = "0x60003EF")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170000FA")]
	public bool vertical
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x60003D1")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[Token(Token = "0x60003D2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010D")]
	public float verticalNormalizedPosition
	{
		[Address(RVA = "0x3453B40", Offset = "0x3452F40", Length = "0x13F")]
		[Token(Token = "0x6000408")]
		 get { } //Length: 319
		[Address(RVA = "0x3453FF0", Offset = "0x34533F0", Length = "0x1A")]
		[Token(Token = "0x6000409")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000102")]
	public Scrollbar verticalScrollbar
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60003E1")]
		 get { } //Length: 5
		[Address(RVA = "0x3454030", Offset = "0x3453430", Length = "0x18B")]
		[Token(Token = "0x60003E2")]
		 set { } //Length: 395
	}

	[Token(Token = "0x17000106")]
	public float verticalScrollbarSpacing
	{
		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[Token(Token = "0x60003E9")]
		 get { } //Length: 6
		[Address(RVA = "0x3454010", Offset = "0x3453410", Length = "0xC")]
		[Token(Token = "0x60003EA")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000104")]
	public ScrollbarVisibility verticalScrollbarVisibility
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 4
		[Address(RVA = "0x3454020", Offset = "0x3453420", Length = "0xA")]
		[Token(Token = "0x60003E6")]
		 set { } //Length: 10
	}

	[Token(Token = "0x17000100")]
	public RectTransform viewport
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60003DD")]
		 get { } //Length: 5
		[Address(RVA = "0x34541C0", Offset = "0x34535C0", Length = "0x25")]
		[Token(Token = "0x60003DE")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000108")]
	protected RectTransform viewRect
	{
		[Address(RVA = "0x3453C80", Offset = "0x3453080", Length = "0x125")]
		[Token(Token = "0x60003ED")]
		 get { } //Length: 293
	}

	[Token(Token = "0x1700010F")]
	private bool vScrollingNeeded
	{
		[Address(RVA = "0x3453AA0", Offset = "0x3452EA0", Length = "0x79")]
		[Token(Token = "0x6000410")]
		private get { } //Length: 121
	}

	[Address(RVA = "0x3453660", Offset = "0x3452A60", Length = "0x191")]
	[Token(Token = "0x60003F1")]
	protected ScrollRect() { }

	[Address(RVA = "0x344F460", Offset = "0x344E860", Length = "0x98")]
	[Token(Token = "0x6000420")]
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000411")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000412")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x344F500", Offset = "0x344E900", Length = "0x1A7")]
	[Token(Token = "0x6000423")]
	private Vector2 CalculateOffset(Vector2 delta) { }

	[Address(RVA = "0x344F6B0", Offset = "0x344EAB0", Length = "0x60")]
	[Token(Token = "0x60003F9")]
	private void EnsureLayoutHasRebuilt() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60003CD")]
	public RectTransform get_content() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x60003D9")]
	public float get_decelerationRate() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x60003D5")]
	public float get_elasticity() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000418")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000415")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60003CF")]
	public bool get_horizontal() { }

	[Address(RVA = "0x3453880", Offset = "0x3452C80", Length = "0x137")]
	[Token(Token = "0x6000406")]
	public float get_horizontalNormalizedPosition() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60003DF")]
	public Scrollbar get_horizontalScrollbar() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x60003E7")]
	public float get_horizontalScrollbarSpacing() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60003E3")]
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	[Address(RVA = "0x3453800", Offset = "0x3452C00", Length = "0x79")]
	[Token(Token = "0x600040F")]
	private bool get_hScrollingNeeded() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x60003D7")]
	public bool get_inertia() { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x6000419")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000416")]
	public override float get_minHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000413")]
	public override float get_minWidth() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60003D3")]
	public MovementType get_movementType() { }

	[Address(RVA = "0x34539C0", Offset = "0x3452DC0", Length = "0x35")]
	[Token(Token = "0x6000404")]
	public Vector2 get_normalizedPosition() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60003EB")]
	public ScrollRectEvent get_onValueChanged() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000417")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000414")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x3453A00", Offset = "0x3452E00", Length = "0x99")]
	[Token(Token = "0x60003F0")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x60003DB")]
	public float get_scrollSensitivity() { }

	[Address(RVA = "0x3453B20", Offset = "0x3452F20", Length = "0x19")]
	[Token(Token = "0x60003EE")]
	public Vector2 get_velocity() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x60003D1")]
	public bool get_vertical() { }

	[Address(RVA = "0x3453B40", Offset = "0x3452F40", Length = "0x13F")]
	[Token(Token = "0x6000408")]
	public float get_verticalNormalizedPosition() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60003E1")]
	public Scrollbar get_verticalScrollbar() { }

	[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
	[Token(Token = "0x60003E9")]
	public float get_verticalScrollbarSpacing() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60003E5")]
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60003DD")]
	public RectTransform get_viewport() { }

	[Address(RVA = "0x3453C80", Offset = "0x3453080", Length = "0x125")]
	[Token(Token = "0x60003ED")]
	protected RectTransform get_viewRect() { }

	[Address(RVA = "0x3453AA0", Offset = "0x3452EA0", Length = "0x79")]
	[Token(Token = "0x6000410")]
	private bool get_vScrollingNeeded() { }

	[Address(RVA = "0x344F710", Offset = "0x344EB10", Length = "0x127")]
	[Token(Token = "0x6000421")]
	private Bounds GetBounds() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003F4")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x344F840", Offset = "0x344EC40", Length = "0x173")]
	[Token(Token = "0x6000424")]
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	[Address(RVA = "0x344F9C0", Offset = "0x344EDC0", Length = "0x2BA")]
	[Token(Token = "0x6000422")]
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	[Address(RVA = "0x344FC80", Offset = "0x344F080", Length = "0x64")]
	[Token(Token = "0x60003F8")]
	public virtual bool IsActive() { }

	[Address(RVA = "0x344FCF0", Offset = "0x344F0F0", Length = "0x9DA")]
	[Token(Token = "0x6000401")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003F3")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x34506D0", Offset = "0x344FAD0", Length = "0x166")]
	[Token(Token = "0x60003FD")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3450840", Offset = "0x344FC40", Length = "0x234")]
	[Token(Token = "0x60003F7")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3450A80", Offset = "0x344FE80", Length = "0x2AB")]
	[Token(Token = "0x60003FF")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3450D30", Offset = "0x3450130", Length = "0x1AA")]
	[Token(Token = "0x60003F6")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3450EE0", Offset = "0x34502E0", Length = "0x23")]
	[Token(Token = "0x60003FE")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3450F10", Offset = "0x3450310", Length = "0x65")]
	[Token(Token = "0x60003FC")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3450F80", Offset = "0x3450380", Length = "0x7")]
	[Token(Token = "0x600040E")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x3450F90", Offset = "0x3450390", Length = "0x218")]
	[Token(Token = "0x60003FB")]
	public override void OnScroll(PointerEventData data) { }

	[Address(RVA = "0x34511B0", Offset = "0x34505B0", Length = "0x82")]
	[Token(Token = "0x60003F2")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x3451240", Offset = "0x3450640", Length = "0x51")]
	[Token(Token = "0x600040D")]
	private static float RubberDelta(float overStretching, float viewSize) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60003CE")]
	public void set_content(RectTransform value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x60003DA")]
	public void set_decelerationRate(float value) { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[Token(Token = "0x60003D6")]
	public void set_elasticity(float value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x60003D0")]
	public void set_horizontal(bool value) { }

	[Address(RVA = "0x3453DB0", Offset = "0x34531B0", Length = "0x17")]
	[Token(Token = "0x6000407")]
	public void set_horizontalNormalizedPosition(float value) { }

	[Address(RVA = "0x3453DF0", Offset = "0x34531F0", Length = "0x18B")]
	[Token(Token = "0x60003E0")]
	public void set_horizontalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x3453DD0", Offset = "0x34531D0", Length = "0xC")]
	[Token(Token = "0x60003E8")]
	public void set_horizontalScrollbarSpacing(float value) { }

	[Address(RVA = "0x3453DE0", Offset = "0x34531E0", Length = "0xA")]
	[Token(Token = "0x60003E4")]
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[Token(Token = "0x60003D8")]
	public void set_inertia(bool value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x60003D4")]
	public void set_movementType(MovementType value) { }

	[Address(RVA = "0x3453F80", Offset = "0x3453380", Length = "0x52")]
	[Token(Token = "0x6000405")]
	public void set_normalizedPosition(Vector2 value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60003EC")]
	public void set_onValueChanged(ScrollRectEvent value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[Token(Token = "0x60003DC")]
	public void set_scrollSensitivity(float value) { }

	[Address(RVA = "0x3453FE0", Offset = "0x34533E0", Length = "0x8")]
	[Token(Token = "0x60003EF")]
	public void set_velocity(Vector2 value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x60003D2")]
	public void set_vertical(bool value) { }

	[Address(RVA = "0x3453FF0", Offset = "0x34533F0", Length = "0x1A")]
	[Token(Token = "0x6000409")]
	public void set_verticalNormalizedPosition(float value) { }

	[Address(RVA = "0x3454030", Offset = "0x3453430", Length = "0x18B")]
	[Token(Token = "0x60003E2")]
	public void set_verticalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x3454010", Offset = "0x3453410", Length = "0xC")]
	[Token(Token = "0x60003EA")]
	public void set_verticalScrollbarSpacing(float value) { }

	[Address(RVA = "0x3454020", Offset = "0x3453420", Length = "0xA")]
	[Token(Token = "0x60003E6")]
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	[Address(RVA = "0x34541C0", Offset = "0x34535C0", Length = "0x25")]
	[Token(Token = "0x60003DE")]
	public void set_viewport(RectTransform value) { }

	[Address(RVA = "0x34512A0", Offset = "0x34506A0", Length = "0x116")]
	[Token(Token = "0x6000400")]
	protected override void SetContentAnchoredPosition(Vector2 position) { }

	[Address(RVA = "0x3451480", Offset = "0x3450880", Length = "0x76")]
	[Token(Token = "0x6000425")]
	protected void SetDirty() { }

	[Address(RVA = "0x34513C0", Offset = "0x34507C0", Length = "0xBF")]
	[Token(Token = "0x6000426")]
	protected void SetDirtyCaching() { }

	[Address(RVA = "0x3451500", Offset = "0x3450900", Length = "0x46")]
	[Token(Token = "0x600040A")]
	private void SetHorizontalNormalizedPosition(float value) { }

	[Address(RVA = "0x3451550", Offset = "0x3450950", Length = "0x79C")]
	[Token(Token = "0x600041A")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x3451CF0", Offset = "0x34510F0", Length = "0x179")]
	[Token(Token = "0x600041B")]
	public override void SetLayoutVertical() { }

	[Address(RVA = "0x3451E70", Offset = "0x3451270", Length = "0x4F7")]
	[Token(Token = "0x600040C")]
	protected override void SetNormalizedPosition(float value, int axis) { }

	[Address(RVA = "0x3452370", Offset = "0x3451770", Length = "0x49")]
	[Token(Token = "0x600040B")]
	private void SetVerticalNormalizedPosition(float value) { }

	[Address(RVA = "0x34523C0", Offset = "0x34517C0", Length = "0x52")]
	[Token(Token = "0x60003FA")]
	public override void StopMovement() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x6000427")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x3452420", Offset = "0x3451820", Length = "0x623")]
	[Token(Token = "0x600041F")]
	protected void UpdateBounds() { }

	[Address(RVA = "0x3452A50", Offset = "0x3451E50", Length = "0x3E5")]
	[Token(Token = "0x60003F5")]
	private void UpdateCachedData() { }

	[Address(RVA = "0x3452E40", Offset = "0x3452240", Length = "0xEE")]
	[Token(Token = "0x600041D")]
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	[Address(RVA = "0x3452F30", Offset = "0x3452330", Length = "0x10C")]
	[Token(Token = "0x6000402")]
	protected void UpdatePrevData() { }

	[Address(RVA = "0x3453040", Offset = "0x3452440", Length = "0x3D3")]
	[Token(Token = "0x600041E")]
	private void UpdateScrollbarLayout() { }

	[Address(RVA = "0x3453480", Offset = "0x3452880", Length = "0x1D9")]
	[Token(Token = "0x6000403")]
	private void UpdateScrollbars(Vector2 offset) { }

	[Address(RVA = "0x3453420", Offset = "0x3452820", Length = "0x5A")]
	[Token(Token = "0x600041C")]
	private void UpdateScrollbarVisibility() { }

}

