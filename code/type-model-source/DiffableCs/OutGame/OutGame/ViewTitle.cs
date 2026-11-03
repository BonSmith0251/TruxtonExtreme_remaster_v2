namespace OutGame;

[Token(Token = "0x2000044")]
public class ViewTitle : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <PreOpenMenu>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E1")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E2")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000E3")]
		public ViewTitle <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000E4")]
		public bool isTruxton; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40000E5")]
		public float tsec; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000E6")]
		private float <ttime>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000E7")]
		private YieldInstruction <ywait>5__3; //Field offset: 0x38

		[Token(Token = "0x1700005A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000196")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700005B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000198")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000193")]
		public <PreOpenMenu>d__1(int <>1__state) { }

		[Address(RVA = "0x21C9260", Offset = "0x21C8660", Length = "0x41C")]
		[Token(Token = "0x6000195")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000196")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000198")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21C9680", Offset = "0x21C8A80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000197")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000194")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private UITextMeshPro _versionText; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private UIImage _titleTruxton; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	private UIImage _titleTatsujin; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	private TXEMenuWindow _mainWindow; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	private UITextMeshPro _gamerTagText; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	private GameObject _gamerTagObject; //Field offset: 0x48

	[Token(Token = "0x17000059")]
	public TXEMenuWindow MainMenu
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000192")]
	public ViewTitle() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000191")]
	public TXEMenuWindow get_MainMenu() { }

	[Address(RVA = "0x21D1FA0", Offset = "0x21D13A0", Length = "0x8B")]
	[IteratorStateMachine(typeof(<PreOpenMenu>d__1))]
	[Token(Token = "0x600018F")]
	public IEnumerator PreOpenMenu(float tsec, bool isTruxton) { }

	[Address(RVA = "0x21D2030", Offset = "0x21D1430", Length = "0x1A2")]
	[Token(Token = "0x600018E")]
	private void Start() { }

	[Address(RVA = "0x21D21E0", Offset = "0x21D15E0", Length = "0xDF")]
	[Token(Token = "0x6000190")]
	private void UpdateGamertag() { }

}

