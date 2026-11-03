namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200006D")]
public static class TaskPool
{
	[CompilerGenerated]
	[Token(Token = "0x200006E")]
	private sealed class <GetCacheSizeInfo>d__4 : IEnumerable<ValueTuple`2<Type, Int32>>, IEnumerable, IEnumerator<ValueTuple`2<Type, Int32>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E9")]
		private ValueTuple<Type, Int32> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000EA")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000EB")]
		private Dictionary<Type, Func`1<Int32>> <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000EC")]
		private bool <>7__wrap2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000ED")]
		private Enumerator<Type, Func<Int32>> <>7__wrap3; //Field offset: 0x40

		[Token(Token = "0x1700002A")]
		private override ValueTuple<Type, Int32> System.Collections.Generic.IEnumerator<(System.Type,System.Int32)>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000170")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700002B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x273B4D0", Offset = "0x273A8D0", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6000172")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600016B")]
		public <GetCacheSizeInfo>d__4(int <>1__state) { }

		[Address(RVA = "0x273B630", Offset = "0x273AA30", Length = "0x19")]
		[Token(Token = "0x600016E")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x273B650", Offset = "0x273AA50", Length = "0x41")]
		[Token(Token = "0x600016F")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x273B0D0", Offset = "0x273A4D0", Length = "0x327")]
		[Token(Token = "0x600016D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x273B400", Offset = "0x273A800", Length = "0x8B")]
		[DebuggerHidden]
		[Token(Token = "0x6000173")]
		private override IEnumerator<ValueTuple`2<Type, Int32>> System.Collections.Generic.IEnumerable<(System.Type,System.Int32)>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000170")]
		private override ValueTuple<Type, Int32> System.Collections.Generic.IEnumerator<(System.Type,System.Int32)>.get_Current() { }

		[Address(RVA = "0x273B400", Offset = "0x273A800", Length = "0x8B")]
		[DebuggerHidden]
		[Token(Token = "0x6000174")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x273B4D0", Offset = "0x273A8D0", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x6000172")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x273B490", Offset = "0x273A890", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000171")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x273B520", Offset = "0x273A920", Length = "0x10E")]
		[DebuggerHidden]
		[Token(Token = "0x600016C")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000E6")]
	internal static int MaxPoolSize; //Field offset: 0x0
	[Token(Token = "0x40000E7")]
	private static Dictionary<Type, Func`1<Int32>> sizes; //Field offset: 0x8

	[Address(RVA = "0x2738890", Offset = "0x2737C90", Length = "0xF2")]
	[Token(Token = "0x6000167")]
	private static TaskPool() { }

	[Address(RVA = "0x2738690", Offset = "0x2737A90", Length = "0x55")]
	[IteratorStateMachine(typeof(<GetCacheSizeInfo>d__4))]
	[Token(Token = "0x6000169")]
	public static IEnumerable<ValueTuple`2<Type, Int32>> GetCacheSizeInfo() { }

	[Address(RVA = "0x27386F0", Offset = "0x2737AF0", Length = "0x133")]
	[Token(Token = "0x600016A")]
	public static void RegisterSizeGetter(Type type, Func<Int32> getSize) { }

	[Address(RVA = "0x2738830", Offset = "0x2737C30", Length = "0x52")]
	[Token(Token = "0x6000168")]
	public static void SetMaxPoolSize(int maxPoolSize) { }

}

