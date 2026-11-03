namespace Steamworks;

[CallbackIdentity(206)]
[Token(Token = "0x200004B")]
public struct GSClientAchievementStatus_t
{
	[Token(Token = "0x4000076")]
	public const int k_iCallback = 206; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000077")]
	public ulong m_SteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000078")]
	private Byte[] m_pchAchievement_; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000079")]
	public bool m_bUnlocked; //Field offset: 0x10

	[Token(Token = "0x17000007")]
	public string m_pchAchievement
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x6000883")]
		 get { } //Length: 125
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x6000884")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x6000883")]
	public string get_m_pchAchievement() { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x6000884")]
	public void set_m_pchAchievement(string value) { }

}

