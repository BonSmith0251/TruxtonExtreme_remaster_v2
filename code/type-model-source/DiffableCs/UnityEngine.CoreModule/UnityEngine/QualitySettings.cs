namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000E7")]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000286")]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	[Token(Token = "0x1700013C")]
	public static ColorSpace activeColorSpace
	{
		[Address(RVA = "0x300F120", Offset = "0x300E520", Length = "0x2A")]
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		[Token(Token = "0x60006BF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013A")]
	public static int antiAliasing
	{
		[Address(RVA = "0x300F150", Offset = "0x300E550", Length = "0x2A")]
		[Token(Token = "0x60006BB")]
		 get { } //Length: 42
		[Address(RVA = "0x300F2A0", Offset = "0x300E6A0", Length = "0x31")]
		[Token(Token = "0x60006BC")]
		 set { } //Length: 49
	}

	[Token(Token = "0x1700013B")]
	public static bool billboardsFaceCameraPosition
	{
		[Address(RVA = "0x300F180", Offset = "0x300E580", Length = "0x2A")]
		[Token(Token = "0x60006BD")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000138")]
	public static bool enableLODCrossFade
	{
		[Address(RVA = "0x300F1B0", Offset = "0x300E5B0", Length = "0x2A")]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 42
		[Address(RVA = "0x300F2E0", Offset = "0x300E6E0", Length = "0x33")]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 51
	}

	[NativeProperty("LODBias")]
	[Token(Token = "0x17000135")]
	public static float lodBias
	{
		[Address(RVA = "0x300F1E0", Offset = "0x300E5E0", Length = "0x2A")]
		[Token(Token = "0x60006B4")]
		 get { } //Length: 42
		[Address(RVA = "0x300F320", Offset = "0x300E720", Length = "0x3A")]
		[Token(Token = "0x60006B5")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000137")]
	public static int maximumLODLevel
	{
		[Address(RVA = "0x300F210", Offset = "0x300E610", Length = "0x2A")]
		[Token(Token = "0x60006B7")]
		 get { } //Length: 42
	}

	[NativeProperty("MeshLODThreshold")]
	[Token(Token = "0x17000136")]
	public static float meshLodThreshold
	{
		[Address(RVA = "0x300F240", Offset = "0x300E640", Length = "0x2A")]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000133")]
	public static int pixelLightCount
	{
		[Address(RVA = "0x2FFAEF0", Offset = "0x2FFA2F0", Length = "0x2A")]
		[Token(Token = "0x60006B1")]
		 get { } //Length: 42
		[Address(RVA = "0x2FFCD50", Offset = "0x2FFC150", Length = "0x31")]
		[Token(Token = "0x60006B2")]
		 set { } //Length: 49
	}

	[NativeProperty("ShadowmaskMode")]
	[Token(Token = "0x17000134")]
	public static ShadowmaskMode shadowmaskMode
	{
		[Address(RVA = "0x300F270", Offset = "0x300E670", Length = "0x2A")]
		[Token(Token = "0x60006B3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000139")]
	public static int vSyncCount
	{
		[Address(RVA = "0x300F360", Offset = "0x300E760", Length = "0x31")]
		[Token(Token = "0x60006BA")]
		 set { } //Length: 49
	}

	[Address(RVA = "0x300F120", Offset = "0x300E520", Length = "0x2A")]
	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x60006BF")]
	public static ColorSpace get_activeColorSpace() { }

	[Address(RVA = "0x300F150", Offset = "0x300E550", Length = "0x2A")]
	[Token(Token = "0x60006BB")]
	public static int get_antiAliasing() { }

	[Address(RVA = "0x300F180", Offset = "0x300E580", Length = "0x2A")]
	[Token(Token = "0x60006BD")]
	public static bool get_billboardsFaceCameraPosition() { }

	[Address(RVA = "0x300F1B0", Offset = "0x300E5B0", Length = "0x2A")]
	[Token(Token = "0x60006B8")]
	public static bool get_enableLODCrossFade() { }

	[Address(RVA = "0x300F1E0", Offset = "0x300E5E0", Length = "0x2A")]
	[Token(Token = "0x60006B4")]
	public static float get_lodBias() { }

	[Address(RVA = "0x300F210", Offset = "0x300E610", Length = "0x2A")]
	[Token(Token = "0x60006B7")]
	public static int get_maximumLODLevel() { }

	[Address(RVA = "0x300F240", Offset = "0x300E640", Length = "0x2A")]
	[Token(Token = "0x60006B6")]
	public static float get_meshLodThreshold() { }

	[Address(RVA = "0x2FFAEF0", Offset = "0x2FFA2F0", Length = "0x2A")]
	[Token(Token = "0x60006B1")]
	public static int get_pixelLightCount() { }

	[Address(RVA = "0x300F270", Offset = "0x300E670", Length = "0x2A")]
	[Token(Token = "0x60006B3")]
	public static ShadowmaskMode get_shadowmaskMode() { }

	[Address(RVA = "0x300F040", Offset = "0x300E440", Length = "0x5E")]
	[RequiredByNativeCode]
	[Token(Token = "0x60006AF")]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	[Address(RVA = "0x300F2A0", Offset = "0x300E6A0", Length = "0x31")]
	[Token(Token = "0x60006BC")]
	public static void set_antiAliasing(int value) { }

	[Address(RVA = "0x300F2E0", Offset = "0x300E6E0", Length = "0x33")]
	[Token(Token = "0x60006B9")]
	public static void set_enableLODCrossFade(bool value) { }

	[Address(RVA = "0x300F320", Offset = "0x300E720", Length = "0x3A")]
	[Token(Token = "0x60006B5")]
	public static void set_lodBias(float value) { }

	[Address(RVA = "0x2FFCD50", Offset = "0x2FFC150", Length = "0x31")]
	[Token(Token = "0x60006B2")]
	public static void set_pixelLightCount(int value) { }

	[Address(RVA = "0x300F360", Offset = "0x300E760", Length = "0x31")]
	[Token(Token = "0x60006BA")]
	public static void set_vSyncCount(int value) { }

	[Address(RVA = "0x300F0A0", Offset = "0x300E4A0", Length = "0x40")]
	[NativeName("SetCurrentIndex")]
	[Token(Token = "0x60006BE")]
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[Address(RVA = "0x300F0E0", Offset = "0x300E4E0", Length = "0x33")]
	[Token(Token = "0x60006B0")]
	public static void SetQualityLevel(int index) { }

}

