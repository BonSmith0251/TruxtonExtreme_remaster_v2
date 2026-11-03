namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x200024F")]
internal static class MiscHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x2000250")]
	private sealed class <EveryNth>d__1 : IEnumerable<TValue>, IEnumerable, IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C9F")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA0")]
		private TValue <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA1")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA2")]
		private IEnumerable<TValue> enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA3")]
		public IEnumerable<TValue> <>3__enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA4")]
		private int start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA5")]
		public int <>3__start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA6")]
		private int n; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA7")]
		public int <>3__n; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA8")]
		private int <index>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CA9")]
		private IEnumerator<TValue> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x170005FC")]
		private override TValue System.Collections.Generic.IEnumerator<TValue>.Current
		{
			[Address(RVA = "0x16F5F40", Offset = "0x16F5340", Length = "0xAC")]
			[DebuggerHidden]
			[Token(Token = "0x60015A7")]
			private get { } //Length: 172
		}

		[Token(Token = "0x170005FD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16F6010", Offset = "0x16F5410", Length = "0xAD")]
			[DebuggerHidden]
			[Token(Token = "0x60015A9")]
			private get { } //Length: 173
		}

		[Address(RVA = "0x113F950", Offset = "0x113ED50", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x60015A3")]
		public <EveryNth>d__1`1(int <>1__state) { }

		[Address(RVA = "0x16F60C0", Offset = "0x16F54C0", Length = "0xEC")]
		[Token(Token = "0x60015A6")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x16F5620", Offset = "0x16F4A20", Length = "0x6A7")]
		[Token(Token = "0x60015A5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x16F5CD0", Offset = "0x16F50D0", Length = "0x266")]
		[DebuggerHidden]
		[Token(Token = "0x60015AA")]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[Address(RVA = "0x16F5F40", Offset = "0x16F5340", Length = "0xAC")]
		[DebuggerHidden]
		[Token(Token = "0x60015A7")]
		private override TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

		[Address(RVA = "0x16F5FF0", Offset = "0x16F53F0", Length = "0x18")]
		[DebuggerHidden]
		[Token(Token = "0x60015AB")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x16F6010", Offset = "0x16F5410", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60015A9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60015A8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x113F5E0", Offset = "0x113E9E0", Length = "0x95")]
		[DebuggerHidden]
		[Token(Token = "0x60015A4")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x888100", Offset = "0x887500", Length = "0x15E")]
	[Extension]
	[IteratorStateMachine(typeof(<EveryNth>d__1`1))]
	[Token(Token = "0x60015A1")]
	public static IEnumerable<TValue> EveryNth(IEnumerable<TValue> enumerable, int n, int start = 0) { }

	[Address(RVA = "0x888260", Offset = "0x887660", Length = "0x1AA")]
	[Extension]
	[Token(Token = "0x60015A0")]
	public static TValue GetValueOrDefault(Dictionary<TKey, TValue> dictionary, TKey key) { }

	[Address(RVA = "0x888410", Offset = "0x887810", Length = "0x375")]
	[Extension]
	[Token(Token = "0x60015A2")]
	public static int IndexOf(IEnumerable<TValue> enumerable, TValue value) { }

}

