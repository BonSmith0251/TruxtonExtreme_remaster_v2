namespace System.Collections.Specialized;

[Token(Token = "0x20001E4")]
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000C30")]
	public NotifyCollectionChangedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000C31")]
	public override void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

