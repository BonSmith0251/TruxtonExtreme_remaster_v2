namespace Steamworks;

[Token(Token = "0x20001B5")]
public class gameserveritem_t
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AAF")]
	public servernetadr_t m_NetAdr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AB0")]
	public int m_nPing; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000AB1")]
	public bool m_bHadSuccessfulResponse; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000AB2")]
	public bool m_bDoNotRefresh; //Field offset: 0x1D
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AB3")]
	private Byte[] m_szGameDir; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AB4")]
	private Byte[] m_szMap; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AB5")]
	private Byte[] m_szGameDescription; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AB6")]
	public uint m_nAppID; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000AB7")]
	public int m_nPlayers; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AB8")]
	public int m_nMaxPlayers; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000AB9")]
	public int m_nBotPlayers; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000ABA")]
	public bool m_bPassword; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000ABB")]
	public bool m_bSecure; //Field offset: 0x49
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000ABC")]
	public uint m_ulTimeLastPlayed; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ABD")]
	public int m_nServerVersion; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ABE")]
	private Byte[] m_szServerName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000ABF")]
	private Byte[] m_szGameTags; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AC0")]
	public CSteamID m_steamID; //Field offset: 0x68

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60009C8")]
	public gameserveritem_t() { }

	[Address(RVA = "0x645EC0", Offset = "0x6452C0", Length = "0x8C")]
	[Token(Token = "0x60009C2")]
	public string GetGameDescription() { }

	[Address(RVA = "0x645F50", Offset = "0x645350", Length = "0x8C")]
	[Token(Token = "0x60009BE")]
	public string GetGameDir() { }

	[Address(RVA = "0x645FE0", Offset = "0x6453E0", Length = "0x8C")]
	[Token(Token = "0x60009C6")]
	public string GetGameTags() { }

	[Address(RVA = "0x646070", Offset = "0x645470", Length = "0x8C")]
	[Token(Token = "0x60009C0")]
	public string GetMap() { }

	[Address(RVA = "0x646100", Offset = "0x645500", Length = "0xCE")]
	[Token(Token = "0x60009C4")]
	public string GetServerName() { }

	[Address(RVA = "0x6461D0", Offset = "0x6455D0", Length = "0x90")]
	[Token(Token = "0x60009C3")]
	public void SetGameDescription(string desc) { }

	[Address(RVA = "0x646270", Offset = "0x645670", Length = "0x90")]
	[Token(Token = "0x60009BF")]
	public void SetGameDir(string dir) { }

	[Address(RVA = "0x646310", Offset = "0x645710", Length = "0x90")]
	[Token(Token = "0x60009C7")]
	public void SetGameTags(string tags) { }

	[Address(RVA = "0x6463B0", Offset = "0x6457B0", Length = "0x90")]
	[Token(Token = "0x60009C1")]
	public void SetMap(string map) { }

	[Address(RVA = "0x646450", Offset = "0x645850", Length = "0x90")]
	[Token(Token = "0x60009C5")]
	public void SetServerName(string name) { }

}

