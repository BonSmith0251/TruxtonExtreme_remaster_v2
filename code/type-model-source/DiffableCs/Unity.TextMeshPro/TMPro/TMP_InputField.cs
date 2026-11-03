namespace TMPro;

[AddComponentMenu("UI (Canvas)/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[Token(Token = "0x2000061")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler
{
	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private sealed class <CaretBlink>d__293 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400030D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400030E")]
		public TMP_InputField <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000D5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003F6")]
		public <CaretBlink>d__293(int <>1__state) { }

		[Address(RVA = "0x2F17E00", Offset = "0x2F17200", Length = "0x151")]
		[Token(Token = "0x60003F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F17F60", Offset = "0x2F17360", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private sealed class <MouseDragOutsideRect>d__314 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000310")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000311")]
		public TMP_InputField <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000312")]
		public PointerEventData eventData; //Field offset: 0x28

		[Token(Token = "0x170000D7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003FF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000401")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003FC")]
		public <MouseDragOutsideRect>d__314(int <>1__state) { }

		[Address(RVA = "0x2F18D00", Offset = "0x2F18100", Length = "0x344")]
		[Token(Token = "0x60003FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003FF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000401")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F19050", Offset = "0x2F18450", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000400")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000064")]
	internal enum CharacterValidation : int
	{
		None = 0,
		Digit = 1,
		Integer = 2,
		Decimal = 3,
		Alphanumeric = 4,
		Name = 5,
		Regex = 6,
		EmailAddress = 7,
		CustomValidator = 8,
	}

	[Token(Token = "0x2000062")]
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

	[Token(Token = "0x200006C")]
	internal enum EditState : int
	{
		Continue = 0,
		Finish = 1,
	}

	[Token(Token = "0x2000063")]
	internal enum InputType : int
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	[Token(Token = "0x2000065")]
	internal enum LineType : int
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	[Token(Token = "0x2000068")]
	internal class OnChangeEvent : UnityEvent<String>
	{

		[Address(RVA = "0x2F04000", Offset = "0x2F03400", Length = "0x39")]
		[Token(Token = "0x60003F2")]
		public OnChangeEvent() { }

	}

	[Token(Token = "0x2000066")]
	internal sealed class OnValidateInput : MulticastDelegate
	{

		[Address(RVA = "0x2F040F0", Offset = "0x2F034F0", Length = "0xB5")]
		[Token(Token = "0x60003ED")]
		public OnValidateInput(object object, IntPtr method) { }

		[Address(RVA = "0x2F04040", Offset = "0x2F03440", Length = "0x73")]
		[Token(Token = "0x60003EF")]
		public override IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2F040C0", Offset = "0x2F034C0", Length = "0x28")]
		[Token(Token = "0x60003F0")]
		public override char EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60003EE")]
		public override char Invoke(string text, int charIndex, char addedChar) { }

	}

	[Token(Token = "0x2000069")]
	internal class SelectionEvent : UnityEvent<String>
	{

		[Address(RVA = "0x2F041B0", Offset = "0x2F035B0", Length = "0x39")]
		[Token(Token = "0x60003F3")]
		public SelectionEvent() { }

	}

	[Token(Token = "0x2000067")]
	internal class SubmitEvent : UnityEvent<String>
	{

		[Address(RVA = "0x2F07860", Offset = "0x2F06C60", Length = "0x39")]
		[Token(Token = "0x60003F1")]
		public SubmitEvent() { }

	}

	[Token(Token = "0x200006A")]
	internal class TextSelectionEvent : UnityEvent<String, Int32, Int32>
	{

		[Address(RVA = "0x2F17D80", Offset = "0x2F17180", Length = "0x39")]
		[Token(Token = "0x60003F4")]
		public TextSelectionEvent() { }

	}

	[Token(Token = "0x200006B")]
	internal class TouchScreenKeyboardEvent : UnityEvent<Status>
	{

		[Address(RVA = "0x2F17DC0", Offset = "0x2F171C0", Length = "0x39")]
		[Token(Token = "0x60003F5")]
		public TouchScreenKeyboardEvent() { }

	}

	[Token(Token = "0x40002C0")]
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000287")]
	private static readonly Char[] kSeparators; //Field offset: 0x0
	[Token(Token = "0x40002D2")]
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	[Token(Token = "0x40002D3")]
	private const string kOculusQuestDeviceModel = "Oculus Quest"; //Field offset: 0x0
	[Token(Token = "0x40002C1")]
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000288")]
	private static bool s_IsQuestDevice; //Field offset: 0x8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000286")]
	protected TouchScreenKeyboard m_SoftKeyboard; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000289")]
	protected RectTransform m_RectTransform; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x400028A")]
	protected RectTransform m_TextViewport; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400028B")]
	protected RectMask2D m_TextComponentRectMask; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400028C")]
	protected RectMask2D m_TextViewportRectMask; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x400028D")]
	protected TMP_Text m_TextComponent; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400028E")]
	protected RectTransform m_TextComponentRectTransform; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400028F")]
	protected Graphic m_Placeholder; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000290")]
	protected Scrollbar m_VerticalScrollbar; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000291")]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000292")]
	private bool m_IsDrivenByLayoutComponents; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000293")]
	private LayoutGroup m_LayoutGroup; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000294")]
	private IScrollHandler m_IScrollHandlerParent; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000295")]
	private float m_ScrollPosition; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	[Token(Token = "0x4000296")]
	protected float m_ScrollSensitivity; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4000297")]
	private ContentType m_ContentType; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[SerializeField]
	[Token(Token = "0x4000298")]
	private InputType m_InputType; //Field offset: 0x174
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000299")]
	private char m_AsteriskChar; //Field offset: 0x178
	[FieldOffset(Offset = "0x17C")]
	[SerializeField]
	[Token(Token = "0x400029A")]
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x17C
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x400029B")]
	private LineType m_LineType; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	[Token(Token = "0x400029C")]
	private bool m_HideMobileInput; //Field offset: 0x184
	[FieldOffset(Offset = "0x185")]
	[SerializeField]
	[Token(Token = "0x400029D")]
	private bool m_HideSoftKeyboard; //Field offset: 0x185
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x400029E")]
	private CharacterValidation m_CharacterValidation; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x400029F")]
	private string m_RegexValue; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x40002A0")]
	private float m_GlobalPointSize; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	[Token(Token = "0x40002A1")]
	private int m_CharacterLimit; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x40002A2")]
	private SubmitEvent m_OnEndEdit; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x40002A3")]
	private SubmitEvent m_OnSubmit; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40002A4")]
	private SelectionEvent m_OnSelect; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40002A5")]
	private SelectionEvent m_OnDeselect; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40002A6")]
	private TextSelectionEvent m_OnTextSelection; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x40002A7")]
	private TextSelectionEvent m_OnEndTextSelection; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x40002A8")]
	private OnChangeEvent m_OnValueChanged; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x40002A9")]
	private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x40002AA")]
	private OnValidateInput m_OnValidateInput; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x40002AB")]
	private Color m_CaretColor; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x40002AC")]
	private bool m_CustomCaretColor; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[SerializeField]
	[Token(Token = "0x40002AD")]
	private Color m_SelectionColor; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[TextArea(5, 10)]
	[Token(Token = "0x40002AE")]
	protected string m_Text; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Range(0, 4)]
	[SerializeField]
	[Token(Token = "0x40002AF")]
	private float m_CaretBlinkRate; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x40002B0")]
	private int m_CaretWidth; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[SerializeField]
	[Token(Token = "0x40002B1")]
	private bool m_ReadOnly; //Field offset: 0x220
	[FieldOffset(Offset = "0x221")]
	[SerializeField]
	[Token(Token = "0x40002B2")]
	private bool m_RichText; //Field offset: 0x221
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40002B3")]
	protected int m_StringPosition; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40002B4")]
	protected int m_StringSelectPosition; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40002B5")]
	protected int m_CaretPosition; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x40002B6")]
	protected int m_CaretSelectPosition; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40002B7")]
	private RectTransform caretRectTrans; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x40002B8")]
	protected UIVertex[] m_CursorVerts; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x40002B9")]
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x40002BA")]
	private Vector2 m_LastPosition; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40002BB")]
	protected Mesh m_Mesh; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40002BC")]
	private bool m_AllowInput; //Field offset: 0x260
	[FieldOffset(Offset = "0x261")]
	[Token(Token = "0x40002BD")]
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x261
	[FieldOffset(Offset = "0x262")]
	[Token(Token = "0x40002BE")]
	private bool m_UpdateDrag; //Field offset: 0x262
	[FieldOffset(Offset = "0x263")]
	[Token(Token = "0x40002BF")]
	private bool m_DragPositionOutOfBounds; //Field offset: 0x263
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40002C2")]
	protected bool m_CaretVisible; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40002C3")]
	private Coroutine m_BlinkCoroutine; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40002C4")]
	private float m_BlinkStartTime; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40002C5")]
	private Coroutine m_DragCoroutine; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40002C6")]
	private string m_OriginalText; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40002C7")]
	private bool m_WasCanceled; //Field offset: 0x288
	[FieldOffset(Offset = "0x289")]
	[Token(Token = "0x40002C8")]
	private bool m_HasDoneFocusTransition; //Field offset: 0x289
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40002C9")]
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40002CA")]
	private bool m_PreventCallback; //Field offset: 0x298
	[FieldOffset(Offset = "0x299")]
	[Token(Token = "0x40002CB")]
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x299
	[FieldOffset(Offset = "0x29A")]
	[Token(Token = "0x40002CC")]
	private bool m_IsTextComponentUpdateRequired; //Field offset: 0x29A
	[FieldOffset(Offset = "0x29B")]
	[Token(Token = "0x40002CD")]
	private bool m_HasTextBeenRemoved; //Field offset: 0x29B
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x40002CE")]
	private float m_PointerDownClickStartTime; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40002CF")]
	private float m_KeyDownStartTime; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x40002D0")]
	private float m_DoubleClickDelay; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40002D1")]
	private bool m_IsApplePlatform; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2A9")]
	[Token(Token = "0x40002D4")]
	private bool m_IsCompositionActive; //Field offset: 0x2A9
	[FieldOffset(Offset = "0x2AA")]
	[Token(Token = "0x40002D5")]
	private bool m_ShouldUpdateIMEWindowPosition; //Field offset: 0x2AA
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x40002D6")]
	private int m_PreviousIMEInsertionLine; //Field offset: 0x2AC
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x40002D7")]
	protected TMP_FontAsset m_GlobalFontAsset; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x40002D8")]
	protected bool m_OnFocusSelectAll; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2B9")]
	[Token(Token = "0x40002D9")]
	protected bool m_isSelectAll; //Field offset: 0x2B9
	[FieldOffset(Offset = "0x2BA")]
	[SerializeField]
	[Token(Token = "0x40002DA")]
	protected bool m_ResetOnDeActivation; //Field offset: 0x2BA
	[FieldOffset(Offset = "0x2BB")]
	[Token(Token = "0x40002DB")]
	private bool m_SelectionStillActive; //Field offset: 0x2BB
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x40002DC")]
	private bool m_ReleaseSelection; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x40002DD")]
	private KeyCode m_LastKeyCode; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40002DE")]
	private GameObject m_PreviouslySelectedObject; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Token(Token = "0x40002DF")]
	private bool m_KeepTextSelectionVisible; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D1")]
	[SerializeField]
	[Token(Token = "0x40002E0")]
	private bool m_RestoreOriginalTextOnEscape; //Field offset: 0x2D1
	[FieldOffset(Offset = "0x2D2")]
	[SerializeField]
	[Token(Token = "0x40002E1")]
	protected bool m_isRichTextEditingAllowed; //Field offset: 0x2D2
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	[Token(Token = "0x40002E2")]
	protected int m_LineLimit; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40002E3")]
	public bool isAlert; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	[Token(Token = "0x40002E4")]
	protected TMP_InputValidator m_InputValidator; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x40002E5")]
	private bool m_ShouldActivateOnSelect; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2E9")]
	[Token(Token = "0x40002E6")]
	private bool m_isSelected; //Field offset: 0x2E9
	[FieldOffset(Offset = "0x2EA")]
	[Token(Token = "0x40002E7")]
	private bool m_IsStringPositionDirty; //Field offset: 0x2EA
	[FieldOffset(Offset = "0x2EB")]
	[Token(Token = "0x40002E8")]
	private bool m_IsCaretPositionDirty; //Field offset: 0x2EB
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x40002E9")]
	private bool m_forceRectTransformAdjustment; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2ED")]
	[Token(Token = "0x40002EA")]
	private bool m_IsKeyboardBeingClosedInHoloLens; //Field offset: 0x2ED
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40002EB")]
	private Event m_ProcessingEvent; //Field offset: 0x2F0

	[Token(Token = "0x170000C0")]
	public char asteriskChar
	{
		[Address(RVA = "0x2ED72F0", Offset = "0x2ED66F0", Length = "0x8")]
		[Token(Token = "0x600035A")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED7EC0", Offset = "0x2ED72C0", Length = "0x5B")]
		[Token(Token = "0x600035B")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700009A")]
	public float caretBlinkRate
	{
		[Address(RVA = "0x2ED7300", Offset = "0x2ED6700", Length = "0x9")]
		[Token(Token = "0x6000310")]
		 get { } //Length: 9
		[Address(RVA = "0x2ED7F20", Offset = "0x2ED7320", Length = "0x65")]
		[Token(Token = "0x6000311")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170000A1")]
	public Color caretColor
	{
		[Address(RVA = "0x2ED7310", Offset = "0x2ED6710", Length = "0x5D")]
		[Token(Token = "0x600031E")]
		 get { } //Length: 93
		[Address(RVA = "0x2ED7F90", Offset = "0x2ED7390", Length = "0x6F")]
		[Token(Token = "0x600031F")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000C7")]
	public int caretPosition
	{
		[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
		[Token(Token = "0x6000369")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED8020", Offset = "0x2ED7420", Length = "0x9F")]
		[Token(Token = "0x600036A")]
		 set { } //Length: 159
	}

	[Token(Token = "0x170000C2")]
	protected int caretPositionInternal
	{
		[Address(RVA = "0x2ED7370", Offset = "0x2ED6770", Length = "0x3B")]
		[Token(Token = "0x6000360")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED8000", Offset = "0x2ED7400", Length = "0x15")]
		[Token(Token = "0x6000361")]
		 set { } //Length: 21
	}

	[Token(Token = "0x170000C4")]
	protected int caretSelectPositionInternal
	{
		[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
		[Token(Token = "0x6000364")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED80C0", Offset = "0x2ED74C0", Length = "0x15")]
		[Token(Token = "0x6000365")]
		 set { } //Length: 21
	}

	[Token(Token = "0x1700009B")]
	public int caretWidth
	{
		[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
		[Token(Token = "0x6000312")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED80E0", Offset = "0x2ED74E0", Length = "0x8A")]
		[Token(Token = "0x6000313")]
		 set { } //Length: 138
	}

	[Token(Token = "0x170000AD")]
	public int characterLimit
	{
		[Address(RVA = "0x2ED73F0", Offset = "0x2ED67F0", Length = "0x7")]
		[Token(Token = "0x6000336")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED8170", Offset = "0x2ED7570", Length = "0xA1")]
		[Token(Token = "0x6000337")]
		 set { } //Length: 161
	}

	[Token(Token = "0x170000BB")]
	public CharacterValidation characterValidation
	{
		[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
		[Token(Token = "0x6000351")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED8220", Offset = "0x2ED7620", Length = "0x68")]
		[Token(Token = "0x6000352")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000CD")]
	private static string clipboard
	{
		[Address(RVA = "0x2ED7410", Offset = "0x2ED6810", Length = "0x40")]
		[Token(Token = "0x6000381")]
		private get { } //Length: 64
		[Address(RVA = "0x2ED8290", Offset = "0x2ED7690", Length = "0x49")]
		[Token(Token = "0x6000382")]
		private set { } //Length: 73
	}

	[Token(Token = "0x17000093")]
	private int compositionLength
	{
		[Address(RVA = "0x2ED7450", Offset = "0x2ED6850", Length = "0x2D")]
		[Token(Token = "0x6000300")]
		private get { } //Length: 45
	}

	[Token(Token = "0x17000092")]
	private string compositionString
	{
		[Address(RVA = "0x2ED7480", Offset = "0x2ED6880", Length = "0xA2")]
		[Token(Token = "0x60002FF")]
		private get { } //Length: 162
	}

	[Token(Token = "0x170000B5")]
	public ContentType contentType
	{
		[Address(RVA = "0x2ED7530", Offset = "0x2ED6930", Length = "0x7")]
		[Token(Token = "0x6000346")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED82E0", Offset = "0x2ED76E0", Length = "0x210")]
		[Token(Token = "0x6000347")]
		 set { } //Length: 528
	}

	[Token(Token = "0x170000A2")]
	public bool customCaretColor
	{
		[Address(RVA = "0x2ED7540", Offset = "0x2ED6940", Length = "0x8")]
		[Token(Token = "0x6000320")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8520", Offset = "0x2ED7920", Length = "0x5D")]
		[Token(Token = "0x6000321")]
		 set { } //Length: 93
	}

	[Token(Token = "0x170000D3")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000D0")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
		[Token(Token = "0x60003E4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000AF")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x1D6D5E0", Offset = "0x1D6C9E0", Length = "0x8")]
		[Token(Token = "0x600033A")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8580", Offset = "0x2ED7980", Length = "0x134")]
		[Token(Token = "0x600033B")]
		 set { } //Length: 308
	}

	[Token(Token = "0x170000C6")]
	private bool hasSelection
	{
		[Address(RVA = "0x2ED7550", Offset = "0x2ED6950", Length = "0x80")]
		[Token(Token = "0x6000368")]
		private get { } //Length: 128
	}

	[Token(Token = "0x17000091")]
	private BaseInput inputSystem
	{
		[Address(RVA = "0x2ED75E0", Offset = "0x2ED69E0", Length = "0xFB")]
		[Token(Token = "0x60002FE")]
		private get { } //Length: 251
	}

	[Token(Token = "0x170000B8")]
	public InputType inputType
	{
		[Address(RVA = "0x1D11C30", Offset = "0x1D11030", Length = "0x7")]
		[Token(Token = "0x600034C")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED86C0", Offset = "0x2ED7AC0", Length = "0x68")]
		[Token(Token = "0x600034D")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000BC")]
	public TMP_InputValidator inputValidator
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[Token(Token = "0x6000353")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8730", Offset = "0x2ED7B30", Length = "0x6A")]
		[Token(Token = "0x6000354")]
		 set { } //Length: 106
	}

	[Token(Token = "0x17000099")]
	public bool isFocused
	{
		[Address(RVA = "0x2ED76F0", Offset = "0x2ED6AF0", Length = "0x8")]
		[Token(Token = "0x600030F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000B4")]
	public bool isRichTextEditingAllowed
	{
		[Address(RVA = "0x2ED7700", Offset = "0x2ED6B00", Length = "0x8")]
		[Token(Token = "0x6000344")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED87A0", Offset = "0x2ED7BA0", Length = "0x7")]
		[Token(Token = "0x6000345")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B2")]
	public bool keepTextSelectionVisible
	{
		[Address(RVA = "0x2ED7710", Offset = "0x2ED6B10", Length = "0x8")]
		[Token(Token = "0x6000340")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED87B0", Offset = "0x2ED7BB0", Length = "0x7")]
		[Token(Token = "0x6000341")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000BA")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x2DA3900", Offset = "0x2DA2D00", Length = "0x7")]
		[Token(Token = "0x600034F")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED87C0", Offset = "0x2ED7BC0", Length = "0x68")]
		[Token(Token = "0x6000350")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000D4")]
	public override int layoutPriority
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60003E8")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B7")]
	public int lineLimit
	{
		[Address(RVA = "0x2ED7720", Offset = "0x2ED6B20", Length = "0x7")]
		[Token(Token = "0x600034A")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED8830", Offset = "0x2ED7C30", Length = "0x68")]
		[Token(Token = "0x600034B")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170000B6")]
	public LineType lineType
	{
		[Address(RVA = "0x2ED7730", Offset = "0x2ED6B30", Length = "0x7")]
		[Token(Token = "0x6000348")]
		 get { } //Length: 7
		[Address(RVA = "0x2ED88A0", Offset = "0x2ED7CA0", Length = "0xD7")]
		[Token(Token = "0x6000349")]
		 set { } //Length: 215
	}

	[Token(Token = "0x17000094")]
	protected Mesh mesh
	{
		[Address(RVA = "0x2ED7740", Offset = "0x2ED6B40", Length = "0xA3")]
		[Token(Token = "0x6000302")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170000D1")]
	public override float minHeight
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000CE")]
	public override float minWidth
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60003E2")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000BF")]
	public bool multiLine
	{
		[Address(RVA = "0x2ED77F0", Offset = "0x2ED6BF0", Length = "0x17")]
		[Token(Token = "0x6000359")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170000A7")]
	public SelectionEvent onDeselect
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[Token(Token = "0x600032A")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8980", Offset = "0x2ED7D80", Length = "0x4C")]
		[Token(Token = "0x600032B")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A4")]
	public SubmitEvent onEndEdit
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[Token(Token = "0x6000324")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED89D0", Offset = "0x2ED7DD0", Length = "0x4C")]
		[Token(Token = "0x6000325")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A9")]
	public TextSelectionEvent onEndTextSelection
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[Token(Token = "0x600032E")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8A20", Offset = "0x2ED7E20", Length = "0x4C")]
		[Token(Token = "0x600032F")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000B0")]
	public bool onFocusSelectAll
	{
		[Address(RVA = "0x1D6D620", Offset = "0x1D6CA20", Length = "0x8")]
		[Token(Token = "0x600033C")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8A70", Offset = "0x2ED7E70", Length = "0x7")]
		[Token(Token = "0x600033D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000A6")]
	public SelectionEvent onSelect
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[Token(Token = "0x6000328")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8A80", Offset = "0x2ED7E80", Length = "0x4C")]
		[Token(Token = "0x6000329")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A5")]
	public SubmitEvent onSubmit
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[Token(Token = "0x6000326")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8AD0", Offset = "0x2ED7ED0", Length = "0x4C")]
		[Token(Token = "0x6000327")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000A8")]
	public TextSelectionEvent onTextSelection
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[Token(Token = "0x600032C")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8B20", Offset = "0x2ED7F20", Length = "0x4C")]
		[Token(Token = "0x600032D")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AB")]
	public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8B70", Offset = "0x2ED7F70", Length = "0x4C")]
		[Token(Token = "0x6000333")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AC")]
	public OnValidateInput onValidateInput
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[Token(Token = "0x6000334")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8BC0", Offset = "0x2ED7FC0", Length = "0x4C")]
		[Token(Token = "0x6000335")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AA")]
	public OnChangeEvent onValueChanged
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[Token(Token = "0x6000330")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8C10", Offset = "0x2ED8010", Length = "0x4C")]
		[Token(Token = "0x6000331")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700009E")]
	public Graphic placeholder
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x6000318")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8C60", Offset = "0x2ED8060", Length = "0x4C")]
		[Token(Token = "0x6000319")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000AE")]
	public float pointSize
	{
		[Address(RVA = "0x2ED7810", Offset = "0x2ED6C10", Length = "0x9")]
		[Token(Token = "0x6000338")]
		 get { } //Length: 9
		[Address(RVA = "0x2ED8CB0", Offset = "0x2ED80B0", Length = "0x165")]
		[Token(Token = "0x6000339")]
		 set { } //Length: 357
	}

	[Token(Token = "0x170000D2")]
	public override float preferredHeight
	{
		[Address(RVA = "0x2ED7820", Offset = "0x2ED6C20", Length = "0x16D")]
		[Token(Token = "0x60003E6")]
		 get { } //Length: 365
	}

	[Token(Token = "0x170000CF")]
	public override float preferredWidth
	{
		[Address(RVA = "0x2ED7990", Offset = "0x2ED6D90", Length = "0x16D")]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 365
	}

	[Token(Token = "0x170000BD")]
	public bool readOnly
	{
		[Address(RVA = "0x1D49FA0", Offset = "0x1D493A0", Length = "0x8")]
		[Token(Token = "0x6000355")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4B2F0", Offset = "0x1D4A6F0", Length = "0x7")]
		[Token(Token = "0x6000356")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B1")]
	public bool resetOnDeActivation
	{
		[Address(RVA = "0x2ED7B00", Offset = "0x2ED6F00", Length = "0x8")]
		[Token(Token = "0x600033E")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8E20", Offset = "0x2ED8220", Length = "0x7")]
		[Token(Token = "0x600033F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B3")]
	public bool restoreOriginalTextOnEscape
	{
		[Address(RVA = "0x2ED7B10", Offset = "0x2ED6F10", Length = "0x8")]
		[Token(Token = "0x6000342")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8E30", Offset = "0x2ED8230", Length = "0x7")]
		[Token(Token = "0x6000343")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000BE")]
	public bool richText
	{
		[Address(RVA = "0x2ED7B20", Offset = "0x2ED6F20", Length = "0x8")]
		[Token(Token = "0x6000357")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED8E40", Offset = "0x2ED8240", Length = "0x87")]
		[Token(Token = "0x6000358")]
		 set { } //Length: 135
	}

	[Token(Token = "0x170000A0")]
	public float scrollSensitivity
	{
		[Address(RVA = "0x2D01AA0", Offset = "0x2D00EA0", Length = "0x9")]
		[Token(Token = "0x600031C")]
		 get { } //Length: 9
		[Address(RVA = "0x2ED8ED0", Offset = "0x2ED82D0", Length = "0x8D")]
		[Token(Token = "0x600031D")]
		 set { } //Length: 141
	}

	[Token(Token = "0x170000C8")]
	public int selectionAnchorPosition
	{
		[Address(RVA = "0x2ED7370", Offset = "0x2ED6770", Length = "0x3B")]
		[Token(Token = "0x600036B")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED8F60", Offset = "0x2ED8360", Length = "0x59")]
		[Token(Token = "0x600036C")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000A3")]
	public Color selectionColor
	{
		[Address(RVA = "0x2ED7B30", Offset = "0x2ED6F30", Length = "0xE")]
		[Token(Token = "0x6000322")]
		 get { } //Length: 14
		[Address(RVA = "0x2ED8FC0", Offset = "0x2ED83C0", Length = "0x6F")]
		[Token(Token = "0x6000323")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000C9")]
	public int selectionFocusPosition
	{
		[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
		[Token(Token = "0x600036D")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED9030", Offset = "0x2ED8430", Length = "0x59")]
		[Token(Token = "0x600036E")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000CB")]
	public int selectionStringAnchorPosition
	{
		[Address(RVA = "0x2ED7B40", Offset = "0x2ED6F40", Length = "0x3B")]
		[Token(Token = "0x6000371")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED9090", Offset = "0x2ED8490", Length = "0x82")]
		[Token(Token = "0x6000372")]
		 set { } //Length: 130
	}

	[Token(Token = "0x170000CC")]
	public int selectionStringFocusPosition
	{
		[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
		[Token(Token = "0x6000373")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED9120", Offset = "0x2ED8520", Length = "0x82")]
		[Token(Token = "0x6000374")]
		 set { } //Length: 130
	}

	[Token(Token = "0x17000095")]
	public override bool shouldActivateOnSelect
	{
		[Address(RVA = "0x2ED7BC0", Offset = "0x2ED6FC0", Length = "0x5E")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 94
		[Address(RVA = "0x2ED91B0", Offset = "0x2ED85B0", Length = "0x7")]
		[Token(Token = "0x6000303")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000096")]
	public bool shouldHideMobileInput
	{
		[Address(RVA = "0x2ED7C20", Offset = "0x2ED7020", Length = "0x6F")]
		[Token(Token = "0x6000305")]
		 get { } //Length: 111
		[Address(RVA = "0x2ED91C0", Offset = "0x2ED85C0", Length = "0xA0")]
		[Token(Token = "0x6000306")]
		 set { } //Length: 160
	}

	[Token(Token = "0x17000097")]
	public bool shouldHideSoftKeyboard
	{
		[Address(RVA = "0x2ED7C90", Offset = "0x2ED7090", Length = "0x8F")]
		[Token(Token = "0x6000307")]
		 get { } //Length: 143
		[Address(RVA = "0x2ED9260", Offset = "0x2ED8660", Length = "0x144")]
		[Token(Token = "0x6000308")]
		 set { } //Length: 324
	}

	[Token(Token = "0x170000CA")]
	public int stringPosition
	{
		[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
		[Token(Token = "0x600036F")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED9400", Offset = "0x2ED8800", Length = "0xD9")]
		[Token(Token = "0x6000370")]
		 set { } //Length: 217
	}

	[Token(Token = "0x170000C3")]
	protected int stringPositionInternal
	{
		[Address(RVA = "0x2ED7B40", Offset = "0x2ED6F40", Length = "0x3B")]
		[Token(Token = "0x6000362")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED93B0", Offset = "0x2ED87B0", Length = "0x46")]
		[Token(Token = "0x6000363")]
		 set { } //Length: 70
	}

	[Token(Token = "0x170000C5")]
	protected int stringSelectPositionInternal
	{
		[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
		[Token(Token = "0x6000366")]
		 get { } //Length: 59
		[Address(RVA = "0x2ED94E0", Offset = "0x2ED88E0", Length = "0x46")]
		[Token(Token = "0x6000367")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000098")]
	public string text
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[Token(Token = "0x600030B")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED95E0", Offset = "0x2ED89E0", Length = "0xB")]
		[Token(Token = "0x600030C")]
		 set { } //Length: 11
	}

	[Token(Token = "0x1700009D")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED9530", Offset = "0x2ED8930", Length = "0x5B")]
		[Token(Token = "0x6000317")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700009C")]
	public RectTransform textViewport
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x6000314")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED9590", Offset = "0x2ED8990", Length = "0x4C")]
		[Token(Token = "0x6000315")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000B9")]
	public TouchScreenKeyboard touchScreenKeyboard
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x600034E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009F")]
	public Scrollbar verticalScrollbar
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x600031A")]
		 get { } //Length: 8
		[Address(RVA = "0x2ED95F0", Offset = "0x2ED89F0", Length = "0x19D")]
		[Token(Token = "0x600031B")]
		 set { } //Length: 413
	}

	[Token(Token = "0x170000C1")]
	public bool wasCanceled
	{
		[Address(RVA = "0x2ED7D20", Offset = "0x2ED7120", Length = "0x8")]
		[Token(Token = "0x600035C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2ED6F10", Offset = "0x2ED6310", Length = "0x9F")]
	[Token(Token = "0x60003EB")]
	private static TMP_InputField() { }

	[Address(RVA = "0x2ED6FB0", Offset = "0x2ED63B0", Length = "0x33C")]
	[Token(Token = "0x6000301")]
	protected TMP_InputField() { }

	[Address(RVA = "0x2EC8E90", Offset = "0x2EC8290", Length = "0x13C")]
	[Token(Token = "0x60003CE")]
	public void ActivateInputField() { }

	[Address(RVA = "0x2EC89B0", Offset = "0x2EC7DB0", Length = "0x4D8")]
	[Token(Token = "0x60003CF")]
	private void ActivateInputFieldInternal() { }

	[Address(RVA = "0x2EC8FD0", Offset = "0x2EC83D0", Length = "0x843")]
	[Token(Token = "0x60003CC")]
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	[Address(RVA = "0x2EC9820", Offset = "0x2EC8C20", Length = "0x27F")]
	[Token(Token = "0x60003BA")]
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	[Address(RVA = "0x2EC9B50", Offset = "0x2EC8F50", Length = "0x60A")]
	[Token(Token = "0x60003AA")]
	protected override void Append(char input) { }

	[Address(RVA = "0x2EC9AA0", Offset = "0x2EC8EA0", Length = "0xA8")]
	[Token(Token = "0x60003A9")]
	protected override void Append(string input) { }

	[Address(RVA = "0x2ECA160", Offset = "0x2EC9560", Length = "0x772")]
	[Token(Token = "0x60003C7")]
	private void AssignPositioningIfNeeded() { }

	[Address(RVA = "0x2ECA8E0", Offset = "0x2EC9CE0", Length = "0x487")]
	[Token(Token = "0x60003A8")]
	private void Backspace() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E0")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003E1")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x2ECAD70", Offset = "0x2ECA170", Length = "0x6D")]
	[IteratorStateMachine(typeof(<CaretBlink>d__293))]
	[Token(Token = "0x6000378")]
	private IEnumerator CaretBlink() { }

	[Address(RVA = "0x2ECADE0", Offset = "0x2ECA1E0", Length = "0x8")]
	[Token(Token = "0x600035F")]
	private int ClampArrayIndex(int index) { }

	[Address(RVA = "0x2ECADF0", Offset = "0x2ECA1F0", Length = "0x77")]
	[Token(Token = "0x600035E")]
	protected void ClampCaretPos(ref int pos) { }

	[Address(RVA = "0x2ECAE70", Offset = "0x2ECA270", Length = "0x3D")]
	[Token(Token = "0x600035D")]
	protected void ClampStringPos(ref int pos) { }

	[Address(RVA = "0x2ECAEB0", Offset = "0x2ECA2B0", Length = "0x1B6")]
	[Token(Token = "0x60003CA")]
	private void CreateCursorVerts() { }

	[Address(RVA = "0x2ECB070", Offset = "0x2ECA470", Length = "0x263")]
	[Token(Token = "0x60003D4")]
	public void DeactivateInputField(bool clearSelection = false) { }

	[Address(RVA = "0x2ECB6B0", Offset = "0x2ECAAB0", Length = "0x3B7")]
	[Token(Token = "0x60003A6")]
	private void Delete() { }

	[Address(RVA = "0x2ECB2E0", Offset = "0x2ECA6E0", Length = "0x3C6")]
	[Token(Token = "0x60003A7")]
	private void DeleteKey() { }

	[Address(RVA = "0x2ECBA70", Offset = "0x2ECAE70", Length = "0x2A")]
	[Token(Token = "0x60003DF")]
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	[Address(RVA = "0x2ECBAA0", Offset = "0x2ECAEA0", Length = "0x1D4")]
	[Token(Token = "0x60003D9")]
	private void EnforceContentType() { }

	[Address(RVA = "0x2ECBCA0", Offset = "0x2ECB0A0", Length = "0x11E")]
	[Token(Token = "0x6000396")]
	private int FindNextWordBegin() { }

	[Address(RVA = "0x2ECBDC0", Offset = "0x2ECB1C0", Length = "0x10B")]
	[Token(Token = "0x6000398")]
	private int FindPrevWordBegin() { }

	[Address(RVA = "0x2ECBED0", Offset = "0x2ECB2D0", Length = "0x7")]
	[Token(Token = "0x60003C1")]
	public void ForceLabelUpdate() { }

	[Address(RVA = "0x2ECBEE0", Offset = "0x2ECB2E0", Length = "0x738")]
	[Token(Token = "0x60003C9")]
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x2ECCC40", Offset = "0x2ECC040", Length = "0xA10")]
	[Token(Token = "0x60003CB")]
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	[Address(RVA = "0x2ED72F0", Offset = "0x2ED66F0", Length = "0x8")]
	[Token(Token = "0x600035A")]
	public char get_asteriskChar() { }

	[Address(RVA = "0x2ED7300", Offset = "0x2ED6700", Length = "0x9")]
	[Token(Token = "0x6000310")]
	public float get_caretBlinkRate() { }

	[Address(RVA = "0x2ED7310", Offset = "0x2ED6710", Length = "0x5D")]
	[Token(Token = "0x600031E")]
	public Color get_caretColor() { }

	[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
	[Token(Token = "0x6000369")]
	public int get_caretPosition() { }

	[Address(RVA = "0x2ED7370", Offset = "0x2ED6770", Length = "0x3B")]
	[Token(Token = "0x6000360")]
	protected int get_caretPositionInternal() { }

	[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
	[Token(Token = "0x6000364")]
	protected int get_caretSelectPositionInternal() { }

	[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
	[Token(Token = "0x6000312")]
	public int get_caretWidth() { }

	[Address(RVA = "0x2ED73F0", Offset = "0x2ED67F0", Length = "0x7")]
	[Token(Token = "0x6000336")]
	public int get_characterLimit() { }

	[Address(RVA = "0x2ED7400", Offset = "0x2ED6800", Length = "0x7")]
	[Token(Token = "0x6000351")]
	public CharacterValidation get_characterValidation() { }

	[Address(RVA = "0x2ED7410", Offset = "0x2ED6810", Length = "0x40")]
	[Token(Token = "0x6000381")]
	private static string get_clipboard() { }

	[Address(RVA = "0x2ED7450", Offset = "0x2ED6850", Length = "0x2D")]
	[Token(Token = "0x6000300")]
	private int get_compositionLength() { }

	[Address(RVA = "0x2ED7480", Offset = "0x2ED6880", Length = "0xA2")]
	[Token(Token = "0x60002FF")]
	private string get_compositionString() { }

	[Address(RVA = "0x2ED7530", Offset = "0x2ED6930", Length = "0x7")]
	[Token(Token = "0x6000346")]
	public ContentType get_contentType() { }

	[Address(RVA = "0x2ED7540", Offset = "0x2ED6940", Length = "0x8")]
	[Token(Token = "0x6000320")]
	public bool get_customCaretColor() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x60003E7")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x60003E4")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1D6D5E0", Offset = "0x1D6C9E0", Length = "0x8")]
	[Token(Token = "0x600033A")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0x2ED7550", Offset = "0x2ED6950", Length = "0x80")]
	[Token(Token = "0x6000368")]
	private bool get_hasSelection() { }

	[Address(RVA = "0x2ED75E0", Offset = "0x2ED69E0", Length = "0xFB")]
	[Token(Token = "0x60002FE")]
	private BaseInput get_inputSystem() { }

	[Address(RVA = "0x1D11C30", Offset = "0x1D11030", Length = "0x7")]
	[Token(Token = "0x600034C")]
	public InputType get_inputType() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[Token(Token = "0x6000353")]
	public TMP_InputValidator get_inputValidator() { }

	[Address(RVA = "0x2ED76F0", Offset = "0x2ED6AF0", Length = "0x8")]
	[Token(Token = "0x600030F")]
	public bool get_isFocused() { }

	[Address(RVA = "0x2ED7700", Offset = "0x2ED6B00", Length = "0x8")]
	[Token(Token = "0x6000344")]
	public bool get_isRichTextEditingAllowed() { }

	[Address(RVA = "0x2ED7710", Offset = "0x2ED6B10", Length = "0x8")]
	[Token(Token = "0x6000340")]
	public bool get_keepTextSelectionVisible() { }

	[Address(RVA = "0x2DA3900", Offset = "0x2DA2D00", Length = "0x7")]
	[Token(Token = "0x600034F")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60003E8")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x2ED7720", Offset = "0x2ED6B20", Length = "0x7")]
	[Token(Token = "0x600034A")]
	public int get_lineLimit() { }

	[Address(RVA = "0x2ED7730", Offset = "0x2ED6B30", Length = "0x7")]
	[Token(Token = "0x6000348")]
	public LineType get_lineType() { }

	[Address(RVA = "0x2ED7740", Offset = "0x2ED6B40", Length = "0xA3")]
	[Token(Token = "0x6000302")]
	protected Mesh get_mesh() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60003E5")]
	public override float get_minHeight() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60003E2")]
	public override float get_minWidth() { }

	[Address(RVA = "0x2ED77F0", Offset = "0x2ED6BF0", Length = "0x17")]
	[Token(Token = "0x6000359")]
	public bool get_multiLine() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[Token(Token = "0x600032A")]
	public SelectionEvent get_onDeselect() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[Token(Token = "0x6000324")]
	public SubmitEvent get_onEndEdit() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[Token(Token = "0x600032E")]
	public TextSelectionEvent get_onEndTextSelection() { }

	[Address(RVA = "0x1D6D620", Offset = "0x1D6CA20", Length = "0x8")]
	[Token(Token = "0x600033C")]
	public bool get_onFocusSelectAll() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[Token(Token = "0x6000328")]
	public SelectionEvent get_onSelect() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[Token(Token = "0x6000326")]
	public SubmitEvent get_onSubmit() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[Token(Token = "0x600032C")]
	public TextSelectionEvent get_onTextSelection() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[Token(Token = "0x6000332")]
	public TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[Token(Token = "0x6000334")]
	public OnValidateInput get_onValidateInput() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[Token(Token = "0x6000330")]
	public OnChangeEvent get_onValueChanged() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x6000318")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x2ED7810", Offset = "0x2ED6C10", Length = "0x9")]
	[Token(Token = "0x6000338")]
	public float get_pointSize() { }

	[Address(RVA = "0x2ED7820", Offset = "0x2ED6C20", Length = "0x16D")]
	[Token(Token = "0x60003E6")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x2ED7990", Offset = "0x2ED6D90", Length = "0x16D")]
	[Token(Token = "0x60003E3")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x1D49FA0", Offset = "0x1D493A0", Length = "0x8")]
	[Token(Token = "0x6000355")]
	public bool get_readOnly() { }

	[Address(RVA = "0x2ED7B00", Offset = "0x2ED6F00", Length = "0x8")]
	[Token(Token = "0x600033E")]
	public bool get_resetOnDeActivation() { }

	[Address(RVA = "0x2ED7B10", Offset = "0x2ED6F10", Length = "0x8")]
	[Token(Token = "0x6000342")]
	public bool get_restoreOriginalTextOnEscape() { }

	[Address(RVA = "0x2ED7B20", Offset = "0x2ED6F20", Length = "0x8")]
	[Token(Token = "0x6000357")]
	public bool get_richText() { }

	[Address(RVA = "0x2D01AA0", Offset = "0x2D00EA0", Length = "0x9")]
	[Token(Token = "0x600031C")]
	public float get_scrollSensitivity() { }

	[Address(RVA = "0x2ED7370", Offset = "0x2ED6770", Length = "0x3B")]
	[Token(Token = "0x600036B")]
	public int get_selectionAnchorPosition() { }

	[Address(RVA = "0x2ED7B30", Offset = "0x2ED6F30", Length = "0xE")]
	[Token(Token = "0x6000322")]
	public Color get_selectionColor() { }

	[Address(RVA = "0x2ED73B0", Offset = "0x2ED67B0", Length = "0x3B")]
	[Token(Token = "0x600036D")]
	public int get_selectionFocusPosition() { }

	[Address(RVA = "0x2ED7B40", Offset = "0x2ED6F40", Length = "0x3B")]
	[Token(Token = "0x6000371")]
	public int get_selectionStringAnchorPosition() { }

	[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
	[Token(Token = "0x6000373")]
	public int get_selectionStringFocusPosition() { }

	[Address(RVA = "0x2ED7BC0", Offset = "0x2ED6FC0", Length = "0x5E")]
	[Token(Token = "0x6000304")]
	public override bool get_shouldActivateOnSelect() { }

	[Address(RVA = "0x2ED7C20", Offset = "0x2ED7020", Length = "0x6F")]
	[Token(Token = "0x6000305")]
	public bool get_shouldHideMobileInput() { }

	[Address(RVA = "0x2ED7C90", Offset = "0x2ED7090", Length = "0x8F")]
	[Token(Token = "0x6000307")]
	public bool get_shouldHideSoftKeyboard() { }

	[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
	[Token(Token = "0x600036F")]
	public int get_stringPosition() { }

	[Address(RVA = "0x2ED7B40", Offset = "0x2ED6F40", Length = "0x3B")]
	[Token(Token = "0x6000362")]
	protected int get_stringPositionInternal() { }

	[Address(RVA = "0x2ED7B80", Offset = "0x2ED6F80", Length = "0x3B")]
	[Token(Token = "0x6000366")]
	protected int get_stringSelectPositionInternal() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[Token(Token = "0x600030B")]
	public string get_text() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[Token(Token = "0x6000316")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x6000314")]
	public RectTransform get_textViewport() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x600034E")]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x600031A")]
	public Scrollbar get_verticalScrollbar() { }

	[Address(RVA = "0x2ED7D20", Offset = "0x2ED7120", Length = "0x8")]
	[Token(Token = "0x600035C")]
	public bool get_wasCanceled() { }

	[Address(RVA = "0x2ECD660", Offset = "0x2ECCA60", Length = "0xBF")]
	[Token(Token = "0x60003BB")]
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x2ECD660", Offset = "0x2ECCA60", Length = "0xBF")]
	[Token(Token = "0x60003BD")]
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x2ECD720", Offset = "0x2ECCB20", Length = "0x105")]
	[Token(Token = "0x60003BC")]
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	[Address(RVA = "0x2ECD830", Offset = "0x2ECCC30", Length = "0x1DA")]
	[Token(Token = "0x6000394")]
	private float GetScrollPositionRelativeToViewport() { }

	[Address(RVA = "0x2ECDA10", Offset = "0x2ECCE10", Length = "0xDE")]
	[Token(Token = "0x6000395")]
	private string GetSelectedString() { }

	[Address(RVA = "0x2ECDAF0", Offset = "0x2ECCEF0", Length = "0xA8")]
	[Token(Token = "0x60003BE")]
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003C5")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x2ECDC20", Offset = "0x2ECD020", Length = "0x78")]
	[Token(Token = "0x6000383")]
	private bool InPlaceEditing() { }

	[Address(RVA = "0x2ECDBA0", Offset = "0x2ECCFA0", Length = "0x72")]
	[Token(Token = "0x6000384")]
	private bool InPlaceEditingChanged() { }

	[Address(RVA = "0x2ECDCA0", Offset = "0x2ECD0A0", Length = "0x17F")]
	[Token(Token = "0x60003AB")]
	private void Insert(char c) { }

	[Address(RVA = "0x2ED7D30", Offset = "0x2ED7130", Length = "0x7C")]
	[Token(Token = "0x6000309")]
	private bool isKeyboardUsingEvents() { }

	[Address(RVA = "0x2ED7E30", Offset = "0x2ED7230", Length = "0x90")]
	[Token(Token = "0x600030A")]
	private bool isUWP() { }

	[Address(RVA = "0x2ECDE20", Offset = "0x2ECD220", Length = "0x1B")]
	[Token(Token = "0x6000390")]
	protected override bool IsValidChar(char c) { }

	[Address(RVA = "0x2ECDE40", Offset = "0x2ECD240", Length = "0x4A0")]
	[Token(Token = "0x600038F")]
	protected EditState KeyPressed(Event evt) { }

	[Address(RVA = "0x2ECE310", Offset = "0x2ECD710", Length = "0xA4C")]
	[Token(Token = "0x6000388")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003C4")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x2ECED80", Offset = "0x2ECE180", Length = "0x2C5")]
	[Token(Token = "0x600039B")]
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x2ECF050", Offset = "0x2ECE450", Length = "0x289")]
	[Token(Token = "0x600039A")]
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x2ECF2E0", Offset = "0x2ECE6E0", Length = "0x49")]
	[Token(Token = "0x60003C2")]
	private void MarkGeometryAsDirty() { }

	[Address(RVA = "0x2ECF330", Offset = "0x2ECE730", Length = "0xEA")]
	[Token(Token = "0x6000389")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x2ECF420", Offset = "0x2ECE820", Length = "0x8A")]
	[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__314))]
	[Token(Token = "0x600038C")]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	[Address(RVA = "0x2ECF4B0", Offset = "0x2ECE8B0", Length = "0x2B3")]
	[Token(Token = "0x600039F")]
	private void MoveDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x2ECF770", Offset = "0x2ECEB70", Length = "0xB")]
	[Token(Token = "0x600039E")]
	private void MoveDown(bool shift) { }

	[Address(RVA = "0x2ECF780", Offset = "0x2ECEB80", Length = "0x755")]
	[Token(Token = "0x6000399")]
	private void MoveLeft(bool shift, bool ctrl) { }

	[Address(RVA = "0x2ECFEE0", Offset = "0x2ECF2E0", Length = "0x477")]
	[Token(Token = "0x60003A5")]
	private void MovePageDown(bool shift, bool goToLastChar) { }

	[Address(RVA = "0x2ED0360", Offset = "0x2ECF760", Length = "0xB")]
	[Token(Token = "0x60003A4")]
	private void MovePageDown(bool shift) { }

	[Address(RVA = "0x2ED07E0", Offset = "0x2ECFBE0", Length = "0xB")]
	[Token(Token = "0x60003A2")]
	private void MovePageUp(bool shift) { }

	[Address(RVA = "0x2ED0370", Offset = "0x2ECF770", Length = "0x461")]
	[Token(Token = "0x60003A3")]
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x2ED07F0", Offset = "0x2ECFBF0", Length = "0x865")]
	[Token(Token = "0x6000397")]
	private void MoveRight(bool shift, bool ctrl) { }

	[Address(RVA = "0x2ED1060", Offset = "0x2ED0460", Length = "0x1E7")]
	[Token(Token = "0x600037D")]
	public void MoveTextEnd(bool shift) { }

	[Address(RVA = "0x2ED1250", Offset = "0x2ED0650", Length = "0x159")]
	[Token(Token = "0x600037E")]
	public void MoveTextStart(bool shift) { }

	[Address(RVA = "0x2ED13B0", Offset = "0x2ED07B0", Length = "0x288")]
	[Token(Token = "0x600037F")]
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	[Address(RVA = "0x2ED1640", Offset = "0x2ED0A40", Length = "0x2D4")]
	[Token(Token = "0x6000380")]
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	[Address(RVA = "0x2ED1930", Offset = "0x2ED0D30", Length = "0x290")]
	[Token(Token = "0x60003A1")]
	private void MoveUp(bool shift, bool goToFirstChar) { }

	[Address(RVA = "0x2ED1920", Offset = "0x2ED0D20", Length = "0xB")]
	[Token(Token = "0x60003A0")]
	private void MoveUp(bool shift) { }

	[Address(RVA = "0x2ED1BD0", Offset = "0x2ED0FD0", Length = "0x202")]
	[Token(Token = "0x6000377")]
	private void ON_TEXT_CHANGED(object obj) { }

	[Address(RVA = "0x2ED1DE0", Offset = "0x2ED11E0", Length = "0x22")]
	[Token(Token = "0x600038A")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x2ED1E10", Offset = "0x2ED1210", Length = "0x90")]
	[Token(Token = "0x60003D7")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003D2")]
	public void OnControlClick() { }

	[Address(RVA = "0x2ED1EB0", Offset = "0x2ED12B0", Length = "0x73")]
	[Token(Token = "0x60003D5")]
	public virtual void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x2ED1F30", Offset = "0x2ED1330", Length = "0x366")]
	[Token(Token = "0x6000376")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2ED22A0", Offset = "0x2ED16A0", Length = "0x4C4")]
	[Token(Token = "0x600038B")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x2ED2770", Offset = "0x2ED1B70", Length = "0x89F")]
	[Token(Token = "0x6000375")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2ED3010", Offset = "0x2ED2410", Length = "0x22")]
	[Token(Token = "0x600038D")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x2ED3040", Offset = "0x2ED2440", Length = "0x2C7")]
	[Token(Token = "0x60003C8")]
	private void OnFillVBO(Mesh vbo) { }

	[Address(RVA = "0x2ED3310", Offset = "0x2ED2710", Length = "0x11")]
	[Token(Token = "0x600037B")]
	protected void OnFocus() { }

	[Address(RVA = "0x2ED3330", Offset = "0x2ED2730", Length = "0x12")]
	[Token(Token = "0x60003D8")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x2ED3350", Offset = "0x2ED2750", Length = "0x27")]
	[Token(Token = "0x60003D1")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x2ED3380", Offset = "0x2ED2780", Length = "0x98C")]
	[Token(Token = "0x600038E")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x2ED3D10", Offset = "0x2ED3110", Length = "0x24D")]
	[Token(Token = "0x6000393")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x2ED3F60", Offset = "0x2ED3360", Length = "0x3D")]
	[Token(Token = "0x60003B8")]
	private void OnScrollbarValueChange(float value) { }

	[Address(RVA = "0x2ED3FA0", Offset = "0x2ED33A0", Length = "0x80")]
	[Token(Token = "0x60003D0")]
	public virtual void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x2ED4020", Offset = "0x2ED3420", Length = "0xC8")]
	[Token(Token = "0x60003D6")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x2ED40F0", Offset = "0x2ED34F0", Length = "0x203")]
	[Token(Token = "0x6000392")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0x2ED4300", Offset = "0x2ED3700", Length = "0x44B")]
	[Token(Token = "0x600039D")]
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	[Address(RVA = "0x2ED4750", Offset = "0x2ED3B50", Length = "0x3D4")]
	[Token(Token = "0x600039C")]
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	[Address(RVA = "0x2ED4B30", Offset = "0x2ED3F30", Length = "0x8")]
	[Token(Token = "0x6000391")]
	public void ProcessEvent(Event e) { }

	[Address(RVA = "0x2ED4B40", Offset = "0x2ED3F40", Length = "0xC7")]
	[Token(Token = "0x60003C3")]
	public override void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x2ED4C10", Offset = "0x2ED4010", Length = "0xB5")]
	[Token(Token = "0x60003D3")]
	public void ReleaseSelection() { }

	[Address(RVA = "0x2ED4CD0", Offset = "0x2ED40D0", Length = "0x76")]
	[Token(Token = "0x600037C")]
	protected void SelectAll() { }

	[Address(RVA = "0x2ED4D50", Offset = "0x2ED4150", Length = "0x54")]
	[Token(Token = "0x60003AF")]
	protected void SendOnEndEdit() { }

	[Address(RVA = "0x2ED4DB0", Offset = "0x2ED41B0", Length = "0x100")]
	[Token(Token = "0x60003B4")]
	protected void SendOnEndTextSelection() { }

	[Address(RVA = "0x2ED4F20", Offset = "0x2ED4320", Length = "0x54")]
	[Token(Token = "0x60003B1")]
	protected void SendOnFocus() { }

	[Address(RVA = "0x2ED4EC0", Offset = "0x2ED42C0", Length = "0x54")]
	[Token(Token = "0x60003B2")]
	protected void SendOnFocusLost() { }

	[Address(RVA = "0x2ED4F80", Offset = "0x2ED4380", Length = "0x54")]
	[Token(Token = "0x60003B0")]
	protected void SendOnSubmit() { }

	[Address(RVA = "0x2ED4FE0", Offset = "0x2ED43E0", Length = "0xF7")]
	[Token(Token = "0x60003B3")]
	protected void SendOnTextSelection() { }

	[Address(RVA = "0x2ED5140", Offset = "0x2ED4540", Length = "0x54")]
	[Token(Token = "0x60003AE")]
	private void SendOnValueChanged() { }

	[Address(RVA = "0x2ED50E0", Offset = "0x2ED44E0", Length = "0x5B")]
	[Token(Token = "0x60003AD")]
	private void SendOnValueChangedAndUpdateLabel() { }

	[Address(RVA = "0x2ED51A0", Offset = "0x2ED45A0", Length = "0x6F")]
	[Token(Token = "0x60003B5")]
	protected void SendTouchScreenKeyboardStatusChanged() { }

	[Address(RVA = "0x2ED7EC0", Offset = "0x2ED72C0", Length = "0x5B")]
	[Token(Token = "0x600035B")]
	public void set_asteriskChar(char value) { }

	[Address(RVA = "0x2ED7F20", Offset = "0x2ED7320", Length = "0x65")]
	[Token(Token = "0x6000311")]
	public void set_caretBlinkRate(float value) { }

	[Address(RVA = "0x2ED7F90", Offset = "0x2ED7390", Length = "0x6F")]
	[Token(Token = "0x600031F")]
	public void set_caretColor(Color value) { }

	[Address(RVA = "0x2ED8020", Offset = "0x2ED7420", Length = "0x9F")]
	[Token(Token = "0x600036A")]
	public void set_caretPosition(int value) { }

	[Address(RVA = "0x2ED8000", Offset = "0x2ED7400", Length = "0x15")]
	[Token(Token = "0x6000361")]
	protected void set_caretPositionInternal(int value) { }

	[Address(RVA = "0x2ED80C0", Offset = "0x2ED74C0", Length = "0x15")]
	[Token(Token = "0x6000365")]
	protected void set_caretSelectPositionInternal(int value) { }

	[Address(RVA = "0x2ED80E0", Offset = "0x2ED74E0", Length = "0x8A")]
	[Token(Token = "0x6000313")]
	public void set_caretWidth(int value) { }

	[Address(RVA = "0x2ED8170", Offset = "0x2ED7570", Length = "0xA1")]
	[Token(Token = "0x6000337")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x2ED8220", Offset = "0x2ED7620", Length = "0x68")]
	[Token(Token = "0x6000352")]
	public void set_characterValidation(CharacterValidation value) { }

	[Address(RVA = "0x2ED8290", Offset = "0x2ED7690", Length = "0x49")]
	[Token(Token = "0x6000382")]
	private static void set_clipboard(string value) { }

	[Address(RVA = "0x2ED82E0", Offset = "0x2ED76E0", Length = "0x210")]
	[Token(Token = "0x6000347")]
	public void set_contentType(ContentType value) { }

	[Address(RVA = "0x2ED8520", Offset = "0x2ED7920", Length = "0x5D")]
	[Token(Token = "0x6000321")]
	public void set_customCaretColor(bool value) { }

	[Address(RVA = "0x2ED8580", Offset = "0x2ED7980", Length = "0x134")]
	[Token(Token = "0x600033B")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x2ED86C0", Offset = "0x2ED7AC0", Length = "0x68")]
	[Token(Token = "0x600034D")]
	public void set_inputType(InputType value) { }

	[Address(RVA = "0x2ED8730", Offset = "0x2ED7B30", Length = "0x6A")]
	[Token(Token = "0x6000354")]
	public void set_inputValidator(TMP_InputValidator value) { }

	[Address(RVA = "0x2ED87A0", Offset = "0x2ED7BA0", Length = "0x7")]
	[Token(Token = "0x6000345")]
	public void set_isRichTextEditingAllowed(bool value) { }

	[Address(RVA = "0x2ED87B0", Offset = "0x2ED7BB0", Length = "0x7")]
	[Token(Token = "0x6000341")]
	public void set_keepTextSelectionVisible(bool value) { }

	[Address(RVA = "0x2ED87C0", Offset = "0x2ED7BC0", Length = "0x68")]
	[Token(Token = "0x6000350")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Address(RVA = "0x2ED8830", Offset = "0x2ED7C30", Length = "0x68")]
	[Token(Token = "0x600034B")]
	public void set_lineLimit(int value) { }

	[Address(RVA = "0x2ED88A0", Offset = "0x2ED7CA0", Length = "0xD7")]
	[Token(Token = "0x6000349")]
	public void set_lineType(LineType value) { }

	[Address(RVA = "0x2ED8980", Offset = "0x2ED7D80", Length = "0x4C")]
	[Token(Token = "0x600032B")]
	public void set_onDeselect(SelectionEvent value) { }

	[Address(RVA = "0x2ED89D0", Offset = "0x2ED7DD0", Length = "0x4C")]
	[Token(Token = "0x6000325")]
	public void set_onEndEdit(SubmitEvent value) { }

	[Address(RVA = "0x2ED8A20", Offset = "0x2ED7E20", Length = "0x4C")]
	[Token(Token = "0x600032F")]
	public void set_onEndTextSelection(TextSelectionEvent value) { }

	[Address(RVA = "0x2ED8A70", Offset = "0x2ED7E70", Length = "0x7")]
	[Token(Token = "0x600033D")]
	public void set_onFocusSelectAll(bool value) { }

	[Address(RVA = "0x2ED8A80", Offset = "0x2ED7E80", Length = "0x4C")]
	[Token(Token = "0x6000329")]
	public void set_onSelect(SelectionEvent value) { }

	[Address(RVA = "0x2ED8AD0", Offset = "0x2ED7ED0", Length = "0x4C")]
	[Token(Token = "0x6000327")]
	public void set_onSubmit(SubmitEvent value) { }

	[Address(RVA = "0x2ED8B20", Offset = "0x2ED7F20", Length = "0x4C")]
	[Token(Token = "0x600032D")]
	public void set_onTextSelection(TextSelectionEvent value) { }

	[Address(RVA = "0x2ED8B70", Offset = "0x2ED7F70", Length = "0x4C")]
	[Token(Token = "0x6000333")]
	public void set_onTouchScreenKeyboardStatusChanged(TouchScreenKeyboardEvent value) { }

	[Address(RVA = "0x2ED8BC0", Offset = "0x2ED7FC0", Length = "0x4C")]
	[Token(Token = "0x6000335")]
	public void set_onValidateInput(OnValidateInput value) { }

	[Address(RVA = "0x2ED8C10", Offset = "0x2ED8010", Length = "0x4C")]
	[Token(Token = "0x6000331")]
	public void set_onValueChanged(OnChangeEvent value) { }

	[Address(RVA = "0x2ED8C60", Offset = "0x2ED8060", Length = "0x4C")]
	[Token(Token = "0x6000319")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x2ED8CB0", Offset = "0x2ED80B0", Length = "0x165")]
	[Token(Token = "0x6000339")]
	public void set_pointSize(float value) { }

	[Address(RVA = "0x1D4B2F0", Offset = "0x1D4A6F0", Length = "0x7")]
	[Token(Token = "0x6000356")]
	public void set_readOnly(bool value) { }

	[Address(RVA = "0x2ED8E20", Offset = "0x2ED8220", Length = "0x7")]
	[Token(Token = "0x600033F")]
	public void set_resetOnDeActivation(bool value) { }

	[Address(RVA = "0x2ED8E30", Offset = "0x2ED8230", Length = "0x7")]
	[Token(Token = "0x6000343")]
	public void set_restoreOriginalTextOnEscape(bool value) { }

	[Address(RVA = "0x2ED8E40", Offset = "0x2ED8240", Length = "0x87")]
	[Token(Token = "0x6000358")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x2ED8ED0", Offset = "0x2ED82D0", Length = "0x8D")]
	[Token(Token = "0x600031D")]
	public void set_scrollSensitivity(float value) { }

	[Address(RVA = "0x2ED8F60", Offset = "0x2ED8360", Length = "0x59")]
	[Token(Token = "0x600036C")]
	public void set_selectionAnchorPosition(int value) { }

	[Address(RVA = "0x2ED8FC0", Offset = "0x2ED83C0", Length = "0x6F")]
	[Token(Token = "0x6000323")]
	public void set_selectionColor(Color value) { }

	[Address(RVA = "0x2ED9030", Offset = "0x2ED8430", Length = "0x59")]
	[Token(Token = "0x600036E")]
	public void set_selectionFocusPosition(int value) { }

	[Address(RVA = "0x2ED9090", Offset = "0x2ED8490", Length = "0x82")]
	[Token(Token = "0x6000372")]
	public void set_selectionStringAnchorPosition(int value) { }

	[Address(RVA = "0x2ED9120", Offset = "0x2ED8520", Length = "0x82")]
	[Token(Token = "0x6000374")]
	public void set_selectionStringFocusPosition(int value) { }

	[Address(RVA = "0x2ED91B0", Offset = "0x2ED85B0", Length = "0x7")]
	[Token(Token = "0x6000303")]
	public override void set_shouldActivateOnSelect(bool value) { }

	[Address(RVA = "0x2ED91C0", Offset = "0x2ED85C0", Length = "0xA0")]
	[Token(Token = "0x6000306")]
	public void set_shouldHideMobileInput(bool value) { }

	[Address(RVA = "0x2ED9260", Offset = "0x2ED8660", Length = "0x144")]
	[Token(Token = "0x6000308")]
	public void set_shouldHideSoftKeyboard(bool value) { }

	[Address(RVA = "0x2ED9400", Offset = "0x2ED8800", Length = "0xD9")]
	[Token(Token = "0x6000370")]
	public void set_stringPosition(int value) { }

	[Address(RVA = "0x2ED93B0", Offset = "0x2ED87B0", Length = "0x46")]
	[Token(Token = "0x6000363")]
	protected void set_stringPositionInternal(int value) { }

	[Address(RVA = "0x2ED94E0", Offset = "0x2ED88E0", Length = "0x46")]
	[Token(Token = "0x6000367")]
	protected void set_stringSelectPositionInternal(int value) { }

	[Address(RVA = "0x2ED95E0", Offset = "0x2ED89E0", Length = "0xB")]
	[Token(Token = "0x600030C")]
	public void set_text(string value) { }

	[Address(RVA = "0x2ED9530", Offset = "0x2ED8930", Length = "0x5B")]
	[Token(Token = "0x6000317")]
	public void set_textComponent(TMP_Text value) { }

	[Address(RVA = "0x2ED9590", Offset = "0x2ED8990", Length = "0x4C")]
	[Token(Token = "0x6000315")]
	public void set_textViewport(RectTransform value) { }

	[Address(RVA = "0x2ED95F0", Offset = "0x2ED89F0", Length = "0x19D")]
	[Token(Token = "0x600031B")]
	public void set_verticalScrollbar(Scrollbar value) { }

	[Address(RVA = "0x2ED5210", Offset = "0x2ED4610", Length = "0xC3")]
	[Token(Token = "0x600037A")]
	private void SetCaretActive() { }

	[Address(RVA = "0x2ED52E0", Offset = "0x2ED46E0", Length = "0x3D")]
	[Token(Token = "0x6000379")]
	private void SetCaretVisible() { }

	[Address(RVA = "0x2ED5320", Offset = "0x2ED4720", Length = "0xE7")]
	[Token(Token = "0x60003EA")]
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2ED5410", Offset = "0x2ED4810", Length = "0xE8")]
	[Token(Token = "0x60003E9")]
	public void SetGlobalPointSize(float pointSize) { }

	[Address(RVA = "0x2ED5650", Offset = "0x2ED4A50", Length = "0x16C")]
	[Token(Token = "0x600030E")]
	private void SetText(string value, bool sendCallback = true) { }

	[Address(RVA = "0x2ED5500", Offset = "0x2ED4900", Length = "0x81")]
	[Token(Token = "0x60003DB")]
	private void SetTextComponentRichTextMode() { }

	[Address(RVA = "0x2ED5590", Offset = "0x2ED4990", Length = "0xAD")]
	[Token(Token = "0x60003DA")]
	private void SetTextComponentWrapMode() { }

	[Address(RVA = "0x2ED5640", Offset = "0x2ED4A40", Length = "0xB")]
	[Token(Token = "0x600030D")]
	public void SetTextWithoutNotify(string input) { }

	[Address(RVA = "0x2ED5830", Offset = "0x2ED4C30", Length = "0x17")]
	[Token(Token = "0x60003DD")]
	private void SetToCustom() { }

	[Address(RVA = "0x2ED5830", Offset = "0x2ED4C30", Length = "0x17")]
	[Token(Token = "0x60003DE")]
	private void SetToCustom(CharacterValidation characterValidation) { }

	[Address(RVA = "0x2ED57C0", Offset = "0x2ED4BC0", Length = "0x6E")]
	[Token(Token = "0x60003DC")]
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	[Address(RVA = "0x2ED5850", Offset = "0x2ED4C50", Length = "0x97")]
	[Token(Token = "0x6000385")]
	private bool TouchScreenKeyboardShouldBeUsed() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x60003EC")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x2ED58F0", Offset = "0x2ED4CF0", Length = "0xC3")]
	[Token(Token = "0x60003C0")]
	private void UpdateCaretPositionFromStringIndex() { }

	[Address(RVA = "0x2ED59C0", Offset = "0x2ED4DC0", Length = "0xBF")]
	[Token(Token = "0x60003C6")]
	private void UpdateGeometry() { }

	[Address(RVA = "0x2ED5A80", Offset = "0x2ED4E80", Length = "0x1C0")]
	[Token(Token = "0x6000386")]
	private void UpdateKeyboardStringPosition() { }

	[Address(RVA = "0x2ED5C50", Offset = "0x2ED5050", Length = "0x595")]
	[Token(Token = "0x60003B6")]
	protected void UpdateLabel() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003B9")]
	private void UpdateMaskRegions() { }

	[Address(RVA = "0x2ED61F0", Offset = "0x2ED55F0", Length = "0x114")]
	[Token(Token = "0x60003B7")]
	private void UpdateScrollbar() { }

	[Address(RVA = "0x2ED6310", Offset = "0x2ED5710", Length = "0xC5")]
	[Token(Token = "0x60003BF")]
	private void UpdateStringIndexFromCaretPosition() { }

	[Address(RVA = "0x2ED63E0", Offset = "0x2ED57E0", Length = "0x1F3")]
	[Token(Token = "0x6000387")]
	private void UpdateStringPositionFromKeyboard() { }

	[Address(RVA = "0x2ED65E0", Offset = "0x2ED59E0", Length = "0x49")]
	[Token(Token = "0x60003AC")]
	private void UpdateTouchKeyboardFromEditChanges() { }

	[Address(RVA = "0x2ED6630", Offset = "0x2ED5A30", Length = "0x8D4")]
	[Token(Token = "0x60003CD")]
	protected char Validate(string text, int pos, char ch) { }

}

