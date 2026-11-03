namespace Mono.Btls;

[Token(Token = "0x200006B")]
internal class MonoBtlsBio : MonoBtlsObject
{
	[Token(Token = "0x200006C")]
	private class BoringBioHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x22BAFD0", Offset = "0x22BA3D0", Length = "0xB")]
		[Token(Token = "0x6000185")]
		public BoringBioHandle(IntPtr handle) { }

		[Address(RVA = "0x22BAF30", Offset = "0x22BA330", Length = "0x97")]
		[Token(Token = "0x6000186")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000057")]
	protected private BoringBioHandle Handle
	{
		[Address(RVA = "0x22C13D0", Offset = "0x22C07D0", Length = "0x75")]
		[Token(Token = "0x6000183")]
		private get { } //Length: 117
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000182")]
	internal MonoBtlsBio(BoringBioHandle handle) { }

	[Address(RVA = "0x22C13D0", Offset = "0x22C07D0", Length = "0x75")]
	[Token(Token = "0x6000183")]
	protected private BoringBioHandle get_Handle() { }

	[Address(RVA = "0x22C1450", Offset = "0x22C0850", Length = "0x78")]
	[Token(Token = "0x6000184")]
	private static void mono_btls_bio_free(IntPtr handle) { }

}

