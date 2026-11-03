namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Delegate (4096), AllowMultiple = False, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000444")]
public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A3")]
	private CallingConvention m_callingConvention; //Field offset: 0x10

	[Token(Token = "0x170003EE")]
	public CallingConvention CallingConvention
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6002026")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002025")]
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6002026")]
	public CallingConvention get_CallingConvention() { }

}

