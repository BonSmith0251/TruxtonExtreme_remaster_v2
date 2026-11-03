namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200024D")]
public abstract class BaseFieldMouseDragger
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000FD1")]
	protected BaseFieldMouseDragger() { }

	[Token(Token = "0x6000FD0")]
	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	[Address(RVA = "0x33C63C0", Offset = "0x33C57C0", Length = "0x2F")]
	[Token(Token = "0x6000FCF")]
	public void SetDragZone(VisualElement dragElement) { }

}

