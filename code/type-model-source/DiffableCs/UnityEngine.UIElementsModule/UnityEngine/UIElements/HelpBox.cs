namespace UnityEngine.UIElements;

[Token(Token = "0x20000E1")]
public class HelpBox : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000E2")]
	internal class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
	{

		[Address(RVA = "0x33913E0", Offset = "0x33907E0", Length = "0x39")]
		[Token(Token = "0x60006DC")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000E3")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000450")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000451")]
		private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType; //Field offset: 0x90

		[Address(RVA = "0x3392600", Offset = "0x3391A00", Length = "0x11E")]
		[Token(Token = "0x60006DE")]
		public UxmlTraits() { }

		[Address(RVA = "0x3391C60", Offset = "0x3391060", Length = "0x2C6")]
		[Token(Token = "0x60006DD")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000444")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x4000445")]
	internal static readonly BindingId messageTypeProperty; //Field offset: 0x98
	[Token(Token = "0x4000446")]
	public static readonly string ussClassName; //Field offset: 0x130
	[Token(Token = "0x4000447")]
	public static readonly string labelUssClassName; //Field offset: 0x138
	[Token(Token = "0x4000448")]
	public static readonly string iconUssClassName; //Field offset: 0x140
	[Token(Token = "0x4000449")]
	public static readonly string iconInfoUssClassName; //Field offset: 0x148
	[Token(Token = "0x400044A")]
	public static readonly string iconwarningUssClassName; //Field offset: 0x150
	[Token(Token = "0x400044B")]
	public static readonly string iconErrorUssClassName; //Field offset: 0x158
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400044C")]
	private HelpBoxMessageType m_HelpBoxMessageType; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400044D")]
	private VisualElement m_Icon; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400044E")]
	private string m_IconClass; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400044F")]
	private Label m_Label; //Field offset: 0x2E0

	[CreateProperty]
	[Token(Token = "0x17000100")]
	public HelpBoxMessageType messageType
	{
		[Address(RVA = "0x3380AE0", Offset = "0x337FEE0", Length = "0x9")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 9
		[Address(RVA = "0x3380B20", Offset = "0x337FF20", Length = "0x89")]
		[Token(Token = "0x60006D6")]
		 set { } //Length: 137
	}

	[CreateProperty]
	[Token(Token = "0x170000FF")]
	public string text
	{
		[Address(RVA = "0x3380AF0", Offset = "0x337FEF0", Length = "0x2D")]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 45
		[Address(RVA = "0x3380BB0", Offset = "0x337FFB0", Length = "0xF5")]
		[Token(Token = "0x60006D4")]
		 set { } //Length: 245
	}

	[Address(RVA = "0x3380370", Offset = "0x337F770", Length = "0x415")]
	[Token(Token = "0x60006DB")]
	private static HelpBox() { }

	[Address(RVA = "0x3380790", Offset = "0x337FB90", Length = "0x1A3")]
	[Token(Token = "0x60006D7")]
	public HelpBox() { }

	[Address(RVA = "0x3380940", Offset = "0x337FD40", Length = "0x19E")]
	[Token(Token = "0x60006D8")]
	public HelpBox(string text, HelpBoxMessageType messageType) { }

	[Address(RVA = "0x3380AE0", Offset = "0x337FEE0", Length = "0x9")]
	[Token(Token = "0x60006D5")]
	public HelpBoxMessageType get_messageType() { }

	[Address(RVA = "0x3380AF0", Offset = "0x337FEF0", Length = "0x2D")]
	[Token(Token = "0x60006D3")]
	public string get_text() { }

	[Address(RVA = "0x3380100", Offset = "0x337F500", Length = "0xD6")]
	[Token(Token = "0x60006D9")]
	private string GetIconClass(HelpBoxMessageType messageType) { }

	[Address(RVA = "0x3380B20", Offset = "0x337FF20", Length = "0x89")]
	[Token(Token = "0x60006D6")]
	public void set_messageType(HelpBoxMessageType value) { }

	[Address(RVA = "0x3380BB0", Offset = "0x337FFB0", Length = "0xF5")]
	[Token(Token = "0x60006D4")]
	public void set_text(string value) { }

	[Address(RVA = "0x33801E0", Offset = "0x337F5E0", Length = "0x184")]
	[Token(Token = "0x60006DA")]
	private void UpdateIcon(HelpBoxMessageType messageType) { }

}

