namespace UnityEngine.UIElements;

[Token(Token = "0x20000F4")]
public abstract class TextInputBaseField : BaseField<TValueType>, IDelayedField
{
	[Token(Token = "0x20000F6")]
	private abstract class TextInputBase : VisualElement
	{
		[Token(Token = "0x40004CE")]
		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004C9")]
		public static readonly string innerComponentsModifierName; //Field offset: 0x0
		[Token(Token = "0x40004CA")]
		public static readonly string innerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004CB")]
		internal static readonly string innerTextElementWithScrollViewUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004CC")]
		public static readonly string horizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004CD")]
		public static readonly string verticalVariantInnerTextElementUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004CF")]
		public static readonly string innerScrollviewUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004D0")]
		public static readonly string innerViewportUssClassName; //Field offset: 0x0
		[Token(Token = "0x40004D1")]
		public static readonly string innerContentContainerUssClassName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D4")]
		private bool m_ScrollViewWasClamped; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D3")]
		internal Vector2 scrollOffset; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D2")]
		private bool <isDragging>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C6")]
		private TextElement <textElement>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C8")]
		internal VisualElement multilineContainer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C7")]
		internal ScrollView scrollView; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D5")]
		private Vector2 lastCursorPos; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D6")]
		internal ScrollerVisibility verticalScrollerVisibility; //Field offset: 0x0

		[Token(Token = "0x1700013B")]
		internal bool isDragging
		{
			[Address(RVA = "0x102C810", Offset = "0x102BC10", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x600079E")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x1700013D")]
		internal string originalText
		{
			[Address(RVA = "0x102C770", Offset = "0x102BB70", Length = "0x21")]
			[Token(Token = "0x60007A1")]
			internal get { } //Length: 33
		}

		[Token(Token = "0x1700013C")]
		public string text
		{
			[Address(RVA = "0x102C7E0", Offset = "0x102BBE0", Length = "0x2D")]
			[Token(Token = "0x600079F")]
			 get { } //Length: 45
			[Address(RVA = "0x102C840", Offset = "0x102BC40", Length = "0x73")]
			[Token(Token = "0x60007A0")]
			 set { } //Length: 115
		}

		[Token(Token = "0x1700013A")]
		public ITextEdition textEdition
		{
			[Address(RVA = "0x102C7A0", Offset = "0x102BBA0", Length = "0x20")]
			[Token(Token = "0x600079D")]
			 get { } //Length: 32
		}

		[Token(Token = "0x17000138")]
		internal TextElement textElement
		{
			[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000799")]
			internal get { } //Length: 8
			[Address(RVA = "0x102C820", Offset = "0x102BC20", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x600079A")]
			private set { } //Length: 19
		}

		[Token(Token = "0x17000139")]
		public ITextSelection textSelection
		{
			[Address(RVA = "0x102C7A0", Offset = "0x102BBA0", Length = "0x20")]
			[Token(Token = "0x600079C")]
			 get { } //Length: 32
		}

		[Address(RVA = "0x1029E60", Offset = "0x1029260", Length = "0x88E")]
		[Token(Token = "0x60007B6")]
		private static TextInputBase() { }

		[Address(RVA = "0x102B730", Offset = "0x102AB30", Length = "0x817")]
		[Token(Token = "0x600079B")]
		internal TextInputBase() { }

		[Address(RVA = "0x101DC10", Offset = "0x101D010", Length = "0x72")]
		[Token(Token = "0x60007AD")]
		internal override bool AcceptCharacter(char c) { }

		[Address(RVA = "0x102C770", Offset = "0x102BB70", Length = "0x21")]
		[Token(Token = "0x60007A1")]
		internal string get_originalText() { }

		[Address(RVA = "0x102C7E0", Offset = "0x102BBE0", Length = "0x2D")]
		[Token(Token = "0x600079F")]
		public string get_text() { }

		[Address(RVA = "0x102C7A0", Offset = "0x102BBA0", Length = "0x20")]
		[Token(Token = "0x600079D")]
		public ITextEdition get_textEdition() { }

		[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000799")]
		internal TextElement get_textElement() { }

		[Address(RVA = "0x102C7A0", Offset = "0x102BBA0", Length = "0x20")]
		[Token(Token = "0x600079C")]
		public ITextSelection get_textSelection() { }

		[Address(RVA = "0x101DDC0", Offset = "0x101D1C0", Length = "0x2C")]
		[Token(Token = "0x60007AC")]
		private string GetDefaultValueType() { }

		[Address(RVA = "0x101E320", Offset = "0x101D720", Length = "0x4C1")]
		[Token(Token = "0x60007B0")]
		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

		[Address(RVA = "0x101F190", Offset = "0x101E590", Length = "0x1F")]
		[Token(Token = "0x60007A6")]
		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<Single> evt) { }

		[Address(RVA = "0x101F310", Offset = "0x101E710", Length = "0x152")]
		[Token(Token = "0x60007A5")]
		internal void MoveFocusToCompositeRoot() { }

		[Address(RVA = "0x101FCF0", Offset = "0x101F0F0", Length = "0x2DC")]
		[Token(Token = "0x60007AB")]
		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

		[Address(RVA = "0x10202B0", Offset = "0x101F6B0", Length = "0x5E0")]
		[Token(Token = "0x60007B4")]
		private void RemoveMultilineComponents() { }

		[Address(RVA = "0x1021A70", Offset = "0x1020E70", Length = "0x1AE")]
		[Token(Token = "0x60007B3")]
		private void RemoveSingleLineComponents() { }

		[Address(RVA = "0x10222F0", Offset = "0x10216F0", Length = "0xDE")]
		[Token(Token = "0x60007A9")]
		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[Address(RVA = "0x102C810", Offset = "0x102BC10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600079E")]
		internal void set_isDragging(bool value) { }

		[Address(RVA = "0x102C840", Offset = "0x102BC40", Length = "0x73")]
		[Token(Token = "0x60007A0")]
		public void set_text(string value) { }

		[Address(RVA = "0x102C820", Offset = "0x102BC20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600079A")]
		private void set_textElement(TextElement value) { }

		[Address(RVA = "0x10231F0", Offset = "0x10225F0", Length = "0x7F6")]
		[Token(Token = "0x60007A8")]
		internal void SetMultiline() { }

		[Address(RVA = "0x10228A0", Offset = "0x1021CA0", Length = "0x14F")]
		[Token(Token = "0x60007B2")]
		private void SetMultilineContainerStyle() { }

		[Address(RVA = "0x1025190", Offset = "0x1024590", Length = "0x3C3")]
		[Token(Token = "0x60007B1")]
		internal void SetScrollViewMode() { }

		[Address(RVA = "0x10261D0", Offset = "0x10255D0", Length = "0x2D1")]
		[Token(Token = "0x60007A7")]
		internal void SetSingleLine() { }

		[Address(RVA = "0x1026750", Offset = "0x1025B50", Length = "0xDC")]
		[Token(Token = "0x60007B5")]
		internal bool SetVerticalScrollerVisibility(ScrollerVisibility sv) { }

		[Address(RVA = "0x1026870", Offset = "0x1025C70", Length = "0x39")]
		[Token(Token = "0x60007A2")]
		protected override TValueType StringToValue(string str) { }

		[Address(RVA = "0x1026B30", Offset = "0x1025F30", Length = "0x132")]
		[Token(Token = "0x60007AA")]
		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

		[Address(RVA = "0x1026DB0", Offset = "0x10261B0", Length = "0x1A")]
		[Token(Token = "0x60007AE")]
		internal void UpdateScrollOffset(bool isBackspace = false) { }

		[Address(RVA = "0x1026DF0", Offset = "0x10261F0", Length = "0x544")]
		[Token(Token = "0x60007AF")]
		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

		[Address(RVA = "0x1028370", Offset = "0x1027770", Length = "0x94")]
		[Token(Token = "0x60007A4")]
		internal void UpdateTextFromValue() { }

		[Address(RVA = "0x1028410", Offset = "0x1027810", Length = "0x94")]
		[Token(Token = "0x60007A3")]
		internal void UpdateValueFromText() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F5")]
	internal class UxmlTraits : BaseFieldTraits<String, UxmlStringAttributeDescription>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B6")]
		private UxmlIntAttributeDescription m_MaxLength; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B7")]
		private UxmlBoolAttributeDescription m_Password; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B8")]
		private UxmlStringAttributeDescription m_MaskCharacter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B9")]
		private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BA")]
		private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BB")]
		private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BC")]
		private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BD")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BE")]
		private UxmlBoolAttributeDescription m_SelectAllOnMouseUp; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BF")]
		private UxmlBoolAttributeDescription m_SelectAllOnFocus; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C0")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C1")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C2")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C3")]
		private UxmlBoolAttributeDescription m_HideMobileInput; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C4")]
		private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C5")]
		private UxmlBoolAttributeDescription m_AutoCorrection; //Field offset: 0x0

		[Address(RVA = "0x11E9A90", Offset = "0x11E8E90", Length = "0x780")]
		[Token(Token = "0x6000798")]
		public UxmlTraits() { }

		[Address(RVA = "0x11E83D0", Offset = "0x11E77D0", Length = "0x7DA")]
		[Token(Token = "0x6000797")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000494")]
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x0
	[Token(Token = "0x40004B3")]
	public static readonly string textInputUssName; //Field offset: 0x0
	[Token(Token = "0x40004B2")]
	internal static readonly string multilineInputWithScrollViewUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004B1")]
	public static readonly string placeholderUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004B0")]
	public static readonly string multilineInputUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004AF")]
	public static readonly string singleLineInputUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004AE")]
	internal static readonly string multilineContainerClassName; //Field offset: 0x0
	[Token(Token = "0x40004AD")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004AC")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x40004AB")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40004AA")]
	private static CustomStyleProperty<Color> s_CursorColorProperty; //Field offset: 0x0
	[Token(Token = "0x40004A9")]
	private static CustomStyleProperty<Color> s_SelectionColorProperty; //Field offset: 0x0
	[Token(Token = "0x40004A8")]
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x0
	[Token(Token = "0x40004A7")]
	internal static readonly BindingId maskCharProperty; //Field offset: 0x0
	[Token(Token = "0x40004A6")]
	internal static readonly BindingId isDelayedProperty; //Field offset: 0x0
	[Token(Token = "0x40004A5")]
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x0
	[Token(Token = "0x40004A4")]
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0x0
	[Token(Token = "0x40004A3")]
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0x0
	[Token(Token = "0x4000495")]
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x0
	[Token(Token = "0x4000496")]
	internal static readonly BindingId hidePlaceholderOnFocusProperty; //Field offset: 0x0
	[Token(Token = "0x4000497")]
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x0
	[Token(Token = "0x4000498")]
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x0
	[Token(Token = "0x4000499")]
	internal static readonly BindingId isPasswordFieldProperty; //Field offset: 0x0
	[Token(Token = "0x400049A")]
	internal static readonly BindingId textSelectionProperty; //Field offset: 0x0
	[Token(Token = "0x400049B")]
	internal static readonly BindingId textEditionProperty; //Field offset: 0x0
	[Token(Token = "0x400049D")]
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x0
	[Token(Token = "0x400049E")]
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0x0
	[Token(Token = "0x400049F")]
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x0
	[Token(Token = "0x40004A0")]
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0x0
	[Token(Token = "0x40004A1")]
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0x0
	[Token(Token = "0x40004A2")]
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x0
	[Token(Token = "0x400049C")]
	internal static readonly BindingId placeholderTextProperty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B4")]
	private TextInputBase<TValueType> m_TextInputBase; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B5")]
	internal bool m_UpdateTextFromValue; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x17000127")]
	public bool autoCorrection
	{
		[Address(RVA = "0x1036FE0", Offset = "0x10363E0", Length = "0x67")]
		[Token(Token = "0x600076C")]
		 get { } //Length: 103
		[Address(RVA = "0x1038840", Offset = "0x1037C40", Length = "0x141")]
		[Token(Token = "0x600076D")]
		 set { } //Length: 321
	}

	[Token(Token = "0x17000137")]
	virtual bool canSwitchToMixedValue
	{
		[Address(RVA = "0x10370C0", Offset = "0x10364C0", Length = "0x2F")]
		[Token(Token = "0x600078F")]
		 get { } //Length: 47
	}

	[CreateProperty]
	[Token(Token = "0x1700012D")]
	public int cursorIndex
	{
		[Address(RVA = "0x1037120", Offset = "0x1036520", Length = "0x67")]
		[Token(Token = "0x6000778")]
		 get { } //Length: 103
		[Address(RVA = "0x1038D80", Offset = "0x1038180", Length = "0x145")]
		[Token(Token = "0x6000779")]
		 set { } //Length: 325
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700012E")]
	public Vector2 cursorPosition
	{
		[Address(RVA = "0x1037270", Offset = "0x1036670", Length = "0x67")]
		[Token(Token = "0x600077A")]
		 get { } //Length: 103
	}

	[CreateProperty]
	[Token(Token = "0x17000132")]
	public bool doubleClickSelectsWord
	{
		[Address(RVA = "0x1037430", Offset = "0x1036830", Length = "0x67")]
		[Token(Token = "0x6000781")]
		 get { } //Length: 103
		[Address(RVA = "0x10392C0", Offset = "0x10386C0", Length = "0x148")]
		[Token(Token = "0x6000782")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000135")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0x1037510", Offset = "0x1036910", Length = "0x2D")]
		[Token(Token = "0x6000787")]
		 get { } //Length: 45
		[Address(RVA = "0x1039410", Offset = "0x1038810", Length = "0x107")]
		[Token(Token = "0x6000788")]
		 set { } //Length: 263
	}

	[CreateProperty]
	[Token(Token = "0x17000128")]
	public bool hideMobileInput
	{
		[Address(RVA = "0x10375E0", Offset = "0x10369E0", Length = "0x67")]
		[Token(Token = "0x600076E")]
		 get { } //Length: 103
		[Address(RVA = "0x1039630", Offset = "0x1038A30", Length = "0x148")]
		[Token(Token = "0x600076F")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000120")]
	internal bool hidePlaceholderOnFocus
	{
		[Address(RVA = "0x1037730", Offset = "0x1036B30", Length = "0x67")]
		[Token(Token = "0x6000760")]
		internal get { } //Length: 103
		[Address(RVA = "0x1039A20", Offset = "0x1038E20", Length = "0x148")]
		[Token(Token = "0x6000761")]
		internal set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700012B")]
	public override bool isDelayed
	{
		[Address(RVA = "0x10378F0", Offset = "0x1036CF0", Length = "0x67")]
		[Token(Token = "0x6000774")]
		 get { } //Length: 103
		[Address(RVA = "0x1039E10", Offset = "0x1039210", Length = "0x148")]
		[Token(Token = "0x6000775")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000126")]
	public bool isPasswordField
	{
		[Address(RVA = "0x1037960", Offset = "0x1036D60", Length = "0x67")]
		[Token(Token = "0x600076A")]
		 get { } //Length: 103
		[Address(RVA = "0x103A200", Offset = "0x1039600", Length = "0x165")]
		[Token(Token = "0x600076B")]
		 set { } //Length: 357
	}

	[CreateProperty]
	[Token(Token = "0x17000125")]
	public bool isReadOnly
	{
		[Address(RVA = "0x1037AB0", Offset = "0x1036EB0", Length = "0x67")]
		[Token(Token = "0x6000768")]
		 get { } //Length: 103
		[Address(RVA = "0x103A7A0", Offset = "0x1039BA0", Length = "0x148")]
		[Token(Token = "0x6000769")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000129")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x1037C00", Offset = "0x1037000", Length = "0x67")]
		[Token(Token = "0x6000770")]
		 get { } //Length: 103
		[Address(RVA = "0x103ACE0", Offset = "0x103A0E0", Length = "0x145")]
		[Token(Token = "0x6000771")]
		 set { } //Length: 325
	}

	[CreateProperty]
	[Token(Token = "0x1700012C")]
	public char maskChar
	{
		[Address(RVA = "0x1037DC0", Offset = "0x10371C0", Length = "0x67")]
		[Token(Token = "0x6000776")]
		 get { } //Length: 103
		[Address(RVA = "0x103AE30", Offset = "0x103A230", Length = "0x148")]
		[Token(Token = "0x6000777")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700012A")]
	public int maxLength
	{
		[Address(RVA = "0x1037F80", Offset = "0x1037380", Length = "0x67")]
		[Token(Token = "0x6000772")]
		 get { } //Length: 103
		[Address(RVA = "0x103B3F0", Offset = "0x103A7F0", Length = "0x1BF")]
		[Token(Token = "0x6000773")]
		 set { } //Length: 447
	}

	[Token(Token = "0x17000124")]
	protected Action<Boolean> onIsReadOnlyChanged
	{
		[Address(RVA = "0x1038020", Offset = "0x1037420", Length = "0x2D")]
		[Token(Token = "0x6000766")]
		 get { } //Length: 45
		[Address(RVA = "0x103B770", Offset = "0x103AB70", Length = "0x38")]
		[Token(Token = "0x6000767")]
		 set { } //Length: 56
	}

	[Token(Token = "0x1700011D")]
	internal bool password
	{
		[Address(RVA = "0x103B870", Offset = "0x103AC70", Length = "0x77")]
		[Token(Token = "0x600075C")]
		internal set { } //Length: 119
	}

	[CreateProperty]
	[Token(Token = "0x1700011F")]
	internal string placeholderText
	{
		[Address(RVA = "0x1038130", Offset = "0x1037530", Length = "0x67")]
		[Token(Token = "0x600075E")]
		internal get { } //Length: 103
		[Address(RVA = "0x103BC30", Offset = "0x103B030", Length = "0x154")]
		[Token(Token = "0x600075F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 340
	}

	[Token(Token = "0x1700011E")]
	internal bool readOnly
	{
		[Address(RVA = "0x103BD90", Offset = "0x103B190", Length = "0x154")]
		[Token(Token = "0x600075D")]
		internal set { } //Length: 340
	}

	[CreateProperty]
	[Token(Token = "0x17000130")]
	public bool selectAllOnFocus
	{
		[Address(RVA = "0x1038210", Offset = "0x1037610", Length = "0x67")]
		[Token(Token = "0x600077D")]
		 get { } //Length: 103
		[Address(RVA = "0x103C450", Offset = "0x103B850", Length = "0x148")]
		[Token(Token = "0x600077E")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000131")]
	public bool selectAllOnMouseUp
	{
		[Address(RVA = "0x10383D0", Offset = "0x10377D0", Length = "0x67")]
		[Token(Token = "0x600077F")]
		 get { } //Length: 103
		[Address(RVA = "0x103C840", Offset = "0x103BC40", Length = "0x148")]
		[Token(Token = "0x6000780")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x1700012F")]
	public int selectIndex
	{
		[Address(RVA = "0x1038440", Offset = "0x1037840", Length = "0x67")]
		[Token(Token = "0x600077B")]
		 get { } //Length: 103
		[Address(RVA = "0x103CAE0", Offset = "0x103BEE0", Length = "0x145")]
		[Token(Token = "0x600077C")]
		 set { } //Length: 325
	}

	[Token(Token = "0x17000134")]
	public private string text
	{
		[Address(RVA = "0x1038610", Offset = "0x1037A10", Length = "0x30")]
		[Token(Token = "0x6000785")]
		 get { } //Length: 48
		[Address(RVA = "0x103CDC0", Offset = "0x103C1C0", Length = "0x30")]
		[Token(Token = "0x6000786")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		private set { } //Length: 48
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000123")]
	public ITextEdition textEdition
	{
		[Address(RVA = "0x1038590", Offset = "0x1037990", Length = "0x2C")]
		[Token(Token = "0x6000765")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000121")]
	protected private TextInputBase<TValueType> textInputBase
	{
		[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
		[Token(Token = "0x6000763")]
		private get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000122")]
	public ITextSelection textSelection
	{
		[Address(RVA = "0x1038590", Offset = "0x1037990", Length = "0x2C")]
		[Token(Token = "0x6000764")]
		 get { } //Length: 44
	}

	[CreateProperty]
	[Token(Token = "0x17000133")]
	public bool tripleClickSelectsLine
	{
		[Address(RVA = "0x1038770", Offset = "0x1037B70", Length = "0x67")]
		[Token(Token = "0x6000783")]
		 get { } //Length: 103
		[Address(RVA = "0x103CE00", Offset = "0x103C200", Length = "0x148")]
		[Token(Token = "0x6000784")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x17000136")]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Address(RVA = "0x10387E0", Offset = "0x1037BE0", Length = "0x20")]
		[Token(Token = "0x6000789")]
		 get { } //Length: 32
		[Address(RVA = "0x103D1F0", Offset = "0x103C5F0", Length = "0xC4")]
		[Token(Token = "0x600078A")]
		 set { } //Length: 196
	}

	[Address(RVA = "0x10313A0", Offset = "0x10307A0", Length = "0x27CE")]
	[Token(Token = "0x6000796")]
	private static TextInputBaseField`1() { }

	[Address(RVA = "0x1036340", Offset = "0x1035740", Length = "0x400")]
	[Token(Token = "0x6000762")]
	protected TextInputBaseField`1(string label, int maxLength, char maskChar, TextInputBase<TValueType> textInputBase) { }

	[Address(RVA = "0x1036FE0", Offset = "0x10363E0", Length = "0x67")]
	[Token(Token = "0x600076C")]
	public bool get_autoCorrection() { }

	[Address(RVA = "0x10370C0", Offset = "0x10364C0", Length = "0x2F")]
	[Token(Token = "0x600078F")]
	virtual bool get_canSwitchToMixedValue() { }

	[Address(RVA = "0x1037120", Offset = "0x1036520", Length = "0x67")]
	[Token(Token = "0x6000778")]
	public int get_cursorIndex() { }

	[Address(RVA = "0x1037270", Offset = "0x1036670", Length = "0x67")]
	[Token(Token = "0x600077A")]
	public Vector2 get_cursorPosition() { }

	[Address(RVA = "0x1037430", Offset = "0x1036830", Length = "0x67")]
	[Token(Token = "0x6000781")]
	public bool get_doubleClickSelectsWord() { }

	[Address(RVA = "0x1037510", Offset = "0x1036910", Length = "0x2D")]
	[Token(Token = "0x6000787")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0x10375E0", Offset = "0x10369E0", Length = "0x67")]
	[Token(Token = "0x600076E")]
	public bool get_hideMobileInput() { }

	[Address(RVA = "0x1037730", Offset = "0x1036B30", Length = "0x67")]
	[Token(Token = "0x6000760")]
	internal bool get_hidePlaceholderOnFocus() { }

	[Address(RVA = "0x10378F0", Offset = "0x1036CF0", Length = "0x67")]
	[Token(Token = "0x6000774")]
	public override bool get_isDelayed() { }

	[Address(RVA = "0x1037960", Offset = "0x1036D60", Length = "0x67")]
	[Token(Token = "0x600076A")]
	public bool get_isPasswordField() { }

	[Address(RVA = "0x1037AB0", Offset = "0x1036EB0", Length = "0x67")]
	[Token(Token = "0x6000768")]
	public bool get_isReadOnly() { }

	[Address(RVA = "0x1037C00", Offset = "0x1037000", Length = "0x67")]
	[Token(Token = "0x6000770")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x1037DC0", Offset = "0x10371C0", Length = "0x67")]
	[Token(Token = "0x6000776")]
	public char get_maskChar() { }

	[Address(RVA = "0x1037F80", Offset = "0x1037380", Length = "0x67")]
	[Token(Token = "0x6000772")]
	public int get_maxLength() { }

	[Address(RVA = "0x1038020", Offset = "0x1037420", Length = "0x2D")]
	[Token(Token = "0x6000766")]
	protected Action<Boolean> get_onIsReadOnlyChanged() { }

	[Address(RVA = "0x1038130", Offset = "0x1037530", Length = "0x67")]
	[Token(Token = "0x600075E")]
	internal string get_placeholderText() { }

	[Address(RVA = "0x1038210", Offset = "0x1037610", Length = "0x67")]
	[Token(Token = "0x600077D")]
	public bool get_selectAllOnFocus() { }

	[Address(RVA = "0x10383D0", Offset = "0x10377D0", Length = "0x67")]
	[Token(Token = "0x600077F")]
	public bool get_selectAllOnMouseUp() { }

	[Address(RVA = "0x1038440", Offset = "0x1037840", Length = "0x67")]
	[Token(Token = "0x600077B")]
	public int get_selectIndex() { }

	[Address(RVA = "0x1038610", Offset = "0x1037A10", Length = "0x30")]
	[Token(Token = "0x6000785")]
	public string get_text() { }

	[Address(RVA = "0x1038590", Offset = "0x1037990", Length = "0x2C")]
	[Token(Token = "0x6000765")]
	public ITextEdition get_textEdition() { }

	[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
	[Token(Token = "0x6000763")]
	protected private TextInputBase<TValueType> get_textInputBase() { }

	[Address(RVA = "0x1038590", Offset = "0x1037990", Length = "0x2C")]
	[Token(Token = "0x6000764")]
	public ITextSelection get_textSelection() { }

	[Address(RVA = "0x1038770", Offset = "0x1037B70", Length = "0x67")]
	[Token(Token = "0x6000783")]
	public bool get_tripleClickSelectsLine() { }

	[Address(RVA = "0x10387E0", Offset = "0x1037BE0", Length = "0x20")]
	[Token(Token = "0x6000789")]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[Address(RVA = "0x102D100", Offset = "0x102C500", Length = "0x41C")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationSubmitEvent), typeof(FocusInEvent), typeof(FocusEvent), typeof(FocusOutEvent), typeof(BlurEvent)})]
	[Token(Token = "0x600078B")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x102D520", Offset = "0x102C920", Length = "0x30")]
	[Token(Token = "0x6000795")]
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0x102D900", Offset = "0x102CD00", Length = "0x187")]
	[Token(Token = "0x6000791")]
	internal void OnPlaceholderChanged() { }

	[Address(RVA = "0x1038840", Offset = "0x1037C40", Length = "0x141")]
	[Token(Token = "0x600076D")]
	public void set_autoCorrection(bool value) { }

	[Address(RVA = "0x1038D80", Offset = "0x1038180", Length = "0x145")]
	[Token(Token = "0x6000779")]
	public void set_cursorIndex(int value) { }

	[Address(RVA = "0x10392C0", Offset = "0x10386C0", Length = "0x148")]
	[Token(Token = "0x6000782")]
	public void set_doubleClickSelectsWord(bool value) { }

	[Address(RVA = "0x1039410", Offset = "0x1038810", Length = "0x107")]
	[Token(Token = "0x6000788")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0x1039630", Offset = "0x1038A30", Length = "0x148")]
	[Token(Token = "0x600076F")]
	public void set_hideMobileInput(bool value) { }

	[Address(RVA = "0x1039A20", Offset = "0x1038E20", Length = "0x148")]
	[Token(Token = "0x6000761")]
	internal void set_hidePlaceholderOnFocus(bool value) { }

	[Address(RVA = "0x1039E10", Offset = "0x1039210", Length = "0x148")]
	[Token(Token = "0x6000775")]
	public void set_isDelayed(bool value) { }

	[Address(RVA = "0x103A200", Offset = "0x1039600", Length = "0x165")]
	[Token(Token = "0x600076B")]
	public void set_isPasswordField(bool value) { }

	[Address(RVA = "0x103A7A0", Offset = "0x1039BA0", Length = "0x148")]
	[Token(Token = "0x6000769")]
	public void set_isReadOnly(bool value) { }

	[Address(RVA = "0x103ACE0", Offset = "0x103A0E0", Length = "0x145")]
	[Token(Token = "0x6000771")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x103AE30", Offset = "0x103A230", Length = "0x148")]
	[Token(Token = "0x6000777")]
	public void set_maskChar(char value) { }

	[Address(RVA = "0x103B3F0", Offset = "0x103A7F0", Length = "0x1BF")]
	[Token(Token = "0x6000773")]
	public void set_maxLength(int value) { }

	[Address(RVA = "0x103B770", Offset = "0x103AB70", Length = "0x38")]
	[Token(Token = "0x6000767")]
	protected void set_onIsReadOnlyChanged(Action<Boolean> value) { }

	[Address(RVA = "0x103B870", Offset = "0x103AC70", Length = "0x77")]
	[Token(Token = "0x600075C")]
	internal void set_password(bool value) { }

	[Address(RVA = "0x103BC30", Offset = "0x103B030", Length = "0x154")]
	[Token(Token = "0x600075F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_placeholderText(string value) { }

	[Address(RVA = "0x103BD90", Offset = "0x103B190", Length = "0x154")]
	[Token(Token = "0x600075D")]
	internal void set_readOnly(bool value) { }

	[Address(RVA = "0x103C450", Offset = "0x103B850", Length = "0x148")]
	[Token(Token = "0x600077E")]
	public void set_selectAllOnFocus(bool value) { }

	[Address(RVA = "0x103C840", Offset = "0x103BC40", Length = "0x148")]
	[Token(Token = "0x6000780")]
	public void set_selectAllOnMouseUp(bool value) { }

	[Address(RVA = "0x103CAE0", Offset = "0x103BEE0", Length = "0x145")]
	[Token(Token = "0x600077C")]
	public void set_selectIndex(int value) { }

	[Address(RVA = "0x103CDC0", Offset = "0x103C1C0", Length = "0x30")]
	[Token(Token = "0x6000786")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	protected private void set_text(string value) { }

	[Address(RVA = "0x103CE00", Offset = "0x103C200", Length = "0x148")]
	[Token(Token = "0x6000784")]
	public void set_tripleClickSelectsLine(bool value) { }

	[Address(RVA = "0x103D1F0", Offset = "0x103C5F0", Length = "0xC4")]
	[Token(Token = "0x600078A")]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[Address(RVA = "0x102DBE0", Offset = "0x102CFE0", Length = "0x130")]
	[Token(Token = "0x600078C")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Token(Token = "0x600078E")]
	protected abstract TValueType StringToValue(string str) { }

	[Address(RVA = "0x102E470", Offset = "0x102D870", Length = "0x30B")]
	[Token(Token = "0x6000790")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0x102E780", Offset = "0x102DB80", Length = "0x15D")]
	[Token(Token = "0x6000792")]
	internal void UpdatePlaceholderClassList(ChangeEvent<TValueType> evt = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000794")]
	internal override void UpdateTextFromValue() { }

	[Address(RVA = "0x102EAC0", Offset = "0x102DEC0", Length = "0x7C")]
	[Token(Token = "0x6000793")]
	internal override void UpdateValueFromText() { }

	[Token(Token = "0x600078D")]
	protected abstract string ValueToString(TValueType value) { }

}

