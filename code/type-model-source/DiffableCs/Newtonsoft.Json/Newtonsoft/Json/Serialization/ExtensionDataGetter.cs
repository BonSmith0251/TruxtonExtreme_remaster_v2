namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000118")]
public sealed class ExtensionDataGetter : MulticastDelegate
{

	[Address(RVA = "0x1EEE9D0", Offset = "0x1EEDDD0", Length = "0x124")]
	[Token(Token = "0x60007F4")]
	public ExtensionDataGetter(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
	[Token(Token = "0x60007F6")]
	public override IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60007F7")]
	public override IEnumerable<KeyValuePair`2<Object, Object>> EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[NullableContext(1)]
	[Token(Token = "0x60007F5")]
	public override IEnumerable<KeyValuePair`2<Object, Object>> Invoke(object o) { }

}

