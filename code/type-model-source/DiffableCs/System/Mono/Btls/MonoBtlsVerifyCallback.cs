namespace Mono.Btls;

[Token(Token = "0x200007E")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class MonoBtlsVerifyCallback : MulticastDelegate
{

	[Address(RVA = "0x1C132B0", Offset = "0x1C126B0", Length = "0x124")]
	[Token(Token = "0x600020F")]
	public MonoBtlsVerifyCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000210")]
	public override int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

