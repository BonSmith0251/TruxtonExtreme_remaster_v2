namespace UnityEngine.Rendering;

[Token(Token = "0x200002C")]
public class ConstantBuffer
{
	[Token(Token = "0x40000B8")]
	private static List<ConstantBufferBase> m_RegisteredConstantBuffers; //Field offset: 0x0

	[Address(RVA = "0x2BBDCD0", Offset = "0x2BBD0D0", Length = "0x84")]
	[Token(Token = "0x6000464")]
	private static ConstantBuffer() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000463")]
	public ConstantBuffer() { }

	[Address(RVA = "0x7A9C50", Offset = "0x7A9050", Length = "0x96")]
	[Token(Token = "0x6000456")]
	public static void Push(in CBType data, Material mat, int shaderId) { }

	[Address(RVA = "0x7A9A00", Offset = "0x7A8E00", Length = "0xA2")]
	[Token(Token = "0x6000451")]
	public static void Push(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9AB0", Offset = "0x7A8EB0", Length = "0xFC")]
	[Token(Token = "0x6000452")]
	public static void Push(IComputeCommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9C50", Offset = "0x7A9050", Length = "0x96")]
	[Token(Token = "0x6000453")]
	public static void Push(in CBType data, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9BB0", Offset = "0x7A8FB0", Length = "0x9A")]
	[Token(Token = "0x6000454")]
	public static void Push(CommandBuffer cmd, in CBType data, Material mat, int shaderId) { }

	[Address(RVA = "0x7A9BB0", Offset = "0x7A8FB0", Length = "0x9A")]
	[Token(Token = "0x6000455")]
	public static void Push(BaseCommandBuffer cmd, in CBType data, Material mat, int shaderId) { }

	[Address(RVA = "0x7A98C0", Offset = "0x7A8CC0", Length = "0x94")]
	[Token(Token = "0x600044E")]
	public static void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId) { }

	[Address(RVA = "0x7A9790", Offset = "0x7A8B90", Length = "0x99")]
	[Token(Token = "0x600044F")]
	public static void PushGlobal(BaseCommandBuffer cmd, in CBType data, int shaderId) { }

	[Address(RVA = "0x7A9830", Offset = "0x7A8C30", Length = "0x82")]
	[Token(Token = "0x6000450")]
	public static void PushGlobal(in CBType data, int shaderId) { }

	[Address(RVA = "0x2BBDA50", Offset = "0x2BBCE50", Length = "0xC9")]
	[Token(Token = "0x6000462")]
	internal static void Register(ConstantBufferBase cb) { }

	[Address(RVA = "0x2BBDB20", Offset = "0x2BBCF20", Length = "0x1AA")]
	[Token(Token = "0x6000461")]
	public static void ReleaseAll() { }

	[Address(RVA = "0x7A9FC0", Offset = "0x7A93C0", Length = "0x7C")]
	[Token(Token = "0x600045D")]
	public static void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9FC0", Offset = "0x7A93C0", Length = "0x7C")]
	[Token(Token = "0x600045E")]
	public static void Set(IComputeCommandBuffer cmd, ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9CF0", Offset = "0x7A90F0", Length = "0x65")]
	[Token(Token = "0x600045F")]
	public static void Set(ComputeShader cs, int shaderId) { }

	[Address(RVA = "0x7A9CF0", Offset = "0x7A90F0", Length = "0x65")]
	[Token(Token = "0x6000460")]
	public static void Set(Material mat, int shaderId) { }

	[Address(RVA = "0x7A9CF0", Offset = "0x7A90F0", Length = "0x65")]
	[Token(Token = "0x600045A")]
	public static void SetGlobal(CommandBuffer cmd, int shaderId) { }

	[Address(RVA = "0x7A9CF0", Offset = "0x7A90F0", Length = "0x65")]
	[Token(Token = "0x600045B")]
	public static void SetGlobal(BaseCommandBuffer cmd, int shaderId) { }

	[Address(RVA = "0x7A9D60", Offset = "0x7A9160", Length = "0x54")]
	[Token(Token = "0x600045C")]
	public static void SetGlobal(int shaderId) { }

	[Address(RVA = "0x7AA230", Offset = "0x7A9630", Length = "0x66")]
	[Token(Token = "0x6000457")]
	public static void UpdateData(CommandBuffer cmd, in CBType data) { }

	[Address(RVA = "0x7AA230", Offset = "0x7A9630", Length = "0x66")]
	[Token(Token = "0x6000458")]
	public static void UpdateData(BaseCommandBuffer cmd, in CBType data) { }

	[Address(RVA = "0x7AA2A0", Offset = "0x7A96A0", Length = "0x56")]
	[Token(Token = "0x6000459")]
	public static void UpdateData(in CBType data) { }

}

