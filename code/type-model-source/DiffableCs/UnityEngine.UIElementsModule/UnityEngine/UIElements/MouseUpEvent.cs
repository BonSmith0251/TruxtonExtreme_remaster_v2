namespace UnityEngine.UIElements;

[Token(Token = "0x20001F3")]
public class MouseUpEvent : MouseEventBase<MouseUpEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001F4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000876")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E0220", Offset = "0x33DF620", Length = "0x67")]
		[Token(Token = "0x6000E10")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E11")]
		public <>c() { }

		[Address(RVA = "0x33DE580", Offset = "0x33DD980", Length = "0x8F")]
		[Token(Token = "0x6000E12")]
		internal MouseUpEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D6360", Offset = "0x33D5760", Length = "0xD1")]
	[Token(Token = "0x6000E08")]
	private static MouseUpEvent() { }

	[Address(RVA = "0x33D6440", Offset = "0x33D5840", Length = "0x64")]
	[Token(Token = "0x6000E0B")]
	public MouseUpEvent() { }

	[Address(RVA = "0x33D61F0", Offset = "0x33D55F0", Length = "0x6A")]
	[Token(Token = "0x6000E0D")]
	internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	[Address(RVA = "0x33D6110", Offset = "0x33D5510", Length = "0x6A")]
	[Token(Token = "0x6000E0E")]
	internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	[Address(RVA = "0x33D6180", Offset = "0x33D5580", Length = "0x6A")]
	[Token(Token = "0x6000E0F")]
	internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

	[Address(RVA = "0x33D6260", Offset = "0x33D5660", Length = "0x64")]
	[Token(Token = "0x6000E09")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D62D0", Offset = "0x33D56D0", Length = "0x4D")]
	[Token(Token = "0x6000E0A")]
	private void LocalInit() { }

	[Address(RVA = "0x33D6320", Offset = "0x33D5720", Length = "0x39")]
	[Token(Token = "0x6000E0C")]
	private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

