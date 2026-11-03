namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[Token(Token = "0x2000009")]
internal class CameraRaycastHelper
{

	[Address(RVA = "0x31105F0", Offset = "0x310F9F0", Length = "0xB5")]
	[FreeFunction("CameraScripting::RaycastTry")]
	[Token(Token = "0x6000012")]
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x3110580", Offset = "0x310F980", Length = "0x62")]
	[Token(Token = "0x6000014")]
	private static IntPtr RaycastTry_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x31104C0", Offset = "0x310F8C0", Length = "0xB5")]
	[FreeFunction("CameraScripting::RaycastTry2D")]
	[Token(Token = "0x6000013")]
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x3110450", Offset = "0x310F850", Length = "0x62")]
	[Token(Token = "0x6000015")]
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

}

