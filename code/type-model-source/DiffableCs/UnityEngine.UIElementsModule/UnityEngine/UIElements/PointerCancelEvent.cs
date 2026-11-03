namespace UnityEngine.UIElements;

[Token(Token = "0x200022E")]
public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200022F")]
	private sealed class <>c
	{
		[Token(Token = "0x40008E1")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E00D0", Offset = "0x33DF4D0", Length = "0x67")]
		[Token(Token = "0x6000F62")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F63")]
		public <>c() { }

		[Address(RVA = "0x33DE7D0", Offset = "0x33DDBD0", Length = "0x8F")]
		[Token(Token = "0x6000F64")]
		internal PointerCancelEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x33D7220", Offset = "0x33D6620", Length = "0xD1")]
	[Token(Token = "0x6000F5A")]
	private static PointerCancelEvent() { }

	[Address(RVA = "0x33D7300", Offset = "0x33D6700", Length = "0x64")]
	[Token(Token = "0x6000F5D")]
	public PointerCancelEvent() { }

	[Address(RVA = "0x33D6CC0", Offset = "0x33D60C0", Length = "0xAD")]
	[Token(Token = "0x6000F61")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33D6D70", Offset = "0x33D6170", Length = "0x9B")]
	[Token(Token = "0x6000F5E")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x33D6E10", Offset = "0x33D6210", Length = "0x64")]
	[Token(Token = "0x6000F5B")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D6E80", Offset = "0x33D6280", Length = "0x4D")]
	[Token(Token = "0x6000F5C")]
	private void LocalInit() { }

	[Address(RVA = "0x33D6ED0", Offset = "0x33D62D0", Length = "0x2F5")]
	[Token(Token = "0x6000F60")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x33D71D0", Offset = "0x33D65D0", Length = "0x48")]
	[Token(Token = "0x6000F5F")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

