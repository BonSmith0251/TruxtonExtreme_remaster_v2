namespace UnityEngine.Rendering;

[Token(Token = "0x200001F")]
public class BaseCommandBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A8")]
	protected private CommandBuffer m_WrappedCommandBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A9")]
	internal RenderGraphPass m_ExecutingPass; //Field offset: 0x18

	[Token(Token = "0x1700002B")]
	public string name
	{
		[Address(RVA = "0x2BBA380", Offset = "0x2BB9780", Length = "0x1D")]
		[Token(Token = "0x60000DB")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700002C")]
	public int sizeInBytes
	{
		[Address(RVA = "0x2BBA3A0", Offset = "0x2BB97A0", Length = "0x1D")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x2BBA300", Offset = "0x2BB9700", Length = "0x7D")]
	[Token(Token = "0x60000DA")]
	internal BaseCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync) { }

	[Address(RVA = "0x2BBA380", Offset = "0x2BB9780", Length = "0x1D")]
	[Token(Token = "0x60000DB")]
	public string get_name() { }

	[Address(RVA = "0x2BBA3A0", Offset = "0x2BB97A0", Length = "0x1D")]
	[Token(Token = "0x60000DC")]
	public int get_sizeInBytes() { }

	[Address(RVA = "0x2BB99F0", Offset = "0x2BB8DF0", Length = "0x9F")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x60000DD")]
	protected private void ThrowIfGlobalStateNotAllowed() { }

	[Address(RVA = "0x2BB9A90", Offset = "0x2BB8E90", Length = "0x149")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x60000DE")]
	protected private void ThrowIfRasterNotAllowed() { }

	[Address(RVA = "0x2BBA0B0", Offset = "0x2BB94B0", Length = "0x24A")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x60000DF")]
	protected private void ValidateTextureHandle(in TextureHandle h) { }

	[Address(RVA = "0x2BB9BE0", Offset = "0x2BB8FE0", Length = "0x1F6")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x60000E0")]
	protected private void ValidateTextureHandleRead(in TextureHandle h) { }

	[Address(RVA = "0x2BB9DE0", Offset = "0x2BB91E0", Length = "0x2C0")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x60000E1")]
	protected private void ValidateTextureHandleWrite(in TextureHandle h) { }

}

