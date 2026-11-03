namespace Steamworks;

[CallbackIdentity(1109)]
[Token(Token = "0x20000F2")]
public struct UserAchievementIconFetched_t
{
	[Token(Token = "0x40002F8")]
	public const int k_iCallback = 1109; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F9")]
	public CGameID m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002FA")]
	private Byte[] m_rgchAchievementName_; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002FB")]
	public bool m_bAchieved; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002FC")]
	public int m_nIconHandle; //Field offset: 0x14

	[Token(Token = "0x17000018")]
	public string m_rgchAchievementName
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x60008A5")]
		 get { } //Length: 125
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x60008A6")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x60008A5")]
	public string get_m_rgchAchievementName() { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x60008A6")]
	public void set_m_rgchAchievementName(string value) { }

}

