namespace System.Data;

[Token(Token = "0x2000030")]
public sealed class DataColumnChangeEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x600037B")]
	public DataColumnChangeEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600037C")]
	public override void Invoke(object sender, DataColumnChangeEventArgs e) { }

}

