namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003B6")]
public sealed class HeaderHandler : MulticastDelegate
{

	[Address(RVA = "0x1EEE9D0", Offset = "0x1EEDDD0", Length = "0x124")]
	[Token(Token = "0x6001CC7")]
	public HeaderHandler(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6001CC8")]
	public override object Invoke(Header[] headers) { }

}

