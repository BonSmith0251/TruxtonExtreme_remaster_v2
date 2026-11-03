namespace UnityEngine.UIElements;

[Token(Token = "0x20000D9")]
public class GroupBox : BindableElement, IGroupBox
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DA")]
	internal class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
	{

		[Address(RVA = "0x3391360", Offset = "0x3390760", Length = "0x39")]
		[Token(Token = "0x60006BE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DB")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400043B")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90

		[Address(RVA = "0x3392520", Offset = "0x3391920", Length = "0x96")]
		[Token(Token = "0x60006C0")]
		public UxmlTraits() { }

		[Address(RVA = "0x3391F30", Offset = "0x3391330", Length = "0x12E")]
		[Token(Token = "0x60006BF")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000437")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x4000438")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x4000439")]
	public static readonly string labelUssClassName; //Field offset: 0xA0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400043A")]
	private Label m_TitleLabel; //Field offset: 0x2D8

	[CreateProperty]
	[Token(Token = "0x170000FC")]
	public string text
	{
		[Address(RVA = "0x337F260", Offset = "0x337E660", Length = "0x23")]
		[Token(Token = "0x60006B7")]
		 get { } //Length: 35
		[Address(RVA = "0x337F290", Offset = "0x337E690", Length = "0x1F8")]
		[Token(Token = "0x60006B8")]
		 set { } //Length: 504
	}

	[Address(RVA = "0x337EF80", Offset = "0x337E380", Length = "0x1CA")]
	[Token(Token = "0x60006BD")]
	private static GroupBox() { }

	[Address(RVA = "0x337F1E0", Offset = "0x337E5E0", Length = "0x79")]
	[Token(Token = "0x60006B9")]
	public GroupBox() { }

	[Address(RVA = "0x337F150", Offset = "0x337E550", Length = "0x86")]
	[Token(Token = "0x60006BA")]
	public GroupBox(string text) { }

	[Address(RVA = "0x337F260", Offset = "0x337E660", Length = "0x23")]
	[Token(Token = "0x60006B7")]
	public string get_text() { }

	[Address(RVA = "0x337F290", Offset = "0x337E690", Length = "0x1F8")]
	[Token(Token = "0x60006B8")]
	public void set_text(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60006BB")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60006BC")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

}

