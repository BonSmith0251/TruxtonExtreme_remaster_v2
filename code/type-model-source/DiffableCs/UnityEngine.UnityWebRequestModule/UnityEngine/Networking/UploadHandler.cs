namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
[Token(Token = "0x2000011")]
public class UploadHandler
{
	[Token(Token = "0x2000012")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600008D")]
		public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000055")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x347E850", Offset = "0x347DC50", Length = "0x50")]
	[Token(Token = "0x600008B")]
	public override void Dispose() { }

	[Address(RVA = "0x347E8E0", Offset = "0x347DCE0", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600008A")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x347E8A0", Offset = "0x347DCA0", Length = "0x33")]
	[Token(Token = "0x600008C")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

