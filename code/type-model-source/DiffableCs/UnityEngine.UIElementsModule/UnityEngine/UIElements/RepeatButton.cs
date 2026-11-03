namespace UnityEngine.UIElements;

[Token(Token = "0x200013C")]
public class RepeatButton : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200013D")]
	internal class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{

		[Address(RVA = "0x33A8140", Offset = "0x33A7540", Length = "0x39")]
		[Token(Token = "0x60009A5")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200013E")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000612")]
		private UxmlLongAttributeDescription m_Delay; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000613")]
		private UxmlLongAttributeDescription m_Interval; //Field offset: 0xD8

		[Address(RVA = "0x33AB8A0", Offset = "0x33AACA0", Length = "0xEE")]
		[Token(Token = "0x60009A7")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A8670", Offset = "0x33A7A70", Length = "0x1A6")]
		[Token(Token = "0x60009A6")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000611")]
	public static readonly string ussClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x400060F")]
	private Clickable m_Clickable; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x4000610")]
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x3D8

	[Token(Token = "0x170001A0")]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x3398220", Offset = "0x3397620", Length = "0x28")]
		[Token(Token = "0x600099F")]
		internal set { } //Length: 40
	}

	[Address(RVA = "0x3398050", Offset = "0x3397450", Length = "0x62")]
	[Token(Token = "0x60009A4")]
	private static RepeatButton() { }

	[Address(RVA = "0x3398190", Offset = "0x3397590", Length = "0x89")]
	[Token(Token = "0x60009A0")]
	public RepeatButton() { }

	[Address(RVA = "0x33980C0", Offset = "0x33974C0", Length = "0xC9")]
	[Token(Token = "0x60009A1")]
	public RepeatButton(Action clickEvent, long delay, long interval) { }

	[Address(RVA = "0x3397F60", Offset = "0x3397360", Length = "0x21")]
	[Token(Token = "0x60009A3")]
	internal void AddAction(Action clickEvent) { }

	[Address(RVA = "0x3398220", Offset = "0x3397620", Length = "0x28")]
	[Token(Token = "0x600099F")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x3397F90", Offset = "0x3397390", Length = "0xBF")]
	[Token(Token = "0x60009A2")]
	public void SetAction(Action clickEvent, long delay, long interval) { }

}

