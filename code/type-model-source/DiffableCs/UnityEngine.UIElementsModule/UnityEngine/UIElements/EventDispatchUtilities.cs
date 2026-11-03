namespace UnityEngine.UIElements;

[Token(Token = "0x20001D5")]
internal static class EventDispatchUtilities
{

	[Address(RVA = "0x33C9CB0", Offset = "0x33C90B0", Length = "0x44")]
	[Token(Token = "0x6000D49")]
	public static void DefaultDispatch(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33CB150", Offset = "0x33CA550", Length = "0x34")]
	[Token(Token = "0x6000D45")]
	private static bool Disabled(EventBase evt, VisualElement target) { }

	[Address(RVA = "0x33CB190", Offset = "0x33CA590", Length = "0xA9")]
	[Token(Token = "0x6000D48")]
	public static void DispatchToAssignedTarget(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33CB2A0", Offset = "0x33CA6A0", Length = "0x1AA")]
	[Token(Token = "0x6000D4B")]
	private static bool DispatchToCapturingElement(EventBase evt, BaseVisualElementPanel panel, int pointerId) { }

	[Address(RVA = "0x33CB240", Offset = "0x33CA640", Length = "0x5F")]
	[Token(Token = "0x6000D4A")]
	public static void DispatchToCapturingElementOrElementUnderPointer(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[Address(RVA = "0x33CB450", Offset = "0x33CA850", Length = "0x11C")]
	[Token(Token = "0x6000D47")]
	public static void DispatchToElementUnderPointerOrPanelRoot(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[Address(RVA = "0x33CB570", Offset = "0x33CA970", Length = "0x264")]
	[Token(Token = "0x6000D46")]
	public static void DispatchToFocusedElementOrPanelRoot(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33CB7E0", Offset = "0x33CABE0", Length = "0x77")]
	[Token(Token = "0x6000D4C")]
	internal static void DispatchToPanelRoot(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33C59D0", Offset = "0x33C4DD0", Length = "0x799")]
	[Token(Token = "0x6000D44")]
	private static void HandleEvent_BubbleUpAllDefaultActions(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled, bool isCapturingTarget) { }

	[Address(RVA = "0x33CD100", Offset = "0x33CC500", Length = "0x3A")]
	[Token(Token = "0x6000D41")]
	private static void HandleEvent_BubbleUpCallbacks(EventBase evt, BaseVisualElementPanel panel, VisualElement element) { }

	[Address(RVA = "0x33CD140", Offset = "0x33CC540", Length = "0x57")]
	[Token(Token = "0x6000D43")]
	private static void HandleEvent_BubbleUpHandleEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[Address(RVA = "0x33CD270", Offset = "0x33CC670", Length = "0xC3")]
	[Token(Token = "0x6000D3F")]
	private static void HandleEvent_DefaultAction(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[Address(RVA = "0x33CD1A0", Offset = "0x33CC5A0", Length = "0xC3")]
	[Token(Token = "0x6000D3E")]
	private static void HandleEvent_DefaultActionAtTarget(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[Address(RVA = "0x33CD340", Offset = "0x33CC740", Length = "0x3A")]
	[Token(Token = "0x6000D40")]
	private static void HandleEvent_TrickleDownCallbacks(EventBase evt, BaseVisualElementPanel panel, VisualElement element) { }

	[Address(RVA = "0x33CD380", Offset = "0x33CC780", Length = "0x57")]
	[Token(Token = "0x6000D42")]
	private static void HandleEvent_TrickleDownHandleEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[Address(RVA = "0x33CC4F0", Offset = "0x33CB8F0", Length = "0x7BA")]
	[Token(Token = "0x6000D3C")]
	private static void HandleEventAcrossPropagationPath(EventBase evt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[Address(RVA = "0x33CB860", Offset = "0x33CAC60", Length = "0xC8E")]
	[Token(Token = "0x6000D3D")]
	private static void HandleEventAcrossPropagationPathWithCompatibilityEvent(EventBase evt, EventBase compatibilityEvt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[Address(RVA = "0x33CCCB0", Offset = "0x33CC0B0", Length = "0x441")]
	[Token(Token = "0x6000D3B")]
	public static void HandleEventAtTargetAndDefaultPhase(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

	[Address(RVA = "0x33CD3E0", Offset = "0x33CC7E0", Length = "0x104")]
	[Token(Token = "0x6000D39")]
	private static void PropagateEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[Address(RVA = "0x33CD4F0", Offset = "0x33CC8F0", Length = "0x3D3")]
	[Token(Token = "0x6000D4E")]
	private static void PropagateToRemainingIMGUIContainerRecursive(EventBase evt, VisualElement root) { }

	[Address(RVA = "0x33CD8D0", Offset = "0x33CCCD0", Length = "0x68")]
	[Token(Token = "0x6000D4D")]
	internal static void PropagateToRemainingIMGUIContainers(EventBase evt, VisualElement root) { }

	[Address(RVA = "0x33CD940", Offset = "0x33CCD40", Length = "0x65")]
	[Token(Token = "0x6000D3A")]
	public static void SendEventDirectlyToTarget(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

}

