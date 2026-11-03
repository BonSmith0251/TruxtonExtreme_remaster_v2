namespace InGame.Kernel.Effect;

[Token(Token = "0x2000235")]
public class EffectScore5000 : InGameEffect
{
	[Token(Token = "0x2000236")]
	private enum MulSprites : int
	{
		n10 = 0,
		n00 = 1,
		cross = 2,
	}

	[Token(Token = "0x4001391")]
	private static readonly float NumDisplaySeconds; //Field offset: 0x0
	[Token(Token = "0x4001392")]
	private static readonly float NumFadeintSeconds; //Field offset: 0x4
	[Token(Token = "0x4001393")]
	private static readonly float NumFadeinTime; //Field offset: 0x8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x400138B")]
	private SpriteRenderer[] _sprites; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x400138C")]
	private Sprite[] _nums; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400138D")]
	private int _numRender; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400138E")]
	private int _numMul; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400138F")]
	private float _numDisplayTime; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4001390")]
	private float _talpha; //Field offset: 0x10C

	[Address(RVA = "0x1D13ED0", Offset = "0x1D132D0", Length = "0x6A")]
	[Token(Token = "0x60010CA")]
	private static EffectScore5000() { }

	[Address(RVA = "0x1D13F40", Offset = "0x1D13340", Length = "0xA8")]
	[Token(Token = "0x60010C9")]
	public EffectScore5000() { }

	[Address(RVA = "0x1D136C0", Offset = "0x1D12AC0", Length = "0xED")]
	[Token(Token = "0x60010C3")]
	private float GetAlpha() { }

	[Address(RVA = "0x1D137B0", Offset = "0x1D12BB0", Length = "0x2E")]
	[Token(Token = "0x60010C7")]
	private Sprite GetNums(int n) { }

	[Address(RVA = "0x1D137E0", Offset = "0x1D12BE0", Length = "0x3C")]
	[Token(Token = "0x60010C8")]
	private SpriteRenderer GetRenderer(MulSprites n) { }

	[Address(RVA = "0x1D13820", Offset = "0x1D12C20", Length = "0x47")]
	[Token(Token = "0x60010BE")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D13870", Offset = "0x1D12C70", Length = "0x29C")]
	[Token(Token = "0x60010C0")]
	protected virtual void PlayStartEffect() { }

	[Address(RVA = "0x1D13B10", Offset = "0x1D12F10", Length = "0x136")]
	[Token(Token = "0x60010C2")]
	public virtual bool ProgressEffect(float dt, float ts) { }

	[Address(RVA = "0x1D13C50", Offset = "0x1D13050", Length = "0x11")]
	[Token(Token = "0x60010C5")]
	public virtual void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D13C70", Offset = "0x1D13070", Length = "0xF8")]
	[Token(Token = "0x60010C4")]
	private void SetAlphaMaterial(float talpha) { }

	[Address(RVA = "0x1D13D70", Offset = "0x1D13170", Length = "0x6A")]
	[Token(Token = "0x60010BF")]
	public virtual void SetIntEffect(int nmul) { }

	[Address(RVA = "0x1D13DE0", Offset = "0x1D131E0", Length = "0x6E")]
	[Token(Token = "0x60010C6")]
	private void SetNumDisable() { }

	[Address(RVA = "0x1D13E50", Offset = "0x1D13250", Length = "0x7B")]
	[Token(Token = "0x60010C1")]
	public virtual void SetSortingLayer(int tid) { }

}

