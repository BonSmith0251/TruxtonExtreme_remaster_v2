namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerDown (3))]
[Token(Token = "0x2000228")]
public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000229")]
	private sealed class <>c
	{
		[Token(Token = "0x40008DD")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DFE30", Offset = "0x33DF230", Length = "0x67")]
		[Token(Token = "0x6000F3D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F3E")]
		public <>c() { }

		[Address(RVA = "0x33DEE40", Offset = "0x33DE240", Length = "0x8F")]
		[Token(Token = "0x6000F3F")]
		internal PointerDownEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D9170", Offset = "0x33D8570", Length = "0xD1")]
	[Token(Token = "0x6000F35")]
	private static PointerDownEvent() { }

	[Address(RVA = "0x33D9250", Offset = "0x33D8650", Length = "0x64")]
	[Token(Token = "0x6000F38")]
	public PointerDownEvent() { }

	[Address(RVA = "0x33D8DC0", Offset = "0x33D81C0", Length = "0xAD")]
	[Token(Token = "0x6000F3C")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D8E70", Offset = "0x33D8270", Length = "0x9B")]
	[Token(Token = "0x6000F39")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x33D8F10", Offset = "0x33D8310", Length = "0x64")]
	[Token(Token = "0x6000F36")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D8F80", Offset = "0x33D8380", Length = "0x4D")]
	[Token(Token = "0x6000F37")]
	private void LocalInit() { }

	[Address(RVA = "0x33D8FD0", Offset = "0x33D83D0", Length = "0xF9")]
	[Token(Token = "0x6000F3B")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x33D90D0", Offset = "0x33D84D0", Length = "0x97")]
	[Token(Token = "0x6000F3A")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

