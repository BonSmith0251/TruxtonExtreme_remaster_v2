namespace UnityEngine.Rendering;

[CategoryInfo(Name = "Lighting", Order = 21)]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000010")]
public class URPReflectionProbeSettings : IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private int version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000046")]
	[Tooltip("Use ReflectionProbe rotation. Enabling this will improve the appearance of reflections when the ReflectionProbe isn't axis aligned, but may worsen performance on lower end platforms.")]
	private bool useReflectionProbeRotation; //Field offset: 0x14

	[Token(Token = "0x17000004")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000031")]
		private get { } //Length: 85
	}

	[Token(Token = "0x17000005")]
	public bool UseReflectionProbeRotation
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D661E0", Offset = "0x2D655E0", Length = "0x12")]
	[Token(Token = "0x6000033")]
	public URPReflectionProbeSettings() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000032")]
	public bool get_UseReflectionProbeRotation() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000031")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

