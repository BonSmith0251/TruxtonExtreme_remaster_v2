namespace UnityEngine.Rendering;

[Token(Token = "0x200002E")]
public class ConstantBuffer : ConstantBufferBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	private HashSet<Int32> m_GlobalBindings; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BA")]
	private CBType[] m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	private ComputeBuffer m_GPUConstantBuffer; //Field offset: 0x0

	[Address(RVA = "0x17C6100", Offset = "0x17C5500", Length = "0x10E")]
	[Token(Token = "0x6000467")]
	public ConstantBuffer`1() { }

	[Address(RVA = "0x17C2A00", Offset = "0x17C1E00", Length = "0x67")]
	[Token(Token = "0x6000473")]
	public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId) { }

	[Address(RVA = "0x17C2860", Offset = "0x17C1C60", Length = "0x94")]
	[Token(Token = "0x6000474")]
	public void PushGlobal(BaseCommandBuffer cmd, in CBType data, int shaderId) { }

	[Address(RVA = "0x17C1E00", Offset = "0x17C1200", Length = "0x11C")]
	[Token(Token = "0x6000475")]
	public void PushGlobal(in CBType data, int shaderId) { }

	[Address(RVA = "0x17C3040", Offset = "0x17C2440", Length = "0x179")]
	[Token(Token = "0x6000476")]
	public virtual void Release() { }

	[Address(RVA = "0x17C45E0", Offset = "0x17C39E0", Length = "0x6F")]
	[Token(Token = "0x600046E")]
	public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x17C4650", Offset = "0x17C3A50", Length = "0xA6")]
	[Token(Token = "0x600046F")]
	public void Set(IComputeCommandBuffer cmd, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x17C44C0", Offset = "0x17C38C0", Length = "0x5F")]
	[Token(Token = "0x6000470")]
	public void Set(ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x17C4580", Offset = "0x17C3980", Length = "0x5F")]
	[Token(Token = "0x6000471")]
	public void Set(Material mat, int shaderId) { }

	[Address(RVA = "0x17C4520", Offset = "0x17C3920", Length = "0x5F")]
	[Token(Token = "0x6000472")]
	public void Set(MaterialPropertyBlock mpb, int shaderId) { }

	[Address(RVA = "0x17C4330", Offset = "0x17C3730", Length = "0xA0")]
	[Token(Token = "0x600046B")]
	public void SetGlobal(CommandBuffer cmd, int shaderId) { }

	[Address(RVA = "0x17C3D50", Offset = "0x17C3150", Length = "0x2A")]
	[Token(Token = "0x600046C")]
	public void SetGlobal(BaseCommandBuffer cmd, int shaderId) { }

	[Address(RVA = "0x17C3E10", Offset = "0x17C3210", Length = "0x88")]
	[Token(Token = "0x600046D")]
	public void SetGlobal(int shaderId) { }

	[Address(RVA = "0x17C5460", Offset = "0x17C4860", Length = "0xB0")]
	[Token(Token = "0x6000468")]
	public void UpdateData(CommandBuffer cmd, in CBType data) { }

	[Address(RVA = "0x17C5210", Offset = "0x17C4610", Length = "0x2A")]
	[Token(Token = "0x6000469")]
	public void UpdateData(BaseCommandBuffer cmd, in CBType data) { }

	[Address(RVA = "0x17C50D0", Offset = "0x17C44D0", Length = "0xA3")]
	[Token(Token = "0x600046A")]
	public void UpdateData(in CBType data) { }

}

