namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000006")]
public class AssetBundleRequest : ResourceRequest
{
	[Token(Token = "0x2000007")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x2FC3DD0", Offset = "0x2FC31D0", Length = "0x54")]
		[Token(Token = "0x6000027")]
		public static AssetBundleRequest ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000028")]
		public static IntPtr ConvertToNative(AssetBundleRequest request) { }

	}


	[Token(Token = "0x17000003")]
	public Object[] allAssets
	{
		[Address(RVA = "0x2FC2650", Offset = "0x2FC1A50", Length = "0x51")]
		[NativeMethod("GetAllLoadedAssets")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000002")]
	public object asset
	{
		[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x2FC2460", Offset = "0x2FC1860", Length = "0x8")]
	[Token(Token = "0x6000024")]
	private AssetBundleRequest(IntPtr ptr) { }

	[Address(RVA = "0x2FC2650", Offset = "0x2FC1A50", Length = "0x51")]
	[NativeMethod("GetAllLoadedAssets")]
	[Token(Token = "0x6000023")]
	public Object[] get_allAssets() { }

	[Address(RVA = "0x2FC2610", Offset = "0x2FC1A10", Length = "0x33")]
	[Token(Token = "0x6000026")]
	private static Object[] get_allAssets_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x6000022")]
	public object get_asset() { }

	[Address(RVA = "0x2FC2580", Offset = "0x2FC1980", Length = "0x84")]
	[NativeMethod("GetLoadedAsset")]
	[Token(Token = "0x6000021")]
	protected virtual object GetResult() { }

	[Address(RVA = "0x2FC2540", Offset = "0x2FC1940", Length = "0x33")]
	[Token(Token = "0x6000025")]
	private static IntPtr GetResult_Injected(IntPtr _unity_self) { }

}

