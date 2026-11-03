namespace Steamworks;

[Token(Token = "0x20001BE")]
public struct SteamDatagramRelayAuthTicket
{
	[Token(Token = "0x20001BF")]
	private struct ExtraField
	{
		[Token(Token = "0x20001C0")]
		private enum EType : int
		{
			k_EType_String = 0,
			k_EType_Int = 1,
			k_EType_Fixed64 = 2,
		}

		[Token(Token = "0x20001C1")]
		private struct OptionValue
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000AE5")]
			private Byte[] m_szStringValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000AE6")]
			private long m_nIntValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000AE7")]
			private ulong m_nFixed64Value; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ADE")]
		private EType m_eType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000ADF")]
		private Byte[] m_szName; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE0")]
		private OptionValue m_val; //Field offset: 0x10

	}

	[Token(Token = "0x4000ADB")]
	private const int k_nMaxExtraFields = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD4")]
	private SteamNetworkingIdentity m_identityGameserver; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AD5")]
	private SteamNetworkingIdentity m_identityAuthorizedClient; //Field offset: 0x88
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000AD6")]
	private uint m_unPublicIP; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000AD7")]
	private RTime32 m_rtimeTicketExpiry; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000AD8")]
	private SteamDatagramHostedAddress m_routing; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000AD9")]
	private uint m_nAppID; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000ADA")]
	private int m_nRestrictToVirtualPort; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000ADC")]
	private int m_nExtraFields; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000ADD")]
	private ExtraField[] m_vecExtraFields; //Field offset: 0x138

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A2F")]
	public void Clear() { }

}

