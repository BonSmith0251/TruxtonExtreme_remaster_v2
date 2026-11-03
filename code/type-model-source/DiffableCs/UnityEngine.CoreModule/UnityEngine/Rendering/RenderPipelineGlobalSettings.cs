namespace UnityEngine.Rendering;

[Token(Token = "0x20003E8")]
public abstract class RenderPipelineGlobalSettings : ScriptableObject, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CCD")]
	private readonly Dictionary<Type, Int32> <settingsMap>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700045A")]
	protected override List<IRenderPipelineGraphicsSettings> settingsList
	{
		[Address(RVA = "0x30C3B50", Offset = "0x30C2F50", Length = "0x25F")]
		[Token(Token = "0x6001E0A")]
		 get { } //Length: 607
	}

	[Token(Token = "0x1700045B")]
	private Dictionary<Type, Int32> settingsMap
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001E0B")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x30C3AD0", Offset = "0x30C2ED0", Length = "0x77")]
	[Token(Token = "0x6001E13")]
	protected RenderPipelineGlobalSettings() { }

	[Address(RVA = "0x30C3800", Offset = "0x30C2C00", Length = "0x7A")]
	[Token(Token = "0x6001E10")]
	protected private bool Contains(Type type) { }

	[Address(RVA = "0x30C3B50", Offset = "0x30C2F50", Length = "0x25F")]
	[Token(Token = "0x6001E0A")]
	protected override List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001E0B")]
	private Dictionary<Type, Int32> get_settingsMap() { }

	[Address(RVA = "0x8E8050", Offset = "0x8E7450", Length = "0x1A1")]
	[Token(Token = "0x6001E0F")]
	protected private bool GetSettingsImplementingInterface(out List<TSettingsInterfaceType>& settings) { }

	[Address(RVA = "0x30C3880", Offset = "0x30C2C80", Length = "0x142")]
	[Token(Token = "0x6001E12")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001E11")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x30C3880", Offset = "0x30C2C80", Length = "0x142")]
	[Token(Token = "0x6001E0C")]
	private void RecreateSettingsMap() { }

	[Address(RVA = "0x30C39D0", Offset = "0x30C2DD0", Length = "0xF9")]
	[Token(Token = "0x6001E0D")]
	protected private bool TryGet(Type type, out IRenderPipelineGraphicsSettings settings) { }

	[Address(RVA = "0x8E8200", Offset = "0x8E7600", Length = "0x151")]
	[Token(Token = "0x6001E0E")]
	protected private bool TryGetFirstSettingsImplementingInterface(out TSettingsInterfaceType settings) { }

}

