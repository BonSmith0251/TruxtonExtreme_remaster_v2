namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
[Token(Token = "0x20000E3")]
[UsedByNativeCode]
public class HDROutputSettings
{
	[Token(Token = "0x400027D")]
	public static HDROutputSettings[] displays; //Field offset: 0x0
	[Token(Token = "0x400027E")]
	private static HDROutputSettings _mainDisplay; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027C")]
	private int m_DisplayIndex; //Field offset: 0x10

	[Token(Token = "0x17000126")]
	public bool active
	{
		[Address(RVA = "0x2FF81A0", Offset = "0x2FF75A0", Length = "0x66")]
		[Token(Token = "0x600068F")]
		 get { } //Length: 102
	}

	[Token(Token = "0x17000128")]
	public bool automaticHDRTonemapping
	{
		[Address(RVA = "0x2FF8210", Offset = "0x2FF7610", Length = "0x66")]
		[Token(Token = "0x6000691")]
		 get { } //Length: 102
		[Address(RVA = "0x2FF85E0", Offset = "0x2FF79E0", Length = "0x76")]
		[Token(Token = "0x6000692")]
		 set { } //Length: 118
	}

	[Token(Token = "0x17000127")]
	public bool available
	{
		[Address(RVA = "0x2FF8280", Offset = "0x2FF7680", Length = "0x66")]
		[Token(Token = "0x6000690")]
		 get { } //Length: 102
	}

	[Token(Token = "0x17000129")]
	public ColorGamut displayColorGamut
	{
		[Address(RVA = "0x2FF82F0", Offset = "0x2FF76F0", Length = "0x66")]
		[Token(Token = "0x6000693")]
		 get { } //Length: 102
	}

	[Token(Token = "0x1700012A")]
	public GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0x2FF8360", Offset = "0x2FF7760", Length = "0x66")]
		[Token(Token = "0x6000694")]
		 get { } //Length: 102
	}

	[Token(Token = "0x1700012F")]
	public bool HDRModeChangeRequested
	{
		[Address(RVA = "0x2FF8130", Offset = "0x2FF7530", Length = "0x66")]
		[Token(Token = "0x6000699")]
		 get { } //Length: 102
	}

	[Token(Token = "0x17000125")]
	public static HDROutputSettings main
	{
		[Address(RVA = "0x2FF83D0", Offset = "0x2FF77D0", Length = "0x4F")]
		[Token(Token = "0x600068E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700012C")]
	public int maxFullFrameToneMapLuminance
	{
		[Address(RVA = "0x2FF8420", Offset = "0x2FF7820", Length = "0x66")]
		[Token(Token = "0x6000696")]
		 get { } //Length: 102
	}

	[Token(Token = "0x1700012D")]
	public int maxToneMapLuminance
	{
		[Address(RVA = "0x2FF8490", Offset = "0x2FF7890", Length = "0x66")]
		[Token(Token = "0x6000697")]
		 get { } //Length: 102
	}

	[Token(Token = "0x1700012E")]
	public int minToneMapLuminance
	{
		[Address(RVA = "0x2FF8500", Offset = "0x2FF7900", Length = "0x66")]
		[Token(Token = "0x6000698")]
		 get { } //Length: 102
	}

	[Token(Token = "0x1700012B")]
	public float paperWhiteNits
	{
		[Address(RVA = "0x2FF8570", Offset = "0x2FF7970", Length = "0x66")]
		[Token(Token = "0x6000695")]
		 get { } //Length: 102
	}

	[Address(RVA = "0x2FF8000", Offset = "0x2FF7400", Length = "0x128")]
	[Token(Token = "0x60006A7")]
	private static HDROutputSettings() { }

	[Address(RVA = "0x25E1A20", Offset = "0x25E0E20", Length = "0x1D")]
	[Token(Token = "0x600068C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal HDROutputSettings() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x600068D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal HDROutputSettings(int displayIndex) { }

	[Address(RVA = "0x2FF81A0", Offset = "0x2FF75A0", Length = "0x66")]
	[Token(Token = "0x600068F")]
	public bool get_active() { }

	[Address(RVA = "0x2FF8210", Offset = "0x2FF7610", Length = "0x66")]
	[Token(Token = "0x6000691")]
	public bool get_automaticHDRTonemapping() { }

	[Address(RVA = "0x2FF8280", Offset = "0x2FF7680", Length = "0x66")]
	[Token(Token = "0x6000690")]
	public bool get_available() { }

	[Address(RVA = "0x2FF82F0", Offset = "0x2FF76F0", Length = "0x66")]
	[Token(Token = "0x6000693")]
	public ColorGamut get_displayColorGamut() { }

	[Address(RVA = "0x2FF8360", Offset = "0x2FF7760", Length = "0x66")]
	[Token(Token = "0x6000694")]
	public GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x2FF8130", Offset = "0x2FF7530", Length = "0x66")]
	[Token(Token = "0x6000699")]
	public bool get_HDRModeChangeRequested() { }

	[Address(RVA = "0x2FF83D0", Offset = "0x2FF77D0", Length = "0x4F")]
	[Token(Token = "0x600068E")]
	public static HDROutputSettings get_main() { }

	[Address(RVA = "0x2FF8420", Offset = "0x2FF7820", Length = "0x66")]
	[Token(Token = "0x6000696")]
	public int get_maxFullFrameToneMapLuminance() { }

	[Address(RVA = "0x2FF8490", Offset = "0x2FF7890", Length = "0x66")]
	[Token(Token = "0x6000697")]
	public int get_maxToneMapLuminance() { }

	[Address(RVA = "0x2FF8500", Offset = "0x2FF7900", Length = "0x66")]
	[Token(Token = "0x6000698")]
	public int get_minToneMapLuminance() { }

	[Address(RVA = "0x2FF8570", Offset = "0x2FF7970", Length = "0x66")]
	[Token(Token = "0x6000695")]
	public float get_paperWhiteNits() { }

	[Address(RVA = "0x2FF7C80", Offset = "0x2FF7080", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x600069B")]
	private static bool GetActive(int displayIndex) { }

	[Address(RVA = "0x2FF7CC0", Offset = "0x2FF70C0", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x600069D")]
	private static bool GetAutomaticHDRTonemapping(int displayIndex) { }

	[Address(RVA = "0x2FF7D00", Offset = "0x2FF7100", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x600069C")]
	private static bool GetAvailable(int displayIndex) { }

	[Address(RVA = "0x2FF7D40", Offset = "0x2FF7140", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x600069F")]
	private static ColorGamut GetDisplayColorGamut(int displayIndex) { }

	[Address(RVA = "0x2FF7D80", Offset = "0x2FF7180", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetGraphicsFormat", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A0")]
	private static GraphicsFormat GetGraphicsFormat(int displayIndex) { }

	[Address(RVA = "0x2FF7DC0", Offset = "0x2FF71C0", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetHDRModeChangeRequested", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A5")]
	private static bool GetHDRModeChangeRequested(int displayIndex) { }

	[Address(RVA = "0x2FF7E00", Offset = "0x2FF7200", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A2")]
	private static int GetMaxFullFrameToneMapLuminance(int displayIndex) { }

	[Address(RVA = "0x2FF7E40", Offset = "0x2FF7240", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A3")]
	private static int GetMaxToneMapLuminance(int displayIndex) { }

	[Address(RVA = "0x2FF7E80", Offset = "0x2FF7280", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A4")]
	private static int GetMinToneMapLuminance(int displayIndex) { }

	[Address(RVA = "0x2FF7EC0", Offset = "0x2FF72C0", Length = "0x31")]
	[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A1")]
	private static float GetPaperWhiteNits(int displayIndex) { }

	[Address(RVA = "0x2FF7F40", Offset = "0x2FF7340", Length = "0x76")]
	[Token(Token = "0x600069A")]
	public void RequestHDRModeChange(bool enabled) { }

	[Address(RVA = "0x2FF7F00", Offset = "0x2FF7300", Length = "0x40")]
	[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x60006A6")]
	private static void RequestHDRModeChangeInternal(int displayIndex, bool enabled) { }

	[Address(RVA = "0x2FF85E0", Offset = "0x2FF79E0", Length = "0x76")]
	[Token(Token = "0x6000692")]
	public void set_automaticHDRTonemapping(bool value) { }

	[Address(RVA = "0x2FF7FC0", Offset = "0x2FF73C0", Length = "0x40")]
	[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	[Token(Token = "0x600069E")]
	private static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted) { }

}

