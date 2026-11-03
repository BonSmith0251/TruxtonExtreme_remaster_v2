namespace KANAI.UI;

[Token(Token = "0x200000D")]
public abstract class UIBase : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <WaitAnimation>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002D")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x1700000E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000051")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000053")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600004E")]
		public <WaitAnimation>d__8(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x6000050")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000051")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000053")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E18000", Offset = "0x1E17400", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000052")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600004F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002B")]
	private GameObject <UIObject>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700000D")]
	public private GameObject UIObject
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600004B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600004C")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600004D")]
	protected UIBase() { }

	[Address(RVA = "0x1E18300", Offset = "0x1E17700", Length = "0x78")]
	[Token(Token = "0x6000042")]
	protected override void Awake() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600004B")]
	public GameObject get_UIObject() { }

	[Address(RVA = "0x1E18380", Offset = "0x1E17780", Length = "0x44")]
	[Token(Token = "0x6000044")]
	public override void Hidden() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000045")]
	public override void Initialize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000049")]
	public override bool IsAnimation() { }

	[Address(RVA = "0x1E183D0", Offset = "0x1E177D0", Length = "0x1D")]
	[Token(Token = "0x6000047")]
	public override bool IsShow() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600004C")]
	private void set_UIObject(GameObject value) { }

	[Address(RVA = "0x1E183F0", Offset = "0x1E177F0", Length = "0x1E")]
	[Token(Token = "0x6000048")]
	public override void SetShow(bool value) { }

	[Address(RVA = "0x1E18410", Offset = "0x1E17810", Length = "0x16")]
	[Token(Token = "0x6000043")]
	public override void Show() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000046")]
	public override void Terminate() { }

	[Address(RVA = "0x1E18430", Offset = "0x1E17830", Length = "0x4B")]
	[IteratorStateMachine(typeof(<WaitAnimation>d__8))]
	[Token(Token = "0x600004A")]
	public override IEnumerator WaitAnimation() { }

}

