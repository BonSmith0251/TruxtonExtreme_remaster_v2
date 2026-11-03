namespace System.Data;

[Token(Token = "0x200004A")]
public sealed class DataTableClearEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x60004A6")]
	public DataTableClearEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60004A7")]
	public override void Invoke(object sender, DataTableClearEventArgs e) { }

}

