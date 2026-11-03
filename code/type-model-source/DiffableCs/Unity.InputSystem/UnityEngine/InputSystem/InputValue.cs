namespace UnityEngine.InputSystem;

[DebuggerDisplay("Value = {Get()}")]
[Token(Token = "0x20000D6")]
public class InputValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000512")]
	internal Nullable<CallbackContext> m_Context; //Field offset: 0x10

	[Token(Token = "0x170002F5")]
	public bool isPressed
	{
		[Address(RVA = "0x29BFB90", Offset = "0x29BEF90", Length = "0x5A")]
		[Token(Token = "0x6000B7C")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B7D")]
	public InputValue() { }

	[Address(RVA = "0x29BFB30", Offset = "0x29BEF30", Length = "0x5F")]
	[Token(Token = "0x6000B7A")]
	public object Get() { }

	[Address(RVA = "0x84BE30", Offset = "0x84B230", Length = "0xC4")]
	[Token(Token = "0x6000B7B")]
	public TValue Get() { }

	[Address(RVA = "0x29BFB90", Offset = "0x29BEF90", Length = "0x5A")]
	[Token(Token = "0x6000B7C")]
	public bool get_isPressed() { }

}

