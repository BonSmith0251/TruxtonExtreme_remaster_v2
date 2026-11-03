namespace UnityEngine.Rendering;

[Token(Token = "0x2000074")]
public class DebugDisplaySettingsUI : IDebugData
{
	[CompilerGenerated]
	[Token(Token = "0x2000075")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000174")]
		public DebugManager debugManager; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000175")]
		public List<IDebugDisplaySettingsPanelDisposable> panels; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005B3")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x2BEB250", Offset = "0x2BEA650", Length = "0x256")]
		[Token(Token = "0x60005B4")]
		internal void <RegisterDebug>b__0(IDebugDisplaySettingsData data) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000172")]
	private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000173")]
	private IDebugDisplaySettings m_Settings; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60005B2")]
	public DebugDisplaySettingsUI() { }

	[Address(RVA = "0x2BD5EA0", Offset = "0x2BD52A0", Length = "0x67")]
	[Token(Token = "0x60005B1")]
	public override Action GetReset() { }

	[Address(RVA = "0x2BD5F10", Offset = "0x2BD5310", Length = "0x365")]
	[Token(Token = "0x60005AF")]
	public void RegisterDebug(IDebugDisplaySettings settings) { }

	[Address(RVA = "0x2BD6280", Offset = "0x2BD5680", Length = "0x93")]
	[Token(Token = "0x60005AE")]
	private void Reset() { }

	[Address(RVA = "0x2BD6320", Offset = "0x2BD5720", Length = "0x4B9")]
	[Token(Token = "0x60005B0")]
	public void UnregisterDebug() { }

}

