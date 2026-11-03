namespace OutGame.UI;

[Token(Token = "0x2000164")]
public class UnlockItemWindow : MonoBehaviour
{
	[Token(Token = "0x4000643")]
	private const float termTime = 0.25; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000644")]
	private TXEUIFontText _uiText; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000645")]
	private RectTransform _windowTransform; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000646")]
	private Vector2 _fromPosition; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000647")]
	private Vector2 _toPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000648")]
	private float _moveTime; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000649")]
	private bool _isComplate; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x400064A")]
	private bool _ssr; //Field offset: 0x45

	[Token(Token = "0x170001F5")]
	public bool IsComplate
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[Token(Token = "0x60008F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001F4")]
	public RectTransform WindowTransform
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60008F4")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60008F5")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2210970", Offset = "0x220FD70", Length = "0x188")]
	[Token(Token = "0x60008F3")]
	private void _updatePosition() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60008F7")]
	public UnlockItemWindow() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[Token(Token = "0x60008F6")]
	public bool get_IsComplate() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60008F4")]
	public RectTransform get_WindowTransform() { }

	[Address(RVA = "0x2210910", Offset = "0x220FD10", Length = "0x3D")]
	[Token(Token = "0x60008F1")]
	public Vector2 GetPosition() { }

	[Address(RVA = "0x21F4140", Offset = "0x21F3540", Length = "0x1E")]
	[Token(Token = "0x60008EF")]
	public void Initialize(string text) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60008F5")]
	public void set_WindowTransform(RectTransform value) { }

	[Address(RVA = "0x2210950", Offset = "0x220FD50", Length = "0x18")]
	[Token(Token = "0x60008F2")]
	public void StartMove(Vector2 formPosition, Vector2 toPosition, bool ssr = false) { }

	[Address(RVA = "0x2210970", Offset = "0x220FD70", Length = "0x188")]
	[Token(Token = "0x60008F0")]
	private void Update() { }

}

