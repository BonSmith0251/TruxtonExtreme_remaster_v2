namespace UnityEngine.UIElements;

[Token(Token = "0x20004A9")]
public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[CompilerGenerated]
	[Token(Token = "0x20004AD")]
	private sealed class <>c__DisplayClass127_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FD6")]
		public EventBase evt; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FD7")]
		public TextElement <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600238F")]
		public <>c__DisplayClass127_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20004AE")]
	private sealed class <>c__DisplayClass127_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FD8")]
		public long evtTimestamp; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FD9")]
		public <>c__DisplayClass127_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002390")]
		public <>c__DisplayClass127_1() { }

		[Address(RVA = "0x32AFD00", Offset = "0x32AF100", Length = "0xC3")]
		[Token(Token = "0x6002391")]
		internal void <EditionHandleEvent>b__0(FocusEvent _) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20004AA")]
	internal struct GlyphsEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FCB")]
		public readonly int Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000FCC")]
		private readonly List<NativeSlice`1<Vertex>> m_Vertices; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FCD")]
		private readonly TextElement m_TextElement; //Field offset: 0x10

		[Address(RVA = "0x32A09C0", Offset = "0x329FDC0", Length = "0x44")]
		[Token(Token = "0x6002389")]
		internal GlyphsEnumerable(TextElement te, List<NativeSlice`1<Vertex>> vertices) { }

		[Address(RVA = "0x32A0A10", Offset = "0x329FE10", Length = "0x169")]
		[Token(Token = "0x600238A")]
		internal GlyphsEnumerable(TextElement te, List<NativeSlice`1<Vertex>> vertices, Span<ATGMeshInfo> meshInfos) { }

		[Address(RVA = "0x32A08F0", Offset = "0x329FCF0", Length = "0xC0")]
		[Token(Token = "0x600238B")]
		private static int ComputeCount(List<NativeSlice`1<Vertex>> verts) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20004AB")]
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		[Address(RVA = "0x32B6EE0", Offset = "0x32B62E0", Length = "0x39")]
		[Token(Token = "0x600238C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20004AC")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000FCE")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000FCF")]
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000FD0")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000FD1")]
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000FD2")]
		private UxmlBoolAttributeDescription m_Selectable; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000FD3")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000FD4")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000FD5")]
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0xC8

		[Address(RVA = "0x32B74B0", Offset = "0x32B68B0", Length = "0xACF")]
		[Token(Token = "0x600238E")]
		public UxmlTraits() { }

		[Address(RVA = "0x32B6F20", Offset = "0x32B6320", Length = "0x587")]
		[Token(Token = "0x600238D")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000F85")]
	internal static readonly BindingId displayTooltipWhenElidedProperty; //Field offset: 0x0
	[Token(Token = "0x4000FB2")]
	private const string ZeroWidthSpace = "​"; //Field offset: 0x0
	[Token(Token = "0x4000F86")]
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x98
	[Token(Token = "0x4000F87")]
	internal static readonly BindingId enableRichTextProperty; //Field offset: 0x130
	[Token(Token = "0x4000F88")]
	internal static readonly BindingId isElidedProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000F89")]
	internal static readonly BindingId parseEscapeSequencesProperty; //Field offset: 0x260
	[Token(Token = "0x4000F8A")]
	internal static readonly BindingId textProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000F8B")]
	internal static readonly BindingId valueProperty; //Field offset: 0x390
	[Token(Token = "0x4000F8C")]
	public static readonly string ussClassName; //Field offset: 0x428
	[Token(Token = "0x4000F8D")]
	public static readonly string selectableUssClassName; //Field offset: 0x430
	[Token(Token = "0x4000F96")]
	internal static readonly string k_EllipsisText; //Field offset: 0x438
	[Token(Token = "0x4000F99")]
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x440
	[Token(Token = "0x4000F9A")]
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x4D8
	[Token(Token = "0x4000F9B")]
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x570
	[Token(Token = "0x4000F9C")]
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x608
	[Token(Token = "0x4000F9D")]
	internal static readonly BindingId isPasswordProperty; //Field offset: 0x6A0
	[Token(Token = "0x4000F9E")]
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x738
	[Token(Token = "0x4000F9F")]
	internal static readonly BindingId maskCharProperty; //Field offset: 0x7D0
	[Token(Token = "0x4000FB9")]
	internal static readonly BindingId isSelectableProperty; //Field offset: 0x868
	[Token(Token = "0x4000FBA")]
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x900
	[Token(Token = "0x4000FBB")]
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x998
	[Token(Token = "0x4000FBC")]
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0xA30
	[Token(Token = "0x4000FBD")]
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0xAC8
	[Token(Token = "0x4000FBE")]
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0xB60
	[Token(Token = "0x4000FBF")]
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0xBF8
	[Token(Token = "0x4000FC0")]
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0xC90
	[Token(Token = "0x4000FC1")]
	internal static readonly BindingId selectionProperty; //Field offset: 0xD28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000F8E")]
	private Action<GlyphsEnumerable> <PostProcessTextVertices>k__BackingField; //Field offset: 0x2D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000F8F")]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000F90")]
	private string m_Text; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000F91")]
	private bool m_EnableRichText; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F1")]
	[Token(Token = "0x4000F92")]
	private bool m_EmojiFallbackSupport; //Field offset: 0x2F1
	[FieldOffset(Offset = "0x2F2")]
	[Token(Token = "0x4000F93")]
	private bool m_ParseEscapeSequences; //Field offset: 0x2F2
	[FieldOffset(Offset = "0x2F3")]
	[Token(Token = "0x4000F94")]
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x2F3
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000F95")]
	private bool <isElided>k__BackingField; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000F97")]
	internal string elidedText; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000F98")]
	private bool m_WasElided; //Field offset: 0x300
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000FA0")]
	private TextEditingManipulator <editingManipulator>k__BackingField; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000FA1")]
	internal bool isInputField; //Field offset: 0x310
	[FieldOffset(Offset = "0x311")]
	[Token(Token = "0x4000FA2")]
	private bool m_Multiline; //Field offset: 0x311
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000FA3")]
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000FA4")]
	internal Action<Boolean> onIsReadOnlyChanged; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000FA5")]
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x328
	[FieldOffset(Offset = "0x32C")]
	[Token(Token = "0x4000FA6")]
	private bool m_HideMobileInput; //Field offset: 0x32C
	[FieldOffset(Offset = "0x32D")]
	[Token(Token = "0x4000FA7")]
	private bool m_IsReadOnly; //Field offset: 0x32D
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000FA8")]
	private int m_MaxLength; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000FA9")]
	private string m_PlaceholderText; //Field offset: 0x338
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000FAA")]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x340
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000FAB")]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x348
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000FAC")]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x350
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000FAD")]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x358
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000FAE")]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000FAF")]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000FB0")]
	private Action <OnPlaceholderChanged>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000FB1")]
	private Func<String> <UnityEngine.UIElements.ITextEdition.GetDefaultValueType>k__BackingField; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000FB3")]
	private string m_RenderedText; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000FB4")]
	private string m_OriginalText; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000FB5")]
	private char m_MaskChar; //Field offset: 0x390
	[FieldOffset(Offset = "0x392")]
	[Token(Token = "0x4000FB6")]
	private bool m_IsPassword; //Field offset: 0x392
	[FieldOffset(Offset = "0x393")]
	[Token(Token = "0x4000FB7")]
	private bool m_HidePlaceholderTextOnFocus; //Field offset: 0x393
	[FieldOffset(Offset = "0x394")]
	[Token(Token = "0x4000FB8")]
	private bool m_AutoCorrection; //Field offset: 0x394
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000FC2")]
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000FC3")]
	private bool m_IsSelectable; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A1")]
	[Token(Token = "0x4000FC4")]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x3A1
	[FieldOffset(Offset = "0x3A2")]
	[Token(Token = "0x4000FC5")]
	private bool m_TripleClickSelectsLine; //Field offset: 0x3A2
	[FieldOffset(Offset = "0x3A3")]
	[Token(Token = "0x4000FC6")]
	private bool m_SelectAllOnFocus; //Field offset: 0x3A3
	[FieldOffset(Offset = "0x3A4")]
	[Token(Token = "0x4000FC7")]
	private bool m_SelectAllOnMouseUp; //Field offset: 0x3A4
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000FC8")]
	private Color m_SelectionColor; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000FC9")]
	private Color m_CursorColor; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000FCA")]
	private float m_CursorWidth; //Field offset: 0x3C8

	[CreateProperty]
	[Token(Token = "0x17000965")]
	private bool autoCorrection
	{
		[Address(RVA = "0x32A90C0", Offset = "0x32A84C0", Length = "0x48")]
		[Token(Token = "0x6002355")]
		private get { } //Length: 72
		[Address(RVA = "0x32A9DE0", Offset = "0x32A91E0", Length = "0x58")]
		[Token(Token = "0x6002356")]
		private set { } //Length: 88
	}

	[Token(Token = "0x1700097C")]
	internal Color cursorColor
	{
		[Address(RVA = "0x32A9110", Offset = "0x32A8510", Length = "0xE")]
		[Token(Token = "0x6002380")]
		internal get { } //Length: 14
		[Address(RVA = "0x32A9E40", Offset = "0x32A9240", Length = "0x7C")]
		[Token(Token = "0x6002381")]
		internal set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x1700096D")]
	private int cursorIndex
	{
		[Address(RVA = "0x32A9120", Offset = "0x32A8520", Length = "0x48")]
		[Token(Token = "0x6002362")]
		private get { } //Length: 72
		[Address(RVA = "0x32A9EC0", Offset = "0x32A92C0", Length = "0x56")]
		[Token(Token = "0x6002363")]
		private set { } //Length: 86
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000979")]
	private Vector2 cursorPosition
	{
		[Address(RVA = "0x32A9170", Offset = "0x32A8570", Length = "0x48")]
		[Token(Token = "0x600237C")]
		private get { } //Length: 72
	}

	[CreateProperty]
	[Token(Token = "0x17000942")]
	public bool displayTooltipWhenElided
	{
		[Address(RVA = "0x32A91C0", Offset = "0x32A85C0", Length = "0x8")]
		[Token(Token = "0x60022FD")]
		 get { } //Length: 8
		[Address(RVA = "0x32A9F20", Offset = "0x32A9320", Length = "0x8C")]
		[Token(Token = "0x60022FE")]
		 set { } //Length: 140
	}

	[CreateProperty]
	[Token(Token = "0x17000971")]
	internal bool doubleClickSelectsWord
	{
		[Address(RVA = "0x32A91D0", Offset = "0x32A85D0", Length = "0x48")]
		[Token(Token = "0x600236D")]
		internal get { } //Length: 72
		[Address(RVA = "0x32A9FB0", Offset = "0x32A93B0", Length = "0x58")]
		[Token(Token = "0x600236E")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x17000948")]
	internal TextEditingManipulator editingManipulator
	{
		[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002312")]
		internal get { } //Length: 8
		[Address(RVA = "0x32AA010", Offset = "0x32A9410", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002313")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000947")]
	internal ITextEdition edition
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6002311")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700095E")]
	private char effectiveMaskChar
	{
		[Address(RVA = "0x32A9230", Offset = "0x32A8630", Length = "0x5C")]
		[Token(Token = "0x600234A")]
		private get { } //Length: 92
	}

	[CreateProperty]
	[Token(Token = "0x17000940")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0x32A9290", Offset = "0x32A8690", Length = "0x8")]
		[Token(Token = "0x60022F9")]
		 get { } //Length: 8
		[Address(RVA = "0x32AA030", Offset = "0x32A9430", Length = "0x89")]
		[Token(Token = "0x60022FA")]
		 set { } //Length: 137
	}

	[CreateProperty]
	[Token(Token = "0x1700093F")]
	public bool enableRichText
	{
		[Address(RVA = "0x32A92A0", Offset = "0x32A86A0", Length = "0x8")]
		[Token(Token = "0x60022F7")]
		 get { } //Length: 8
		[Address(RVA = "0x32AA0C0", Offset = "0x32A94C0", Length = "0x89")]
		[Token(Token = "0x60022F8")]
		 set { } //Length: 137
	}

	[Token(Token = "0x17000944")]
	internal bool hasFocus
	{
		[Address(RVA = "0x32A92B0", Offset = "0x32A86B0", Length = "0x77")]
		[Token(Token = "0x6002308")]
		internal get { } //Length: 119
	}

	[CreateProperty]
	[Token(Token = "0x1700094E")]
	private bool hideMobileInput
	{
		[Address(RVA = "0x32A9330", Offset = "0x32A8730", Length = "0x48")]
		[Token(Token = "0x600231D")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA150", Offset = "0x32A9550", Length = "0x58")]
		[Token(Token = "0x600231E")]
		private set { } //Length: 88
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000943")]
	public private bool isElided
	{
		[Address(RVA = "0x32A9380", Offset = "0x32A8780", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022FF")]
		 get { } //Length: 8
		[Address(RVA = "0x32AA1B0", Offset = "0x32A95B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002300")]
		private set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x17000960")]
	private bool isPassword
	{
		[Address(RVA = "0x32A9390", Offset = "0x32A8790", Length = "0x48")]
		[Token(Token = "0x600234D")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA1C0", Offset = "0x32A95C0", Length = "0x58")]
		[Token(Token = "0x600234E")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x17000950")]
	private bool isReadOnly
	{
		[Address(RVA = "0x32A93E0", Offset = "0x32A87E0", Length = "0x48")]
		[Token(Token = "0x6002321")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA220", Offset = "0x32A9620", Length = "0x58")]
		[Token(Token = "0x6002322")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x1700096B")]
	internal bool isSelectable
	{
		[Address(RVA = "0x32A9430", Offset = "0x32A8830", Length = "0x45")]
		[Token(Token = "0x600235E")]
		internal get { } //Length: 69
		[Address(RVA = "0x32AA280", Offset = "0x32A9680", Length = "0x58")]
		[Token(Token = "0x600235F")]
		internal set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x1700094C")]
	private TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x32A9480", Offset = "0x32A8880", Length = "0x48")]
		[Token(Token = "0x6002319")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA2E0", Offset = "0x32A96E0", Length = "0x56")]
		[Token(Token = "0x600231A")]
		private set { } //Length: 86
	}

	[CreateProperty]
	[Token(Token = "0x1700095D")]
	private char maskChar
	{
		[Address(RVA = "0x32A94D0", Offset = "0x32A88D0", Length = "0xBB")]
		[Token(Token = "0x6002348")]
		private get { } //Length: 187
		[Address(RVA = "0x32AA340", Offset = "0x32A9740", Length = "0xB4")]
		[Token(Token = "0x6002349")]
		private set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x17000952")]
	private int maxLength
	{
		[Address(RVA = "0x32A9590", Offset = "0x32A8990", Length = "0x48")]
		[Token(Token = "0x600232E")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA400", Offset = "0x32A9800", Length = "0x56")]
		[Token(Token = "0x600232F")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000962")]
	internal bool needsPlaceholderIfTextIsEmpty
	{
		[Address(RVA = "0x32A95E0", Offset = "0x32A89E0", Length = "0x7C")]
		[Token(Token = "0x6002351")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x1700095A")]
	internal Action OnPlaceholderChanged
	{
		[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002340")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002341")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000968")]
	internal string originalText
	{
		[Address(RVA = "0x32A9660", Offset = "0x32A8A60", Length = "0x8")]
		[Token(Token = "0x600235A")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000941")]
	public bool parseEscapeSequences
	{
		[Address(RVA = "0x32A9670", Offset = "0x32A8A70", Length = "0x8")]
		[Token(Token = "0x60022FB")]
		 get { } //Length: 8
		[Address(RVA = "0x32AA460", Offset = "0x32A9860", Length = "0x89")]
		[Token(Token = "0x60022FC")]
		 set { } //Length: 137
	}

	[Token(Token = "0x1700093C")]
	public Action<GlyphsEnumerable> PostProcessTextVertices
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022EF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000966")]
	internal RenderedText renderedText
	{
		[Address(RVA = "0x32A97A0", Offset = "0x32A8BA0", Length = "0x32C")]
		[Token(Token = "0x6002357")]
		internal get { } //Length: 812
	}

	[Token(Token = "0x17000967")]
	internal string renderedTextString
	{
		[Address(RVA = "0x32A9680", Offset = "0x32A8A80", Length = "0x11C")]
		[Token(Token = "0x6002358")]
		internal get { } //Length: 284
	}

	[CreateProperty]
	[Token(Token = "0x17000975")]
	private bool selectAllOnFocus
	{
		[Address(RVA = "0x32A9AD0", Offset = "0x32A8ED0", Length = "0x48")]
		[Token(Token = "0x6002375")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA4F0", Offset = "0x32A98F0", Length = "0x58")]
		[Token(Token = "0x6002376")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x17000977")]
	private bool selectAllOnMouseUp
	{
		[Address(RVA = "0x32A9B20", Offset = "0x32A8F20", Length = "0x48")]
		[Token(Token = "0x6002379")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA550", Offset = "0x32A9950", Length = "0x58")]
		[Token(Token = "0x600237A")]
		private set { } //Length: 88
	}

	[CreateProperty]
	[Token(Token = "0x1700096F")]
	private int selectIndex
	{
		[Address(RVA = "0x32A9B70", Offset = "0x32A8F70", Length = "0x48")]
		[Token(Token = "0x6002366")]
		private get { } //Length: 72
		[Address(RVA = "0x32AA5B0", Offset = "0x32A99B0", Length = "0x56")]
		[Token(Token = "0x6002367")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700097E")]
	internal TextSelectingManipulator selectingManipulator
	{
		[Address(RVA = "0x32A9BC0", Offset = "0x32A8FC0", Length = "0x77")]
		[Token(Token = "0x6002383")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 119
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000969")]
	public ITextSelection selection
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x600235B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700097B")]
	internal Color selectionColor
	{
		[Address(RVA = "0x32A9C40", Offset = "0x32A9040", Length = "0xE")]
		[Token(Token = "0x600237E")]
		internal get { } //Length: 14
		[Address(RVA = "0x32AA610", Offset = "0x32A9A10", Length = "0x7C")]
		[Token(Token = "0x600237F")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x17000963")]
	internal bool showPlaceholderText
	{
		[Address(RVA = "0x32A9C50", Offset = "0x32A9050", Length = "0xB1")]
		[Token(Token = "0x6002352")]
		internal get { } //Length: 177
	}

	[CreateProperty]
	[Token(Token = "0x1700093E")]
	public override string text
	{
		[Address(RVA = "0x32A9D10", Offset = "0x32A9110", Length = "0x3B")]
		[Token(Token = "0x60022F5")]
		 get { } //Length: 59
		[Address(RVA = "0x32AA690", Offset = "0x32A9A90", Length = "0x4D")]
		[Token(Token = "0x60022F6")]
		 set { } //Length: 77
	}

	[CreateProperty]
	[Token(Token = "0x17000973")]
	internal bool tripleClickSelectsLine
	{
		[Address(RVA = "0x32A9D50", Offset = "0x32A9150", Length = "0x48")]
		[Token(Token = "0x6002371")]
		internal get { } //Length: 72
		[Address(RVA = "0x32AA6E0", Offset = "0x32A9AE0", Length = "0x58")]
		[Token(Token = "0x6002372")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x1700093D")]
	internal UITKTextHandle uitkTextHandle
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022F0")]
		internal get { } //Length: 8
		[Address(RVA = "0x3292EB0", Offset = "0x32922B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60022F1")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000945")]
	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		[Address(RVA = "0x32A60D0", Offset = "0x32A54D0", Length = "0x1E")]
		[Token(Token = "0x600230B")]
		private get { } //Length: 30
		[Address(RVA = "0x32A60F0", Offset = "0x32A54F0", Length = "0x205")]
		[Token(Token = "0x600230C")]
		private set { } //Length: 517
	}

	[Token(Token = "0x17000955")]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002336")]
		private get { } //Length: 8
		[Address(RVA = "0x32A66C0", Offset = "0x32A5AC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002337")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000964")]
	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		[Address(RVA = "0x32A65C0", Offset = "0x32A59C0", Length = "0x8")]
		[Token(Token = "0x6002353")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6700", Offset = "0x32A5B00", Length = "0x7F")]
		[Token(Token = "0x6002354")]
		private set { } //Length: 127
	}

	[Token(Token = "0x1700095B")]
	private override Func<String> UnityEngine.UIElements.ITextEdition.GetDefaultValueType
	{
		[Address(RVA = "0x16A5700", Offset = "0x16A4B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002342")]
		private get { } //Length: 8
		[Address(RVA = "0x16A5D50", Offset = "0x16A5150", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002343")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700094D")]
	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		[Address(RVA = "0x32A65D0", Offset = "0x32A59D0", Length = "0x31")]
		[Token(Token = "0x600231B")]
		private get { } //Length: 49
		[Address(RVA = "0x32A6780", Offset = "0x32A5B80", Length = "0x89")]
		[Token(Token = "0x600231C")]
		private set { } //Length: 137
	}

	[Token(Token = "0x17000961")]
	private override bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus
	{
		[Address(RVA = "0x32A6610", Offset = "0x32A5A10", Length = "0x8")]
		[Token(Token = "0x600234F")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6810", Offset = "0x32A5C10", Length = "0x7")]
		[Token(Token = "0x6002350")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000954")]
	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[Address(RVA = "0x32A6620", Offset = "0x32A5A20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002332")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6820", Offset = "0x32A5C20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002333")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700095F")]
	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		[Address(RVA = "0x32A6630", Offset = "0x32A5A30", Length = "0x8")]
		[Token(Token = "0x600234B")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6830", Offset = "0x32A5C30", Length = "0x8F")]
		[Token(Token = "0x600234C")]
		private set { } //Length: 143
	}

	[Token(Token = "0x1700094F")]
	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		[Address(RVA = "0x32A6640", Offset = "0x32A5A40", Length = "0x22")]
		[Token(Token = "0x600231F")]
		private get { } //Length: 34
		[Address(RVA = "0x32A68C0", Offset = "0x32A5CC0", Length = "0x236")]
		[Token(Token = "0x6002320")]
		private set { } //Length: 566
	}

	[Token(Token = "0x1700094B")]
	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		[Address(RVA = "0x32A6670", Offset = "0x32A5A70", Length = "0x7")]
		[Token(Token = "0x6002317")]
		private get { } //Length: 7
		[Address(RVA = "0x32A6B00", Offset = "0x32A5F00", Length = "0x7C")]
		[Token(Token = "0x6002318")]
		private set { } //Length: 124
	}

	[Token(Token = "0x1700095C")]
	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		[Address(RVA = "0x32A6680", Offset = "0x32A5A80", Length = "0x8")]
		[Token(Token = "0x6002346")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6B80", Offset = "0x32A5F80", Length = "0xB3")]
		[Token(Token = "0x6002347")]
		private set { } //Length: 179
	}

	[Token(Token = "0x17000951")]
	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		[Address(RVA = "0x32A6690", Offset = "0x32A5A90", Length = "0x7")]
		[Token(Token = "0x600232C")]
		private get { } //Length: 7
		[Address(RVA = "0x32A6C40", Offset = "0x32A6040", Length = "0xD3")]
		[Token(Token = "0x600232D")]
		private set { } //Length: 211
	}

	[Token(Token = "0x17000959")]
	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600233E")]
		private get { } //Length: 8
		[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600233F")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000949")]
	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		[Address(RVA = "0x32A66A0", Offset = "0x32A5AA0", Length = "0x8")]
		[Token(Token = "0x6002314")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6D20", Offset = "0x32A6120", Length = "0x7D")]
		[Token(Token = "0x6002315")]
		private set { } //Length: 125
	}

	[Token(Token = "0x17000953")]
	private override string UnityEngine.UIElements.ITextEdition.placeholder
	{
		[Address(RVA = "0x32A66B0", Offset = "0x32A5AB0", Length = "0x8")]
		[Token(Token = "0x6002330")]
		private get { } //Length: 8
		[Address(RVA = "0x32A6DA0", Offset = "0x32A61A0", Length = "0x1C5")]
		[Token(Token = "0x6002331")]
		private set { } //Length: 453
	}

	[Token(Token = "0x1700094A")]
	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.touchScreenKeyboard
	{
		[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
		[Token(Token = "0x6002316")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000956")]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[Address(RVA = "0x1662BD0", Offset = "0x1661FD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002338")]
		private get { } //Length: 8
		[Address(RVA = "0x32A66E0", Offset = "0x32A5AE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002339")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000958")]
	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600233C")]
		private get { } //Length: 8
		[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600233D")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000957")]
	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600233A")]
		private get { } //Length: 8
		[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600233B")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700096C")]
	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		[Address(RVA = "0x32A70C0", Offset = "0x32A64C0", Length = "0x73")]
		[Token(Token = "0x6002360")]
		private get { } //Length: 115
		[Address(RVA = "0x32A73E0", Offset = "0x32A67E0", Length = "0xF7")]
		[Token(Token = "0x6002361")]
		private set { } //Length: 247
	}

	[Token(Token = "0x17000978")]
	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		[Address(RVA = "0x32A7140", Offset = "0x32A6540", Length = "0xF9")]
		[Token(Token = "0x600237B")]
		private get { } //Length: 249
	}

	[Token(Token = "0x1700097D")]
	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		[Address(RVA = "0x32A7240", Offset = "0x32A6640", Length = "0x9")]
		[Token(Token = "0x6002382")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000970")]
	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		[Address(RVA = "0x32A7250", Offset = "0x32A6650", Length = "0x8")]
		[Token(Token = "0x600236B")]
		private get { } //Length: 8
		[Address(RVA = "0x32A74E0", Offset = "0x32A68E0", Length = "0x7F")]
		[Token(Token = "0x600236C")]
		private set { } //Length: 127
	}

	[Token(Token = "0x1700096A")]
	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		[Address(RVA = "0x32A7260", Offset = "0x32A6660", Length = "0x39")]
		[Token(Token = "0x600235C")]
		private get { } //Length: 57
		[Address(RVA = "0x32A7560", Offset = "0x32A6960", Length = "0xBD")]
		[Token(Token = "0x600235D")]
		private set { } //Length: 189
	}

	[Token(Token = "0x1700097A")]
	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		[Address(RVA = "0x32A72A0", Offset = "0x32A66A0", Length = "0x85")]
		[Token(Token = "0x600237D")]
		private get { } //Length: 133
	}

	[Token(Token = "0x17000974")]
	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		[Address(RVA = "0x32A7330", Offset = "0x32A6730", Length = "0x8")]
		[Token(Token = "0x6002373")]
		private get { } //Length: 8
		[Address(RVA = "0x32A7620", Offset = "0x32A6A20", Length = "0x7F")]
		[Token(Token = "0x6002374")]
		private set { } //Length: 127
	}

	[Token(Token = "0x17000976")]
	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		[Address(RVA = "0x32A7340", Offset = "0x32A6740", Length = "0x8")]
		[Token(Token = "0x6002377")]
		private get { } //Length: 8
		[Address(RVA = "0x32A76A0", Offset = "0x32A6AA0", Length = "0x7F")]
		[Token(Token = "0x6002378")]
		private set { } //Length: 127
	}

	[Token(Token = "0x1700096E")]
	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		[Address(RVA = "0x32A7350", Offset = "0x32A6750", Length = "0x73")]
		[Token(Token = "0x6002364")]
		private get { } //Length: 115
		[Address(RVA = "0x32A7720", Offset = "0x32A6B20", Length = "0xF7")]
		[Token(Token = "0x6002365")]
		private set { } //Length: 247
	}

	[Token(Token = "0x17000972")]
	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		[Address(RVA = "0x32A73D0", Offset = "0x32A67D0", Length = "0x8")]
		[Token(Token = "0x600236F")]
		private get { } //Length: 8
		[Address(RVA = "0x32A7820", Offset = "0x32A6C20", Length = "0x7F")]
		[Token(Token = "0x6002370")]
		private set { } //Length: 127
	}

	[CreateProperty]
	[Token(Token = "0x17000946")]
	private string value
	{
		[Address(RVA = "0x32A9DA0", Offset = "0x32A91A0", Length = "0x3B")]
		[Token(Token = "0x600230D")]
		private get { } //Length: 59
		[Address(RVA = "0x32AA740", Offset = "0x32A9B40", Length = "0x4D")]
		[Token(Token = "0x600230E")]
		private set { } //Length: 77
	}

	[Address(RVA = "0x32A7AE0", Offset = "0x32A6EE0", Length = "0x12D9")]
	[Token(Token = "0x6002388")]
	private static TextElement() { }

	[Address(RVA = "0x32A8DC0", Offset = "0x32A81C0", Length = "0x2F3")]
	[Token(Token = "0x60022ED")]
	public TextElement() { }

	[Address(RVA = "0x32A2D80", Offset = "0x32A2180", Length = "0x95")]
	[Token(Token = "0x600230F")]
	internal static bool AnySizeAutoOrNone(ComputedStyle computedStyle) { }

	[Address(RVA = "0x32A2E20", Offset = "0x32A2220", Length = "0x333")]
	[Token(Token = "0x6002327")]
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x32A31F0", Offset = "0x32A25F0", Length = "0x3C")]
	[Token(Token = "0x6002325")]
	private void Copy(DropdownMenuAction a) { }

	[Address(RVA = "0x32A3160", Offset = "0x32A2560", Length = "0x8E")]
	[Token(Token = "0x6002329")]
	private Status CopyActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x32A32C0", Offset = "0x32A26C0", Length = "0x3C")]
	[Token(Token = "0x6002324")]
	private void Cut(DropdownMenuAction a) { }

	[Address(RVA = "0x32A3230", Offset = "0x32A2630", Length = "0x8F")]
	[Token(Token = "0x6002328")]
	private Status CutActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x32A3300", Offset = "0x32A2700", Length = "0x2AA")]
	[Token(Token = "0x600230A")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x32A35B0", Offset = "0x32A29B0", Length = "0x2E5")]
	[Token(Token = "0x6002386")]
	internal void DrawCaret(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A38A0", Offset = "0x32A2CA0", Length = "0x91A")]
	[Token(Token = "0x6002384")]
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A41C0", Offset = "0x32A35C0", Length = "0x4D1")]
	[Token(Token = "0x6002385")]
	private void DrawNativeHighlighting(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A46A0", Offset = "0x32A3AA0", Length = "0x478")]
	[Token(Token = "0x600232B")]
	private void EditionHandleEvent(EventBase evt) { }

	[Address(RVA = "0x32A4B20", Offset = "0x32A3F20", Length = "0x480")]
	[Token(Token = "0x6002304")]
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	[Address(RVA = "0x32A90C0", Offset = "0x32A84C0", Length = "0x48")]
	[Token(Token = "0x6002355")]
	private bool get_autoCorrection() { }

	[Address(RVA = "0x32A9110", Offset = "0x32A8510", Length = "0xE")]
	[Token(Token = "0x6002380")]
	internal Color get_cursorColor() { }

	[Address(RVA = "0x32A9120", Offset = "0x32A8520", Length = "0x48")]
	[Token(Token = "0x6002362")]
	private int get_cursorIndex() { }

	[Address(RVA = "0x32A9170", Offset = "0x32A8570", Length = "0x48")]
	[Token(Token = "0x600237C")]
	private Vector2 get_cursorPosition() { }

	[Address(RVA = "0x32A91C0", Offset = "0x32A85C0", Length = "0x8")]
	[Token(Token = "0x60022FD")]
	public bool get_displayTooltipWhenElided() { }

	[Address(RVA = "0x32A91D0", Offset = "0x32A85D0", Length = "0x48")]
	[Token(Token = "0x600236D")]
	internal bool get_doubleClickSelectsWord() { }

	[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002312")]
	internal TextEditingManipulator get_editingManipulator() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002311")]
	internal ITextEdition get_edition() { }

	[Address(RVA = "0x32A9230", Offset = "0x32A8630", Length = "0x5C")]
	[Token(Token = "0x600234A")]
	private char get_effectiveMaskChar() { }

	[Address(RVA = "0x32A9290", Offset = "0x32A8690", Length = "0x8")]
	[Token(Token = "0x60022F9")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0x32A92A0", Offset = "0x32A86A0", Length = "0x8")]
	[Token(Token = "0x60022F7")]
	public bool get_enableRichText() { }

	[Address(RVA = "0x32A92B0", Offset = "0x32A86B0", Length = "0x77")]
	[Token(Token = "0x6002308")]
	internal bool get_hasFocus() { }

	[Address(RVA = "0x32A9330", Offset = "0x32A8730", Length = "0x48")]
	[Token(Token = "0x600231D")]
	private bool get_hideMobileInput() { }

	[Address(RVA = "0x32A9380", Offset = "0x32A8780", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022FF")]
	public bool get_isElided() { }

	[Address(RVA = "0x32A9390", Offset = "0x32A8790", Length = "0x48")]
	[Token(Token = "0x600234D")]
	private bool get_isPassword() { }

	[Address(RVA = "0x32A93E0", Offset = "0x32A87E0", Length = "0x48")]
	[Token(Token = "0x6002321")]
	private bool get_isReadOnly() { }

	[Address(RVA = "0x32A9430", Offset = "0x32A8830", Length = "0x45")]
	[Token(Token = "0x600235E")]
	internal bool get_isSelectable() { }

	[Address(RVA = "0x32A9480", Offset = "0x32A8880", Length = "0x48")]
	[Token(Token = "0x6002319")]
	private TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x32A94D0", Offset = "0x32A88D0", Length = "0xBB")]
	[Token(Token = "0x6002348")]
	private char get_maskChar() { }

	[Address(RVA = "0x32A9590", Offset = "0x32A8990", Length = "0x48")]
	[Token(Token = "0x600232E")]
	private int get_maxLength() { }

	[Address(RVA = "0x32A95E0", Offset = "0x32A89E0", Length = "0x7C")]
	[Token(Token = "0x6002351")]
	internal bool get_needsPlaceholderIfTextIsEmpty() { }

	[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002340")]
	internal Action get_OnPlaceholderChanged() { }

	[Address(RVA = "0x32A9660", Offset = "0x32A8A60", Length = "0x8")]
	[Token(Token = "0x600235A")]
	internal string get_originalText() { }

	[Address(RVA = "0x32A9670", Offset = "0x32A8A70", Length = "0x8")]
	[Token(Token = "0x60022FB")]
	public bool get_parseEscapeSequences() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022EF")]
	public Action<GlyphsEnumerable> get_PostProcessTextVertices() { }

	[Address(RVA = "0x32A97A0", Offset = "0x32A8BA0", Length = "0x32C")]
	[Token(Token = "0x6002357")]
	internal RenderedText get_renderedText() { }

	[Address(RVA = "0x32A9680", Offset = "0x32A8A80", Length = "0x11C")]
	[Token(Token = "0x6002358")]
	internal string get_renderedTextString() { }

	[Address(RVA = "0x32A9AD0", Offset = "0x32A8ED0", Length = "0x48")]
	[Token(Token = "0x6002375")]
	private bool get_selectAllOnFocus() { }

	[Address(RVA = "0x32A9B20", Offset = "0x32A8F20", Length = "0x48")]
	[Token(Token = "0x6002379")]
	private bool get_selectAllOnMouseUp() { }

	[Address(RVA = "0x32A9B70", Offset = "0x32A8F70", Length = "0x48")]
	[Token(Token = "0x6002366")]
	private int get_selectIndex() { }

	[Address(RVA = "0x32A9BC0", Offset = "0x32A8FC0", Length = "0x77")]
	[Token(Token = "0x6002383")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingManipulator get_selectingManipulator() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600235B")]
	public ITextSelection get_selection() { }

	[Address(RVA = "0x32A9C40", Offset = "0x32A9040", Length = "0xE")]
	[Token(Token = "0x600237E")]
	internal Color get_selectionColor() { }

	[Address(RVA = "0x32A9C50", Offset = "0x32A9050", Length = "0xB1")]
	[Token(Token = "0x6002352")]
	internal bool get_showPlaceholderText() { }

	[Address(RVA = "0x32A9D10", Offset = "0x32A9110", Length = "0x3B")]
	[Token(Token = "0x60022F5")]
	public override string get_text() { }

	[Address(RVA = "0x32A9D50", Offset = "0x32A9150", Length = "0x48")]
	[Token(Token = "0x6002371")]
	internal bool get_tripleClickSelectsLine() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022F0")]
	internal UITKTextHandle get_uitkTextHandle() { }

	[Address(RVA = "0x32A9DA0", Offset = "0x32A91A0", Length = "0x3B")]
	[Token(Token = "0x600230D")]
	private string get_value() { }

	[Address(RVA = "0x32A4FB0", Offset = "0x32A43B0", Length = "0x14")]
	[Token(Token = "0x60022EE")]
	private string GetDefaultValueType() { }

	[Address(RVA = "0x32A4FD0", Offset = "0x32A43D0", Length = "0x2D1")]
	[Token(Token = "0x6002387")]
	private int GetLastCharacterAt(int lineIndex) { }

	[Address(RVA = "0x32A52B0", Offset = "0x32A46B0", Length = "0x33B")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(IMEEvent), typeof(GeometryChangedEvent), typeof(AttachToPanelEvent), typeof(DetachFromPanelEvent)})]
	[Token(Token = "0x60022F2")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x32A55F0", Offset = "0x32A49F0", Length = "0x2E")]
	[Token(Token = "0x6002309")]
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	[Address(RVA = "0x32A5620", Offset = "0x32A4A20", Length = "0xD8")]
	[Token(Token = "0x60022F3")]
	private void OnAttachToPanel(AttachToPanelEvent attachEvent) { }

	[Address(RVA = "0x32A5700", Offset = "0x32A4B00", Length = "0x11C")]
	[Token(Token = "0x60022F4")]
	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent) { }

	[Address(RVA = "0x32A59A0", Offset = "0x32A4DA0", Length = "0x170")]
	[Token(Token = "0x6002302")]
	internal void OnGenerateTextOver(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A5820", Offset = "0x32A4C20", Length = "0x170")]
	[Token(Token = "0x6002303")]
	internal void OnGenerateTextOverNative(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A5B20", Offset = "0x32A4F20", Length = "0x15F")]
	[Token(Token = "0x6002301")]
	internal static void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32A5CF0", Offset = "0x32A50F0", Length = "0x3C")]
	[Token(Token = "0x6002326")]
	private void Paste(DropdownMenuAction a) { }

	[Address(RVA = "0x32A5C80", Offset = "0x32A5080", Length = "0x62")]
	[Token(Token = "0x600232A")]
	private Status PasteActionStatus(DropdownMenuAction a) { }

	[Address(RVA = "0x32A5D30", Offset = "0x32A5130", Length = "0x106")]
	[Token(Token = "0x6002323")]
	private void ProcessMenuCommand(string command) { }

	[Address(RVA = "0x32A9DE0", Offset = "0x32A91E0", Length = "0x58")]
	[Token(Token = "0x6002356")]
	private void set_autoCorrection(bool value) { }

	[Address(RVA = "0x32A9E40", Offset = "0x32A9240", Length = "0x7C")]
	[Token(Token = "0x6002381")]
	internal void set_cursorColor(Color value) { }

	[Address(RVA = "0x32A9EC0", Offset = "0x32A92C0", Length = "0x56")]
	[Token(Token = "0x6002363")]
	private void set_cursorIndex(int value) { }

	[Address(RVA = "0x32A9F20", Offset = "0x32A9320", Length = "0x8C")]
	[Token(Token = "0x60022FE")]
	public void set_displayTooltipWhenElided(bool value) { }

	[Address(RVA = "0x32A9FB0", Offset = "0x32A93B0", Length = "0x58")]
	[Token(Token = "0x600236E")]
	internal void set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0x32AA010", Offset = "0x32A9410", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002313")]
	private void set_editingManipulator(TextEditingManipulator value) { }

	[Address(RVA = "0x32AA030", Offset = "0x32A9430", Length = "0x89")]
	[Token(Token = "0x60022FA")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0x32AA0C0", Offset = "0x32A94C0", Length = "0x89")]
	[Token(Token = "0x60022F8")]
	public void set_enableRichText(bool value) { }

	[Address(RVA = "0x32AA150", Offset = "0x32A9550", Length = "0x58")]
	[Token(Token = "0x600231E")]
	private void set_hideMobileInput(bool value) { }

	[Address(RVA = "0x32AA1B0", Offset = "0x32A95B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6002300")]
	private void set_isElided(bool value) { }

	[Address(RVA = "0x32AA1C0", Offset = "0x32A95C0", Length = "0x58")]
	[Token(Token = "0x600234E")]
	private void set_isPassword(bool value) { }

	[Address(RVA = "0x32AA220", Offset = "0x32A9620", Length = "0x58")]
	[Token(Token = "0x6002322")]
	private void set_isReadOnly(bool value) { }

	[Address(RVA = "0x32AA280", Offset = "0x32A9680", Length = "0x58")]
	[Token(Token = "0x600235F")]
	internal void set_isSelectable(bool value) { }

	[Address(RVA = "0x32AA2E0", Offset = "0x32A96E0", Length = "0x56")]
	[Token(Token = "0x600231A")]
	private void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x32AA340", Offset = "0x32A9740", Length = "0xB4")]
	[Token(Token = "0x6002349")]
	private void set_maskChar(char value) { }

	[Address(RVA = "0x32AA400", Offset = "0x32A9800", Length = "0x56")]
	[Token(Token = "0x600232F")]
	private void set_maxLength(int value) { }

	[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002341")]
	internal void set_OnPlaceholderChanged(Action value) { }

	[Address(RVA = "0x32AA460", Offset = "0x32A9860", Length = "0x89")]
	[Token(Token = "0x60022FC")]
	public void set_parseEscapeSequences(bool value) { }

	[Address(RVA = "0x32AA4F0", Offset = "0x32A98F0", Length = "0x58")]
	[Token(Token = "0x6002376")]
	private void set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0x32AA550", Offset = "0x32A9950", Length = "0x58")]
	[Token(Token = "0x600237A")]
	private void set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0x32AA5B0", Offset = "0x32A99B0", Length = "0x56")]
	[Token(Token = "0x6002367")]
	private void set_selectIndex(int value) { }

	[Address(RVA = "0x32AA610", Offset = "0x32A9A10", Length = "0x7C")]
	[Token(Token = "0x600237F")]
	internal void set_selectionColor(Color value) { }

	[Address(RVA = "0x32AA690", Offset = "0x32A9A90", Length = "0x4D")]
	[Token(Token = "0x60022F6")]
	public override void set_text(string value) { }

	[Address(RVA = "0x32AA6E0", Offset = "0x32A9AE0", Length = "0x58")]
	[Token(Token = "0x6002372")]
	internal void set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0x3292EB0", Offset = "0x32922B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60022F1")]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	[Address(RVA = "0x32AA740", Offset = "0x32A9B40", Length = "0x4D")]
	[Token(Token = "0x600230E")]
	private void set_value(string value) { }

	[Address(RVA = "0x16A5AF0", Offset = "0x16A4EF0", Length = "0x13")]
	[Token(Token = "0x6002359")]
	private void SetRenderedText(string value) { }

	[Address(RVA = "0x32A5E40", Offset = "0x32A5240", Length = "0x4A")]
	[Token(Token = "0x6002307")]
	private bool ShouldElide() { }

	[Address(RVA = "0x32A60D0", Offset = "0x32A54D0", Length = "0x1E")]
	[Token(Token = "0x600230B")]
	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	[Address(RVA = "0x32A60F0", Offset = "0x32A54F0", Length = "0x205")]
	[Token(Token = "0x600230C")]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	[Address(RVA = "0x32A5E90", Offset = "0x32A5290", Length = "0x235")]
	[Token(Token = "0x6002310")]
	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	[Address(RVA = "0x32A6300", Offset = "0x32A5700", Length = "0x79")]
	[Token(Token = "0x6002345")]
	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002336")]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	[Address(RVA = "0x32A65C0", Offset = "0x32A59C0", Length = "0x8")]
	[Token(Token = "0x6002353")]
	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	[Address(RVA = "0x16A5700", Offset = "0x16A4B00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002342")]
	private override Func<String> UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType() { }

	[Address(RVA = "0x32A65D0", Offset = "0x32A59D0", Length = "0x31")]
	[Token(Token = "0x600231B")]
	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	[Address(RVA = "0x32A6610", Offset = "0x32A5A10", Length = "0x8")]
	[Token(Token = "0x600234F")]
	private override bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	[Address(RVA = "0x32A6620", Offset = "0x32A5A20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002332")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	[Address(RVA = "0x32A6630", Offset = "0x32A5A30", Length = "0x8")]
	[Token(Token = "0x600234B")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	[Address(RVA = "0x32A6640", Offset = "0x32A5A40", Length = "0x22")]
	[Token(Token = "0x600231F")]
	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	[Address(RVA = "0x32A6670", Offset = "0x32A5A70", Length = "0x7")]
	[Token(Token = "0x6002317")]
	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	[Address(RVA = "0x32A6680", Offset = "0x32A5A80", Length = "0x8")]
	[Token(Token = "0x6002346")]
	private override char UnityEngine.UIElements.ITextEdition.get_maskChar() { }

	[Address(RVA = "0x32A6690", Offset = "0x32A5A90", Length = "0x7")]
	[Token(Token = "0x600232C")]
	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600233E")]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	[Address(RVA = "0x32A66A0", Offset = "0x32A5AA0", Length = "0x8")]
	[Token(Token = "0x6002314")]
	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	[Address(RVA = "0x32A66B0", Offset = "0x32A5AB0", Length = "0x8")]
	[Token(Token = "0x6002330")]
	private override string UnityEngine.UIElements.ITextEdition.get_placeholder() { }

	[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
	[Token(Token = "0x6002316")]
	private override TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.get_touchScreenKeyboard() { }

	[Address(RVA = "0x1662BD0", Offset = "0x1661FD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002338")]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600233C")]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600233A")]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	[Address(RVA = "0x32A6380", Offset = "0x32A5780", Length = "0x1B")]
	[Token(Token = "0x6002335")]
	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	[Address(RVA = "0x32A63A0", Offset = "0x32A57A0", Length = "0x37")]
	[Token(Token = "0x6002334")]
	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[Address(RVA = "0x32A66C0", Offset = "0x32A5AC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002337")]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	[Address(RVA = "0x32A6700", Offset = "0x32A5B00", Length = "0x7F")]
	[Token(Token = "0x6002354")]
	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	[Address(RVA = "0x16A5D50", Offset = "0x16A5150", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002343")]
	private override void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(Func<String> value) { }

	[Address(RVA = "0x32A6780", Offset = "0x32A5B80", Length = "0x89")]
	[Token(Token = "0x600231C")]
	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	[Address(RVA = "0x32A6810", Offset = "0x32A5C10", Length = "0x7")]
	[Token(Token = "0x6002350")]
	private override void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	[Address(RVA = "0x32A6820", Offset = "0x32A5C20", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6002333")]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	[Address(RVA = "0x32A6830", Offset = "0x32A5C30", Length = "0x8F")]
	[Token(Token = "0x600234C")]
	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	[Address(RVA = "0x32A68C0", Offset = "0x32A5CC0", Length = "0x236")]
	[Token(Token = "0x6002320")]
	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	[Address(RVA = "0x32A6B00", Offset = "0x32A5F00", Length = "0x7C")]
	[Token(Token = "0x6002318")]
	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x32A6B80", Offset = "0x32A5F80", Length = "0xB3")]
	[Token(Token = "0x6002347")]
	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	[Address(RVA = "0x32A6C40", Offset = "0x32A6040", Length = "0xD3")]
	[Token(Token = "0x600232D")]
	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600233F")]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	[Address(RVA = "0x32A6D20", Offset = "0x32A6120", Length = "0x7D")]
	[Token(Token = "0x6002315")]
	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	[Address(RVA = "0x32A6DA0", Offset = "0x32A61A0", Length = "0x1C5")]
	[Token(Token = "0x6002331")]
	private override void UnityEngine.UIElements.ITextEdition.set_placeholder(string value) { }

	[Address(RVA = "0x32A66E0", Offset = "0x32A5AE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002339")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600233D")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600233B")]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	[Address(RVA = "0x32A63E0", Offset = "0x32A57E0", Length = "0x1DF")]
	[Token(Token = "0x6002344")]
	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	[Address(RVA = "0x32A70C0", Offset = "0x32A64C0", Length = "0x73")]
	[Token(Token = "0x6002360")]
	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	[Address(RVA = "0x32A7140", Offset = "0x32A6540", Length = "0xF9")]
	[Token(Token = "0x600237B")]
	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	[Address(RVA = "0x32A7240", Offset = "0x32A6640", Length = "0x9")]
	[Token(Token = "0x6002382")]
	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	[Address(RVA = "0x32A7250", Offset = "0x32A6650", Length = "0x8")]
	[Token(Token = "0x600236B")]
	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	[Address(RVA = "0x32A7260", Offset = "0x32A6660", Length = "0x39")]
	[Token(Token = "0x600235C")]
	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	[Address(RVA = "0x32A72A0", Offset = "0x32A66A0", Length = "0x85")]
	[Token(Token = "0x600237D")]
	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	[Address(RVA = "0x32A7330", Offset = "0x32A6730", Length = "0x8")]
	[Token(Token = "0x6002373")]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	[Address(RVA = "0x32A7340", Offset = "0x32A6740", Length = "0x8")]
	[Token(Token = "0x6002377")]
	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	[Address(RVA = "0x32A7350", Offset = "0x32A6750", Length = "0x73")]
	[Token(Token = "0x6002364")]
	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	[Address(RVA = "0x32A73D0", Offset = "0x32A67D0", Length = "0x8")]
	[Token(Token = "0x600236F")]
	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	[Address(RVA = "0x32A6F70", Offset = "0x32A6370", Length = "0x6F")]
	[Token(Token = "0x600236A")]
	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	[Address(RVA = "0x32A6FE0", Offset = "0x32A63E0", Length = "0x6E")]
	[Token(Token = "0x6002368")]
	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	[Address(RVA = "0x32A7050", Offset = "0x32A6450", Length = "0x6E")]
	[Token(Token = "0x6002369")]
	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	[Address(RVA = "0x32A73E0", Offset = "0x32A67E0", Length = "0xF7")]
	[Token(Token = "0x6002361")]
	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	[Address(RVA = "0x32A74E0", Offset = "0x32A68E0", Length = "0x7F")]
	[Token(Token = "0x600236C")]
	private override void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0x32A7560", Offset = "0x32A6960", Length = "0xBD")]
	[Token(Token = "0x600235D")]
	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	[Address(RVA = "0x32A7620", Offset = "0x32A6A20", Length = "0x7F")]
	[Token(Token = "0x6002374")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0x32A76A0", Offset = "0x32A6AA0", Length = "0x7F")]
	[Token(Token = "0x6002378")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0x32A7720", Offset = "0x32A6B20", Length = "0xF7")]
	[Token(Token = "0x6002365")]
	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	[Address(RVA = "0x32A7820", Offset = "0x32A6C20", Length = "0x7F")]
	[Token(Token = "0x6002370")]
	private override void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0x32A78A0", Offset = "0x32A6CA0", Length = "0x77")]
	[Token(Token = "0x6002305")]
	private void UpdateTooltip() { }

	[Address(RVA = "0x32A7920", Offset = "0x32A6D20", Length = "0x1B5")]
	[Token(Token = "0x6002306")]
	private void UpdateVisibleText() { }

}

