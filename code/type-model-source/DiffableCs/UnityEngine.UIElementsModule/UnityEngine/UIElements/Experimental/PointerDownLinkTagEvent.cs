namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x200065A")]
public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200065B")]
	private sealed class <>c
	{
		[Token(Token = "0x40017DD")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3373580", Offset = "0x3372980", Length = "0x67")]
		[Token(Token = "0x6002D10")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002D11")]
		public <>c() { }

		[Address(RVA = "0x3373200", Offset = "0x3372600", Length = "0x6C")]
		[Token(Token = "0x6002D12")]
		internal PointerDownLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40017DB")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40017DC")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000B65")]
	private string linkID
	{
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002D0A")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B66")]
	private string linkText
	{
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002D0B")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x336B480", Offset = "0x336A880", Length = "0xD1")]
	[Token(Token = "0x6002D09")]
	private static PointerDownLinkTagEvent() { }

	[Address(RVA = "0x336B560", Offset = "0x336A960", Length = "0x41")]
	[Token(Token = "0x6002D0F")]
	public PointerDownLinkTagEvent() { }

	[Address(RVA = "0x336B390", Offset = "0x336A790", Length = "0x8F")]
	[Token(Token = "0x6002D0E")]
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x336B420", Offset = "0x336A820", Length = "0x41")]
	[Token(Token = "0x6002D0C")]
	protected virtual void Init() { }

	[Address(RVA = "0x336B470", Offset = "0x336A870", Length = "0x8")]
	[Token(Token = "0x6002D0D")]
	private void LocalInit() { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002D0A")]
	private void set_linkID(string value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002D0B")]
	private void set_linkText(string value) { }

}

