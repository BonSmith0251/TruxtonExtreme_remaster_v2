namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000135")]
public sealed class ObjectConstructor : MulticastDelegate
{

	[Address(RVA = "0xDC2410", Offset = "0xDC1810", Length = "0x124")]
	[Token(Token = "0x6000989")]
	public ObjectConstructor`1(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
	[Token(Token = "0x600098B")]
	public override IAsyncResult BeginInvoke(Object[] args, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600098C")]
	public override object EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[NullableContext(1)]
	[Token(Token = "0x600098A")]
	public override object Invoke(Object[] args) { }

}

