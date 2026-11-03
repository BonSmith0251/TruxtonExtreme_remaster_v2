namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000032")]
public enum NtlmAuthLevel : int
{
	LM_and_NTLM = 0,
	LM_and_NTLM_and_try_NTLMv2_Session = 1,
	NTLM_only = 2,
	NTLMv2_only = 3,
}

