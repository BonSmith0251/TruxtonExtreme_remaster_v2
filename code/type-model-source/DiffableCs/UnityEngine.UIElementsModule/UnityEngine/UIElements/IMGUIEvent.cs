namespace UnityEngine.UIElements;

[EventCategory(EventCategory::IMGUI (18))]
[Token(Token = "0x200024B")]
public class IMGUIEvent : EventBase<IMGUIEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200024C")]
	private sealed class <>c
	{
		[Token(Token = "0x40008F7")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E04C0", Offset = "0x33DF8C0", Length = "0x67")]
		[Token(Token = "0x6000FCC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FCD")]
		public <>c() { }

		[Address(RVA = "0x33DED10", Offset = "0x33DE110", Length = "0x8D")]
		[Token(Token = "0x6000FCE")]
		internal IMGUIEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D1670", Offset = "0x33D0A70", Length = "0xD1")]
	[Token(Token = "0x6000FC6")]
	private static IMGUIEvent() { }

	[Address(RVA = "0x33D1750", Offset = "0x33D0B50", Length = "0x62")]
	[Token(Token = "0x6000FCA")]
	public IMGUIEvent() { }

	[Address(RVA = "0x33CB7E0", Offset = "0x33CABE0", Length = "0x77")]
	[Token(Token = "0x6000FCB")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D1500", Offset = "0x33D0900", Length = "0x11F")]
	[Token(Token = "0x6000FC7")]
	public static IMGUIEvent GetPooled(Event systemEvent) { }

	[Address(RVA = "0x33D1620", Offset = "0x33D0A20", Length = "0x41")]
	[Token(Token = "0x6000FC8")]
	protected virtual void Init() { }

	[Address(RVA = "0x336B470", Offset = "0x336A870", Length = "0x8")]
	[Token(Token = "0x6000FC9")]
	private void LocalInit() { }

}

