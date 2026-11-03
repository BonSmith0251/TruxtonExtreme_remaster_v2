namespace Steamworks;

[CallbackIdentity(3401)]
[Token(Token = "0x20000C8")]
public struct SteamUGCQueryCompleted_t
{
	[Token(Token = "0x4000255")]
	public const int k_iCallback = 3401; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000256")]
	public UGCQueryHandle_t m_handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000257")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000258")]
	public uint m_unNumResultsReturned; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000259")]
	public uint m_unTotalMatchingResults; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400025A")]
	public bool m_bCachedData; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400025B")]
	private Byte[] m_rgchNextCursor_; //Field offset: 0x18

	[Token(Token = "0x17000014")]
	public string m_rgchNextCursor
	{
		[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
		[Token(Token = "0x600089D")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x600089E")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
	[Token(Token = "0x600089D")]
	public string get_m_rgchNextCursor() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x600089E")]
	public void set_m_rgchNextCursor(string value) { }

}

