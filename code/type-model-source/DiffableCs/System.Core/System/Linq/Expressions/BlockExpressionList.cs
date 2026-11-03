namespace System.Linq.Expressions;

[DefaultMember("Item")]
[Token(Token = "0x200006F")]
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000070")]
	private sealed class <GetEnumerator>d__18 : IEnumerator<Expression>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F1")]
		private Expression <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F2")]
		public BlockExpressionList <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F3")]
		private int <i>5__2; //Field offset: 0x28

		[Token(Token = "0x17000068")]
		private override Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002D9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000069")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60002DB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60002D6")]
		public <GetEnumerator>d__18(int <>1__state) { }

		[Address(RVA = "0x226C000", Offset = "0x226B400", Length = "0x103")]
		[Token(Token = "0x60002D8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60002D9")]
		private override Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60002DB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x226C110", Offset = "0x226B510", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60002DA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60002D7")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EE")]
	private readonly BlockExpression _block; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EF")]
	private readonly Expression _arg0; //Field offset: 0x18

	[Token(Token = "0x17000066")]
	public override int Count
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x60002D1")]
		 get { } //Length: 42
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000067")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2253350", Offset = "0x2252750", Length = "0x27")]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000065")]
	public override Expression Item
	{
		[Address(RVA = "0x2253380", Offset = "0x2252780", Length = "0x37")]
		[Token(Token = "0x60002CB")]
		 get { } //Length: 55
		[Address(RVA = "0x22533C0", Offset = "0x22527C0", Length = "0x27")]
		[ExcludeFromCodeCoverage]
		[Token(Token = "0x60002CC")]
		 set { } //Length: 39
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60002C7")]
	internal BlockExpressionList(BlockExpression provider, Expression arg0) { }

	[Address(RVA = "0x2252E60", Offset = "0x2252260", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002CD")]
	public override void Add(Expression item) { }

	[Address(RVA = "0x2252E90", Offset = "0x2252290", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002CE")]
	public override void Clear() { }

	[Address(RVA = "0x2252EC0", Offset = "0x22522C0", Length = "0xA2")]
	[Token(Token = "0x60002CF")]
	public override bool Contains(Expression item) { }

	[Address(RVA = "0x2252F70", Offset = "0x2252370", Length = "0x221")]
	[Token(Token = "0x60002D0")]
	public override void CopyTo(Expression[] array, int index) { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x60002D1")]
	public override int get_Count() { }

	[Address(RVA = "0x2253350", Offset = "0x2252750", Length = "0x27")]
	[Token(Token = "0x60002D2")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x2253380", Offset = "0x2252780", Length = "0x37")]
	[Token(Token = "0x60002CB")]
	public override Expression get_Item(int index) { }

	[Address(RVA = "0x22531A0", Offset = "0x22525A0", Length = "0x67")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__18))]
	[Token(Token = "0x60002D4")]
	public override IEnumerator<Expression> GetEnumerator() { }

	[Address(RVA = "0x2253210", Offset = "0x2252610", Length = "0xAD")]
	[Token(Token = "0x60002C8")]
	public override int IndexOf(Expression item) { }

	[Address(RVA = "0x22532C0", Offset = "0x22526C0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002C9")]
	public override void Insert(int index, Expression item) { }

	[Address(RVA = "0x2253320", Offset = "0x2252720", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002D3")]
	public override bool Remove(Expression item) { }

	[Address(RVA = "0x22532F0", Offset = "0x22526F0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002CA")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x22533C0", Offset = "0x22527C0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60002CC")]
	public override void set_Item(int index, Expression value) { }

	[Address(RVA = "0x22531A0", Offset = "0x22525A0", Length = "0x67")]
	[Token(Token = "0x60002D5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

