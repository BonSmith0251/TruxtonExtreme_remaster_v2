namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
[Token(Token = "0x20000E9")]
public sealed class LineRenderer : Renderer
{

	[Token(Token = "0x17000150")]
	public LineAlignment alignment
	{
		[Address(RVA = "0x2FFF1B0", Offset = "0x2FFE5B0", Length = "0x76")]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFFED0", Offset = "0x2FFF2D0", Length = "0x83")]
		[Token(Token = "0x60006F2")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700014E")]
	public bool applyActiveColorSpace
	{
		[Address(RVA = "0x2FFF270", Offset = "0x2FFE670", Length = "0x76")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFFFB0", Offset = "0x2FFF3B0", Length = "0x86")]
		[Token(Token = "0x60006EE")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000153")]
	public Gradient colorGradient
	{
		[Address(RVA = "0x2FFDF80", Offset = "0x2FFD380", Length = "0x99")]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 153
		[Address(RVA = "0x2FFE6D0", Offset = "0x2FFDAD0", Length = "0xC7")]
		[Token(Token = "0x60006FB")]
		 set { } //Length: 199
	}

	[Token(Token = "0x17000149")]
	public Color endColor
	{
		[Address(RVA = "0x2FFF340", Offset = "0x2FFE740", Length = "0x8E")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 142
		[Address(RVA = "0x3000090", Offset = "0x2FFF490", Length = "0x85")]
		[Token(Token = "0x60006E2")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000142")]
	public float endWidth
	{
		[Address(RVA = "0x2FFF410", Offset = "0x2FFE810", Length = "0x76")]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 118
		[Address(RVA = "0x3000170", Offset = "0x2FFF570", Length = "0x86")]
		[Token(Token = "0x60006D4")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700014D")]
	public bool generateLightingData
	{
		[Address(RVA = "0x2FFF4D0", Offset = "0x2FFE8D0", Length = "0x76")]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 118
		[Address(RVA = "0x3000250", Offset = "0x2FFF650", Length = "0x86")]
		[Token(Token = "0x60006EC")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000147")]
	public bool loop
	{
		[Address(RVA = "0x2FFF590", Offset = "0x2FFE990", Length = "0x76")]
		[Token(Token = "0x60006DD")]
		 get { } //Length: 118
		[Address(RVA = "0x3000330", Offset = "0x2FFF730", Length = "0x86")]
		[Token(Token = "0x60006DE")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000151")]
	public SpriteMaskInteraction maskInteraction
	{
		[Address(RVA = "0x2FFF650", Offset = "0x2FFEA50", Length = "0x76")]
		[Token(Token = "0x60006F3")]
		 get { } //Length: 118
		[Address(RVA = "0x3000400", Offset = "0x2FFF800", Length = "0x83")]
		[Token(Token = "0x60006F4")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000145")]
	public int numCapVertices
	{
		[Address(RVA = "0x2FFF710", Offset = "0x2FFEB10", Length = "0x76")]
		[Token(Token = "0x60006D9")]
		 get { } //Length: 118
		[Address(RVA = "0x30004D0", Offset = "0x2FFF8D0", Length = "0x83")]
		[Token(Token = "0x60006DA")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000144")]
	public int numCornerVertices
	{
		[Address(RVA = "0x2FFF7D0", Offset = "0x2FFEBD0", Length = "0x76")]
		[Token(Token = "0x60006D7")]
		 get { } //Length: 118
		[Address(RVA = "0x30005A0", Offset = "0x2FFF9A0", Length = "0x83")]
		[Token(Token = "0x60006D8")]
		 set { } //Length: 131
	}

	[Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
	[Token(Token = "0x17000140")]
	public int numPositions
	{
		[Address(RVA = "0x2FFF850", Offset = "0x2FFEC50", Length = "0x76")]
		[Token(Token = "0x60006CF")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFEDF0", Offset = "0x2FFE1F0", Length = "0x83")]
		[Token(Token = "0x60006D0")]
		 set { } //Length: 131
	}

	[NativeProperty("PositionsCount")]
	[Token(Token = "0x1700014A")]
	public int positionCount
	{
		[Address(RVA = "0x2FFF850", Offset = "0x2FFEC50", Length = "0x76")]
		[Token(Token = "0x60006E3")]
		 get { } //Length: 118
		[Address(RVA = "0x2FFEDF0", Offset = "0x2FFE1F0", Length = "0x83")]
		[Token(Token = "0x60006E4")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700014C")]
	public float shadowBias
	{
		[Address(RVA = "0x2FFF950", Offset = "0x2FFED50", Length = "0x76")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 118
		[Address(RVA = "0x30006C0", Offset = "0x2FFFAC0", Length = "0x86")]
		[Token(Token = "0x60006EA")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000148")]
	public Color startColor
	{
		[Address(RVA = "0x2FFFA20", Offset = "0x2FFEE20", Length = "0x8E")]
		[Token(Token = "0x60006DF")]
		 get { } //Length: 142
		[Address(RVA = "0x30007A0", Offset = "0x2FFFBA0", Length = "0x85")]
		[Token(Token = "0x60006E0")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000141")]
	public float startWidth
	{
		[Address(RVA = "0x2FFFAF0", Offset = "0x2FFEEF0", Length = "0x76")]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 118
		[Address(RVA = "0x3000880", Offset = "0x2FFFC80", Length = "0x86")]
		[Token(Token = "0x60006D2")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700014F")]
	public LineTextureMode textureMode
	{
		[Address(RVA = "0x2FFFBB0", Offset = "0x2FFEFB0", Length = "0x76")]
		[Token(Token = "0x60006EF")]
		 get { } //Length: 118
		[Address(RVA = "0x3000950", Offset = "0x2FFFD50", Length = "0x83")]
		[Token(Token = "0x60006F0")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700014B")]
	public Vector2 textureScale
	{
		[Address(RVA = "0x2FFFC80", Offset = "0x2FFF080", Length = "0x87")]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 135
		[Address(RVA = "0x3000A30", Offset = "0x2FFFE30", Length = "0x80")]
		[Token(Token = "0x60006E8")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000146")]
	public bool useWorldSpace
	{
		[Address(RVA = "0x2FFFD50", Offset = "0x2FFF150", Length = "0x76")]
		[Token(Token = "0x60006DB")]
		 get { } //Length: 118
		[Address(RVA = "0x3000B10", Offset = "0x2FFFF10", Length = "0x86")]
		[Token(Token = "0x60006DC")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000152")]
	public AnimationCurve widthCurve
	{
		[Address(RVA = "0x2FFE5E0", Offset = "0x2FFD9E0", Length = "0x99")]
		[Token(Token = "0x60006F8")]
		 get { } //Length: 153
		[Address(RVA = "0x2FFEED0", Offset = "0x2FFE2D0", Length = "0xC7")]
		[Token(Token = "0x60006F9")]
		 set { } //Length: 199
	}

	[Token(Token = "0x17000143")]
	public float widthMultiplier
	{
		[Address(RVA = "0x2FFFE10", Offset = "0x2FFF210", Length = "0x76")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 118
		[Address(RVA = "0x3000BF0", Offset = "0x2FFFFF0", Length = "0x86")]
		[Token(Token = "0x60006D6")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000708")]
	public LineRenderer() { }

	[Address(RVA = "0x2FFDDE0", Offset = "0x2FFD1E0", Length = "0x154")]
	[Token(Token = "0x60006F6")]
	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	[Address(RVA = "0x2FFDC90", Offset = "0x2FFD090", Length = "0x14D")]
	[Token(Token = "0x60006F7")]
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Address(RVA = "0x2FFDC20", Offset = "0x2FFD020", Length = "0x64")]
	[Token(Token = "0x600072E")]
	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, bool useTransform) { }

	[Address(RVA = "0x2FFF1B0", Offset = "0x2FFE5B0", Length = "0x76")]
	[Token(Token = "0x60006F1")]
	public LineAlignment get_alignment() { }

	[Address(RVA = "0x2FFF170", Offset = "0x2FFE570", Length = "0x33")]
	[Token(Token = "0x6000729")]
	private static LineAlignment get_alignment_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF270", Offset = "0x2FFE670", Length = "0x76")]
	[Token(Token = "0x60006ED")]
	public bool get_applyActiveColorSpace() { }

	[Address(RVA = "0x2FFF230", Offset = "0x2FFE630", Length = "0x33")]
	[Token(Token = "0x6000725")]
	private static bool get_applyActiveColorSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFDF80", Offset = "0x2FFD380", Length = "0x99")]
	[Token(Token = "0x60006FA")]
	public Gradient get_colorGradient() { }

	[Address(RVA = "0x2FFF340", Offset = "0x2FFE740", Length = "0x8E")]
	[Token(Token = "0x60006E1")]
	public Color get_endColor() { }

	[Address(RVA = "0x2FFF2F0", Offset = "0x2FFE6F0", Length = "0x42")]
	[Token(Token = "0x6000719")]
	private static void get_endColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FFF410", Offset = "0x2FFE810", Length = "0x76")]
	[Token(Token = "0x60006D3")]
	public float get_endWidth() { }

	[Address(RVA = "0x2FFF3D0", Offset = "0x2FFE7D0", Length = "0x33")]
	[Token(Token = "0x600070B")]
	private static float get_endWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF4D0", Offset = "0x2FFE8D0", Length = "0x76")]
	[Token(Token = "0x60006EB")]
	public bool get_generateLightingData() { }

	[Address(RVA = "0x2FFF490", Offset = "0x2FFE890", Length = "0x33")]
	[Token(Token = "0x6000723")]
	private static bool get_generateLightingData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF590", Offset = "0x2FFE990", Length = "0x76")]
	[Token(Token = "0x60006DD")]
	public bool get_loop() { }

	[Address(RVA = "0x2FFF550", Offset = "0x2FFE950", Length = "0x33")]
	[Token(Token = "0x6000715")]
	private static bool get_loop_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF650", Offset = "0x2FFEA50", Length = "0x76")]
	[Token(Token = "0x60006F3")]
	public SpriteMaskInteraction get_maskInteraction() { }

	[Address(RVA = "0x2FFF610", Offset = "0x2FFEA10", Length = "0x33")]
	[Token(Token = "0x600072B")]
	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF710", Offset = "0x2FFEB10", Length = "0x76")]
	[Token(Token = "0x60006D9")]
	public int get_numCapVertices() { }

	[Address(RVA = "0x2FFF6D0", Offset = "0x2FFEAD0", Length = "0x33")]
	[Token(Token = "0x6000711")]
	private static int get_numCapVertices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF7D0", Offset = "0x2FFEBD0", Length = "0x76")]
	[Token(Token = "0x60006D7")]
	public int get_numCornerVertices() { }

	[Address(RVA = "0x2FFF790", Offset = "0x2FFEB90", Length = "0x33")]
	[Token(Token = "0x600070F")]
	private static int get_numCornerVertices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF850", Offset = "0x2FFEC50", Length = "0x76")]
	[Token(Token = "0x60006CF")]
	public int get_numPositions() { }

	[Address(RVA = "0x2FFF850", Offset = "0x2FFEC50", Length = "0x76")]
	[Token(Token = "0x60006E3")]
	public int get_positionCount() { }

	[Address(RVA = "0x2FFF8D0", Offset = "0x2FFECD0", Length = "0x33")]
	[Token(Token = "0x600071B")]
	private static int get_positionCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFF950", Offset = "0x2FFED50", Length = "0x76")]
	[Token(Token = "0x60006E9")]
	public float get_shadowBias() { }

	[Address(RVA = "0x2FFF910", Offset = "0x2FFED10", Length = "0x33")]
	[Token(Token = "0x6000721")]
	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFFA20", Offset = "0x2FFEE20", Length = "0x8E")]
	[Token(Token = "0x60006DF")]
	public Color get_startColor() { }

	[Address(RVA = "0x2FFF9D0", Offset = "0x2FFEDD0", Length = "0x42")]
	[Token(Token = "0x6000717")]
	private static void get_startColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x2FFFAF0", Offset = "0x2FFEEF0", Length = "0x76")]
	[Token(Token = "0x60006D1")]
	public float get_startWidth() { }

	[Address(RVA = "0x2FFFAB0", Offset = "0x2FFEEB0", Length = "0x33")]
	[Token(Token = "0x6000709")]
	private static float get_startWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFFBB0", Offset = "0x2FFEFB0", Length = "0x76")]
	[Token(Token = "0x60006EF")]
	public LineTextureMode get_textureMode() { }

	[Address(RVA = "0x2FFFB70", Offset = "0x2FFEF70", Length = "0x33")]
	[Token(Token = "0x6000727")]
	private static LineTextureMode get_textureMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFFC80", Offset = "0x2FFF080", Length = "0x87")]
	[Token(Token = "0x60006E7")]
	public Vector2 get_textureScale() { }

	[Address(RVA = "0x2FFFC30", Offset = "0x2FFF030", Length = "0x42")]
	[Token(Token = "0x600071F")]
	private static void get_textureScale_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FFFD50", Offset = "0x2FFF150", Length = "0x76")]
	[Token(Token = "0x60006DB")]
	public bool get_useWorldSpace() { }

	[Address(RVA = "0x2FFFD10", Offset = "0x2FFF110", Length = "0x33")]
	[Token(Token = "0x6000713")]
	private static bool get_useWorldSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFE5E0", Offset = "0x2FFD9E0", Length = "0x99")]
	[Token(Token = "0x60006F8")]
	public AnimationCurve get_widthCurve() { }

	[Address(RVA = "0x2FFFE10", Offset = "0x2FFF210", Length = "0x76")]
	[Token(Token = "0x60006D5")]
	public float get_widthMultiplier() { }

	[Address(RVA = "0x2FFFDD0", Offset = "0x2FFF1D0", Length = "0x33")]
	[Token(Token = "0x600070D")]
	private static float get_widthMultiplier_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFDF80", Offset = "0x2FFD380", Length = "0x99")]
	[Token(Token = "0x60006FE")]
	private Gradient GetColorGradientCopy() { }

	[Address(RVA = "0x2FFDF40", Offset = "0x2FFD340", Length = "0x33")]
	[Token(Token = "0x6000731")]
	private static IntPtr GetColorGradientCopy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFE070", Offset = "0x2FFD470", Length = "0x9F")]
	[Token(Token = "0x60006E6")]
	public Vector3 GetPosition(int index) { }

	[Address(RVA = "0x2FFE020", Offset = "0x2FFD420", Length = "0x50")]
	[Token(Token = "0x600071E")]
	private static void GetPosition_Injected(IntPtr _unity_self, int index, out Vector3 ret) { }

	[Address(RVA = "0x2FFE260", Offset = "0x2FFD660", Length = "0x155")]
	[FreeFunction(Name = "LineRendererScripting::GetPositions", HasExplicitThis = True)]
	[Token(Token = "0x6000700")]
	public int GetPositions(out Vector3[] positions) { }

	[Address(RVA = "0x2FFE3C0", Offset = "0x2FFD7C0", Length = "0xD7")]
	[Token(Token = "0x6000704")]
	public int GetPositions(out NativeArray<Vector3> positions) { }

	[Address(RVA = "0x2FFE4A0", Offset = "0x2FFD8A0", Length = "0xF1")]
	[Token(Token = "0x6000705")]
	public int GetPositions(out NativeSlice<Vector3> positions) { }

	[Address(RVA = "0x2FFE210", Offset = "0x2FFD610", Length = "0x42")]
	[Token(Token = "0x6000733")]
	private static int GetPositions_Injected(IntPtr _unity_self, out BlittableArrayWrapper positions) { }

	[Address(RVA = "0x2FFE170", Offset = "0x2FFD570", Length = "0x95")]
	[FreeFunction(Name = "LineRendererScripting::GetPositionsWithNativeContainer", HasExplicitThis = True)]
	[Token(Token = "0x6000707")]
	private int GetPositionsWithNativeContainer(IntPtr positions, int length) { }

	[Address(RVA = "0x2FFE110", Offset = "0x2FFD510", Length = "0x52")]
	[Token(Token = "0x6000736")]
	private static int GetPositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int length) { }

	[Address(RVA = "0x2FFE5E0", Offset = "0x2FFD9E0", Length = "0x99")]
	[Token(Token = "0x60006FC")]
	private AnimationCurve GetWidthCurveCopy() { }

	[Address(RVA = "0x2FFE5A0", Offset = "0x2FFD9A0", Length = "0x33")]
	[Token(Token = "0x600072F")]
	private static IntPtr GetWidthCurveCopy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FFFED0", Offset = "0x2FFF2D0", Length = "0x83")]
	[Token(Token = "0x60006F2")]
	public void set_alignment(LineAlignment value) { }

	[Address(RVA = "0x2FFFE90", Offset = "0x2FFF290", Length = "0x40")]
	[Token(Token = "0x600072A")]
	private static void set_alignment_Injected(IntPtr _unity_self, LineAlignment value) { }

	[Address(RVA = "0x2FFFFB0", Offset = "0x2FFF3B0", Length = "0x86")]
	[Token(Token = "0x60006EE")]
	public void set_applyActiveColorSpace(bool value) { }

	[Address(RVA = "0x2FFFF60", Offset = "0x2FFF360", Length = "0x42")]
	[Token(Token = "0x6000726")]
	private static void set_applyActiveColorSpace_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFE6D0", Offset = "0x2FFDAD0", Length = "0xC7")]
	[Token(Token = "0x60006FB")]
	public void set_colorGradient(Gradient value) { }

	[Address(RVA = "0x3000090", Offset = "0x2FFF490", Length = "0x85")]
	[Token(Token = "0x60006E2")]
	public void set_endColor(Color value) { }

	[Address(RVA = "0x3000040", Offset = "0x2FFF440", Length = "0x42")]
	[Token(Token = "0x600071A")]
	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x3000170", Offset = "0x2FFF570", Length = "0x86")]
	[Token(Token = "0x60006D4")]
	public void set_endWidth(float value) { }

	[Address(RVA = "0x3000120", Offset = "0x2FFF520", Length = "0x43")]
	[Token(Token = "0x600070C")]
	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3000250", Offset = "0x2FFF650", Length = "0x86")]
	[Token(Token = "0x60006EC")]
	public void set_generateLightingData(bool value) { }

	[Address(RVA = "0x3000200", Offset = "0x2FFF600", Length = "0x42")]
	[Token(Token = "0x6000724")]
	private static void set_generateLightingData_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3000330", Offset = "0x2FFF730", Length = "0x86")]
	[Token(Token = "0x60006DE")]
	public void set_loop(bool value) { }

	[Address(RVA = "0x30002E0", Offset = "0x2FFF6E0", Length = "0x42")]
	[Token(Token = "0x6000716")]
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3000400", Offset = "0x2FFF800", Length = "0x83")]
	[Token(Token = "0x60006F4")]
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	[Address(RVA = "0x30003C0", Offset = "0x2FFF7C0", Length = "0x40")]
	[Token(Token = "0x600072C")]
	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	[Address(RVA = "0x30004D0", Offset = "0x2FFF8D0", Length = "0x83")]
	[Token(Token = "0x60006DA")]
	public void set_numCapVertices(int value) { }

	[Address(RVA = "0x3000490", Offset = "0x2FFF890", Length = "0x40")]
	[Token(Token = "0x6000712")]
	private static void set_numCapVertices_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30005A0", Offset = "0x2FFF9A0", Length = "0x83")]
	[Token(Token = "0x60006D8")]
	public void set_numCornerVertices(int value) { }

	[Address(RVA = "0x3000560", Offset = "0x2FFF960", Length = "0x40")]
	[Token(Token = "0x6000710")]
	private static void set_numCornerVertices_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FFEDF0", Offset = "0x2FFE1F0", Length = "0x83")]
	[Token(Token = "0x60006D0")]
	public void set_numPositions(int value) { }

	[Address(RVA = "0x2FFEDF0", Offset = "0x2FFE1F0", Length = "0x83")]
	[Token(Token = "0x60006E4")]
	public void set_positionCount(int value) { }

	[Address(RVA = "0x3000630", Offset = "0x2FFFA30", Length = "0x40")]
	[Token(Token = "0x600071C")]
	private static void set_positionCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30006C0", Offset = "0x2FFFAC0", Length = "0x86")]
	[Token(Token = "0x60006EA")]
	public void set_shadowBias(float value) { }

	[Address(RVA = "0x3000670", Offset = "0x2FFFA70", Length = "0x43")]
	[Token(Token = "0x6000722")]
	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x30007A0", Offset = "0x2FFFBA0", Length = "0x85")]
	[Token(Token = "0x60006E0")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x3000750", Offset = "0x2FFFB50", Length = "0x42")]
	[Token(Token = "0x6000718")]
	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x3000880", Offset = "0x2FFFC80", Length = "0x86")]
	[Token(Token = "0x60006D2")]
	public void set_startWidth(float value) { }

	[Address(RVA = "0x3000830", Offset = "0x2FFFC30", Length = "0x43")]
	[Token(Token = "0x600070A")]
	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3000950", Offset = "0x2FFFD50", Length = "0x83")]
	[Token(Token = "0x60006F0")]
	public void set_textureMode(LineTextureMode value) { }

	[Address(RVA = "0x3000910", Offset = "0x2FFFD10", Length = "0x40")]
	[Token(Token = "0x6000728")]
	private static void set_textureMode_Injected(IntPtr _unity_self, LineTextureMode value) { }

	[Address(RVA = "0x3000A30", Offset = "0x2FFFE30", Length = "0x80")]
	[Token(Token = "0x60006E8")]
	public void set_textureScale(Vector2 value) { }

	[Address(RVA = "0x30009E0", Offset = "0x2FFFDE0", Length = "0x42")]
	[Token(Token = "0x6000720")]
	private static void set_textureScale_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x3000B10", Offset = "0x2FFFF10", Length = "0x86")]
	[Token(Token = "0x60006DC")]
	public void set_useWorldSpace(bool value) { }

	[Address(RVA = "0x3000AC0", Offset = "0x2FFFEC0", Length = "0x42")]
	[Token(Token = "0x6000714")]
	private static void set_useWorldSpace_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FFEED0", Offset = "0x2FFE2D0", Length = "0xC7")]
	[Token(Token = "0x60006F9")]
	public void set_widthCurve(AnimationCurve value) { }

	[Address(RVA = "0x3000BF0", Offset = "0x2FFFFF0", Length = "0x86")]
	[Token(Token = "0x60006D6")]
	public void set_widthMultiplier(float value) { }

	[Address(RVA = "0x3000BA0", Offset = "0x2FFFFA0", Length = "0x43")]
	[Token(Token = "0x600070E")]
	private static void set_widthMultiplier_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FFE6D0", Offset = "0x2FFDAD0", Length = "0xC7")]
	[Token(Token = "0x60006FF")]
	private void SetColorGradient(Gradient curve) { }

	[Address(RVA = "0x2FFE680", Offset = "0x2FFDA80", Length = "0x42")]
	[Token(Token = "0x6000732")]
	private static void SetColorGradient_Injected(IntPtr _unity_self, IntPtr curve) { }

	[Address(RVA = "0x2FFE7A0", Offset = "0x2FFDBA0", Length = "0xF3")]
	[Obsolete("Use startColor, endColor or colorGradient instead.", False)]
	[Token(Token = "0x60006CD")]
	public void SetColors(Color start, Color end) { }

	[Address(RVA = "0x2FFE8F0", Offset = "0x2FFDCF0", Length = "0x93")]
	[Token(Token = "0x60006E5")]
	public void SetPosition(int index, Vector3 position) { }

	[Address(RVA = "0x2FFE8A0", Offset = "0x2FFDCA0", Length = "0x50")]
	[Token(Token = "0x600071D")]
	private static void SetPosition_Injected(IntPtr _unity_self, int index, in Vector3 position) { }

	[Address(RVA = "0x2FFEBE0", Offset = "0x2FFDFE0", Length = "0x126")]
	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	[Token(Token = "0x6000701")]
	public void SetPositions(Vector3[] positions) { }

	[Address(RVA = "0x2FFEAE0", Offset = "0x2FFDEE0", Length = "0xF1")]
	[Token(Token = "0x6000703")]
	public void SetPositions(NativeSlice<Vector3> positions) { }

	[Address(RVA = "0x2FFED10", Offset = "0x2FFE110", Length = "0xD7")]
	[Token(Token = "0x6000702")]
	public void SetPositions(NativeArray<Vector3> positions) { }

	[Address(RVA = "0x2FFEA90", Offset = "0x2FFDE90", Length = "0x42")]
	[Token(Token = "0x6000734")]
	private static void SetPositions_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions) { }

	[Address(RVA = "0x2FFE9F0", Offset = "0x2FFDDF0", Length = "0x95")]
	[FreeFunction(Name = "LineRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = True)]
	[Token(Token = "0x6000706")]
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	[Address(RVA = "0x2FFE990", Offset = "0x2FFDD90", Length = "0x52")]
	[Token(Token = "0x6000735")]
	private static void SetPositionsWithNativeContainer_Injected(IntPtr _unity_self, IntPtr positions, int count) { }

	[Address(RVA = "0x2FFEDF0", Offset = "0x2FFE1F0", Length = "0x83")]
	[Obsolete("Use positionCount instead.", False)]
	[Token(Token = "0x60006CE")]
	public void SetVertexCount(int count) { }

	[Address(RVA = "0x2FFEFA0", Offset = "0x2FFE3A0", Length = "0xED")]
	[Obsolete("Use startWidth, endWidth or widthCurve instead.", False)]
	[Token(Token = "0x60006CC")]
	public void SetWidth(float start, float end) { }

	[Address(RVA = "0x2FFEED0", Offset = "0x2FFE2D0", Length = "0xC7")]
	[Token(Token = "0x60006FD")]
	private void SetWidthCurve(AnimationCurve curve) { }

	[Address(RVA = "0x2FFEE80", Offset = "0x2FFE280", Length = "0x42")]
	[Token(Token = "0x6000730")]
	private static void SetWidthCurve_Injected(IntPtr _unity_self, IntPtr curve) { }

	[Address(RVA = "0x2FFF0E0", Offset = "0x2FFE4E0", Length = "0x86")]
	[Token(Token = "0x60006F5")]
	public void Simplify(float tolerance) { }

	[Address(RVA = "0x2FFF090", Offset = "0x2FFE490", Length = "0x43")]
	[Token(Token = "0x600072D")]
	private static void Simplify_Injected(IntPtr _unity_self, float tolerance) { }

}

