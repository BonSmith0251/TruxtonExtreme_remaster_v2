namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20000C9")]
public class Physics2DRaycaster : PhysicsRaycaster
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400036C")]
	private RaycastHit2D[] m_Hits; //Field offset: 0x48

	[Address(RVA = "0x346B090", Offset = "0x346A490", Length = "0x27")]
	[Token(Token = "0x600078C")]
	protected Physics2DRaycaster() { }

	[Address(RVA = "0x346A820", Offset = "0x3469C20", Length = "0x86F")]
	[Token(Token = "0x600078D")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

