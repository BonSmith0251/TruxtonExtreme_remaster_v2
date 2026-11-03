namespace System.ComponentModel;

[Token(Token = "0x20001A5")]
public sealed class PropertyChangedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000A2C")]
	public PropertyChangedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000A2D")]
	public override void Invoke(object sender, PropertyChangedEventArgs e) { }

}

