namespace OutGame.UI;

[Token(Token = "0x2000121")]
public static class OutGameHelper
{
	[CompilerGenerated]
	[Token(Token = "0x2000122")]
	private sealed class <>c
	{
		[Token(Token = "0x40004DD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004DE")]
		public static Func<Int32, Boolean> <>9__18_0; //Field offset: 0x8
		[Token(Token = "0x40004DF")]
		public static Action <>9__28_0; //Field offset: 0x10
		[Token(Token = "0x40004E0")]
		public static Action <>9__28_1; //Field offset: 0x18

		[Address(RVA = "0x21F84B0", Offset = "0x21F78B0", Length = "0x67")]
		[Token(Token = "0x600074C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600074D")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600074F")]
		internal void <LoadBgmSeReady>b__28_0() { }

		[Address(RVA = "0x21F80F0", Offset = "0x21F74F0", Length = "0x4F")]
		[Token(Token = "0x6000750")]
		internal void <LoadBgmSeReady>b__28_1() { }

		[Address(RVA = "0x21F8140", Offset = "0x21F7540", Length = "0x5A")]
		[Token(Token = "0x600074E")]
		internal bool <SaveIconGuidePU>b__18_0(int id) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000123")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E1")]
		public bool isExistsData; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40004E2")]
		public TXEErrors errCode; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004E3")]
		public TXEDataStore txeDataStore; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000751")]
		public <>c__DisplayClass15_0() { }

		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000752")]
		internal void <LoadSaveDataAllOnBoot>b__0(bool r) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000124")]
	private sealed class <>c__DisplayClass15_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E4")]
		public bool waitFlg; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004E5")]
		public <>c__DisplayClass15_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000753")]
		public <>c__DisplayClass15_1() { }

		[Address(RVA = "0x21F81D0", Offset = "0x21F75D0", Length = "0x4B")]
		[Token(Token = "0x6000754")]
		internal void <LoadSaveDataAllOnBoot>b__1(Response res) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000125")]
	private sealed class <FadeStopBGM_Coroutine>d__36 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004E7")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004E8")]
		public float tsecond; //Field offset: 0x20

		[Token(Token = "0x170001A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000758")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600075A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000755")]
		public <FadeStopBGM_Coroutine>d__36(int <>1__state) { }

		[Address(RVA = "0x21F4560", Offset = "0x21F3960", Length = "0xAB")]
		[Token(Token = "0x6000757")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000758")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600075A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F4610", Offset = "0x21F3A10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000759")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000756")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000126")]
	private sealed class <FirstStart>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004EA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004EB")]
		private bool <languageSelected>5__2; //Field offset: 0x20

		[Token(Token = "0x170001A3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600075E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000760")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600075B")]
		public <FirstStart>d__16(int <>1__state) { }

		[Address(RVA = "0x21F4650", Offset = "0x21F3A50", Length = "0x223")]
		[Token(Token = "0x600075D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600075E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000760")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F4880", Offset = "0x21F3C80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600075F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600075C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000127")]
	private sealed class <LanguageSelectPU>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004EC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004ED")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001A5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000764")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000766")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000761")]
		public <LanguageSelectPU>d__17(int <>1__state) { }

		[Address(RVA = "0x21F48C0", Offset = "0x21F3CC0", Length = "0x16E")]
		[Token(Token = "0x6000763")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000764")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000766")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F4A30", Offset = "0x21F3E30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000765")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000762")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000128")]
	private sealed class <LoadBgmSeReady>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004EE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004EF")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001A7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600076A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600076C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000767")]
		public <LoadBgmSeReady>d__28(int <>1__state) { }

		[Address(RVA = "0x21F4A70", Offset = "0x21F3E70", Length = "0x31F")]
		[Token(Token = "0x6000769")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600076A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600076C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F4D90", Offset = "0x21F4190", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600076B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000768")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000129")]
	private sealed class <LoadBgmSeWait>d__31 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004F0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004F1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F2")]
		private NowLoadingScope <>7__wrap1; //Field offset: 0x20

		[Token(Token = "0x170001A9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000771")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001AA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000773")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600076D")]
		public <LoadBgmSeWait>d__31(int <>1__state) { }

		[Address(RVA = "0x21F5070", Offset = "0x21F4470", Length = "0x50")]
		[Token(Token = "0x6000770")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21F4DD0", Offset = "0x21F41D0", Length = "0x1C8")]
		[Token(Token = "0x600076F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000771")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000773")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F4FA0", Offset = "0x21F43A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000772")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21F4FE0", Offset = "0x21F43E0", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x600076E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012A")]
	private sealed class <LoadFont>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004F3")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004F4")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F5")]
		public Area tarea; //Field offset: 0x20

		[Token(Token = "0x170001AB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000777")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001AC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000779")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000774")]
		public <LoadFont>d__20(int <>1__state) { }

		[Address(RVA = "0x21F50C0", Offset = "0x21F44C0", Length = "0xF1")]
		[Token(Token = "0x6000776")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000777")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000779")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F51C0", Offset = "0x21F45C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000778")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000775")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012B")]
	private sealed class <LoadSaveDataAllOnBoot>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004F6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004F7")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F8")]
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004F9")]
		public bool LanguageSelect; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004FA")]
		private <>c__DisplayClass15_1 <>8__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004FB")]
		public Action<TXEErrors> tcallback; //Field offset: 0x38

		[Token(Token = "0x170001AD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600077D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001AE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600077F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600077A")]
		public <LoadSaveDataAllOnBoot>d__15(int <>1__state) { }

		[Address(RVA = "0x21F5200", Offset = "0x21F4600", Length = "0x5EC")]
		[Token(Token = "0x600077C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600077D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600077F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F5810", Offset = "0x21F4C10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600077E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600077B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012C")]
	private sealed class <SaveIconGuidePU>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004FC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004FD")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001AF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000783")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000785")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000780")]
		public <SaveIconGuidePU>d__18(int <>1__state) { }

		[Address(RVA = "0x21F5850", Offset = "0x21F4C50", Length = "0x239")]
		[Token(Token = "0x6000782")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000783")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000785")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F5A90", Offset = "0x21F4E90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000784")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000781")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private sealed class <Setup>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004FE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004FF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000500")]
		public ShaderVariantCollection svc; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000501")]
		private Transform <root>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000502")]
		private NowLoadingScope <>7__wrap2; //Field offset: 0x30

		[Token(Token = "0x170001B1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600078A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600078C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000786")]
		public <Setup>d__25(int <>1__state) { }

		[Address(RVA = "0x21F7AF0", Offset = "0x21F6EF0", Length = "0x50")]
		[Token(Token = "0x6000789")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x21F7420", Offset = "0x21F6820", Length = "0x5D4")]
		[Token(Token = "0x6000788")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600078A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600078C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F7A20", Offset = "0x21F6E20", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600078B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x21F7A60", Offset = "0x21F6E60", Length = "0x8F")]
		[DebuggerHidden]
		[Token(Token = "0x6000787")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012E")]
	private sealed class <SetupDictionary>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000503")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000504")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000505")]
		private UIManager <m>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000506")]
		private string <dictionaryPath>5__3; //Field offset: 0x28

		[Token(Token = "0x170001B3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000790")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000792")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600078D")]
		public <SetupDictionary>d__8(int <>1__state) { }

		[Address(RVA = "0x21F62F0", Offset = "0x21F56F0", Length = "0x12F")]
		[Token(Token = "0x600078F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000790")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000792")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F6420", Offset = "0x21F5820", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000791")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600078E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012F")]
	private sealed class <SetupFont>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000507")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000508")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000509")]
		public Area tarea; //Field offset: 0x20

		[Token(Token = "0x170001B5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000796")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000798")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000793")]
		public <SetupFont>d__21(int <>1__state) { }

		[Address(RVA = "0x21F6460", Offset = "0x21F5860", Length = "0x146")]
		[Token(Token = "0x6000795")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000796")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000798")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F65B0", Offset = "0x21F59B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000797")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000794")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private sealed class <SetupFunctions>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400050A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400050B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400050C")]
		public Transform root; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400050D")]
		private string <shutterPath>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400050E")]
		private AsyncInstantiateOperation<GameObject> <op2>5__3; //Field offset: 0x30

		[Token(Token = "0x170001B7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600079C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600079E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000799")]
		public <SetupFunctions>d__10(int <>1__state) { }

		[Address(RVA = "0x21F65F0", Offset = "0x21F59F0", Length = "0x383")]
		[Token(Token = "0x600079B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600079C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600079E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F6980", Offset = "0x21F5D80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600079D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600079A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000131")]
	private sealed class <SetupGuideIcon>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400050F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000510")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001B9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007A2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001BA")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007A4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600079F")]
		public <SetupGuideIcon>d__27(int <>1__state) { }

		[Address(RVA = "0x21F69C0", Offset = "0x21F5DC0", Length = "0x161")]
		[Token(Token = "0x60007A1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007A2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007A4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F6B30", Offset = "0x21F5F30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007A3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007A0")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000132")]
	private sealed class <SetupPopup>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000511")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000512")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000513")]
		public string puname; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000514")]
		private PopupManager <popupMan>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000515")]
		private string <ppath>5__3; //Field offset: 0x30

		[Token(Token = "0x170001BB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007A8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001BC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007AA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007A5")]
		public <SetupPopup>d__12(int <>1__state) { }

		[Address(RVA = "0x21F6B70", Offset = "0x21F5F70", Length = "0x15F")]
		[Token(Token = "0x60007A7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007A8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007AA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F6CD0", Offset = "0x21F60D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007A9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007A6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000133")]
	private sealed class <SetupPopups>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000516")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000517")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000518")]
		private PopupManager <popupMan>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000519")]
		private string <tpath>5__3; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400051A")]
		private String[] <>7__wrap3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400051B")]
		private int <>7__wrap4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400051C")]
		private string <tname>5__6; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400051D")]
		private string <ppath>5__7; //Field offset: 0x48

		[Token(Token = "0x170001BD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007AE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001BE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007B0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007AB")]
		public <SetupPopups>d__11(int <>1__state) { }

		[Address(RVA = "0x21F6D10", Offset = "0x21F6110", Length = "0x2E9")]
		[Token(Token = "0x60007AD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007AE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007B0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F7000", Offset = "0x21F6400", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007AF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007AC")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000134")]
	private sealed class <SetupResident>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400051E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400051F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000520")]
		private string <tpath>5__2; //Field offset: 0x20

		[Token(Token = "0x170001BF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007B4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001C0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007B6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007B1")]
		public <SetupResident>d__19(int <>1__state) { }

		[Address(RVA = "0x21F7040", Offset = "0x21F6440", Length = "0x1E2")]
		[Token(Token = "0x60007B3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007B4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007B6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F7230", Offset = "0x21F6630", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007B5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007B2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000135")]
	private sealed class <SetupSpritePalette>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000521")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000522")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000523")]
		public string sname; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000524")]
		private string <sppath>5__2; //Field offset: 0x28

		[Token(Token = "0x170001C1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007BA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001C2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007BC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007B7")]
		public <SetupSpritePalette>d__23(int <>1__state) { }

		[Address(RVA = "0x21F7270", Offset = "0x21F6670", Length = "0x160")]
		[Token(Token = "0x60007B9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007BA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007BC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F73E0", Offset = "0x21F67E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007BB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007B8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000136")]
	private sealed class <SetupUIGuides>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000525")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000526")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000527")]
		public Transform root; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000528")]
		private string <guidePath>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000529")]
		private AsyncInstantiateOperation<GameObject> <op1>5__3; //Field offset: 0x30

		[Token(Token = "0x170001C3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007C0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001C4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007C2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007BD")]
		public <SetupUIGuides>d__9(int <>1__state) { }

		[Address(RVA = "0x21F7B40", Offset = "0x21F6F40", Length = "0x294")]
		[Token(Token = "0x60007BF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007C0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007C2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F7DE0", Offset = "0x21F71E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007C1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007BE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000137")]
	private sealed class <WarmupShaders>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400052A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400052B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400052C")]
		public ShaderVariantCollection svc; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400052D")]
		private Stopwatch <stopWatch>5__2; //Field offset: 0x28

		[Token(Token = "0x170001C5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007C6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001C6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007C8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007C3")]
		public <WarmupShaders>d__14(int <>1__state) { }

		[Address(RVA = "0x21F8B70", Offset = "0x21F7F70", Length = "0x1A9")]
		[Token(Token = "0x60007C5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007C6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007C8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F8D20", Offset = "0x21F8120", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007C7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007C4")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40004CD")]
	private static readonly string _residentPath; //Field offset: 0x0
	[Token(Token = "0x40004CE")]
	private static readonly string _uiPath; //Field offset: 0x8
	[Token(Token = "0x40004CF")]
	private static readonly string _uiPopup; //Field offset: 0x10
	[Token(Token = "0x40004D0")]
	private static readonly string _localizePath; //Field offset: 0x18
	[Token(Token = "0x40004D1")]
	private static readonly string _windowPrefab; //Field offset: 0x20
	[Token(Token = "0x40004D2")]
	private static readonly string guidePrefab; //Field offset: 0x28
	[Token(Token = "0x40004D3")]
	private static readonly string shutterPrefab; //Field offset: 0x30
	[Token(Token = "0x40004D4")]
	private static readonly String[] _popupContents; //Field offset: 0x38
	[Token(Token = "0x40004D5")]
	private static string _nowGuideIcon; //Field offset: 0x40
	[Token(Token = "0x40004D6")]
	private static bool _isSELoadStart; //Field offset: 0x48
	[Token(Token = "0x40004D7")]
	private static bool _isSELoadDone; //Field offset: 0x49
	[Token(Token = "0x40004D8")]
	public static readonly string spal_PS; //Field offset: 0x50
	[Token(Token = "0x40004D9")]
	public static readonly string spal_PC; //Field offset: 0x58
	[Token(Token = "0x40004DA")]
	public static readonly string spal_Sw; //Field offset: 0x60
	[Token(Token = "0x40004DB")]
	public static readonly string spal_X; //Field offset: 0x68
	[Token(Token = "0x40004DC")]
	public static readonly string spal_Deck; //Field offset: 0x70

	[Address(RVA = "0x21ED590", Offset = "0x21EC990", Length = "0x616")]
	[Token(Token = "0x600074B")]
	private static OutGameHelper() { }

	[Address(RVA = "0x21EC280", Offset = "0x21EB680", Length = "0x5D")]
	[IteratorStateMachine(typeof(<FadeStopBGM_Coroutine>d__36))]
	[Token(Token = "0x6000747")]
	public static IEnumerator FadeStopBGM_Coroutine(float tsecond = 0.25) { }

	[Address(RVA = "0x21EC2E0", Offset = "0x21EB6E0", Length = "0x72")]
	[Token(Token = "0x6000746")]
	public static void FadeStopBGM_Forget(float tsecond = 0.25) { }

	[Address(RVA = "0x21EC360", Offset = "0x21EB760", Length = "0x4B")]
	[IteratorStateMachine(typeof(<FirstStart>d__16))]
	[Token(Token = "0x6000736")]
	public static IEnumerator FirstStart() { }

	[Address(RVA = "0x21EC3B0", Offset = "0x21EB7B0", Length = "0x1C4")]
	[Token(Token = "0x6000749")]
	public static string GetSpritePaletteName() { }

	[Address(RVA = "0x21EC580", Offset = "0x21EB980", Length = "0x4F")]
	[Token(Token = "0x6000743")]
	public static bool IsLoadBgmSeStarted() { }

	[Address(RVA = "0x21EC5D0", Offset = "0x21EB9D0", Length = "0xB8")]
	[Token(Token = "0x600074A")]
	public static bool IsTruxton() { }

	[Address(RVA = "0x21EC690", Offset = "0x21EBA90", Length = "0x4B")]
	[IteratorStateMachine(typeof(<LanguageSelectPU>d__17))]
	[Token(Token = "0x6000737")]
	private static IEnumerator LanguageSelectPU() { }

	[Address(RVA = "0x21EC6E0", Offset = "0x21EBAE0", Length = "0x4B")]
	[IteratorStateMachine(typeof(<LoadBgmSeReady>d__28))]
	[Token(Token = "0x6000741")]
	public static IEnumerator LoadBgmSeReady() { }

	[Address(RVA = "0x21EC730", Offset = "0x21EBB30", Length = "0x4F")]
	[Token(Token = "0x6000742")]
	public static void LoadBgmSeStart() { }

	[Address(RVA = "0x21EC780", Offset = "0x21EBB80", Length = "0x4B")]
	[IteratorStateMachine(typeof(<LoadBgmSeWait>d__31))]
	[Token(Token = "0x6000744")]
	public static IEnumerator LoadBgmSeWait() { }

	[Address(RVA = "0x21EC7D0", Offset = "0x21EBBD0", Length = "0x59")]
	[IteratorStateMachine(typeof(<LoadFont>d__20))]
	[Token(Token = "0x600073A")]
	public static IEnumerator LoadFont(Area tarea) { }

	[Address(RVA = "0x21EC830", Offset = "0x21EBC30", Length = "0x78")]
	[IteratorStateMachine(typeof(<LoadSaveDataAllOnBoot>d__15))]
	[Token(Token = "0x6000735")]
	public static IEnumerator LoadSaveDataAllOnBoot(Action<TXEErrors> tcallback, bool LanguageSelect = true) { }

	[Address(RVA = "0x21EC8B0", Offset = "0x21EBCB0", Length = "0x14C")]
	[Token(Token = "0x6000745")]
	public static void PlayBGM(BGM tbgm) { }

	[Address(RVA = "0x21ECCC0", Offset = "0x21EC0C0", Length = "0x336")]
	[Token(Token = "0x6000748")]
	public static void Release() { }

	[Address(RVA = "0x21ECA00", Offset = "0x21EBE00", Length = "0x123")]
	[Token(Token = "0x600073C")]
	public static void ReleaseFont(Area tarea) { }

	[Address(RVA = "0x21ECB30", Offset = "0x21EBF30", Length = "0x184")]
	[Token(Token = "0x600073E")]
	private static void ReleaseSpritePalette() { }

	[Address(RVA = "0x21ED000", Offset = "0x21EC400", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SaveIconGuidePU>d__18))]
	[Token(Token = "0x6000738")]
	private static IEnumerator SaveIconGuidePU() { }

	[Address(RVA = "0x21ED3B0", Offset = "0x21EC7B0", Length = "0x67")]
	[IteratorStateMachine(typeof(<Setup>d__25))]
	[Token(Token = "0x600073F")]
	public static IEnumerator Setup(ShaderVariantCollection svc = null) { }

	[Address(RVA = "0x21ED050", Offset = "0x21EC450", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SetupDictionary>d__8))]
	[Token(Token = "0x600072E")]
	public static IEnumerator SetupDictionary() { }

	[Address(RVA = "0x21ED0A0", Offset = "0x21EC4A0", Length = "0x59")]
	[IteratorStateMachine(typeof(<SetupFont>d__21))]
	[Token(Token = "0x600073B")]
	public static IEnumerator SetupFont(Area tarea) { }

	[Address(RVA = "0x21ED100", Offset = "0x21EC500", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupFunctions>d__10))]
	[Token(Token = "0x6000730")]
	public static IEnumerator SetupFunctions(Transform root) { }

	[Address(RVA = "0x21ED170", Offset = "0x21EC570", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SetupGuideIcon>d__27))]
	[Token(Token = "0x6000740")]
	public static IEnumerator SetupGuideIcon() { }

	[Address(RVA = "0x21ED1C0", Offset = "0x21EC5C0", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupPopup>d__12))]
	[Token(Token = "0x6000732")]
	public static IEnumerator SetupPopup(string puname) { }

	[Address(RVA = "0x21ED230", Offset = "0x21EC630", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SetupPopups>d__11))]
	[Token(Token = "0x6000731")]
	public static IEnumerator SetupPopups() { }

	[Address(RVA = "0x21ED280", Offset = "0x21EC680", Length = "0x4B")]
	[IteratorStateMachine(typeof(<SetupResident>d__19))]
	[Token(Token = "0x6000739")]
	public static IEnumerator SetupResident() { }

	[Address(RVA = "0x21ED2D0", Offset = "0x21EC6D0", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupSpritePalette>d__23))]
	[Token(Token = "0x600073D")]
	private static IEnumerator SetupSpritePalette(string sname) { }

	[Address(RVA = "0x21ED340", Offset = "0x21EC740", Length = "0x67")]
	[IteratorStateMachine(typeof(<SetupUIGuides>d__9))]
	[Token(Token = "0x600072F")]
	public static IEnumerator SetupUIGuides(Transform root) { }

	[Address(RVA = "0x21ED420", Offset = "0x21EC820", Length = "0xF5")]
	[Token(Token = "0x6000733")]
	public static void TeardownPopup(string puname) { }

	[Address(RVA = "0x21ED520", Offset = "0x21EC920", Length = "0x67")]
	[IteratorStateMachine(typeof(<WarmupShaders>d__14))]
	[Token(Token = "0x6000734")]
	public static IEnumerator WarmupShaders(ShaderVariantCollection svc) { }

}

