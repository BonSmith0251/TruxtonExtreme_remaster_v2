namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x2000132")]
public class X509CertificateCollection : CollectionBase
{
	[Token(Token = "0x2000133")]
	internal class X509CertificateEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000597")]
		private IEnumerator enumerator; //Field offset: 0x10

		[Token(Token = "0x1700014D")]
		public X509Certificate Current
		{
			[Address(RVA = "0x26511A0", Offset = "0x26505A0", Length = "0x95")]
			[Token(Token = "0x6000762")]
			 get { } //Length: 149
		}

		[Token(Token = "0x1700014E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x26510E0", Offset = "0x26504E0", Length = "0x49")]
			[Token(Token = "0x6000763")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x2651130", Offset = "0x2650530", Length = "0x6B")]
		[Token(Token = "0x6000761")]
		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		[Address(RVA = "0x26511A0", Offset = "0x26505A0", Length = "0x95")]
		[Token(Token = "0x6000762")]
		public X509Certificate get_Current() { }

		[Address(RVA = "0x2650FF0", Offset = "0x26503F0", Length = "0x46")]
		[Token(Token = "0x6000766")]
		public bool MoveNext() { }

		[Address(RVA = "0x26510E0", Offset = "0x26504E0", Length = "0x49")]
		[Token(Token = "0x6000763")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2651040", Offset = "0x2650440", Length = "0x46")]
		[Token(Token = "0x6000764")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x2651090", Offset = "0x2650490", Length = "0x49")]
		[Token(Token = "0x6000765")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Token(Token = "0x1700014C")]
	public X509Certificate Item
	{
		[Address(RVA = "0x2650F50", Offset = "0x2650350", Length = "0x98")]
		[Token(Token = "0x600075C")]
		 get { } //Length: 152
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x600075A")]
	public X509CertificateCollection() { }

	[Address(RVA = "0x2650DF0", Offset = "0x26501F0", Length = "0x15E")]
	[Token(Token = "0x600075B")]
	public X509CertificateCollection(X509CertificateCollection value) { }

	[Address(RVA = "0x2650CC0", Offset = "0x26500C0", Length = "0x81")]
	[Token(Token = "0x600075D")]
	public int Add(X509Certificate value) { }

	[Address(RVA = "0x2650B60", Offset = "0x264FF60", Length = "0x15E")]
	[Token(Token = "0x600075E")]
	public void AddRange(X509CertificateCollection value) { }

	[Address(RVA = "0x2650F50", Offset = "0x2650350", Length = "0x98")]
	[Token(Token = "0x600075C")]
	public X509Certificate get_Item(int index) { }

	[Address(RVA = "0x2650D50", Offset = "0x2650150", Length = "0x97")]
	[Token(Token = "0x600075F")]
	public X509CertificateEnumerator GetEnumerator() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6000760")]
	public virtual int GetHashCode() { }

}

