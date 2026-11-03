namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000034")]
public static class NtlmSettings
{
	[Token(Token = "0x40000A3")]
	private static NtlmAuthLevel defaultAuthLevel; //Field offset: 0x0

	[Token(Token = "0x17000055")]
	public static NtlmAuthLevel DefaultAuthLevel
	{
		[Address(RVA = "0x1E52430", Offset = "0x1E51830", Length = "0x4D")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x1E523F0", Offset = "0x1E517F0", Length = "0x39")]
	[Token(Token = "0x6000129")]
	private static NtlmSettings() { }

	[Address(RVA = "0x1E52430", Offset = "0x1E51830", Length = "0x4D")]
	[Token(Token = "0x6000128")]
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

}

