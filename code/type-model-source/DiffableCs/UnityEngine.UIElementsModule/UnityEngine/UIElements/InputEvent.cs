namespace UnityEngine.UIElements;

[Token(Token = "0x20001E3")]
public class InputEvent : EventBase<InputEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001E4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000862")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DFF10", Offset = "0x33DF310", Length = "0x67")]
		[Token(Token = "0x6000D9F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DA0")]
		public <>c() { }

		[Address(RVA = "0x33DE9B0", Offset = "0x33DDDB0", Length = "0xB3")]
		[Token(Token = "0x6000DA1")]
		internal InputEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000860")]
	private string <previousData>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000861")]
	private string <newData>k__BackingField; //Field offset: 0x70

	[Token(Token = "0x17000263")]
	protected string newData
	{
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D9A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000262")]
	protected string previousData
	{
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D99")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x33D1910", Offset = "0x33D0D10", Length = "0xD1")]
	[Token(Token = "0x6000D98")]
	private static InputEvent() { }

	[Address(RVA = "0x33D19F0", Offset = "0x33D0DF0", Length = "0x87")]
	[Token(Token = "0x6000D9E")]
	public InputEvent() { }

	[Address(RVA = "0x33D17C0", Offset = "0x33D0BC0", Length = "0x9E")]
	[Token(Token = "0x6000D9D")]
	public static InputEvent GetPooled(string previousData, string newData) { }

	[Address(RVA = "0x33D1860", Offset = "0x33D0C60", Length = "0x66")]
	[Token(Token = "0x6000D9B")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D18D0", Offset = "0x33D0CD0", Length = "0x3B")]
	[Token(Token = "0x6000D9C")]
	private void LocalInit() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D9A")]
	protected void set_newData(string value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D99")]
	protected void set_previousData(string value) { }

}

