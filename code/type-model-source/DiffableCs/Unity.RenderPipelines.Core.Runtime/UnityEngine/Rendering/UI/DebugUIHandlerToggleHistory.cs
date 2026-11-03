namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002EE")]
public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
{
	[CompilerGenerated]
	[Token(Token = "0x20002EF")]
	private sealed class <RefreshAfterSanitization>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D82")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D83")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D84")]
		public DebugUIHandlerToggleHistory <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700026F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60014A4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000270")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60014A6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60014A1")]
		public <RefreshAfterSanitization>d__4(int <>1__state) { }

		[Address(RVA = "0x2CBF720", Offset = "0x2CBEB20", Length = "0xAE")]
		[Token(Token = "0x60014A3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60014A4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60014A6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2CBF900", Offset = "0x2CBED00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60014A5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60014A2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000D81")]
	private const float k_XOffset = 230; //Field offset: 0x0
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D80")]
	private Toggle[] historyToggles; //Field offset: 0x80

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014A0")]
	public DebugUIHandlerToggleHistory() { }

	[Address(RVA = "0x2CB5620", Offset = "0x2CB4A20", Length = "0x67")]
	[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
	[Token(Token = "0x600149F")]
	private IEnumerator RefreshAfterSanitization() { }

	[Address(RVA = "0x2CB5690", Offset = "0x2CB4A90", Length = "0x614")]
	[Token(Token = "0x600149D")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB5CB0", Offset = "0x2CB50B0", Length = "0x284")]
	[Token(Token = "0x600149E")]
	protected private virtual void UpdateValueLabel() { }

}

