namespace UnityEngine.UIElements;

[Token(Token = "0x200027D")]
internal class RuntimePanel : BaseRuntimePanel, IRuntimePanel, IPanel, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200027E")]
	private sealed class <>c
	{
		[Token(Token = "0x40009E5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009E6")]
		public static EventCallback<FocusEvent, RuntimePanel> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x33F4530", Offset = "0x33F3930", Length = "0x67")]
		[Token(Token = "0x6001182")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001183")]
		public <>c() { }

		[Address(RVA = "0x33F43E0", Offset = "0x33F37E0", Length = "0x9C")]
		[Token(Token = "0x6001184")]
		internal void <.ctor>b__8_0(FocusEvent e, RuntimePanel p) { }

	}

	[Token(Token = "0x40009E2")]
	internal static readonly EventDispatcher s_EventDispatcher; //Field offset: 0x0
	[Token(Token = "0x40009E4")]
	private static readonly List<UIDocument> s_EmptyDocumentList; //Field offset: 0x8
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40009E3")]
	private readonly PanelSettings m_PanelSettings; //Field offset: 0x220

	[Token(Token = "0x1700035F")]
	public override PanelSettings panelSettings
	{
		[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
		[Token(Token = "0x600117C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x33F2A00", Offset = "0x33F1E00", Length = "0xE8")]
	[Token(Token = "0x6001181")]
	private static RuntimePanel() { }

	[Address(RVA = "0x33F2AF0", Offset = "0x33F1EF0", Length = "0x427")]
	[Token(Token = "0x600117E")]
	private RuntimePanel(ScriptableObject ownerObject) { }

	[Address(RVA = "0x33F2870", Offset = "0x33F1C70", Length = "0x54")]
	[Token(Token = "0x600117D")]
	public static RuntimePanel Create(ScriptableObject ownerObject) { }

	[Address(RVA = "0x28EA8F0", Offset = "0x28E9CF0", Length = "0x8")]
	[Token(Token = "0x600117C")]
	public override PanelSettings get_panelSettings() { }

	[Address(RVA = "0x33F28D0", Offset = "0x33F1CD0", Length = "0x93")]
	[Token(Token = "0x6001180")]
	private void OnElementFocus(FocusEvent evt) { }

	[Address(RVA = "0x33F2970", Offset = "0x33F1D70", Length = "0x82")]
	[Token(Token = "0x600117F")]
	internal virtual void Update() { }

}

