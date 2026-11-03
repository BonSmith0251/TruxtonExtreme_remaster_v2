namespace OutGame.UI;

[Token(Token = "0x2000110")]
public class EpisodeButton : MonoBehaviour
{
	[Token(Token = "0x4000492")]
	private static readonly string EpisodeLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400048C")]
	private PopupButton _button; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400048D")]
	private UINew _newMark; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400048E")]
	private UIImage _completeMark; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400048F")]
	private TXEUIFontText _buttonText; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000490")]
	private bool _isPlayable; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000491")]
	private bool _isComplete; //Field offset: 0x41

	[Token(Token = "0x17000196")]
	public PopupButton Button
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60006DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000197")]
	public bool IsComplete
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x60006DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000198")]
	public bool IsPlayable
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x60006DF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21E8F70", Offset = "0x21E8370", Length = "0x62")]
	[Token(Token = "0x60006E1")]
	private static EpisodeButton() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006E0")]
	public EpisodeButton() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60006DD")]
	public PopupButton get_Button() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x60006DE")]
	public bool get_IsComplete() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x60006DF")]
	public bool get_IsPlayable() { }

	[Address(RVA = "0x21E8C40", Offset = "0x21E8040", Length = "0x53")]
	[Token(Token = "0x60006DC")]
	public void SetButtonState(ButtonState bstate) { }

	[Address(RVA = "0x21E8DF0", Offset = "0x21E81F0", Length = "0x17D")]
	[Token(Token = "0x60006DA")]
	public void Setup(int episode, in StageData stageData) { }

	[Address(RVA = "0x21E8CA0", Offset = "0x21E80A0", Length = "0x148")]
	[Token(Token = "0x60006DB")]
	public void SetupForViewer(int episode, in StageData stageData) { }

}

