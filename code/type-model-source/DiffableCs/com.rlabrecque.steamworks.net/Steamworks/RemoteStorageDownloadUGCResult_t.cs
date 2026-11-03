namespace Steamworks;

[CallbackIdentity(1317)]
[Token(Token = "0x20000B5")]
public struct RemoteStorageDownloadUGCResult_t
{
	[Token(Token = "0x40001F6")]
	public const int k_iCallback = 1317; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F7")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001F8")]
	public UGCHandle_t m_hFile; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F9")]
	public AppId_t m_nAppID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001FA")]
	public int m_nSizeInBytes; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FB")]
	private Byte[] m_pchFileName_; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FC")]
	public ulong m_ulSteamIDOwner; //Field offset: 0x20

	[Token(Token = "0x1700000E")]
	public string m_pchFileName
	{
		[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
		[Token(Token = "0x6000891")]
		 get { } //Length: 125
		[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
		[Token(Token = "0x6000892")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
	[Token(Token = "0x6000891")]
	public string get_m_pchFileName() { }

	[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
	[Token(Token = "0x6000892")]
	public void set_m_pchFileName(string value) { }

}

