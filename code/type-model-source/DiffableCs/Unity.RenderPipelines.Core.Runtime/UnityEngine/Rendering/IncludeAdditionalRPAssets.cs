namespace UnityEngine.Rendering;

[CategoryInfo(Name = "H: RP Assets Inclusion", Order = 990)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000169")]
public class IncludeAdditionalRPAssets : IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x200016A")]
	private enum Version : int
	{
		Initial = 0,
		Count = 1,
		Last = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006E6")]
	private Version m_version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40006E7")]
	private bool m_IncludeReferencedInScenes; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	[Token(Token = "0x40006E8")]
	private bool m_IncludeAssetsByLabel; //Field offset: 0x15
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40006E9")]
	private string m_LabelToInclude; //Field offset: 0x18

	[Token(Token = "0x1700015B")]
	public bool includeAssetsByLabel
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x6000B6A")]
		 get { } //Length: 5
		[Address(RVA = "0x2C249D0", Offset = "0x2C23DD0", Length = "0x66")]
		[Token(Token = "0x6000B6B")]
		 set { } //Length: 102
	}

	[Token(Token = "0x1700015A")]
	public bool includeReferencedInScenes
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000B68")]
		 get { } //Length: 5
		[Address(RVA = "0x2C24A40", Offset = "0x2C23E40", Length = "0x66")]
		[Token(Token = "0x6000B69")]
		 set { } //Length: 102
	}

	[Token(Token = "0x1700015C")]
	public string labelToInclude
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B6C")]
		 get { } //Length: 5
		[Address(RVA = "0x2C24AB0", Offset = "0x2C23EB0", Length = "0x65")]
		[Token(Token = "0x6000B6D")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000159")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B67")]
		private get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B6E")]
	public IncludeAdditionalRPAssets() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x6000B6A")]
	public bool get_includeAssetsByLabel() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000B68")]
	public bool get_includeReferencedInScenes() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B6C")]
	public string get_labelToInclude() { }

	[Address(RVA = "0x2C249D0", Offset = "0x2C23DD0", Length = "0x66")]
	[Token(Token = "0x6000B6B")]
	public void set_includeAssetsByLabel(bool value) { }

	[Address(RVA = "0x2C24A40", Offset = "0x2C23E40", Length = "0x66")]
	[Token(Token = "0x6000B69")]
	public void set_includeReferencedInScenes(bool value) { }

	[Address(RVA = "0x2C24AB0", Offset = "0x2C23EB0", Length = "0x65")]
	[Token(Token = "0x6000B6D")]
	public void set_labelToInclude(string value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B67")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

