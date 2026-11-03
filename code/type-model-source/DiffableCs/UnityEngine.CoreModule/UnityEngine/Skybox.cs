namespace UnityEngine;

[NativeHeader("Runtime/Camera/Skybox.h")]
[Token(Token = "0x20000FA")]
public sealed class Skybox : Behaviour
{

	[Token(Token = "0x170001C6")]
	public Material material
	{
		[Address(RVA = "0x303B590", Offset = "0x303A990", Length = "0x90")]
		[Token(Token = "0x6000AE0")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x303B590", Offset = "0x303A990", Length = "0x90")]
	[Token(Token = "0x6000AE0")]
	public Material get_material() { }

	[Address(RVA = "0x303B550", Offset = "0x303A950", Length = "0x33")]
	[Token(Token = "0x6000AE1")]
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

}

