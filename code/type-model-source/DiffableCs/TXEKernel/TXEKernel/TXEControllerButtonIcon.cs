namespace TXEKernel;

[Token(Token = "0x200010F")]
public class TXEControllerButtonIcon : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000110")]
	private sealed class <Start>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000574")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000575")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000576")]
		public TXEControllerButtonIcon <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700021B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007B5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700021C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60007B7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007B2")]
		public <Start>d__12(int <>1__state) { }

		[Address(RVA = "0x272B340", Offset = "0x272A740", Length = "0x173")]
		[Token(Token = "0x60007B4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007B5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60007B7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x272B4C0", Offset = "0x272A8C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007B6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007B3")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000568")]
	public GameObject _enable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000569")]
	public GameObject _disable; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400056A")]
	public UIImage _enable_image; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400056B")]
	public UIImage _disable_image; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400056C")]
	public Sprite _enable_ps; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400056D")]
	public Sprite _disable_ps; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400056E")]
	public Sprite _enable_sw; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400056F")]
	public Sprite _disable_sw; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000570")]
	public Sprite _enable_other; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000571")]
	public Sprite _disable_other; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000572")]
	public Sprite _enable_switch; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000573")]
	public Sprite _disable_switch; //Field offset: 0x78

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007B1")]
	public TXEControllerButtonIcon() { }

	[Address(RVA = "0x27266E0", Offset = "0x2725AE0", Length = "0x5C")]
	[Token(Token = "0x60007B0")]
	public void Set(bool on) { }

	[Address(RVA = "0x2726740", Offset = "0x2725B40", Length = "0x67")]
	[IteratorStateMachine(typeof(<Start>d__12))]
	[Token(Token = "0x60007AF")]
	private IEnumerator Start() { }

}

