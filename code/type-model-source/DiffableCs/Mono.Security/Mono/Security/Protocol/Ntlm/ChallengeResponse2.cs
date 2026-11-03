namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000030")]
public static class ChallengeResponse2
{
	[Token(Token = "0x400008E")]
	private static Byte[] magic; //Field offset: 0x0
	[Token(Token = "0x400008F")]
	private static Byte[] nullEncMagic; //Field offset: 0x8

	[Address(RVA = "0x1E2F930", Offset = "0x1E2ED30", Length = "0xEA")]
	[Token(Token = "0x600011E")]
	private static ChallengeResponse2() { }

	[Address(RVA = "0x1E2F150", Offset = "0x1E2E550", Length = "0x20D")]
	[Token(Token = "0x600011A")]
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Byte[] lm, out Byte[] ntlm) { }

	[Address(RVA = "0x1E2E570", Offset = "0x1E2D970", Length = "0x2E8")]
	[Token(Token = "0x6000115")]
	private static Byte[] Compute_LM(string password, Byte[] challenge) { }

	[Address(RVA = "0x1E2E970", Offset = "0x1E2DD70", Length = "0x63")]
	[Token(Token = "0x6000117")]
	private static Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	[Address(RVA = "0x1E2E860", Offset = "0x1E2DC60", Length = "0x109")]
	[Token(Token = "0x6000116")]
	private static Byte[] Compute_NTLM_Password(string password) { }

	[Address(RVA = "0x1E2EC10", Offset = "0x1E2E010", Length = "0x538")]
	[Token(Token = "0x6000119")]
	private static Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	[Address(RVA = "0x1E2E9E0", Offset = "0x1E2DDE0", Length = "0x229")]
	[Token(Token = "0x6000118")]
	private static void Compute_NTLMv2_Session(string password, Byte[] challenge, out Byte[] lm, out Byte[] ntlm) { }

	[Address(RVA = "0x1E2F360", Offset = "0x1E2E760", Length = "0x255")]
	[Token(Token = "0x600011B")]
	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	[Address(RVA = "0x1E2F5C0", Offset = "0x1E2E9C0", Length = "0x173")]
	[Token(Token = "0x600011D")]
	private static Byte[] PasswordToKey(string password, int position) { }

	[Address(RVA = "0x1E2F740", Offset = "0x1E2EB40", Length = "0x1EC")]
	[Token(Token = "0x600011C")]
	private static Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

}

