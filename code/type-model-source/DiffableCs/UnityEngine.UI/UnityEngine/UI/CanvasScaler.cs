namespace UnityEngine.UI;

[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
[Token(Token = "0x200003C")]
public class CanvasScaler : UIBehaviour
{
	[Token(Token = "0x200003D")]
	internal enum ScaleMode : int
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2,
	}

	[Token(Token = "0x200003E")]
	internal enum ScreenMatchMode : int
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2,
	}

	[Token(Token = "0x200003F")]
	internal enum Unit : int
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4,
	}

	[Token(Token = "0x400013A")]
	private const float kLogBase = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000134")]
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	private ScaleMode m_UiScaleMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000135")]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000136")]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000137")]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; //Field offset: 0x2C
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000138")]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x4000139")]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	protected float m_MatchWidthOrHeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400013B")]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected Unit m_PhysicalUnit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400013C")]
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	protected float m_FallbackScreenDPI; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400013D")]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400013E")]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400013F")]
	private Canvas m_Canvas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000140")]
	private float m_PrevScaleFactor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000141")]
	private float m_PrevReferencePixelsPerUnit; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000142")]
	protected bool m_PresetInfoIsWorld; //Field offset: 0x60

	[Token(Token = "0x170000A4")]
	public float defaultSpriteDPI
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x600026F")]
		 get { } //Length: 6
		[Address(RVA = "0x3434EF0", Offset = "0x34342F0", Length = "0x14")]
		[Token(Token = "0x6000270")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170000A5")]
	public float dynamicPixelsPerUnit
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000271")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[Token(Token = "0x6000272")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A3")]
	public float fallbackScreenDPI
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x600026D")]
		 get { } //Length: 6
		[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
		[Token(Token = "0x600026E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A1")]
	public float matchWidthOrHeight
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x6000269")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x600026A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A2")]
	public Unit physicalUnit
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600026B")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x600026C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009D")]
	public float referencePixelsPerUnit
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x6000261")]
		 get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x6000262")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700009F")]
	public Vector2 referenceResolution
	{
		[Address(RVA = "0x1E08DC0", Offset = "0x1E081C0", Length = "0x13")]
		[Token(Token = "0x6000265")]
		 get { } //Length: 19
		[Address(RVA = "0x3434F10", Offset = "0x3434310", Length = "0x74")]
		[Token(Token = "0x6000266")]
		 set { } //Length: 116
	}

	[Token(Token = "0x1700009E")]
	public float scaleFactor
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x6000263")]
		 get { } //Length: 6
		[Address(RVA = "0x3434F90", Offset = "0x3434390", Length = "0x14")]
		[Token(Token = "0x6000264")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170000A0")]
	public ScreenMatchMode screenMatchMode
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000267")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6000268")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009C")]
	public ScaleMode uiScaleMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600025F")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000260")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3434EA0", Offset = "0x34342A0", Length = "0x4D")]
	[Token(Token = "0x6000273")]
	protected CanvasScaler() { }

	[Address(RVA = "0x2265EC0", Offset = "0x22652C0", Length = "0x14")]
	[Token(Token = "0x6000275")]
	private void Canvas_preWillRenderCanvases() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x600026F")]
	public float get_defaultSpriteDPI() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000271")]
	public float get_dynamicPixelsPerUnit() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x600026D")]
	public float get_fallbackScreenDPI() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x6000269")]
	public float get_matchWidthOrHeight() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600026B")]
	public Unit get_physicalUnit() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x6000261")]
	public float get_referencePixelsPerUnit() { }

	[Address(RVA = "0x1E08DC0", Offset = "0x1E081C0", Length = "0x13")]
	[Token(Token = "0x6000265")]
	public Vector2 get_referenceResolution() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x6000263")]
	public float get_scaleFactor() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000267")]
	public ScreenMatchMode get_screenMatchMode() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600025F")]
	public ScaleMode get_uiScaleMode() { }

	[Address(RVA = "0x3434B30", Offset = "0x3433F30", Length = "0x11E")]
	[Token(Token = "0x6000277")]
	protected override void Handle() { }

	[Address(RVA = "0x34346E0", Offset = "0x3433AE0", Length = "0xEE")]
	[Token(Token = "0x600027B")]
	protected override void HandleConstantPhysicalSize() { }

	[Address(RVA = "0x34347D0", Offset = "0x3433BD0", Length = "0x7E")]
	[Token(Token = "0x6000279")]
	protected override void HandleConstantPixelSize() { }

	[Address(RVA = "0x3434850", Offset = "0x3433C50", Length = "0x256")]
	[Token(Token = "0x600027A")]
	protected override void HandleScaleWithScreenSize() { }

	[Address(RVA = "0x3434AB0", Offset = "0x3433EB0", Length = "0x7E")]
	[Token(Token = "0x6000278")]
	protected override void HandleWorldCanvas() { }

	[Address(RVA = "0x3434C50", Offset = "0x3434050", Length = "0xE1")]
	[Token(Token = "0x6000276")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3434D40", Offset = "0x3434140", Length = "0xB8")]
	[Token(Token = "0x6000274")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3434EF0", Offset = "0x34342F0", Length = "0x14")]
	[Token(Token = "0x6000270")]
	public void set_defaultSpriteDPI(float value) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x6000272")]
	public void set_dynamicPixelsPerUnit(float value) { }

	[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
	[Token(Token = "0x600026E")]
	public void set_fallbackScreenDPI(float value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x600026A")]
	public void set_matchWidthOrHeight(float value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x600026C")]
	public void set_physicalUnit(Unit value) { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[Token(Token = "0x6000262")]
	public void set_referencePixelsPerUnit(float value) { }

	[Address(RVA = "0x3434F10", Offset = "0x3434310", Length = "0x74")]
	[Token(Token = "0x6000266")]
	public void set_referenceResolution(Vector2 value) { }

	[Address(RVA = "0x3434F90", Offset = "0x3434390", Length = "0x14")]
	[Token(Token = "0x6000264")]
	public void set_scaleFactor(float value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6000268")]
	public void set_screenMatchMode(ScreenMatchMode value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000260")]
	public void set_uiScaleMode(ScaleMode value) { }

	[Address(RVA = "0x3434E00", Offset = "0x3434200", Length = "0x3F")]
	[Token(Token = "0x600027D")]
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

	[Address(RVA = "0x3434E40", Offset = "0x3434240", Length = "0x53")]
	[Token(Token = "0x600027C")]
	protected void SetScaleFactor(float scaleFactor) { }

}

