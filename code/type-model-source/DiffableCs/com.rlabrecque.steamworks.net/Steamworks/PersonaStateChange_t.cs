namespace Steamworks;

[CallbackIdentity(304)]
[Token(Token = "0x2000030")]
public struct PersonaStateChange_t
{
	[Token(Token = "0x400001A")]
	public const int k_iCallback = 304; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001B")]
	public ulong m_ulSteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001C")]
	public EPersonaChange m_nChangeFlags; //Field offset: 0x8

}

