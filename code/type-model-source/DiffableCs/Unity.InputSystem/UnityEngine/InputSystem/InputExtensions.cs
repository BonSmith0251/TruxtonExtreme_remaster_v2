namespace UnityEngine.InputSystem;

[Extension]
[Token(Token = "0x20000C0")]
public static class InputExtensions
{

	[Address(RVA = "0x299A420", Offset = "0x2999820", Length = "0x12")]
	[Extension]
	[Token(Token = "0x6000A54")]
	public static bool IsActive(TouchPhase phase) { }

	[Address(RVA = "0x299A440", Offset = "0x2999840", Length = "0xF")]
	[Extension]
	[Token(Token = "0x6000A53")]
	public static bool IsEndedOrCanceled(TouchPhase phase) { }

	[Address(RVA = "0x20CDAA0", Offset = "0x20CCEA0", Length = "0xF")]
	[Extension]
	[Token(Token = "0x6000A52")]
	public static bool IsInProgress(InputActionPhase phase) { }

	[Address(RVA = "0x299A450", Offset = "0x2999850", Length = "0xA")]
	[Extension]
	[Token(Token = "0x6000A55")]
	public static bool IsModifierKey(Key key) { }

	[Address(RVA = "0x299A460", Offset = "0x2999860", Length = "0x2C")]
	[Extension]
	[Token(Token = "0x6000A56")]
	public static bool IsTextInputKey(Key key) { }

}

