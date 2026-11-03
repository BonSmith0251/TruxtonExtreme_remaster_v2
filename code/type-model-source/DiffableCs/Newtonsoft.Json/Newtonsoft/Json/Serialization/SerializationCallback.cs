namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000115")]
public sealed class SerializationCallback : MulticastDelegate
{

	[Address(RVA = "0x169F620", Offset = "0x169EA20", Length = "0x125")]
	[Token(Token = "0x60007E8")]
	public SerializationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2152380", Offset = "0x2151780", Length = "0x88")]
	[Token(Token = "0x60007EA")]
	public override IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60007EB")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x169F5F0", Offset = "0x169E9F0", Length = "0x25")]
	[NullableContext(1)]
	[Token(Token = "0x60007E9")]
	public override void Invoke(object o, StreamingContext context) { }

}

