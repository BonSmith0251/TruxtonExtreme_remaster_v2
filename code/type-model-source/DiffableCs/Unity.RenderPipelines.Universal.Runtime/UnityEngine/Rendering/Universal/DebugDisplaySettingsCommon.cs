namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200002C")]
internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Frequently Used", order = -1)]
	[Token(Token = "0x200002D")]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{
		[CompilerGenerated]
		[Token(Token = "0x200002E")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000122")]
			public Foldout foldout; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60000FE")]
			public <>c__DisplayClass3_0() { }

			[Address(RVA = "0x2D63B30", Offset = "0x2D62F30", Length = "0xC2")]
			[Token(Token = "0x60000FF")]
			internal void <.ctor>b__0() { }

		}

		[Token(Token = "0x4000121")]
		private const string k_GoToSectionString = "Go to Section..."; //Field offset: 0x0

		[Token(Token = "0x17000072")]
		public virtual Flags Flags
		{
			[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
			[Token(Token = "0x60000FC")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2D5DF90", Offset = "0x2D5D390", Length = "0x322")]
		[Token(Token = "0x60000FD")]
		public SettingsPanel() { }

		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x60000FC")]
		public virtual Flags get_Flags() { }

	}


	[Token(Token = "0x17000071")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60000F9")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000FB")]
	public DebugDisplaySettingsCommon() { }

	[Address(RVA = "0x2D57060", Offset = "0x2D56460", Length = "0x44")]
	[Token(Token = "0x60000FA")]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000F9")]
	public override bool get_AreAnySettingsActive() { }

}

