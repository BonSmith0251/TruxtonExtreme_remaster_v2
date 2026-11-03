namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x200028C")]
internal static class GroupBoxUtility
{
	[Token(Token = "0x4000A2A")]
	private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; //Field offset: 0x0
	[Token(Token = "0x4000A2B")]
	private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; //Field offset: 0x8
	[Token(Token = "0x4000A2C")]
	private static readonly Type k_GenericGroupBoxType; //Field offset: 0x10

	[Address(RVA = "0x33FF2C0", Offset = "0x33FE6C0", Length = "0x144")]
	[Token(Token = "0x60011F4")]
	private static GroupBoxUtility() { }

	[Address(RVA = "0x33FEB50", Offset = "0x33FDF50", Length = "0x533")]
	[Token(Token = "0x60011F1")]
	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	[Address(RVA = "0x33FF090", Offset = "0x33FE490", Length = "0xBD")]
	[Token(Token = "0x60011F2")]
	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x814F60", Offset = "0x814360", Length = "0xF5")]
	[Extension]
	[Token(Token = "0x60011F0")]
	public static void OnOptionSelected(T selectedOption) { }

	[Address(RVA = "0x33FF150", Offset = "0x33FE550", Length = "0x169")]
	[Token(Token = "0x60011F3")]
	private static void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x815060", Offset = "0x814460", Length = "0x143")]
	[Extension]
	[Token(Token = "0x60011EE")]
	public static void RegisterGroupBoxOption(T option) { }

	[Address(RVA = "0x8151B0", Offset = "0x8145B0", Length = "0x12F")]
	[Extension]
	[Token(Token = "0x60011EF")]
	public static void UnregisterGroupBoxOption(T option) { }

}

