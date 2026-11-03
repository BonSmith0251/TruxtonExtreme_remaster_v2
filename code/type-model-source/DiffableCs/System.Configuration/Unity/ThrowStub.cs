namespace Unity;

[Token(Token = "0x200000A")]
internal sealed class ThrowStub : ObjectDisposedException
{

	[Address(RVA = "0x2228E30", Offset = "0x2228230", Length = "0x3E")]
	[Token(Token = "0x6000011")]
	public static void ThrowNotSupportedException() { }

}

