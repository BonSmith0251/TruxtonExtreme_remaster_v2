namespace KANAI.Network;

[Token(Token = "0x2000018")]
public class RequestCryptor : SimpleSingleton<RequestCryptor>
{
	[Token(Token = "0x400006C")]
	public const string DecryptoLastPatternNormal = ","id":null}"; //Field offset: 0x0
	[Token(Token = "0x400006D")]
	private const int KeyLength = 32; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	private const int IVLength = 16; //Field offset: 0x0
	[Token(Token = "0x400006F")]
	private const int PaddingSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000070")]
	private Byte[] _enckey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000071")]
	private BitArray _mask; //Field offset: 0x18

	[Token(Token = "0x17000017")]
	public BitArray BitMask
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public static int EncryptKeyLength
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6000084")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1E02FE0", Offset = "0x1E023E0", Length = "0xF9")]
	[Token(Token = "0x6000086")]
	public RequestCryptor() { }

	[Address(RVA = "0x1E027F0", Offset = "0x1E01BF0", Length = "0x1FE")]
	[Token(Token = "0x6000083")]
	public Byte[] DecryptStringToBytes(string response, int mode) { }

	[Address(RVA = "0x1E029F0", Offset = "0x1E01DF0", Length = "0x37B")]
	[Token(Token = "0x6000082")]
	public string DecryptStringToJson(string response, int mode, string lastPattern = null) { }

	[Address(RVA = "0x1E02D70", Offset = "0x1E02170", Length = "0xB1")]
	[Token(Token = "0x6000080")]
	public string EncryptStringToBASE64(string jsonRaw, int mode = 2) { }

	[Address(RVA = "0x1E02E30", Offset = "0x1E02230", Length = "0x1A7")]
	[Token(Token = "0x6000081")]
	public Byte[] EncryptStringToBytes(string jsonRaw, int mode) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000085")]
	public BitArray get_BitMask() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000084")]
	public static int get_EncryptKeyLength() { }

}

