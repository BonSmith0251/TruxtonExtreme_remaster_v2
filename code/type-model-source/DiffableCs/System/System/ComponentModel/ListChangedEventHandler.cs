namespace System.ComponentModel;

[Token(Token = "0x2000185")]
public sealed class ListChangedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x600096D")]
	public ListChangedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600096E")]
	public override void Invoke(object sender, ListChangedEventArgs e) { }

}

