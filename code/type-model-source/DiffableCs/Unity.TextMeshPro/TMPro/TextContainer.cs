namespace TMPro;

[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000016")]
public class TextContainer : UIBehaviour
{
	[Token(Token = "0x4000049")]
	private static Vector2 k_defaultSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003E")]
	private bool m_hasChanged; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400003F")]
	private Vector2 m_pivot; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000040")]
	private TextContainerAnchors m_anchorPosition; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000041")]
	private Rect m_rect; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000042")]
	private bool m_isDefaultWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000043")]
	private bool m_isDefaultHeight; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000044")]
	private bool m_isAutoFitting; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000045")]
	private Vector3[] m_corners; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000046")]
	private Vector3[] m_worldCorners; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000047")]
	private Vector4 m_margins; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000048")]
	private RectTransform m_rectTransform; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400004A")]
	private TextMeshPro m_textMeshPro; //Field offset: 0x70

	[Token(Token = "0x17000014")]
	public TextContainerAnchors anchorPosition
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 4
		[Address(RVA = "0x2E9AAF0", Offset = "0x2E99EF0", Length = "0x100")]
		[Token(Token = "0x6000056")]
		 set { } //Length: 256
	}

	[Token(Token = "0x1700001C")]
	public Vector3[] corners
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000012")]
	public bool hasChanged
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000052")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public float height
	{
		[Address(RVA = "0x2E9A8D0", Offset = "0x2E99CD0", Length = "0x45")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 69
		[Address(RVA = "0x2E9AC20", Offset = "0x2E9A020", Length = "0x76")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700001B")]
	public bool isAutoFitting
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 5
		[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
		[Token(Token = "0x6000062")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public bool isDefaultHeight
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x6000060")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000019")]
	public bool isDefaultWidth
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public Vector4 margins
	{
		[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 11
		[Address(RVA = "0x2E9ACA0", Offset = "0x2E9A0A0", Length = "0x81")]
		[Token(Token = "0x6000066")]
		 set { } //Length: 129
	}

	[Token(Token = "0x17000013")]
	public Vector2 pivot
	{
		[Address(RVA = "0x1E08DE0", Offset = "0x1E081E0", Length = "0x13")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 19
		[Address(RVA = "0x2E9AD30", Offset = "0x2E9A130", Length = "0x7F")]
		[Token(Token = "0x6000054")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000015")]
	public Rect rect
	{
		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x6000057")]
		 get { } //Length: 11
		[Address(RVA = "0x2E9ADB0", Offset = "0x2E9A1B0", Length = "0xED")]
		[Token(Token = "0x6000058")]
		 set { } //Length: 237
	}

	[Token(Token = "0x1700001F")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x2E9A920", Offset = "0x2E99D20", Length = "0x8D")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000016")]
	public Vector2 size
	{
		[Address(RVA = "0x2E9A9B0", Offset = "0x2E99DB0", Length = "0x52")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 82
		[Address(RVA = "0x2E9AEA0", Offset = "0x2E9A2A0", Length = "0xAF")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 175
	}

	[Token(Token = "0x17000020")]
	public TextMeshPro textMeshPro
	{
		[Address(RVA = "0x2E9AA10", Offset = "0x2E99E10", Length = "0x8D")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000017")]
	public float width
	{
		[Address(RVA = "0x2E9AAA0", Offset = "0x2E99EA0", Length = "0x45")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 69
		[Address(RVA = "0x2E9AF50", Offset = "0x2E9A350", Length = "0x76")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700001D")]
	public Vector3[] worldCorners
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2E9A810", Offset = "0x2E99C10", Length = "0x40")]
	[Token(Token = "0x6000073")]
	private static TextContainer() { }

	[Address(RVA = "0x2E9A850", Offset = "0x2E99C50", Length = "0x7D")]
	[Token(Token = "0x6000072")]
	public TextContainer() { }

	[Address(RVA = "0x2E99D00", Offset = "0x2E99100", Length = "0xA9")]
	[Token(Token = "0x6000069")]
	protected virtual void Awake() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000055")]
	public TextContainerAnchors get_anchorPosition() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000063")]
	public Vector3[] get_corners() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000051")]
	public bool get_hasChanged() { }

	[Address(RVA = "0x2E9A8D0", Offset = "0x2E99CD0", Length = "0x45")]
	[Token(Token = "0x600005D")]
	public float get_height() { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[Token(Token = "0x6000061")]
	public bool get_isAutoFitting() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x6000060")]
	public bool get_isDefaultHeight() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600005F")]
	public bool get_isDefaultWidth() { }

	[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
	[Token(Token = "0x6000065")]
	public Vector4 get_margins() { }

	[Address(RVA = "0x1E08DE0", Offset = "0x1E081E0", Length = "0x13")]
	[Token(Token = "0x6000053")]
	public Vector2 get_pivot() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
	[Token(Token = "0x6000057")]
	public Rect get_rect() { }

	[Address(RVA = "0x2E9A920", Offset = "0x2E99D20", Length = "0x8D")]
	[Token(Token = "0x6000067")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x2E9A9B0", Offset = "0x2E99DB0", Length = "0x52")]
	[Token(Token = "0x6000059")]
	public Vector2 get_size() { }

	[Address(RVA = "0x2E9AA10", Offset = "0x2E99E10", Length = "0x8D")]
	[Token(Token = "0x6000068")]
	public TextMeshPro get_textMeshPro() { }

	[Address(RVA = "0x2E9AAA0", Offset = "0x2E99EA0", Length = "0x45")]
	[Token(Token = "0x600005B")]
	public float get_width() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000064")]
	public Vector3[] get_worldCorners() { }

	[Address(RVA = "0x2E99DB0", Offset = "0x2E991B0", Length = "0x20B")]
	[Token(Token = "0x6000071")]
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	[Address(RVA = "0x2E99FC0", Offset = "0x2E993C0", Length = "0x12C")]
	[Token(Token = "0x6000070")]
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	[Address(RVA = "0x2E9A110", Offset = "0x2E99510", Length = "0x1C0")]
	[Token(Token = "0x600006C")]
	private void OnContainerChanged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006B")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2E9A2E0", Offset = "0x2E996E0", Length = "0x7")]
	[Token(Token = "0x600006A")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2E9A2F0", Offset = "0x2E996F0", Length = "0x2D1")]
	[Token(Token = "0x600006D")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x2E9AAF0", Offset = "0x2E99EF0", Length = "0x100")]
	[Token(Token = "0x6000056")]
	public void set_anchorPosition(TextContainerAnchors value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000052")]
	public void set_hasChanged(bool value) { }

	[Address(RVA = "0x2E9AC20", Offset = "0x2E9A020", Length = "0x76")]
	[Token(Token = "0x600005E")]
	public void set_height(float value) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[Token(Token = "0x6000062")]
	public void set_isAutoFitting(bool value) { }

	[Address(RVA = "0x2E9ACA0", Offset = "0x2E9A0A0", Length = "0x81")]
	[Token(Token = "0x6000066")]
	public void set_margins(Vector4 value) { }

	[Address(RVA = "0x2E9AD30", Offset = "0x2E9A130", Length = "0x7F")]
	[Token(Token = "0x6000054")]
	public void set_pivot(Vector2 value) { }

	[Address(RVA = "0x2E9ADB0", Offset = "0x2E9A1B0", Length = "0xED")]
	[Token(Token = "0x6000058")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x2E9AEA0", Offset = "0x2E9A2A0", Length = "0xAF")]
	[Token(Token = "0x600005A")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x2E9AF50", Offset = "0x2E9A350", Length = "0x76")]
	[Token(Token = "0x600005C")]
	public void set_width(float value) { }

	[Address(RVA = "0x2E9A5D0", Offset = "0x2E999D0", Length = "0x7B")]
	[Token(Token = "0x600006E")]
	private void SetRect(Vector2 size) { }

	[Address(RVA = "0x2E9A650", Offset = "0x2E99A50", Length = "0x1B7")]
	[Token(Token = "0x600006F")]
	private void UpdateCorners() { }

}

