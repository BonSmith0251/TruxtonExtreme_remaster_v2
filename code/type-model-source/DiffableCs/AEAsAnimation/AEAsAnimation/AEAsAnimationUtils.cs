namespace AEAsAnimation;

[Token(Token = "0x200000A")]
public class AEAsAnimationUtils
{
	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000037")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000038")]
		public static Func<Int32, AVLayerMaskMode> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x5C1390", Offset = "0x5C0790", Length = "0x67")]
		[Token(Token = "0x6000051")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000052")]
		public <>c() { }

		[Address(RVA = "0x5C0170", Offset = "0x5BF570", Length = "0x1F")]
		[Token(Token = "0x6000053")]
		internal AVLayerMaskMode <GetAVLayerPropertiesData>b__3_0(int mode) { }

	}

	[Token(Token = "0x4000036")]
	public static bool ShowVersionStringLog; //Field offset: 0x0

	[Address(RVA = "0x5B09A0", Offset = "0x5AFDA0", Length = "0x36")]
	[Token(Token = "0x6000050")]
	private static AEAsAnimationUtils() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600004F")]
	public AEAsAnimationUtils() { }

	[Address(RVA = "0x5AD620", Offset = "0x5ACA20", Length = "0x368")]
	[Token(Token = "0x6000048")]
	public static AEData BootUpFromJsonString(string dataString) { }

	[Address(RVA = "0x5ADC30", Offset = "0x5AD030", Length = "0x75")]
	[Token(Token = "0x600004C")]
	private static void BuildMaskDepth(AEData bakedData) { }

	[Address(RVA = "0x5AD990", Offset = "0x5ACD90", Length = "0x1F1")]
	[Token(Token = "0x600004D")]
	private static void BuildMaskDepthComposition(AEData bakedData, CompositionData composition, int depth) { }

	[Address(RVA = "0x5ADB90", Offset = "0x5ACF90", Length = "0x9F")]
	[Token(Token = "0x600004E")]
	private static void BuildMaskDepthLayer(AEData bakedData, LayerData layer, int depth) { }

	[Address(RVA = "0x5ADCB0", Offset = "0x5AD0B0", Length = "0x108E")]
	[Token(Token = "0x600004A")]
	private static AVLayerPropertiesData GetAVLayerPropertiesData(JArray propertiesDataList) { }

	[Address(RVA = "0x5AED40", Offset = "0x5AE140", Length = "0x7BA")]
	[Token(Token = "0x6000049")]
	private static List<CompositionData> ParseCompositions(JArray compositions) { }

	[Address(RVA = "0x5AF500", Offset = "0x5AE900", Length = "0x1496")]
	[Token(Token = "0x600004B")]
	private static List<LayerData> ParseLayers(JArray layers) { }

}

