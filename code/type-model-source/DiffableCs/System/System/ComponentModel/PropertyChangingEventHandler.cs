namespace System.ComponentModel;

[Token(Token = "0x20001A7")]
public sealed class PropertyChangingEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000A2F")]
	public PropertyChangingEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000A30")]
	public override void Invoke(object sender, PropertyChangingEventArgs e) { }

}

