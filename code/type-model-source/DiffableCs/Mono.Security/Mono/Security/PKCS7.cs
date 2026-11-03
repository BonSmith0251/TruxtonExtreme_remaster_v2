namespace Mono.Security;

[Token(Token = "0x2000006")]
public sealed class PKCS7
{
	[Token(Token = "0x2000007")]
	internal class ContentInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000004")]
		private string contentType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000005")]
		private ASN1 content; //Field offset: 0x18

		[Token(Token = "0x17000006")]
		public ASN1 ASN1
		{
			[Address(RVA = "0x1E310E0", Offset = "0x1E304E0", Length = "0x7")]
			[Token(Token = "0x6000027")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000007")]
		public ASN1 Content
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000028")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x6000029")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000008")]
		public string ContentType
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600002A")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x600002B")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x1E30DA0", Offset = "0x1E301A0", Length = "0x7D")]
		[Token(Token = "0x6000023")]
		public ContentInfo() { }

		[Address(RVA = "0x1E30E90", Offset = "0x1E30290", Length = "0x31")]
		[Token(Token = "0x6000024")]
		public ContentInfo(string oid) { }

		[Address(RVA = "0x1E30E20", Offset = "0x1E30220", Length = "0x6B")]
		[Token(Token = "0x6000025")]
		public ContentInfo(Byte[] data) { }

		[Address(RVA = "0x1E30ED0", Offset = "0x1E302D0", Length = "0x204")]
		[Token(Token = "0x6000026")]
		public ContentInfo(ASN1 asn1) { }

		[Address(RVA = "0x1E310E0", Offset = "0x1E304E0", Length = "0x7")]
		[Token(Token = "0x6000027")]
		public ASN1 get_ASN1() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000028")]
		public ASN1 get_Content() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600002A")]
		public string get_ContentType() { }

		[Address(RVA = "0x1E30BB0", Offset = "0x1E2FFB0", Length = "0x1ED")]
		[Token(Token = "0x600002C")]
		internal ASN1 GetASN1() { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000029")]
		public void set_Content(ASN1 value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600002B")]
		public void set_ContentType(string value) { }

	}

	[Token(Token = "0x2000008")]
	internal class EncryptedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000006")]
		private byte _version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000007")]
		private ContentInfo _content; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000008")]
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000009")]
		private Byte[] _encrypted; //Field offset: 0x28

		[Token(Token = "0x1700000A")]
		public Byte[] EncryptedContent
		{
			[Address(RVA = "0x1E32070", Offset = "0x1E31470", Length = "0x7B")]
			[Token(Token = "0x6000030")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000009")]
		public ContentInfo EncryptionAlgorithm
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x600002F")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1E31C30", Offset = "0x1E31030", Length = "0x1A")]
		[Token(Token = "0x600002D")]
		public EncryptedData() { }

		[Address(RVA = "0x1E31C50", Offset = "0x1E31050", Length = "0x41E")]
		[Token(Token = "0x600002E")]
		public EncryptedData(ASN1 asn1) { }

		[Address(RVA = "0x1E32070", Offset = "0x1E31470", Length = "0x7B")]
		[Token(Token = "0x6000030")]
		public Byte[] get_EncryptedContent() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600002F")]
		public ContentInfo get_EncryptionAlgorithm() { }

	}

	[Token(Token = "0x2000009")]
	internal class SignedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000A")]
		private byte version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000B")]
		private string hashAlgorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000C")]
		private ContentInfo contentInfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000D")]
		private X509CertificateCollection certs; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000E")]
		private ArrayList crls; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400000F")]
		private SignerInfo signerInfo; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000010")]
		private bool mda; //Field offset: 0x40

		[Token(Token = "0x1700000B")]
		public X509CertificateCollection Certificates
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000032")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700000C")]
		public ContentInfo ContentInfo
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000033")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700000D")]
		public string HashName
		{
			[Address(RVA = "0x1E3B590", Offset = "0x1E3A990", Length = "0x45")]
			[Token(Token = "0x6000034")]
			 set { } //Length: 69
		}

		[Token(Token = "0x1700000E")]
		public SignerInfo SignerInfo
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x6000035")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1E3ACF0", Offset = "0x1E3A0F0", Length = "0x89E")]
		[Token(Token = "0x6000031")]
		public SignedData(ASN1 asn1) { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000032")]
		public X509CertificateCollection get_Certificates() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000033")]
		public ContentInfo get_ContentInfo() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000035")]
		public SignerInfo get_SignerInfo() { }

		[Address(RVA = "0x1E3AB60", Offset = "0x1E39F60", Length = "0x181")]
		[Token(Token = "0x6000036")]
		internal string OidToName(string oid) { }

		[Address(RVA = "0x1E3B590", Offset = "0x1E3A990", Length = "0x45")]
		[Token(Token = "0x6000034")]
		public void set_HashName(string value) { }

	}

	[Token(Token = "0x200000A")]
	internal class SignerInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		private byte version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		private string hashAlgorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000013")]
		private ArrayList authenticatedAttributes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000014")]
		private ArrayList unauthenticatedAttributes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000015")]
		private Byte[] signature; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000016")]
		private string issuer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000017")]
		private Byte[] serial; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000018")]
		private Byte[] ski; //Field offset: 0x48

		[Token(Token = "0x17000011")]
		public ArrayList AuthenticatedAttributes
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x600003B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000012")]
		public string HashName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600003C")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x600003D")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700000F")]
		public string IssuerName
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x6000039")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000010")]
		public Byte[] SerialNumber
		{
			[Address(RVA = "0x1E3BB20", Offset = "0x1E3AF20", Length = "0x7B")]
			[Token(Token = "0x600003A")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000013")]
		public Byte[] Signature
		{
			[Address(RVA = "0x1E3BBA0", Offset = "0x1E3AFA0", Length = "0x7B")]
			[Token(Token = "0x600003E")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000014")]
		public ArrayList UnauthenticatedAttributes
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x600003F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000015")]
		public byte Version
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[Token(Token = "0x6000040")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1E3B5E0", Offset = "0x1E3A9E0", Length = "0x93")]
		[Token(Token = "0x6000037")]
		public SignerInfo() { }

		[Address(RVA = "0x1E3B680", Offset = "0x1E3AA80", Length = "0x49E")]
		[Token(Token = "0x6000038")]
		public SignerInfo(ASN1 asn1) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600003B")]
		public ArrayList get_AuthenticatedAttributes() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600003C")]
		public string get_HashName() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000039")]
		public string get_IssuerName() { }

		[Address(RVA = "0x1E3BB20", Offset = "0x1E3AF20", Length = "0x7B")]
		[Token(Token = "0x600003A")]
		public Byte[] get_SerialNumber() { }

		[Address(RVA = "0x1E3BBA0", Offset = "0x1E3AFA0", Length = "0x7B")]
		[Token(Token = "0x600003E")]
		public Byte[] get_Signature() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600003F")]
		public ArrayList get_UnauthenticatedAttributes() { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000040")]
		public byte get_Version() { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600003D")]
		public void set_HashName(string value) { }

	}


}

