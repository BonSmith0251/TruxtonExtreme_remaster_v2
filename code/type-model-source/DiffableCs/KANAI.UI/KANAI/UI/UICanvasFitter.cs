namespace KANAI.UI;

[Token(Token = "0x2000011")]
public class UICanvasFitter : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	private static readonly float baseRatio; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000039")]
	private CanvasScaler _scaler; //Field offset: 0x20

	[Address(RVA = "0x1E18B40", Offset = "0x1E17F40", Length = "0x39")]
	[Token(Token = "0x6000069")]
	private static UICanvasFitter() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000068")]
	public UICanvasFitter() { }

	[Address(RVA = "0x1E18A70", Offset = "0x1E17E70", Length = "0xCE")]
	[Token(Token = "0x6000067")]
	private void Awake() { }

}

