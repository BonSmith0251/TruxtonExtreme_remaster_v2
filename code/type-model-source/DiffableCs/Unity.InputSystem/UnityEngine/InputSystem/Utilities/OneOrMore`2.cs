namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
[Token(Token = "0x2000260")]
internal struct OneOrMore : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	[Token(Token = "0x2000261")]
	private class Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CCA")]
		internal int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CCB")]
		internal OneOrMore<TValue, TList> m_List; //Field offset: 0x0

		[Token(Token = "0x17000605")]
		public override TValue Current
		{
			[Address(RVA = "0x19BFC00", Offset = "0x19BF000", Length = "0x1F")]
			[Token(Token = "0x6001607")]
			 get { } //Length: 31
		}

		[Token(Token = "0x17000606")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19BCFD0", Offset = "0x19BC3D0", Length = "0x2E")]
			[Token(Token = "0x6001608")]
			private get { } //Length: 46
		}

		[Address(RVA = "0x19BFBF0", Offset = "0x19BEFF0", Length = "0xE")]
		[Token(Token = "0x600160A")]
		public Enumerator() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001609")]
		public override void Dispose() { }

		[Address(RVA = "0x19BFC00", Offset = "0x19BF000", Length = "0x1F")]
		[Token(Token = "0x6001607")]
		public override TValue get_Current() { }

		[Address(RVA = "0x19BBE50", Offset = "0x19BB250", Length = "0x31")]
		[Token(Token = "0x6001605")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195F910", Offset = "0x195ED10", Length = "0x8")]
		[Token(Token = "0x6001606")]
		public override void Reset() { }

		[Address(RVA = "0x19BCFD0", Offset = "0x19BC3D0", Length = "0x2E")]
		[Token(Token = "0x6001608")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC7")]
	private readonly bool m_IsSingle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC8")]
	private readonly TValue m_Single; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC9")]
	private readonly TList m_Multiple; //Field offset: 0x0

	[Token(Token = "0x17000603")]
	public override int Count
	{
		[Address(RVA = "0xE111C0", Offset = "0xE105C0", Length = "0x41")]
		[Token(Token = "0x60015FD")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000604")]
	public override TValue Item
	{
		[Address(RVA = "0xE11520", Offset = "0xE10920", Length = "0xAC")]
		[Token(Token = "0x60015FE")]
		 get { } //Length: 172
	}

	[Address(RVA = "0xE10DA0", Offset = "0xE101A0", Length = "0x26")]
	[Token(Token = "0x60015FF")]
	public OneOrMore`2(TValue single) { }

	[Address(RVA = "0xE10DD0", Offset = "0xE101D0", Length = "0x1B")]
	[Token(Token = "0x6001600")]
	public OneOrMore`2(TList multiple) { }

	[Address(RVA = "0xE111C0", Offset = "0xE105C0", Length = "0x41")]
	[Token(Token = "0x60015FD")]
	public override int get_Count() { }

	[Address(RVA = "0xE11520", Offset = "0xE10920", Length = "0xAC")]
	[Token(Token = "0x60015FE")]
	public override TValue get_Item(int index) { }

	[Address(RVA = "0xE10A70", Offset = "0xE0FE70", Length = "0xB0")]
	[Token(Token = "0x6001603")]
	public override IEnumerator<TValue> GetEnumerator() { }

	[Address(RVA = "0xE11630", Offset = "0xE10A30", Length = "0x54")]
	[Token(Token = "0x6001601")]
	public static OneOrMore<TValue, TList> op_Implicit(TValue single) { }

	[Address(RVA = "0xE115D0", Offset = "0xE109D0", Length = "0x55")]
	[Token(Token = "0x6001602")]
	public static OneOrMore<TValue, TList> op_Implicit(TList multiple) { }

	[Address(RVA = "0xE10B30", Offset = "0xE0FF30", Length = "0x36")]
	[Token(Token = "0x6001604")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

