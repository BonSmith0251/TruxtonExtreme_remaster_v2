namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/World Document Raycaster (UI Toolkit)")]
[Token(Token = "0x2000099")]
public class WorldDocumentRaycaster : BaseRaycaster
{
	[Token(Token = "0x40002CD")]
	private static PhysicsDocumentPicker worldPicker; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40002CC")]
	private Camera m_EventCamera; //Field offset: 0x28

	[Token(Token = "0x1700019B")]
	public Camera camera
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000626")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000627")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700019A")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000625")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x34776E0", Offset = "0x3476AE0", Length = "0x73")]
	[Token(Token = "0x600062B")]
	private static WorldDocumentRaycaster() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600062A")]
	public WorldDocumentRaycaster() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000626")]
	public Camera get_camera() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000625")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x3476FF0", Offset = "0x34763F0", Length = "0x187")]
	[Token(Token = "0x6000629")]
	protected override bool GetWorldRay(PointerEventData eventData, out Ray worldRay, out float maxDistance, out int layerMask) { }

	[Address(RVA = "0x3477180", Offset = "0x3476580", Length = "0x555")]
	[Token(Token = "0x6000628")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000627")]
	public void set_camera(Camera value) { }

}

