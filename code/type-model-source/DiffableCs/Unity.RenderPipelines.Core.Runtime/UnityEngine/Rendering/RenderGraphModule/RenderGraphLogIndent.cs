namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200025D")]
internal struct RenderGraphLogIndent : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD1")]
	private int m_Indentation; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AD2")]
	private RenderGraphLogger m_Logger; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AD3")]
	private bool m_Disposed; //Field offset: 0x10

	[Address(RVA = "0x2C7B600", Offset = "0x2C7AA00", Length = "0x86")]
	[Token(Token = "0x60010E6")]
	public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1) { }

	[Address(RVA = "0x2C7B570", Offset = "0x2C7A970", Length = "0x90")]
	[Token(Token = "0x60010E7")]
	public override void Dispose() { }

	[Address(RVA = "0x2C7B4D0", Offset = "0x2C7A8D0", Length = "0x94")]
	[Token(Token = "0x60010E8")]
	private void Dispose(bool disposing) { }

}

