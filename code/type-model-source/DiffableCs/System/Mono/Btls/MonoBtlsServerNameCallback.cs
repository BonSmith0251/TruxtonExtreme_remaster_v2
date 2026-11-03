namespace Mono.Btls;

[Token(Token = "0x2000080")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsServerNameCallback : MulticastDelegate
{

	[Address(RVA = "0x17C9CC0", Offset = "0x17C90C0", Length = "0xA5")]
	[Token(Token = "0x6000213")]
	public MonoBtlsServerNameCallback(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x6000214")]
	public override int Invoke() { }

}

