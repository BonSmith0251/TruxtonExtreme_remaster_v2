namespace KANAI.UI;

[Token(Token = "0x200003D")]
public class UISafeArea : MonoBehaviour
{
	[Token(Token = "0x400018E")]
	private const float outsideAreaRatio = 0.06; //Field offset: 0x0
	[Token(Token = "0x400018F")]
	private const float baseAspectRatio = 1.7777778; //Field offset: 0x0
	[Token(Token = "0x4000190")]
	private const float safeAreaRatioW = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000191")]
	private const float safeAreaRatioH = 0.05; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000192")]
	private int screenHeight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000193")]
	private int screenWidth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000194")]
	private Rect safeArea; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000195")]
	private bool _isOnlyHeightSafe; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000196")]
	private bool _isOnlyWidthSafe; //Field offset: 0x39

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60001A8")]
	public UISafeArea() { }

	[Address(RVA = "0x1E26A30", Offset = "0x1E25E30", Length = "0x41B")]
	[Token(Token = "0x60001A4")]
	private void adjust() { }

	[Address(RVA = "0x1E269E0", Offset = "0x1E25DE0", Length = "0x7")]
	[Token(Token = "0x60001A2")]
	public void Awake() { }

	[Address(RVA = "0x1E26E50", Offset = "0x1E26250", Length = "0x14A")]
	[Token(Token = "0x60001A6")]
	private Rect getSafeArea() { }

	[Address(RVA = "0x1E26FA0", Offset = "0x1E263A0", Length = "0x47")]
	[Token(Token = "0x60001A7")]
	private bool isCalculationSafeArea() { }

	[Address(RVA = "0x1E26FF0", Offset = "0x1E263F0", Length = "0x42")]
	[Token(Token = "0x60001A5")]
	private bool isUpdateSafeArea() { }

	[Address(RVA = "0x1E269F0", Offset = "0x1E25DF0", Length = "0x3E")]
	[Token(Token = "0x60001A3")]
	public void Update() { }

}

