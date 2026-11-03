namespace UnityEngine.UIElements;

[EventCategory(EventCategory::EnterLeave (4))]
[Token(Token = "0x20001FF")]
public class MouseOverEvent : MouseEventBase<MouseOverEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000200")]
	private sealed class <>c
	{
		[Token(Token = "0x400087D")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E0A00", Offset = "0x33DFE00", Length = "0x67")]
		[Token(Token = "0x6000E43")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E44")]
		public <>c() { }

		[Address(RVA = "0x33DE940", Offset = "0x33DDD40", Length = "0x65")]
		[Token(Token = "0x6000E45")]
		internal MouseOverEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D5FF0", Offset = "0x33D53F0", Length = "0xD1")]
	[Token(Token = "0x6000E3F")]
	private static MouseOverEvent() { }

	[Address(RVA = "0x33D60D0", Offset = "0x33D54D0", Length = "0x39")]
	[Token(Token = "0x6000E42")]
	public MouseOverEvent() { }

	[Address(RVA = "0x33D4E90", Offset = "0x33D4290", Length = "0x8")]
	[Token(Token = "0x6000E40")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D5F70", Offset = "0x33D5370", Length = "0x7A")]
	[Token(Token = "0x6000E41")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

