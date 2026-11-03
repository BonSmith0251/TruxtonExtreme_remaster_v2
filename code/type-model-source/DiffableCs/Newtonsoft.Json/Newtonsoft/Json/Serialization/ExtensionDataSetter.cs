namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000117")]
public sealed class ExtensionDataSetter : MulticastDelegate
{

	[Address(RVA = "0x1C4CD00", Offset = "0x1C4C100", Length = "0x125")]
	[Token(Token = "0x60007F0")]
	public ExtensionDataSetter(object object, IntPtr method) { }

	[Address(RVA = "0x213E140", Offset = "0x213D540", Length = "0x35")]
	[Token(Token = "0x60007F2")]
	public override IAsyncResult BeginInvoke(object o, string key, object value, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60007F3")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[NullableContext(1)]
	[Token(Token = "0x60007F1")]
	public override void Invoke(object o, string key, object value) { }

}

