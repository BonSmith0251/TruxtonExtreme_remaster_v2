namespace KANAI.Kernel.Extensions;

[Extension]
[Token(Token = "0x2000043")]
public static class ExtensionMonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <Interval>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010F")]
		public float seconds; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000110")]
		public Action done; //Field offset: 0x28

		[Token(Token = "0x1700003B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000246")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000248")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000243")]
		public <Interval>d__0(int <>1__state) { }

		[Address(RVA = "0x1DF33F0", Offset = "0x1DF27F0", Length = "0xBA")]
		[Token(Token = "0x6000245")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000246")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000248")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF34B0", Offset = "0x1DF28B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000247")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000244")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <Timer>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000112")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000113")]
		public float seconds; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000114")]
		public Action done; //Field offset: 0x28

		[Token(Token = "0x1700003D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600024C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600024E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000249")]
		public <Timer>d__1(int <>1__state) { }

		[Address(RVA = "0x1DF4910", Offset = "0x1DF3D10", Length = "0xB8")]
		[Token(Token = "0x600024B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600024C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600024E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF49D0", Offset = "0x1DF3DD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600024D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600024A")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x1DE8F50", Offset = "0x1DE8350", Length = "0x79")]
	[Extension]
	[IteratorStateMachine(typeof(<Interval>d__0))]
	[Token(Token = "0x6000241")]
	public static IEnumerator Interval(MonoBehaviour _, float seconds, Action done) { }

	[Address(RVA = "0x1DE8FD0", Offset = "0x1DE83D0", Length = "0x79")]
	[Extension]
	[IteratorStateMachine(typeof(<Timer>d__1))]
	[Token(Token = "0x6000242")]
	public static IEnumerator Timer(MonoBehaviour _, float seconds, Action done) { }

}

