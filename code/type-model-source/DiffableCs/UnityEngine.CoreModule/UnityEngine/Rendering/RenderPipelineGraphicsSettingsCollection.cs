namespace UnityEngine.Rendering;

[Token(Token = "0x200038D")]
public class RenderPipelineGraphicsSettingsCollection
{
	[FieldOffset(Offset = "0x10")]
	[SerializeReference]
	[Token(Token = "0x4000AAE")]
	private List<IRenderPipelineGraphicsSettings> m_List; //Field offset: 0x10

	[Token(Token = "0x170003E7")]
	public List<IRenderPipelineGraphicsSettings> settingsList
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001CB2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x30B7030", Offset = "0x30B6430", Length = "0x77")]
	[Token(Token = "0x6001CB3")]
	public RenderPipelineGraphicsSettingsCollection() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001CB2")]
	public List<IRenderPipelineGraphicsSettings> get_settingsList() { }

}

