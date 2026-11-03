namespace UnityEngine.Rendering;

[Obsolete("Use GraphicsSettings.GetRenderPipelineSettings<ShaderStrippingSetting>(). #from(2023.3)")]
[Token(Token = "0x20000E3")]
public interface IShaderVariantSettings
{

	[Token(Token = "0x170000DB")]
	public bool exportShaderVariants
	{
		[Token(Token = "0x600080C")]
		 get { } //Length: 0
		[Token(Token = "0x600080D")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000DA")]
	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		[Token(Token = "0x600080A")]
		 get { } //Length: 0
		[Token(Token = "0x600080B")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000DC")]
	public bool stripDebugVariants
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600080E")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600080F")]
		 set { } //Length: 3
	}

	[Token(Token = "0x600080C")]
	public bool get_exportShaderVariants() { }

	[Token(Token = "0x600080A")]
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600080E")]
	public bool get_stripDebugVariants() { }

	[Token(Token = "0x600080D")]
	public void set_exportShaderVariants(bool value) { }

	[Token(Token = "0x600080B")]
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600080F")]
	public void set_stripDebugVariants(bool value) { }

}

