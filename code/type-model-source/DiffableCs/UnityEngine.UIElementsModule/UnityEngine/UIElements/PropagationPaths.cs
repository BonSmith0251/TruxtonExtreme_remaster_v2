namespace UnityEngine.UIElements;

[Token(Token = "0x200023A")]
internal class PropagationPaths : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200023B")]
	private sealed class <>c
	{
		[Token(Token = "0x40008EA")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DFA40", Offset = "0x33DEE40", Length = "0x67")]
		[Token(Token = "0x6000F8F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F90")]
		public <>c() { }

		[Address(RVA = "0x33DF390", Offset = "0x33DE790", Length = "0xDB")]
		[Token(Token = "0x6000F91")]
		internal PropagationPaths <.cctor>b__8_0() { }

	}

	[Token(Token = "0x40008E7")]
	private static readonly ObjectPool<PropagationPaths> s_Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008E8")]
	public readonly List<VisualElement> trickleDownPath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008E9")]
	public readonly List<VisualElement> bubbleUpPath; //Field offset: 0x18

	[Address(RVA = "0x33DB3C0", Offset = "0x33DA7C0", Length = "0x107")]
	[Token(Token = "0x6000F8E")]
	private static PropagationPaths() { }

	[Address(RVA = "0x33DB4D0", Offset = "0x33DA8D0", Length = "0xAF")]
	[Token(Token = "0x6000F8B")]
	public PropagationPaths() { }

	[Address(RVA = "0x33DB100", Offset = "0x33DA500", Length = "0x1D9")]
	[NotNull]
	[Token(Token = "0x6000F8C")]
	public static PropagationPaths Build(VisualElement elem, EventBase evt, int eventCategories) { }

	[Address(RVA = "0x33DB2E0", Offset = "0x33DA6E0", Length = "0xDC")]
	[Token(Token = "0x6000F8D")]
	public override void Dispose() { }

}

