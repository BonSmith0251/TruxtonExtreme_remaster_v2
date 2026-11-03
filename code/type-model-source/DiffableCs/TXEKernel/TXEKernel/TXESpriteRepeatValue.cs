namespace TXEKernel;

[Token(Token = "0x2000113")]
public class TXESpriteRepeatValue : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057A")]
	private RectTransform _transformCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400057B")]
	private Vector2 _targetSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400057C")]
	private Vector2 _targetWidth; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400057D")]
	private long _displayValue; //Field offset: 0x38

	[Token(Token = "0x1700021D")]
	public long DisplayValue
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60007C3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2727000", Offset = "0x2726400", Length = "0x92")]
	[Token(Token = "0x60007C4")]
	public TXESpriteRepeatValue() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60007C3")]
	public long get_DisplayValue() { }

	[Address(RVA = "0x2726E60", Offset = "0x2726260", Length = "0x98")]
	[Token(Token = "0x60007BE")]
	public void Initialize() { }

	[Address(RVA = "0x1D510C0", Offset = "0x1D504C0", Length = "0x13")]
	[Token(Token = "0x60007C2")]
	private void OnDestroy() { }

	[Address(RVA = "0x2726F70", Offset = "0x2726370", Length = "0x81")]
	[Token(Token = "0x60007C0")]
	public void SetValue(long tnum, bool isForce = false) { }

	[Address(RVA = "0x2726F00", Offset = "0x2726300", Length = "0x66")]
	[Token(Token = "0x60007C1")]
	public void SetValueSprite(long tnum) { }

	[Address(RVA = "0x1D510C0", Offset = "0x1D504C0", Length = "0x13")]
	[Token(Token = "0x60007BF")]
	public void Terminate() { }

}

