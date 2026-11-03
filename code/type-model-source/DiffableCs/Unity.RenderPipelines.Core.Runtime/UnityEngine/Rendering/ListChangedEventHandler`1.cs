namespace UnityEngine.Rendering;

[Token(Token = "0x200005F")]
public sealed class ListChangedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000549")]
	public ListChangedEventHandler`1(object object, IntPtr method) { }

	[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
	[Token(Token = "0x600054B")]
	public override IAsyncResult BeginInvoke(ObservableList<T> sender, ListChangedEventArgs<T> e, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600054C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600054A")]
	public override void Invoke(ObservableList<T> sender, ListChangedEventArgs<T> e) { }

}

