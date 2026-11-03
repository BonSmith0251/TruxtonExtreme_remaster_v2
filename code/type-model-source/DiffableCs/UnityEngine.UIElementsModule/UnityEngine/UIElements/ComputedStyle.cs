namespace UnityEngine.UIElements;

[Token(Token = "0x20002F8")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct ComputedStyle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C02")]
	public StyleDataRef<InheritedData> inheritedData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C03")]
	public StyleDataRef<LayoutData> layoutData; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C04")]
	public StyleDataRef<RareData> rareData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C05")]
	public StyleDataRef<TransformData> transformData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C06")]
	public StyleDataRef<TransitionData> transitionData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C07")]
	public StyleDataRef<VisualData> visualData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C08")]
	public Dictionary<String, StylePropertyValue> customProperties; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C09")]
	public long matchingRulesHash; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C0A")]
	public float dpiScaling; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C0B")]
	public ComputedTransitionProperty[] computedTransitions; //Field offset: 0x48

	[Token(Token = "0x1700040E")]
	public Align alignContent
	{
		[Address(RVA = "0x342A200", Offset = "0x3429600", Length = "0x3D")]
		[Token(Token = "0x60014B7")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700040F")]
	public Align alignItems
	{
		[Address(RVA = "0x342A240", Offset = "0x3429640", Length = "0x3E")]
		[Token(Token = "0x60014B8")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000410")]
	public Align alignSelf
	{
		[Address(RVA = "0x342A280", Offset = "0x3429680", Length = "0x3E")]
		[Token(Token = "0x60014B9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000411")]
	public Ratio aspectRatio
	{
		[Address(RVA = "0x342A2C0", Offset = "0x34296C0", Length = "0x3E")]
		[Token(Token = "0x60014BA")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000412")]
	public Color backgroundColor
	{
		[Address(RVA = "0x342A300", Offset = "0x3429700", Length = "0x50")]
		[Token(Token = "0x60014BB")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000413")]
	public Background backgroundImage
	{
		[Address(RVA = "0x342A350", Offset = "0x3429750", Length = "0x59")]
		[Token(Token = "0x60014BC")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000414")]
	public BackgroundPosition backgroundPositionX
	{
		[Address(RVA = "0x342A3B0", Offset = "0x34297B0", Length = "0x59")]
		[Token(Token = "0x60014BD")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000415")]
	public BackgroundPosition backgroundPositionY
	{
		[Address(RVA = "0x342A410", Offset = "0x3429810", Length = "0x59")]
		[Token(Token = "0x60014BE")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000416")]
	public BackgroundRepeat backgroundRepeat
	{
		[Address(RVA = "0x342A470", Offset = "0x3429870", Length = "0x3F")]
		[Token(Token = "0x60014BF")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000417")]
	public BackgroundSize backgroundSize
	{
		[Address(RVA = "0x342A4B0", Offset = "0x34298B0", Length = "0x57")]
		[Token(Token = "0x60014C0")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000418")]
	public Color borderBottomColor
	{
		[Address(RVA = "0x342A510", Offset = "0x3429910", Length = "0x51")]
		[Token(Token = "0x60014C1")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000419")]
	public Length borderBottomLeftRadius
	{
		[Address(RVA = "0x342A570", Offset = "0x3429970", Length = "0x3F")]
		[Token(Token = "0x60014C2")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700041A")]
	public Length borderBottomRightRadius
	{
		[Address(RVA = "0x342A5B0", Offset = "0x34299B0", Length = "0x3F")]
		[Token(Token = "0x60014C3")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700041B")]
	public float borderBottomWidth
	{
		[Address(RVA = "0x342A5F0", Offset = "0x34299F0", Length = "0x40")]
		[Token(Token = "0x60014C4")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700041C")]
	public Color borderLeftColor
	{
		[Address(RVA = "0x342A630", Offset = "0x3429A30", Length = "0x54")]
		[Token(Token = "0x60014C5")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700041D")]
	public float borderLeftWidth
	{
		[Address(RVA = "0x342A690", Offset = "0x3429A90", Length = "0x40")]
		[Token(Token = "0x60014C6")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700041E")]
	public Color borderRightColor
	{
		[Address(RVA = "0x342A6D0", Offset = "0x3429AD0", Length = "0x54")]
		[Token(Token = "0x60014C7")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700041F")]
	public float borderRightWidth
	{
		[Address(RVA = "0x342A730", Offset = "0x3429B30", Length = "0x40")]
		[Token(Token = "0x60014C8")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000420")]
	public Color borderTopColor
	{
		[Address(RVA = "0x342A770", Offset = "0x3429B70", Length = "0x54")]
		[Token(Token = "0x60014C9")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000421")]
	public Length borderTopLeftRadius
	{
		[Address(RVA = "0x342A7D0", Offset = "0x3429BD0", Length = "0x42")]
		[Token(Token = "0x60014CA")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000422")]
	public Length borderTopRightRadius
	{
		[Address(RVA = "0x342A820", Offset = "0x3429C20", Length = "0x42")]
		[Token(Token = "0x60014CB")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000423")]
	public float borderTopWidth
	{
		[Address(RVA = "0x342A870", Offset = "0x3429C70", Length = "0x40")]
		[Token(Token = "0x60014CC")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000424")]
	public Length bottom
	{
		[Address(RVA = "0x342A8B0", Offset = "0x3429CB0", Length = "0x3F")]
		[Token(Token = "0x60014CD")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000425")]
	public Color color
	{
		[Address(RVA = "0x342A8F0", Offset = "0x3429CF0", Length = "0x4F")]
		[Token(Token = "0x60014CE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000426")]
	public Cursor cursor
	{
		[Address(RVA = "0x342A940", Offset = "0x3429D40", Length = "0x5A")]
		[Token(Token = "0x60014CF")]
		 get { } //Length: 90
	}

	[Token(Token = "0x1700040C")]
	public int customPropertiesCount
	{
		[Address(RVA = "0x342A9A0", Offset = "0x3429DA0", Length = "0x47")]
		[Token(Token = "0x60014A6")]
		 get { } //Length: 71
	}

	[Token(Token = "0x17000427")]
	public DisplayStyle display
	{
		[Address(RVA = "0x342A9F0", Offset = "0x3429DF0", Length = "0x3E")]
		[Token(Token = "0x60014D0")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000428")]
	public List<FilterFunction> filter
	{
		[Address(RVA = "0x342AA30", Offset = "0x3429E30", Length = "0x42")]
		[Token(Token = "0x60014D1")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000429")]
	public Length flexBasis
	{
		[Address(RVA = "0x342AA80", Offset = "0x3429E80", Length = "0x3F")]
		[Token(Token = "0x60014D2")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700042A")]
	public FlexDirection flexDirection
	{
		[Address(RVA = "0x342AAC0", Offset = "0x3429EC0", Length = "0x3E")]
		[Token(Token = "0x60014D3")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700042B")]
	public float flexGrow
	{
		[Address(RVA = "0x342AB00", Offset = "0x3429F00", Length = "0x40")]
		[Token(Token = "0x60014D4")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700042C")]
	public float flexShrink
	{
		[Address(RVA = "0x342AB40", Offset = "0x3429F40", Length = "0x40")]
		[Token(Token = "0x60014D5")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700042D")]
	public Wrap flexWrap
	{
		[Address(RVA = "0x342AB80", Offset = "0x3429F80", Length = "0x3E")]
		[Token(Token = "0x60014D6")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700042E")]
	public Length fontSize
	{
		[Address(RVA = "0x342ABC0", Offset = "0x3429FC0", Length = "0x3E")]
		[Token(Token = "0x60014D7")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700040D")]
	public bool hasTransition
	{
		[Address(RVA = "0x342AC00", Offset = "0x342A000", Length = "0x12")]
		[Token(Token = "0x60014A7")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700042F")]
	public Length height
	{
		[Address(RVA = "0x342AC20", Offset = "0x342A020", Length = "0x3F")]
		[Token(Token = "0x60014D8")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000430")]
	public Justify justifyContent
	{
		[Address(RVA = "0x342AC60", Offset = "0x342A060", Length = "0x3E")]
		[Token(Token = "0x60014D9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000431")]
	public Length left
	{
		[Address(RVA = "0x342ACA0", Offset = "0x342A0A0", Length = "0x3F")]
		[Token(Token = "0x60014DA")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000432")]
	public Length letterSpacing
	{
		[Address(RVA = "0x342ACE0", Offset = "0x342A0E0", Length = "0x3E")]
		[Token(Token = "0x60014DB")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000433")]
	public Length marginBottom
	{
		[Address(RVA = "0x342AD20", Offset = "0x342A120", Length = "0x3F")]
		[Token(Token = "0x60014DC")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000434")]
	public Length marginLeft
	{
		[Address(RVA = "0x342AD60", Offset = "0x342A160", Length = "0x3F")]
		[Token(Token = "0x60014DD")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000435")]
	public Length marginRight
	{
		[Address(RVA = "0x342ADA0", Offset = "0x342A1A0", Length = "0x3F")]
		[Token(Token = "0x60014DE")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000436")]
	public Length marginTop
	{
		[Address(RVA = "0x342ADE0", Offset = "0x342A1E0", Length = "0x3F")]
		[Token(Token = "0x60014DF")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000437")]
	public Length maxHeight
	{
		[Address(RVA = "0x342AE20", Offset = "0x342A220", Length = "0x3F")]
		[Token(Token = "0x60014E0")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000438")]
	public Length maxWidth
	{
		[Address(RVA = "0x342AE60", Offset = "0x342A260", Length = "0x42")]
		[Token(Token = "0x60014E1")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000439")]
	public Length minHeight
	{
		[Address(RVA = "0x342AEB0", Offset = "0x342A2B0", Length = "0x42")]
		[Token(Token = "0x60014E2")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700043A")]
	public Length minWidth
	{
		[Address(RVA = "0x342AF00", Offset = "0x342A300", Length = "0x42")]
		[Token(Token = "0x60014E3")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700043B")]
	public float opacity
	{
		[Address(RVA = "0x342AF50", Offset = "0x342A350", Length = "0x43")]
		[Token(Token = "0x60014E4")]
		 get { } //Length: 67
	}

	[Token(Token = "0x1700043C")]
	public OverflowInternal overflow
	{
		[Address(RVA = "0x342AFA0", Offset = "0x342A3A0", Length = "0x41")]
		[Token(Token = "0x60014E5")]
		 get { } //Length: 65
	}

	[Token(Token = "0x1700043D")]
	public Length paddingBottom
	{
		[Address(RVA = "0x342AFF0", Offset = "0x342A3F0", Length = "0x42")]
		[Token(Token = "0x60014E6")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700043E")]
	public Length paddingLeft
	{
		[Address(RVA = "0x342B040", Offset = "0x342A440", Length = "0x42")]
		[Token(Token = "0x60014E7")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700043F")]
	public Length paddingRight
	{
		[Address(RVA = "0x342B090", Offset = "0x342A490", Length = "0x42")]
		[Token(Token = "0x60014E8")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000440")]
	public Length paddingTop
	{
		[Address(RVA = "0x342B0E0", Offset = "0x342A4E0", Length = "0x42")]
		[Token(Token = "0x60014E9")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000441")]
	public Position position
	{
		[Address(RVA = "0x342B130", Offset = "0x342A530", Length = "0x41")]
		[Token(Token = "0x60014EA")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000442")]
	public Length right
	{
		[Address(RVA = "0x342B180", Offset = "0x342A580", Length = "0x42")]
		[Token(Token = "0x60014EB")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000443")]
	public Rotate rotate
	{
		[Address(RVA = "0x342B1D0", Offset = "0x342A5D0", Length = "0x5A")]
		[Token(Token = "0x60014EC")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000444")]
	public Scale scale
	{
		[Address(RVA = "0x342B230", Offset = "0x342A630", Length = "0x51")]
		[Token(Token = "0x60014ED")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000445")]
	public TextOverflow textOverflow
	{
		[Address(RVA = "0x342B290", Offset = "0x342A690", Length = "0x3E")]
		[Token(Token = "0x60014EE")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000446")]
	public TextShadow textShadow
	{
		[Address(RVA = "0x342B2D0", Offset = "0x342A6D0", Length = "0x60")]
		[Token(Token = "0x60014EF")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000447")]
	public Length top
	{
		[Address(RVA = "0x342B330", Offset = "0x342A730", Length = "0x42")]
		[Token(Token = "0x60014F0")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000448")]
	public TransformOrigin transformOrigin
	{
		[Address(RVA = "0x342B380", Offset = "0x342A780", Length = "0x57")]
		[Token(Token = "0x60014F1")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000449")]
	public List<TimeValue> transitionDelay
	{
		[Address(RVA = "0x342B3E0", Offset = "0x342A7E0", Length = "0x3E")]
		[Token(Token = "0x60014F2")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700044A")]
	public List<TimeValue> transitionDuration
	{
		[Address(RVA = "0x342B420", Offset = "0x342A820", Length = "0x3F")]
		[Token(Token = "0x60014F3")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700044B")]
	public List<StylePropertyName> transitionProperty
	{
		[Address(RVA = "0x342B460", Offset = "0x342A860", Length = "0x3F")]
		[Token(Token = "0x60014F4")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700044C")]
	public List<EasingFunction> transitionTimingFunction
	{
		[Address(RVA = "0x342B4A0", Offset = "0x342A8A0", Length = "0x3F")]
		[Token(Token = "0x60014F5")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700044D")]
	public Translate translate
	{
		[Address(RVA = "0x342B4E0", Offset = "0x342A8E0", Length = "0x5B")]
		[Token(Token = "0x60014F6")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700044E")]
	public Color unityBackgroundImageTintColor
	{
		[Address(RVA = "0x342B540", Offset = "0x342A940", Length = "0x51")]
		[Token(Token = "0x60014F7")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700044F")]
	public EditorTextRenderingMode unityEditorTextRenderingMode
	{
		[Address(RVA = "0x342B5A0", Offset = "0x342A9A0", Length = "0x3D")]
		[Token(Token = "0x60014F8")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000450")]
	public Font unityFont
	{
		[Address(RVA = "0x342B670", Offset = "0x342AA70", Length = "0x3E")]
		[Token(Token = "0x60014F9")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000451")]
	public FontDefinition unityFontDefinition
	{
		[Address(RVA = "0x342B5E0", Offset = "0x342A9E0", Length = "0x50")]
		[Token(Token = "0x60014FA")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000452")]
	public FontStyle unityFontStyleAndWeight
	{
		[Address(RVA = "0x342B630", Offset = "0x342AA30", Length = "0x3D")]
		[Token(Token = "0x60014FB")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000453")]
	public MaterialDefinition unityMaterial
	{
		[Address(RVA = "0x342B6B0", Offset = "0x342AAB0", Length = "0x50")]
		[Token(Token = "0x60014FC")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000454")]
	public OverflowClipBox unityOverflowClipBox
	{
		[Address(RVA = "0x342B700", Offset = "0x342AB00", Length = "0x3E")]
		[Token(Token = "0x60014FD")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000455")]
	public Length unityParagraphSpacing
	{
		[Address(RVA = "0x342B740", Offset = "0x342AB40", Length = "0x3E")]
		[Token(Token = "0x60014FE")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000456")]
	public int unitySliceBottom
	{
		[Address(RVA = "0x342B780", Offset = "0x342AB80", Length = "0x3E")]
		[Token(Token = "0x60014FF")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000457")]
	public int unitySliceLeft
	{
		[Address(RVA = "0x342B7C0", Offset = "0x342ABC0", Length = "0x3E")]
		[Token(Token = "0x6001500")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000458")]
	public int unitySliceRight
	{
		[Address(RVA = "0x342B800", Offset = "0x342AC00", Length = "0x3E")]
		[Token(Token = "0x6001501")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000459")]
	public float unitySliceScale
	{
		[Address(RVA = "0x342B840", Offset = "0x342AC40", Length = "0x40")]
		[Token(Token = "0x6001502")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700045A")]
	public int unitySliceTop
	{
		[Address(RVA = "0x342B880", Offset = "0x342AC80", Length = "0x3E")]
		[Token(Token = "0x6001503")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700045B")]
	public SliceType unitySliceType
	{
		[Address(RVA = "0x342B8C0", Offset = "0x342ACC0", Length = "0x3E")]
		[Token(Token = "0x6001504")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700045C")]
	public TextAnchor unityTextAlign
	{
		[Address(RVA = "0x342B900", Offset = "0x342AD00", Length = "0x3D")]
		[Token(Token = "0x6001505")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700045D")]
	public TextAutoSize unityTextAutoSize
	{
		[Address(RVA = "0x342B940", Offset = "0x342AD40", Length = "0x59")]
		[Token(Token = "0x6001506")]
		 get { } //Length: 89
	}

	[Token(Token = "0x1700045E")]
	public TextGeneratorType unityTextGenerator
	{
		[Address(RVA = "0x342B9A0", Offset = "0x342ADA0", Length = "0x40")]
		[Token(Token = "0x6001507")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700045F")]
	public Color unityTextOutlineColor
	{
		[Address(RVA = "0x342B9E0", Offset = "0x342ADE0", Length = "0x53")]
		[Token(Token = "0x6001508")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000460")]
	public float unityTextOutlineWidth
	{
		[Address(RVA = "0x342BA40", Offset = "0x342AE40", Length = "0x42")]
		[Token(Token = "0x6001509")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000461")]
	public TextOverflowPosition unityTextOverflowPosition
	{
		[Address(RVA = "0x342BA90", Offset = "0x342AE90", Length = "0x3E")]
		[Token(Token = "0x600150A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000462")]
	public Visibility visibility
	{
		[Address(RVA = "0x342BAD0", Offset = "0x342AED0", Length = "0x40")]
		[Token(Token = "0x600150B")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000463")]
	public WhiteSpace whiteSpace
	{
		[Address(RVA = "0x342BB10", Offset = "0x342AF10", Length = "0x40")]
		[Token(Token = "0x600150C")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000464")]
	public Length width
	{
		[Address(RVA = "0x342BB50", Offset = "0x342AF50", Length = "0x42")]
		[Token(Token = "0x600150D")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000465")]
	public Length wordSpacing
	{
		[Address(RVA = "0x342BBA0", Offset = "0x342AFA0", Length = "0x41")]
		[Token(Token = "0x600150E")]
		 get { } //Length: 65
	}

	[Address(RVA = "0x34127F0", Offset = "0x3411BF0", Length = "0x111")]
	[Token(Token = "0x6001511")]
	public ComputedStyle Acquire() { }

	[Address(RVA = "0x3412910", Offset = "0x3411D10", Length = "0x54")]
	[Token(Token = "0x60014AE")]
	private void ApplyAllPropertyInitial() { }

	[Address(RVA = "0x3412970", Offset = "0x3411D70", Length = "0x105")]
	[Token(Token = "0x60014AC")]
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	[Address(RVA = "0x3412A80", Offset = "0x3411E80", Length = "0x868")]
	[Token(Token = "0x600151A")]
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	[Address(RVA = "0x34143B0", Offset = "0x34137B0", Length = "0xBC")]
	[Token(Token = "0x60014A9")]
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x3414470", Offset = "0x3413870", Length = "0x20")]
	[Token(Token = "0x60014AA")]
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x34145B0", Offset = "0x34139B0", Length = "0x2078")]
	[Token(Token = "0x6001537")]
	public void ApplyInitialValue(StylePropertyId id) { }

	[Address(RVA = "0x3414490", Offset = "0x3413890", Length = "0x119")]
	[Token(Token = "0x6001536")]
	public void ApplyInitialValue(StylePropertyReader reader) { }

	[Address(RVA = "0x34167A0", Offset = "0x3415BA0", Length = "0x1874")]
	[Token(Token = "0x6001514")]
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x3418BC0", Offset = "0x3417FC0", Length = "0x80C")]
	[Token(Token = "0x600151B")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	[Address(RVA = "0x3418590", Offset = "0x3417990", Length = "0x368")]
	[Token(Token = "0x600151C")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	[Address(RVA = "0x3419F90", Offset = "0x3419390", Length = "0x167")]
	[Token(Token = "0x600151F")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	[Address(RVA = "0x3418A70", Offset = "0x3417E70", Length = "0x141")]
	[Token(Token = "0x6001520")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	[Address(RVA = "0x3419E50", Offset = "0x3419250", Length = "0x13B")]
	[Token(Token = "0x600152A")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	[Address(RVA = "0x341A900", Offset = "0x3419D00", Length = "0xD4")]
	[Token(Token = "0x6001521")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	[Address(RVA = "0x341A250", Offset = "0x3419650", Length = "0x1AD")]
	[Token(Token = "0x6001522")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	[Address(RVA = "0x3418920", Offset = "0x3417D20", Length = "0x145")]
	[Token(Token = "0x600152B")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, MaterialDefinition newValue) { }

	[Address(RVA = "0x341A620", Offset = "0x3419A20", Length = "0x18B")]
	[Token(Token = "0x6001525")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	[Address(RVA = "0x3418440", Offset = "0x3417840", Length = "0x14A")]
	[Token(Token = "0x6001523")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, List<FilterFunction> newValue) { }

	[Address(RVA = "0x3419450", Offset = "0x3418850", Length = "0x199")]
	[Token(Token = "0x6001524")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	[Address(RVA = "0x34195F0", Offset = "0x34189F0", Length = "0x6E4")]
	[Token(Token = "0x600151D")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	[Address(RVA = "0x341A7B0", Offset = "0x3419BB0", Length = "0x14A")]
	[Token(Token = "0x6001526")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	[Address(RVA = "0x3419D00", Offset = "0x3419100", Length = "0x145")]
	[Token(Token = "0x6001527")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	[Address(RVA = "0x341A100", Offset = "0x3419500", Length = "0x141")]
	[Token(Token = "0x6001528")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	[Address(RVA = "0x34182F0", Offset = "0x34176F0", Length = "0x144")]
	[Token(Token = "0x6001529")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	[Address(RVA = "0x3418180", Offset = "0x3417580", Length = "0x161")]
	[Token(Token = "0x600152C")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Ratio newValue) { }

	[Address(RVA = "0x341A400", Offset = "0x3419800", Length = "0x21B")]
	[Token(Token = "0x600151E")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	[Address(RVA = "0x341ABB0", Offset = "0x3419FB0", Length = "0x54")]
	[Token(Token = "0x6001534")]
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	[Address(RVA = "0x341AC10", Offset = "0x341A010", Length = "0x60")]
	[Token(Token = "0x6001517")]
	public void ApplyStyleCursor(Cursor cursor) { }

	[Address(RVA = "0x341AC70", Offset = "0x341A070", Length = "0x5C")]
	[Token(Token = "0x6001535")]
	public void ApplyStyleFilter(List<FilterFunction> st) { }

	[Address(RVA = "0x341ACD0", Offset = "0x341A0D0", Length = "0x57")]
	[Token(Token = "0x6001532")]
	public void ApplyStyleRotate(Rotate rotateValue) { }

	[Address(RVA = "0x341AD30", Offset = "0x341A130", Length = "0x4E")]
	[Token(Token = "0x6001533")]
	public void ApplyStyleScale(Scale scaleValue) { }

	[Address(RVA = "0x341AD80", Offset = "0x341A180", Length = "0x56")]
	[Token(Token = "0x6001519")]
	public void ApplyStyleTextAutoSize(TextAutoSize st) { }

	[Address(RVA = "0x341ADE0", Offset = "0x341A1E0", Length = "0x5D")]
	[Token(Token = "0x6001518")]
	public void ApplyStyleTextShadow(TextShadow st) { }

	[Address(RVA = "0x341AE40", Offset = "0x341A240", Length = "0x54")]
	[Token(Token = "0x6001530")]
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	[Address(RVA = "0x341AEA0", Offset = "0x341A2A0", Length = "0x58")]
	[Token(Token = "0x6001531")]
	public void ApplyStyleTranslate(Translate translateValue) { }

	[Address(RVA = "0x341B590", Offset = "0x341A990", Length = "0xD90")]
	[Token(Token = "0x6001515")]
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x341AF00", Offset = "0x341A300", Length = "0x682")]
	[Token(Token = "0x6001516")]
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x341C460", Offset = "0x341B860", Length = "0xB5")]
	[Token(Token = "0x6001538")]
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x341C520", Offset = "0x341B920", Length = "0x504")]
	[Token(Token = "0x6001539")]
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x7A7E40", Offset = "0x7A7240", Length = "0x19B")]
	[Token(Token = "0x60014AD")]
	private static bool AreListPropertiesEqual(List<T> a, List<T> b) { }

	[Address(RVA = "0x341CA70", Offset = "0x341BE70", Length = "0x1D7A")]
	[Token(Token = "0x600153A")]
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }

	[Address(RVA = "0x341E7F0", Offset = "0x341DBF0", Length = "0x118")]
	[Token(Token = "0x6001513")]
	public void CopyFrom(ref ComputedStyle other) { }

	[Address(RVA = "0x341EAA0", Offset = "0x341DEA0", Length = "0x1F4")]
	[Token(Token = "0x600150F")]
	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x341E910", Offset = "0x341DD10", Length = "0x186")]
	[Token(Token = "0x6001510")]
	public static ComputedStyle CreateInitial() { }

	[Address(RVA = "0x341ECA0", Offset = "0x341E0A0", Length = "0x12E")]
	[Token(Token = "0x60014A8")]
	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	[Address(RVA = "0x342A200", Offset = "0x3429600", Length = "0x3D")]
	[Token(Token = "0x60014B7")]
	public Align get_alignContent() { }

	[Address(RVA = "0x342A240", Offset = "0x3429640", Length = "0x3E")]
	[Token(Token = "0x60014B8")]
	public Align get_alignItems() { }

	[Address(RVA = "0x342A280", Offset = "0x3429680", Length = "0x3E")]
	[Token(Token = "0x60014B9")]
	public Align get_alignSelf() { }

	[Address(RVA = "0x342A2C0", Offset = "0x34296C0", Length = "0x3E")]
	[Token(Token = "0x60014BA")]
	public Ratio get_aspectRatio() { }

	[Address(RVA = "0x342A300", Offset = "0x3429700", Length = "0x50")]
	[Token(Token = "0x60014BB")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x342A350", Offset = "0x3429750", Length = "0x59")]
	[Token(Token = "0x60014BC")]
	public Background get_backgroundImage() { }

	[Address(RVA = "0x342A3B0", Offset = "0x34297B0", Length = "0x59")]
	[Token(Token = "0x60014BD")]
	public BackgroundPosition get_backgroundPositionX() { }

	[Address(RVA = "0x342A410", Offset = "0x3429810", Length = "0x59")]
	[Token(Token = "0x60014BE")]
	public BackgroundPosition get_backgroundPositionY() { }

	[Address(RVA = "0x342A470", Offset = "0x3429870", Length = "0x3F")]
	[Token(Token = "0x60014BF")]
	public BackgroundRepeat get_backgroundRepeat() { }

	[Address(RVA = "0x342A4B0", Offset = "0x34298B0", Length = "0x57")]
	[Token(Token = "0x60014C0")]
	public BackgroundSize get_backgroundSize() { }

	[Address(RVA = "0x342A510", Offset = "0x3429910", Length = "0x51")]
	[Token(Token = "0x60014C1")]
	public Color get_borderBottomColor() { }

	[Address(RVA = "0x342A570", Offset = "0x3429970", Length = "0x3F")]
	[Token(Token = "0x60014C2")]
	public Length get_borderBottomLeftRadius() { }

	[Address(RVA = "0x342A5B0", Offset = "0x34299B0", Length = "0x3F")]
	[Token(Token = "0x60014C3")]
	public Length get_borderBottomRightRadius() { }

	[Address(RVA = "0x342A5F0", Offset = "0x34299F0", Length = "0x40")]
	[Token(Token = "0x60014C4")]
	public float get_borderBottomWidth() { }

	[Address(RVA = "0x342A630", Offset = "0x3429A30", Length = "0x54")]
	[Token(Token = "0x60014C5")]
	public Color get_borderLeftColor() { }

	[Address(RVA = "0x342A690", Offset = "0x3429A90", Length = "0x40")]
	[Token(Token = "0x60014C6")]
	public float get_borderLeftWidth() { }

	[Address(RVA = "0x342A6D0", Offset = "0x3429AD0", Length = "0x54")]
	[Token(Token = "0x60014C7")]
	public Color get_borderRightColor() { }

	[Address(RVA = "0x342A730", Offset = "0x3429B30", Length = "0x40")]
	[Token(Token = "0x60014C8")]
	public float get_borderRightWidth() { }

	[Address(RVA = "0x342A770", Offset = "0x3429B70", Length = "0x54")]
	[Token(Token = "0x60014C9")]
	public Color get_borderTopColor() { }

	[Address(RVA = "0x342A7D0", Offset = "0x3429BD0", Length = "0x42")]
	[Token(Token = "0x60014CA")]
	public Length get_borderTopLeftRadius() { }

	[Address(RVA = "0x342A820", Offset = "0x3429C20", Length = "0x42")]
	[Token(Token = "0x60014CB")]
	public Length get_borderTopRightRadius() { }

	[Address(RVA = "0x342A870", Offset = "0x3429C70", Length = "0x40")]
	[Token(Token = "0x60014CC")]
	public float get_borderTopWidth() { }

	[Address(RVA = "0x342A8B0", Offset = "0x3429CB0", Length = "0x3F")]
	[Token(Token = "0x60014CD")]
	public Length get_bottom() { }

	[Address(RVA = "0x342A8F0", Offset = "0x3429CF0", Length = "0x4F")]
	[Token(Token = "0x60014CE")]
	public Color get_color() { }

	[Address(RVA = "0x342A940", Offset = "0x3429D40", Length = "0x5A")]
	[Token(Token = "0x60014CF")]
	public Cursor get_cursor() { }

	[Address(RVA = "0x342A9A0", Offset = "0x3429DA0", Length = "0x47")]
	[Token(Token = "0x60014A6")]
	public int get_customPropertiesCount() { }

	[Address(RVA = "0x342A9F0", Offset = "0x3429DF0", Length = "0x3E")]
	[Token(Token = "0x60014D0")]
	public DisplayStyle get_display() { }

	[Address(RVA = "0x342AA30", Offset = "0x3429E30", Length = "0x42")]
	[Token(Token = "0x60014D1")]
	public List<FilterFunction> get_filter() { }

	[Address(RVA = "0x342AA80", Offset = "0x3429E80", Length = "0x3F")]
	[Token(Token = "0x60014D2")]
	public Length get_flexBasis() { }

	[Address(RVA = "0x342AAC0", Offset = "0x3429EC0", Length = "0x3E")]
	[Token(Token = "0x60014D3")]
	public FlexDirection get_flexDirection() { }

	[Address(RVA = "0x342AB00", Offset = "0x3429F00", Length = "0x40")]
	[Token(Token = "0x60014D4")]
	public float get_flexGrow() { }

	[Address(RVA = "0x342AB40", Offset = "0x3429F40", Length = "0x40")]
	[Token(Token = "0x60014D5")]
	public float get_flexShrink() { }

	[Address(RVA = "0x342AB80", Offset = "0x3429F80", Length = "0x3E")]
	[Token(Token = "0x60014D6")]
	public Wrap get_flexWrap() { }

	[Address(RVA = "0x342ABC0", Offset = "0x3429FC0", Length = "0x3E")]
	[Token(Token = "0x60014D7")]
	public Length get_fontSize() { }

	[Address(RVA = "0x342AC00", Offset = "0x342A000", Length = "0x12")]
	[Token(Token = "0x60014A7")]
	public bool get_hasTransition() { }

	[Address(RVA = "0x342AC20", Offset = "0x342A020", Length = "0x3F")]
	[Token(Token = "0x60014D8")]
	public Length get_height() { }

	[Address(RVA = "0x342AC60", Offset = "0x342A060", Length = "0x3E")]
	[Token(Token = "0x60014D9")]
	public Justify get_justifyContent() { }

	[Address(RVA = "0x342ACA0", Offset = "0x342A0A0", Length = "0x3F")]
	[Token(Token = "0x60014DA")]
	public Length get_left() { }

	[Address(RVA = "0x342ACE0", Offset = "0x342A0E0", Length = "0x3E")]
	[Token(Token = "0x60014DB")]
	public Length get_letterSpacing() { }

	[Address(RVA = "0x342AD20", Offset = "0x342A120", Length = "0x3F")]
	[Token(Token = "0x60014DC")]
	public Length get_marginBottom() { }

	[Address(RVA = "0x342AD60", Offset = "0x342A160", Length = "0x3F")]
	[Token(Token = "0x60014DD")]
	public Length get_marginLeft() { }

	[Address(RVA = "0x342ADA0", Offset = "0x342A1A0", Length = "0x3F")]
	[Token(Token = "0x60014DE")]
	public Length get_marginRight() { }

	[Address(RVA = "0x342ADE0", Offset = "0x342A1E0", Length = "0x3F")]
	[Token(Token = "0x60014DF")]
	public Length get_marginTop() { }

	[Address(RVA = "0x342AE20", Offset = "0x342A220", Length = "0x3F")]
	[Token(Token = "0x60014E0")]
	public Length get_maxHeight() { }

	[Address(RVA = "0x342AE60", Offset = "0x342A260", Length = "0x42")]
	[Token(Token = "0x60014E1")]
	public Length get_maxWidth() { }

	[Address(RVA = "0x342AEB0", Offset = "0x342A2B0", Length = "0x42")]
	[Token(Token = "0x60014E2")]
	public Length get_minHeight() { }

	[Address(RVA = "0x342AF00", Offset = "0x342A300", Length = "0x42")]
	[Token(Token = "0x60014E3")]
	public Length get_minWidth() { }

	[Address(RVA = "0x342AF50", Offset = "0x342A350", Length = "0x43")]
	[Token(Token = "0x60014E4")]
	public float get_opacity() { }

	[Address(RVA = "0x342AFA0", Offset = "0x342A3A0", Length = "0x41")]
	[Token(Token = "0x60014E5")]
	public OverflowInternal get_overflow() { }

	[Address(RVA = "0x342AFF0", Offset = "0x342A3F0", Length = "0x42")]
	[Token(Token = "0x60014E6")]
	public Length get_paddingBottom() { }

	[Address(RVA = "0x342B040", Offset = "0x342A440", Length = "0x42")]
	[Token(Token = "0x60014E7")]
	public Length get_paddingLeft() { }

	[Address(RVA = "0x342B090", Offset = "0x342A490", Length = "0x42")]
	[Token(Token = "0x60014E8")]
	public Length get_paddingRight() { }

	[Address(RVA = "0x342B0E0", Offset = "0x342A4E0", Length = "0x42")]
	[Token(Token = "0x60014E9")]
	public Length get_paddingTop() { }

	[Address(RVA = "0x342B130", Offset = "0x342A530", Length = "0x41")]
	[Token(Token = "0x60014EA")]
	public Position get_position() { }

	[Address(RVA = "0x342B180", Offset = "0x342A580", Length = "0x42")]
	[Token(Token = "0x60014EB")]
	public Length get_right() { }

	[Address(RVA = "0x342B1D0", Offset = "0x342A5D0", Length = "0x5A")]
	[Token(Token = "0x60014EC")]
	public Rotate get_rotate() { }

	[Address(RVA = "0x342B230", Offset = "0x342A630", Length = "0x51")]
	[Token(Token = "0x60014ED")]
	public Scale get_scale() { }

	[Address(RVA = "0x342B290", Offset = "0x342A690", Length = "0x3E")]
	[Token(Token = "0x60014EE")]
	public TextOverflow get_textOverflow() { }

	[Address(RVA = "0x342B2D0", Offset = "0x342A6D0", Length = "0x60")]
	[Token(Token = "0x60014EF")]
	public TextShadow get_textShadow() { }

	[Address(RVA = "0x342B330", Offset = "0x342A730", Length = "0x42")]
	[Token(Token = "0x60014F0")]
	public Length get_top() { }

	[Address(RVA = "0x342B380", Offset = "0x342A780", Length = "0x57")]
	[Token(Token = "0x60014F1")]
	public TransformOrigin get_transformOrigin() { }

	[Address(RVA = "0x342B3E0", Offset = "0x342A7E0", Length = "0x3E")]
	[Token(Token = "0x60014F2")]
	public List<TimeValue> get_transitionDelay() { }

	[Address(RVA = "0x342B420", Offset = "0x342A820", Length = "0x3F")]
	[Token(Token = "0x60014F3")]
	public List<TimeValue> get_transitionDuration() { }

	[Address(RVA = "0x342B460", Offset = "0x342A860", Length = "0x3F")]
	[Token(Token = "0x60014F4")]
	public List<StylePropertyName> get_transitionProperty() { }

	[Address(RVA = "0x342B4A0", Offset = "0x342A8A0", Length = "0x3F")]
	[Token(Token = "0x60014F5")]
	public List<EasingFunction> get_transitionTimingFunction() { }

	[Address(RVA = "0x342B4E0", Offset = "0x342A8E0", Length = "0x5B")]
	[Token(Token = "0x60014F6")]
	public Translate get_translate() { }

	[Address(RVA = "0x342B540", Offset = "0x342A940", Length = "0x51")]
	[Token(Token = "0x60014F7")]
	public Color get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x342B5A0", Offset = "0x342A9A0", Length = "0x3D")]
	[Token(Token = "0x60014F8")]
	public EditorTextRenderingMode get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x342B670", Offset = "0x342AA70", Length = "0x3E")]
	[Token(Token = "0x60014F9")]
	public Font get_unityFont() { }

	[Address(RVA = "0x342B5E0", Offset = "0x342A9E0", Length = "0x50")]
	[Token(Token = "0x60014FA")]
	public FontDefinition get_unityFontDefinition() { }

	[Address(RVA = "0x342B630", Offset = "0x342AA30", Length = "0x3D")]
	[Token(Token = "0x60014FB")]
	public FontStyle get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x342B6B0", Offset = "0x342AAB0", Length = "0x50")]
	[Token(Token = "0x60014FC")]
	public MaterialDefinition get_unityMaterial() { }

	[Address(RVA = "0x342B700", Offset = "0x342AB00", Length = "0x3E")]
	[Token(Token = "0x60014FD")]
	public OverflowClipBox get_unityOverflowClipBox() { }

	[Address(RVA = "0x342B740", Offset = "0x342AB40", Length = "0x3E")]
	[Token(Token = "0x60014FE")]
	public Length get_unityParagraphSpacing() { }

	[Address(RVA = "0x342B780", Offset = "0x342AB80", Length = "0x3E")]
	[Token(Token = "0x60014FF")]
	public int get_unitySliceBottom() { }

	[Address(RVA = "0x342B7C0", Offset = "0x342ABC0", Length = "0x3E")]
	[Token(Token = "0x6001500")]
	public int get_unitySliceLeft() { }

	[Address(RVA = "0x342B800", Offset = "0x342AC00", Length = "0x3E")]
	[Token(Token = "0x6001501")]
	public int get_unitySliceRight() { }

	[Address(RVA = "0x342B840", Offset = "0x342AC40", Length = "0x40")]
	[Token(Token = "0x6001502")]
	public float get_unitySliceScale() { }

	[Address(RVA = "0x342B880", Offset = "0x342AC80", Length = "0x3E")]
	[Token(Token = "0x6001503")]
	public int get_unitySliceTop() { }

	[Address(RVA = "0x342B8C0", Offset = "0x342ACC0", Length = "0x3E")]
	[Token(Token = "0x6001504")]
	public SliceType get_unitySliceType() { }

	[Address(RVA = "0x342B900", Offset = "0x342AD00", Length = "0x3D")]
	[Token(Token = "0x6001505")]
	public TextAnchor get_unityTextAlign() { }

	[Address(RVA = "0x342B940", Offset = "0x342AD40", Length = "0x59")]
	[Token(Token = "0x6001506")]
	public TextAutoSize get_unityTextAutoSize() { }

	[Address(RVA = "0x342B9A0", Offset = "0x342ADA0", Length = "0x40")]
	[Token(Token = "0x6001507")]
	public TextGeneratorType get_unityTextGenerator() { }

	[Address(RVA = "0x342B9E0", Offset = "0x342ADE0", Length = "0x53")]
	[Token(Token = "0x6001508")]
	public Color get_unityTextOutlineColor() { }

	[Address(RVA = "0x342BA40", Offset = "0x342AE40", Length = "0x42")]
	[Token(Token = "0x6001509")]
	public float get_unityTextOutlineWidth() { }

	[Address(RVA = "0x342BA90", Offset = "0x342AE90", Length = "0x3E")]
	[Token(Token = "0x600150A")]
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	[Address(RVA = "0x342BAD0", Offset = "0x342AED0", Length = "0x40")]
	[Token(Token = "0x600150B")]
	public Visibility get_visibility() { }

	[Address(RVA = "0x342BB10", Offset = "0x342AF10", Length = "0x40")]
	[Token(Token = "0x600150C")]
	public WhiteSpace get_whiteSpace() { }

	[Address(RVA = "0x342BB50", Offset = "0x342AF50", Length = "0x42")]
	[Token(Token = "0x600150D")]
	public Length get_width() { }

	[Address(RVA = "0x342BBA0", Offset = "0x342AFA0", Length = "0x41")]
	[Token(Token = "0x600150E")]
	public Length get_wordSpacing() { }

	[Address(RVA = "0x341EDD0", Offset = "0x341E1D0", Length = "0xC5")]
	[Token(Token = "0x6001512")]
	public void Release() { }

	[Address(RVA = "0x341EEA0", Offset = "0x341E2A0", Length = "0x96")]
	[Token(Token = "0x60014AB")]
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	[Address(RVA = "0x1D3AA60", Offset = "0x1D39E60", Length = "0x13")]
	[Token(Token = "0x60014AF")]
	private void ResetComputedTransitions() { }

	[Address(RVA = "0x34262A0", Offset = "0x34256A0", Length = "0xCC")]
	[Token(Token = "0x600152D")]
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x341EF40", Offset = "0x341E340", Length = "0x318A")]
	[Token(Token = "0x600152E")]
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3422DE0", Offset = "0x34221E0", Length = "0x3384")]
	[Token(Token = "0x600152F")]
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x34220D0", Offset = "0x34214D0", Length = "0x1DA")]
	[Token(Token = "0x60014B5")]
	public static bool StartAnimationInlineBackgroundSize(VisualElement element, ref ComputedStyle computedStyle, StyleBackgroundSize backgroundSize, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x34222B0", Offset = "0x34216B0", Length = "0x138")]
	[Token(Token = "0x60014B6")]
	public static bool StartAnimationInlineFilter(VisualElement element, ref ComputedStyle computedStyle, StyleList<FilterFunction> filter, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x34223F0", Offset = "0x34217F0", Length = "0x22B")]
	[Token(Token = "0x60014B1")]
	public static bool StartAnimationInlineRotate(VisualElement element, ref ComputedStyle computedStyle, StyleRotate rotate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3422620", Offset = "0x3421A20", Length = "0x1EF")]
	[Token(Token = "0x60014B3")]
	public static bool StartAnimationInlineScale(VisualElement element, ref ComputedStyle computedStyle, StyleScale scale, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3422810", Offset = "0x3421C10", Length = "0x18B")]
	[Token(Token = "0x60014B0")]
	public static bool StartAnimationInlineTextShadow(VisualElement element, ref ComputedStyle computedStyle, StyleTextShadow textShadow, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x34229A0", Offset = "0x3421DA0", Length = "0x20F")]
	[Token(Token = "0x60014B4")]
	public static bool StartAnimationInlineTransformOrigin(VisualElement element, ref ComputedStyle computedStyle, StyleTransformOrigin transformOrigin, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3422BB0", Offset = "0x3421FB0", Length = "0x22B")]
	[Token(Token = "0x60014B2")]
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

}

