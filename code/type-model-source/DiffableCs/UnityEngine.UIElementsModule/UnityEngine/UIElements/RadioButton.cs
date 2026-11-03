namespace UnityEngine.UIElements;

[Token(Token = "0x2000135")]
public class RadioButton : BaseBoolField, IGroupBoxOption
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000136")]
	internal class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{

		[Address(RVA = "0x33A8200", Offset = "0x33A7600", Length = "0x39")]
		[Token(Token = "0x600097C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000137")]
	internal class UxmlTraits : BaseFieldTraits<Boolean, UxmlBoolAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40005F8")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0xA0

		[Address(RVA = "0x33AAB80", Offset = "0x33A9F80", Length = "0xA7")]
		[Token(Token = "0x600097E")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A9170", Offset = "0x33A8570", Length = "0x13D")]
		[Token(Token = "0x600097D")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005F1")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40005F2")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40005F3")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Token(Token = "0x40005F4")]
	public static readonly string checkmarkBackgroundUssClassName; //Field offset: 0x18
	[Token(Token = "0x40005F5")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x20
	[Token(Token = "0x40005F6")]
	public static readonly string textUssClassName; //Field offset: 0x28
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x40005F7")]
	private VisualElement m_CheckmarkBackground; //Field offset: 0x380

	[Token(Token = "0x1700019A")]
	public virtual bool value
	{
		[Address(RVA = "0x3397E60", Offset = "0x3397260", Length = "0x39")]
		[Token(Token = "0x600096F")]
		 get { } //Length: 57
		[Address(RVA = "0x3397EA0", Offset = "0x33972A0", Length = "0xB5")]
		[Token(Token = "0x6000970")]
		 set { } //Length: 181
	}

	[Address(RVA = "0x3397940", Offset = "0x3396D40", Length = "0x21A")]
	[Token(Token = "0x600097B")]
	private static RadioButton() { }

	[Address(RVA = "0x3397B60", Offset = "0x3396F60", Length = "0xA")]
	[Token(Token = "0x6000971")]
	public RadioButton() { }

	[Address(RVA = "0x3397B70", Offset = "0x3396F70", Length = "0x2E5")]
	[Token(Token = "0x6000972")]
	public RadioButton(string label) { }

	[Address(RVA = "0x3397E60", Offset = "0x3397260", Length = "0x39")]
	[Token(Token = "0x600096F")]
	public virtual bool get_value() { }

	[Address(RVA = "0x3397620", Offset = "0x3396A20", Length = "0x7A")]
	[Token(Token = "0x6000975")]
	protected virtual void InitLabel() { }

	[Address(RVA = "0x33976A0", Offset = "0x3396AA0", Length = "0x5A")]
	[Token(Token = "0x6000973")]
	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x3397700", Offset = "0x3396B00", Length = "0x5A")]
	[Token(Token = "0x6000974")]
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x3397EA0", Offset = "0x33972A0", Length = "0xB5")]
	[Token(Token = "0x6000970")]
	public virtual void set_value(bool value) { }

	[Address(RVA = "0x3397760", Offset = "0x3396B60", Length = "0x20")]
	[Token(Token = "0x6000978")]
	public virtual void SetValueWithoutNotify(bool newValue) { }

	[Address(RVA = "0x3397780", Offset = "0x3396B80", Length = "0x44")]
	[Token(Token = "0x6000976")]
	protected virtual void ToggleValue() { }

	[Address(RVA = "0x33977D0", Offset = "0x3396BD0", Length = "0x14")]
	[Token(Token = "0x6000977")]
	private override void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	[Address(RVA = "0x33977F0", Offset = "0x3396BF0", Length = "0xA1")]
	[Token(Token = "0x6000979")]
	private void UpdateCheckmark() { }

	[Address(RVA = "0x33978A0", Offset = "0x3396CA0", Length = "0x9C")]
	[Token(Token = "0x600097A")]
	protected virtual void UpdateMixedValueContent() { }

}

