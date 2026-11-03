namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000209")]
internal static class ArrayPoolUtil
{
	[Token(Token = "0x200020A")]
	internal struct RentArray : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A5")]
		public readonly T[] Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A6")]
		public readonly int Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A7")]
		private ArrayPool<T> pool; //Field offset: 0x0

		[Address(RVA = "0xF52C10", Offset = "0xF52010", Length = "0x42")]
		[Token(Token = "0x6000BD3")]
		public RentArray`1(T[] array, int length, ArrayPool<T> pool) { }

		[Address(RVA = "0xF52A70", Offset = "0xF51E70", Length = "0xCD")]
		[Token(Token = "0x6000BD4")]
		public override void Dispose() { }

		[Address(RVA = "0xF529D0", Offset = "0xF51DD0", Length = "0x9D")]
		[Token(Token = "0x6000BD5")]
		public void DisposeManually(bool clearArray) { }

	}


	[Address(RVA = "0x726270", Offset = "0x725670", Length = "0x6A")]
	[Token(Token = "0x6000BD0")]
	internal static void EnsureCapacity(ref T[] array, int index, ArrayPool<T> pool) { }

	[Address(RVA = "0x7260B0", Offset = "0x7254B0", Length = "0x142")]
	[Token(Token = "0x6000BD1")]
	private static void EnsureCapacityCore(ref T[] array, int index, ArrayPool<T> pool) { }

	[Address(RVA = "0x726920", Offset = "0x725D20", Length = "0x648")]
	[Token(Token = "0x6000BD2")]
	public static RentArray<T> Materialize(IEnumerable<T> source) { }

}

