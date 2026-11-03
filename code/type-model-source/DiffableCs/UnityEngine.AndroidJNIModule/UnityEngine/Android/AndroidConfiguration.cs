namespace UnityEngine.Android;

[NativeAsStruct]
[NativeType(Header = "Modules/AndroidJNI/Public/AndroidConfiguration.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000015")]
public sealed class AndroidConfiguration
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000032")]
	private int <colorMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000033")]
	private int <densityDpi>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000034")]
	private float <fontScale>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000035")]
	private int <fontWeightAdjustment>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000036")]
	private AndroidKeyboard <keyboard>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000037")]
	private AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000038")]
	private AndroidKeyboardHidden <keyboardHidden>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000039")]
	private int <mobileCountryCode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private int <mobileNetworkCode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400003B")]
	private AndroidNavigation <navigation>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003C")]
	private AndroidNavigationHidden <navigationHidden>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400003D")]
	private AndroidOrientation <orientation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003E")]
	private int <screenHeightDp>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400003F")]
	private int <screenWidthDp>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000040")]
	private int <smallestScreenWidthDp>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000041")]
	private int <screenLayout>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000042")]
	private AndroidTouchScreen <touchScreen>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000043")]
	private int <uiMode>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000044")]
	private string <primaryLocaleCountry>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000045")]
	private string <primaryLocaleLanguage>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x17000005")]
	private int colorMode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600010D")]
		private get { } //Length: 85
	}

	[Token(Token = "0x1700001A")]
	public AndroidColorModeHdr colorModeHdr
	{
		[Address(RVA = "0x2F9CE50", Offset = "0x2F9C250", Length = "0x7")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700001B")]
	public AndroidColorModeWideColorGamut colorModeWideColorGamut
	{
		[Address(RVA = "0x2F9CE60", Offset = "0x2F9C260", Length = "0x7")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000006")]
	public int densityDpi
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600010E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public float fontScale
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600010F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	public int fontWeightAdjustment
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000110")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public AndroidHardwareKeyboardHidden hardKeyboardHidden
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000112")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public AndroidKeyboard keyboard
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000111")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public AndroidKeyboardHidden keyboardHidden
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000113")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000019")]
	public AndroidLocale[] locales
	{
		[Address(RVA = "0x2F9CE70", Offset = "0x2F9C270", Length = "0x122")]
		[Token(Token = "0x6000121")]
		 get { } //Length: 290
	}

	[Token(Token = "0x1700000C")]
	public int mobileCountryCode
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000114")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public int mobileNetworkCode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000115")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public AndroidNavigation navigation
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000116")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public AndroidNavigationHidden navigationHidden
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000117")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public AndroidOrientation orientation
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000118")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	private string primaryLocaleCountry
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000018")]
	private string primaryLocaleLanguage
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000120")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000011")]
	public int screenHeightDp
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000119")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	private int screenLayout
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011C")]
		private get { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public AndroidScreenLayoutDirection screenLayoutDirection
	{
		[Address(RVA = "0x2F9CFA0", Offset = "0x2F9C3A0", Length = "0x9")]
		[Token(Token = "0x6000124")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700001D")]
	public AndroidScreenLayoutLong screenLayoutLong
	{
		[Address(RVA = "0x2F9CFB0", Offset = "0x2F9C3B0", Length = "0x7")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700001E")]
	public AndroidScreenLayoutRound screenLayoutRound
	{
		[Address(RVA = "0x2F9CFC0", Offset = "0x2F9C3C0", Length = "0x9")]
		[Token(Token = "0x6000126")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700001F")]
	public AndroidScreenLayoutSize screenLayoutSize
	{
		[Address(RVA = "0x2F9CFD0", Offset = "0x2F9C3D0", Length = "0x7")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000012")]
	public int screenWidthDp
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public int smallestScreenWidthDp
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public AndroidTouchScreen touchScreen
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	private int uiMode
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011E")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public AndroidUIModeNight uiModeNight
	{
		[Address(RVA = "0x2F9CFE0", Offset = "0x2F9C3E0", Length = "0x7")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000021")]
	public AndroidUIModeType uiModeType
	{
		[Address(RVA = "0x2F9CFF0", Offset = "0x2F9C3F0", Length = "0x7")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600010D")]
	private int get_colorMode() { }

	[Address(RVA = "0x2F9CE50", Offset = "0x2F9C250", Length = "0x7")]
	[Token(Token = "0x6000122")]
	public AndroidColorModeHdr get_colorModeHdr() { }

	[Address(RVA = "0x2F9CE60", Offset = "0x2F9C260", Length = "0x7")]
	[Token(Token = "0x6000123")]
	public AndroidColorModeWideColorGamut get_colorModeWideColorGamut() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600010E")]
	public int get_densityDpi() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600010F")]
	public float get_fontScale() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000110")]
	public int get_fontWeightAdjustment() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000112")]
	public AndroidHardwareKeyboardHidden get_hardKeyboardHidden() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000111")]
	public AndroidKeyboard get_keyboard() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000113")]
	public AndroidKeyboardHidden get_keyboardHidden() { }

	[Address(RVA = "0x2F9CE70", Offset = "0x2F9C270", Length = "0x122")]
	[Token(Token = "0x6000121")]
	public AndroidLocale[] get_locales() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000114")]
	public int get_mobileCountryCode() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000115")]
	public int get_mobileNetworkCode() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000116")]
	public AndroidNavigation get_navigation() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000117")]
	public AndroidNavigationHidden get_navigationHidden() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000118")]
	public AndroidOrientation get_orientation() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600011F")]
	private string get_primaryLocaleCountry() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000120")]
	private string get_primaryLocaleLanguage() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000119")]
	public int get_screenHeightDp() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011C")]
	private int get_screenLayout() { }

	[Address(RVA = "0x2F9CFA0", Offset = "0x2F9C3A0", Length = "0x9")]
	[Token(Token = "0x6000124")]
	public AndroidScreenLayoutDirection get_screenLayoutDirection() { }

	[Address(RVA = "0x2F9CFB0", Offset = "0x2F9C3B0", Length = "0x7")]
	[Token(Token = "0x6000125")]
	public AndroidScreenLayoutLong get_screenLayoutLong() { }

	[Address(RVA = "0x2F9CFC0", Offset = "0x2F9C3C0", Length = "0x9")]
	[Token(Token = "0x6000126")]
	public AndroidScreenLayoutRound get_screenLayoutRound() { }

	[Address(RVA = "0x2F9CFD0", Offset = "0x2F9C3D0", Length = "0x7")]
	[Token(Token = "0x6000127")]
	public AndroidScreenLayoutSize get_screenLayoutSize() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011A")]
	public int get_screenWidthDp() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011B")]
	public int get_smallestScreenWidthDp() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011D")]
	public AndroidTouchScreen get_touchScreen() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600011E")]
	private int get_uiMode() { }

	[Address(RVA = "0x2F9CFE0", Offset = "0x2F9C3E0", Length = "0x7")]
	[Token(Token = "0x6000128")]
	public AndroidUIModeNight get_uiModeNight() { }

	[Address(RVA = "0x2F9CFF0", Offset = "0x2F9C3F0", Length = "0x7")]
	[Token(Token = "0x6000129")]
	public AndroidUIModeType get_uiModeType() { }

	[Address(RVA = "0x2F9C590", Offset = "0x2F9B990", Length = "0x8B7")]
	[Preserve]
	[Token(Token = "0x600012A")]
	public virtual string ToString() { }

}

