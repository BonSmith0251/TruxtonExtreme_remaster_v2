namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeaveWindow (5))]
[Token(Token = "0x2000205")]
public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000206")]
	private sealed class <>c
	{
		[Token(Token = "0x4000880")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF730", Offset = "0x33DEB30", Length = "0x67")]
		[Token(Token = "0x6000E5C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E5D")]
		public <>c() { }

		[Address(RVA = "0x33DDE50", Offset = "0x33DD250", Length = "0x8F")]
		[Token(Token = "0x6000E5E")]
		internal MouseLeaveWindowEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D5A30", Offset = "0x33D4E30", Length = "0xD1")]
	[Token(Token = "0x6000E55")]
	private static MouseLeaveWindowEvent() { }

	[Address(RVA = "0x33D5B10", Offset = "0x33D4F10", Length = "0x64")]
	[Token(Token = "0x6000E58")]
	public MouseLeaveWindowEvent() { }

	[Address(RVA = "0x33D56B0", Offset = "0x33D4AB0", Length = "0x94")]
	[Token(Token = "0x6000E5B")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D5750", Offset = "0x33D4B50", Length = "0x103")]
	[Token(Token = "0x6000E59")]
	public static MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	[Address(RVA = "0x33D5860", Offset = "0x33D4C60", Length = "0x64")]
	[Token(Token = "0x6000E56")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D58D0", Offset = "0x33D4CD0", Length = "0x4D")]
	[Token(Token = "0x6000E57")]
	private void LocalInit() { }

	[Address(RVA = "0x33D5920", Offset = "0x33D4D20", Length = "0x10C")]
	[Token(Token = "0x6000E5A")]
	protected private virtual void PostDispatch(IPanel panel) { }

}

