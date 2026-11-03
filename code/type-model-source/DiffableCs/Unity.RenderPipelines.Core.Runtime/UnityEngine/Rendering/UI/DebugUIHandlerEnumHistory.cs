namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D8")]
public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
{
	[CompilerGenerated]
	[Token(Token = "0x20002D9")]
	private sealed class <RefreshAfterSanitization>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D32")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D33")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D34")]
		public DebugUIHandlerEnumHistory <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700026D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600141C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700026E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600141E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6001419")]
		public <RefreshAfterSanitization>d__4(int <>1__state) { }

		[Address(RVA = "0x2CBF7D0", Offset = "0x2CBEBD0", Length = "0x127")]
		[Token(Token = "0x600141B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600141C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600141E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2CBF940", Offset = "0x2CBED40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600141D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600141A")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000D31")]
	private const float k_XOffset = 230; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D30")]
	private Text[] historyValues; //Field offset: 0x88

	[Address(RVA = "0x2CB0A50", Offset = "0x2CAFE50", Length = "0x39")]
	[Token(Token = "0x6001418")]
	public DebugUIHandlerEnumHistory() { }

	[Address(RVA = "0x2CB0A90", Offset = "0x2CAFE90", Length = "0x67")]
	[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
	[Token(Token = "0x6001417")]
	private IEnumerator RefreshAfterSanitization() { }

	[Address(RVA = "0x2CB0B00", Offset = "0x2CAFF00", Length = "0x35B")]
	[Token(Token = "0x6001415")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB0E60", Offset = "0x2CB0260", Length = "0x2CE")]
	[Token(Token = "0x6001416")]
	public virtual void UpdateValueLabel() { }

}

