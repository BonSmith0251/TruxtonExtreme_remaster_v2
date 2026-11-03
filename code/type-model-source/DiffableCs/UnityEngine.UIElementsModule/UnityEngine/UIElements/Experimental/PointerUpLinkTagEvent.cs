namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x200065C")]
public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200065D")]
	private sealed class <>c
	{
		[Token(Token = "0x40017E0")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3373430", Offset = "0x3372830", Length = "0x67")]
		[Token(Token = "0x6002D1A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002D1B")]
		public <>c() { }

		[Address(RVA = "0x3373120", Offset = "0x3372520", Length = "0x6C")]
		[Token(Token = "0x6002D1C")]
		internal PointerUpLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40017DE")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40017DF")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000B67")]
	private string linkID
	{
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002D14")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B68")]
	private string linkText
	{
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002D15")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x336BC70", Offset = "0x336B070", Length = "0xD1")]
	[Token(Token = "0x6002D13")]
	private static PointerUpLinkTagEvent() { }

	[Address(RVA = "0x336BD50", Offset = "0x336B150", Length = "0x41")]
	[Token(Token = "0x6002D19")]
	public PointerUpLinkTagEvent() { }

	[Address(RVA = "0x336BB90", Offset = "0x336AF90", Length = "0x8F")]
	[Token(Token = "0x6002D18")]
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x336BC20", Offset = "0x336B020", Length = "0x41")]
	[Token(Token = "0x6002D16")]
	protected virtual void Init() { }

	[Address(RVA = "0x336B470", Offset = "0x336A870", Length = "0x8")]
	[Token(Token = "0x6002D17")]
	private void LocalInit() { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002D14")]
	private void set_linkID(string value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002D15")]
	private void set_linkText(string value) { }

}

