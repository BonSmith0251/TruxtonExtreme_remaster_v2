namespace Steamworks;

[CallbackIdentity(4705)]
[Token(Token = "0x2000078")]
public struct SteamInventoryRequestPricesResult_t
{
	[Token(Token = "0x4000135")]
	public const int k_iCallback = 4705; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000136")]
	public EResult m_result; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000137")]
	private Byte[] m_rgchCurrency_; //Field offset: 0x8

	[Token(Token = "0x17000008")]
	public string m_rgchCurrency
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x6000885")]
		 get { } //Length: 125
		[Address(RVA = "0x63B010", Offset = "0x63A410", Length = "0xA8")]
		[Token(Token = "0x6000886")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x6000885")]
	public string get_m_rgchCurrency() { }

	[Address(RVA = "0x63B010", Offset = "0x63A410", Length = "0xA8")]
	[Token(Token = "0x6000886")]
	public void set_m_rgchCurrency(string value) { }

}

