namespace KANAI.Popup;

[Token(Token = "0x2000005")]
public class ChoicesPopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		public int buttonID; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		public ChoicesPopupContent <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000011")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x1E0E590", Offset = "0x1E0D990", Length = "0x30")]
		[Token(Token = "0x6000012")]
		internal void <_createButtons>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <AppearanceDelay>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000013")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000014")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000015")]
		public ChoicesPopupContent <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000001")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000016")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000002")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000018")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000013")]
		public <AppearanceDelay>d__4(int <>1__state) { }

		[Address(RVA = "0x1E0DDA0", Offset = "0x1E0D1A0", Length = "0xA9")]
		[Token(Token = "0x6000015")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000016")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000018")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0DE50", Offset = "0x1E0D250", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000017")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000014")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000010")]
	private static readonly Dictionary<String, Int32> defaultButtonDic; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private GameObject buttonArea; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000007")]
	private GameObject textArea; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private GameObject _buttonPrefab; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private int buttonDistance; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private int TextDistance; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400000B")]
	private List<UITextMeshPro> _texts; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400000C")]
	private int _defaultCode; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400000D")]
	private int _defaultFloor; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400000E")]
	private int _defaultIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400000F")]
	private Dictionary<String, Int32> buttonDic; //Field offset: 0x98

	[Address(RVA = "0x1E03E60", Offset = "0x1E03260", Length = "0x9A5")]
	[Token(Token = "0x600000D")]
	private void _createButtons() { }

	[Address(RVA = "0x1E03BD0", Offset = "0x1E02FD0", Length = "0x282")]
	[Token(Token = "0x600000F")]
	private static ChoicesPopupContent() { }

	[Address(RVA = "0x1E04810", Offset = "0x1E03C10", Length = "0xE1")]
	[Token(Token = "0x600000E")]
	public ChoicesPopupContent() { }

	[Address(RVA = "0x1E03B80", Offset = "0x1E02F80", Length = "0x4B")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000010")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x1E039B0", Offset = "0x1E02DB0", Length = "0x67")]
	[IteratorStateMachine(typeof(<AppearanceDelay>d__4))]
	[Token(Token = "0x600000B")]
	public virtual IEnumerator AppearanceDelay() { }

	[Address(RVA = "0x1E03A20", Offset = "0x1E02E20", Length = "0x45")]
	[Token(Token = "0x6000007")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6000009")]
	public void SetButtonDic(Dictionary<String, Int32> _tdic) { }

	[Address(RVA = "0x1E03A90", Offset = "0x1E02E90", Length = "0x66")]
	[Token(Token = "0x600000A")]
	public void SetDefaultButton() { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[Token(Token = "0x6000008")]
	public void SetDefaultPosition(int nCode) { }

	[Address(RVA = "0x1E03B00", Offset = "0x1E02F00", Length = "0x70")]
	[Token(Token = "0x600000C")]
	public virtual void StartActive() { }

}

