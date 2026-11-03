namespace UnityEngine.UIElements;

[Token(Token = "0x200054F")]
internal class VisualElementFocusChangeTarget : FocusChangeDirection
{
	[CompilerGenerated]
	[Token(Token = "0x2000550")]
	private sealed class <>c
	{
		[Token(Token = "0x40011A0")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32BB6F0", Offset = "0x32BAAF0", Length = "0x67")]
		[Token(Token = "0x60026D9")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60026DA")]
		public <>c() { }

		[Address(RVA = "0x32BB0B0", Offset = "0x32BA4B0", Length = "0xC1")]
		[Token(Token = "0x60026DB")]
		internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }

	}

	[Token(Token = "0x400119E")]
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400119F")]
	private Focusable <target>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000A16")]
	public private Focusable target
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60026D6")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60026D7")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x32CC150", Offset = "0x32CB550", Length = "0x107")]
	[Token(Token = "0x60026D8")]
	private static VisualElementFocusChangeTarget() { }

	[Address(RVA = "0x32CC260", Offset = "0x32CB660", Length = "0x95")]
	[Token(Token = "0x60026D5")]
	public VisualElementFocusChangeTarget() { }

	[Address(RVA = "0x32CBFD0", Offset = "0x32CB3D0", Length = "0x44")]
	[Token(Token = "0x60026D4")]
	internal virtual void ApplyTo(FocusController focusController, Focusable f) { }

	[Address(RVA = "0x32CC020", Offset = "0x32CB420", Length = "0x8B")]
	[Token(Token = "0x60026D3")]
	protected virtual void Dispose() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60026D6")]
	public Focusable get_target() { }

	[Address(RVA = "0x32CC0B0", Offset = "0x32CB4B0", Length = "0x9B")]
	[Token(Token = "0x60026D2")]
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60026D7")]
	private void set_target(Focusable value) { }

}

