namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000208")]
internal sealed class ArrayPool
{
	[Token(Token = "0x40005A0")]
	private const int DefaultMaxNumberOfArraysPerBucket = 50; //Field offset: 0x0
	[Token(Token = "0x40005A1")]
	private static readonly T[] EmptyArray; //Field offset: 0x0
	[Token(Token = "0x40005A2")]
	public static readonly ArrayPool<T> Shared; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A3")]
	private readonly MinimumQueue<T[]>[] buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A4")]
	private readonly SpinLock[] locks; //Field offset: 0x0

	[Address(RVA = "0xB47860", Offset = "0xB46C60", Length = "0x1B4")]
	[Token(Token = "0x6000BCF")]
	private static ArrayPool`1() { }

	[Address(RVA = "0xB47B20", Offset = "0xB46F20", Length = "0x1E5")]
	[Token(Token = "0x6000BCA")]
	private ArrayPool`1() { }

	[Address(RVA = "0xB46370", Offset = "0xB45770", Length = "0x31")]
	[Token(Token = "0x6000BCD")]
	private static int CalculateSize(int size) { }

	[Address(RVA = "0xB463B0", Offset = "0xB457B0", Length = "0x153")]
	[Token(Token = "0x6000BCE")]
	private static int GetQueueIndex(int size) { }

	[Address(RVA = "0xB46510", Offset = "0xB45910", Length = "0x36E")]
	[Token(Token = "0x6000BCB")]
	public T[] Rent(int minimumLength) { }

	[Address(RVA = "0xB46DD0", Offset = "0xB461D0", Length = "0x283")]
	[Token(Token = "0x6000BCC")]
	public void Return(T[] array, bool clearArray = false) { }

}

