namespace Steamworks;

[CallbackIdentity(1701)]
[Token(Token = "0x2000046")]
public struct GCMessageAvailable_t
{
	[Token(Token = "0x4000069")]
	public const int k_iCallback = 1701; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006A")]
	public uint m_nMessageSize; //Field offset: 0x0

}

