namespace System.ComponentModel;

[Token(Token = "0x2000158")]
public sealed class AddingNewEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000860")]
	public AddingNewEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000861")]
	public override void Invoke(object sender, AddingNewEventArgs e) { }

}

