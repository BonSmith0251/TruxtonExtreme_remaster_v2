namespace UnityEngine.UIElements;

[Token(Token = "0x20002B6")]
internal sealed class HierarchyEvent : MulticastDelegate
{

	[Address(RVA = "0x26B3DA0", Offset = "0x26B31A0", Length = "0x125")]
	[Token(Token = "0x6001283")]
	public HierarchyEvent(object object, IntPtr method) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6001284")]
	public override void Invoke(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

}

