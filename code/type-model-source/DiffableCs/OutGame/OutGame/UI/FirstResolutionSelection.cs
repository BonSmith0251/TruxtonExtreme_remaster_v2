namespace OutGame.UI;

[Token(Token = "0x2000113")]
public class FirstResolutionSelection : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000114")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400049D")]
		public int iIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400049E")]
		public FirstResolutionSelection <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006F4")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x21F8220", Offset = "0x21F7620", Length = "0x2C")]
		[Token(Token = "0x60006F5")]
		internal void <Initialize>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000115")]
	private sealed class <Show>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400049F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004A0")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000199")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700019A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60006FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60006F6")]
		public <Show>d__1(int <>1__state) { }

		[Address(RVA = "0x21F7E20", Offset = "0x21F7220", Length = "0x285")]
		[Token(Token = "0x60006F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60006FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21F80B0", Offset = "0x21F74B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60006FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60006F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000498")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"width", "height", "fullscreen"})]
	private static readonly ValueTuple<Int32, Int32, Int32>[] resolutions; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000499")]
	private PopupButton[] _buttons; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400049A")]
	private int _currentArea; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400049B")]
	private int _resolutionMax; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400049C")]
	private bool _isComplate; //Field offset: 0x70

	[Address(RVA = "0x21E9DA0", Offset = "0x21E91A0", Length = "0x172")]
	[Token(Token = "0x60006EF")]
	private bool _buttonUpdate() { }

	[Address(RVA = "0x21EA210", Offset = "0x21E9610", Length = "0x75")]
	[Token(Token = "0x60006F1")]
	private int _stepMove(int tstep) { }

	[Address(RVA = "0x21E9F20", Offset = "0x21E9320", Length = "0x2E1")]
	[Token(Token = "0x60006F3")]
	private static FirstResolutionSelection() { }

	[Address(RVA = "0x21E8C30", Offset = "0x21E8030", Length = "0x7")]
	[Token(Token = "0x60006F2")]
	public FirstResolutionSelection() { }

	[Address(RVA = "0x21E9690", Offset = "0x21E8A90", Length = "0x2F")]
	[Token(Token = "0x60006ED")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x21E96C0", Offset = "0x21E8AC0", Length = "0x1F5")]
	[Token(Token = "0x60006F0")]
	private int GetStartIndex() { }

	[Address(RVA = "0x21E98C0", Offset = "0x21E8CC0", Length = "0x303")]
	[Token(Token = "0x60006EC")]
	public virtual void Initialize() { }

	[Address(RVA = "0x21E9BD0", Offset = "0x21E8FD0", Length = "0x26")]
	[Token(Token = "0x60006EA")]
	public static bool IsResolutionChangeAllowed() { }

	[Address(RVA = "0x21E9C00", Offset = "0x21E9000", Length = "0x14C")]
	[Token(Token = "0x60006EE")]
	private void OnClickButton() { }

	[Address(RVA = "0x21E9D50", Offset = "0x21E9150", Length = "0x4B")]
	[IteratorStateMachine(typeof(<Show>d__1))]
	[Token(Token = "0x60006EB")]
	public static IEnumerator Show() { }

}

