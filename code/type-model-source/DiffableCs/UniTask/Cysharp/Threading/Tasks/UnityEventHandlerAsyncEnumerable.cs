namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015F")]
public class UnityEventHandlerAsyncEnumerable : IUniTaskAsyncEnumerable<AsyncUnit>
{
	[Token(Token = "0x2000160")]
	private class UnityEventHandlerAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000536")]
		private static readonly Action<Object> cancel1; //Field offset: 0x0
		[Token(Token = "0x4000537")]
		private static readonly Action<Object> cancel2; //Field offset: 0x8
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000538")]
		private readonly UnityEvent unityEvent; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000539")]
		private CancellationToken cancellationToken1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400053A")]
		private CancellationToken cancellationToken2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400053B")]
		private UnityAction unityAction; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400053C")]
		private CancellationTokenRegistration registration1; //Field offset: 0x58
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400053D")]
		private CancellationTokenRegistration registration2; //Field offset: 0x70
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400053E")]
		private bool isDisposed; //Field offset: 0x88

		[Token(Token = "0x1700005E")]
		public override AsyncUnit Current
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600086E")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x27932E0", Offset = "0x27926E0", Length = "0xE4")]
		[Token(Token = "0x6000874")]
		private static UnityEventHandlerAsyncEnumerator() { }

		[Address(RVA = "0x119F8E0", Offset = "0x119ECE0", Length = "0x69")]
		[Token(Token = "0x600086D")]
		public UnityEventHandlerAsyncEnumerator(UnityEvent unityEvent, CancellationToken cancellationToken1, CancellationToken cancellationToken2) { }

		[Address(RVA = "0x2792E10", Offset = "0x2792210", Length = "0x6A")]
		[Token(Token = "0x6000873")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600086E")]
		public override AsyncUnit get_Current() { }

		[Address(RVA = "0x2792E80", Offset = "0x2792280", Length = "0x3C")]
		[Token(Token = "0x6000870")]
		private void Invoke() { }

		[Address(RVA = "0x2792EC0", Offset = "0x27922C0", Length = "0x29D")]
		[Token(Token = "0x600086F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x2793160", Offset = "0x2792560", Length = "0xB9")]
		[Token(Token = "0x6000871")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x2793220", Offset = "0x2792620", Length = "0xB9")]
		[Token(Token = "0x6000872")]
		private static void OnCanceled2(object state) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000534")]
	private readonly UnityEvent unityEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000535")]
	private readonly CancellationToken cancellationToken1; //Field offset: 0x18

	[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
	[Token(Token = "0x600086B")]
	public UnityEventHandlerAsyncEnumerable(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2792D10", Offset = "0x2792110", Length = "0xF3")]
	[Token(Token = "0x600086C")]
	public override IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

