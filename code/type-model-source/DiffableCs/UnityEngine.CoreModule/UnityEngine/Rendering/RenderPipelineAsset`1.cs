namespace UnityEngine.Rendering;

[Token(Token = "0x20003E7")]
public abstract class RenderPipelineAsset : RenderPipelineAsset
{

	[Token(Token = "0x17000457")]
	public virtual Type pipelineType
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x6001E06")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000458")]
	public virtual string renderPipelineShaderTag
	{
		[Address(RVA = "0xF52590", Offset = "0xF51990", Length = "0x59")]
		[Token(Token = "0x6001E07")]
		 get { } //Length: 89
	}

	[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", False)]
	[Token(Token = "0x17000459")]
	protected private virtual Type renderPipelineType
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x6001E08")]
		private get { } //Length: 56
	}

	[Address(RVA = "0xF52580", Offset = "0xF51980", Length = "0x7")]
	[Token(Token = "0x6001E09")]
	protected RenderPipelineAsset`1() { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x6001E06")]
	public virtual Type get_pipelineType() { }

	[Address(RVA = "0xF52590", Offset = "0xF51990", Length = "0x59")]
	[Token(Token = "0x6001E07")]
	public virtual string get_renderPipelineShaderTag() { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x6001E08")]
	protected private virtual Type get_renderPipelineType() { }

}

