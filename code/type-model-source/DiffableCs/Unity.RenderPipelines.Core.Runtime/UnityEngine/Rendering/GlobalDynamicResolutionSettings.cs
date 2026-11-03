namespace UnityEngine.Rendering;

[Token(Token = "0x200004E")]
public struct GlobalDynamicResolutionSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000116")]
	public bool enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000117")]
	public bool useMipBias; //Field offset: 0x1
	[FieldOffset(Offset = "0x8")]
	[Obsolete("Obsolete, use advancedUpscalerNames list instead.")]
	[Token(Token = "0x4000118")]
	public List<AdvancedUpscalers> advancedUpscalersByPriority; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000119")]
	public List<String> advancedUpscalerNames; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011A")]
	public uint DLSSPerfQualitySetting; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400011B")]
	public UpsamplerScheduleType DLSSInjectionPoint; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011C")]
	public UpsamplerScheduleType TAAUInjectionPoint; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400011D")]
	public UpsamplerScheduleType STPInjectionPoint; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011E")]
	public UpsamplerScheduleType defaultInjectionPoint; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400011F")]
	public bool DLSSUseOptimalSettings; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Range(0, 1)]
	[Token(Token = "0x4000120")]
	public float DLSSSharpness; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000121")]
	public uint DLSSRenderPresetForQuality; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000122")]
	public uint DLSSRenderPresetForBalanced; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000123")]
	public uint DLSSRenderPresetForPerformance; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000124")]
	public uint DLSSRenderPresetForUltraPerformance; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000125")]
	public uint DLSSRenderPresetForDLAA; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000126")]
	public bool FSR2EnableSharpness; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 1)]
	[Token(Token = "0x4000127")]
	public float FSR2Sharpness; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000128")]
	public bool FSR2UseOptimalSettings; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000129")]
	public uint FSR2QualitySetting; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400012A")]
	public UpsamplerScheduleType FSR2InjectionPoint; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400012B")]
	public bool fsrOverrideSharpness; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1)]
	[Token(Token = "0x400012C")]
	public float fsrSharpness; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400012D")]
	public float maxPercentage; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400012E")]
	public float minPercentage; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400012F")]
	public DynamicResolutionType dynResType; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x4000130")]
	public DynamicResUpscaleFilter upsampleFilter; //Field offset: 0x6D
	[FieldOffset(Offset = "0x6E")]
	[Token(Token = "0x4000131")]
	public bool forceResolution; //Field offset: 0x6E
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000132")]
	public float forcedPercentage; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000133")]
	public float lowResTransparencyMinimumThreshold; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000134")]
	public float rayTracingHalfResThreshold; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000135")]
	public float lowResSSGIMinimumThreshold; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000136")]
	public float lowResVolumetricCloudsMinimumThreshold; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Obsolete("Obsolete, used only for data migration. Use the advancedUpscalersByPriority list instead to add the proper supported advanced upscaler by priority. #from(2023.3)")]
	[Token(Token = "0x4000137")]
	public bool enableDLSS; //Field offset: 0x84

	[Address(RVA = "0x2BE4AA0", Offset = "0x2BE3EA0", Length = "0x1A6")]
	[Token(Token = "0x600050F")]
	public static GlobalDynamicResolutionSettings NewDefault() { }

}

