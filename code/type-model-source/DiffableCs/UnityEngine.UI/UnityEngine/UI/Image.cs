namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Image", 11)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000024")]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	[Token(Token = "0x2000026")]
	internal enum FillMethod : int
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	[Token(Token = "0x200002A")]
	internal enum Origin180 : int
	{
		Bottom = 0,
		Left = 1,
		Top = 2,
		Right = 3,
	}

	[Token(Token = "0x200002B")]
	internal enum Origin360 : int
	{
		Bottom = 0,
		Right = 1,
		Top = 2,
		Left = 3,
	}

	[Token(Token = "0x2000029")]
	internal enum Origin90 : int
	{
		BottomLeft = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomRight = 3,
	}

	[Token(Token = "0x2000027")]
	internal enum OriginHorizontal : int
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x2000028")]
	internal enum OriginVertical : int
	{
		Bottom = 0,
		Top = 1,
	}

	[Token(Token = "0x2000025")]
	internal enum Type : int
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
	}

	[Token(Token = "0x4000096")]
	protected static Material s_ETC1DefaultUI; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	private static SecondarySpriteTexture[] s_TempNewSecondaryTextures; //Field offset: 0x8
	[Token(Token = "0x40000A7")]
	private static readonly Vector2[] s_VertScratch; //Field offset: 0x10
	[Token(Token = "0x40000A8")]
	private static readonly Vector2[] s_UVScratch; //Field offset: 0x18
	[Token(Token = "0x40000A9")]
	private static readonly Vector3[] s_Xy; //Field offset: 0x20
	[Token(Token = "0x40000AA")]
	private static readonly Vector3[] s_Uv; //Field offset: 0x28
	[Token(Token = "0x40000AB")]
	private static List<Image> m_TrackedTexturelessImages; //Field offset: 0x30
	[Token(Token = "0x40000AC")]
	private static bool s_Initialized; //Field offset: 0x38
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private Sprite m_Sprite; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000098")]
	private Sprite m_OverrideSprite; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000099")]
	private Type m_Type; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x400009A")]
	private bool m_PreserveAspect; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF5")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	private bool m_FillCenter; //Field offset: 0xF5
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x400009C")]
	private FillMethod m_FillMethod; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x400009D")]
	private float m_FillAmount; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400009E")]
	private bool m_FillClockwise; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	[Token(Token = "0x400009F")]
	private int m_FillOrigin; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000A0")]
	private float m_AlphaHitTestMinimumThreshold; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40000A1")]
	private bool m_Tracked; //Field offset: 0x10C
	[FieldOffset(Offset = "0x10D")]
	[SerializeField]
	[Token(Token = "0x40000A2")]
	private bool m_UseSpriteMesh; //Field offset: 0x10D
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000A3")]
	private float m_PixelsPerUnitMultiplier; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40000A4")]
	private float m_CachedReferencePixelsPerUnit; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40000A6")]
	private SecondarySpriteTexture[] m_SecondaryTextures; //Field offset: 0x118

	[Token(Token = "0x1700004D")]
	private Sprite activeSprite
	{
		[Address(RVA = "0x31EB0A0", Offset = "0x31EA4A0", Length = "0x7A")]
		[Token(Token = "0x6000143")]
		private get { } //Length: 122
	}

	[Token(Token = "0x17000056")]
	public float alphaHitTestMinimumThreshold
	{
		[Address(RVA = "0x2C2F7A0", Offset = "0x2C2EBA0", Length = "0x9")]
		[Token(Token = "0x6000154")]
		 get { } //Length: 9
		[Address(RVA = "0x31EBAD0", Offset = "0x31EAED0", Length = "0x159")]
		[Token(Token = "0x6000155")]
		 set { } //Length: 345
	}

	[Token(Token = "0x17000058")]
	public static Material defaultETC1GraphicMaterial
	{
		[Address(RVA = "0x31EB120", Offset = "0x31EA520", Length = "0xF2")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 242
	}

	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	[Token(Token = "0x17000055")]
	public float eventAlphaThreshold
	{
		[Address(RVA = "0x31EB220", Offset = "0x31EA620", Length = "0x11")]
		[Token(Token = "0x6000152")]
		 get { } //Length: 17
		[Address(RVA = "0x31EBC30", Offset = "0x31EB030", Length = "0x162")]
		[Token(Token = "0x6000153")]
		 set { } //Length: 354
	}

	[Token(Token = "0x17000052")]
	public float fillAmount
	{
		[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
		[Token(Token = "0x600014C")]
		 get { } //Length: 9
		[Address(RVA = "0x31EBDA0", Offset = "0x31EB1A0", Length = "0x85")]
		[Token(Token = "0x600014D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000050")]
	public bool fillCenter
	{
		[Address(RVA = "0x31EB240", Offset = "0x31EA640", Length = "0x8")]
		[Token(Token = "0x6000148")]
		 get { } //Length: 8
		[Address(RVA = "0x31EBE30", Offset = "0x31EB230", Length = "0x68")]
		[Token(Token = "0x6000149")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000053")]
	public bool fillClockwise
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[Token(Token = "0x600014E")]
		 get { } //Length: 8
		[Address(RVA = "0x31EBEA0", Offset = "0x31EB2A0", Length = "0x68")]
		[Token(Token = "0x600014F")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000051")]
	public FillMethod fillMethod
	{
		[Address(RVA = "0x31EB250", Offset = "0x31EA650", Length = "0x7")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 7
		[Address(RVA = "0x31EBF10", Offset = "0x31EB310", Length = "0x6F")]
		[Token(Token = "0x600014B")]
		 set { } //Length: 111
	}

	[Token(Token = "0x17000054")]
	public int fillOrigin
	{
		[Address(RVA = "0x2C2F7B0", Offset = "0x2C2EBB0", Length = "0x7")]
		[Token(Token = "0x6000150")]
		 get { } //Length: 7
		[Address(RVA = "0x31EBF80", Offset = "0x31EB380", Length = "0x65")]
		[Token(Token = "0x6000151")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000065")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000062")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000180")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700005A")]
	public bool hasBorder
	{
		[Address(RVA = "0x31EB260", Offset = "0x31EA660", Length = "0xD3")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 211
	}

	[Token(Token = "0x17000066")]
	public override int layoutPriority
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000184")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000059")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x31EB340", Offset = "0x31EA740", Length = "0x18A")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 394
	}

	[Token(Token = "0x1700005E")]
	public virtual Material material
	{
		[Address(RVA = "0x31EB4D0", Offset = "0x31EA8D0", Length = "0x219")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 537
		[Address(RVA = "0x31E3900", Offset = "0x31E2D00", Length = "0x92")]
		[Token(Token = "0x6000161")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000063")]
	public override float minHeight
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x6000181")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public override float minWidth
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x600017E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	protected float multipliedPixelsPerUnit
	{
		[Address(RVA = "0x31EB6F0", Offset = "0x31EAAF0", Length = "0x1E")]
		[Token(Token = "0x600015F")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700004C")]
	public Sprite overrideSprite
	{
		[Address(RVA = "0x31EB710", Offset = "0x31EAB10", Length = "0x7")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 7
		[Address(RVA = "0x31EBFF0", Offset = "0x31EB3F0", Length = "0x71")]
		[Token(Token = "0x6000142")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700005C")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x31EB720", Offset = "0x31EAB20", Length = "0x13E")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 318
	}

	[Token(Token = "0x1700005B")]
	public float pixelsPerUnitMultiplier
	{
		[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 9
		[Address(RVA = "0x31EC070", Offset = "0x31EB470", Length = "0x2A")]
		[Token(Token = "0x600015D")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000064")]
	public override float preferredHeight
	{
		[Address(RVA = "0x31EB860", Offset = "0x31EAC60", Length = "0x128")]
		[Token(Token = "0x6000182")]
		 get { } //Length: 296
	}

	[Token(Token = "0x17000061")]
	public override float preferredWidth
	{
		[Address(RVA = "0x31EB990", Offset = "0x31EAD90", Length = "0x128")]
		[Token(Token = "0x600017F")]
		 get { } //Length: 296
	}

	[Token(Token = "0x1700004F")]
	public bool preserveAspect
	{
		[Address(RVA = "0x31AE1A0", Offset = "0x31AD5A0", Length = "0x8")]
		[Token(Token = "0x6000146")]
		 get { } //Length: 8
		[Address(RVA = "0x31EC0A0", Offset = "0x31EB4A0", Length = "0x68")]
		[Token(Token = "0x6000147")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700005F")]
	internal SecondarySpriteTexture[] secondaryTextures
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x600016B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700004B")]
	public Sprite sprite
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x600013E")]
		 get { } //Length: 8
		[Address(RVA = "0x31EC110", Offset = "0x31EB510", Length = "0x3EA")]
		[Token(Token = "0x600013F")]
		 set { } //Length: 1002
	}

	[Token(Token = "0x1700004E")]
	public Type type
	{
		[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
		[Token(Token = "0x6000144")]
		 get { } //Length: 7
		[Address(RVA = "0x31EC500", Offset = "0x31EB900", Length = "0x65")]
		[Token(Token = "0x6000145")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000057")]
	public bool useSpriteMesh
	{
		[Address(RVA = "0x31EBAC0", Offset = "0x31EAEC0", Length = "0x8")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 8
		[Address(RVA = "0x31EC570", Offset = "0x31EB970", Length = "0x68")]
		[Token(Token = "0x6000157")]
		 set { } //Length: 104
	}

	[Address(RVA = "0x31EAE30", Offset = "0x31EA230", Length = "0x205")]
	[Token(Token = "0x600018B")]
	private static Image() { }

	[Address(RVA = "0x31EB040", Offset = "0x31EA440", Length = "0x53")]
	[Token(Token = "0x6000158")]
	protected Image() { }

	[Address(RVA = "0x31EA830", Offset = "0x31E9C30", Length = "0xBB")]
	[CompilerGenerated]
	[Token(Token = "0x600018E")]
	internal static bool <CheckSecondaryTexturesChanged>g__Compare|93_0(SecondarySpriteTexture[] array1, SecondarySpriteTexture[] array2) { }

	[Address(RVA = "0x31EA8F0", Offset = "0x31E9CF0", Length = "0x1A4")]
	[CompilerGenerated]
	[Token(Token = "0x600018C")]
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[Address(RVA = "0x31EAAA0", Offset = "0x31E9EA0", Length = "0x13F")]
	[CompilerGenerated]
	[Token(Token = "0x600018D")]
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

	[Address(RVA = "0x31E3CD0", Offset = "0x31E30D0", Length = "0x178")]
	[Token(Token = "0x6000176")]
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	[Address(RVA = "0x31E3A90", Offset = "0x31E2E90", Length = "0x231")]
	[Token(Token = "0x6000177")]
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600017C")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600017D")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x31E3EE0", Offset = "0x31E32E0", Length = "0x207")]
	[Token(Token = "0x600016E")]
	private bool CheckSecondaryTexturesChanged(Sprite sprite, ref SecondarySpriteTexture[] newSecondaryTextures) { }

	[Address(RVA = "0x31E3E50", Offset = "0x31E3250", Length = "0x8F")]
	[Token(Token = "0x600016D")]
	private bool CheckSecondaryTexturesChanged(Sprite sprite) { }

	[Address(RVA = "0x31E40F0", Offset = "0x31E34F0", Length = "0xA1")]
	[Token(Token = "0x600016C")]
	private static void ClearArray(ref SecondarySpriteTexture[] array) { }

	[Address(RVA = "0x31E41A0", Offset = "0x31E35A0", Length = "0x7")]
	[Token(Token = "0x6000140")]
	public void DisableSpriteOptimizations() { }

	[Address(RVA = "0x31E41B0", Offset = "0x31E35B0", Length = "0x1397")]
	[Token(Token = "0x6000179")]
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	[Address(RVA = "0x31E5550", Offset = "0x31E4950", Length = "0x388")]
	[Token(Token = "0x6000172")]
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	[Address(RVA = "0x31E58E0", Offset = "0x31E4CE0", Length = "0xA64")]
	[Token(Token = "0x6000174")]
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	[Address(RVA = "0x31E6350", Offset = "0x31E5750", Length = "0x649")]
	[Token(Token = "0x6000173")]
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	[Address(RVA = "0x31E69A0", Offset = "0x31E5DA0", Length = "0x147B")]
	[Token(Token = "0x6000175")]
	private void GenerateTiledSprite(VertexHelper toFill) { }

	[Address(RVA = "0x31EB0A0", Offset = "0x31EA4A0", Length = "0x7A")]
	[Token(Token = "0x6000143")]
	private Sprite get_activeSprite() { }

	[Address(RVA = "0x2C2F7A0", Offset = "0x2C2EBA0", Length = "0x9")]
	[Token(Token = "0x6000154")]
	public float get_alphaHitTestMinimumThreshold() { }

	[Address(RVA = "0x31EB120", Offset = "0x31EA520", Length = "0xF2")]
	[Token(Token = "0x6000159")]
	public static Material get_defaultETC1GraphicMaterial() { }

	[Address(RVA = "0x31EB220", Offset = "0x31EA620", Length = "0x11")]
	[Token(Token = "0x6000152")]
	public float get_eventAlphaThreshold() { }

	[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
	[Token(Token = "0x600014C")]
	public float get_fillAmount() { }

	[Address(RVA = "0x31EB240", Offset = "0x31EA640", Length = "0x8")]
	[Token(Token = "0x6000148")]
	public bool get_fillCenter() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[Token(Token = "0x600014E")]
	public bool get_fillClockwise() { }

	[Address(RVA = "0x31EB250", Offset = "0x31EA650", Length = "0x7")]
	[Token(Token = "0x600014A")]
	public FillMethod get_fillMethod() { }

	[Address(RVA = "0x2C2F7B0", Offset = "0x2C2EBB0", Length = "0x7")]
	[Token(Token = "0x6000150")]
	public int get_fillOrigin() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000183")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000180")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x31EB260", Offset = "0x31EA660", Length = "0xD3")]
	[Token(Token = "0x600015B")]
	public bool get_hasBorder() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000184")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x31EB340", Offset = "0x31EA740", Length = "0x18A")]
	[Token(Token = "0x600015A")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x31EB4D0", Offset = "0x31EA8D0", Length = "0x219")]
	[Token(Token = "0x6000160")]
	public virtual Material get_material() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000181")]
	public override float get_minHeight() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x600017E")]
	public override float get_minWidth() { }

	[Address(RVA = "0x31EB6F0", Offset = "0x31EAAF0", Length = "0x1E")]
	[Token(Token = "0x600015F")]
	protected float get_multipliedPixelsPerUnit() { }

	[Address(RVA = "0x31EB710", Offset = "0x31EAB10", Length = "0x7")]
	[Token(Token = "0x6000141")]
	public Sprite get_overrideSprite() { }

	[Address(RVA = "0x31EB720", Offset = "0x31EAB20", Length = "0x13E")]
	[Token(Token = "0x600015E")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
	[Token(Token = "0x600015C")]
	public float get_pixelsPerUnitMultiplier() { }

	[Address(RVA = "0x31EB860", Offset = "0x31EAC60", Length = "0x128")]
	[Token(Token = "0x6000182")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x31EB990", Offset = "0x31EAD90", Length = "0x128")]
	[Token(Token = "0x600017F")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x31AE1A0", Offset = "0x31AD5A0", Length = "0x8")]
	[Token(Token = "0x6000146")]
	public bool get_preserveAspect() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x600016B")]
	internal SecondarySpriteTexture[] get_secondaryTextures() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x600013E")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
	[Token(Token = "0x6000144")]
	public Type get_type() { }

	[Address(RVA = "0x31EBAC0", Offset = "0x31EAEC0", Length = "0x8")]
	[Token(Token = "0x6000156")]
	public bool get_useSpriteMesh() { }

	[Address(RVA = "0x31E7E20", Offset = "0x31E7220", Length = "0x3E1")]
	[Token(Token = "0x6000178")]
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	[Address(RVA = "0x31E8210", Offset = "0x31E7610", Length = "0x337")]
	[Token(Token = "0x6000165")]
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	[Address(RVA = "0x31E8550", Offset = "0x31E7950", Length = "0x447")]
	[Token(Token = "0x6000185")]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	[Address(RVA = "0x31E89A0", Offset = "0x31E7DA0", Length = "0x775")]
	[Token(Token = "0x6000186")]
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	[Address(RVA = "0x31E9120", Offset = "0x31E8520", Length = "0x6F")]
	[Token(Token = "0x6000163")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000162")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x31E9190", Offset = "0x31E8590", Length = "0x15D")]
	[Token(Token = "0x6000171")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x31E92F0", Offset = "0x31E86F0", Length = "0x41")]
	[Token(Token = "0x600018A")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x31E9340", Offset = "0x31E8740", Length = "0xC0")]
	[Token(Token = "0x600016A")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x31E9410", Offset = "0x31E8810", Length = "0x1F")]
	[Token(Token = "0x6000169")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x31E9430", Offset = "0x31E8830", Length = "0x144")]
	[Token(Token = "0x6000167")]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[Address(RVA = "0x31E9580", Offset = "0x31E8980", Length = "0x1CE")]
	[Token(Token = "0x6000164")]
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	[Address(RVA = "0x31E9750", Offset = "0x31E8B50", Length = "0x14A")]
	[Token(Token = "0x600017A")]
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	[Address(RVA = "0x31E98A0", Offset = "0x31E8CA0", Length = "0x4D7")]
	[Token(Token = "0x600017B")]
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	[Address(RVA = "0x31E9D80", Offset = "0x31E9180", Length = "0x1FC")]
	[Token(Token = "0x6000187")]
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x31EBAD0", Offset = "0x31EAED0", Length = "0x159")]
	[Token(Token = "0x6000155")]
	public void set_alphaHitTestMinimumThreshold(float value) { }

	[Address(RVA = "0x31EBC30", Offset = "0x31EB030", Length = "0x162")]
	[Token(Token = "0x6000153")]
	public void set_eventAlphaThreshold(float value) { }

	[Address(RVA = "0x31EBDA0", Offset = "0x31EB1A0", Length = "0x85")]
	[Token(Token = "0x600014D")]
	public void set_fillAmount(float value) { }

	[Address(RVA = "0x31EBE30", Offset = "0x31EB230", Length = "0x68")]
	[Token(Token = "0x6000149")]
	public void set_fillCenter(bool value) { }

	[Address(RVA = "0x31EBEA0", Offset = "0x31EB2A0", Length = "0x68")]
	[Token(Token = "0x600014F")]
	public void set_fillClockwise(bool value) { }

	[Address(RVA = "0x31EBF10", Offset = "0x31EB310", Length = "0x6F")]
	[Token(Token = "0x600014B")]
	public void set_fillMethod(FillMethod value) { }

	[Address(RVA = "0x31EBF80", Offset = "0x31EB380", Length = "0x65")]
	[Token(Token = "0x6000151")]
	public void set_fillOrigin(int value) { }

	[Address(RVA = "0x31E3900", Offset = "0x31E2D00", Length = "0x92")]
	[Token(Token = "0x6000161")]
	public virtual void set_material(Material value) { }

	[Address(RVA = "0x31EBFF0", Offset = "0x31EB3F0", Length = "0x71")]
	[Token(Token = "0x6000142")]
	public void set_overrideSprite(Sprite value) { }

	[Address(RVA = "0x31EC070", Offset = "0x31EB470", Length = "0x2A")]
	[Token(Token = "0x600015D")]
	public void set_pixelsPerUnitMultiplier(float value) { }

	[Address(RVA = "0x31EC0A0", Offset = "0x31EB4A0", Length = "0x68")]
	[Token(Token = "0x6000147")]
	public void set_preserveAspect(bool value) { }

	[Address(RVA = "0x31EC110", Offset = "0x31EB510", Length = "0x3EA")]
	[Token(Token = "0x600013F")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x31EC500", Offset = "0x31EB900", Length = "0x65")]
	[Token(Token = "0x6000145")]
	public void set_type(Type value) { }

	[Address(RVA = "0x31EC570", Offset = "0x31EB970", Length = "0x68")]
	[Token(Token = "0x6000157")]
	public void set_useSpriteMesh(bool value) { }

	[Address(RVA = "0x31E9F80", Offset = "0x31E9380", Length = "0x23E")]
	[Token(Token = "0x6000166")]
	public virtual void SetNativeSize() { }

	[Address(RVA = "0x31EA1C0", Offset = "0x31E95C0", Length = "0x2B3")]
	[Token(Token = "0x600016F")]
	internal void SetSecondaryTextures(CanvasRenderer renderer) { }

	[Address(RVA = "0x31EA480", Offset = "0x31E9880", Length = "0x169")]
	[Token(Token = "0x6000188")]
	private static void TrackImage(Image g) { }

	[Address(RVA = "0x31EA5F0", Offset = "0x31E99F0", Length = "0x23E")]
	[Token(Token = "0x6000168")]
	private void TrackSprite() { }

	[Address(RVA = "0x31EABE0", Offset = "0x31E9FE0", Length = "0x79")]
	[Token(Token = "0x6000189")]
	private static void UnTrackImage(Image g) { }

	[Address(RVA = "0x31EAC60", Offset = "0x31EA060", Length = "0x1C6")]
	[Token(Token = "0x6000170")]
	protected virtual void UpdateMaterial() { }

}

