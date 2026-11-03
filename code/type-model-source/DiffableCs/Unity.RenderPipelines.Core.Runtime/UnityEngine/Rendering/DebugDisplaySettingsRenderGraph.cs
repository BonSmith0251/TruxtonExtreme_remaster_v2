namespace UnityEngine.Rendering;

[Token(Token = "0x200015D")]
internal class DebugDisplaySettingsRenderGraph : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Rendering", order = 10)]
	[Token(Token = "0x200015E")]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{

		[Address(RVA = "0x2C36670", Offset = "0x2C35A70", Length = "0x3EE")]
		[Token(Token = "0x6000B4A")]
		public SettingsPanel(DebugDisplaySettingsRenderGraph _) { }

	}


	[Token(Token = "0x1700014D")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2C236B0", Offset = "0x2C22AB0", Length = "0x1EA")]
		[Token(Token = "0x6000B49")]
		 get { } //Length: 490
	}

	[Address(RVA = "0x2C23560", Offset = "0x2C22960", Length = "0x14A")]
	[Token(Token = "0x6000B47")]
	public DebugDisplaySettingsRenderGraph() { }

	[Address(RVA = "0x2C236B0", Offset = "0x2C22AB0", Length = "0x1EA")]
	[Token(Token = "0x6000B49")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x2C23500", Offset = "0x2C22900", Length = "0x54")]
	[Token(Token = "0x6000B48")]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

