namespace UnityEngine.UI;

[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
[Token(Token = "0x200001F")]
public class GraphicRaycaster : BaseRaycaster
{
	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c
	{
		[Token(Token = "0x4000090")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000091")]
		public static Comparison<Graphic> <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x31ECCC0", Offset = "0x31EC0C0", Length = "0x67")]
		[Token(Token = "0x600012F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000130")]
		public <>c() { }

		[Address(RVA = "0x31ECB20", Offset = "0x31EBF20", Length = "0x6B")]
		[Token(Token = "0x6000131")]
		internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }

	}

	[Token(Token = "0x2000020")]
	internal enum BlockingObjects : int
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3,
	}

	[Token(Token = "0x4000084")]
	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	[Token(Token = "0x400008A")]
	private static readonly List<Graphic> s_SortedGraphics; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private BlockingObjects m_BlockingObjects; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	protected LayerMask m_BlockingMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000088")]
	private Canvas m_Canvas; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000089")]
	private List<Graphic> m_RaycastResults; //Field offset: 0x40

	[Token(Token = "0x17000047")]
	public LayerMask blockingMask
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public BlockingObjects blockingObjects
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	private Canvas canvas
	{
		[Address(RVA = "0x31DEB50", Offset = "0x31DDF50", Length = "0x8D")]
		[Token(Token = "0x600012A")]
		private get { } //Length: 141
	}

	[Token(Token = "0x17000049")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x31DEBE0", Offset = "0x31DDFE0", Length = "0xB0")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 176
	}

	[Token(Token = "0x17000045")]
	public bool ignoreReversedGraphics
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000124")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000044")]
	public virtual int renderOrderPriority
	{
		[Address(RVA = "0x31DECA0", Offset = "0x31DE0A0", Length = "0x5F")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000043")]
	public virtual int sortOrderPriority
	{
		[Address(RVA = "0x31DED00", Offset = "0x31DE100", Length = "0x50")]
		[Token(Token = "0x6000121")]
		 get { } //Length: 80
	}

	[Address(RVA = "0x31DEA30", Offset = "0x31DDE30", Length = "0x84")]
	[Token(Token = "0x600012E")]
	private static GraphicRaycaster() { }

	[Address(RVA = "0x31DEAC0", Offset = "0x31DDEC0", Length = "0x8A")]
	[Token(Token = "0x6000129")]
	protected GraphicRaycaster() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000127")]
	public LayerMask get_blockingMask() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000125")]
	public BlockingObjects get_blockingObjects() { }

	[Address(RVA = "0x31DEB50", Offset = "0x31DDF50", Length = "0x8D")]
	[Token(Token = "0x600012A")]
	private Canvas get_canvas() { }

	[Address(RVA = "0x31DEBE0", Offset = "0x31DDFE0", Length = "0xB0")]
	[Token(Token = "0x600012C")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000123")]
	public bool get_ignoreReversedGraphics() { }

	[Address(RVA = "0x31DECA0", Offset = "0x31DE0A0", Length = "0x5F")]
	[Token(Token = "0x6000122")]
	public virtual int get_renderOrderPriority() { }

	[Address(RVA = "0x31DED00", Offset = "0x31DE100", Length = "0x50")]
	[Token(Token = "0x6000121")]
	public virtual int get_sortOrderPriority() { }

	[Address(RVA = "0x31DDBA0", Offset = "0x31DCFA0", Length = "0xE8D")]
	[Token(Token = "0x600012B")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x31DD5C0", Offset = "0x31DC9C0", Length = "0x5D4")]
	[Token(Token = "0x600012D")]
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000128")]
	public void set_blockingMask(LayerMask value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x6000126")]
	public void set_blockingObjects(BlockingObjects value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000124")]
	public void set_ignoreReversedGraphics(bool value) { }

}

