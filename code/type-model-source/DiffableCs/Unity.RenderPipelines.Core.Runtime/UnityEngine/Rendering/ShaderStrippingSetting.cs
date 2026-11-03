namespace UnityEngine.Rendering;

[CategoryInfo(Name = "Additional Shader Stripping Settings", Order = 40)]
[ElementInfo(Order = 0)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200016F")]
public class ShaderStrippingSetting : IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x2000170")]
	public enum Version : int
	{
		Initial = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006F9")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40006FA")]
	[Tooltip("Controls whether to output shader variant information to a file.")]
	private bool m_ExportShaderVariants; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40006FB")]
	[Tooltip("Controls the level of logging of shader variant information outputted during the build process. Information appears in the Unity Console when the build finishes.")]
	private ShaderVariantLogLevel m_ShaderVariantLogLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40006FC")]
	[Tooltip("When enabled, all debug display shader variants are removed when you build for the Unity Player. This decreases build time, but prevents the use of most Rendering Debugger features in Player builds.")]
	private bool m_StripRuntimeDebugShaders; //Field offset: 0x1C

	[Token(Token = "0x17000163")]
	public bool exportShaderVariants
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000B78")]
		 get { } //Length: 5
		[Address(RVA = "0x2C36F00", Offset = "0x2C36300", Length = "0x66")]
		[Token(Token = "0x6000B79")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000164")]
	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000B7A")]
		 get { } //Length: 4
		[Address(RVA = "0x2C36F70", Offset = "0x2C36370", Length = "0x64")]
		[Token(Token = "0x6000B7B")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000165")]
	public bool stripRuntimeDebugShaders
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x6000B7C")]
		 get { } //Length: 5
		[Address(RVA = "0x2C36FE0", Offset = "0x2C363E0", Length = "0x66")]
		[Token(Token = "0x6000B7D")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000162")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B77")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000161")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B76")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x2C36EF0", Offset = "0x2C362F0", Length = "0xF")]
	[Token(Token = "0x6000B7E")]
	public ShaderStrippingSetting() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000B78")]
	public bool get_exportShaderVariants() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000B7A")]
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x6000B7C")]
	public bool get_stripRuntimeDebugShaders() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B76")]
	public override int get_version() { }

	[Address(RVA = "0x2C36F00", Offset = "0x2C36300", Length = "0x66")]
	[Token(Token = "0x6000B79")]
	public void set_exportShaderVariants(bool value) { }

	[Address(RVA = "0x2C36F70", Offset = "0x2C36370", Length = "0x64")]
	[Token(Token = "0x6000B7B")]
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	[Address(RVA = "0x2C36FE0", Offset = "0x2C363E0", Length = "0x66")]
	[Token(Token = "0x6000B7D")]
	public void set_stripRuntimeDebugShaders(bool value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000B77")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

