namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x2000654")]
public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000655")]
	private sealed class <>c
	{
		[Token(Token = "0x40017D6")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3373510", Offset = "0x3372910", Length = "0x67")]
		[Token(Token = "0x6002CF4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002CF5")]
		public <>c() { }

		[Address(RVA = "0x33730B0", Offset = "0x33724B0", Length = "0x6C")]
		[Token(Token = "0x6002CF6")]
		internal PointerOverLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40017D4")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40017D5")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000B61")]
	private string linkID
	{
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002CEE")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B62")]
	private string linkText
	{
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002CEF")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x336BA60", Offset = "0x336AE60", Length = "0xD1")]
	[Token(Token = "0x6002CED")]
	private static PointerOverLinkTagEvent() { }

	[Address(RVA = "0x336BB40", Offset = "0x336AF40", Length = "0x41")]
	[Token(Token = "0x6002CF3")]
	public PointerOverLinkTagEvent() { }

	[Address(RVA = "0x336B980", Offset = "0x336AD80", Length = "0x8F")]
	[Token(Token = "0x6002CF2")]
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x336BA10", Offset = "0x336AE10", Length = "0x41")]
	[Token(Token = "0x6002CF0")]
	protected virtual void Init() { }

	[Address(RVA = "0x336B470", Offset = "0x336A870", Length = "0x8")]
	[Token(Token = "0x6002CF1")]
	private void LocalInit() { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002CEE")]
	private void set_linkID(string value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002CEF")]
	private void set_linkText(string value) { }

}

