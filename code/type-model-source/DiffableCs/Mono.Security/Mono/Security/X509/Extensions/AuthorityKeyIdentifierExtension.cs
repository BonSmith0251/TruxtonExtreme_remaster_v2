namespace Mono.Security.X509.Extensions;

[Token(Token = "0x200002D")]
public class AuthorityKeyIdentifierExtension : X509Extension
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000085")]
	private Byte[] aki; //Field offset: 0x28

	[Token(Token = "0x1700004D")]
	public Byte[] Identifier
	{
		[Address(RVA = "0x1E2DC50", Offset = "0x1E2D050", Length = "0x7B")]
		[Token(Token = "0x6000101")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x1E2DC40", Offset = "0x1E2D040", Length = "0x8")]
	[Token(Token = "0x60000FE")]
	public AuthorityKeyIdentifierExtension(X509Extension extension) { }

	[Address(RVA = "0x1E2D7F0", Offset = "0x1E2CBF0", Length = "0x145")]
	[Token(Token = "0x60000FF")]
	protected virtual void Decode() { }

	[Address(RVA = "0x1E2D940", Offset = "0x1E2CD40", Length = "0x163")]
	[Token(Token = "0x6000100")]
	protected virtual void Encode() { }

	[Address(RVA = "0x1E2DC50", Offset = "0x1E2D050", Length = "0x7B")]
	[Token(Token = "0x6000101")]
	public Byte[] get_Identifier() { }

	[Address(RVA = "0x1E2DAB0", Offset = "0x1E2CEB0", Length = "0x18C")]
	[Token(Token = "0x6000102")]
	public virtual string ToString() { }

}

