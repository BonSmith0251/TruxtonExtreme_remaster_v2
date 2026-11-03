namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView))]
[Token(Token = "0x20005BF")]
public class Stack : ICollection, IEnumerable, ICloneable
{
	[Token(Token = "0x20005C1")]
	public class StackDebugView
	{

	}

	[Token(Token = "0x20005C0")]
	private class StackEnumerator : IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017E3")]
		private Stack _stack; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017E4")]
		private int _index; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40017E5")]
		private int _version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017E6")]
		private object _currentElement; //Field offset: 0x20

		[Token(Token = "0x17000666")]
		public override object Current
		{
			[Address(RVA = "0x1FCE850", Offset = "0x1FCDC50", Length = "0xAD")]
			[Token(Token = "0x6002A41")]
			 get { } //Length: 173
		}

		[Address(RVA = "0x1FCE7F0", Offset = "0x1FCDBF0", Length = "0x5F")]
		[Token(Token = "0x6002A3E")]
		internal StackEnumerator(Stack stack) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6002A3F")]
		public override object Clone() { }

		[Address(RVA = "0x1FCE850", Offset = "0x1FCDC50", Length = "0xAD")]
		[Token(Token = "0x6002A41")]
		public override object get_Current() { }

		[Address(RVA = "0x1FCE620", Offset = "0x1FCDA20", Length = "0x13E")]
		[Token(Token = "0x6002A40")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FCE760", Offset = "0x1FCDB60", Length = "0x8B")]
		[Token(Token = "0x6002A42")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017DF")]
	private Object[] _array; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017E0")]
	private int _size; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017E1")]
	private int _version; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017E2")]
	private object _syncRoot; //Field offset: 0x20

	[Token(Token = "0x17000663")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002A34")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000664")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002A35")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000665")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FD0B30", Offset = "0x1FCFF30", Length = "0x68")]
		[Token(Token = "0x6002A36")]
		 get { } //Length: 104
	}

	[Address(RVA = "0x1FD0AD0", Offset = "0x1FCFED0", Length = "0x5C")]
	[Token(Token = "0x6002A32")]
	public Stack() { }

	[Address(RVA = "0x1FD0A00", Offset = "0x1FCFE00", Length = "0xCA")]
	[Token(Token = "0x6002A33")]
	public Stack(int initialCapacity) { }

	[Address(RVA = "0xFC78E0", Offset = "0xFC6CE0", Length = "0x2B")]
	[Token(Token = "0x6002A37")]
	public override void Clear() { }

	[Address(RVA = "0x1FD0310", Offset = "0x1FCF710", Length = "0x12F")]
	[Token(Token = "0x6002A38")]
	public override object Clone() { }

	[Address(RVA = "0x1FD0440", Offset = "0x1FCF840", Length = "0x2CA")]
	[Token(Token = "0x6002A39")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002A34")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002A35")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FD0B30", Offset = "0x1FCFF30", Length = "0x68")]
	[Token(Token = "0x6002A36")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FD0710", Offset = "0x1FCFB10", Length = "0x8E")]
	[Token(Token = "0x6002A3A")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FD07A0", Offset = "0x1FCFBA0", Length = "0x86")]
	[Token(Token = "0x6002A3B")]
	public override object Peek() { }

	[Address(RVA = "0x1FD0830", Offset = "0x1FCFC30", Length = "0xB6")]
	[Token(Token = "0x6002A3C")]
	public override object Pop() { }

	[Address(RVA = "0x1FD08F0", Offset = "0x1FCFCF0", Length = "0x10D")]
	[Token(Token = "0x6002A3D")]
	public override void Push(object obj) { }

}

