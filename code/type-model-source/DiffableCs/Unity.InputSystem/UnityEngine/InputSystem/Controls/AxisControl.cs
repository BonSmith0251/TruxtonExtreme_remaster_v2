namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x200021B")]
public class AxisControl : InputControl<Single>
{
	[Token(Token = "0x200021C")]
	internal enum Clamp : int
	{
		None = 0,
		BeforeNormalize = 1,
		AfterNormalize = 2,
		ToConstantBeforeNormalize = 3,
	}

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000BF9")]
	public Clamp clamp; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000BFA")]
	public float clampMin; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000BFB")]
	public float clampMax; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000BFC")]
	public float clampConstant; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000BFD")]
	public bool invert; //Field offset: 0x118
	[FieldOffset(Offset = "0x119")]
	[Token(Token = "0x4000BFE")]
	public bool normalize; //Field offset: 0x119
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000BFF")]
	public float normalizeMin; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C00")]
	public float normalizeMax; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000C01")]
	public float normalizeZero; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C02")]
	public bool scale; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000C03")]
	public float scaleFactor; //Field offset: 0x12C

	[Address(RVA = "0x290D4E0", Offset = "0x290C8E0", Length = "0x72")]
	[Token(Token = "0x60013F5")]
	public AxisControl() { }

	[Address(RVA = "0x290CD60", Offset = "0x290C160", Length = "0x19B")]
	[Token(Token = "0x60013FC")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x290CF00", Offset = "0x290C300", Length = "0x85")]
	[Token(Token = "0x60013F9")]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[Address(RVA = "0x290D070", Offset = "0x290C470", Length = "0x116")]
	[Token(Token = "0x60013FA")]
	public virtual float EvaluateMagnitude(Void* statePtr) { }

	[Address(RVA = "0x290CF90", Offset = "0x290C390", Length = "0xDB")]
	[Token(Token = "0x60013FB")]
	private float EvaluateMagnitude(float value) { }

	[Address(RVA = "0x290D190", Offset = "0x290C590", Length = "0xE1")]
	[Token(Token = "0x60013F6")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x290C0F0", Offset = "0x290B4F0", Length = "0xEB")]
	[Token(Token = "0x60013F3")]
	protected float Preprocess(float value) { }

	[Address(RVA = "0x290D280", Offset = "0x290C680", Length = "0xBE")]
	[Token(Token = "0x60013F7")]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x290D340", Offset = "0x290C740", Length = "0x63")]
	[Token(Token = "0x60013F4")]
	private float Unpreprocess(float value) { }

	[Address(RVA = "0x290D3B0", Offset = "0x290C7B0", Length = "0x124")]
	[Token(Token = "0x60013F8")]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

