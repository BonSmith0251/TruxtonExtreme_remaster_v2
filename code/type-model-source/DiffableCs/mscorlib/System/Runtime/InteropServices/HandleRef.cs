namespace System.Runtime.InteropServices;

[IsReadOnly]
[Token(Token = "0x200043C")]
public struct HandleRef
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001199")]
	private readonly object _wrapper; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400119A")]
	private readonly IntPtr _handle; //Field offset: 0x8

	[Token(Token = "0x170003ED")]
	public IntPtr Handle
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600200B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEE5A0", Offset = "0xAED9A0", Length = "0x27")]
	[Token(Token = "0x600200A")]
	public HandleRef(object wrapper, IntPtr handle) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x600200B")]
	public IntPtr get_Handle() { }

}

