namespace UnityEngine.Rendering;

[Obsolete("VolumeComponentMenuForRenderPipelineAttribute is deprecated. Use VolumeComponentMenu with SupportedOnRenderPipeline instead. #from(2023.1)")]
[Token(Token = "0x20001F4")]
public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000974")]
	private readonly Type[] <pipelineTypes>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001E6")]
	public Type[] pipelineTypes
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000EDC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C69190", Offset = "0x2C68590", Length = "0x1CE")]
	[Token(Token = "0x6000EDD")]
	public VolumeComponentMenuForRenderPipeline(string menu, Type[] pipelineTypes) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000EDC")]
	public Type[] get_pipelineTypes() { }

}

