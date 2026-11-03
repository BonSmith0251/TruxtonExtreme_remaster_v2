namespace OutGame.UI;

[Token(Token = "0x2000142")]
public class StageResultItem : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000143")]
	private sealed class <animationScoreCount>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000571")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000572")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000573")]
		public StageResultItem <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000574")]
		private float <countUpSecond>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000575")]
		private float <countUpTotalSecond>5__3; //Field offset: 0x2C

		[Token(Token = "0x170001CC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000800")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001CD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000802")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60007FD")]
		public <animationScoreCount>d__3(int <>1__state) { }

		[Address(RVA = "0x220E0B0", Offset = "0x220D4B0", Length = "0x363")]
		[Token(Token = "0x60007FF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000800")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000802")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220E420", Offset = "0x220D820", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000801")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007FE")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400055F")]
	private StageResultPopupContent _parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000560")]
	private TXEUIFontText _passingLine; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000561")]
	private string _labelName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000562")]
	private UITextMeshPro _nameUiText; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000563")]
	private TXEUIFontText _numberUiText; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000564")]
	private UIImage _numberUiGauge; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000565")]
	private TXEUIFontText _scoreUiText; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000566")]
	private GameObject _successStamp; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000567")]
	private long _displayScore; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000568")]
	private int _initialNumber; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000569")]
	private int _endNumber; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400056A")]
	private long _score; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400056B")]
	private bool _isSuccessStamp; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x400056C")]
	private bool _isBonus; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x400056D")]
	private bool _isTime; //Field offset: 0x7A
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400056E")]
	private Vector3 _savePosision; //Field offset: 0x7C
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400056F")]
	private Nullable<Int32> _seChannel; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000570")]
	private bool _isComplate; //Field offset: 0x90

	[Token(Token = "0x170001CA")]
	private bool _hasNumberUiGauge
	{
		[Address(RVA = "0x2201700", Offset = "0x2200B00", Length = "0x50")]
		[Token(Token = "0x60007FA")]
		private get { } //Length: 80
	}

	[Token(Token = "0x170001C9")]
	public long DisplayScore
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60007F9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CB")]
	public bool IsComplate
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x60007FB")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x22014F0", Offset = "0x22008F0", Length = "0x19B")]
	[Token(Token = "0x60007F7")]
	private void _setNumberAndScore(int displayNumber, long displayScore) { }

	[Address(RVA = "0x2201470", Offset = "0x2200870", Length = "0x7E")]
	[Token(Token = "0x60007FC")]
	public StageResultItem() { }

	[Address(RVA = "0x2201690", Offset = "0x2200A90", Length = "0x67")]
	[IteratorStateMachine(typeof(<animationScoreCount>d__3))]
	[Token(Token = "0x60007F6")]
	private IEnumerator animationScoreCount() { }

	[Address(RVA = "0x2201070", Offset = "0x2200470", Length = "0xAD")]
	[Token(Token = "0x60007F3")]
	public void Awake() { }

	[Address(RVA = "0x2201700", Offset = "0x2200B00", Length = "0x50")]
	[Token(Token = "0x60007FA")]
	private bool get__hasNumberUiGauge() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60007F9")]
	public long get_DisplayScore() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x60007FB")]
	public bool get_IsComplate() { }

	[Address(RVA = "0x2201120", Offset = "0x2200520", Length = "0x1E")]
	[Token(Token = "0x60007F8")]
	public void PassingLineText(string txt) { }

	[Address(RVA = "0x2201140", Offset = "0x2200540", Length = "0x2A1")]
	[Token(Token = "0x60007F4")]
	public void Setup(StageResultPopupContent parent, Vector3 pos, int initialNumber, int endNumber, long score, bool isSuccessStamp, bool isBonus, bool isTime) { }

	[Address(RVA = "0x22013F0", Offset = "0x22007F0", Length = "0x71")]
	[Token(Token = "0x60007F5")]
	public void StartContent() { }

}

