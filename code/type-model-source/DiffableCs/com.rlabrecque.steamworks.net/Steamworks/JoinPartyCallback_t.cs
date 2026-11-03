namespace Steamworks;

[CallbackIdentity(5301)]
[Token(Token = "0x200008B")]
public struct JoinPartyCallback_t
{
	[Token(Token = "0x400018E")]
	public const int k_iCallback = 5301; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018F")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000190")]
	public PartyBeaconID_t m_ulBeaconID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000191")]
	public CSteamID m_SteamIDBeaconOwner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000192")]
	private Byte[] m_rgchConnectString_; //Field offset: 0x18

	[Token(Token = "0x17000009")]
	public string m_rgchConnectString
	{
		[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
		[Token(Token = "0x6000887")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x6000888")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
	[Token(Token = "0x6000887")]
	public string get_m_rgchConnectString() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x6000888")]
	public void set_m_rgchConnectString(string value) { }

}

