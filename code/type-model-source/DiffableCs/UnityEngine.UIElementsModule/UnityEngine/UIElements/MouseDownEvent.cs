namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerDown (3))]
[Token(Token = "0x20001F1")]
public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001F2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000875")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF650", Offset = "0x33DEA50", Length = "0x67")]
		[Token(Token = "0x6000E05")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E06")]
		public <>c() { }

		[Address(RVA = "0x33DDCE0", Offset = "0x33DD0E0", Length = "0x8F")]
		[Token(Token = "0x6000E07")]
		internal MouseDownEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D4D40", Offset = "0x33D4140", Length = "0xD1")]
	[Token(Token = "0x6000DFE")]
	private static MouseDownEvent() { }

	[Address(RVA = "0x33D4E20", Offset = "0x33D4220", Length = "0x64")]
	[Token(Token = "0x6000E01")]
	public MouseDownEvent() { }

	[Address(RVA = "0x33D4B60", Offset = "0x33D3F60", Length = "0x6A")]
	[Token(Token = "0x6000E03")]
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	[Address(RVA = "0x33D4BD0", Offset = "0x33D3FD0", Length = "0x6A")]
	[Token(Token = "0x6000E04")]
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

	[Address(RVA = "0x33D4C40", Offset = "0x33D4040", Length = "0x64")]
	[Token(Token = "0x6000DFF")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D4CB0", Offset = "0x33D40B0", Length = "0x4D")]
	[Token(Token = "0x6000E00")]
	private void LocalInit() { }

	[Address(RVA = "0x33D4D00", Offset = "0x33D4100", Length = "0x39")]
	[Token(Token = "0x6000E02")]
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

