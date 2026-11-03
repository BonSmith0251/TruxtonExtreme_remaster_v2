namespace OutGame.UI;

[Token(Token = "0x200011B")]
public class NowDownLoading : MonoBehaviourSingleton<NowDownLoading>
{
	[Token(Token = "0x200011C")]
	internal class NowDownLoadingScope : IDisposable
	{

		[Address(RVA = "0x21EB780", Offset = "0x21EAB80", Length = "0xB4")]
		[Token(Token = "0x6000717")]
		public NowDownLoadingScope() { }

		[Address(RVA = "0x21EB6D0", Offset = "0x21EAAD0", Length = "0xA7")]
		[Token(Token = "0x6000718")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004B6")]
	private UIImage _icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004B7")]
	private UIRotater _rotater; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B8")]
	private bool _isLoading; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40004B9")]
	private bool _forceHiddenFlag; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x40004BA")]
	private bool _isBlink; //Field offset: 0x32
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004BB")]
	private float _canvasAlpha; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004BC")]
	private float _blinkTimer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004BD")]
	private CanvasGroup _canvas; //Field offset: 0x40

	[Address(RVA = "0x21EBCF0", Offset = "0x21EB0F0", Length = "0x39")]
	[Token(Token = "0x6000716")]
	public NowDownLoading() { }

	[Address(RVA = "0x21EB840", Offset = "0x21EAC40", Length = "0xA1")]
	[Token(Token = "0x6000710")]
	protected virtual void Awake() { }

	[Address(RVA = "0x21EB8F0", Offset = "0x21EACF0", Length = "0x44")]
	[Token(Token = "0x6000714")]
	private void DisplayActive(bool tactive) { }

	[Address(RVA = "0x21EB940", Offset = "0x21EAD40", Length = "0x9A")]
	[Token(Token = "0x6000715")]
	private bool IsForceHidden() { }

	[Address(RVA = "0x21EB9E0", Offset = "0x21EADE0", Length = "0x52")]
	[Token(Token = "0x6000711")]
	public void Loading(bool isLoading) { }

	[Address(RVA = "0x21EBA40", Offset = "0x21EAE40", Length = "0x16D")]
	[Token(Token = "0x6000713")]
	private void ProgressIcon() { }

	[Address(RVA = "0x21EBBB0", Offset = "0x21EAFB0", Length = "0x136")]
	[Token(Token = "0x6000712")]
	private void Update() { }

}

