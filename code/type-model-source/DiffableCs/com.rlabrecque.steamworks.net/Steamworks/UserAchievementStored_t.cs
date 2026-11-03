namespace Steamworks;

[CallbackIdentity(1103)]
[Token(Token = "0x20000EC")]
public struct UserAchievementStored_t
{
	[Token(Token = "0x40002DF")]
	public const int k_iCallback = 1103; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002E0")]
	public ulong m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002E1")]
	public bool m_bGroupAchievement; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E2")]
	private Byte[] m_rgchAchievementName_; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E3")]
	public uint m_nCurProgress; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E4")]
	public uint m_nMaxProgress; //Field offset: 0x1C

	[Token(Token = "0x17000017")]
	public string m_rgchAchievementName
	{
		[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
		[Token(Token = "0x60008A3")]
		 get { } //Length: 125
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x60008A4")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
	[Token(Token = "0x60008A3")]
	public string get_m_rgchAchievementName() { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x60008A4")]
	public void set_m_rgchAchievementName(string value) { }

}

