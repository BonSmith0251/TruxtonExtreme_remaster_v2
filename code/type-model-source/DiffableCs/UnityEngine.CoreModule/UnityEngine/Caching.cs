namespace UnityEngine;

[NativeHeader("Runtime/Misc/CachingManager.h")]
[StaticAccessor("GetCachingManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000A4")]
public sealed class Caching
{

	[Token(Token = "0x1700006E")]
	public static bool compressionEnabled
	{
		[Address(RVA = "0x2FD1430", Offset = "0x2FD0830", Length = "0x33")]
		[Token(Token = "0x60002C4")]
		 set { } //Length: 51
	}

	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000071")]
	public static Cache currentCacheForWriting
	{
		[Address(RVA = "0x2FD1340", Offset = "0x2FD0740", Length = "0x3B")]
		[NativeName("Caching_GetCurrentCacheHandle")]
		[Token(Token = "0x60002D1")]
		 get { } //Length: 59
		[Address(RVA = "0x2FD14B0", Offset = "0x2FD08B0", Length = "0x33")]
		[NativeName("Caching_SetCurrentCacheByHandle")]
		[NativeThrows]
		[Token(Token = "0x60002D2")]
		 set { } //Length: 51
	}

	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000070")]
	public static Cache defaultCache
	{
		[Address(RVA = "0x2FD13C0", Offset = "0x2FD07C0", Length = "0x3B")]
		[NativeName("Caching_GetDefaultCacheHandle")]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 59
	}

	[Token(Token = "0x1700006F")]
	public static bool ready
	{
		[Address(RVA = "0x2FD1400", Offset = "0x2FD0800", Length = "0x2A")]
		[NativeName("GetIsReady")]
		[Token(Token = "0x60002C5")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2FD0540", Offset = "0x2FCF940", Length = "0x239")]
	[Token(Token = "0x60002CD")]
	public static Cache AddCache(string cachePath) { }

	[Address(RVA = "0x2FD0370", Offset = "0x2FCF770", Length = "0x1CB")]
	[NativeName("AddCachePath")]
	[Token(Token = "0x60002CE")]
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	[Address(RVA = "0x2FD0310", Offset = "0x2FCF710", Length = "0x53")]
	[Token(Token = "0x60002D6")]
	private static void AddCache_Injected(ref ManagedSpanWrapper cachePath, bool isReadonly, out Cache ret) { }

	[Address(RVA = "0x2FD0780", Offset = "0x2FCFB80", Length = "0x7E")]
	[Token(Token = "0x60002C9")]
	public static bool ClearAllCachedVersions(string assetBundleName) { }

	[Address(RVA = "0x2FD09F0", Offset = "0x2FCFDF0", Length = "0x86")]
	[Token(Token = "0x60002C6")]
	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash) { }

	[Address(RVA = "0x2FD0850", Offset = "0x2FCFC50", Length = "0x19C")]
	[NativeName("ClearCachedVersion")]
	[Token(Token = "0x60002C7")]
	internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash) { }

	[Address(RVA = "0x2FD0800", Offset = "0x2FCFC00", Length = "0x42")]
	[Token(Token = "0x60002D3")]
	private static bool ClearCachedVersionInternal_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	[Address(RVA = "0x2FD0AE0", Offset = "0x2FCFEE0", Length = "0x1A0")]
	[Token(Token = "0x60002CA")]
	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	[Address(RVA = "0x2FD0A80", Offset = "0x2FCFE80", Length = "0x54")]
	[Token(Token = "0x60002D4")]
	private static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash, bool keepInputVersion) { }

	[Address(RVA = "0x2FD0C90", Offset = "0x2FD0090", Length = "0x89")]
	[Token(Token = "0x60002C8")]
	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	[Address(RVA = "0x2FD1340", Offset = "0x2FD0740", Length = "0x3B")]
	[NativeName("Caching_GetCurrentCacheHandle")]
	[Token(Token = "0x60002D1")]
	public static Cache get_currentCacheForWriting() { }

	[Address(RVA = "0x2FD1300", Offset = "0x2FD0700", Length = "0x33")]
	[Token(Token = "0x60002D9")]
	private static void get_currentCacheForWriting_Injected(out Cache ret) { }

	[Address(RVA = "0x2FD13C0", Offset = "0x2FD07C0", Length = "0x3B")]
	[NativeName("Caching_GetDefaultCacheHandle")]
	[Token(Token = "0x60002D0")]
	public static Cache get_defaultCache() { }

	[Address(RVA = "0x2FD1380", Offset = "0x2FD0780", Length = "0x33")]
	[Token(Token = "0x60002D8")]
	private static void get_defaultCache_Injected(out Cache ret) { }

	[Address(RVA = "0x2FD1400", Offset = "0x2FD0800", Length = "0x2A")]
	[NativeName("GetIsReady")]
	[Token(Token = "0x60002C5")]
	public static bool get_ready() { }

	[Address(RVA = "0x2FD0D70", Offset = "0x2FD0170", Length = "0x1CA")]
	[NativeName("Caching_GetCacheHandleByPath")]
	[NativeThrows]
	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x60002CF")]
	public static Cache GetCacheByPath(string cachePath) { }

	[Address(RVA = "0x2FD0D20", Offset = "0x2FD0120", Length = "0x42")]
	[Token(Token = "0x60002D7")]
	private static void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret) { }

	[Address(RVA = "0x2FD1250", Offset = "0x2FD0650", Length = "0xA1")]
	[Token(Token = "0x60002CB")]
	public static bool IsVersionCached(CachedAssetBundle cachedBundle) { }

	[Address(RVA = "0x2FD0FA0", Offset = "0x2FD03A0", Length = "0x2A4")]
	[NativeName("IsCached")]
	[Token(Token = "0x60002CC")]
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	[Address(RVA = "0x2FD0F40", Offset = "0x2FD0340", Length = "0x52")]
	[Token(Token = "0x60002D5")]
	private static bool IsVersionCached_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	[Address(RVA = "0x2FD1430", Offset = "0x2FD0830", Length = "0x33")]
	[Token(Token = "0x60002C4")]
	public static void set_compressionEnabled(bool value) { }

	[Address(RVA = "0x2FD14B0", Offset = "0x2FD08B0", Length = "0x33")]
	[NativeName("Caching_SetCurrentCacheByHandle")]
	[NativeThrows]
	[Token(Token = "0x60002D2")]
	public static void set_currentCacheForWriting(Cache value) { }

	[Address(RVA = "0x2FD1470", Offset = "0x2FD0870", Length = "0x33")]
	[Token(Token = "0x60002DA")]
	private static void set_currentCacheForWriting_Injected(in Cache value) { }

}

