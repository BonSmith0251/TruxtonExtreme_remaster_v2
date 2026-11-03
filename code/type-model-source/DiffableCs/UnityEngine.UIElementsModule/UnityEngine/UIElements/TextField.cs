namespace UnityEngine.UIElements;

[Token(Token = "0x20000F0")]
public class TextField : TextInputBaseField<String>
{
	[Token(Token = "0x20000F3")]
	private class TextInput : TextInputBase<String>
	{

		[Token(Token = "0x1700011C")]
		public bool multiline
		{
			[Address(RVA = "0x338F650", Offset = "0x338EA50", Length = "0x60")]
			[Token(Token = "0x6000758")]
			 get { } //Length: 96
			[Address(RVA = "0x338F740", Offset = "0x338EB40", Length = "0x23F")]
			[Token(Token = "0x6000759")]
			 set { } //Length: 575
		}

		[Token(Token = "0x1700011B")]
		private TextField parentTextField
		{
			[Address(RVA = "0x338F6C0", Offset = "0x338EAC0", Length = "0x71")]
			[Token(Token = "0x6000757")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x338F5F0", Offset = "0x338E9F0", Length = "0x5A")]
		[Token(Token = "0x600075B")]
		public TextInput() { }

		[Address(RVA = "0x338F650", Offset = "0x338EA50", Length = "0x60")]
		[Token(Token = "0x6000758")]
		public bool get_multiline() { }

		[Address(RVA = "0x338F6C0", Offset = "0x338EAC0", Length = "0x71")]
		[Token(Token = "0x6000757")]
		private TextField get_parentTextField() { }

		[Address(RVA = "0x338F740", Offset = "0x338EB40", Length = "0x23F")]
		[Token(Token = "0x6000759")]
		public void set_multiline(bool value) { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x600075A")]
		protected virtual string StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F1")]
	internal class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
	{

		[Address(RVA = "0x3391220", Offset = "0x3390620", Length = "0x39")]
		[Token(Token = "0x6000753")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F2")]
	internal class UxmlTraits : UxmlTraits<String>
	{
		[Token(Token = "0x4000492")]
		private static readonly UxmlStringAttributeDescription k_Value; //Field offset: 0x0
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4000493")]
		private UxmlBoolAttributeDescription m_Multiline; //Field offset: 0x120

		[Address(RVA = "0x3392060", Offset = "0x3391460", Length = "0x10A")]
		[Token(Token = "0x6000756")]
		private static UxmlTraits() { }

		[Address(RVA = "0x3392180", Offset = "0x3391580", Length = "0xA7")]
		[Token(Token = "0x6000755")]
		public UxmlTraits() { }

		[Address(RVA = "0x3391A40", Offset = "0x3390E40", Length = "0x21D")]
		[Token(Token = "0x6000754")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400048E")]
	internal static readonly BindingId multilineProperty; //Field offset: 0x0
	[Token(Token = "0x400048F")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x4000490")]
	public static readonly string labelUssClassName; //Field offset: 0xA0
	[Token(Token = "0x4000491")]
	public static readonly string inputUssClassName; //Field offset: 0xA8

	[CreateProperty]
	[Token(Token = "0x17000119")]
	public bool multiline
	{
		[Address(RVA = "0x338F290", Offset = "0x338E690", Length = "0x6C")]
		[Token(Token = "0x6000745")]
		 get { } //Length: 108
		[Address(RVA = "0x338F3C0", Offset = "0x338E7C0", Length = "0x175")]
		[Token(Token = "0x6000746")]
		 set { } //Length: 373
	}

	[Token(Token = "0x17000118")]
	private TextInput textInput
	{
		[Address(RVA = "0x338F300", Offset = "0x338E700", Length = "0x7A")]
		[Token(Token = "0x6000744")]
		private get { } //Length: 122
	}

	[Token(Token = "0x1700011A")]
	public virtual string value
	{
		[Address(RVA = "0x338F380", Offset = "0x338E780", Length = "0x39")]
		[Token(Token = "0x600074A")]
		 get { } //Length: 57
		[Address(RVA = "0x338F540", Offset = "0x338E940", Length = "0xAE")]
		[Token(Token = "0x600074B")]
		 set { } //Length: 174
	}

	[Address(RVA = "0x338EDA0", Offset = "0x338E1A0", Length = "0x22C")]
	[Token(Token = "0x6000752")]
	private static TextField() { }

	[Address(RVA = "0x338F260", Offset = "0x338E660", Length = "0x2E")]
	[Token(Token = "0x6000747")]
	public TextField() { }

	[Address(RVA = "0x338F230", Offset = "0x338E630", Length = "0x2C")]
	[Token(Token = "0x6000748")]
	public TextField(string label) { }

	[Address(RVA = "0x338EFD0", Offset = "0x338E3D0", Length = "0x25E")]
	[Token(Token = "0x6000749")]
	public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) { }

	[Address(RVA = "0x338F290", Offset = "0x338E690", Length = "0x6C")]
	[Token(Token = "0x6000745")]
	public bool get_multiline() { }

	[Address(RVA = "0x338F300", Offset = "0x338E700", Length = "0x7A")]
	[Token(Token = "0x6000744")]
	private TextInput get_textInput() { }

	[Address(RVA = "0x338F380", Offset = "0x338E780", Length = "0x39")]
	[Token(Token = "0x600074A")]
	public virtual string get_value() { }

	[Address(RVA = "0x338E910", Offset = "0x338DD10", Length = "0x202")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	[Token(Token = "0x600074E")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x338EB20", Offset = "0x338DF20", Length = "0x8D")]
	[Token(Token = "0x600074F")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x338F3C0", Offset = "0x338E7C0", Length = "0x175")]
	[Token(Token = "0x6000746")]
	public void set_multiline(bool value) { }

	[Address(RVA = "0x338F540", Offset = "0x338E940", Length = "0xAE")]
	[Token(Token = "0x600074B")]
	public virtual void set_value(string value) { }

	[Address(RVA = "0x338EBB0", Offset = "0x338DFB0", Length = "0x183")]
	[Token(Token = "0x600074C")]
	public virtual void SetValueWithoutNotify(string newValue) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000751")]
	protected virtual string StringToValue(string str) { }

	[Address(RVA = "0x338ED40", Offset = "0x338E140", Length = "0x53")]
	[Token(Token = "0x600074D")]
	internal virtual void UpdateTextFromValue() { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000750")]
	protected virtual string ValueToString(string value) { }

}

