namespace InGame.Kernel;

[Token(Token = "0x20000B5")]
public static class InGameHelper
{
	[CompilerGenerated]
	[Token(Token = "0x20000B6")]
	private sealed class <DebugPlayerSetting>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000572")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000573")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x1700013A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600069D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700013B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600069F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600069A")]
		public <DebugPlayerSetting>d__0(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x600069C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600069D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600069F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D45640", Offset = "0x1D44A40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600069E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600069B")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x1D37830", Offset = "0x1D36C30", Length = "0x4B")]
	[IteratorStateMachine(typeof(<DebugPlayerSetting>d__0))]
	[Token(Token = "0x6000699")]
	public static IEnumerator DebugPlayerSetting(int pno) { }

}

