namespace Steamworks;

[CallbackIdentity(1281)]
[Token(Token = "0x20000A8")]
public struct SteamRelayNetworkStatus_t
{
	[Token(Token = "0x40001C9")]
	public const int k_iCallback = 1281; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CA")]
	public ESteamNetworkingAvailability m_eAvail; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001CB")]
	public int m_bPingMeasurementInProgress; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001CC")]
	public ESteamNetworkingAvailability m_eAvailNetworkConfig; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001CD")]
	public ESteamNetworkingAvailability m_eAvailAnyRelay; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	private Byte[] m_debugMsg_; //Field offset: 0x10

	[Token(Token = "0x1700000B")]
	public string m_debugMsg
	{
		[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
		[Token(Token = "0x600088B")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x600088C")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
	[Token(Token = "0x600088B")]
	public string get_m_debugMsg() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x600088C")]
	public void set_m_debugMsg(string value) { }

}

