namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
[Token(Token = "0x2000005")]
public class CertificateHandler
{
	[Token(Token = "0x2000006")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000012")]
		public static IntPtr ConvertToNative(CertificateHandler handler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x347ADB0", Offset = "0x347A1B0", Length = "0x50")]
	[Token(Token = "0x6000010")]
	public override void Dispose() { }

	[Address(RVA = "0x347AE40", Offset = "0x347A240", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600000D")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x347AE00", Offset = "0x347A200", Length = "0x33")]
	[Token(Token = "0x6000011")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x600000E")]
	protected override bool ValidateCertificate(Byte[] certificateData) { }

	[Address(RVA = "0x347AEA0", Offset = "0x347A2A0", Length = "0x14")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

}

