namespace System.Data;

[Token(Token = "0x200004D")]
public sealed class DataTableNewRowEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x60004C8")]
	public DataTableNewRowEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60004C9")]
	public override void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

