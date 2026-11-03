namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000116")]
public sealed class SerializationErrorCallback : MulticastDelegate
{

	[Address(RVA = "0x21524E0", Offset = "0x21518E0", Length = "0x125")]
	[Token(Token = "0x60007EC")]
	public SerializationErrorCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2152410", Offset = "0x2151810", Length = "0x98")]
	[Token(Token = "0x60007EE")]
	public override IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60007EF")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x21524B0", Offset = "0x21518B0", Length = "0x2B")]
	[NullableContext(1)]
	[Token(Token = "0x60007ED")]
	public override void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

