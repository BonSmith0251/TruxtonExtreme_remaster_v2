namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000009")]
public sealed class Canvas : Behaviour
{
	[Token(Token = "0x200000A")]
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x60000E6")]
		public WillRenderCanvases(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x60000E7")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000011")]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000012")]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000013")]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000014")]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000015")]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x14000001")]
	public static event WillRenderCanvases preWillRenderCanvases
	{
		[Address(RVA = "0x342FA00", Offset = "0x342EE00", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		 add { } //Length: 180
		[Address(RVA = "0x3430EA0", Offset = "0x34302A0", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x600007D")]
		 remove { } //Length: 180
	}

	[Token(Token = "0x14000002")]
	public static event WillRenderCanvases willRenderCanvases
	{
		[Address(RVA = "0x342FAC0", Offset = "0x342EEC0", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x600007E")]
		 add { } //Length: 184
		[Address(RVA = "0x3430F60", Offset = "0x3430360", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x600007F")]
		 remove { } //Length: 184
	}

	[Token(Token = "0x1700001F")]
	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		[Address(RVA = "0x342FBC0", Offset = "0x342EFC0", Length = "0x76")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 118
		[Address(RVA = "0x3431060", Offset = "0x3430460", Length = "0x83")]
		[Token(Token = "0x600009B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001E")]
	public int cachedSortingLayerValue
	{
		[Address(RVA = "0x342FC80", Offset = "0x342F080", Length = "0x76")]
		[Token(Token = "0x6000099")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000024")]
	internal static Action<Int32> externBeginRenderOverlays
	{
		[Address(RVA = "0x342FD00", Offset = "0x342F100", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60000A2")]
		internal get { } //Length: 55
		[Address(RVA = "0x34310F0", Offset = "0x34304F0", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60000A3")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x17000026")]
	internal static Action<Int32> externEndRenderOverlays
	{
		[Address(RVA = "0x342FD40", Offset = "0x342F140", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60000A6")]
		internal get { } //Length: 55
		[Address(RVA = "0x3431150", Offset = "0x3430550", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60000A7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x17000025")]
	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[Address(RVA = "0x342FD80", Offset = "0x342F180", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60000A4")]
		internal get { } //Length: 55
		[Address(RVA = "0x34311B0", Offset = "0x34305B0", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60000A5")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x17000011")]
	public bool isRootCanvas
	{
		[Address(RVA = "0x342FE00", Offset = "0x342F200", Length = "0x76")]
		[Token(Token = "0x6000082")]
		 get { } //Length: 118
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	[Token(Token = "0x17000028")]
	public float normalizedSortingGridSize
	{
		[Address(RVA = "0x342FEC0", Offset = "0x342F2C0", Length = "0x76")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 118
		[Address(RVA = "0x3431260", Offset = "0x3430660", Length = "0x86")]
		[Token(Token = "0x60000AC")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000015")]
	public bool overridePixelPerfect
	{
		[Address(RVA = "0x342FF80", Offset = "0x342F380", Length = "0x76")]
		[Token(Token = "0x6000088")]
		 get { } //Length: 118
		[Address(RVA = "0x3431340", Offset = "0x3430740", Length = "0x86")]
		[Token(Token = "0x6000089")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700001A")]
	public bool overrideSorting
	{
		[Address(RVA = "0x3430040", Offset = "0x342F440", Length = "0x76")]
		[Token(Token = "0x6000091")]
		 get { } //Length: 118
		[Address(RVA = "0x3431420", Offset = "0x3430820", Length = "0x86")]
		[Token(Token = "0x6000092")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000017")]
	public bool pixelPerfect
	{
		[Address(RVA = "0x3430100", Offset = "0x342F500", Length = "0x76")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 118
		[Address(RVA = "0x3431500", Offset = "0x3430900", Length = "0x86")]
		[Token(Token = "0x600008D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000012")]
	public Rect pixelRect
	{
		[Address(RVA = "0x34301D0", Offset = "0x342F5D0", Length = "0x8E")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000018")]
	public float planeDistance
	{
		[Address(RVA = "0x34302A0", Offset = "0x342F6A0", Length = "0x76")]
		[Token(Token = "0x600008E")]
		 get { } //Length: 118
		[Address(RVA = "0x34315E0", Offset = "0x34309E0", Length = "0x86")]
		[Token(Token = "0x600008F")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000014")]
	public float referencePixelsPerUnit
	{
		[Address(RVA = "0x3430360", Offset = "0x342F760", Length = "0x76")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 118
		[Address(RVA = "0x34316C0", Offset = "0x3430AC0", Length = "0x86")]
		[Token(Token = "0x6000087")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000022")]
	public Vector2 renderingDisplaySize
	{
		[Address(RVA = "0x34305B0", Offset = "0x342F9B0", Length = "0x87")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000010")]
	public RenderMode renderMode
	{
		[Address(RVA = "0x3430420", Offset = "0x342F820", Length = "0x76")]
		[Token(Token = "0x6000080")]
		 get { } //Length: 118
		[Address(RVA = "0x3431790", Offset = "0x3430B90", Length = "0x83")]
		[Token(Token = "0x6000081")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000019")]
	public int renderOrder
	{
		[Address(RVA = "0x34304E0", Offset = "0x342F8E0", Length = "0x76")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000021")]
	public Canvas rootCanvas
	{
		[Address(RVA = "0x3430680", Offset = "0x342FA80", Length = "0x90")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000013")]
	public float scaleFactor
	{
		[Address(RVA = "0x3430760", Offset = "0x342FB60", Length = "0x76")]
		[Token(Token = "0x6000084")]
		 get { } //Length: 118
		[Address(RVA = "0x3431870", Offset = "0x3430C70", Length = "0x86")]
		[Token(Token = "0x6000085")]
		 set { } //Length: 134
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", False)]
	[Token(Token = "0x17000029")]
	public int sortingGridNormalizedSize
	{
		[Address(RVA = "0x3430820", Offset = "0x342FC20", Length = "0x76")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 118
		[Address(RVA = "0x3431940", Offset = "0x3430D40", Length = "0x83")]
		[Token(Token = "0x60000AE")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001D")]
	public int sortingLayerID
	{
		[Address(RVA = "0x34308E0", Offset = "0x342FCE0", Length = "0x76")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 118
		[Address(RVA = "0x3431A10", Offset = "0x3430E10", Length = "0x83")]
		[Token(Token = "0x6000098")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000020")]
	public string sortingLayerName
	{
		[Address(RVA = "0x34309B0", Offset = "0x342FDB0", Length = "0x106")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 262
		[Address(RVA = "0x3431AF0", Offset = "0x3430EF0", Length = "0x1C7")]
		[Token(Token = "0x600009D")]
		 set { } //Length: 455
	}

	[Token(Token = "0x1700001B")]
	public int sortingOrder
	{
		[Address(RVA = "0x3430B00", Offset = "0x342FF00", Length = "0x76")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 118
		[Address(RVA = "0x3431D00", Offset = "0x3431100", Length = "0x83")]
		[Token(Token = "0x6000094")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001C")]
	public int targetDisplay
	{
		[Address(RVA = "0x3430BC0", Offset = "0x342FFC0", Length = "0x76")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 118
		[Address(RVA = "0x3431DD0", Offset = "0x34311D0", Length = "0x83")]
		[Token(Token = "0x6000096")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000023")]
	public StandaloneRenderResize updateRectTransformForStandalone
	{
		[Address(RVA = "0x3430C80", Offset = "0x3430080", Length = "0x76")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 118
		[Address(RVA = "0x3431EA0", Offset = "0x34312A0", Length = "0x83")]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000016")]
	public bool vertexColorAlwaysGammaSpace
	{
		[Address(RVA = "0x3430D40", Offset = "0x3430140", Length = "0x76")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 118
		[Address(RVA = "0x3431F80", Offset = "0x3431380", Length = "0x86")]
		[Token(Token = "0x600008B")]
		 set { } //Length: 134
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	[Token(Token = "0x17000027")]
	public Camera worldCamera
	{
		[Address(RVA = "0x3430E00", Offset = "0x3430200", Length = "0x90")]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 144
		[Address(RVA = "0x3432060", Offset = "0x3431460", Length = "0xBA")]
		[Token(Token = "0x60000AA")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60000B9")]
	public Canvas() { }

	[Address(RVA = "0x342FA00", Offset = "0x342EE00", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x342FAC0", Offset = "0x342EEC0", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x600007E")]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x342F4E0", Offset = "0x342E8E0", Length = "0x57")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B6")]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[Address(RVA = "0x342F540", Offset = "0x342E940", Length = "0x57")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B8")]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	[Address(RVA = "0x342F5A0", Offset = "0x342E9A0", Length = "0x8F")]
	[Token(Token = "0x60000B3")]
	public static void ForceUpdateCanvases() { }

	[Address(RVA = "0x342FBC0", Offset = "0x342EFC0", Length = "0x76")]
	[Token(Token = "0x600009A")]
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	[Address(RVA = "0x342FB80", Offset = "0x342EF80", Length = "0x33")]
	[Token(Token = "0x60000D4")]
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342FC80", Offset = "0x342F080", Length = "0x76")]
	[Token(Token = "0x6000099")]
	public int get_cachedSortingLayerValue() { }

	[Address(RVA = "0x342FC40", Offset = "0x342F040", Length = "0x33")]
	[Token(Token = "0x60000D3")]
	private static int get_cachedSortingLayerValue_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342FD00", Offset = "0x342F100", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60000A2")]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[Address(RVA = "0x342FD40", Offset = "0x342F140", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60000A6")]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[Address(RVA = "0x342FD80", Offset = "0x342F180", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60000A4")]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	[Address(RVA = "0x342FE00", Offset = "0x342F200", Length = "0x76")]
	[Token(Token = "0x6000082")]
	public bool get_isRootCanvas() { }

	[Address(RVA = "0x342FDC0", Offset = "0x342F1C0", Length = "0x33")]
	[Token(Token = "0x60000BC")]
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342FEC0", Offset = "0x342F2C0", Length = "0x76")]
	[Token(Token = "0x60000AB")]
	public float get_normalizedSortingGridSize() { }

	[Address(RVA = "0x342FE80", Offset = "0x342F280", Length = "0x33")]
	[Token(Token = "0x60000DE")]
	private static float get_normalizedSortingGridSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342FF80", Offset = "0x342F380", Length = "0x76")]
	[Token(Token = "0x6000088")]
	public bool get_overridePixelPerfect() { }

	[Address(RVA = "0x342FF40", Offset = "0x342F340", Length = "0x33")]
	[Token(Token = "0x60000C2")]
	private static bool get_overridePixelPerfect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430040", Offset = "0x342F440", Length = "0x76")]
	[Token(Token = "0x6000091")]
	public bool get_overrideSorting() { }

	[Address(RVA = "0x3430000", Offset = "0x342F400", Length = "0x33")]
	[Token(Token = "0x60000CB")]
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430100", Offset = "0x342F500", Length = "0x76")]
	[Token(Token = "0x600008C")]
	public bool get_pixelPerfect() { }

	[Address(RVA = "0x34300C0", Offset = "0x342F4C0", Length = "0x33")]
	[Token(Token = "0x60000C6")]
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34301D0", Offset = "0x342F5D0", Length = "0x8E")]
	[Token(Token = "0x6000083")]
	public Rect get_pixelRect() { }

	[Address(RVA = "0x3430180", Offset = "0x342F580", Length = "0x42")]
	[Token(Token = "0x60000BD")]
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x34302A0", Offset = "0x342F6A0", Length = "0x76")]
	[Token(Token = "0x600008E")]
	public float get_planeDistance() { }

	[Address(RVA = "0x3430260", Offset = "0x342F660", Length = "0x33")]
	[Token(Token = "0x60000C8")]
	private static float get_planeDistance_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430360", Offset = "0x342F760", Length = "0x76")]
	[Token(Token = "0x6000086")]
	public float get_referencePixelsPerUnit() { }

	[Address(RVA = "0x3430320", Offset = "0x342F720", Length = "0x33")]
	[Token(Token = "0x60000C0")]
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34305B0", Offset = "0x342F9B0", Length = "0x87")]
	[Token(Token = "0x600009F")]
	public Vector2 get_renderingDisplaySize() { }

	[Address(RVA = "0x3430560", Offset = "0x342F960", Length = "0x42")]
	[Token(Token = "0x60000D9")]
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x3430420", Offset = "0x342F820", Length = "0x76")]
	[Token(Token = "0x6000080")]
	public RenderMode get_renderMode() { }

	[Address(RVA = "0x34303E0", Offset = "0x342F7E0", Length = "0x33")]
	[Token(Token = "0x60000BA")]
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34304E0", Offset = "0x342F8E0", Length = "0x76")]
	[Token(Token = "0x6000090")]
	public int get_renderOrder() { }

	[Address(RVA = "0x34304A0", Offset = "0x342F8A0", Length = "0x33")]
	[Token(Token = "0x60000CA")]
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430680", Offset = "0x342FA80", Length = "0x90")]
	[Token(Token = "0x600009E")]
	public Canvas get_rootCanvas() { }

	[Address(RVA = "0x3430640", Offset = "0x342FA40", Length = "0x33")]
	[Token(Token = "0x60000D8")]
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430760", Offset = "0x342FB60", Length = "0x76")]
	[Token(Token = "0x6000084")]
	public float get_scaleFactor() { }

	[Address(RVA = "0x3430720", Offset = "0x342FB20", Length = "0x33")]
	[Token(Token = "0x60000BE")]
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430820", Offset = "0x342FC20", Length = "0x76")]
	[Token(Token = "0x60000AD")]
	public int get_sortingGridNormalizedSize() { }

	[Address(RVA = "0x34307E0", Offset = "0x342FBE0", Length = "0x33")]
	[Token(Token = "0x60000E0")]
	private static int get_sortingGridNormalizedSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34308E0", Offset = "0x342FCE0", Length = "0x76")]
	[Token(Token = "0x6000097")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x34308A0", Offset = "0x342FCA0", Length = "0x33")]
	[Token(Token = "0x60000D1")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34309B0", Offset = "0x342FDB0", Length = "0x106")]
	[Token(Token = "0x600009C")]
	public string get_sortingLayerName() { }

	[Address(RVA = "0x3430960", Offset = "0x342FD60", Length = "0x42")]
	[Token(Token = "0x60000D6")]
	private static void get_sortingLayerName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3430B00", Offset = "0x342FF00", Length = "0x76")]
	[Token(Token = "0x6000093")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x3430AC0", Offset = "0x342FEC0", Length = "0x33")]
	[Token(Token = "0x60000CD")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430BC0", Offset = "0x342FFC0", Length = "0x76")]
	[Token(Token = "0x6000095")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x3430B80", Offset = "0x342FF80", Length = "0x33")]
	[Token(Token = "0x60000CF")]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430C80", Offset = "0x3430080", Length = "0x76")]
	[Token(Token = "0x60000A0")]
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	[Address(RVA = "0x3430C40", Offset = "0x3430040", Length = "0x33")]
	[Token(Token = "0x60000DA")]
	private static StandaloneRenderResize get_updateRectTransformForStandalone_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430D40", Offset = "0x3430140", Length = "0x76")]
	[Token(Token = "0x600008A")]
	public bool get_vertexColorAlwaysGammaSpace() { }

	[Address(RVA = "0x3430D00", Offset = "0x3430100", Length = "0x33")]
	[Token(Token = "0x60000C4")]
	private static bool get_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3430E00", Offset = "0x3430200", Length = "0x90")]
	[Token(Token = "0x60000A9")]
	public Camera get_worldCamera() { }

	[Address(RVA = "0x3430DC0", Offset = "0x34301C0", Length = "0x33")]
	[Token(Token = "0x60000DC")]
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342F660", Offset = "0x342EA60", Length = "0x54")]
	[FreeFunction("UI::GetDefaultUIMaterial")]
	[Token(Token = "0x60000B0")]
	public static Material GetDefaultCanvasMaterial() { }

	[Address(RVA = "0x342F630", Offset = "0x342EA30", Length = "0x2A")]
	[Token(Token = "0x60000E3")]
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	[Address(RVA = "0x342F6F0", Offset = "0x342EAF0", Length = "0x54")]
	[FreeFunction("UI::GetDefaultUIMaterial")]
	[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", False)]
	[Token(Token = "0x60000AF")]
	public static Material GetDefaultCanvasTextMaterial() { }

	[Address(RVA = "0x342F6C0", Offset = "0x342EAC0", Length = "0x2A")]
	[Token(Token = "0x60000E2")]
	private static IntPtr GetDefaultCanvasTextMaterial_Injected() { }

	[Address(RVA = "0x342F780", Offset = "0x342EB80", Length = "0x54")]
	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	[Token(Token = "0x60000B1")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[Address(RVA = "0x342F750", Offset = "0x342EB50", Length = "0x2A")]
	[Token(Token = "0x60000E4")]
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }

	[Address(RVA = "0x3430EA0", Offset = "0x34302A0", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x600007D")]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x3430F60", Offset = "0x3430360", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x600007F")]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x342F7E0", Offset = "0x342EBE0", Length = "0x5F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B7")]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[Address(RVA = "0x342F840", Offset = "0x342EC40", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B4")]
	private static void SendPreWillRenderCanvases() { }

	[Address(RVA = "0x342F890", Offset = "0x342EC90", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B5")]
	private static void SendWillRenderCanvases() { }

	[Address(RVA = "0x3431060", Offset = "0x3430460", Length = "0x83")]
	[Token(Token = "0x600009B")]
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[Address(RVA = "0x3431020", Offset = "0x3430420", Length = "0x40")]
	[Token(Token = "0x60000D5")]
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	[Address(RVA = "0x34310F0", Offset = "0x34304F0", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60000A3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[Address(RVA = "0x3431150", Offset = "0x3430550", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60000A7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[Address(RVA = "0x34311B0", Offset = "0x34305B0", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60000A5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	[Address(RVA = "0x3431260", Offset = "0x3430660", Length = "0x86")]
	[Token(Token = "0x60000AC")]
	public void set_normalizedSortingGridSize(float value) { }

	[Address(RVA = "0x3431210", Offset = "0x3430610", Length = "0x43")]
	[Token(Token = "0x60000DF")]
	private static void set_normalizedSortingGridSize_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3431340", Offset = "0x3430740", Length = "0x86")]
	[Token(Token = "0x6000089")]
	public void set_overridePixelPerfect(bool value) { }

	[Address(RVA = "0x34312F0", Offset = "0x34306F0", Length = "0x42")]
	[Token(Token = "0x60000C3")]
	private static void set_overridePixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3431420", Offset = "0x3430820", Length = "0x86")]
	[Token(Token = "0x6000092")]
	public void set_overrideSorting(bool value) { }

	[Address(RVA = "0x34313D0", Offset = "0x34307D0", Length = "0x42")]
	[Token(Token = "0x60000CC")]
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3431500", Offset = "0x3430900", Length = "0x86")]
	[Token(Token = "0x600008D")]
	public void set_pixelPerfect(bool value) { }

	[Address(RVA = "0x34314B0", Offset = "0x34308B0", Length = "0x42")]
	[Token(Token = "0x60000C7")]
	private static void set_pixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x34315E0", Offset = "0x34309E0", Length = "0x86")]
	[Token(Token = "0x600008F")]
	public void set_planeDistance(float value) { }

	[Address(RVA = "0x3431590", Offset = "0x3430990", Length = "0x43")]
	[Token(Token = "0x60000C9")]
	private static void set_planeDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x34316C0", Offset = "0x3430AC0", Length = "0x86")]
	[Token(Token = "0x6000087")]
	public void set_referencePixelsPerUnit(float value) { }

	[Address(RVA = "0x3431670", Offset = "0x3430A70", Length = "0x43")]
	[Token(Token = "0x60000C1")]
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3431790", Offset = "0x3430B90", Length = "0x83")]
	[Token(Token = "0x6000081")]
	public void set_renderMode(RenderMode value) { }

	[Address(RVA = "0x3431750", Offset = "0x3430B50", Length = "0x40")]
	[Token(Token = "0x60000BB")]
	private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value) { }

	[Address(RVA = "0x3431870", Offset = "0x3430C70", Length = "0x86")]
	[Token(Token = "0x6000085")]
	public void set_scaleFactor(float value) { }

	[Address(RVA = "0x3431820", Offset = "0x3430C20", Length = "0x43")]
	[Token(Token = "0x60000BF")]
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3431940", Offset = "0x3430D40", Length = "0x83")]
	[Token(Token = "0x60000AE")]
	public void set_sortingGridNormalizedSize(int value) { }

	[Address(RVA = "0x3431900", Offset = "0x3430D00", Length = "0x40")]
	[Token(Token = "0x60000E1")]
	private static void set_sortingGridNormalizedSize_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3431A10", Offset = "0x3430E10", Length = "0x83")]
	[Token(Token = "0x6000098")]
	public void set_sortingLayerID(int value) { }

	[Address(RVA = "0x34319D0", Offset = "0x3430DD0", Length = "0x40")]
	[Token(Token = "0x60000D2")]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3431AF0", Offset = "0x3430EF0", Length = "0x1C7")]
	[Token(Token = "0x600009D")]
	public void set_sortingLayerName(string value) { }

	[Address(RVA = "0x3431AA0", Offset = "0x3430EA0", Length = "0x42")]
	[Token(Token = "0x60000D7")]
	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x3431D00", Offset = "0x3431100", Length = "0x83")]
	[Token(Token = "0x6000094")]
	public void set_sortingOrder(int value) { }

	[Address(RVA = "0x3431CC0", Offset = "0x34310C0", Length = "0x40")]
	[Token(Token = "0x60000CE")]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3431DD0", Offset = "0x34311D0", Length = "0x83")]
	[Token(Token = "0x6000096")]
	public void set_targetDisplay(int value) { }

	[Address(RVA = "0x3431D90", Offset = "0x3431190", Length = "0x40")]
	[Token(Token = "0x60000D0")]
	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3431EA0", Offset = "0x34312A0", Length = "0x83")]
	[Token(Token = "0x60000A1")]
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	[Address(RVA = "0x3431E60", Offset = "0x3431260", Length = "0x40")]
	[Token(Token = "0x60000DB")]
	private static void set_updateRectTransformForStandalone_Injected(IntPtr _unity_self, StandaloneRenderResize value) { }

	[Address(RVA = "0x3431F80", Offset = "0x3431380", Length = "0x86")]
	[Token(Token = "0x600008B")]
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	[Address(RVA = "0x3431F30", Offset = "0x3431330", Length = "0x42")]
	[Token(Token = "0x60000C5")]
	private static void set_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3432060", Offset = "0x3431460", Length = "0xBA")]
	[Token(Token = "0x60000AA")]
	public void set_worldCamera(Camera value) { }

	[Address(RVA = "0x3432010", Offset = "0x3431410", Length = "0x42")]
	[Token(Token = "0x60000DD")]
	private static void set_worldCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x342F8E0", Offset = "0x342ECE0", Length = "0x33")]
	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	[Token(Token = "0x60000A8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	[Address(RVA = "0x342F970", Offset = "0x342ED70", Length = "0x86")]
	[Token(Token = "0x60000B2")]
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	[Address(RVA = "0x342F920", Offset = "0x342ED20", Length = "0x42")]
	[Token(Token = "0x60000E5")]
	private static void UpdateCanvasRectTransform_Injected(IntPtr _unity_self, bool alignWithCamera) { }

}

