namespace TXEKernel;

[Token(Token = "0x2000114")]
public class TXESpriteValue : MonoBehaviour
{
	[Token(Token = "0x4000589")]
	private static readonly Int64[] nKetas; //Field offset: 0x0
	[Token(Token = "0x400058A")]
	private static readonly Vector2 _numPivot; //Field offset: 0x8
	[Token(Token = "0x400058B")]
	private static readonly Vector2 _numAnchor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057E")]
	private Image[] _numberImages; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400057F")]
	private RectTransform[] _numberRects; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000580")]
	private int _ketaCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000581")]
	private Vector2 _NumberSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000582")]
	private int _displayW; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000583")]
	private int _KetaSpace; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000584")]
	private bool _isSpaceSupperssion; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	[Token(Token = "0x4000585")]
	private bool _isZeroSuppression; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	[Token(Token = "0x4000586")]
	private bool _isCentering; //Field offset: 0x46
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	[Token(Token = "0x4000587")]
	private bool _isProportional; //Field offset: 0x47
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000588")]
	private long _displayValue; //Field offset: 0x48

	[Token(Token = "0x1700021E")]
	public long DisplayValue
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60007D1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2727F80", Offset = "0x2727380", Length = "0xA9")]
	[Token(Token = "0x60007CF")]
	private Vector3 _getFirstPosition(long tnum) { }

	[Address(RVA = "0x2728030", Offset = "0x2727430", Length = "0x1DD")]
	[Token(Token = "0x60007D0")]
	private float _getWidth(long tnum) { }

	[Address(RVA = "0x2728210", Offset = "0x2727610", Length = "0x1D3")]
	[Token(Token = "0x60007CE")]
	private void _setRectTransform(RectTransform numT) { }

	[Address(RVA = "0x2727E40", Offset = "0x2727240", Length = "0xC5")]
	[Token(Token = "0x60007D3")]
	private static TXESpriteValue() { }

	[Address(RVA = "0x2727F10", Offset = "0x2727310", Length = "0x68")]
	[Token(Token = "0x60007D2")]
	public TXESpriteValue() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60007D1")]
	public long get_DisplayValue() { }

	[Address(RVA = "0x27270A0", Offset = "0x27264A0", Length = "0x19")]
	[Token(Token = "0x60007C5")]
	public void Initialize(int nketa, Vector2 nsize, int displayW = 32, int nketaSpace = 0) { }

	[Address(RVA = "0x27270C0", Offset = "0x27264C0", Length = "0x540")]
	[Token(Token = "0x60007C6")]
	public void Initialize() { }

	[Address(RVA = "0x2727610", Offset = "0x2726A10", Length = "0xE1")]
	[Token(Token = "0x60007CD")]
	private void OnDestroy() { }

	[Address(RVA = "0x2727700", Offset = "0x2726B00", Length = "0x142")]
	[Token(Token = "0x60007CB")]
	public void SetAlpha(float a) { }

	[Address(RVA = "0x2727850", Offset = "0x2726C50", Length = "0x85")]
	[Token(Token = "0x60007CA")]
	public void SetColor(Color c) { }

	[Address(RVA = "0x2727E00", Offset = "0x2727200", Length = "0x2C")]
	[Token(Token = "0x60007C8")]
	public void SetValue(long tnum, bool isForce = false) { }

	[Address(RVA = "0x27278E0", Offset = "0x2726CE0", Length = "0x51E")]
	[Token(Token = "0x60007CC")]
	private void SetValueSprite(long tnum) { }

	[Address(RVA = "0x2727E30", Offset = "0x2727230", Length = "0x8")]
	[Token(Token = "0x60007C9")]
	public void SetZeroSuppress(bool tflag, bool tCenter) { }

	[Address(RVA = "0x2727610", Offset = "0x2726A10", Length = "0xE1")]
	[Token(Token = "0x60007C7")]
	public void Terminate() { }

}

