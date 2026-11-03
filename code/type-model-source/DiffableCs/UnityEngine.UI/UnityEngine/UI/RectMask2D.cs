namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Rect Mask 2D", 14)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200005F")]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B5")]
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B6")]
	private RectTransform m_RectTransform; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B7")]
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B8")]
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B9")]
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BA")]
	private List<RectMask2D> m_Clippers; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001BB")]
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001BC")]
	private bool m_ForceClip; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40001BD")]
	private Vector4 m_Padding; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40001BE")]
	private Vector2Int m_Softness; //Field offset: 0x74
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001BF")]
	private Canvas m_Canvas; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001C0")]
	private Vector3[] m_Corners; //Field offset: 0x88

	[Token(Token = "0x170000E9")]
	internal Canvas Canvas
	{
		[Address(RVA = "0x344DEA0", Offset = "0x344D2A0", Length = "0x164")]
		[Token(Token = "0x600038A")]
		internal get { } //Length: 356
	}

	[Token(Token = "0x170000EA")]
	public Rect canvasRect
	{
		[Address(RVA = "0x344E010", Offset = "0x344D410", Length = "0xB4")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 180
	}

	[Token(Token = "0x170000E7")]
	public Vector4 padding
	{
		[Address(RVA = "0x344E0D0", Offset = "0x344D4D0", Length = "0xB")]
		[Token(Token = "0x6000386")]
		 get { } //Length: 11
		[Address(RVA = "0x344E340", Offset = "0x344D740", Length = "0xE")]
		[Token(Token = "0x6000387")]
		 set { } //Length: 14
	}

	[Token(Token = "0x170000EB")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x344E0E0", Offset = "0x344D4E0", Length = "0x63")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 99
	}

	[Token(Token = "0x170000EC")]
	private Rect rootCanvasRect
	{
		[Address(RVA = "0x344E150", Offset = "0x344D550", Length = "0x1D3")]
		[Token(Token = "0x6000392")]
		private get { } //Length: 467
	}

	[Token(Token = "0x170000E8")]
	public Vector2Int softness
	{
		[Address(RVA = "0x344E330", Offset = "0x344D730", Length = "0x5")]
		[Token(Token = "0x6000388")]
		 get { } //Length: 5
		[Address(RVA = "0x344E350", Offset = "0x344D750", Length = "0x25")]
		[Token(Token = "0x6000389")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x344DD30", Offset = "0x344D130", Length = "0x16B")]
	[Token(Token = "0x600038D")]
	protected RectMask2D() { }

	[Address(RVA = "0x344CA40", Offset = "0x344BE40", Length = "0x108")]
	[Token(Token = "0x6000395")]
	public void AddClippable(IClippable clippable) { }

	[Address(RVA = "0x344DEA0", Offset = "0x344D2A0", Length = "0x164")]
	[Token(Token = "0x600038A")]
	internal Canvas get_Canvas() { }

	[Address(RVA = "0x344E010", Offset = "0x344D410", Length = "0xB4")]
	[Token(Token = "0x600038B")]
	public Rect get_canvasRect() { }

	[Address(RVA = "0x344E0D0", Offset = "0x344D4D0", Length = "0xB")]
	[Token(Token = "0x6000386")]
	public Vector4 get_padding() { }

	[Address(RVA = "0x344E0E0", Offset = "0x344D4E0", Length = "0x63")]
	[Token(Token = "0x600038C")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x344E150", Offset = "0x344D550", Length = "0x1D3")]
	[Token(Token = "0x6000392")]
	private Rect get_rootCanvasRect() { }

	[Address(RVA = "0x344E330", Offset = "0x344D730", Length = "0x5")]
	[Token(Token = "0x6000388")]
	public Vector2Int get_softness() { }

	[Address(RVA = "0x344CB50", Offset = "0x344BF50", Length = "0x102")]
	[Token(Token = "0x6000391")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x344CC60", Offset = "0x344C060", Length = "0x33")]
	[Token(Token = "0x6000398")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x344CCA0", Offset = "0x344C0A0", Length = "0x1F")]
	[Token(Token = "0x6000390")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x344CCC0", Offset = "0x344C0C0", Length = "0xB9")]
	[Token(Token = "0x600038F")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x344CD80", Offset = "0x344C180", Length = "0x2D")]
	[Token(Token = "0x600038E")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x344CC60", Offset = "0x344C060", Length = "0x33")]
	[Token(Token = "0x6000397")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x344CDB0", Offset = "0x344C1B0", Length = "0xA99")]
	[Token(Token = "0x6000393")]
	public override void PerformClipping() { }

	[Address(RVA = "0x344D850", Offset = "0x344CC50", Length = "0x1AF")]
	[Token(Token = "0x6000396")]
	public void RemoveClippable(IClippable clippable) { }

	[Address(RVA = "0x344E340", Offset = "0x344D740", Length = "0xE")]
	[Token(Token = "0x6000387")]
	public void set_padding(Vector4 value) { }

	[Address(RVA = "0x344E350", Offset = "0x344D750", Length = "0x25")]
	[Token(Token = "0x6000389")]
	public void set_softness(Vector2Int value) { }

	[Address(RVA = "0x344DA00", Offset = "0x344CE00", Length = "0x326")]
	[Token(Token = "0x6000394")]
	public override void UpdateClipSoftness() { }

}

