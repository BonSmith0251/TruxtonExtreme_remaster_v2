namespace System.Runtime.InteropServices;

[Token(Token = "0x2000440")]
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	[Token(Token = "0x40011A0")]
	private static readonly UIntPtr Uninitialized; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011A1")]
	private UIntPtr _numBytes; //Field offset: 0x20

	[Address(RVA = "0x1F41CA0", Offset = "0x1F410A0", Length = "0x5C")]
	[Token(Token = "0x600201C")]
	private static SafeBuffer() { }

	[Address(RVA = "0x1F41A90", Offset = "0x1F40E90", Length = "0xE0")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002019")]
	public void AcquirePointer(ref Byte* pointer) { }

	[Address(RVA = "0x1F41B80", Offset = "0x1F40F80", Length = "0x58")]
	[Token(Token = "0x600201B")]
	private static InvalidOperationException NotInitialized() { }

	[Address(RVA = "0x1F41BE0", Offset = "0x1F40FE0", Length = "0xB1")]
	[Token(Token = "0x600201A")]
	public void ReleasePointer() { }

}

