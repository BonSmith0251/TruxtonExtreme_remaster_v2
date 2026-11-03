namespace UnityEngine.VFX.Utility;

[RequireComponent(typeof(Collider))]
[Token(Token = "0x200003E")]
internal class VFXMouseEventBinder : VFXEventBinderBase
{
	[Token(Token = "0x200003F")]
	internal enum Activation : int
	{
		OnMouseUp = 0,
		OnMouseDown = 1,
		OnMouseEnter = 2,
		OnMouseExit = 3,
		OnMouseOver = 4,
		OnMouseDrag = 5,
	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000148")]
	public Activation activation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000149")]
	private ExposedProperty position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400014A")]
	[Tooltip("Computes intersection in world space and sets it to the position EventAttribute")]
	public bool RaycastMousePosition; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400014B")]
	private InputAction mouseDown; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400014C")]
	private InputAction mouseUp; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400014D")]
	private InputAction mouseDragStart; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400014E")]
	private InputAction mouseDragStop; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400014F")]
	private InputAction mouseEnter; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000150")]
	private bool mouseOver; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000151")]
	private bool drag; //Field offset: 0x79

	[Address(RVA = "0x2F778D0", Offset = "0x2F76CD0", Length = "0xE8")]
	[Token(Token = "0x6000101")]
	public VFXMouseEventBinder() { }

	[Address(RVA = "0x2F777D0", Offset = "0x2F76BD0", Length = "0x71")]
	[CompilerGenerated]
	[Token(Token = "0x6000102")]
	private void <Awake>b__12_0(CallbackContext ctx) { }

	[Address(RVA = "0x2F77850", Offset = "0x2F76C50", Length = "0x71")]
	[CompilerGenerated]
	[Token(Token = "0x6000103")]
	private void <Awake>b__12_1(CallbackContext ctx) { }

	[Address(RVA = "0x2F76CB0", Offset = "0x2F760B0", Length = "0x2A6")]
	[Token(Token = "0x60000EE")]
	private void Awake() { }

	[Address(RVA = "0x2F76F60", Offset = "0x2F76360", Length = "0x50")]
	[Token(Token = "0x60000F5")]
	private void DoOnMouseDown() { }

	[Address(RVA = "0x2F76FB0", Offset = "0x2F763B0", Length = "0x50")]
	[Token(Token = "0x60000F7")]
	private void DoOnMouseDrag() { }

	[Address(RVA = "0x2F77000", Offset = "0x2F76400", Length = "0x50")]
	[Token(Token = "0x60000F9")]
	private void DoOnMouseEnter() { }

	[Address(RVA = "0x2F77050", Offset = "0x2F76450", Length = "0x50")]
	[Token(Token = "0x60000FA")]
	private void DoOnMouseExit() { }

	[Address(RVA = "0x2F770A0", Offset = "0x2F764A0", Length = "0x50")]
	[Token(Token = "0x60000F8")]
	private void DoOnMouseOver() { }

	[Address(RVA = "0x2F770F0", Offset = "0x2F764F0", Length = "0x50")]
	[Token(Token = "0x60000F6")]
	private void DoOnMouseUp() { }

	[Address(RVA = "0x2F77140", Offset = "0x2F76540", Length = "0x73")]
	[Token(Token = "0x60000F4")]
	private static Vector2 GetMousePosition() { }

	[Address(RVA = "0x2F771C0", Offset = "0x2F765C0", Length = "0x43")]
	[Token(Token = "0x60000F3")]
	private void OnDisable() { }

	[Address(RVA = "0x2F77210", Offset = "0x2F76610", Length = "0x4A")]
	[Token(Token = "0x60000F2")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F76F60", Offset = "0x2F76360", Length = "0x50")]
	[Token(Token = "0x60000FB")]
	private void OnMouseDown() { }

	[Address(RVA = "0x2F76FB0", Offset = "0x2F763B0", Length = "0x50")]
	[Token(Token = "0x60000FD")]
	private void OnMouseDrag() { }

	[Address(RVA = "0x2F77000", Offset = "0x2F76400", Length = "0x50")]
	[Token(Token = "0x60000FF")]
	private void OnMouseEnter() { }

	[Address(RVA = "0x2F77050", Offset = "0x2F76450", Length = "0x50")]
	[Token(Token = "0x6000100")]
	private void OnMouseExit() { }

	[Address(RVA = "0x2F770A0", Offset = "0x2F764A0", Length = "0x50")]
	[Token(Token = "0x60000FE")]
	private void OnMouseOver() { }

	[Address(RVA = "0x2F770F0", Offset = "0x2F764F0", Length = "0x50")]
	[Token(Token = "0x60000FC")]
	private void OnMouseUp() { }

	[Address(RVA = "0x2F77260", Offset = "0x2F76660", Length = "0x148")]
	[Token(Token = "0x60000F1")]
	private void RayCastAndTriggerEvent(Action trigger) { }

	[Address(RVA = "0x2F773B0", Offset = "0x2F767B0", Length = "0x71")]
	[Token(Token = "0x60000F0")]
	private void RayCastDrag() { }

	[Address(RVA = "0x2F77430", Offset = "0x2F76830", Length = "0x192")]
	[Token(Token = "0x60000EF")]
	private void RaycastMainCamera() { }

	[Address(RVA = "0x2F775D0", Offset = "0x2F769D0", Length = "0x1FE")]
	[Token(Token = "0x60000ED")]
	protected virtual void SetEventAttribute(Object[] parameters) { }

}

