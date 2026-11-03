namespace OutGame.Team;

[Token(Token = "0x2000083")]
public class ControllerSelectPopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000085")]
	private sealed class <>c
	{
		[Token(Token = "0x400020B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400020C")]
		public static Func<Int32, Boolean> <>9__15_0; //Field offset: 0x8

		[Address(RVA = "0x21E0BF0", Offset = "0x21DFFF0", Length = "0x67")]
		[Token(Token = "0x6000352")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000353")]
		public <>c() { }

		[Address(RVA = "0x21E02F0", Offset = "0x21DF6F0", Length = "0x7")]
		[Token(Token = "0x6000354")]
		internal bool <IsNoSelect>b__15_0(int id) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000086")]
	private sealed class <TerminateDelay>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400020D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400020E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400020F")]
		public ControllerSelectPopupContent <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000CE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000358")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000CF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600035A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000355")]
		public <TerminateDelay>d__3(int <>1__state) { }

		[Address(RVA = "0x21DEF00", Offset = "0x21DE300", Length = "0x10E")]
		[Token(Token = "0x6000357")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000358")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600035A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21DF010", Offset = "0x21DE410", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000359")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000356")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000084")]
	private enum PlayerID : int
	{
		P1 = 0,
		P2 = 1,
	}

	[Token(Token = "0x40001FA")]
	private static readonly float doublePlayCheckTime; //Field offset: 0x0
	[Token(Token = "0x40001FB")]
	private static readonly Buttons doublePlayCheckBtns; //Field offset: 0x4
	[Token(Token = "0x40001FC")]
	private static readonly Buttons doublePlayUncheckBtns; //Field offset: 0x8
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001FD")]
	private String[] numberList; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001FE")]
	private String[] colorCodeList; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40001FF")]
	private UITextMeshPro _descriptionText; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000200")]
	private UITextMeshPro[] _messageText; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000201")]
	private UIImage[] _selectWindow; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000202")]
	private Single[] _selectedWait; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000203")]
	private float _closeWait; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000204")]
	private bool _startTeamMode; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000205")]
	private Int32[] _selectedPadIds; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000206")]
	private bool _doublePlayFlg; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000207")]
	private float _doublePlayCheckTimer; //Field offset: 0xA4

	[Token(Token = "0x170000CD")]
	public bool IsDoublePlay
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[Token(Token = "0x600034F")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x21BCC00", Offset = "0x21BC000", Length = "0x709")]
	[Token(Token = "0x6000348")]
	private void _select(AppGamePad pad) { }

	[Address(RVA = "0x21BC730", Offset = "0x21BBB30", Length = "0x63")]
	[Token(Token = "0x6000351")]
	private static ControllerSelectPopupContent() { }

	[Address(RVA = "0x21BC7A0", Offset = "0x21BBBA0", Length = "0x455")]
	[Token(Token = "0x6000350")]
	public ControllerSelectPopupContent() { }

	[Address(RVA = "0x21BD310", Offset = "0x21BC710", Length = "0x1BA")]
	[Token(Token = "0x6000347")]
	private int checkDoublePlay(AppGamePad pad) { }

	[Address(RVA = "0x21BC100", Offset = "0x21BB500", Length = "0x216")]
	[Token(Token = "0x6000345")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[Token(Token = "0x600034F")]
	public bool get_IsDoublePlay() { }

	[Address(RVA = "0x21BD4D0", Offset = "0x21BC8D0", Length = "0x67")]
	[Token(Token = "0x6000349")]
	private string getLocalizeText(string nkey) { }

	[Address(RVA = "0x21BD540", Offset = "0x21BC940", Length = "0x2FA")]
	[Token(Token = "0x600034B")]
	private string getMessageString(PlayerID playerId, int padId) { }

	[Address(RVA = "0x21BD840", Offset = "0x21BCC40", Length = "0x105")]
	[Token(Token = "0x600034A")]
	private string han2zen(string src) { }

	[Address(RVA = "0x21BC320", Offset = "0x21BB720", Length = "0xD9")]
	[Token(Token = "0x6000343")]
	public virtual void Initialize() { }

	[Address(RVA = "0x21BC400", Offset = "0x21BB800", Length = "0x114")]
	[Token(Token = "0x600034D")]
	public bool IsNoSelect(AppGamePad pad) { }

	[Address(RVA = "0x21BC520", Offset = "0x21BB920", Length = "0x13")]
	[Token(Token = "0x600034E")]
	public bool IsStartOk(AppGamePad pad) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000344")]
	public virtual void StartAppear() { }

	[Address(RVA = "0x21BC540", Offset = "0x21BB940", Length = "0x6D")]
	[IteratorStateMachine(typeof(<TerminateDelay>d__3))]
	[Token(Token = "0x6000346")]
	public virtual IEnumerator TerminateDelay() { }

	[Address(RVA = "0x21BC5B0", Offset = "0x21BB9B0", Length = "0x170")]
	[Token(Token = "0x600034C")]
	private void UpdateDisplayOnSelect(PlayerID playerId, int padId) { }

}

