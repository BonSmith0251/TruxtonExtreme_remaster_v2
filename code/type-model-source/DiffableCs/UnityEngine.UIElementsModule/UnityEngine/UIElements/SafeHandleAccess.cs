namespace UnityEngine.UIElements;

[Token(Token = "0x20002CA")]
internal struct SafeHandleAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B43")]
	private IntPtr m_Handle; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600136A")]
	public SafeHandleAccess(IntPtr ptr) { }

	[Address(RVA = "0x340BB70", Offset = "0x340AF70", Length = "0xA")]
	[Token(Token = "0x600136B")]
	public bool IsNull() { }

	[Address(RVA = "0x340BB80", Offset = "0x340AF80", Length = "0x53")]
	[Token(Token = "0x600136C")]
	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}

