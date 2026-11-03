namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Legacy/Input Field", 103)]
[Token(Token = "0x200002E")]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private sealed class <CaretBlink>d__170 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000121")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000122")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000123")]
		public InputField <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000095")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000241")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000096")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000243")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600023E")]
		public <CaretBlink>d__170(int <>1__state) { }

		[Address(RVA = "0x34498F0", Offset = "0x3448CF0", Length = "0x148")]
		[Token(Token = "0x6000240")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000241")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000243")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3449A40", Offset = "0x3448E40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000242")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600023F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000124")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000125")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000126")]
		public PointerEventData eventData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000127")]
		public InputField <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000097")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000247")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000098")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000249")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000244")]
		public <MouseDragOutsideRect>d__194(int <>1__state) { }

		[Address(RVA = "0x3449B50", Offset = "0x3448F50", Length = "0x46E")]
		[Token(Token = "0x6000246")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000247")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000249")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3449FC0", Offset = "0x34493C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000248")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000245")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000031")]
	internal enum CharacterValidation : int
	{
		None = 0,
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5,
	}

	[Token(Token = "0x200002F")]
	internal enum ContentType : int
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9,
	}

	[Token(Token = "0x2000037")]
	internal enum EditState : int
	{
		Continue = 0,
		Finish = 1,
	}

	[Token(Token = "0x2000035")]
	internal class EndEditEvent : UnityEvent<String>
	{

		[Address(RVA = "0x3435390", Offset = "0x3434790", Length = "0x39")]
		[Token(Token = "0x600023C")]
		public EndEditEvent() { }

	}

	[Token(Token = "0x2000030")]
	internal enum InputType : int
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	[Token(Token = "0x2000032")]
	internal enum LineType : int
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	[Token(Token = "0x2000036")]
	internal class OnChangeEvent : UnityEvent<String>
	{

		[Address(RVA = "0x3449870", Offset = "0x3448C70", Length = "0x39")]
		[Token(Token = "0x600023D")]
		public OnChangeEvent() { }

	}

	[Token(Token = "0x2000033")]
	internal sealed class OnValidateInput : MulticastDelegate
	{

		[Address(RVA = "0x2F040F0", Offset = "0x2F034F0", Length = "0xB5")]
		[Token(Token = "0x6000237")]
		public OnValidateInput(object object, IntPtr method) { }

		[Address(RVA = "0x2F04040", Offset = "0x2F03440", Length = "0x73")]
		[Token(Token = "0x6000239")]
		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2F040C0", Offset = "0x2F034C0", Length = "0x28")]
		[Token(Token = "0x600023A")]
		public override char EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000238")]
		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	[Token(Token = "0x2000034")]
	internal class SubmitEvent : UnityEvent<String>
	{

		[Address(RVA = "0x34498B0", Offset = "0x3448CB0", Length = "0x39")]
		[Token(Token = "0x600023B")]
		public SubmitEvent() { }

	}

	[Token(Token = "0x4000103")]
	private const int k_MaxTextLength = 16382; //Field offset: 0x0
	[Token(Token = "0x40000CE")]
	private static readonly Char[] kSeparators; //Field offset: 0x0
	[Token(Token = "0x4000101")]
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	[Token(Token = "0x4000100")]
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	[Token(Token = "0x40000F3")]
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	[Token(Token = "0x40000F2")]
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	[Token(Token = "0x40000CF")]
	private static bool s_IsQuestDevice; //Field offset: 0x8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000CD")]
	protected TouchScreenKeyboard m_Keyboard; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[FormerlySerializedAs("text")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	protected Text m_TextComponent; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	protected Graphic m_Placeholder; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	private ContentType m_ContentType; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	private InputType m_InputType; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	private char m_AsteriskChar; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	private LineType m_LineType; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	private bool m_HideMobileInput; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[FormerlySerializedAs("validation")]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	private int m_CharacterLimit; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	private SubmitEvent m_OnSubmit; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private EndEditEvent m_OnDidEndEdit; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	private Color m_CaretColor; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	private bool m_CustomCaretColor; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	private Color m_SelectionColor; //Field offset: 0x16C
	[FieldOffset(Offset = "0x180")]
	[FormerlySerializedAs("mValue")]
	[Multiline]
	[SerializeField]
	[Token(Token = "0x40000E1")]
	protected string m_Text; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Range(0, 4)]
	[SerializeField]
	[Token(Token = "0x40000E2")]
	private float m_CaretBlinkRate; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x40000E3")]
	private int m_CaretWidth; //Field offset: 0x18C
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	private bool m_ReadOnly; //Field offset: 0x190
	[FieldOffset(Offset = "0x191")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x191
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x40000E6")]
	protected int m_CaretPosition; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40000E7")]
	protected int m_CaretSelectPosition; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40000E8")]
	private RectTransform caretRectTrans; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40000E9")]
	protected UIVertex[] m_CursorVerts; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40000EA")]
	private TextGenerator m_InputTextCache; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40000EB")]
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40000EC")]
	private bool m_PreventFontCallback; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40000ED")]
	protected Mesh m_Mesh; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40000EE")]
	private bool m_AllowInput; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D1")]
	[Token(Token = "0x40000EF")]
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x1D1
	[FieldOffset(Offset = "0x1D2")]
	[Token(Token = "0x40000F0")]
	private bool m_UpdateDrag; //Field offset: 0x1D2
	[FieldOffset(Offset = "0x1D3")]
	[Token(Token = "0x40000F1")]
	private bool m_DragPositionOutOfBounds; //Field offset: 0x1D3
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x40000F4")]
	protected bool m_CaretVisible; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40000F5")]
	private Coroutine m_BlinkCoroutine; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40000F6")]
	private float m_BlinkStartTime; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x40000F7")]
	protected int m_DrawStart; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40000F8")]
	protected int m_DrawEnd; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40000F9")]
	private Coroutine m_DragCoroutine; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40000FA")]
	private string m_OriginalText; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40000FB")]
	private bool m_WasCanceled; //Field offset: 0x200
	[FieldOffset(Offset = "0x201")]
	[Token(Token = "0x40000FC")]
	private bool m_HasDoneFocusTransition; //Field offset: 0x201
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x40000FD")]
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40000FE")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x210
	[FieldOffset(Offset = "0x211")]
	[Token(Token = "0x40000FF")]
	private bool m_IsCompositionActive; //Field offset: 0x211
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000102")]
	private Event m_ProcessingEvent; //Field offset: 0x218

	[Token(Token = "0x17000085")]
	public char asteriskChar
	{
		[Address(RVA = "0x3441170", Offset = "0x3440570", Length = "0x8")]
		[Token(Token = "0x60001C8")]
		 get { } //Length: 8
		[Address(RVA = "0x3441B10", Offset = "0x3440F10", Length = "0x5B")]
		[Token(Token = "0x60001C9")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700006B")]
	protected TextGenerator cachedInputTextGenerator
	{
		[Address(RVA = "0x3441180", Offset = "0x3440580", Length = "0x75")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000070")]
	public float caretBlinkRate
	{
		[Address(RVA = "0x3441200", Offset = "0x3440600", Length = "0x9")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 9
		[Address(RVA = "0x3441B70", Offset = "0x3440F70", Length = "0x65")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000074")]
	public Color caretColor
	{
		[Address(RVA = "0x3441210", Offset = "0x3440610", Length = "0x5D")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 93
		[Address(RVA = "0x3441BE0", Offset = "0x3440FE0", Length = "0x6F")]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 111
	}

	[Token(Token = "0x1700008A")]
	public int caretPosition
	{
		[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 40
		[Address(RVA = "0x3441CA0", Offset = "0x34410A0", Length = "0xB5")]
		[Token(Token = "0x60001D2")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000087")]
	protected int caretPositionInternal
	{
		[Address(RVA = "0x3441270", Offset = "0x3440670", Length = "0x28")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 40
		[Address(RVA = "0x3441C50", Offset = "0x3441050", Length = "0x46")]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000088")]
	protected int caretSelectPositionInternal
	{
		[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 40
		[Address(RVA = "0x3441D60", Offset = "0x3441160", Length = "0x46")]
		[Token(Token = "0x60001CF")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000071")]
	public int caretWidth
	{
		[Address(RVA = "0x34412D0", Offset = "0x34406D0", Length = "0x7")]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 7
		[Address(RVA = "0x3441DB0", Offset = "0x34411B0", Length = "0x8A")]
		[Token(Token = "0x60001A3")]
		 set { } //Length: 138
	}

	[Token(Token = "0x1700007C")]
	public int characterLimit
	{
		[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 7
		[Address(RVA = "0x3441E40", Offset = "0x3441240", Length = "0xA1")]
		[Token(Token = "0x60001B9")]
		 set { } //Length: 161
	}

	[Token(Token = "0x17000082")]
	public CharacterValidation characterValidation
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 7
		[Address(RVA = "0x3441EF0", Offset = "0x34412F0", Length = "0x68")]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700008D")]
	private static string clipboard
	{
		[Address(RVA = "0x34412E0", Offset = "0x34406E0", Length = "0x40")]
		[Token(Token = "0x60001E2")]
		private get { } //Length: 64
		[Address(RVA = "0x3441F60", Offset = "0x3441360", Length = "0x49")]
		[Token(Token = "0x60001E3")]
		private set { } //Length: 73
	}

	[Token(Token = "0x17000069")]
	private string compositionString
	{
		[Address(RVA = "0x3441320", Offset = "0x3440720", Length = "0xA2")]
		[Token(Token = "0x6000193")]
		private get { } //Length: 162
	}

	[Token(Token = "0x1700007D")]
	public ContentType contentType
	{
		[Address(RVA = "0x1E2A1C0", Offset = "0x1E295C0", Length = "0x7")]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 7
		[Address(RVA = "0x3441FB0", Offset = "0x34413B0", Length = "0x210")]
		[Token(Token = "0x60001BB")]
		 set { } //Length: 528
	}

	[Token(Token = "0x17000075")]
	public bool customCaretColor
	{
		[Address(RVA = "0x34413D0", Offset = "0x34407D0", Length = "0x8")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 8
		[Address(RVA = "0x34421F0", Offset = "0x34415F0", Length = "0x5D")]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 93
	}

	[Token(Token = "0x17000093")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000233")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000090")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x6000230")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000089")]
	private bool hasSelection
	{
		[Address(RVA = "0x34413E0", Offset = "0x34407E0", Length = "0x5B")]
		[Token(Token = "0x60001D0")]
		private get { } //Length: 91
	}

	[Token(Token = "0x17000068")]
	private BaseInput input
	{
		[Address(RVA = "0x3441440", Offset = "0x3440840", Length = "0xFB")]
		[Token(Token = "0x6000192")]
		private get { } //Length: 251
	}

	[Token(Token = "0x1700007F")]
	public InputType inputType
	{
		[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
		[Token(Token = "0x60001BE")]
		 get { } //Length: 7
		[Address(RVA = "0x3442250", Offset = "0x3441650", Length = "0x68")]
		[Token(Token = "0x60001BF")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700006F")]
	public bool isFocused
	{
		[Address(RVA = "0x3441540", Offset = "0x3440940", Length = "0x8")]
		[Token(Token = "0x600019F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000081")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x3441550", Offset = "0x3440950", Length = "0x7")]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 7
		[Address(RVA = "0x34422C0", Offset = "0x34416C0", Length = "0x68")]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000094")]
	public override int layoutPriority
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000234")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700007E")]
	public LineType lineType
	{
		[Address(RVA = "0x31DCD20", Offset = "0x31DC120", Length = "0x7")]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 7
		[Address(RVA = "0x3442330", Offset = "0x3441730", Length = "0xD7")]
		[Token(Token = "0x60001BD")]
		 set { } //Length: 215
	}

	[Token(Token = "0x1700006A")]
	protected Mesh mesh
	{
		[Address(RVA = "0x3441560", Offset = "0x3440960", Length = "0xA3")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 163
	}

	[Token(Token = "0x17000091")]
	public override float minHeight
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x6000231")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008E")]
	public override float minWidth
	{
		[Address(RVA = "0x3441610", Offset = "0x3440A10", Length = "0x9")]
		[Token(Token = "0x600022E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000084")]
	public bool multiLine
	{
		[Address(RVA = "0x3441620", Offset = "0x3440A20", Length = "0x17")]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000077")]
	public EndEditEvent onEndEdit
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 8
		[Address(RVA = "0x3442410", Offset = "0x3441810", Length = "0x4C")]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000078")]
	public SubmitEvent onSubmit
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 8
		[Address(RVA = "0x3442460", Offset = "0x3441860", Length = "0x4C")]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700007B")]
	public OnValidateInput onValidateInput
	{
		[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 8
		[Address(RVA = "0x34424B0", Offset = "0x34418B0", Length = "0x4C")]
		[Token(Token = "0x60001B7")]
		 set { } //Length: 76
	}

	[Obsolete("onValueChange has been renamed to onValueChanged")]
	[Token(Token = "0x17000079")]
	public OnChangeEvent onValueChange
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 8
		[Address(RVA = "0x3442500", Offset = "0x3441900", Length = "0x4C")]
		[Token(Token = "0x60001B3")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700007A")]
	public OnChangeEvent onValueChanged
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 8
		[Address(RVA = "0x3442500", Offset = "0x3441900", Length = "0x4C")]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000073")]
	public Graphic placeholder
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 8
		[Address(RVA = "0x3442550", Offset = "0x3441950", Length = "0x4C")]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000092")]
	public override float preferredHeight
	{
		[Address(RVA = "0x3441640", Offset = "0x3440A40", Length = "0x1F9")]
		[Token(Token = "0x6000232")]
		 get { } //Length: 505
	}

	[Token(Token = "0x1700008F")]
	public override float preferredWidth
	{
		[Address(RVA = "0x3441840", Offset = "0x3440C40", Length = "0x1DA")]
		[Token(Token = "0x600022F")]
		 get { } //Length: 474
	}

	[Token(Token = "0x17000083")]
	public bool readOnly
	{
		[Address(RVA = "0x3441A20", Offset = "0x3440E20", Length = "0x8")]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDB5A0", Offset = "0x1CDA9A0", Length = "0x7")]
		[Token(Token = "0x60001C6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700008B")]
	public int selectionAnchorPosition
	{
		[Address(RVA = "0x3441270", Offset = "0x3440670", Length = "0x28")]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 40
		[Address(RVA = "0x34425A0", Offset = "0x34419A0", Length = "0x6B")]
		[Token(Token = "0x60001D4")]
		 set { } //Length: 107
	}

	[Token(Token = "0x17000076")]
	public Color selectionColor
	{
		[Address(RVA = "0x3441A30", Offset = "0x3440E30", Length = "0xE")]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 14
		[Address(RVA = "0x3442610", Offset = "0x3441A10", Length = "0x6F")]
		[Token(Token = "0x60001AD")]
		 set { } //Length: 111
	}

	[Token(Token = "0x1700008C")]
	public int selectionFocusPosition
	{
		[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
		[Token(Token = "0x60001D5")]
		 get { } //Length: 40
		[Address(RVA = "0x3442680", Offset = "0x3441A80", Length = "0x6B")]
		[Token(Token = "0x60001D6")]
		 set { } //Length: 107
	}

	[Token(Token = "0x1700006D")]
	public override bool shouldActivateOnSelect
	{
		[Address(RVA = "0x3441A40", Offset = "0x3440E40", Length = "0x5E")]
		[Token(Token = "0x600019A")]
		 get { } //Length: 94
		[Address(RVA = "0x1CDAEA0", Offset = "0x1CDA2A0", Length = "0x7")]
		[Token(Token = "0x6000199")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700006C")]
	public bool shouldHideMobileInput
	{
		[Address(RVA = "0x3441AA0", Offset = "0x3440EA0", Length = "0x5F")]
		[Token(Token = "0x6000198")]
		 get { } //Length: 95
		[Address(RVA = "0x34426F0", Offset = "0x3441AF0", Length = "0x4C")]
		[Token(Token = "0x6000197")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700006E")]
	public string text
	{
		[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
		[Token(Token = "0x600019B")]
		 get { } //Length: 8
		[Address(RVA = "0x34429E0", Offset = "0x3441DE0", Length = "0xB")]
		[Token(Token = "0x600019C")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000072")]
	public Text textComponent
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 8
		[Address(RVA = "0x3442740", Offset = "0x3441B40", Length = "0x29A")]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 666
	}

	[Token(Token = "0x17000080")]
	public TouchScreenKeyboard touchScreenKeyboard
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000086")]
	public bool wasCanceled
	{
		[Address(RVA = "0x3441B00", Offset = "0x3440F00", Length = "0x8")]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3440E90", Offset = "0x3440290", Length = "0x9F")]
	[Token(Token = "0x6000235")]
	private static InputField() { }

	[Address(RVA = "0x3440F30", Offset = "0x3440330", Length = "0x23E")]
	[Token(Token = "0x6000194")]
	protected InputField() { }

	[Address(RVA = "0x34377D0", Offset = "0x3436BD0", Length = "0x13F")]
	[Token(Token = "0x6000220")]
	public void ActivateInputField() { }

	[Address(RVA = "0x3437370", Offset = "0x3436770", Length = "0x450")]
	[Token(Token = "0x6000221")]
	private void ActivateInputFieldInternal() { }

	[Address(RVA = "0x3437C90", Offset = "0x3437090", Length = "0xA8")]
	[Token(Token = "0x600020D")]
	protected override void Append(string input) { }

	[Address(RVA = "0x3437910", Offset = "0x3436D10", Length = "0x373")]
	[Token(Token = "0x600020E")]
	protected override void Append(char input) { }

	[Address(RVA = "0x3437D40", Offset = "0x3437140", Length = "0x772")]
	[Token(Token = "0x600021A")]
	private void AssignPositioningIfNeeded() { }

	[Address(RVA = "0x34384C0", Offset = "0x34378C0", Length = "0x1B3")]
	[Token(Token = "0x6000206")]
	private void Backspace() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600022C")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600022D")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x3438680", Offset = "0x3437A80", Length = "0x67")]
	[IteratorStateMachine(typeof(<CaretBlink>d__170))]
	[Token(Token = "0x60001DA")]
	private IEnumerator CaretBlink() { }

	[Address(RVA = "0x34386F0", Offset = "0x3437AF0", Length = "0x3D")]
	[Token(Token = "0x60001CB")]
	protected void ClampPos(ref int pos) { }

	[Address(RVA = "0x3438730", Offset = "0x3437B30", Length = "0x1B6")]
	[Token(Token = "0x600021D")]
	private void CreateCursorVerts() { }

	[Address(RVA = "0x34388F0", Offset = "0x3437CF0", Length = "0x247")]
	[Token(Token = "0x6000224")]
	public void DeactivateInputField() { }

	[Address(RVA = "0x3438B40", Offset = "0x3437F40", Length = "0x320")]
	[Token(Token = "0x6000204")]
	private void Delete() { }

	[Address(RVA = "0x3438E70", Offset = "0x3438270", Length = "0x114")]
	[Token(Token = "0x60001FD")]
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	[Address(RVA = "0x3438F90", Offset = "0x3438390", Length = "0x2A")]
	[Token(Token = "0x600022B")]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x3438FC0", Offset = "0x34383C0", Length = "0x1D8")]
	[Token(Token = "0x6000227")]
	private void EnforceContentType() { }

	[Address(RVA = "0x34391C0", Offset = "0x34385C0", Length = "0xAA")]
	[Token(Token = "0x6000228")]
	private void EnforceTextHOverflow() { }

	[Address(RVA = "0x3439270", Offset = "0x3438670", Length = "0xFC")]
	[Token(Token = "0x60001F9")]
	private int FindtNextWordBegin() { }

	[Address(RVA = "0x3439370", Offset = "0x3438770", Length = "0xE7")]
	[Token(Token = "0x60001FB")]
	private int FindtPrevWordBegin() { }

	[Address(RVA = "0x3439460", Offset = "0x3438860", Length = "0x7")]
	[Token(Token = "0x6000214")]
	public void ForceLabelUpdate() { }

	[Address(RVA = "0x3439470", Offset = "0x3438870", Length = "0x151")]
	[Token(Token = "0x6000205")]
	private void ForwardSpace() { }

	[Address(RVA = "0x34395D0", Offset = "0x34389D0", Length = "0xAB0")]
	[Token(Token = "0x600021C")]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x343A090", Offset = "0x3439490", Length = "0x79B")]
	[Token(Token = "0x600021E")]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x3441170", Offset = "0x3440570", Length = "0x8")]
	[Token(Token = "0x60001C8")]
	public char get_asteriskChar() { }

	[Address(RVA = "0x3441180", Offset = "0x3440580", Length = "0x75")]
	[Token(Token = "0x6000196")]
	protected TextGenerator get_cachedInputTextGenerator() { }

	[Address(RVA = "0x3441200", Offset = "0x3440600", Length = "0x9")]
	[Token(Token = "0x60001A0")]
	public float get_caretBlinkRate() { }

	[Address(RVA = "0x3441210", Offset = "0x3440610", Length = "0x5D")]
	[Token(Token = "0x60001A8")]
	public Color get_caretColor() { }

	[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
	[Token(Token = "0x60001D1")]
	public int get_caretPosition() { }

	[Address(RVA = "0x3441270", Offset = "0x3440670", Length = "0x28")]
	[Token(Token = "0x60001CC")]
	protected int get_caretPositionInternal() { }

	[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
	[Token(Token = "0x60001CE")]
	protected int get_caretSelectPositionInternal() { }

	[Address(RVA = "0x34412D0", Offset = "0x34406D0", Length = "0x7")]
	[Token(Token = "0x60001A2")]
	public int get_caretWidth() { }

	[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
	[Token(Token = "0x60001B8")]
	public int get_characterLimit() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x60001C3")]
	public CharacterValidation get_characterValidation() { }

	[Address(RVA = "0x34412E0", Offset = "0x34406E0", Length = "0x40")]
	[Token(Token = "0x60001E2")]
	private static string get_clipboard() { }

	[Address(RVA = "0x3441320", Offset = "0x3440720", Length = "0xA2")]
	[Token(Token = "0x6000193")]
	private string get_compositionString() { }

	[Address(RVA = "0x1E2A1C0", Offset = "0x1E295C0", Length = "0x7")]
	[Token(Token = "0x60001BA")]
	public ContentType get_contentType() { }

	[Address(RVA = "0x34413D0", Offset = "0x34407D0", Length = "0x8")]
	[Token(Token = "0x60001AA")]
	public bool get_customCaretColor() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000233")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000230")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x34413E0", Offset = "0x34407E0", Length = "0x5B")]
	[Token(Token = "0x60001D0")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x3441440", Offset = "0x3440840", Length = "0xFB")]
	[Token(Token = "0x6000192")]
	private BaseInput get_input() { }

	[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
	[Token(Token = "0x60001BE")]
	public InputType get_inputType() { }

	[Address(RVA = "0x3441540", Offset = "0x3440940", Length = "0x8")]
	[Token(Token = "0x600019F")]
	public bool get_isFocused() { }

	[Address(RVA = "0x3441550", Offset = "0x3440950", Length = "0x7")]
	[Token(Token = "0x60001C1")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000234")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x31DCD20", Offset = "0x31DC120", Length = "0x7")]
	[Token(Token = "0x60001BC")]
	public LineType get_lineType() { }

	[Address(RVA = "0x3441560", Offset = "0x3440960", Length = "0xA3")]
	[Token(Token = "0x6000195")]
	protected Mesh get_mesh() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000231")]
	public override float get_minHeight() { }

	[Address(RVA = "0x3441610", Offset = "0x3440A10", Length = "0x9")]
	[Token(Token = "0x600022E")]
	public override float get_minWidth() { }

	[Address(RVA = "0x3441620", Offset = "0x3440A20", Length = "0x17")]
	[Token(Token = "0x60001C7")]
	public bool get_multiLine() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x60001AE")]
	public EndEditEvent get_onEndEdit() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x60001B0")]
	public SubmitEvent get_onSubmit() { }

	[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
	[Token(Token = "0x60001B6")]
	public OnValidateInput get_onValidateInput() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[Token(Token = "0x60001B2")]
	public OnChangeEvent get_onValueChange() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[Token(Token = "0x60001B4")]
	public OnChangeEvent get_onValueChanged() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x60001A6")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x3441640", Offset = "0x3440A40", Length = "0x1F9")]
	[Token(Token = "0x6000232")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x3441840", Offset = "0x3440C40", Length = "0x1DA")]
	[Token(Token = "0x600022F")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x3441A20", Offset = "0x3440E20", Length = "0x8")]
	[Token(Token = "0x60001C5")]
	public bool get_readOnly() { }

	[Address(RVA = "0x3441270", Offset = "0x3440670", Length = "0x28")]
	[Token(Token = "0x60001D3")]
	public int get_selectionAnchorPosition() { }

	[Address(RVA = "0x3441A30", Offset = "0x3440E30", Length = "0xE")]
	[Token(Token = "0x60001AC")]
	public Color get_selectionColor() { }

	[Address(RVA = "0x34412A0", Offset = "0x34406A0", Length = "0x28")]
	[Token(Token = "0x60001D5")]
	public int get_selectionFocusPosition() { }

	[Address(RVA = "0x3441A40", Offset = "0x3440E40", Length = "0x5E")]
	[Token(Token = "0x600019A")]
	public override bool get_shouldActivateOnSelect() { }

	[Address(RVA = "0x3441AA0", Offset = "0x3440EA0", Length = "0x5F")]
	[Token(Token = "0x6000198")]
	public bool get_shouldHideMobileInput() { }

	[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
	[Token(Token = "0x600019B")]
	public string get_text() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x60001A4")]
	public Text get_textComponent() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x60001C0")]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[Address(RVA = "0x3441B00", Offset = "0x3440F00", Length = "0x8")]
	[Token(Token = "0x60001CA")]
	public bool get_wasCanceled() { }

	[Address(RVA = "0x343A830", Offset = "0x3439C30", Length = "0x244")]
	[Token(Token = "0x60001ED")]
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	[Address(RVA = "0x343AA80", Offset = "0x3439E80", Length = "0xFD")]
	[Token(Token = "0x60001E7")]
	private RangeInt GetInternalSelection() { }

	[Address(RVA = "0x343AB80", Offset = "0x3439F80", Length = "0xB9")]
	[Token(Token = "0x6000212")]
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	[Address(RVA = "0x343AC40", Offset = "0x343A040", Length = "0x115")]
	[Token(Token = "0x6000211")]
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	[Address(RVA = "0x343AD60", Offset = "0x343A160", Length = "0xF4")]
	[Token(Token = "0x60001F8")]
	private string GetSelectedString() { }

	[Address(RVA = "0x343AE60", Offset = "0x343A260", Length = "0x27C")]
	[Token(Token = "0x60001EC")]
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000218")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x343B160", Offset = "0x343A560", Length = "0x23")]
	[Token(Token = "0x60001E5")]
	private bool InPlaceEditing() { }

	[Address(RVA = "0x343B0E0", Offset = "0x343A4E0", Length = "0x72")]
	[Token(Token = "0x60001E6")]
	private bool InPlaceEditingChanged() { }

	[Address(RVA = "0x343B190", Offset = "0x343A590", Length = "0x195")]
	[Token(Token = "0x6000207")]
	private void Insert(char c) { }

	[Address(RVA = "0x343B330", Offset = "0x343A730", Length = "0xCC")]
	[Token(Token = "0x6000210")]
	private bool IsSelectionVisible() { }

	[Address(RVA = "0x343B400", Offset = "0x343A800", Length = "0x5D")]
	[Token(Token = "0x60001F5")]
	private bool IsValidChar(char c) { }

	[Address(RVA = "0x343B460", Offset = "0x343A860", Length = "0x4F4")]
	[Token(Token = "0x60001F4")]
	protected EditState KeyPressed(Event evt) { }

	[Address(RVA = "0x343B980", Offset = "0x343AD80", Length = "0x732")]
	[Token(Token = "0x60001EA")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000217")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x343C0C0", Offset = "0x343B4C0", Length = "0x2A5")]
	[Token(Token = "0x60001FF")]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x343C370", Offset = "0x343B770", Length = "0x211")]
	[Token(Token = "0x60001FE")]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x343C590", Offset = "0x343B990", Length = "0x49")]
	[Token(Token = "0x6000215")]
	private void MarkGeometryAsDirty() { }

	[Address(RVA = "0x343C5E0", Offset = "0x343B9E0", Length = "0xE4")]
	[Token(Token = "0x60001EE")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x343C6D0", Offset = "0x343BAD0", Length = "0x84")]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__194))]
	[Token(Token = "0x60001F1")]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[Address(RVA = "0x343C760", Offset = "0x343BB60", Length = "0x211")]
	[Token(Token = "0x6000201")]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x343C980", Offset = "0x343BD80", Length = "0xB")]
	[Token(Token = "0x6000200")]
	private void MoveDown(bool shift) { }

	[Address(RVA = "0x343C990", Offset = "0x343BD90", Length = "0x279")]
	[Token(Token = "0x60001FC")]
	private void MoveLeft(bool shift, bool ctrl) { }

	[Address(RVA = "0x343CC10", Offset = "0x343C010", Length = "0x2AD")]
	[Token(Token = "0x60001FA")]
	private void MoveRight(bool shift, bool ctrl) { }

	[Address(RVA = "0x343CEC0", Offset = "0x343C2C0", Length = "0x112")]
	[Token(Token = "0x60001E0")]
	public void MoveTextEnd(bool shift) { }

	[Address(RVA = "0x343CFE0", Offset = "0x343C3E0", Length = "0xEA")]
	[Token(Token = "0x60001E1")]
	public void MoveTextStart(bool shift) { }

	[Address(RVA = "0x343D0D0", Offset = "0x343C4D0", Length = "0xB")]
	[Token(Token = "0x6000202")]
	private void MoveUp(bool shift) { }

	[Address(RVA = "0x343D0E0", Offset = "0x343C4E0", Length = "0x1D7")]
	[Token(Token = "0x6000203")]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x343D2C0", Offset = "0x343C6C0", Length = "0x22")]
	[Token(Token = "0x60001EF")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x343D2F0", Offset = "0x343C6F0", Length = "0x2F")]
	[Token(Token = "0x6000225")]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x343D320", Offset = "0x343C720", Length = "0x53")]
	[Token(Token = "0x60001D9")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x343D380", Offset = "0x343C780", Length = "0x271")]
	[Token(Token = "0x60001D8")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x343D600", Offset = "0x343CA00", Length = "0x2D6")]
	[Token(Token = "0x60001F0")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x343D8E0", Offset = "0x343CCE0", Length = "0x272")]
	[Token(Token = "0x60001D7")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x343DB60", Offset = "0x343CF60", Length = "0x22")]
	[Token(Token = "0x60001F2")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x343DB90", Offset = "0x343CF90", Length = "0x202")]
	[Token(Token = "0x600021B")]
	private void OnFillVBO(Mesh vbo) { }

	[Address(RVA = "0x343DDA0", Offset = "0x343D1A0", Length = "0x7")]
	[Token(Token = "0x60001DE")]
	protected void OnFocus() { }

	[Address(RVA = "0x343DDB0", Offset = "0x343D1B0", Length = "0x27")]
	[Token(Token = "0x6000223")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x343DDE0", Offset = "0x343D1E0", Length = "0x2A0")]
	[Token(Token = "0x60001F3")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x343E090", Offset = "0x343D490", Length = "0x40")]
	[Token(Token = "0x6000222")]
	public virtual void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x343E0D0", Offset = "0x343D4D0", Length = "0x50")]
	[Token(Token = "0x6000226")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x343E120", Offset = "0x343D520", Length = "0x1CE")]
	[Token(Token = "0x60001F7")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x343E2F0", Offset = "0x343D6F0", Length = "0x8")]
	[Token(Token = "0x60001F6")]
	public void ProcessEvent(Event e) { }

	[Address(RVA = "0x343E300", Offset = "0x343D700", Length = "0xD")]
	[Token(Token = "0x6000216")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x343E310", Offset = "0x343D710", Length = "0x565")]
	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	[Token(Token = "0x60001EB")]
	public Vector2 ScreenToLocal(Vector2 screen) { }

	[Address(RVA = "0x343E880", Offset = "0x343DC80", Length = "0x80")]
	[Token(Token = "0x60001DF")]
	protected void SelectAll() { }

	[Address(RVA = "0x343E910", Offset = "0x343DD10", Length = "0x72")]
	[Token(Token = "0x600020B")]
	protected void SendOnEndEdit() { }

	[Address(RVA = "0x343E990", Offset = "0x343DD90", Length = "0x72")]
	[Token(Token = "0x600020C")]
	protected void SendOnSubmit() { }

	[Address(RVA = "0x343EA30", Offset = "0x343DE30", Length = "0x72")]
	[Token(Token = "0x600020A")]
	private void SendOnValueChanged() { }

	[Address(RVA = "0x343EA10", Offset = "0x343DE10", Length = "0x1F")]
	[Token(Token = "0x6000209")]
	private void SendOnValueChangedAndUpdateLabel() { }

	[Address(RVA = "0x3441B10", Offset = "0x3440F10", Length = "0x5B")]
	[Token(Token = "0x60001C9")]
	public void set_asteriskChar(char value) { }

	[Address(RVA = "0x3441B70", Offset = "0x3440F70", Length = "0x65")]
	[Token(Token = "0x60001A1")]
	public void set_caretBlinkRate(float value) { }

	[Address(RVA = "0x3441BE0", Offset = "0x3440FE0", Length = "0x6F")]
	[Token(Token = "0x60001A9")]
	public void set_caretColor(Color value) { }

	[Address(RVA = "0x3441CA0", Offset = "0x34410A0", Length = "0xB5")]
	[Token(Token = "0x60001D2")]
	public void set_caretPosition(int value) { }

	[Address(RVA = "0x3441C50", Offset = "0x3441050", Length = "0x46")]
	[Token(Token = "0x60001CD")]
	protected void set_caretPositionInternal(int value) { }

	[Address(RVA = "0x3441D60", Offset = "0x3441160", Length = "0x46")]
	[Token(Token = "0x60001CF")]
	protected void set_caretSelectPositionInternal(int value) { }

	[Address(RVA = "0x3441DB0", Offset = "0x34411B0", Length = "0x8A")]
	[Token(Token = "0x60001A3")]
	public void set_caretWidth(int value) { }

	[Address(RVA = "0x3441E40", Offset = "0x3441240", Length = "0xA1")]
	[Token(Token = "0x60001B9")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x3441EF0", Offset = "0x34412F0", Length = "0x68")]
	[Token(Token = "0x60001C4")]
	public void set_characterValidation(CharacterValidation value) { }

	[Address(RVA = "0x3441F60", Offset = "0x3441360", Length = "0x49")]
	[Token(Token = "0x60001E3")]
	private static void set_clipboard(string value) { }

	[Address(RVA = "0x3441FB0", Offset = "0x34413B0", Length = "0x210")]
	[Token(Token = "0x60001BB")]
	public void set_contentType(ContentType value) { }

	[Address(RVA = "0x34421F0", Offset = "0x34415F0", Length = "0x5D")]
	[Token(Token = "0x60001AB")]
	public void set_customCaretColor(bool value) { }

	[Address(RVA = "0x3442250", Offset = "0x3441650", Length = "0x68")]
	[Token(Token = "0x60001BF")]
	public void set_inputType(InputType value) { }

	[Address(RVA = "0x34422C0", Offset = "0x34416C0", Length = "0x68")]
	[Token(Token = "0x60001C2")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x3442330", Offset = "0x3441730", Length = "0xD7")]
	[Token(Token = "0x60001BD")]
	public void set_lineType(LineType value) { }

	[Address(RVA = "0x3442410", Offset = "0x3441810", Length = "0x4C")]
	[Token(Token = "0x60001AF")]
	public void set_onEndEdit(EndEditEvent value) { }

	[Address(RVA = "0x3442460", Offset = "0x3441860", Length = "0x4C")]
	[Token(Token = "0x60001B1")]
	public void set_onSubmit(SubmitEvent value) { }

	[Address(RVA = "0x34424B0", Offset = "0x34418B0", Length = "0x4C")]
	[Token(Token = "0x60001B7")]
	public void set_onValidateInput(OnValidateInput value) { }

	[Address(RVA = "0x3442500", Offset = "0x3441900", Length = "0x4C")]
	[Token(Token = "0x60001B3")]
	public void set_onValueChange(OnChangeEvent value) { }

	[Address(RVA = "0x3442500", Offset = "0x3441900", Length = "0x4C")]
	[Token(Token = "0x60001B5")]
	public void set_onValueChanged(OnChangeEvent value) { }

	[Address(RVA = "0x3442550", Offset = "0x3441950", Length = "0x4C")]
	[Token(Token = "0x60001A7")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x1CDB5A0", Offset = "0x1CDA9A0", Length = "0x7")]
	[Token(Token = "0x60001C6")]
	public void set_readOnly(bool value) { }

	[Address(RVA = "0x34425A0", Offset = "0x34419A0", Length = "0x6B")]
	[Token(Token = "0x60001D4")]
	public void set_selectionAnchorPosition(int value) { }

	[Address(RVA = "0x3442610", Offset = "0x3441A10", Length = "0x6F")]
	[Token(Token = "0x60001AD")]
	public void set_selectionColor(Color value) { }

	[Address(RVA = "0x3442680", Offset = "0x3441A80", Length = "0x6B")]
	[Token(Token = "0x60001D6")]
	public void set_selectionFocusPosition(int value) { }

	[Address(RVA = "0x1CDAEA0", Offset = "0x1CDA2A0", Length = "0x7")]
	[Token(Token = "0x6000199")]
	public override void set_shouldActivateOnSelect(bool value) { }

	[Address(RVA = "0x34426F0", Offset = "0x3441AF0", Length = "0x4C")]
	[Token(Token = "0x6000197")]
	public void set_shouldHideMobileInput(bool value) { }

	[Address(RVA = "0x34429E0", Offset = "0x3441DE0", Length = "0xB")]
	[Token(Token = "0x600019C")]
	public void set_text(string value) { }

	[Address(RVA = "0x3442740", Offset = "0x3441B40", Length = "0x29A")]
	[Token(Token = "0x60001A5")]
	public void set_textComponent(Text value) { }

	[Address(RVA = "0x343EAB0", Offset = "0x343DEB0", Length = "0xBD")]
	[Token(Token = "0x60001DC")]
	private void SetCaretActive() { }

	[Address(RVA = "0x343EB70", Offset = "0x343DF70", Length = "0x3D")]
	[Token(Token = "0x60001DB")]
	private void SetCaretVisible() { }

	[Address(RVA = "0x343EBB0", Offset = "0x343DFB0", Length = "0x876")]
	[Token(Token = "0x6000213")]
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	[Address(RVA = "0x343F440", Offset = "0x343E840", Length = "0x444")]
	[Token(Token = "0x600019E")]
	private void SetText(string value, bool sendCallback = true) { }

	[Address(RVA = "0x343F430", Offset = "0x343E830", Length = "0xB")]
	[Token(Token = "0x600019D")]
	public void SetTextWithoutNotify(string input) { }

	[Address(RVA = "0x343F900", Offset = "0x343ED00", Length = "0x17")]
	[Token(Token = "0x600022A")]
	private void SetToCustom() { }

	[Address(RVA = "0x343F890", Offset = "0x343EC90", Length = "0x6E")]
	[Token(Token = "0x6000229")]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[Address(RVA = "0x343F920", Offset = "0x343ED20", Length = "0xA2")]
	[Token(Token = "0x60001E4")]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x6000236")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x343F9D0", Offset = "0x343EDD0", Length = "0x131")]
	[Token(Token = "0x60001E9")]
	private void UpdateCaretFromKeyboard() { }

	[Address(RVA = "0x343FB10", Offset = "0x343EF10", Length = "0x10C")]
	[Token(Token = "0x60001DD")]
	private void UpdateCaretMaterial() { }

	[Address(RVA = "0x343FC20", Offset = "0x343F020", Length = "0x4CE")]
	[Token(Token = "0x6000219")]
	private void UpdateGeometry() { }

	[Address(RVA = "0x34400F0", Offset = "0x343F4F0", Length = "0xCD")]
	[Token(Token = "0x60001E8")]
	private void UpdateKeyboardCaret() { }

	[Address(RVA = "0x34401C0", Offset = "0x343F5C0", Length = "0x516")]
	[Token(Token = "0x600020F")]
	protected void UpdateLabel() { }

	[Address(RVA = "0x34406E0", Offset = "0x343FAE0", Length = "0x52")]
	[Token(Token = "0x6000208")]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[Address(RVA = "0x3440740", Offset = "0x343FB40", Length = "0x74F")]
	[Token(Token = "0x600021F")]
	protected char Validate(string text, int pos, char ch) { }

}

