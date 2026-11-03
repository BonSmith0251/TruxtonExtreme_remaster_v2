namespace TXEKernel;

[Token(Token = "0x2000093")]
public abstract class RecordsBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000095")]
	private sealed class <_initialize>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000310")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000311")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x1700019C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004FA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004FC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60004F7")]
		public <_initialize>d__8(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x60004F9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004FA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004FC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2707580", Offset = "0x2706980", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60004FB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60004F8")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400030D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400030E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400030F")]
		public RecordsBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700019A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004F4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60004F6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60004F1")]
		public <Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x2704B60", Offset = "0x2703F60", Length = "0xA9")]
		[Token(Token = "0x60004F3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004F4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60004F6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2704C10", Offset = "0x2704010", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60004F5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60004F2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x400030B")]
	public const int _version_00_01_00 = 100; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030C")]
	protected RecordVersion NowVersion; //Field offset: 0x10

	[Token(Token = "0x17000198")]
	protected abstract string BaseName
	{
		[Token(Token = "0x60004EF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000199")]
	public abstract int Version_now
	{
		[Token(Token = "0x60004F0")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x26F7BB0", Offset = "0x26F6FB0", Length = "0x4B")]
	[IteratorStateMachine(typeof(<_initialize>d__8))]
	[Token(Token = "0x60004EB")]
	public override IEnumerator _initialize() { }

	[Token(Token = "0x60004EE")]
	protected abstract void _postMigrate() { }

	[Token(Token = "0x60004ED")]
	protected abstract void _preMigrate() { }

	[Address(RVA = "0x26F7A60", Offset = "0x26F6E60", Length = "0x147")]
	[Token(Token = "0x60004E3")]
	public RecordsBase() { }

	[Token(Token = "0x60004EC")]
	protected abstract IEnumerable<RecordValueBase> AllEnumerator() { }

	[Address(RVA = "0x26F6D10", Offset = "0x26F6110", Length = "0x1FB")]
	[Token(Token = "0x60004E7")]
	public override void CompleteReset() { }

	[Token(Token = "0x60004EF")]
	protected abstract string get_BaseName() { }

	[Token(Token = "0x60004F0")]
	public abstract int get_Version_now() { }

	[Address(RVA = "0x26F6F10", Offset = "0x26F6310", Length = "0x67")]
	[IteratorStateMachine(typeof(<Initialize>d__1))]
	[Token(Token = "0x60004E4")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x26F6F80", Offset = "0x26F6380", Length = "0x182")]
	[Token(Token = "0x60004E5")]
	public override bool IsChanged() { }

	[Address(RVA = "0x26F7110", Offset = "0x26F6510", Length = "0x356")]
	[Token(Token = "0x60004E9")]
	public override bool Load() { }

	[Address(RVA = "0x26F7470", Offset = "0x26F6870", Length = "0x1CF")]
	[Token(Token = "0x60004E8")]
	public override void RollBack() { }

	[Address(RVA = "0x26F7640", Offset = "0x26F6A40", Length = "0x216")]
	[Token(Token = "0x60004EA")]
	public override void Save(bool forceFlg = false) { }

	[Address(RVA = "0x26F7860", Offset = "0x26F6C60", Length = "0x1FB")]
	[Token(Token = "0x60004E6")]
	public override void SetDefault() { }

}

