namespace UnityEngine.Rendering;

[Token(Token = "0x2000072")]
public class DebugDisplaySettingsStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Display Stats", order = -2147483648)]
	[Token(Token = "0x2000073")]
	private class StatsPanel : DebugDisplaySettingsPanel
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000171")]
		private readonly DebugDisplaySettingsStats<TProfileId> m_Data; //Field offset: 0x0

		[Token(Token = "0x17000054")]
		public virtual Flags Flags
		{
			[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
			[Token(Token = "0x60005AB")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xFCF3E0", Offset = "0xFCE7E0", Length = "0x1BB")]
		[Token(Token = "0x60005AC")]
		public StatsPanel(DebugDisplaySettingsStats<TProfileId> displaySettingsStats) { }

		[Address(RVA = "0xFCF180", Offset = "0xFCE580", Length = "0x42")]
		[Token(Token = "0x60005AD")]
		public virtual void Dispose() { }

		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x60005AB")]
		public virtual Flags get_Flags() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000170")]
	private readonly DebugDisplayStats<TProfileId> <debugDisplayStats>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000053")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60005A9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000052")]
	public DebugDisplayStats<TProfileId> debugDisplayStats
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005A7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60005A8")]
	public DebugDisplaySettingsStats`1(DebugDisplayStats<TProfileId> debugDisplayStats) { }

	[Address(RVA = "0x17CDB80", Offset = "0x17CCF80", Length = "0x6D")]
	[Token(Token = "0x60005AA")]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005A9")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005A7")]
	public DebugDisplayStats<TProfileId> get_debugDisplayStats() { }

}

