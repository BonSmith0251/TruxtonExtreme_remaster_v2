namespace UnityEngine.UIElements;

[Token(Token = "0x2000283")]
internal class MainCameraScreenRaycaster : CameraScreenRaycaster
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009F4")]
	private Camera[] singleCameraArray; //Field offset: 0x28

	[Address(RVA = "0x33EDD80", Offset = "0x33ED180", Length = "0x5F")]
	[Token(Token = "0x6001198")]
	public MainCameraScreenRaycaster() { }

	[Address(RVA = "0x33EDCA0", Offset = "0x33ED0A0", Length = "0xCE")]
	[Token(Token = "0x600119A")]
	private void ResolveCamera() { }

	[Address(RVA = "0x33EDD70", Offset = "0x33ED170", Length = "0x7")]
	[Token(Token = "0x6001199")]
	public virtual void Update() { }

}

