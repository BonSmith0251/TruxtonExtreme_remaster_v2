namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000027")]
public struct PhysicsMask : IEnumerable<Int32>, IEnumerable
{
	[Token(Token = "0x2000028")]
	internal struct SetBitIterator : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E4")]
		private int m_BitIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000E5")]
		private ulong bitMask; //Field offset: 0x8

		[Token(Token = "0x17000044")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[IsReadOnly]
			[Token(Token = "0x600013B")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000045")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x3133640", Offset = "0x3132A40", Length = "0x20")]
			[IsReadOnly]
			[Token(Token = "0x600013C")]
			private get { } //Length: 32
		}

		[Address(RVA = "0x3133660", Offset = "0x3132A60", Length = "0x56")]
		[Token(Token = "0x600013A")]
		public SetBitIterator(PhysicsMask bitMask) { }

		[Address(RVA = "0x31335A0", Offset = "0x31329A0", Length = "0x44")]
		[Token(Token = "0x600013F")]
		public override IEnumerator<Int32> GetEnumerator() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[IsReadOnly]
		[Token(Token = "0x600013B")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x31335A0", Offset = "0x31329A0", Length = "0x44")]
		[Token(Token = "0x6000140")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x3133640", Offset = "0x3132A40", Length = "0x20")]
		[IsReadOnly]
		[Token(Token = "0x600013C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x31335F0", Offset = "0x31329F0", Length = "0x44")]
		[Token(Token = "0x600013D")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x292D6A0", Offset = "0x292CAA0", Length = "0x7")]
		[Token(Token = "0x600013E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[IsReadOnly]
		[Token(Token = "0x6000141")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000E1")]
	public static readonly PhysicsMask None; //Field offset: 0x0
	[Token(Token = "0x40000E2")]
	public static readonly PhysicsMask One; //Field offset: 0x8
	[Token(Token = "0x40000E3")]
	public static readonly PhysicsMask All; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E0")]
	public ulong bitMask; //Field offset: 0x0

	[Address(RVA = "0x312C5F0", Offset = "0x312B9F0", Length = "0x64")]
	[Token(Token = "0x6000139")]
	private static PhysicsMask() { }

	[Address(RVA = "0x312C470", Offset = "0x312B870", Length = "0x90")]
	[IsReadOnly]
	[Token(Token = "0x6000136")]
	public override IEnumerator<Int32> GetEnumerator() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6000135")]
	public static ulong op_Implicit(PhysicsMask bitMask) { }

	[Address(RVA = "0x312C500", Offset = "0x312B900", Length = "0x90")]
	[IsReadOnly]
	[Token(Token = "0x6000137")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x312C590", Offset = "0x312B990", Length = "0x56")]
	[IsReadOnly]
	[Token(Token = "0x6000138")]
	public virtual string ToString() { }

}

