namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000129")]
public sealed class PublicKey
{
	[Token(Token = "0x400057E")]
	private static Byte[] Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057B")]
	private AsnEncodedData _keyValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057C")]
	private AsnEncodedData _params; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057D")]
	private Oid _oid; //Field offset: 0x20

	[Token(Token = "0x17000117")]
	public AsnEncodedData EncodedKeyValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60006DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000118")]
	public AsnEncodedData EncodedParameters
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60006DF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000119")]
	public AsymmetricAlgorithm Key
	{
		[Address(RVA = "0x2649530", Offset = "0x2648930", Length = "0x1B4")]
		[Token(Token = "0x60006E0")]
		 get { } //Length: 436
	}

	[Token(Token = "0x1700011A")]
	public Oid Oid
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x26492D0", Offset = "0x26486D0", Length = "0x65")]
	[Token(Token = "0x60006E5")]
	private static PublicKey() { }

	[Address(RVA = "0x2649340", Offset = "0x2648740", Length = "0x1EE")]
	[Token(Token = "0x60006DD")]
	public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	[Address(RVA = "0x26489C0", Offset = "0x2647DC0", Length = "0x503")]
	[Token(Token = "0x60006E3")]
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	[Address(RVA = "0x2648ED0", Offset = "0x26482D0", Length = "0x35A")]
	[Token(Token = "0x60006E4")]
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60006DE")]
	public AsnEncodedData get_EncodedKeyValue() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60006DF")]
	public AsnEncodedData get_EncodedParameters() { }

	[Address(RVA = "0x2649530", Offset = "0x2648930", Length = "0x1B4")]
	[Token(Token = "0x60006E0")]
	public AsymmetricAlgorithm get_Key() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60006E1")]
	public Oid get_Oid() { }

	[Address(RVA = "0x2649230", Offset = "0x2648630", Length = "0x9D")]
	[Token(Token = "0x60006E2")]
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

}

