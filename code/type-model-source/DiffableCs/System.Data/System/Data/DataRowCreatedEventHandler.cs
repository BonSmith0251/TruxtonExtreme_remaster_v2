namespace System.Data;

[Token(Token = "0x2000042")]
internal sealed class DataRowCreatedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000485")]
	public DataRowCreatedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000486")]
	public override void Invoke(object sender, DataRow r) { }

}

