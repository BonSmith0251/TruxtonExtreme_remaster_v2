namespace UnityEngine.UIElements;

[Token(Token = "0x200009F")]
public class Button : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A0")]
	internal class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{

		[Address(RVA = "0x3346D60", Offset = "0x3346160", Length = "0x39")]
		[Token(Token = "0x60005C5")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A1")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000384")]
		private readonly UxmlImageAttributeDescription m_IconImage; //Field offset: 0xD0

		[Address(RVA = "0x334B520", Offset = "0x334A920", Length = "0xB0")]
		[Token(Token = "0x60005C6")]
		public UxmlTraits() { }

		[Address(RVA = "0x3347780", Offset = "0x3346B80", Length = "0x160")]
		[Token(Token = "0x60005C7")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000379")]
	internal static readonly BindingId iconImageProperty; //Field offset: 0x0
	[Token(Token = "0x400037A")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x400037B")]
	public static readonly string iconUssClassName; //Field offset: 0xA0
	[Token(Token = "0x400037C")]
	public static readonly string iconOnlyUssClassName; //Field offset: 0xA8
	[Token(Token = "0x400037D")]
	public static readonly string imageUSSClassName; //Field offset: 0xB0
	[Token(Token = "0x4000383")]
	private static readonly string NonEmptyString; //Field offset: 0xB8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x400037E")]
	private Clickable m_Clickable; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x400037F")]
	private TextElement m_TextElement; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000380")]
	private Image m_ImageElement; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000381")]
	private Background m_IconImage; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x4000382")]
	private string m_Text; //Field offset: 0x408

	[Token(Token = "0x170000E8")]
	public Clickable clickable
	{
		[Address(RVA = "0x333A690", Offset = "0x3339A90", Length = "0xA")]
		[Token(Token = "0x60005B7")]
		 get { } //Length: 10
		[Address(RVA = "0x333A6E0", Offset = "0x3339AE0", Length = "0x7C")]
		[Token(Token = "0x60005B8")]
		 set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x170000E9")]
	public Background iconImage
	{
		[Address(RVA = "0x333A6A0", Offset = "0x3339AA0", Length = "0x19")]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 25
		[Address(RVA = "0x333A760", Offset = "0x3339B60", Length = "0x3C6")]
		[Token(Token = "0x60005BA")]
		 set { } //Length: 966
	}

	[Token(Token = "0x170000EA")]
	public virtual string text
	{
		[Address(RVA = "0x333A6C0", Offset = "0x3339AC0", Length = "0x1E")]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 30
		[Address(RVA = "0x333AB30", Offset = "0x3339F30", Length = "0x182")]
		[Token(Token = "0x60005BC")]
		 set { } //Length: 386
	}

	[Address(RVA = "0x3339DD0", Offset = "0x33391D0", Length = "0x2D7")]
	[Token(Token = "0x60005C4")]
	private static Button() { }

	[Address(RVA = "0x333A290", Offset = "0x3339690", Length = "0x1E3")]
	[Token(Token = "0x60005BD")]
	public Button() { }

	[Address(RVA = "0x333A480", Offset = "0x3339880", Length = "0x203")]
	[Token(Token = "0x60005BE")]
	public Button(Background iconImage, Action clickEvent = null) { }

	[Address(RVA = "0x333A0B0", Offset = "0x33394B0", Length = "0x1D3")]
	[Token(Token = "0x60005BF")]
	public Button(Action clickEvent) { }

	[Address(RVA = "0x3339920", Offset = "0x3338D20", Length = "0xDA")]
	[Token(Token = "0x60005C1")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x333A690", Offset = "0x3339A90", Length = "0xA")]
	[Token(Token = "0x60005B7")]
	public Clickable get_clickable() { }

	[Address(RVA = "0x333A6A0", Offset = "0x3339AA0", Length = "0x19")]
	[Token(Token = "0x60005B9")]
	public Background get_iconImage() { }

	[Address(RVA = "0x333A6C0", Offset = "0x3339AC0", Length = "0x1E")]
	[Token(Token = "0x60005BB")]
	public virtual string get_text() { }

	[Address(RVA = "0x3339A00", Offset = "0x3338E00", Length = "0x3C")]
	[Token(Token = "0x60005C0")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x3339A40", Offset = "0x3338E40", Length = "0x12F")]
	[Token(Token = "0x60005C3")]
	private void ResetButtonHierarchy() { }

	[Address(RVA = "0x333A6E0", Offset = "0x3339AE0", Length = "0x7C")]
	[Token(Token = "0x60005B8")]
	public void set_clickable(Clickable value) { }

	[Address(RVA = "0x333A760", Offset = "0x3339B60", Length = "0x3C6")]
	[Token(Token = "0x60005BA")]
	public void set_iconImage(Background value) { }

	[Address(RVA = "0x333AB30", Offset = "0x3339F30", Length = "0x182")]
	[Token(Token = "0x60005BC")]
	public virtual void set_text(string value) { }

	[Address(RVA = "0x3339B70", Offset = "0x3338F70", Length = "0x253")]
	[Token(Token = "0x60005C2")]
	private void UpdateButtonHierarchy() { }

}

