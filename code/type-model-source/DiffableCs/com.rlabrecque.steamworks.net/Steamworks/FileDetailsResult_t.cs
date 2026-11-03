namespace Steamworks;

[CallbackIdentity(1023)]
[Token(Token = "0x200002E")]
public struct FileDetailsResult_t
{
	[Token(Token = "0x4000010")]
	public const int k_iCallback = 1023; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000012")]
	public ulong m_ulFileSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	public Byte[] m_FileSHA; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000014")]
	public uint m_unFlags; //Field offset: 0x18

}

