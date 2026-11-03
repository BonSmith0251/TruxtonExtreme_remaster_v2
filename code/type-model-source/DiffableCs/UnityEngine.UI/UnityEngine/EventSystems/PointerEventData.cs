namespace UnityEngine.EventSystems;

[Token(Token = "0x200009D")]
public class PointerEventData : BaseEventData
{
	[Token(Token = "0x200009F")]
	internal enum FramePressState : int
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	[Token(Token = "0x200009E")]
	internal enum InputButton : int
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D2")]
	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D3")]
	private GameObject m_PointerPress; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D4")]
	private GameObject <lastPress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D5")]
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D6")]
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D7")]
	private GameObject <pointerClick>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002D8")]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40002D9")]
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0xC0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40002DA")]
	public List<GameObject> hovered; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40002DB")]
	private bool <eligibleForClick>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40002DC")]
	private int <displayIndex>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40002DD")]
	private int <pointerId>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40002DE")]
	private Vector2 <position>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40002DF")]
	private Vector2 <delta>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40002E0")]
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40002E1")]
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40002E2")]
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x40002E3")]
	private float <clickTime>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40002E4")]
	private int <clickCount>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x40002E5")]
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0x17C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x40002E6")]
	private bool <useDragThreshold>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	[FieldOffset(Offset = "0x185")]
	[Token(Token = "0x40002E7")]
	private bool <dragging>k__BackingField; //Field offset: 0x185
	[CompilerGenerated]
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40002E8")]
	private InputButton <button>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x40002E9")]
	private float <pressure>k__BackingField; //Field offset: 0x18C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40002EA")]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x40002EB")]
	private float <altitudeAngle>k__BackingField; //Field offset: 0x194
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40002EC")]
	private float <azimuthAngle>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x40002ED")]
	private float <twist>k__BackingField; //Field offset: 0x19C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40002EE")]
	private Vector2 <tilt>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40002EF")]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x40002F0")]
	private Vector2 <radius>k__BackingField; //Field offset: 0x1AC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x40002F1")]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x1B4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40002F2")]
	private bool <fullyExited>k__BackingField; //Field offset: 0x1BC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x40002F3")]
	private bool <reentered>k__BackingField; //Field offset: 0x1BD

	[Token(Token = "0x170001B8")]
	public float altitudeAngle
	{
		[Address(RVA = "0x346C630", Offset = "0x346BA30", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000667")]
		 get { } //Length: 9
		[Address(RVA = "0x1D64B80", Offset = "0x1D63F80", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000668")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B9")]
	public float azimuthAngle
	{
		[Address(RVA = "0x2ED7810", Offset = "0x2ED6C10", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000669")]
		 get { } //Length: 9
		[Address(RVA = "0x3180DA0", Offset = "0x31801A0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600066A")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B5")]
	public InputButton button
	{
		[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000661")]
		 get { } //Length: 7
		[Address(RVA = "0x346C9F0", Offset = "0x346BDF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000662")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B1")]
	public int clickCount
	{
		[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000659")]
		 get { } //Length: 7
		[Address(RVA = "0x346CA00", Offset = "0x346BE00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600065A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B0")]
	public float clickTime
	{
		[Address(RVA = "0x346C640", Offset = "0x346BA40", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000657")]
		 get { } //Length: 9
		[Address(RVA = "0x346CA10", Offset = "0x346BE10", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000658")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001AC")]
	public Vector2 delta
	{
		[Address(RVA = "0x346C650", Offset = "0x346BA50", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x600064F")]
		 get { } //Length: 25
		[Address(RVA = "0x346CA20", Offset = "0x346BE20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000650")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001A9")]
	public int displayIndex
	{
		[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000649")]
		 get { } //Length: 7
		[Address(RVA = "0x346CA30", Offset = "0x346BE30", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600064A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B4")]
	public bool dragging
	{
		[Address(RVA = "0x346C670", Offset = "0x346BA70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600065F")]
		 get { } //Length: 8
		[Address(RVA = "0x346CA40", Offset = "0x346BE40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000660")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A8")]
	public bool eligibleForClick
	{
		[Address(RVA = "0x346C680", Offset = "0x346BA80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000647")]
		 get { } //Length: 8
		[Address(RVA = "0x346CA50", Offset = "0x346BE50", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000648")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001C1")]
	public Camera enterEventCamera
	{
		[Address(RVA = "0x346C690", Offset = "0x346BA90", Length = "0x98")]
		[Token(Token = "0x600067C")]
		 get { } //Length: 152
	}

	[Token(Token = "0x170001BF")]
	public bool fullyExited
	{
		[Address(RVA = "0x346C730", Offset = "0x346BB30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000675")]
		 get { } //Length: 8
		[Address(RVA = "0x346CA60", Offset = "0x346BE60", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000676")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A2")]
	public private GameObject lastPress
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600063B")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600063C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001BC")]
	public PenStatus penStatus
	{
		[Address(RVA = "0x346C740", Offset = "0x346BB40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600066F")]
		 get { } //Length: 7
		[Address(RVA = "0x1D4B680", Offset = "0x1D4AA80", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000670")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001A5")]
	public GameObject pointerClick
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000641")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000642")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001A6")]
	public RaycastResult pointerCurrentRaycast
	{
		[Address(RVA = "0x346C750", Offset = "0x346BB50", Length = "0x47")]
		[CompilerGenerated]
		[Token(Token = "0x6000643")]
		 get { } //Length: 71
		[Address(RVA = "0x346CA70", Offset = "0x346BE70", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000644")]
		 set { } //Length: 78
	}

	[Token(Token = "0x170001A4")]
	public GameObject pointerDrag
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600063F")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000640")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001A1")]
	public GameObject pointerEnter
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000639")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600063A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001AA")]
	public int pointerId
	{
		[Address(RVA = "0x346C7A0", Offset = "0x346BBA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600064B")]
		 get { } //Length: 7
		[Address(RVA = "0x1CDB770", Offset = "0x1CDAB70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600064C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001C3")]
	public GameObject pointerPress
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600067E")]
		 get { } //Length: 5
		[Address(RVA = "0x346CB20", Offset = "0x346BF20", Length = "0x8D")]
		[Token(Token = "0x600067F")]
		 set { } //Length: 141
	}

	[Token(Token = "0x170001A7")]
	public RaycastResult pointerPressRaycast
	{
		[Address(RVA = "0x346C7B0", Offset = "0x346BBB0", Length = "0x50")]
		[CompilerGenerated]
		[Token(Token = "0x6000645")]
		 get { } //Length: 80
		[Address(RVA = "0x346CAC0", Offset = "0x346BEC0", Length = "0x5A")]
		[CompilerGenerated]
		[Token(Token = "0x6000646")]
		 set { } //Length: 90
	}

	[Token(Token = "0x170001AB")]
	public Vector2 position
	{
		[Address(RVA = "0x346C800", Offset = "0x346BC00", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x600064D")]
		 get { } //Length: 25
		[Address(RVA = "0x346CBB0", Offset = "0x346BFB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600064E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001C2")]
	public Camera pressEventCamera
	{
		[Address(RVA = "0x346C820", Offset = "0x346BC20", Length = "0x9E")]
		[Token(Token = "0x600067D")]
		 get { } //Length: 158
	}

	[Token(Token = "0x170001AD")]
	public Vector2 pressPosition
	{
		[Address(RVA = "0x346C8C0", Offset = "0x346BCC0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000651")]
		 get { } //Length: 25
		[Address(RVA = "0x346CBC0", Offset = "0x346BFC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000652")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B6")]
	public float pressure
	{
		[Address(RVA = "0x346C8E0", Offset = "0x346BCE0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000663")]
		 get { } //Length: 9
		[Address(RVA = "0x346CBD0", Offset = "0x346BFD0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000664")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001BD")]
	public Vector2 radius
	{
		[Address(RVA = "0x346C910", Offset = "0x346BD10", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000671")]
		 get { } //Length: 25
		[Address(RVA = "0x346CBF0", Offset = "0x346BFF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000672")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001BE")]
	public Vector2 radiusVariance
	{
		[Address(RVA = "0x346C8F0", Offset = "0x346BCF0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000673")]
		 get { } //Length: 25
		[Address(RVA = "0x346CBE0", Offset = "0x346BFE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000674")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001A3")]
	public GameObject rawPointerPress
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600063D")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600063E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001C0")]
	public bool reentered
	{
		[Address(RVA = "0x346C930", Offset = "0x346BD30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000677")]
		 get { } //Length: 8
		[Address(RVA = "0x346CC00", Offset = "0x346C000", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000678")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B2")]
	public Vector2 scrollDelta
	{
		[Address(RVA = "0x346C940", Offset = "0x346BD40", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x600065B")]
		 get { } //Length: 25
		[Address(RVA = "0x346CC10", Offset = "0x346C010", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600065C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B7")]
	public float tangentialPressure
	{
		[Address(RVA = "0x346C960", Offset = "0x346BD60", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000665")]
		 get { } //Length: 9
		[Address(RVA = "0x3181000", Offset = "0x3180400", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000666")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001BB")]
	public Vector2 tilt
	{
		[Address(RVA = "0x346C970", Offset = "0x346BD70", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x600066D")]
		 get { } //Length: 25
		[Address(RVA = "0x346CC20", Offset = "0x346C020", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600066E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001BA")]
	public float twist
	{
		[Address(RVA = "0x346C990", Offset = "0x346BD90", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600066B")]
		 get { } //Length: 9
		[Address(RVA = "0x3180D90", Offset = "0x3180190", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600066C")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001B3")]
	public bool useDragThreshold
	{
		[Address(RVA = "0x346C9A0", Offset = "0x346BDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600065D")]
		 get { } //Length: 8
		[Address(RVA = "0x3305340", Offset = "0x3304740", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600065E")]
		 set { } //Length: 7
	}

	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	[Token(Token = "0x170001AF")]
	public Vector3 worldNormal
	{
		[Address(RVA = "0x346C9B0", Offset = "0x346BDB0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000655")]
		 get { } //Length: 25
		[Address(RVA = "0x346CC30", Offset = "0x346C030", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000656")]
		 set { } //Length: 22
	}

	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	[Token(Token = "0x170001AE")]
	public Vector3 worldPosition
	{
		[Address(RVA = "0x346C9D0", Offset = "0x346BDD0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000653")]
		 get { } //Length: 25
		[Address(RVA = "0x346CC50", Offset = "0x346C050", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000654")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x346C3D0", Offset = "0x346B7D0", Length = "0x25A")]
	[Token(Token = "0x6000679")]
	public PointerEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x346C630", Offset = "0x346BA30", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000667")]
	public float get_altitudeAngle() { }

	[Address(RVA = "0x2ED7810", Offset = "0x2ED6C10", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000669")]
	public float get_azimuthAngle() { }

	[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000661")]
	public InputButton get_button() { }

	[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000659")]
	public int get_clickCount() { }

	[Address(RVA = "0x346C640", Offset = "0x346BA40", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000657")]
	public float get_clickTime() { }

	[Address(RVA = "0x346C650", Offset = "0x346BA50", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x600064F")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000649")]
	public int get_displayIndex() { }

	[Address(RVA = "0x346C670", Offset = "0x346BA70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600065F")]
	public bool get_dragging() { }

	[Address(RVA = "0x346C680", Offset = "0x346BA80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000647")]
	public bool get_eligibleForClick() { }

	[Address(RVA = "0x346C690", Offset = "0x346BA90", Length = "0x98")]
	[Token(Token = "0x600067C")]
	public Camera get_enterEventCamera() { }

	[Address(RVA = "0x346C730", Offset = "0x346BB30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000675")]
	public bool get_fullyExited() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600063B")]
	public GameObject get_lastPress() { }

	[Address(RVA = "0x346C740", Offset = "0x346BB40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600066F")]
	public PenStatus get_penStatus() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000641")]
	public GameObject get_pointerClick() { }

	[Address(RVA = "0x346C750", Offset = "0x346BB50", Length = "0x47")]
	[CompilerGenerated]
	[Token(Token = "0x6000643")]
	public RaycastResult get_pointerCurrentRaycast() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600063F")]
	public GameObject get_pointerDrag() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000639")]
	public GameObject get_pointerEnter() { }

	[Address(RVA = "0x346C7A0", Offset = "0x346BBA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600064B")]
	public int get_pointerId() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600067E")]
	public GameObject get_pointerPress() { }

	[Address(RVA = "0x346C7B0", Offset = "0x346BBB0", Length = "0x50")]
	[CompilerGenerated]
	[Token(Token = "0x6000645")]
	public RaycastResult get_pointerPressRaycast() { }

	[Address(RVA = "0x346C800", Offset = "0x346BC00", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x600064D")]
	public Vector2 get_position() { }

	[Address(RVA = "0x346C820", Offset = "0x346BC20", Length = "0x9E")]
	[Token(Token = "0x600067D")]
	public Camera get_pressEventCamera() { }

	[Address(RVA = "0x346C8C0", Offset = "0x346BCC0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000651")]
	public Vector2 get_pressPosition() { }

	[Address(RVA = "0x346C8E0", Offset = "0x346BCE0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000663")]
	public float get_pressure() { }

	[Address(RVA = "0x346C910", Offset = "0x346BD10", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000671")]
	public Vector2 get_radius() { }

	[Address(RVA = "0x346C8F0", Offset = "0x346BCF0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000673")]
	public Vector2 get_radiusVariance() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600063D")]
	public GameObject get_rawPointerPress() { }

	[Address(RVA = "0x346C930", Offset = "0x346BD30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000677")]
	public bool get_reentered() { }

	[Address(RVA = "0x346C940", Offset = "0x346BD40", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x600065B")]
	public Vector2 get_scrollDelta() { }

	[Address(RVA = "0x346C960", Offset = "0x346BD60", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000665")]
	public float get_tangentialPressure() { }

	[Address(RVA = "0x346C970", Offset = "0x346BD70", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x600066D")]
	public Vector2 get_tilt() { }

	[Address(RVA = "0x346C990", Offset = "0x346BD90", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600066B")]
	public float get_twist() { }

	[Address(RVA = "0x346C9A0", Offset = "0x346BDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600065D")]
	public bool get_useDragThreshold() { }

	[Address(RVA = "0x346C9B0", Offset = "0x346BDB0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000655")]
	public Vector3 get_worldNormal() { }

	[Address(RVA = "0x346C9D0", Offset = "0x346BDD0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000653")]
	public Vector3 get_worldPosition() { }

	[Address(RVA = "0x346BC80", Offset = "0x346B080", Length = "0x26")]
	[Token(Token = "0x600067A")]
	public bool IsPointerMoving() { }

	[Address(RVA = "0x346BCB0", Offset = "0x346B0B0", Length = "0x26")]
	[Token(Token = "0x600067B")]
	public bool IsScrolling() { }

	[Address(RVA = "0x1D64B80", Offset = "0x1D63F80", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000668")]
	public void set_altitudeAngle(float value) { }

	[Address(RVA = "0x3180DA0", Offset = "0x31801A0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600066A")]
	public void set_azimuthAngle(float value) { }

	[Address(RVA = "0x346C9F0", Offset = "0x346BDF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000662")]
	public void set_button(InputButton value) { }

	[Address(RVA = "0x346CA00", Offset = "0x346BE00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600065A")]
	public void set_clickCount(int value) { }

	[Address(RVA = "0x346CA10", Offset = "0x346BE10", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000658")]
	public void set_clickTime(float value) { }

	[Address(RVA = "0x346CA20", Offset = "0x346BE20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000650")]
	public void set_delta(Vector2 value) { }

	[Address(RVA = "0x346CA30", Offset = "0x346BE30", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600064A")]
	public void set_displayIndex(int value) { }

	[Address(RVA = "0x346CA40", Offset = "0x346BE40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000660")]
	public void set_dragging(bool value) { }

	[Address(RVA = "0x346CA50", Offset = "0x346BE50", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000648")]
	public void set_eligibleForClick(bool value) { }

	[Address(RVA = "0x346CA60", Offset = "0x346BE60", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000676")]
	public void set_fullyExited(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600063C")]
	private void set_lastPress(GameObject value) { }

	[Address(RVA = "0x1D4B680", Offset = "0x1D4AA80", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000670")]
	public void set_penStatus(PenStatus value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000642")]
	public void set_pointerClick(GameObject value) { }

	[Address(RVA = "0x346CA70", Offset = "0x346BE70", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000644")]
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000640")]
	public void set_pointerDrag(GameObject value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600063A")]
	public void set_pointerEnter(GameObject value) { }

	[Address(RVA = "0x1CDB770", Offset = "0x1CDAB70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600064C")]
	public void set_pointerId(int value) { }

	[Address(RVA = "0x346CB20", Offset = "0x346BF20", Length = "0x8D")]
	[Token(Token = "0x600067F")]
	public void set_pointerPress(GameObject value) { }

	[Address(RVA = "0x346CAC0", Offset = "0x346BEC0", Length = "0x5A")]
	[CompilerGenerated]
	[Token(Token = "0x6000646")]
	public void set_pointerPressRaycast(RaycastResult value) { }

	[Address(RVA = "0x346CBB0", Offset = "0x346BFB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600064E")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x346CBC0", Offset = "0x346BFC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000652")]
	public void set_pressPosition(Vector2 value) { }

	[Address(RVA = "0x346CBD0", Offset = "0x346BFD0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000664")]
	public void set_pressure(float value) { }

	[Address(RVA = "0x346CBF0", Offset = "0x346BFF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000672")]
	public void set_radius(Vector2 value) { }

	[Address(RVA = "0x346CBE0", Offset = "0x346BFE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000674")]
	public void set_radiusVariance(Vector2 value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600063E")]
	public void set_rawPointerPress(GameObject value) { }

	[Address(RVA = "0x346CC00", Offset = "0x346C000", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000678")]
	public void set_reentered(bool value) { }

	[Address(RVA = "0x346CC10", Offset = "0x346C010", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600065C")]
	public void set_scrollDelta(Vector2 value) { }

	[Address(RVA = "0x3181000", Offset = "0x3180400", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000666")]
	public void set_tangentialPressure(float value) { }

	[Address(RVA = "0x346CC20", Offset = "0x346C020", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600066E")]
	public void set_tilt(Vector2 value) { }

	[Address(RVA = "0x3180D90", Offset = "0x3180190", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600066C")]
	public void set_twist(float value) { }

	[Address(RVA = "0x3305340", Offset = "0x3304740", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600065E")]
	public void set_useDragThreshold(bool value) { }

	[Address(RVA = "0x346CC30", Offset = "0x346C030", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000656")]
	public void set_worldNormal(Vector3 value) { }

	[Address(RVA = "0x346CC50", Offset = "0x346C050", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000654")]
	public void set_worldPosition(Vector3 value) { }

	[Address(RVA = "0x346BCE0", Offset = "0x346B0E0", Length = "0x6EC")]
	[Token(Token = "0x6000680")]
	public virtual string ToString() { }

}

