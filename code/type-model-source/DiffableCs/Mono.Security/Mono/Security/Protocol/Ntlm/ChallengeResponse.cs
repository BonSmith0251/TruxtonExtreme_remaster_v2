namespace Mono.Security.Protocol.Ntlm;

[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
[Token(Token = "0x200002F")]
public class ChallengeResponse : IDisposable
{
	[Token(Token = "0x4000088")]
	private static Byte[] magic; //Field offset: 0x0
	[Token(Token = "0x4000089")]
	private static Byte[] nullEncMagic; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008A")]
	private bool _disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008B")]
	private Byte[] _challenge; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008C")]
	private Byte[] _lmpwd; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008D")]
	private Byte[] _ntpwd; //Field offset: 0x28

	[Token(Token = "0x17000050")]
	public Byte[] Challenge
	{
		[Address(RVA = "0x1E30610", Offset = "0x1E2FA10", Length = "0x14F")]
		[Token(Token = "0x600010C")]
		 set { } //Length: 335
	}

	[Token(Token = "0x17000051")]
	public Byte[] LM
	{
		[Address(RVA = "0x1E30530", Offset = "0x1E2F930", Length = "0x6C")]
		[Token(Token = "0x600010D")]
		 get { } //Length: 108
	}

	[Token(Token = "0x17000052")]
	public Byte[] NT
	{
		[Address(RVA = "0x1E305A0", Offset = "0x1E2F9A0", Length = "0x6C")]
		[Token(Token = "0x600010E")]
		 get { } //Length: 108
	}

	[Token(Token = "0x1700004F")]
	public string Password
	{
		[Address(RVA = "0x1E30760", Offset = "0x1E2FB60", Length = "0x3E9")]
		[Token(Token = "0x600010B")]
		 set { } //Length: 1001
	}

	[Address(RVA = "0x1E301F0", Offset = "0x1E2F5F0", Length = "0xEA")]
	[Token(Token = "0x6000114")]
	private static ChallengeResponse() { }

	[Address(RVA = "0x1E304B0", Offset = "0x1E2F8B0", Length = "0x7A")]
	[Token(Token = "0x6000108")]
	public ChallengeResponse() { }

	[Address(RVA = "0x1E302E0", Offset = "0x1E2F6E0", Length = "0x1CC")]
	[Token(Token = "0x6000109")]
	public ChallengeResponse(string password, Byte[] challenge) { }

	[Address(RVA = "0x1E2FA20", Offset = "0x1E2EE20", Length = "0xAB")]
	[Token(Token = "0x600010F")]
	public override void Dispose() { }

	[Address(RVA = "0x1E2FAD0", Offset = "0x1E2EED0", Length = "0x71")]
	[Token(Token = "0x6000110")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1E2FB50", Offset = "0x1E2EF50", Length = "0x10A")]
	[Token(Token = "0x600010A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E30530", Offset = "0x1E2F930", Length = "0x6C")]
	[Token(Token = "0x600010D")]
	public Byte[] get_LM() { }

	[Address(RVA = "0x1E305A0", Offset = "0x1E2F9A0", Length = "0x6C")]
	[Token(Token = "0x600010E")]
	public Byte[] get_NT() { }

	[Address(RVA = "0x1E2FC60", Offset = "0x1E2F060", Length = "0x243")]
	[Token(Token = "0x6000111")]
	private Byte[] GetResponse(Byte[] pwd) { }

	[Address(RVA = "0x1E2FEB0", Offset = "0x1E2F2B0", Length = "0x152")]
	[Token(Token = "0x6000113")]
	private Byte[] PasswordToKey(string password, int position) { }

	[Address(RVA = "0x1E30010", Offset = "0x1E2F410", Length = "0x1D8")]
	[Token(Token = "0x6000112")]
	private Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	[Address(RVA = "0x1E30610", Offset = "0x1E2FA10", Length = "0x14F")]
	[Token(Token = "0x600010C")]
	public void set_Challenge(Byte[] value) { }

	[Address(RVA = "0x1E30760", Offset = "0x1E2FB60", Length = "0x3E9")]
	[Token(Token = "0x600010B")]
	public void set_Password(string value) { }

}

