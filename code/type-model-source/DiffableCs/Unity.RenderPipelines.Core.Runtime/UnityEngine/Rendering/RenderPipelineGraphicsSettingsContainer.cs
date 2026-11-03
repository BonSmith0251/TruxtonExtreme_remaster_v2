namespace UnityEngine.Rendering;

[Token(Token = "0x2000165")]
public class RenderPipelineGraphicsSettingsContainer : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006E5")]
	private RenderPipelineGraphicsSettingsCollection m_RuntimeSettings; //Field offset: 0x10

	[Token(Token = "0x17000153")]
	public List<IRenderPipelineGraphicsSettings> settingsList
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x6000B5B")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2C31450", Offset = "0x2C30850", Length = "0x66")]
	[Token(Token = "0x6000B5E")]
	public RenderPipelineGraphicsSettingsContainer() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x6000B5B")]
	public List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B5D")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B5C")]
	public override void OnBeforeSerialize() { }

}

