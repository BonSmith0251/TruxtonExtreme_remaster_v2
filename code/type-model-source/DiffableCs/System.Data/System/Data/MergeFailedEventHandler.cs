namespace System.Data;

[Token(Token = "0x2000074")]
public sealed class MergeFailedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000660")]
	public MergeFailedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000661")]
	public override void Invoke(object sender, MergeFailedEventArgs e) { }

}

