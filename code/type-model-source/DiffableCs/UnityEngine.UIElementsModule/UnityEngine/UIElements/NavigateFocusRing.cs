namespace UnityEngine.UIElements;

[Token(Token = "0x200026E")]
internal class NavigateFocusRing : IFocusRing
{
	[Token(Token = "0x200026F")]
	internal class ChangeDirection : FocusChangeDirection
	{

		[Address(RVA = "0x33E1AF0", Offset = "0x33E0EF0", Length = "0x58")]
		[Token(Token = "0x60010FB")]
		public ChangeDirection(int i) { }

	}

	[Token(Token = "0x2000270")]
	private struct FocusableHierarchyTraversal
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400098B")]
		public VisualElement root; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400098C")]
		public VisualElement currentFocusable; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400098D")]
		public Rect validRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400098E")]
		public bool firstPass; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400098F")]
		public ChangeDirection direction; //Field offset: 0x28

		[Address(RVA = "0x33E6CC0", Offset = "0x33E60C0", Length = "0x116")]
		[Token(Token = "0x6001102")]
		public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) { }

		[Address(RVA = "0x33E6DE0", Offset = "0x33E61E0", Length = "0x118")]
		[Token(Token = "0x60010FE")]
		private int Order(VisualElement a, VisualElement b) { }

		[Address(RVA = "0x33E6F00", Offset = "0x33E6300", Length = "0xE7")]
		[Token(Token = "0x60010FF")]
		private int StrictOrder(VisualElement a, VisualElement b) { }

		[Address(RVA = "0x33E6FF0", Offset = "0x33E63F0", Length = "0x238")]
		[Token(Token = "0x6001100")]
		private int StrictOrder(Rect ra, Rect rb) { }

		[Address(RVA = "0x33E7230", Offset = "0x33E6630", Length = "0x19A")]
		[Token(Token = "0x6001101")]
		private int TieBreaker(Rect ra, Rect rb) { }

		[Address(RVA = "0x33E73D0", Offset = "0x33E67D0", Length = "0x205")]
		[Token(Token = "0x60010FD")]
		private bool ValidateElement(VisualElement v) { }

		[Address(RVA = "0x33E75E0", Offset = "0x33E69E0", Length = "0x227")]
		[Token(Token = "0x60010FC")]
		private bool ValidateHierarchyTraversal(VisualElement v) { }

	}

	[Token(Token = "0x4000983")]
	public static readonly ChangeDirection Left; //Field offset: 0x0
	[Token(Token = "0x4000984")]
	public static readonly ChangeDirection Right; //Field offset: 0x8
	[Token(Token = "0x4000985")]
	public static readonly ChangeDirection Up; //Field offset: 0x10
	[Token(Token = "0x4000986")]
	public static readonly ChangeDirection Down; //Field offset: 0x18
	[Token(Token = "0x4000987")]
	public static readonly FocusChangeDirection Next; //Field offset: 0x20
	[Token(Token = "0x4000988")]
	public static readonly FocusChangeDirection Previous; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000989")]
	private readonly VisualElement m_Root; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400098A")]
	private readonly VisualElementFocusRing m_Ring; //Field offset: 0x18

	[Token(Token = "0x1700032C")]
	private FocusController focusController
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x60010F2")]
		private get { } //Length: 42
	}

	[Address(RVA = "0x33EF0A0", Offset = "0x33EE4A0", Length = "0x31D")]
	[Token(Token = "0x60010FA")]
	private static NavigateFocusRing() { }

	[Address(RVA = "0x33EF3C0", Offset = "0x33EE7C0", Length = "0x8A")]
	[Token(Token = "0x60010F3")]
	public NavigateFocusRing(VisualElement root) { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x60010F2")]
	private FocusController get_focusController() { }

	[Address(RVA = "0x33EDDE0", Offset = "0x33ED1E0", Length = "0x31C")]
	[Token(Token = "0x60010F4")]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x33EEAB0", Offset = "0x33EDEB0", Length = "0x43B")]
	[Token(Token = "0x60010F5")]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x33EE2A0", Offset = "0x33ED6A0", Length = "0x80A")]
	[Token(Token = "0x60010F7")]
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction, VisualElement root) { }

	[Address(RVA = "0x33EEEF0", Offset = "0x33EE2F0", Length = "0x6F")]
	[Token(Token = "0x60010F8")]
	private static bool IsActive(VisualElement v) { }

	[Address(RVA = "0x33EEF60", Offset = "0x33EE360", Length = "0x4C")]
	[Token(Token = "0x60010F9")]
	private static bool IsNavigable(Focusable focusable) { }

	[Address(RVA = "0x33EEFB0", Offset = "0x33EE3B0", Length = "0xEC")]
	[Token(Token = "0x60010F6")]
	private bool IsWorldSpaceNavigationValid(Focusable currentFocusable, out UIDocument document) { }

}

