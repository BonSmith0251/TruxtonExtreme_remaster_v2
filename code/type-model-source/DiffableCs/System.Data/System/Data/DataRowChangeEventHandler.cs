namespace System.Data;

[Token(Token = "0x200003F")]
public sealed class DataRowChangeEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000472")]
	public DataRowChangeEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000473")]
	public override void Invoke(object sender, DataRowChangeEventArgs e) { }

}

