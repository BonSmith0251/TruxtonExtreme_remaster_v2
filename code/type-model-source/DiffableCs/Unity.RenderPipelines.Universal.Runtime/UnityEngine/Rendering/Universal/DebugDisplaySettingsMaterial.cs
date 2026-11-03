namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000036")]
public class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[Token(Token = "0x2000037")]
	internal enum AlbedoDebugValidationPreset : int
	{
		DefaultLuminance = 0,
		BlackAcrylicPaint = 1,
		DarkSoil = 2,
		WornAsphalt = 3,
		DryClaySoil = 4,
		GreenGrass = 5,
		OldConcrete = 6,
		RedClayTile = 7,
		DrySand = 8,
		NewConcrete = 9,
		WhiteAcrylicPaint = 10,
		FreshSnow = 11,
		BlueSky = 12,
		Foliage = 13,
		Custom = 14,
	}

	[Token(Token = "0x2000038")]
	private struct AlbedoDebugValidationPresetData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400014D")]
		public Color color; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014E")]
		public float minLuminance; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400014F")]
		public float maxLuminance; //Field offset: 0x1C

	}

	[DisplayInfo(name = "Material", order = 2)]
	[Token(Token = "0x200004A")]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsMaterial>
	{
		[CompilerGenerated]
		[Token(Token = "0x200004B")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000172")]
			public DebugDisplaySettingsMaterial data; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600018C")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2D62180", Offset = "0x2D61580", Length = "0x1E")]
			[Token(Token = "0x600018D")]
			internal bool <.ctor>b__0() { }

			[Address(RVA = "0x2D621A0", Offset = "0x2D615A0", Length = "0x1E")]
			[Token(Token = "0x600018E")]
			internal bool <.ctor>b__1() { }

			[Address(RVA = "0x2D621C0", Offset = "0x2D615C0", Length = "0x1E")]
			[Token(Token = "0x600018F")]
			internal bool <.ctor>b__2() { }

		}


		[Address(RVA = "0x2D5E680", Offset = "0x2D5DA80", Length = "0x10D3")]
		[Token(Token = "0x600018B")]
		public SettingsPanel(DebugDisplaySettingsMaterial data) { }

	}

	[Token(Token = "0x2000039")]
	private static class Strings
	{
		[Token(Token = "0x4000150")]
		public const string AlbedoSettingsContainerName = "Albedo Settings"; //Field offset: 0x0
		[Token(Token = "0x4000151")]
		public const string MetallicSettingsContainerName = "Metallic Settings"; //Field offset: 0x0
		[Token(Token = "0x4000152")]
		public const string RenderingLayerMasksSettingsContainerName = "Rendering Layer Masks Settings"; //Field offset: 0x0
		[Token(Token = "0x4000153")]
		public static readonly NameAndTooltip MaterialOverride; //Field offset: 0x0
		[Token(Token = "0x4000154")]
		public static readonly NameAndTooltip VertexAttribute; //Field offset: 0x10
		[Token(Token = "0x4000155")]
		public static readonly NameAndTooltip MaterialValidationMode; //Field offset: 0x20
		[Token(Token = "0x4000156")]
		public static readonly NameAndTooltip RenderingLayersSelectedLight; //Field offset: 0x30
		[Token(Token = "0x4000157")]
		public static readonly NameAndTooltip SelectedLightShadowLayerMask; //Field offset: 0x40
		[Token(Token = "0x4000158")]
		public static readonly NameAndTooltip FilterRenderingLayerMask; //Field offset: 0x50
		[Token(Token = "0x4000159")]
		public static readonly NameAndTooltip ValidationPreset; //Field offset: 0x60
		[Token(Token = "0x400015A")]
		public static readonly NameAndTooltip AlbedoCustomColor; //Field offset: 0x70
		[Token(Token = "0x400015B")]
		public static readonly NameAndTooltip AlbedoMinLuminance; //Field offset: 0x80
		[Token(Token = "0x400015C")]
		public static readonly NameAndTooltip AlbedoMaxLuminance; //Field offset: 0x90
		[Token(Token = "0x400015D")]
		public static readonly NameAndTooltip AlbedoHueTolerance; //Field offset: 0xA0
		[Token(Token = "0x400015E")]
		public static readonly NameAndTooltip AlbedoSaturationTolerance; //Field offset: 0xB0
		[Token(Token = "0x400015F")]
		public static readonly NameAndTooltip MetallicMinValue; //Field offset: 0xC0
		[Token(Token = "0x4000160")]
		public static readonly NameAndTooltip MetallicMaxValue; //Field offset: 0xD0

		[Address(RVA = "0x2D612E0", Offset = "0x2D606E0", Length = "0x688")]
		[Token(Token = "0x600013F")]
		private static Strings() { }

	}

	[Token(Token = "0x200003A")]
	public static class WidgetFactory
	{
		[CompilerGenerated]
		[Token(Token = "0x200003B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000161")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000162")]
			public static Action<Field`1<Int32>, Int32> <>9__2_4; //Field offset: 0x8
			[Token(Token = "0x4000163")]
			public static Action<Field`1<Int32>, Int32> <>9__6_4; //Field offset: 0x10

			[Address(RVA = "0x2D64DA0", Offset = "0x2D641A0", Length = "0x67")]
			[Token(Token = "0x600014E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600014F")]
			public <>c() { }

			[Address(RVA = "0x2D61A60", Offset = "0x2D60E60", Length = "0x54")]
			[Token(Token = "0x6000151")]
			internal void <CreateAlbedoPreset>b__6_4(Field<Int32> _, int _) { }

			[Address(RVA = "0x2D61AC0", Offset = "0x2D60EC0", Length = "0x54")]
			[Token(Token = "0x6000150")]
			internal void <CreateMaterialValidationMode>b__2_4(Field<Int32> _, int _) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003C")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000164")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000152")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2D62000", Offset = "0x2D61400", Length = "0x45")]
			[Token(Token = "0x6000153")]
			internal int <CreateMaterialOverride>b__0() { }

			[Address(RVA = "0x2D62050", Offset = "0x2D61450", Length = "0x50")]
			[Token(Token = "0x6000154")]
			internal void <CreateMaterialOverride>b__1(int value) { }

			[Address(RVA = "0x2D620B0", Offset = "0x2D614B0", Length = "0x45")]
			[Token(Token = "0x6000155")]
			internal int <CreateMaterialOverride>b__2() { }

			[Address(RVA = "0x2D62100", Offset = "0x2D61500", Length = "0x50")]
			[Token(Token = "0x6000156")]
			internal void <CreateMaterialOverride>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000041")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000169")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000165")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x2D63300", Offset = "0x2D62700", Length = "0x45")]
			[Token(Token = "0x6000166")]
			internal int <CreateVertexAttribute>b__0() { }

			[Address(RVA = "0x2D63350", Offset = "0x2D62750", Length = "0x50")]
			[Token(Token = "0x6000167")]
			internal void <CreateVertexAttribute>b__1(int value) { }

			[Address(RVA = "0x2D633B0", Offset = "0x2D627B0", Length = "0x45")]
			[Token(Token = "0x6000168")]
			internal int <CreateVertexAttribute>b__2() { }

			[Address(RVA = "0x2D63400", Offset = "0x2D62800", Length = "0x50")]
			[Token(Token = "0x6000169")]
			internal void <CreateVertexAttribute>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003D")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000165")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000157")]
			public <>c__DisplayClass10_0() { }

			[Address(RVA = "0x2D621E0", Offset = "0x2D615E0", Length = "0x5B")]
			[Token(Token = "0x6000158")]
			internal float <CreateAlbedoHueTolerance>b__0() { }

			[Address(RVA = "0x2D62240", Offset = "0x2D61640", Length = "0x54")]
			[Token(Token = "0x6000159")]
			internal void <CreateAlbedoHueTolerance>b__1(float value) { }

			[Address(RVA = "0x2D622A0", Offset = "0x2D616A0", Length = "0x49")]
			[Token(Token = "0x600015A")]
			internal bool <CreateAlbedoHueTolerance>b__2() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003E")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000166")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600015B")]
			public <>c__DisplayClass11_0() { }

			[Address(RVA = "0x2D62450", Offset = "0x2D61850", Length = "0x5B")]
			[Token(Token = "0x600015C")]
			internal float <CreateAlbedoSaturationTolerance>b__0() { }

			[Address(RVA = "0x2D624B0", Offset = "0x2D618B0", Length = "0x54")]
			[Token(Token = "0x600015D")]
			internal void <CreateAlbedoSaturationTolerance>b__1(float value) { }

			[Address(RVA = "0x2D62510", Offset = "0x2D61910", Length = "0x49")]
			[Token(Token = "0x600015E")]
			internal bool <CreateAlbedoSaturationTolerance>b__2() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200003F")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000167")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600015F")]
			public <>c__DisplayClass12_0() { }

			[Address(RVA = "0x2D62660", Offset = "0x2D61A60", Length = "0x47")]
			[Token(Token = "0x6000160")]
			internal float <CreateMetallicMinValue>b__0() { }

			[Address(RVA = "0x2D626B0", Offset = "0x2D61AB0", Length = "0x54")]
			[Token(Token = "0x6000161")]
			internal void <CreateMetallicMinValue>b__1(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000040")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000168")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000162")]
			public <>c__DisplayClass13_0() { }

			[Address(RVA = "0x2D62810", Offset = "0x2D61C10", Length = "0x47")]
			[Token(Token = "0x6000163")]
			internal float <CreateMetallicMaxValue>b__0() { }

			[Address(RVA = "0x2D62860", Offset = "0x2D61C60", Length = "0x54")]
			[Token(Token = "0x6000164")]
			internal void <CreateMetallicMaxValue>b__1(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000042")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016A")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600016A")]
			public <>c__DisplayClass2_0() { }

			[Address(RVA = "0x2D63720", Offset = "0x2D62B20", Length = "0x45")]
			[Token(Token = "0x600016B")]
			internal int <CreateMaterialValidationMode>b__0() { }

			[Address(RVA = "0x2D63770", Offset = "0x2D62B70", Length = "0x50")]
			[Token(Token = "0x600016C")]
			internal void <CreateMaterialValidationMode>b__1(int value) { }

			[Address(RVA = "0x2D637D0", Offset = "0x2D62BD0", Length = "0x45")]
			[Token(Token = "0x600016D")]
			internal int <CreateMaterialValidationMode>b__2() { }

			[Address(RVA = "0x2D63820", Offset = "0x2D62C20", Length = "0x50")]
			[Token(Token = "0x600016E")]
			internal void <CreateMaterialValidationMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000043")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016B")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600016F")]
			public <>c__DisplayClass3_0() { }

			[Address(RVA = "0x2D63A80", Offset = "0x2D62E80", Length = "0x46")]
			[Token(Token = "0x6000170")]
			internal bool <CreateRenderingLayersSelectedLight>b__0() { }

			[Address(RVA = "0x2D63AD0", Offset = "0x2D62ED0", Length = "0x51")]
			[Token(Token = "0x6000171")]
			internal void <CreateRenderingLayersSelectedLight>b__1(bool value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000044")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016C")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000172")]
			public <>c__DisplayClass4_0() { }

			[Address(RVA = "0x2D63C00", Offset = "0x2D63000", Length = "0x46")]
			[Token(Token = "0x6000173")]
			internal bool <CreateSelectedLightShadowLayerMask>b__0() { }

			[Address(RVA = "0x2D63C50", Offset = "0x2D63050", Length = "0x51")]
			[Token(Token = "0x6000174")]
			internal void <CreateSelectedLightShadowLayerMask>b__1(bool value) { }

			[Address(RVA = "0x2D63CB0", Offset = "0x2D630B0", Length = "0x49")]
			[Token(Token = "0x6000175")]
			internal bool <CreateSelectedLightShadowLayerMask>b__2() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000045")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016D")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000176")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x2D63D70", Offset = "0x2D63170", Length = "0x6E")]
			[Token(Token = "0x6000177")]
			internal RenderingLayerMask <CreateFilterRenderingLayerMasks>b__0() { }

			[Address(RVA = "0x2D63DE0", Offset = "0x2D631E0", Length = "0x7A")]
			[Token(Token = "0x6000178")]
			internal void <CreateFilterRenderingLayerMasks>b__1(RenderingLayerMask value) { }

			[Address(RVA = "0x2D63E60", Offset = "0x2D63260", Length = "0x80")]
			[Token(Token = "0x6000179")]
			internal Vector4 <CreateFilterRenderingLayerMasks>b__2(int index) { }

			[Address(RVA = "0x2D63EF0", Offset = "0x2D632F0", Length = "0x7D")]
			[Token(Token = "0x600017A")]
			internal void <CreateFilterRenderingLayerMasks>b__3(Vector4 value, int index) { }

			[Address(RVA = "0x2D63F70", Offset = "0x2D63370", Length = "0x46")]
			[Token(Token = "0x600017B")]
			internal bool <CreateFilterRenderingLayerMasks>b__4() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000046")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016E")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600017C")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0x2D641C0", Offset = "0x2D635C0", Length = "0x45")]
			[Token(Token = "0x600017D")]
			internal int <CreateAlbedoPreset>b__0() { }

			[Address(RVA = "0x2D64210", Offset = "0x2D63610", Length = "0x9D")]
			[Token(Token = "0x600017E")]
			internal void <CreateAlbedoPreset>b__1(int value) { }

			[Address(RVA = "0x2D642B0", Offset = "0x2D636B0", Length = "0x45")]
			[Token(Token = "0x600017F")]
			internal int <CreateAlbedoPreset>b__2() { }

			[Address(RVA = "0x2D64300", Offset = "0x2D63700", Length = "0x9D")]
			[Token(Token = "0x6000180")]
			internal void <CreateAlbedoPreset>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000047")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016F")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000181")]
			public <>c__DisplayClass7_0() { }

			[Address(RVA = "0x2D644A0", Offset = "0x2D638A0", Length = "0x58")]
			[Token(Token = "0x6000182")]
			internal Color <CreateAlbedoCustomColor>b__0() { }

			[Address(RVA = "0x2D64500", Offset = "0x2D63900", Length = "0x55")]
			[Token(Token = "0x6000183")]
			internal void <CreateAlbedoCustomColor>b__1(Color value) { }

			[Address(RVA = "0x2D64560", Offset = "0x2D63960", Length = "0x49")]
			[Token(Token = "0x6000184")]
			internal bool <CreateAlbedoCustomColor>b__2() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000048")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000170")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000185")]
			public <>c__DisplayClass8_0() { }

			[Address(RVA = "0x2D645B0", Offset = "0x2D639B0", Length = "0x47")]
			[Token(Token = "0x6000186")]
			internal float <CreateAlbedoMinLuminance>b__0() { }

			[Address(RVA = "0x2D64600", Offset = "0x2D63A00", Length = "0x54")]
			[Token(Token = "0x6000187")]
			internal void <CreateAlbedoMinLuminance>b__1(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000049")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000171")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000188")]
			public <>c__DisplayClass9_0() { }

			[Address(RVA = "0x2D647C0", Offset = "0x2D63BC0", Length = "0x47")]
			[Token(Token = "0x6000189")]
			internal float <CreateAlbedoMaxLuminance>b__0() { }

			[Address(RVA = "0x2D64810", Offset = "0x2D63C10", Length = "0x54")]
			[Token(Token = "0x600018A")]
			internal void <CreateAlbedoMaxLuminance>b__1(float value) { }

		}


		[Address(RVA = "0x2D69000", Offset = "0x2D68400", Length = "0x1EE")]
		[Token(Token = "0x6000147")]
		internal static Widget CreateAlbedoCustomColor(SettingsPanel panel) { }

		[Address(RVA = "0x2D691F0", Offset = "0x2D685F0", Length = "0x1F8")]
		[Token(Token = "0x600014A")]
		internal static Widget CreateAlbedoHueTolerance(SettingsPanel panel) { }

		[Address(RVA = "0x2D693F0", Offset = "0x2D687F0", Length = "0x1A8")]
		[Token(Token = "0x6000149")]
		internal static Widget CreateAlbedoMaxLuminance(SettingsPanel panel) { }

		[Address(RVA = "0x2D695A0", Offset = "0x2D689A0", Length = "0x1A8")]
		[Token(Token = "0x6000148")]
		internal static Widget CreateAlbedoMinLuminance(SettingsPanel panel) { }

		[Address(RVA = "0x2D69750", Offset = "0x2D68B50", Length = "0x33F")]
		[Token(Token = "0x6000146")]
		internal static Widget CreateAlbedoPreset(SettingsPanel panel) { }

		[Address(RVA = "0x2D69A90", Offset = "0x2D68E90", Length = "0x1F8")]
		[Token(Token = "0x600014B")]
		internal static Widget CreateAlbedoSaturationTolerance(SettingsPanel panel) { }

		[Address(RVA = "0x2D69C90", Offset = "0x2D69090", Length = "0x292")]
		[Token(Token = "0x6000145")]
		internal static RenderingLayerField CreateFilterRenderingLayerMasks(SettingsPanel panel) { }

		[Address(RVA = "0x2D6AF60", Offset = "0x2D6A360", Length = "0x26D")]
		[Token(Token = "0x6000140")]
		internal static Widget CreateMaterialOverride(SettingsPanel panel) { }

		[Address(RVA = "0x2D6B1D0", Offset = "0x2D6A5D0", Length = "0x33F")]
		[Token(Token = "0x6000142")]
		internal static Widget CreateMaterialValidationMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6B8F0", Offset = "0x2D6ACF0", Length = "0x1A8")]
		[Token(Token = "0x600014D")]
		internal static Widget CreateMetallicMaxValue(SettingsPanel panel) { }

		[Address(RVA = "0x2D6BAA0", Offset = "0x2D6AEA0", Length = "0x1A8")]
		[Token(Token = "0x600014C")]
		internal static Widget CreateMetallicMinValue(SettingsPanel panel) { }

		[Address(RVA = "0x2D6E4E0", Offset = "0x2D6D8E0", Length = "0x1A5")]
		[Token(Token = "0x6000143")]
		internal static Widget CreateRenderingLayersSelectedLight(SettingsPanel panel) { }

		[Address(RVA = "0x2D6E690", Offset = "0x2D6DA90", Length = "0x1E5")]
		[Token(Token = "0x6000144")]
		internal static Widget CreateSelectedLightShadowLayerMask(SettingsPanel panel) { }

		[Address(RVA = "0x2D6EF20", Offset = "0x2D6E320", Length = "0x26E")]
		[Token(Token = "0x6000141")]
		internal static Widget CreateVertexAttribute(SettingsPanel panel) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012C")]
	private AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400012D")]
	private AlbedoDebugValidationPreset m_AlbedoValidationPreset; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400012E")]
	private float <albedoMinLuminance>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400012F")]
	private float <albedoMaxLuminance>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000130")]
	private float m_AlbedoHueTolerance; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000131")]
	private float m_AlbedoSaturationTolerance; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000132")]
	private Color <albedoCompareColor>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000133")]
	private float <metallicMinValue>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000134")]
	private float <metallicMaxValue>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000135")]
	private bool <renderingLayersSelectedLight>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x4000136")]
	private bool <selectedLightShadowLayerMask>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000137")]
	private uint <renderingLayerMask>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000138")]
	public Vector4[] debugRenderingLayersColors; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000139")]
	private DebugMaterialValidationMode <materialValidationMode>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400013A")]
	private DebugMaterialMode <materialDebugMode>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400013B")]
	private DebugVertexAttributeMode <vertexAttributeDebugMode>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x1700007E")]
	public Color albedoCompareColor
	{
		[Address(RVA = "0x2D57D50", Offset = "0x2D57150", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000127")]
		 get { } //Length: 11
		[Address(RVA = "0x2D57DA0", Offset = "0x2D571A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000128")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700007C")]
	public float albedoHueTolerance
	{
		[Address(RVA = "0x2D57D60", Offset = "0x2D57160", Length = "0x15")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 21
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x6000124")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700007B")]
	public float albedoMaxLuminance
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000121")]
		 get { } //Length: 6
		[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000122")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700007A")]
	public float albedoMinLuminance
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		 get { } //Length: 6
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000120")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700007D")]
	public float albedoSaturationTolerance
	{
		[Address(RVA = "0x2D57D80", Offset = "0x2D57180", Length = "0x15")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 21
		[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000079")]
	public AlbedoDebugValidationPreset albedoValidationPreset
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600011D")]
		 get { } //Length: 4
		[Address(RVA = "0x2D57DB0", Offset = "0x2D571B0", Length = "0x63")]
		[Token(Token = "0x600011E")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000087")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2D57D10", Offset = "0x2D57110", Length = "0x17")]
		[Token(Token = "0x600013A")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000089")]
	public override bool IsLightingActive
	{
		[Address(RVA = "0x2D57D30", Offset = "0x2D57130", Length = "0x18")]
		[Token(Token = "0x600013C")]
		 get { } //Length: 24
	}

	[Token(Token = "0x17000088")]
	public override bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x2D57D30", Offset = "0x2D57130", Length = "0x18")]
		[Token(Token = "0x600013B")]
		 get { } //Length: 24
	}

	[Token(Token = "0x17000085")]
	public DebugMaterialMode materialDebugMode
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000136")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000137")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000084")]
	public DebugMaterialValidationMode materialValidationMode
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000134")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000135")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000080")]
	public float metallicMaxValue
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600012B")]
		 get { } //Length: 6
		[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600012C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700007F")]
	public float metallicMinValue
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000129")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600012A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000083")]
	public uint renderingLayerMask
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000131")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000132")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000081")]
	public bool renderingLayersSelectedLight
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600012D")]
		 get { } //Length: 5
		[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600012E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000082")]
	public bool selectedLightShadowLayerMask
	{
		[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600012F")]
		 get { } //Length: 5
		[Address(RVA = "0x2D57E20", Offset = "0x2D57220", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000130")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000086")]
	public DebugVertexAttributeMode vertexAttributeDebugMode
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000138")]
		 get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000139")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2D571B0", Offset = "0x2D565B0", Length = "0xB58")]
	[Token(Token = "0x600013E")]
	public DebugDisplaySettingsMaterial() { }

	[Address(RVA = "0x2D57D50", Offset = "0x2D57150", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000127")]
	public Color get_albedoCompareColor() { }

	[Address(RVA = "0x2D57D60", Offset = "0x2D57160", Length = "0x15")]
	[Token(Token = "0x6000123")]
	public float get_albedoHueTolerance() { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000121")]
	public float get_albedoMaxLuminance() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600011F")]
	public float get_albedoMinLuminance() { }

	[Address(RVA = "0x2D57D80", Offset = "0x2D57180", Length = "0x15")]
	[Token(Token = "0x6000125")]
	public float get_albedoSaturationTolerance() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600011D")]
	public AlbedoDebugValidationPreset get_albedoValidationPreset() { }

	[Address(RVA = "0x2D57D10", Offset = "0x2D57110", Length = "0x17")]
	[Token(Token = "0x600013A")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x2D57D30", Offset = "0x2D57130", Length = "0x18")]
	[Token(Token = "0x600013C")]
	public override bool get_IsLightingActive() { }

	[Address(RVA = "0x2D57D30", Offset = "0x2D57130", Length = "0x18")]
	[Token(Token = "0x600013B")]
	public override bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000136")]
	public DebugMaterialMode get_materialDebugMode() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000134")]
	public DebugMaterialValidationMode get_materialValidationMode() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600012B")]
	public float get_metallicMaxValue() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000129")]
	public float get_metallicMinValue() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000131")]
	public uint get_renderingLayerMask() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600012D")]
	public bool get_renderingLayersSelectedLight() { }

	[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600012F")]
	public bool get_selectedLightShadowLayerMask() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000138")]
	public DebugVertexAttributeMode get_vertexAttributeDebugMode() { }

	[Address(RVA = "0x1F52210", Offset = "0x1F51610", Length = "0x6")]
	[Token(Token = "0x6000133")]
	public uint GetDebugLightLayersMask() { }

	[Address(RVA = "0x2D57DA0", Offset = "0x2D571A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000128")]
	public void set_albedoCompareColor(Color value) { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[Token(Token = "0x6000124")]
	public void set_albedoHueTolerance(float value) { }

	[Address(RVA = "0x1D719C0", Offset = "0x1D70DC0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000122")]
	public void set_albedoMaxLuminance(float value) { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000120")]
	public void set_albedoMinLuminance(float value) { }

	[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
	[Token(Token = "0x6000126")]
	public void set_albedoSaturationTolerance(float value) { }

	[Address(RVA = "0x2D57DB0", Offset = "0x2D571B0", Length = "0x63")]
	[Token(Token = "0x600011E")]
	public void set_albedoValidationPreset(AlbedoDebugValidationPreset value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000137")]
	public void set_materialDebugMode(DebugMaterialMode value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000135")]
	public void set_materialValidationMode(DebugMaterialValidationMode value) { }

	[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600012C")]
	public void set_metallicMaxValue(float value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600012A")]
	public void set_metallicMinValue(float value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000132")]
	public void set_renderingLayerMask(uint value) { }

	[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600012E")]
	public void set_renderingLayersSelectedLight(bool value) { }

	[Address(RVA = "0x2D57E20", Offset = "0x2D57220", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000130")]
	public void set_selectedLightShadowLayerMask(bool value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000139")]
	public void set_vertexAttributeDebugMode(DebugVertexAttributeMode value) { }

	[Address(RVA = "0x2D57150", Offset = "0x2D56550", Length = "0x54")]
	[Token(Token = "0x600013D")]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

