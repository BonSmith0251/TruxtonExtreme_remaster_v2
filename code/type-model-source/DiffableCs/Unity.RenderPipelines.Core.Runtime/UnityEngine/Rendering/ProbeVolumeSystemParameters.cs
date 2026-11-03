namespace UnityEngine.Rendering;

[Token(Token = "0x2000118")]
public struct ProbeVolumeSystemParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004DE")]
	public ProbeVolumeTextureMemoryBudget memoryBudget; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004DF")]
	public ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004E0")]
	public ProbeVolumeSHBands shBands; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004E1")]
	public bool supportScenarios; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40004E2")]
	public bool supportScenarioBlending; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40004E3")]
	public bool supportGPUStreaming; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x40004E4")]
	public bool supportDiskStreaming; //Field offset: 0xF
	[FieldOffset(Offset = "0x10")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004E5")]
	public Shader probeDebugShader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004E6")]
	public Shader probeSamplingDebugShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004E7")]
	public Texture probeSamplingDebugTexture; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004E8")]
	public Mesh probeSamplingDebugMesh; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004E9")]
	public Shader offsetDebugShader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004EA")]
	public Shader fragmentationDebugShader; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004EB")]
	public ComputeShader scenarioBlendingShader; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004EC")]
	public ComputeShader streamingUploadShader; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Obsolete("This field is not used anymore. #from(2023.3)")]
	[Token(Token = "0x40004ED")]
	public ProbeVolumeSceneData sceneData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Obsolete("This field is not used anymore. Used with the current Shader Stripping Settings. #from(2023.3)")]
	[Token(Token = "0x40004EE")]
	public bool supportsRuntimeDebug; //Field offset: 0x58

}

