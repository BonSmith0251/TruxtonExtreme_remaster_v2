namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
[Token(Token = "0x2000003")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler
{
	[Token(Token = "0x2000004")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000018")]
		public static IntPtr ConvertToNative(DownloadHandlerAssetBundle handler) { }

	}


	[Token(Token = "0x17000001")]
	public AssetBundle assetBundle
	{
		[Address(RVA = "0x347A5A0", Offset = "0x34799A0", Length = "0x129")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 297
	}

	[Token(Token = "0x17000002")]
	public bool autoLoadAssetBundle
	{
		[Address(RVA = "0x347A710", Offset = "0x3479B10", Length = "0x51")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 81
		[Address(RVA = "0x347A860", Offset = "0x3479C60", Length = "0x5B")]
		[NativeThrows]
		[Token(Token = "0x6000010")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000003")]
	public bool isDownloadComplete
	{
		[Address(RVA = "0x347A7B0", Offset = "0x3479BB0", Length = "0x51")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x347A470", Offset = "0x3479870", Length = "0x44")]
	[Token(Token = "0x600000A")]
	public DownloadHandlerAssetBundle(string url, uint crc) { }

	[Address(RVA = "0x347A4C0", Offset = "0x34798C0", Length = "0x91")]
	[Token(Token = "0x600000B")]
	public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc) { }

	[Address(RVA = "0x347A1C0", Offset = "0x34795C0", Length = "0x1A1")]
	[Token(Token = "0x6000006")]
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	[Address(RVA = "0x347A160", Offset = "0x3479560", Length = "0x52")]
	[Token(Token = "0x6000012")]
	private static IntPtr Create_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, uint crc) { }

	[Address(RVA = "0x3479E80", Offset = "0x3479280", Length = "0x2D2")]
	[Token(Token = "0x6000007")]
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	[Address(RVA = "0x3479E10", Offset = "0x3479210", Length = "0x62")]
	[Token(Token = "0x6000013")]
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, ref ManagedSpanWrapper name, in Hash128 hash, uint crc) { }

	[Address(RVA = "0x347A5A0", Offset = "0x34799A0", Length = "0x129")]
	[Token(Token = "0x600000E")]
	public AssetBundle get_assetBundle() { }

	[Address(RVA = "0x347A560", Offset = "0x3479960", Length = "0x33")]
	[Token(Token = "0x6000014")]
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347A710", Offset = "0x3479B10", Length = "0x51")]
	[Token(Token = "0x600000F")]
	public bool get_autoLoadAssetBundle() { }

	[Address(RVA = "0x347A6D0", Offset = "0x3479AD0", Length = "0x33")]
	[Token(Token = "0x6000015")]
	private static bool get_autoLoadAssetBundle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347A7B0", Offset = "0x3479BB0", Length = "0x51")]
	[Token(Token = "0x6000011")]
	public bool get_isDownloadComplete() { }

	[Address(RVA = "0x347A770", Offset = "0x3479B70", Length = "0x33")]
	[Token(Token = "0x6000017")]
	private static bool get_isDownloadComplete_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347A370", Offset = "0x3479770", Length = "0x4E")]
	[Token(Token = "0x600000C")]
	protected virtual Byte[] GetData() { }

	[Address(RVA = "0x347A3C0", Offset = "0x34797C0", Length = "0x4E")]
	[Token(Token = "0x600000D")]
	protected virtual string GetText() { }

	[Address(RVA = "0x347A450", Offset = "0x3479850", Length = "0x1B")]
	[Token(Token = "0x6000008")]
	private void InternalCreateAssetBundle(string url, uint crc) { }

	[Address(RVA = "0x347A410", Offset = "0x3479810", Length = "0x37")]
	[Token(Token = "0x6000009")]
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	[Address(RVA = "0x347A860", Offset = "0x3479C60", Length = "0x5B")]
	[NativeThrows]
	[Token(Token = "0x6000010")]
	public void set_autoLoadAssetBundle(bool value) { }

	[Address(RVA = "0x347A810", Offset = "0x3479C10", Length = "0x42")]
	[Token(Token = "0x6000016")]
	private static void set_autoLoadAssetBundle_Injected(IntPtr _unity_self, bool value) { }

}

