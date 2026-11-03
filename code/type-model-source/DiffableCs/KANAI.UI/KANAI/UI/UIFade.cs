namespace KANAI.UI;

[Token(Token = "0x2000019")]
public class UIFade : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200001C")]
	private sealed class <_progress>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000081")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000082")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000083")]
		public UIFade <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000084")]
		public float tsecond; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000085")]
		public Color s; //Field offset: 0x2C
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000086")]
		public Color t; //Field offset: 0x3C
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000087")]
		public bool isEndDisable; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000088")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000089")]
		private float <ttime>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400008A")]
		private float <trate>5__4; //Field offset: 0x5C

		[Token(Token = "0x17000018")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000097")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000019")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000099")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000094")]
		public <_progress>d__5(int <>1__state) { }

		[Address(RVA = "0x1E18040", Offset = "0x1E17440", Length = "0x27A")]
		[Token(Token = "0x6000096")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000097")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000099")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E182C0", Offset = "0x1E176C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000098")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000095")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <FadeIn>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000077")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000078")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000079")]
		public bool isskip; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400007A")]
		public UIFade <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400007B")]
		public float duration; //Field offset: 0x30

		[Token(Token = "0x17000014")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000015")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600008D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000088")]
		public <FadeIn>d__3(int <>1__state) { }

		[Address(RVA = "0x1E17350", Offset = "0x1E16750", Length = "0x238")]
		[Token(Token = "0x600008A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600008D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E17590", Offset = "0x1E16990", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600008C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000089")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private sealed class <FadeOut>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400007D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400007E")]
		public UIFade <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400007F")]
		public bool isskip; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000080")]
		public float duration; //Field offset: 0x2C

		[Token(Token = "0x17000016")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000091")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000017")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000093")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600008E")]
		public <FadeOut>d__2(int <>1__state) { }

		[Address(RVA = "0x1E175D0", Offset = "0x1E169D0", Length = "0x2EE")]
		[Token(Token = "0x6000090")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000091")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000093")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E178C0", Offset = "0x1E16CC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000092")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600008F")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000072")]
	public const string UIFaderName = "UIFader"; //Field offset: 0x0
	[Token(Token = "0x4000075")]
	public static readonly Color32 DarkColor; //Field offset: 0x0
	[Token(Token = "0x4000076")]
	public static readonly Color32 DarkColorClear; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000073")]
	private bool _isMasked; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000074")]
	private Image fadeImage; //Field offset: 0x28

	[Address(RVA = "0x1E1AAC0", Offset = "0x1E19EC0", Length = "0xAA")]
	[IteratorStateMachine(typeof(<_progress>d__5))]
	[Token(Token = "0x6000085")]
	private IEnumerator _progress(Color s, Color t, float tsecond, bool isEndDisable) { }

	[Address(RVA = "0x1E1AA60", Offset = "0x1E19E60", Length = "0x5E")]
	[Token(Token = "0x6000087")]
	private static UIFade() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000086")]
	public UIFade() { }

	[Address(RVA = "0x1E1A300", Offset = "0x1E19700", Length = "0x469")]
	[Token(Token = "0x6000081")]
	public static UIFade Create(GameObject parent) { }

	[Address(RVA = "0x1E1A770", Offset = "0x1E19B70", Length = "0x8B")]
	[IteratorStateMachine(typeof(<FadeIn>d__3))]
	[Token(Token = "0x6000083")]
	public IEnumerator FadeIn(float duration, bool isskip = false) { }

	[Address(RVA = "0x1E1A800", Offset = "0x1E19C00", Length = "0x8B")]
	[IteratorStateMachine(typeof(<FadeOut>d__2))]
	[Token(Token = "0x6000082")]
	public IEnumerator FadeOut(float duration, bool isskip = false) { }

	[Address(RVA = "0x1E1A890", Offset = "0x1E19C90", Length = "0x1C3")]
	[Token(Token = "0x6000084")]
	public void Initialize() { }

}

