namespace Mono.Net.Security.Private;

[Token(Token = "0x2000065")]
internal static class CallbackHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x2000066")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012D")]
		public RemoteCertificateValidationCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000174")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x22CE500", Offset = "0x22CD900", Length = "0x2A")]
		[Token(Token = "0x6000175")]
		internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000067")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012E")]
		public MonoLocalCertificateSelectionCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000176")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x22CE500", Offset = "0x22CD900", Length = "0x2A")]
		[Token(Token = "0x6000177")]
		internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}


	[Address(RVA = "0x22BB670", Offset = "0x22BAA70", Length = "0xBA")]
	[Token(Token = "0x6000173")]
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

	[Address(RVA = "0x22BB730", Offset = "0x22BAB30", Length = "0xBA")]
	[Token(Token = "0x6000172")]
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

}

