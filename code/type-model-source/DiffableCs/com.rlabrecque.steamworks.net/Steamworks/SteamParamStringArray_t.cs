namespace Steamworks;

[Token(Token = "0x2000179")]
public struct SteamParamStringArray_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A04")]
	public IntPtr m_ppStrings; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A05")]
	public int m_nNumStrings; //Field offset: 0x8

}

