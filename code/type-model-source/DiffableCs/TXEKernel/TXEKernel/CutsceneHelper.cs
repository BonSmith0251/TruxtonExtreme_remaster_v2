namespace TXEKernel;

[Token(Token = "0x2000013")]
public static class CutsceneHelper
{
	[CompilerGenerated]
	[Token(Token = "0x2000014")]
	private sealed class <LoadScene>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000053")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000054")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000055")]
		public string subSceneName; //Field offset: 0x20

		[Token(Token = "0x1700000B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000042")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000044")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600003F")]
		public <LoadScene>d__0(int <>1__state) { }

		[Address(RVA = "0x26E7870", Offset = "0x26E6C70", Length = "0x17C")]
		[Token(Token = "0x6000041")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000042")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000044")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E79F0", Offset = "0x26E6DF0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000043")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <UnloadScene>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000056")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000057")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000058")]
		public string subSceneName; //Field offset: 0x20

		[Token(Token = "0x1700000D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000048")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600004A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000045")]
		public <UnloadScene>d__1(int <>1__state) { }

		[Address(RVA = "0x26EA150", Offset = "0x26E9550", Length = "0x92")]
		[Token(Token = "0x6000047")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000048")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600004A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26EA1F0", Offset = "0x26E95F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000049")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000046")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x26D2AF0", Offset = "0x26D1EF0", Length = "0x67")]
	[IteratorStateMachine(typeof(<LoadScene>d__0))]
	[Token(Token = "0x600003D")]
	public static IEnumerator LoadScene(string subSceneName) { }

	[Address(RVA = "0x26D2B60", Offset = "0x26D1F60", Length = "0x67")]
	[IteratorStateMachine(typeof(<UnloadScene>d__1))]
	[Token(Token = "0x600003E")]
	public static IEnumerator UnloadScene(string subSceneName) { }

}

