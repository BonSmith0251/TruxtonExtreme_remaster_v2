namespace System.Collections.Generic;

[Token(Token = "0x2000612")]
internal sealed class LowLevelListWithIList : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[Token(Token = "0x2000613")]
	private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A8")]
		private LowLevelListWithIList<T> _list; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A9")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018AA")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018AB")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x17000739")]
		public override T Current
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6002D65")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700073A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19903A0", Offset = "0x198F7A0", Length = "0x7B")]
			[Token(Token = "0x6002D66")]
			private get { } //Length: 123
		}

		[Address(RVA = "0x195B960", Offset = "0x195AD60", Length = "0x40")]
		[Token(Token = "0x6002D61")]
		internal Enumerator(LowLevelListWithIList<T> list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002D62")]
		public override void Dispose() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002D65")]
		public override T get_Current() { }

		[Address(RVA = "0x198E860", Offset = "0x198DC60", Length = "0x88")]
		[Token(Token = "0x6002D63")]
		public override bool MoveNext() { }

		[Address(RVA = "0x198BCD0", Offset = "0x198B0D0", Length = "0x6C")]
		[Token(Token = "0x6002D64")]
		private bool MoveNextRare() { }

		[Address(RVA = "0x19903A0", Offset = "0x198F7A0", Length = "0x7B")]
		[Token(Token = "0x6002D66")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x198F0E0", Offset = "0x198E4E0", Length = "0x68")]
		[Token(Token = "0x6002D67")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Token(Token = "0x17000738")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002D5E")]
		private get { } //Length: 3
	}

	[Address(RVA = "0xCF4BB0", Offset = "0xCF3FB0", Length = "0xCB")]
	[Token(Token = "0x6002D5C")]
	public LowLevelListWithIList`1() { }

	[Address(RVA = "0xCF4C80", Offset = "0xCF4080", Length = "0x14A")]
	[Token(Token = "0x6002D5D")]
	public LowLevelListWithIList`1(int capacity) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002D5E")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xCF4A50", Offset = "0xCF3E50", Length = "0x69")]
	[Token(Token = "0x6002D5F")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xCF4A50", Offset = "0xCF3E50", Length = "0x69")]
	[Token(Token = "0x6002D60")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

