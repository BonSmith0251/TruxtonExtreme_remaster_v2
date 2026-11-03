namespace Steamworks;

[CallbackIdentity(705)]
[Token(Token = "0x20000FA")]
public struct CheckFileSignature_t
{
	[Token(Token = "0x400030E")]
	public const int k_iCallback = 705; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400030F")]
	public ECheckFileSignature m_eCheckFileSignature; //Field offset: 0x0

}

