namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B6")]
internal struct NativeBool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000741")]
	private byte value; //Field offset: 0x0

	[Token(Token = "0x17000305")]
	internal bool Value
	{
		[Address(RVA = "0x2B8EE40", Offset = "0x2B8E240", Length = "0x7")]
		[Token(Token = "0x6000E1B")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x2B8EE30", Offset = "0x2B8E230", Length = "0x5")]
	[Token(Token = "0x6000E1A")]
	internal NativeBool(bool value) { }

	[Address(RVA = "0x2B8EE40", Offset = "0x2B8E240", Length = "0x7")]
	[Token(Token = "0x6000E1B")]
	internal bool get_Value() { }

}

