namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000069")]
public static class Progress
{
	[Token(Token = "0x200006B")]
	private sealed class AnonymousProgress : IProgress<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E1")]
		private readonly Action<T> action; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000163")]
		public AnonymousProgress`1(Action<T> action) { }

		[Address(RVA = "0xB44040", Offset = "0xB43440", Length = "0xDF")]
		[Token(Token = "0x6000164")]
		public override void Report(T value) { }

	}

	[Token(Token = "0x200006A")]
	private sealed class NullProgress : IProgress<T>
	{
		[Token(Token = "0x40000E0")]
		public static readonly IProgress<T> Instance; //Field offset: 0x0

		[Address(RVA = "0xD99F90", Offset = "0xD99390", Length = "0x11F")]
		[Token(Token = "0x6000162")]
		private static NullProgress`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000160")]
		private NullProgress`1() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000161")]
		public override void Report(T value) { }

	}

	[Token(Token = "0x200006C")]
	private sealed class OnlyValueChangedProgress : IProgress<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E2")]
		private readonly Action<T> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E3")]
		private readonly IEqualityComparer<T> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E4")]
		private bool isFirstCall; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E5")]
		private T latestValue; //Field offset: 0x0

		[Address(RVA = "0xE11D40", Offset = "0xE11140", Length = "0x10B")]
		[Token(Token = "0x6000165")]
		public OnlyValueChangedProgress`1(Action<T> action, IEqualityComparer<T> comparer) { }

		[Address(RVA = "0xE119F0", Offset = "0xE10DF0", Length = "0x348")]
		[Token(Token = "0x6000166")]
		public override void Report(T value) { }

	}


	[Address(RVA = "0x8B5D40", Offset = "0x8B5140", Length = "0xC8")]
	[Token(Token = "0x600015E")]
	public static IProgress<T> Create(Action<T> handler) { }

	[Address(RVA = "0x8B5C10", Offset = "0x8B5010", Length = "0x124")]
	[Token(Token = "0x600015F")]
	public static IProgress<T> CreateOnlyValueChanged(Action<T> handler, IEqualityComparer<T> comparer = null) { }

}

