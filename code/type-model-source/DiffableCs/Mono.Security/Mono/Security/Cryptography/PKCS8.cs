namespace Mono.Security.Cryptography;

[Token(Token = "0x200004E")]
public sealed class PKCS8
{
	[Token(Token = "0x2000050")]
	internal class EncryptedPrivateKeyInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000220")]
		private string _algorithm; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000221")]
		private Byte[] _salt; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000222")]
		private int _iterations; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000223")]
		private Byte[] _data; //Field offset: 0x28

		[Token(Token = "0x1700007D")]
		public string Algorithm
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60001B7")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x60001B8")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700007E")]
		public Byte[] EncryptedData
		{
			[Address(RVA = "0x1E4C790", Offset = "0x1E4BB90", Length = "0x79")]
			[Token(Token = "0x60001B9")]
			 get { } //Length: 121
			[Address(RVA = "0x1E4C8E0", Offset = "0x1E4BCE0", Length = "0x98")]
			[Token(Token = "0x60001BA")]
			 set { } //Length: 152
		}

		[Token(Token = "0x17000080")]
		public int IterationCount
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x60001BC")]
			 get { } //Length: 4
			[Address(RVA = "0x1E4C980", Offset = "0x1E4BD80", Length = "0x7E")]
			[Token(Token = "0x60001BD")]
			 set { } //Length: 126
		}

		[Token(Token = "0x1700007F")]
		public Byte[] Salt
		{
			[Address(RVA = "0x1E4C810", Offset = "0x1E4BC10", Length = "0xC9")]
			[Token(Token = "0x60001BB")]
			 get { } //Length: 201
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001B5")]
		public EncryptedPrivateKeyInfo() { }

		[Address(RVA = "0x1E4C760", Offset = "0x1E4BB60", Length = "0x2F")]
		[Token(Token = "0x60001B6")]
		public EncryptedPrivateKeyInfo(Byte[] data) { }

		[Address(RVA = "0x1E4C1B0", Offset = "0x1E4B5B0", Length = "0x3A5")]
		[Token(Token = "0x60001BE")]
		private void Decode(Byte[] data) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001B7")]
		public string get_Algorithm() { }

		[Address(RVA = "0x1E4C790", Offset = "0x1E4BB90", Length = "0x79")]
		[Token(Token = "0x60001B9")]
		public Byte[] get_EncryptedData() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60001BC")]
		public int get_IterationCount() { }

		[Address(RVA = "0x1E4C810", Offset = "0x1E4BC10", Length = "0xC9")]
		[Token(Token = "0x60001BB")]
		public Byte[] get_Salt() { }

		[Address(RVA = "0x1E4C560", Offset = "0x1E4B960", Length = "0x1F0")]
		[Token(Token = "0x60001BF")]
		public Byte[] GetBytes() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60001B8")]
		public void set_Algorithm(string value) { }

		[Address(RVA = "0x1E4C8E0", Offset = "0x1E4BCE0", Length = "0x98")]
		[Token(Token = "0x60001BA")]
		public void set_EncryptedData(Byte[] value) { }

		[Address(RVA = "0x1E4C980", Offset = "0x1E4BD80", Length = "0x7E")]
		[Token(Token = "0x60001BD")]
		public void set_IterationCount(int value) { }

	}

	[Token(Token = "0x200004F")]
	internal class PrivateKeyInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021C")]
		private int _version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021D")]
		private string _algorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400021E")]
		private Byte[] _key; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400021F")]
		private ArrayList _list; //Field offset: 0x28

		[Token(Token = "0x1700007B")]
		public string Algorithm
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60001A8")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x60001A9")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700007C")]
		public Byte[] PrivateKey
		{
			[Address(RVA = "0x1E55680", Offset = "0x1E54A80", Length = "0x7B")]
			[Token(Token = "0x60001AA")]
			 get { } //Length: 123
			[Address(RVA = "0x1E55700", Offset = "0x1E54B00", Length = "0xFC")]
			[Token(Token = "0x60001AB")]
			 set { } //Length: 252
		}

		[Address(RVA = "0x1E55580", Offset = "0x1E54980", Length = "0x6D")]
		[Token(Token = "0x60001A6")]
		public PrivateKeyInfo() { }

		[Address(RVA = "0x1E555F0", Offset = "0x1E549F0", Length = "0x88")]
		[Token(Token = "0x60001A7")]
		public PrivateKeyInfo(Byte[] data) { }

		[Address(RVA = "0x1E548C0", Offset = "0x1E53CC0", Length = "0x2FC")]
		[Token(Token = "0x60001AC")]
		private void Decode(Byte[] data) { }

		[Address(RVA = "0x1E54200", Offset = "0x1E53600", Length = "0x1B8")]
		[Token(Token = "0x60001B2")]
		public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

		[Address(RVA = "0x1E543C0", Offset = "0x1E537C0", Length = "0x4F6")]
		[Token(Token = "0x60001B0")]
		public static RSA DecodeRSA(Byte[] keypair) { }

		[Address(RVA = "0x1E54C20", Offset = "0x1E54020", Length = "0x220")]
		[Token(Token = "0x60001B1")]
		public static Byte[] Encode(RSA rsa) { }

		[Address(RVA = "0x1E54BC0", Offset = "0x1E53FC0", Length = "0x5D")]
		[Token(Token = "0x60001B3")]
		public static Byte[] Encode(DSA dsa) { }

		[Address(RVA = "0x1E54E50", Offset = "0x1E54250", Length = "0x1D0")]
		[Token(Token = "0x60001B4")]
		public static Byte[] Encode(AsymmetricAlgorithm aa) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001A8")]
		public string get_Algorithm() { }

		[Address(RVA = "0x1E55680", Offset = "0x1E54A80", Length = "0x7B")]
		[Token(Token = "0x60001AA")]
		public Byte[] get_PrivateKey() { }

		[Address(RVA = "0x1E55030", Offset = "0x1E54430", Length = "0x3EC")]
		[Token(Token = "0x60001AD")]
		public Byte[] GetBytes() { }

		[Address(RVA = "0x1E55420", Offset = "0x1E54820", Length = "0xA9")]
		[Token(Token = "0x60001AF")]
		private static Byte[] Normalize(Byte[] bigInt, int length) { }

		[Address(RVA = "0x1E554D0", Offset = "0x1E548D0", Length = "0xA5")]
		[Token(Token = "0x60001AE")]
		private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60001A9")]
		public void set_Algorithm(string value) { }

		[Address(RVA = "0x1E55700", Offset = "0x1E54B00", Length = "0xFC")]
		[Token(Token = "0x60001AB")]
		public void set_PrivateKey(Byte[] value) { }

	}


}

