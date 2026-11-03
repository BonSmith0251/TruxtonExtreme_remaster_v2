namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200000E")]
public class SDK
{
	[CompilerGenerated]
	[Token(Token = "0x200007F")]
	private sealed class <>c
	{
		[Token(Token = "0x40000D5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000D6")]
		public static XTaskQueueTerminatedCallback <>9__82_0; //Field offset: 0x8
		[Token(Token = "0x40000D7")]
		public static Func<XGameSaveBlobInfo, String> <>9__228_0; //Field offset: 0x10
		[Token(Token = "0x40000D8")]
		public static Func<XGameSaveBlobInfo, Int32> <>9__228_1; //Field offset: 0x18
		[Token(Token = "0x40000D9")]
		public static Func<XGameSaveBlobInterop, XGameSaveBlob> <>9__228_2; //Field offset: 0x20
		[Token(Token = "0x40000DA")]
		public static Func<XGameSaveBlobInterop, XGameSaveBlob> <>9__230_0; //Field offset: 0x28

		[Address(RVA = "0x2B7B700", Offset = "0x2B7AB00", Length = "0x67")]
		[Token(Token = "0x6000499")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600049A")]
		public <>c() { }

		[Address(RVA = "0x2B6EDF0", Offset = "0x2B6E1F0", Length = "0x4F")]
		[Token(Token = "0x600049B")]
		internal void <CloseDefaultXTaskQueue>b__82_0(IntPtr context) { }

		[Address(RVA = "0x2B6EEB0", Offset = "0x2B6E2B0", Length = "0x1F")]
		[Token(Token = "0x600049C")]
		internal string <XGameSaveReadBlobData>b__228_0(XGameSaveBlobInfo x) { }

		[Address(RVA = "0x2B6EED0", Offset = "0x2B6E2D0", Length = "0xEC")]
		[Token(Token = "0x600049D")]
		internal int <XGameSaveReadBlobData>b__228_1(XGameSaveBlobInfo x) { }

		[Address(RVA = "0x2B6EFC0", Offset = "0x2B6E3C0", Length = "0x69")]
		[Token(Token = "0x600049E")]
		internal XGameSaveBlob <XGameSaveReadBlobData>b__228_2(XGameSaveBlobInterop blobDataInterop) { }

		[Address(RVA = "0x2B6EE40", Offset = "0x2B6E240", Length = "0x69")]
		[Token(Token = "0x600049F")]
		internal XGameSaveBlob <XGameSaveReadBlobDataResult>b__230_0(XGameSaveBlobInterop blobDataInterop) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000085")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E0")]
		public HCSocketCompletionResultFunction completionRoutine; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E1")]
		public HCWebsocketHandle websocket; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004AA")]
		public <>c__DisplayClass10_0() { }

		[Address(RVA = "0x2B719A0", Offset = "0x2B70DA0", Length = "0x8F")]
		[Token(Token = "0x60004AB")]
		internal void <HCWebSocketSendMessageAsync>b__0(XAsyncBlock block) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000080")]
	private sealed class <>c__DisplayClass100_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DB")]
		public XGameUiShowWebAuthenticationAsyncCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A0")]
		public <>c__DisplayClass100_0() { }

		[Address(RVA = "0x2B71380", Offset = "0x2B70780", Length = "0x14F")]
		[Token(Token = "0x60004A1")]
		internal void <XGameUiShowWebAuthenticationAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000081")]
	private sealed class <>c__DisplayClass101_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DC")]
		public Action<Int32, XGameUiWebAuthenticationResultData> onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A2")]
		public <>c__DisplayClass101_0() { }

		[Address(RVA = "0x2B714D0", Offset = "0x2B708D0", Length = "0x14F")]
		[Token(Token = "0x60004A3")]
		internal void <XGameUiShowWebAuthenticationWithOptionsAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000082")]
	private sealed class <>c__DisplayClass102_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DD")]
		public XNetworkingQueryPreferredLocalUdpMultiplayerPortResultFunction onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A4")]
		public <>c__DisplayClass102_0() { }

		[Address(RVA = "0x2B71620", Offset = "0x2B70A20", Length = "0x87")]
		[Token(Token = "0x60004A5")]
		internal void <XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000083")]
	private sealed class <>c__DisplayClass103_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DE")]
		public XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A6")]
		public <>c__DisplayClass103_0() { }

		[Address(RVA = "0x2B716B0", Offset = "0x2B70AB0", Length = "0x155")]
		[Token(Token = "0x60004A7")]
		internal void <XNetworkingQuerySecurityInformationForUrlAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000084")]
	private sealed class <>c__DisplayClass104_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DF")]
		public XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A8")]
		public <>c__DisplayClass104_0() { }

		[Address(RVA = "0x2B71810", Offset = "0x2B70C10", Length = "0x155")]
		[Token(Token = "0x60004A9")]
		internal void <XNetworkingQuerySecurityInformationForUrlUtf16Async>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008C")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E8")]
		public HCSocketCompletionResultFunction completionRoutine; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E9")]
		public HCWebsocketHandle websocket; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004B8")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x2B719A0", Offset = "0x2B70DA0", Length = "0x8F")]
		[Token(Token = "0x60004B9")]
		internal void <HCWebSocketSendBinaryMessageAsync>b__0(XAsyncBlock block) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000086")]
	private sealed class <>c__DisplayClass110_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E2")]
		public XPackageInstallChunksCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004AC")]
		public <>c__DisplayClass110_0() { }

		[Address(RVA = "0x2B71A80", Offset = "0x2B70E80", Length = "0x89")]
		[Token(Token = "0x60004AD")]
		internal void <XPackageInstallChunksAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000087")]
	private sealed class <>c__DisplayClass113_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E3")]
		public XPackageMountWithUiAsyncCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004AE")]
		public <>c__DisplayClass113_0() { }

		[Address(RVA = "0x2B71B10", Offset = "0x2B70F10", Length = "0x89")]
		[Token(Token = "0x60004AF")]
		internal void <XPackageMountWithUiAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000088")]
	private sealed class <>c__DisplayClass116_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E4")]
		public XPersistentLocalStoragePromptUserForSpaceAsyncCallback onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004B0")]
		public <>c__DisplayClass116_0() { }

		[Address(RVA = "0x2B71BA0", Offset = "0x2B70FA0", Length = "0x74")]
		[Token(Token = "0x60004B1")]
		internal void <XPersistentLocalStoragePromptUserForSpaceAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000089")]
	private sealed class <>c__DisplayClass117_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E5")]
		public XStoreAcquireLicenseForDurablesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004B2")]
		public <>c__DisplayClass117_0() { }

		[Address(RVA = "0x2B71C20", Offset = "0x2B71020", Length = "0x89")]
		[Token(Token = "0x60004B3")]
		internal void <XStoreAcquireLicenseForDurablesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008A")]
	private sealed class <>c__DisplayClass118_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E6")]
		public XStoreAcquireLicenseForPackageCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004B4")]
		public <>c__DisplayClass118_0() { }

		[Address(RVA = "0x2B71CB0", Offset = "0x2B710B0", Length = "0x89")]
		[Token(Token = "0x60004B5")]
		internal void <XStoreAcquireLicenseForPackageAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <>c__DisplayClass119_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E7")]
		public XStoreCanAcquireLicenseForPackageCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004B6")]
		public <>c__DisplayClass119_0() { }

		[Address(RVA = "0x2B71D40", Offset = "0x2B71140", Length = "0x89")]
		[Token(Token = "0x60004B7")]
		internal void <XStoreCanAcquireLicenseForPackageAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private sealed class <>c__DisplayClass120_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EA")]
		public XStoreCanAcquireLicenseForStoreIdCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004BA")]
		public <>c__DisplayClass120_0() { }

		[Address(RVA = "0x2B71DD0", Offset = "0x2B711D0", Length = "0x89")]
		[Token(Token = "0x60004BB")]
		internal void <XStoreCanAcquireLicenseForStoreIdAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008E")]
	private sealed class <>c__DisplayClass121_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EB")]
		public XStoreDownloadAndInstallPackagesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004BC")]
		public <>c__DisplayClass121_0() { }

		[Address(RVA = "0x2B71E60", Offset = "0x2B71260", Length = "0xFA")]
		[Token(Token = "0x60004BD")]
		internal void <XStoreDownloadAndInstallPackagesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008F")]
	private sealed class <>c__DisplayClass122_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EC")]
		public XStoreDownloadAndInstallPackageUpdatesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004BE")]
		public <>c__DisplayClass122_0() { }

		[Address(RVA = "0x2B71F60", Offset = "0x2B71360", Length = "0x74")]
		[Token(Token = "0x60004BF")]
		internal void <XStoreDownloadAndInstallPackageUpdatesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private sealed class <>c__DisplayClass123_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000ED")]
		public XStoreDownloadPackageUpdatesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004C0")]
		public <>c__DisplayClass123_0() { }

		[Address(RVA = "0x2B71FE0", Offset = "0x2B713E0", Length = "0x74")]
		[Token(Token = "0x60004C1")]
		internal void <XStoreDownloadPackageUpdatesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <>c__DisplayClass124_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EE")]
		public XStoreGetUserCollectionsIdCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004C2")]
		public <>c__DisplayClass124_0() { }

		[Address(RVA = "0x2B72060", Offset = "0x2B71460", Length = "0xFD")]
		[Token(Token = "0x60004C3")]
		internal void <XStoreGetUserCollectionsIdAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000092")]
	private sealed class <>c__DisplayClass125_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EF")]
		public XStoreGetUserPurchaseIdCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004C4")]
		public <>c__DisplayClass125_0() { }

		[Address(RVA = "0x2B72160", Offset = "0x2B71560", Length = "0xFD")]
		[Token(Token = "0x60004C5")]
		internal void <XStoreGetUserPurchaseIdAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000093")]
	private sealed class <>c__DisplayClass126_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F0")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004C6")]
		public <>c__DisplayClass126_0() { }

		[Address(RVA = "0x2B72260", Offset = "0x2B71660", Length = "0x1A3")]
		[Token(Token = "0x60004C7")]
		internal void <XStoreProductsQueryNextPageAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <>c__DisplayClass128_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F1")]
		public Action<Int32, XStoreProductQuery> onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004C8")]
		public <>c__DisplayClass128_0() { }

		[Address(RVA = "0x2B72410", Offset = "0x2B71810", Length = "0x89")]
		[Token(Token = "0x60004C9")]
		internal void <XStoreQueryAssociatedProductsAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000095")]
	private sealed class <>c__DisplayClass129_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F2")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004CA")]
		public <>c__DisplayClass129_0() { }

		[Address(RVA = "0x2B724A0", Offset = "0x2B718A0", Length = "0x165")]
		[Token(Token = "0x60004CB")]
		internal void <XStoreQueryAssociatedProductsAsync>b__0(int hr, XStoreProductQuery queryResult) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000096")]
	private sealed class <>c__DisplayClass131_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F3")]
		public XStoreQueryAddOnLicensesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004CC")]
		public <>c__DisplayClass131_0() { }

		[Address(RVA = "0x2B72610", Offset = "0x2B71A10", Length = "0x10D")]
		[Token(Token = "0x60004CD")]
		internal void <XStoreQueryAddOnLicensesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000097")]
	private sealed class <>c__DisplayClass132_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F4")]
		public XStoreQueryConsumableBalanceRemainingCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004CE")]
		public <>c__DisplayClass132_0() { }

		[Address(RVA = "0x2B72720", Offset = "0x2B71B20", Length = "0x89")]
		[Token(Token = "0x60004CF")]
		internal void <XStoreQueryConsumableBalanceRemainingAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000098")]
	private sealed class <>c__DisplayClass133_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F5")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004D0")]
		public <>c__DisplayClass133_0() { }

		[Address(RVA = "0x2B72890", Offset = "0x2B71C90", Length = "0x1A3")]
		[Token(Token = "0x60004D1")]
		internal void <XStoreQueryEntitledProductsAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000099")]
	private sealed class <>c__DisplayClass134_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F6")]
		public XStoreQueryGameAndDlcPackageUpdatesCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004D2")]
		public <>c__DisplayClass134_0() { }

		[Address(RVA = "0x2B72B20", Offset = "0x2B71F20", Length = "0x10D")]
		[Token(Token = "0x60004D3")]
		internal void <XStoreQueryGameAndDlcPackageUpdatesAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009A")]
	private sealed class <>c__DisplayClass135_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F7")]
		public XStoreQueryGameLicenseCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004D4")]
		public <>c__DisplayClass135_0() { }

		[Address(RVA = "0x2B72D10", Offset = "0x2B72110", Length = "0x89")]
		[Token(Token = "0x60004D5")]
		internal void <XStoreQueryGameLicenseAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009B")]
	private sealed class <>c__DisplayClass136_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F8")]
		public XStoreQueryLicenseTokenCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004D6")]
		public <>c__DisplayClass136_0() { }

		[Address(RVA = "0x2B72E80", Offset = "0x2B72280", Length = "0xFD")]
		[Token(Token = "0x60004D7")]
		internal void <XStoreQueryLicenseTokenAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009C")]
	private sealed class <>c__DisplayClass138_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F9")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004D8")]
		public <>c__DisplayClass138_0() { }

		[Address(RVA = "0x2B731E0", Offset = "0x2B725E0", Length = "0x1A3")]
		[Token(Token = "0x60004D9")]
		internal void <XStoreQueryProductForCurrentGameAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009D")]
	private sealed class <>c__DisplayClass139_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FA")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004DA")]
		public <>c__DisplayClass139_0() { }

		[Address(RVA = "0x2B73390", Offset = "0x2B72790", Length = "0x1A3")]
		[Token(Token = "0x60004DB")]
		internal void <XStoreQueryProductForPackageAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009E")]
	private sealed class <>c__DisplayClass140_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FB")]
		public XStoreQueryComplete onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004DC")]
		public <>c__DisplayClass140_0() { }

		[Address(RVA = "0x2B73710", Offset = "0x2B72B10", Length = "0x1A3")]
		[Token(Token = "0x60004DD")]
		internal void <XStoreQueryProductsAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200009F")]
	private sealed class <>c__DisplayClass145_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FC")]
		public XStoreReportConsumableFulfillmentCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004DE")]
		public <>c__DisplayClass145_0() { }

		[Address(RVA = "0x2B73FD0", Offset = "0x2B733D0", Length = "0x89")]
		[Token(Token = "0x60004DF")]
		internal void <XStoreReportConsumableFulfillmentAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A0")]
	private sealed class <>c__DisplayClass146_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FD")]
		public XStoreShowAssociatedProductsUICompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E0")]
		public <>c__DisplayClass146_0() { }

		[Address(RVA = "0x2B743D0", Offset = "0x2B737D0", Length = "0x74")]
		[Token(Token = "0x60004E1")]
		internal void <XStoreShowAssociatedProductsUIAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A1")]
	private sealed class <>c__DisplayClass147_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FE")]
		public XStoreShowProductPageUICompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E2")]
		public <>c__DisplayClass147_0() { }

		[Address(RVA = "0x2B74680", Offset = "0x2B73A80", Length = "0x74")]
		[Token(Token = "0x60004E3")]
		internal void <XStoreShowProductPageUIAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A2")]
	private sealed class <>c__DisplayClass148_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FF")]
		public XStoreShowPurchaseUICompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E4")]
		public <>c__DisplayClass148_0() { }

		[Address(RVA = "0x2B74A50", Offset = "0x2B73E50", Length = "0x74")]
		[Token(Token = "0x60004E5")]
		internal void <XStoreShowPurchaseUIAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A3")]
	private sealed class <>c__DisplayClass149_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000100")]
		public XStoreShowRateAndReviewUICompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E6")]
		public <>c__DisplayClass149_0() { }

		[Address(RVA = "0x2B74AD0", Offset = "0x2B73ED0", Length = "0x89")]
		[Token(Token = "0x60004E7")]
		internal void <XStoreShowRateAndReviewUIAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A4")]
	private sealed class <>c__DisplayClass150_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000101")]
		public XStoreShowRedeemTokenUICompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004E8")]
		public <>c__DisplayClass150_0() { }

		[Address(RVA = "0x2B74D10", Offset = "0x2B74110", Length = "0x74")]
		[Token(Token = "0x60004E9")]
		internal void <XStoreShowRedeemTokenUIAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A5")]
	private sealed class <>c__DisplayClass151_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000102")]
		public XUserAddCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004EA")]
		public <>c__DisplayClass151_0() { }

		[Address(RVA = "0x2B74D90", Offset = "0x2B74190", Length = "0x89")]
		[Token(Token = "0x60004EB")]
		internal void <XUserAddByIdWithUiAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A6")]
	private sealed class <>c__DisplayClass152_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000103")]
		public XUserFindControllerForUserWithUiResult onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004EC")]
		public <>c__DisplayClass152_0() { }

		[Address(RVA = "0x2B74E20", Offset = "0x2B74220", Length = "0x89")]
		[Token(Token = "0x60004ED")]
		internal void <XUserFindControllerForUserWithUiAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A7")]
	private sealed class <>c__DisplayClass153_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000104")]
		public XUserGetTokenAndSignatureUtf16Result onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004EE")]
		public <>c__DisplayClass153_0() { }

		[Address(RVA = "0x2B74EB0", Offset = "0x2B742B0", Length = "0x14F")]
		[Token(Token = "0x60004EF")]
		internal void <XUserGetTokenAndSignatureUtf16Async>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private sealed class <>c__DisplayClass154_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000105")]
		public XUserResolveIssueWithUiUtf16Result onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004F0")]
		public <>c__DisplayClass154_0() { }

		[Address(RVA = "0x2B75000", Offset = "0x2B74400", Length = "0x74")]
		[Token(Token = "0x60004F1")]
		internal void <XUserResolveIssueWithUiUtf16Async>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000A9")]
	private sealed class <>c__DisplayClass155_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000106")]
		public XUserResolvePrivilegeWithUiCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004F2")]
		public <>c__DisplayClass155_0() { }

		[Address(RVA = "0x2B75080", Offset = "0x2B74480", Length = "0x74")]
		[Token(Token = "0x60004F3")]
		internal void <XUserResolvePrivilegeWithUiAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AA")]
	private sealed class <>c__DisplayClass156_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000107")]
		public XUserGetGamerPictureCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004F4")]
		public <>c__DisplayClass156_0() { }

		[Address(RVA = "0x2B75100", Offset = "0x2B74500", Length = "0x14D")]
		[Token(Token = "0x60004F5")]
		internal void <XUserGetGamerPictureAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AB")]
	private sealed class <>c__DisplayClass157_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000108")]
		public XUserAddCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004F6")]
		public <>c__DisplayClass157_0() { }

		[Address(RVA = "0x2B75250", Offset = "0x2B74650", Length = "0x89")]
		[Token(Token = "0x60004F7")]
		internal void <XUserAddAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AC")]
	private sealed class <>c__DisplayClass164_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000109")]
		public XAsyncBlock asyncBlock; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010A")]
		public XAsyncProvider provider; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004F8")]
		public <>c__DisplayClass164_0() { }

		[Address(RVA = "0x2B75610", Offset = "0x2B74A10", Length = "0xB7")]
		[Token(Token = "0x60004F9")]
		internal int <XAsyncBegin>b__0(XAsyncOp _op, XAsyncProviderData _dataInterop) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AD")]
	private sealed class <>c__DisplayClass174_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010B")]
		public XErrorCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004FA")]
		public <>c__DisplayClass174_0() { }

		[Address(RVA = "0x2B756E0", Offset = "0x2B74AE0", Length = "0x2A")]
		[Token(Token = "0x60004FB")]
		internal bool <XErrorSetCallback>b__0(int hr, string msg, IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AE")]
	private sealed class <>c__DisplayClass180_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010C")]
		public List<XGameSaveBlobInfo> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004FC")]
		public <>c__DisplayClass180_0() { }

		[Address(RVA = "0x2B75710", Offset = "0x2B74B10", Length = "0xAF")]
		[Token(Token = "0x60004FD")]
		internal bool <XGameSaveEnumerateBlobInfo>b__0(XGameSaveBlobInfo _blobInfo, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000AF")]
	private sealed class <>c__DisplayClass181_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010D")]
		public XGameSaveContainerInfo info; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004FE")]
		public <>c__DisplayClass181_0() { }

		[Address(RVA = "0x2B757C0", Offset = "0x2B74BC0", Length = "0x18")]
		[Token(Token = "0x60004FF")]
		internal bool <XGameSaveGetContainerInfo>b__0(XGameSaveContainerInfo _info, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B0")]
	private sealed class <>c__DisplayClass182_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010E")]
		public List<XGameSaveContainerInfo> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000500")]
		public <>c__DisplayClass182_0() { }

		[Address(RVA = "0x2B757E0", Offset = "0x2B74BE0", Length = "0xAF")]
		[Token(Token = "0x6000501")]
		internal bool <XGameSaveEnumerateContainerInfo>b__0(XGameSaveContainerInfo _info, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B1")]
	private sealed class <>c__DisplayClass183_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010F")]
		public List<XGameSaveContainerInfo> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000502")]
		public <>c__DisplayClass183_0() { }

		[Address(RVA = "0x2B75890", Offset = "0x2B74C90", Length = "0xAF")]
		[Token(Token = "0x6000503")]
		internal bool <XGameSaveEnumerateContainerInfoByName>b__0(XGameSaveContainerInfo _info, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B2")]
	private sealed class <>c__DisplayClass184_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000110")]
		public List<XGameSaveBlobInfo> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000504")]
		public <>c__DisplayClass184_0() { }

		[Address(RVA = "0x2B75940", Offset = "0x2B74D40", Length = "0xAF")]
		[Token(Token = "0x6000505")]
		internal bool <XGameSaveEnumerateBlobInfoByName>b__0(XGameSaveBlobInfo _info, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B3")]
	private sealed class <>c__DisplayClass186_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		public List<XSpeechSynthesizerVoiceInformation> voices; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000506")]
		public <>c__DisplayClass186_0() { }

		[Address(RVA = "0x2B759F0", Offset = "0x2B74DF0", Length = "0xAD")]
		[Token(Token = "0x6000507")]
		internal bool <XSpeechSynthesizerEnumerateInstalledVoices>g__VoiceCallback|0(ref XSpeechSynthesizerVoiceInformation information, IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B4")]
	private sealed class <>c__DisplayClass188_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000112")]
		public List<XStoreProduct> tmpProducts; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000508")]
		public <>c__DisplayClass188_0() { }

		[Address(RVA = "0x2B75AA0", Offset = "0x2B74EA0", Length = "0xAF")]
		[Token(Token = "0x6000509")]
		internal bool <XStoreEnumerateProductsQuery>g__OnProduct|0(XStoreProduct product, IntPtr _) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B5")]
	private sealed class <>c__DisplayClass194_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000113")]
		public List<XPackageDetails> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600050A")]
		public <>c__DisplayClass194_0() { }

		[Address(RVA = "0x2B75B50", Offset = "0x2B74F50", Length = "0xAF")]
		[Token(Token = "0x600050B")]
		internal bool <XPackageEnumeratePackages>b__0(IntPtr context, XPackageDetails details) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B6")]
	private sealed class <>c__DisplayClass195_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000114")]
		public List<XPackageFeature> results; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600050C")]
		public <>c__DisplayClass195_0() { }

		[Address(RVA = "0x2B75C00", Offset = "0x2B75000", Length = "0xAF")]
		[Token(Token = "0x600050D")]
		internal bool <XPackageEnumerateFeatures>b__0(IntPtr context, XPackageFeature feature) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B7")]
	private sealed class <>c__DisplayClass201_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000115")]
		public XGameInviteEventCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600050E")]
		public <>c__DisplayClass201_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x600050F")]
		internal void <XGameInviteRegisterForEvent>b__0(IntPtr context, string inviteUri) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B8")]
	private sealed class <>c__DisplayClass205_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000116")]
		public XGameProtocolActivationCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000510")]
		public <>c__DisplayClass205_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x6000511")]
		internal void <XGameProtocolRegisterForActivation>b__0(IntPtr context, string protocolUri) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B9")]
	private sealed class <>c__DisplayClass225_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000117")]
		public XGameSaveContainerInfoCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000512")]
		public <>c__DisplayClass225_0() { }

		[Address(RVA = "0x2B75F70", Offset = "0x2B75370", Length = "0xA9")]
		[Token(Token = "0x6000513")]
		internal bool <XGameSaveGetContainerInfo>b__0(XGameSaveContainerInfo info, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BA")]
	private sealed class <>c__DisplayClass226_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000118")]
		public XGameSaveContainerInfoCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000514")]
		public <>c__DisplayClass226_0() { }

		[Address(RVA = "0x2B76020", Offset = "0x2B75420", Length = "0xA9")]
		[Token(Token = "0x6000515")]
		internal bool <XGameSaveEnumerateContainerInfo>b__0(XGameSaveContainerInfo info, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BB")]
	private sealed class <>c__DisplayClass227_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000119")]
		public XGameSaveContainerInfoCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000516")]
		public <>c__DisplayClass227_0() { }

		[Address(RVA = "0x2B76150", Offset = "0x2B75550", Length = "0xA9")]
		[Token(Token = "0x6000517")]
		internal bool <XGameSaveEnumerateContainerInfoByName>b__0(XGameSaveContainerInfo info, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private sealed class <>c__DisplayClass232_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011A")]
		public XGameSaveBlobInfoCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000518")]
		public <>c__DisplayClass232_0() { }

		[Address(RVA = "0x2B76B30", Offset = "0x2B75F30", Length = "0x98")]
		[Token(Token = "0x6000519")]
		internal bool <XGameSaveEnumerateBlobInfo>b__0(XGameSaveBlobInfo info, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BD")]
	private sealed class <>c__DisplayClass233_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011B")]
		public XGameSaveBlobInfoCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600051A")]
		public <>c__DisplayClass233_0() { }

		[Address(RVA = "0x2B76EE0", Offset = "0x2B762E0", Length = "0x98")]
		[Token(Token = "0x600051B")]
		internal bool <XGameSaveEnumerateBlobInfoByName>b__0(XGameSaveBlobInfo info, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BE")]
	private sealed class <>c__DisplayClass257_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011C")]
		public XGameStreamingConnectionStateChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600051C")]
		public <>c__DisplayClass257_0() { }

		[Address(RVA = "0x2B77A00", Offset = "0x2B76E00", Length = "0xA4")]
		[Token(Token = "0x600051D")]
		internal void <XGameStreamingRegisterConnectionStateChanged>b__0(IntPtr _context, XGameStreamingClientId _client, XGameStreamingConnectionState _state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BF")]
	private sealed class <>c__DisplayClass263_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011D")]
		public XGameStreamingClientPropertiesChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600051E")]
		public <>c__DisplayClass263_0() { }

		[Address(RVA = "0x2B77AB0", Offset = "0x2B76EB0", Length = "0x97")]
		[Token(Token = "0x600051F")]
		internal void <XGameStreamingRegisterClientPropertiesChanged>b__0(IntPtr _context, XGameStreamingClientId _clientId, uint _updatedPropertiesCount, XGameStreamingClientProperty[] _updatedProperties) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C0")]
	private sealed class <>c__DisplayClass323_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011E")]
		public XNetworkingConnectivityHintChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000520")]
		public <>c__DisplayClass323_0() { }

		[Address(RVA = "0x2B794F0", Offset = "0x2B788F0", Length = "0x98")]
		[Token(Token = "0x6000521")]
		internal void <XNetworkingRegisterConnectivityHintChanged>b__0(IntPtr context, XNetworkingConnectivityHint connectivityHint) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C1")]
	private sealed class <>c__DisplayClass325_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011F")]
		public XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000522")]
		public <>c__DisplayClass325_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x6000523")]
		internal void <XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged>b__0(IntPtr context, ushort preferredLocalUdpMultiplayerPort) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C2")]
	private sealed class <>c__DisplayClass349_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000120")]
		public XPackageChunkAvailabilityCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000524")]
		public <>c__DisplayClass349_0() { }

		[Address(RVA = "0x2B79590", Offset = "0x2B78990", Length = "0xAF")]
		[Token(Token = "0x6000525")]
		internal bool <XPackageEnumerateChunkAvailability>b__0(IntPtr _context, XPackageChunkSelectorInterop _selector, XPackageChunkAvailability _availability) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C3")]
	private sealed class <>c__DisplayClass351_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000121")]
		public XPackageFeatureEnumerationCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000526")]
		public <>c__DisplayClass351_0() { }

		[Address(RVA = "0x2B79640", Offset = "0x2B78A40", Length = "0xAB")]
		[Token(Token = "0x6000527")]
		internal bool <XPackageEnumerateFeatures>b__0(IntPtr _context, XPackageFeature _featureInterop) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C4")]
	private sealed class <>c__DisplayClass353_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000122")]
		public XPackageEnumerationCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000528")]
		public <>c__DisplayClass353_0() { }

		[Address(RVA = "0x2B796F0", Offset = "0x2B78AF0", Length = "0xB5")]
		[Token(Token = "0x6000529")]
		internal bool <XPackageEnumeratePackages>b__0(IntPtr _context, XPackageDetails _details) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C5")]
	private sealed class <>c__DisplayClass359_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000123")]
		public XPackageInstallationProgressCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000124")]
		public XPackageInstallationMonitorHandle installationMonitorHandle; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600052A")]
		public <>c__DisplayClass359_0() { }

		[Address(RVA = "0x2B797B0", Offset = "0x2B78BB0", Length = "0x2C")]
		[Token(Token = "0x600052B")]
		internal void <XPackageRegisterInstallationProgressChanged>b__0(IntPtr _context, IntPtr _monitor) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C6")]
	private sealed class <>c__DisplayClass360_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000125")]
		public XPackageInstalledCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600052C")]
		public <>c__DisplayClass360_0() { }

		[Address(RVA = "0x2B797E0", Offset = "0x2B78BE0", Length = "0xB5")]
		[Token(Token = "0x600052D")]
		internal void <XPackageRegisterPackageInstalled>b__0(IntPtr _context, XPackageDetails _details) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C8")]
	private sealed class <>c__DisplayClass37_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000127")]
		public XAppBroadcastMonitorCallback appBroadcastMonitorCallback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000530")]
		public <>c__DisplayClass37_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6000531")]
		internal void <XAppBroadcastRegisterIsAppBroadcastingChanged>b__0(IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C7")]
	private sealed class <>c__DisplayClass373_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000126")]
		public XSpeechSynthesizerInstalledVoicesCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600052E")]
		public <>c__DisplayClass373_0() { }

		[Address(RVA = "0x2B798A0", Offset = "0x2B78CA0", Length = "0xE2")]
		[Token(Token = "0x600052F")]
		internal bool <XSpeechSynthesizerEnumerateInstalledVoices>b__0(ref XSpeechSynthesizerVoiceInformation _information, IntPtr _context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C9")]
	private sealed class <>c__DisplayClass398_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000128")]
		public XStoreProductQueryCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000532")]
		public <>c__DisplayClass398_0() { }

		[Address(RVA = "0x2B79990", Offset = "0x2B78D90", Length = "0x8D")]
		[Token(Token = "0x6000533")]
		internal bool <XStoreEnumerateProductsQuery>b__0(ref XStoreProductInterop product, IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	private sealed class <>c__DisplayClass441_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000129")]
		public XStoreGameLicenseChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000534")]
		public <>c__DisplayClass441_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6000535")]
		internal void <XStoreRegisterGameLicenseChanged>b__0(IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CB")]
	private sealed class <>c__DisplayClass443_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012A")]
		public XStorePackageLicenseLostCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000536")]
		public <>c__DisplayClass443_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6000537")]
		internal void <XStoreRegisterPackageLicenseLost>b__0(IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CC")]
	private sealed class <>c__DisplayClass468_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012B")]
		public XSystemHandleCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000538")]
		public <>c__DisplayClass468_0() { }

		[Address(RVA = "0x22CE500", Offset = "0x22CD900", Length = "0x2A")]
		[Token(Token = "0x6000539")]
		internal void <XSystemHandleTrack>b__0(IntPtr handlePtr, XSystemHandleType type, XSystemHandleCallbackReason reason, IntPtr callbackContext) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CD")]
	private sealed class <>c__DisplayClass476_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012C")]
		public XTaskQueueMonitorCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600053A")]
		public <>c__DisplayClass476_0() { }

		[Address(RVA = "0x2B756E0", Offset = "0x2B74AE0", Length = "0x2A")]
		[Token(Token = "0x600053B")]
		internal void <XTaskQueueRegisterMonitor>b__0(IntPtr context, IntPtr queuePtr, XTaskQueuePort port) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CE")]
	private sealed class <>c__DisplayClass477_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012D")]
		public XTaskQueueCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600053C")]
		public <>c__DisplayClass477_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x600053D")]
		internal void <XTaskQueueRegisterWaiter>b__0(IntPtr context, bool canceled) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CF")]
	private sealed class <>c__DisplayClass479_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012E")]
		public XTaskQueueCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600053E")]
		public <>c__DisplayClass479_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x600053F")]
		internal void <XTaskQueueSubmitCallback>b__0(IntPtr context, bool canceled) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D0")]
	private sealed class <>c__DisplayClass480_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012F")]
		public XTaskQueueCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000540")]
		public <>c__DisplayClass480_0() { }

		[Address(RVA = "0x179DC90", Offset = "0x179D090", Length = "0x25")]
		[Token(Token = "0x6000541")]
		internal void <XTaskQueueSubmitDelayedCallback>b__0(IntPtr context, bool canceled) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D1")]
	private sealed class <>c__DisplayClass481_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000130")]
		public XTaskQueueTerminatedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000542")]
		public <>c__DisplayClass481_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x6000543")]
		internal void <XTaskQueueTerminate>b__0(IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D5")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000134")]
		public HCCleanupHandler completionRoutine; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600054A")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2B7A300", Offset = "0x2B79700", Length = "0x19")]
		[Token(Token = "0x600054B")]
		internal void <HCCleanupAsync>b__0(XAsyncBlock block) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D2")]
	private sealed class <>c__DisplayClass523_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000131")]
		public XUserChangeEventCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000544")]
		public <>c__DisplayClass523_0() { }

		[Address(RVA = "0x2B79A20", Offset = "0x2B78E20", Length = "0xA4")]
		[Token(Token = "0x6000545")]
		internal void <XUserRegisterForChangeEvent>b__0(IntPtr callbackContext, XUserLocalId userLocalId, XUserChangeEvent changeEvent) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D3")]
	private sealed class <>c__DisplayClass524_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000132")]
		public XUserDefaultAudioEndpointUtf16ChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000546")]
		public <>c__DisplayClass524_0() { }

		[Address(RVA = "0x2B79AD0", Offset = "0x2B78ED0", Length = "0xA4")]
		[Token(Token = "0x6000547")]
		internal void <XUserRegisterForDefaultAudioEndpointUtf16Changed>b__0(IntPtr callbackContext, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D4")]
	private sealed class <>c__DisplayClass525_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000133")]
		public XUserDeviceAssociationChangedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000548")]
		public <>c__DisplayClass525_0() { }

		[Address(RVA = "0x2B79B80", Offset = "0x2B78F80", Length = "0xBE")]
		[Token(Token = "0x6000549")]
		internal void <XUserRegisterForDeviceAssociationChanged>b__0(IntPtr context, ref XUserDeviceAssociationChange change) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D6")]
	private sealed class <>c__DisplayClass61_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000135")]
		public XAppCaptureMetadataPurgedCallback callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600054C")]
		public <>c__DisplayClass61_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x600054D")]
		internal void <XAppCaptureRegisterMetadataPurged>b__0(IntPtr context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D7")]
	private sealed class <>c__DisplayClass73_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000136")]
		public XAsyncWork work; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000137")]
		public XAsyncBlock asyncBlock; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600054E")]
		public <>c__DisplayClass73_0() { }

		[Address(RVA = "0x2B7AAA0", Offset = "0x2B79EA0", Length = "0x29")]
		[Token(Token = "0x600054F")]
		internal int <XAsyncRun>b__0(IntPtr _asyncBlockInterop) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D8")]
	private sealed class <>c__DisplayClass86_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000138")]
		public XGameSaveDeleteContainerCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000550")]
		public <>c__DisplayClass86_0() { }

		[Address(RVA = "0x2B7AAD0", Offset = "0x2B79ED0", Length = "0x74")]
		[Token(Token = "0x6000551")]
		internal void <XGameSaveDeleteContainerAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D9")]
	private sealed class <>c__DisplayClass87_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000139")]
		public XGameSaveGetRemainingQuotaCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000552")]
		public <>c__DisplayClass87_0() { }

		[Address(RVA = "0x2B7AB50", Offset = "0x2B79F50", Length = "0x89")]
		[Token(Token = "0x6000553")]
		internal void <XGameSaveGetRemainingQuotaAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DA")]
	private sealed class <>c__DisplayClass88_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013A")]
		public XGameSaveInitializeProviderCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000554")]
		public <>c__DisplayClass88_0() { }

		[Address(RVA = "0x2B7ABE0", Offset = "0x2B79FE0", Length = "0x89")]
		[Token(Token = "0x6000555")]
		internal void <XGameSaveInitializeProviderAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DB")]
	private sealed class <>c__DisplayClass89_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013B")]
		public XGameSaveReadBlobDataCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000556")]
		public <>c__DisplayClass89_0() { }

		[Address(RVA = "0x2B7AC70", Offset = "0x2B7A070", Length = "0xFD")]
		[Token(Token = "0x6000557")]
		internal void <XGameSaveReadBlobDataAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000146")]
		public HCSocketCompletionResultFunction completionRoutine; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000147")]
		public HCWebsocketHandle websocket; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600056C")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x2B7B4A0", Offset = "0x2B7A8A0", Length = "0x8F")]
		[Token(Token = "0x600056D")]
		internal void <HCWebSocketConnectAsync>b__0(XAsyncBlock block) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DC")]
	private sealed class <>c__DisplayClass90_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013C")]
		public XGameSaveSubmitUpdateCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000558")]
		public <>c__DisplayClass90_0() { }

		[Address(RVA = "0x2B7AE60", Offset = "0x2B7A260", Length = "0x74")]
		[Token(Token = "0x6000559")]
		internal void <XGameSaveSubmitUpdateAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DD")]
	private sealed class <>c__DisplayClass91_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013D")]
		public XGameSaveFilesGetFolderWithUiCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600055A")]
		public <>c__DisplayClass91_0() { }

		[Address(RVA = "0x2B7AEE0", Offset = "0x2B7A2E0", Length = "0x8E")]
		[Token(Token = "0x600055B")]
		internal void <XGameSaveFilesGetFolderWithUiAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DE")]
	private sealed class <>c__DisplayClass92_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013E")]
		public XGameUiShowAchievementsCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600055C")]
		public <>c__DisplayClass92_0() { }

		[Address(RVA = "0x2B7AF70", Offset = "0x2B7A370", Length = "0x74")]
		[Token(Token = "0x600055D")]
		internal void <XGameUiShowAchievementsAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DF")]
	private sealed class <>c__DisplayClass93_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013F")]
		public XGameUiShowErrorDialogCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600055E")]
		public <>c__DisplayClass93_0() { }

		[Address(RVA = "0x2B7AFF0", Offset = "0x2B7A3F0", Length = "0x74")]
		[Token(Token = "0x600055F")]
		internal void <XGameUiShowErrorDialogAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E0")]
	private sealed class <>c__DisplayClass94_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000140")]
		public XGameUiShowMessageDialogCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000560")]
		public <>c__DisplayClass94_0() { }

		[Address(RVA = "0x2B7B070", Offset = "0x2B7A470", Length = "0x88")]
		[Token(Token = "0x6000561")]
		internal void <XGameUiShowMessageDialogAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E1")]
	private sealed class <>c__DisplayClass95_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000141")]
		public XGameUiShowMultiplayerActivityGameInviteCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000562")]
		public <>c__DisplayClass95_0() { }

		[Address(RVA = "0x2B7B100", Offset = "0x2B7A500", Length = "0x74")]
		[Token(Token = "0x6000563")]
		internal void <XGameUiShowMultiplayerActivityGameInviteAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E2")]
	private sealed class <>c__DisplayClass96_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000142")]
		public XGameUiShowPlayerPickerCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000564")]
		public <>c__DisplayClass96_0() { }

		[Address(RVA = "0x2B7B180", Offset = "0x2B7A580", Length = "0x113")]
		[Token(Token = "0x6000565")]
		internal void <XGameUiShowPlayerPickerAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E3")]
	private sealed class <>c__DisplayClass97_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000143")]
		public XGameUiShowPlayerProfileCardCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000566")]
		public <>c__DisplayClass97_0() { }

		[Address(RVA = "0x2B7B2A0", Offset = "0x2B7A6A0", Length = "0x74")]
		[Token(Token = "0x6000567")]
		internal void <XGameUiShowPlayerProfileCardAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E4")]
	private sealed class <>c__DisplayClass98_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000144")]
		public XGameUiShowSendGameInviteCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000568")]
		public <>c__DisplayClass98_0() { }

		[Address(RVA = "0x2B7B320", Offset = "0x2B7A720", Length = "0x74")]
		[Token(Token = "0x6000569")]
		internal void <XGameUiShowSendGameInviteAsync>b__0(XAsyncBlock _async) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E5")]
	private sealed class <>c__DisplayClass99_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000145")]
		public XGameUiShowTextEntryCompleted onCompleted; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600056A")]
		public <>c__DisplayClass99_0() { }

		[Address(RVA = "0x2B7B3A0", Offset = "0x2B7A7A0", Length = "0xFA")]
		[Token(Token = "0x600056B")]
		internal void <XGameUiShowTextEntryAsync>b__0(XAsyncBlock _async) { }

	}

	[Token(Token = "0x200000F")]
	internal class XBL
	{
		[CompilerGenerated]
		[Token(Token = "0x2000030")]
		private sealed class <>c
		{
			[Token(Token = "0x4000040")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000041")]
			public static Func<XblAchievement, XblAchievement> <>9__6_0; //Field offset: 0x8
			[Token(Token = "0x4000042")]
			public static Func<XblAchievement, XblAchievement> <>9__19_0; //Field offset: 0x10
			[Token(Token = "0x4000043")]
			public static Func<XblAchievementsManagerEvent, XblAchievementsManagerEvent> <>9__25_0; //Field offset: 0x18
			[Token(Token = "0x4000044")]
			public static Func<XblLeaderboardResult, XblLeaderboardResult> <>9__56_1; //Field offset: 0x20
			[Token(Token = "0x4000045")]
			public static Func<XblLeaderboardResult, XblLeaderboardResult> <>9__57_1; //Field offset: 0x28
			[Token(Token = "0x4000046")]
			public static Func<XblMatchTicketDetailsResponse, XblMatchTicketDetailsResponse> <>9__64_1; //Field offset: 0x30
			[Token(Token = "0x4000047")]
			public static Func<XblHopperStatisticsResponse, XblHopperStatisticsResponse> <>9__65_1; //Field offset: 0x38
			[Token(Token = "0x4000048")]
			public static Func<XblDeviceToken, XblDeviceToken> <>9__85_0; //Field offset: 0x40
			[Token(Token = "0x4000049")]
			public static Func<XblMultiplayerSessionMember, XblMultiplayerSessionMember> <>9__101_0; //Field offset: 0x48
			[Token(Token = "0x400004A")]
			public static Func<UInt64, UInt64> <>9__122_0; //Field offset: 0x50
			[Token(Token = "0x400004B")]
			public static Func<XblMultiplayerSessionTag, XblMultiplayerSessionTag> <>9__123_0; //Field offset: 0x58
			[Token(Token = "0x400004C")]
			public static Func<XblMultiplayerSessionStringAttribute, XblMultiplayerSessionStringAttribute> <>9__124_0; //Field offset: 0x60
			[Token(Token = "0x400004D")]
			public static Func<XblMultiplayerSessionNumberAttribute, XblMultiplayerSessionNumberAttribute> <>9__125_0; //Field offset: 0x68
			[Token(Token = "0x400004E")]
			public static Converter<XblMultiplayerSessionQueryResult, XblMultiplayerSessionQueryResult> <>9__136_1; //Field offset: 0x70
			[Token(Token = "0x400004F")]
			public static Func<XblMultiplayerSessionTag, XblMultiplayerSessionTag> <>9__140_1; //Field offset: 0x78
			[Token(Token = "0x4000050")]
			public static Func<XblMultiplayerSessionNumberAttribute, XblMultiplayerSessionNumberAttribute> <>9__140_2; //Field offset: 0x80
			[Token(Token = "0x4000051")]
			public static Func<XblMultiplayerSessionStringAttribute, XblMultiplayerSessionStringAttribute> <>9__140_3; //Field offset: 0x88
			[Token(Token = "0x4000052")]
			public static Converter<XblMultiplayerSearchHandle, XblMultiplayerSearchHandle> <>9__142_1; //Field offset: 0x90
			[Token(Token = "0x4000053")]
			public static Converter<XblMultiplayerInviteHandle, XblMultiplayerInviteHandle> <>9__143_1; //Field offset: 0x98
			[Token(Token = "0x4000054")]
			public static Converter<XblMultiplayerActivityDetails, XblMultiplayerActivityDetails> <>9__144_1; //Field offset: 0xA0
			[Token(Token = "0x4000055")]
			public static Func<XblMultiplayerActivityDetails, XblMultiplayerActivityDetails> <>9__145_1; //Field offset: 0xA8
			[Token(Token = "0x4000056")]
			public static Converter<XblMultiplayerActivityDetails, XblMultiplayerActivityDetails> <>9__146_1; //Field offset: 0xB0
			[Token(Token = "0x4000057")]
			public static Func<XblMultiplayerActivityDetails, XblMultiplayerActivityDetails> <>9__147_1; //Field offset: 0xB8
			[Token(Token = "0x4000058")]
			public static Func<XblMultiplayerActivityRecentPlayerUpdate, XblMultiplayerActivityRecentPlayerUpdate> <>9__155_0; //Field offset: 0xC0
			[Token(Token = "0x4000059")]
			public static Func<XblMultiplayerActivityInfo, XblMultiplayerActivityInfo> <>9__158_1; //Field offset: 0xC8
			[Token(Token = "0x400005A")]
			public static Func<XblMultiplayerEvent, XblMultiplayerEvent> <>9__162_0; //Field offset: 0xD0
			[Token(Token = "0x400005B")]
			public static Converter<XblMultiplayerManagerMember, XblMultiplayerManagerMember> <>9__187_0; //Field offset: 0xD8
			[Token(Token = "0x400005C")]
			public static Converter<XblMultiplayerManagerMember, XblMultiplayerManagerMember> <>9__200_0; //Field offset: 0xE0
			[Token(Token = "0x400005D")]
			public static Converter<XblMultiplayerManagerMember, XblMultiplayerManagerMember> <>9__206_0; //Field offset: 0xE8
			[Token(Token = "0x400005E")]
			public static Converter<XblMultiplayerManagerMember, XblMultiplayerManagerMember> <>9__209_0; //Field offset: 0xF0
			[Token(Token = "0x400005F")]
			public static Func<XblPresenceDeviceRecord, XblPresenceDeviceRecord> <>9__222_0; //Field offset: 0xF8
			[Token(Token = "0x4000060")]
			public static Converter<XblPresenceRecordHandle, XblPresenceRecordHandle> <>9__227_1; //Field offset: 0x100
			[Token(Token = "0x4000061")]
			public static Converter<XblPresenceRecordHandle, XblPresenceRecordHandle> <>9__228_1; //Field offset: 0x108
			[Token(Token = "0x4000062")]
			public static Func<XblPermissionCheckResult, XblPermissionCheckResult> <>9__231_1; //Field offset: 0x110
			[Token(Token = "0x4000063")]
			public static Func<XblPermissionCheckResult, XblPermissionCheckResult> <>9__232_1; //Field offset: 0x118
			[Token(Token = "0x4000064")]
			public static Func<XblPermissionCheckResult, XblPermissionCheckResult> <>9__233_1; //Field offset: 0x120
			[Token(Token = "0x4000065")]
			public static Converter<XblUserProfile, XblUserProfile> <>9__235_1; //Field offset: 0x128
			[Token(Token = "0x4000066")]
			public static Converter<XblUserProfile, XblUserProfile> <>9__236_1; //Field offset: 0x130
			[Token(Token = "0x4000067")]
			public static Func<XblSocialRelationship2, XblSocialRelationship> <>9__246_0; //Field offset: 0x138
			[Token(Token = "0x4000068")]
			public static Func<XblSocialRelationship, XblSocialRelationship> <>9__246_1; //Field offset: 0x140
			[Token(Token = "0x4000069")]
			public static Func<XblSocialManagerUser2, XblSocialManagerUser> <>9__257_2; //Field offset: 0x148
			[Token(Token = "0x400006A")]
			public static Func<IntPtr, XblSocialManagerUser> <>9__257_0; //Field offset: 0x150
			[Token(Token = "0x400006B")]
			public static Func<XblSocialManagerUser, XblSocialManagerUser> <>9__257_3; //Field offset: 0x158
			[Token(Token = "0x400006C")]
			public static Func<IntPtr, XblSocialManagerUser> <>9__257_1; //Field offset: 0x160
			[Token(Token = "0x400006D")]
			public static Func<UInt64, UInt64> <>9__258_0; //Field offset: 0x168
			[Token(Token = "0x400006E")]
			public static Func<XblSocialManagerEvent, XblSocialManagerEvent> <>9__261_0; //Field offset: 0x170
			[Token(Token = "0x400006F")]
			public static Converter<IntPtr, XUserHandle> <>9__265_0; //Field offset: 0x178
			[Token(Token = "0x4000070")]
			public static Func<XblVerifyStringResult, XblVerifyStringResult> <>9__271_1; //Field offset: 0x180
			[Token(Token = "0x4000071")]
			public static Func<XblVerifyStringResult, XblVerifyStringResult> <>9__272_1; //Field offset: 0x188
			[Token(Token = "0x4000072")]
			public static Func<XblTitleStorageBlobMetadata, XblTitleStorageBlobMetadata> <>9__276_0; //Field offset: 0x190
			[Token(Token = "0x4000073")]
			public static Func<XblUserStatisticsResultInternal, XblUserStatisticsResult> <>9__287_1; //Field offset: 0x198
			[Token(Token = "0x4000074")]
			public static Func<XblUserStatisticsResultInternal, XblUserStatisticsResult> <>9__288_1; //Field offset: 0x1A0
			[Token(Token = "0x4000075")]
			public static Func<XblUserStatisticsResultInternal, XblUserStatisticsResult> <>9__289_1; //Field offset: 0x1A8
			[Token(Token = "0x4000076")]
			public static Func<XblUserStatisticsResultInternal, XblUserStatisticsResult> <>9__290_1; //Field offset: 0x1B0
			[Token(Token = "0x4000077")]
			public static Func<XblRequestedStatistics, DisposableCollection, XblRequestedStatisticsInternal> <>9__290_2; //Field offset: 0x1B8

			[Address(RVA = "0x2B7B690", Offset = "0x2B7AA90", Length = "0x67")]
			[Token(Token = "0x60003C3")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003C4")]
			public <>c() { }

			[Address(RVA = "0x2B6F030", Offset = "0x2B6E430", Length = "0xEE")]
			[Token(Token = "0x60003C7")]
			internal XblAchievementsManagerEvent <XblAchievementsManagerDoWork>b__25_0(XblAchievementsManagerEvent x) { }

			[Address(RVA = "0x2B6F120", Offset = "0x2B6E520", Length = "0xDF")]
			[Token(Token = "0x60003C6")]
			internal XblAchievement <XblAchievementsManagerResultGetAchievements>b__19_0(XblAchievement x) { }

			[Address(RVA = "0x2B6F200", Offset = "0x2B6E600", Length = "0xDF")]
			[Token(Token = "0x60003C5")]
			internal XblAchievement <XblAchievementsResultGetAchievements>b__6_0(XblAchievement a) { }

			[Address(RVA = "0x2B6F2E0", Offset = "0x2B6E6E0", Length = "0xCC")]
			[Token(Token = "0x60003C8")]
			internal XblLeaderboardResult <XblLeaderboardGetLeaderboardAsync>b__56_1(XblLeaderboardResult r) { }

			[Address(RVA = "0x2B6F3B0", Offset = "0x2B6E7B0", Length = "0xCC")]
			[Token(Token = "0x60003C9")]
			internal XblLeaderboardResult <XblLeaderboardResultGetNextAsync>b__57_1(XblLeaderboardResult r) { }

			[Address(RVA = "0x2B6F480", Offset = "0x2B6E880", Length = "0x69")]
			[Token(Token = "0x60003CB")]
			internal XblHopperStatisticsResponse <XblMatchmakingGetHopperStatisticsAsync>b__65_1(XblHopperStatisticsResponse r) { }

			[Address(RVA = "0x2B6F4F0", Offset = "0x2B6E8F0", Length = "0xC7")]
			[Token(Token = "0x60003CA")]
			internal XblMatchTicketDetailsResponse <XblMatchmakingGetMatchTicketDetailsAsync>b__64_1(XblMatchTicketDetailsResponse r) { }

			[Address(RVA = "0x2B6F5C0", Offset = "0x2B6E9C0", Length = "0x7B")]
			[Token(Token = "0x60003DD")]
			internal XblMultiplayerActivityInfo <XblMultiplayerActivityGetActivityAsync>b__158_1(XblMultiplayerActivityInfo r) { }

			[Address(RVA = "0x2B6F640", Offset = "0x2B6EA40", Length = "0x23")]
			[Token(Token = "0x60003DC")]
			internal XblMultiplayerActivityRecentPlayerUpdate <XblMultiplayerActivityUpdateRecentPlayers>b__155_0(XblMultiplayerActivityRecentPlayerUpdate r) { }

			[Address(RVA = "0x2B6F670", Offset = "0x2B6EA70", Length = "0x3F")]
			[Token(Token = "0x60003D3")]
			internal XblMultiplayerSessionTag <XblMultiplayerCreateSearchHandleAsync>b__140_1(XblMultiplayerSessionTag r) { }

			[Address(RVA = "0x2B6F6B0", Offset = "0x2B6EAB0", Length = "0x3B")]
			[Token(Token = "0x60003D4")]
			internal XblMultiplayerSessionNumberAttribute <XblMultiplayerCreateSearchHandleAsync>b__140_2(XblMultiplayerSessionNumberAttribute r) { }

			[Address(RVA = "0x2B6F6F0", Offset = "0x2B6EAF0", Length = "0x39")]
			[Token(Token = "0x60003D5")]
			internal XblMultiplayerSessionStringAttribute <XblMultiplayerCreateSearchHandleAsync>b__140_3(XblMultiplayerSessionStringAttribute r) { }

			[Address(RVA = "0x2B6F730", Offset = "0x2B6EB30", Length = "0x87")]
			[Token(Token = "0x60003DF")]
			internal XblMultiplayerManagerMember <XblMultiplayerEventArgsMembers>b__187_0(XblMultiplayerManagerMember x) { }

			[Address(RVA = "0x2B6F7C0", Offset = "0x2B6EBC0", Length = "0xD5")]
			[Token(Token = "0x60003D8")]
			internal XblMultiplayerActivityDetails <XblMultiplayerGetActivitiesForSocialGroupAsync>b__144_1(XblMultiplayerActivityDetails h) { }

			[Address(RVA = "0x2B6F8A0", Offset = "0x2B6ECA0", Length = "0xD5")]
			[Token(Token = "0x60003DA")]
			internal XblMultiplayerActivityDetails <XblMultiplayerGetActivitiesForUsersAsync>b__146_1(XblMultiplayerActivityDetails h) { }

			[Address(RVA = "0x2B6F980", Offset = "0x2B6ED80", Length = "0xD5")]
			[Token(Token = "0x60003D9")]
			internal XblMultiplayerActivityDetails <XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync>b__145_1(XblMultiplayerActivityDetails r) { }

			[Address(RVA = "0x2B6FA60", Offset = "0x2B6EE60", Length = "0xD5")]
			[Token(Token = "0x60003DB")]
			internal XblMultiplayerActivityDetails <XblMultiplayerGetActivitiesWithPropertiesForUsersAsync>b__147_1(XblMultiplayerActivityDetails r) { }

			[Address(RVA = "0x2B6FB40", Offset = "0x2B6EF40", Length = "0x54")]
			[Token(Token = "0x60003D6")]
			internal XblMultiplayerSearchHandle <XblMultiplayerGetSearchHandlesAsync>b__142_1(XblMultiplayerSearchHandle h) { }

			[Address(RVA = "0x2B6FBA0", Offset = "0x2B6EFA0", Length = "0x70")]
			[Token(Token = "0x60003DE")]
			internal XblMultiplayerEvent <XblMultiplayerManagerDoWork>b__162_0(XblMultiplayerEvent x) { }

			[Address(RVA = "0x2B6FC10", Offset = "0x2B6F010", Length = "0x87")]
			[Token(Token = "0x60003E0")]
			internal XblMultiplayerManagerMember <XblMultiplayerManagerGameSessionMembers>b__200_0(XblMultiplayerManagerMember x) { }

			[Address(RVA = "0x2B6FCA0", Offset = "0x2B6F0A0", Length = "0x87")]
			[Token(Token = "0x60003E2")]
			internal XblMultiplayerManagerMember <XblMultiplayerManagerLobbySessionLocalMembers>b__209_0(XblMultiplayerManagerMember x) { }

			[Address(RVA = "0x2B6FD30", Offset = "0x2B6F130", Length = "0x87")]
			[Token(Token = "0x60003E1")]
			internal XblMultiplayerManagerMember <XblMultiplayerManagerLobbySessionMembers>b__206_0(XblMultiplayerManagerMember x) { }

			[Address(RVA = "0x2B6FDC0", Offset = "0x2B6F1C0", Length = "0xD5")]
			[Token(Token = "0x60003D2")]
			internal XblMultiplayerSessionQueryResult <XblMultiplayerQuerySessionsAsync>b__136_1(XblMultiplayerSessionQueryResult h) { }

			[Address(RVA = "0x2B6FEA0", Offset = "0x2B6F2A0", Length = "0xA0")]
			[Token(Token = "0x60003D1")]
			internal XblMultiplayerSessionNumberAttribute <XblMultiplayerSearchHandleGetNumberAttributes>b__125_0(XblMultiplayerSessionNumberAttribute x) { }

			[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
			[Token(Token = "0x60003CE")]
			internal ulong <XblMultiplayerSearchHandleGetSessionOwnerXuids>b__122_0(ulong x) { }

			[Address(RVA = "0x2B6FF40", Offset = "0x2B6F340", Length = "0xDF")]
			[Token(Token = "0x60003D0")]
			internal XblMultiplayerSessionStringAttribute <XblMultiplayerSearchHandleGetStringAttributes>b__124_0(XblMultiplayerSessionStringAttribute x) { }

			[Address(RVA = "0x2B70020", Offset = "0x2B6F420", Length = "0x9E")]
			[Token(Token = "0x60003CF")]
			internal XblMultiplayerSessionTag <XblMultiplayerSearchHandleGetTags>b__123_0(XblMultiplayerSessionTag x) { }

			[Address(RVA = "0x2B700C0", Offset = "0x2B6F4C0", Length = "0x72")]
			[Token(Token = "0x60003D7")]
			internal XblMultiplayerInviteHandle <XblMultiplayerSendInvitesAsync>b__143_1(XblMultiplayerInviteHandle h) { }

			[Address(RVA = "0x2B70140", Offset = "0x2B6F540", Length = "0x72")]
			[Token(Token = "0x60003CC")]
			internal XblDeviceToken <XblMultiplayerSessionHostCandidates>b__85_0(XblDeviceToken x) { }

			[Address(RVA = "0x2B701C0", Offset = "0x2B6F5C0", Length = "0xCD")]
			[Token(Token = "0x60003CD")]
			internal XblMultiplayerSessionMember <XblMultiplayerSessionMembers>b__101_0(XblMultiplayerSessionMember x) { }

			[Address(RVA = "0x2B70290", Offset = "0x2B6F690", Length = "0x54")]
			[Token(Token = "0x60003E4")]
			internal XblPresenceRecordHandle <XblPresenceGetPresenceForMultipleUsersAsync>b__227_1(XblPresenceRecordHandle h) { }

			[Address(RVA = "0x2B702F0", Offset = "0x2B6F6F0", Length = "0x54")]
			[Token(Token = "0x60003E5")]
			internal XblPresenceRecordHandle <XblPresenceGetPresenceForSocialGroupAsync>b__228_1(XblPresenceRecordHandle h) { }

			[Address(RVA = "0x2B70350", Offset = "0x2B6F750", Length = "0x69")]
			[Token(Token = "0x60003E3")]
			internal XblPresenceDeviceRecord <XblPresenceRecordGetDeviceRecords>b__222_0(XblPresenceDeviceRecord dr) { }

			[Address(RVA = "0x2B703C0", Offset = "0x2B6F7C0", Length = "0x72")]
			[Token(Token = "0x60003E8")]
			internal XblPermissionCheckResult <XblPrivacyBatchCheckPermissionAsync>b__233_1(XblPermissionCheckResult r) { }

			[Address(RVA = "0x2B70440", Offset = "0x2B6F840", Length = "0x72")]
			[Token(Token = "0x60003E6")]
			internal XblPermissionCheckResult <XblPrivacyCheckPermissionAsync>b__231_1(XblPermissionCheckResult r) { }

			[Address(RVA = "0x2B704C0", Offset = "0x2B6F8C0", Length = "0x72")]
			[Token(Token = "0x60003E7")]
			internal XblPermissionCheckResult <XblPrivacyCheckPermissionForAnonymousUserAsync>b__232_1(XblPermissionCheckResult r) { }

			[Address(RVA = "0x2B70540", Offset = "0x2B6F940", Length = "0x85")]
			[Token(Token = "0x60003E9")]
			internal XblUserProfile <XblProfileGetUserProfilesAsync>b__235_1(XblUserProfile x) { }

			[Address(RVA = "0x2B705D0", Offset = "0x2B6F9D0", Length = "0x85")]
			[Token(Token = "0x60003EA")]
			internal XblUserProfile <XblProfileGetUserProfilesForSocialGroupAsync>b__236_1(XblUserProfile x) { }

			[Address(RVA = "0x2B70660", Offset = "0x2B6FA60", Length = "0x67")]
			[Token(Token = "0x60003F2")]
			internal XblSocialManagerEvent <XblSocialManagerDoWork>b__261_0(XblSocialManagerEvent e) { }

			[Address(RVA = "0x2B706D0", Offset = "0x2B6FAD0", Length = "0x57")]
			[Token(Token = "0x60003F3")]
			internal XUserHandle <XblSocialManagerGetLocalUsers>b__265_0(IntPtr u) { }

			[Address(RVA = "0x2B70730", Offset = "0x2B6FB30", Length = "0x116")]
			[Token(Token = "0x60003ED")]
			internal XblSocialManagerUser <XblSocialManagerUserGroupGetUsers>b__257_0(IntPtr intPtr) { }

			[Address(RVA = "0x2B70850", Offset = "0x2B6FC50", Length = "0x116")]
			[Token(Token = "0x60003EF")]
			internal XblSocialManagerUser <XblSocialManagerUserGroupGetUsers>b__257_1(IntPtr intPtr) { }

			[Address(RVA = "0x2B70970", Offset = "0x2B6FD70", Length = "0xCC")]
			[Token(Token = "0x60003EE")]
			internal XblSocialManagerUser <XblSocialManagerUserGroupGetUsers>b__257_2(XblSocialManagerUser2 u) { }

			[Address(RVA = "0x2B70A40", Offset = "0x2B6FE40", Length = "0xCC")]
			[Token(Token = "0x60003F0")]
			internal XblSocialManagerUser <XblSocialManagerUserGroupGetUsers>b__257_3(XblSocialManagerUser u) { }

			[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
			[Token(Token = "0x60003F1")]
			internal ulong <XblSocialManagerUserGroupGetUsersTrackedByGroup>b__258_0(ulong x) { }

			[Address(RVA = "0x2B70B10", Offset = "0x2B6FF10", Length = "0x67")]
			[Token(Token = "0x60003EB")]
			internal XblSocialRelationship <XblSocialRelationshipResultGetRelationships>b__246_0(XblSocialRelationship2 c) { }

			[Address(RVA = "0x2B70B80", Offset = "0x2B6FF80", Length = "0x67")]
			[Token(Token = "0x60003EC")]
			internal XblSocialRelationship <XblSocialRelationshipResultGetRelationships>b__246_1(XblSocialRelationship c) { }

			[Address(RVA = "0x2B70BF0", Offset = "0x2B6FFF0", Length = "0x5E")]
			[Token(Token = "0x60003F4")]
			internal XblVerifyStringResult <XblStringVerifyStringAsync>b__271_1(XblVerifyStringResult r) { }

			[Address(RVA = "0x2B70C50", Offset = "0x2B70050", Length = "0x5E")]
			[Token(Token = "0x60003F5")]
			internal XblVerifyStringResult <XblStringVerifyStringsAsync>b__272_1(XblVerifyStringResult r) { }

			[Address(RVA = "0x2B70CB0", Offset = "0x2B700B0", Length = "0x79")]
			[Token(Token = "0x60003F6")]
			internal XblTitleStorageBlobMetadata <XblTitleStorageBlobMetadataResultGetItems>b__276_0(XblTitleStorageBlobMetadata i) { }

			[Address(RVA = "0x2B70D30", Offset = "0x2B70130", Length = "0x69")]
			[Token(Token = "0x60003F9")]
			internal XblUserStatisticsResult <XblUserStatisticsGetMultipleUserStatisticsAsync>b__289_1(XblUserStatisticsResultInternal r) { }

			[Address(RVA = "0x2B70DA0", Offset = "0x2B701A0", Length = "0x69")]
			[Token(Token = "0x60003FA")]
			internal XblUserStatisticsResult <XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync>b__290_1(XblUserStatisticsResultInternal r) { }

			[Address(RVA = "0x2B70E10", Offset = "0x2B70210", Length = "0x32")]
			[Token(Token = "0x60003FB")]
			internal XblRequestedStatisticsInternal <XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync>b__290_2(XblRequestedStatistics request, DisposableCollection disposables) { }

			[Address(RVA = "0x2B70E50", Offset = "0x2B70250", Length = "0x69")]
			[Token(Token = "0x60003F7")]
			internal XblUserStatisticsResult <XblUserStatisticsGetSingleUserStatisticAsync>b__287_1(XblUserStatisticsResultInternal r) { }

			[Address(RVA = "0x2B70EC0", Offset = "0x2B702C0", Length = "0x69")]
			[Token(Token = "0x60003F8")]
			internal XblUserStatisticsResult <XblUserStatisticsGetSingleUserStatisticsAsync>b__288_1(XblUserStatisticsResultInternal r) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000032")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000079")]
			public XblAchievementsUpdateAchievementResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003FE")]
			public <>c__DisplayClass10_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x60003FF")]
			internal void <XblAchievementsUpdateAchievementAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000031")]
		private sealed class <>c__DisplayClass104_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000078")]
			public DisposableCollection disposableCollection; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003FC")]
			public <>c__DisplayClass104_0() { }

			[Address(RVA = "0x2B71970", Offset = "0x2B70D70", Length = "0x2A")]
			[Token(Token = "0x60003FD")]
			internal XblMultiplayerSessionMemberRole <XblMultiplayerSessionCurrentUserSetRoles>b__0(XblMultiplayerSessionMemberRole role, DisposableCollection collection) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000033")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007A")]
			public XblAchievementsUpdateAchievementForTitleIdResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000400")]
			public <>c__DisplayClass11_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x6000401")]
			internal void <XblAchievementsUpdateAchievementAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000034")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007B")]
			public XblAchievementsUpdateAchievementForTitleIdResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000402")]
			public <>c__DisplayClass12_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x6000403")]
			internal void <XblAchievementsUpdateAchievementForTitleIdAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003D")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000084")]
			public XblAchievementsGetAchievementResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000414")]
			public <>c__DisplayClass13_0() { }

			[Address(RVA = "0x2B73620", Offset = "0x2B72A20", Length = "0xE6")]
			[Token(Token = "0x6000415")]
			internal void <XblAchievementsGetAchievementAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000035")]
		private sealed class <>c__DisplayClass132_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007C")]
			public XblMultiplayerWriteSessionHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000404")]
			public <>c__DisplayClass132_0() { }

			[Address(RVA = "0x2B727B0", Offset = "0x2B71BB0", Length = "0xDB")]
			[Token(Token = "0x6000405")]
			internal void <XblMultiplayerWriteSessionAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000036")]
		private sealed class <>c__DisplayClass133_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007D")]
			public XblMultiplayerWriteSessionHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000406")]
			public <>c__DisplayClass133_0() { }

			[Address(RVA = "0x2B72A40", Offset = "0x2B71E40", Length = "0xDB")]
			[Token(Token = "0x6000407")]
			internal void <XblMultiplayerWriteSessionByHandleAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000037")]
		private sealed class <>c__DisplayClass134_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007E")]
			public XblMultiplayerGetSessionHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000408")]
			public <>c__DisplayClass134_0() { }

			[Address(RVA = "0x2B72C30", Offset = "0x2B72030", Length = "0xDB")]
			[Token(Token = "0x6000409")]
			internal void <XblMultiplayerGetSessionAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000038")]
		private sealed class <>c__DisplayClass135_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400007F")]
			public XblMultiplayerGetSessionHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600040A")]
			public <>c__DisplayClass135_0() { }

			[Address(RVA = "0x2B72DA0", Offset = "0x2B721A0", Length = "0xDB")]
			[Token(Token = "0x600040B")]
			internal void <XblMultiplayerGetSessionByHandleAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000039")]
		private sealed class <>c__DisplayClass136_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000080")]
			public XblMultiplayerSessionQueryHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600040C")]
			public <>c__DisplayClass136_0() { }

			[Address(RVA = "0x2B72F80", Offset = "0x2B72380", Length = "0x200")]
			[Token(Token = "0x600040D")]
			internal void <XblMultiplayerQuerySessionsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003A")]
		private sealed class <>c__DisplayClass137_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000081")]
			public XblMultiplayerSetActivityHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600040E")]
			public <>c__DisplayClass137_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x600040F")]
			internal void <XblMultiplayerSetActivityAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003B")]
		private sealed class <>c__DisplayClass138_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000082")]
			public XblMultiplayerClearActivityHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000410")]
			public <>c__DisplayClass138_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000411")]
			internal void <XblMultiplayerClearActivityAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003C")]
		private sealed class <>c__DisplayClass139_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000083")]
			public XblMultiplayerSetTransferHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000412")]
			public <>c__DisplayClass139_0() { }

			[Address(RVA = "0x2B73540", Offset = "0x2B72940", Length = "0xDB")]
			[Token(Token = "0x6000413")]
			internal void <XblMultiplayerSetTransferHandleAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000046")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000090")]
			public XblAchievementsProgressChangeHandlerResult handler; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000426")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0x2B74B60", Offset = "0x2B73F60", Length = "0x1A5")]
			[Token(Token = "0x6000427")]
			internal void <XblAchievementsAddAchievementProgressChangeHandler>b__0(XblAchievementProgressChangeEventArgs eventArgsInterop, IntPtr context) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003E")]
		private sealed class <>c__DisplayClass140_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000085")]
			public XblMultiplayerCreateSearchHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000416")]
			public <>c__DisplayClass140_0() { }

			[Address(RVA = "0x2B738C0", Offset = "0x2B72CC0", Length = "0xDB")]
			[Token(Token = "0x6000417")]
			internal void <XblMultiplayerCreateSearchHandleAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003F")]
		private sealed class <>c__DisplayClass141_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000086")]
			public XblMultiplayerDeleteSearchHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000418")]
			public <>c__DisplayClass141_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000419")]
			internal void <XblMultiplayerDeleteSearchHandleAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000040")]
		private sealed class <>c__DisplayClass142_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000087")]
			public XblMultiplayerGetSearchHandlesResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600041A")]
			public <>c__DisplayClass142_0() { }

			[Address(RVA = "0x2B739A0", Offset = "0x2B72DA0", Length = "0x22D")]
			[Token(Token = "0x600041B")]
			internal void <XblMultiplayerGetSearchHandlesAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000041")]
		private sealed class <>c__DisplayClass143_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000088")]
			public SizeT xuidsCount; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000089")]
			public XblMultiplayerSendInvitesResult completionRoutine; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600041C")]
			public <>c__DisplayClass143_0() { }

			[Address(RVA = "0x2B73BD0", Offset = "0x2B72FD0", Length = "0x1C4")]
			[Token(Token = "0x600041D")]
			internal void <XblMultiplayerSendInvitesAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000042")]
		private sealed class <>c__DisplayClass144_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400008A")]
			public XblMultiplayerGetActivitiesResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600041E")]
			public <>c__DisplayClass144_0() { }

			[Address(RVA = "0x2B73DA0", Offset = "0x2B731A0", Length = "0x22D")]
			[Token(Token = "0x600041F")]
			internal void <XblMultiplayerGetActivitiesForSocialGroupAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000043")]
		private sealed class <>c__DisplayClass145_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400008B")]
			public int hr; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400008C")]
			public XblMultiplayerGetActivitiesResult completionRoutine; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000420")]
			public <>c__DisplayClass145_0() { }

			[Address(RVA = "0x2B74060", Offset = "0x2B73460", Length = "0x360")]
			[Token(Token = "0x6000421")]
			internal void <XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000044")]
		private sealed class <>c__DisplayClass146_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400008D")]
			public XblMultiplayerGetActivitiesResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000422")]
			public <>c__DisplayClass146_0() { }

			[Address(RVA = "0x2B74450", Offset = "0x2B73850", Length = "0x22D")]
			[Token(Token = "0x6000423")]
			internal void <XblMultiplayerGetActivitiesForUsersAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000045")]
		private sealed class <>c__DisplayClass147_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400008E")]
			public int hr; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400008F")]
			public XblMultiplayerGetActivitiesResult completionRoutine; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000424")]
			public <>c__DisplayClass147_0() { }

			[Address(RVA = "0x2B74700", Offset = "0x2B73B00", Length = "0x349")]
			[Token(Token = "0x6000425")]
			internal void <XblMultiplayerGetActivitiesWithPropertiesForUsersAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000047")]
		private sealed class <>c__DisplayClass156_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000091")]
			public XblMultiplayerActivityAsyncOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000428")]
			public <>c__DisplayClass156_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000429")]
			internal void <XblMultiplayerActivityFlushRecentPlayersAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000048")]
		private sealed class <>c__DisplayClass157_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000092")]
			public XblMultiplayerActivityAsyncOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600042A")]
			public <>c__DisplayClass157_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x600042B")]
			internal void <XblMultiplayerActivitySetActivityAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000049")]
		private sealed class <>c__DisplayClass158_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000093")]
			public int hr; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000094")]
			public XblMultiplayerGetActivityAsyncOperationCompleted completionRoutine; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600042C")]
			public <>c__DisplayClass158_0() { }

			[Address(RVA = "0x2B752E0", Offset = "0x2B746E0", Length = "0x329")]
			[Token(Token = "0x600042D")]
			internal void <XblMultiplayerActivityGetActivityAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004A")]
		private sealed class <>c__DisplayClass159_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000095")]
			public XblMultiplayerActivityAsyncOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600042E")]
			public <>c__DisplayClass159_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x600042F")]
			internal void <XblMultiplayerActivityDeleteActivityAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004B")]
		private sealed class <>c__DisplayClass160_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000096")]
			public XblMultiplayerActivityAsyncOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000430")]
			public <>c__DisplayClass160_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000431")]
			internal void <XblMultiplayerActivitySendInvitesAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004C")]
		private sealed class <>c__DisplayClass166_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000097")]
			public XblMultiplayerJoinability joinability; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000432")]
			public <>c__DisplayClass166_0() { }

			[Address(RVA = "0x2B756D0", Offset = "0x2B74AD0", Length = "0xB")]
			[Token(Token = "0x6000433")]
			internal int <XblMultiplayerManagerSetJoinability>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004D")]
		private sealed class <>c__DisplayClass195_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000098")]
			public string name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000099")]
			public string valueJson; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000434")]
			public <>c__DisplayClass195_0() { }

			[Address(RVA = "0x2B75CB0", Offset = "0x2B750B0", Length = "0x4E")]
			[Token(Token = "0x6000435")]
			internal int <XblMultiplayerManagerGameSessionSetProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004E")]
		private sealed class <>c__DisplayClass196_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400009A")]
			public string deviceToken; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000436")]
			public <>c__DisplayClass196_0() { }

			[Address(RVA = "0x2B75D00", Offset = "0x2B75100", Length = "0x27")]
			[Token(Token = "0x6000437")]
			internal int <XblMultiplayerManagerGameSessionSetSynchronizedHost>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200004F")]
		private sealed class <>c__DisplayClass197_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400009B")]
			public string name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400009C")]
			public string valueJson; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000438")]
			public <>c__DisplayClass197_0() { }

			[Address(RVA = "0x2B75D30", Offset = "0x2B75130", Length = "0x4E")]
			[Token(Token = "0x6000439")]
			internal int <XblMultiplayerManagerGameSessionSetSynchronizedProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000050")]
		private sealed class <>c__DisplayClass214_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400009D")]
			public string deviceToken; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600043A")]
			public <>c__DisplayClass214_0() { }

			[Address(RVA = "0x2B75D80", Offset = "0x2B75180", Length = "0x27")]
			[Token(Token = "0x600043B")]
			internal int <XblMultiplayerManagerLobbySessionSetSynchronizedHost>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000051")]
		private sealed class <>c__DisplayClass215_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400009E")]
			public string name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400009F")]
			public string valueJson; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600043C")]
			public <>c__DisplayClass215_0() { }

			[Address(RVA = "0x2B75DB0", Offset = "0x2B751B0", Length = "0x4E")]
			[Token(Token = "0x600043D")]
			internal int <XblMultiplayerManagerLobbySessionSetProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000052")]
		private sealed class <>c__DisplayClass216_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000A0")]
			public XUserHandle user; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000A1")]
			public string name; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000A2")]
			public string valueJson; //Field offset: 0x20

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600043E")]
			public <>c__DisplayClass216_0() { }

			[Address(RVA = "0x2B75E00", Offset = "0x2B75200", Length = "0x74")]
			[Token(Token = "0x600043F")]
			internal int <XblMultiplayerManagerLobbySessionSetLocalMemberProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000053")]
		private sealed class <>c__DisplayClass217_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000A3")]
			public string name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000A4")]
			public string valueJson; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000440")]
			public <>c__DisplayClass217_0() { }

			[Address(RVA = "0x2B75E80", Offset = "0x2B75280", Length = "0x4E")]
			[Token(Token = "0x6000441")]
			internal int <XblMultiplayerManagerLobbySessionSetSynchronizedProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000054")]
		private sealed class <>c__DisplayClass218_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000A5")]
			public XUserHandle user; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000A6")]
			public string connectionAddress; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000442")]
			public <>c__DisplayClass218_0() { }

			[Address(RVA = "0x2B75ED0", Offset = "0x2B752D0", Length = "0x45")]
			[Token(Token = "0x6000443")]
			internal int <XblMultiplayerManagerLobbySessionSetLocalMemberConnectionAddress>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000055")]
		private sealed class <>c__DisplayClass219_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000A7")]
			public XUserHandle user; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000A8")]
			public string name; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000444")]
			public <>c__DisplayClass219_0() { }

			[Address(RVA = "0x2B75F20", Offset = "0x2B75320", Length = "0x45")]
			[Token(Token = "0x6000445")]
			internal int <XblMultiplayerManagerLobbySessionDeleteLocalMemberProperties>b__0(IntPtr ctx) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000056")]
		private sealed class <>c__DisplayClass225_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000A9")]
			public XblPresenceSetPresenceCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000446")]
			public <>c__DisplayClass225_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000447")]
			internal void <XblPresenceSetPresenceAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000057")]
		private sealed class <>c__DisplayClass226_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AA")]
			public XblPresenceGetPresenceCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000448")]
			public <>c__DisplayClass226_0() { }

			[Address(RVA = "0x2B760D0", Offset = "0x2B754D0", Length = "0x7B")]
			[Token(Token = "0x6000449")]
			internal void <XblPresenceGetPresenceAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000058")]
		private sealed class <>c__DisplayClass227_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AB")]
			public XblPresenceGetPresenceForMultipleUsersCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600044A")]
			public <>c__DisplayClass227_0() { }

			[Address(RVA = "0x2B76200", Offset = "0x2B75600", Length = "0x206")]
			[Token(Token = "0x600044B")]
			internal void <XblPresenceGetPresenceForMultipleUsersAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000059")]
		private sealed class <>c__DisplayClass228_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AC")]
			public XblPresenceGetPresenceForSocialGroupCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600044C")]
			public <>c__DisplayClass228_0() { }

			[Address(RVA = "0x2B76410", Offset = "0x2B75810", Length = "0x206")]
			[Token(Token = "0x600044D")]
			internal void <XblPresenceGetPresenceForSocialGroupAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005A")]
		private sealed class <>c__DisplayClass229_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AD")]
			public XblPrivacyGetAvoidListCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600044E")]
			public <>c__DisplayClass229_0() { }

			[Address(RVA = "0x2B76620", Offset = "0x2B75A20", Length = "0xFB")]
			[Token(Token = "0x600044F")]
			internal void <XblPrivacyGetAvoidListAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005B")]
		private sealed class <>c__DisplayClass230_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AE")]
			public XblPrivacyGetMuteListCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000450")]
			public <>c__DisplayClass230_0() { }

			[Address(RVA = "0x2B76720", Offset = "0x2B75B20", Length = "0xFB")]
			[Token(Token = "0x6000451")]
			internal void <XblPrivacyGetMuteListAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005C")]
		private sealed class <>c__DisplayClass231_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000AF")]
			public XblPrivacyCheckPermissionCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000452")]
			public <>c__DisplayClass231_0() { }

			[Address(RVA = "0x2B76820", Offset = "0x2B75C20", Length = "0x303")]
			[Token(Token = "0x6000453")]
			internal void <XblPrivacyCheckPermissionAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005D")]
		private sealed class <>c__DisplayClass232_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B0")]
			public XblPrivacyCheckPermissionCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000454")]
			public <>c__DisplayClass232_0() { }

			[Address(RVA = "0x2B76BD0", Offset = "0x2B75FD0", Length = "0x303")]
			[Token(Token = "0x6000455")]
			internal void <XblPrivacyCheckPermissionForAnonymousUserAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005E")]
		private sealed class <>c__DisplayClass233_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B1")]
			public XblPrivacyBatchCheckPermissionCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000456")]
			public <>c__DisplayClass233_0() { }

			[Address(RVA = "0x2B76F80", Offset = "0x2B76380", Length = "0x31A")]
			[Token(Token = "0x6000457")]
			internal void <XblPrivacyBatchCheckPermissionAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005F")]
		private sealed class <>c__DisplayClass234_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B2")]
			public XblProfileGetUserProfileCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000458")]
			public <>c__DisplayClass234_0() { }

			[Address(RVA = "0x2B772A0", Offset = "0x2B766A0", Length = "0x172")]
			[Token(Token = "0x6000459")]
			internal void <XblProfileGetUserProfileAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000060")]
		private sealed class <>c__DisplayClass235_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B3")]
			public XblProfileGetUserProfilesCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600045A")]
			public <>c__DisplayClass235_0() { }

			[Address(RVA = "0x2B77420", Offset = "0x2B76820", Length = "0x206")]
			[Token(Token = "0x600045B")]
			internal void <XblProfileGetUserProfilesAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000061")]
		private sealed class <>c__DisplayClass236_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B4")]
			public XblProfileGetUserProfilesForSocialGroupCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600045C")]
			public <>c__DisplayClass236_0() { }

			[Address(RVA = "0x2B77630", Offset = "0x2B76A30", Length = "0x206")]
			[Token(Token = "0x600045D")]
			internal void <XblProfileGetUserProfilesForSocialGroupAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000062")]
		private sealed class <>c__DisplayClass245_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B5")]
			public XblSocialGetSocialRelationshipsResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600045E")]
			public <>c__DisplayClass245_0() { }

			[Address(RVA = "0x2B77840", Offset = "0x2B76C40", Length = "0xDB")]
			[Token(Token = "0x600045F")]
			internal void <XblSocialGetSocialRelationshipsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000063")]
		private sealed class <>c__DisplayClass249_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B6")]
			public XblSocialRelationshipResultGetNextResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000460")]
			public <>c__DisplayClass249_0() { }

			[Address(RVA = "0x2B77920", Offset = "0x2B76D20", Length = "0xDB")]
			[Token(Token = "0x6000461")]
			internal void <XblSocialRelationshipResultGetNextAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000064")]
		private sealed class <>c__DisplayClass271_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B7")]
			public XblStringVerifyStringCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000462")]
			public <>c__DisplayClass271_0() { }

			[Address(RVA = "0x2B77B50", Offset = "0x2B76F50", Length = "0x303")]
			[Token(Token = "0x6000463")]
			internal void <XblStringVerifyStringAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000065")]
		private sealed class <>c__DisplayClass272_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B8")]
			public XblStringVerifyStringsCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000464")]
			public <>c__DisplayClass272_0() { }

			[Address(RVA = "0x2B77E60", Offset = "0x2B77260", Length = "0x31A")]
			[Token(Token = "0x6000465")]
			internal void <XblStringVerifyStringsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000066")]
		private sealed class <>c__DisplayClass273_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000B9")]
			public XblTitleManagedStatsOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000466")]
			public <>c__DisplayClass273_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x6000467")]
			internal void <XblTitleManagedStatsWriteAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000067")]
		private sealed class <>c__DisplayClass273_1
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BA")]
			public DisposableCollection disposableCollection; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000468")]
			public <>c__DisplayClass273_1() { }

			[Address(RVA = "0x2B78180", Offset = "0x2B77580", Length = "0x2E")]
			[Token(Token = "0x6000469")]
			internal XblTitleManagedStatistic <XblTitleManagedStatsWriteAsync>b__1(XblTitleManagedStatistic s) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000068")]
		private sealed class <>c__DisplayClass274_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BB")]
			public XblTitleManagedStatsOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600046A")]
			public <>c__DisplayClass274_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x600046B")]
			internal void <XblTitleManagedStatsUpdateStatsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000069")]
		private sealed class <>c__DisplayClass274_1
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BC")]
			public DisposableCollection disposableCollection; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600046C")]
			public <>c__DisplayClass274_1() { }

			[Address(RVA = "0x2B78180", Offset = "0x2B77580", Length = "0x2E")]
			[Token(Token = "0x600046D")]
			internal XblTitleManagedStatistic <XblTitleManagedStatsUpdateStatsAsync>b__1(XblTitleManagedStatistic s) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006A")]
		private sealed class <>c__DisplayClass275_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BD")]
			public XblTitleManagedStatsOperationCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600046E")]
			public <>c__DisplayClass275_0() { }

			[Address(RVA = "0x2B71A30", Offset = "0x2B70E30", Length = "0x4A")]
			[Token(Token = "0x600046F")]
			internal void <XblTitleManagedStatsDeleteStatsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006B")]
		private sealed class <>c__DisplayClass278_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BE")]
			public XblTitleStorageBlobMetadataResultGetNextCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000470")]
			public <>c__DisplayClass278_0() { }

			[Address(RVA = "0x2B781B0", Offset = "0x2B775B0", Length = "0xC0")]
			[Token(Token = "0x6000471")]
			internal void <XblTitleStorageBlobMetadataResultGetNextAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006C")]
		private sealed class <>c__DisplayClass281_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BF")]
			public XblTitleStorageGetQuotaCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000472")]
			public <>c__DisplayClass281_0() { }

			[Address(RVA = "0x2B78280", Offset = "0x2B77680", Length = "0xBB")]
			[Token(Token = "0x6000473")]
			internal void <XblTitleStorageGetQuotaAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006D")]
		private sealed class <>c__DisplayClass282_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C0")]
			public XblTitleStorageGetBlobMetadataCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000474")]
			public <>c__DisplayClass282_0() { }

			[Address(RVA = "0x2B78340", Offset = "0x2B77740", Length = "0xC0")]
			[Token(Token = "0x6000475")]
			internal void <XblTitleStorageGetBlobMetadataAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006E")]
		private sealed class <>c__DisplayClass283_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C1")]
			public XblTitleStorageDeleteBlobCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000476")]
			public <>c__DisplayClass283_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000477")]
			internal void <XblTitleStorageDeleteBlobAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200006F")]
		private sealed class <>c__DisplayClass284_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C2")]
			public int blobBufferCount; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000C3")]
			public IntPtr blobBuffer; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000C4")]
			public XblTitleStorageDownloadBlobCompleted completionRoutine; //Field offset: 0x20

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000478")]
			public <>c__DisplayClass284_0() { }

			[Address(RVA = "0x2B78410", Offset = "0x2B77810", Length = "0x204")]
			[Token(Token = "0x6000479")]
			internal void <XblTitleStorageDownloadBlobAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000070")]
		private sealed class <>c__DisplayClass285_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C5")]
			public XblTitleStorageUploadBlobCompleted completionRoutine; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000C6")]
			public IntPtr blobBufferPtr; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600047A")]
			public <>c__DisplayClass285_0() { }

			[Address(RVA = "0x2B78620", Offset = "0x2B77A20", Length = "0x181")]
			[Token(Token = "0x600047B")]
			internal void <XblTitleStorageUploadBlobAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000071")]
		private sealed class <>c__DisplayClass287_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C7")]
			public XblUserStatisticsGetSingleUserStatisticCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600047C")]
			public <>c__DisplayClass287_0() { }

			[Address(RVA = "0x2B787B0", Offset = "0x2B77BB0", Length = "0x30A")]
			[Token(Token = "0x600047D")]
			internal void <XblUserStatisticsGetSingleUserStatisticAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000072")]
		private sealed class <>c__DisplayClass288_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C8")]
			public XblUserStatisticsGetSingleUserStatisticsCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600047E")]
			public <>c__DisplayClass288_0() { }

			[Address(RVA = "0x2B78AC0", Offset = "0x2B77EC0", Length = "0x30A")]
			[Token(Token = "0x600047F")]
			internal void <XblUserStatisticsGetSingleUserStatisticsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000073")]
		private sealed class <>c__DisplayClass289_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000C9")]
			public XblUserStatisticsGetMultipleUserStatisticsCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000480")]
			public <>c__DisplayClass289_0() { }

			[Address(RVA = "0x2B78DD0", Offset = "0x2B781D0", Length = "0x321")]
			[Token(Token = "0x6000481")]
			internal void <XblUserStatisticsGetMultipleUserStatisticsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000074")]
		private sealed class <>c__DisplayClass290_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CA")]
			public XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000482")]
			public <>c__DisplayClass290_0() { }

			[Address(RVA = "0x2B79100", Offset = "0x2B78500", Length = "0x321")]
			[Token(Token = "0x6000483")]
			internal void <XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000075")]
		private sealed class <>c__DisplayClass302_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CB")]
			public XblCleanupResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000484")]
			public <>c__DisplayClass302_0() { }

			[Address(RVA = "0x2B79430", Offset = "0x2B78830", Length = "0x52")]
			[Token(Token = "0x6000485")]
			internal void <XblCleanup>b__0(XAsyncBlock block) { }

			[Address(RVA = "0x2B79490", Offset = "0x2B78890", Length = "0x5B")]
			[Token(Token = "0x6000486")]
			internal void <XblCleanup>b__1(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000076")]
		private sealed class <>c__DisplayClass39_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CC")]
			public XblHttpCallPerformCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000487")]
			public <>c__DisplayClass39_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000488")]
			internal void <XblHttpCallPerformAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000077")]
		private sealed class <>c__DisplayClass56_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CD")]
			public XblLeaderboardGetLeaderboardCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000489")]
			public <>c__DisplayClass56_0() { }

			[Address(RVA = "0x2B79C40", Offset = "0x2B79040", Length = "0x3BE")]
			[Token(Token = "0x600048A")]
			internal void <XblLeaderboardGetLeaderboardAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000078")]
		private sealed class <>c__DisplayClass57_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CE")]
			public XblLeaderboardGetNextCompleted completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600048B")]
			public <>c__DisplayClass57_0() { }

			[Address(RVA = "0x2B7A000", Offset = "0x2B79400", Length = "0x2FA")]
			[Token(Token = "0x600048C")]
			internal void <XblLeaderboardResultGetNextAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000079")]
		private sealed class <>c__DisplayClass62_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000CF")]
			public XblMatchmakingCreateMatchTicketHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600048D")]
			public <>c__DisplayClass62_0() { }

			[Address(RVA = "0x2B7A320", Offset = "0x2B79720", Length = "0xF0")]
			[Token(Token = "0x600048E")]
			internal void <XblMatchmakingCreateMatchTicketAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007A")]
		private sealed class <>c__DisplayClass63_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000D0")]
			public XblMatchmakingDeleteMatchTicketHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600048F")]
			public <>c__DisplayClass63_0() { }

			[Address(RVA = "0x2B73190", Offset = "0x2B72590", Length = "0x47")]
			[Token(Token = "0x6000490")]
			internal void <XblMatchmakingDeleteMatchTicketAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007B")]
		private sealed class <>c__DisplayClass64_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000D1")]
			public XblMatchmakingGetMatchTicketDetailsHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000491")]
			public <>c__DisplayClass64_0() { }

			[Address(RVA = "0x2B7A420", Offset = "0x2B79820", Length = "0x33A")]
			[Token(Token = "0x6000492")]
			internal void <XblMatchmakingGetMatchTicketDetailsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007C")]
		private sealed class <>c__DisplayClass65_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000D2")]
			public XblMatchmakingGetHopperStatisticsHandleResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000493")]
			public <>c__DisplayClass65_0() { }

			[Address(RVA = "0x2B7A760", Offset = "0x2B79B60", Length = "0x33A")]
			[Token(Token = "0x6000494")]
			internal void <XblMatchmakingGetHopperStatisticsAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007D")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000D3")]
			public XblAchievementsResultGetNextResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000495")]
			public <>c__DisplayClass8_0() { }

			[Address(RVA = "0x2B7AD70", Offset = "0x2B7A170", Length = "0xE6")]
			[Token(Token = "0x6000496")]
			internal void <XblAchievementsResultGetNextAsync>b__0(XAsyncBlock block) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200007E")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000D4")]
			public XblAchievementsGetAchievementsForTitleIdResult completionRoutine; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000497")]
			public <>c__DisplayClass9_0() { }

			[Address(RVA = "0x2B7B530", Offset = "0x2B7A930", Length = "0xE6")]
			[Token(Token = "0x6000498")]
			internal void <XblAchievementsGetAchievementsForTitleIdAsync>b__0(XAsyncBlock block) { }

		}

		[Token(Token = "0x200002B")]
		private class ConnectionResyncCallbackManager : InteropCallbackManager<XblConnectionResyncCallback>
		{

			[Address(RVA = "0x2B6E230", Offset = "0x2B6D630", Length = "0x39")]
			[Token(Token = "0x60003B4")]
			public ConnectionResyncCallbackManager() { }

			[Address(RVA = "0x2B6E000", Offset = "0x2B6D400", Length = "0x18D")]
			[MonoPInvokeCallback]
			[Token(Token = "0x60003B2")]
			internal static void InteropPInvokeCallback(IntPtr context) { }

			[Address(RVA = "0x2B6E190", Offset = "0x2B6D590", Length = "0x97")]
			[Token(Token = "0x60003B3")]
			private void IssueEventCallback(int functionId) { }

		}

		[Token(Token = "0x200002A")]
		private class ConnectionStateChangeCallbackManager : InteropCallbackManager<XblConnectionStateChangeCallback>
		{

			[Address(RVA = "0x2B6E4C0", Offset = "0x2B6D8C0", Length = "0x39")]
			[Token(Token = "0x60003B1")]
			public ConnectionStateChangeCallbackManager() { }

			[Address(RVA = "0x2B6E270", Offset = "0x2B6D670", Length = "0x197")]
			[MonoPInvokeCallback]
			[Token(Token = "0x60003AF")]
			internal static void InteropPInvokeCallback(IntPtr context, XblRealTimeActivityConnectionState newConnectionState) { }

			[Address(RVA = "0x2B6E410", Offset = "0x2B6D810", Length = "0xA6")]
			[Token(Token = "0x60003B0")]
			private void IssueEventCallback(int functionId, XblRealTimeActivityConnectionState newConnectionState) { }

		}

		[Token(Token = "0x200002C")]
		private class SocialRelationshipChangeCallbackManager : InteropCallbackManager<XblSocialRelationshipChangedCallback>
		{

			[Address(RVA = "0x2B6EDB0", Offset = "0x2B6E1B0", Length = "0x39")]
			[Token(Token = "0x60003B7")]
			public SocialRelationshipChangeCallbackManager() { }

			[Address(RVA = "0x2B6E930", Offset = "0x2B6DD30", Length = "0x2BB")]
			[MonoPInvokeCallback]
			[Token(Token = "0x60003B5")]
			internal static void InteropPInvokeCallback(XblSocialRelationshipChangeEventArgs* eventArgs, IntPtr context) { }

			[Address(RVA = "0x2B6EBF0", Offset = "0x2B6DFF0", Length = "0x1B9")]
			[Token(Token = "0x60003B6")]
			private void IssueEventCallback(int functionId, XblSocialRelationshipChangeEventArgs* eventArgs) { }

		}

		[Token(Token = "0x200002E")]
		private class UserStatisticsChangeCallbackManager : InteropCallbackManager<XblStatisticChangedCallback>
		{

			[Address(RVA = "0x2B7BD10", Offset = "0x2B7B110", Length = "0x39")]
			[Token(Token = "0x60003BE")]
			public UserStatisticsChangeCallbackManager() { }

			[Address(RVA = "0x2B7B8C0", Offset = "0x2B7ACC0", Length = "0x2BA")]
			[MonoPInvokeCallback]
			[Token(Token = "0x60003BC")]
			internal static void InteropPInvokeCallback(XblStatisticChangeEventArgs eventArgs, Void* context) { }

			[Address(RVA = "0x2B7BB80", Offset = "0x2B7AF80", Length = "0x18A")]
			[Token(Token = "0x60003BD")]
			private void IssueEventCallback(int functionId, XblStatisticChangeEventArgs eventArgs) { }

		}

		[Token(Token = "0x2000014")]
		internal sealed class XblAchievementsGetAchievementResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000357")]
			public XblAchievementsGetAchievementResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000359")]
			public override IAsyncResult BeginInvoke(int hresult, XblAchievementsResultHandle result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600035A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000358")]
			public override void Invoke(int hresult, XblAchievementsResultHandle result) { }

		}

		[Token(Token = "0x2000011")]
		internal sealed class XblAchievementsGetAchievementsForTitleIdResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600034B")]
			public XblAchievementsGetAchievementsForTitleIdResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x600034D")]
			public override IAsyncResult BeginInvoke(int hresult, XblAchievementsResultHandle result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600034E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x600034C")]
			public override void Invoke(int hresult, XblAchievementsResultHandle result) { }

		}

		[Token(Token = "0x2000015")]
		internal sealed class XblAchievementsProgressChangeHandlerResult : MulticastDelegate
		{

			[Address(RVA = "0x2B7E930", Offset = "0x2B7DD30", Length = "0xA6")]
			[Token(Token = "0x600035B")]
			public XblAchievementsProgressChangeHandlerResult(object object, IntPtr method) { }

			[Address(RVA = "0x2B7E8B0", Offset = "0x2B7DCB0", Length = "0x79")]
			[Token(Token = "0x600035D")]
			public override IAsyncResult BeginInvoke(int hresult, XblAchievementProgressChangeEventArgs eventArgs, IntPtr context, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600035E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
			[Token(Token = "0x600035C")]
			public override void Invoke(int hresult, XblAchievementProgressChangeEventArgs eventArgs, IntPtr context) { }

		}

		[Token(Token = "0x2000010")]
		internal sealed class XblAchievementsResultGetNextResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000347")]
			public XblAchievementsResultGetNextResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000349")]
			public override IAsyncResult BeginInvoke(int hresult, XblAchievementsResultHandle result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600034A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000348")]
			public override void Invoke(int hresult, XblAchievementsResultHandle result) { }

		}

		[Token(Token = "0x2000013")]
		internal sealed class XblAchievementsUpdateAchievementForTitleIdResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x6000353")]
			public XblAchievementsUpdateAchievementForTitleIdResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x6000355")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000356")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000354")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000012")]
		internal sealed class XblAchievementsUpdateAchievementResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x600034F")]
			public XblAchievementsUpdateAchievementResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x6000351")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000352")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000350")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x200002F")]
		internal sealed class XblCleanupResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x60003BF")]
			public XblCleanupResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x60003C1")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003C2")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x60003C0")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000016")]
		internal sealed class XblMatchmakingCreateMatchTicketHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600035F")]
			public XblMatchmakingCreateMatchTicketHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000361")]
			public override IAsyncResult BeginInvoke(int hresult, XblCreateMatchTicketResponse handle, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000362")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000360")]
			public override void Invoke(int hresult, XblCreateMatchTicketResponse handle) { }

		}

		[Token(Token = "0x2000017")]
		internal sealed class XblMatchmakingDeleteMatchTicketHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x6000363")]
			public XblMatchmakingDeleteMatchTicketHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x6000365")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000366")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000364")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000019")]
		internal sealed class XblMatchmakingGetHopperStatisticsHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600036B")]
			public XblMatchmakingGetHopperStatisticsHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x600036D")]
			public override IAsyncResult BeginInvoke(int hresult, XblHopperStatisticsResponse result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600036E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x600036C")]
			public override void Invoke(int hresult, XblHopperStatisticsResponse result) { }

		}

		[Token(Token = "0x2000018")]
		internal sealed class XblMatchmakingGetMatchTicketDetailsHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000367")]
			public XblMatchmakingGetMatchTicketDetailsHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000369")]
			public override IAsyncResult BeginInvoke(int hresult, XblMatchTicketDetailsResponse result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600036A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000368")]
			public override void Invoke(int hresult, XblMatchTicketDetailsResponse result) { }

		}

		[Token(Token = "0x2000028")]
		internal sealed class XblMultiplayerActivityAsyncOperationCompleted : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x60003A7")]
			public XblMultiplayerActivityAsyncOperationCompleted(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x60003A9")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003AA")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x60003A8")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000021")]
		internal sealed class XblMultiplayerClearActivityHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x600038B")]
			public XblMultiplayerClearActivityHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x600038D")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600038E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x600038C")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000025")]
		internal sealed class XblMultiplayerConnectionIdChangedHandler : MulticastDelegate
		{

			[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
			[Token(Token = "0x600039B")]
			public XblMultiplayerConnectionIdChangedHandler(object object, IntPtr method) { }

			[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
			[Token(Token = "0x600039D")]
			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600039E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
			[Token(Token = "0x600039C")]
			public override void Invoke() { }

		}

		[Token(Token = "0x200001E")]
		internal sealed class XblMultiplayerCreateSearchHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600037F")]
			public XblMultiplayerCreateSearchHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000381")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSearchHandle handle, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000382")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000380")]
			public override void Invoke(int hresult, XblMultiplayerSearchHandle handle) { }

		}

		[Token(Token = "0x2000020")]
		internal sealed class XblMultiplayerDeleteSearchHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x6000387")]
			public XblMultiplayerDeleteSearchHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x6000389")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600038A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000388")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x2000027")]
		internal sealed class XblMultiplayerGetActivitiesResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x60003A3")]
			public XblMultiplayerGetActivitiesResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x60003A5")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerActivityDetails[] activities, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003A6")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x60003A4")]
			public override void Invoke(int hresult, XblMultiplayerActivityDetails[] activities) { }

		}

		[Token(Token = "0x2000029")]
		internal sealed class XblMultiplayerGetActivityAsyncOperationCompleted : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x60003AB")]
			public XblMultiplayerGetActivityAsyncOperationCompleted(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x60003AD")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerActivityInfo[] results, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003AE")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x60003AC")]
			public override void Invoke(int hresult, XblMultiplayerActivityInfo[] results) { }

		}

		[Token(Token = "0x2000022")]
		internal sealed class XblMultiplayerGetSearchHandlesResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600038F")]
			public XblMultiplayerGetSearchHandlesResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000391")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSearchHandle[] searchHandles, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000392")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000390")]
			public override void Invoke(int hresult, XblMultiplayerSearchHandle[] searchHandles) { }

		}

		[Token(Token = "0x200001B")]
		internal sealed class XblMultiplayerGetSessionHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000373")]
			public XblMultiplayerGetSessionHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000375")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSessionHandle handle, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000376")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000374")]
			public override void Invoke(int hresult, XblMultiplayerSessionHandle handle) { }

		}

		[Token(Token = "0x2000026")]
		internal sealed class XblMultiplayerSendInvitesResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600039F")]
			public XblMultiplayerSendInvitesResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x60003A1")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerInviteHandle[] handles, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003A2")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x60003A0")]
			public override void Invoke(int hresult, XblMultiplayerInviteHandle[] handles) { }

		}

		[Token(Token = "0x2000023")]
		internal sealed class XblMultiplayerSessionChangedHandler : MulticastDelegate
		{

			[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
			[Token(Token = "0x6000393")]
			public XblMultiplayerSessionChangedHandler(object object, IntPtr method) { }

			[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
			[Token(Token = "0x6000395")]
			public override IAsyncResult BeginInvoke(XblMultiplayerSessionChangeEventArgs args, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000396")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000394")]
			public override void Invoke(XblMultiplayerSessionChangeEventArgs args) { }

		}

		[Token(Token = "0x200001C")]
		internal sealed class XblMultiplayerSessionQueryHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000377")]
			public XblMultiplayerSessionQueryHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000379")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSessionQueryResult[] sessions, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600037A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000378")]
			public override void Invoke(int hresult, XblMultiplayerSessionQueryResult[] sessions) { }

		}

		[Token(Token = "0x2000024")]
		internal sealed class XblMultiplayerSessionSubscriptionLostHandler : MulticastDelegate
		{

			[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
			[Token(Token = "0x6000397")]
			public XblMultiplayerSessionSubscriptionLostHandler(object object, IntPtr method) { }

			[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
			[Token(Token = "0x6000399")]
			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600039A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
			[Token(Token = "0x6000398")]
			public override void Invoke() { }

		}

		[Token(Token = "0x200001D")]
		internal sealed class XblMultiplayerSetActivityHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
			[Token(Token = "0x600037B")]
			public XblMultiplayerSetActivityHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
			[Token(Token = "0x600037D")]
			public override IAsyncResult BeginInvoke(int hresult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x600037E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x600037C")]
			public override void Invoke(int hresult) { }

		}

		[Token(Token = "0x200001F")]
		internal sealed class XblMultiplayerSetTransferHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x6000383")]
			public XblMultiplayerSetTransferHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000385")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSessionHandleId handle, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000386")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000384")]
			public override void Invoke(int hresult, XblMultiplayerSessionHandleId handle) { }

		}

		[Token(Token = "0x200001A")]
		internal sealed class XblMultiplayerWriteSessionHandleResult : MulticastDelegate
		{

			[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
			[Token(Token = "0x600036F")]
			public XblMultiplayerWriteSessionHandleResult(object object, IntPtr method) { }

			[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
			[Token(Token = "0x6000371")]
			public override IAsyncResult BeginInvoke(int hresult, XblMultiplayerSessionHandle handle, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x6000372")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x6000370")]
			public override void Invoke(int hresult, XblMultiplayerSessionHandle handle) { }

		}

		[Token(Token = "0x200002D")]
		internal sealed class XblUserStatisticsStatisticChangedHandler : MulticastDelegate
		{

			[Address(RVA = "0x1B5CE70", Offset = "0x1B5C270", Length = "0xA6")]
			[Token(Token = "0x60003B8")]
			public XblUserStatisticsStatisticChangedHandler(object object, IntPtr method) { }

			[Address(RVA = "0x2B7F380", Offset = "0x2B7E780", Length = "0x80")]
			[Token(Token = "0x60003BA")]
			public override IAsyncResult BeginInvoke(XblStatisticChangeEventArgs args, AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003BB")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0xE2BDE0", Offset = "0xE2B1E0", Length = "0x2F")]
			[Token(Token = "0x60003B9")]
			public override void Invoke(XblStatisticChangeEventArgs args) { }

		}

		[Token(Token = "0x400003A")]
		private static ConnectionStateChangeCallbackManager _connectionStateChangeCallbackManager; //Field offset: 0x0
		[Token(Token = "0x400003E")]
		public const int StandardScidLength = 36; //Field offset: 0x0
		[Token(Token = "0x400003B")]
		private static ConnectionResyncCallbackManager _connectionResyncCallbackManager; //Field offset: 0x8
		[Token(Token = "0x400003C")]
		private static SocialRelationshipChangeCallbackManager _socialRelationshipChangeCallbackManager; //Field offset: 0x10
		[Token(Token = "0x400003D")]
		private static UserStatisticsChangeCallbackManager _userStatisticsChangeCallbackManager; //Field offset: 0x18
		[Token(Token = "0x400003F")]
		internal static bool IsXblInitialized; //Field offset: 0x20

		[Address(RVA = "0x2B63700", Offset = "0x2B62B00", Length = "0x179")]
		[Token(Token = "0x6000346")]
		private static XBL() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000345")]
		public XBL() { }

		[Address(RVA = "0x2B4FF60", Offset = "0x2B4F360", Length = "0x50")]
		[Token(Token = "0x6000252")]
		public static int HCSettingsGetTraceLevel(out HCTraceLevel traceLevel) { }

		[Address(RVA = "0x2B4FFB0", Offset = "0x2B4F3B0", Length = "0x4E")]
		[Token(Token = "0x6000251")]
		public static int HCSettingsSetTraceLevel(HCTraceLevel traceLevel) { }

		[Address(RVA = "0x2B50000", Offset = "0x2B4F400", Length = "0x50")]
		[Token(Token = "0x6000253")]
		public static void HCTraceSetTraceToDebugger(bool traceToDebugger) { }

		[Address(RVA = "0x2B50050", Offset = "0x2B4F450", Length = "0x8B")]
		[Token(Token = "0x60002D9")]
		private static int SessionSetInternalWithMarshalledContext(Func<IntPtr, Int32> setterFunction, object context) { }

		[Address(RVA = "0x2B500E0", Offset = "0x2B4F4E0", Length = "0x120")]
		[Token(Token = "0x600023E")]
		public static XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(XblContextHandle xboxLiveContext, XblAchievementsProgressChangeHandlerResult handler, IntPtr handlerContext) { }

		[Address(RVA = "0x2B50210", Offset = "0x2B4F610", Length = "0x151")]
		[Token(Token = "0x600023F")]
		public static XblFunctionContext XblAchievementsAddAchievementProgressChangeHandler(XblContextHandle xboxLiveContext, XblAchievementsProgressChangeHandlerResult handler) { }

		[Address(RVA = "0x2B50370", Offset = "0x2B4F770", Length = "0x1DF")]
		[Token(Token = "0x600023D")]
		public static void XblAchievementsGetAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, string serviceConfigurationId, string achievementId, XblAchievementsGetAchievementResult completionRoutine) { }

		[Address(RVA = "0x2B50550", Offset = "0x2B4F950", Length = "0x1F9")]
		[Token(Token = "0x6000239")]
		public static void XblAchievementsGetAchievementsForTitleIdAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, XblAchievementType type, bool unlockedOnly, XblAchievementOrderBy orderBy, uint skipItems, uint maxItems, XblAchievementsGetAchievementsForTitleIdResult completionRoutine) { }

		[Address(RVA = "0x2B50750", Offset = "0x2B4FB50", Length = "0x8F")]
		[Token(Token = "0x6000246")]
		public static int XblAchievementsManagerAddLocalUser(XUserHandle user) { }

		[Address(RVA = "0x2B507E0", Offset = "0x2B4FBE0", Length = "0x19C")]
		[Token(Token = "0x6000249")]
		public static int XblAchievementsManagerDoWork(out XblAchievementsManagerEvent[] events) { }

		[Address(RVA = "0x2B50980", Offset = "0x2B4FD80", Length = "0x56")]
		[Token(Token = "0x600024A")]
		public static int XblAchievementsManagerGetAchievement(ulong xboxUserId, string achievementId, out XblAchievementsManagerResultHandle handle) { }

		[Address(RVA = "0x2B50A20", Offset = "0x2B4FE20", Length = "0x37")]
		[Token(Token = "0x600024B")]
		public static int XblAchievementsManagerGetAchievements(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, out XblAchievementsManagerResultHandle handle) { }

		[Address(RVA = "0x2B509E0", Offset = "0x2B4FDE0", Length = "0x38")]
		[Token(Token = "0x600024C")]
		public static int XblAchievementsManagerGetAchievementsByState(ulong xboxUserId, XblAchievementOrderBy sortField, XblAchievementsManagerSortOrder sortOrder, XblAchievementProgressState achievementState, out XblAchievementsManagerResultHandle handle) { }

		[Address(RVA = "0x2B50A60", Offset = "0x2B4FE60", Length = "0x7")]
		[Token(Token = "0x6000248")]
		public static int XblAchievementsManagerIsUserInitialized(ulong xboxUserId) { }

		[Address(RVA = "0x2B50A70", Offset = "0x2B4FE70", Length = "0x42")]
		[Token(Token = "0x6000247")]
		public static int XblAchievementsManagerRemoveLocalUser(XUserHandle user) { }

		[Address(RVA = "0x2B50AC0", Offset = "0x2B4FEC0", Length = "0x36")]
		[Token(Token = "0x6000245")]
		public static void XblAchievementsManagerResultCloseHandle(XblAchievementsManagerResultHandle handle) { }

		[Address(RVA = "0x2B50B00", Offset = "0x2B4FF00", Length = "0x80")]
		[Token(Token = "0x6000244")]
		public static int XblAchievementsManagerResultDuplicateHandle(XblAchievementsManagerResultHandle handle, out XblAchievementsManagerResultHandle duplicatedHandle) { }

		[Address(RVA = "0x2B50B90", Offset = "0x2B4FF90", Length = "0x1DD")]
		[Token(Token = "0x6000243")]
		public static int XblAchievementsManagerResultGetAchievements(XblAchievementsManagerResultHandle handle, out XblAchievement[] achievements) { }

		[Address(RVA = "0x2B50D70", Offset = "0x2B50170", Length = "0x3A")]
		[Token(Token = "0x600024D")]
		public static int XblAchievementsManagerUpdateAchievement(ulong xboxUserId, string achievementId, byte currentProgress) { }

		[Address(RVA = "0x2B50DB0", Offset = "0x2B501B0", Length = "0x1E")]
		[Token(Token = "0x6000240")]
		public static void XblAchievementsRemoveAchievementProgressChangeHandler(XblContextHandle xblContextHandle, XblFunctionContext functionContext) { }

		[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
		[Token(Token = "0x6000242")]
		public static void XblAchievementsResultCloseHandle(XblAchievementsResultHandle handle) { }

		[Address(RVA = "0x2B50DD0", Offset = "0x2B501D0", Length = "0xF2")]
		[Token(Token = "0x6000241")]
		public static int XblAchievementsResultDuplicateHandle(XblAchievementsResultHandle handle, out XblAchievementsResultHandle duplicatedHandle) { }

		[Address(RVA = "0x2B50ED0", Offset = "0x2B502D0", Length = "0x1D3")]
		[Token(Token = "0x6000236")]
		public static int XblAchievementsResultGetAchievements(XblAchievementsResultHandle resultHandle, out XblAchievement[] achievements) { }

		[Address(RVA = "0x2B510B0", Offset = "0x2B504B0", Length = "0x1AA")]
		[Token(Token = "0x6000238")]
		public static void XblAchievementsResultGetNextAsync(XblAchievementsResultHandle resultHandle, uint maxItems, XblAchievementsResultGetNextResult completionRoutine) { }

		[Address(RVA = "0x2B51260", Offset = "0x2B50660", Length = "0x5A")]
		[Token(Token = "0x6000237")]
		public static int XblAchievementsResultHasNext(XblAchievementsResultHandle resultHandle, out bool hasNext) { }

		[Address(RVA = "0x2B51490", Offset = "0x2B50890", Length = "0x1F4")]
		[Token(Token = "0x600023B")]
		public static void XblAchievementsUpdateAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, string serviceConfigurationId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementForTitleIdResult completionRoutine) { }

		[Address(RVA = "0x2B512C0", Offset = "0x2B506C0", Length = "0x1CE")]
		[Token(Token = "0x600023A")]
		public static void XblAchievementsUpdateAchievementAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementResult completionRoutine) { }

		[Address(RVA = "0x2B51690", Offset = "0x2B50A90", Length = "0x1F4")]
		[Token(Token = "0x600023C")]
		public static void XblAchievementsUpdateAchievementForTitleIdAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, uint titleId, string serviceConfigurationId, string achievementId, uint percentComplete, XblAchievementsUpdateAchievementForTitleIdResult completionRoutine) { }

		[Address(RVA = "0x2B51890", Offset = "0x2B50C90", Length = "0x250")]
		[Token(Token = "0x600033E")]
		public static void XblCleanup(XblCleanupResult completionRoutine) { }

		[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
		[Token(Token = "0x6000340")]
		public static void XblContextCloseHandle(XblContextHandle xboxLiveContextHandle) { }

		[Address(RVA = "0x2B51AF0", Offset = "0x2B50EF0", Length = "0x11F")]
		[Token(Token = "0x600033F")]
		public static int XblContextCreateHandle(XUserHandle user, out XblContextHandle context) { }

		[Address(RVA = "0x2B51C10", Offset = "0x2B51010", Length = "0xB5")]
		[Token(Token = "0x6000341")]
		public static int XblContextDuplicateHandle(XblContextHandle srcXboxLiveContextHandle, out XblContextHandle dstXboxLiveContextHandle) { }

		[Address(RVA = "0x2B51CD0", Offset = "0x2B510D0", Length = "0xB5")]
		[Token(Token = "0x6000342")]
		public static int XblContextGetUser(XblContextHandle xboxLiveContextHandle, out XUserHandle dstUserHandle) { }

		[Address(RVA = "0x2B51D90", Offset = "0x2B51190", Length = "0x6A")]
		[Token(Token = "0x6000343")]
		public static int XblContextGetXboxUserId(XblContextHandle xboxLiveContextHandle, ref ulong dstXboxUserId) { }

		[Address(RVA = "0x2B51E00", Offset = "0x2B51200", Length = "0x9C")]
		[Token(Token = "0x6000250")]
		public static int XblEventsWriteInGameEvent(XblContextHandle xboxLiveContext, string eventName, string dimensionsJson, string measurementsJson) { }

		[Address(RVA = "0x2B51EA0", Offset = "0x2B512A0", Length = "0x9A")]
		[Token(Token = "0x6000294")]
		public static int XblFormatSecureDeviceAddress(string deviceId, out string address) { }

		[Address(RVA = "0x2B51F40", Offset = "0x2B51340", Length = "0x7")]
		[Token(Token = "0x600024E")]
		public static XblErrorCondition XblGetErrorCondition(int hr) { }

		[Address(RVA = "0x2B51F50", Offset = "0x2B51350", Length = "0xD2")]
		[Token(Token = "0x600024F")]
		public static XblHresult XblGetHRESULT(int hr) { }

		[Address(RVA = "0x2B52030", Offset = "0x2B51430", Length = "0x77")]
		[Token(Token = "0x6000344")]
		public static int XblGetScid(ref string resultScid) { }

		[Address(RVA = "0x2B520B0", Offset = "0x2B514B0", Length = "0x37")]
		[Token(Token = "0x600025A")]
		public static void XblHttpCallCloseHandle(XblHttpCallHandle call) { }

		[Address(RVA = "0x2B520F0", Offset = "0x2B514F0", Length = "0xBD")]
		[Token(Token = "0x6000259")]
		public static int XblHttpCallCreate(XblContextHandle xblContext, string method, string url, out XblHttpCallHandle call) { }

		[Address(RVA = "0x2B521B0", Offset = "0x2B515B0", Length = "0x86")]
		[Token(Token = "0x6000262")]
		public static int XblHttpCallDuplicateHandle(XblHttpCallHandle call, out XblHttpCallHandle duplicateHandle) { }

		[Address(RVA = "0x2B52320", Offset = "0x2B51720", Length = "0xBE")]
		[Token(Token = "0x6000265")]
		public static int XblHttpCallGetHeader(XblHttpCallHandle call, string headerName, out string headerValue) { }

		[Address(RVA = "0x2B52240", Offset = "0x2B51640", Length = "0xDE")]
		[Token(Token = "0x600025D")]
		public static int XblHttpCallGetHeaderAtIndex(XblHttpCallHandle call, uint headerIndex, out string headerName, out string headerValue) { }

		[Address(RVA = "0x2B523E0", Offset = "0x2B517E0", Length = "0x72")]
		[Token(Token = "0x6000255")]
		public static int XblHttpCallGetNetworkErrorCode(XblHttpCallHandle call, out int networkErrorCode, out uint platformNetworkErrorCode) { }

		[Address(RVA = "0x2B52460", Offset = "0x2B51860", Length = "0x5D")]
		[Token(Token = "0x6000263")]
		public static int XblHttpCallGetNumHeaders(XblHttpCallHandle call, out uint numHeaders) { }

		[Address(RVA = "0x2B524C0", Offset = "0x2B518C0", Length = "0x9C")]
		[Token(Token = "0x600025E")]
		public static int XblHttpCallGetPlatformNetworkErrorMessage(XblHttpCallHandle call, out string platformNetworkErrorMessage) { }

		[Address(RVA = "0x2B52560", Offset = "0x2B51960", Length = "0x9C")]
		[Token(Token = "0x6000266")]
		public static int XblHttpCallGetRequestUrl(XblHttpCallHandle call, out string url) { }

		[Address(RVA = "0x2B52600", Offset = "0x2B51A00", Length = "0xFD")]
		[Token(Token = "0x600025F")]
		public static int XblHttpCallGetResponseBodyBytes(XblHttpCallHandle call, out Byte[] buffer) { }

		[Address(RVA = "0x2B52700", Offset = "0x2B51B00", Length = "0x9C")]
		[Token(Token = "0x600025C")]
		public static int XblHttpCallGetResponseString(XblHttpCallHandle call, out string responseString) { }

		[Address(RVA = "0x2B527A0", Offset = "0x2B51BA0", Length = "0x5D")]
		[Token(Token = "0x6000264")]
		public static int XblHttpCallGetStatusCode(XblHttpCallHandle call, out uint statusCode) { }

		[Address(RVA = "0x2B52800", Offset = "0x2B51C00", Length = "0x1A4")]
		[Token(Token = "0x6000257")]
		public static void XblHttpCallPerformAsync(XblHttpCallHandle call, XblHttpCallResponseBodyType type, XblHttpCallPerformCompleted completionRoutine) { }

		[Address(RVA = "0x2B529B0", Offset = "0x2B51DB0", Length = "0xAC")]
		[Token(Token = "0x6000261")]
		public static int XblHttpCallRequestSetHeader(XblHttpCallHandle call, string headerName, string headerValue, bool allowTracing) { }

		[Address(RVA = "0x2B52A60", Offset = "0x2B51E60", Length = "0x72")]
		[Token(Token = "0x6000256")]
		public static int XblHttpCallRequestSetLongHttpCall(XblHttpCallHandle call, bool longHttpCall) { }

		[Address(RVA = "0x2B52AE0", Offset = "0x2B51EE0", Length = "0x60")]
		[Token(Token = "0x6000254")]
		public static int XblHttpCallRequestSetRequestBodyBytes(XblHttpCallHandle call, Byte[] requestBodyBytes) { }

		[Address(RVA = "0x2B52B40", Offset = "0x2B51F40", Length = "0x64")]
		[Token(Token = "0x600025B")]
		public static int XblHttpCallRequestSetRequestBodyString(XblHttpCallHandle call, string requestBodyString) { }

		[Address(RVA = "0x2B52BB0", Offset = "0x2B51FB0", Length = "0x72")]
		[Token(Token = "0x6000260")]
		public static int XblHttpCallRequestSetRetryAllowed(XblHttpCallHandle call, bool retryAllowed) { }

		[Address(RVA = "0x2B52C30", Offset = "0x2B52030", Length = "0x55")]
		[Token(Token = "0x6000267")]
		public static int XblHttpCallRequestSetRetryCacheId(XblHttpCallHandle call, uint retryAfterCacheId) { }

		[Address(RVA = "0x2B52C90", Offset = "0x2B52090", Length = "0x72")]
		[Token(Token = "0x6000258")]
		public static int XblHttpCallSetTracing(XblHttpCallHandle call, bool traceCall) { }

		[Address(RVA = "0x2B52D10", Offset = "0x2B52110", Length = "0xA2")]
		[Token(Token = "0x600033D")]
		public static int XblInitialize(string scid) { }

		[Address(RVA = "0x2B52DC0", Offset = "0x2B521C0", Length = "0x313")]
		[Token(Token = "0x6000268")]
		public static void XblLeaderboardGetLeaderboardAsync(XblContextHandle xboxLiveContext, XblLeaderboardQuery leaderboardQuery, XblLeaderboardGetLeaderboardCompleted completionRoutine) { }

		[Address(RVA = "0x2B530E0", Offset = "0x2B524E0", Length = "0x294")]
		[Token(Token = "0x6000269")]
		public static void XblLeaderboardResultGetNextAsync(XblContextHandle xboxLiveContext, XblLeaderboardResult leaderboardResult, uint maxItems, XblLeaderboardGetNextCompleted completionRoutine) { }

		[Address(RVA = "0x2B53380", Offset = "0x2B52780", Length = "0x2F5")]
		[Token(Token = "0x600026A")]
		public static void XblMatchmakingCreateMatchTicketAsync(XblContextHandle xboxLiveContext, XblMultiplayerSessionReference ticketSessionReference, string matchmakingServiceConfigurationId, string hopperName, ulong ticketTimeout, XblPreserveSessionMode preserveSession, string ticketAttributesJson, XblMatchmakingCreateMatchTicketHandleResult completionRoutine) { }

		[Address(RVA = "0x2B53680", Offset = "0x2B52A80", Length = "0x1E7")]
		[Token(Token = "0x600026B")]
		public static void XblMatchmakingDeleteMatchTicketAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, string ticketId, XblMatchmakingDeleteMatchTicketHandleResult completionRoutine) { }

		[Address(RVA = "0x2B53870", Offset = "0x2B52C70", Length = "0x1D8")]
		[Token(Token = "0x600026D")]
		public static void XblMatchmakingGetHopperStatisticsAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, XblMatchmakingGetHopperStatisticsHandleResult completionRoutine) { }

		[Address(RVA = "0x2B53A50", Offset = "0x2B52E50", Length = "0x1ED")]
		[Token(Token = "0x600026C")]
		public static void XblMatchmakingGetMatchTicketDetailsAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, string hopperName, string ticketId, XblMatchmakingGetMatchTicketDetailsHandleResult completionRoutine) { }

		[Address(RVA = "0x2B53C40", Offset = "0x2B53040", Length = "0x196")]
		[Token(Token = "0x60002BB")]
		public static void XblMultiplayerActivityDeleteActivityAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityAsyncOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B53DE0", Offset = "0x2B531E0", Length = "0x196")]
		[Token(Token = "0x60002B8")]
		public static void XblMultiplayerActivityFlushRecentPlayersAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityAsyncOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B53F80", Offset = "0x2B53380", Length = "0x1CE")]
		[Token(Token = "0x60002BA")]
		public static void XblMultiplayerActivityGetActivityAsync(XblContextHandle xboxLiveContext, UInt64[] xboxUserIdList, XblMultiplayerGetActivityAsyncOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B54150", Offset = "0x2B53550", Length = "0x209")]
		[Token(Token = "0x60002BC")]
		public static void XblMultiplayerActivitySendInvitesAsync(XblContextHandle xboxLiveContext, UInt64[] xboxUserIdList, bool allowCrossPlatformJoin, string connectionString, XblMultiplayerActivityAsyncOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B54360", Offset = "0x2B53760", Length = "0x2A1")]
		[Token(Token = "0x60002B9")]
		public static void XblMultiplayerActivitySetActivityAsync(XblContextHandle xboxLiveContext, XblMultiplayerActivityInfo activityInfo, bool allowCrossPlatformJoin, XblMultiplayerActivityAsyncOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B54610", Offset = "0x2B53A10", Length = "0x1A3")]
		[Token(Token = "0x60002B7")]
		public static int XblMultiplayerActivityUpdateRecentPlayers(XblContextHandle xboxLiveContext, XblMultiplayerActivityRecentPlayerUpdate[] updates) { }

		[Address(RVA = "0x2B547C0", Offset = "0x2B53BC0", Length = "0x1B6")]
		[Token(Token = "0x60002A8")]
		public static void XblMultiplayerClearActivityAsync(XblContextHandle xblContext, string scid, XblMultiplayerClearActivityHandleResult completionRoutine) { }

		[Address(RVA = "0x2B54980", Offset = "0x2B53D80", Length = "0x56F")]
		[Token(Token = "0x60002AA")]
		public static void XblMultiplayerCreateSearchHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionRef, XblMultiplayerSessionTag[] tags, XblMultiplayerSessionNumberAttribute[] numberAttributes, XblMultiplayerSessionStringAttribute[] stringAttributes, XblMultiplayerCreateSearchHandleResult completionRoutine) { }

		[Address(RVA = "0x2B54EF0", Offset = "0x2B542F0", Length = "0x1B6")]
		[Token(Token = "0x60002AB")]
		public static void XblMultiplayerDeleteSearchHandleAsync(XblContextHandle xblContext, string handleId, XblMultiplayerDeleteSearchHandleResult completionRoutine) { }

		[Address(RVA = "0x2B550B0", Offset = "0x2B544B0", Length = "0x72")]
		[Token(Token = "0x60002D2")]
		public static int XblMultiplayerEventArgsFindMatchCompleted(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerMatchStatus matchStatus, out XblMultiplayerMeasurementFailure initializationFailureCause) { }

		[Address(RVA = "0x2B55130", Offset = "0x2B54530", Length = "0x19F")]
		[Token(Token = "0x60002D6")]
		public static int XblMultiplayerEventArgsMember(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerManagerMember member) { }

		[Address(RVA = "0x2B552D0", Offset = "0x2B546D0", Length = "0x202")]
		[Token(Token = "0x60002D7")]
		public static int XblMultiplayerEventArgsMembers(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerManagerMember[] members) { }

		[Address(RVA = "0x2B554E0", Offset = "0x2B548E0", Length = "0xF3")]
		[Token(Token = "0x60002D8")]
		public static int XblMultiplayerEventArgsPerformQoSMeasurements(XblMultiplayerEventArgsHandle argsHandle, out XblMultiplayerPerformQoSMeasurementsArgs performQoSMeasurementsArgs) { }

		[Address(RVA = "0x2B555E0", Offset = "0x2B549E0", Length = "0x9C")]
		[Token(Token = "0x60002D3")]
		public static int XblMultiplayerEventArgsPropertiesJson(XblMultiplayerEventArgsHandle argsHandle, out string properties) { }

		[Address(RVA = "0x2B55680", Offset = "0x2B54A80", Length = "0xBC")]
		[Token(Token = "0x60002D5")]
		public static int XblMultiplayerEventArgsTournamentGameSessionReady(XblMultiplayerEventArgsHandle argsHandle, out DateTime startTime) { }

		[Address(RVA = "0x2B55740", Offset = "0x2B54B40", Length = "0x72")]
		[Token(Token = "0x60002D1")]
		public static int XblMultiplayerEventArgsTournamentRegistrationStateChanged(XblMultiplayerEventArgsHandle argsHandle, out XblTournamentRegistrationState registrationState, out XblTournamentRegistrationReason registrationReason) { }

		[Address(RVA = "0x2B557C0", Offset = "0x2B54BC0", Length = "0x5E")]
		[Token(Token = "0x60002D4")]
		public static int XblMultiplayerEventArgsXuid(XblMultiplayerEventArgsHandle argsHandle, out ulong xuid) { }

		[Address(RVA = "0x2B55820", Offset = "0x2B54C20", Length = "0x208")]
		[Token(Token = "0x60002AE")]
		public static void XblMultiplayerGetActivitiesForSocialGroupAsync(XblContextHandle xboxLiveContext, string scid, ulong socialGroupOwnerXuid, string socialGroup, XblMultiplayerGetActivitiesResult completionRoutine) { }

		[Address(RVA = "0x2B55A30", Offset = "0x2B54E30", Length = "0x216")]
		[Token(Token = "0x60002B0")]
		public static void XblMultiplayerGetActivitiesForUsersAsync(XblContextHandle xboxLiveContext, string scid, UInt64[] xuids, XblMultiplayerGetActivitiesResult completionRoutine) { }

		[Address(RVA = "0x2B55C50", Offset = "0x2B55050", Length = "0x20C")]
		[Token(Token = "0x60002AF")]
		public static void XblMultiplayerGetActivitiesWithPropertiesForSocialGroupAsync(XblContextHandle xboxLiveContext, string scid, ulong socialGroupOwnerXuid, string socialGroup, XblMultiplayerGetActivitiesResult completionRoutine) { }

		[Address(RVA = "0x2B55E60", Offset = "0x2B55260", Length = "0x21A")]
		[Token(Token = "0x60002B1")]
		public static void XblMultiplayerGetActivitiesWithPropertiesForUsersAsync(XblContextHandle xboxLiveContext, string scid, UInt64[] xuids, XblMultiplayerGetActivitiesResult completionRoutine) { }

		[Address(RVA = "0x2B56080", Offset = "0x2B55480", Length = "0x261")]
		[Token(Token = "0x60002AC")]
		public static void XblMultiplayerGetSearchHandlesAsync(XblContextHandle xboxLiveContext, string scid, string sessionTemplateName, string orderByAttribute, bool orderAscending, string searchFilter, string socialGroup, XblMultiplayerGetSearchHandlesResult completionRoutine) { }

		[Address(RVA = "0x2B562F0", Offset = "0x2B556F0", Length = "0x1E6")]
		[Token(Token = "0x60002A4")]
		public static void XblMultiplayerGetSessionAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionRef, XblMultiplayerGetSessionHandleResult completionRoutine) { }

		[Address(RVA = "0x2B564E0", Offset = "0x2B558E0", Length = "0x1BC")]
		[Token(Token = "0x60002A5")]
		public static void XblMultiplayerGetSessionByHandleAsync(XblContextHandle xblContext, string handleId, XblMultiplayerGetSessionHandleResult completionRoutine) { }

		[Address(RVA = "0x2B566A0", Offset = "0x2B55AA0", Length = "0x25")]
		[Token(Token = "0x60002CD")]
		public static bool XblMultiplayerManagerAutoFillMembersDuringMatchmaking() { }

		[Address(RVA = "0x2B566D0", Offset = "0x2B55AD0", Length = "0x7")]
		[Token(Token = "0x60002C6")]
		public static void XblMultiplayerManagerCancelMatch() { }

		[Address(RVA = "0x2B566E0", Offset = "0x2B55AE0", Length = "0x191")]
		[Token(Token = "0x60002BE")]
		public static int XblMultiplayerManagerDoWork(out XblMultiplayerEvent[] events) { }

		[Address(RVA = "0x2B56880", Offset = "0x2B55C80", Length = "0x7")]
		[Token(Token = "0x60002C7")]
		public static uint XblMultiplayerManagerEstimatedMatchWaitTime() { }

		[Address(RVA = "0x2B56890", Offset = "0x2B55C90", Length = "0x49")]
		[Token(Token = "0x60002CE")]
		public static int XblMultiplayerManagerFindMatch(string hopperName, string attributesJson, uint timeoutInSeconds) { }

		[Address(RVA = "0x2B568E0", Offset = "0x2B55CE0", Length = "0x25")]
		[Token(Token = "0x60002DE")]
		public static bool XblMultiplayerManagerGameSessionActive() { }

		[Address(RVA = "0x2B56910", Offset = "0x2B55D10", Length = "0x15A")]
		[Token(Token = "0x60002E3")]
		public static XblMultiplayerSessionConstants XblMultiplayerManagerGameSessionConstants() { }

		[Address(RVA = "0x2B56A70", Offset = "0x2B55E70", Length = "0x2A")]
		[Token(Token = "0x60002E2")]
		public static string XblMultiplayerManagerGameSessionCorrelationId() { }

		[Address(RVA = "0x2B56AA0", Offset = "0x2B55EA0", Length = "0x158")]
		[Token(Token = "0x60002DB")]
		public static int XblMultiplayerManagerGameSessionHost(out XblMultiplayerManagerMember hostMember) { }

		[Address(RVA = "0x2B56C00", Offset = "0x2B56000", Length = "0x25")]
		[Token(Token = "0x60002DA")]
		public static bool XblMultiplayerManagerGameSessionIsHost(ulong xuid) { }

		[Address(RVA = "0x2B56C30", Offset = "0x2B56030", Length = "0x1C4")]
		[Token(Token = "0x60002E4")]
		public static int XblMultiplayerManagerGameSessionMembers(out XblMultiplayerManagerMember[] members) { }

		[Address(RVA = "0x2B56E00", Offset = "0x2B56200", Length = "0x2A")]
		[Token(Token = "0x60002E5")]
		public static string XblMultiplayerManagerGameSessionPropertiesJson() { }

		[Address(RVA = "0x2B56E30", Offset = "0x2B56230", Length = "0x18B")]
		[Token(Token = "0x60002DD")]
		public static XblMultiplayerSessionReference XblMultiplayerManagerGameSessionSessionReference() { }

		[Address(RVA = "0x2B56FC0", Offset = "0x2B563C0", Length = "0x163")]
		[Token(Token = "0x60002DF")]
		public static int XblMultiplayerManagerGameSessionSetProperties(string name, string valueJson, object context) { }

		[Address(RVA = "0x2B57130", Offset = "0x2B56530", Length = "0x146")]
		[Token(Token = "0x60002E0")]
		public static int XblMultiplayerManagerGameSessionSetSynchronizedHost(string deviceToken, object context) { }

		[Address(RVA = "0x2B57280", Offset = "0x2B56680", Length = "0x163")]
		[Token(Token = "0x60002E1")]
		public static int XblMultiplayerManagerGameSessionSetSynchronizedProperties(string name, string valueJson, object context) { }

		[Address(RVA = "0x2B573F0", Offset = "0x2B567F0", Length = "0x6C")]
		[Token(Token = "0x60002BD")]
		public static int XblMultiplayerManagerInitialize(string lobbySessionTemplateName) { }

		[Address(RVA = "0x2B57570", Offset = "0x2B56970", Length = "0x7")]
		[Token(Token = "0x60002C5")]
		public static XblMultiplayerJoinability XblMultiplayerManagerJoinability() { }

		[Address(RVA = "0x2B57480", Offset = "0x2B56880", Length = "0x7B")]
		[Token(Token = "0x60002D0")]
		public static int XblMultiplayerManagerJoinGame(string sessionName, string sessionTemplateName, UInt64[] xuids) { }

		[Address(RVA = "0x2B57460", Offset = "0x2B56860", Length = "0x19")]
		[Token(Token = "0x60002C3")]
		public static int XblMultiplayerManagerJoinGameFromLobby(string sessionTemplateName) { }

		[Address(RVA = "0x2B57500", Offset = "0x2B56900", Length = "0x64")]
		[Token(Token = "0x60002C0")]
		public static int XblMultiplayerManagerJoinLobby(string handleId, XUserHandle user) { }

		[Address(RVA = "0x2B57580", Offset = "0x2B56980", Length = "0x7")]
		[Token(Token = "0x60002CB")]
		public static int XblMultiplayerManagerLeaveGame() { }

		[Address(RVA = "0x2B57590", Offset = "0x2B56990", Length = "0x42")]
		[Token(Token = "0x60002E9")]
		public static int XblMultiplayerManagerLobbySessionAddLocalUser(XUserHandle user) { }

		[Address(RVA = "0x2B575E0", Offset = "0x2B569E0", Length = "0x15A")]
		[Token(Token = "0x60002EC")]
		public static XblMultiplayerSessionConstants XblMultiplayerManagerLobbySessionConstants() { }

		[Address(RVA = "0x2B57740", Offset = "0x2B56B40", Length = "0x108")]
		[Token(Token = "0x60002F1")]
		public static int XblMultiplayerManagerLobbySessionCorrelationId(out XblGuid correlationId) { }

		[Address(RVA = "0x2B57850", Offset = "0x2B56C50", Length = "0x194")]
		[Token(Token = "0x60002F7")]
		public static int XblMultiplayerManagerLobbySessionDeleteLocalMemberProperties(XUserHandle user, string name, object context) { }

		[Address(RVA = "0x2B579F0", Offset = "0x2B56DF0", Length = "0x158")]
		[Token(Token = "0x60002E6")]
		public static int XblMultiplayerManagerLobbySessionHost(out XblMultiplayerManagerMember hostMember) { }

		[Address(RVA = "0x2B57B50", Offset = "0x2B56F50", Length = "0x86")]
		[Token(Token = "0x60002E8")]
		public static int XblMultiplayerManagerLobbySessionInviteFriends(XUserHandle requestingUser, string contextStringId, string customActivationContext) { }

		[Address(RVA = "0x2B57BE0", Offset = "0x2B56FE0", Length = "0xC5")]
		[Token(Token = "0x60002E7")]
		public static int XblMultiplayerManagerLobbySessionInviteUsers(XUserHandle user, UInt64[] xuids, string contextStringId, string customActivationContext) { }

		[Address(RVA = "0x2B57CB0", Offset = "0x2B570B0", Length = "0x25")]
		[Token(Token = "0x60002F0")]
		public static bool XblMultiplayerManagerLobbySessionIsHost(ulong xuid) { }

		[Address(RVA = "0x2B57CE0", Offset = "0x2B570E0", Length = "0x8B")]
		[Token(Token = "0x60002EF")]
		public static XblTournamentTeamResult XblMultiplayerManagerLobbySessionLastTournamentTeamResult() { }

		[Address(RVA = "0x2B57D70", Offset = "0x2B57170", Length = "0x1C4")]
		[Token(Token = "0x60002ED")]
		public static int XblMultiplayerManagerLobbySessionLocalMembers(out XblMultiplayerManagerMember[] localMembers) { }

		[Address(RVA = "0x2B57F40", Offset = "0x2B57340", Length = "0x1C4")]
		[Token(Token = "0x60002EA")]
		public static int XblMultiplayerManagerLobbySessionMembers(out XblMultiplayerManagerMember[] members) { }

		[Address(RVA = "0x2B58110", Offset = "0x2B57510", Length = "0x2A")]
		[Token(Token = "0x60002EB")]
		public static string XblMultiplayerManagerLobbySessionPropertiesJson() { }

		[Address(RVA = "0x2B58140", Offset = "0x2B57540", Length = "0x42")]
		[Token(Token = "0x60002EE")]
		public static int XblMultiplayerManagerLobbySessionRemoveLocalUser(XUserHandle user) { }

		[Address(RVA = "0x2B58190", Offset = "0x2B57590", Length = "0x1E2")]
		[Token(Token = "0x60002DC")]
		public static int XblMultiplayerManagerLobbySessionSessionReference(out XblMultiplayerSessionReference sessionReference) { }

		[Address(RVA = "0x2B58380", Offset = "0x2B57780", Length = "0x194")]
		[Token(Token = "0x60002F6")]
		public static int XblMultiplayerManagerLobbySessionSetLocalMemberConnectionAddress(XUserHandle user, string connectionAddress, object context) { }

		[Address(RVA = "0x2B58520", Offset = "0x2B57920", Length = "0x1A3")]
		[Token(Token = "0x60002F4")]
		public static int XblMultiplayerManagerLobbySessionSetLocalMemberProperties(XUserHandle user, string name, string valueJson, object context) { }

		[Address(RVA = "0x2B586D0", Offset = "0x2B57AD0", Length = "0x163")]
		[Token(Token = "0x60002F3")]
		public static int XblMultiplayerManagerLobbySessionSetProperties(string name, string valueJson, object context) { }

		[Address(RVA = "0x2B58840", Offset = "0x2B57C40", Length = "0x146")]
		[Token(Token = "0x60002F2")]
		public static int XblMultiplayerManagerLobbySessionSetSynchronizedHost(string deviceToken, object context) { }

		[Address(RVA = "0x2B58990", Offset = "0x2B57D90", Length = "0x163")]
		[Token(Token = "0x60002F5")]
		public static int XblMultiplayerManagerLobbySessionSetSynchronizedProperties(string name, string valueJson, object context) { }

		[Address(RVA = "0x2B58B00", Offset = "0x2B57F00", Length = "0x7")]
		[Token(Token = "0x60002CC")]
		public static XblMultiplayerMatchStatus XblMultiplayerManagerMatchStatus() { }

		[Address(RVA = "0x2B58B10", Offset = "0x2B57F10", Length = "0x197")]
		[Token(Token = "0x60002C8")]
		public static bool XblMultiplayerManagerMemberAreMembersOnSameDevice(XblMultiplayerManagerMember first, XblMultiplayerManagerMember second) { }

		[Address(RVA = "0x2B58CB0", Offset = "0x2B580B0", Length = "0x2A")]
		[Token(Token = "0x60002C4")]
		public static void XblMultiplayerManagerSetAutoFillMembersDuringMatchmaking(bool autoFillMembers) { }

		[Address(RVA = "0x2B58CE0", Offset = "0x2B580E0", Length = "0x138")]
		[Token(Token = "0x60002C2")]
		public static int XblMultiplayerManagerSetJoinability(XblMultiplayerJoinability joinability, object context) { }

		[Address(RVA = "0x2B58E20", Offset = "0x2B58220", Length = "0x19")]
		[Token(Token = "0x60002C1")]
		public static int XblMultiplayerManagerSetQosMeasurements(string measurementsJson) { }

		[Address(RVA = "0x2B58E40", Offset = "0x2B58240", Length = "0x292")]
		[Token(Token = "0x60002A6")]
		public static void XblMultiplayerQuerySessionsAsync(XblContextHandle xblContext, XblMultiplayerSessionQuery sessionQuery, XblMultiplayerSessionQueryHandleResult completionRoutine) { }

		[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
		[Token(Token = "0x6000295")]
		public static void XblMultiplayerSearchHandleCloseHandle(XblMultiplayerSearchHandle handle) { }

		[Address(RVA = "0x2B590E0", Offset = "0x2B584E0", Length = "0xBC")]
		[Token(Token = "0x60002A0")]
		public static int XblMultiplayerSearchHandleGetCreationTime(XblMultiplayerSearchHandle handle, out DateTime creationTime) { }

		[Address(RVA = "0x2B591A0", Offset = "0x2B585A0", Length = "0x9C")]
		[Token(Token = "0x60002A1")]
		public static int XblMultiplayerSearchHandleGetCustomSessionPropertiesJson(XblMultiplayerSearchHandle handle, out string customPropertiesJson) { }

		[Address(RVA = "0x2B59240", Offset = "0x2B58640", Length = "0x71")]
		[Token(Token = "0x6000297")]
		public static int XblMultiplayerSearchHandleGetId(XblMultiplayerSearchHandle handle, out string id) { }

		[Address(RVA = "0x2B592C0", Offset = "0x2B586C0", Length = "0x1E")]
		[Token(Token = "0x600029D")]
		public static int XblMultiplayerSearchHandleGetJoinRestriction(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionRestriction joinRestriction) { }

		[Address(RVA = "0x2B592E0", Offset = "0x2B586E0", Length = "0xAF")]
		[Token(Token = "0x600029F")]
		public static int XblMultiplayerSearchHandleGetMemberCounts(XblMultiplayerSearchHandle handle, out uint maxMembers, out uint currentMembers) { }

		[Address(RVA = "0x2B59390", Offset = "0x2B58790", Length = "0x1B2")]
		[Token(Token = "0x600029B")]
		public static int XblMultiplayerSearchHandleGetNumberAttributes(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionNumberAttribute[] attributes) { }

		[Address(RVA = "0x2B59550", Offset = "0x2B58950", Length = "0x1E")]
		[Token(Token = "0x600029E")]
		public static int XblMultiplayerSearchHandleGetSessionClosed(XblMultiplayerSearchHandle handle, out bool closed) { }

		[Address(RVA = "0x2B59570", Offset = "0x2B58970", Length = "0x1BF")]
		[Token(Token = "0x6000298")]
		public static int XblMultiplayerSearchHandleGetSessionOwnerXuids(XblMultiplayerSearchHandle handle, out UInt64[] xuids) { }

		[Address(RVA = "0x2B59730", Offset = "0x2B58B30", Length = "0x1F2")]
		[Token(Token = "0x6000296")]
		public static int XblMultiplayerSearchHandleGetSessionReference(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionReference sessionRef) { }

		[Address(RVA = "0x2B59930", Offset = "0x2B58D30", Length = "0x1B2")]
		[Token(Token = "0x600029A")]
		public static int XblMultiplayerSearchHandleGetStringAttributes(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionStringAttribute[] attributes) { }

		[Address(RVA = "0x2B59AF0", Offset = "0x2B58EF0", Length = "0x1B2")]
		[Token(Token = "0x6000299")]
		public static int XblMultiplayerSearchHandleGetTags(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionTag[] tags) { }

		[Address(RVA = "0x2B59CB0", Offset = "0x2B590B0", Length = "0x1E")]
		[Token(Token = "0x600029C")]
		public static int XblMultiplayerSearchHandleGetVisibility(XblMultiplayerSearchHandle handle, out XblMultiplayerSessionVisibility visibility) { }

		[Address(RVA = "0x2B59CD0", Offset = "0x2B590D0", Length = "0x297")]
		[Token(Token = "0x60002AD")]
		public static void XblMultiplayerSendInvitesAsync(XblContextHandle xboxLiveContext, XblMultiplayerSessionReference sessionRef, UInt64[] xboxUserIdList, uint titleId, string contextStringId, string customActivationContext, XblMultiplayerSendInvitesResult completionRoutine) { }

		[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
		[Token(Token = "0x600026F")]
		public static void XblMultiplayerSessionCloseHandle(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B59F70", Offset = "0x2B59370", Length = "0x79")]
		[Token(Token = "0x60002B6")]
		public static XblMultiplayerSessionChangeTypes XblMultiplayerSessionCompare(XblMultiplayerSessionHandle currentSessionHandle, XblMultiplayerSessionHandle oldSessionHandle) { }

		[Address(RVA = "0x2B59FF0", Offset = "0x2B593F0", Length = "0xAA")]
		[Token(Token = "0x600027D")]
		public static int XblMultiplayerSessionConstantsSetCapabilities(XblMultiplayerSessionHandle handle, XblMultiplayerSessionCapabilities capabilities) { }

		[Address(RVA = "0x2B5A0A0", Offset = "0x2B594A0", Length = "0x46")]
		[Token(Token = "0x6000276")]
		public static void XblMultiplayerSessionConstantsSetMaxMembersInSession(XblMultiplayerSessionHandle handle, uint maxMembersInSession) { }

		[Address(RVA = "0x2B5A0F0", Offset = "0x2B594F0", Length = "0x64")]
		[Token(Token = "0x600027C")]
		public static int XblMultiplayerSessionConstantsSetMeasurementServerAddressesJson(XblMultiplayerSessionHandle handle, string measurementServerAddressesJson) { }

		[Address(RVA = "0x2B5A160", Offset = "0x2B59560", Length = "0x8E")]
		[Token(Token = "0x600027A")]
		public static int XblMultiplayerSessionConstantsSetMemberInitialization(XblMultiplayerSessionHandle handle, XblMultiplayerMemberInitialization memberInitialization) { }

		[Address(RVA = "0x2B5A1F0", Offset = "0x2B595F0", Length = "0x80")]
		[Token(Token = "0x600027B")]
		public static int XblMultiplayerSessionConstantsSetPeerToPeerRequirements(XblMultiplayerSessionHandle handle, XblMultiplayerPeerToPeerRequirements requirements) { }

		[Address(RVA = "0x2B5A270", Offset = "0x2B59670", Length = "0xEB")]
		[Token(Token = "0x6000279")]
		public static int XblMultiplayerSessionConstantsSetQosConnectivityMetrics(XblMultiplayerSessionHandle handle, bool enableLatencyMetric, bool enableBandwidthDownMetric, bool enableBandwidthUpMetric, bool enableCustomMetric) { }

		[Address(RVA = "0x2B5A360", Offset = "0x2B59760", Length = "0x7F")]
		[Token(Token = "0x6000278")]
		public static int XblMultiplayerSessionConstantsSetTimeouts(XblMultiplayerSessionHandle handle, ulong memberReservedTimeout, ulong memberInactiveTimeout, ulong memberReadyTimeout, ulong sessionEmptyTimeout) { }

		[Address(RVA = "0x2B5A3E0", Offset = "0x2B597E0", Length = "0x46")]
		[Token(Token = "0x6000277")]
		public static void XblMultiplayerSessionConstantsSetVisibility(XblMultiplayerSessionHandle handle, XblMultiplayerSessionVisibility visibility) { }

		[Address(RVA = "0x2B5A430", Offset = "0x2B59830", Length = "0x18B")]
		[Token(Token = "0x600026E")]
		public static XblMultiplayerSessionHandle XblMultiplayerSessionCreateHandle(ulong xboxUserId, XblMultiplayerSessionReference sessionRef, XblMultiplayerSessionInitArgs initArgs) { }

		[Address(RVA = "0x2B5ACD0", Offset = "0x2B5A0D0", Length = "0x18B")]
		[Token(Token = "0x6000285")]
		public static XblMultiplayerSessionMember XblMultiplayerSessionCurrentUser(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5A5C0", Offset = "0x2B599C0", Length = "0x64")]
		[Token(Token = "0x600028B")]
		public static int XblMultiplayerSessionCurrentUserDeleteCustomPropertyJson(XblMultiplayerSessionHandle handle, string name) { }

		[Address(RVA = "0x2B5A630", Offset = "0x2B59A30", Length = "0x86")]
		[Token(Token = "0x600028A")]
		public static int XblMultiplayerSessionCurrentUserSetCustomPropertyJson(XblMultiplayerSessionHandle handle, string name, string valueJson) { }

		[Address(RVA = "0x2B5A6C0", Offset = "0x2B59AC0", Length = "0x144")]
		[Token(Token = "0x6000287")]
		public static int XblMultiplayerSessionCurrentUserSetEncounters(XblMultiplayerSessionHandle handle, String[] encounters) { }

		[Address(RVA = "0x2B5A810", Offset = "0x2B59C10", Length = "0x144")]
		[Token(Token = "0x6000289")]
		public static int XblMultiplayerSessionCurrentUserSetGroups(XblMultiplayerSessionHandle handle, String[] groups) { }

		[Address(RVA = "0x2B5A960", Offset = "0x2B59D60", Length = "0x83")]
		[Token(Token = "0x6000288")]
		public static int XblMultiplayerSessionCurrentUserSetMembersInGroup(XblMultiplayerSessionHandle handle, UInt32[] memberIds) { }

		[Address(RVA = "0x2B5A9F0", Offset = "0x2B59DF0", Length = "0x202")]
		[Token(Token = "0x6000286")]
		public static int XblMultiplayerSessionCurrentUserSetRoles(XblMultiplayerSessionHandle handle, XblMultiplayerSessionMemberRole[] roles) { }

		[Address(RVA = "0x2B5AC00", Offset = "0x2B5A000", Length = "0x64")]
		[Token(Token = "0x6000293")]
		public static int XblMultiplayerSessionCurrentUserSetSecureDeviceAddressBase64(XblMultiplayerSessionHandle handle, string value) { }

		[Address(RVA = "0x2B5AC70", Offset = "0x2B5A070", Length = "0x55")]
		[Token(Token = "0x6000292")]
		public static int XblMultiplayerSessionCurrentUserSetStatus(XblMultiplayerSessionHandle handle, XblMultiplayerSessionMemberStatus status) { }

		[Address(RVA = "0x2B5AE60", Offset = "0x2B5A260", Length = "0x3B")]
		[Token(Token = "0x60002B5")]
		public static int XblMultiplayerSessionDeleteCustomPropertyJson(XblMultiplayerSessionHandle handle, string name) { }

		[Address(RVA = "0x2B5AEA0", Offset = "0x2B5A2A0", Length = "0xAF")]
		[Token(Token = "0x6000271")]
		public static XblMultiplayerSessionInitializationInfo XblMultiplayerSessionGetInitializationInfo(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5AF50", Offset = "0x2B5A350", Length = "0x1BE")]
		[Token(Token = "0x6000273")]
		public static int XblMultiplayerSessionHostCandidates(XblMultiplayerSessionHandle handle, out XblDeviceToken[] deviceTokens) { }

		[Address(RVA = "0x2B5B110", Offset = "0x2B5A510", Length = "0x5D")]
		[Token(Token = "0x600028D")]
		public static int XblMultiplayerSessionJoin(XblMultiplayerSessionHandle handle, string memberCustomConstantsJson, bool initializeRequested, bool joinWithActiveStatus) { }

		[Address(RVA = "0x2B5B170", Offset = "0x2B5A570", Length = "0x42")]
		[Token(Token = "0x6000291")]
		public static int XblMultiplayerSessionLeave(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5B1C0", Offset = "0x2B5A5C0", Length = "0x18B")]
		[Token(Token = "0x6000284")]
		public static XblMultiplayerMatchmakingServer XblMultiplayerSessionMatchmakingServer(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5B350", Offset = "0x2B5A750", Length = "0x1B2")]
		[Token(Token = "0x6000283")]
		public static int XblMultiplayerSessionMembers(XblMultiplayerSessionHandle handle, out XblMultiplayerSessionMember[] members) { }

		[Address(RVA = "0x2B5B510", Offset = "0x2B5A910", Length = "0x46")]
		[Token(Token = "0x6000280")]
		public static void XblMultiplayerSessionPropertiesSetJoinRestriction(XblMultiplayerSessionHandle handle, XblMultiplayerSessionRestriction joinRestriction) { }

		[Address(RVA = "0x2B5B560", Offset = "0x2B5A960", Length = "0x144")]
		[Token(Token = "0x600027F")]
		public static int XblMultiplayerSessionPropertiesSetKeywords(XblMultiplayerSessionHandle handle, String[] keywords) { }

		[Address(RVA = "0x2B5B6B0", Offset = "0x2B5AAB0", Length = "0x46")]
		[Token(Token = "0x6000281")]
		public static void XblMultiplayerSessionPropertiesSetReadRestriction(XblMultiplayerSessionHandle handle, XblMultiplayerSessionRestriction readRestriction) { }

		[Address(RVA = "0x2B5B700", Offset = "0x2B5AB00", Length = "0x83")]
		[Token(Token = "0x6000282")]
		public static int XblMultiplayerSessionPropertiesSetTurnCollection(XblMultiplayerSessionHandle handle, UInt32[] turnCollectionMemberIds) { }

		[Address(RVA = "0x2B5B790", Offset = "0x2B5AB90", Length = "0x1C5")]
		[Token(Token = "0x60002BF")]
		public static XblMultiplayerSessionReference XblMultiplayerSessionReferenceCreate(string scid, string sessionTemplateName, string sessionName) { }

		[Address(RVA = "0x2B5B960", Offset = "0x2B5AD60", Length = "0x61")]
		[Token(Token = "0x60002CF")]
		public static bool XblMultiplayerSessionReferenceIsValid(XblMultiplayerSessionReference sessionReference) { }

		[Address(RVA = "0x2B5B9D0", Offset = "0x2B5ADD0", Length = "0x1E6")]
		[Token(Token = "0x60002C9")]
		public static int XblMultiplayerSessionReferenceParseFromUriPath(string path, out XblMultiplayerSessionReference sessionReference) { }

		[Address(RVA = "0x2B5BBC0", Offset = "0x2B5AFC0", Length = "0x297")]
		[Token(Token = "0x60002CA")]
		public static int XblMultiplayerSessionReferenceToUriPath(XblMultiplayerSessionReference sessionReference, out XblMultiplayerSessionReferenceUri sessionReferenceUri) { }

		[Address(RVA = "0x2B5BE60", Offset = "0x2B5B260", Length = "0x180")]
		[Token(Token = "0x6000275")]
		public static XblMultiplayerSessionConstants XblMultiplayerSessionSessionConstants(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5BFE0", Offset = "0x2B5B3E0", Length = "0x178")]
		[Token(Token = "0x600027E")]
		public static XblMultiplayerSessionProperties XblMultiplayerSessionSessionProperties(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5C160", Offset = "0x2B5B560", Length = "0x1B1")]
		[Token(Token = "0x6000274")]
		public static XblMultiplayerSessionReference XblMultiplayerSessionSessionReference(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5C320", Offset = "0x2B5B720", Length = "0x49")]
		[Token(Token = "0x600028F")]
		public static void XblMultiplayerSessionSetClosed(XblMultiplayerSessionHandle handle, bool closed) { }

		[Address(RVA = "0x2B5C370", Offset = "0x2B5B770", Length = "0x5B")]
		[Token(Token = "0x60002B4")]
		public static int XblMultiplayerSessionSetCustomPropertyJson(XblMultiplayerSessionHandle handle, string name, string valueJson) { }

		[Address(RVA = "0x2B5C3D0", Offset = "0x2B5B7D0", Length = "0x9E")]
		[Token(Token = "0x600028E")]
		public static void XblMultiplayerSessionSetHostDeviceToken(XblMultiplayerSessionHandle handle, XblDeviceToken hostDeviceToken) { }

		[Address(RVA = "0x2B5C470", Offset = "0x2B5B870", Length = "0x55")]
		[Token(Token = "0x6000290")]
		public static int XblMultiplayerSessionSetSessionChangeSubscription(XblMultiplayerSessionHandle handle, XblMultiplayerSessionChangeTypes changeTypes) { }

		[Address(RVA = "0x2B5C4D0", Offset = "0x2B5B8D0", Length = "0x3F")]
		[Token(Token = "0x6000272")]
		public static XblMultiplayerSessionChangeTypes XblMultiplayerSessionSubscribedChangeTypes(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5C510", Offset = "0x2B5B910", Length = "0x8E")]
		[Token(Token = "0x6000270")]
		public static DateTime XblMultiplayerSessionTimeOfSession(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5C5A0", Offset = "0x2B5B9A0", Length = "0x1D")]
		[Token(Token = "0x600028C")]
		public static XblWriteSessionStatus XblMultiplayerSessionWriteStatus(XblMultiplayerSessionHandle handle) { }

		[Address(RVA = "0x2B5C5C0", Offset = "0x2B5B9C0", Length = "0x1E0")]
		[Token(Token = "0x60002A7")]
		public static void XblMultiplayerSetActivityAsync(XblContextHandle xblContext, XblMultiplayerSessionReference sessionReference, XblMultiplayerSetActivityHandleResult completionRoutine) { }

		[Address(RVA = "0x2B5C7B0", Offset = "0x2B5BBB0", Length = "0x1E")]
		[Token(Token = "0x60002B2")]
		public static int XblMultiplayerSetSubscriptionsEnabled(XblContextHandle xblContext, bool subscriptionsEnabled) { }

		[Address(RVA = "0x2B5C7D0", Offset = "0x2B5BBD0", Length = "0x225")]
		[Token(Token = "0x60002A9")]
		public static void XblMultiplayerSetTransferHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionReference targetSessionReference, XblMultiplayerSessionReference originSessionReference, XblMultiplayerSetTransferHandleResult completionRoutine) { }

		[Address(RVA = "0x2B5CA00", Offset = "0x2B5BE00", Length = "0x1D")]
		[Token(Token = "0x60002B3")]
		public static bool XblMultiplayerSubscriptionsEnabled(XblContextHandle xblHandle) { }

		[Address(RVA = "0x2B5CA20", Offset = "0x2B5BE20", Length = "0x1ED")]
		[Token(Token = "0x60002A2")]
		public static void XblMultiplayerWriteSessionAsync(XblContextHandle xblContext, XblMultiplayerSessionHandle handle, XblMultiplayerSessionWriteMode writeMode, XblMultiplayerWriteSessionHandleResult completionRoutine) { }

		[Address(RVA = "0x2B5CC10", Offset = "0x2B5C010", Length = "0x208")]
		[Token(Token = "0x60002A3")]
		public static void XblMultiplayerWriteSessionByHandleAsync(XblContextHandle xblContext, XblMultiplayerSessionHandle handle, XblMultiplayerSessionWriteMode writeMode, string handleId, XblMultiplayerWriteSessionHandleResult completionRoutine) { }

		[Address(RVA = "0x2B5CE20", Offset = "0x2B5C220", Length = "0x1AC")]
		[Token(Token = "0x60002FE")]
		public static void XblPresenceGetPresenceAsync(XblContextHandle xblContextHandle, ulong xuid, XblPresenceGetPresenceCompleted completionRoutine) { }

		[Address(RVA = "0x2B5CFD0", Offset = "0x2B5C3D0", Length = "0x2D0")]
		[Token(Token = "0x60002FF")]
		public static void XblPresenceGetPresenceForMultipleUsersAsync(XblContextHandle xblContextHandle, UInt64[] xuids, XblPresenceQueryFilters filters, XblPresenceGetPresenceForMultipleUsersCompleted completionRoutine) { }

		[Address(RVA = "0x2B5D2B0", Offset = "0x2B5C6B0", Length = "0x31C")]
		[Token(Token = "0x6000300")]
		public static void XblPresenceGetPresenceForSocialGroupAsync(XblContextHandle xblContextHandle, string socialGroupName, Nullable<UInt64> socialGroupOwnerXuid, XblPresenceQueryFilters filters, XblPresenceGetPresenceForSocialGroupCompleted completionRoutine) { }

		[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
		[Token(Token = "0x60002FC")]
		public static void XblPresenceRecordCloseHandle(XblPresenceRecordHandle handle) { }

		[Address(RVA = "0x2B5D5D0", Offset = "0x2B5C9D0", Length = "0x86")]
		[Token(Token = "0x60002FB")]
		public static int XblPresenceRecordDuplicateHandle(XblPresenceRecordHandle handle, out XblPresenceRecordHandle duplicatedHandle) { }

		[Address(RVA = "0x2B5D660", Offset = "0x2B5CA60", Length = "0x1DC")]
		[Token(Token = "0x60002FA")]
		public static int XblPresenceRecordGetDeviceRecords(XblPresenceRecordHandle handle, out XblPresenceDeviceRecord[] deviceRecords) { }

		[Address(RVA = "0x2B5D840", Offset = "0x2B5CC40", Length = "0x5D")]
		[Token(Token = "0x60002F9")]
		public static int XblPresenceRecordGetUserState(XblPresenceRecordHandle handle, out XblPresenceUserState userState) { }

		[Address(RVA = "0x2B5D8A0", Offset = "0x2B5CCA0", Length = "0x5E")]
		[Token(Token = "0x60002F8")]
		public static int XblPresenceRecordGetXuid(XblPresenceRecordHandle handle, out ulong xuid) { }

		[Address(RVA = "0x2B5D900", Offset = "0x2B5CD00", Length = "0x29D")]
		[Token(Token = "0x60002FD")]
		public static void XblPresenceSetPresenceAsync(XblContextHandle xblContextHandle, bool isUserActiveInTitle, XblPresenceRichPresenceIds richPresenceIds, XblPresenceSetPresenceCompleted completionRoutine) { }

		[Address(RVA = "0x2B5DBA0", Offset = "0x2B5CFA0", Length = "0x269")]
		[Token(Token = "0x6000305")]
		public static void XblPrivacyBatchCheckPermissionAsync(XblContextHandle xblContextHandle, XblPermission[] permissionsToCheck, UInt64[] targetXuids, XblAnonymousUserType[] targetAnonymousUserTypes, XblPrivacyBatchCheckPermissionCompleted completionRoutine) { }

		[Address(RVA = "0x2B5DE10", Offset = "0x2B5D210", Length = "0x1AE")]
		[Token(Token = "0x6000303")]
		public static void XblPrivacyCheckPermissionAsync(XblContextHandle xblContextHandle, XblPermission permissionToCheck, ulong targetXuid, XblPrivacyCheckPermissionCompleted completionRoutine) { }

		[Address(RVA = "0x2B5DFC0", Offset = "0x2B5D3C0", Length = "0x1AB")]
		[Token(Token = "0x6000304")]
		public static void XblPrivacyCheckPermissionForAnonymousUserAsync(XblContextHandle xblContextHandle, XblPermission permissionToCheck, XblAnonymousUserType userType, XblPrivacyCheckPermissionCompleted completionRoutine) { }

		[Address(RVA = "0x2B5E170", Offset = "0x2B5D570", Length = "0x19C")]
		[Token(Token = "0x6000301")]
		public static void XblPrivacyGetAvoidListAsync(XblContextHandle xblContextHandle, XblPrivacyGetAvoidListCompleted completionRoutine) { }

		[Address(RVA = "0x2B5E310", Offset = "0x2B5D710", Length = "0x19C")]
		[Token(Token = "0x6000302")]
		public static void XblPrivacyGetMuteListAsync(XblContextHandle xblContextHandle, XblPrivacyGetMuteListCompleted completionRoutine) { }

		[Address(RVA = "0x2B5E4B0", Offset = "0x2B5D8B0", Length = "0x1A6")]
		[Token(Token = "0x6000306")]
		public static void XblProfileGetUserProfileAsync(XblContextHandle xblContextHandle, ulong xboxUserId, XblProfileGetUserProfileCompleted completionRoutine) { }

		[Address(RVA = "0x2B5E660", Offset = "0x2B5DA60", Length = "0x1D8")]
		[Token(Token = "0x6000307")]
		public static void XblProfileGetUserProfilesAsync(XblContextHandle xblContextHandle, UInt64[] xboxUserIds, XblProfileGetUserProfilesCompleted completionRoutine) { }

		[Address(RVA = "0x2B5E840", Offset = "0x2B5DC40", Length = "0x1BF")]
		[Token(Token = "0x6000308")]
		public static void XblProfileGetUserProfilesForSocialGroupAsync(XblContextHandle xblContextHandle, string socialGroup, XblProfileGetUserProfilesForSocialGroupCompleted completionRoutine) { }

		[Address(RVA = "0x2B5EA00", Offset = "0x2B5DE00", Length = "0x164")]
		[Token(Token = "0x6000309")]
		public static XblRealTimeActivityCallbackToken XblRealTimeActivityAddConnectionStateChangeHandler(XblContextHandle xboxLiveContext, XblConnectionStateChangeCallback callback) { }

		[Address(RVA = "0x2B5EB70", Offset = "0x2B5DF70", Length = "0x166")]
		[Token(Token = "0x600030B")]
		public static XblRealTimeActivityCallbackToken XblRealTimeActivityAddResyncHandler(XblContextHandle xboxLiveContext, XblConnectionResyncCallback callback) { }

		[Address(RVA = "0x2B5ECE0", Offset = "0x2B5E0E0", Length = "0xB2")]
		[Token(Token = "0x600030A")]
		public static int XblRealTimeActivityRemoveConnectionStateChangeHandler(XblContextHandle xboxLiveContext, ref XblRealTimeActivityCallbackToken connectionStateChangeCallbackToken) { }

		[Address(RVA = "0x2B5EDA0", Offset = "0x2B5E1A0", Length = "0xB3")]
		[Token(Token = "0x600030C")]
		public static int XblRealTimeActivityRemoveResyncHandler(XblContextHandle xboxLiveContext, ref XblRealTimeActivityCallbackToken connectionResyncCallbackToken) { }

		[Address(RVA = "0x2B5EE60", Offset = "0x2B5E260", Length = "0x150")]
		[Token(Token = "0x6000314")]
		public static int XblSocialAddSocialRelationshipChangedHandler(XblContextHandle xboxLiveContext, XblSocialRelationshipChangedCallback eventCallback) { }

		[Address(RVA = "0x2B5EFC0", Offset = "0x2B5E3C0", Length = "0x20D")]
		[Token(Token = "0x600030D")]
		public static void XblSocialGetSocialRelationshipsAsync(XblContextHandle xboxLiveContext, ulong xboxUserId, XblSocialRelationshipFilter socialRelationshipFilter, uint startIndex, uint maxItems, XblSocialGetSocialRelationshipsResult completionRoutine) { }

		[Address(RVA = "0x2B5F1D0", Offset = "0x2B5E5D0", Length = "0xA2")]
		[Token(Token = "0x6000319")]
		public static int XblSocialManagerAddLocalUser(XUserHandle user, XblSocialManagerExtraDetailLevel extraLevelDetail) { }

		[Address(RVA = "0x2B5F280", Offset = "0x2B5E680", Length = "0xA1")]
		[Token(Token = "0x600031C")]
		public static int XblSocialManagerCreateSocialUserGroupFromFilters(XUserHandle user, XblPresenceFilter presenceDetailLevel, XblRelationshipFilter filter, out XblSocialManagerUserGroupHandle group) { }

		[Address(RVA = "0x2B5F330", Offset = "0x2B5E730", Length = "0xC0")]
		[Token(Token = "0x600031D")]
		public static int XblSocialManagerCreateSocialUserGroupFromList(XUserHandle user, UInt64[] xboxUserIdList, out XblSocialManagerUserGroupHandle group) { }

		[Address(RVA = "0x2B5F3F0", Offset = "0x2B5E7F0", Length = "0x5B")]
		[Token(Token = "0x600031E")]
		public static int XblSocialManagerDestroySocialUserGroup(XblSocialManagerUserGroupHandle group) { }

		[Address(RVA = "0x2B5F450", Offset = "0x2B5E850", Length = "0x1A2")]
		[Token(Token = "0x600031B")]
		public static int XblSocialManagerDoWork(out XblSocialManagerEvent[] socialEvents) { }

		[Address(RVA = "0x2B5F600", Offset = "0x2B5EA00", Length = "0x1A8")]
		[Token(Token = "0x600031F")]
		public static int XblSocialManagerGetLocalUsers(out XUserHandle[] users) { }

		[Address(RVA = "0x2B5F7B0", Offset = "0x2B5EBB0", Length = "0x3C")]
		[Token(Token = "0x6000316")]
		public static bool XblSocialManagerPresenceRecordIsUserPlayingTitle(XblSocialManagerPresenceRecord presenceRecord, uint titleId) { }

		[Address(RVA = "0x2B5F7F0", Offset = "0x2B5EBF0", Length = "0x42")]
		[Token(Token = "0x600031A")]
		public static int XblSocialManagerRemoveLocalUser(XUserHandle user, XblSocialManagerExtraDetailLevel extraLevelDetail) { }

		[Address(RVA = "0x2B5F840", Offset = "0x2B5EC40", Length = "0x58")]
		[Token(Token = "0x6000321")]
		public static int XblSocialManagerSetRichPresencePollingStatus(XUserHandle user, bool shouldEnablePolling) { }

		[Address(RVA = "0x2B5F8A0", Offset = "0x2B5ECA0", Length = "0x91")]
		[Token(Token = "0x6000320")]
		public static int XblSocialManagerUpdateSocialUserGroup(XblSocialManagerUserGroupHandle group, UInt64[] users) { }

		[Address(RVA = "0x2B5F940", Offset = "0x2B5ED40", Length = "0x73")]
		[Token(Token = "0x6000324")]
		public static int XblSocialManagerUserGroupGetFilters(XblSocialManagerUserGroupHandle group, out XblPresenceFilter presenceFilter, out XblRelationshipFilter relationshipFilter) { }

		[Address(RVA = "0x2B5F9C0", Offset = "0x2B5EDC0", Length = "0x103")]
		[Token(Token = "0x6000323")]
		public static int XblSocialManagerUserGroupGetLocalUser(XblSocialManagerUserGroupHandle group, out XUserHandle localUser) { }

		[Address(RVA = "0x2B5FAD0", Offset = "0x2B5EED0", Length = "0x5D")]
		[Token(Token = "0x6000322")]
		public static int XblSocialManagerUserGroupGetType(XblSocialManagerUserGroupHandle group, out XblSocialUserGroupType type) { }

		[Address(RVA = "0x2B5FD10", Offset = "0x2B5F110", Length = "0x2B5")]
		[Token(Token = "0x6000317")]
		public static int XblSocialManagerUserGroupGetUsers(XblSocialManagerUserGroupHandle group, out XblSocialManagerUser[] xboxSocialUsers) { }

		[Address(RVA = "0x2B5FB30", Offset = "0x2B5EF30", Length = "0x1D5")]
		[Token(Token = "0x6000318")]
		public static int XblSocialManagerUserGroupGetUsersTrackedByGroup(XblSocialManagerUserGroupHandle group, out UInt64[] trackedUsers) { }

		[Address(RVA = "0x2B5FFD0", Offset = "0x2B5F3D0", Length = "0x19")]
		[Token(Token = "0x6000313")]
		public static void XblSocialRelationshipResultCloseHandle(XblSocialRelationshipResult handle) { }

		[Address(RVA = "0x2B5FFF0", Offset = "0x2B5F3F0", Length = "0xDC")]
		[Token(Token = "0x6000312")]
		public static int XblSocialRelationshipResultDuplicateHandle(XblSocialRelationshipResult handle, out XblSocialRelationshipResult duplicatedHandle) { }

		[Address(RVA = "0x2B600D0", Offset = "0x2B5F4D0", Length = "0x1D1")]
		[Token(Token = "0x6000311")]
		public static void XblSocialRelationshipResultGetNextAsync(XblContextHandle xboxLiveContext, XblSocialRelationshipResult result, uint maxItems, XblSocialRelationshipResultGetNextResult completionRoutine) { }

		[Address(RVA = "0x2B602B0", Offset = "0x2B5F6B0", Length = "0x2CA")]
		[Token(Token = "0x600030E")]
		public static int XblSocialRelationshipResultGetRelationships(XblSocialRelationshipResult resultHandle, out XblSocialRelationship[] relationships) { }

		[Address(RVA = "0x2B60580", Offset = "0x2B5F980", Length = "0x62")]
		[Token(Token = "0x6000310")]
		public static int XblSocialRelationshipResultGetTotalCount(XblSocialRelationshipResult result, out uint totalCount) { }

		[Address(RVA = "0x2B605F0", Offset = "0x2B5F9F0", Length = "0x1A")]
		[Token(Token = "0x600030F")]
		public static int XblSocialRelationshipResultHasNext(XblSocialRelationshipResult result, out bool hasNext) { }

		[Address(RVA = "0x2B60610", Offset = "0x2B5FA10", Length = "0xA8")]
		[Token(Token = "0x6000315")]
		public static int XblSocialRemoveSocialRelationshipChangedHandler(XblContextHandle xboxLiveContext, int callbackFunctionId) { }

		[Address(RVA = "0x2B606C0", Offset = "0x2B5FAC0", Length = "0x1B6")]
		[Token(Token = "0x6000325")]
		public static void XblStringVerifyStringAsync(XblContextHandle xblContextHandle, string stringToVerify, XblStringVerifyStringCompleted completionRoutine) { }

		[Address(RVA = "0x2B60880", Offset = "0x2B5FC80", Length = "0x2A3")]
		[Token(Token = "0x6000326")]
		public static void XblStringVerifyStringsAsync(XblContextHandle xblContextHandle, String[] stringsToVerify, XblStringVerifyStringsCompleted completionRoutine) { }

		[Address(RVA = "0x2B60B30", Offset = "0x2B5FF30", Length = "0x281")]
		[Token(Token = "0x6000329")]
		public static void XblTitleManagedStatsDeleteStatsAsync(XblContextHandle xblContextHandle, String[] statisticNames, XblTitleManagedStatsOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B60DC0", Offset = "0x2B601C0", Length = "0x31F")]
		[Token(Token = "0x6000328")]
		public static void XblTitleManagedStatsUpdateStatsAsync(XblContextHandle xblContextHandle, XblTitleManagedStatistic[] statistics, XblTitleManagedStatsOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B610E0", Offset = "0x2B604E0", Length = "0x32F")]
		[Token(Token = "0x6000327")]
		public static void XblTitleManagedStatsWriteAsync(XblContextHandle xblContextHandle, ulong xboxUserId, XblTitleManagedStatistic[] statistics, XblTitleManagedStatsOperationCompleted completionRoutine) { }

		[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
		[Token(Token = "0x600032E")]
		public static void XblTitleStorageBlobMetadataResultCloseHandle(XblTitleStorageBlobMetadataResultHandle handle) { }

		[Address(RVA = "0x2B61410", Offset = "0x2B60810", Length = "0xF2")]
		[Token(Token = "0x600032D")]
		public static int XblTitleStorageBlobMetadataResultDuplicateHandle(XblTitleStorageBlobMetadataResultHandle handle, out XblTitleStorageBlobMetadataResultHandle duplicatedHandle) { }

		[Address(RVA = "0x2B61510", Offset = "0x2B60910", Length = "0x1DC")]
		[Token(Token = "0x600032A")]
		public static int XblTitleStorageBlobMetadataResultGetItems(XblTitleStorageBlobMetadataResultHandle resultHandle, out XblTitleStorageBlobMetadata[] items) { }

		[Address(RVA = "0x2B616F0", Offset = "0x2B60AF0", Length = "0x1AA")]
		[Token(Token = "0x600032C")]
		public static void XblTitleStorageBlobMetadataResultGetNextAsync(XblTitleStorageBlobMetadataResultHandle result, uint maxItems, XblTitleStorageBlobMetadataResultGetNextCompleted completionRoutine) { }

		[Address(RVA = "0x2B618A0", Offset = "0x2B60CA0", Length = "0x5A")]
		[Token(Token = "0x600032B")]
		public static int XblTitleStorageBlobMetadataResultHasNext(XblTitleStorageBlobMetadataResultHandle result, out bool hasNext) { }

		[Address(RVA = "0x2B61900", Offset = "0x2B60D00", Length = "0x21E")]
		[Token(Token = "0x6000331")]
		public static void XblTitleStorageDeleteBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, bool deleteOnlyIfEtagMatches, XblTitleStorageDeleteBlobCompleted completionRoutine) { }

		[Address(RVA = "0x2B61B20", Offset = "0x2B60F20", Length = "0x33F")]
		[Token(Token = "0x6000332")]
		public static void XblTitleStorageDownloadBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, XblTitleStorageETagMatchCondition etagMatchCondition, string selectQuery, ulong preferredDownloadBlockSize, XblTitleStorageDownloadBlobCompleted completionRoutine) { }

		[Address(RVA = "0x2B61E60", Offset = "0x2B61260", Length = "0x214")]
		[Token(Token = "0x6000330")]
		public static void XblTitleStorageGetBlobMetadataAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, XblTitleStorageType storageType, string blobPath, ulong xboxUserId, uint skipItems, uint maxItems, XblTitleStorageGetBlobMetadataCompleted completionRoutine) { }

		[Address(RVA = "0x2B62080", Offset = "0x2B61480", Length = "0x1DE")]
		[Token(Token = "0x600032F")]
		public static void XblTitleStorageGetQuotaAsync(XblContextHandle xboxLiveContext, string serviceConfigurationId, XblTitleStorageType storageType, XblTitleStorageGetQuotaCompleted completionRoutine) { }

		[Address(RVA = "0x2B62260", Offset = "0x2B61660", Length = "0x312")]
		[Token(Token = "0x6000333")]
		public static void XblTitleStorageUploadBlobAsync(XblContextHandle xboxLiveContext, XblTitleStorageBlobMetadata blobMetadata, Byte[] blobBuffer, XblTitleStorageETagMatchCondition etagMatchCondition, ulong preferredDownloadBlockSize, XblTitleStorageUploadBlobCompleted completionRoutine) { }

		[Address(RVA = "0x2B62580", Offset = "0x2B61980", Length = "0x150")]
		[Token(Token = "0x6000338")]
		public static int XblUserStatisticsAddStatisticChangedHandler(XblContextHandle xblContextHandle, XblStatisticChangedCallback eventCallback) { }

		[Address(RVA = "0x2B626E0", Offset = "0x2B61AE0", Length = "0x2D2")]
		[Token(Token = "0x6000336")]
		public static void XblUserStatisticsGetMultipleUserStatisticsAsync(XblContextHandle xblContextHandle, UInt64[] xboxUserIds, string serviceConfigurationId, String[] statisticNames, XblUserStatisticsGetMultipleUserStatisticsCompleted completionRoutine) { }

		[Address(RVA = "0x2B629C0", Offset = "0x2B61DC0", Length = "0x3B3")]
		[Token(Token = "0x6000337")]
		public static void XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsAsync(XblContextHandle xblContextHandle, UInt64[] xboxUserIds, XblRequestedStatistics[] requestedServiceConfigurationStatisticsCollection, XblUserStatisticsGetMultipleUserStatisticsForMultipleServiceConfigurationsCompleted completionRoutine) { }

		[Address(RVA = "0x2B62D80", Offset = "0x2B62180", Length = "0x1DF")]
		[Token(Token = "0x6000334")]
		public static void XblUserStatisticsGetSingleUserStatisticAsync(XblContextHandle xblContextHandle, ulong xboxUserId, string serviceConfigurationId, string statisticName, XblUserStatisticsGetSingleUserStatisticCompleted completionRoutine) { }

		[Address(RVA = "0x2B62F60", Offset = "0x2B62360", Length = "0x2A9")]
		[Token(Token = "0x6000335")]
		public static void XblUserStatisticsGetSingleUserStatisticsAsync(XblContextHandle xblContextHandle, ulong xboxUserId, string serviceConfigurationId, String[] statisticNames, XblUserStatisticsGetSingleUserStatisticsCompleted completionRoutine) { }

		[Address(RVA = "0x2B63210", Offset = "0x2B62610", Length = "0x96")]
		[Token(Token = "0x6000339")]
		public static void XblUserStatisticsRemoveStatisticChangedHandler(XblContextHandle xblContextHandle, int callbackFunctionId) { }

		[Address(RVA = "0x2B632B0", Offset = "0x2B626B0", Length = "0x1EE")]
		[Token(Token = "0x600033B")]
		public static void XblUserStatisticsStopTrackingStatistics(XblContextHandle xblContextHandle, UInt64[] xuids, string serviceConfigurationId, String[] statisticNames) { }

		[Address(RVA = "0x2B634A0", Offset = "0x2B628A0", Length = "0x65")]
		[Token(Token = "0x600033C")]
		public static void XblUserStatisticsStopTrackingUsers(XblContextHandle xblContextHandle, UInt64[] xuids) { }

		[Address(RVA = "0x2B63510", Offset = "0x2B62910", Length = "0x1EE")]
		[Token(Token = "0x600033A")]
		public static void XblUserStatisticsTrackStatistics(XblContextHandle xblContextHandle, UInt64[] xuids, string serviceConfigurationId, String[] statisticNames) { }

	}

	[Token(Token = "0x4000020")]
	private static HCWebSocketRoutedHandler routedCallback; //Field offset: 0x0
	[Token(Token = "0x4000033")]
	private const ulong SessionIdMaxBytes = 256; //Field offset: 0x0
	[Token(Token = "0x4000032")]
	private const ulong ClientIPAddressMaxBytes = 65; //Field offset: 0x0
	[Token(Token = "0x400002F")]
	private const int XUserGamertagComponentUniqueModernMaxBytes = 101; //Field offset: 0x0
	[Token(Token = "0x400002E")]
	private const int XUserGamertagComponentModernSuffixMaxBytes = 15; //Field offset: 0x0
	[Token(Token = "0x400002D")]
	private const int XUserGamertagComponentModernMaxBytes = 97; //Field offset: 0x0
	[Token(Token = "0x400002A")]
	private const string obsoleteXPackageMountMsg = "XPackageMount(string, out XPackageMountHandle) has been removed. Please use XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted) instead."; //Field offset: 0x0
	[Token(Token = "0x400002C")]
	private const int XUserGamertagComponentClassicMaxBytes = 16; //Field offset: 0x0
	[Token(Token = "0x4000022")]
	private const string k_ResourcesFolderName = "GDKEditionAutoGen"; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	private static int hcRoutedHandlerId; //Field offset: 0x8
	[Token(Token = "0x4000023")]
	private static Nullable<Int32> s_CachedEditionNumber; //Field offset: 0xC
	[Token(Token = "0x4000024")]
	private static Dictionary<IntPtr, CallbackWrapper`1<XAsyncWorkInterop>> asyncWorkCallbackDictionary; //Field offset: 0x18
	[Token(Token = "0x4000025")]
	private static XTaskQueueHandle defaultQueue; //Field offset: 0x20
	[Token(Token = "0x4000026")]
	private static bool canBreak; //Field offset: 0x28
	[Token(Token = "0x4000027")]
	private static Thread m_DispatchJob; //Field offset: 0x30
	[Token(Token = "0x4000028")]
	private static bool isInitialized; //Field offset: 0x38
	[Token(Token = "0x4000029")]
	private static bool m_StopExecution; //Field offset: 0x39
	[Token(Token = "0x400002B")]
	private static CallbackWrapper<XErrorCallback> errorCallbackWrapper; //Field offset: 0x40
	[Token(Token = "0x4000034")]
	public static readonly int XPACKAGE_IDENTIFIER_MAX_LENGTH; //Field offset: 0x48
	[Token(Token = "0x4000035")]
	public static readonly int LOCALE_NAME_MAX_LENGTH; //Field offset: 0x4C
	[Token(Token = "0x4000036")]
	public static readonly ulong XSystemAppSpecificDeviceIdBytes; //Field offset: 0x50
	[Token(Token = "0x4000037")]
	public static readonly ulong XSystemConsoleIdBytes; //Field offset: 0x58
	[Token(Token = "0x4000038")]
	public static readonly ulong XSystemXboxLiveSandboxIdMaxBytes; //Field offset: 0x60
	[Token(Token = "0x4000039")]
	public static readonly ulong XUserAudioEndpointMaxUtf16Count; //Field offset: 0x68
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	private XGameStreamingClientId XGameStreamingNullClientId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	private XGameStreamingClientId XGameStreamingAllClients; //Field offset: 0x18

	[Token(Token = "0x14000001")]
	public static event HCWebSocketRoutedHandler HCWebSocketRouted
	{
		[Address(RVA = "0x2B4FBA0", Offset = "0x2B4EFA0", Length = "0x192")]
		[Token(Token = "0x6000048")]
		 add { } //Length: 402
		[Address(RVA = "0x2B4FD40", Offset = "0x2B4F140", Length = "0x13B")]
		[Token(Token = "0x6000049")]
		 remove { } //Length: 315
	}

	[Address(RVA = "0x2B4F9B0", Offset = "0x2B4EDB0", Length = "0x149")]
	[Token(Token = "0x6000235")]
	private static SDK() { }

	[Address(RVA = "0x2B4FB00", Offset = "0x2B4EF00", Length = "0x9A")]
	[Token(Token = "0x6000234")]
	public SDK() { }

	[Address(RVA = "0x2B4FBA0", Offset = "0x2B4EFA0", Length = "0x192")]
	[Token(Token = "0x6000048")]
	public static void add_HCWebSocketRouted(HCWebSocketRoutedHandler value) { }

	[Address(RVA = "0x2B33E10", Offset = "0x2B33210", Length = "0x44E")]
	[Token(Token = "0x600007F")]
	public static void CloseDefaultXTaskQueue() { }

	[Address(RVA = "0x2B34260", Offset = "0x2B33660", Length = "0x25F")]
	[Token(Token = "0x600007E")]
	public static int CreateDefaultTaskQueue() { }

	[Address(RVA = "0x2B344C0", Offset = "0x2B338C0", Length = "0x51")]
	[Token(Token = "0x600007D")]
	private static void DispatchGXDKTaskDone() { }

	[Address(RVA = "0x2B34520", Offset = "0x2B33920", Length = "0x110")]
	[Token(Token = "0x600007C")]
	private static void DispatchGXDKTaskQueue() { }

	[Address(RVA = "0x2B34640", Offset = "0x2B33A40", Length = "0x24D")]
	[Token(Token = "0x600004B")]
	public static int GetGdkEdition() { }

	[Address(RVA = "0x2B34890", Offset = "0x2B33C90", Length = "0x1A4")]
	[Obsolete("This method is deprecated and will be removed. Use the HCWebSocketRouted event instead.", False)]
	[Token(Token = "0x6000046")]
	public static int HCAddWebSocketRoutedHandler(HCWebSocketRoutedHandler handler) { }

	[Address(RVA = "0x2B34A40", Offset = "0x2B33E40", Length = "0x10C")]
	[Token(Token = "0x600003D")]
	public static int HCCleanupAsync(HCCleanupHandler completionRoutine) { }

	[Address(RVA = "0x2B34B50", Offset = "0x2B33F50", Length = "0x49")]
	[Token(Token = "0x600003C")]
	public static int HCInitialize() { }

	[Address(RVA = "0x2B34BA0", Offset = "0x2B33FA0", Length = "0x7")]
	[Obsolete("This method is deprecated and will be removed. Use the HCWebSocketRouted event instead.", False)]
	[Token(Token = "0x6000047")]
	public static void HCRemoveWebSocketRoutedHandler(int handlerId) { }

	[Address(RVA = "0x2B34BB0", Offset = "0x2B33FB0", Length = "0x213")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000039")]
	private static void HCWebSocketBinaryMessageCallback(IntPtr websocket, IntPtr payloadBytes, uint countOfBlobs, IntPtr functionContext) { }

	[Address(RVA = "0x2B34DD0", Offset = "0x2B341D0", Length = "0x17A")]
	[MonoPInvokeCallback]
	[Token(Token = "0x600003A")]
	private static void HCWebSocketCloseCallback(IntPtr websocket, HCWebSocketCloseStatus closeStatus, IntPtr functionContext) { }

	[Address(RVA = "0x2B34F50", Offset = "0x2B34350", Length = "0x5B")]
	[Token(Token = "0x6000045")]
	public static int HCWebSocketCloseHandle(HCWebsocketHandle websocket) { }

	[Address(RVA = "0x2B34FB0", Offset = "0x2B343B0", Length = "0x175")]
	[Token(Token = "0x6000041")]
	public static int HCWebSocketConnectAsync(string uri, string subProtocol, HCWebsocketHandle websocket, HCSocketCompletionResultFunction completionRoutine) { }

	[Address(RVA = "0x2B35130", Offset = "0x2B34530", Length = "0x2E6")]
	[Token(Token = "0x600003E")]
	public static int HCWebSocketCreate(out HCWebsocketHandle websocket, HCWebSocketMessageFunction messageFunc, HCWebSocketBinaryMessageFunction binaryMessageFunc, HCWebSocketCloseEventFunction closeFunc) { }

	[Address(RVA = "0x2B35420", Offset = "0x2B34820", Length = "0x5B")]
	[Token(Token = "0x6000044")]
	public static int HCWebSocketDisconnect(HCWebsocketHandle websocket) { }

	[Address(RVA = "0x2B35480", Offset = "0x2B34880", Length = "0x1E1")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000038")]
	private static void HCWebSocketMessageCallback(IntPtr websocket, IntPtr incomingBodyString, IntPtr functionContext) { }

	[Address(RVA = "0x2B35670", Offset = "0x2B34A70", Length = "0x2AC")]
	[MonoPInvokeCallback]
	[Token(Token = "0x600003B")]
	private static void HCWebSocketRoutedCallback(IntPtr websocket, NativeBool receiving, IntPtr message, IntPtr payloadBytes, SizeT payloadSize, IntPtr conext) { }

	[Address(RVA = "0x2B35920", Offset = "0x2B34D20", Length = "0x158")]
	[Token(Token = "0x6000043")]
	public static int HCWebSocketSendBinaryMessageAsync(HCWebsocketHandle websocket, Byte[] data, uint payloadSize, HCSocketCompletionResultFunction completionRoutine) { }

	[Address(RVA = "0x2B35A80", Offset = "0x2B34E80", Length = "0x150")]
	[Token(Token = "0x6000042")]
	public static int HCWebSocketSendMessageAsync(HCWebsocketHandle websocket, string message, HCSocketCompletionResultFunction completionRoutine) { }

	[Address(RVA = "0x2B35BE0", Offset = "0x2B34FE0", Length = "0x92")]
	[Token(Token = "0x6000040")]
	public static int HCWebSocketSetHeader(HCWebsocketHandle websocket, string headerName, string headerValue) { }

	[Address(RVA = "0x2B35C80", Offset = "0x2B35080", Length = "0x6B")]
	[Token(Token = "0x600003F")]
	public static int HCWebSocketSetProxyUri(HCWebsocketHandle websocket, Byte[] proxyUri) { }

	[Address(RVA = "0x2B35CF0", Offset = "0x2B350F0", Length = "0x105")]
	[Token(Token = "0x600004A")]
	private static void IsHttpClientApiSupported() { }

	[Address(RVA = "0x2B35E00", Offset = "0x2B35200", Length = "0x4EF")]
	[Token(Token = "0x600016A")]
	public static void MarshalXNetworkingSecurityInformationInteropToManaged(IntPtr securityInformationInteropPtr, ref XNetworkingSecurityInformation securityInformation) { }

	[Address(RVA = "0x2B362F0", Offset = "0x2B356F0", Length = "0x51D")]
	[Token(Token = "0x600016B")]
	public static void MarshalXNetworkingSecurityInformationManagedToInterop(XNetworkingSecurityInformation securityInformation, out IntPtr securityInformationInteropPtr) { }

	[Address(RVA = "0x2B36810", Offset = "0x2B35C10", Length = "0x158")]
	[MonoPInvokeCallback(typeof(XAsyncProviderInterop))]
	[Token(Token = "0x60000CF")]
	private static int OnAsyncProvider(XAsyncOp op, XAsyncProviderData data) { }

	[Address(RVA = "0x2B36970", Offset = "0x2B35D70", Length = "0x1CF")]
	[MonoPInvokeCallback(typeof(XAsyncWorkInterop))]
	[Token(Token = "0x6000077")]
	private static int OnAsyncWorkCallback(IntPtr asyncBlock) { }

	[Address(RVA = "0x2B36B40", Offset = "0x2B35F40", Length = "0x12C")]
	[MonoPInvokeCallback(typeof(XGameSaveBlobInfoCallback))]
	[Token(Token = "0x600010D")]
	private static bool OnBlobInfo(XGameSaveBlobInfo info, IntPtr context) { }

	[Address(RVA = "0x2B36C70", Offset = "0x2B36070", Length = "0x146")]
	[MonoPInvokeCallback(typeof(XGameSaveContainerInfoCallback))]
	[Token(Token = "0x6000106")]
	private static bool OnContainerInfo(XGameSaveContainerInfo info, IntPtr context) { }

	[Address(RVA = "0x2B36DC0", Offset = "0x2B361C0", Length = "0x136")]
	[MonoPInvokeCallback(typeof(XErrorCallback))]
	[Token(Token = "0x60000D7")]
	private static bool OnErrorCallback(int hr, string msg, IntPtr context) { }

	[Address(RVA = "0x2B36F00", Offset = "0x2B36300", Length = "0x14A")]
	[MonoPInvokeCallback(typeof(XPackageChunkAvailabilityCallback))]
	[Token(Token = "0x600017C")]
	private static bool OnPackageChunkAvailability(IntPtr context, XPackageChunkSelectorInterop selector, XPackageChunkAvailability availability) { }

	[Address(RVA = "0x2B37050", Offset = "0x2B36450", Length = "0x14F")]
	[MonoPInvokeCallback(typeof(XPackageEnumerationCallback))]
	[Token(Token = "0x6000180")]
	private static bool OnPackageEnumeration(IntPtr context, XPackageDetails details) { }

	[Address(RVA = "0x2B371A0", Offset = "0x2B365A0", Length = "0x11E")]
	[MonoPInvokeCallback(typeof(XStoreProductQueryCallbackInterop))]
	[Token(Token = "0x60001AD")]
	private static bool OnProductQueryCallback(in XStoreProductInterop product, IntPtr context) { }

	[Address(RVA = "0x2B372C0", Offset = "0x2B366C0", Length = "0x13E")]
	[MonoPInvokeCallback(typeof(XSpeechSynthesizerInstalledVoicesCallback))]
	[Token(Token = "0x6000194")]
	private static bool OnSpeechSynthesizerInstalledVoicesCallback(ref XSpeechSynthesizerVoiceInformation information, IntPtr context) { }

	[Address(RVA = "0x2B37400", Offset = "0x2B36800", Length = "0x148")]
	[MonoPInvokeCallback(typeof(XPackageFeatureEnumerationCallbackInterop))]
	[Token(Token = "0x600017E")]
	private static bool OnXPackageFeature(IntPtr context, XPackageFeature feature) { }

	[Address(RVA = "0x2B37550", Offset = "0x2B36950", Length = "0x1C9")]
	[Token(Token = "0x600016C")]
	private static int ProcessChunkSelector(XPackageChunkSelector[] selectors, ref XPackageChunkSelectorInterop[] nativeSelectors, out List<IntPtr>& stringsToFree) { }

	[Address(RVA = "0x2B37720", Offset = "0x2B36B20", Length = "0x2E5")]
	[Token(Token = "0x600011C")]
	private static int ProcessTouchControlOperation(ref XGameStreamingTouchControlsStateOperation[] operations, out XGameStreamingTouchControlsStateOperation[] nativeOperations, out List<IntPtr>& stringsToFree) { }

	[Address(RVA = "0x2B4FD40", Offset = "0x2B4F140", Length = "0x13B")]
	[Token(Token = "0x6000049")]
	public static void remove_HCWebSocketRouted(HCWebSocketRoutedHandler value) { }

	[Address(RVA = "0x2B37A10", Offset = "0x2B36E10", Length = "0xF9")]
	[Token(Token = "0x6000055")]
	public static int XAppBroadcastGetStatus(XUserHandle requestingUser, out XAppBroadcastStatus appBroadcastStatus) { }

	[Address(RVA = "0x2B37B10", Offset = "0x2B36F10", Length = "0x7")]
	[Token(Token = "0x6000056")]
	public static bool XAppBroadcastIsAppBroadcasting() { }

	[Address(RVA = "0x2B37B20", Offset = "0x2B36F20", Length = "0xB2")]
	[Token(Token = "0x60000CA")]
	public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XAppBroadcastMonitorCallback callback, out XIsAppBroadcastingChangedRegistrationToken token) { }

	[Address(RVA = "0x2B37BE0", Offset = "0x2B36FE0", Length = "0x1F6")]
	[Token(Token = "0x6000058")]
	public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XTaskQueueHandle queue, IntPtr context, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out XIsAppBroadcastingChangedRegistrationToken token) { }

	[Address(RVA = "0x2B37DE0", Offset = "0x2B371E0", Length = "0x72")]
	[Token(Token = "0x6000059")]
	public static int XAppBroadcastRegisterIsAppBroadcastingChanged(XTaskQueueHandle queue, XAppBroadcastMonitorCallback appBroadcastMonitorCallback, out XIsAppBroadcastingChangedRegistrationToken token) { }

	[Address(RVA = "0x2B37E60", Offset = "0x2B37260", Length = "0x45")]
	[Token(Token = "0x6000057")]
	public static int XAppBroadcastShowUI(XUserHandle requestingUser) { }

	[Address(RVA = "0x2B37ED0", Offset = "0x2B372D0", Length = "0x56")]
	[Token(Token = "0x60000CB")]
	public static bool XAppBroadcastUnregisterIsAppBroadcastingChanged(XIsAppBroadcastingChangedRegistrationToken token) { }

	[Address(RVA = "0x2B37EB0", Offset = "0x2B372B0", Length = "0x1A")]
	[Token(Token = "0x600005F")]
	public static bool XAppBroadcastUnregisterIsAppBroadcastingChanged(XIsAppBroadcastingChangedRegistrationToken token, bool wait) { }

	[Address(RVA = "0x2B37F30", Offset = "0x2B37330", Length = "0x23")]
	[Token(Token = "0x600005A")]
	public static int XAppCaptureCloseLocalStream(XAppCaptureLocalStreamHandle handle) { }

	[Address(RVA = "0x2B37F60", Offset = "0x2B37360", Length = "0x7")]
	[Obsolete("Please use XAppCaptureCloseScreenshotStream(XAppCaptureScreenshotStreamHandle) instead.", False)]
	[Token(Token = "0x600005B")]
	public static int XAppCaptureCloseScreenshotStream(IntPtr handle) { }

	[Address(RVA = "0x2B37F30", Offset = "0x2B37330", Length = "0x23")]
	[Token(Token = "0x600005C")]
	public static int XAppCaptureCloseScreenshotStream(XAppCaptureScreenshotStreamHandle handle) { }

	[Address(RVA = "0x2B37F70", Offset = "0x2B37370", Length = "0x7")]
	[Token(Token = "0x600005E")]
	public static int XAppCaptureDisableRecord() { }

	[Address(RVA = "0x2B37F80", Offset = "0x2B37380", Length = "0x7")]
	[Token(Token = "0x600005D")]
	public static int XAppCaptureEnableRecord() { }

	[Address(RVA = "0x2B37F90", Offset = "0x2B37390", Length = "0xD3")]
	[Token(Token = "0x6000076")]
	public static int XAppCaptureGetVideoCaptureSettings(out XAppCaptureVideoCaptureSettings userCaptureSettings) { }

	[Address(RVA = "0x2B38070", Offset = "0x2B37470", Length = "0x8")]
	[Token(Token = "0x6000062")]
	public static int XAppCaptureMetadataAddDoubleEvent(string name, double value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B38080", Offset = "0x2B37480", Length = "0x8")]
	[Token(Token = "0x6000061")]
	public static int XAppCaptureMetadataAddInt32Event(string name, int value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B38090", Offset = "0x2B37490", Length = "0x8")]
	[Token(Token = "0x6000060")]
	public static int XAppCaptureMetadataAddStringEvent(string name, string value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B380A0", Offset = "0x2B374A0", Length = "0x7")]
	[Token(Token = "0x6000068")]
	public static int XAppCaptureMetadataRemainingStorageBytesAvailable(out ulong value) { }

	[Address(RVA = "0x2B380B0", Offset = "0x2B374B0", Length = "0x8")]
	[Token(Token = "0x6000065")]
	public static int XAppCaptureMetadataStartDoubleState(string name, double value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B380C0", Offset = "0x2B374C0", Length = "0x8")]
	[Token(Token = "0x6000064")]
	public static int XAppCaptureMetadataStartInt32State(string name, int value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B380D0", Offset = "0x2B374D0", Length = "0x8")]
	[Token(Token = "0x6000063")]
	public static int XAppCaptureMetadataStartStringState(string name, string value, XAppCaptureMetadataPriority priority) { }

	[Address(RVA = "0x2B380E0", Offset = "0x2B374E0", Length = "0x7")]
	[Token(Token = "0x6000067")]
	public static int XAppCaptureMetadataStopAllStates() { }

	[Address(RVA = "0x2B380F0", Offset = "0x2B374F0", Length = "0x7")]
	[Token(Token = "0x6000066")]
	public static int XAppCaptureMetadataStopState(string name) { }

	[Address(RVA = "0x2B38180", Offset = "0x2B37580", Length = "0x72")]
	[Token(Token = "0x600006A")]
	public static int XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag screenshotFormat, out XAppCaptureScreenshotStreamHandle handle, out ulong totalBytes) { }

	[Address(RVA = "0x2B38100", Offset = "0x2B37500", Length = "0x7F")]
	[Obsolete("Use XAppCaptureOpenScreenshotStream(string localId, XAppCaptureScreenshotFormatFlag, out XAppCaptureScreenshotStreamHandle, out UInt64)", False)]
	[Token(Token = "0x6000069")]
	public static int XAppCaptureOpenScreenshotStream(XAppScreenshotLocalId id, XAppCaptureScreenshotFormatFlag screenshotFormat, out IntPtr handle, out ulong totalBytes) { }

	[Address(RVA = "0x2B38200", Offset = "0x2B37600", Length = "0x27")]
	[Token(Token = "0x6000073")]
	public static int XAppCaptureReadLocalStream(XAppCaptureLocalStreamHandle handle, long startPosition, uint bytesToRead, ref Byte[] buffer, out uint bytesWritten) { }

	[Address(RVA = "0x2B38230", Offset = "0x2B37630", Length = "0x24")]
	[Token(Token = "0x600006C")]
	public static int XAppCaptureReadScreenshotStream(XAppCaptureScreenshotStreamHandle handle, ulong startPosition, uint bytesToRead, Byte[] buffer, out uint bytesWritten) { }

	[Address(RVA = "0x2B38260", Offset = "0x2B37660", Length = "0x2E")]
	[Obsolete("Use XAppCaptureReadScreenshotStream(XAppCaptureScreenshotStreamHandle, UInt64, UInt32, byte[], out UInt32)", False)]
	[Token(Token = "0x600006B")]
	public static int XAppCaptureReadScreenshotStream(IntPtr handle, ulong startPosition, uint totalBytes, Byte[] data, out int bytesWritten) { }

	[Address(RVA = "0x2B383D0", Offset = "0x2B377D0", Length = "0x1EA")]
	[Token(Token = "0x60000E4")]
	public static int XAppCaptureRecordDiagnosticClip(DateTime startTime, uint durationInMS, string fileNamePrefix, out XAppCaptureRecordClipResult result) { }

	[Address(RVA = "0x2B38290", Offset = "0x2B37690", Length = "0x133")]
	[Token(Token = "0x600006D")]
	public static int XAppCaptureRecordDiagnosticClip(long startTime, uint durationInMs, string filenamePrefix, out XAppCaptureRecordClipResult result) { }

	[Address(RVA = "0x2B386F0", Offset = "0x2B37AF0", Length = "0x223")]
	[Token(Token = "0x6000074")]
	public static int XAppCaptureRecordTimespan(SYSTEMTIME startTimestamp, ulong durationInMilliseconds, out XAppCaptureLocalResult result) { }

	[Address(RVA = "0x2B385C0", Offset = "0x2B379C0", Length = "0x12C")]
	[Token(Token = "0x6000075")]
	public static int XAppCaptureRecordTimespan(ulong durationInMilliseconds, out XAppCaptureLocalResult result) { }

	[Address(RVA = "0x2B38BA0", Offset = "0x2B37FA0", Length = "0xB2")]
	[Token(Token = "0x60000CC")]
	public static int XAppCaptureRegisterMetadataPurged(XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token) { }

	[Address(RVA = "0x2B38B20", Offset = "0x2B37F20", Length = "0x72")]
	[Token(Token = "0x6000071")]
	public static int XAppCaptureRegisterMetadataPurged(XTaskQueueHandle queue, XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token) { }

	[Address(RVA = "0x2B38920", Offset = "0x2B37D20", Length = "0x1F5")]
	[Token(Token = "0x6000070")]
	public static int XAppCaptureRegisterMetadataPurged(XTaskQueueHandle queue, IntPtr context, XAppCaptureMetadataPurgedCallback callback, out XMetadataPurgedToken token) { }

	[Address(RVA = "0x2B38C60", Offset = "0x2B38060", Length = "0xE5")]
	[Token(Token = "0x600006E")]
	public static int XAppCaptureTakeDiagnosticScreenshot(bool gamescreenOnly, XAppCaptureScreenshotFormatFlag captureFlags, string filenamePrefix, out XAppCaptureDiagnosticScreenshotResult result) { }

	[Address(RVA = "0x2B38D50", Offset = "0x2B38150", Length = "0xE8")]
	[Token(Token = "0x600006F")]
	public static int XAppCaptureTakeScreenshot(XUserHandle requestingUser, out XAppCaptureTakeScreenshotResult result) { }

	[Address(RVA = "0x2B38E40", Offset = "0x2B38240", Length = "0x1A")]
	[Token(Token = "0x6000072")]
	public static bool XAppCaptureUnRegisterMetadataPurged(XMetadataPurgedToken token, bool wait) { }

	[Address(RVA = "0x2B38E60", Offset = "0x2B38260", Length = "0x56")]
	[Token(Token = "0x60000CD")]
	public static bool XAppCaptureUnRegisterMetadataPurged(XMetadataPurgedToken token) { }

	[Address(RVA = "0x2B38EC0", Offset = "0x2B382C0", Length = "0x25F")]
	[Token(Token = "0x60000D0")]
	public static int XAsyncBegin(XAsyncBlock asyncBlock, IntPtr context, IntPtr identity, string identityName, XAsyncProvider provider) { }

	[Address(RVA = "0x2B39120", Offset = "0x2B38520", Length = "0x150")]
	[Token(Token = "0x600007A")]
	public static void XAsyncCancel(XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B39280", Offset = "0x2B38680", Length = "0x3A")]
	[Token(Token = "0x60000D2")]
	public static void XAsyncComplete(XAsyncBlock asyncBlock, uint result, ulong requiredBufferSize) { }

	[Address(RVA = "0x2B392F0", Offset = "0x2B386F0", Length = "0x5E")]
	[Token(Token = "0x60000D3")]
	public static int XAsyncGetResult(XAsyncBlock asyncBlock, IntPtr identity, Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B392C0", Offset = "0x2B386C0", Length = "0x2D")]
	[Token(Token = "0x6000079")]
	public static int XAsyncGetResultSize(XAsyncBlock asyncBlock, out ulong bufferSize) { }

	[Address(RVA = "0x2B39350", Offset = "0x2B38750", Length = "0x2D")]
	[Token(Token = "0x6000078")]
	public static int XAsyncGetStatus(XAsyncBlock asyncBlock, bool wait) { }

	[Address(RVA = "0x2B39380", Offset = "0x2B38780", Length = "0x2EF")]
	[Token(Token = "0x600007B")]
	public static int XAsyncRun(XAsyncBlock asyncBlock, XAsyncWork work) { }

	[Address(RVA = "0x2B39670", Offset = "0x2B38A70", Length = "0x2B")]
	[Token(Token = "0x60000D1")]
	public static int XAsyncSchedule(XAsyncBlock asyncBlock, uint delayInMs) { }

	[Address(RVA = "0x2B396A0", Offset = "0x2B38AA0", Length = "0x102")]
	[Token(Token = "0x600004C")]
	public static int XClosedCaptionGetProperties(out XClosedCaptionProperties properties) { }

	[Address(RVA = "0x2B397B0", Offset = "0x2B38BB0", Length = "0x7")]
	[Token(Token = "0x600004D")]
	public static int XClosedCaptionSetEnabled(bool enabled) { }

	[Address(RVA = "0x2B397C0", Offset = "0x2B38BC0", Length = "0xA9")]
	[Token(Token = "0x60000D5")]
	public static int XDisplayAcquireTimeoutDeferral(out XDisplayTimeoutDeferralHandle handle) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60000D6")]
	public static void XDisplayCloseTimeoutDeferralHandle(XDisplayTimeoutDeferralHandle handle) { }

	[Address(RVA = "0x2B39890", Offset = "0x2B38C90", Length = "0xB7")]
	[Token(Token = "0x60000D4")]
	public static XDisplayHdrModeResult XDisplayTryEnableHdrMode(XDisplayHdrModePreference displayModePreference, out XDisplayHdrModeInfo displayHdrModeInfo) { }

	[Address(RVA = "0x2B39950", Offset = "0x2B38D50", Length = "0x305")]
	[Token(Token = "0x60000D8")]
	public static void XErrorSetCallback(XErrorCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B39C60", Offset = "0x2B39060", Length = "0x8")]
	[Token(Token = "0x60000D9")]
	public static void XErrorSetOptions(XErrorOptions optionsDebuggerPresent, XErrorOptions optionsDebuggerNotPresent) { }

	[Address(RVA = "0x2B39C70", Offset = "0x2B39070", Length = "0x74")]
	[Token(Token = "0x60000EE")]
	public static int XGameEventWrite(XUserHandle user, string serviceConfigId, string playSessionId, string eventName, string dimensionsJson, string measurementsJson) { }

	[Address(RVA = "0x2B39CF0", Offset = "0x2B390F0", Length = "0x7")]
	[Token(Token = "0x60000EB")]
	public static int XGameGetXboxTitleId(out uint titleId) { }

	[Address(RVA = "0x2B39F90", Offset = "0x2B39390", Length = "0xB3")]
	[Token(Token = "0x60000CE")]
	public static int XGameInviteRegisterForEvent(XGameInviteEventCallback callback, out XGameInviteRegistrationToken token) { }

	[Address(RVA = "0x2B39D80", Offset = "0x2B39180", Length = "0x206")]
	[Token(Token = "0x60000EF")]
	public static int XGameInviteRegisterForEvent(XTaskQueueHandle handle, XGameInviteEventCallback callback, IntPtr context, out XGameInviteRegistrationToken token) { }

	[Address(RVA = "0x2B39D00", Offset = "0x2B39100", Length = "0x73")]
	[Token(Token = "0x60000F0")]
	public static int XGameInviteRegisterForEvent(XTaskQueueHandle handle, XGameInviteEventCallback callback, out XGameInviteRegistrationToken token) { }

	[Address(RVA = "0x2B3A0B0", Offset = "0x2B394B0", Length = "0x1A")]
	[Token(Token = "0x60000F1")]
	public static bool XGameInviteUnregisterForEvent(XGameInviteRegistrationToken token, bool wait) { }

	[Address(RVA = "0x2B3A050", Offset = "0x2B39450", Length = "0x56")]
	[Token(Token = "0x60000F2")]
	public static bool XGameInviteUnregisterForEvent(XGameInviteRegistrationToken token) { }

	[Address(RVA = "0x2B3A0D0", Offset = "0x2B394D0", Length = "0x1F5")]
	[Token(Token = "0x60000F3")]
	public static int XGameProtocolRegisterForActivation(XTaskQueueHandle queue, IntPtr context, XGameProtocolActivationCallback callback, out XGameProtocolActivationToken token) { }

	[Address(RVA = "0x2B3A2D0", Offset = "0x2B396D0", Length = "0x1A")]
	[Token(Token = "0x60000F4")]
	public static bool XGameProtocolUnregisterForActivation(XGameProtocolActivationToken token, bool wait) { }

	[Address(RVA = "0x2B3A310", Offset = "0x2B39710", Length = "0x7")]
	[Token(Token = "0x60000F6")]
	public static int XGameRuntimeInitialize() { }

	[Address(RVA = "0x2B3A2F0", Offset = "0x2B396F0", Length = "0x1D")]
	[Token(Token = "0x60000F7")]
	private static int XGameRuntimeInitializeWithOptions(XGameRuntimeOptions options) { }

	[Address(RVA = "0x2B3A320", Offset = "0x2B39720", Length = "0x7")]
	[Token(Token = "0x60000F5")]
	public static bool XGameRuntimeIsFeatureAvailable(XGameRuntimeFeature feature) { }

	[Address(RVA = "0x2B3A330", Offset = "0x2B39730", Length = "0x7")]
	[Token(Token = "0x60000F8")]
	public static void XGameRuntimeUninitialize() { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60000FA")]
	public static void XGameSaveCloseContainer(XGameSaveContainerHandle context) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60000FB")]
	public static void XGameSaveCloseProvider(XGameSaveProviderHandle provider) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60000FC")]
	public static void XGameSaveCloseUpdate(XGameSaveUpdateHandle context) { }

	[Address(RVA = "0x2B3A340", Offset = "0x2B39740", Length = "0x53")]
	[Obsolete("Please use XGameSaveCloseUpdate(XGameSaveUpdateHandle context) instead. (UnityUpgradable) -> XGameSaveCloseUpdate(*)", True)]
	[Token(Token = "0x6000082")]
	public static void XGameSaveCloseUpdateHandle(XGameSaveUpdateHandle updateHandle) { }

	[Address(RVA = "0x2B3A3A0", Offset = "0x2B397A0", Length = "0xC1")]
	[Token(Token = "0x600010B")]
	public static int XGameSaveCreateContainer(XGameSaveProviderHandle provider, string containerName, out XGameSaveContainerHandle containerContext) { }

	[Address(RVA = "0x2B3A470", Offset = "0x2B39870", Length = "0xC1")]
	[Token(Token = "0x6000111")]
	public static int XGameSaveCreateUpdate(XGameSaveContainerHandle container, string containerDisplayName, out XGameSaveUpdateHandle updateContext) { }

	[Address(RVA = "0x2B3A760", Offset = "0x2B39B60", Length = "0x1E")]
	[Token(Token = "0x6000103")]
	public static int XGameSaveDeleteContainer(XGameSaveProviderHandle provider, string containerName) { }

	[Address(RVA = "0x2B3A540", Offset = "0x2B39940", Length = "0x191")]
	[Token(Token = "0x6000083")]
	public static int XGameSaveDeleteContainerAsync(XGameSaveProviderHandle gameSaveProviderHandle, string containerName, XGameSaveDeleteContainerCompleted onCompleted) { }

	[Address(RVA = "0x2B3A6E0", Offset = "0x2B39AE0", Length = "0x45")]
	[Token(Token = "0x6000104")]
	public static int XGameSaveDeleteContainerAsync(XGameSaveProviderHandle provider, string containerName, XAsyncBlock async) { }

	[Address(RVA = "0x2B3A730", Offset = "0x2B39B30", Length = "0x23")]
	[Token(Token = "0x6000105")]
	public static int XGameSaveDeleteContainerResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B3AD80", Offset = "0x2B3A180", Length = "0x176")]
	[Token(Token = "0x60000DA")]
	public static int XGameSaveEnumerateBlobInfo(XGameSaveContainerHandle container, out XGameSaveBlobInfo[] blobInfos) { }

	[Address(RVA = "0x2B3AB50", Offset = "0x2B39F50", Length = "0x22A")]
	[Token(Token = "0x600010E")]
	public static int XGameSaveEnumerateBlobInfo(XGameSaveContainerHandle container, IntPtr context, XGameSaveBlobInfoCallback callback) { }

	[Address(RVA = "0x2B3A9C0", Offset = "0x2B39DC0", Length = "0x18F")]
	[Token(Token = "0x60000DE")]
	public static int XGameSaveEnumerateBlobInfoByName(XGameSaveContainerHandle provider, string blobNamePrefix, out XGameSaveBlobInfo[] blobInfos) { }

	[Address(RVA = "0x2B3A780", Offset = "0x2B39B80", Length = "0x238")]
	[Token(Token = "0x600010F")]
	public static int XGameSaveEnumerateBlobInfoByName(XGameSaveContainerHandle container, string blobNamePrefix, IntPtr context, XGameSaveBlobInfoCallback callback) { }

	[Address(RVA = "0x2B3B2D0", Offset = "0x2B3A6D0", Length = "0x22A")]
	[Token(Token = "0x6000108")]
	public static int XGameSaveEnumerateContainerInfo(XGameSaveProviderHandle provider, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B3B500", Offset = "0x2B3A900", Length = "0x176")]
	[Token(Token = "0x60000DC")]
	public static int XGameSaveEnumerateContainerInfo(XGameSaveProviderHandle provider, out XGameSaveContainerInfo[] localInfos) { }

	[Address(RVA = "0x2B3B140", Offset = "0x2B3A540", Length = "0x18F")]
	[Token(Token = "0x60000DD")]
	public static int XGameSaveEnumerateContainerInfoByName(XGameSaveProviderHandle provider, string containerNamePrefix, out XGameSaveContainerInfo[] localInfos) { }

	[Address(RVA = "0x2B3AF00", Offset = "0x2B3A300", Length = "0x238")]
	[Token(Token = "0x6000109")]
	public static int XGameSaveEnumerateContainerInfoByName(XGameSaveProviderHandle provider, string containerNamePrefix, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B3B680", Offset = "0x2B3AA80", Length = "0x1BA")]
	[Token(Token = "0x6000088")]
	public static int XGameSaveFilesGetFolderWithUiAsync(XUserHandle requestingUser, string configurationId, XGameSaveFilesGetFolderWithUiCompleted onCompleted) { }

	[Address(RVA = "0x2B3B840", Offset = "0x2B3AC40", Length = "0x72")]
	[Token(Token = "0x6000118")]
	public static int XGameSaveFilesGetFolderWithUiAsync(XUserHandle requestingUser, string configurationId, XAsyncBlock async) { }

	[Address(RVA = "0x2B3B8C0", Offset = "0x2B3ACC0", Length = "0xDB")]
	[Token(Token = "0x6000119")]
	public static int XGameSaveFilesGetFolderWithUiResult(XAsyncBlock async, ulong folderSize, out string folderResult) { }

	[Address(RVA = "0x2B3B9A0", Offset = "0x2B3ADA0", Length = "0x3B")]
	[Obsolete("Please use XGameSaveFilesGetRemainingQuota(XUserHandle, string, out UInt64) instead", False)]
	[Token(Token = "0x600011A")]
	public static int XGameSaveFilesGetRemainingQuota(XUserHandle userContext, string configurationId, out long remainingQuota) { }

	[Address(RVA = "0x2B3B9E0", Offset = "0x2B3ADE0", Length = "0x5B")]
	[Token(Token = "0x600011B")]
	public static int XGameSaveFilesGetRemainingQuota(XUserHandle userContext, string configurationId, out ulong remainingQuota) { }

	[Address(RVA = "0x2B3BA40", Offset = "0x2B3AE40", Length = "0x238")]
	[Token(Token = "0x6000107")]
	public static int XGameSaveGetContainerInfo(XGameSaveProviderHandle provider, string containerName, IntPtr context, XGameSaveContainerInfoCallback callback) { }

	[Address(RVA = "0x2B3BC80", Offset = "0x2B3B080", Length = "0x13C")]
	[Token(Token = "0x60000DB")]
	public static int XGameSaveGetContainerInfo(XGameSaveProviderHandle provider, string containerName, out XGameSaveContainerInfo containerInfo) { }

	[Address(RVA = "0x2B3BFD0", Offset = "0x2B3B3D0", Length = "0x1E")]
	[Token(Token = "0x6000100")]
	public static int XGameSaveGetRemainingQuota(XGameSaveProviderHandle provider, out long remainingQuota) { }

	[Address(RVA = "0x2B3BE00", Offset = "0x2B3B200", Length = "0x192")]
	[Token(Token = "0x6000084")]
	public static int XGameSaveGetRemainingQuotaAsync(XGameSaveProviderHandle provider, XGameSaveGetRemainingQuotaCompleted onCompleted) { }

	[Address(RVA = "0x2B3BDC0", Offset = "0x2B3B1C0", Length = "0x39")]
	[Token(Token = "0x6000101")]
	public static int XGameSaveGetRemainingQuotaAsync(XGameSaveProviderHandle provider, XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B3BFA0", Offset = "0x2B3B3A0", Length = "0x2D")]
	[Token(Token = "0x6000102")]
	public static int XGameSaveGetRemainingQuotaResult(XAsyncBlock async, out long remainingQuota) { }

	[Address(RVA = "0x2B3C330", Offset = "0x2B3B730", Length = "0xFD")]
	[Token(Token = "0x60000FD")]
	public static int XGameSaveInitializeProvider(XUserHandle requestingUser, string configurationId, bool syncOnDemand, out XGameSaveProviderHandle provider) { }

	[Address(RVA = "0x2B3C1C0", Offset = "0x2B3B5C0", Length = "0x8A")]
	[Token(Token = "0x60000FE")]
	public static int XGameSaveInitializeProviderAsync(XUserHandle requestingUser, string configurationId, bool syncOnDemand, XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B3BFF0", Offset = "0x2B3B3F0", Length = "0x1CF")]
	[Token(Token = "0x6000085")]
	public static int XGameSaveInitializeProviderAsync(XUserHandle requestingUser, string configurationId, bool syncOnDemand, XGameSaveInitializeProviderCompleted onCompleted) { }

	[Address(RVA = "0x2B3C250", Offset = "0x2B3B650", Length = "0xD5")]
	[Token(Token = "0x60000FF")]
	public static int XGameSaveInitializeProviderResult(XAsyncBlock asyncBlock, out XGameSaveProviderHandle provider) { }

	[Address(RVA = "0x2B3CA40", Offset = "0x2B3BE40", Length = "0x4AD")]
	[Token(Token = "0x600010A")]
	public static int XGameSaveReadBlobData(XGameSaveContainerHandle container, XGameSaveBlobInfo[] blobInfos, out XGameSaveBlob[] blobData) { }

	[Address(RVA = "0x2B3C920", Offset = "0x2B3BD20", Length = "0x113")]
	[Token(Token = "0x60000DF")]
	public static int XGameSaveReadBlobData(XGameSaveContainerHandle container, List<XGameSaveBlobInfo> blobInfos, out List<XGameSaveBlob>& blobs) { }

	[Address(RVA = "0x2B3C490", Offset = "0x2B3B890", Length = "0x1A3")]
	[Token(Token = "0x6000086")]
	public static int XGameSaveReadBlobDataAsync(XGameSaveContainerHandle container, String[] blobNames, XGameSaveReadBlobDataCompleted onCompleted) { }

	[Address(RVA = "0x2B3C430", Offset = "0x2B3B830", Length = "0x55")]
	[Token(Token = "0x6000110")]
	public static int XGameSaveReadBlobDataAsync(XGameSaveContainerHandle container, String[] blobNames, XAsyncBlock async) { }

	[Address(RVA = "0x2B3C640", Offset = "0x2B3BA40", Length = "0x2DA")]
	[Token(Token = "0x600010C")]
	public static int XGameSaveReadBlobDataResult(XAsyncBlock async, ulong blobsSize, out XGameSaveBlob[] blobData) { }

	[Address(RVA = "0x2B3CEF0", Offset = "0x2B3C2F0", Length = "0x1E")]
	[Token(Token = "0x6000114")]
	public static int XGameSaveSubmitBlobDelete(XGameSaveUpdateHandle updateContext, string blobName) { }

	[Address(RVA = "0x2B3CF40", Offset = "0x2B3C340", Length = "0x27")]
	[Token(Token = "0x6000113")]
	public static int XGameSaveSubmitBlobWrite(XGameSaveUpdateHandle updateContext, string blobName, Byte[] data, uint length) { }

	[Address(RVA = "0x2B3CF10", Offset = "0x2B3C310", Length = "0x2E")]
	[Token(Token = "0x6000112")]
	public static int XGameSaveSubmitBlobWrite(XGameSaveUpdateHandle updateContext, string blobName, Byte[] data) { }

	[Address(RVA = "0x2B3D170", Offset = "0x2B3C570", Length = "0x1D")]
	[Token(Token = "0x6000115")]
	public static int XGameSaveSubmitUpdate(XGameSaveUpdateHandle updateContext) { }

	[Address(RVA = "0x2B3CF70", Offset = "0x2B3C370", Length = "0x18F")]
	[Token(Token = "0x6000087")]
	public static int XGameSaveSubmitUpdateAsync(XGameSaveUpdateHandle updateContext, XGameSaveSubmitUpdateCompleted onCompleted) { }

	[Address(RVA = "0x2B3D100", Offset = "0x2B3C500", Length = "0x39")]
	[Token(Token = "0x6000116")]
	public static int XGameSaveSubmitUpdateAsync(XGameSaveUpdateHandle updateContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B3D140", Offset = "0x2B3C540", Length = "0x23")]
	[Token(Token = "0x6000117")]
	public static int XGameSaveSubmitUpdateResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B3D190", Offset = "0x2B3C590", Length = "0x7")]
	[Token(Token = "0x6000120")]
	public static uint XGameStreamingGetClientCount() { }

	[Address(RVA = "0x2B3D1A0", Offset = "0x2B3C5A0", Length = "0xCA")]
	[Token(Token = "0x6000137")]
	public static int XGameStreamingGetClientIPAddress(XGameStreamingClientId client, out string ipAddress) { }

	[Address(RVA = "0x2B3D270", Offset = "0x2B3C670", Length = "0x1C6")]
	[Token(Token = "0x6000121")]
	public static int XGameStreamingGetClients(ref XGameStreamingClientId[] clients, out uint clientUsed) { }

	[Address(RVA = "0x2B3D440", Offset = "0x2B3C840", Length = "0x1D")]
	[Token(Token = "0x6000122")]
	public static XGameStreamingConnectionState XGameStreamingGetConnectionState(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B3D460", Offset = "0x2B3C860", Length = "0x141")]
	[Token(Token = "0x6000139")]
	public static int XGameStreamingGetDisplayDetails(XGameStreamingClientId clientId, uint maxSupportedPixels, float widestSupportedAspectRatio, float tallestSupportedAspectRatio, out XGameStreamingDisplayDetails displayDetails) { }

	[Address(RVA = "0x2B3D5B0", Offset = "0x2B3C9B0", Length = "0xC0")]
	[Token(Token = "0x6000130")]
	public static int XGameStreamingGetLastFrameDisplayed(XGameStreamingClientId client, out D3D12XBOX_FRAME_PIPELINE_TOKEN framePipelineToken) { }

	[Address(RVA = "0x2B3D690", Offset = "0x2B3CA90", Length = "0xBC")]
	[Token(Token = "0x600012E")]
	public static int XGameStreamingGetServerLocationName(ulong serverLocalNameSize, out string serverLocationName) { }

	[Address(RVA = "0x2B3D680", Offset = "0x2B3CA80", Length = "0x7")]
	[Token(Token = "0x600012D")]
	public static ulong XGameStreamingGetServerLocationNameSize() { }

	[Address(RVA = "0x2B3D750", Offset = "0x2B3CB50", Length = "0xE3")]
	[Token(Token = "0x6000138")]
	public static int XGameStreamingGetSessionId(XGameStreamingClientId client, out string sessionId) { }

	[Address(RVA = "0x2B3D840", Offset = "0x2B3CC40", Length = "0x24")]
	[Token(Token = "0x600012C")]
	public static int XGameStreamingGetStreamAddedLatency(XGameStreamingClientId client, out uint averageInputLatencyUs, out uint averageOutputLatencyUs, out uint standardDeviationUs) { }

	[Address(RVA = "0x2B3D870", Offset = "0x2B3CC70", Length = "0x1E")]
	[Token(Token = "0x600012B")]
	public static int XGameStreamingGetStreamPhysicalDimensions(XGameStreamingClientId client, out uint horizontalMm, out uint verticalMm) { }

	[Address(RVA = "0x2B3D8B0", Offset = "0x2B3CCB0", Length = "0x13A")]
	[Token(Token = "0x6000136")]
	public static int XGameStreamingGetTouchBundleVersion(XGameStreamingClientId client, out XVersion version, ulong versionNameSize, out string versionName) { }

	[Address(RVA = "0x2B3D890", Offset = "0x2B3CC90", Length = "0x1D")]
	[Token(Token = "0x6000135")]
	public static ulong XGameStreamingGetTouchBundleVersionNameSize(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B3DA10", Offset = "0x2B3CE10", Length = "0x7")]
	[Token(Token = "0x6000125")]
	public static void XGameStreamingHideTouchControls() { }

	[Address(RVA = "0x2B3D9F0", Offset = "0x2B3CDF0", Length = "0x1D")]
	[Token(Token = "0x6000126")]
	public static void XGameStreamingHideTouchControlsOnClient(XGameStreamingClientId client) { }

	[Address(RVA = "0x2B3DA20", Offset = "0x2B3CE20", Length = "0x7")]
	[Token(Token = "0x600011D")]
	public static int XGameStreamingInitialize() { }

	[Address(RVA = "0x2B3DA30", Offset = "0x2B3CE30", Length = "0x7")]
	[Token(Token = "0x600011F")]
	public static bool XGameStreamingIsStreaming() { }

	[Address(RVA = "0x2B3DA40", Offset = "0x2B3CE40", Length = "0x1E")]
	[Token(Token = "0x600012F")]
	public static int XGameStreamingIsTouchInputEnabled(XGameStreamingClientId client, out bool touchInputEnabled) { }

	[Address(RVA = "0x2B3DA60", Offset = "0x2B3CE60", Length = "0x204")]
	[Token(Token = "0x6000129")]
	public static int XGameStreamingRegisterClientPropertiesChanged(XGameStreamingClientId client, XTaskQueueHandle queue, IntPtr context, XGameStreamingClientPropertiesChangedCallback callback, out XGameStreamingRegisterClientPropertiesChangedToken token) { }

	[Address(RVA = "0x2B3DC70", Offset = "0x2B3D070", Length = "0x20F")]
	[Token(Token = "0x6000123")]
	public static int XGameStreamingRegisterConnectionStateChanged(XTaskQueueHandle queue, IntPtr context, XGameStreamingConnectionStateChangedCallback callback, out XGameStreamingConnectionStateChangedToken token) { }

	[Address(RVA = "0x2B3DE80", Offset = "0x2B3D280", Length = "0x8")]
	[Token(Token = "0x600013A")]
	public static int XGameStreamingSetResolution(uint width, uint height) { }

	[Address(RVA = "0x2B3DEB0", Offset = "0x2B3D2B0", Length = "0x7")]
	[Token(Token = "0x6000127")]
	public static void XGameStreamingShowTouchControlLayout(string layout) { }

	[Address(RVA = "0x2B3DE90", Offset = "0x2B3D290", Length = "0x1E")]
	[Token(Token = "0x6000128")]
	public static void XGameStreamingShowTouchControlLayoutOnClient(XGameStreamingClientId client, string layout) { }

	[Address(RVA = "0x2B3E3C0", Offset = "0x2B3D7C0", Length = "0x4E3")]
	[Token(Token = "0x6000133")]
	public static int XGameStreamingShowTouchControlsWithStateUpdate(string layout, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B3DEC0", Offset = "0x2B3D2C0", Length = "0x4FD")]
	[Token(Token = "0x6000134")]
	public static int XGameStreamingShowTouchControlsWithStateUpdateOnClient(XGameStreamingClientId client, string layout, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B3E8B0", Offset = "0x2B3DCB0", Length = "0x7")]
	[Token(Token = "0x600011E")]
	public static void XGameStreamingUninitialize() { }

	[Address(RVA = "0x2B3E8C0", Offset = "0x2B3DCC0", Length = "0x23")]
	[Token(Token = "0x600012A")]
	public static bool XGameStreamingUnregisterClientPropertiesChanged(XGameStreamingClientId client, XGameStreamingRegisterClientPropertiesChangedToken token, bool wait) { }

	[Address(RVA = "0x2B3E8F0", Offset = "0x2B3DCF0", Length = "0x1A")]
	[Token(Token = "0x6000124")]
	public static bool XGameStreamingUnregisterConnectionStateChanged(XGameStreamingConnectionStateChangedToken token, bool wait) { }

	[Address(RVA = "0x2B3EE20", Offset = "0x2B3E220", Length = "0x4D5")]
	[Token(Token = "0x6000131")]
	public static int XGameStreamingUpdateTouchControlsState(XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B3E910", Offset = "0x2B3DD10", Length = "0x50E")]
	[Token(Token = "0x6000132")]
	public static int XGameStreamingUpdateTouchControlsStateOnClient(XGameStreamingClientId client, XGameStreamingTouchControlsStateOperation[] operations) { }

	[Address(RVA = "0x2B3F300", Offset = "0x2B3E700", Length = "0x7")]
	[Token(Token = "0x600014B")]
	public static int XGameUiSetNotificationPositionHint(XGameUiNotificationPositionHint position) { }

	[Address(RVA = "0x2B3F4D0", Offset = "0x2B3E8D0", Length = "0x75")]
	[Token(Token = "0x6000143")]
	public static int XGameUiShowAchievementsAsync(XAsyncBlock async, XUserHandle requestingUser, uint titleId) { }

	[Address(RVA = "0x2B3F310", Offset = "0x2B3E710", Length = "0x1B7")]
	[Token(Token = "0x6000089")]
	public static int XGameUiShowAchievementsAsync(XUserHandle requestingUser, uint titleId, XGameUiShowAchievementsCompleted onCompleted) { }

	[Address(RVA = "0x2B3F550", Offset = "0x2B3E950", Length = "0x23")]
	[Token(Token = "0x6000144")]
	public static int XGameUiShowAchievementsResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B3F5C0", Offset = "0x2B3E9C0", Length = "0x188")]
	[Token(Token = "0x600008A")]
	public static int XGameUiShowErrorDialogAsync(int errorCode, string context, XGameUiShowErrorDialogCompleted onCompleted) { }

	[Address(RVA = "0x2B3F580", Offset = "0x2B3E980", Length = "0x3A")]
	[Token(Token = "0x6000149")]
	public static int XGameUiShowErrorDialogAsync(XAsyncBlock async, int errorCode, string context) { }

	[Address(RVA = "0x2B3F750", Offset = "0x2B3EB50", Length = "0x23")]
	[Token(Token = "0x600014A")]
	public static int XGameUiShowErrorDialogResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B3F780", Offset = "0x2B3EB80", Length = "0x55")]
	[Token(Token = "0x600013B")]
	public static int XGameUiShowMessageDialogAsync(XAsyncBlock async, string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton) { }

	[Address(RVA = "0x2B3F7E0", Offset = "0x2B3EBE0", Length = "0x1E3")]
	[Token(Token = "0x600008B")]
	public static int XGameUiShowMessageDialogAsync(string titleText, string contextText, string firstButtonText, string secondButtonText, string thirdButtonText, XGameUiMessageDialogButton defaultButton, XGameUiMessageDialogButton cancelButton, XGameUiShowMessageDialogCompleted onCompleted) { }

	[Address(RVA = "0x2B3F9D0", Offset = "0x2B3EDD0", Length = "0x2D")]
	[Token(Token = "0x600013C")]
	public static int XGameUiShowMessageDialogResult(XAsyncBlock async, out XGameUiMessageDialogButton resultButton) { }

	[Address(RVA = "0x2B3FA00", Offset = "0x2B3EE00", Length = "0x1A6")]
	[Token(Token = "0x600008C")]
	public static int XGameUiShowMultiplayerActivityGameInviteAsync(XUserHandle requestingUser, XGameUiShowMultiplayerActivityGameInviteCompleted onCompleted) { }

	[Address(RVA = "0x2B3FBB0", Offset = "0x2B3EFB0", Length = "0x65")]
	[Token(Token = "0x600013F")]
	public static int XGameUiShowMultiplayerActivityGameInviteAsync(XAsyncBlock async, XUserHandle requestingUser) { }

	[Address(RVA = "0x2B3FC20", Offset = "0x2B3F020", Length = "0x23")]
	[Token(Token = "0x6000140")]
	public static int XGameUiShowMultiplayerActivityGameInviteResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B3FC50", Offset = "0x2B3F050", Length = "0x220")]
	[Token(Token = "0x600008D")]
	public static int XGameUiShowPlayerPickerAsync(XUserHandle requestingUser, string promptText, UInt64[] selectFromPlayers, UInt64[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount, XGameUiShowPlayerPickerCompleted onCompleted) { }

	[Address(RVA = "0x2B3FE80", Offset = "0x2B3F280", Length = "0xD5")]
	[Token(Token = "0x6000145")]
	public static int XGameUiShowPlayerPickerAsync(XAsyncBlock async, XUserHandle requestingUser, string promptText, UInt64[] selectFromPlayers, UInt64[] preSelectedPlayers, uint minSelectionCount, uint maxSelectionCount) { }

	[Address(RVA = "0x2B3FF90", Offset = "0x2B3F390", Length = "0x4B")]
	[Token(Token = "0x6000148")]
	public static int XGameUiShowPlayerPickerResult(XAsyncBlock async, UInt64[] resultPlayers, out uint resultPlayerUsed) { }

	[Address(RVA = "0x2B3FF60", Offset = "0x2B3F360", Length = "0x2D")]
	[Token(Token = "0x6000147")]
	public static int XGameUiShowPlayerPickerResultCount(XAsyncBlock async, out uint resultPlayersCount) { }

	[Address(RVA = "0x2B3FFE0", Offset = "0x2B3F3E0", Length = "0x1B7")]
	[Token(Token = "0x600008E")]
	public static int XGameUiShowPlayerProfileCardAsync(XUserHandle requestingUser, ulong targetPlayer, XGameUiShowPlayerProfileCardCompleted onCompleted) { }

	[Address(RVA = "0x2B401A0", Offset = "0x2B3F5A0", Length = "0x75")]
	[Token(Token = "0x6000141")]
	public static int XGameUiShowPlayerProfileCardAsync(XAsyncBlock async, XUserHandle requestingUser, ulong targetPlayer) { }

	[Address(RVA = "0x2B40220", Offset = "0x2B3F620", Length = "0x23")]
	[Token(Token = "0x6000142")]
	public static int XGameUiShowPlayerProfileCardResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B402E0", Offset = "0x2B3F6E0", Length = "0x1F5")]
	[Token(Token = "0x600008F")]
	public static int XGameUiShowSendGameInviteAsync(XUserHandle requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext, XGameUiShowSendGameInviteCompleted onCompleted) { }

	[Address(RVA = "0x2B40250", Offset = "0x2B3F650", Length = "0x8E")]
	[Token(Token = "0x600013D")]
	public static int XGameUiShowSendGameInviteAsync(XAsyncBlock async, XUserHandle requestingUser, string sessionConfigurationId, string sessionTemplateName, string sessionId, string invitationText, string customActivationContext) { }

	[Address(RVA = "0x2B404E0", Offset = "0x2B3F8E0", Length = "0x23")]
	[Token(Token = "0x600013E")]
	public static int XGameUiShowSendGameInviteResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B40510", Offset = "0x2B3F910", Length = "0x1BF")]
	[Token(Token = "0x6000090")]
	public static int XGameUiShowTextEntryAsync(string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength, XGameUiShowTextEntryCompleted onCompleted) { }

	[Address(RVA = "0x2B406D0", Offset = "0x2B3FAD0", Length = "0x55")]
	[Token(Token = "0x600014C")]
	public static int XGameUiShowTextEntryAsync(XAsyncBlock async, string titleText, string descriptionText, string defaultText, XGameUiTextEntryInputScope inputScope, uint maxTextLength) { }

	[Address(RVA = "0x2B40760", Offset = "0x2B3FB60", Length = "0xEC")]
	[Token(Token = "0x600014E")]
	public static int XGameUiShowTextEntryResult(XAsyncBlock async, uint resultTextBufferSize, out string resultTextBuffer) { }

	[Address(RVA = "0x2B40730", Offset = "0x2B3FB30", Length = "0x2D")]
	[Token(Token = "0x600014D")]
	public static int XGameUiShowTextEntryResultSize(XAsyncBlock async, out uint resultTextBufferSize) { }

	[Address(RVA = "0x2B40A20", Offset = "0x2B3FE20", Length = "0x8B")]
	[Token(Token = "0x600014F")]
	public static int XGameUiShowWebAuthenticationAsync(XAsyncBlock async, XUserHandle requestingUser, string requestUri, string completeUri) { }

	[Address(RVA = "0x2B40850", Offset = "0x2B3FC50", Length = "0x1CD")]
	[Token(Token = "0x6000091")]
	public static int XGameUiShowWebAuthenticationAsync(XUserHandle requestingUser, string requestUri, string completeUri, XGameUiShowWebAuthenticationAsyncCompleted onCompleted) { }

	[Address(RVA = "0x2B40AE0", Offset = "0x2B3FEE0", Length = "0x198")]
	[Token(Token = "0x6000146")]
	public static int XGameUiShowWebAuthenticationResult(XAsyncBlock async, Byte[] buffer, out XGameUiWebAuthenticationResultData result) { }

	[Address(RVA = "0x2B40AB0", Offset = "0x2B3FEB0", Length = "0x2D")]
	[Token(Token = "0x6000151")]
	public static int XGameUiShowWebAuthenticationResultSize(XAsyncBlock async, out ulong bufferSize) { }

	[Address(RVA = "0x2B40D10", Offset = "0x2B40110", Length = "0x1D4")]
	[Token(Token = "0x6000092")]
	public static int XGameUiShowWebAuthenticationWithOptionsAsync(XUserHandle requestingUser, string requestUri, string completeUri, XGameUiWebAuthenticationOptions options, Action<Int32, XGameUiWebAuthenticationResultData> onCompleted) { }

	[Address(RVA = "0x2B40C80", Offset = "0x2B40080", Length = "0x8B")]
	[Token(Token = "0x6000150")]
	public static int XGameUiShowWebAuthenticationWithOptionsAsync(XAsyncBlock async, XUserHandle requestingUser, string requestUri, string completionUri, XGameUiWebAuthenticationOptions options) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x6000152")]
	public static void XGameUiTextEntryClose(XGameUiTextEntryHandle handle) { }

	[Address(RVA = "0x2B40EF0", Offset = "0x2B402F0", Length = "0xD0")]
	[Token(Token = "0x6000153")]
	public static int XGameUiTextEntryGetExtents(XGameUiTextEntryHandle handle, out XGameUiTextEntryExtents extents) { }

	[Address(RVA = "0x2B40FD0", Offset = "0x2B403D0", Length = "0x11B")]
	[Token(Token = "0x6000155")]
	public static int XGameUiTextEntryGetState(XGameUiTextEntryHandle handle, out XGameUiTextEntryChangeTypeFlags changeType, out uint cursorIndex, out uint imeClauseStartIndex, out uint imeClauseEndIndex, uint bufferSize, out string buffer) { }

	[Address(RVA = "0x2B410F0", Offset = "0x2B404F0", Length = "0xF6")]
	[Token(Token = "0x6000154")]
	public static int XGameUiTextEntryOpen(XGameUiTextEntryOptions options, uint maxLength, string initialText, uint cursorIndex, out XGameUiTextEntryHandle handle) { }

	[Address(RVA = "0x2B411F0", Offset = "0x2B405F0", Length = "0x1E")]
	[Token(Token = "0x6000156")]
	public static int XGameUiTextEntryUpdatePositionHint(XGameUiTextEntryHandle handle, XGameUiTextEntryPositionHint positionHint) { }

	[Address(RVA = "0x2B41210", Offset = "0x2B40610", Length = "0x1E")]
	[Token(Token = "0x6000157")]
	public static int XGameUiTextEntryUpdateVisibility(XGameUiTextEntryHandle handle, XGameUiTextEntryVisibilityFlags visibilityFlags) { }

	[Address(RVA = "0x2B41230", Offset = "0x2B40630", Length = "0x7")]
	[Token(Token = "0x600004E")]
	public static int XHighContrastGetMode(out XHighContrastMode mode) { }

	[Address(RVA = "0x2B41240", Offset = "0x2B40640", Length = "0x5F")]
	[Token(Token = "0x60000EC")]
	public static void XLaunchNewGame(string exePath, string args, XUserHandle defaultUser) { }

	[Address(RVA = "0x2B412A0", Offset = "0x2B406A0", Length = "0x8")]
	[Token(Token = "0x60000ED")]
	public static int XLaunchRestartOnCrash(string args, uint reserved) { }

	[Address(RVA = "0x2B412B0", Offset = "0x2B406B0", Length = "0x4B")]
	[Token(Token = "0x6000158")]
	public static int XLaunchUri(XUserHandle requestingUser, string uri) { }

	[Address(RVA = "0x2B41300", Offset = "0x2B40700", Length = "0xB6")]
	[Token(Token = "0x6000159")]
	public static int XNetworkingGetConnectivityHint(out XNetworkingConnectivityHint getConnectivityHint) { }

	[Address(RVA = "0x2B413C0", Offset = "0x2B407C0", Length = "0x8")]
	[Token(Token = "0x600015A")]
	public static int XNetworkingQueryConfigurationSetting(XNetworkingConfigurationSetting getConfigurationSetting, out ulong value) { }

	[Address(RVA = "0x2B415B0", Offset = "0x2B409B0", Length = "0x7")]
	[Token(Token = "0x600015B")]
	public static int XNetworkingQueryPreferredLocalUdpMultiplayerPort(out ushort value) { }

	[Address(RVA = "0x2B41400", Offset = "0x2B40800", Length = "0x176")]
	[Token(Token = "0x6000093")]
	public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(XNetworkingQueryPreferredLocalUdpMultiplayerPortResultFunction onCompleted) { }

	[Address(RVA = "0x2B41580", Offset = "0x2B40980", Length = "0x23")]
	[Token(Token = "0x600015C")]
	public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsync(XAsyncBlock async) { }

	[Address(RVA = "0x2B413D0", Offset = "0x2B407D0", Length = "0x2D")]
	[Token(Token = "0x600015D")]
	public static int XNetworkingQueryPreferredLocalUdpMultiplayerPortAsyncResult(XAsyncBlock async, out ushort preferredLocalUdpMultiplayerPort) { }

	[Address(RVA = "0x2B41740", Offset = "0x2B40B40", Length = "0x189")]
	[Token(Token = "0x6000094")]
	public static int XNetworkingQuerySecurityInformationForUrlAsync(string url, XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted) { }

	[Address(RVA = "0x2B41700", Offset = "0x2B40B00", Length = "0x33")]
	[Token(Token = "0x600015E")]
	public static int XNetworkingQuerySecurityInformationForUrlAsync(string url, XAsyncBlock async) { }

	[Address(RVA = "0x2B415F0", Offset = "0x2B409F0", Length = "0x104")]
	[Token(Token = "0x6000160")]
	public static int XNetworkingQuerySecurityInformationForUrlAsyncResult(XAsyncBlock async, Byte[] securityInformationBuffer, out ulong securityInformationBufferByteCountUsed, out XNetworkingSecurityInformation securityInformation) { }

	[Address(RVA = "0x2B415C0", Offset = "0x2B409C0", Length = "0x2D")]
	[Token(Token = "0x600015F")]
	public static int XNetworkingQuerySecurityInformationForUrlAsyncResultSize(XAsyncBlock async, out ulong securityInformationBufferByteCount) { }

	[Address(RVA = "0x2B41A10", Offset = "0x2B40E10", Length = "0x189")]
	[Token(Token = "0x6000095")]
	public static int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, XNetworkingQuerySecurityInformationForUrlResultCallback onCompleted) { }

	[Address(RVA = "0x2B41BA0", Offset = "0x2B40FA0", Length = "0x33")]
	[Token(Token = "0x6000161")]
	public static int XNetworkingQuerySecurityInformationForUrlUtf16Async(string url, XAsyncBlock async) { }

	[Address(RVA = "0x2B41900", Offset = "0x2B40D00", Length = "0x104")]
	[Token(Token = "0x6000163")]
	public static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResult(XAsyncBlock async, Byte[] securityInformationBuffer, out ulong securityInformationBufferByteCountUsed, out XNetworkingSecurityInformation securityInformation) { }

	[Address(RVA = "0x2B418D0", Offset = "0x2B40CD0", Length = "0x2D")]
	[Token(Token = "0x6000162")]
	public static int XNetworkingQuerySecurityInformationForUrlUtf16AsyncResultSize(XAsyncBlock async, out ulong securityInformationBufferByteCount) { }

	[Address(RVA = "0x2B41BE0", Offset = "0x2B40FE0", Length = "0x102")]
	[Token(Token = "0x6000164")]
	public static int XNetworkingQueryStatistics(XNetworkingStatisticsType statisticsType, out XNetworkingStatisticsBuffer statisticsBuffer) { }

	[Address(RVA = "0x2B41D70", Offset = "0x2B41170", Length = "0x1FF")]
	[Token(Token = "0x6000165")]
	public static int XNetworkingRegisterConnectivityHintChanged(XTaskQueueHandle queue, IntPtr context, XNetworkingConnectivityHintChangedCallback callback, out XNetworkingRegisterConnectivityHintChangedCallbackToken token) { }

	[Address(RVA = "0x2B41CF0", Offset = "0x2B410F0", Length = "0x74")]
	[Token(Token = "0x6000096")]
	public static int XNetworkingRegisterConnectivityHintChanged(XNetworkingConnectivityHintChangedCallback callback, out XNetworkingRegisterConnectivityHintChangedCallbackToken token) { }

	[Address(RVA = "0x2B41F70", Offset = "0x2B41370", Length = "0x74")]
	[Token(Token = "0x6000097")]
	public static int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token) { }

	[Address(RVA = "0x2B41FF0", Offset = "0x2B413F0", Length = "0x1FE")]
	[Token(Token = "0x6000167")]
	public static int XNetworkingRegisterPreferredLocalUdpMultiplayerPortChanged(XTaskQueueHandle queue, IntPtr context, XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, out XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token) { }

	[Address(RVA = "0x2B421F0", Offset = "0x2B415F0", Length = "0x1A")]
	[Token(Token = "0x6000166")]
	public static bool XNetworkingUnregisterConnectivityHintChanged(XNetworkingRegisterConnectivityHintChangedCallbackToken token, bool wait) { }

	[Address(RVA = "0x2B42270", Offset = "0x2B41670", Length = "0x1A")]
	[Token(Token = "0x6000168")]
	public static bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token, bool wait) { }

	[Address(RVA = "0x2B42210", Offset = "0x2B41610", Length = "0x56")]
	[Token(Token = "0x6000098")]
	public static bool XNetworkingUnregisterPreferredLocalUdpMultiplayerPortChanged(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken token) { }

	[Address(RVA = "0x2B42290", Offset = "0x2B41690", Length = "0xAE")]
	[Token(Token = "0x6000169")]
	public static int XNetworkingVerifyServerCertificate(IntPtr requestHandle, XNetworkingSecurityInformation securityInformation) { }

	[Address(RVA = "0x2B42340", Offset = "0x2B41740", Length = "0x1BE")]
	[Token(Token = "0x6000175")]
	public static int XPackageChangeChunkInstallOrder(string packageIdentifier, XPackageChunkSelector[] selectors) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x600016E")]
	public static void XPackageCloseInstallationMonitorHandle(XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x600017B")]
	public static void XPackageCloseMountHandle(XPackageMountHandle mount) { }

	[Address(RVA = "0x2B425E0", Offset = "0x2B419E0", Length = "0x98")]
	[Token(Token = "0x6000099")]
	public static int XPackageCreateInstallationMonitor(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, out XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B42500", Offset = "0x2B41900", Length = "0xDE")]
	[Token(Token = "0x600009A")]
	public static int XPackageCreateInstallationMonitor(string packageIdentifier, uint minimumUpdateIntervalMs, out XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B42680", Offset = "0x2B41A80", Length = "0x2FD")]
	[Token(Token = "0x600016D")]
	public static int XPackageCreateInstallationMonitor(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, XTaskQueueHandle queue, out XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B42980", Offset = "0x2B41D80", Length = "0x226")]
	[Token(Token = "0x600017D")]
	public static int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, IntPtr context, XPackageChunkAvailabilityCallback callback) { }

	[Address(RVA = "0x2B42BB0", Offset = "0x2B41FB0", Length = "0x71")]
	[Token(Token = "0x60000E7")]
	public static int XPackageEnumerateChunkAvailability(string packageIdentifier, XPackageChunkSelectorType type, XPackageChunkAvailabilityCallback callback) { }

	[Address(RVA = "0x2B42C30", Offset = "0x2B42030", Length = "0x176")]
	[Token(Token = "0x60000E9")]
	public static int XPackageEnumerateFeatures(string packageIdentifier, out XPackageFeature[] features) { }

	[Address(RVA = "0x2B42DB0", Offset = "0x2B421B0", Length = "0x218")]
	[Token(Token = "0x600017F")]
	public static int XPackageEnumerateFeatures(string packageIdentifier, IntPtr context, XPackageFeatureEnumerationCallback callback) { }

	[Address(RVA = "0x2B43160", Offset = "0x2B42560", Length = "0x226")]
	[Token(Token = "0x6000181")]
	public static int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, IntPtr context, XPackageEnumerationCallback callback) { }

	[Address(RVA = "0x2B42FD0", Offset = "0x2B423D0", Length = "0x18D")]
	[Token(Token = "0x60000E8")]
	public static int XPackageEnumeratePackages(XPackageKind kind, XPackageEnumerationScope scope, out XPackageDetails[] details) { }

	[Address(RVA = "0x2B43580", Offset = "0x2B42980", Length = "0x9A")]
	[Token(Token = "0x60000E6")]
	public static int XPackageEstimateDownloadSize(string packageIdentifier, out ulong downloadSize, out bool shouldPresentUserConfirmation) { }

	[Address(RVA = "0x2B43390", Offset = "0x2B42790", Length = "0x1E8")]
	[Token(Token = "0x6000179")]
	public static int XPackageEstimateDownloadSize(string packageIdentifier, XPackageChunkSelector[] selectors, out ulong downloadSize, out bool shouldPresentUserConfirmation) { }

	[Address(RVA = "0x2B43620", Offset = "0x2B42A20", Length = "0x1D5")]
	[Token(Token = "0x6000174")]
	public static int XPackageFindChunkAvailability(string packageIdentifier, XPackageChunkSelector[] selectors, out XPackageChunkAvailability availability) { }

	[Address(RVA = "0x2B43800", Offset = "0x2B42C00", Length = "0xFD")]
	[Token(Token = "0x600016F")]
	public static int XPackageGetCurrentProcessPackageIdentifier(out string buffer) { }

	[Address(RVA = "0x2B43900", Offset = "0x2B42D00", Length = "0xB7")]
	[Token(Token = "0x6000171")]
	public static void XPackageGetInstallationProgress(XPackageInstallationMonitorHandle installationMonitor, out XPackageInstallationProgress progress) { }

	[Address(RVA = "0x2B439E0", Offset = "0x2B42DE0", Length = "0xD2")]
	[Token(Token = "0x6000183")]
	public static int XPackageGetMountPath(XPackageMountHandle mount, ulong pathSize, out string path) { }

	[Address(RVA = "0x2B43AC0", Offset = "0x2B42EC0", Length = "0x179")]
	[Token(Token = "0x60000E5")]
	public static int XPackageGetMountPath(XPackageMountHandle mountHandle, out string path) { }

	[Address(RVA = "0x2B439C0", Offset = "0x2B42DC0", Length = "0x1E")]
	[Token(Token = "0x6000182")]
	public static int XPackageGetMountPathSize(XPackageMountHandle mount, out ulong pathSize) { }

	[Address(RVA = "0x2B43C40", Offset = "0x2B43040", Length = "0xFD")]
	[Token(Token = "0x6000173")]
	public static int XPackageGetUserLocale(out string locale) { }

	[Address(RVA = "0x2B43D40", Offset = "0x2B43140", Length = "0xE4")]
	[Token(Token = "0x6000184")]
	public static int XPackageGetWriteStats(out XPackageWriteStats writeStats) { }

	[Address(RVA = "0x2B442C0", Offset = "0x2B436C0", Length = "0x299")]
	[Token(Token = "0x6000176")]
	public static int XPackageInstallChunks(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XTaskQueueHandle queue, out XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B44040", Offset = "0x2B43440", Length = "0x1A2")]
	[Token(Token = "0x600009B")]
	public static int XPackageInstallChunksAsync(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XPackageInstallChunksCompleted onCompleted) { }

	[Address(RVA = "0x2B43E30", Offset = "0x2B43230", Length = "0x20D")]
	[Token(Token = "0x6000177")]
	public static int XPackageInstallChunksAsync(string packageIdentifier, XPackageChunkSelector[] selectors, uint minimumUpdateIntervalMs, bool suppressUserConfirmation, XAsyncBlock async) { }

	[Address(RVA = "0x2B441F0", Offset = "0x2B435F0", Length = "0xC4")]
	[Token(Token = "0x6000178")]
	public static int XPackageInstallChunksResult(XAsyncBlock asyncBlock, out XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B44560", Offset = "0x2B43960", Length = "0x7")]
	[Token(Token = "0x6000170")]
	public static bool XPackageIsPackagedProcess() { }

	[Address(RVA = "0x2B44810", Offset = "0x2B43C10", Length = "0x4E")]
	[Obsolete("XPackageMount(string, out XPackageMountHandle) has been removed. Please use XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted) instead.", True)]
	[Token(Token = "0x600009C")]
	public static int XPackageMount(string packageIdentifier, out XPackageMountHandle mountHandle) { }

	[Address(RVA = "0x2B44570", Offset = "0x2B43970", Length = "0x33")]
	[Token(Token = "0x6000185")]
	public static int XPackageMountWithUiAsync(string packageIdentifier, XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B445B0", Offset = "0x2B439B0", Length = "0x189")]
	[Token(Token = "0x600009D")]
	public static int XPackageMountWithUiAsync(string packageIdentifier, XPackageMountWithUiAsyncCompleted onCompleted) { }

	[Address(RVA = "0x2B44740", Offset = "0x2B43B40", Length = "0xC4")]
	[Token(Token = "0x6000186")]
	public static int XPackageMountWithUiResult(XAsyncBlock async, out XPackageMountHandle mount) { }

	[Address(RVA = "0x2B44860", Offset = "0x2B43C60", Length = "0x1D7")]
	[Token(Token = "0x6000187")]
	public static int XPackageRegisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitorHandle, IntPtr context, XPackageInstallationProgressCallback callback, out XPackageRegisterInstallationProgressChangedToken token) { }

	[Address(RVA = "0x2B44A40", Offset = "0x2B43E40", Length = "0x72")]
	[Token(Token = "0x600009F")]
	public static int XPackageRegisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageInstallationProgressCallback callback, out XPackageRegisterInstallationProgressChangedToken token) { }

	[Address(RVA = "0x2B44B40", Offset = "0x2B43F40", Length = "0x1BB")]
	[Token(Token = "0x6000188")]
	public static int XPackageRegisterPackageInstalled(XTaskQueueHandle queue, IntPtr context, XPackageInstalledCallback callback, out XPackageRegisterPackageInstalledToken token) { }

	[Address(RVA = "0x2B44AC0", Offset = "0x2B43EC0", Length = "0x74")]
	[Token(Token = "0x600009E")]
	public static int XPackageRegisterPackageInstalled(XPackageInstalledCallback callback, out XPackageRegisterPackageInstalledToken token) { }

	[Address(RVA = "0x2B44D00", Offset = "0x2B44100", Length = "0x1C3")]
	[Token(Token = "0x600017A")]
	public static int XPackageUninstallChunks(string packageIdentifier, XPackageChunkSelector[] selectors) { }

	[Address(RVA = "0x2B44ED0", Offset = "0x2B442D0", Length = "0x7")]
	[Token(Token = "0x600018A")]
	public static bool XPackageUninstallPackage(string packageIdentifier) { }

	[Address(RVA = "0x2B44EE0", Offset = "0x2B442E0", Length = "0x7")]
	[Token(Token = "0x6000189")]
	public static int XPackageUninstallUWPInstance(string packageName) { }

	[Address(RVA = "0x2B44EF0", Offset = "0x2B442F0", Length = "0x23")]
	[Token(Token = "0x600018B")]
	public static bool XPackageUnregisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageRegisterInstallationProgressChangedToken token, bool wait) { }

	[Address(RVA = "0x2B44F20", Offset = "0x2B44320", Length = "0x66")]
	[Token(Token = "0x600018C")]
	public static bool XPackageUnregisterInstallationProgressChanged(XPackageInstallationMonitorHandle installationMonitor, XPackageRegisterInstallationProgressChangedToken token) { }

	[Address(RVA = "0x2B44F90", Offset = "0x2B44390", Length = "0x56")]
	[Token(Token = "0x600018D")]
	public static bool XPackageUnregisterPackageInstalled(XPackageRegisterPackageInstalledToken token) { }

	[Address(RVA = "0x2B44FF0", Offset = "0x2B443F0", Length = "0x1A")]
	[Token(Token = "0x600018E")]
	public static bool XPackageUnregisterPackageInstalled(XPackageRegisterPackageInstalledToken token, bool wait) { }

	[Address(RVA = "0x2B45010", Offset = "0x2B44410", Length = "0x1D")]
	[Token(Token = "0x6000172")]
	public static void XPackageUpdateInstallationMonitor(XPackageInstallationMonitorHandle installationMonitor) { }

	[Address(RVA = "0x2B45040", Offset = "0x2B44440", Length = "0x11E")]
	[Token(Token = "0x6000190")]
	public static int XPersistentLocalStorageGetPath(ulong pathSize, out string path) { }

	[Address(RVA = "0x2B45030", Offset = "0x2B44430", Length = "0x7")]
	[Token(Token = "0x600018F")]
	public static int XPersistentLocalStorageGetPathSize(out ulong pathSize) { }

	[Address(RVA = "0x2B45160", Offset = "0x2B44560", Length = "0xE4")]
	[Token(Token = "0x6000191")]
	public static int XPersistentLocalStorageGetSpaceInfo(out XPersistentLocalStorageSpaceInfo spaceInfo) { }

	[Address(RVA = "0x2B453E0", Offset = "0x2B447E0", Length = "0x33")]
	[Token(Token = "0x6000192")]
	public static int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B45250", Offset = "0x2B44650", Length = "0x186")]
	[Token(Token = "0x60000A0")]
	public static int XPersistentLocalStoragePromptUserForSpaceAsync(ulong requestedBytes, XPersistentLocalStoragePromptUserForSpaceAsyncCallback onCompleted) { }

	[Address(RVA = "0x2B45420", Offset = "0x2B44820", Length = "0x23")]
	[Token(Token = "0x6000193")]
	public static int XPersistentLocalStoragePromptUserForSpaceResult(XAsyncBlock asyncBlock) { }

	[Address(RVA = "0x2B37F30", Offset = "0x2B37330", Length = "0x23")]
	[Token(Token = "0x6000197")]
	public static int XSpeechSynthesizerCloseHandle(XSpeechSynthesizerHandle speechSynthesizer) { }

	[Address(RVA = "0x2B37F30", Offset = "0x2B37330", Length = "0x23")]
	[Token(Token = "0x600019C")]
	public static int XSpeechSynthesizerCloseStreamHandle(XSpeechSynthesizerStreamHandle speechSynthesisStream) { }

	[Address(RVA = "0x2B455F0", Offset = "0x2B449F0", Length = "0xA9")]
	[Token(Token = "0x6000196")]
	public static int XSpeechSynthesizerCreate(out XSpeechSynthesizerHandle speechSynthesizer) { }

	[Address(RVA = "0x2B45450", Offset = "0x2B44850", Length = "0xC1")]
	[Token(Token = "0x600019B")]
	public static int XSpeechSynthesizerCreateStreamFromSsml(XSpeechSynthesizerHandle speechSynthesizer, string ssml, out XSpeechSynthesizerStreamHandle speechSynthesisStream) { }

	[Address(RVA = "0x2B45520", Offset = "0x2B44920", Length = "0xC1")]
	[Token(Token = "0x600019A")]
	public static int XSpeechSynthesizerCreateStreamFromText(XSpeechSynthesizerHandle speechSynthesizer, string text, out XSpeechSynthesizerStreamHandle speechSynthesisStream) { }

	[Address(RVA = "0x2B45810", Offset = "0x2B44C10", Length = "0x212")]
	[Token(Token = "0x6000195")]
	public static int XSpeechSynthesizerEnumerateInstalledVoices(IntPtr context, XSpeechSynthesizerInstalledVoicesCallback callback) { }

	[Address(RVA = "0x2B456A0", Offset = "0x2B44AA0", Length = "0x166")]
	[Token(Token = "0x60000E0")]
	public static int XSpeechSynthesizerEnumerateInstalledVoices(out XSpeechSynthesizerVoiceInformation[] voiceInformation) { }

	[Address(RVA = "0x2B45A50", Offset = "0x2B44E50", Length = "0x34")]
	[Token(Token = "0x600019E")]
	public static int XSpeechSynthesizerGetStreamData(XSpeechSynthesizerStreamHandle speechSynthesisStream, Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B45A90", Offset = "0x2B44E90", Length = "0x13A")]
	[Token(Token = "0x60000E1")]
	public static int XSpeechSynthesizerGetStreamData(XSpeechSynthesizerStreamHandle speechSynthesisStream, out Byte[] buffer) { }

	[Address(RVA = "0x2B45A30", Offset = "0x2B44E30", Length = "0x1E")]
	[Token(Token = "0x600019D")]
	public static int XSpeechSynthesizerGetStreamDataSize(XSpeechSynthesizerStreamHandle speechSynthesisStream, out ulong bufferSize) { }

	[Address(RVA = "0x2B45C50", Offset = "0x2B45050", Length = "0x1E")]
	[Token(Token = "0x6000199")]
	public static int XSpeechSynthesizerSetCustomVoice(XSpeechSynthesizerHandle speechSynthesizer, string voiceId) { }

	[Address(RVA = "0x2B45BD0", Offset = "0x2B44FD0", Length = "0x76")]
	[Token(Token = "0x60000EA")]
	public static int XSpeechSynthesizerSetCustomVoice(XSpeechSynthesizerHandle speechSynthesizer, XSpeechSynthesizerVoiceInformation voiceInformation) { }

	[Address(RVA = "0x2B45C70", Offset = "0x2B45070", Length = "0x1D")]
	[Token(Token = "0x6000198")]
	public static int XSpeechSynthesizerSetDefaultVoice(XSpeechSynthesizerHandle speechSynthesizer) { }

	[Address(RVA = "0x2B45C90", Offset = "0x2B45090", Length = "0xE")]
	[Token(Token = "0x6000051")]
	public static int XSpeechToTextBeginHypothesisString(string speakerName, string content, XSpeechToTextType type, out uint hypothesisId) { }

	[Address(RVA = "0x2B45CA0", Offset = "0x2B450A0", Length = "0x7")]
	[Token(Token = "0x6000054")]
	public static int XSpeechToTextCancelHypothesisString(uint hypothesisId) { }

	[Address(RVA = "0x2B45CB0", Offset = "0x2B450B0", Length = "0x8")]
	[Token(Token = "0x6000053")]
	public static int XSpeechToTextFinalizeHypothesisString(uint hypothesisId, string content) { }

	[Address(RVA = "0x2B45CC0", Offset = "0x2B450C0", Length = "0x8")]
	[Token(Token = "0x6000050")]
	public static int XSpeechToTextSendString(string speakerName, string content, XSpeechToTextType type) { }

	[Address(RVA = "0x2B45CD0", Offset = "0x2B450D0", Length = "0x7")]
	[Token(Token = "0x600004F")]
	public static int XSpeechToTextSetPositionHint(XSpeechToTextPositionHint position) { }

	[Address(RVA = "0x2B45CE0", Offset = "0x2B450E0", Length = "0x8")]
	[Token(Token = "0x6000052")]
	public static int XSpeechToTextUpdateHypothesisString(uint hypothesisId, string content) { }

	[Address(RVA = "0x2B45D40", Offset = "0x2B45140", Length = "0x194")]
	[Token(Token = "0x60000A1")]
	public static int XStoreAcquireLicenseForDurablesAsync(XStoreContext context, string storeId, XStoreAcquireLicenseForDurablesCompleted onCompleted) { }

	[Address(RVA = "0x2B45CF0", Offset = "0x2B450F0", Length = "0x45")]
	[Token(Token = "0x60001A3")]
	public static int XStoreAcquireLicenseForDurablesAsync(XStoreContext context, string storeId, XAsyncBlock async) { }

	[Address(RVA = "0x2B45EE0", Offset = "0x2B452E0", Length = "0xC4")]
	[Token(Token = "0x60001A4")]
	public static int XStoreAcquireLicenseForDurablesResult(XAsyncBlock async, out XStoreLicense storeLicense) { }

	[Address(RVA = "0x2B45FB0", Offset = "0x2B453B0", Length = "0x45")]
	[Token(Token = "0x60001A5")]
	public static int XStoreAcquireLicenseForPackageAsync(XStoreContext context, string packageIdentifier, XAsyncBlock async) { }

	[Address(RVA = "0x2B46000", Offset = "0x2B45400", Length = "0x194")]
	[Token(Token = "0x60000A2")]
	public static int XStoreAcquireLicenseForPackageAsync(XStoreContext context, string packageIdentifier, XStoreAcquireLicenseForPackageCompleted onCompleted) { }

	[Address(RVA = "0x2B461A0", Offset = "0x2B455A0", Length = "0xC4")]
	[Token(Token = "0x60001A6")]
	public static int XStoreAcquireLicenseForPackageResult(XAsyncBlock async, out XStoreLicense storeLicenseHandle) { }

	[Address(RVA = "0x2B46270", Offset = "0x2B45670", Length = "0x194")]
	[Token(Token = "0x60000A3")]
	public static int XStoreCanAcquireLicenseForPackageAsync(XStoreContext storeContextHandle, string packageIdentifier, XStoreCanAcquireLicenseForPackageCompleted onCompleted) { }

	[Address(RVA = "0x2B46410", Offset = "0x2B45810", Length = "0x45")]
	[Token(Token = "0x60001A9")]
	public static int XStoreCanAcquireLicenseForPackageAsync(XStoreContext storeContext, string packageIdentifier, XAsyncBlock async) { }

	[Address(RVA = "0x2B46460", Offset = "0x2B45860", Length = "0xD5")]
	[Token(Token = "0x60001AA")]
	public static int XStoreCanAcquireLicenseForPackageResult(XAsyncBlock async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult) { }

	[Address(RVA = "0x2B46540", Offset = "0x2B45940", Length = "0x194")]
	[Token(Token = "0x60000A4")]
	public static int XStoreCanAcquireLicenseForStoreIdAsync(XStoreContext storeContextHandle, string storeProductId, XStoreCanAcquireLicenseForStoreIdCompleted onCompleted) { }

	[Address(RVA = "0x2B466E0", Offset = "0x2B45AE0", Length = "0x45")]
	[Token(Token = "0x60001A7")]
	public static int XStoreCanAcquireLicenseForStoreIdAsync(XStoreContext storeContext, string storeProductId, XAsyncBlock async) { }

	[Address(RVA = "0x2B46730", Offset = "0x2B45B30", Length = "0xD5")]
	[Token(Token = "0x60001A8")]
	public static int XStoreCanAcquireLicenseForStoreIdResult(XAsyncBlock async, out XStoreCanAcquireLicenseResult storeCanAcquireLicenseResult) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60001A1")]
	public static void XStoreCloseContextHandle(XStoreContext storeContext) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60001A2")]
	public static void XStoreCloseLicenseHandle(XStoreLicense storeLicense) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60001AF")]
	public static void XStoreCloseProductsQueryHandle(XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B46810", Offset = "0x2B45C10", Length = "0x5C")]
	[Token(Token = "0x60000AE")]
	public static void XStoreCloseProductsQueryHandle(XStoreQueryResult result) { }

	[Address(RVA = "0x2B46870", Offset = "0x2B45C70", Length = "0xE2")]
	[Token(Token = "0x60001A0")]
	public static int XStoreCreateContext(out XStoreContext storeContext) { }

	[Address(RVA = "0x2B46960", Offset = "0x2B45D60", Length = "0xDC")]
	[Token(Token = "0x600019F")]
	public static int XStoreCreateContext(XUserHandle user, out XStoreContext storeContext) { }

	[Address(RVA = "0x2B46C80", Offset = "0x2B46080", Length = "0x55")]
	[Token(Token = "0x60001B4")]
	public static int XStoreDownloadAndInstallPackagesAsync(XStoreContext storeContext, String[] storeIds, XAsyncBlock async) { }

	[Address(RVA = "0x2B46CE0", Offset = "0x2B460E0", Length = "0x1A3")]
	[Token(Token = "0x60000A5")]
	public static int XStoreDownloadAndInstallPackagesAsync(XStoreContext storeContextHandle, String[] storeIds, XStoreDownloadAndInstallPackagesCompleted onCompleted) { }

	[Address(RVA = "0x2B46EC0", Offset = "0x2B462C0", Length = "0x123")]
	[Token(Token = "0x60001B6")]
	public static int XStoreDownloadAndInstallPackagesResult(XAsyncBlock async, uint count, out String[] packageIdentifiers) { }

	[Address(RVA = "0x2B46E90", Offset = "0x2B46290", Length = "0x2D")]
	[Token(Token = "0x60001B5")]
	public static int XStoreDownloadAndInstallPackagesResultCount(XAsyncBlock async, out uint count) { }

	[Address(RVA = "0x2B46AA0", Offset = "0x2B45EA0", Length = "0x1A0")]
	[Token(Token = "0x60000A6")]
	public static int XStoreDownloadAndInstallPackageUpdatesAsync(XStoreContext storeContextHandle, String[] packageIdentifiers, XStoreDownloadAndInstallPackageUpdatesCompleted onCompleted) { }

	[Address(RVA = "0x2B46A40", Offset = "0x2B45E40", Length = "0x55")]
	[Token(Token = "0x60001B2")]
	public static int XStoreDownloadAndInstallPackageUpdatesAsync(XStoreContext storeContext, String[] packageIdentifiers, XAsyncBlock async) { }

	[Address(RVA = "0x2B46C50", Offset = "0x2B46050", Length = "0x23")]
	[Token(Token = "0x60001B3")]
	public static int XStoreDownloadAndInstallPackageUpdatesResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B47050", Offset = "0x2B46450", Length = "0x1A0")]
	[Token(Token = "0x60000A7")]
	public static int XStoreDownloadPackageUpdatesAsync(XStoreContext storeContextHandle, String[] packageIdentifiers, XStoreDownloadPackageUpdatesCompleted onCompleted) { }

	[Address(RVA = "0x2B46FF0", Offset = "0x2B463F0", Length = "0x55")]
	[Token(Token = "0x60001B0")]
	public static int XStoreDownloadPackageUpdatesAsync(XStoreContext storeContext, String[] packageIdentifiers, XAsyncBlock async) { }

	[Address(RVA = "0x2B47200", Offset = "0x2B46600", Length = "0x23")]
	[Token(Token = "0x60001B1")]
	public static int XStoreDownloadPackageUpdatesResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B473B0", Offset = "0x2B467B0", Length = "0x22A")]
	[Token(Token = "0x60001AE")]
	public static int XStoreEnumerateProductsQuery(XStoreProductQuery productQueryHandle, IntPtr context, XStoreProductQueryCallback callback) { }

	[Address(RVA = "0x2B47230", Offset = "0x2B46630", Length = "0x176")]
	[Token(Token = "0x60000E2")]
	public static int XStoreEnumerateProductsQuery(XStoreProductQuery productQueryHandle, out XStoreProduct[] products) { }

	[Address(RVA = "0x2B47790", Offset = "0x2B46B90", Length = "0x5B")]
	[Token(Token = "0x60001B7")]
	public static int XStoreGetUserCollectionsIdAsync(XStoreContext storeContext, string serviceTicket, string publisherUserId, XAsyncBlock async) { }

	[Address(RVA = "0x2B475E0", Offset = "0x2B469E0", Length = "0x1AC")]
	[Token(Token = "0x60000A8")]
	public static int XStoreGetUserCollectionsIdAsync(XStoreContext storeContextHandle, string serviceTicket, string publisherUserId, XStoreGetUserCollectionsIdCompleted onCompleted) { }

	[Address(RVA = "0x2B47820", Offset = "0x2B46C20", Length = "0xDB")]
	[Token(Token = "0x60001B9")]
	public static int XStoreGetUserCollectionsIdResult(XAsyncBlock async, ulong size, out string result) { }

	[Address(RVA = "0x2B477F0", Offset = "0x2B46BF0", Length = "0x2D")]
	[Token(Token = "0x60001B8")]
	public static int XStoreGetUserCollectionsIdResultSize(XAsyncBlock async, out ulong size) { }

	[Address(RVA = "0x2B47AB0", Offset = "0x2B46EB0", Length = "0x5B")]
	[Token(Token = "0x60001BA")]
	public static int XStoreGetUserPurchaseIdAsync(XStoreContext storeContext, string serviceTicket, string publisherUserId, XAsyncBlock async) { }

	[Address(RVA = "0x2B47900", Offset = "0x2B46D00", Length = "0x1AC")]
	[Token(Token = "0x60000A9")]
	public static int XStoreGetUserPurchaseIdAsync(XStoreContext storeContextHandle, string serviceTicket, string publisherUserId, XStoreGetUserPurchaseIdCompleted onCompleted) { }

	[Address(RVA = "0x2B47B40", Offset = "0x2B46F40", Length = "0xDB")]
	[Token(Token = "0x60001BC")]
	public static int XStoreGetUserPurchaseIdResult(XAsyncBlock async, ulong size, out string result) { }

	[Address(RVA = "0x2B47B10", Offset = "0x2B46F10", Length = "0x2D")]
	[Token(Token = "0x60001BB")]
	public static int XStoreGetUserPurchaseIdResultSize(XAsyncBlock async, out ulong size) { }

	[Address(RVA = "0x2B47C20", Offset = "0x2B47020", Length = "0x61")]
	[Token(Token = "0x60001BD")]
	public static bool XStoreIsAvailabilityPurchasable(XStoreAvailability availability) { }

	[Address(RVA = "0x2B47C90", Offset = "0x2B47090", Length = "0x1D")]
	[Token(Token = "0x60001BE")]
	public static bool XStoreIsLicenseValid(XStoreLicense license) { }

	[Address(RVA = "0x2B47CB0", Offset = "0x2B470B0", Length = "0x1D")]
	[Token(Token = "0x60001BF")]
	public static bool XStoreProductsQueryHasMorePages(XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B47CD0", Offset = "0x2B470D0", Length = "0x192")]
	[Token(Token = "0x60000AA")]
	public static int XStoreProductsQueryNextPageAsync(XStoreProductQuery productQueryHandle, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B47E70", Offset = "0x2B47270", Length = "0x1CE")]
	[Token(Token = "0x60000AB")]
	public static int XStoreProductsQueryNextPageAsync(XStoreQueryResult currentPage, XStoreQueryComplete completionRoutine) { }

	[Address(RVA = "0x2B48040", Offset = "0x2B47440", Length = "0x39")]
	[Token(Token = "0x60001C0")]
	public static int XStoreProductsQueryNextPageAsync(XStoreProductQuery productQueryHandle, XAsyncBlock async) { }

	[Address(RVA = "0x2B48080", Offset = "0x2B47480", Length = "0xC4")]
	[Token(Token = "0x60001C1")]
	public static int XStoreProductsQueryNextPageResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B48150", Offset = "0x2B47550", Length = "0x39")]
	[Token(Token = "0x60001C2")]
	public static int XStoreQueryAddOnLicensesAsync(XStoreContext storeContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B48190", Offset = "0x2B47590", Length = "0x192")]
	[Token(Token = "0x60000AF")]
	public static int XStoreQueryAddOnLicensesAsync(XStoreContext storeContextHandle, XStoreQueryAddOnLicensesCompleted onCompleted) { }

	[Address(RVA = "0x2B48360", Offset = "0x2B47760", Length = "0x1A8")]
	[Token(Token = "0x60001C4")]
	public static int XStoreQueryAddOnLicensesResult(XAsyncBlock async, XStoreAddonLicense[] addOnLicenses) { }

	[Address(RVA = "0x2B48330", Offset = "0x2B47730", Length = "0x2D")]
	[Token(Token = "0x60001C3")]
	public static int XStoreQueryAddOnLicensesResultCount(XAsyncBlock async, out uint count) { }

	[Address(RVA = "0x2B487D0", Offset = "0x2B47BD0", Length = "0x1AC")]
	[Token(Token = "0x60000AC")]
	public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, Action<Int32, XStoreProductQuery> onCompleted) { }

	[Address(RVA = "0x2B48510", Offset = "0x2B47910", Length = "0x59")]
	[Token(Token = "0x60001C5")]
	public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XAsyncBlock async) { }

	[Address(RVA = "0x2B48570", Offset = "0x2B47970", Length = "0x25B")]
	[Token(Token = "0x60000AD")]
	public static int XStoreQueryAssociatedProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B48980", Offset = "0x2B47D80", Length = "0xC4")]
	[Token(Token = "0x60001C6")]
	public static int XStoreQueryAssociatedProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B48A50", Offset = "0x2B47E50", Length = "0x194")]
	[Token(Token = "0x60000B0")]
	public static int XStoreQueryConsumableBalanceRemainingAsync(XStoreContext storeContextHandle, string storeProductId, XStoreQueryConsumableBalanceRemainingCompleted onCompleted) { }

	[Address(RVA = "0x2B48BF0", Offset = "0x2B47FF0", Length = "0x45")]
	[Token(Token = "0x60001C7")]
	public static int XStoreQueryConsumableBalanceRemainingAsync(XStoreContext storeContext, string storeProductId, XAsyncBlock async) { }

	[Address(RVA = "0x2B48C40", Offset = "0x2B48040", Length = "0xC5")]
	[Token(Token = "0x60001C8")]
	public static int XStoreQueryConsumableBalanceRemainingResult(XAsyncBlock async, out XStoreConsumableResult consumableResult) { }

	[Address(RVA = "0x2B48D10", Offset = "0x2B48110", Length = "0x1AC")]
	[Token(Token = "0x60000B1")]
	public static int XStoreQueryEntitledProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B48EC0", Offset = "0x2B482C0", Length = "0x59")]
	[Token(Token = "0x60001C9")]
	public static int XStoreQueryEntitledProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, uint maxItemsToRetrievePerPage, XAsyncBlock async) { }

	[Address(RVA = "0x2B48F20", Offset = "0x2B48320", Length = "0xC4")]
	[Token(Token = "0x60001CA")]
	public static int XStoreQueryEntitledProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B49030", Offset = "0x2B48430", Length = "0x192")]
	[Token(Token = "0x60000B2")]
	public static int XStoreQueryGameAndDlcPackageUpdatesAsync(XStoreContext storeContextHandle, XStoreQueryGameAndDlcPackageUpdatesCompleted onCompleted) { }

	[Address(RVA = "0x2B48FF0", Offset = "0x2B483F0", Length = "0x39")]
	[Token(Token = "0x60001CB")]
	public static int XStoreQueryGameAndDlcPackageUpdatesAsync(XStoreContext storeContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B49200", Offset = "0x2B48600", Length = "0x17A")]
	[Token(Token = "0x60001CD")]
	public static int XStoreQueryGameAndDlcPackageUpdatesResult(XAsyncBlock async, XStorePackageUpdate[] packageUpdates) { }

	[Address(RVA = "0x2B491D0", Offset = "0x2B485D0", Length = "0x2D")]
	[Token(Token = "0x60001CC")]
	public static int XStoreQueryGameAndDlcPackageUpdatesResultCount(XAsyncBlock async, out uint count) { }

	[Address(RVA = "0x2B49520", Offset = "0x2B48920", Length = "0x39")]
	[Token(Token = "0x60001CE")]
	public static int XStoreQueryGameLicenseAsync(XStoreContext storeContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B49380", Offset = "0x2B48780", Length = "0x192")]
	[Token(Token = "0x60000B3")]
	public static int XStoreQueryGameLicenseAsync(XStoreContext storeContextHandle, XStoreQueryGameLicenseCompleted onCompleted) { }

	[Address(RVA = "0x2B49560", Offset = "0x2B48960", Length = "0x103")]
	[Token(Token = "0x60001CF")]
	public static int XStoreQueryGameLicenseResult(XAsyncBlock async, out XStoreGameLicense license) { }

	[Address(RVA = "0x2B49A20", Offset = "0x2B48E20", Length = "0x67")]
	[Token(Token = "0x60001D0")]
	public static int XStoreQueryLicenseTokenAsync(XStoreContext storeContext, String[] productIds, string customDeveloperString, XAsyncBlock async) { }

	[Address(RVA = "0x2B49830", Offset = "0x2B48C30", Length = "0x1E9")]
	[Obsolete("Please use XStoreQueryLicenseTokenAsync(XStoreContext, string[], string, XStoreQueryLicenseTokenCompleted) instead.", False)]
	[Token(Token = "0x60000B5")]
	public static void XStoreQueryLicenseTokenAsync(XStoreContext context, String[] productIds, uint productIdsCount, string customDeveloperString, XStoreQueryLicenseTokenCompleted completionRoutine) { }

	[Address(RVA = "0x2B49670", Offset = "0x2B48A70", Length = "0x1BF")]
	[Token(Token = "0x60000B4")]
	public static int XStoreQueryLicenseTokenAsync(XStoreContext storeContextHandle, String[] productIds, string customDeveloperString, XStoreQueryLicenseTokenCompleted onCompleted) { }

	[Address(RVA = "0x2B49AC0", Offset = "0x2B48EC0", Length = "0xDB")]
	[Token(Token = "0x60001D2")]
	public static int XStoreQueryLicenseTokenResult(XAsyncBlock async, ulong size, out string result) { }

	[Address(RVA = "0x2B49A90", Offset = "0x2B48E90", Length = "0x2D")]
	[Token(Token = "0x60001D1")]
	public static int XStoreQueryLicenseTokenResultSize(XAsyncBlock async, out ulong size) { }

	[Address(RVA = "0x2B49CB0", Offset = "0x2B490B0", Length = "0xCC")]
	[Token(Token = "0x60001D3")]
	public static int XStoreQueryPackageIdentifier(string storeId, ulong size, out string packageIdentifier) { }

	[Address(RVA = "0x2B49BA0", Offset = "0x2B48FA0", Length = "0x10F")]
	[Token(Token = "0x60001D4")]
	public static int XStoreQueryPackageIdentifier(string storeId, out string packageIdentifier) { }

	[Address(RVA = "0x2B49DC0", Offset = "0x2B491C0", Length = "0x192")]
	[Token(Token = "0x60000B6")]
	public static int XStoreQueryProductForCurrentGameAsync(XStoreContext storeContextHandle, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B49D80", Offset = "0x2B49180", Length = "0x39")]
	[Token(Token = "0x60001AB")]
	public static int XStoreQueryProductForCurrentGameAsync(XStoreContext storeContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B49F60", Offset = "0x2B49360", Length = "0xC4")]
	[Token(Token = "0x60001AC")]
	public static int XStoreQueryProductForCurrentGameResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B4A090", Offset = "0x2B49490", Length = "0x1AC")]
	[Token(Token = "0x60000B7")]
	public static int XStoreQueryProductForPackageAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, string packageIdentifier, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B4A030", Offset = "0x2B49430", Length = "0x59")]
	[Token(Token = "0x60001D5")]
	public static int XStoreQueryProductForPackageAsync(XStoreContext storeContext, XStoreProductKind productKinds, string packageIdentifier, XAsyncBlock async) { }

	[Address(RVA = "0x2B4A240", Offset = "0x2B49640", Length = "0xC4")]
	[Token(Token = "0x60001D6")]
	public static int XStoreQueryProductForPackageResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B4A310", Offset = "0x2B49710", Length = "0x99")]
	[Token(Token = "0x60001D7")]
	public static int XStoreQueryProductsAsync(XStoreContext storeContext, XStoreProductKind productKinds, String[] storeIds, String[] actionFilters, XAsyncBlock async) { }

	[Address(RVA = "0x2B4A3B0", Offset = "0x2B497B0", Length = "0x1E3")]
	[Token(Token = "0x60000B8")]
	public static int XStoreQueryProductsAsync(XStoreContext storeContextHandle, XStoreProductKind productKinds, String[] storeIds, String[] actionFilters, XStoreQueryComplete onCompleted) { }

	[Address(RVA = "0x2B4A5A0", Offset = "0x2B499A0", Length = "0xC4")]
	[Token(Token = "0x60001D8")]
	public static int XStoreQueryProductsResult(XAsyncBlock async, out XStoreProductQuery productQueryHandle) { }

	[Address(RVA = "0x2B4A700", Offset = "0x2B49B00", Length = "0x1DD")]
	[Token(Token = "0x60001D9")]
	public static int XStoreRegisterGameLicenseChanged(XStoreContext storeContext, XTaskQueueHandle queue, IntPtr context, XStoreGameLicenseChangedCallback callback, out GameLicenseChangedCallbackToken token) { }

	[Address(RVA = "0x2B4A670", Offset = "0x2B49A70", Length = "0x8A")]
	[Token(Token = "0x60000B9")]
	public static int XStoreRegisterGameLicenseChanged(XStoreContext context, XStoreGameLicenseChangedCallback callback, out GameLicenseChangedCallbackToken token) { }

	[Address(RVA = "0x2B4A8E0", Offset = "0x2B49CE0", Length = "0x1DD")]
	[Token(Token = "0x60001DB")]
	public static int XStoreRegisterPackageLicenseLost(XStoreLicense licenseHandle, XTaskQueueHandle queue, IntPtr context, XStorePackageLicenseLostCallback callback, out PackageLicenseLostCallbackToken token) { }

	[Address(RVA = "0x2B4AAC0", Offset = "0x2B49EC0", Length = "0x8A")]
	[Token(Token = "0x60000BB")]
	public static int XStoreRegisterPackageLicenseLost(XStoreLicense license, XStorePackageLicenseLostCallback callback, out PackageLicenseLostCallbackToken token) { }

	[Address(RVA = "0x2B4AB50", Offset = "0x2B49F50", Length = "0x7A")]
	[Token(Token = "0x60001DE")]
	public static int XStoreReportConsumableFulfillmentAsync(XStoreContext storeContext, string storeProductId, uint quantity, Guid trackingId, XAsyncBlock async) { }

	[Address(RVA = "0x2B4ABD0", Offset = "0x2B49FD0", Length = "0x1CC")]
	[Token(Token = "0x60000BD")]
	public static int XStoreReportConsumableFulfillmentAsync(XStoreContext storeContextHandle, string storeProductId, uint quantity, Guid trackingId, XStoreReportConsumableFulfillmentCompleted onCompleted) { }

	[Address(RVA = "0x2B4ADA0", Offset = "0x2B4A1A0", Length = "0xC5")]
	[Token(Token = "0x60001DF")]
	public static int XStoreReportConsumableFulfillmentResult(XAsyncBlock async, out XStoreConsumableResult consumableResult) { }

	[Address(RVA = "0x2B4AE70", Offset = "0x2B4A270", Length = "0x5B")]
	[Token(Token = "0x60001E0")]
	public static int XStoreShowAssociatedProductsUIAsync(XStoreContext storeContext, string storeId, XStoreProductKind productKinds, XAsyncBlock async) { }

	[Address(RVA = "0x2B4AED0", Offset = "0x2B4A2D0", Length = "0x1A9")]
	[Token(Token = "0x60000BE")]
	public static int XStoreShowAssociatedProductsUIAsync(XStoreContext storeContextHandle, string storeId, XStoreProductKind productKinds, XStoreShowAssociatedProductsUICompleted onCompleted) { }

	[Address(RVA = "0x2B4B080", Offset = "0x2B4A480", Length = "0x23")]
	[Token(Token = "0x60001E1")]
	public static int XStoreShowAssociatedProductsUIResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4B100", Offset = "0x2B4A500", Length = "0x191")]
	[Token(Token = "0x60000BF")]
	public static int XStoreShowProductPageUIAsync(XStoreContext storeContextHandle, string storeId, XStoreShowProductPageUICompleted onCompleted) { }

	[Address(RVA = "0x2B4B0B0", Offset = "0x2B4A4B0", Length = "0x45")]
	[Token(Token = "0x60001E2")]
	public static int XStoreShowProductPageUIAsync(XStoreContext storeContext, string storeId, XAsyncBlock async) { }

	[Address(RVA = "0x2B4B2A0", Offset = "0x2B4A6A0", Length = "0x23")]
	[Token(Token = "0x60001E3")]
	public static int XStoreShowProductPageUIResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4B2D0", Offset = "0x2B4A6D0", Length = "0x1B0")]
	[Token(Token = "0x60000C0")]
	public static int XStoreShowPurchaseUIAsync(XStoreContext storeContextHandle, string storeId, string name, string extendedJsonData, XStoreShowPurchaseUICompleted onCompleted) { }

	[Address(RVA = "0x2B4B490", Offset = "0x2B4A890", Length = "0x6F")]
	[Token(Token = "0x60001E4")]
	public static int XStoreShowPurchaseUIAsync(XStoreContext storeContext, string storeId, string name, string extendedJsonData, XAsyncBlock async) { }

	[Address(RVA = "0x2B4B500", Offset = "0x2B4A900", Length = "0x23")]
	[Token(Token = "0x60001E5")]
	public static int XStoreShowPurchaseUIResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4B570", Offset = "0x2B4A970", Length = "0x192")]
	[Token(Token = "0x60000C1")]
	public static int XStoreShowRateAndReviewUIAsync(XStoreContext storeContextHandle, XStoreShowRateAndReviewUICompleted onCompleted) { }

	[Address(RVA = "0x2B4B530", Offset = "0x2B4A930", Length = "0x39")]
	[Token(Token = "0x60001E6")]
	public static int XStoreShowRateAndReviewUIAsync(XStoreContext storeContext, XAsyncBlock async) { }

	[Address(RVA = "0x2B4B710", Offset = "0x2B4AB10", Length = "0xCB")]
	[Token(Token = "0x60001E7")]
	public static int XStoreShowRateAndReviewUIResult(XAsyncBlock async, out XStoreRateAndReviewResult result) { }

	[Address(RVA = "0x2B4B9B0", Offset = "0x2B4ADB0", Length = "0x7C")]
	[Token(Token = "0x60001E8")]
	public static int XStoreShowRedeemTokenUIAsync(XStoreContext storeContext, string token, String[] allowedStoreIds, bool disallowCsvRedemption, XAsyncBlock async) { }

	[Address(RVA = "0x2B4B7E0", Offset = "0x2B4ABE0", Length = "0x1CA")]
	[Token(Token = "0x60000C2")]
	public static int XStoreShowRedeemTokenUIAsync(XStoreContext storeContextHandle, string token, String[] allowedStoreIds, bool disallowCsvRedemption, XStoreShowRedeemTokenUICompleted onCompleted) { }

	[Address(RVA = "0x2B4BA30", Offset = "0x2B4AE30", Length = "0x23")]
	[Token(Token = "0x60001E9")]
	public static int XStoreShowRedeemTokenUIResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4BA90", Offset = "0x2B4AE90", Length = "0x1A")]
	[Token(Token = "0x60001DA")]
	public static bool XStoreUnregisterGameLicenseChanged(GameLicenseChangedCallbackToken token, bool wait) { }

	[Address(RVA = "0x2B4BA60", Offset = "0x2B4AE60", Length = "0x22")]
	[Token(Token = "0x60000BA")]
	public static void XStoreUnregisterGameLicenseChanged(XStoreContext context, GameLicenseChangedCallbackToken token) { }

	[Address(RVA = "0x2B4BB10", Offset = "0x2B4AF10", Length = "0x1A")]
	[Token(Token = "0x60001DC")]
	public static bool XStoreUnregisterPackageLicenseLost(PackageLicenseLostCallbackToken token, bool wait) { }

	[Address(RVA = "0x2B4BAB0", Offset = "0x2B4AEB0", Length = "0x56")]
	[Token(Token = "0x60001DD")]
	public static bool XStoreUnregisterPackageLicenseLost(PackageLicenseLostCallbackToken token) { }

	[Address(RVA = "0x2B4BB30", Offset = "0x2B4AF30", Length = "0x22")]
	[Token(Token = "0x60000BC")]
	public static void XStoreUnregisterPackageLicenseLost(XStoreLicense license, PackageLicenseLostCallbackToken token) { }

	[Address(RVA = "0x2B4BB60", Offset = "0x2B4AF60", Length = "0x8B")]
	[Token(Token = "0x60001EA")]
	public static XSystemAnalyticsInfo XSystemGetAnalyticsInfo() { }

	[Address(RVA = "0x2B4BBF0", Offset = "0x2B4AFF0", Length = "0x101")]
	[Token(Token = "0x60001EB")]
	public static int XSystemGetAppSpecificDeviceId(out string appSpecificDeviceId) { }

	[Address(RVA = "0x2B4BD00", Offset = "0x2B4B100", Length = "0x101")]
	[Token(Token = "0x60001EC")]
	public static int XSystemGetConsoleId(out string consoleId) { }

	[Address(RVA = "0x2B4BE10", Offset = "0x2B4B210", Length = "0x7")]
	[Token(Token = "0x60001ED")]
	public static XSystemDeviceType XSystemGetDeviceType() { }

	[Address(RVA = "0x2B4BE20", Offset = "0x2B4B220", Length = "0x69")]
	[Token(Token = "0x60001EF")]
	public static XSystemRuntimeInfo XSystemGetRuntimeInfo() { }

	[Address(RVA = "0x2B4BE90", Offset = "0x2B4B290", Length = "0x101")]
	[Token(Token = "0x60001EE")]
	public static int XSystemGetXboxLiveSandboxId(out string sandboxId) { }

	[Address(RVA = "0x2B4BFA0", Offset = "0x2B4B3A0", Length = "0x17A")]
	[Token(Token = "0x60001F1")]
	public static int XSystemHandleTrack(XSystemHandleCallback callback, IntPtr context, out XSystemHandleCallbackHandle handle) { }

	[Address(RVA = "0x2B4C120", Offset = "0x2B4B520", Length = "0x7")]
	[Token(Token = "0x60001F0")]
	public static bool XSystemIsHandleValid(IntPtr handle) { }

	[Address(RVA = "0x2B39870", Offset = "0x2B38C70", Length = "0x19")]
	[Token(Token = "0x60001F2")]
	public static void XTaskQueueCloseHandle(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B4C200", Offset = "0x2B4B600", Length = "0xB2")]
	[Token(Token = "0x60001F3")]
	public static int XTaskQueueCreate(XTaskQueueDispatchMode workDispatchMode, XTaskQueueDispatchMode completionDispatchMode, out XTaskQueueHandle handle) { }

	[Address(RVA = "0x2B4C130", Offset = "0x2B4B530", Length = "0xC7")]
	[Token(Token = "0x60001F4")]
	public static int XTaskQueueCreateComposite(XTaskQueuePortHandle workPort, XTaskQueuePortHandle completionPort, out XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B4C2C0", Offset = "0x2B4B6C0", Length = "0x71")]
	[Token(Token = "0x6000080")]
	public static bool XTaskQueueDispatch(uint timeoutInMs) { }

	[Address(RVA = "0x2B4C340", Offset = "0x2B4B740", Length = "0x1E")]
	[Token(Token = "0x60001F5")]
	public static bool XTaskQueueDispatch(XTaskQueueHandle queue, XTaskQueuePort port, uint timeoutInMs) { }

	[Address(RVA = "0x2B4C360", Offset = "0x2B4B760", Length = "0xBB")]
	[Token(Token = "0x60001F6")]
	public static int XTaskQueueDuplicateHandle(XTaskQueueHandle queue, out XTaskQueueHandle duplicatedHandle) { }

	[Address(RVA = "0x2B4C420", Offset = "0x2B4B820", Length = "0x96")]
	[Token(Token = "0x60001F7")]
	public static bool XTaskQueueGetCurrentProcessTaskQueue(out XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B4C4C0", Offset = "0x2B4B8C0", Length = "0xBF")]
	[Token(Token = "0x60001F8")]
	public static int XTaskQueueGetPort(XTaskQueueHandle queue, XTaskQueuePort port, out XTaskQueuePortHandle portHandle) { }

	[Address(RVA = "0x2B4C580", Offset = "0x2B4B980", Length = "0x1C3")]
	[Token(Token = "0x60001F9")]
	public static int XTaskQueueRegisterMonitor(XTaskQueueHandle queue, IntPtr callbackContext, XTaskQueueMonitorCallback callback, out XTaskQueueMonitorCallbackHandle tokenHandle) { }

	[Address(RVA = "0x2B4C750", Offset = "0x2B4BB50", Length = "0x20B")]
	[Token(Token = "0x60001FA")]
	public static int XTaskQueueRegisterWaiter(XTaskQueueHandle queue, XTaskQueuePort port, WaitHandle waitHandle, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueWaiterCallbackHandle tokenHandle) { }

	[Address(RVA = "0x2B4C960", Offset = "0x2B4BD60", Length = "0x1D")]
	[Token(Token = "0x60001FB")]
	public static void XTaskQueueSetCurrentProcessTaskQueue(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B4C980", Offset = "0x2B4BD80", Length = "0x1AA")]
	[Token(Token = "0x60001FC")]
	public static int XTaskQueueSubmitCallback(XTaskQueueHandle queue, XTaskQueuePort port, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueCallbackHandle callbackHandle) { }

	[Address(RVA = "0x2B4CB30", Offset = "0x2B4BF30", Length = "0x1B6")]
	[Token(Token = "0x60001FD")]
	public static int XTaskQueueSubmitDelayedCallback(XTaskQueueHandle queue, XTaskQueuePort port, uint delayMs, IntPtr callbackContext, XTaskQueueCallback callback, out XTaskQueueCallbackHandle callbackHandle) { }

	[Address(RVA = "0x2B4CCF0", Offset = "0x2B4C0F0", Length = "0x1AD")]
	[Token(Token = "0x60001FE")]
	public static int XTaskQueueTerminate(XTaskQueueHandle queue, bool wait, IntPtr callbackContext, XTaskQueueTerminatedCallback callback, out XTaskQueueTerminateCallbackHandle callbackHandle) { }

	[Address(RVA = "0x2B4CEA0", Offset = "0x2B4C2A0", Length = "0x28")]
	[Token(Token = "0x60001FF")]
	public static int XTaskQueueTerminate(XTaskQueueHandle queue, bool wait, IntPtr callbackContext) { }

	[Address(RVA = "0x2B4CED0", Offset = "0x2B4C2D0", Length = "0x23")]
	[Token(Token = "0x6000200")]
	public static void XTaskQueueUnregisterMonitor(XTaskQueueHandle queue, XTaskQueueMonitorCallbackHandle token) { }

	[Address(RVA = "0x2B4CF00", Offset = "0x2B4C300", Length = "0x23")]
	[Token(Token = "0x6000201")]
	public static void XTaskQueueUnregisterWaiter(XTaskQueueHandle queue, XTaskQueueWaiterCallbackHandle token) { }

	[Address(RVA = "0x2B4CF30", Offset = "0x2B4C330", Length = "0x7")]
	[Token(Token = "0x6000202")]
	public static void XThreadAssertNotTimeSensitive() { }

	[Address(RVA = "0x2B4CF40", Offset = "0x2B4C340", Length = "0x7")]
	[Token(Token = "0x6000203")]
	public static bool XThreadIsTimeSensitive() { }

	[Address(RVA = "0x2B4CF50", Offset = "0x2B4C350", Length = "0x7")]
	[Token(Token = "0x6000204")]
	public static int XThreadSetTimeSensitive(bool isTimeSensitiveThread) { }

	[Address(RVA = "0x2B4CF60", Offset = "0x2B4C360", Length = "0x31")]
	[Token(Token = "0x6000205")]
	public static int XUserAddAsync(XUserAddOptions options, XAsyncBlock async) { }

	[Address(RVA = "0x2B4CFA0", Offset = "0x2B4C3A0", Length = "0x189")]
	[Token(Token = "0x60000C9")]
	public static int XUserAddAsync(XUserAddOptions options, XUserAddCompleted onCompleted) { }

	[Address(RVA = "0x2B4D2C0", Offset = "0x2B4C6C0", Length = "0x33")]
	[Token(Token = "0x6000207")]
	public static int XUserAddByIdWithUiAsync(ulong userId, XAsyncBlock async) { }

	[Address(RVA = "0x2B4D130", Offset = "0x2B4C530", Length = "0x189")]
	[Token(Token = "0x60000C3")]
	public static int XUserAddByIdWithUiAsync(ulong userId, XUserAddCompleted onCompleted) { }

	[Address(RVA = "0x2B4D300", Offset = "0x2B4C700", Length = "0x4B")]
	[Token(Token = "0x6000208")]
	public static int XUserAddByIdWithUiResult(XAsyncBlock async, out XUserHandle newUser) { }

	[Address(RVA = "0x2B4D350", Offset = "0x2B4C750", Length = "0x4B")]
	[Token(Token = "0x6000206")]
	public static int XUserAddResult(XAsyncBlock async, out XUserHandle newUser) { }

	[Address(RVA = "0x2B4D3A0", Offset = "0x2B4C7A0", Length = "0x6F")]
	[Token(Token = "0x6000209")]
	public static int XUserCheckPrivilege(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, out bool hasPrivilege, out XUserPrivilegeDenyReason reason) { }

	[Address(RVA = "0x2B4D410", Offset = "0x2B4C810", Length = "0x36")]
	[Token(Token = "0x600020A")]
	public static void XUserCloseHandle(XUserHandle user) { }

	[Address(RVA = "0x2B4D450", Offset = "0x2B4C850", Length = "0x1C")]
	[Token(Token = "0x600020B")]
	public static int XUserCloseSignOutDeferralHandle(XUserSignOutDeferralHandle deferral) { }

	[Address(RVA = "0x2B4D470", Offset = "0x2B4C870", Length = "0xC9")]
	[Token(Token = "0x600020D")]
	public static int XUserCompare(XUserHandle user1, XUserHandle user2, out int comparisonResult) { }

	[Address(RVA = "0x2B4D540", Offset = "0x2B4C940", Length = "0x80")]
	[Token(Token = "0x600020C")]
	public static int XUserCompare(XUserHandle user1, XUserHandle user2) { }

	[Address(RVA = "0x2B4D5C0", Offset = "0x2B4C9C0", Length = "0x70")]
	[Token(Token = "0x600020E")]
	public static int XUserDuplicateHandle(XUserHandle handle, out XUserHandle duplicatedHandle) { }

	[Address(RVA = "0x2B4D7E0", Offset = "0x2B4CBE0", Length = "0x62")]
	[Token(Token = "0x600020F")]
	public static int XUserFindControllerForUserWithUiAsync(XUserHandle user, XAsyncBlock async) { }

	[Address(RVA = "0x2B4D630", Offset = "0x2B4CA30", Length = "0x1A9")]
	[Token(Token = "0x60000C4")]
	public static int XUserFindControllerForUserWithUiAsync(XUserHandle user, XUserFindControllerForUserWithUiResult onCompleted) { }

	[Address(RVA = "0x2B4D850", Offset = "0x2B4CC50", Length = "0xC9")]
	[Token(Token = "0x6000210")]
	public static int XUserFindControllerForUserWithUiResult(XAsyncBlock async, out APP_LOCAL_DEVICE_ID deviceId) { }

	[Address(RVA = "0x2B4D920", Offset = "0x2B4CD20", Length = "0x45")]
	[Token(Token = "0x6000211")]
	public static int XUserFindForDevice(APP_LOCAL_DEVICE_ID deviceId, out XUserHandle handle) { }

	[Address(RVA = "0x2B4D970", Offset = "0x2B4CD70", Length = "0x37")]
	[Token(Token = "0x6000212")]
	public static int XUserFindUserById(ulong userId, out XUserHandle handle) { }

	[Address(RVA = "0x2B4D9B0", Offset = "0x2B4CDB0", Length = "0x45")]
	[Token(Token = "0x6000213")]
	public static int XUserFindUserByLocalId(XUserLocalId userLocalId, out XUserHandle handle) { }

	[Address(RVA = "0x2B4DA00", Offset = "0x2B4CE00", Length = "0x4B")]
	[Token(Token = "0x6000214")]
	public static int XUserGetAgeGroup(XUserHandle user, out XUserAgeGroup ageGroup) { }

	[Address(RVA = "0x2B4DA50", Offset = "0x2B4CE50", Length = "0x24")]
	[Token(Token = "0x6000215")]
	public static int XUserGetDefaultAudioEndpointUtf16(XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, ulong endpointIdUtf16Count, Char[] endpointIdUtf16, out ulong endpointIdUtf16Used) { }

	[Address(RVA = "0x2B4DA80", Offset = "0x2B4CE80", Length = "0x70")]
	[Token(Token = "0x6000216")]
	public static int XUserGetGamerPictureAsync(XUserHandle user, XUserGamerPictureSize pictureSize, XAsyncBlock async) { }

	[Address(RVA = "0x2B4DB00", Offset = "0x2B4CF00", Length = "0x1BA")]
	[Token(Token = "0x60000C8")]
	public static int XUserGetGamerPictureAsync(XUserHandle user, XUserGamerPictureSize pictureSize, XUserGetGamerPictureCompleted onCompleted) { }

	[Address(RVA = "0x2B4DCF0", Offset = "0x2B4D0F0", Length = "0x4C")]
	[Token(Token = "0x6000218")]
	public static int XUserGetGamerPictureResult(XAsyncBlock async, Byte[] buffer, out ulong bufferUsed) { }

	[Address(RVA = "0x2B4DCC0", Offset = "0x2B4D0C0", Length = "0x2D")]
	[Token(Token = "0x6000217")]
	public static int XUserGetGamerPictureResultSize(XAsyncBlock async, out ulong bufferSize) { }

	[Address(RVA = "0x2B4DD40", Offset = "0x2B4D140", Length = "0x179")]
	[Token(Token = "0x60000E3")]
	public static int XUserGetGamertag(XUserHandle user, XUserGamertagComponent gamertagComponent, out string gamertag) { }

	[Address(RVA = "0x2B4DEC0", Offset = "0x2B4D2C0", Length = "0x8C")]
	[Token(Token = "0x6000219")]
	public static int XUserGetGamertag(XUserHandle user, XUserGamertagComponent gamertagComponent, StringBuilder gamertag, out ulong gamertagUsed) { }

	[Address(RVA = "0x2B4DF50", Offset = "0x2B4D350", Length = "0x4B")]
	[Token(Token = "0x600021A")]
	public static int XUserGetId(XUserHandle user, out ulong userId) { }

	[Address(RVA = "0x2B4DFA0", Offset = "0x2B4D3A0", Length = "0x4B")]
	[Token(Token = "0x600021B")]
	public static int XUserGetIsGuest(XUserHandle user, out bool isGuest) { }

	[Address(RVA = "0x2B4DFF0", Offset = "0x2B4D3F0", Length = "0xDA")]
	[Token(Token = "0x600021C")]
	public static int XUserGetLocalId(XUserHandle user, out XUserLocalId userLocalId) { }

	[Address(RVA = "0x2B4E0D0", Offset = "0x2B4D4D0", Length = "0x7")]
	[Token(Token = "0x600021D")]
	public static int XUserGetMaxUsers(out uint maxUsers) { }

	[Address(RVA = "0x2B4E0E0", Offset = "0x2B4D4E0", Length = "0xA9")]
	[Token(Token = "0x600021E")]
	public static int XUserGetSignOutDeferral(out XUserSignOutDeferralHandle deferral) { }

	[Address(RVA = "0x2B4E190", Offset = "0x2B4D590", Length = "0x4B")]
	[Token(Token = "0x600021F")]
	public static int XUserGetState(XUserHandle user, out XUserState state) { }

	[Address(RVA = "0x2B4E1E0", Offset = "0x2B4D5E0", Length = "0x19E")]
	[Token(Token = "0x6000220")]
	public static int XUserGetTokenAndSignatureAsync(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureHttpHeader[] headers, Byte[] bodyBuffer, XAsyncBlock async) { }

	[Address(RVA = "0x2B4E3B0", Offset = "0x2B4D7B0", Length = "0x1B3")]
	[Token(Token = "0x6000222")]
	public static int XUserGetTokenAndSignatureResult(XAsyncBlock async, Byte[] buffer, out XUserGetTokenAndSignatureData result) { }

	[Address(RVA = "0x2B4E380", Offset = "0x2B4D780", Length = "0x2D")]
	[Token(Token = "0x6000221")]
	public static int XUserGetTokenAndSignatureResultSize(XAsyncBlock async, out ulong bufferSize) { }

	[Address(RVA = "0x2B4E570", Offset = "0x2B4D970", Length = "0x2E5")]
	[Token(Token = "0x60000C5")]
	public static int XUserGetTokenAndSignatureUtf16Async(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, Byte[] bodyBuffer, XUserGetTokenAndSignatureUtf16Result onCompleted) { }

	[Address(RVA = "0x2B4E860", Offset = "0x2B4DC60", Length = "0x19E")]
	[Token(Token = "0x6000223")]
	public static int XUserGetTokenAndSignatureUtf16Async(XUserHandle user, XUserGetTokenAndSignatureOptions options, string method, string url, XUserGetTokenAndSignatureUtf16HttpHeader[] headers, Byte[] bodyBuffer, XAsyncBlock async) { }

	[Address(RVA = "0x2B4EA30", Offset = "0x2B4DE30", Length = "0x1B3")]
	[Token(Token = "0x6000225")]
	public static int XUserGetTokenAndSignatureUtf16Result(XAsyncBlock async, Byte[] buffer, out XUserGetTokenAndSignatureUtf16Data result) { }

	[Address(RVA = "0x2B4EA00", Offset = "0x2B4DE00", Length = "0x2D")]
	[Token(Token = "0x6000224")]
	public static int XUserGetTokenAndSignatureUtf16ResultSize(XAsyncBlock async, out ulong bufferSize) { }

	[Address(RVA = "0x2B4EBF0", Offset = "0x2B4DFF0", Length = "0x45")]
	[Token(Token = "0x6000226")]
	public static bool XUserIsStoreUser(XUserHandle user) { }

	[Address(RVA = "0x2B4EE20", Offset = "0x2B4E220", Length = "0x74")]
	[Token(Token = "0x6000081")]
	public static int XUserRegisterForChangeEvent(XUserChangeEventCallback callback, out XUserChangeRegistrationToken token) { }

	[Address(RVA = "0x2B4EC40", Offset = "0x2B4E040", Length = "0x1D7")]
	[Token(Token = "0x6000227")]
	public static int XUserRegisterForChangeEvent(XTaskQueueHandle queue, IntPtr context, XUserChangeEventCallback callback, out XUserChangeRegistrationToken token) { }

	[Address(RVA = "0x2B4EEA0", Offset = "0x2B4E2A0", Length = "0x1D7")]
	[Token(Token = "0x6000228")]
	public static int XUserRegisterForDefaultAudioEndpointUtf16Changed(XTaskQueueHandle queue, IntPtr context, XUserDefaultAudioEndpointUtf16ChangedCallback callback, out XUserDefaultAudioEndpointUtf16RegistrationToken token) { }

	[Address(RVA = "0x2B4F080", Offset = "0x2B4E480", Length = "0x1D7")]
	[Token(Token = "0x6000229")]
	public static int XUserRegisterForDeviceAssociationChanged(XTaskQueueHandle queue, IntPtr context, XUserDeviceAssociationChangedCallback callback, out XUserDeviceAssociationChangedRegistrationToken token) { }

	[Address(RVA = "0x2B4F260", Offset = "0x2B4E660", Length = "0x72")]
	[Token(Token = "0x600022A")]
	public static int XUserResolveIssueWithUiAsync(XUserHandle user, string url, XAsyncBlock async) { }

	[Address(RVA = "0x2B4F2E0", Offset = "0x2B4E6E0", Length = "0x23")]
	[Token(Token = "0x600022B")]
	public static int XUserResolveIssueWithUiResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4F310", Offset = "0x2B4E710", Length = "0x72")]
	[Token(Token = "0x600022C")]
	public static int XUserResolveIssueWithUiUtf16Async(XUserHandle user, string url, XAsyncBlock async) { }

	[Address(RVA = "0x2B4F390", Offset = "0x2B4E790", Length = "0x1B7")]
	[Token(Token = "0x60000C6")]
	public static int XUserResolveIssueWithUiUtf16Async(XUserHandle user, string url, XUserResolveIssueWithUiUtf16Result onCompleted) { }

	[Address(RVA = "0x2B4F550", Offset = "0x2B4E950", Length = "0x23")]
	[Token(Token = "0x600022D")]
	public static int XUserResolveIssueWithUiUtf16Result(XAsyncBlock async) { }

	[Address(RVA = "0x2B4F750", Offset = "0x2B4EB50", Length = "0x86")]
	[Token(Token = "0x600022E")]
	public static int XUserResolvePrivilegeWithUiAsync(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, XAsyncBlock async) { }

	[Address(RVA = "0x2B4F580", Offset = "0x2B4E980", Length = "0x1CA")]
	[Token(Token = "0x60000C7")]
	public static int XUserResolvePrivilegeWithUiAsync(XUserHandle user, XUserPrivilegeOptions options, XUserPrivilege privilege, XUserResolvePrivilegeWithUiCompleted onCompleted) { }

	[Address(RVA = "0x2B4F7E0", Offset = "0x2B4EBE0", Length = "0x23")]
	[Token(Token = "0x600022F")]
	public static int XUserResolvePrivilegeWithUiResult(XAsyncBlock async) { }

	[Address(RVA = "0x2B4F810", Offset = "0x2B4EC10", Length = "0x1A")]
	[Token(Token = "0x6000230")]
	public static bool XUserUnregisterForChangeEvent(XUserChangeRegistrationToken token, bool wait) { }

	[Address(RVA = "0x2B4F830", Offset = "0x2B4EC30", Length = "0x56")]
	[Token(Token = "0x6000231")]
	public static bool XUserUnregisterForChangeEvent(XUserChangeRegistrationToken token) { }

	[Address(RVA = "0x2B4F890", Offset = "0x2B4EC90", Length = "0x1A")]
	[Token(Token = "0x6000232")]
	public static bool XUserUnregisterForDefaultAudioEndpointUtf16Changed(XUserDefaultAudioEndpointUtf16RegistrationToken token, bool wait) { }

	[Address(RVA = "0x2B4F8B0", Offset = "0x2B4ECB0", Length = "0x1A")]
	[Token(Token = "0x6000233")]
	public static bool XUserUnregisterForDeviceAssociationChanged(XUserDeviceAssociationChangedRegistrationToken token, bool wait) { }

	[Address(RVA = "0x2B4F8D0", Offset = "0x2B4ECD0", Length = "0xDD")]
	[Token(Token = "0x60000F9")]
	private static bool XVersionLessThan(XVersion version1, XVersion version2) { }

}

