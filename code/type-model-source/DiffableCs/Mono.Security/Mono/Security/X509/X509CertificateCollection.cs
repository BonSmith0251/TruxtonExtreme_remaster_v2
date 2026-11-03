namespace Mono.Security.X509;

[DefaultMember("Item")]
[Token(Token = "0x2000012")]
public class X509CertificateCollection : CollectionBase, IEnumerable
{
	[Token(Token = "0x2000013")]
	internal class X509CertificateEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000061")]
		private IEnumerator enumerator; //Field offset: 0x10

		[Token(Token = "0x1700003B")]
		public X509Certificate Current
		{
			[Address(RVA = "0x1E3F220", Offset = "0x1E3E620", Length = "0x95")]
			[Token(Token = "0x60000B6")]
			 get { } //Length: 149
		}

		[Token(Token = "0x1700003C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1E3F160", Offset = "0x1E3E560", Length = "0x49")]
			[Token(Token = "0x60000B7")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x1E3F1B0", Offset = "0x1E3E5B0", Length = "0x6B")]
		[Token(Token = "0x60000B5")]
		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		[Address(RVA = "0x1E3F220", Offset = "0x1E3E620", Length = "0x95")]
		[Token(Token = "0x60000B6")]
		public X509Certificate get_Current() { }

		[Address(RVA = "0x1E3F070", Offset = "0x1E3E470", Length = "0x46")]
		[Token(Token = "0x60000BA")]
		public bool MoveNext() { }

		[Address(RVA = "0x1E3F160", Offset = "0x1E3E560", Length = "0x49")]
		[Token(Token = "0x60000B7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E3F0C0", Offset = "0x1E3E4C0", Length = "0x46")]
		[Token(Token = "0x60000B8")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x1E3F110", Offset = "0x1E3E510", Length = "0x49")]
		[Token(Token = "0x60000B9")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Token(Token = "0x1700003A")]
	public X509Certificate Item
	{
		[Address(RVA = "0x1E3EFD0", Offset = "0x1E3E3D0", Length = "0x98")]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 152
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x60000AB")]
	public X509CertificateCollection() { }

	[Address(RVA = "0x1E3EBD0", Offset = "0x1E3DFD0", Length = "0x81")]
	[Token(Token = "0x60000AD")]
	public int Add(X509Certificate value) { }

	[Address(RVA = "0x1E3EA70", Offset = "0x1E3DE70", Length = "0x15E")]
	[Token(Token = "0x60000AE")]
	public void AddRange(X509CertificateCollection value) { }

	[Address(RVA = "0x1E3EC60", Offset = "0x1E3E060", Length = "0x6B")]
	[Token(Token = "0x60000B4")]
	private bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x1E3ECD0", Offset = "0x1E3E0D0", Length = "0x17")]
	[Token(Token = "0x60000AF")]
	public bool Contains(X509Certificate value) { }

	[Address(RVA = "0x1E3EFD0", Offset = "0x1E3E3D0", Length = "0x98")]
	[Token(Token = "0x60000AC")]
	public X509Certificate get_Item(int index) { }

	[Address(RVA = "0x1E3ECF0", Offset = "0x1E3E0F0", Length = "0x97")]
	[Token(Token = "0x60000B0")]
	public X509CertificateEnumerator GetEnumerator() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x60000B2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E3EDC0", Offset = "0x1E3E1C0", Length = "0x1CB")]
	[Token(Token = "0x60000B3")]
	public int IndexOf(X509Certificate value) { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x60000B1")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

