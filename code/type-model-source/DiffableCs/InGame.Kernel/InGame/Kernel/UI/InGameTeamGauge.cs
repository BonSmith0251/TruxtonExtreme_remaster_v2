namespace InGame.Kernel.UI;

[DefaultExecutionOrder(10)]
[Token(Token = "0x20000B7")]
public class InGameTeamGauge : MonoBehaviour
{
	[Token(Token = "0x4000574")]
	private const float DisplaySecond = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000575")]
	private static readonly Vector2 markerOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000576")]
	private UIImage _PMark; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	private UIImage _RGauge; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	private UIImageColor _RGaugeColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000579")]
	private UIImage _RFrame; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400057A")]
	private RectTransform _transform; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400057B")]
	private int _pno; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400057C")]
	private float _ttall; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400057D")]
	private float _tsize; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400057E")]
	private float _displayTime; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400057F")]
	private bool _isDisplay; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000580")]
	private bool _isSetuped; //Field offset: 0x59

	[Address(RVA = "0x1D38130", Offset = "0x1D37530", Length = "0x40")]
	[Token(Token = "0x60006A6")]
	private static InGameTeamGauge() { }

	[Address(RVA = "0x1D38170", Offset = "0x1D37570", Length = "0xE")]
	[Token(Token = "0x60006A5")]
	public InGameTeamGauge() { }

	[Address(RVA = "0x1D37C90", Offset = "0x1D37090", Length = "0xE1")]
	[Token(Token = "0x60006A4")]
	private void DisplayGauge(bool isDisplay, bool isRescue, float grate, float tremain) { }

	[Address(RVA = "0x1D37D80", Offset = "0x1D37180", Length = "0x8E")]
	[Token(Token = "0x60006A0")]
	public void Initialize(int pno) { }

	[Address(RVA = "0x1D37E10", Offset = "0x1D37210", Length = "0x2AB")]
	[Token(Token = "0x60006A3")]
	private void LateUpdate() { }

	[Address(RVA = "0x1D380C0", Offset = "0x1D374C0", Length = "0xB")]
	[Token(Token = "0x60006A2")]
	public void SetupMark(float tsize, float ttall) { }

	[Address(RVA = "0x1D380D0", Offset = "0x1D374D0", Length = "0x51")]
	[Token(Token = "0x60006A1")]
	public void Terminate() { }

}

