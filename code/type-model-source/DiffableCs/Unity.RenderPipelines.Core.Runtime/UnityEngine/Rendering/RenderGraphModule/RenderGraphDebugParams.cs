namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000258")]
internal class RenderGraphDebugParams : IDebugDisplaySettingsQuery
{
	[CompilerGenerated]
	[Token(Token = "0x200025A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AC8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AC9")]
		public static Func<Boolean> <>9__14_8; //Field offset: 0x8

		[Address(RVA = "0x2C88A80", Offset = "0x2C87E80", Length = "0x67")]
		[Token(Token = "0x60010C1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010C2")]
		public <>c() { }

		[Address(RVA = "0x2C88750", Offset = "0x2C87B50", Length = "0x43")]
		[Token(Token = "0x60010C3")]
		internal bool <GetWidgetList>b__14_8() { }

	}

	[Token(Token = "0x2000259")]
	private static class Strings
	{
		[Token(Token = "0x4000AC0")]
		public static readonly NameAndTooltip ClearRenderTargetsAtCreation; //Field offset: 0x0
		[Token(Token = "0x4000AC1")]
		public static readonly NameAndTooltip ClearRenderTargetsAtFree; //Field offset: 0x10
		[Token(Token = "0x4000AC2")]
		public static readonly NameAndTooltip DisablePassCulling; //Field offset: 0x20
		[Token(Token = "0x4000AC3")]
		public static readonly NameAndTooltip DisablePassMerging; //Field offset: 0x30
		[Token(Token = "0x4000AC4")]
		public static readonly NameAndTooltip ImmediateMode; //Field offset: 0x40
		[Token(Token = "0x4000AC5")]
		public static readonly NameAndTooltip EnableLogging; //Field offset: 0x50
		[Token(Token = "0x4000AC6")]
		public static readonly NameAndTooltip LogFrameInformation; //Field offset: 0x60
		[Token(Token = "0x4000AC7")]
		public static readonly NameAndTooltip LogResources; //Field offset: 0x70

		[Address(RVA = "0x2C88210", Offset = "0x2C87610", Length = "0x3CD")]
		[Token(Token = "0x60010C0")]
		private static Strings() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AB7")]
	private Widget[] m_DebugItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AB8")]
	private Panel m_DebugPanel; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AB9")]
	public bool clearRenderTargetsAtCreation; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000ABA")]
	public bool clearRenderTargetsAtRelease; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000ABB")]
	public bool disablePassCulling; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x4000ABC")]
	public bool disablePassMerging; //Field offset: 0x23
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000ABD")]
	public bool immediateMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000ABE")]
	public bool logFrameInformation; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x4000ABF")]
	public bool logResources; //Field offset: 0x26

	[Token(Token = "0x17000221")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2C77F10", Offset = "0x2C77310", Length = "0x2E")]
		[Token(Token = "0x60010B1")]
		 get { } //Length: 46
	}

	[Token(Token = "0x17000220")]
	public bool enableLogging
	{
		[Address(RVA = "0x2C77F40", Offset = "0x2C77340", Length = "0xD")]
		[Token(Token = "0x60010AA")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010B2")]
	public RenderGraphDebugParams() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010B3")]
	private bool <GetWidgetList>b__14_0() { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60010B4")]
	private void <GetWidgetList>b__14_1(bool value) { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60010BC")]
	private void <GetWidgetList>b__14_10(bool value) { }

	[Address(RVA = "0x2C77D70", Offset = "0x2C77170", Length = "0xE4")]
	[CompilerGenerated]
	[Token(Token = "0x60010BD")]
	private bool <GetWidgetList>b__14_11() { }

	[Address(RVA = "0x2C77E60", Offset = "0x2C77260", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010BE")]
	private void <GetWidgetList>b__14_12() { }

	[Address(RVA = "0x2226880", Offset = "0x2225C80", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010BF")]
	private void <GetWidgetList>b__14_13() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010B5")]
	private bool <GetWidgetList>b__14_2() { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60010B6")]
	private void <GetWidgetList>b__14_3(bool value) { }

	[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010B7")]
	private bool <GetWidgetList>b__14_4() { }

	[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60010B8")]
	private void <GetWidgetList>b__14_5(bool value) { }

	[Address(RVA = "0x2C77E70", Offset = "0x2C77270", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010B9")]
	private bool <GetWidgetList>b__14_6() { }

	[Address(RVA = "0x2C77E80", Offset = "0x2C77280", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60010BA")]
	private void <GetWidgetList>b__14_7(bool value) { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010BB")]
	private bool <GetWidgetList>b__14_9() { }

	[Address(RVA = "0x2C77F10", Offset = "0x2C77310", Length = "0x2E")]
	[Token(Token = "0x60010B1")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x2C77F40", Offset = "0x2C77340", Length = "0xD")]
	[Token(Token = "0x60010AA")]
	public bool get_enableLogging() { }

	[Address(RVA = "0x2C771E0", Offset = "0x2C765E0", Length = "0x8CF")]
	[Token(Token = "0x60010AD")]
	internal List<Widget> GetWidgetList(string name) { }

	[Address(RVA = "0x2C77AB0", Offset = "0x2C76EB0", Length = "0xEE")]
	[Token(Token = "0x60010AE")]
	private bool IsImmediateModeSupported() { }

	[Address(RVA = "0x2C77BA0", Offset = "0x2C76FA0", Length = "0x192")]
	[Token(Token = "0x60010AF")]
	public void RegisterDebug(string name, Panel debugPanel = null) { }

	[Address(RVA = "0x2C77D50", Offset = "0x2C77150", Length = "0x12")]
	[Token(Token = "0x60010AC")]
	internal void Reset() { }

	[Address(RVA = "0x2C77D40", Offset = "0x2C77140", Length = "0x7")]
	[Token(Token = "0x60010AB")]
	public void ResetLogging() { }

	[Address(RVA = "0x2C77E90", Offset = "0x2C77290", Length = "0x79")]
	[Token(Token = "0x60010B0")]
	public void UnRegisterDebug(string name) { }

}

