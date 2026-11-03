namespace Mono.Btls;

[Token(Token = "0x200007F")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsSelectCallback : MulticastDelegate
{

	[Address(RVA = "0x10DF1E0", Offset = "0x10DE5E0", Length = "0xB4")]
	[Token(Token = "0x6000211")]
	public MonoBtlsSelectCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000212")]
	public override int Invoke(String[] acceptableIssuers) { }

}

