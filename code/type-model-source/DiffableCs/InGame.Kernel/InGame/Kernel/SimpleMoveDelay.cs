namespace InGame.Kernel;

[Token(Token = "0x20000AD")]
public class SimpleMoveDelay : SimpleMove
{
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000530")]
	private float _delayTimeBase; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000531")]
	private float _delayTimePass; //Field offset: 0xEC

	[Address(RVA = "0x1D40F70", Offset = "0x1D40370", Length = "0xB")]
	[Token(Token = "0x600064B")]
	protected virtual void _setupStart() { }

	[Address(RVA = "0x1D40FB0", Offset = "0x1D403B0", Length = "0x29")]
	[Token(Token = "0x600064C")]
	protected virtual void _updateMove(float tdt) { }

	[Address(RVA = "0x1D40F90", Offset = "0x1D40390", Length = "0x1B")]
	[Token(Token = "0x600064F")]
	public SimpleMoveDelay() { }

	[Address(RVA = "0x1D40F70", Offset = "0x1D40370", Length = "0xB")]
	[Token(Token = "0x600064E")]
	public void ResetPassTime() { }

	[Address(RVA = "0x1D40F80", Offset = "0x1D40380", Length = "0xD")]
	[Token(Token = "0x600064D")]
	public void SkipPassTime() { }

}

