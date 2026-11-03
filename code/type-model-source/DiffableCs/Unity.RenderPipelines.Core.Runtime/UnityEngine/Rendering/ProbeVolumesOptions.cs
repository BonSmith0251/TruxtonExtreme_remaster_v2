namespace UnityEngine.Rendering;

[DisplayInfo(name = "Adaptive Probe Volumes Options")]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000141")]
[VolumeComponentMenu("Lighting/Adaptive Probe Volumes Options")]
public sealed class ProbeVolumesOptions : VolumeComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000608")]
	[Tooltip("The overridden normal bias to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
	public ClampedFloatParameter normalBias; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000609")]
	[Tooltip("A bias alongside the view vector to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
	public ClampedFloatParameter viewBias; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400060A")]
	[Tooltip("Whether to scale the bias for Adaptive Probe Volumes by the minimum distance between probes.")]
	public BoolParameter scaleBiasWithMinProbeDistance; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400060B")]
	[Tooltip("Noise to be applied to the sampling position. It can hide seams issues between subdivision levels, but introduces noise.")]
	public ClampedFloatParameter samplingNoise; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400060C")]
	[Tooltip("Whether to animate the noise when TAA is enabled. It can potentially remove the visible noise patterns.")]
	public BoolParameter animateSamplingNoise; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400060D")]
	[Tooltip("Method used to reduce leaks. Currently available modes are crude, but cheap methods.")]
	public APVLeakReductionModeParameter leakReductionMode; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Obsolete("This parameter isn't used anymore. #from(6000.0)")]
	[Token(Token = "0x400060E")]
	public ClampedFloatParameter minValidDotProductValue; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400060F")]
	[Tooltip("When enabled, reflection probe normalization can only decrease the reflection intensity.")]
	public BoolParameter occlusionOnlyReflectionNormalization; //Field offset: 0x70
	[AdditionalProperty]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000610")]
	[Tooltip("Global probe volumes weight. Allows for fading out probe volumes influence falling back to ambient probe.")]
	public ClampedFloatParameter intensityMultiplier; //Field offset: 0x78
	[AdditionalProperty]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000611")]
	[Tooltip("Multiplier applied on the sky lighting when using sky occlusion.")]
	public ClampedFloatParameter skyOcclusionIntensityMultiplier; //Field offset: 0x80
	[AdditionalProperty]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000612")]
	[Tooltip("Offset applied at runtime to probe positions in world space.\nThis is not considered while baking.")]
	public Vector3Parameter worldOffset; //Field offset: 0x88

	[Address(RVA = "0x2C31000", Offset = "0x2C30400", Length = "0x35E")]
	[Token(Token = "0x6000AC9")]
	public ProbeVolumesOptions() { }

}

