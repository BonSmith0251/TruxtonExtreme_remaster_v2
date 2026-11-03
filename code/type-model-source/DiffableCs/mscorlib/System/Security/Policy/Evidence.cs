namespace System.Security.Policy;

[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
[Token(Token = "0x20002DF")]
public sealed class Evidence : ICollection, IEnumerable
{
	[Token(Token = "0x20002E0")]
	private class EvidenceEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C5A")]
		private IEnumerator currentEnum; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C5B")]
		private IEnumerator hostEnum; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C5C")]
		private IEnumerator assemblyEnum; //Field offset: 0x20

		[Token(Token = "0x1700025E")]
		public override object Current
		{
			[Address(RVA = "0x1EA5570", Offset = "0x1EA4970", Length = "0x49")]
			[Token(Token = "0x60017FF")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x1EA5510", Offset = "0x1EA4910", Length = "0x5F")]
		[Token(Token = "0x60017FC")]
		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum) { }

		[Address(RVA = "0x1EA5570", Offset = "0x1EA4970", Length = "0x49")]
		[Token(Token = "0x60017FF")]
		public override object get_Current() { }

		[Address(RVA = "0x1EA53F0", Offset = "0x1EA47F0", Length = "0x8D")]
		[Token(Token = "0x60017FD")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1EA5480", Offset = "0x1EA4880", Length = "0x82")]
		[Token(Token = "0x60017FE")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C57")]
	private bool _locked; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C58")]
	private ArrayList hostEvidenceList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C59")]
	private ArrayList assemblyEvidenceList; //Field offset: 0x20

	[Obsolete]
	[Token(Token = "0x1700025B")]
	public override int Count
	{
		[Address(RVA = "0x1EA5760", Offset = "0x1EA4B60", Length = "0x67")]
		[Token(Token = "0x60017F7")]
		 get { } //Length: 103
	}

	[Token(Token = "0x1700025C")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017F8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700025D")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60017F9")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60017F6")]
	public Evidence() { }

	[Address(RVA = "0x1EA55C0", Offset = "0x1EA49C0", Length = "0xC4")]
	[Obsolete]
	[Token(Token = "0x60017FA")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1EA5760", Offset = "0x1EA4B60", Length = "0x67")]
	[Token(Token = "0x60017F7")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60017F8")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60017F9")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1EA5690", Offset = "0x1EA4A90", Length = "0xD0")]
	[Obsolete]
	[Token(Token = "0x60017FB")]
	public override IEnumerator GetEnumerator() { }

}

