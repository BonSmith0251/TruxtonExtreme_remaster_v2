namespace UnityEngine.UIElements;

[Token(Token = "0x200030C")]
internal class InlineStyleAccessPropertyBag : PropertyBag<InlineStyleAccess>, INamedProperties<InlineStyleAccess>
{
	[Token(Token = "0x200030D")]
	private class AlignContentProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004D2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016A1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D0")]
		public virtual string Name
		{
			[Address(RVA = "0x322EBE0", Offset = "0x322DFE0", Length = "0x2C")]
			[Token(Token = "0x600169F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D1")]
		public virtual string ussName
		{
			[Address(RVA = "0x322EC10", Offset = "0x322E010", Length = "0x2C")]
			[Token(Token = "0x60016A0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322EBA0", Offset = "0x322DFA0", Length = "0x39")]
		[Token(Token = "0x60016A4")]
		public AlignContentProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016A1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322EBE0", Offset = "0x322DFE0", Length = "0x2C")]
		[Token(Token = "0x600169F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322EC10", Offset = "0x322E010", Length = "0x2C")]
		[Token(Token = "0x60016A0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322EAF0", Offset = "0x322DEF0", Length = "0x45")]
		[Token(Token = "0x60016A2")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322EB40", Offset = "0x322DF40", Length = "0x57")]
		[Token(Token = "0x60016A3")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x200030E")]
	private class AlignItemsProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004D5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016A7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D3")]
		public virtual string Name
		{
			[Address(RVA = "0x322ED30", Offset = "0x322E130", Length = "0x2C")]
			[Token(Token = "0x60016A5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D4")]
		public virtual string ussName
		{
			[Address(RVA = "0x322ED60", Offset = "0x322E160", Length = "0x2C")]
			[Token(Token = "0x60016A6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322ECF0", Offset = "0x322E0F0", Length = "0x39")]
		[Token(Token = "0x60016AA")]
		public AlignItemsProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016A7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322ED30", Offset = "0x322E130", Length = "0x2C")]
		[Token(Token = "0x60016A5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322ED60", Offset = "0x322E160", Length = "0x2C")]
		[Token(Token = "0x60016A6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322EC40", Offset = "0x322E040", Length = "0x48")]
		[Token(Token = "0x60016A8")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322EC90", Offset = "0x322E090", Length = "0x57")]
		[Token(Token = "0x60016A9")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x200030F")]
	private class AlignSelfProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004D8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016AD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D6")]
		public virtual string Name
		{
			[Address(RVA = "0x322EE80", Offset = "0x322E280", Length = "0x2C")]
			[Token(Token = "0x60016AB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D7")]
		public virtual string ussName
		{
			[Address(RVA = "0x322EEB0", Offset = "0x322E2B0", Length = "0x2C")]
			[Token(Token = "0x60016AC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322EE40", Offset = "0x322E240", Length = "0x39")]
		[Token(Token = "0x60016B0")]
		public AlignSelfProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016AD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322EE80", Offset = "0x322E280", Length = "0x2C")]
		[Token(Token = "0x60016AB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322EEB0", Offset = "0x322E2B0", Length = "0x2C")]
		[Token(Token = "0x60016AC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322ED90", Offset = "0x322E190", Length = "0x48")]
		[Token(Token = "0x60016AE")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322EDE0", Offset = "0x322E1E0", Length = "0x57")]
		[Token(Token = "0x60016AF")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x2000310")]
	private class AspectRatioProperty : InlineStyleRatioProperty
	{

		[Token(Token = "0x170004DB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016B3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D9")]
		public virtual string Name
		{
			[Address(RVA = "0x322F7B0", Offset = "0x322EBB0", Length = "0x2C")]
			[Token(Token = "0x60016B1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004DA")]
		public virtual string ussName
		{
			[Address(RVA = "0x322F7E0", Offset = "0x322EBE0", Length = "0x2C")]
			[Token(Token = "0x60016B2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F7A0", Offset = "0x322EBA0", Length = "0x7")]
		[Token(Token = "0x60016B6")]
		public AspectRatioProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016B3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322F7B0", Offset = "0x322EBB0", Length = "0x2C")]
		[Token(Token = "0x60016B1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322F7E0", Offset = "0x322EBE0", Length = "0x2C")]
		[Token(Token = "0x60016B2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322F620", Offset = "0x322EA20", Length = "0xBC")]
		[Token(Token = "0x60016B4")]
		public virtual StyleRatio GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322F6E0", Offset = "0x322EAE0", Length = "0xB7")]
		[Token(Token = "0x60016B5")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleRatio value) { }

	}

	[Token(Token = "0x2000311")]
	private class BackgroundColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004DE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016B9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004DC")]
		public virtual string Name
		{
			[Address(RVA = "0x322F9E0", Offset = "0x322EDE0", Length = "0x2C")]
			[Token(Token = "0x60016B7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004DD")]
		public virtual string ussName
		{
			[Address(RVA = "0x322FA10", Offset = "0x322EE10", Length = "0x2C")]
			[Token(Token = "0x60016B8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x60016BC")]
		public BackgroundColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016B9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322F9E0", Offset = "0x322EDE0", Length = "0x2C")]
		[Token(Token = "0x60016B7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322FA10", Offset = "0x322EE10", Length = "0x2C")]
		[Token(Token = "0x60016B8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322F810", Offset = "0x322EC10", Length = "0xD5")]
		[Token(Token = "0x60016BA")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322F8F0", Offset = "0x322ECF0", Length = "0xD5")]
		[Token(Token = "0x60016BB")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000312")]
	private class BackgroundImageProperty : InlineStyleBackgroundProperty
	{

		[Token(Token = "0x170004E1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016BF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004DF")]
		public virtual string Name
		{
			[Address(RVA = "0x322FC30", Offset = "0x322F030", Length = "0x2C")]
			[Token(Token = "0x60016BD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E0")]
		public virtual string ussName
		{
			[Address(RVA = "0x322FC60", Offset = "0x322F060", Length = "0x2C")]
			[Token(Token = "0x60016BE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322FC20", Offset = "0x322F020", Length = "0x7")]
		[Token(Token = "0x60016C2")]
		public BackgroundImageProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016BF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322FC30", Offset = "0x322F030", Length = "0x2C")]
		[Token(Token = "0x60016BD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322FC60", Offset = "0x322F060", Length = "0x2C")]
		[Token(Token = "0x60016BE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322FA40", Offset = "0x322EE40", Length = "0xE1")]
		[Token(Token = "0x60016C0")]
		public virtual StyleBackground GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322FB30", Offset = "0x322EF30", Length = "0xE2")]
		[Token(Token = "0x60016C1")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackground value) { }

	}

	[Token(Token = "0x2000313")]
	private class BackgroundPositionXProperty : InlineStyleBackgroundPositionProperty
	{

		[Token(Token = "0x170004E4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016C5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E2")]
		public virtual string Name
		{
			[Address(RVA = "0x322FE40", Offset = "0x322F240", Length = "0x2C")]
			[Token(Token = "0x60016C3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E3")]
		public virtual string ussName
		{
			[Address(RVA = "0x322FE70", Offset = "0x322F270", Length = "0x2C")]
			[Token(Token = "0x60016C4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322FE30", Offset = "0x322F230", Length = "0x7")]
		[Token(Token = "0x60016C8")]
		public BackgroundPositionXProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016C5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x322FE40", Offset = "0x322F240", Length = "0x2C")]
		[Token(Token = "0x60016C3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x322FE70", Offset = "0x322F270", Length = "0x2C")]
		[Token(Token = "0x60016C4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322FC90", Offset = "0x322F090", Length = "0xCF")]
		[Token(Token = "0x60016C6")]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322FD60", Offset = "0x322F160", Length = "0xCE")]
		[Token(Token = "0x60016C7")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	[Token(Token = "0x2000314")]
	private class BackgroundPositionYProperty : InlineStyleBackgroundPositionProperty
	{

		[Token(Token = "0x170004E7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016CB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E5")]
		public virtual string Name
		{
			[Address(RVA = "0x3230040", Offset = "0x322F440", Length = "0x2C")]
			[Token(Token = "0x60016C9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E6")]
		public virtual string ussName
		{
			[Address(RVA = "0x3230070", Offset = "0x322F470", Length = "0x2C")]
			[Token(Token = "0x60016CA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322FE30", Offset = "0x322F230", Length = "0x7")]
		[Token(Token = "0x60016CE")]
		public BackgroundPositionYProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016CB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3230040", Offset = "0x322F440", Length = "0x2C")]
		[Token(Token = "0x60016C9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3230070", Offset = "0x322F470", Length = "0x2C")]
		[Token(Token = "0x60016CA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x322FEA0", Offset = "0x322F2A0", Length = "0xCF")]
		[Token(Token = "0x60016CC")]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x322FF70", Offset = "0x322F370", Length = "0xCE")]
		[Token(Token = "0x60016CD")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	[Token(Token = "0x2000315")]
	private class BackgroundRepeatProperty : InlineStyleBackgroundRepeatProperty
	{

		[Token(Token = "0x170004EA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016D1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E8")]
		public virtual string Name
		{
			[Address(RVA = "0x3230270", Offset = "0x322F670", Length = "0x2C")]
			[Token(Token = "0x60016CF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E9")]
		public virtual string ussName
		{
			[Address(RVA = "0x32302A0", Offset = "0x322F6A0", Length = "0x2C")]
			[Token(Token = "0x60016D0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3230260", Offset = "0x322F660", Length = "0x7")]
		[Token(Token = "0x60016D4")]
		public BackgroundRepeatProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016D1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3230270", Offset = "0x322F670", Length = "0x2C")]
		[Token(Token = "0x60016CF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32302A0", Offset = "0x322F6A0", Length = "0x2C")]
		[Token(Token = "0x60016D0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32300A0", Offset = "0x322F4A0", Length = "0xD7")]
		[Token(Token = "0x60016D2")]
		public virtual StyleBackgroundRepeat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3230180", Offset = "0x322F580", Length = "0xD7")]
		[Token(Token = "0x60016D3")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundRepeat value) { }

	}

	[Token(Token = "0x2000316")]
	private class BackgroundSizeProperty : InlineStyleBackgroundSizeProperty
	{

		[Token(Token = "0x170004ED")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016D7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004EB")]
		public virtual string Name
		{
			[Address(RVA = "0x3230430", Offset = "0x322F830", Length = "0x2C")]
			[Token(Token = "0x60016D5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004EC")]
		public virtual string ussName
		{
			[Address(RVA = "0x3230460", Offset = "0x322F860", Length = "0x2C")]
			[Token(Token = "0x60016D6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3230420", Offset = "0x322F820", Length = "0x7")]
		[Token(Token = "0x60016DA")]
		public BackgroundSizeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016D7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3230430", Offset = "0x322F830", Length = "0x2C")]
		[Token(Token = "0x60016D5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3230460", Offset = "0x322F860", Length = "0x2C")]
		[Token(Token = "0x60016D6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32302D0", Offset = "0x322F6D0", Length = "0x6D")]
		[Token(Token = "0x60016D8")]
		public virtual StyleBackgroundSize GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3230340", Offset = "0x322F740", Length = "0xD9")]
		[Token(Token = "0x60016D9")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundSize value) { }

	}

	[Token(Token = "0x2000317")]
	private class BorderBottomColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004F0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016DD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004EE")]
		public virtual string Name
		{
			[Address(RVA = "0x32317E0", Offset = "0x3230BE0", Length = "0x2C")]
			[Token(Token = "0x60016DB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004EF")]
		public virtual string ussName
		{
			[Address(RVA = "0x3231810", Offset = "0x3230C10", Length = "0x2C")]
			[Token(Token = "0x60016DC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x60016E0")]
		public BorderBottomColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016DD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32317E0", Offset = "0x3230BE0", Length = "0x2C")]
		[Token(Token = "0x60016DB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3231810", Offset = "0x3230C10", Length = "0x2C")]
		[Token(Token = "0x60016DC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231620", Offset = "0x3230A20", Length = "0xD5")]
		[Token(Token = "0x60016DE")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3231700", Offset = "0x3230B00", Length = "0xD5")]
		[Token(Token = "0x60016DF")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000318")]
	private class BorderBottomLeftRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004F3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016E3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F1")]
		public virtual string Name
		{
			[Address(RVA = "0x3231A10", Offset = "0x3230E10", Length = "0x2C")]
			[Token(Token = "0x60016E1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F2")]
		public virtual string ussName
		{
			[Address(RVA = "0x3231A40", Offset = "0x3230E40", Length = "0x2C")]
			[Token(Token = "0x60016E2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60016E6")]
		public BorderBottomLeftRadiusProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016E3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3231A10", Offset = "0x3230E10", Length = "0x2C")]
		[Token(Token = "0x60016E1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3231A40", Offset = "0x3230E40", Length = "0x2C")]
		[Token(Token = "0x60016E2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231840", Offset = "0x3230C40", Length = "0xD7")]
		[Token(Token = "0x60016E4")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3231920", Offset = "0x3230D20", Length = "0xD7")]
		[Token(Token = "0x60016E5")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000319")]
	private class BorderBottomRightRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004F6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016E9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F4")]
		public virtual string Name
		{
			[Address(RVA = "0x3231C30", Offset = "0x3231030", Length = "0x2C")]
			[Token(Token = "0x60016E7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F5")]
		public virtual string ussName
		{
			[Address(RVA = "0x3231C60", Offset = "0x3231060", Length = "0x2C")]
			[Token(Token = "0x60016E8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60016EC")]
		public BorderBottomRightRadiusProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016E9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3231C30", Offset = "0x3231030", Length = "0x2C")]
		[Token(Token = "0x60016E7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3231C60", Offset = "0x3231060", Length = "0x2C")]
		[Token(Token = "0x60016E8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231A70", Offset = "0x3230E70", Length = "0xD7")]
		[Token(Token = "0x60016EA")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3231B50", Offset = "0x3230F50", Length = "0xD7")]
		[Token(Token = "0x60016EB")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200031A")]
	private class BorderBottomWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004F9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016EF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F7")]
		public virtual string Name
		{
			[Address(RVA = "0x3231D50", Offset = "0x3231150", Length = "0x2C")]
			[Token(Token = "0x60016ED")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F8")]
		public virtual string ussName
		{
			[Address(RVA = "0x3231D80", Offset = "0x3231180", Length = "0x2C")]
			[Token(Token = "0x60016EE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x60016F2")]
		public BorderBottomWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016EF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3231D50", Offset = "0x3231150", Length = "0x2C")]
		[Token(Token = "0x60016ED")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3231D80", Offset = "0x3231180", Length = "0x2C")]
		[Token(Token = "0x60016EE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231C90", Offset = "0x3231090", Length = "0x48")]
		[Token(Token = "0x60016F0")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3231CE0", Offset = "0x32310E0", Length = "0x57")]
		[Token(Token = "0x60016F1")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200031B")]
	private class BorderLeftColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004FC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016F5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004FA")]
		public virtual string Name
		{
			[Address(RVA = "0x3231F70", Offset = "0x3231370", Length = "0x2C")]
			[Token(Token = "0x60016F3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004FB")]
		public virtual string ussName
		{
			[Address(RVA = "0x3231FA0", Offset = "0x32313A0", Length = "0x2C")]
			[Token(Token = "0x60016F4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x60016F8")]
		public BorderLeftColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016F5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3231F70", Offset = "0x3231370", Length = "0x2C")]
		[Token(Token = "0x60016F3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3231FA0", Offset = "0x32313A0", Length = "0x2C")]
		[Token(Token = "0x60016F4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231DB0", Offset = "0x32311B0", Length = "0xD5")]
		[Token(Token = "0x60016F6")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3231E90", Offset = "0x3231290", Length = "0xD5")]
		[Token(Token = "0x60016F7")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200031C")]
	private class BorderLeftWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004FF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60016FB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004FD")]
		public virtual string Name
		{
			[Address(RVA = "0x3232080", Offset = "0x3231480", Length = "0x2C")]
			[Token(Token = "0x60016F9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004FE")]
		public virtual string ussName
		{
			[Address(RVA = "0x32320B0", Offset = "0x32314B0", Length = "0x2C")]
			[Token(Token = "0x60016FA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x60016FE")]
		public BorderLeftWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016FB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3232080", Offset = "0x3231480", Length = "0x2C")]
		[Token(Token = "0x60016F9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32320B0", Offset = "0x32314B0", Length = "0x2C")]
		[Token(Token = "0x60016FA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3231FD0", Offset = "0x32313D0", Length = "0x48")]
		[Token(Token = "0x60016FC")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232020", Offset = "0x3231420", Length = "0x57")]
		[Token(Token = "0x60016FD")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200031D")]
	private class BorderRightColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000502")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001701")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000500")]
		public virtual string Name
		{
			[Address(RVA = "0x32322A0", Offset = "0x32316A0", Length = "0x2C")]
			[Token(Token = "0x60016FF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000501")]
		public virtual string ussName
		{
			[Address(RVA = "0x32322D0", Offset = "0x32316D0", Length = "0x2C")]
			[Token(Token = "0x6001700")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x6001704")]
		public BorderRightColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001701")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32322A0", Offset = "0x32316A0", Length = "0x2C")]
		[Token(Token = "0x60016FF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32322D0", Offset = "0x32316D0", Length = "0x2C")]
		[Token(Token = "0x6001700")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32320E0", Offset = "0x32314E0", Length = "0xD5")]
		[Token(Token = "0x6001702")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32321C0", Offset = "0x32315C0", Length = "0xD5")]
		[Token(Token = "0x6001703")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200031E")]
	private class BorderRightWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000505")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001707")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000503")]
		public virtual string Name
		{
			[Address(RVA = "0x32323B0", Offset = "0x32317B0", Length = "0x2C")]
			[Token(Token = "0x6001705")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000504")]
		public virtual string ussName
		{
			[Address(RVA = "0x32323E0", Offset = "0x32317E0", Length = "0x2C")]
			[Token(Token = "0x6001706")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x600170A")]
		public BorderRightWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001707")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32323B0", Offset = "0x32317B0", Length = "0x2C")]
		[Token(Token = "0x6001705")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32323E0", Offset = "0x32317E0", Length = "0x2C")]
		[Token(Token = "0x6001706")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232300", Offset = "0x3231700", Length = "0x48")]
		[Token(Token = "0x6001708")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232350", Offset = "0x3231750", Length = "0x57")]
		[Token(Token = "0x6001709")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200031F")]
	private class BorderTopColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000508")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600170D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000506")]
		public virtual string Name
		{
			[Address(RVA = "0x32325D0", Offset = "0x32319D0", Length = "0x2C")]
			[Token(Token = "0x600170B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000507")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232600", Offset = "0x3231A00", Length = "0x2C")]
			[Token(Token = "0x600170C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x6001710")]
		public BorderTopColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600170D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32325D0", Offset = "0x32319D0", Length = "0x2C")]
		[Token(Token = "0x600170B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232600", Offset = "0x3231A00", Length = "0x2C")]
		[Token(Token = "0x600170C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232410", Offset = "0x3231810", Length = "0xD5")]
		[Token(Token = "0x600170E")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32324F0", Offset = "0x32318F0", Length = "0xD5")]
		[Token(Token = "0x600170F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000320")]
	private class BorderTopLeftRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700050B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001713")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000509")]
		public virtual string Name
		{
			[Address(RVA = "0x32327F0", Offset = "0x3231BF0", Length = "0x2C")]
			[Token(Token = "0x6001711")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700050A")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232820", Offset = "0x3231C20", Length = "0x2C")]
			[Token(Token = "0x6001712")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001716")]
		public BorderTopLeftRadiusProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001713")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32327F0", Offset = "0x3231BF0", Length = "0x2C")]
		[Token(Token = "0x6001711")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232820", Offset = "0x3231C20", Length = "0x2C")]
		[Token(Token = "0x6001712")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232630", Offset = "0x3231A30", Length = "0xD7")]
		[Token(Token = "0x6001714")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232710", Offset = "0x3231B10", Length = "0xD7")]
		[Token(Token = "0x6001715")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000321")]
	private class BorderTopRightRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700050E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001719")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700050C")]
		public virtual string Name
		{
			[Address(RVA = "0x3232A10", Offset = "0x3231E10", Length = "0x2C")]
			[Token(Token = "0x6001717")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700050D")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232A40", Offset = "0x3231E40", Length = "0x2C")]
			[Token(Token = "0x6001718")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600171C")]
		public BorderTopRightRadiusProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001719")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3232A10", Offset = "0x3231E10", Length = "0x2C")]
		[Token(Token = "0x6001717")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232A40", Offset = "0x3231E40", Length = "0x2C")]
		[Token(Token = "0x6001718")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232850", Offset = "0x3231C50", Length = "0xD7")]
		[Token(Token = "0x600171A")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232930", Offset = "0x3231D30", Length = "0xD7")]
		[Token(Token = "0x600171B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000322")]
	private class BorderTopWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000511")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600171F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700050F")]
		public virtual string Name
		{
			[Address(RVA = "0x3232B20", Offset = "0x3231F20", Length = "0x2C")]
			[Token(Token = "0x600171D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000510")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232B50", Offset = "0x3231F50", Length = "0x2C")]
			[Token(Token = "0x600171E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x6001722")]
		public BorderTopWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600171F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3232B20", Offset = "0x3231F20", Length = "0x2C")]
		[Token(Token = "0x600171D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232B50", Offset = "0x3231F50", Length = "0x2C")]
		[Token(Token = "0x600171E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232A70", Offset = "0x3231E70", Length = "0x48")]
		[Token(Token = "0x6001720")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232AC0", Offset = "0x3231EC0", Length = "0x57")]
		[Token(Token = "0x6001721")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000323")]
	private class BottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000514")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001725")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000512")]
		public virtual string Name
		{
			[Address(RVA = "0x3232D40", Offset = "0x3232140", Length = "0x2C")]
			[Token(Token = "0x6001723")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000513")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232D70", Offset = "0x3232170", Length = "0x2C")]
			[Token(Token = "0x6001724")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001728")]
		public BottomProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001725")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3232D40", Offset = "0x3232140", Length = "0x2C")]
		[Token(Token = "0x6001723")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232D70", Offset = "0x3232170", Length = "0x2C")]
		[Token(Token = "0x6001724")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232B80", Offset = "0x3231F80", Length = "0xD7")]
		[Token(Token = "0x6001726")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232C60", Offset = "0x3232060", Length = "0xD7")]
		[Token(Token = "0x6001727")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000324")]
	private class ColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000517")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600172B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000515")]
		public virtual string Name
		{
			[Address(RVA = "0x3232F60", Offset = "0x3232360", Length = "0x2C")]
			[Token(Token = "0x6001729")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000516")]
		public virtual string ussName
		{
			[Address(RVA = "0x3232F90", Offset = "0x3232390", Length = "0x2C")]
			[Token(Token = "0x600172A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x600172E")]
		public ColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600172B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3232F60", Offset = "0x3232360", Length = "0x2C")]
		[Token(Token = "0x6001729")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3232F90", Offset = "0x3232390", Length = "0x2C")]
		[Token(Token = "0x600172A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3232DA0", Offset = "0x32321A0", Length = "0xD5")]
		[Token(Token = "0x600172C")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3232E80", Offset = "0x3232280", Length = "0xD5")]
		[Token(Token = "0x600172D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000325")]
	private class CursorProperty : InlineStyleCursorProperty
	{

		[Token(Token = "0x1700051A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001731")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000518")]
		public virtual string Name
		{
			[Address(RVA = "0x32354E0", Offset = "0x32348E0", Length = "0x2C")]
			[Token(Token = "0x600172F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000519")]
		public virtual string ussName
		{
			[Address(RVA = "0x3235510", Offset = "0x3234910", Length = "0x2C")]
			[Token(Token = "0x6001730")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32354D0", Offset = "0x32348D0", Length = "0x7")]
		[Token(Token = "0x6001734")]
		public CursorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001731")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32354E0", Offset = "0x32348E0", Length = "0x2C")]
		[Token(Token = "0x600172F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3235510", Offset = "0x3234910", Length = "0x2C")]
		[Token(Token = "0x6001730")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3235310", Offset = "0x3234710", Length = "0xD7")]
		[Token(Token = "0x6001732")]
		public virtual StyleCursor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32353F0", Offset = "0x32347F0", Length = "0xD7")]
		[Token(Token = "0x6001733")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleCursor value) { }

	}

	[Token(Token = "0x2000326")]
	private class DisplayProperty : InlineStyleEnumProperty<DisplayStyle>
	{

		[Token(Token = "0x1700051D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001737")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700051B")]
		public virtual string Name
		{
			[Address(RVA = "0x3235700", Offset = "0x3234B00", Length = "0x2C")]
			[Token(Token = "0x6001735")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700051C")]
		public virtual string ussName
		{
			[Address(RVA = "0x3235730", Offset = "0x3234B30", Length = "0x2C")]
			[Token(Token = "0x6001736")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32356C0", Offset = "0x3234AC0", Length = "0x39")]
		[Token(Token = "0x600173A")]
		public DisplayProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001737")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3235700", Offset = "0x3234B00", Length = "0x2C")]
		[Token(Token = "0x6001735")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3235730", Offset = "0x3234B30", Length = "0x2C")]
		[Token(Token = "0x6001736")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3235540", Offset = "0x3234940", Length = "0xBC")]
		[Token(Token = "0x6001738")]
		public virtual StyleEnum<DisplayStyle> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3235600", Offset = "0x3234A00", Length = "0xB7")]
		[Token(Token = "0x6001739")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<DisplayStyle> value) { }

	}

	[Token(Token = "0x2000327")]
	private class FilterProperty : InlineStyleListProperty<FilterFunction>
	{

		[Token(Token = "0x17000520")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600173D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700051E")]
		public virtual string Name
		{
			[Address(RVA = "0x3236F80", Offset = "0x3236380", Length = "0x2C")]
			[Token(Token = "0x600173B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700051F")]
		public virtual string ussName
		{
			[Address(RVA = "0x3236FB0", Offset = "0x32363B0", Length = "0x2C")]
			[Token(Token = "0x600173C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3236F40", Offset = "0x3236340", Length = "0x39")]
		[Token(Token = "0x6001740")]
		public FilterProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600173D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3236F80", Offset = "0x3236380", Length = "0x2C")]
		[Token(Token = "0x600173B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3236FB0", Offset = "0x32363B0", Length = "0x2C")]
		[Token(Token = "0x600173C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3236DA0", Offset = "0x32361A0", Length = "0xCF")]
		[Token(Token = "0x600173E")]
		public virtual StyleList<FilterFunction> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3236E70", Offset = "0x3236270", Length = "0xCE")]
		[Token(Token = "0x600173F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<FilterFunction> value) { }

	}

	[Token(Token = "0x2000328")]
	private class FlexBasisProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000523")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001743")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000521")]
		public virtual string Name
		{
			[Address(RVA = "0x32371A0", Offset = "0x32365A0", Length = "0x2C")]
			[Token(Token = "0x6001741")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000522")]
		public virtual string ussName
		{
			[Address(RVA = "0x32371D0", Offset = "0x32365D0", Length = "0x2C")]
			[Token(Token = "0x6001742")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001746")]
		public FlexBasisProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001743")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32371A0", Offset = "0x32365A0", Length = "0x2C")]
		[Token(Token = "0x6001741")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32371D0", Offset = "0x32365D0", Length = "0x2C")]
		[Token(Token = "0x6001742")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3236FE0", Offset = "0x32363E0", Length = "0xD7")]
		[Token(Token = "0x6001744")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32370C0", Offset = "0x32364C0", Length = "0xD7")]
		[Token(Token = "0x6001745")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000329")]
	private class FlexDirectionProperty : InlineStyleEnumProperty<FlexDirection>
	{

		[Token(Token = "0x17000526")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001749")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000524")]
		public virtual string Name
		{
			[Address(RVA = "0x32373C0", Offset = "0x32367C0", Length = "0x2C")]
			[Token(Token = "0x6001747")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000525")]
		public virtual string ussName
		{
			[Address(RVA = "0x32373F0", Offset = "0x32367F0", Length = "0x2C")]
			[Token(Token = "0x6001748")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3237380", Offset = "0x3236780", Length = "0x39")]
		[Token(Token = "0x600174C")]
		public FlexDirectionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001749")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32373C0", Offset = "0x32367C0", Length = "0x2C")]
		[Token(Token = "0x6001747")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32373F0", Offset = "0x32367F0", Length = "0x2C")]
		[Token(Token = "0x6001748")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3237200", Offset = "0x3236600", Length = "0xBC")]
		[Token(Token = "0x600174A")]
		public virtual StyleEnum<FlexDirection> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32372C0", Offset = "0x32366C0", Length = "0xB7")]
		[Token(Token = "0x600174B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FlexDirection> value) { }

	}

	[Token(Token = "0x200032A")]
	private class FlexGrowProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000529")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600174F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000527")]
		public virtual string Name
		{
			[Address(RVA = "0x32374D0", Offset = "0x32368D0", Length = "0x2C")]
			[Token(Token = "0x600174D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000528")]
		public virtual string ussName
		{
			[Address(RVA = "0x3237500", Offset = "0x3236900", Length = "0x2C")]
			[Token(Token = "0x600174E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x6001752")]
		public FlexGrowProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600174F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32374D0", Offset = "0x32368D0", Length = "0x2C")]
		[Token(Token = "0x600174D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3237500", Offset = "0x3236900", Length = "0x2C")]
		[Token(Token = "0x600174E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3237420", Offset = "0x3236820", Length = "0x48")]
		[Token(Token = "0x6001750")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3237470", Offset = "0x3236870", Length = "0x57")]
		[Token(Token = "0x6001751")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200032B")]
	private class FlexShrinkProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x1700052C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001755")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700052A")]
		public virtual string Name
		{
			[Address(RVA = "0x32375E0", Offset = "0x32369E0", Length = "0x2C")]
			[Token(Token = "0x6001753")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700052B")]
		public virtual string ussName
		{
			[Address(RVA = "0x3237610", Offset = "0x3236A10", Length = "0x2C")]
			[Token(Token = "0x6001754")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x6001758")]
		public FlexShrinkProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001755")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32375E0", Offset = "0x32369E0", Length = "0x2C")]
		[Token(Token = "0x6001753")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3237610", Offset = "0x3236A10", Length = "0x2C")]
		[Token(Token = "0x6001754")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3237530", Offset = "0x3236930", Length = "0x48")]
		[Token(Token = "0x6001756")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3237580", Offset = "0x3236980", Length = "0x57")]
		[Token(Token = "0x6001757")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200032C")]
	private class FlexWrapProperty : InlineStyleEnumProperty<Wrap>
	{

		[Token(Token = "0x1700052F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600175B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700052D")]
		public virtual string Name
		{
			[Address(RVA = "0x3237800", Offset = "0x3236C00", Length = "0x2C")]
			[Token(Token = "0x6001759")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700052E")]
		public virtual string ussName
		{
			[Address(RVA = "0x3237830", Offset = "0x3236C30", Length = "0x2C")]
			[Token(Token = "0x600175A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32377C0", Offset = "0x3236BC0", Length = "0x39")]
		[Token(Token = "0x600175E")]
		public FlexWrapProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600175B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3237800", Offset = "0x3236C00", Length = "0x2C")]
		[Token(Token = "0x6001759")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3237830", Offset = "0x3236C30", Length = "0x2C")]
		[Token(Token = "0x600175A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3237640", Offset = "0x3236A40", Length = "0xBC")]
		[Token(Token = "0x600175C")]
		public virtual StyleEnum<Wrap> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3237700", Offset = "0x3236B00", Length = "0xB7")]
		[Token(Token = "0x600175D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Wrap> value) { }

	}

	[Token(Token = "0x200032D")]
	private class FontSizeProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000532")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001761")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000530")]
		public virtual string Name
		{
			[Address(RVA = "0x3238270", Offset = "0x3237670", Length = "0x2C")]
			[Token(Token = "0x600175F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000531")]
		public virtual string ussName
		{
			[Address(RVA = "0x32382A0", Offset = "0x32376A0", Length = "0x2C")]
			[Token(Token = "0x6001760")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001764")]
		public FontSizeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001761")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3238270", Offset = "0x3237670", Length = "0x2C")]
		[Token(Token = "0x600175F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32382A0", Offset = "0x32376A0", Length = "0x2C")]
		[Token(Token = "0x6001760")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32380B0", Offset = "0x32374B0", Length = "0xD7")]
		[Token(Token = "0x6001762")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3238190", Offset = "0x3237590", Length = "0xD7")]
		[Token(Token = "0x6001763")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200032E")]
	private class HeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000535")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001767")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000533")]
		public virtual string Name
		{
			[Address(RVA = "0x3238490", Offset = "0x3237890", Length = "0x2C")]
			[Token(Token = "0x6001765")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000534")]
		public virtual string ussName
		{
			[Address(RVA = "0x32384C0", Offset = "0x32378C0", Length = "0x2C")]
			[Token(Token = "0x6001766")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600176A")]
		public HeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001767")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3238490", Offset = "0x3237890", Length = "0x2C")]
		[Token(Token = "0x6001765")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32384C0", Offset = "0x32378C0", Length = "0x2C")]
		[Token(Token = "0x6001766")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32382D0", Offset = "0x32376D0", Length = "0xD7")]
		[Token(Token = "0x6001768")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32383B0", Offset = "0x32377B0", Length = "0xD7")]
		[Token(Token = "0x6001769")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200037E")]
	private abstract class InlineStyleBackgroundPositionProperty : InlineStyleProperty<StyleBackgroundPosition, BackgroundPosition>
	{

		[Address(RVA = "0x3247270", Offset = "0x3246670", Length = "0x39")]
		[Token(Token = "0x60018EA")]
		protected InlineStyleBackgroundPositionProperty() { }

	}

	[Token(Token = "0x200036C")]
	private abstract class InlineStyleBackgroundProperty : InlineStyleProperty<StyleBackground, Background>
	{
		[CompilerGenerated]
		[Token(Token = "0x200036D")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C86")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C87")]
			public static TypeConverter<Texture2D, StyleBackground> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C88")]
			public static TypeConverter<Sprite, StyleBackground> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C89")]
			public static TypeConverter<VectorImage, StyleBackground> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C8A")]
			public static TypeConverter<RenderTexture, StyleBackground> <>9__0_3; //Field offset: 0x20
			[Token(Token = "0x4000C8B")]
			public static TypeConverter<StyleBackground, Texture2D> <>9__0_4; //Field offset: 0x28
			[Token(Token = "0x4000C8C")]
			public static TypeConverter<StyleBackground, Sprite> <>9__0_5; //Field offset: 0x30
			[Token(Token = "0x4000C8D")]
			public static TypeConverter<StyleBackground, RenderTexture> <>9__0_6; //Field offset: 0x38
			[Token(Token = "0x4000C8E")]
			public static TypeConverter<StyleBackground, VectorImage> <>9__0_7; //Field offset: 0x40

			[Address(RVA = "0x324E1C0", Offset = "0x324D5C0", Length = "0x67")]
			[Token(Token = "0x60018C3")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018C4")]
			public <>c() { }

			[Address(RVA = "0x324DD30", Offset = "0x324D130", Length = "0x2D")]
			[Token(Token = "0x60018C5")]
			internal StyleBackground <.ctor>b__0_0(ref Texture2D v) { }

			[Address(RVA = "0x324DE40", Offset = "0x324D240", Length = "0x2D")]
			[Token(Token = "0x60018C6")]
			internal StyleBackground <.ctor>b__0_1(ref Sprite v) { }

			[Address(RVA = "0x324DF00", Offset = "0x324D300", Length = "0x2D")]
			[Token(Token = "0x60018C7")]
			internal StyleBackground <.ctor>b__0_2(ref VectorImage v) { }

			[Address(RVA = "0x324DF90", Offset = "0x324D390", Length = "0x53")]
			[Token(Token = "0x60018C8")]
			internal StyleBackground <.ctor>b__0_3(ref RenderTexture v) { }

			[Address(RVA = "0x324E050", Offset = "0x324D450", Length = "0x40")]
			[Token(Token = "0x60018C9")]
			internal Texture2D <.ctor>b__0_4(ref StyleBackground sv) { }

			[Address(RVA = "0x324E090", Offset = "0x324D490", Length = "0x40")]
			[Token(Token = "0x60018CA")]
			internal Sprite <.ctor>b__0_5(ref StyleBackground sv) { }

			[Address(RVA = "0x324E0D0", Offset = "0x324D4D0", Length = "0x40")]
			[Token(Token = "0x60018CB")]
			internal RenderTexture <.ctor>b__0_6(ref StyleBackground sv) { }

			[Address(RVA = "0x324E110", Offset = "0x324D510", Length = "0x40")]
			[Token(Token = "0x60018CC")]
			internal VectorImage <.ctor>b__0_7(ref StyleBackground sv) { }

		}


		[Address(RVA = "0x32472B0", Offset = "0x32466B0", Length = "0x76E")]
		[Token(Token = "0x60018C2")]
		protected InlineStyleBackgroundProperty() { }

	}

	[Token(Token = "0x200037F")]
	private abstract class InlineStyleBackgroundRepeatProperty : InlineStyleProperty<StyleBackgroundRepeat, BackgroundRepeat>
	{

		[Address(RVA = "0x3247A20", Offset = "0x3246E20", Length = "0x39")]
		[Token(Token = "0x60018EB")]
		protected InlineStyleBackgroundRepeatProperty() { }

	}

	[Token(Token = "0x2000380")]
	private abstract class InlineStyleBackgroundSizeProperty : InlineStyleProperty<StyleBackgroundSize, BackgroundSize>
	{

		[Address(RVA = "0x3247A60", Offset = "0x3246E60", Length = "0x39")]
		[Token(Token = "0x60018EC")]
		protected InlineStyleBackgroundSizeProperty() { }

	}

	[Token(Token = "0x2000368")]
	private abstract class InlineStyleColorProperty : InlineStyleProperty<StyleColor, Color>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000369")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C80")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C81")]
			public static TypeConverter<Color32, StyleColor> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C82")]
			public static TypeConverter<StyleColor, Color32> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x324E150", Offset = "0x324D550", Length = "0x67")]
			[Token(Token = "0x60018B9")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018BA")]
			public <>c() { }

			[Address(RVA = "0x324DC90", Offset = "0x324D090", Length = "0x9E")]
			[Token(Token = "0x60018BB")]
			internal StyleColor <.ctor>b__0_0(ref Color32 v) { }

			[Address(RVA = "0x324DEA0", Offset = "0x324D2A0", Length = "0x2A")]
			[Token(Token = "0x60018BC")]
			internal Color32 <.ctor>b__0_1(ref StyleColor sv) { }

		}


		[Address(RVA = "0x3247AA0", Offset = "0x3246EA0", Length = "0x21E")]
		[Token(Token = "0x60018B8")]
		protected InlineStyleColorProperty() { }

	}

	[Token(Token = "0x2000379")]
	private abstract class InlineStyleCursorProperty : InlineStyleProperty<StyleCursor, Cursor>
	{

		[Address(RVA = "0x3247CC0", Offset = "0x32470C0", Length = "0x39")]
		[Token(Token = "0x60018E5")]
		protected InlineStyleCursorProperty() { }

	}

	[Token(Token = "0x2000367")]
	private abstract class InlineStyleEnumProperty : InlineStyleProperty<StyleEnum`1<TValue>, TValue>
	{

		[Address(RVA = "0x1C7C4C0", Offset = "0x1C7B8C0", Length = "0x13")]
		[Token(Token = "0x60018B7")]
		protected InlineStyleEnumProperty`1() { }

	}

	[Token(Token = "0x2000370")]
	private abstract class InlineStyleFloatProperty : InlineStyleProperty<StyleFloat, Single>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000371")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C94")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C95")]
			public static TypeConverter<Int32, StyleFloat> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C96")]
			public static TypeConverter<StyleFloat, Int32> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x324E380", Offset = "0x324D780", Length = "0x67")]
			[Token(Token = "0x60018D5")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018D6")]
			public <>c() { }

			[Address(RVA = "0x324DBF0", Offset = "0x324CFF0", Length = "0x2B")]
			[Token(Token = "0x60018D7")]
			internal StyleFloat <.ctor>b__0_0(ref int v) { }

			[Address(RVA = "0x324DDD0", Offset = "0x324D1D0", Length = "0x17")]
			[Token(Token = "0x60018D8")]
			internal int <.ctor>b__0_1(ref StyleFloat sv) { }

		}


		[Address(RVA = "0x3247D00", Offset = "0x3247100", Length = "0x21E")]
		[Token(Token = "0x60018D4")]
		protected InlineStyleFloatProperty() { }

	}

	[Token(Token = "0x2000374")]
	private abstract class InlineStyleFontDefinitionProperty : InlineStyleProperty<StyleFontDefinition, FontDefinition>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000375")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C97")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C98")]
			public static TypeConverter<Font, StyleFontDefinition> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C99")]
			public static TypeConverter<FontAsset, StyleFontDefinition> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C9A")]
			public static TypeConverter<StyleFontDefinition, Font> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C9B")]
			public static TypeConverter<StyleFontDefinition, FontAsset> <>9__0_3; //Field offset: 0x20

			[Address(RVA = "0x324E230", Offset = "0x324D630", Length = "0x67")]
			[Token(Token = "0x60018DC")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018DD")]
			public <>c() { }

			[Address(RVA = "0x324DC20", Offset = "0x324D020", Length = "0x29")]
			[Token(Token = "0x60018DE")]
			internal StyleFontDefinition <.ctor>b__0_0(ref Font v) { }

			[Address(RVA = "0x324DDF0", Offset = "0x324D1F0", Length = "0x29")]
			[Token(Token = "0x60018DF")]
			internal StyleFontDefinition <.ctor>b__0_1(ref FontAsset v) { }

			[Address(RVA = "0x324DF30", Offset = "0x324D330", Length = "0x32")]
			[Token(Token = "0x60018E0")]
			internal Font <.ctor>b__0_2(ref StyleFontDefinition sv) { }

			[Address(RVA = "0x324DFF0", Offset = "0x324D3F0", Length = "0x32")]
			[Token(Token = "0x60018E1")]
			internal FontAsset <.ctor>b__0_3(ref StyleFontDefinition sv) { }

		}


		[Address(RVA = "0x3247F20", Offset = "0x3247320", Length = "0x3E6")]
		[Token(Token = "0x60018DB")]
		protected InlineStyleFontDefinitionProperty() { }

	}

	[Token(Token = "0x2000373")]
	private abstract class InlineStyleFontProperty : InlineStyleProperty<StyleFont, Font>
	{

		[Address(RVA = "0x3248310", Offset = "0x3247710", Length = "0x39")]
		[Token(Token = "0x60018DA")]
		protected InlineStyleFontProperty() { }

	}

	[Token(Token = "0x2000376")]
	private abstract class InlineStyleIntProperty : InlineStyleProperty<StyleInt, Int32>
	{

		[Address(RVA = "0x3248350", Offset = "0x3247750", Length = "0x39")]
		[Token(Token = "0x60018E2")]
		protected InlineStyleIntProperty() { }

	}

	[Token(Token = "0x200036E")]
	private abstract class InlineStyleLengthProperty : InlineStyleProperty<StyleLength, Length>
	{
		[CompilerGenerated]
		[Token(Token = "0x200036F")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C8F")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C90")]
			public static TypeConverter<Single, StyleLength> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C91")]
			public static TypeConverter<Int32, StyleLength> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C92")]
			public static TypeConverter<StyleLength, Single> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C93")]
			public static TypeConverter<StyleLength, Int32> <>9__0_3; //Field offset: 0x20

			[Address(RVA = "0x324E2A0", Offset = "0x324D6A0", Length = "0x67")]
			[Token(Token = "0x60018CE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018CF")]
			public <>c() { }

			[Address(RVA = "0x324DD60", Offset = "0x324D160", Length = "0x27")]
			[Token(Token = "0x60018D0")]
			internal StyleLength <.ctor>b__0_0(ref float v) { }

			[Address(RVA = "0x324DE70", Offset = "0x324D270", Length = "0x2F")]
			[Token(Token = "0x60018D1")]
			internal StyleLength <.ctor>b__0_1(ref int v) { }

			[Address(RVA = "0x324DF70", Offset = "0x324D370", Length = "0x1E")]
			[Token(Token = "0x60018D2")]
			internal float <.ctor>b__0_2(ref StyleLength sv) { }

			[Address(RVA = "0x324E030", Offset = "0x324D430", Length = "0x1E")]
			[Token(Token = "0x60018D3")]
			internal int <.ctor>b__0_3(ref StyleLength sv) { }

		}


		[Address(RVA = "0x3248390", Offset = "0x3247790", Length = "0x3E6")]
		[Token(Token = "0x60018CD")]
		protected InlineStyleLengthProperty() { }

	}

	[Token(Token = "0x2000372")]
	private abstract class InlineStyleListProperty : InlineStyleProperty<StyleList`1<T>, List`1<T>>
	{

		[Address(RVA = "0x1C7C4E0", Offset = "0x1C7B8E0", Length = "0x13")]
		[Token(Token = "0x60018D9")]
		protected InlineStyleListProperty`1() { }

	}

	[Token(Token = "0x2000381")]
	private abstract class InlineStyleMaterialDefinitionProperty : InlineStyleProperty<StyleMaterialDefinition, MaterialDefinition>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000382")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C9C")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C9D")]
			public static TypeConverter<MaterialDefinition, StyleMaterialDefinition> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C9E")]
			public static TypeConverter<StyleMaterialDefinition, MaterialDefinition> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x324E310", Offset = "0x324D710", Length = "0x67")]
			[Token(Token = "0x60018EE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018EF")]
			public <>c() { }

			[Address(RVA = "0x324DC50", Offset = "0x324D050", Length = "0x35")]
			[Token(Token = "0x60018F0")]
			internal StyleMaterialDefinition <.ctor>b__0_0(ref MaterialDefinition v) { }

			[Address(RVA = "0x324DED0", Offset = "0x324D2D0", Length = "0x28")]
			[Token(Token = "0x60018F1")]
			internal MaterialDefinition <.ctor>b__0_1(ref StyleMaterialDefinition sv) { }

		}


		[Address(RVA = "0x3248780", Offset = "0x3247B80", Length = "0x21E")]
		[Token(Token = "0x60018ED")]
		protected InlineStyleMaterialDefinitionProperty() { }

	}

	[Token(Token = "0x2000365")]
	private abstract class InlineStyleProperty : Property<InlineStyleAccess, TStyleValue>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000366")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C7B")]
			public static readonly <>c<TStyleValue, TValue> <>9; //Field offset: 0x0
			[Token(Token = "0x4000C7C")]
			public static TypeConverter<TStyleValue, TValue> <>9__0_0; //Field offset: 0x0
			[Token(Token = "0x4000C7D")]
			public static TypeConverter<TValue, TStyleValue> <>9__0_1; //Field offset: 0x0
			[Token(Token = "0x4000C7E")]
			public static TypeConverter<TStyleValue, StyleKeyword> <>9__0_2; //Field offset: 0x0
			[Token(Token = "0x4000C7F")]
			public static TypeConverter<StyleKeyword, TStyleValue> <>9__0_3; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x60018B1")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018B2")]
			public <>c() { }

			[Address(RVA = "0xA36FC0", Offset = "0xA363C0", Length = "0x17")]
			[Token(Token = "0x60018B3")]
			internal TValue <.ctor>b__0_0(ref TStyleValue sv) { }

			[Address(RVA = "0xA37530", Offset = "0xA36930", Length = "0x5D")]
			[Token(Token = "0x60018B4")]
			internal TStyleValue <.ctor>b__0_1(ref TValue v) { }

			[Address(RVA = "0xA37F70", Offset = "0xA37370", Length = "0x17")]
			[Token(Token = "0x60018B5")]
			internal StyleKeyword <.ctor>b__0_2(ref TStyleValue sv) { }

			[Address(RVA = "0xA37FD0", Offset = "0xA373D0", Length = "0x5D")]
			[Token(Token = "0x60018B6")]
			internal TStyleValue <.ctor>b__0_3(ref StyleKeyword kw) { }

		}


		[Token(Token = "0x170005D8")]
		public abstract string ussName
		{
			[Token(Token = "0x60018B0")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x1C7CC10", Offset = "0x1C7C010", Length = "0x6AE")]
		[Token(Token = "0x60018AF")]
		protected InlineStyleProperty`2() { }

		[Token(Token = "0x60018B0")]
		public abstract string get_ussName() { }

	}

	[Token(Token = "0x200036A")]
	private abstract class InlineStyleRatioProperty : InlineStyleProperty<StyleRatio, Ratio>
	{
		[CompilerGenerated]
		[Token(Token = "0x200036B")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C83")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C84")]
			public static TypeConverter<Single, StyleRatio> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C85")]
			public static TypeConverter<StyleRatio, Single> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x324E3F0", Offset = "0x324D7F0", Length = "0x67")]
			[Token(Token = "0x60018BE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60018BF")]
			public <>c() { }

			[Address(RVA = "0x324DD90", Offset = "0x324D190", Length = "0x34")]
			[Token(Token = "0x60018C0")]
			internal StyleRatio <.ctor>b__0_0(ref float v) { }

			[Address(RVA = "0x324DE20", Offset = "0x324D220", Length = "0x1B")]
			[Token(Token = "0x60018C1")]
			internal float <.ctor>b__0_1(ref StyleRatio sv) { }

		}


		[Address(RVA = "0x32489A0", Offset = "0x3247DA0", Length = "0x21E")]
		[Token(Token = "0x60018BD")]
		protected InlineStyleRatioProperty() { }

	}

	[Token(Token = "0x2000377")]
	private abstract class InlineStyleRotateProperty : InlineStyleProperty<StyleRotate, Rotate>
	{

		[Address(RVA = "0x3248BC0", Offset = "0x3247FC0", Length = "0x39")]
		[Token(Token = "0x60018E3")]
		protected InlineStyleRotateProperty() { }

	}

	[Token(Token = "0x2000378")]
	private abstract class InlineStyleScaleProperty : InlineStyleProperty<StyleScale, Scale>
	{

		[Address(RVA = "0x3248C00", Offset = "0x3248000", Length = "0x39")]
		[Token(Token = "0x60018E4")]
		protected InlineStyleScaleProperty() { }

	}

	[Token(Token = "0x200037B")]
	private abstract class InlineStyleTextAutoSizeProperty : InlineStyleProperty<StyleTextAutoSize, TextAutoSize>
	{

		[Address(RVA = "0x3248C40", Offset = "0x3248040", Length = "0x39")]
		[Token(Token = "0x60018E7")]
		protected InlineStyleTextAutoSizeProperty() { }

	}

	[Token(Token = "0x200037A")]
	private abstract class InlineStyleTextShadowProperty : InlineStyleProperty<StyleTextShadow, TextShadow>
	{

		[Address(RVA = "0x3248C80", Offset = "0x3248080", Length = "0x39")]
		[Token(Token = "0x60018E6")]
		protected InlineStyleTextShadowProperty() { }

	}

	[Token(Token = "0x200037C")]
	private abstract class InlineStyleTransformOriginProperty : InlineStyleProperty<StyleTransformOrigin, TransformOrigin>
	{

		[Address(RVA = "0x3248CC0", Offset = "0x32480C0", Length = "0x39")]
		[Token(Token = "0x60018E8")]
		protected InlineStyleTransformOriginProperty() { }

	}

	[Token(Token = "0x200037D")]
	private abstract class InlineStyleTranslateProperty : InlineStyleProperty<StyleTranslate, Translate>
	{

		[Address(RVA = "0x3248D00", Offset = "0x3248100", Length = "0x39")]
		[Token(Token = "0x60018E9")]
		protected InlineStyleTranslateProperty() { }

	}

	[Token(Token = "0x200032F")]
	private class JustifyContentProperty : InlineStyleEnumProperty<Justify>
	{

		[Token(Token = "0x17000538")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600176D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000536")]
		public virtual string Name
		{
			[Address(RVA = "0x3244CE0", Offset = "0x32440E0", Length = "0x2C")]
			[Token(Token = "0x600176B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000537")]
		public virtual string ussName
		{
			[Address(RVA = "0x3244D10", Offset = "0x3244110", Length = "0x2C")]
			[Token(Token = "0x600176C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3244CA0", Offset = "0x32440A0", Length = "0x39")]
		[Token(Token = "0x6001770")]
		public JustifyContentProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600176D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3244CE0", Offset = "0x32440E0", Length = "0x2C")]
		[Token(Token = "0x600176B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3244D10", Offset = "0x3244110", Length = "0x2C")]
		[Token(Token = "0x600176C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3244B20", Offset = "0x3243F20", Length = "0xBC")]
		[Token(Token = "0x600176E")]
		public virtual StyleEnum<Justify> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3244BE0", Offset = "0x3243FE0", Length = "0xB7")]
		[Token(Token = "0x600176F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Justify> value) { }

	}

	[Token(Token = "0x2000330")]
	private class LeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700053B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001773")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000539")]
		public virtual string Name
		{
			[Address(RVA = "0x3248F00", Offset = "0x3248300", Length = "0x2C")]
			[Token(Token = "0x6001771")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700053A")]
		public virtual string ussName
		{
			[Address(RVA = "0x3248F30", Offset = "0x3248330", Length = "0x2C")]
			[Token(Token = "0x6001772")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001776")]
		public LeftProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001773")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3248F00", Offset = "0x3248300", Length = "0x2C")]
		[Token(Token = "0x6001771")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3248F30", Offset = "0x3248330", Length = "0x2C")]
		[Token(Token = "0x6001772")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3248D40", Offset = "0x3248140", Length = "0xD7")]
		[Token(Token = "0x6001774")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3248E20", Offset = "0x3248220", Length = "0xD7")]
		[Token(Token = "0x6001775")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000331")]
	private class LetterSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700053E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001779")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700053C")]
		public virtual string Name
		{
			[Address(RVA = "0x3249120", Offset = "0x3248520", Length = "0x2C")]
			[Token(Token = "0x6001777")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700053D")]
		public virtual string ussName
		{
			[Address(RVA = "0x3249150", Offset = "0x3248550", Length = "0x2C")]
			[Token(Token = "0x6001778")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600177C")]
		public LetterSpacingProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001779")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249120", Offset = "0x3248520", Length = "0x2C")]
		[Token(Token = "0x6001777")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3249150", Offset = "0x3248550", Length = "0x2C")]
		[Token(Token = "0x6001778")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3248F60", Offset = "0x3248360", Length = "0xD7")]
		[Token(Token = "0x600177A")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249040", Offset = "0x3248440", Length = "0xD7")]
		[Token(Token = "0x600177B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000332")]
	private class MarginBottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000541")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600177F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700053F")]
		public virtual string Name
		{
			[Address(RVA = "0x3249340", Offset = "0x3248740", Length = "0x2C")]
			[Token(Token = "0x600177D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000540")]
		public virtual string ussName
		{
			[Address(RVA = "0x3249370", Offset = "0x3248770", Length = "0x2C")]
			[Token(Token = "0x600177E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001782")]
		public MarginBottomProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600177F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249340", Offset = "0x3248740", Length = "0x2C")]
		[Token(Token = "0x600177D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3249370", Offset = "0x3248770", Length = "0x2C")]
		[Token(Token = "0x600177E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3249180", Offset = "0x3248580", Length = "0xD7")]
		[Token(Token = "0x6001780")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249260", Offset = "0x3248660", Length = "0xD7")]
		[Token(Token = "0x6001781")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000333")]
	private class MarginLeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000544")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001785")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000542")]
		public virtual string Name
		{
			[Address(RVA = "0x3249560", Offset = "0x3248960", Length = "0x2C")]
			[Token(Token = "0x6001783")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000543")]
		public virtual string ussName
		{
			[Address(RVA = "0x3249590", Offset = "0x3248990", Length = "0x2C")]
			[Token(Token = "0x6001784")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001788")]
		public MarginLeftProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001785")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249560", Offset = "0x3248960", Length = "0x2C")]
		[Token(Token = "0x6001783")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3249590", Offset = "0x3248990", Length = "0x2C")]
		[Token(Token = "0x6001784")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32493A0", Offset = "0x32487A0", Length = "0xD7")]
		[Token(Token = "0x6001786")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249480", Offset = "0x3248880", Length = "0xD7")]
		[Token(Token = "0x6001787")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000334")]
	private class MarginRightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000547")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600178B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000545")]
		public virtual string Name
		{
			[Address(RVA = "0x3249780", Offset = "0x3248B80", Length = "0x2C")]
			[Token(Token = "0x6001789")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000546")]
		public virtual string ussName
		{
			[Address(RVA = "0x32497B0", Offset = "0x3248BB0", Length = "0x2C")]
			[Token(Token = "0x600178A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600178E")]
		public MarginRightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600178B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249780", Offset = "0x3248B80", Length = "0x2C")]
		[Token(Token = "0x6001789")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32497B0", Offset = "0x3248BB0", Length = "0x2C")]
		[Token(Token = "0x600178A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32495C0", Offset = "0x32489C0", Length = "0xD7")]
		[Token(Token = "0x600178C")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32496A0", Offset = "0x3248AA0", Length = "0xD7")]
		[Token(Token = "0x600178D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000335")]
	private class MarginTopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700054A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001791")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000548")]
		public virtual string Name
		{
			[Address(RVA = "0x32499A0", Offset = "0x3248DA0", Length = "0x2C")]
			[Token(Token = "0x600178F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000549")]
		public virtual string ussName
		{
			[Address(RVA = "0x32499D0", Offset = "0x3248DD0", Length = "0x2C")]
			[Token(Token = "0x6001790")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x6001794")]
		public MarginTopProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001791")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32499A0", Offset = "0x3248DA0", Length = "0x2C")]
		[Token(Token = "0x600178F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32499D0", Offset = "0x3248DD0", Length = "0x2C")]
		[Token(Token = "0x6001790")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32497E0", Offset = "0x3248BE0", Length = "0xD7")]
		[Token(Token = "0x6001792")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32498C0", Offset = "0x3248CC0", Length = "0xD7")]
		[Token(Token = "0x6001793")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000336")]
	private class MaxHeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700054D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001797")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700054B")]
		public virtual string Name
		{
			[Address(RVA = "0x3249BC0", Offset = "0x3248FC0", Length = "0x2C")]
			[Token(Token = "0x6001795")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700054C")]
		public virtual string ussName
		{
			[Address(RVA = "0x3249BF0", Offset = "0x3248FF0", Length = "0x2C")]
			[Token(Token = "0x6001796")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600179A")]
		public MaxHeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001797")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249BC0", Offset = "0x3248FC0", Length = "0x2C")]
		[Token(Token = "0x6001795")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3249BF0", Offset = "0x3248FF0", Length = "0x2C")]
		[Token(Token = "0x6001796")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3249A00", Offset = "0x3248E00", Length = "0xD7")]
		[Token(Token = "0x6001798")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249AE0", Offset = "0x3248EE0", Length = "0xD7")]
		[Token(Token = "0x6001799")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000337")]
	private class MaxWidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000550")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600179D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700054E")]
		public virtual string Name
		{
			[Address(RVA = "0x3249DE0", Offset = "0x32491E0", Length = "0x2C")]
			[Token(Token = "0x600179B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700054F")]
		public virtual string ussName
		{
			[Address(RVA = "0x3249E10", Offset = "0x3249210", Length = "0x2C")]
			[Token(Token = "0x600179C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017A0")]
		public MaxWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600179D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3249DE0", Offset = "0x32491E0", Length = "0x2C")]
		[Token(Token = "0x600179B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3249E10", Offset = "0x3249210", Length = "0x2C")]
		[Token(Token = "0x600179C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3249C20", Offset = "0x3249020", Length = "0xD7")]
		[Token(Token = "0x600179E")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249D00", Offset = "0x3249100", Length = "0xD7")]
		[Token(Token = "0x600179F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000338")]
	private class MinHeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000553")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017A3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000551")]
		public virtual string Name
		{
			[Address(RVA = "0x324A000", Offset = "0x3249400", Length = "0x2C")]
			[Token(Token = "0x60017A1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000552")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A030", Offset = "0x3249430", Length = "0x2C")]
			[Token(Token = "0x60017A2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017A6")]
		public MinHeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017A3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A000", Offset = "0x3249400", Length = "0x2C")]
		[Token(Token = "0x60017A1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A030", Offset = "0x3249430", Length = "0x2C")]
		[Token(Token = "0x60017A2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3249E40", Offset = "0x3249240", Length = "0xD7")]
		[Token(Token = "0x60017A4")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3249F20", Offset = "0x3249320", Length = "0xD7")]
		[Token(Token = "0x60017A5")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000339")]
	private class MinWidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000556")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017A9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000554")]
		public virtual string Name
		{
			[Address(RVA = "0x324A220", Offset = "0x3249620", Length = "0x2C")]
			[Token(Token = "0x60017A7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000555")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A250", Offset = "0x3249650", Length = "0x2C")]
			[Token(Token = "0x60017A8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017AC")]
		public MinWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017A9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A220", Offset = "0x3249620", Length = "0x2C")]
		[Token(Token = "0x60017A7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A250", Offset = "0x3249650", Length = "0x2C")]
		[Token(Token = "0x60017A8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A060", Offset = "0x3249460", Length = "0xD7")]
		[Token(Token = "0x60017AA")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324A140", Offset = "0x3249540", Length = "0xD7")]
		[Token(Token = "0x60017AB")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200033A")]
	private class OpacityProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000559")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017AF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000557")]
		public virtual string Name
		{
			[Address(RVA = "0x324A330", Offset = "0x3249730", Length = "0x2C")]
			[Token(Token = "0x60017AD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000558")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A360", Offset = "0x3249760", Length = "0x2C")]
			[Token(Token = "0x60017AE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x60017B2")]
		public OpacityProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017AF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A330", Offset = "0x3249730", Length = "0x2C")]
		[Token(Token = "0x60017AD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A360", Offset = "0x3249760", Length = "0x2C")]
		[Token(Token = "0x60017AE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A280", Offset = "0x3249680", Length = "0x48")]
		[Token(Token = "0x60017B0")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324A2D0", Offset = "0x32496D0", Length = "0x57")]
		[Token(Token = "0x60017B1")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200033B")]
	private class OverflowProperty : InlineStyleEnumProperty<Overflow>
	{

		[Token(Token = "0x1700055C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017B5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700055A")]
		public virtual string Name
		{
			[Address(RVA = "0x324A550", Offset = "0x3249950", Length = "0x2C")]
			[Token(Token = "0x60017B3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700055B")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A580", Offset = "0x3249980", Length = "0x2C")]
			[Token(Token = "0x60017B4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324A510", Offset = "0x3249910", Length = "0x39")]
		[Token(Token = "0x60017B8")]
		public OverflowProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017B5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A550", Offset = "0x3249950", Length = "0x2C")]
		[Token(Token = "0x60017B3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A580", Offset = "0x3249980", Length = "0x2C")]
		[Token(Token = "0x60017B4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A390", Offset = "0x3249790", Length = "0xBC")]
		[Token(Token = "0x60017B6")]
		public virtual StyleEnum<Overflow> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324A450", Offset = "0x3249850", Length = "0xB7")]
		[Token(Token = "0x60017B7")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Overflow> value) { }

	}

	[Token(Token = "0x200033C")]
	private class PaddingBottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700055F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017BB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700055D")]
		public virtual string Name
		{
			[Address(RVA = "0x324A770", Offset = "0x3249B70", Length = "0x2C")]
			[Token(Token = "0x60017B9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700055E")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A7A0", Offset = "0x3249BA0", Length = "0x2C")]
			[Token(Token = "0x60017BA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017BE")]
		public PaddingBottomProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017BB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A770", Offset = "0x3249B70", Length = "0x2C")]
		[Token(Token = "0x60017B9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A7A0", Offset = "0x3249BA0", Length = "0x2C")]
		[Token(Token = "0x60017BA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A5B0", Offset = "0x32499B0", Length = "0xD7")]
		[Token(Token = "0x60017BC")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324A690", Offset = "0x3249A90", Length = "0xD7")]
		[Token(Token = "0x60017BD")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200033D")]
	private class PaddingLeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000562")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017C1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000560")]
		public virtual string Name
		{
			[Address(RVA = "0x324A990", Offset = "0x3249D90", Length = "0x2C")]
			[Token(Token = "0x60017BF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000561")]
		public virtual string ussName
		{
			[Address(RVA = "0x324A9C0", Offset = "0x3249DC0", Length = "0x2C")]
			[Token(Token = "0x60017C0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017C4")]
		public PaddingLeftProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017C1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324A990", Offset = "0x3249D90", Length = "0x2C")]
		[Token(Token = "0x60017BF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324A9C0", Offset = "0x3249DC0", Length = "0x2C")]
		[Token(Token = "0x60017C0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A7D0", Offset = "0x3249BD0", Length = "0xD7")]
		[Token(Token = "0x60017C2")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324A8B0", Offset = "0x3249CB0", Length = "0xD7")]
		[Token(Token = "0x60017C3")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200033E")]
	private class PaddingRightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000565")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017C7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000563")]
		public virtual string Name
		{
			[Address(RVA = "0x324ABB0", Offset = "0x3249FB0", Length = "0x2C")]
			[Token(Token = "0x60017C5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000564")]
		public virtual string ussName
		{
			[Address(RVA = "0x324ABE0", Offset = "0x3249FE0", Length = "0x2C")]
			[Token(Token = "0x60017C6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017CA")]
		public PaddingRightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017C7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324ABB0", Offset = "0x3249FB0", Length = "0x2C")]
		[Token(Token = "0x60017C5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324ABE0", Offset = "0x3249FE0", Length = "0x2C")]
		[Token(Token = "0x60017C6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324A9F0", Offset = "0x3249DF0", Length = "0xD7")]
		[Token(Token = "0x60017C8")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324AAD0", Offset = "0x3249ED0", Length = "0xD7")]
		[Token(Token = "0x60017C9")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200033F")]
	private class PaddingTopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000568")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017CD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000566")]
		public virtual string Name
		{
			[Address(RVA = "0x324ADD0", Offset = "0x324A1D0", Length = "0x2C")]
			[Token(Token = "0x60017CB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000567")]
		public virtual string ussName
		{
			[Address(RVA = "0x324AE00", Offset = "0x324A200", Length = "0x2C")]
			[Token(Token = "0x60017CC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017D0")]
		public PaddingTopProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017CD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324ADD0", Offset = "0x324A1D0", Length = "0x2C")]
		[Token(Token = "0x60017CB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324AE00", Offset = "0x324A200", Length = "0x2C")]
		[Token(Token = "0x60017CC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324AC10", Offset = "0x324A010", Length = "0xD7")]
		[Token(Token = "0x60017CE")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324ACF0", Offset = "0x324A0F0", Length = "0xD7")]
		[Token(Token = "0x60017CF")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000340")]
	private class PositionProperty : InlineStyleEnumProperty<Position>
	{

		[Token(Token = "0x1700056B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017D3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000569")]
		public virtual string Name
		{
			[Address(RVA = "0x324AF90", Offset = "0x324A390", Length = "0x2C")]
			[Token(Token = "0x60017D1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700056A")]
		public virtual string ussName
		{
			[Address(RVA = "0x324AFC0", Offset = "0x324A3C0", Length = "0x2C")]
			[Token(Token = "0x60017D2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324AF50", Offset = "0x324A350", Length = "0x39")]
		[Token(Token = "0x60017D6")]
		public PositionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017D3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324AF90", Offset = "0x324A390", Length = "0x2C")]
		[Token(Token = "0x60017D1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324AFC0", Offset = "0x324A3C0", Length = "0x2C")]
		[Token(Token = "0x60017D2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324AE30", Offset = "0x324A230", Length = "0xBC")]
		[Token(Token = "0x60017D4")]
		public virtual StyleEnum<Position> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324AEF0", Offset = "0x324A2F0", Length = "0x57")]
		[Token(Token = "0x60017D5")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Position> value) { }

	}

	[Token(Token = "0x2000341")]
	private class RightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700056E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017D9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700056C")]
		public virtual string Name
		{
			[Address(RVA = "0x324C390", Offset = "0x324B790", Length = "0x2C")]
			[Token(Token = "0x60017D7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700056D")]
		public virtual string ussName
		{
			[Address(RVA = "0x324C3C0", Offset = "0x324B7C0", Length = "0x2C")]
			[Token(Token = "0x60017D8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017DC")]
		public RightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017D9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324C390", Offset = "0x324B790", Length = "0x2C")]
		[Token(Token = "0x60017D7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324C3C0", Offset = "0x324B7C0", Length = "0x2C")]
		[Token(Token = "0x60017D8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324C1D0", Offset = "0x324B5D0", Length = "0xD7")]
		[Token(Token = "0x60017DA")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324C2B0", Offset = "0x324B6B0", Length = "0xD7")]
		[Token(Token = "0x60017DB")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000342")]
	private class RotateProperty : InlineStyleRotateProperty
	{

		[Token(Token = "0x17000571")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017DF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700056F")]
		public virtual string Name
		{
			[Address(RVA = "0x324C5C0", Offset = "0x324B9C0", Length = "0x2C")]
			[Token(Token = "0x60017DD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000570")]
		public virtual string ussName
		{
			[Address(RVA = "0x324C5F0", Offset = "0x324B9F0", Length = "0x2C")]
			[Token(Token = "0x60017DE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248BC0", Offset = "0x3247FC0", Length = "0x39")]
		[Token(Token = "0x60017E2")]
		public RotateProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017DF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324C5C0", Offset = "0x324B9C0", Length = "0x2C")]
		[Token(Token = "0x60017DD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324C5F0", Offset = "0x324B9F0", Length = "0x2C")]
		[Token(Token = "0x60017DE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324C3F0", Offset = "0x324B7F0", Length = "0xDF")]
		[Token(Token = "0x60017E0")]
		public virtual StyleRotate GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324C4D0", Offset = "0x324B8D0", Length = "0xE0")]
		[Token(Token = "0x60017E1")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleRotate value) { }

	}

	[Token(Token = "0x2000343")]
	private class ScaleProperty : InlineStyleScaleProperty
	{

		[Token(Token = "0x17000574")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017E5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000572")]
		public virtual string Name
		{
			[Address(RVA = "0x324C7E0", Offset = "0x324BBE0", Length = "0x2C")]
			[Token(Token = "0x60017E3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000573")]
		public virtual string ussName
		{
			[Address(RVA = "0x324C810", Offset = "0x324BC10", Length = "0x2C")]
			[Token(Token = "0x60017E4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248C00", Offset = "0x3248000", Length = "0x39")]
		[Token(Token = "0x60017E8")]
		public ScaleProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017E5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324C7E0", Offset = "0x324BBE0", Length = "0x2C")]
		[Token(Token = "0x60017E3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324C810", Offset = "0x324BC10", Length = "0x2C")]
		[Token(Token = "0x60017E4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324C620", Offset = "0x324BA20", Length = "0xD5")]
		[Token(Token = "0x60017E6")]
		public virtual StyleScale GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324C700", Offset = "0x324BB00", Length = "0xD5")]
		[Token(Token = "0x60017E7")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleScale value) { }

	}

	[Token(Token = "0x2000344")]
	private class TextOverflowProperty : InlineStyleEnumProperty<TextOverflow>
	{

		[Token(Token = "0x17000577")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017EB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000575")]
		public virtual string Name
		{
			[Address(RVA = "0x324CA00", Offset = "0x324BE00", Length = "0x2C")]
			[Token(Token = "0x60017E9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000576")]
		public virtual string ussName
		{
			[Address(RVA = "0x324CA30", Offset = "0x324BE30", Length = "0x2C")]
			[Token(Token = "0x60017EA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324C9C0", Offset = "0x324BDC0", Length = "0x39")]
		[Token(Token = "0x60017EE")]
		public TextOverflowProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017EB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324CA00", Offset = "0x324BE00", Length = "0x2C")]
		[Token(Token = "0x60017E9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324CA30", Offset = "0x324BE30", Length = "0x2C")]
		[Token(Token = "0x60017EA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324C840", Offset = "0x324BC40", Length = "0xBC")]
		[Token(Token = "0x60017EC")]
		public virtual StyleEnum<TextOverflow> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324C900", Offset = "0x324BD00", Length = "0xB7")]
		[Token(Token = "0x60017ED")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflow> value) { }

	}

	[Token(Token = "0x2000345")]
	private class TextShadowProperty : InlineStyleTextShadowProperty
	{

		[Token(Token = "0x1700057A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017F1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000578")]
		public virtual string Name
		{
			[Address(RVA = "0x324CC20", Offset = "0x324C020", Length = "0x2C")]
			[Token(Token = "0x60017EF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000579")]
		public virtual string ussName
		{
			[Address(RVA = "0x324CC50", Offset = "0x324C050", Length = "0x2C")]
			[Token(Token = "0x60017F0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248C80", Offset = "0x3248080", Length = "0x39")]
		[Token(Token = "0x60017F4")]
		public TextShadowProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017F1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324CC20", Offset = "0x324C020", Length = "0x2C")]
		[Token(Token = "0x60017EF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324CC50", Offset = "0x324C050", Length = "0x2C")]
		[Token(Token = "0x60017F0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324CA60", Offset = "0x324BE60", Length = "0xD7")]
		[Token(Token = "0x60017F2")]
		public virtual StyleTextShadow GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324CB40", Offset = "0x324BF40", Length = "0xD7")]
		[Token(Token = "0x60017F3")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTextShadow value) { }

	}

	[Token(Token = "0x2000346")]
	private class TopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700057D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017F7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700057B")]
		public virtual string Name
		{
			[Address(RVA = "0x324CE40", Offset = "0x324C240", Length = "0x2C")]
			[Token(Token = "0x60017F5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700057C")]
		public virtual string ussName
		{
			[Address(RVA = "0x324CE70", Offset = "0x324C270", Length = "0x2C")]
			[Token(Token = "0x60017F6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60017FA")]
		public TopProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017F7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324CE40", Offset = "0x324C240", Length = "0x2C")]
		[Token(Token = "0x60017F5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324CE70", Offset = "0x324C270", Length = "0x2C")]
		[Token(Token = "0x60017F6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324CC80", Offset = "0x324C080", Length = "0xD7")]
		[Token(Token = "0x60017F8")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324CD60", Offset = "0x324C160", Length = "0xD7")]
		[Token(Token = "0x60017F9")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000347")]
	private class TransformOriginProperty : InlineStyleTransformOriginProperty
	{

		[Token(Token = "0x17000580")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60017FD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700057E")]
		public virtual string Name
		{
			[Address(RVA = "0x324D060", Offset = "0x324C460", Length = "0x2C")]
			[Token(Token = "0x60017FB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700057F")]
		public virtual string ussName
		{
			[Address(RVA = "0x324D090", Offset = "0x324C490", Length = "0x2C")]
			[Token(Token = "0x60017FC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248CC0", Offset = "0x32480C0", Length = "0x39")]
		[Token(Token = "0x6001800")]
		public TransformOriginProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60017FD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324D060", Offset = "0x324C460", Length = "0x2C")]
		[Token(Token = "0x60017FB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324D090", Offset = "0x324C490", Length = "0x2C")]
		[Token(Token = "0x60017FC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324CEA0", Offset = "0x324C2A0", Length = "0xD9")]
		[Token(Token = "0x60017FE")]
		public virtual StyleTransformOrigin GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324CF80", Offset = "0x324C380", Length = "0xD9")]
		[Token(Token = "0x60017FF")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTransformOrigin value) { }

	}

	[Token(Token = "0x2000348")]
	private class TransitionDelayProperty : InlineStyleListProperty<TimeValue>
	{

		[Token(Token = "0x17000583")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001803")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000581")]
		public virtual string Name
		{
			[Address(RVA = "0x324D2A0", Offset = "0x324C6A0", Length = "0x2C")]
			[Token(Token = "0x6001801")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000582")]
		public virtual string ussName
		{
			[Address(RVA = "0x324D2D0", Offset = "0x324C6D0", Length = "0x2C")]
			[Token(Token = "0x6001802")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324D260", Offset = "0x324C660", Length = "0x39")]
		[Token(Token = "0x6001806")]
		public TransitionDelayProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001803")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324D2A0", Offset = "0x324C6A0", Length = "0x2C")]
		[Token(Token = "0x6001801")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324D2D0", Offset = "0x324C6D0", Length = "0x2C")]
		[Token(Token = "0x6001802")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324D0C0", Offset = "0x324C4C0", Length = "0xCF")]
		[Token(Token = "0x6001804")]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324D190", Offset = "0x324C590", Length = "0xCE")]
		[Token(Token = "0x6001805")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	[Token(Token = "0x2000349")]
	private class TransitionDurationProperty : InlineStyleListProperty<TimeValue>
	{

		[Token(Token = "0x17000586")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001809")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000584")]
		public virtual string Name
		{
			[Address(RVA = "0x324D4E0", Offset = "0x324C8E0", Length = "0x2C")]
			[Token(Token = "0x6001807")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000585")]
		public virtual string ussName
		{
			[Address(RVA = "0x324D510", Offset = "0x324C910", Length = "0x2C")]
			[Token(Token = "0x6001808")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324D4A0", Offset = "0x324C8A0", Length = "0x39")]
		[Token(Token = "0x600180C")]
		public TransitionDurationProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001809")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324D4E0", Offset = "0x324C8E0", Length = "0x2C")]
		[Token(Token = "0x6001807")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324D510", Offset = "0x324C910", Length = "0x2C")]
		[Token(Token = "0x6001808")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324D300", Offset = "0x324C700", Length = "0xCF")]
		[Token(Token = "0x600180A")]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324D3D0", Offset = "0x324C7D0", Length = "0xCE")]
		[Token(Token = "0x600180B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	[Token(Token = "0x200034A")]
	private class TransitionPropertyProperty : InlineStyleListProperty<StylePropertyName>
	{

		[Token(Token = "0x17000589")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600180F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000587")]
		public virtual string Name
		{
			[Address(RVA = "0x324D720", Offset = "0x324CB20", Length = "0x2C")]
			[Token(Token = "0x600180D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000588")]
		public virtual string ussName
		{
			[Address(RVA = "0x324D750", Offset = "0x324CB50", Length = "0x2C")]
			[Token(Token = "0x600180E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324D6E0", Offset = "0x324CAE0", Length = "0x39")]
		[Token(Token = "0x6001812")]
		public TransitionPropertyProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600180F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324D720", Offset = "0x324CB20", Length = "0x2C")]
		[Token(Token = "0x600180D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324D750", Offset = "0x324CB50", Length = "0x2C")]
		[Token(Token = "0x600180E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324D540", Offset = "0x324C940", Length = "0xCF")]
		[Token(Token = "0x6001810")]
		public virtual StyleList<StylePropertyName> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324D610", Offset = "0x324CA10", Length = "0xCE")]
		[Token(Token = "0x6001811")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<StylePropertyName> value) { }

	}

	[Token(Token = "0x200034B")]
	private class TransitionTimingFunctionProperty : InlineStyleListProperty<EasingFunction>
	{

		[Token(Token = "0x1700058C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001815")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700058A")]
		public virtual string Name
		{
			[Address(RVA = "0x324D960", Offset = "0x324CD60", Length = "0x2C")]
			[Token(Token = "0x6001813")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700058B")]
		public virtual string ussName
		{
			[Address(RVA = "0x324D990", Offset = "0x324CD90", Length = "0x2C")]
			[Token(Token = "0x6001814")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324D920", Offset = "0x324CD20", Length = "0x39")]
		[Token(Token = "0x6001818")]
		public TransitionTimingFunctionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001815")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324D960", Offset = "0x324CD60", Length = "0x2C")]
		[Token(Token = "0x6001813")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324D990", Offset = "0x324CD90", Length = "0x2C")]
		[Token(Token = "0x6001814")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324D780", Offset = "0x324CB80", Length = "0xCF")]
		[Token(Token = "0x6001816")]
		public virtual StyleList<EasingFunction> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324D850", Offset = "0x324CC50", Length = "0xCE")]
		[Token(Token = "0x6001817")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<EasingFunction> value) { }

	}

	[Token(Token = "0x200034C")]
	private class TranslateProperty : InlineStyleTranslateProperty
	{

		[Token(Token = "0x1700058F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600181B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700058D")]
		public virtual string Name
		{
			[Address(RVA = "0x324DB90", Offset = "0x324CF90", Length = "0x2C")]
			[Token(Token = "0x6001819")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700058E")]
		public virtual string ussName
		{
			[Address(RVA = "0x324DBC0", Offset = "0x324CFC0", Length = "0x2C")]
			[Token(Token = "0x600181A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248D00", Offset = "0x3248100", Length = "0x39")]
		[Token(Token = "0x600181E")]
		public TranslateProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600181B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324DB90", Offset = "0x324CF90", Length = "0x2C")]
		[Token(Token = "0x6001819")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324DBC0", Offset = "0x324CFC0", Length = "0x2C")]
		[Token(Token = "0x600181A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324D9C0", Offset = "0x324CDC0", Length = "0xDF")]
		[Token(Token = "0x600181C")]
		public virtual StyleTranslate GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324DAA0", Offset = "0x324CEA0", Length = "0xE0")]
		[Token(Token = "0x600181D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTranslate value) { }

	}

	[Token(Token = "0x200034D")]
	private class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000592")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001821")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000590")]
		public virtual string Name
		{
			[Address(RVA = "0x324E620", Offset = "0x324DA20", Length = "0x2C")]
			[Token(Token = "0x600181F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000591")]
		public virtual string ussName
		{
			[Address(RVA = "0x324E650", Offset = "0x324DA50", Length = "0x2C")]
			[Token(Token = "0x6001820")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x6001824")]
		public UnityBackgroundImageTintColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001821")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324E620", Offset = "0x324DA20", Length = "0x2C")]
		[Token(Token = "0x600181F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324E650", Offset = "0x324DA50", Length = "0x2C")]
		[Token(Token = "0x6001820")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324E460", Offset = "0x324D860", Length = "0xD5")]
		[Token(Token = "0x6001822")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324E540", Offset = "0x324D940", Length = "0xD7")]
		[Token(Token = "0x6001823")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200034E")]
	private class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty<EditorTextRenderingMode>
	{

		[Token(Token = "0x17000595")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001827")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000593")]
		public virtual string Name
		{
			[Address(RVA = "0x324E850", Offset = "0x324DC50", Length = "0x2C")]
			[Token(Token = "0x6001825")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000594")]
		public virtual string ussName
		{
			[Address(RVA = "0x324E880", Offset = "0x324DC80", Length = "0x2C")]
			[Token(Token = "0x6001826")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324E810", Offset = "0x324DC10", Length = "0x39")]
		[Token(Token = "0x600182A")]
		public UnityEditorTextRenderingModeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001827")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324E850", Offset = "0x324DC50", Length = "0x2C")]
		[Token(Token = "0x6001825")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324E880", Offset = "0x324DC80", Length = "0x2C")]
		[Token(Token = "0x6001826")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324E680", Offset = "0x324DA80", Length = "0xBE")]
		[Token(Token = "0x6001828")]
		public virtual StyleEnum<EditorTextRenderingMode> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324E740", Offset = "0x324DB40", Length = "0xC5")]
		[Token(Token = "0x6001829")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<EditorTextRenderingMode> value) { }

	}

	[Token(Token = "0x2000350")]
	private class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
	{

		[Token(Token = "0x1700059B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001833")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000599")]
		public virtual string Name
		{
			[Address(RVA = "0x324EA80", Offset = "0x324DE80", Length = "0x2C")]
			[Token(Token = "0x6001831")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700059A")]
		public virtual string ussName
		{
			[Address(RVA = "0x324EAB0", Offset = "0x324DEB0", Length = "0x2C")]
			[Token(Token = "0x6001832")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324EA70", Offset = "0x324DE70", Length = "0x7")]
		[Token(Token = "0x6001836")]
		public UnityFontDefinitionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001833")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324EA80", Offset = "0x324DE80", Length = "0x2C")]
		[Token(Token = "0x6001831")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324EAB0", Offset = "0x324DEB0", Length = "0x2C")]
		[Token(Token = "0x6001832")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324E8B0", Offset = "0x324DCB0", Length = "0xDB")]
		[Token(Token = "0x6001834")]
		public virtual StyleFontDefinition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324E990", Offset = "0x324DD90", Length = "0xDB")]
		[Token(Token = "0x6001835")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFontDefinition value) { }

	}

	[Token(Token = "0x200034F")]
	private class UnityFontProperty : InlineStyleFontProperty
	{

		[Token(Token = "0x17000598")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600182D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000596")]
		public virtual string Name
		{
			[Address(RVA = "0x324ECA0", Offset = "0x324E0A0", Length = "0x2C")]
			[Token(Token = "0x600182B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000597")]
		public virtual string ussName
		{
			[Address(RVA = "0x324ECD0", Offset = "0x324E0D0", Length = "0x2C")]
			[Token(Token = "0x600182C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248310", Offset = "0x3247710", Length = "0x39")]
		[Token(Token = "0x6001830")]
		public UnityFontProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600182D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324ECA0", Offset = "0x324E0A0", Length = "0x2C")]
		[Token(Token = "0x600182B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324ECD0", Offset = "0x324E0D0", Length = "0x2C")]
		[Token(Token = "0x600182C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324EAE0", Offset = "0x324DEE0", Length = "0xD1")]
		[Token(Token = "0x600182E")]
		public virtual StyleFont GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324EBC0", Offset = "0x324DFC0", Length = "0xD0")]
		[Token(Token = "0x600182F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFont value) { }

	}

	[Token(Token = "0x2000351")]
	private class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty<FontStyle>
	{

		[Token(Token = "0x1700059E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001839")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700059C")]
		public virtual string Name
		{
			[Address(RVA = "0x324EED0", Offset = "0x324E2D0", Length = "0x2C")]
			[Token(Token = "0x6001837")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700059D")]
		public virtual string ussName
		{
			[Address(RVA = "0x324EF00", Offset = "0x324E300", Length = "0x2C")]
			[Token(Token = "0x6001838")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324EE90", Offset = "0x324E290", Length = "0x39")]
		[Token(Token = "0x600183C")]
		public UnityFontStyleAndWeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001839")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324EED0", Offset = "0x324E2D0", Length = "0x2C")]
		[Token(Token = "0x6001837")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324EF00", Offset = "0x324E300", Length = "0x2C")]
		[Token(Token = "0x6001838")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324ED00", Offset = "0x324E100", Length = "0xBE")]
		[Token(Token = "0x600183A")]
		public virtual StyleEnum<FontStyle> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324EDC0", Offset = "0x324E1C0", Length = "0xC5")]
		[Token(Token = "0x600183B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FontStyle> value) { }

	}

	[Token(Token = "0x2000352")]
	private class UnityMaterialProperty : InlineStyleMaterialDefinitionProperty
	{

		[Token(Token = "0x170005A1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600183F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700059F")]
		public virtual string Name
		{
			[Address(RVA = "0x324F100", Offset = "0x324E500", Length = "0x2C")]
			[Token(Token = "0x600183D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A0")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F130", Offset = "0x324E530", Length = "0x2C")]
			[Token(Token = "0x600183E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324F0F0", Offset = "0x324E4F0", Length = "0x7")]
		[Token(Token = "0x6001842")]
		public UnityMaterialProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600183F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F100", Offset = "0x324E500", Length = "0x2C")]
		[Token(Token = "0x600183D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F130", Offset = "0x324E530", Length = "0x2C")]
		[Token(Token = "0x600183E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324EF30", Offset = "0x324E330", Length = "0xDB")]
		[Token(Token = "0x6001840")]
		public virtual StyleMaterialDefinition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F010", Offset = "0x324E410", Length = "0xDB")]
		[Token(Token = "0x6001841")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleMaterialDefinition value) { }

	}

	[Token(Token = "0x2000353")]
	private class UnityOverflowClipBoxProperty : InlineStyleEnumProperty<OverflowClipBox>
	{

		[Token(Token = "0x170005A4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001845")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005A2")]
		public virtual string Name
		{
			[Address(RVA = "0x324F330", Offset = "0x324E730", Length = "0x2C")]
			[Token(Token = "0x6001843")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A3")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F360", Offset = "0x324E760", Length = "0x2C")]
			[Token(Token = "0x6001844")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324F2F0", Offset = "0x324E6F0", Length = "0x39")]
		[Token(Token = "0x6001848")]
		public UnityOverflowClipBoxProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001845")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F330", Offset = "0x324E730", Length = "0x2C")]
		[Token(Token = "0x6001843")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F360", Offset = "0x324E760", Length = "0x2C")]
		[Token(Token = "0x6001844")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F160", Offset = "0x324E560", Length = "0xBE")]
		[Token(Token = "0x6001846")]
		public virtual StyleEnum<OverflowClipBox> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F220", Offset = "0x324E620", Length = "0xC5")]
		[Token(Token = "0x6001847")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<OverflowClipBox> value) { }

	}

	[Token(Token = "0x2000354")]
	private class UnityParagraphSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170005A7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600184B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005A5")]
		public virtual string Name
		{
			[Address(RVA = "0x324F550", Offset = "0x324E950", Length = "0x2C")]
			[Token(Token = "0x6001849")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A6")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F580", Offset = "0x324E980", Length = "0x2C")]
			[Token(Token = "0x600184A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x600184E")]
		public UnityParagraphSpacingProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600184B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F550", Offset = "0x324E950", Length = "0x2C")]
		[Token(Token = "0x6001849")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F580", Offset = "0x324E980", Length = "0x2C")]
		[Token(Token = "0x600184A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F390", Offset = "0x324E790", Length = "0xD9")]
		[Token(Token = "0x600184C")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F470", Offset = "0x324E870", Length = "0xD9")]
		[Token(Token = "0x600184D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000355")]
	private class UnitySliceBottomProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x170005AA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001851")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005A8")]
		public virtual string Name
		{
			[Address(RVA = "0x324F660", Offset = "0x324EA60", Length = "0x2C")]
			[Token(Token = "0x600184F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A9")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F690", Offset = "0x324EA90", Length = "0x2C")]
			[Token(Token = "0x6001850")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248350", Offset = "0x3247750", Length = "0x39")]
		[Token(Token = "0x6001854")]
		public UnitySliceBottomProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001851")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F660", Offset = "0x324EA60", Length = "0x2C")]
		[Token(Token = "0x600184F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F690", Offset = "0x324EA90", Length = "0x2C")]
		[Token(Token = "0x6001850")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F5B0", Offset = "0x324E9B0", Length = "0x48")]
		[Token(Token = "0x6001852")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F600", Offset = "0x324EA00", Length = "0x57")]
		[Token(Token = "0x6001853")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000356")]
	private class UnitySliceLeftProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x170005AD")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001857")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005AB")]
		public virtual string Name
		{
			[Address(RVA = "0x324F770", Offset = "0x324EB70", Length = "0x2C")]
			[Token(Token = "0x6001855")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005AC")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F7A0", Offset = "0x324EBA0", Length = "0x2C")]
			[Token(Token = "0x6001856")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248350", Offset = "0x3247750", Length = "0x39")]
		[Token(Token = "0x600185A")]
		public UnitySliceLeftProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001857")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F770", Offset = "0x324EB70", Length = "0x2C")]
		[Token(Token = "0x6001855")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F7A0", Offset = "0x324EBA0", Length = "0x2C")]
		[Token(Token = "0x6001856")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F6C0", Offset = "0x324EAC0", Length = "0x48")]
		[Token(Token = "0x6001858")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F710", Offset = "0x324EB10", Length = "0x57")]
		[Token(Token = "0x6001859")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000357")]
	private class UnitySliceRightProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x170005B0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600185D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005AE")]
		public virtual string Name
		{
			[Address(RVA = "0x324F880", Offset = "0x324EC80", Length = "0x2C")]
			[Token(Token = "0x600185B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005AF")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F8B0", Offset = "0x324ECB0", Length = "0x2C")]
			[Token(Token = "0x600185C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248350", Offset = "0x3247750", Length = "0x39")]
		[Token(Token = "0x6001860")]
		public UnitySliceRightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600185D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F880", Offset = "0x324EC80", Length = "0x2C")]
		[Token(Token = "0x600185B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F8B0", Offset = "0x324ECB0", Length = "0x2C")]
		[Token(Token = "0x600185C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F7D0", Offset = "0x324EBD0", Length = "0x48")]
		[Token(Token = "0x600185E")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F820", Offset = "0x324EC20", Length = "0x57")]
		[Token(Token = "0x600185F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000358")]
	private class UnitySliceScaleProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170005B3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001863")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005B1")]
		public virtual string Name
		{
			[Address(RVA = "0x324F990", Offset = "0x324ED90", Length = "0x2C")]
			[Token(Token = "0x6001861")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005B2")]
		public virtual string ussName
		{
			[Address(RVA = "0x324F9C0", Offset = "0x324EDC0", Length = "0x2C")]
			[Token(Token = "0x6001862")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x6001866")]
		public UnitySliceScaleProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001863")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324F990", Offset = "0x324ED90", Length = "0x2C")]
		[Token(Token = "0x6001861")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324F9C0", Offset = "0x324EDC0", Length = "0x2C")]
		[Token(Token = "0x6001862")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F8E0", Offset = "0x324ECE0", Length = "0x48")]
		[Token(Token = "0x6001864")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324F930", Offset = "0x324ED30", Length = "0x57")]
		[Token(Token = "0x6001865")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000359")]
	private class UnitySliceTopProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x170005B6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001869")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005B4")]
		public virtual string Name
		{
			[Address(RVA = "0x324FAA0", Offset = "0x324EEA0", Length = "0x2C")]
			[Token(Token = "0x6001867")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005B5")]
		public virtual string ussName
		{
			[Address(RVA = "0x324FAD0", Offset = "0x324EED0", Length = "0x2C")]
			[Token(Token = "0x6001868")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248350", Offset = "0x3247750", Length = "0x39")]
		[Token(Token = "0x600186C")]
		public UnitySliceTopProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001869")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324FAA0", Offset = "0x324EEA0", Length = "0x2C")]
		[Token(Token = "0x6001867")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324FAD0", Offset = "0x324EED0", Length = "0x2C")]
		[Token(Token = "0x6001868")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324F9F0", Offset = "0x324EDF0", Length = "0x48")]
		[Token(Token = "0x600186A")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324FA40", Offset = "0x324EE40", Length = "0x57")]
		[Token(Token = "0x600186B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x200035A")]
	private class UnitySliceTypeProperty : InlineStyleEnumProperty<SliceType>
	{

		[Token(Token = "0x170005B9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600186F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005B7")]
		public virtual string Name
		{
			[Address(RVA = "0x324FCD0", Offset = "0x324F0D0", Length = "0x2C")]
			[Token(Token = "0x600186D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005B8")]
		public virtual string ussName
		{
			[Address(RVA = "0x324FD00", Offset = "0x324F100", Length = "0x2C")]
			[Token(Token = "0x600186E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324FC90", Offset = "0x324F090", Length = "0x39")]
		[Token(Token = "0x6001872")]
		public UnitySliceTypeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600186F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324FCD0", Offset = "0x324F0D0", Length = "0x2C")]
		[Token(Token = "0x600186D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324FD00", Offset = "0x324F100", Length = "0x2C")]
		[Token(Token = "0x600186E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324FB00", Offset = "0x324EF00", Length = "0xBE")]
		[Token(Token = "0x6001870")]
		public virtual StyleEnum<SliceType> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324FBC0", Offset = "0x324EFC0", Length = "0xC5")]
		[Token(Token = "0x6001871")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<SliceType> value) { }

	}

	[Token(Token = "0x200035B")]
	private class UnityTextAlignProperty : InlineStyleEnumProperty<TextAnchor>
	{

		[Token(Token = "0x170005BC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001875")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005BA")]
		public virtual string Name
		{
			[Address(RVA = "0x324FF00", Offset = "0x324F300", Length = "0x2C")]
			[Token(Token = "0x6001873")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005BB")]
		public virtual string ussName
		{
			[Address(RVA = "0x324FF30", Offset = "0x324F330", Length = "0x2C")]
			[Token(Token = "0x6001874")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x324FEC0", Offset = "0x324F2C0", Length = "0x39")]
		[Token(Token = "0x6001878")]
		public UnityTextAlignProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001875")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x324FF00", Offset = "0x324F300", Length = "0x2C")]
		[Token(Token = "0x6001873")]
		public virtual string get_Name() { }

		[Address(RVA = "0x324FF30", Offset = "0x324F330", Length = "0x2C")]
		[Token(Token = "0x6001874")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324FD30", Offset = "0x324F130", Length = "0xBE")]
		[Token(Token = "0x6001876")]
		public virtual StyleEnum<TextAnchor> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x324FDF0", Offset = "0x324F1F0", Length = "0xC5")]
		[Token(Token = "0x6001877")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextAnchor> value) { }

	}

	[Token(Token = "0x200035C")]
	private class UnityTextAutoSizeProperty : InlineStyleTextAutoSizeProperty
	{

		[Token(Token = "0x170005BF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600187B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005BD")]
		public virtual string Name
		{
			[Address(RVA = "0x3250120", Offset = "0x324F520", Length = "0x2C")]
			[Token(Token = "0x6001879")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005BE")]
		public virtual string ussName
		{
			[Address(RVA = "0x3250150", Offset = "0x324F550", Length = "0x2C")]
			[Token(Token = "0x600187A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3248C40", Offset = "0x3248040", Length = "0x39")]
		[Token(Token = "0x600187E")]
		public UnityTextAutoSizeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600187B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3250120", Offset = "0x324F520", Length = "0x2C")]
		[Token(Token = "0x6001879")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3250150", Offset = "0x324F550", Length = "0x2C")]
		[Token(Token = "0x600187A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x324FF60", Offset = "0x324F360", Length = "0xDB")]
		[Token(Token = "0x600187C")]
		public virtual StyleTextAutoSize GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3250040", Offset = "0x324F440", Length = "0xDB")]
		[Token(Token = "0x600187D")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTextAutoSize value) { }

	}

	[Token(Token = "0x200035D")]
	private class UnityTextGeneratorProperty : InlineStyleEnumProperty<TextGeneratorType>
	{

		[Token(Token = "0x170005C2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001881")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005C0")]
		public virtual string Name
		{
			[Address(RVA = "0x3250350", Offset = "0x324F750", Length = "0x2C")]
			[Token(Token = "0x600187F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005C1")]
		public virtual string ussName
		{
			[Address(RVA = "0x3250380", Offset = "0x324F780", Length = "0x2C")]
			[Token(Token = "0x6001880")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3250310", Offset = "0x324F710", Length = "0x39")]
		[Token(Token = "0x6001884")]
		public UnityTextGeneratorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001881")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3250350", Offset = "0x324F750", Length = "0x2C")]
		[Token(Token = "0x600187F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3250380", Offset = "0x324F780", Length = "0x2C")]
		[Token(Token = "0x6001880")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3250180", Offset = "0x324F580", Length = "0xBE")]
		[Token(Token = "0x6001882")]
		public virtual StyleEnum<TextGeneratorType> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3250240", Offset = "0x324F640", Length = "0xC5")]
		[Token(Token = "0x6001883")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextGeneratorType> value) { }

	}

	[Token(Token = "0x200035E")]
	private class UnityTextOutlineColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170005C5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001887")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005C3")]
		public virtual string Name
		{
			[Address(RVA = "0x3250570", Offset = "0x324F970", Length = "0x2C")]
			[Token(Token = "0x6001885")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005C4")]
		public virtual string ussName
		{
			[Address(RVA = "0x32505A0", Offset = "0x324F9A0", Length = "0x2C")]
			[Token(Token = "0x6001886")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x322F9D0", Offset = "0x322EDD0", Length = "0x7")]
		[Token(Token = "0x600188A")]
		public UnityTextOutlineColorProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001887")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3250570", Offset = "0x324F970", Length = "0x2C")]
		[Token(Token = "0x6001885")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32505A0", Offset = "0x324F9A0", Length = "0x2C")]
		[Token(Token = "0x6001886")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32503B0", Offset = "0x324F7B0", Length = "0xD7")]
		[Token(Token = "0x6001888")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3250490", Offset = "0x324F890", Length = "0xD7")]
		[Token(Token = "0x6001889")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200035F")]
	private class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170005C8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600188D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005C6")]
		public virtual string Name
		{
			[Address(RVA = "0x3250680", Offset = "0x324FA80", Length = "0x2C")]
			[Token(Token = "0x600188B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005C7")]
		public virtual string ussName
		{
			[Address(RVA = "0x32506B0", Offset = "0x324FAB0", Length = "0x2C")]
			[Token(Token = "0x600188C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231D40", Offset = "0x3231140", Length = "0x7")]
		[Token(Token = "0x6001890")]
		public UnityTextOutlineWidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600188D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3250680", Offset = "0x324FA80", Length = "0x2C")]
		[Token(Token = "0x600188B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32506B0", Offset = "0x324FAB0", Length = "0x2C")]
		[Token(Token = "0x600188C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32505D0", Offset = "0x324F9D0", Length = "0x48")]
		[Token(Token = "0x600188E")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3250620", Offset = "0x324FA20", Length = "0x57")]
		[Token(Token = "0x600188F")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000360")]
	private class UnityTextOverflowPositionProperty : InlineStyleEnumProperty<TextOverflowPosition>
	{

		[Token(Token = "0x170005CB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001893")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005C9")]
		public virtual string Name
		{
			[Address(RVA = "0x32508B0", Offset = "0x324FCB0", Length = "0x2C")]
			[Token(Token = "0x6001891")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005CA")]
		public virtual string ussName
		{
			[Address(RVA = "0x32508E0", Offset = "0x324FCE0", Length = "0x2C")]
			[Token(Token = "0x6001892")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3250870", Offset = "0x324FC70", Length = "0x39")]
		[Token(Token = "0x6001896")]
		public UnityTextOverflowPositionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001893")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32508B0", Offset = "0x324FCB0", Length = "0x2C")]
		[Token(Token = "0x6001891")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32508E0", Offset = "0x324FCE0", Length = "0x2C")]
		[Token(Token = "0x6001892")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32506E0", Offset = "0x324FAE0", Length = "0xBE")]
		[Token(Token = "0x6001894")]
		public virtual StyleEnum<TextOverflowPosition> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32507A0", Offset = "0x324FBA0", Length = "0xC5")]
		[Token(Token = "0x6001895")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflowPosition> value) { }

	}

	[Token(Token = "0x2000361")]
	private class VisibilityProperty : InlineStyleEnumProperty<Visibility>
	{

		[Token(Token = "0x170005CE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001899")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005CC")]
		public virtual string Name
		{
			[Address(RVA = "0x3250A70", Offset = "0x324FE70", Length = "0x2C")]
			[Token(Token = "0x6001897")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005CD")]
		public virtual string ussName
		{
			[Address(RVA = "0x3250AA0", Offset = "0x324FEA0", Length = "0x2C")]
			[Token(Token = "0x6001898")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3250A30", Offset = "0x324FE30", Length = "0x39")]
		[Token(Token = "0x600189C")]
		public VisibilityProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001899")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3250A70", Offset = "0x324FE70", Length = "0x2C")]
		[Token(Token = "0x6001897")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3250AA0", Offset = "0x324FEA0", Length = "0x2C")]
		[Token(Token = "0x6001898")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3250910", Offset = "0x324FD10", Length = "0xBE")]
		[Token(Token = "0x600189A")]
		public virtual StyleEnum<Visibility> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x32509D0", Offset = "0x324FDD0", Length = "0x57")]
		[Token(Token = "0x600189B")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Visibility> value) { }

	}

	[Token(Token = "0x2000362")]
	private class WhiteSpaceProperty : InlineStyleEnumProperty<WhiteSpace>
	{

		[Token(Token = "0x170005D1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600189F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005CF")]
		public virtual string Name
		{
			[Address(RVA = "0x3267990", Offset = "0x3266D90", Length = "0x2C")]
			[Token(Token = "0x600189D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005D0")]
		public virtual string ussName
		{
			[Address(RVA = "0x32679C0", Offset = "0x3266DC0", Length = "0x2C")]
			[Token(Token = "0x600189E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3267950", Offset = "0x3266D50", Length = "0x39")]
		[Token(Token = "0x60018A2")]
		public WhiteSpaceProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600189F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3267990", Offset = "0x3266D90", Length = "0x2C")]
		[Token(Token = "0x600189D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32679C0", Offset = "0x3266DC0", Length = "0x2C")]
		[Token(Token = "0x600189E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32677C0", Offset = "0x3266BC0", Length = "0xBE")]
		[Token(Token = "0x60018A0")]
		public virtual StyleEnum<WhiteSpace> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3267880", Offset = "0x3266C80", Length = "0xC5")]
		[Token(Token = "0x60018A1")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<WhiteSpace> value) { }

	}

	[Token(Token = "0x2000363")]
	private class WidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170005D4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60018A5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005D2")]
		public virtual string Name
		{
			[Address(RVA = "0x3267BB0", Offset = "0x3266FB0", Length = "0x2C")]
			[Token(Token = "0x60018A3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005D3")]
		public virtual string ussName
		{
			[Address(RVA = "0x3267BE0", Offset = "0x3266FE0", Length = "0x2C")]
			[Token(Token = "0x60018A4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60018A8")]
		public WidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60018A5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3267BB0", Offset = "0x3266FB0", Length = "0x2C")]
		[Token(Token = "0x60018A3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3267BE0", Offset = "0x3266FE0", Length = "0x2C")]
		[Token(Token = "0x60018A4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32679F0", Offset = "0x3266DF0", Length = "0xD9")]
		[Token(Token = "0x60018A6")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3267AD0", Offset = "0x3266ED0", Length = "0xD9")]
		[Token(Token = "0x60018A7")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000364")]
	private class WordSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170005D7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60018AB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005D5")]
		public virtual string Name
		{
			[Address(RVA = "0x3267DD0", Offset = "0x32671D0", Length = "0x2C")]
			[Token(Token = "0x60018A9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005D6")]
		public virtual string ussName
		{
			[Address(RVA = "0x3267E00", Offset = "0x3267200", Length = "0x2C")]
			[Token(Token = "0x60018AA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3231A00", Offset = "0x3230E00", Length = "0x7")]
		[Token(Token = "0x60018AE")]
		public WordSpacingProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60018AB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3267DD0", Offset = "0x32671D0", Length = "0x2C")]
		[Token(Token = "0x60018A9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3267E00", Offset = "0x3267200", Length = "0x2C")]
		[Token(Token = "0x60018AA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3267C10", Offset = "0x3267010", Length = "0xD9")]
		[Token(Token = "0x60018AC")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x3267CF0", Offset = "0x32670F0", Length = "0xD9")]
		[Token(Token = "0x60018AD")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C79")]
	private readonly List<IProperty`1<InlineStyleAccess>> m_PropertiesList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C7A")]
	private readonly Dictionary<String, IProperty`1<InlineStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[Address(RVA = "0x3238620", Offset = "0x3237A20", Length = "0x16CD")]
	[Token(Token = "0x600169A")]
	public InlineStyleAccessPropertyBag() { }

	[Address(RVA = "0x830670", Offset = "0x82FA70", Length = "0x17B")]
	[Token(Token = "0x600169B")]
	private void AddProperty(InlineStyleProperty<TStyleValue, TValue> property) { }

	[Address(RVA = "0x32384F0", Offset = "0x32378F0", Length = "0x5D")]
	[Token(Token = "0x600169C")]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties() { }

	[Address(RVA = "0x3238550", Offset = "0x3237950", Length = "0x5D")]
	[Token(Token = "0x600169D")]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties(ref InlineStyleAccess container) { }

	[Address(RVA = "0x32385B0", Offset = "0x32379B0", Length = "0x63")]
	[Token(Token = "0x600169E")]
	public override bool TryGetProperty(ref InlineStyleAccess container, string name, out IProperty<InlineStyleAccess>& property) { }

}

