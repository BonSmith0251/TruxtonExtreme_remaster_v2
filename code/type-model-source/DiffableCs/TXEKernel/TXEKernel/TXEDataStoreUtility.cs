namespace TXEKernel;

[Token(Token = "0x2000024")]
public static class TXEDataStoreUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <>c
	{
		[Token(Token = "0x40000AA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000AB")]
		public static Func<Int32, Boolean> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x26EA070", Offset = "0x26E9470", Length = "0x67")]
		[Token(Token = "0x60000AA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000AB")]
		public <>c() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60000AC")]
		internal bool <ShowError>b__2_0(int id) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AC")]
		public TXEDataStore txeDataStore; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000AD")]
		public <>c__DisplayClass1_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private sealed class <>c__DisplayClass1_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AD")]
		public TXEErrors errCode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AE")]
		public <>c__DisplayClass1_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000AE")]
		public <>c__DisplayClass1_1() { }

		[Address(RVA = "0x26E9C40", Offset = "0x26E9040", Length = "0xB8")]
		[Token(Token = "0x60000AF")]
		internal void <SaveProcess>b__0(Response res) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <SaveProcess>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B1")]
		public bool forceFlg; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B2")]
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B3")]
		private <>c__DisplayClass1_1 <>8__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000B4")]
		public float displayTime; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000B5")]
		private NowSavingScope <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000B6")]
		private float <startTime>5__3; //Field offset: 0x48

		[Token(Token = "0x17000020")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000B4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000021")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000B6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000B0")]
		public <SaveProcess>d__1(int <>1__state) { }

		[Address(RVA = "0x26E8810", Offset = "0x26E7C10", Length = "0x50")]
		[Token(Token = "0x60000B3")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x26E7F40", Offset = "0x26E7340", Length = "0x7F2")]
		[Token(Token = "0x60000B2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000B4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000B6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E8740", Offset = "0x26E7B40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000B5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x26E8780", Offset = "0x26E7B80", Length = "0x8E")]
		[DebuggerHidden]
		[Token(Token = "0x60000B1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private struct <SaveProcessUniTask>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B8")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B9")]
		private Awaiter <>u__1; //Field offset: 0x10

		[Address(RVA = "0x26E8860", Offset = "0x26E7C60", Length = "0x398")]
		[Token(Token = "0x60000B7")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60000B8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private sealed class <ShowError>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000BC")]
		public TXEErrors errCode; //Field offset: 0x20

		[Token(Token = "0x17000022")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000BC")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000023")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000BE")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000B9")]
		public <ShowError>d__2(int <>1__state) { }

		[Address(RVA = "0x26E9390", Offset = "0x26E8790", Length = "0x234")]
		[Token(Token = "0x60000BB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000BC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000BE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x26E95D0", Offset = "0x26E89D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000BD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000BA")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x26E0D60", Offset = "0x26E0160", Length = "0x6D")]
	[IteratorStateMachine(typeof(<SaveProcess>d__1))]
	[Token(Token = "0x60000A8")]
	public static IEnumerator SaveProcess(float displayTime = 0.2, bool forceFlg = false) { }

	[Address(RVA = "0x26E0CF0", Offset = "0x26E00F0", Length = "0x66")]
	[AsyncStateMachine(typeof(<SaveProcessUniTask>d__0))]
	[Token(Token = "0x60000A7")]
	public static UniTaskVoid SaveProcessUniTask() { }

	[Address(RVA = "0x26E0DD0", Offset = "0x26E01D0", Length = "0x59")]
	[IteratorStateMachine(typeof(<ShowError>d__2))]
	[Token(Token = "0x60000A9")]
	public static IEnumerator ShowError(TXEErrors errCode) { }

}

