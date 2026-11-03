namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000008")]
public class AssetBundleUnloadOperation : AsyncOperation
{
	[Token(Token = "0x2000009")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x2FC3D70", Offset = "0x2FC3170", Length = "0x54")]
		[Token(Token = "0x600002C")]
		public static AssetBundleUnloadOperation ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600002D")]
		public static IntPtr ConvertToNative(AssetBundleUnloadOperation assetBundleUnloadOperation) { }

	}


	[Address(RVA = "0x2FC2460", Offset = "0x2FC1860", Length = "0x8")]
	[Token(Token = "0x600002A")]
	private AssetBundleUnloadOperation(IntPtr ptr) { }

	[Address(RVA = "0x2FC26F0", Offset = "0x2FC1AF0", Length = "0x51")]
	[NativeMethod("WaitForCompletion")]
	[Token(Token = "0x6000029")]
	public void WaitForCompletion() { }

	[Address(RVA = "0x2FC26B0", Offset = "0x2FC1AB0", Length = "0x33")]
	[Token(Token = "0x600002B")]
	private static void WaitForCompletion_Injected(IntPtr _unity_self) { }

}

