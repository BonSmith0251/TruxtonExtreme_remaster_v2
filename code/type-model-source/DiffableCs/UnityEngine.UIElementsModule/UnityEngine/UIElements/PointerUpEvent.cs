namespace UnityEngine.UIElements;

[Token(Token = "0x200022C")]
public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200022D")]
	private sealed class <>c
	{
		[Token(Token = "0x40008E0")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF880", Offset = "0x33DEC80", Length = "0x67")]
		[Token(Token = "0x6000F57")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F58")]
		public <>c() { }

		[Address(RVA = "0x33DEED0", Offset = "0x33DE2D0", Length = "0x8F")]
		[Token(Token = "0x6000F59")]
		internal PointerUpEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33DAE80", Offset = "0x33DA280", Length = "0xD1")]
	[Token(Token = "0x6000F4F")]
	private static PointerUpEvent() { }

	[Address(RVA = "0x33DAF60", Offset = "0x33DA360", Length = "0x64")]
	[Token(Token = "0x6000F52")]
	public PointerUpEvent() { }

	[Address(RVA = "0x33DAA60", Offset = "0x33D9E60", Length = "0xAD")]
	[Token(Token = "0x6000F56")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33DAB10", Offset = "0x33D9F10", Length = "0x9B")]
	[Token(Token = "0x6000F53")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x33DABB0", Offset = "0x33D9FB0", Length = "0x64")]
	[Token(Token = "0x6000F50")]
	protected virtual void Init() { }

	[Address(RVA = "0x33DAC20", Offset = "0x33DA020", Length = "0x4D")]
	[Token(Token = "0x6000F51")]
	private void LocalInit() { }

	[Address(RVA = "0x33DAC70", Offset = "0x33DA070", Length = "0x1B6")]
	[Token(Token = "0x6000F55")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x33DAE30", Offset = "0x33DA230", Length = "0x48")]
	[Token(Token = "0x6000F54")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

