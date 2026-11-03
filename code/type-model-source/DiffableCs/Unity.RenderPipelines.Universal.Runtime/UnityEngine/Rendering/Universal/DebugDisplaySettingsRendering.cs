namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200004D")]
public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Rendering", order = 1)]
	[Token(Token = "0x2000066")]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000067")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001D0")]
			public DebugDisplaySettingsRendering data; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600024C")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2D62160", Offset = "0x2D61560", Length = "0x1E")]
			[Token(Token = "0x600024D")]
			internal bool <.ctor>b__0() { }

		}


		[Address(RVA = "0x2D5F760", Offset = "0x2D5EB60", Length = "0xCC5")]
		[Token(Token = "0x600024B")]
		public SettingsPanel(DebugDisplaySettingsRendering data) { }

	}

	[Token(Token = "0x200004F")]
	private static class Strings
	{
		[Token(Token = "0x4000195")]
		public const string RangeValidationSettingsContainerName = "Pixel Range Settings"; //Field offset: 0x0
		[Token(Token = "0x4000196")]
		public static readonly NameAndTooltip MapOverlays; //Field offset: 0x0
		[Token(Token = "0x4000197")]
		public static readonly NameAndTooltip StpDebugViews; //Field offset: 0x10
		[Token(Token = "0x4000198")]
		public static readonly NameAndTooltip MapSize; //Field offset: 0x20
		[Token(Token = "0x4000199")]
		public static readonly NameAndTooltip AdditionalWireframeModes; //Field offset: 0x30
		[Token(Token = "0x400019A")]
		public static readonly NameAndTooltip WireframeNotSupportedWarning; //Field offset: 0x40
		[Token(Token = "0x400019B")]
		public static readonly NameAndTooltip OverdrawMode; //Field offset: 0x50
		[Token(Token = "0x400019C")]
		public static readonly NameAndTooltip MaxOverdrawCount; //Field offset: 0x60
		[Token(Token = "0x400019D")]
		public static readonly NameAndTooltip MipMapDisableMipCaching; //Field offset: 0x70
		[Token(Token = "0x400019E")]
		public static readonly NameAndTooltip MipMapDebugView; //Field offset: 0x80
		[Token(Token = "0x400019F")]
		public static readonly NameAndTooltip MipMapDebugOpacity; //Field offset: 0x90
		[Token(Token = "0x40001A0")]
		public static readonly NameAndTooltip MipMapMaterialTextureSlot; //Field offset: 0xA0
		[Token(Token = "0x40001A1")]
		public static readonly NameAndTooltip MipMapTerrainTexture; //Field offset: 0xB0
		[Token(Token = "0x40001A2")]
		public static readonly NameAndTooltip MipMapDisplayStatusCodes; //Field offset: 0xC0
		[Token(Token = "0x40001A3")]
		public static readonly NameAndTooltip MipMapActivityTimespan; //Field offset: 0xD0
		[Token(Token = "0x40001A4")]
		public static readonly NameAndTooltip MipMapCombinePerMaterial; //Field offset: 0xE0
		[Token(Token = "0x40001A5")]
		public static readonly NameAndTooltip PostProcessing; //Field offset: 0xF0
		[Token(Token = "0x40001A6")]
		public static readonly NameAndTooltip MSAA; //Field offset: 0x100
		[Token(Token = "0x40001A7")]
		public static readonly NameAndTooltip HDR; //Field offset: 0x110
		[Token(Token = "0x40001A8")]
		public static readonly NameAndTooltip TaaDebugMode; //Field offset: 0x120
		[Token(Token = "0x40001A9")]
		public static readonly NameAndTooltip PixelValidationMode; //Field offset: 0x130
		[Token(Token = "0x40001AA")]
		public static readonly NameAndTooltip Channels; //Field offset: 0x140
		[Token(Token = "0x40001AB")]
		public static readonly NameAndTooltip ValueRangeMin; //Field offset: 0x150
		[Token(Token = "0x40001AC")]
		public static readonly NameAndTooltip ValueRangeMax; //Field offset: 0x160

		[Address(RVA = "0x2D605A0", Offset = "0x2D5F9A0", Length = "0xAE1")]
		[Token(Token = "0x60001C8")]
		private static Strings() { }

	}

	[Token(Token = "0x200004E")]
	internal enum TaaDebugMode : int
	{
		None = 0,
		ShowRawFrame = 1,
		ShowRawFrameNoJitter = 2,
		ShowClampedHistory = 3,
	}

	[Token(Token = "0x2000050")]
	public static class WidgetFactory
	{
		[CompilerGenerated]
		[Token(Token = "0x2000051")]
		private sealed class <>c
		{
			[Token(Token = "0x40001AD")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40001AE")]
			public static Func<Int32> <>9__2_2; //Field offset: 0x8
			[Token(Token = "0x40001AF")]
			public static Func<Int32> <>9__2_3; //Field offset: 0x10
			[Token(Token = "0x40001B0")]
			public static Action<Field`1<Int32>, Int32> <>9__3_4; //Field offset: 0x18
			[Token(Token = "0x40001B1")]
			public static Func<Int32> <>9__6_3; //Field offset: 0x20
			[Token(Token = "0x40001B2")]
			public static Func<Int32> <>9__6_4; //Field offset: 0x28
			[Token(Token = "0x40001B3")]
			public static Func<Boolean> <>9__7_0; //Field offset: 0x30
			[Token(Token = "0x40001B4")]
			public static Action<Boolean> <>9__7_1; //Field offset: 0x38
			[Token(Token = "0x40001B5")]
			public static Func<Single> <>9__9_4; //Field offset: 0x40
			[Token(Token = "0x40001B6")]
			public static Func<Single> <>9__9_5; //Field offset: 0x48
			[Token(Token = "0x40001B7")]
			public static Func<Boolean> <>9__9_10; //Field offset: 0x50
			[Token(Token = "0x40001B8")]
			public static Func<Single> <>9__11_3; //Field offset: 0x58
			[Token(Token = "0x40001B9")]
			public static Func<Single> <>9__11_4; //Field offset: 0x60
			[Token(Token = "0x40001BA")]
			public static Action<Field`1<Int32>, Int32> <>9__16_4; //Field offset: 0x68
			[Token(Token = "0x40001BB")]
			public static Action<Field`1<Int32>, Int32> <>9__17_4; //Field offset: 0x70

			[Address(RVA = "0x2D64D30", Offset = "0x2D64130", Length = "0x67")]
			[Token(Token = "0x60001DE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001DF")]
			public <>c() { }

			[Address(RVA = "0x2D61A00", Offset = "0x2D60E00", Length = "0x54")]
			[Token(Token = "0x60001E2")]
			internal void <CreateAdditionalWireframeShaderViews>b__3_4(Field<Int32> _, int _) { }

			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x60001E0")]
			internal int <CreateMapOverlaySize>b__2_2() { }

			[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
			[Token(Token = "0x60001E1")]
			internal int <CreateMapOverlaySize>b__2_3() { }

			[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
			[Token(Token = "0x60001E3")]
			internal int <CreateMaxOverdrawCount>b__6_3() { }

			[Address(RVA = "0x2D61B20", Offset = "0x2D60F20", Length = "0x6")]
			[Token(Token = "0x60001E4")]
			internal int <CreateMaxOverdrawCount>b__6_4() { }

			[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
			[Token(Token = "0x60001EA")]
			internal float <CreateMipMapDebugCooldownSlider>b__11_3() { }

			[Address(RVA = "0x2D61B30", Offset = "0x2D60F30", Length = "0x9")]
			[Token(Token = "0x60001EB")]
			internal float <CreateMipMapDebugCooldownSlider>b__11_4() { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60001E9")]
			internal bool <CreateMipMapDebugSettings>b__9_10() { }

			[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
			[Token(Token = "0x60001E7")]
			internal float <CreateMipMapDebugSettings>b__9_4() { }

			[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
			[Token(Token = "0x60001E8")]
			internal float <CreateMipMapDebugSettings>b__9_5() { }

			[Address(RVA = "0x2D61B40", Offset = "0x2D60F40", Length = "0x40")]
			[Token(Token = "0x60001E5")]
			internal bool <CreateMipMapDebugWidget>b__7_0() { }

			[Address(RVA = "0x2D61B80", Offset = "0x2D60F80", Length = "0x49")]
			[Token(Token = "0x60001E6")]
			internal void <CreateMipMapDebugWidget>b__7_1(bool value) { }

			[Address(RVA = "0x2D61BD0", Offset = "0x2D60FD0", Length = "0x54")]
			[Token(Token = "0x60001ED")]
			internal void <CreatePixelValidationMode>b__17_4(Field<Int32> _, int _) { }

			[Address(RVA = "0x2D61C30", Offset = "0x2D61030", Length = "0x54")]
			[Token(Token = "0x60001EC")]
			internal void <CreateTaaDebugMode>b__16_4(Field<Int32> _, int _) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000052")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001BC")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001EE")]
			public <>c__DisplayClass0_0() { }

			[Address(RVA = "0x2D61EA0", Offset = "0x2D612A0", Length = "0x45")]
			[Token(Token = "0x60001EF")]
			internal int <CreateMapOverlays>b__0() { }

			[Address(RVA = "0x2D61EF0", Offset = "0x2D612F0", Length = "0x50")]
			[Token(Token = "0x60001F0")]
			internal void <CreateMapOverlays>b__1(int value) { }

			[Address(RVA = "0x2D61F50", Offset = "0x2D61350", Length = "0x45")]
			[Token(Token = "0x60001F1")]
			internal int <CreateMapOverlays>b__2() { }

			[Address(RVA = "0x2D61FA0", Offset = "0x2D613A0", Length = "0x50")]
			[Token(Token = "0x60001F2")]
			internal void <CreateMapOverlays>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005D")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C7")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600021D")]
			public <>c__DisplayClass1_0() { }

			[Address(RVA = "0x2D63150", Offset = "0x2D62550", Length = "0x49")]
			[Token(Token = "0x600021E")]
			internal bool <CreateStpDebugViews>b__0() { }

			[Address(RVA = "0x2D631A0", Offset = "0x2D625A0", Length = "0x45")]
			[Token(Token = "0x600021F")]
			internal int <CreateStpDebugViews>b__1() { }

			[Address(RVA = "0x2D631F0", Offset = "0x2D625F0", Length = "0x50")]
			[Token(Token = "0x6000220")]
			internal void <CreateStpDebugViews>b__2(int value) { }

			[Address(RVA = "0x2D63250", Offset = "0x2D62650", Length = "0x45")]
			[Token(Token = "0x6000221")]
			internal int <CreateStpDebugViews>b__3() { }

			[Address(RVA = "0x2D632A0", Offset = "0x2D626A0", Length = "0x50")]
			[Token(Token = "0x6000222")]
			internal void <CreateStpDebugViews>b__4(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000053")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001BD")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001F3")]
			public <>c__DisplayClass10_0() { }

			[Address(RVA = "0x2D622F0", Offset = "0x2D616F0", Length = "0x45")]
			[Token(Token = "0x60001F4")]
			internal int <CreateMipMapDebugSlotSelector>b__0() { }

			[Address(RVA = "0x2D62340", Offset = "0x2D61740", Length = "0x50")]
			[Token(Token = "0x60001F5")]
			internal void <CreateMipMapDebugSlotSelector>b__1(int value) { }

			[Address(RVA = "0x2D623A0", Offset = "0x2D617A0", Length = "0x45")]
			[Token(Token = "0x60001F6")]
			internal int <CreateMipMapDebugSlotSelector>b__2() { }

			[Address(RVA = "0x2D623F0", Offset = "0x2D617F0", Length = "0x50")]
			[Token(Token = "0x60001F7")]
			internal void <CreateMipMapDebugSlotSelector>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000054")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001BE")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001F8")]
			public <>c__DisplayClass11_0() { }

			[Address(RVA = "0x2D62560", Offset = "0x2D61960", Length = "0x49")]
			[Token(Token = "0x60001F9")]
			internal bool <CreateMipMapDebugCooldownSlider>b__0() { }

			[Address(RVA = "0x2D625B0", Offset = "0x2D619B0", Length = "0x47")]
			[Token(Token = "0x60001FA")]
			internal float <CreateMipMapDebugCooldownSlider>b__1() { }

			[Address(RVA = "0x2D62600", Offset = "0x2D61A00", Length = "0x54")]
			[Token(Token = "0x60001FB")]
			internal void <CreateMipMapDebugCooldownSlider>b__2(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000055")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001BF")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001FC")]
			public <>c__DisplayClass12_0() { }

			[Address(RVA = "0x2D62710", Offset = "0x2D61B10", Length = "0x49")]
			[Token(Token = "0x60001FD")]
			internal bool <CreateMipMapShowStatusCodeToggle>b__0() { }

			[Address(RVA = "0x2D62760", Offset = "0x2D61B60", Length = "0x46")]
			[Token(Token = "0x60001FE")]
			internal bool <CreateMipMapShowStatusCodeToggle>b__1() { }

			[Address(RVA = "0x2D627B0", Offset = "0x2D61BB0", Length = "0x51")]
			[Token(Token = "0x60001FF")]
			internal void <CreateMipMapShowStatusCodeToggle>b__2(bool value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000056")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C0")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000200")]
			public <>c__DisplayClass13_0() { }

			[Address(RVA = "0x2D628C0", Offset = "0x2D61CC0", Length = "0x45")]
			[Token(Token = "0x6000201")]
			internal int <CreatePostProcessing>b__0() { }

			[Address(RVA = "0x2D62910", Offset = "0x2D61D10", Length = "0x50")]
			[Token(Token = "0x6000202")]
			internal void <CreatePostProcessing>b__1(int value) { }

			[Address(RVA = "0x2D62970", Offset = "0x2D61D70", Length = "0x45")]
			[Token(Token = "0x6000203")]
			internal int <CreatePostProcessing>b__2() { }

			[Address(RVA = "0x2D629C0", Offset = "0x2D61DC0", Length = "0x50")]
			[Token(Token = "0x6000204")]
			internal void <CreatePostProcessing>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000057")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C1")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000205")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0x2D62A20", Offset = "0x2D61E20", Length = "0x46")]
			[Token(Token = "0x6000206")]
			internal bool <CreateMSAA>b__0() { }

			[Address(RVA = "0x2D62A70", Offset = "0x2D61E70", Length = "0x51")]
			[Token(Token = "0x6000207")]
			internal void <CreateMSAA>b__1(bool value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000058")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C2")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000208")]
			public <>c__DisplayClass15_0() { }

			[Address(RVA = "0x2D62AD0", Offset = "0x2D61ED0", Length = "0x46")]
			[Token(Token = "0x6000209")]
			internal bool <CreateHDR>b__0() { }

			[Address(RVA = "0x2D62B20", Offset = "0x2D61F20", Length = "0x51")]
			[Token(Token = "0x600020A")]
			internal void <CreateHDR>b__1(bool value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000059")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C3")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600020B")]
			public <>c__DisplayClass16_0() { }

			[Address(RVA = "0x2D62B80", Offset = "0x2D61F80", Length = "0x45")]
			[Token(Token = "0x600020C")]
			internal int <CreateTaaDebugMode>b__0() { }

			[Address(RVA = "0x2D62BD0", Offset = "0x2D61FD0", Length = "0x50")]
			[Token(Token = "0x600020D")]
			internal void <CreateTaaDebugMode>b__1(int value) { }

			[Address(RVA = "0x2D62C30", Offset = "0x2D62030", Length = "0x45")]
			[Token(Token = "0x600020E")]
			internal int <CreateTaaDebugMode>b__2() { }

			[Address(RVA = "0x2D62C80", Offset = "0x2D62080", Length = "0x50")]
			[Token(Token = "0x600020F")]
			internal void <CreateTaaDebugMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005A")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C4")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000210")]
			public <>c__DisplayClass17_0() { }

			[Address(RVA = "0x2D62CE0", Offset = "0x2D620E0", Length = "0x45")]
			[Token(Token = "0x6000211")]
			internal int <CreatePixelValidationMode>b__0() { }

			[Address(RVA = "0x2D62D30", Offset = "0x2D62130", Length = "0x50")]
			[Token(Token = "0x6000212")]
			internal void <CreatePixelValidationMode>b__1(int value) { }

			[Address(RVA = "0x2D62D90", Offset = "0x2D62190", Length = "0x45")]
			[Token(Token = "0x6000213")]
			internal int <CreatePixelValidationMode>b__2() { }

			[Address(RVA = "0x2D62DE0", Offset = "0x2D621E0", Length = "0x50")]
			[Token(Token = "0x6000214")]
			internal void <CreatePixelValidationMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005B")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C5")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000215")]
			public <>c__DisplayClass18_0() { }

			[Address(RVA = "0x2D62E40", Offset = "0x2D62240", Length = "0x45")]
			[Token(Token = "0x6000216")]
			internal int <CreatePixelValidationChannels>b__0() { }

			[Address(RVA = "0x2D62E90", Offset = "0x2D62290", Length = "0x50")]
			[Token(Token = "0x6000217")]
			internal void <CreatePixelValidationChannels>b__1(int value) { }

			[Address(RVA = "0x2D62EF0", Offset = "0x2D622F0", Length = "0x45")]
			[Token(Token = "0x6000218")]
			internal int <CreatePixelValidationChannels>b__2() { }

			[Address(RVA = "0x2D62F40", Offset = "0x2D62340", Length = "0x50")]
			[Token(Token = "0x6000219")]
			internal void <CreatePixelValidationChannels>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005C")]
		private sealed class <>c__DisplayClass19_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C6")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600021A")]
			public <>c__DisplayClass19_0() { }

			[Address(RVA = "0x2D62FA0", Offset = "0x2D623A0", Length = "0x47")]
			[Token(Token = "0x600021B")]
			internal float <CreatePixelValueRangeMin>b__0() { }

			[Address(RVA = "0x2D62FF0", Offset = "0x2D623F0", Length = "0x54")]
			[Token(Token = "0x600021C")]
			internal void <CreatePixelValueRangeMin>b__1(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005F")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C9")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000226")]
			public <>c__DisplayClass2_0() { }

			[Address(RVA = "0x2D63670", Offset = "0x2D62A70", Length = "0x45")]
			[Token(Token = "0x6000227")]
			internal int <CreateMapOverlaySize>b__0() { }

			[Address(RVA = "0x2D636C0", Offset = "0x2D62AC0", Length = "0x50")]
			[Token(Token = "0x6000228")]
			internal void <CreateMapOverlaySize>b__1(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200005E")]
		private sealed class <>c__DisplayClass20_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001C8")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000223")]
			public <>c__DisplayClass20_0() { }

			[Address(RVA = "0x2D63460", Offset = "0x2D62860", Length = "0x47")]
			[Token(Token = "0x6000224")]
			internal float <CreatePixelValueRangeMax>b__0() { }

			[Address(RVA = "0x2D634B0", Offset = "0x2D628B0", Length = "0x54")]
			[Token(Token = "0x6000225")]
			internal void <CreatePixelValueRangeMax>b__1(float value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000060")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CA")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000229")]
			public <>c__DisplayClass3_0() { }

			[Address(RVA = "0x2D63880", Offset = "0x2D62C80", Length = "0x45")]
			[Token(Token = "0x600022A")]
			internal int <CreateAdditionalWireframeShaderViews>b__0() { }

			[Address(RVA = "0x2D638D0", Offset = "0x2D62CD0", Length = "0xA2")]
			[Token(Token = "0x600022B")]
			internal void <CreateAdditionalWireframeShaderViews>b__1(int value) { }

			[Address(RVA = "0x2D63980", Offset = "0x2D62D80", Length = "0x45")]
			[Token(Token = "0x600022C")]
			internal int <CreateAdditionalWireframeShaderViews>b__2() { }

			[Address(RVA = "0x2D639D0", Offset = "0x2D62DD0", Length = "0xA2")]
			[Token(Token = "0x600022D")]
			internal void <CreateAdditionalWireframeShaderViews>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000061")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CB")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600022E")]
			public <>c__DisplayClass4_0() { }

			[Address(RVA = "0x2D63D00", Offset = "0x2D63100", Length = "0x62")]
			[Token(Token = "0x600022F")]
			internal bool <CreateWireframeNotSupportedWarning>b__0() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000062")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CC")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000230")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x2D63FC0", Offset = "0x2D633C0", Length = "0x45")]
			[Token(Token = "0x6000231")]
			internal int <CreateOverdrawMode>b__0() { }

			[Address(RVA = "0x2D64010", Offset = "0x2D63410", Length = "0xA2")]
			[Token(Token = "0x6000232")]
			internal void <CreateOverdrawMode>b__1(int value) { }

			[Address(RVA = "0x2D640C0", Offset = "0x2D634C0", Length = "0x45")]
			[Token(Token = "0x6000233")]
			internal int <CreateOverdrawMode>b__2() { }

			[Address(RVA = "0x2D64110", Offset = "0x2D63510", Length = "0xA2")]
			[Token(Token = "0x6000234")]
			internal void <CreateOverdrawMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000063")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CD")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000235")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0x2D643A0", Offset = "0x2D637A0", Length = "0x49")]
			[Token(Token = "0x6000236")]
			internal bool <CreateMaxOverdrawCount>b__0() { }

			[Address(RVA = "0x2D643F0", Offset = "0x2D637F0", Length = "0x45")]
			[Token(Token = "0x6000237")]
			internal int <CreateMaxOverdrawCount>b__1() { }

			[Address(RVA = "0x2D64440", Offset = "0x2D63840", Length = "0x50")]
			[Token(Token = "0x6000238")]
			internal void <CreateMaxOverdrawCount>b__2(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000064")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CE")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000239")]
			public <>c__DisplayClass8_0() { }

			[Address(RVA = "0x2D64660", Offset = "0x2D63A60", Length = "0x45")]
			[Token(Token = "0x600023A")]
			internal int <CreateMipMapMode>b__0() { }

			[Address(RVA = "0x2D646B0", Offset = "0x2D63AB0", Length = "0x50")]
			[Token(Token = "0x600023B")]
			internal void <CreateMipMapMode>b__1(int value) { }

			[Address(RVA = "0x2D64710", Offset = "0x2D63B10", Length = "0x45")]
			[Token(Token = "0x600023C")]
			internal int <CreateMipMapMode>b__2() { }

			[Address(RVA = "0x2D64760", Offset = "0x2D63B60", Length = "0x50")]
			[Token(Token = "0x600023D")]
			internal void <CreateMipMapMode>b__3(int value) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000065")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001CF")]
			public SettingsPanel panel; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600023E")]
			public <>c__DisplayClass9_0() { }

			[Address(RVA = "0x2D64870", Offset = "0x2D63C70", Length = "0x49")]
			[Token(Token = "0x600023F")]
			internal bool <CreateMipMapDebugSettings>b__0() { }

			[Address(RVA = "0x2D64A20", Offset = "0x2D63E20", Length = "0x57")]
			[Token(Token = "0x6000242")]
			internal bool <CreateMipMapDebugSettings>b__1() { }

			[Address(RVA = "0x2D648C0", Offset = "0x2D63CC0", Length = "0x45")]
			[Token(Token = "0x6000247")]
			internal int <CreateMipMapDebugSettings>b__11() { }

			[Address(RVA = "0x2D64910", Offset = "0x2D63D10", Length = "0x50")]
			[Token(Token = "0x6000248")]
			internal void <CreateMipMapDebugSettings>b__12(int value) { }

			[Address(RVA = "0x2D64970", Offset = "0x2D63D70", Length = "0x45")]
			[Token(Token = "0x6000249")]
			internal int <CreateMipMapDebugSettings>b__13() { }

			[Address(RVA = "0x2D649C0", Offset = "0x2D63DC0", Length = "0x50")]
			[Token(Token = "0x600024A")]
			internal void <CreateMipMapDebugSettings>b__14(int value) { }

			[Address(RVA = "0x2D64A80", Offset = "0x2D63E80", Length = "0x47")]
			[Token(Token = "0x6000240")]
			internal float <CreateMipMapDebugSettings>b__2() { }

			[Address(RVA = "0x2D64AD0", Offset = "0x2D63ED0", Length = "0x54")]
			[Token(Token = "0x6000241")]
			internal void <CreateMipMapDebugSettings>b__3(float value) { }

			[Address(RVA = "0x2D64B30", Offset = "0x2D63F30", Length = "0x57")]
			[Token(Token = "0x6000243")]
			internal bool <CreateMipMapDebugSettings>b__6() { }

			[Address(RVA = "0x2D64B90", Offset = "0x2D63F90", Length = "0x46")]
			[Token(Token = "0x6000244")]
			internal bool <CreateMipMapDebugSettings>b__7() { }

			[Address(RVA = "0x2D64BE0", Offset = "0x2D63FE0", Length = "0x6C")]
			[Token(Token = "0x6000245")]
			internal void <CreateMipMapDebugSettings>b__8(bool value) { }

			[Address(RVA = "0x2D64C50", Offset = "0x2D64050", Length = "0x62")]
			[Token(Token = "0x6000246")]
			internal bool <CreateMipMapDebugSettings>b__9() { }

		}


		[Address(RVA = "0x2D68CC0", Offset = "0x2D680C0", Length = "0x33F")]
		[Token(Token = "0x60001CC")]
		internal static Widget CreateAdditionalWireframeShaderViews(SettingsPanel panel) { }

		[Address(RVA = "0x2D6A1A0", Offset = "0x2D695A0", Length = "0x1A1")]
		[Token(Token = "0x60001D8")]
		internal static Widget CreateHDR(SettingsPanel panel) { }

		[Address(RVA = "0x2D6ACF0", Offset = "0x2D6A0F0", Length = "0x26D")]
		[Token(Token = "0x60001C9")]
		internal static Widget CreateMapOverlays(SettingsPanel panel) { }

		[Address(RVA = "0x2D6A960", Offset = "0x2D69D60", Length = "0x38A")]
		[Token(Token = "0x60001CB")]
		internal static Widget CreateMapOverlaySize(SettingsPanel panel) { }

		[Address(RVA = "0x2D6B510", Offset = "0x2D6A910", Length = "0x3D9")]
		[Token(Token = "0x60001CF")]
		internal static Widget CreateMaxOverdrawCount(SettingsPanel panel) { }

		[Address(RVA = "0x2D6BC50", Offset = "0x2D6B050", Length = "0x36C")]
		[Token(Token = "0x60001D4")]
		internal static Widget CreateMipMapDebugCooldownSlider(SettingsPanel panel) { }

		[Address(RVA = "0x2D6BFC0", Offset = "0x2D6B3C0", Length = "0xCAB")]
		[Token(Token = "0x60001D2")]
		internal static Widget CreateMipMapDebugSettings(SettingsPanel panel) { }

		[Address(RVA = "0x2D6CC70", Offset = "0x2D6C070", Length = "0x291")]
		[Token(Token = "0x60001D3")]
		internal static Widget CreateMipMapDebugSlotSelector(SettingsPanel panel, Func<Boolean> hiddenCB, GUIContent[] texSlotStrings, Int32[] texSlotValues) { }

		[Address(RVA = "0x2D6CF10", Offset = "0x2D6C310", Length = "0x337")]
		[Token(Token = "0x60001D0")]
		internal static Widget CreateMipMapDebugWidget(SettingsPanel panel) { }

		[Address(RVA = "0x2D6D250", Offset = "0x2D6C650", Length = "0x271")]
		[Token(Token = "0x60001D1")]
		internal static Widget CreateMipMapMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6D4D0", Offset = "0x2D6C8D0", Length = "0x1E4")]
		[Token(Token = "0x60001D5")]
		internal static Widget CreateMipMapShowStatusCodeToggle(SettingsPanel panel) { }

		[Address(RVA = "0x2D6A7B0", Offset = "0x2D69BB0", Length = "0x1A1")]
		[Token(Token = "0x60001D7")]
		internal static Widget CreateMSAA(SettingsPanel panel) { }

		[Address(RVA = "0x2D6D6C0", Offset = "0x2D6CAC0", Length = "0x26E")]
		[Token(Token = "0x60001CE")]
		internal static Widget CreateOverdrawMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6D930", Offset = "0x2D6CD30", Length = "0x271")]
		[Token(Token = "0x60001DB")]
		internal static Widget CreatePixelValidationChannels(SettingsPanel panel) { }

		[Address(RVA = "0x2D6DBB0", Offset = "0x2D6CFB0", Length = "0x342")]
		[Token(Token = "0x60001DA")]
		internal static Widget CreatePixelValidationMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6DF00", Offset = "0x2D6D300", Length = "0x1A8")]
		[Token(Token = "0x60001DD")]
		internal static Widget CreatePixelValueRangeMax(SettingsPanel panel) { }

		[Address(RVA = "0x2D6E0B0", Offset = "0x2D6D4B0", Length = "0x1A8")]
		[Token(Token = "0x60001DC")]
		internal static Widget CreatePixelValueRangeMin(SettingsPanel panel) { }

		[Address(RVA = "0x2D6E260", Offset = "0x2D6D660", Length = "0x271")]
		[Token(Token = "0x60001D6")]
		internal static Widget CreatePostProcessing(SettingsPanel panel) { }

		[Address(RVA = "0x2D6E880", Offset = "0x2D6DC80", Length = "0x34E")]
		[Token(Token = "0x60001CA")]
		internal static Widget CreateStpDebugViews(SettingsPanel panel) { }

		[Address(RVA = "0x2D6EBD0", Offset = "0x2D6DFD0", Length = "0x342")]
		[Token(Token = "0x60001D9")]
		internal static Widget CreateTaaDebugMode(SettingsPanel panel) { }

		[Address(RVA = "0x2D6F190", Offset = "0x2D6E590", Length = "0x13D")]
		[Token(Token = "0x60001CD")]
		internal static Widget CreateWireframeNotSupportedWarning(SettingsPanel panel) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000178")]
	private DebugWireframeMode m_WireframeMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000179")]
	private bool m_Overdraw; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017A")]
	private DebugOverdrawMode m_OverdrawMode; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400017B")]
	private int <maxOverdrawCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017C")]
	private DebugFullScreenMode <fullScreenDebugMode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400017D")]
	private int <stpDebugViewIndex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017E")]
	private int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400017F")]
	private DebugSceneOverrideMode <sceneOverrideMode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000180")]
	private DebugMipInfoMode <mipInfoMode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000181")]
	private bool <mipDebugStatusShowCode>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000182")]
	private DebugMipMapStatusMode <mipDebugStatusMode>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000183")]
	private float <mipDebugOpacity>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000184")]
	private float <mipDebugRecentUpdateCooldown>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000185")]
	private int <mipDebugMaterialTextureSlot>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000186")]
	private bool <showInfoForAllSlots>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000187")]
	private DebugMipMapModeTerrainTexture <mipDebugTerrainTexture>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000188")]
	private DebugPostProcessingMode <postProcessingDebugMode>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000189")]
	private bool <enableMsaa>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x400018A")]
	private bool <enableHDR>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400018B")]
	private TaaDebugMode <taaDebugMode>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400018C")]
	private DebugValidationMode <validationMode>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400018D")]
	private PixelValidationChannels <validationChannels>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400018E")]
	private float <validationRangeMin>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400018F")]
	private float <validationRangeMax>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x170000A3")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2D57FE0", Offset = "0x2D573E0", Length = "0x35")]
		[Token(Token = "0x60001C2")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000099")]
	internal bool canAggregateData
	{
		[Address(RVA = "0x2D58060", Offset = "0x2D57460", Length = "0x11")]
		[Token(Token = "0x60001AF")]
		internal get { } //Length: 17
	}

	[Token(Token = "0x1700009D")]
	public bool enableHDR
	{
		[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 5
		[Address(RVA = "0x2D58080", Offset = "0x2D57480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009C")]
	public bool enableMsaa
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700008E")]
	public DebugFullScreenMode fullScreenDebugMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000199")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000090")]
	public int fullScreenDebugModeOutputSizeScreenPercent
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019D")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A5")]
	public override bool IsLightingActive
	{
		[Address(RVA = "0x2D58020", Offset = "0x2D57420", Length = "0x11")]
		[Token(Token = "0x60001C4")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000A4")]
	public override bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x2D58040", Offset = "0x2D57440", Length = "0x17")]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700008D")]
	public int maxOverdrawCount
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000196")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000197")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000097")]
	public int mipDebugMaterialTextureSlot
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001AC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000095")]
	public float mipDebugOpacity
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001A7")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001A8")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000096")]
	public float mipDebugRecentUpdateCooldown
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 6
		[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001AA")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000094")]
	public DebugMipMapStatusMode mipDebugStatusMode
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000093")]
	public bool mipDebugStatusShowCode
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009A")]
	public DebugMipMapModeTerrainTexture mipDebugTerrainTexture
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000092")]
	public DebugMipInfoMode mipInfoMode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A1")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A2")]
		 set { } //Length: 4
	}

	[Obsolete("overdraw has been deprecated. Use overdrawMode instead. #from(2022.2) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700008B")]
	public bool overdraw
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 5
		[Address(RVA = "0x2D580E0", Offset = "0x2D574E0", Length = "0x54")]
		[Token(Token = "0x6000193")]
		 set { } //Length: 84
	}

	[Token(Token = "0x1700008C")]
	public DebugOverdrawMode overdrawMode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000194")]
		 get { } //Length: 4
		[Address(RVA = "0x2D58090", Offset = "0x2D57490", Length = "0x48")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 72
	}

	[Token(Token = "0x1700009B")]
	public DebugPostProcessingMode postProcessingDebugMode
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000091")]
	internal DebugSceneOverrideMode sceneOverrideMode
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019F")]
		internal get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A0")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000098")]
	public bool showInfoForAllSlots
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001AD")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001AE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700008F")]
	internal int stpDebugViewIndex
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019B")]
		internal get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600019C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700009E")]
	public TaaDebugMode taaDebugMode
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A0")]
	public PixelValidationChannels validationChannels
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001BD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009F")]
	public DebugValidationMode validationMode
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001BB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A2")]
	public float validationRangeMax
	{
		[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 6
		[Address(RVA = "0x16D0CA0", Offset = "0x16D00A0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001C1")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A1")]
	public float validationRangeMin
	{
		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001BE")]
		 get { } //Length: 6
		[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60001BF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700008A")]
	public DebugWireframeMode wireframeMode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 85
		[Address(RVA = "0x2D58140", Offset = "0x2D57540", Length = "0x51")]
		[Token(Token = "0x6000191")]
		 set { } //Length: 81
	}

	[Address(RVA = "0x2D57FA0", Offset = "0x2D573A0", Length = "0x3B")]
	[Token(Token = "0x60001C7")]
	public DebugDisplaySettingsRendering() { }

	[Address(RVA = "0x2D57FE0", Offset = "0x2D573E0", Length = "0x35")]
	[Token(Token = "0x60001C2")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x2D58060", Offset = "0x2D57460", Length = "0x11")]
	[Token(Token = "0x60001AF")]
	internal bool get_canAggregateData() { }

	[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001B6")]
	public bool get_enableHDR() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001B4")]
	public bool get_enableMsaa() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000199")]
	public DebugFullScreenMode get_fullScreenDebugMode() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019D")]
	public int get_fullScreenDebugModeOutputSizeScreenPercent() { }

	[Address(RVA = "0x2D58020", Offset = "0x2D57420", Length = "0x11")]
	[Token(Token = "0x60001C4")]
	public override bool get_IsLightingActive() { }

	[Address(RVA = "0x2D58040", Offset = "0x2D57440", Length = "0x17")]
	[Token(Token = "0x60001C3")]
	public override bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000196")]
	public int get_maxOverdrawCount() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001AB")]
	public int get_mipDebugMaterialTextureSlot() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001A7")]
	public float get_mipDebugOpacity() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001A9")]
	public float get_mipDebugRecentUpdateCooldown() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A5")]
	public DebugMipMapStatusMode get_mipDebugStatusMode() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A3")]
	public bool get_mipDebugStatusShowCode() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B0")]
	public DebugMipMapModeTerrainTexture get_mipDebugTerrainTexture() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A1")]
	public DebugMipInfoMode get_mipInfoMode() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000192")]
	public bool get_overdraw() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000194")]
	public DebugOverdrawMode get_overdrawMode() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B2")]
	public DebugPostProcessingMode get_postProcessingDebugMode() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019F")]
	internal DebugSceneOverrideMode get_sceneOverrideMode() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001AD")]
	public bool get_showInfoForAllSlots() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019B")]
	internal int get_stpDebugViewIndex() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B8")]
	public TaaDebugMode get_taaDebugMode() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001BC")]
	public PixelValidationChannels get_validationChannels() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001BA")]
	public DebugValidationMode get_validationMode() { }

	[Address(RVA = "0x16D0A10", Offset = "0x16CFE10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001C0")]
	public float get_validationRangeMax() { }

	[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001BE")]
	public float get_validationRangeMin() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000190")]
	public DebugWireframeMode get_wireframeMode() { }

	[Address(RVA = "0x2D58080", Offset = "0x2D57480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B7")]
	public void set_enableHDR(bool value) { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B5")]
	public void set_enableMsaa(bool value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019A")]
	public void set_fullScreenDebugMode(DebugFullScreenMode value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019E")]
	public void set_fullScreenDebugModeOutputSizeScreenPercent(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000197")]
	public void set_maxOverdrawCount(int value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001AC")]
	public void set_mipDebugMaterialTextureSlot(int value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001A8")]
	public void set_mipDebugOpacity(float value) { }

	[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001AA")]
	public void set_mipDebugRecentUpdateCooldown(float value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A6")]
	public void set_mipDebugStatusMode(DebugMipMapStatusMode value) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A4")]
	public void set_mipDebugStatusShowCode(bool value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B1")]
	public void set_mipDebugTerrainTexture(DebugMipMapModeTerrainTexture value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A2")]
	public void set_mipInfoMode(DebugMipInfoMode value) { }

	[Address(RVA = "0x2D580E0", Offset = "0x2D574E0", Length = "0x54")]
	[Token(Token = "0x6000193")]
	public void set_overdraw(bool value) { }

	[Address(RVA = "0x2D58090", Offset = "0x2D57490", Length = "0x48")]
	[Token(Token = "0x6000195")]
	public void set_overdrawMode(DebugOverdrawMode value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B3")]
	public void set_postProcessingDebugMode(DebugPostProcessingMode value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A0")]
	internal void set_sceneOverrideMode(DebugSceneOverrideMode value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001AE")]
	public void set_showInfoForAllSlots(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600019C")]
	internal void set_stpDebugViewIndex(int value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B9")]
	public void set_taaDebugMode(TaaDebugMode value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001BD")]
	public void set_validationChannels(PixelValidationChannels value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001BB")]
	public void set_validationMode(DebugValidationMode value) { }

	[Address(RVA = "0x16D0CA0", Offset = "0x16D00A0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001C1")]
	public void set_validationRangeMax(float value) { }

	[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60001BF")]
	public void set_validationRangeMin(float value) { }

	[Address(RVA = "0x2D58140", Offset = "0x2D57540", Length = "0x51")]
	[Token(Token = "0x6000191")]
	public void set_wireframeMode(DebugWireframeMode value) { }

	[Address(RVA = "0x2D57E30", Offset = "0x2D57230", Length = "0xA4")]
	[Token(Token = "0x60001C5")]
	public override bool TryGetScreenClearColor(ref Color color) { }

	[Address(RVA = "0x2D57EE0", Offset = "0x2D572E0", Length = "0x54")]
	[Token(Token = "0x60001C6")]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	[Address(RVA = "0x2D57F40", Offset = "0x2D57340", Length = "0x51")]
	[Token(Token = "0x6000198")]
	private void UpdateDebugSceneOverrideMode() { }

}

