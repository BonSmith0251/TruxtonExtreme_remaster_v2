namespace AEAsAnimation;

[CreateAssetMenu(menuName = "Comic/Create AEData", fileName = "AEData", order = 1)]
[Token(Token = "0x2000017")]
public class AEData : ScriptableObject
{
	[Token(Token = "0x2000020")]
	internal class AVLayerAudioLevelData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B3")]
		public float _time; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000B4")]
		public float _volume; //Field offset: 0x14

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008E")]
		public AVLayerAudioLevelData() { }

	}

	[Token(Token = "0x2000028")]
	internal enum AVLayerBlendingMode : int
	{
		None = 0,
		ADD = 1,
		ALPHA_ADD = 2,
		CLASSIC_COLOR_BURN = 3,
		CLASSIC_COLOR_DODGE = 4,
		CLASSIC_DIFFERENCE = 5,
		COLOR = 6,
		COLOR_BURN = 7,
		COLOR_DODGE = 8,
		DANCING_DISSOLVE = 9,
		DARKEN = 10,
		DARKER_COLOR = 11,
		DIFFERENCE = 12,
		DISSOLVE = 13,
		EXCLUSION = 14,
		HARD_LIGHT = 15,
		HARD_MIX = 16,
		HUE = 17,
		LIGHTEN = 18,
		LIGHTER_COLOR = 19,
		LINEAR_BURN = 20,
		LINEAR_DODGE = 21,
		LINEAR_LIGHT = 22,
		LUMINESCENT_PREMUL = 23,
		LUMINOSITY = 24,
		MULTIPLY = 25,
		NORMAL = 26,
		OVERLAY = 27,
		PIN_LIGHT = 28,
		SATURATION = 29,
		SCREEN = 30,
		SILHOUETE_ALPHA = 31,
		SILHOUETTE_LUMA = 32,
		SOFT_LIGHT = 33,
		STENCIL_ALPHA = 34,
		STENCIL_LUMA = 35,
		SUBTRACT = 36,
		VIVID_LIGHT = 37,
	}

	[Token(Token = "0x2000029")]
	internal enum AVLayerBlendingModeValue : int
	{
		ADD = 5220,
		ALPHA_ADD = 5244,
		CLASSIC_COLOR_BURN = 5219,
		CLASSIC_COLOR_DODGE = 5225,
		CLASSIC_DIFFERENCE = 5234,
		COLOR = 5238,
		COLOR_BURN = 5218,
		COLOR_DODGE = 5224,
		DANCING_DISSOLVE = 5214,
		DARKEN = 5215,
		DARKER_COLOR = 5247,
		DIFFERENCE = 5233,
		DISSOLVE = 5213,
		DIVIDE = 5249,
		EXCLUSION = 5235,
		HARD_LIGHT = 5228,
		HARD_MIX = 5232,
		HUE = 5236,
		LIGHTEN = 5221,
		LIGHTER_COLOR = 5246,
		LINEAR_BURN = 5217,
		LINEAR_DODGE = 5223,
		LINEAR_LIGHT = 5229,
		LUMINESCENT_PREMUL = 5245,
		LUMINOSITY = 5239,
		MULTIPLY = 5216,
		NORMAL = 5212,
		OVERLAY = 5226,
		PIN_LIGHT = 5231,
		SATURATION = 5237,
		SCREEN = 5222,
		SILHOUETE_ALPHA = 5242,
		SILHOUETTE_LUMA = 5243,
		STENCIL_ALPHA = 5240,
		SOFT_LIGHT = 5227,
		STENCIL_LUMA = 5241,
		SUBTRACT = 5248,
		VIVID_LIGHT = 5230,
	}

	[Token(Token = "0x200002F")]
	internal class AVLayerExpressionData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013A")]
		public string _raw; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013B")]
		private readonly string LoopInTag; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400013C")]
		private readonly string LoopOutTag; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400013D")]
		private bool _hasLoopIn; //Field offset: 0x28
		[FieldOffset(Offset = "0x29")]
		[Token(Token = "0x400013E")]
		private bool _hasLoopOut; //Field offset: 0x29

		[Token(Token = "0x17000017")]
		public bool hasLoopIn
		{
			[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
			[Token(Token = "0x60000A2")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000018")]
		public bool hasLoopOut
		{
			[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
			[Token(Token = "0x60000A3")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x5BB1F0", Offset = "0x5BA5F0", Length = "0x9D")]
		[Token(Token = "0x60000A5")]
		public AVLayerExpressionData() { }

		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60000A2")]
		public bool get_hasLoopIn() { }

		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x60000A3")]
		public bool get_hasLoopOut() { }

		[Address(RVA = "0x5BB070", Offset = "0x5BA470", Length = "0x17D")]
		[Token(Token = "0x60000A4")]
		public AVLayerExpressionData Parse() { }

	}

	[Token(Token = "0x200001F")]
	internal class AVLayerMaskData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B0")]
		public LayerShapePropertyData _shape; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B1")]
		public AVLayerMaskMode _mode; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000B2")]
		public bool _inverted; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008D")]
		public AVLayerMaskData() { }

	}

	[Token(Token = "0x2000026")]
	internal enum AVLayerMaskMode : int
	{
		None = 0,
		ADD = 1,
		SUBTRACT = 2,
		INTERSECT = 3,
		LIGHTEN = 4,
		DARKEN = 5,
		DIFFERENCE = 6,
	}

	[Token(Token = "0x2000027")]
	internal enum AVLayerMaskModeValue : int
	{
		NONE = 6812,
		ADD = 6813,
		SUBTRACT = 6814,
		INTERSECT = 6815,
		LIGHTEN = 6816,
		DARKEN = 6817,
		DIFFERENCE = 6818,
	}

	[Token(Token = "0x2000022")]
	internal class AVLayerPropertiesData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BA")]
		public AVLayerTransformsData _transforms; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BB")]
		public AVLayerStyleStrokeData _styleStroke; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000BC")]
		public List<AVLayerMaskData> _masks; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000BD")]
		public List<AVLayerAudioLevelData> _audioLevels; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000BE")]
		public int _maskDepth; //Field offset: 0x30

		[Token(Token = "0x17000016")]
		public int _totalFrane
		{
			[Address(RVA = "0x5BB360", Offset = "0x5BA760", Length = "0x48")]
			[Token(Token = "0x6000090")]
			 get { } //Length: 72
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000092")]
		public AVLayerPropertiesData() { }

		[Address(RVA = "0x5BB2B0", Offset = "0x5BA6B0", Length = "0xA0")]
		[Token(Token = "0x6000091")]
		public static AVLayerPropertiesData Empty() { }

		[Address(RVA = "0x5BB360", Offset = "0x5BA760", Length = "0x48")]
		[Token(Token = "0x6000090")]
		public int get__totalFrane() { }

	}

	[Token(Token = "0x2000025")]
	internal enum AVLayerPropertyType : int
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Scale = 3,
		Anchor_Point = 4,
		Opacity = 5,
		ColorOverlay = 6,
	}

	[Token(Token = "0x2000021")]
	internal class AVLayerStyleStrokeData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B5")]
		public int _blendmode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000B6")]
		public float _size; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B7")]
		public Color _color; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B8")]
		public float _opacity; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40000B9")]
		public int _position; //Field offset: 0x2C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008F")]
		public AVLayerStyleStrokeData() { }

	}

	[Token(Token = "0x200001D")]
	internal class AVLayerTransformsData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A2")]
		public LayerPropertyData<Single> _position; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A3")]
		public LayerPropertyData<Single> _rotation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A4")]
		public LayerPropertyData<Single> _scale; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000A5")]
		public LayerPropertyData<Single> _anchor; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000A6")]
		public LayerPropertyData<Single> _opacity; //Field offset: 0x30

		[Token(Token = "0x17000015")]
		public int _totalFrane
		{
			[Address(RVA = "0x5BB3B0", Offset = "0x5BA7B0", Length = "0x13E")]
			[Token(Token = "0x600008A")]
			 get { } //Length: 318
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008B")]
		public AVLayerTransformsData() { }

		[Address(RVA = "0x5BB3B0", Offset = "0x5BA7B0", Length = "0x13E")]
		[Token(Token = "0x600008A")]
		public int get__totalFrane() { }

	}

	[Token(Token = "0x2000018")]
	internal class CompositionData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400006E")]
		public int _id; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006F")]
		public string _name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000070")]
		public float _width; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000071")]
		public float _height; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000072")]
		public float _duration; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000073")]
		public float _frameDuration; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000074")]
		public int _frameTime; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000075")]
		public float _fps; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000076")]
		public List<String> _layerIds; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000077")]
		public string _metaData; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000078")]
		public List<MarkerData> _markers; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000079")]
		public bool _enable; //Field offset: 0x50

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000085")]
		public CompositionData() { }

	}

	[Token(Token = "0x200001C")]
	internal class FootageData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000091")]
		public FootageType _type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000092")]
		public string _sourceName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000093")]
		public List<Single> _color; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000094")]
		public string _fileName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000095")]
		public float _duration; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000096")]
		public float _frameDuration; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000097")]
		public int _frameTime; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000098")]
		public float _fps; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000099")]
		public float _width; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400009A")]
		public float _height; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400009B")]
		public string _font; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400009C")]
		public int _size; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400009D")]
		public int _line; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400009E")]
		public string _text; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400009F")]
		public string _textId; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40000A0")]
		public float _textX; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40000A1")]
		public float _textY; //Field offset: 0x6C

		[Address(RVA = "0x5BB4F0", Offset = "0x5BA8F0", Length = "0xBB")]
		[Token(Token = "0x6000089")]
		public FootageData() { }

	}

	[Token(Token = "0x2000024")]
	internal enum FootageType : int
	{
		None = 0,
		SolidSource = 1,
		AudioSource = 2,
		PictureSource = 3,
		TextSource = 4,
	}

	[Token(Token = "0x200001E")]
	internal class GlobalColorData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A7")]
		public float _overlayR; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000A8")]
		public float _overlayG; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A9")]
		public float _overlayB; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000AA")]
		public float _overlayA; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000AB")]
		public float _multiplyR; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000AC")]
		public float _multiplyG; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000AD")]
		public float _multiplyB; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40000AE")]
		public float _multiplyA; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000AF")]
		public float _opacity; //Field offset: 0x30

		[Address(RVA = "0x5BB5B0", Offset = "0x5BA9B0", Length = "0x2A")]
		[Token(Token = "0x600008C")]
		public GlobalColorData() { }

	}

	[Token(Token = "0x2000019")]
	internal class LayerData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007A")]
		public string _id; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400007B")]
		public string _uniqueId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400007C")]
		public FootageData _footage; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400007D")]
		public int _compositionId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400007E")]
		public AVLayerPropertiesData _properties; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400007F")]
		public int _parentCompositionId; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000080")]
		public int _layerIndex; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000081")]
		public int _parentIndex; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000082")]
		public string _name; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000083")]
		public float _width; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000084")]
		public float _height; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000085")]
		public AVLayerBlendingMode _blendMode; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000086")]
		public string _metaData; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000087")]
		public float _inSeconds; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000088")]
		public float _outSeconds; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000089")]
		public bool _isNullLayer; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400008A")]
		public List<TimeRemapData> _timeRemap; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400008B")]
		public bool _enable; //Field offset: 0x80

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000086")]
		public LayerData() { }

	}

	[Token(Token = "0x200002B")]
	internal class LayerPropertyData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000130")]
		public List<LayerPropertyElementData`1<T>> _elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000131")]
		public List<Int32> _markedKeyFrames; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000132")]
		public AVLayerExpressionData _expression; //Field offset: 0x0

		[Address(RVA = "0xAFA0B0", Offset = "0xAF94B0", Length = "0xD6")]
		[Token(Token = "0x600009E")]
		public LayerPropertyData`1() { }

		[Address(RVA = "0xAF8550", Offset = "0xAF7950", Length = "0x310")]
		[Token(Token = "0x600009D")]
		private T Convert(object target) { }

		[Address(RVA = "0xAF8C20", Offset = "0xAF8020", Length = "0x122")]
		[Token(Token = "0x600009B")]
		public int GetEndKeyFrame() { }

		[Address(RVA = "0xAF8D50", Offset = "0xAF8150", Length = "0x1C")]
		[Token(Token = "0x6000099")]
		public int GetMaxFrame() { }

		[Address(RVA = "0xAF8DB0", Offset = "0xAF81B0", Length = "0x122")]
		[Token(Token = "0x600009A")]
		public int GetStartKeyFrame() { }

		[Address(RVA = "0xAF9010", Offset = "0xAF8410", Length = "0x7F0")]
		[Token(Token = "0x600009C")]
		public LayerPropertyData<T> Parse(JArray rawData) { }

	}

	[Token(Token = "0x200002D")]
	internal class LayerPropertyElementData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000135")]
		public int _frame; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000136")]
		public List<T> _args; //Field offset: 0x0

		[Address(RVA = "0xAFA2F0", Offset = "0xAF96F0", Length = "0x7F")]
		[Token(Token = "0x60000A0")]
		public LayerPropertyElementData`1() { }

	}

	[Token(Token = "0x200002E")]
	internal class LayerShapeBezierData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000137")]
		public List<Single> origin; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000138")]
		public List<Single> inOffset; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000139")]
		public List<Single> outOffset; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000A1")]
		public LayerShapeBezierData() { }

	}

	[Token(Token = "0x200002A")]
	internal class LayerShapePropertyData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012D")]
		public List<LayerShapePropertyElementData> _points; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012E")]
		public List<Int32> _markedKeyFrames; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012F")]
		public AVLayerExpressionData _expression; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000098")]
		public LayerShapePropertyData() { }

		[Address(RVA = "0x5BB5E0", Offset = "0x5BA9E0", Length = "0x122")]
		[Token(Token = "0x6000096")]
		public int GetEndKeyFrame() { }

		[Address(RVA = "0x5BB710", Offset = "0x5BAB10", Length = "0x3E")]
		[Token(Token = "0x6000094")]
		public int GetMaxFrame() { }

		[Address(RVA = "0x5BB750", Offset = "0x5BAB50", Length = "0x122")]
		[Token(Token = "0x6000095")]
		public int GetStartKeyFrame() { }

		[Address(RVA = "0x5BB880", Offset = "0x5BAC80", Length = "0xD95")]
		[Token(Token = "0x6000097")]
		public LayerShapePropertyData Parse(JArray rawData) { }

	}

	[Token(Token = "0x200002C")]
	internal class LayerShapePropertyElementData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000133")]
		public int _frame; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000134")]
		public List<LayerShapeBezierData> _args; //Field offset: 0x18

		[Address(RVA = "0x5BC620", Offset = "0x5BBA20", Length = "0x77")]
		[Token(Token = "0x600009F")]
		public LayerShapePropertyElementData() { }

	}

	[Token(Token = "0x200001A")]
	internal class MarkerData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008C")]
		public string _label; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008D")]
		public float _start; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400008E")]
		public float _duration; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000087")]
		public MarkerData() { }

	}

	[Token(Token = "0x200001B")]
	internal class MetaData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008F")]
		public string _versionString; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000090")]
		public float _fps; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000088")]
		public MetaData() { }

	}

	[Token(Token = "0x2000023")]
	internal class TimeRemapData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BF")]
		public float _keyTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000C0")]
		public float _srcTime; //Field offset: 0x14

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000093")]
		public TimeRemapData() { }

	}

	[Token(Token = "0x4000069")]
	public const string _version = "v2.0.7"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006A")]
	public int _mainCompositionId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006B")]
	public List<CompositionData> _allCompositions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006C")]
	public List<LayerData> _allLayers; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400006D")]
	public MetaData _metaData; //Field offset: 0x30

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000084")]
	public AEData() { }

	[Address(RVA = "0x5B3840", Offset = "0x5B2C40", Length = "0x145")]
	[Token(Token = "0x6000082")]
	public CompositionData GetComposition(int id) { }

	[Address(RVA = "0x5B3990", Offset = "0x5B2D90", Length = "0x153")]
	[Token(Token = "0x6000083")]
	public LayerData GetLayer(string id) { }

}

