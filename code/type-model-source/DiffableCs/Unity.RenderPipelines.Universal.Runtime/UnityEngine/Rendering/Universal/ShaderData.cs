namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001A4")]
internal class ShaderData : IDisposable
{
	[Token(Token = "0x4000926")]
	private static ShaderData m_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000927")]
	private ComputeBuffer m_LightDataBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000928")]
	private ComputeBuffer m_LightIndicesBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000929")]
	private ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400092A")]
	private ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer; //Field offset: 0x28

	[Token(Token = "0x17000228")]
	internal static ShaderData instance
	{
		[Address(RVA = "0x2DEB8F0", Offset = "0x2DEACF0", Length = "0x8D")]
		[Token(Token = "0x600090C")]
		internal get { } //Length: 141
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600090B")]
	private ShaderData() { }

	[Address(RVA = "0x2DEB700", Offset = "0x2DEAB00", Length = "0xA4")]
	[Token(Token = "0x600090D")]
	public override void Dispose() { }

	[Address(RVA = "0x2DEB6C0", Offset = "0x2DEAAC0", Length = "0x35")]
	[Token(Token = "0x6000913")]
	private void DisposeBuffer(ref ComputeBuffer buffer) { }

	[Address(RVA = "0x2DEB8F0", Offset = "0x2DEACF0", Length = "0x8D")]
	[Token(Token = "0x600090C")]
	internal static ShaderData get_instance() { }

	[Address(RVA = "0x2DEB7B0", Offset = "0x2DEABB0", Length = "0x4B")]
	[Token(Token = "0x6000910")]
	internal ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size) { }

	[Address(RVA = "0x2DEB800", Offset = "0x2DEAC00", Length = "0x4B")]
	[Token(Token = "0x6000911")]
	internal ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size) { }

	[Address(RVA = "0x2DEB850", Offset = "0x2DEAC50", Length = "0x4B")]
	[Token(Token = "0x600090E")]
	internal ComputeBuffer GetLightDataBuffer(int size) { }

	[Address(RVA = "0x2DEB8A0", Offset = "0x2DEACA0", Length = "0x4B")]
	[Token(Token = "0x600090F")]
	internal ComputeBuffer GetLightIndicesBuffer(int size) { }

	[Address(RVA = "0x8F1550", Offset = "0x8F0950", Length = "0xDB")]
	[Token(Token = "0x6000912")]
	private ComputeBuffer GetOrUpdateBuffer(ref ComputeBuffer buffer, int size) { }

}

