namespace UnityEngine.UIElements;

[Token(Token = "0x200030A")]
internal class InlineStyleAccess : StyleValueCollection, IStyle
{
	[Token(Token = "0x200030B")]
	public struct InlineRule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C77")]
		public StyleSheet sheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C78")]
		public StyleRule rule; //Field offset: 0x8

	}

	[Token(Token = "0x4000C61")]
	private static StylePropertyReader s_StylePropertyReader; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C62")]
	private List<StyleValueManaged> m_ValuesManaged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C63")]
	private VisualElement <ve>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C64")]
	private bool m_HasInlineCursor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C65")]
	private StyleCursor m_InlineCursor; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C66")]
	private bool m_HasInlineTextShadow; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000C67")]
	private StyleTextShadow m_InlineTextShadow; //Field offset: 0x54
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000C68")]
	private bool m_HasInlineTextAutoSize; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C69")]
	private StyleTextAutoSize m_InlineTextAutoSize; //Field offset: 0x78
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C6A")]
	private bool m_HasInlineTransformOrigin; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000C6B")]
	private StyleTransformOrigin m_InlineTransformOrigin; //Field offset: 0x94
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000C6C")]
	private bool m_HasInlineTranslate; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C6D")]
	private StyleTranslate m_InlineTranslateOperation; //Field offset: 0xB0
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4000C6E")]
	private bool m_HasInlineRotate; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C6F")]
	private StyleRotate m_InlineRotateOperation; //Field offset: 0xD0
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000C70")]
	private bool m_HasInlineScale; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000C71")]
	private StyleScale m_InlineScale; //Field offset: 0xF0
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000C72")]
	private bool m_HasInlineBackgroundSize; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000C73")]
	public StyleBackgroundSize m_InlineBackgroundSize; //Field offset: 0x108
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C74")]
	private bool m_HasInlineFilter; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C75")]
	public StyleList<FilterFunction> m_InlineFilter; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C76")]
	private InlineRule m_InlineRule; //Field offset: 0x138

	[Token(Token = "0x17000477")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignContent
	{
		[Address(RVA = "0x323F450", Offset = "0x323E850", Length = "0x87")]
		[Token(Token = "0x60015B3")]
		private get { } //Length: 135
		[Address(RVA = "0x3241090", Offset = "0x3240490", Length = "0xA7")]
		[Token(Token = "0x60015B4")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000478")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignItems
	{
		[Address(RVA = "0x323F4E0", Offset = "0x323E8E0", Length = "0x87")]
		[Token(Token = "0x60015B5")]
		private get { } //Length: 135
		[Address(RVA = "0x3241140", Offset = "0x3240540", Length = "0xA7")]
		[Token(Token = "0x60015B6")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000479")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.alignSelf
	{
		[Address(RVA = "0x323F570", Offset = "0x323E970", Length = "0x87")]
		[Token(Token = "0x60015B7")]
		private get { } //Length: 135
		[Address(RVA = "0x32411F0", Offset = "0x32405F0", Length = "0xA7")]
		[Token(Token = "0x60015B8")]
		private set { } //Length: 167
	}

	[Token(Token = "0x1700047A")]
	private override StyleRatio UnityEngine.UIElements.IStyle.aspectRatio
	{
		[Address(RVA = "0x323F600", Offset = "0x323EA00", Length = "0xF")]
		[Token(Token = "0x60015B9")]
		private get { } //Length: 15
		[Address(RVA = "0x32412A0", Offset = "0x32406A0", Length = "0x1D0")]
		[Token(Token = "0x60015BA")]
		private set { } //Length: 464
	}

	[Token(Token = "0x1700047B")]
	private override StyleColor UnityEngine.UIElements.IStyle.backgroundColor
	{
		[Address(RVA = "0x323F610", Offset = "0x323EA10", Length = "0x3C")]
		[Token(Token = "0x60015BB")]
		private get { } //Length: 60
		[Address(RVA = "0x3241480", Offset = "0x3240880", Length = "0x54")]
		[Token(Token = "0x60015BC")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700047C")]
	private override StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
	{
		[Address(RVA = "0x323F650", Offset = "0x323EA50", Length = "0x4D")]
		[Token(Token = "0x60015BD")]
		private get { } //Length: 77
		[Address(RVA = "0x32414E0", Offset = "0x32408E0", Length = "0x61")]
		[Token(Token = "0x60015BE")]
		private set { } //Length: 97
	}

	[Token(Token = "0x1700047D")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionX
	{
		[Address(RVA = "0x323F6A0", Offset = "0x323EAA0", Length = "0x31")]
		[Token(Token = "0x60015BF")]
		private get { } //Length: 49
		[Address(RVA = "0x3241550", Offset = "0x3240950", Length = "0x4D")]
		[Token(Token = "0x60015C0")]
		private set { } //Length: 77
	}

	[Token(Token = "0x1700047E")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.backgroundPositionY
	{
		[Address(RVA = "0x323F6E0", Offset = "0x323EAE0", Length = "0x31")]
		[Token(Token = "0x60015C1")]
		private get { } //Length: 49
		[Address(RVA = "0x32415A0", Offset = "0x32409A0", Length = "0x4D")]
		[Token(Token = "0x60015C2")]
		private set { } //Length: 77
	}

	[Token(Token = "0x1700047F")]
	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.backgroundRepeat
	{
		[Address(RVA = "0x323F720", Offset = "0x323EB20", Length = "0x3B")]
		[Token(Token = "0x60015C3")]
		private get { } //Length: 59
		[Address(RVA = "0x32415F0", Offset = "0x32409F0", Length = "0x169")]
		[Token(Token = "0x60015C4")]
		private set { } //Length: 361
	}

	[Token(Token = "0x170004CA")]
	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize
	{
		[Address(RVA = "0x323F760", Offset = "0x323EB60", Length = "0x68")]
		[Token(Token = "0x600165E")]
		private get { } //Length: 104
		[Address(RVA = "0x3241760", Offset = "0x3240B60", Length = "0x16C")]
		[Token(Token = "0x600165F")]
		private set { } //Length: 364
	}

	[Token(Token = "0x17000480")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
	{
		[Address(RVA = "0x323F7D0", Offset = "0x323EBD0", Length = "0x3C")]
		[Token(Token = "0x60015C5")]
		private get { } //Length: 60
		[Address(RVA = "0x32418D0", Offset = "0x3240CD0", Length = "0x54")]
		[Token(Token = "0x60015C6")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000481")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
	{
		[Address(RVA = "0x323F810", Offset = "0x323EC10", Length = "0x3B")]
		[Token(Token = "0x60015C7")]
		private get { } //Length: 59
		[Address(RVA = "0x3241930", Offset = "0x3240D30", Length = "0x56")]
		[Token(Token = "0x60015C8")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000482")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
	{
		[Address(RVA = "0x323F850", Offset = "0x323EC50", Length = "0x3B")]
		[Token(Token = "0x60015C9")]
		private get { } //Length: 59
		[Address(RVA = "0x3241990", Offset = "0x3240D90", Length = "0x56")]
		[Token(Token = "0x60015CA")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000483")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth
	{
		[Address(RVA = "0x323F890", Offset = "0x323EC90", Length = "0xF")]
		[Token(Token = "0x60015CB")]
		private get { } //Length: 15
		[Address(RVA = "0x32419F0", Offset = "0x3240DF0", Length = "0x83")]
		[Token(Token = "0x60015CC")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000484")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
	{
		[Address(RVA = "0x323F8A0", Offset = "0x323ECA0", Length = "0x3C")]
		[Token(Token = "0x60015CD")]
		private get { } //Length: 60
		[Address(RVA = "0x3241A80", Offset = "0x3240E80", Length = "0x54")]
		[Token(Token = "0x60015CE")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000485")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth
	{
		[Address(RVA = "0x323F8E0", Offset = "0x323ECE0", Length = "0xF")]
		[Token(Token = "0x60015CF")]
		private get { } //Length: 15
		[Address(RVA = "0x3241AE0", Offset = "0x3240EE0", Length = "0x83")]
		[Token(Token = "0x60015D0")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000486")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderRightColor
	{
		[Address(RVA = "0x323F8F0", Offset = "0x323ECF0", Length = "0x3C")]
		[Token(Token = "0x60015D1")]
		private get { } //Length: 60
		[Address(RVA = "0x3241B70", Offset = "0x3240F70", Length = "0x54")]
		[Token(Token = "0x60015D2")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000487")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth
	{
		[Address(RVA = "0x323F930", Offset = "0x323ED30", Length = "0xF")]
		[Token(Token = "0x60015D3")]
		private get { } //Length: 15
		[Address(RVA = "0x3241BD0", Offset = "0x3240FD0", Length = "0x83")]
		[Token(Token = "0x60015D4")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000488")]
	private override StyleColor UnityEngine.UIElements.IStyle.borderTopColor
	{
		[Address(RVA = "0x323F940", Offset = "0x323ED40", Length = "0x3C")]
		[Token(Token = "0x60015D5")]
		private get { } //Length: 60
		[Address(RVA = "0x3241C60", Offset = "0x3241060", Length = "0x54")]
		[Token(Token = "0x60015D6")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000489")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
	{
		[Address(RVA = "0x323F980", Offset = "0x323ED80", Length = "0x3B")]
		[Token(Token = "0x60015D7")]
		private get { } //Length: 59
		[Address(RVA = "0x3241CC0", Offset = "0x32410C0", Length = "0x56")]
		[Token(Token = "0x60015D8")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700048A")]
	private override StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
	{
		[Address(RVA = "0x323F9C0", Offset = "0x323EDC0", Length = "0x3B")]
		[Token(Token = "0x60015D9")]
		private get { } //Length: 59
		[Address(RVA = "0x3241D20", Offset = "0x3241120", Length = "0x56")]
		[Token(Token = "0x60015DA")]
		private set { } //Length: 86
	}

	[Token(Token = "0x1700048B")]
	private override StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth
	{
		[Address(RVA = "0x323FA00", Offset = "0x323EE00", Length = "0xF")]
		[Token(Token = "0x60015DB")]
		private get { } //Length: 15
		[Address(RVA = "0x3241D80", Offset = "0x3241180", Length = "0x83")]
		[Token(Token = "0x60015DC")]
		private set { } //Length: 131
	}

	[Token(Token = "0x1700048C")]
	private override StyleLength UnityEngine.UIElements.IStyle.bottom
	{
		[Address(RVA = "0x323FA10", Offset = "0x323EE10", Length = "0x3B")]
		[Token(Token = "0x60015DD")]
		private get { } //Length: 59
		[Address(RVA = "0x3241E10", Offset = "0x3241210", Length = "0xA0")]
		[Token(Token = "0x60015DE")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700048D")]
	private override StyleColor UnityEngine.UIElements.IStyle.color
	{
		[Address(RVA = "0x323FA50", Offset = "0x323EE50", Length = "0x3C")]
		[Token(Token = "0x60015DF")]
		private get { } //Length: 60
		[Address(RVA = "0x3241EC0", Offset = "0x32412C0", Length = "0x54")]
		[Token(Token = "0x60015E0")]
		private set { } //Length: 84
	}

	[Token(Token = "0x170004C7")]
	private override StyleCursor UnityEngine.UIElements.IStyle.cursor
	{
		[Address(RVA = "0x323FA90", Offset = "0x323EE90", Length = "0x84")]
		[Token(Token = "0x6001658")]
		private get { } //Length: 132
		[Address(RVA = "0x3241F20", Offset = "0x3241320", Length = "0x1D7")]
		[Token(Token = "0x6001659")]
		private set { } //Length: 471
	}

	[Token(Token = "0x1700048E")]
	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display
	{
		[Address(RVA = "0x323FB20", Offset = "0x323EF20", Length = "0x87")]
		[Token(Token = "0x60015E1")]
		private get { } //Length: 135
		[Address(RVA = "0x3242100", Offset = "0x3241500", Length = "0xA7")]
		[Token(Token = "0x60015E2")]
		private set { } //Length: 167
	}

	[Token(Token = "0x170004CB")]
	private override StyleList<FilterFunction> UnityEngine.UIElements.IStyle.filter
	{
		[Address(RVA = "0x323FBB0", Offset = "0x323EFB0", Length = "0x9A")]
		[Token(Token = "0x6001660")]
		private get { } //Length: 154
		[Address(RVA = "0x32421B0", Offset = "0x32415B0", Length = "0x168")]
		[Token(Token = "0x6001661")]
		private set { } //Length: 360
	}

	[Token(Token = "0x1700048F")]
	private override StyleLength UnityEngine.UIElements.IStyle.flexBasis
	{
		[Address(RVA = "0x323FC50", Offset = "0x323F050", Length = "0x3B")]
		[Token(Token = "0x60015E3")]
		private get { } //Length: 59
		[Address(RVA = "0x3242320", Offset = "0x3241720", Length = "0xA0")]
		[Token(Token = "0x60015E4")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000490")]
	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection
	{
		[Address(RVA = "0x323FC90", Offset = "0x323F090", Length = "0x87")]
		[Token(Token = "0x60015E5")]
		private get { } //Length: 135
		[Address(RVA = "0x32423D0", Offset = "0x32417D0", Length = "0xA7")]
		[Token(Token = "0x60015E6")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000491")]
	private override StyleFloat UnityEngine.UIElements.IStyle.flexGrow
	{
		[Address(RVA = "0x323FD20", Offset = "0x323F120", Length = "0xF")]
		[Token(Token = "0x60015E7")]
		private get { } //Length: 15
		[Address(RVA = "0x3242480", Offset = "0x3241880", Length = "0x83")]
		[Token(Token = "0x60015E8")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000492")]
	private override StyleFloat UnityEngine.UIElements.IStyle.flexShrink
	{
		[Address(RVA = "0x323FD30", Offset = "0x323F130", Length = "0xF")]
		[Token(Token = "0x60015E9")]
		private get { } //Length: 15
		[Address(RVA = "0x3242510", Offset = "0x3241910", Length = "0x83")]
		[Token(Token = "0x60015EA")]
		private set { } //Length: 131
	}

	[Token(Token = "0x17000493")]
	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.flexWrap
	{
		[Address(RVA = "0x323FD40", Offset = "0x323F140", Length = "0x87")]
		[Token(Token = "0x60015EB")]
		private get { } //Length: 135
		[Address(RVA = "0x32425A0", Offset = "0x32419A0", Length = "0xA7")]
		[Token(Token = "0x60015EC")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000494")]
	private override StyleLength UnityEngine.UIElements.IStyle.fontSize
	{
		[Address(RVA = "0x323FDD0", Offset = "0x323F1D0", Length = "0x3B")]
		[Token(Token = "0x60015ED")]
		private get { } //Length: 59
		[Address(RVA = "0x3242650", Offset = "0x3241A50", Length = "0x56")]
		[Token(Token = "0x60015EE")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000495")]
	private override StyleLength UnityEngine.UIElements.IStyle.height
	{
		[Address(RVA = "0x323FE10", Offset = "0x323F210", Length = "0x3B")]
		[Token(Token = "0x60015EF")]
		private get { } //Length: 59
		[Address(RVA = "0x32426B0", Offset = "0x3241AB0", Length = "0xA0")]
		[Token(Token = "0x60015F0")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000496")]
	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.justifyContent
	{
		[Address(RVA = "0x323FE50", Offset = "0x323F250", Length = "0x87")]
		[Token(Token = "0x60015F1")]
		private get { } //Length: 135
		[Address(RVA = "0x3242760", Offset = "0x3241B60", Length = "0xA7")]
		[Token(Token = "0x60015F2")]
		private set { } //Length: 167
	}

	[Token(Token = "0x17000497")]
	private override StyleLength UnityEngine.UIElements.IStyle.left
	{
		[Address(RVA = "0x323FEE0", Offset = "0x323F2E0", Length = "0x3B")]
		[Token(Token = "0x60015F3")]
		private get { } //Length: 59
		[Address(RVA = "0x3242810", Offset = "0x3241C10", Length = "0xA0")]
		[Token(Token = "0x60015F4")]
		private set { } //Length: 160
	}

	[Token(Token = "0x17000498")]
	private override StyleLength UnityEngine.UIElements.IStyle.letterSpacing
	{
		[Address(RVA = "0x323FF20", Offset = "0x323F320", Length = "0x3B")]
		[Token(Token = "0x60015F5")]
		private get { } //Length: 59
		[Address(RVA = "0x32428C0", Offset = "0x3241CC0", Length = "0x56")]
		[Token(Token = "0x60015F6")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000499")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginBottom
	{
		[Address(RVA = "0x323FF60", Offset = "0x323F360", Length = "0x3B")]
		[Token(Token = "0x60015F7")]
		private get { } //Length: 59
		[Address(RVA = "0x3242920", Offset = "0x3241D20", Length = "0xA0")]
		[Token(Token = "0x60015F8")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049A")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginLeft
	{
		[Address(RVA = "0x323FFA0", Offset = "0x323F3A0", Length = "0x3B")]
		[Token(Token = "0x60015F9")]
		private get { } //Length: 59
		[Address(RVA = "0x32429D0", Offset = "0x3241DD0", Length = "0xA0")]
		[Token(Token = "0x60015FA")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049B")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginRight
	{
		[Address(RVA = "0x323FFE0", Offset = "0x323F3E0", Length = "0x3B")]
		[Token(Token = "0x60015FB")]
		private get { } //Length: 59
		[Address(RVA = "0x3242A80", Offset = "0x3241E80", Length = "0xA0")]
		[Token(Token = "0x60015FC")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049C")]
	private override StyleLength UnityEngine.UIElements.IStyle.marginTop
	{
		[Address(RVA = "0x3240020", Offset = "0x323F420", Length = "0x3B")]
		[Token(Token = "0x60015FD")]
		private get { } //Length: 59
		[Address(RVA = "0x3242B30", Offset = "0x3241F30", Length = "0xA0")]
		[Token(Token = "0x60015FE")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049D")]
	private override StyleLength UnityEngine.UIElements.IStyle.maxHeight
	{
		[Address(RVA = "0x3240060", Offset = "0x323F460", Length = "0x3B")]
		[Token(Token = "0x60015FF")]
		private get { } //Length: 59
		[Address(RVA = "0x3242BE0", Offset = "0x3241FE0", Length = "0xA0")]
		[Token(Token = "0x6001600")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049E")]
	private override StyleLength UnityEngine.UIElements.IStyle.maxWidth
	{
		[Address(RVA = "0x32400A0", Offset = "0x323F4A0", Length = "0x3B")]
		[Token(Token = "0x6001601")]
		private get { } //Length: 59
		[Address(RVA = "0x3242C90", Offset = "0x3242090", Length = "0xA0")]
		[Token(Token = "0x6001602")]
		private set { } //Length: 160
	}

	[Token(Token = "0x1700049F")]
	private override StyleLength UnityEngine.UIElements.IStyle.minHeight
	{
		[Address(RVA = "0x32400E0", Offset = "0x323F4E0", Length = "0x3B")]
		[Token(Token = "0x6001603")]
		private get { } //Length: 59
		[Address(RVA = "0x3242D40", Offset = "0x3242140", Length = "0xA0")]
		[Token(Token = "0x6001604")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A0")]
	private override StyleLength UnityEngine.UIElements.IStyle.minWidth
	{
		[Address(RVA = "0x3240120", Offset = "0x323F520", Length = "0x3B")]
		[Token(Token = "0x6001605")]
		private get { } //Length: 59
		[Address(RVA = "0x3242DF0", Offset = "0x32421F0", Length = "0xA0")]
		[Token(Token = "0x6001606")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A1")]
	private override StyleFloat UnityEngine.UIElements.IStyle.opacity
	{
		[Address(RVA = "0x3240160", Offset = "0x323F560", Length = "0xF")]
		[Token(Token = "0x6001607")]
		private get { } //Length: 15
		[Address(RVA = "0x3242EA0", Offset = "0x32422A0", Length = "0x43")]
		[Token(Token = "0x6001608")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004A2")]
	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow
	{
		[Address(RVA = "0x3240170", Offset = "0x323F570", Length = "0x87")]
		[Token(Token = "0x6001609")]
		private get { } //Length: 135
		[Address(RVA = "0x3242EF0", Offset = "0x32422F0", Length = "0x112")]
		[Token(Token = "0x600160A")]
		private set { } //Length: 274
	}

	[Token(Token = "0x170004A3")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingBottom
	{
		[Address(RVA = "0x3240200", Offset = "0x323F600", Length = "0x3B")]
		[Token(Token = "0x600160B")]
		private get { } //Length: 59
		[Address(RVA = "0x3243010", Offset = "0x3242410", Length = "0xA0")]
		[Token(Token = "0x600160C")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A4")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingLeft
	{
		[Address(RVA = "0x3240240", Offset = "0x323F640", Length = "0x3B")]
		[Token(Token = "0x600160D")]
		private get { } //Length: 59
		[Address(RVA = "0x32430C0", Offset = "0x32424C0", Length = "0xA0")]
		[Token(Token = "0x600160E")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A5")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingRight
	{
		[Address(RVA = "0x3240280", Offset = "0x323F680", Length = "0x3B")]
		[Token(Token = "0x600160F")]
		private get { } //Length: 59
		[Address(RVA = "0x3243170", Offset = "0x3242570", Length = "0xA0")]
		[Token(Token = "0x6001610")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A6")]
	private override StyleLength UnityEngine.UIElements.IStyle.paddingTop
	{
		[Address(RVA = "0x32402C0", Offset = "0x323F6C0", Length = "0x3B")]
		[Token(Token = "0x6001611")]
		private get { } //Length: 59
		[Address(RVA = "0x3243220", Offset = "0x3242620", Length = "0xA0")]
		[Token(Token = "0x6001612")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004A7")]
	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.position
	{
		[Address(RVA = "0x3240300", Offset = "0x323F700", Length = "0x87")]
		[Token(Token = "0x6001613")]
		private get { } //Length: 135
		[Address(RVA = "0x32432D0", Offset = "0x32426D0", Length = "0xA7")]
		[Token(Token = "0x6001614")]
		private set { } //Length: 167
	}

	[Token(Token = "0x170004A8")]
	private override StyleLength UnityEngine.UIElements.IStyle.right
	{
		[Address(RVA = "0x3240390", Offset = "0x323F790", Length = "0x3B")]
		[Token(Token = "0x6001615")]
		private get { } //Length: 59
		[Address(RVA = "0x3243380", Offset = "0x3242780", Length = "0xA0")]
		[Token(Token = "0x6001616")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004CE")]
	private override StyleRotate UnityEngine.UIElements.IStyle.rotate
	{
		[Address(RVA = "0x32403D0", Offset = "0x323F7D0", Length = "0x7A")]
		[Token(Token = "0x6001669")]
		private get { } //Length: 122
		[Address(RVA = "0x3243430", Offset = "0x3242830", Length = "0x1A7")]
		[Token(Token = "0x600166A")]
		private set { } //Length: 423
	}

	[Token(Token = "0x170004CF")]
	private override StyleScale UnityEngine.UIElements.IStyle.scale
	{
		[Address(RVA = "0x3240450", Offset = "0x323F850", Length = "0x5F")]
		[Token(Token = "0x600166B")]
		private get { } //Length: 95
		[Address(RVA = "0x32435E0", Offset = "0x32429E0", Length = "0x164")]
		[Token(Token = "0x600166C")]
		private set { } //Length: 356
	}

	[Token(Token = "0x170004A9")]
	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.textOverflow
	{
		[Address(RVA = "0x32404B0", Offset = "0x323F8B0", Length = "0x87")]
		[Token(Token = "0x6001617")]
		private get { } //Length: 135
		[Address(RVA = "0x3243750", Offset = "0x3242B50", Length = "0x6D")]
		[Token(Token = "0x6001618")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004C8")]
	private override StyleTextShadow UnityEngine.UIElements.IStyle.textShadow
	{
		[Address(RVA = "0x3240540", Offset = "0x323F940", Length = "0x5A")]
		[Token(Token = "0x600165A")]
		private get { } //Length: 90
		[Address(RVA = "0x32437C0", Offset = "0x3242BC0", Length = "0x1C1")]
		[Token(Token = "0x600165B")]
		private set { } //Length: 449
	}

	[Token(Token = "0x170004AA")]
	private override StyleLength UnityEngine.UIElements.IStyle.top
	{
		[Address(RVA = "0x32405A0", Offset = "0x323F9A0", Length = "0x3B")]
		[Token(Token = "0x6001619")]
		private get { } //Length: 59
		[Address(RVA = "0x3243990", Offset = "0x3242D90", Length = "0xA0")]
		[Token(Token = "0x600161A")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004CC")]
	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin
	{
		[Address(RVA = "0x32405E0", Offset = "0x323F9E0", Length = "0x68")]
		[Token(Token = "0x6001665")]
		private get { } //Length: 104
		[Address(RVA = "0x3243A40", Offset = "0x3242E40", Length = "0x16C")]
		[Token(Token = "0x6001666")]
		private set { } //Length: 364
	}

	[Token(Token = "0x170004AB")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDelay
	{
		[Address(RVA = "0x3240650", Offset = "0x323FA50", Length = "0x62")]
		[Token(Token = "0x600161B")]
		private get { } //Length: 98
		[Address(RVA = "0x3243BB0", Offset = "0x3242FB0", Length = "0x77")]
		[Token(Token = "0x600161C")]
		private set { } //Length: 119
	}

	[Token(Token = "0x170004AC")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.transitionDuration
	{
		[Address(RVA = "0x32406C0", Offset = "0x323FAC0", Length = "0x62")]
		[Token(Token = "0x600161D")]
		private get { } //Length: 98
		[Address(RVA = "0x3243C30", Offset = "0x3243030", Length = "0x77")]
		[Token(Token = "0x600161E")]
		private set { } //Length: 119
	}

	[Token(Token = "0x170004AD")]
	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.transitionProperty
	{
		[Address(RVA = "0x3240730", Offset = "0x323FB30", Length = "0x62")]
		[Token(Token = "0x600161F")]
		private get { } //Length: 98
		[Address(RVA = "0x3243CB0", Offset = "0x32430B0", Length = "0x77")]
		[Token(Token = "0x6001620")]
		private set { } //Length: 119
	}

	[Token(Token = "0x170004AE")]
	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.transitionTimingFunction
	{
		[Address(RVA = "0x32407A0", Offset = "0x323FBA0", Length = "0x62")]
		[Token(Token = "0x6001621")]
		private get { } //Length: 98
		[Address(RVA = "0x3243D30", Offset = "0x3243130", Length = "0x77")]
		[Token(Token = "0x6001622")]
		private set { } //Length: 119
	}

	[Token(Token = "0x170004CD")]
	private override StyleTranslate UnityEngine.UIElements.IStyle.translate
	{
		[Address(RVA = "0x3240810", Offset = "0x323FC10", Length = "0x7A")]
		[Token(Token = "0x6001667")]
		private get { } //Length: 122
		[Address(RVA = "0x3243DB0", Offset = "0x32431B0", Length = "0x1A7")]
		[Token(Token = "0x6001668")]
		private set { } //Length: 423
	}

	[Token(Token = "0x170004AF")]
	private override StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
	{
		[Address(RVA = "0x3240890", Offset = "0x323FC90", Length = "0x3C")]
		[Token(Token = "0x6001623")]
		private get { } //Length: 60
		[Address(RVA = "0x3243F60", Offset = "0x3243360", Length = "0x54")]
		[Token(Token = "0x6001624")]
		private set { } //Length: 84
	}

	[Token(Token = "0x170004B0")]
	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.unityEditorTextRenderingMode
	{
		[Address(RVA = "0x32408D0", Offset = "0x323FCD0", Length = "0x87")]
		[Token(Token = "0x6001625")]
		private get { } //Length: 135
		[Address(RVA = "0x3243FC0", Offset = "0x32433C0", Length = "0x6D")]
		[Token(Token = "0x6001626")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004B1")]
	private override StyleFont UnityEngine.UIElements.IStyle.unityFont
	{
		[Address(RVA = "0x3240A40", Offset = "0x323FE40", Length = "0x31")]
		[Token(Token = "0x6001627")]
		private get { } //Length: 49
		[Address(RVA = "0x3244100", Offset = "0x3243500", Length = "0x4D")]
		[Token(Token = "0x6001628")]
		private set { } //Length: 77
	}

	[Token(Token = "0x170004B2")]
	private override StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition
	{
		[Address(RVA = "0x3240960", Offset = "0x323FD60", Length = "0x41")]
		[Token(Token = "0x6001629")]
		private get { } //Length: 65
		[Address(RVA = "0x3244030", Offset = "0x3243430", Length = "0x58")]
		[Token(Token = "0x600162A")]
		private set { } //Length: 88
	}

	[Token(Token = "0x170004B3")]
	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.unityFontStyleAndWeight
	{
		[Address(RVA = "0x32409B0", Offset = "0x323FDB0", Length = "0x87")]
		[Token(Token = "0x600162B")]
		private get { } //Length: 135
		[Address(RVA = "0x3244090", Offset = "0x3243490", Length = "0x6D")]
		[Token(Token = "0x600162C")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004B4")]
	private override StyleMaterialDefinition UnityEngine.UIElements.IStyle.unityMaterial
	{
		[Address(RVA = "0x3240A80", Offset = "0x323FE80", Length = "0x41")]
		[Token(Token = "0x600162D")]
		private get { } //Length: 65
		[Address(RVA = "0x3244150", Offset = "0x3243550", Length = "0x58")]
		[Token(Token = "0x600162E")]
		private set { } //Length: 88
	}

	[Token(Token = "0x170004B5")]
	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.unityOverflowClipBox
	{
		[Address(RVA = "0x3240AD0", Offset = "0x323FED0", Length = "0x87")]
		[Token(Token = "0x600162F")]
		private get { } //Length: 135
		[Address(RVA = "0x32441B0", Offset = "0x32435B0", Length = "0x6D")]
		[Token(Token = "0x6001630")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004B6")]
	private override StyleLength UnityEngine.UIElements.IStyle.unityParagraphSpacing
	{
		[Address(RVA = "0x3240B60", Offset = "0x323FF60", Length = "0x3B")]
		[Token(Token = "0x6001631")]
		private get { } //Length: 59
		[Address(RVA = "0x3244220", Offset = "0x3243620", Length = "0x56")]
		[Token(Token = "0x6001632")]
		private set { } //Length: 86
	}

	[Token(Token = "0x170004B7")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceBottom
	{
		[Address(RVA = "0x3240BA0", Offset = "0x323FFA0", Length = "0xF")]
		[Token(Token = "0x6001633")]
		private get { } //Length: 15
		[Address(RVA = "0x3244280", Offset = "0x3243680", Length = "0x43")]
		[Token(Token = "0x6001634")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004B8")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceLeft
	{
		[Address(RVA = "0x3240BB0", Offset = "0x323FFB0", Length = "0xF")]
		[Token(Token = "0x6001635")]
		private get { } //Length: 15
		[Address(RVA = "0x32442D0", Offset = "0x32436D0", Length = "0x43")]
		[Token(Token = "0x6001636")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004B9")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceRight
	{
		[Address(RVA = "0x3240BC0", Offset = "0x323FFC0", Length = "0xF")]
		[Token(Token = "0x6001637")]
		private get { } //Length: 15
		[Address(RVA = "0x3244320", Offset = "0x3243720", Length = "0x43")]
		[Token(Token = "0x6001638")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004BA")]
	private override StyleFloat UnityEngine.UIElements.IStyle.unitySliceScale
	{
		[Address(RVA = "0x3240BD0", Offset = "0x323FFD0", Length = "0xF")]
		[Token(Token = "0x6001639")]
		private get { } //Length: 15
		[Address(RVA = "0x3244370", Offset = "0x3243770", Length = "0x43")]
		[Token(Token = "0x600163A")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004BB")]
	private override StyleInt UnityEngine.UIElements.IStyle.unitySliceTop
	{
		[Address(RVA = "0x3240BE0", Offset = "0x323FFE0", Length = "0xF")]
		[Token(Token = "0x600163B")]
		private get { } //Length: 15
		[Address(RVA = "0x32443C0", Offset = "0x32437C0", Length = "0x43")]
		[Token(Token = "0x600163C")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004BC")]
	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.unitySliceType
	{
		[Address(RVA = "0x3240BF0", Offset = "0x323FFF0", Length = "0x87")]
		[Token(Token = "0x600163D")]
		private get { } //Length: 135
		[Address(RVA = "0x3244410", Offset = "0x3243810", Length = "0x6D")]
		[Token(Token = "0x600163E")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004BD")]
	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.unityTextAlign
	{
		[Address(RVA = "0x3240C80", Offset = "0x3240080", Length = "0x87")]
		[Token(Token = "0x600163F")]
		private get { } //Length: 135
		[Address(RVA = "0x3244480", Offset = "0x3243880", Length = "0x6D")]
		[Token(Token = "0x6001640")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004C9")]
	private override StyleTextAutoSize UnityEngine.UIElements.IStyle.unityTextAutoSize
	{
		[Address(RVA = "0x3240D10", Offset = "0x3240110", Length = "0x62")]
		[Token(Token = "0x600165C")]
		private get { } //Length: 98
		[Address(RVA = "0x32444F0", Offset = "0x32438F0", Length = "0x1E7")]
		[Token(Token = "0x600165D")]
		private set { } //Length: 487
	}

	[Token(Token = "0x170004BE")]
	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.unityTextGenerator
	{
		[Address(RVA = "0x3240D80", Offset = "0x3240180", Length = "0x87")]
		[Token(Token = "0x6001641")]
		private get { } //Length: 135
		[Address(RVA = "0x32446E0", Offset = "0x3243AE0", Length = "0x6D")]
		[Token(Token = "0x6001642")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004BF")]
	private override StyleColor UnityEngine.UIElements.IStyle.unityTextOutlineColor
	{
		[Address(RVA = "0x3240E10", Offset = "0x3240210", Length = "0x3C")]
		[Token(Token = "0x6001643")]
		private get { } //Length: 60
		[Address(RVA = "0x3244750", Offset = "0x3243B50", Length = "0x54")]
		[Token(Token = "0x6001644")]
		private set { } //Length: 84
	}

	[Token(Token = "0x170004C0")]
	private override StyleFloat UnityEngine.UIElements.IStyle.unityTextOutlineWidth
	{
		[Address(RVA = "0x3240E50", Offset = "0x3240250", Length = "0xF")]
		[Token(Token = "0x6001645")]
		private get { } //Length: 15
		[Address(RVA = "0x32447B0", Offset = "0x3243BB0", Length = "0x43")]
		[Token(Token = "0x6001646")]
		private set { } //Length: 67
	}

	[Token(Token = "0x170004C1")]
	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.unityTextOverflowPosition
	{
		[Address(RVA = "0x3240E60", Offset = "0x3240260", Length = "0x87")]
		[Token(Token = "0x6001647")]
		private get { } //Length: 135
		[Address(RVA = "0x3244800", Offset = "0x3243C00", Length = "0x6D")]
		[Token(Token = "0x6001648")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004C2")]
	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility
	{
		[Address(RVA = "0x3240EF0", Offset = "0x32402F0", Length = "0x87")]
		[Token(Token = "0x6001649")]
		private get { } //Length: 135
		[Address(RVA = "0x3244870", Offset = "0x3243C70", Length = "0x6D")]
		[Token(Token = "0x600164A")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004C3")]
	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.whiteSpace
	{
		[Address(RVA = "0x3240F80", Offset = "0x3240380", Length = "0x87")]
		[Token(Token = "0x600164B")]
		private get { } //Length: 135
		[Address(RVA = "0x32448E0", Offset = "0x3243CE0", Length = "0x6D")]
		[Token(Token = "0x600164C")]
		private set { } //Length: 109
	}

	[Token(Token = "0x170004C4")]
	private override StyleLength UnityEngine.UIElements.IStyle.width
	{
		[Address(RVA = "0x3241010", Offset = "0x3240410", Length = "0x3B")]
		[Token(Token = "0x600164D")]
		private get { } //Length: 59
		[Address(RVA = "0x3244950", Offset = "0x3243D50", Length = "0xA0")]
		[Token(Token = "0x600164E")]
		private set { } //Length: 160
	}

	[Token(Token = "0x170004C5")]
	private override StyleLength UnityEngine.UIElements.IStyle.wordSpacing
	{
		[Address(RVA = "0x3241050", Offset = "0x3240450", Length = "0x3B")]
		[Token(Token = "0x600164F")]
		private get { } //Length: 59
		[Address(RVA = "0x3244A00", Offset = "0x3243E00", Length = "0x56")]
		[Token(Token = "0x6001650")]
		private set { } //Length: 86
	}

	[Token(Token = "0x170004C6")]
	private VisualElement ve
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001651")]
		private get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001652")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3244A60", Offset = "0x3243E60", Length = "0x73")]
	[Token(Token = "0x6001699")]
	private static InlineStyleAccess() { }

	[Address(RVA = "0x3244AE0", Offset = "0x3243EE0", Length = "0x31")]
	[Token(Token = "0x6001653")]
	public InlineStyleAccess(VisualElement ve) { }

	[Address(RVA = "0x3239CF0", Offset = "0x32390F0", Length = "0x222")]
	[Token(Token = "0x600168F")]
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x3239F20", Offset = "0x3239320", Length = "0xE97")]
	[Token(Token = "0x6001657")]
	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x323ADC0", Offset = "0x323A1C0", Length = "0x231")]
	[Token(Token = "0x6001689")]
	private void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize) { }

	[Address(RVA = "0x323B000", Offset = "0x323A400", Length = "0x1F1")]
	[Token(Token = "0x600167B")]
	private void ApplyStyleCursor(StyleCursor cursor) { }

	[Address(RVA = "0x323B200", Offset = "0x323A600", Length = "0x212")]
	[Token(Token = "0x600168B")]
	private void ApplyStyleFilter(StyleList<FilterFunction> filter) { }

	[Address(RVA = "0x323B420", Offset = "0x323A820", Length = "0x2BD")]
	[Token(Token = "0x6001687")]
	private void ApplyStyleRotate(StyleRotate rotate) { }

	[Address(RVA = "0x323B6E0", Offset = "0x323AAE0", Length = "0x224")]
	[Token(Token = "0x6001685")]
	private void ApplyStyleScale(StyleScale scale) { }

	[Address(RVA = "0x323B910", Offset = "0x323AD10", Length = "0x60")]
	[Token(Token = "0x600167F")]
	private void ApplyStyleTextAutoSize(StyleTextAutoSize textAutoSize) { }

	[Address(RVA = "0x323B980", Offset = "0x323AD80", Length = "0x240")]
	[Token(Token = "0x600167D")]
	private void ApplyStyleTextShadow(StyleTextShadow textShadow) { }

	[Address(RVA = "0x323BBD0", Offset = "0x323AFD0", Length = "0x231")]
	[Token(Token = "0x6001681")]
	private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin) { }

	[Address(RVA = "0x323BE10", Offset = "0x323B210", Length = "0x245")]
	[Token(Token = "0x6001683")]
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	[Address(RVA = "0x323C380", Offset = "0x323B780", Length = "0xDB")]
	[Token(Token = "0x600168D")]
	private void ApplyStyleValue(StyleValueManaged value) { }

	[Address(RVA = "0x323C060", Offset = "0x323B460", Length = "0x317")]
	[Token(Token = "0x600168C")]
	private void ApplyStyleValue(StyleValue value) { }

	[Address(RVA = "0x323C460", Offset = "0x323B860", Length = "0xB4")]
	[Token(Token = "0x6001654")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001651")]
	private VisualElement get_ve() { }

	[Address(RVA = "0x832170", Offset = "0x831570", Length = "0x10C")]
	[Token(Token = "0x6001662")]
	private StyleList<T> GetStyleList(StylePropertyId id) { }

	[Address(RVA = "0x323C520", Offset = "0x323B920", Length = "0x305")]
	[Token(Token = "0x6001656")]
	public bool IsValueSet(StylePropertyId id) { }

	[Address(RVA = "0x323C830", Offset = "0x323BC30", Length = "0xF3")]
	[Token(Token = "0x600168E")]
	private bool RemoveInlineStyle(StylePropertyId id) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001652")]
	private void set_ve(VisualElement value) { }

	[Address(RVA = "0x323C930", Offset = "0x323BD30", Length = "0x15E")]
	[Token(Token = "0x6001688")]
	private bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue) { }

	[Address(RVA = "0x323CA90", Offset = "0x323BE90", Length = "0x1BB")]
	[Token(Token = "0x600167A")]
	private bool SetInlineCursor(StyleCursor inlineValue) { }

	[Address(RVA = "0x323CC50", Offset = "0x323C050", Length = "0x170")]
	[Token(Token = "0x600168A")]
	private bool SetInlineFilter(StyleList<FilterFunction> inlineValue) { }

	[Address(RVA = "0x323CDC0", Offset = "0x323C1C0", Length = "0x1C7")]
	[Token(Token = "0x6001686")]
	private bool SetInlineRotate(StyleRotate inlineValue) { }

	[Address(RVA = "0x323CF90", Offset = "0x323C390", Length = "0x62")]
	[Token(Token = "0x6001655")]
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x323D000", Offset = "0x323C400", Length = "0x16E")]
	[Token(Token = "0x6001684")]
	private bool SetInlineScale(StyleScale inlineValue) { }

	[Address(RVA = "0x323D170", Offset = "0x323C570", Length = "0x1C4")]
	[Token(Token = "0x600167E")]
	private bool SetInlineTextAutoSize(StyleTextAutoSize inlineValue) { }

	[Address(RVA = "0x323D340", Offset = "0x323C740", Length = "0x1A5")]
	[Token(Token = "0x600167C")]
	private bool SetInlineTextShadow(StyleTextShadow inlineValue) { }

	[Address(RVA = "0x323D4F0", Offset = "0x323C8F0", Length = "0x15E")]
	[Token(Token = "0x6001680")]
	private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue) { }

	[Address(RVA = "0x323D650", Offset = "0x323CA50", Length = "0x1C7")]
	[Token(Token = "0x6001682")]
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	[Address(RVA = "0x323DA30", Offset = "0x323CE30", Length = "0x17F")]
	[Token(Token = "0x600166D")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundPosition inlineValue) { }

	[Address(RVA = "0x323E2C0", Offset = "0x323D6C0", Length = "0x169")]
	[Token(Token = "0x600166E")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundRepeat inlineValue) { }

	[Address(RVA = "0x323DBB0", Offset = "0x323CFB0", Length = "0x15D")]
	[Token(Token = "0x600166F")]
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	[Address(RVA = "0x323EAD0", Offset = "0x323DED0", Length = "0x140")]
	[Token(Token = "0x6001670")]
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	[Address(RVA = "0x323E750", Offset = "0x323DB50", Length = "0x14E")]
	[Token(Token = "0x6001671")]
	private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue) { }

	[Address(RVA = "0x323E590", Offset = "0x323D990", Length = "0x1BE")]
	[Token(Token = "0x6001672")]
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	[Address(RVA = "0x8323A0", Offset = "0x8317A0", Length = "0x2CB")]
	[Token(Token = "0x6001678")]
	private bool SetStyleValue(StylePropertyId id, StyleList<T> inlineValue) { }

	[Address(RVA = "0x323EC10", Offset = "0x323E010", Length = "0x554")]
	[Token(Token = "0x6001674")]
	private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue) { }

	[Address(RVA = "0x323DD10", Offset = "0x323D110", Length = "0x328")]
	[Token(Token = "0x6001675")]
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	[Address(RVA = "0x323E8A0", Offset = "0x323DCA0", Length = "0x227")]
	[Token(Token = "0x6001676")]
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	[Address(RVA = "0x323E040", Offset = "0x323D440", Length = "0x27A")]
	[Token(Token = "0x6001677")]
	private bool SetStyleValue(StylePropertyId id, StyleMaterialDefinition inlineValue) { }

	[Address(RVA = "0x323E430", Offset = "0x323D830", Length = "0x156")]
	[Token(Token = "0x6001679")]
	private bool SetStyleValue(StylePropertyId id, StyleRatio inlineValue) { }

	[Address(RVA = "0x832B80", Offset = "0x831F80", Length = "0x19A")]
	[Token(Token = "0x6001673")]
	private bool SetStyleValue(StylePropertyId id, StyleEnum<T> inlineValue) { }

	[Address(RVA = "0x323D820", Offset = "0x323CC20", Length = "0x202")]
	[Token(Token = "0x6001663")]
	private void SetStyleValueManaged(StyleValueManaged value) { }

	[Address(RVA = "0x323F170", Offset = "0x323E570", Length = "0x26")]
	[Token(Token = "0x6001697")]
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	[Address(RVA = "0x323F1A0", Offset = "0x323E5A0", Length = "0x34")]
	[Token(Token = "0x6001690")]
	public bool TryGetInlineCursor(ref StyleCursor value) { }

	[Address(RVA = "0x323F1E0", Offset = "0x323E5E0", Length = "0x30")]
	[Token(Token = "0x6001698")]
	public bool TryGetInlineFilter(ref StyleList<FilterFunction>& value) { }

	[Address(RVA = "0x323F210", Offset = "0x323E610", Length = "0x2F")]
	[Token(Token = "0x6001695")]
	public bool TryGetInlineRotate(ref StyleRotate value) { }

	[Address(RVA = "0x323F240", Offset = "0x323E640", Length = "0x22")]
	[Token(Token = "0x6001696")]
	public bool TryGetInlineScale(ref StyleScale value) { }

	[Address(RVA = "0x323F270", Offset = "0x323E670", Length = "0x20")]
	[Token(Token = "0x6001692")]
	public bool TryGetInlineTextAutoSize(ref StyleTextAutoSize value) { }

	[Address(RVA = "0x323F290", Offset = "0x323E690", Length = "0x1B")]
	[Token(Token = "0x6001691")]
	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	[Address(RVA = "0x323F2B0", Offset = "0x323E6B0", Length = "0x26")]
	[Token(Token = "0x6001693")]
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	[Address(RVA = "0x323F2E0", Offset = "0x323E6E0", Length = "0x2F")]
	[Token(Token = "0x6001694")]
	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	[Address(RVA = "0x323F310", Offset = "0x323E710", Length = "0x13D")]
	[Token(Token = "0x6001664")]
	private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value) { }

	[Address(RVA = "0x323F450", Offset = "0x323E850", Length = "0x87")]
	[Token(Token = "0x60015B3")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignContent() { }

	[Address(RVA = "0x323F4E0", Offset = "0x323E8E0", Length = "0x87")]
	[Token(Token = "0x60015B5")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignItems() { }

	[Address(RVA = "0x323F570", Offset = "0x323E970", Length = "0x87")]
	[Token(Token = "0x60015B7")]
	private override StyleEnum<Align> UnityEngine.UIElements.IStyle.get_alignSelf() { }

	[Address(RVA = "0x323F600", Offset = "0x323EA00", Length = "0xF")]
	[Token(Token = "0x60015B9")]
	private override StyleRatio UnityEngine.UIElements.IStyle.get_aspectRatio() { }

	[Address(RVA = "0x323F610", Offset = "0x323EA10", Length = "0x3C")]
	[Token(Token = "0x60015BB")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_backgroundColor() { }

	[Address(RVA = "0x323F650", Offset = "0x323EA50", Length = "0x4D")]
	[Token(Token = "0x60015BD")]
	private override StyleBackground UnityEngine.UIElements.IStyle.get_backgroundImage() { }

	[Address(RVA = "0x323F6A0", Offset = "0x323EAA0", Length = "0x31")]
	[Token(Token = "0x60015BF")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionX() { }

	[Address(RVA = "0x323F6E0", Offset = "0x323EAE0", Length = "0x31")]
	[Token(Token = "0x60015C1")]
	private override StyleBackgroundPosition UnityEngine.UIElements.IStyle.get_backgroundPositionY() { }

	[Address(RVA = "0x323F720", Offset = "0x323EB20", Length = "0x3B")]
	[Token(Token = "0x60015C3")]
	private override StyleBackgroundRepeat UnityEngine.UIElements.IStyle.get_backgroundRepeat() { }

	[Address(RVA = "0x323F760", Offset = "0x323EB60", Length = "0x68")]
	[Token(Token = "0x600165E")]
	private override StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	[Address(RVA = "0x323F7D0", Offset = "0x323EBD0", Length = "0x3C")]
	[Token(Token = "0x60015C5")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderBottomColor() { }

	[Address(RVA = "0x323F810", Offset = "0x323EC10", Length = "0x3B")]
	[Token(Token = "0x60015C7")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomLeftRadius() { }

	[Address(RVA = "0x323F850", Offset = "0x323EC50", Length = "0x3B")]
	[Token(Token = "0x60015C9")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderBottomRightRadius() { }

	[Address(RVA = "0x323F890", Offset = "0x323EC90", Length = "0xF")]
	[Token(Token = "0x60015CB")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderBottomWidth() { }

	[Address(RVA = "0x323F8A0", Offset = "0x323ECA0", Length = "0x3C")]
	[Token(Token = "0x60015CD")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderLeftColor() { }

	[Address(RVA = "0x323F8E0", Offset = "0x323ECE0", Length = "0xF")]
	[Token(Token = "0x60015CF")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderLeftWidth() { }

	[Address(RVA = "0x323F8F0", Offset = "0x323ECF0", Length = "0x3C")]
	[Token(Token = "0x60015D1")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderRightColor() { }

	[Address(RVA = "0x323F930", Offset = "0x323ED30", Length = "0xF")]
	[Token(Token = "0x60015D3")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderRightWidth() { }

	[Address(RVA = "0x323F940", Offset = "0x323ED40", Length = "0x3C")]
	[Token(Token = "0x60015D5")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_borderTopColor() { }

	[Address(RVA = "0x323F980", Offset = "0x323ED80", Length = "0x3B")]
	[Token(Token = "0x60015D7")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopLeftRadius() { }

	[Address(RVA = "0x323F9C0", Offset = "0x323EDC0", Length = "0x3B")]
	[Token(Token = "0x60015D9")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_borderTopRightRadius() { }

	[Address(RVA = "0x323FA00", Offset = "0x323EE00", Length = "0xF")]
	[Token(Token = "0x60015DB")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_borderTopWidth() { }

	[Address(RVA = "0x323FA10", Offset = "0x323EE10", Length = "0x3B")]
	[Token(Token = "0x60015DD")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_bottom() { }

	[Address(RVA = "0x323FA50", Offset = "0x323EE50", Length = "0x3C")]
	[Token(Token = "0x60015DF")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_color() { }

	[Address(RVA = "0x323FA90", Offset = "0x323EE90", Length = "0x84")]
	[Token(Token = "0x6001658")]
	private override StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	[Address(RVA = "0x323FB20", Offset = "0x323EF20", Length = "0x87")]
	[Token(Token = "0x60015E1")]
	private override StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	[Address(RVA = "0x323FBB0", Offset = "0x323EFB0", Length = "0x9A")]
	[Token(Token = "0x6001660")]
	private override StyleList<FilterFunction> UnityEngine.UIElements.IStyle.get_filter() { }

	[Address(RVA = "0x323FC50", Offset = "0x323F050", Length = "0x3B")]
	[Token(Token = "0x60015E3")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_flexBasis() { }

	[Address(RVA = "0x323FC90", Offset = "0x323F090", Length = "0x87")]
	[Token(Token = "0x60015E5")]
	private override StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.get_flexDirection() { }

	[Address(RVA = "0x323FD20", Offset = "0x323F120", Length = "0xF")]
	[Token(Token = "0x60015E7")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexGrow() { }

	[Address(RVA = "0x323FD30", Offset = "0x323F130", Length = "0xF")]
	[Token(Token = "0x60015E9")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_flexShrink() { }

	[Address(RVA = "0x323FD40", Offset = "0x323F140", Length = "0x87")]
	[Token(Token = "0x60015EB")]
	private override StyleEnum<Wrap> UnityEngine.UIElements.IStyle.get_flexWrap() { }

	[Address(RVA = "0x323FDD0", Offset = "0x323F1D0", Length = "0x3B")]
	[Token(Token = "0x60015ED")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_fontSize() { }

	[Address(RVA = "0x323FE10", Offset = "0x323F210", Length = "0x3B")]
	[Token(Token = "0x60015EF")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_height() { }

	[Address(RVA = "0x323FE50", Offset = "0x323F250", Length = "0x87")]
	[Token(Token = "0x60015F1")]
	private override StyleEnum<Justify> UnityEngine.UIElements.IStyle.get_justifyContent() { }

	[Address(RVA = "0x323FEE0", Offset = "0x323F2E0", Length = "0x3B")]
	[Token(Token = "0x60015F3")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_left() { }

	[Address(RVA = "0x323FF20", Offset = "0x323F320", Length = "0x3B")]
	[Token(Token = "0x60015F5")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_letterSpacing() { }

	[Address(RVA = "0x323FF60", Offset = "0x323F360", Length = "0x3B")]
	[Token(Token = "0x60015F7")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginBottom() { }

	[Address(RVA = "0x323FFA0", Offset = "0x323F3A0", Length = "0x3B")]
	[Token(Token = "0x60015F9")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginLeft() { }

	[Address(RVA = "0x323FFE0", Offset = "0x323F3E0", Length = "0x3B")]
	[Token(Token = "0x60015FB")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginRight() { }

	[Address(RVA = "0x3240020", Offset = "0x323F420", Length = "0x3B")]
	[Token(Token = "0x60015FD")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_marginTop() { }

	[Address(RVA = "0x3240060", Offset = "0x323F460", Length = "0x3B")]
	[Token(Token = "0x60015FF")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxHeight() { }

	[Address(RVA = "0x32400A0", Offset = "0x323F4A0", Length = "0x3B")]
	[Token(Token = "0x6001601")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_maxWidth() { }

	[Address(RVA = "0x32400E0", Offset = "0x323F4E0", Length = "0x3B")]
	[Token(Token = "0x6001603")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minHeight() { }

	[Address(RVA = "0x3240120", Offset = "0x323F520", Length = "0x3B")]
	[Token(Token = "0x6001605")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_minWidth() { }

	[Address(RVA = "0x3240160", Offset = "0x323F560", Length = "0xF")]
	[Token(Token = "0x6001607")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_opacity() { }

	[Address(RVA = "0x3240170", Offset = "0x323F570", Length = "0x87")]
	[Token(Token = "0x6001609")]
	private override StyleEnum<Overflow> UnityEngine.UIElements.IStyle.get_overflow() { }

	[Address(RVA = "0x3240200", Offset = "0x323F600", Length = "0x3B")]
	[Token(Token = "0x600160B")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingBottom() { }

	[Address(RVA = "0x3240240", Offset = "0x323F640", Length = "0x3B")]
	[Token(Token = "0x600160D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingLeft() { }

	[Address(RVA = "0x3240280", Offset = "0x323F680", Length = "0x3B")]
	[Token(Token = "0x600160F")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingRight() { }

	[Address(RVA = "0x32402C0", Offset = "0x323F6C0", Length = "0x3B")]
	[Token(Token = "0x6001611")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	[Address(RVA = "0x3240300", Offset = "0x323F700", Length = "0x87")]
	[Token(Token = "0x6001613")]
	private override StyleEnum<Position> UnityEngine.UIElements.IStyle.get_position() { }

	[Address(RVA = "0x3240390", Offset = "0x323F790", Length = "0x3B")]
	[Token(Token = "0x6001615")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_right() { }

	[Address(RVA = "0x32403D0", Offset = "0x323F7D0", Length = "0x7A")]
	[Token(Token = "0x6001669")]
	private override StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	[Address(RVA = "0x3240450", Offset = "0x323F850", Length = "0x5F")]
	[Token(Token = "0x600166B")]
	private override StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	[Address(RVA = "0x32404B0", Offset = "0x323F8B0", Length = "0x87")]
	[Token(Token = "0x6001617")]
	private override StyleEnum<TextOverflow> UnityEngine.UIElements.IStyle.get_textOverflow() { }

	[Address(RVA = "0x3240540", Offset = "0x323F940", Length = "0x5A")]
	[Token(Token = "0x600165A")]
	private override StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	[Address(RVA = "0x32405A0", Offset = "0x323F9A0", Length = "0x3B")]
	[Token(Token = "0x6001619")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_top() { }

	[Address(RVA = "0x32405E0", Offset = "0x323F9E0", Length = "0x68")]
	[Token(Token = "0x6001665")]
	private override StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	[Address(RVA = "0x3240650", Offset = "0x323FA50", Length = "0x62")]
	[Token(Token = "0x600161B")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDelay() { }

	[Address(RVA = "0x32406C0", Offset = "0x323FAC0", Length = "0x62")]
	[Token(Token = "0x600161D")]
	private override StyleList<TimeValue> UnityEngine.UIElements.IStyle.get_transitionDuration() { }

	[Address(RVA = "0x3240730", Offset = "0x323FB30", Length = "0x62")]
	[Token(Token = "0x600161F")]
	private override StyleList<StylePropertyName> UnityEngine.UIElements.IStyle.get_transitionProperty() { }

	[Address(RVA = "0x32407A0", Offset = "0x323FBA0", Length = "0x62")]
	[Token(Token = "0x6001621")]
	private override StyleList<EasingFunction> UnityEngine.UIElements.IStyle.get_transitionTimingFunction() { }

	[Address(RVA = "0x3240810", Offset = "0x323FC10", Length = "0x7A")]
	[Token(Token = "0x6001667")]
	private override StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	[Address(RVA = "0x3240890", Offset = "0x323FC90", Length = "0x3C")]
	[Token(Token = "0x6001623")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x32408D0", Offset = "0x323FCD0", Length = "0x87")]
	[Token(Token = "0x6001625")]
	private override StyleEnum<EditorTextRenderingMode> UnityEngine.UIElements.IStyle.get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x3240A40", Offset = "0x323FE40", Length = "0x31")]
	[Token(Token = "0x6001627")]
	private override StyleFont UnityEngine.UIElements.IStyle.get_unityFont() { }

	[Address(RVA = "0x3240960", Offset = "0x323FD60", Length = "0x41")]
	[Token(Token = "0x6001629")]
	private override StyleFontDefinition UnityEngine.UIElements.IStyle.get_unityFontDefinition() { }

	[Address(RVA = "0x32409B0", Offset = "0x323FDB0", Length = "0x87")]
	[Token(Token = "0x600162B")]
	private override StyleEnum<FontStyle> UnityEngine.UIElements.IStyle.get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x3240A80", Offset = "0x323FE80", Length = "0x41")]
	[Token(Token = "0x600162D")]
	private override StyleMaterialDefinition UnityEngine.UIElements.IStyle.get_unityMaterial() { }

	[Address(RVA = "0x3240AD0", Offset = "0x323FED0", Length = "0x87")]
	[Token(Token = "0x600162F")]
	private override StyleEnum<OverflowClipBox> UnityEngine.UIElements.IStyle.get_unityOverflowClipBox() { }

	[Address(RVA = "0x3240B60", Offset = "0x323FF60", Length = "0x3B")]
	[Token(Token = "0x6001631")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_unityParagraphSpacing() { }

	[Address(RVA = "0x3240BA0", Offset = "0x323FFA0", Length = "0xF")]
	[Token(Token = "0x6001633")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceBottom() { }

	[Address(RVA = "0x3240BB0", Offset = "0x323FFB0", Length = "0xF")]
	[Token(Token = "0x6001635")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceLeft() { }

	[Address(RVA = "0x3240BC0", Offset = "0x323FFC0", Length = "0xF")]
	[Token(Token = "0x6001637")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceRight() { }

	[Address(RVA = "0x3240BD0", Offset = "0x323FFD0", Length = "0xF")]
	[Token(Token = "0x6001639")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unitySliceScale() { }

	[Address(RVA = "0x3240BE0", Offset = "0x323FFE0", Length = "0xF")]
	[Token(Token = "0x600163B")]
	private override StyleInt UnityEngine.UIElements.IStyle.get_unitySliceTop() { }

	[Address(RVA = "0x3240BF0", Offset = "0x323FFF0", Length = "0x87")]
	[Token(Token = "0x600163D")]
	private override StyleEnum<SliceType> UnityEngine.UIElements.IStyle.get_unitySliceType() { }

	[Address(RVA = "0x3240C80", Offset = "0x3240080", Length = "0x87")]
	[Token(Token = "0x600163F")]
	private override StyleEnum<TextAnchor> UnityEngine.UIElements.IStyle.get_unityTextAlign() { }

	[Address(RVA = "0x3240D10", Offset = "0x3240110", Length = "0x62")]
	[Token(Token = "0x600165C")]
	private override StyleTextAutoSize UnityEngine.UIElements.IStyle.get_unityTextAutoSize() { }

	[Address(RVA = "0x3240D80", Offset = "0x3240180", Length = "0x87")]
	[Token(Token = "0x6001641")]
	private override StyleEnum<TextGeneratorType> UnityEngine.UIElements.IStyle.get_unityTextGenerator() { }

	[Address(RVA = "0x3240E10", Offset = "0x3240210", Length = "0x3C")]
	[Token(Token = "0x6001643")]
	private override StyleColor UnityEngine.UIElements.IStyle.get_unityTextOutlineColor() { }

	[Address(RVA = "0x3240E50", Offset = "0x3240250", Length = "0xF")]
	[Token(Token = "0x6001645")]
	private override StyleFloat UnityEngine.UIElements.IStyle.get_unityTextOutlineWidth() { }

	[Address(RVA = "0x3240E60", Offset = "0x3240260", Length = "0x87")]
	[Token(Token = "0x6001647")]
	private override StyleEnum<TextOverflowPosition> UnityEngine.UIElements.IStyle.get_unityTextOverflowPosition() { }

	[Address(RVA = "0x3240EF0", Offset = "0x32402F0", Length = "0x87")]
	[Token(Token = "0x6001649")]
	private override StyleEnum<Visibility> UnityEngine.UIElements.IStyle.get_visibility() { }

	[Address(RVA = "0x3240F80", Offset = "0x3240380", Length = "0x87")]
	[Token(Token = "0x600164B")]
	private override StyleEnum<WhiteSpace> UnityEngine.UIElements.IStyle.get_whiteSpace() { }

	[Address(RVA = "0x3241010", Offset = "0x3240410", Length = "0x3B")]
	[Token(Token = "0x600164D")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	[Address(RVA = "0x3241050", Offset = "0x3240450", Length = "0x3B")]
	[Token(Token = "0x600164F")]
	private override StyleLength UnityEngine.UIElements.IStyle.get_wordSpacing() { }

	[Address(RVA = "0x3241090", Offset = "0x3240490", Length = "0xA7")]
	[Token(Token = "0x60015B4")]
	private override void UnityEngine.UIElements.IStyle.set_alignContent(StyleEnum<Align> value) { }

	[Address(RVA = "0x3241140", Offset = "0x3240540", Length = "0xA7")]
	[Token(Token = "0x60015B6")]
	private override void UnityEngine.UIElements.IStyle.set_alignItems(StyleEnum<Align> value) { }

	[Address(RVA = "0x32411F0", Offset = "0x32405F0", Length = "0xA7")]
	[Token(Token = "0x60015B8")]
	private override void UnityEngine.UIElements.IStyle.set_alignSelf(StyleEnum<Align> value) { }

	[Address(RVA = "0x32412A0", Offset = "0x32406A0", Length = "0x1D0")]
	[Token(Token = "0x60015BA")]
	private override void UnityEngine.UIElements.IStyle.set_aspectRatio(StyleRatio value) { }

	[Address(RVA = "0x3241480", Offset = "0x3240880", Length = "0x54")]
	[Token(Token = "0x60015BC")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	[Address(RVA = "0x32414E0", Offset = "0x32408E0", Length = "0x61")]
	[Token(Token = "0x60015BE")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundImage(StyleBackground value) { }

	[Address(RVA = "0x3241550", Offset = "0x3240950", Length = "0x4D")]
	[Token(Token = "0x60015C0")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionX(StyleBackgroundPosition value) { }

	[Address(RVA = "0x32415A0", Offset = "0x32409A0", Length = "0x4D")]
	[Token(Token = "0x60015C2")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundPositionY(StyleBackgroundPosition value) { }

	[Address(RVA = "0x32415F0", Offset = "0x32409F0", Length = "0x169")]
	[Token(Token = "0x60015C4")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundRepeat(StyleBackgroundRepeat value) { }

	[Address(RVA = "0x3241760", Offset = "0x3240B60", Length = "0x16C")]
	[Token(Token = "0x600165F")]
	private override void UnityEngine.UIElements.IStyle.set_backgroundSize(StyleBackgroundSize value) { }

	[Address(RVA = "0x32418D0", Offset = "0x3240CD0", Length = "0x54")]
	[Token(Token = "0x60015C6")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	[Address(RVA = "0x3241930", Offset = "0x3240D30", Length = "0x56")]
	[Token(Token = "0x60015C8")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	[Address(RVA = "0x3241990", Offset = "0x3240D90", Length = "0x56")]
	[Token(Token = "0x60015CA")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	[Address(RVA = "0x32419F0", Offset = "0x3240DF0", Length = "0x83")]
	[Token(Token = "0x60015CC")]
	private override void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	[Address(RVA = "0x3241A80", Offset = "0x3240E80", Length = "0x54")]
	[Token(Token = "0x60015CE")]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	[Address(RVA = "0x3241AE0", Offset = "0x3240EE0", Length = "0x83")]
	[Token(Token = "0x60015D0")]
	private override void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	[Address(RVA = "0x3241B70", Offset = "0x3240F70", Length = "0x54")]
	[Token(Token = "0x60015D2")]
	private override void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	[Address(RVA = "0x3241BD0", Offset = "0x3240FD0", Length = "0x83")]
	[Token(Token = "0x60015D4")]
	private override void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	[Address(RVA = "0x3241C60", Offset = "0x3241060", Length = "0x54")]
	[Token(Token = "0x60015D6")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	[Address(RVA = "0x3241CC0", Offset = "0x32410C0", Length = "0x56")]
	[Token(Token = "0x60015D8")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	[Address(RVA = "0x3241D20", Offset = "0x3241120", Length = "0x56")]
	[Token(Token = "0x60015DA")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	[Address(RVA = "0x3241D80", Offset = "0x3241180", Length = "0x83")]
	[Token(Token = "0x60015DC")]
	private override void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	[Address(RVA = "0x3241E10", Offset = "0x3241210", Length = "0xA0")]
	[Token(Token = "0x60015DE")]
	private override void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	[Address(RVA = "0x3241EC0", Offset = "0x32412C0", Length = "0x54")]
	[Token(Token = "0x60015E0")]
	private override void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	[Address(RVA = "0x3241F20", Offset = "0x3241320", Length = "0x1D7")]
	[Token(Token = "0x6001659")]
	private override void UnityEngine.UIElements.IStyle.set_cursor(StyleCursor value) { }

	[Address(RVA = "0x3242100", Offset = "0x3241500", Length = "0xA7")]
	[Token(Token = "0x60015E2")]
	private override void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	[Address(RVA = "0x32421B0", Offset = "0x32415B0", Length = "0x168")]
	[Token(Token = "0x6001661")]
	private override void UnityEngine.UIElements.IStyle.set_filter(StyleList<FilterFunction> value) { }

	[Address(RVA = "0x3242320", Offset = "0x3241720", Length = "0xA0")]
	[Token(Token = "0x60015E4")]
	private override void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	[Address(RVA = "0x32423D0", Offset = "0x32417D0", Length = "0xA7")]
	[Token(Token = "0x60015E6")]
	private override void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	[Address(RVA = "0x3242480", Offset = "0x3241880", Length = "0x83")]
	[Token(Token = "0x60015E8")]
	private override void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	[Address(RVA = "0x3242510", Offset = "0x3241910", Length = "0x83")]
	[Token(Token = "0x60015EA")]
	private override void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	[Address(RVA = "0x32425A0", Offset = "0x32419A0", Length = "0xA7")]
	[Token(Token = "0x60015EC")]
	private override void UnityEngine.UIElements.IStyle.set_flexWrap(StyleEnum<Wrap> value) { }

	[Address(RVA = "0x3242650", Offset = "0x3241A50", Length = "0x56")]
	[Token(Token = "0x60015EE")]
	private override void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	[Address(RVA = "0x32426B0", Offset = "0x3241AB0", Length = "0xA0")]
	[Token(Token = "0x60015F0")]
	private override void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	[Address(RVA = "0x3242760", Offset = "0x3241B60", Length = "0xA7")]
	[Token(Token = "0x60015F2")]
	private override void UnityEngine.UIElements.IStyle.set_justifyContent(StyleEnum<Justify> value) { }

	[Address(RVA = "0x3242810", Offset = "0x3241C10", Length = "0xA0")]
	[Token(Token = "0x60015F4")]
	private override void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	[Address(RVA = "0x32428C0", Offset = "0x3241CC0", Length = "0x56")]
	[Token(Token = "0x60015F6")]
	private override void UnityEngine.UIElements.IStyle.set_letterSpacing(StyleLength value) { }

	[Address(RVA = "0x3242920", Offset = "0x3241D20", Length = "0xA0")]
	[Token(Token = "0x60015F8")]
	private override void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	[Address(RVA = "0x32429D0", Offset = "0x3241DD0", Length = "0xA0")]
	[Token(Token = "0x60015FA")]
	private override void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	[Address(RVA = "0x3242A80", Offset = "0x3241E80", Length = "0xA0")]
	[Token(Token = "0x60015FC")]
	private override void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	[Address(RVA = "0x3242B30", Offset = "0x3241F30", Length = "0xA0")]
	[Token(Token = "0x60015FE")]
	private override void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	[Address(RVA = "0x3242BE0", Offset = "0x3241FE0", Length = "0xA0")]
	[Token(Token = "0x6001600")]
	private override void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	[Address(RVA = "0x3242C90", Offset = "0x3242090", Length = "0xA0")]
	[Token(Token = "0x6001602")]
	private override void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	[Address(RVA = "0x3242D40", Offset = "0x3242140", Length = "0xA0")]
	[Token(Token = "0x6001604")]
	private override void UnityEngine.UIElements.IStyle.set_minHeight(StyleLength value) { }

	[Address(RVA = "0x3242DF0", Offset = "0x32421F0", Length = "0xA0")]
	[Token(Token = "0x6001606")]
	private override void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	[Address(RVA = "0x3242EA0", Offset = "0x32422A0", Length = "0x43")]
	[Token(Token = "0x6001608")]
	private override void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	[Address(RVA = "0x3242EF0", Offset = "0x32422F0", Length = "0x112")]
	[Token(Token = "0x600160A")]
	private override void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	[Address(RVA = "0x3243010", Offset = "0x3242410", Length = "0xA0")]
	[Token(Token = "0x600160C")]
	private override void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	[Address(RVA = "0x32430C0", Offset = "0x32424C0", Length = "0xA0")]
	[Token(Token = "0x600160E")]
	private override void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	[Address(RVA = "0x3243170", Offset = "0x3242570", Length = "0xA0")]
	[Token(Token = "0x6001610")]
	private override void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	[Address(RVA = "0x3243220", Offset = "0x3242620", Length = "0xA0")]
	[Token(Token = "0x6001612")]
	private override void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	[Address(RVA = "0x32432D0", Offset = "0x32426D0", Length = "0xA7")]
	[Token(Token = "0x6001614")]
	private override void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	[Address(RVA = "0x3243380", Offset = "0x3242780", Length = "0xA0")]
	[Token(Token = "0x6001616")]
	private override void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	[Address(RVA = "0x3243430", Offset = "0x3242830", Length = "0x1A7")]
	[Token(Token = "0x600166A")]
	private override void UnityEngine.UIElements.IStyle.set_rotate(StyleRotate value) { }

	[Address(RVA = "0x32435E0", Offset = "0x32429E0", Length = "0x164")]
	[Token(Token = "0x600166C")]
	private override void UnityEngine.UIElements.IStyle.set_scale(StyleScale value) { }

	[Address(RVA = "0x3243750", Offset = "0x3242B50", Length = "0x6D")]
	[Token(Token = "0x6001618")]
	private override void UnityEngine.UIElements.IStyle.set_textOverflow(StyleEnum<TextOverflow> value) { }

	[Address(RVA = "0x32437C0", Offset = "0x3242BC0", Length = "0x1C1")]
	[Token(Token = "0x600165B")]
	private override void UnityEngine.UIElements.IStyle.set_textShadow(StyleTextShadow value) { }

	[Address(RVA = "0x3243990", Offset = "0x3242D90", Length = "0xA0")]
	[Token(Token = "0x600161A")]
	private override void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	[Address(RVA = "0x3243A40", Offset = "0x3242E40", Length = "0x16C")]
	[Token(Token = "0x6001666")]
	private override void UnityEngine.UIElements.IStyle.set_transformOrigin(StyleTransformOrigin value) { }

	[Address(RVA = "0x3243BB0", Offset = "0x3242FB0", Length = "0x77")]
	[Token(Token = "0x600161C")]
	private override void UnityEngine.UIElements.IStyle.set_transitionDelay(StyleList<TimeValue> value) { }

	[Address(RVA = "0x3243C30", Offset = "0x3243030", Length = "0x77")]
	[Token(Token = "0x600161E")]
	private override void UnityEngine.UIElements.IStyle.set_transitionDuration(StyleList<TimeValue> value) { }

	[Address(RVA = "0x3243CB0", Offset = "0x32430B0", Length = "0x77")]
	[Token(Token = "0x6001620")]
	private override void UnityEngine.UIElements.IStyle.set_transitionProperty(StyleList<StylePropertyName> value) { }

	[Address(RVA = "0x3243D30", Offset = "0x3243130", Length = "0x77")]
	[Token(Token = "0x6001622")]
	private override void UnityEngine.UIElements.IStyle.set_transitionTimingFunction(StyleList<EasingFunction> value) { }

	[Address(RVA = "0x3243DB0", Offset = "0x32431B0", Length = "0x1A7")]
	[Token(Token = "0x6001668")]
	private override void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	[Address(RVA = "0x3243F60", Offset = "0x3243360", Length = "0x54")]
	[Token(Token = "0x6001624")]
	private override void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	[Address(RVA = "0x3243FC0", Offset = "0x32433C0", Length = "0x6D")]
	[Token(Token = "0x6001626")]
	private override void UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode(StyleEnum<EditorTextRenderingMode> value) { }

	[Address(RVA = "0x3244100", Offset = "0x3243500", Length = "0x4D")]
	[Token(Token = "0x6001628")]
	private override void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	[Address(RVA = "0x3244030", Offset = "0x3243430", Length = "0x58")]
	[Token(Token = "0x600162A")]
	private override void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	[Address(RVA = "0x3244090", Offset = "0x3243490", Length = "0x6D")]
	[Token(Token = "0x600162C")]
	private override void UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight(StyleEnum<FontStyle> value) { }

	[Address(RVA = "0x3244150", Offset = "0x3243550", Length = "0x58")]
	[Token(Token = "0x600162E")]
	private override void UnityEngine.UIElements.IStyle.set_unityMaterial(StyleMaterialDefinition value) { }

	[Address(RVA = "0x32441B0", Offset = "0x32435B0", Length = "0x6D")]
	[Token(Token = "0x6001630")]
	private override void UnityEngine.UIElements.IStyle.set_unityOverflowClipBox(StyleEnum<OverflowClipBox> value) { }

	[Address(RVA = "0x3244220", Offset = "0x3243620", Length = "0x56")]
	[Token(Token = "0x6001632")]
	private override void UnityEngine.UIElements.IStyle.set_unityParagraphSpacing(StyleLength value) { }

	[Address(RVA = "0x3244280", Offset = "0x3243680", Length = "0x43")]
	[Token(Token = "0x6001634")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceBottom(StyleInt value) { }

	[Address(RVA = "0x32442D0", Offset = "0x32436D0", Length = "0x43")]
	[Token(Token = "0x6001636")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceLeft(StyleInt value) { }

	[Address(RVA = "0x3244320", Offset = "0x3243720", Length = "0x43")]
	[Token(Token = "0x6001638")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceRight(StyleInt value) { }

	[Address(RVA = "0x3244370", Offset = "0x3243770", Length = "0x43")]
	[Token(Token = "0x600163A")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceScale(StyleFloat value) { }

	[Address(RVA = "0x32443C0", Offset = "0x32437C0", Length = "0x43")]
	[Token(Token = "0x600163C")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceTop(StyleInt value) { }

	[Address(RVA = "0x3244410", Offset = "0x3243810", Length = "0x6D")]
	[Token(Token = "0x600163E")]
	private override void UnityEngine.UIElements.IStyle.set_unitySliceType(StyleEnum<SliceType> value) { }

	[Address(RVA = "0x3244480", Offset = "0x3243880", Length = "0x6D")]
	[Token(Token = "0x6001640")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextAlign(StyleEnum<TextAnchor> value) { }

	[Address(RVA = "0x32444F0", Offset = "0x32438F0", Length = "0x1E7")]
	[Token(Token = "0x600165D")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextAutoSize(StyleTextAutoSize value) { }

	[Address(RVA = "0x32446E0", Offset = "0x3243AE0", Length = "0x6D")]
	[Token(Token = "0x6001642")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextGenerator(StyleEnum<TextGeneratorType> value) { }

	[Address(RVA = "0x3244750", Offset = "0x3243B50", Length = "0x54")]
	[Token(Token = "0x6001644")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineColor(StyleColor value) { }

	[Address(RVA = "0x32447B0", Offset = "0x3243BB0", Length = "0x43")]
	[Token(Token = "0x6001646")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth(StyleFloat value) { }

	[Address(RVA = "0x3244800", Offset = "0x3243C00", Length = "0x6D")]
	[Token(Token = "0x6001648")]
	private override void UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition(StyleEnum<TextOverflowPosition> value) { }

	[Address(RVA = "0x3244870", Offset = "0x3243C70", Length = "0x6D")]
	[Token(Token = "0x600164A")]
	private override void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	[Address(RVA = "0x32448E0", Offset = "0x3243CE0", Length = "0x6D")]
	[Token(Token = "0x600164C")]
	private override void UnityEngine.UIElements.IStyle.set_whiteSpace(StyleEnum<WhiteSpace> value) { }

	[Address(RVA = "0x3244950", Offset = "0x3243D50", Length = "0xA0")]
	[Token(Token = "0x600164E")]
	private override void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	[Address(RVA = "0x3244A00", Offset = "0x3243E00", Length = "0x56")]
	[Token(Token = "0x6001650")]
	private override void UnityEngine.UIElements.IStyle.set_wordSpacing(StyleLength value) { }

}

