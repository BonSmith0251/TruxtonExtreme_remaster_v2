namespace Steamworks;

[CallbackIdentity(1307)]
[Token(Token = "0x20000AD")]
public struct RemoteStorageFileShareResult_t
{
	[Token(Token = "0x40001D6")]
	public const int k_iCallback = 1307; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D7")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001D8")]
	public UGCHandle_t m_hFile; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D9")]
	private Byte[] m_rgchFilename_; //Field offset: 0x10

	[Token(Token = "0x1700000D")]
	public string m_rgchFilename
	{
		[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
		[Token(Token = "0x600088F")]
		 get { } //Length: 125
		[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
		[Token(Token = "0x6000890")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
	[Token(Token = "0x600088F")]
	public string get_m_rgchFilename() { }

	[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
	[Token(Token = "0x6000890")]
	public void set_m_rgchFilename(string value) { }

}

