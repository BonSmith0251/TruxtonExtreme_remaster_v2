namespace InGame.Kernel.Effect;

[Token(Token = "0x200023A")]
public class InGameEffectSwapper : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40013B7")]
	private InGameEffect _effectA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40013B8")]
	private InGameEffect _effectB; //Field offset: 0x28

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001106")]
	public InGameEffectSwapper() { }

	[Address(RVA = "0x1D15420", Offset = "0x1D14820", Length = "0x4C")]
	[Token(Token = "0x60010FF")]
	public void EntryInGame() { }

	[Address(RVA = "0x1D15470", Offset = "0x1D14870", Length = "0x45")]
	[Token(Token = "0x6001105")]
	public void FadeAlpha(float trate) { }

	[Address(RVA = "0x1D154C0", Offset = "0x1D148C0", Length = "0x84")]
	[Token(Token = "0x60010FB")]
	public void Initialize() { }

	[Address(RVA = "0x1D15550", Offset = "0x1D14950", Length = "0x51")]
	[Token(Token = "0x6001103")]
	public void Rate(float trate) { }

	[Address(RVA = "0x1D155B0", Offset = "0x1D149B0", Length = "0x4C")]
	[Token(Token = "0x6001100")]
	public void RemoveInGame() { }

	[Address(RVA = "0x1D15600", Offset = "0x1D14A00", Length = "0x45")]
	[Token(Token = "0x6001104")]
	public void SetAB(float trateA, float trateB) { }

	[Address(RVA = "0x1D156A0", Offset = "0x1D14AA0", Length = "0x59")]
	[Token(Token = "0x60010FC")]
	public void SetSortingLayer(int nlayer) { }

	[Address(RVA = "0x1D15650", Offset = "0x1D14A50", Length = "0x42")]
	[Token(Token = "0x60010FD")]
	public void SetSortingLayerIfDefault(int nlayer) { }

	[Address(RVA = "0x1D15700", Offset = "0x1D14B00", Length = "0x89")]
	[Token(Token = "0x6001101")]
	public void StartAll(float trate) { }

	[Address(RVA = "0x1D15790", Offset = "0x1D14B90", Length = "0x4C")]
	[Token(Token = "0x6001102")]
	public void StopAll() { }

	[Address(RVA = "0x1D157E0", Offset = "0x1D14BE0", Length = "0x4C")]
	[Token(Token = "0x60010FE")]
	public void Terminate() { }

}

