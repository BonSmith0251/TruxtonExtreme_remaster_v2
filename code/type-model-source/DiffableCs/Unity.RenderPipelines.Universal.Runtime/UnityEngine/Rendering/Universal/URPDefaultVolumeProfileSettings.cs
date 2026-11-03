namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "Volume", Order = 0)]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200019F")]
public class URPDefaultVolumeProfileSettings : IDefaultVolumeProfileSettings, IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x20001A0")]
	public enum Version : int
	{
		Initial = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000918")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000919")]
	private VolumeProfile m_VolumeProfile; //Field offset: 0x18

	[Token(Token = "0x1700021E")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60008F6")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700021F")]
	public override VolumeProfile volumeProfile
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008F7")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFB1A0", Offset = "0x2DFA5A0", Length = "0x65")]
		[Token(Token = "0x60008F8")]
		 set { } //Length: 101
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008F9")]
	public URPDefaultVolumeProfileSettings() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60008F6")]
	public override int get_version() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008F7")]
	public override VolumeProfile get_volumeProfile() { }

	[Address(RVA = "0x2DFB1A0", Offset = "0x2DFA5A0", Length = "0x65")]
	[Token(Token = "0x60008F8")]
	public override void set_volumeProfile(VolumeProfile value) { }

}

