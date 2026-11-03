namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000003")]
public class AssetBundleCreateRequest : AsyncOperation
{
	[Token(Token = "0x2000004")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x2FC3D10", Offset = "0x2FC3110", Length = "0x54")]
		[Token(Token = "0x600001F")]
		public static AssetBundleCreateRequest ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000020")]
		public static IntPtr ConvertToNative(AssetBundleCreateRequest assetBundleCreateRequest) { }

	}


	[Token(Token = "0x17000001")]
	public AssetBundle assetBundle
	{
		[Address(RVA = "0x2FC24B0", Offset = "0x2FC18B0", Length = "0x84")]
		[NativeMethod("GetAssetBundleBlocking")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 132
	}

	[Address(RVA = "0x2FC2460", Offset = "0x2FC1860", Length = "0x8")]
	[Token(Token = "0x600001D")]
	private AssetBundleCreateRequest(IntPtr ptr) { }

	[Address(RVA = "0x2FC24B0", Offset = "0x2FC18B0", Length = "0x84")]
	[NativeMethod("GetAssetBundleBlocking")]
	[Token(Token = "0x600001C")]
	public AssetBundle get_assetBundle() { }

	[Address(RVA = "0x2FC2470", Offset = "0x2FC1870", Length = "0x33")]
	[Token(Token = "0x600001E")]
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

}

