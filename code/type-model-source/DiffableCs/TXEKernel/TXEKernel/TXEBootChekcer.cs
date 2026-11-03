namespace TXEKernel;

[Token(Token = "0x20000CC")]
public static class TXEBootChekcer
{
	[CompilerGenerated]
	[Token(Token = "0x20000CD")]
	private sealed class <BootCheck>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000411")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000412")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001E1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000645")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001E2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000647")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000642")]
		public <BootCheck>d__0(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x6000644")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000645")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000647")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2719170", Offset = "0x2718570", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000646")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000643")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x2711150", Offset = "0x2710550", Length = "0x4B")]
	[IteratorStateMachine(typeof(<BootCheck>d__0))]
	[Token(Token = "0x6000641")]
	public static IEnumerator BootCheck() { }

}

