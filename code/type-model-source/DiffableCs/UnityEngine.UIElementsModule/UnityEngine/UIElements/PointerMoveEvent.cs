namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerMove (2))]
[Token(Token = "0x200022A")]
public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200022B")]
	private sealed class <>c
	{
		[Token(Token = "0x40008DF")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF9D0", Offset = "0x33DEDD0", Length = "0x67")]
		[Token(Token = "0x6000F4C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F4D")]
		public <>c() { }

		[Address(RVA = "0x33DEDA0", Offset = "0x33DE1A0", Length = "0x96")]
		[Token(Token = "0x6000F4E")]
		internal PointerMoveEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40008DE")]
	private bool <isHandledByDraggable>k__BackingField; //Field offset: 0x100

	[Token(Token = "0x170002D6")]
	internal bool isHandledByDraggable
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F41")]
		internal get { } //Length: 8
		[Address(RVA = "0x33DA460", Offset = "0x33D9860", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F42")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002D7")]
	internal bool isPointerDown
	{
		[Address(RVA = "0x33DA3A0", Offset = "0x33D97A0", Length = "0x5E")]
		[Token(Token = "0x6000F43")]
		internal get { } //Length: 94
	}

	[Token(Token = "0x170002D8")]
	internal bool isPointerUp
	{
		[Address(RVA = "0x33DA400", Offset = "0x33D9800", Length = "0x60")]
		[Token(Token = "0x6000F44")]
		internal get { } //Length: 96
	}

	[Address(RVA = "0x33DA250", Offset = "0x33D9650", Length = "0xD1")]
	[Token(Token = "0x6000F40")]
	private static PointerMoveEvent() { }

	[Address(RVA = "0x33DA330", Offset = "0x33D9730", Length = "0x6B")]
	[Token(Token = "0x6000F47")]
	public PointerMoveEvent() { }

	[Address(RVA = "0x33D9E40", Offset = "0x33D9240", Length = "0xAD")]
	[Token(Token = "0x6000F4B")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F41")]
	internal bool get_isHandledByDraggable() { }

	[Address(RVA = "0x33DA3A0", Offset = "0x33D97A0", Length = "0x5E")]
	[Token(Token = "0x6000F43")]
	internal bool get_isPointerDown() { }

	[Address(RVA = "0x33DA400", Offset = "0x33D9800", Length = "0x60")]
	[Token(Token = "0x6000F44")]
	internal bool get_isPointerUp() { }

	[Address(RVA = "0x33D9EF0", Offset = "0x33D92F0", Length = "0x1B6")]
	[Token(Token = "0x6000F48")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x33DA0B0", Offset = "0x33D94B0", Length = "0x6B")]
	[Token(Token = "0x6000F45")]
	protected virtual void Init() { }

	[Address(RVA = "0x33DA120", Offset = "0x33D9520", Length = "0x40")]
	[Token(Token = "0x6000F46")]
	private void LocalInit() { }

	[Address(RVA = "0x33DA160", Offset = "0x33D9560", Length = "0x9B")]
	[Token(Token = "0x6000F4A")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x33DA200", Offset = "0x33D9600", Length = "0x48")]
	[Token(Token = "0x6000F49")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0x33DA460", Offset = "0x33D9860", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F42")]
	internal void set_isHandledByDraggable(bool value) { }

}

