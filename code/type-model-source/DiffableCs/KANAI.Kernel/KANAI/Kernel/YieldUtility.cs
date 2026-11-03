namespace KANAI.Kernel;

[Token(Token = "0x200003A")]
public class YieldUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000041")]
	private sealed class <_AdditionWait>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000109")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010A")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010B")]
		public IEnumerator p; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010C")]
		public Action callback; //Field offset: 0x28

		[Token(Token = "0x17000039")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600022F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000231")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600022C")]
		public <_AdditionWait>d__3(int <>1__state) { }

		[Address(RVA = "0x1DF5230", Offset = "0x1DF4630", Length = "0x62")]
		[Token(Token = "0x600022E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600022F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000231")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF52A0", Offset = "0x1DF46A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000230")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600022D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F1")]
		public MonoBehaviour root; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F2")]
		public int counter; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F3")]
		public Action <>9__1; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600020B")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1DF4A10", Offset = "0x1DF3E10", Length = "0x12C")]
		[Token(Token = "0x600020C")]
		internal Coroutine <WaitAllParallel>b__0(IEnumerator p) { }

		[Address(RVA = "0x1DF4B40", Offset = "0x1DF3F40", Length = "0x4")]
		[Token(Token = "0x600020D")]
		internal void <WaitAllParallel>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <WaitAllParallel>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F5")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F6")]
		public MonoBehaviour root; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F7")]
		public IEnumerable<IEnumerator> processes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F8")]
		private <>c__DisplayClass2_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F9")]
		private int <len>5__2; //Field offset: 0x38

		[Token(Token = "0x1700002F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000211")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000030")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000213")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600020E")]
		public <WaitAllParallel>d__2(int <>1__state) { }

		[Address(RVA = "0x1DF4B50", Offset = "0x1DF3F50", Length = "0x20C")]
		[Token(Token = "0x6000210")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000211")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000213")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF4D60", Offset = "0x1DF4160", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000212")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600020F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <WaitAllSerial>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000FB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FC")]
		public IEnumerable<IEnumerator> processes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000FD")]
		private IEnumerator[] <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000FE")]
		private int <>7__wrap2; //Field offset: 0x30

		[Token(Token = "0x17000031")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000217")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000219")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000214")]
		public <WaitAllSerial>d__1(int <>1__state) { }

		[Address(RVA = "0x1DF4DA0", Offset = "0x1DF41A0", Length = "0xD0")]
		[Token(Token = "0x6000216")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000217")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000219")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF4E80", Offset = "0x1DF4280", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000218")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000215")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private sealed class <WaitForSeconds>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000100")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000101")]
		public float nsecond; //Field offset: 0x20

		[Token(Token = "0x17000033")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600021D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000034")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600021F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600021A")]
		public <WaitForSeconds>d__8(int <>1__state) { }

		[Address(RVA = "0x1DF4EC0", Offset = "0x1DF42C0", Length = "0x125")]
		[Token(Token = "0x600021C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600021D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600021F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF4FF0", Offset = "0x1DF43F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600021E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600021B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private sealed class <WaitSeconds>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000102")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000103")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000104")]
		public int nunits; //Field offset: 0x20

		[Token(Token = "0x17000035")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000223")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000036")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000225")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000220")]
		public <WaitSeconds>d__9(int <>1__state) { }

		[Address(RVA = "0x1DF5030", Offset = "0x1DF4430", Length = "0x8C")]
		[Token(Token = "0x6000222")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000223")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000225")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF50C0", Offset = "0x1DF44C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000224")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000221")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000040")]
	private sealed class <WaitSyncing>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000105")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000106")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000107")]
		public AsyncOperation syncing; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000108")]
		private YieldInstruction <twait>5__2; //Field offset: 0x28

		[Token(Token = "0x17000037")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000229")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000038")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600022B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000226")]
		public <WaitSyncing>d__6(int <>1__state) { }

		[Address(RVA = "0x1DF5100", Offset = "0x1DF4500", Length = "0xE5")]
		[Token(Token = "0x6000228")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000229")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600022B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1DF51F0", Offset = "0x1DF45F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600022A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000227")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000EF")]
	private static readonly WaitForEndOfFrame waitForEndOfFrameCached; //Field offset: 0x0
	[Token(Token = "0x40000F0")]
	private static readonly WaitForSeconds wfsUnit; //Field offset: 0x8

	[Address(RVA = "0x1DF8FD0", Offset = "0x1DF83D0", Length = "0x84")]
	[IteratorStateMachine(typeof(<_AdditionWait>d__3))]
	[Token(Token = "0x6000204")]
	private static IEnumerator _AdditionWait(IEnumerator p, Action callback) { }

	[Address(RVA = "0x1DF9060", Offset = "0x1DF8460", Length = "0xCD")]
	[Token(Token = "0x600020A")]
	private static YieldUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000209")]
	public YieldUtility() { }

	[Address(RVA = "0x1DF8C90", Offset = "0x1DF8090", Length = "0x84")]
	[IteratorStateMachine(typeof(<WaitAllParallel>d__2))]
	[Token(Token = "0x6000203")]
	public static IEnumerator WaitAllParallel(IEnumerable<IEnumerator> processes, MonoBehaviour root) { }

	[Address(RVA = "0x1DF8D90", Offset = "0x1DF8190", Length = "0xB6")]
	[Token(Token = "0x6000201")]
	public static IEnumerator WaitAllSerial(IEnumerator[] process) { }

	[Address(RVA = "0x1DF8D20", Offset = "0x1DF8120", Length = "0x67")]
	[IteratorStateMachine(typeof(<WaitAllSerial>d__1))]
	[Token(Token = "0x6000202")]
	public static IEnumerator WaitAllSerial(IEnumerable<IEnumerator> processes) { }

	[Address(RVA = "0x1DF8E50", Offset = "0x1DF8250", Length = "0x4E")]
	[Token(Token = "0x6000205")]
	public static YieldInstruction WaitForFrame() { }

	[Address(RVA = "0x1DF8EA0", Offset = "0x1DF82A0", Length = "0x5D")]
	[IteratorStateMachine(typeof(<WaitForSeconds>d__8))]
	[Token(Token = "0x6000207")]
	public static IEnumerator WaitForSeconds(float nsecond) { }

	[Address(RVA = "0x1DF8F00", Offset = "0x1DF8300", Length = "0x59")]
	[IteratorStateMachine(typeof(<WaitSeconds>d__9))]
	[Token(Token = "0x6000208")]
	public static IEnumerator WaitSeconds(int nunits) { }

	[Address(RVA = "0x1DF8F60", Offset = "0x1DF8360", Length = "0x67")]
	[IteratorStateMachine(typeof(<WaitSyncing>d__6))]
	[Token(Token = "0x6000206")]
	public static IEnumerator WaitSyncing(AsyncOperation syncing) { }

}

