namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
[Token(Token = "0x2000007")]
public class DownloadHandler : IDisposable
{
	[Token(Token = "0x2000008")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600002E")]
		public static IntPtr ConvertToNative(DownloadHandler handler) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000014")]
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000003")]
	public Byte[] data
	{
		[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000002")]
	public string error
	{
		[Address(RVA = "0x347BAD0", Offset = "0x347AED0", Length = "0x9")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000004")]
	public string text
	{
		[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000014")]
	[VisibleToOtherModules]
	internal DownloadHandler() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000023")]
	protected override void CompleteContent() { }

	[Address(RVA = "0x347B120", Offset = "0x347A520", Length = "0x6E")]
	[Token(Token = "0x6000029")]
	internal static void CreateNativeArrayForNativeData(ref NativeArray<Byte>& data, Byte* bytes, int length) { }

	[Address(RVA = "0x347B1D0", Offset = "0x347A5D0", Length = "0x50")]
	[Token(Token = "0x6000016")]
	public override void Dispose() { }

	[Address(RVA = "0x347B190", Offset = "0x347A590", Length = "0x37")]
	[Token(Token = "0x6000028")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static void DisposeNativeArray(ref NativeArray<Byte>& data) { }

	[Address(RVA = "0x347B220", Offset = "0x347A620", Length = "0x63")]
	[Token(Token = "0x6000015")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
	[Token(Token = "0x6000019")]
	public Byte[] get_data() { }

	[Address(RVA = "0x347BAD0", Offset = "0x347AED0", Length = "0x9")]
	[Token(Token = "0x6000017")]
	public string get_error() { }

	[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
	[Token(Token = "0x600001A")]
	public string get_text() { }

	[Address(RVA = "0x347B2E0", Offset = "0x347A6E0", Length = "0xCE")]
	[Token(Token = "0x600001F")]
	private string GetContentType() { }

	[Address(RVA = "0x347B290", Offset = "0x347A690", Length = "0x42")]
	[Token(Token = "0x600002C")]
	private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347B3B0", Offset = "0x347A7B0", Length = "0x8D")]
	[Token(Token = "0x600001C")]
	protected override Byte[] GetData() { }

	[Address(RVA = "0x347B490", Offset = "0x347A890", Length = "0xCE")]
	[Token(Token = "0x6000018")]
	private string GetErrorMsg() { }

	[Address(RVA = "0x347B440", Offset = "0x347A840", Length = "0x42")]
	[Token(Token = "0x600002B")]
	private static void GetErrorMsg_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0xE37D10", Offset = "0xE37110", Length = "0xA")]
	[Token(Token = "0x600001B")]
	protected override NativeArray<Byte> GetNativeData() { }

	[Address(RVA = "0x2FFB220", Offset = "0x2FFA620", Length = "0x6")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000024")]
	protected override float GetProgress() { }

	[Address(RVA = "0x347B760", Offset = "0x347AB60", Length = "0xE2")]
	[Token(Token = "0x600001D")]
	protected override string GetText() { }

	[Address(RVA = "0x347B560", Offset = "0x347A960", Length = "0x1FB")]
	[Token(Token = "0x600001E")]
	private Encoding GetTextEncoder() { }

	[Address(RVA = "0x347B8A0", Offset = "0x347ACA0", Length = "0x4C")]
	[NativeThrows]
	[Token(Token = "0x6000025")]
	[VisibleToOtherModules]
	internal static Byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	[Address(RVA = "0x347B3B0", Offset = "0x347A7B0", Length = "0x8D")]
	[Token(Token = "0x6000026")]
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	[Address(RVA = "0x347B850", Offset = "0x347AC50", Length = "0x42")]
	[Token(Token = "0x600002D")]
	private static Byte* InternalGetByteArray_Injected(IntPtr dh, out int length) { }

	[Address(RVA = "0x347B8F0", Offset = "0x347ACF0", Length = "0x11F")]
	[Token(Token = "0x6000027")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static NativeArray<Byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<Byte>& nativeArray) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Use ReceiveContentLengthHeader")]
	[Token(Token = "0x6000022")]
	protected override void ReceiveContentLength(int contentLength) { }

	[Address(RVA = "0x347BA10", Offset = "0x347AE10", Length = "0x14")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000021")]
	protected override void ReceiveContentLengthHeader(ulong contentLength) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	protected override bool ReceiveData(Byte[] data, int dataLength) { }

	[Address(RVA = "0x347BA70", Offset = "0x347AE70", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000013")]
	private void ReleaseFromScripting() { }

	[Address(RVA = "0x347BA30", Offset = "0x347AE30", Length = "0x33")]
	[Token(Token = "0x600002A")]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

