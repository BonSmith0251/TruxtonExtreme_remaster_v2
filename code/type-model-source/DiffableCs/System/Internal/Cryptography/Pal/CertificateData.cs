namespace Internal.Cryptography.Pal;

[Token(Token = "0x20000AF")]
internal struct CertificateData
{
	[CompilerGenerated]
	[Token(Token = "0x20000B1")]
	private sealed class <ReadReverseRdns>d__21 : IEnumerable<KeyValuePair`2<String, String>>, IEnumerable, IEnumerator<KeyValuePair`2<String, String>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000225")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000226")]
		private KeyValuePair<String, String> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000227")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000228")]
		private X500DistinguishedName name; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000229")]
		public X500DistinguishedName <>3__name; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400022A")]
		private Stack<DerSequenceReader> <rdnReaders>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400022B")]
		private DerSequenceReader <rdnReader>5__3; //Field offset: 0x48

		[Token(Token = "0x17000082")]
		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000349")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000083")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x260D670", Offset = "0x260CA70", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x600034B")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000346")]
		public <ReadReverseRdns>d__21(int <>1__state) { }

		[Address(RVA = "0x260D2F0", Offset = "0x260C6F0", Length = "0x299")]
		[Token(Token = "0x6000348")]
		private override bool MoveNext() { }

		[Address(RVA = "0x260D590", Offset = "0x260C990", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600034C")]
		private override IEnumerator<KeyValuePair`2<String, String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000349")]
		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[Address(RVA = "0x260D590", Offset = "0x260C990", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600034D")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x260D670", Offset = "0x260CA70", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x600034B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x260D630", Offset = "0x260CA30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600034A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000347")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000B0")]
	public struct AlgorithmIdentifier
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000223")]
		internal string AlgorithmId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000224")]
		internal Byte[] Parameters; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000213")]
	internal Byte[] RawData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000214")]
	internal Byte[] SubjectPublicKeyInfo; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000215")]
	internal int Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000216")]
	internal Byte[] SerialNumber; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000217")]
	internal AlgorithmIdentifier TbsSignature; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000218")]
	internal X500DistinguishedName Issuer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000219")]
	internal DateTime NotBefore; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400021A")]
	internal DateTime NotAfter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021B")]
	internal X500DistinguishedName Subject; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400021C")]
	internal AlgorithmIdentifier PublicKeyAlgorithm; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400021D")]
	internal Byte[] PublicKey; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021E")]
	internal Byte[] IssuerUniqueId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400021F")]
	internal Byte[] SubjectUniqueId; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000220")]
	internal List<X509Extension> Extensions; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000221")]
	internal AlgorithmIdentifier SignatureAlgorithm; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000222")]
	internal Byte[] SignatureValue; //Field offset: 0x90

	[Address(RVA = "0x25FA070", Offset = "0x25F9470", Length = "0x912")]
	[Token(Token = "0x6000341")]
	internal CertificateData(Byte[] rawData) { }

	[Address(RVA = "0x25F9580", Offset = "0x25F8980", Length = "0xB0")]
	[Token(Token = "0x6000344")]
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[Address(RVA = "0x25F9730", Offset = "0x25F8B30", Length = "0x50C")]
	[Token(Token = "0x6000342")]
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Address(RVA = "0x25F9C60", Offset = "0x25F9060", Length = "0x380")]
	[Token(Token = "0x6000343")]
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	[Address(RVA = "0x25F9FF0", Offset = "0x25F93F0", Length = "0x71")]
	[IteratorStateMachine(typeof(<ReadReverseRdns>d__21))]
	[Token(Token = "0x6000345")]
	private static IEnumerable<KeyValuePair`2<String, String>> ReadReverseRdns(X500DistinguishedName name) { }

}

