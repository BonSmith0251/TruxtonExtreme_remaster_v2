namespace UnityEngine.TextCore;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200000E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class RichTextTagParser
{
	[Nullable(0)]
	[Token(Token = "0x2000017")]
	public class ParseError : IEquatable<ParseError>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AA")]
		public readonly int position; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AB")]
		public readonly string message; //Field offset: 0x18

		[CompilerGenerated]
		[Token(Token = "0x1700000C")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x3185080", Offset = "0x3184480", Length = "0x4D")]
			[CompilerGenerated]
			[Token(Token = "0x6000044")]
			 get { } //Length: 77
		}

		[Address(RVA = "0x3185030", Offset = "0x3184430", Length = "0x42")]
		[Token(Token = "0x6000045")]
		internal ParseError(string message, int position) { }

		[Address(RVA = "0x3184B90", Offset = "0x3183F90", Length = "0x8D")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000049")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x3184C20", Offset = "0x3184020", Length = "0x156")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600004A")]
		public override bool Equals(ParseError other) { }

		[Address(RVA = "0x3185080", Offset = "0x3184480", Length = "0x4D")]
		[CompilerGenerated]
		[Token(Token = "0x6000044")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x3184D80", Offset = "0x3184180", Length = "0x10F")]
		[CompilerGenerated]
		[Token(Token = "0x6000048")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x3184E90", Offset = "0x3184290", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000047")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x3184F40", Offset = "0x3184340", Length = "0xEA")]
		[CompilerGenerated]
		[Token(Token = "0x6000046")]
		public virtual string ToString() { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000016")]
	internal struct Segment
	{
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		[Token(Token = "0x40000A7")]
		public List<Tag> tags; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000A8")]
		public int start; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000A9")]
		public int end; //Field offset: 0xC

	}

	[Nullable(0)]
	[NullableContext(2)]
	[Token(Token = "0x2000015")]
	public struct Tag
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009E")]
		public TagType tagType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400009F")]
		public bool isClosing; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000A0")]
		public int start; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000A1")]
		public int end; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A2")]
		public TagValue value; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A3")]
		public TagValue value2; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A4")]
		public TagValue value3; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000A5")]
		public TagValue value4; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000A6")]
		public TagValue value5; //Field offset: 0x30

	}

	[NullableContext(0)]
	[Token(Token = "0x200000F")]
	internal enum TagType : int
	{
		Hyperlink = 0,
		Align = 1,
		AllCaps = 2,
		Alpha = 3,
		Bold = 4,
		Br = 5,
		Color = 6,
		CSpace = 7,
		Font = 8,
		FontWeight = 9,
		Gradient = 10,
		Italic = 11,
		Indent = 12,
		LineHeight = 13,
		LineIndent = 14,
		Link = 15,
		Lowercase = 16,
		Margin = 17,
		MarginLeft = 18,
		MarginRight = 19,
		Mark = 20,
		Mspace = 21,
		NoBr = 22,
		NoParse = 23,
		Strikethrough = 24,
		Size = 25,
		SmallCaps = 26,
		Space = 27,
		Sprite = 28,
		Style = 29,
		Subscript = 30,
		Superscript = 31,
		Underline = 32,
		Uppercase = 33,
		Unknown = 34,
	}

	[Nullable(0)]
	[Token(Token = "0x2000011")]
	public class TagTypeInfo : IEquatable<TagTypeInfo>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000084")]
		public TagType TagType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000085")]
		public string name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000086")]
		public TagValueType valueType; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000087")]
		public TagUnitType unitType; //Field offset: 0x24

		[CompilerGenerated]
		[Token(Token = "0x17000003")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x318EEA0", Offset = "0x318E2A0", Length = "0x4D")]
			[CompilerGenerated]
			[Token(Token = "0x6000029")]
			 get { } //Length: 77
		}

		[Address(RVA = "0x318EE40", Offset = "0x318E240", Length = "0x58")]
		[Token(Token = "0x600002A")]
		internal TagTypeInfo(TagType tagType, string name, TagValueType valueType = 0, TagUnitType unitType = 0) { }

		[Address(RVA = "0x318E770", Offset = "0x318DB70", Length = "0x8D")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600002E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x318E800", Offset = "0x318DC00", Length = "0x1E4")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600002F")]
		public override bool Equals(TagTypeInfo other) { }

		[Address(RVA = "0x318EEA0", Offset = "0x318E2A0", Length = "0x4D")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x318E9F0", Offset = "0x318DDF0", Length = "0x1B3")]
		[CompilerGenerated]
		[Token(Token = "0x600002D")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x318EBB0", Offset = "0x318DFB0", Length = "0x192")]
		[CompilerGenerated]
		[Token(Token = "0x600002C")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x318ED50", Offset = "0x318E150", Length = "0xEA")]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		public virtual string ToString() { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000013")]
	public enum TagUnitType : int
	{
		Unknown = 0,
		Pixels = 1,
		FontUnits = 2,
		Percentage = 3,
	}

	[Nullable(0)]
	[NullableContext(2)]
	[Token(Token = "0x2000014")]
	public class TagValue : IEquatable<TagValue>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000095")]
		internal TagValueType type; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000096")]
		internal TagUnitType unit; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000097")]
		private string m_stringValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000098")]
		private float m_numericalValue; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000099")]
		private Color m_colorValue; //Field offset: 0x24
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400009A")]
		private Vector4 m_vector4Value; //Field offset: 0x34
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400009B")]
		private GlyphMetrics m_glyphMetricsValue; //Field offset: 0x44
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400009C")]
		private bool m_boolValue; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400009D")]
		private Nullable<ValueID> m_ID; //Field offset: 0x5C

		[Token(Token = "0x1700000A")]
		internal bool BoolValue
		{
			[Address(RVA = "0x318F970", Offset = "0x318ED70", Length = "0x65")]
			[Token(Token = "0x600003C")]
			internal get { } //Length: 101
		}

		[Token(Token = "0x17000007")]
		internal Color ColorValue
		{
			[Address(RVA = "0x318F9E0", Offset = "0x318EDE0", Length = "0x71")]
			[Token(Token = "0x6000039")]
			internal get { } //Length: 113
		}

		[CompilerGenerated]
		[Nullable(1)]
		[Token(Token = "0x17000004")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x318FA60", Offset = "0x318EE60", Length = "0x4D")]
			[CompilerGenerated]
			[NullableContext(1)]
			[Token(Token = "0x6000030")]
			 get { } //Length: 77
		}

		[Token(Token = "0x17000009")]
		internal GlyphMetrics GlyphMetricsValue
		{
			[Address(RVA = "0x318FAB0", Offset = "0x318EEB0", Length = "0x7C")]
			[Token(Token = "0x600003B")]
			internal get { } //Length: 124
		}

		[Token(Token = "0x1700000B")]
		internal Nullable<ValueID> ID
		{
			[Address(RVA = "0x318FB30", Offset = "0x318EF30", Length = "0x7")]
			[Token(Token = "0x600003D")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x17000006")]
		internal float NumericalValue
		{
			[Address(RVA = "0x318FB40", Offset = "0x318EF40", Length = "0x66")]
			[Token(Token = "0x6000038")]
			internal get { } //Length: 102
		}

		[Token(Token = "0x17000005")]
		internal string StringValue
		{
			[Address(RVA = "0x318FBB0", Offset = "0x318EFB0", Length = "0x65")]
			[Token(Token = "0x6000037")]
			internal get { } //Length: 101
		}

		[Token(Token = "0x17000008")]
		internal Vector4 Vector4Value
		{
			[Address(RVA = "0x318FC20", Offset = "0x318F020", Length = "0x71")]
			[Token(Token = "0x600003A")]
			internal get { } //Length: 113
		}

		[Address(RVA = "0x318F7A0", Offset = "0x318EBA0", Length = "0x4F")]
		[Token(Token = "0x6000031")]
		internal TagValue(float value, TagUnitType tagUnitType = 0, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318F7F0", Offset = "0x318EBF0", Length = "0x41")]
		[Token(Token = "0x6000032")]
		internal TagValue(Color value, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318F920", Offset = "0x318ED20", Length = "0x4A")]
		[NullableContext(1)]
		[Token(Token = "0x6000033")]
		internal TagValue(string value, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318F8D0", Offset = "0x318ECD0", Length = "0x41")]
		[Token(Token = "0x6000034")]
		internal TagValue(Vector4 value, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318F840", Offset = "0x318EC40", Length = "0x47")]
		[Token(Token = "0x6000035")]
		internal TagValue(GlyphMetrics value, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318F890", Offset = "0x318EC90", Length = "0x3E")]
		[Token(Token = "0x6000036")]
		internal TagValue(bool value, Nullable<ValueID> id = null) { }

		[Address(RVA = "0x318EEF0", Offset = "0x318E2F0", Length = "0x3A4")]
		[CompilerGenerated]
		[Token(Token = "0x6000043")]
		public override bool Equals(TagValue other) { }

		[Address(RVA = "0x318F2A0", Offset = "0x318E6A0", Length = "0x8D")]
		[CompilerGenerated]
		[Token(Token = "0x6000042")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x318F970", Offset = "0x318ED70", Length = "0x65")]
		[Token(Token = "0x600003C")]
		internal bool get_BoolValue() { }

		[Address(RVA = "0x318F9E0", Offset = "0x318EDE0", Length = "0x71")]
		[Token(Token = "0x6000039")]
		internal Color get_ColorValue() { }

		[Address(RVA = "0x318FA60", Offset = "0x318EE60", Length = "0x4D")]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x6000030")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x318FAB0", Offset = "0x318EEB0", Length = "0x7C")]
		[Token(Token = "0x600003B")]
		internal GlyphMetrics get_GlyphMetricsValue() { }

		[Address(RVA = "0x318FB30", Offset = "0x318EF30", Length = "0x7")]
		[Token(Token = "0x600003D")]
		internal Nullable<ValueID> get_ID() { }

		[Address(RVA = "0x318FB40", Offset = "0x318EF40", Length = "0x66")]
		[Token(Token = "0x6000038")]
		internal float get_NumericalValue() { }

		[Address(RVA = "0x318FBB0", Offset = "0x318EFB0", Length = "0x65")]
		[Token(Token = "0x6000037")]
		internal string get_StringValue() { }

		[Address(RVA = "0x318FC20", Offset = "0x318F020", Length = "0x71")]
		[Token(Token = "0x600003A")]
		internal Vector4 get_Vector4Value() { }

		[Address(RVA = "0x318F330", Offset = "0x318E730", Length = "0x377")]
		[CompilerGenerated]
		[Token(Token = "0x6000041")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x318FCA0", Offset = "0x318F0A0", Length = "0x49")]
		[CompilerGenerated]
		[Token(Token = "0x6000040")]
		public static bool op_Equality(TagValue left, TagValue right) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x600003F")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x318F6B0", Offset = "0x318EAB0", Length = "0xEA")]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x600003E")]
		public virtual string ToString() { }

	}

	[NullableContext(0)]
	[Token(Token = "0x2000012")]
	public enum TagValueType : int
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 3,
		Vector4Value = 4,
		GlyphMetricsValue = 5,
		BoolValue = 6,
	}

	[NullableContext(0)]
	[Token(Token = "0x2000010")]
	internal enum ValueID : int
	{
		Color = 0,
		Padding = 1,
		AssetID = 2,
		GlyphMetrics = 3,
		Scale = 4,
		Tint = 5,
		SpriteColor = 6,
		Gradient = 7,
	}

	[Token(Token = "0x4000050")]
	internal static readonly Color32 k_HighlightColor; //Field offset: 0x0
	[Token(Token = "0x4000051")]
	internal static readonly char k_PrivateArea; //Field offset: 0x4
	[Token(Token = "0x4000052")]
	internal static Color s_AtgHyperlinkColor; //Field offset: 0x8
	[Token(Token = "0x4000053")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static readonly Dictionary<String, IntPtr> s_FontAssetCache; //Field offset: 0x18
	[Token(Token = "0x4000054")]
	internal static readonly Dictionary<String, WeakReference`1<SpriteAsset>> s_SpriteAssetCache; //Field offset: 0x20
	[Token(Token = "0x4000055")]
	internal static readonly Dictionary<String, IntPtr> s_GradientAssetCache; //Field offset: 0x28
	[Token(Token = "0x4000056")]
	internal static readonly TagTypeInfo[] TagsInfo; //Field offset: 0x30

	[Address(RVA = "0x318D150", Offset = "0x318C550", Length = "0x14C3")]
	[Token(Token = "0x6000028")]
	private static RichTextTagParser() { }

	[Address(RVA = "0x31850D0", Offset = "0x31844D0", Length = "0x252")]
	[Token(Token = "0x600001D")]
	private static int AddLink(TagType type, string value, List<ValueTuple`3<Int32, TagType, String>> links) { }

	[Address(RVA = "0x3185330", Offset = "0x3184730", Length = "0xEF")]
	[Token(Token = "0x600001C")]
	internal static void ApplyStateToSegment(string input, List<Tag> tags, Segment[] segments) { }

	[Address(RVA = "0x3185420", Offset = "0x3184820", Length = "0x181")]
	[Token(Token = "0x6000021")]
	private static bool ContainsFontTag(string text) { }

	[Address(RVA = "0x31855B0", Offset = "0x31849B0", Length = "0x181")]
	[Token(Token = "0x6000024")]
	internal static bool ContainsGradientTag(string text) { }

	[Address(RVA = "0x3185740", Offset = "0x3184B40", Length = "0x181")]
	[Token(Token = "0x6000022")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool ContainsSpriteTag(string text) { }

	[Address(RVA = "0x31858D0", Offset = "0x3184CD0", Length = "0x181")]
	[Token(Token = "0x6000023")]
	internal static bool ContainsStyleTags(string text) { }

	[Address(RVA = "0x3185A60", Offset = "0x3184E60", Length = "0x446")]
	[Token(Token = "0x600001F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateTextGenerationSettingsArray(ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor, float pixelsPerPoint, TextSettings textSettings) { }

	[Address(RVA = "0x3185EB0", Offset = "0x31852B0", Length = "0x11DC")]
	[Token(Token = "0x600001E")]
	private static TextSpan CreateTextSpan(Segment segment, ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor, float pixelsPerPoint) { }

	[Address(RVA = "0x3187120", Offset = "0x3186520", Length = "0x1EC4")]
	[Token(Token = "0x6000017")]
	internal static List<Tag> FindTags(ref string inputStr, TextSettings textSettings, bool preprocessingOnly = false, List<ParseError> errors = null) { }

	[Address(RVA = "0x3188FF0", Offset = "0x31883F0", Length = "0x29F")]
	[Token(Token = "0x600001B")]
	internal static Segment[] GenerateSegments(string input, List<Tag> tags) { }

	[Address(RVA = "0x3189290", Offset = "0x3188690", Length = "0x1A2")]
	[NullableContext(0)]
	[Token(Token = "0x6000018")]
	private static ReadOnlySpan<Char> GetAttributeSpan(ReadOnlySpan<Char> attributeSection) { }

	[Address(RVA = "0x3189440", Offset = "0x3188840", Length = "0x463")]
	[Token(Token = "0x6000025")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
	internal static bool HasFontTags(string text, TextSettings textSettings, out List<String>& fontAssetNames) { }

	[Address(RVA = "0x31898B0", Offset = "0x3188CB0", Length = "0x454")]
	[Token(Token = "0x6000027")]
	internal static bool HasGradientTags(string text, TextSettings textSettings, out List<String>& gradientAssetNames) { }

	[Address(RVA = "0x3189D10", Offset = "0x3189110", Length = "0x458")]
	[Token(Token = "0x6000026")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
	internal static bool HasSpriteTags(string text, TextSettings textSettings, out List<String>& spriteAssetNames) { }

	[Address(RVA = "0x318A170", Offset = "0x3189570", Length = "0x183")]
	[Token(Token = "0x6000020")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool MayNeedParsing(string text) { }

	[Address(RVA = "0x318A300", Offset = "0x3189700", Length = "0x105")]
	[NullableContext(0)]
	[Token(Token = "0x600000F")]
	private static TagValue ParseColorAttribute(ReadOnlySpan<Char> attributeSection) { }

	[Address(RVA = "0x318A410", Offset = "0x3189810", Length = "0x109")]
	[NullableContext(0)]
	[Token(Token = "0x6000011")]
	private static TagValue ParseHref(ReadOnlySpan<Char> attributeSection) { }

	[Address(RVA = "0x318A520", Offset = "0x3189920", Length = "0x2CF")]
	[NullableContext(0)]
	[Token(Token = "0x6000010")]
	private static TagValue ParsePaddingAttribute(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x318A7F0", Offset = "0x3189BF0", Length = "0xCAB")]
	[NullableContext(2)]
	[Token(Token = "0x6000013")]
	private static bool ParseSpriteAttributes(ReadOnlySpan<Char> attributeSection, TextSettings textSettings, out char unicode, out TagValue spriteAssetValue, out TagValue glyphMetricsValue, out TagValue tintValue, out TagValue scaleValue, out TagValue colorValue, out string spriteAssetNameOut) { }

	[Address(RVA = "0x318B4A0", Offset = "0x318A8A0", Length = "0x2A7")]
	[NullableContext(0)]
	[Token(Token = "0x6000019")]
	private static TagUnitType ParseTagUnitType(ref ReadOnlySpan<Char>& attributeSection) { }

	[Address(RVA = "0x318B750", Offset = "0x318AB50", Length = "0xA0F")]
	[Token(Token = "0x600001A")]
	internal static List<Tag> PickResultingTags(List<Tag> allTags, string input, int atPosition, List<Tag> applicableTags = null) { }

	[Address(RVA = "0x318C160", Offset = "0x318B560", Length = "0x2B5")]
	[Token(Token = "0x6000014")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void PreloadFontAssetsFromTags(string text, TextSettings textSettings) { }

	[Address(RVA = "0x318C420", Offset = "0x318B820", Length = "0x2B4")]
	[Token(Token = "0x6000016")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void PreloadGradientAssetsFromTags(string text, TextSettings textSettings) { }

	[Address(RVA = "0x318C6E0", Offset = "0x318BAE0", Length = "0x2ED")]
	[Token(Token = "0x6000015")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void PreloadSpriteAssetsFromTags(string text, TextSettings textSettings) { }

	[Address(RVA = "0x318C9D0", Offset = "0x318BDD0", Length = "0x3A9")]
	[NullableContext(0)]
	[Token(Token = "0x600000E")]
	private static bool SpanToEnum(ReadOnlySpan<Char> tagCandidate, out TagType tagType, out string error, out ReadOnlySpan<Char>& attribute) { }

	[Address(RVA = "0x318E620", Offset = "0x318DA20", Length = "0x146")]
	[NullableContext(0)]
	[Token(Token = "0x600000D")]
	private static bool tagMatch(ReadOnlySpan<Char> tagCandidate, string tagName) { }

	[Address(RVA = "0x318CD80", Offset = "0x318C180", Length = "0x3C4")]
	[NullableContext(0)]
	[Token(Token = "0x6000012")]
	private static bool TryGetSimpleHref(ReadOnlySpan<Char> attributeSection, out string hrefValue) { }

}

