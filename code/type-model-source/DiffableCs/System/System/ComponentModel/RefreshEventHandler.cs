namespace System.ComponentModel;

[Token(Token = "0x2000193")]
public sealed class RefreshEventHandler : MulticastDelegate
{

	[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
	[Token(Token = "0x60009E8")]
	public RefreshEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x60009E9")]
	public override void Invoke(RefreshEventArgs e) { }

}

