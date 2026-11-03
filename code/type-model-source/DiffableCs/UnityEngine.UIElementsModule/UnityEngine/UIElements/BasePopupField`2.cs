namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200007D")]
public abstract class BasePopupField : BaseField<TValueType>
{
	[CompilerGenerated]
	[Token(Token = "0x200007F")]
	private sealed class <>c
	{
		[Token(Token = "0x40002A6")]
		public static readonly <>c<TValueType, TValueChoice> <>9; //Field offset: 0x0
		[Token(Token = "0x40002A7")]
		public static EventCallback<MouseDownEvent> <>9__28_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000498")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000499")]
		public <>c() { }

		[Address(RVA = "0xA41700", Offset = "0xA40B00", Length = "0x4D")]
		[Token(Token = "0x600049A")]
		internal void <.ctor>b__28_0(MouseDownEvent e) { }

	}

	[Token(Token = "0x200007E")]
	private class PopupTextElement : TextElement
	{

		[Address(RVA = "0xE2BB60", Offset = "0xE2AF60", Length = "0x49")]
		[Token(Token = "0x6000497")]
		public PopupTextElement() { }

		[Address(RVA = "0xE2BA50", Offset = "0xE2AE50", Length = "0xBD")]
		[Token(Token = "0x6000496")]
		protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	}

	[Token(Token = "0x4000296")]
	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	[Token(Token = "0x4000297")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x40002A1")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40002A2")]
	public static readonly string textUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002A3")]
	public static readonly string arrowUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002A4")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002A5")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000298")]
	internal List<TValueChoice> m_Choices; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000299")]
	private TextElement m_TextElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029A")]
	private VisualElement m_ArrowElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029B")]
	private IVisualElementScheduledItem m_ScheduledShowMenuItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029C")]
	internal Func<TValueChoice, String> m_FormatSelectedValueCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029D")]
	internal Func<TValueChoice, String> m_FormatListItemCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029E")]
	internal Func<AbstractGenericMenu> createMenuCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029F")]
	internal AbstractGenericMenu m_GenericMenu; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A0")]
	internal bool m_AutoCloseMenu; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x170000AC")]
	public override List<TValueChoice> choices
	{
		[Address(RVA = "0x169F0B0", Offset = "0x169E4B0", Length = "0xA")]
		[Token(Token = "0x6000488")]
		 get { } //Length: 10
		[Address(RVA = "0x169F150", Offset = "0x169E550", Length = "0x106")]
		[Token(Token = "0x6000489")]
		 set { } //Length: 262
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000AD")]
	public string text
	{
		[Address(RVA = "0x169F0D0", Offset = "0x169E4D0", Length = "0x2D")]
		[Token(Token = "0x600048B")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000AB")]
	protected TextElement textElement
	{
		[Address(RVA = "0x169F0C0", Offset = "0x169E4C0", Length = "0xA")]
		[Token(Token = "0x6000484")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x169DA20", Offset = "0x169CE20", Length = "0x789")]
	[Token(Token = "0x6000495")]
	private static BasePopupField`2() { }

	[Address(RVA = "0x169E9E0", Offset = "0x169DDE0", Length = "0x6C5")]
	[Token(Token = "0x600048C")]
	internal BasePopupField`2(string label) { }

	[Token(Token = "0x6000487")]
	internal abstract void AddMenuItems(AbstractGenericMenu menu) { }

	[Address(RVA = "0x169C570", Offset = "0x169B970", Length = "0x83")]
	[Token(Token = "0x6000490")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x169F0B0", Offset = "0x169E4B0", Length = "0xA")]
	[Token(Token = "0x6000488")]
	public override List<TValueChoice> get_choices() { }

	[Address(RVA = "0x169F0D0", Offset = "0x169E4D0", Length = "0x2D")]
	[Token(Token = "0x600048B")]
	public string get_text() { }

	[Address(RVA = "0x169F0C0", Offset = "0x169E4C0", Length = "0xA")]
	[Token(Token = "0x6000484")]
	protected TextElement get_textElement() { }

	[Token(Token = "0x6000486")]
	internal abstract string GetListItemToDisplay(TValueType item) { }

	[Token(Token = "0x6000485")]
	internal abstract string GetValueToDisplay() { }

	[Address(RVA = "0x169C640", Offset = "0x169BA40", Length = "0x12C")]
	[Token(Token = "0x6000492")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x169C770", Offset = "0x169BB70", Length = "0x17")]
	[Token(Token = "0x600048D")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x169C7B0", Offset = "0x169BBB0", Length = "0x89")]
	[Token(Token = "0x600048F")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x169C970", Offset = "0x169BD70", Length = "0xCC")]
	[Token(Token = "0x600048E")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x6996C0", Offset = "0x698AC0", Length = "0x12E")]
	[Token(Token = "0x6000491")]
	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	[Address(RVA = "0x169F150", Offset = "0x169E550", Length = "0x106")]
	[Token(Token = "0x6000489")]
	public override void set_choices(List<TValueChoice> value) { }

	[Address(RVA = "0x169CBA0", Offset = "0x169BFA0", Length = "0xA0")]
	[Token(Token = "0x600048A")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x169CE40", Offset = "0x169C240", Length = "0x102")]
	[Token(Token = "0x6000493")]
	internal void ShowMenu() { }

	[Address(RVA = "0x169CF50", Offset = "0x169C350", Length = "0x15C")]
	[Token(Token = "0x6000494")]
	protected virtual void UpdateMixedValueContent() { }

}

