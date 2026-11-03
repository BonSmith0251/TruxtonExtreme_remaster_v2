namespace Steamworks;

[CallbackIdentity(1021)]
[Token(Token = "0x200002D")]
public struct AppProofOfPurchaseKeyResponse_t
{
	[Token(Token = "0x400000B")]
	public const int k_iCallback = 1021; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400000D")]
	public uint m_nAppID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000E")]
	public uint m_cchKeyLength; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000F")]
	private Byte[] m_rgchKey_; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public string m_rgchKey
	{
		[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
		[Token(Token = "0x6000877")]
		 get { } //Length: 125
		[Address(RVA = "0x6045D0", Offset = "0x6039D0", Length = "0xA8")]
		[Token(Token = "0x6000878")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
	[Token(Token = "0x6000877")]
	public string get_m_rgchKey() { }

	[Address(RVA = "0x6045D0", Offset = "0x6039D0", Length = "0xA8")]
	[Token(Token = "0x6000878")]
	public void set_m_rgchKey(string value) { }

}

