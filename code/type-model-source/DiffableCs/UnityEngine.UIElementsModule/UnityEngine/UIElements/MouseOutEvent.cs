namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x2000201")]
public class MouseOutEvent : MouseEventBase<MouseOutEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000202")]
	private sealed class <>c
	{
		[Token(Token = "0x400087E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E0290", Offset = "0x33DF690", Length = "0x67")]
		[Token(Token = "0x6000E4A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E4B")]
		public <>c() { }

		[Address(RVA = "0x33DE860", Offset = "0x33DDC60", Length = "0x65")]
		[Token(Token = "0x6000E4C")]
		internal MouseOutEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D5E50", Offset = "0x33D5250", Length = "0xD1")]
	[Token(Token = "0x6000E46")]
	private static MouseOutEvent() { }

	[Address(RVA = "0x33D5F30", Offset = "0x33D5330", Length = "0x39")]
	[Token(Token = "0x6000E49")]
	public MouseOutEvent() { }

	[Address(RVA = "0x33D4E90", Offset = "0x33D4290", Length = "0x8")]
	[Token(Token = "0x6000E47")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D5DD0", Offset = "0x33D51D0", Length = "0x7A")]
	[Token(Token = "0x6000E48")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

