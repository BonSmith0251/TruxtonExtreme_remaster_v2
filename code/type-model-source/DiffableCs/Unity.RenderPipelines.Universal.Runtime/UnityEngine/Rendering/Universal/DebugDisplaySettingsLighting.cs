namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200002F")]
public class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Lighting", order = 3)]
	[Token(Token = "0x2000035")]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsLighting>
	{

		[Address(RVA = "0x2D5E2C0", Offset = "0x2D5D6C0", Length = "0x3B2")]
		[Token(Token = "0x600011C")]
		public SettingsPanel(DebugDisplaySettingsLighting data) { }

	}

	[Token(Token = "0x2000030")]
	public static class Strings
	{
		[Token(Token = "0x4000126")]
		public static readonly NameAndTooltip LightingDebugMode; //Field offset: 0x0
		[Token(Token = "0x4000127")]
		public static readonly NameAndTooltip LightingFeatures; //Field offset: 0x10
		[Token(Token = "0x4000128")]
		public static readonly NameAndTooltip HDRDebugMode; //Field offset: 0x20

		[Address(RVA = "0x2D61090", Offset = "0x2D60490", Length = "0x197")]
		[Token(Token = "0x600010B")]
		private static Strings() { }

	}

	[Token(Token = "0x2000031")]
	public static class WidgetFactory
	{
		[CompilerGenerated]
		[Token(Token = "0x2000032")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000129")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600010F")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2D61D40", Offset = "0x2D61140", Length = "0x45")]
			[Token(Token = "0x6000110")]
			internal int <CreateLightingDebugMode>b__0() { }

			[Address(RVA = "0x2D61D90", Offset = "0x2D61190", Length = "0x50")]
			[Token(Token = "0x6000111")]
			internal void <CreateLightingDebugMode>b__1(int value) { }

			[Address(RVA = "0x2D61DF0", Offset = "0x2D611F0", Length = "0x45")]
			[Token(Token = "0x6000112")]
			internal int <CreateLightingDebugMode>b__2() { }

			[Address(RVA = "0x2D61E40", Offset = "0x2D61240", Length = "0x50")]
			[Token(Token = "0x6000113")]
			internal void <CreateLightingDebugMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000033")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400012A")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000114")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x2D63050", Offset = "0x2D62450", Length = "0x66")]
			[Token(Token = "0x6000115")]
			internal Enum <CreateLightingFeatures>b__0() { }

			[Address(RVA = "0x2D630C0", Offset = "0x2D624C0", Length = "0x86")]
			[Token(Token = "0x6000116")]
			internal void <CreateLightingFeatures>b__1(Enum value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000034")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400012B")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000117")]
			public <>c__DisplayClass2_0() { }

			[Address(RVA = "0x2D63510", Offset = "0x2D62910", Length = "0x45")]
			[Token(Token = "0x6000118")]
			internal int <CreateHDRDebugMode>b__0() { }

			[Address(RVA = "0x2D63560", Offset = "0x2D62960", Length = "0x50")]
			[Token(Token = "0x6000119")]
			internal void <CreateHDRDebugMode>b__1(int value) { }

			[Address(RVA = "0x2D635C0", Offset = "0x2D629C0", Length = "0x45")]
			[Token(Token = "0x600011A")]
			internal int <CreateHDRDebugMode>b__2() { }

			[Address(RVA = "0x2D63610", Offset = "0x2D62A10", Length = "0x50")]
			[Token(Token = "0x600011B")]
			internal void <CreateHDRDebugMode>b__3(int value) { }

		}


		[Address(RVA = "0x2D69F30", Offset = "0x2D69330", Length = "0x26E")]
		[Token(Token = "0x600010E")]
		internal static Widget CreateHDRDebugMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6A350", Offset = "0x2D69750", Length = "0x26D")]
		[Token(Token = "0x600010C")]
		internal static Widget CreateLightingDebugMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6A5C0", Offset = "0x2D699C0", Length = "0x1E1")]
		[Token(Token = "0x600010D")]
		internal static Widget CreateLightingFeatures(SettingsPanel panel) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000123")]
	private DebugLightingMode <lightingDebugMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000124")]
	private DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000125")]
	private HDRDebugMode <hdrDebugMode>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000076")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2D57110", Offset = "0x2D56510", Length = "0x17")]
		[Token(Token = "0x6000106")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000075")]
	public HDRDebugMode hdrDebugMode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000104")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000105")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000078")]
	public override bool IsLightingActive
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000108")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000077")]
	public override bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x2D57130", Offset = "0x2D56530", Length = "0x11")]
		[Token(Token = "0x6000107")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000073")]
	public DebugLightingMode lightingDebugMode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000100")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000101")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000074")]
	public DebugLightingFeatureFlags lightingFeatureFlags
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000102")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000103")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600010A")]
	public DebugDisplaySettingsLighting() { }

	[Address(RVA = "0x2D57110", Offset = "0x2D56510", Length = "0x17")]
	[Token(Token = "0x6000106")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000104")]
	public HDRDebugMode get_hdrDebugMode() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000108")]
	public override bool get_IsLightingActive() { }

	[Address(RVA = "0x2D57130", Offset = "0x2D56530", Length = "0x11")]
	[Token(Token = "0x6000107")]
	public override bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000100")]
	public DebugLightingMode get_lightingDebugMode() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000102")]
	public DebugLightingFeatureFlags get_lightingFeatureFlags() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000105")]
	public void set_hdrDebugMode(HDRDebugMode value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000101")]
	public void set_lightingDebugMode(DebugLightingMode value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000103")]
	public void set_lightingFeatureFlags(DebugLightingFeatureFlags value) { }

	[Address(RVA = "0x2D570B0", Offset = "0x2D564B0", Length = "0x54")]
	[Token(Token = "0x6000109")]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

