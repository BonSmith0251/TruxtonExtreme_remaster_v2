namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20000C5")]
internal class FSharpFunction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000449")]
	private readonly object _instance; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	[Token(Token = "0x400044A")]
	private readonly MethodCall<Object, Object> _invoker; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600060C")]
	public FSharpFunction(object instance, MethodCall<Object, Object> invoker) { }

	[Address(RVA = "0x21256E0", Offset = "0x2124AE0", Length = "0x2C")]
	[NullableContext(1)]
	[Token(Token = "0x600060D")]
	public object Invoke(Object[] args) { }

}

