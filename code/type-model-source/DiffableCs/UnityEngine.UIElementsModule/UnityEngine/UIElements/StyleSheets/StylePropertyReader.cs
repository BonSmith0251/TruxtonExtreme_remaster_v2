namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000637")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StylePropertyReader
{
	[Token(Token = "0x2000638")]
	public sealed class GetCursorIdFunction : MulticastDelegate
	{

		[Address(RVA = "0x334EED0", Offset = "0x334E2D0", Length = "0x125")]
		[Token(Token = "0x6002C5E")]
		public GetCursorIdFunction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6002C5F")]
		public override int Invoke(StyleSheet sheet, StyleValueHandle handle) { }

	}

	[Token(Token = "0x4001759")]
	internal static GetCursorIdFunction getCursorIdFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400175A")]
	private List<StylePropertyValue> m_Values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400175B")]
	private List<Int32> m_ValueCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400175C")]
	private StyleVariableResolver m_Resolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400175D")]
	private StyleSheet m_Sheet; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400175E")]
	private StyleProperty[] m_Properties; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400175F")]
	private int <m_CurrentValueIndex>k__BackingField; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001760")]
	private int m_CurrentPropertyIndex; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001761")]
	private StyleProperty <property>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001762")]
	private StylePropertyId <propertyId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001763")]
	private int <valueCount>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001764")]
	private float <dpiScaling>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000B53")]
	public private float dpiScaling
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6002C26")]
		 get { } //Length: 6
		[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6002C27")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000B4F")]
	private int m_CurrentValueIndex
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C1E")]
		private get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C1F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B50")]
	public private StyleProperty property
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002C20")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002C21")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000B51")]
	public private StylePropertyId propertyId
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C22")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C23")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B52")]
	public private int valueCount
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C24")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002C25")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3356EB0", Offset = "0x33562B0", Length = "0xF2")]
	[Token(Token = "0x6002C5D")]
	public StylePropertyReader() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6002C26")]
	public float get_dpiScaling() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C1E")]
	private int get_m_CurrentValueIndex() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002C20")]
	public StyleProperty get_property() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C22")]
	public StylePropertyId get_propertyId() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C24")]
	public int get_valueCount() { }

	[Address(RVA = "0x3350C60", Offset = "0x3350060", Length = "0x7B")]
	[Token(Token = "0x6002C2B")]
	public StylePropertyValue GetValue(int index) { }

	[Address(RVA = "0x3350BE0", Offset = "0x334FFE0", Length = "0x7B")]
	[Token(Token = "0x6002C2C")]
	public StyleValueType GetValueType(int index) { }

	[Address(RVA = "0x3350CE0", Offset = "0x33500E0", Length = "0xA6")]
	[Token(Token = "0x6002C2E")]
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	[Address(RVA = "0x3350D90", Offset = "0x3350190", Length = "0x8D")]
	[Token(Token = "0x6002C2D")]
	public bool IsValueType(int index, StyleValueType type) { }

	[Address(RVA = "0x3350E20", Offset = "0x3350220", Length = "0x40B")]
	[Token(Token = "0x6002C4C")]
	private void LoadProperties() { }

	[Address(RVA = "0x3351230", Offset = "0x3350630", Length = "0x22")]
	[Token(Token = "0x6002C2A")]
	public StylePropertyId MoveNextProperty() { }

	[Address(RVA = "0x3351260", Offset = "0x3350660", Length = "0x121")]
	[Token(Token = "0x6002C55")]
	public static Angle ReadAngle(StylePropertyValue value) { }

	[Address(RVA = "0x3351400", Offset = "0x3350800", Length = "0x15A")]
	[Token(Token = "0x6002C3A")]
	public object ReadAsset(int index) { }

	[Address(RVA = "0x3351390", Offset = "0x3350790", Length = "0x6D")]
	[Token(Token = "0x6002C2F")]
	public string ReadAsString(int index) { }

	[Address(RVA = "0x3351FE0", Offset = "0x33513E0", Length = "0x269")]
	[Token(Token = "0x6002C3E")]
	public Background ReadBackground(int index) { }

	[Address(RVA = "0x33515E0", Offset = "0x33509E0", Length = "0x104")]
	[Token(Token = "0x6002C44")]
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	[Address(RVA = "0x33516F0", Offset = "0x3350AF0", Length = "0x1E6")]
	[Token(Token = "0x6002C56")]
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	[Address(RVA = "0x3351560", Offset = "0x3350960", Length = "0x3D")]
	[Token(Token = "0x6002C42")]
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	[Address(RVA = "0x33515A0", Offset = "0x33509A0", Length = "0x3D")]
	[Token(Token = "0x6002C43")]
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	[Address(RVA = "0x3351AD0", Offset = "0x3350ED0", Length = "0x191")]
	[Token(Token = "0x6002C57")]
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	[Address(RVA = "0x33518E0", Offset = "0x3350CE0", Length = "0x1EA")]
	[Token(Token = "0x6002C45")]
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	[Address(RVA = "0x3351D60", Offset = "0x3351160", Length = "0x272")]
	[Token(Token = "0x6002C58")]
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	[Address(RVA = "0x3351C70", Offset = "0x3351070", Length = "0xEF")]
	[Token(Token = "0x6002C46")]
	public BackgroundSize ReadBackgroundSize(int index) { }

	[Address(RVA = "0x3352250", Offset = "0x3351650", Length = "0x95")]
	[Token(Token = "0x6002C38")]
	public Color ReadColor(int index) { }

	[Address(RVA = "0x33522F0", Offset = "0x33516F0", Length = "0x162")]
	[Token(Token = "0x6002C3F")]
	public Cursor ReadCursor(int index) { }

	[Address(RVA = "0x3352460", Offset = "0x3351860", Length = "0x1EC")]
	[Token(Token = "0x6002C5B")]
	internal static Cursor ReadCursor(int valueCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, float dpiScaling = 1) { }

	[Address(RVA = "0x3352720", Offset = "0x3351B20", Length = "0x101")]
	[Token(Token = "0x6002C39")]
	public int ReadEnum(StyleEnumType enumType, int index) { }

	[Address(RVA = "0x3352650", Offset = "0x3351A50", Length = "0xC3")]
	[Token(Token = "0x6002C54")]
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	[Address(RVA = "0x3352830", Offset = "0x3351C30", Length = "0x72")]
	[Token(Token = "0x6002C36")]
	public float ReadFloat(int index) { }

	[Address(RVA = "0x3352DF0", Offset = "0x33521F0", Length = "0x319")]
	[Token(Token = "0x6002C3C")]
	public Font ReadFont(int index) { }

	[Address(RVA = "0x33528B0", Offset = "0x3351CB0", Length = "0x536")]
	[Token(Token = "0x6002C3B")]
	public FontDefinition ReadFontDefinition(int index) { }

	[Address(RVA = "0x3353110", Offset = "0x3352510", Length = "0x77")]
	[Token(Token = "0x6002C37")]
	public int ReadInt(int index) { }

	[Address(RVA = "0x3353190", Offset = "0x3352590", Length = "0x102")]
	[Token(Token = "0x6002C30")]
	public Length ReadLength(int index) { }

	[Address(RVA = "0x33532A0", Offset = "0x33526A0", Length = "0x1FE")]
	[Token(Token = "0x6002C47")]
	public void ReadListEasingFunction(List<EasingFunction> list, int index) { }

	[Address(RVA = "0x33534A0", Offset = "0x33528A0", Length = "0x91E")]
	[Token(Token = "0x6002C49")]
	public void ReadListFilterFunction(List<FilterFunction> list, int index) { }

	[Address(RVA = "0x3353DC0", Offset = "0x33531C0", Length = "0x231")]
	[Token(Token = "0x6002C4A")]
	public void ReadListStylePropertyName(List<StylePropertyName> list, int index) { }

	[Address(RVA = "0x3354000", Offset = "0x3353400", Length = "0x1AB")]
	[Token(Token = "0x6002C48")]
	public void ReadListTimeValue(List<TimeValue> list, int index) { }

	[Address(RVA = "0x33541B0", Offset = "0x33535B0", Length = "0x5A")]
	[Token(Token = "0x6002C3D")]
	public MaterialDefinition ReadMaterialDefinition(int index) { }

	[Address(RVA = "0x3354210", Offset = "0x3353610", Length = "0x2CC")]
	[Token(Token = "0x6002C4B")]
	public StyleRatio ReadRatio(int index) { }

	[Address(RVA = "0x33546F0", Offset = "0x3353AF0", Length = "0x1B3")]
	[Token(Token = "0x6002C34")]
	public Rotate ReadRotate(int index) { }

	[Address(RVA = "0x33544E0", Offset = "0x33538E0", Length = "0x206")]
	[Token(Token = "0x6002C52")]
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	[Address(RVA = "0x33548B0", Offset = "0x3353CB0", Length = "0x20D")]
	[Token(Token = "0x6002C51")]
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	[Address(RVA = "0x3354AC0", Offset = "0x3353EC0", Length = "0x141")]
	[Token(Token = "0x6002C35")]
	public Scale ReadScale(int index) { }

	[Address(RVA = "0x3354C10", Offset = "0x3354010", Length = "0x175")]
	[Token(Token = "0x6002C5A")]
	public static TextAutoSize ReadTextAutoSize(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	[Address(RVA = "0x3354D90", Offset = "0x3354190", Length = "0x265")]
	[Token(Token = "0x6002C41")]
	public TextAutoSize ReadTextAutoSize(int index) { }

	[Address(RVA = "0x3355000", Offset = "0x3354400", Length = "0x3FA")]
	[Token(Token = "0x6002C59")]
	public static TextShadow ReadTextShadow(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	[Address(RVA = "0x3355400", Offset = "0x3354800", Length = "0x1BC")]
	[Token(Token = "0x6002C40")]
	public TextShadow ReadTextShadow(int index) { }

	[Address(RVA = "0x33555C0", Offset = "0x33549C0", Length = "0xA3")]
	[Token(Token = "0x6002C31")]
	public TimeValue ReadTimeValue(int index) { }

	[Address(RVA = "0x3355920", Offset = "0x3354D20", Length = "0x295")]
	[Token(Token = "0x6002C4E")]
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	[Address(RVA = "0x33557C0", Offset = "0x3354BC0", Length = "0x152")]
	[Token(Token = "0x6002C33")]
	public TransformOrigin ReadTransformOrigin(int index) { }

	[Address(RVA = "0x3355670", Offset = "0x3354A70", Length = "0x148")]
	[Token(Token = "0x6002C4F")]
	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	[Address(RVA = "0x3355D20", Offset = "0x3355120", Length = "0x2C4")]
	[Token(Token = "0x6002C50")]
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	[Address(RVA = "0x3355BC0", Offset = "0x3354FC0", Length = "0x157")]
	[Token(Token = "0x6002C32")]
	public Translate ReadTranslate(int index) { }

	[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6002C27")]
	private void set_dpiScaling(float value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C1F")]
	private void set_m_CurrentValueIndex(int value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002C21")]
	private void set_property(StyleProperty value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C23")]
	private void set_propertyId(StylePropertyId value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002C25")]
	private void set_valueCount(int value) { }

	[Address(RVA = "0x3355FF0", Offset = "0x33553F0", Length = "0x86")]
	[Token(Token = "0x6002C28")]
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1) { }

	[Address(RVA = "0x3356080", Offset = "0x3355480", Length = "0xB6")]
	[Token(Token = "0x6002C4D")]
	private void SetCurrentProperty() { }

	[Address(RVA = "0x3356140", Offset = "0x3355540", Length = "0x53")]
	[Token(Token = "0x6002C29")]
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, float dpiScaling = 1) { }

	[Address(RVA = "0x33561A0", Offset = "0x33555A0", Length = "0xC39")]
	[Token(Token = "0x6002C5C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	[Address(RVA = "0x3356DE0", Offset = "0x33561E0", Length = "0xC2")]
	[Token(Token = "0x6002C53")]
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

}

