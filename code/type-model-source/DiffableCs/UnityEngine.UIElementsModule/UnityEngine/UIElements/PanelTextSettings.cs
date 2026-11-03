namespace UnityEngine.UIElements;

[HelpURL("UIE-text-setting-asset")]
[Token(Token = "0x20004A7")]
public class PanelTextSettings : TextSettings
{
	[Token(Token = "0x4000F7F")]
	private static PanelTextSettings s_DefaultPanelTextSettings; //Field offset: 0x0

	[Token(Token = "0x17000939")]
	internal static PanelTextSettings defaultPanelTextSettings
	{
		[Address(RVA = "0x32A1B60", Offset = "0x32A0F60", Length = "0x3D")]
		[Token(Token = "0x60022E0")]
		internal get { } //Length: 61
	}

	[Address(RVA = "0x30F7050", Offset = "0x30F6450", Length = "0x7")]
	[Token(Token = "0x60022E2")]
	public PanelTextSettings() { }

	[Address(RVA = "0x32A1B60", Offset = "0x32A0F60", Length = "0x3D")]
	[Token(Token = "0x60022E0")]
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	[Address(RVA = "0x32A1AB0", Offset = "0x32A0EB0", Length = "0xAF")]
	[Token(Token = "0x60022E1")]
	internal static void InitializeDefaultPanelTextSettingsIfNull() { }

}

