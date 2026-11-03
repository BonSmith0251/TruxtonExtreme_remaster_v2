namespace UnityEngine.UIElements;

[Token(Token = "0x2000392")]
internal class ResolvedStyleAccessPropertyBag : PropertyBag<ResolvedStyleAccess>, INamedProperties<ResolvedStyleAccess>
{
	[Token(Token = "0x2000393")]
	private class AlignContentProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x1700079F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C30")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700079D")]
		public virtual string Name
		{
			[Address(RVA = "0x3267F00", Offset = "0x3267300", Length = "0x2C")]
			[Token(Token = "0x6001C2E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700079E")]
		public virtual string ussName
		{
			[Address(RVA = "0x3267F30", Offset = "0x3267330", Length = "0x2C")]
			[Token(Token = "0x6001C2F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3267EC0", Offset = "0x32672C0", Length = "0x39")]
		[Token(Token = "0x6001C33")]
		public AlignContentProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C30")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3267F00", Offset = "0x3267300", Length = "0x2C")]
		[Token(Token = "0x6001C2E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3267F30", Offset = "0x3267330", Length = "0x2C")]
		[Token(Token = "0x6001C2F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3267E30", Offset = "0x3267230", Length = "0x45")]
		[Token(Token = "0x6001C31")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3267E80", Offset = "0x3267280", Length = "0x3E")]
		[Token(Token = "0x6001C32")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x2000394")]
	private class AlignItemsProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x170007A2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C36")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A0")]
		public virtual string Name
		{
			[Address(RVA = "0x3268030", Offset = "0x3267430", Length = "0x2C")]
			[Token(Token = "0x6001C34")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A1")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268060", Offset = "0x3267460", Length = "0x2C")]
			[Token(Token = "0x6001C35")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3267FF0", Offset = "0x32673F0", Length = "0x39")]
		[Token(Token = "0x6001C39")]
		public AlignItemsProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C36")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268030", Offset = "0x3267430", Length = "0x2C")]
		[Token(Token = "0x6001C34")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268060", Offset = "0x3267460", Length = "0x2C")]
		[Token(Token = "0x6001C35")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3267F60", Offset = "0x3267360", Length = "0x48")]
		[Token(Token = "0x6001C37")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3267FB0", Offset = "0x32673B0", Length = "0x3E")]
		[Token(Token = "0x6001C38")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x2000395")]
	private class AlignSelfProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x170007A5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C3C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A3")]
		public virtual string Name
		{
			[Address(RVA = "0x3268160", Offset = "0x3267560", Length = "0x2C")]
			[Token(Token = "0x6001C3A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A4")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268190", Offset = "0x3267590", Length = "0x2C")]
			[Token(Token = "0x6001C3B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268120", Offset = "0x3267520", Length = "0x39")]
		[Token(Token = "0x6001C3F")]
		public AlignSelfProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C3C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268160", Offset = "0x3267560", Length = "0x2C")]
		[Token(Token = "0x6001C3A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268190", Offset = "0x3267590", Length = "0x2C")]
		[Token(Token = "0x6001C3B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268090", Offset = "0x3267490", Length = "0x48")]
		[Token(Token = "0x6001C3D")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32680E0", Offset = "0x32674E0", Length = "0x3E")]
		[Token(Token = "0x6001C3E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x2000396")]
	private class AspectRatioProperty : ResolvedRatioProperty
	{

		[Token(Token = "0x170007A8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C42")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A6")]
		public virtual string Name
		{
			[Address(RVA = "0x3268380", Offset = "0x3267780", Length = "0x2C")]
			[Token(Token = "0x6001C40")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A7")]
		public virtual string ussName
		{
			[Address(RVA = "0x32683B0", Offset = "0x32677B0", Length = "0x2C")]
			[Token(Token = "0x6001C41")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268340", Offset = "0x3267740", Length = "0x39")]
		[Token(Token = "0x6001C45")]
		public AspectRatioProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C42")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268380", Offset = "0x3267780", Length = "0x2C")]
		[Token(Token = "0x6001C40")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32683B0", Offset = "0x32677B0", Length = "0x2C")]
		[Token(Token = "0x6001C41")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268240", Offset = "0x3267640", Length = "0xBC")]
		[Token(Token = "0x6001C43")]
		public virtual Ratio GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3268300", Offset = "0x3267700", Length = "0x3E")]
		[Token(Token = "0x6001C44")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Ratio value) { }

	}

	[Token(Token = "0x2000397")]
	private class BackgroundColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007AB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C48")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A9")]
		public virtual string Name
		{
			[Address(RVA = "0x32686B0", Offset = "0x3267AB0", Length = "0x2C")]
			[Token(Token = "0x6001C46")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007AA")]
		public virtual string ussName
		{
			[Address(RVA = "0x32686E0", Offset = "0x3267AE0", Length = "0x2C")]
			[Token(Token = "0x6001C47")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001C4B")]
		public BackgroundColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C48")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32686B0", Offset = "0x3267AB0", Length = "0x2C")]
		[Token(Token = "0x6001C46")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32686E0", Offset = "0x3267AE0", Length = "0x2C")]
		[Token(Token = "0x6001C47")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268560", Offset = "0x3267960", Length = "0xCF")]
		[Token(Token = "0x6001C49")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3268630", Offset = "0x3267A30", Length = "0x3E")]
		[Token(Token = "0x6001C4A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x2000398")]
	private class BackgroundImageProperty : ResolvedBackgroundProperty
	{

		[Token(Token = "0x170007AE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C4E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007AC")]
		public virtual string Name
		{
			[Address(RVA = "0x3268870", Offset = "0x3267C70", Length = "0x2C")]
			[Token(Token = "0x6001C4C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007AD")]
		public virtual string ussName
		{
			[Address(RVA = "0x32688A0", Offset = "0x3267CA0", Length = "0x2C")]
			[Token(Token = "0x6001C4D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268830", Offset = "0x3267C30", Length = "0x39")]
		[Token(Token = "0x6001C51")]
		public BackgroundImageProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C4E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268870", Offset = "0x3267C70", Length = "0x2C")]
		[Token(Token = "0x6001C4C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32688A0", Offset = "0x3267CA0", Length = "0x2C")]
		[Token(Token = "0x6001C4D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268710", Offset = "0x3267B10", Length = "0xD7")]
		[Token(Token = "0x6001C4F")]
		public virtual Background GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32687F0", Offset = "0x3267BF0", Length = "0x3E")]
		[Token(Token = "0x6001C50")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Background value) { }

	}

	[Token(Token = "0x2000399")]
	private class BackgroundPositionXProperty : ResolvedBackgroundPositionProperty
	{

		[Token(Token = "0x170007B1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C54")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007AF")]
		public virtual string Name
		{
			[Address(RVA = "0x3268A30", Offset = "0x3267E30", Length = "0x2C")]
			[Token(Token = "0x6001C52")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B0")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268A60", Offset = "0x3267E60", Length = "0x2C")]
			[Token(Token = "0x6001C53")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32689F0", Offset = "0x3267DF0", Length = "0x39")]
		[Token(Token = "0x6001C57")]
		public BackgroundPositionXProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C54")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268A30", Offset = "0x3267E30", Length = "0x2C")]
		[Token(Token = "0x6001C52")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268A60", Offset = "0x3267E60", Length = "0x2C")]
		[Token(Token = "0x6001C53")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32688D0", Offset = "0x3267CD0", Length = "0xD7")]
		[Token(Token = "0x6001C55")]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32689B0", Offset = "0x3267DB0", Length = "0x3E")]
		[Token(Token = "0x6001C56")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	[Token(Token = "0x200039A")]
	private class BackgroundPositionYProperty : ResolvedBackgroundPositionProperty
	{

		[Token(Token = "0x170007B4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C5A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B2")]
		public virtual string Name
		{
			[Address(RVA = "0x3268BB0", Offset = "0x3267FB0", Length = "0x2C")]
			[Token(Token = "0x6001C58")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B3")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268BE0", Offset = "0x3267FE0", Length = "0x2C")]
			[Token(Token = "0x6001C59")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32689F0", Offset = "0x3267DF0", Length = "0x39")]
		[Token(Token = "0x6001C5D")]
		public BackgroundPositionYProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C5A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268BB0", Offset = "0x3267FB0", Length = "0x2C")]
		[Token(Token = "0x6001C58")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268BE0", Offset = "0x3267FE0", Length = "0x2C")]
		[Token(Token = "0x6001C59")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268A90", Offset = "0x3267E90", Length = "0xD7")]
		[Token(Token = "0x6001C5B")]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3268B70", Offset = "0x3267F70", Length = "0x3E")]
		[Token(Token = "0x6001C5C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	[Token(Token = "0x200039B")]
	private class BackgroundRepeatProperty : ResolvedBackgroundRepeatProperty
	{

		[Token(Token = "0x170007B7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C60")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B5")]
		public virtual string Name
		{
			[Address(RVA = "0x3268D50", Offset = "0x3268150", Length = "0x2C")]
			[Token(Token = "0x6001C5E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B6")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268D80", Offset = "0x3268180", Length = "0x2C")]
			[Token(Token = "0x6001C5F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268D10", Offset = "0x3268110", Length = "0x39")]
		[Token(Token = "0x6001C63")]
		public BackgroundRepeatProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C60")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268D50", Offset = "0x3268150", Length = "0x2C")]
		[Token(Token = "0x6001C5E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268D80", Offset = "0x3268180", Length = "0x2C")]
		[Token(Token = "0x6001C5F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268C10", Offset = "0x3268010", Length = "0xBC")]
		[Token(Token = "0x6001C61")]
		public virtual BackgroundRepeat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3268CD0", Offset = "0x32680D0", Length = "0x3E")]
		[Token(Token = "0x6001C62")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundRepeat value) { }

	}

	[Token(Token = "0x200039C")]
	private class BackgroundSizeProperty : ResolvedBackgroundSizeProperty
	{

		[Token(Token = "0x170007BA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C66")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B8")]
		public virtual string Name
		{
			[Address(RVA = "0x3268F10", Offset = "0x3268310", Length = "0x2C")]
			[Token(Token = "0x6001C64")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B9")]
		public virtual string ussName
		{
			[Address(RVA = "0x3268F40", Offset = "0x3268340", Length = "0x2C")]
			[Token(Token = "0x6001C65")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268ED0", Offset = "0x32682D0", Length = "0x39")]
		[Token(Token = "0x6001C69")]
		public BackgroundSizeProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C66")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3268F10", Offset = "0x3268310", Length = "0x2C")]
		[Token(Token = "0x6001C64")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3268F40", Offset = "0x3268340", Length = "0x2C")]
		[Token(Token = "0x6001C65")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3268DB0", Offset = "0x32681B0", Length = "0xD5")]
		[Token(Token = "0x6001C67")]
		public virtual BackgroundSize GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3268E90", Offset = "0x3268290", Length = "0x3E")]
		[Token(Token = "0x6001C68")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundSize value) { }

	}

	[Token(Token = "0x200039D")]
	private class BorderBottomColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007BD")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C6C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007BB")]
		public virtual string Name
		{
			[Address(RVA = "0x32698A0", Offset = "0x3268CA0", Length = "0x2C")]
			[Token(Token = "0x6001C6A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007BC")]
		public virtual string ussName
		{
			[Address(RVA = "0x32698D0", Offset = "0x3268CD0", Length = "0x2C")]
			[Token(Token = "0x6001C6B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001C6F")]
		public BorderBottomColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C6C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32698A0", Offset = "0x3268CA0", Length = "0x2C")]
		[Token(Token = "0x6001C6A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32698D0", Offset = "0x3268CD0", Length = "0x2C")]
		[Token(Token = "0x6001C6B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269790", Offset = "0x3268B90", Length = "0xCF")]
		[Token(Token = "0x6001C6D")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269860", Offset = "0x3268C60", Length = "0x3E")]
		[Token(Token = "0x6001C6E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x200039E")]
	private class BorderBottomLeftRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C72")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007BE")]
		public virtual string Name
		{
			[Address(RVA = "0x32699D0", Offset = "0x3268DD0", Length = "0x2C")]
			[Token(Token = "0x6001C70")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007BF")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269A00", Offset = "0x3268E00", Length = "0x2C")]
			[Token(Token = "0x6001C71")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001C75")]
		public BorderBottomLeftRadiusProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C72")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32699D0", Offset = "0x3268DD0", Length = "0x2C")]
		[Token(Token = "0x6001C70")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269A00", Offset = "0x3268E00", Length = "0x2C")]
		[Token(Token = "0x6001C71")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269900", Offset = "0x3268D00", Length = "0x48")]
		[Token(Token = "0x6001C73")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269950", Offset = "0x3268D50", Length = "0x3E")]
		[Token(Token = "0x6001C74")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200039F")]
	private class BorderBottomRightRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C78")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C1")]
		public virtual string Name
		{
			[Address(RVA = "0x3269AC0", Offset = "0x3268EC0", Length = "0x2C")]
			[Token(Token = "0x6001C76")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C2")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269AF0", Offset = "0x3268EF0", Length = "0x2C")]
			[Token(Token = "0x6001C77")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001C7B")]
		public BorderBottomRightRadiusProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C78")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3269AC0", Offset = "0x3268EC0", Length = "0x2C")]
		[Token(Token = "0x6001C76")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269AF0", Offset = "0x3268EF0", Length = "0x2C")]
		[Token(Token = "0x6001C77")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269A30", Offset = "0x3268E30", Length = "0x48")]
		[Token(Token = "0x6001C79")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269A80", Offset = "0x3268E80", Length = "0x3E")]
		[Token(Token = "0x6001C7A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A0")]
	private class BorderBottomWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C7E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C4")]
		public virtual string Name
		{
			[Address(RVA = "0x3269BB0", Offset = "0x3268FB0", Length = "0x2C")]
			[Token(Token = "0x6001C7C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C5")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269BE0", Offset = "0x3268FE0", Length = "0x2C")]
			[Token(Token = "0x6001C7D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001C81")]
		public BorderBottomWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C7E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3269BB0", Offset = "0x3268FB0", Length = "0x2C")]
		[Token(Token = "0x6001C7C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269BE0", Offset = "0x3268FE0", Length = "0x2C")]
		[Token(Token = "0x6001C7D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269B20", Offset = "0x3268F20", Length = "0x48")]
		[Token(Token = "0x6001C7F")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269B70", Offset = "0x3268F70", Length = "0x3E")]
		[Token(Token = "0x6001C80")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A1")]
	private class BorderLeftColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007C9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C84")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C7")]
		public virtual string Name
		{
			[Address(RVA = "0x3269D20", Offset = "0x3269120", Length = "0x2C")]
			[Token(Token = "0x6001C82")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C8")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269D50", Offset = "0x3269150", Length = "0x2C")]
			[Token(Token = "0x6001C83")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001C87")]
		public BorderLeftColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C84")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3269D20", Offset = "0x3269120", Length = "0x2C")]
		[Token(Token = "0x6001C82")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269D50", Offset = "0x3269150", Length = "0x2C")]
		[Token(Token = "0x6001C83")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269C10", Offset = "0x3269010", Length = "0xCF")]
		[Token(Token = "0x6001C85")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269CE0", Offset = "0x32690E0", Length = "0x3E")]
		[Token(Token = "0x6001C86")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003A2")]
	private class BorderLeftWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007CC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C8A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007CA")]
		public virtual string Name
		{
			[Address(RVA = "0x3269E10", Offset = "0x3269210", Length = "0x2C")]
			[Token(Token = "0x6001C88")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007CB")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269E40", Offset = "0x3269240", Length = "0x2C")]
			[Token(Token = "0x6001C89")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001C8D")]
		public BorderLeftWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C8A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3269E10", Offset = "0x3269210", Length = "0x2C")]
		[Token(Token = "0x6001C88")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269E40", Offset = "0x3269240", Length = "0x2C")]
		[Token(Token = "0x6001C89")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269D80", Offset = "0x3269180", Length = "0x48")]
		[Token(Token = "0x6001C8B")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269DD0", Offset = "0x32691D0", Length = "0x3E")]
		[Token(Token = "0x6001C8C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A3")]
	private class BorderRightColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007CF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C90")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007CD")]
		public virtual string Name
		{
			[Address(RVA = "0x3269F80", Offset = "0x3269380", Length = "0x2C")]
			[Token(Token = "0x6001C8E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007CE")]
		public virtual string ussName
		{
			[Address(RVA = "0x3269FB0", Offset = "0x32693B0", Length = "0x2C")]
			[Token(Token = "0x6001C8F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001C93")]
		public BorderRightColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C90")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3269F80", Offset = "0x3269380", Length = "0x2C")]
		[Token(Token = "0x6001C8E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3269FB0", Offset = "0x32693B0", Length = "0x2C")]
		[Token(Token = "0x6001C8F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269E70", Offset = "0x3269270", Length = "0xCF")]
		[Token(Token = "0x6001C91")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3269F40", Offset = "0x3269340", Length = "0x3E")]
		[Token(Token = "0x6001C92")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003A4")]
	private class BorderRightWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007D2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C96")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D0")]
		public virtual string Name
		{
			[Address(RVA = "0x326A070", Offset = "0x3269470", Length = "0x2C")]
			[Token(Token = "0x6001C94")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D1")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A0A0", Offset = "0x32694A0", Length = "0x2C")]
			[Token(Token = "0x6001C95")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001C99")]
		public BorderRightWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C96")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A070", Offset = "0x3269470", Length = "0x2C")]
		[Token(Token = "0x6001C94")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A0A0", Offset = "0x32694A0", Length = "0x2C")]
		[Token(Token = "0x6001C95")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3269FE0", Offset = "0x32693E0", Length = "0x48")]
		[Token(Token = "0x6001C97")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A030", Offset = "0x3269430", Length = "0x3E")]
		[Token(Token = "0x6001C98")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A5")]
	private class BorderTopColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007D5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001C9C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D3")]
		public virtual string Name
		{
			[Address(RVA = "0x326A1E0", Offset = "0x32695E0", Length = "0x2C")]
			[Token(Token = "0x6001C9A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D4")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A210", Offset = "0x3269610", Length = "0x2C")]
			[Token(Token = "0x6001C9B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001C9F")]
		public BorderTopColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001C9C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A1E0", Offset = "0x32695E0", Length = "0x2C")]
		[Token(Token = "0x6001C9A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A210", Offset = "0x3269610", Length = "0x2C")]
		[Token(Token = "0x6001C9B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A0D0", Offset = "0x32694D0", Length = "0xCF")]
		[Token(Token = "0x6001C9D")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A1A0", Offset = "0x32695A0", Length = "0x3E")]
		[Token(Token = "0x6001C9E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003A6")]
	private class BorderTopLeftRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007D8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CA2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D6")]
		public virtual string Name
		{
			[Address(RVA = "0x326A2D0", Offset = "0x32696D0", Length = "0x2C")]
			[Token(Token = "0x6001CA0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D7")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A300", Offset = "0x3269700", Length = "0x2C")]
			[Token(Token = "0x6001CA1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CA5")]
		public BorderTopLeftRadiusProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CA2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A2D0", Offset = "0x32696D0", Length = "0x2C")]
		[Token(Token = "0x6001CA0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A300", Offset = "0x3269700", Length = "0x2C")]
		[Token(Token = "0x6001CA1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A240", Offset = "0x3269640", Length = "0x48")]
		[Token(Token = "0x6001CA3")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A290", Offset = "0x3269690", Length = "0x3E")]
		[Token(Token = "0x6001CA4")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A7")]
	private class BorderTopRightRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007DB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CA8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D9")]
		public virtual string Name
		{
			[Address(RVA = "0x326A3C0", Offset = "0x32697C0", Length = "0x2C")]
			[Token(Token = "0x6001CA6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007DA")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A3F0", Offset = "0x32697F0", Length = "0x2C")]
			[Token(Token = "0x6001CA7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CAB")]
		public BorderTopRightRadiusProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CA8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A3C0", Offset = "0x32697C0", Length = "0x2C")]
		[Token(Token = "0x6001CA6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A3F0", Offset = "0x32697F0", Length = "0x2C")]
		[Token(Token = "0x6001CA7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A330", Offset = "0x3269730", Length = "0x48")]
		[Token(Token = "0x6001CA9")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A380", Offset = "0x3269780", Length = "0x3E")]
		[Token(Token = "0x6001CAA")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A8")]
	private class BorderTopWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007DE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CAE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007DC")]
		public virtual string Name
		{
			[Address(RVA = "0x326A4B0", Offset = "0x32698B0", Length = "0x2C")]
			[Token(Token = "0x6001CAC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007DD")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A4E0", Offset = "0x32698E0", Length = "0x2C")]
			[Token(Token = "0x6001CAD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CB1")]
		public BorderTopWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CAE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A4B0", Offset = "0x32698B0", Length = "0x2C")]
		[Token(Token = "0x6001CAC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A4E0", Offset = "0x32698E0", Length = "0x2C")]
		[Token(Token = "0x6001CAD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A420", Offset = "0x3269820", Length = "0x48")]
		[Token(Token = "0x6001CAF")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A470", Offset = "0x3269870", Length = "0x3E")]
		[Token(Token = "0x6001CB0")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A9")]
	private class BottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007E1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CB4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007DF")]
		public virtual string Name
		{
			[Address(RVA = "0x326A5A0", Offset = "0x32699A0", Length = "0x2C")]
			[Token(Token = "0x6001CB2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E0")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A5D0", Offset = "0x32699D0", Length = "0x2C")]
			[Token(Token = "0x6001CB3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CB7")]
		public BottomProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CB4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A5A0", Offset = "0x32699A0", Length = "0x2C")]
		[Token(Token = "0x6001CB2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A5D0", Offset = "0x32699D0", Length = "0x2C")]
		[Token(Token = "0x6001CB3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A510", Offset = "0x3269910", Length = "0x48")]
		[Token(Token = "0x6001CB5")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A560", Offset = "0x3269960", Length = "0x3E")]
		[Token(Token = "0x6001CB6")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AA")]
	private class ColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007E4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CBA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E2")]
		public virtual string Name
		{
			[Address(RVA = "0x326A710", Offset = "0x3269B10", Length = "0x2C")]
			[Token(Token = "0x6001CB8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E3")]
		public virtual string ussName
		{
			[Address(RVA = "0x326A740", Offset = "0x3269B40", Length = "0x2C")]
			[Token(Token = "0x6001CB9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001CBD")]
		public ColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CBA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326A710", Offset = "0x3269B10", Length = "0x2C")]
		[Token(Token = "0x6001CB8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326A740", Offset = "0x3269B40", Length = "0x2C")]
		[Token(Token = "0x6001CB9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326A600", Offset = "0x3269A00", Length = "0xCF")]
		[Token(Token = "0x6001CBB")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326A6D0", Offset = "0x3269AD0", Length = "0x3E")]
		[Token(Token = "0x6001CBC")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003AB")]
	private class DisplayProperty : ResolvedEnumProperty<DisplayStyle>
	{

		[Token(Token = "0x170007E7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CC0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E5")]
		public virtual string Name
		{
			[Address(RVA = "0x326B170", Offset = "0x326A570", Length = "0x2C")]
			[Token(Token = "0x6001CBE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E6")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B1A0", Offset = "0x326A5A0", Length = "0x2C")]
			[Token(Token = "0x6001CBF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B130", Offset = "0x326A530", Length = "0x39")]
		[Token(Token = "0x6001CC3")]
		public DisplayProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CC0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B170", Offset = "0x326A570", Length = "0x2C")]
		[Token(Token = "0x6001CBE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B1A0", Offset = "0x326A5A0", Length = "0x2C")]
		[Token(Token = "0x6001CBF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B0A0", Offset = "0x326A4A0", Length = "0x48")]
		[Token(Token = "0x6001CC1")]
		public virtual DisplayStyle GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B0F0", Offset = "0x326A4F0", Length = "0x3E")]
		[Token(Token = "0x6001CC2")]
		public virtual void SetValue(ref ResolvedStyleAccess container, DisplayStyle value) { }

	}

	[Token(Token = "0x20003AC")]
	private class FilterProperty : ResolvedListProperty<FilterFunction>
	{

		[Token(Token = "0x170007EA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CC6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E8")]
		public virtual string Name
		{
			[Address(RVA = "0x326B2A0", Offset = "0x326A6A0", Length = "0x2C")]
			[Token(Token = "0x6001CC4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E9")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B2D0", Offset = "0x326A6D0", Length = "0x2C")]
			[Token(Token = "0x6001CC5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B260", Offset = "0x326A660", Length = "0x39")]
		[Token(Token = "0x6001CC9")]
		public FilterProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CC6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B2A0", Offset = "0x326A6A0", Length = "0x2C")]
		[Token(Token = "0x6001CC4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B2D0", Offset = "0x326A6D0", Length = "0x2C")]
		[Token(Token = "0x6001CC5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B1D0", Offset = "0x326A5D0", Length = "0x48")]
		[Token(Token = "0x6001CC7")]
		public virtual IEnumerable<FilterFunction> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B220", Offset = "0x326A620", Length = "0x3E")]
		[Token(Token = "0x6001CC8")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<FilterFunction> value) { }

	}

	[Token(Token = "0x20003AD")]
	private class FlexBasisProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007ED")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CCC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007EB")]
		public virtual string Name
		{
			[Address(RVA = "0x326B3D0", Offset = "0x326A7D0", Length = "0x2C")]
			[Token(Token = "0x6001CCA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007EC")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B400", Offset = "0x326A800", Length = "0x2C")]
			[Token(Token = "0x6001CCB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001CCF")]
		public FlexBasisProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CCC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B3D0", Offset = "0x326A7D0", Length = "0x2C")]
		[Token(Token = "0x6001CCA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B400", Offset = "0x326A800", Length = "0x2C")]
		[Token(Token = "0x6001CCB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B300", Offset = "0x326A700", Length = "0x48")]
		[Token(Token = "0x6001CCD")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B350", Offset = "0x326A750", Length = "0x3E")]
		[Token(Token = "0x6001CCE")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003AE")]
	private class FlexDirectionProperty : ResolvedEnumProperty<FlexDirection>
	{

		[Token(Token = "0x170007F0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CD2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007EE")]
		public virtual string Name
		{
			[Address(RVA = "0x326B500", Offset = "0x326A900", Length = "0x2C")]
			[Token(Token = "0x6001CD0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007EF")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B530", Offset = "0x326A930", Length = "0x2C")]
			[Token(Token = "0x6001CD1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B4C0", Offset = "0x326A8C0", Length = "0x39")]
		[Token(Token = "0x6001CD5")]
		public FlexDirectionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CD2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B500", Offset = "0x326A900", Length = "0x2C")]
		[Token(Token = "0x6001CD0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B530", Offset = "0x326A930", Length = "0x2C")]
		[Token(Token = "0x6001CD1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B430", Offset = "0x326A830", Length = "0x48")]
		[Token(Token = "0x6001CD3")]
		public virtual FlexDirection GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B480", Offset = "0x326A880", Length = "0x3E")]
		[Token(Token = "0x6001CD4")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FlexDirection value) { }

	}

	[Token(Token = "0x20003AF")]
	private class FlexGrowProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007F3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CD8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F1")]
		public virtual string Name
		{
			[Address(RVA = "0x326B5F0", Offset = "0x326A9F0", Length = "0x2C")]
			[Token(Token = "0x6001CD6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F2")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B620", Offset = "0x326AA20", Length = "0x2C")]
			[Token(Token = "0x6001CD7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CDB")]
		public FlexGrowProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CD8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B5F0", Offset = "0x326A9F0", Length = "0x2C")]
		[Token(Token = "0x6001CD6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B620", Offset = "0x326AA20", Length = "0x2C")]
		[Token(Token = "0x6001CD7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B560", Offset = "0x326A960", Length = "0x48")]
		[Token(Token = "0x6001CD9")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B5B0", Offset = "0x326A9B0", Length = "0x3E")]
		[Token(Token = "0x6001CDA")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B0")]
	private class FlexShrinkProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007F6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CDE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F4")]
		public virtual string Name
		{
			[Address(RVA = "0x326B6E0", Offset = "0x326AAE0", Length = "0x2C")]
			[Token(Token = "0x6001CDC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F5")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B710", Offset = "0x326AB10", Length = "0x2C")]
			[Token(Token = "0x6001CDD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CE1")]
		public FlexShrinkProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CDE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B6E0", Offset = "0x326AAE0", Length = "0x2C")]
		[Token(Token = "0x6001CDC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B710", Offset = "0x326AB10", Length = "0x2C")]
		[Token(Token = "0x6001CDD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B650", Offset = "0x326AA50", Length = "0x48")]
		[Token(Token = "0x6001CDF")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B6A0", Offset = "0x326AAA0", Length = "0x3E")]
		[Token(Token = "0x6001CE0")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B1")]
	private class FlexWrapProperty : ResolvedEnumProperty<Wrap>
	{

		[Token(Token = "0x170007F9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CE4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F7")]
		public virtual string Name
		{
			[Address(RVA = "0x326B810", Offset = "0x326AC10", Length = "0x2C")]
			[Token(Token = "0x6001CE2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F8")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B840", Offset = "0x326AC40", Length = "0x2C")]
			[Token(Token = "0x6001CE3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B7D0", Offset = "0x326ABD0", Length = "0x39")]
		[Token(Token = "0x6001CE7")]
		public FlexWrapProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CE4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B810", Offset = "0x326AC10", Length = "0x2C")]
		[Token(Token = "0x6001CE2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B840", Offset = "0x326AC40", Length = "0x2C")]
		[Token(Token = "0x6001CE3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B740", Offset = "0x326AB40", Length = "0x48")]
		[Token(Token = "0x6001CE5")]
		public virtual Wrap GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B790", Offset = "0x326AB90", Length = "0x3E")]
		[Token(Token = "0x6001CE6")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Wrap value) { }

	}

	[Token(Token = "0x20003B2")]
	private class FontSizeProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007FC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CEA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007FA")]
		public virtual string Name
		{
			[Address(RVA = "0x326B900", Offset = "0x326AD00", Length = "0x2C")]
			[Token(Token = "0x6001CE8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007FB")]
		public virtual string ussName
		{
			[Address(RVA = "0x326B930", Offset = "0x326AD30", Length = "0x2C")]
			[Token(Token = "0x6001CE9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CED")]
		public FontSizeProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CEA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B900", Offset = "0x326AD00", Length = "0x2C")]
		[Token(Token = "0x6001CE8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326B930", Offset = "0x326AD30", Length = "0x2C")]
		[Token(Token = "0x6001CE9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B870", Offset = "0x326AC70", Length = "0x48")]
		[Token(Token = "0x6001CEB")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B8C0", Offset = "0x326ACC0", Length = "0x3E")]
		[Token(Token = "0x6001CEC")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B3")]
	private class HeightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007FF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CF0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007FD")]
		public virtual string Name
		{
			[Address(RVA = "0x326B9F0", Offset = "0x326ADF0", Length = "0x2C")]
			[Token(Token = "0x6001CEE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007FE")]
		public virtual string ussName
		{
			[Address(RVA = "0x326BA20", Offset = "0x326AE20", Length = "0x2C")]
			[Token(Token = "0x6001CEF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CF3")]
		public HeightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CF0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326B9F0", Offset = "0x326ADF0", Length = "0x2C")]
		[Token(Token = "0x6001CEE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326BA20", Offset = "0x326AE20", Length = "0x2C")]
		[Token(Token = "0x6001CEF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326B960", Offset = "0x326AD60", Length = "0x48")]
		[Token(Token = "0x6001CF1")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326B9B0", Offset = "0x326ADB0", Length = "0x3E")]
		[Token(Token = "0x6001CF2")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B4")]
	private class JustifyContentProperty : ResolvedEnumProperty<Justify>
	{

		[Token(Token = "0x17000802")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CF6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000800")]
		public virtual string Name
		{
			[Address(RVA = "0x326EFD0", Offset = "0x326E3D0", Length = "0x2C")]
			[Token(Token = "0x6001CF4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000801")]
		public virtual string ussName
		{
			[Address(RVA = "0x326F000", Offset = "0x326E400", Length = "0x2C")]
			[Token(Token = "0x6001CF5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326EF90", Offset = "0x326E390", Length = "0x39")]
		[Token(Token = "0x6001CF9")]
		public JustifyContentProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CF6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x326EFD0", Offset = "0x326E3D0", Length = "0x2C")]
		[Token(Token = "0x6001CF4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x326F000", Offset = "0x326E400", Length = "0x2C")]
		[Token(Token = "0x6001CF5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x326EF00", Offset = "0x326E300", Length = "0x48")]
		[Token(Token = "0x6001CF7")]
		public virtual Justify GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x326EF50", Offset = "0x326E350", Length = "0x3E")]
		[Token(Token = "0x6001CF8")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Justify value) { }

	}

	[Token(Token = "0x20003B5")]
	private class LeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000805")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001CFC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000803")]
		public virtual string Name
		{
			[Address(RVA = "0x3272140", Offset = "0x3271540", Length = "0x2C")]
			[Token(Token = "0x6001CFA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000804")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272170", Offset = "0x3271570", Length = "0x2C")]
			[Token(Token = "0x6001CFB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001CFF")]
		public LeftProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001CFC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272140", Offset = "0x3271540", Length = "0x2C")]
		[Token(Token = "0x6001CFA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272170", Offset = "0x3271570", Length = "0x2C")]
		[Token(Token = "0x6001CFB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32720B0", Offset = "0x32714B0", Length = "0x48")]
		[Token(Token = "0x6001CFD")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3272100", Offset = "0x3271500", Length = "0x3E")]
		[Token(Token = "0x6001CFE")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B6")]
	private class LetterSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000808")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D02")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000806")]
		public virtual string Name
		{
			[Address(RVA = "0x3272660", Offset = "0x3271A60", Length = "0x2C")]
			[Token(Token = "0x6001D00")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000807")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272690", Offset = "0x3271A90", Length = "0x2C")]
			[Token(Token = "0x6001D01")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D05")]
		public LetterSpacingProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D02")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272660", Offset = "0x3271A60", Length = "0x2C")]
		[Token(Token = "0x6001D00")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272690", Offset = "0x3271A90", Length = "0x2C")]
		[Token(Token = "0x6001D01")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32725D0", Offset = "0x32719D0", Length = "0x48")]
		[Token(Token = "0x6001D03")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3272620", Offset = "0x3271A20", Length = "0x3E")]
		[Token(Token = "0x6001D04")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B7")]
	private class MarginBottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700080B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D08")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000809")]
		public virtual string Name
		{
			[Address(RVA = "0x3272750", Offset = "0x3271B50", Length = "0x2C")]
			[Token(Token = "0x6001D06")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700080A")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272780", Offset = "0x3271B80", Length = "0x2C")]
			[Token(Token = "0x6001D07")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D0B")]
		public MarginBottomProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D08")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272750", Offset = "0x3271B50", Length = "0x2C")]
		[Token(Token = "0x6001D06")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272780", Offset = "0x3271B80", Length = "0x2C")]
		[Token(Token = "0x6001D07")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32726C0", Offset = "0x3271AC0", Length = "0x48")]
		[Token(Token = "0x6001D09")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3272710", Offset = "0x3271B10", Length = "0x3E")]
		[Token(Token = "0x6001D0A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B8")]
	private class MarginLeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700080E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D0E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700080C")]
		public virtual string Name
		{
			[Address(RVA = "0x3272840", Offset = "0x3271C40", Length = "0x2C")]
			[Token(Token = "0x6001D0C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700080D")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272870", Offset = "0x3271C70", Length = "0x2C")]
			[Token(Token = "0x6001D0D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D11")]
		public MarginLeftProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D0E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272840", Offset = "0x3271C40", Length = "0x2C")]
		[Token(Token = "0x6001D0C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272870", Offset = "0x3271C70", Length = "0x2C")]
		[Token(Token = "0x6001D0D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32727B0", Offset = "0x3271BB0", Length = "0x48")]
		[Token(Token = "0x6001D0F")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3272800", Offset = "0x3271C00", Length = "0x3E")]
		[Token(Token = "0x6001D10")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B9")]
	private class MarginRightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000811")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D14")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700080F")]
		public virtual string Name
		{
			[Address(RVA = "0x3272930", Offset = "0x3271D30", Length = "0x2C")]
			[Token(Token = "0x6001D12")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000810")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272960", Offset = "0x3271D60", Length = "0x2C")]
			[Token(Token = "0x6001D13")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D17")]
		public MarginRightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D14")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272930", Offset = "0x3271D30", Length = "0x2C")]
		[Token(Token = "0x6001D12")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272960", Offset = "0x3271D60", Length = "0x2C")]
		[Token(Token = "0x6001D13")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32728A0", Offset = "0x3271CA0", Length = "0x48")]
		[Token(Token = "0x6001D15")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32728F0", Offset = "0x3271CF0", Length = "0x3E")]
		[Token(Token = "0x6001D16")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003BA")]
	private class MarginTopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000814")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D1A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000812")]
		public virtual string Name
		{
			[Address(RVA = "0x3272A20", Offset = "0x3271E20", Length = "0x2C")]
			[Token(Token = "0x6001D18")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000813")]
		public virtual string ussName
		{
			[Address(RVA = "0x3272A50", Offset = "0x3271E50", Length = "0x2C")]
			[Token(Token = "0x6001D19")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D1D")]
		public MarginTopProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D1A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3272A20", Offset = "0x3271E20", Length = "0x2C")]
		[Token(Token = "0x6001D18")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3272A50", Offset = "0x3271E50", Length = "0x2C")]
		[Token(Token = "0x6001D19")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3272990", Offset = "0x3271D90", Length = "0x48")]
		[Token(Token = "0x6001D1B")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32729E0", Offset = "0x3271DE0", Length = "0x3E")]
		[Token(Token = "0x6001D1C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003BB")]
	private class MaxHeightProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x17000817")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D20")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000815")]
		public virtual string Name
		{
			[Address(RVA = "0x3273CF0", Offset = "0x32730F0", Length = "0x2C")]
			[Token(Token = "0x6001D1E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000816")]
		public virtual string ussName
		{
			[Address(RVA = "0x3273D20", Offset = "0x3273120", Length = "0x2C")]
			[Token(Token = "0x6001D1F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001D23")]
		public MaxHeightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D20")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3273CF0", Offset = "0x32730F0", Length = "0x2C")]
		[Token(Token = "0x6001D1E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3273D20", Offset = "0x3273120", Length = "0x2C")]
		[Token(Token = "0x6001D1F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3273C60", Offset = "0x3273060", Length = "0x48")]
		[Token(Token = "0x6001D21")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3273CB0", Offset = "0x32730B0", Length = "0x3E")]
		[Token(Token = "0x6001D22")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003BC")]
	private class MaxWidthProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x1700081A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D26")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000818")]
		public virtual string Name
		{
			[Address(RVA = "0x3273DE0", Offset = "0x32731E0", Length = "0x2C")]
			[Token(Token = "0x6001D24")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000819")]
		public virtual string ussName
		{
			[Address(RVA = "0x3273E10", Offset = "0x3273210", Length = "0x2C")]
			[Token(Token = "0x6001D25")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001D29")]
		public MaxWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D26")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3273DE0", Offset = "0x32731E0", Length = "0x2C")]
		[Token(Token = "0x6001D24")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3273E10", Offset = "0x3273210", Length = "0x2C")]
		[Token(Token = "0x6001D25")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3273D50", Offset = "0x3273150", Length = "0x48")]
		[Token(Token = "0x6001D27")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3273DA0", Offset = "0x32731A0", Length = "0x3E")]
		[Token(Token = "0x6001D28")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003BD")]
	private class MinHeightProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x1700081D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D2C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700081B")]
		public virtual string Name
		{
			[Address(RVA = "0x3273ED0", Offset = "0x32732D0", Length = "0x2C")]
			[Token(Token = "0x6001D2A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700081C")]
		public virtual string ussName
		{
			[Address(RVA = "0x3273F00", Offset = "0x3273300", Length = "0x2C")]
			[Token(Token = "0x6001D2B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001D2F")]
		public MinHeightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D2C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3273ED0", Offset = "0x32732D0", Length = "0x2C")]
		[Token(Token = "0x6001D2A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3273F00", Offset = "0x3273300", Length = "0x2C")]
		[Token(Token = "0x6001D2B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3273E40", Offset = "0x3273240", Length = "0x48")]
		[Token(Token = "0x6001D2D")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3273E90", Offset = "0x3273290", Length = "0x3E")]
		[Token(Token = "0x6001D2E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003BE")]
	private class MinWidthProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x17000820")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D32")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700081E")]
		public virtual string Name
		{
			[Address(RVA = "0x3273FC0", Offset = "0x32733C0", Length = "0x2C")]
			[Token(Token = "0x6001D30")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700081F")]
		public virtual string ussName
		{
			[Address(RVA = "0x3273FF0", Offset = "0x32733F0", Length = "0x2C")]
			[Token(Token = "0x6001D31")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001D35")]
		public MinWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D32")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3273FC0", Offset = "0x32733C0", Length = "0x2C")]
		[Token(Token = "0x6001D30")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3273FF0", Offset = "0x32733F0", Length = "0x2C")]
		[Token(Token = "0x6001D31")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3273F30", Offset = "0x3273330", Length = "0x48")]
		[Token(Token = "0x6001D33")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3273F80", Offset = "0x3273380", Length = "0x3E")]
		[Token(Token = "0x6001D34")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003BF")]
	private class OpacityProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000823")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D38")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000821")]
		public virtual string Name
		{
			[Address(RVA = "0x32740B0", Offset = "0x32734B0", Length = "0x2C")]
			[Token(Token = "0x6001D36")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000822")]
		public virtual string ussName
		{
			[Address(RVA = "0x32740E0", Offset = "0x32734E0", Length = "0x2C")]
			[Token(Token = "0x6001D37")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D3B")]
		public OpacityProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D38")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32740B0", Offset = "0x32734B0", Length = "0x2C")]
		[Token(Token = "0x6001D36")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32740E0", Offset = "0x32734E0", Length = "0x2C")]
		[Token(Token = "0x6001D37")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3274020", Offset = "0x3273420", Length = "0x48")]
		[Token(Token = "0x6001D39")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274070", Offset = "0x3273470", Length = "0x3E")]
		[Token(Token = "0x6001D3A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C0")]
	private class PaddingBottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000826")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D3E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000824")]
		public virtual string Name
		{
			[Address(RVA = "0x32741A0", Offset = "0x32735A0", Length = "0x2C")]
			[Token(Token = "0x6001D3C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000825")]
		public virtual string ussName
		{
			[Address(RVA = "0x32741D0", Offset = "0x32735D0", Length = "0x2C")]
			[Token(Token = "0x6001D3D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D41")]
		public PaddingBottomProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D3E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32741A0", Offset = "0x32735A0", Length = "0x2C")]
		[Token(Token = "0x6001D3C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32741D0", Offset = "0x32735D0", Length = "0x2C")]
		[Token(Token = "0x6001D3D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3274110", Offset = "0x3273510", Length = "0x48")]
		[Token(Token = "0x6001D3F")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274160", Offset = "0x3273560", Length = "0x3E")]
		[Token(Token = "0x6001D40")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C1")]
	private class PaddingLeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000829")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D44")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000827")]
		public virtual string Name
		{
			[Address(RVA = "0x3274290", Offset = "0x3273690", Length = "0x2C")]
			[Token(Token = "0x6001D42")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000828")]
		public virtual string ussName
		{
			[Address(RVA = "0x32742C0", Offset = "0x32736C0", Length = "0x2C")]
			[Token(Token = "0x6001D43")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D47")]
		public PaddingLeftProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D44")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3274290", Offset = "0x3273690", Length = "0x2C")]
		[Token(Token = "0x6001D42")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32742C0", Offset = "0x32736C0", Length = "0x2C")]
		[Token(Token = "0x6001D43")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3274200", Offset = "0x3273600", Length = "0x48")]
		[Token(Token = "0x6001D45")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274250", Offset = "0x3273650", Length = "0x3E")]
		[Token(Token = "0x6001D46")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C2")]
	private class PaddingRightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700082C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D4A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700082A")]
		public virtual string Name
		{
			[Address(RVA = "0x3274380", Offset = "0x3273780", Length = "0x2C")]
			[Token(Token = "0x6001D48")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700082B")]
		public virtual string ussName
		{
			[Address(RVA = "0x32743B0", Offset = "0x32737B0", Length = "0x2C")]
			[Token(Token = "0x6001D49")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D4D")]
		public PaddingRightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D4A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3274380", Offset = "0x3273780", Length = "0x2C")]
		[Token(Token = "0x6001D48")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32743B0", Offset = "0x32737B0", Length = "0x2C")]
		[Token(Token = "0x6001D49")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32742F0", Offset = "0x32736F0", Length = "0x48")]
		[Token(Token = "0x6001D4B")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274340", Offset = "0x3273740", Length = "0x3E")]
		[Token(Token = "0x6001D4C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C3")]
	private class PaddingTopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700082F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D50")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700082D")]
		public virtual string Name
		{
			[Address(RVA = "0x3274470", Offset = "0x3273870", Length = "0x2C")]
			[Token(Token = "0x6001D4E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700082E")]
		public virtual string ussName
		{
			[Address(RVA = "0x32744A0", Offset = "0x32738A0", Length = "0x2C")]
			[Token(Token = "0x6001D4F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D53")]
		public PaddingTopProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D50")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3274470", Offset = "0x3273870", Length = "0x2C")]
		[Token(Token = "0x6001D4E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32744A0", Offset = "0x32738A0", Length = "0x2C")]
		[Token(Token = "0x6001D4F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32743E0", Offset = "0x32737E0", Length = "0x48")]
		[Token(Token = "0x6001D51")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274430", Offset = "0x3273830", Length = "0x3E")]
		[Token(Token = "0x6001D52")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C4")]
	private class PositionProperty : ResolvedEnumProperty<Position>
	{

		[Token(Token = "0x17000832")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D56")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000830")]
		public virtual string Name
		{
			[Address(RVA = "0x32745A0", Offset = "0x32739A0", Length = "0x2C")]
			[Token(Token = "0x6001D54")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000831")]
		public virtual string ussName
		{
			[Address(RVA = "0x32745D0", Offset = "0x32739D0", Length = "0x2C")]
			[Token(Token = "0x6001D55")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3274560", Offset = "0x3273960", Length = "0x39")]
		[Token(Token = "0x6001D59")]
		public PositionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D56")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32745A0", Offset = "0x32739A0", Length = "0x2C")]
		[Token(Token = "0x6001D54")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32745D0", Offset = "0x32739D0", Length = "0x2C")]
		[Token(Token = "0x6001D55")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32744D0", Offset = "0x32738D0", Length = "0x48")]
		[Token(Token = "0x6001D57")]
		public virtual Position GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3274520", Offset = "0x3273920", Length = "0x3E")]
		[Token(Token = "0x6001D58")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Position value) { }

	}

	[Token(Token = "0x20003F3")]
	private abstract class ResolvedBackgroundPositionProperty : ResolvedStyleProperty<BackgroundPosition>
	{

		[Address(RVA = "0x32689F0", Offset = "0x3267DF0", Length = "0x39")]
		[Token(Token = "0x6001E2E")]
		protected ResolvedBackgroundPositionProperty() { }

	}

	[Token(Token = "0x20003E9")]
	private abstract class ResolvedBackgroundProperty : ResolvedStyleProperty<Background>
	{

		[Address(RVA = "0x3268830", Offset = "0x3267C30", Length = "0x39")]
		[Token(Token = "0x6001E24")]
		protected ResolvedBackgroundProperty() { }

	}

	[Token(Token = "0x20003F4")]
	private abstract class ResolvedBackgroundRepeatProperty : ResolvedStyleProperty<BackgroundRepeat>
	{

		[Address(RVA = "0x3268D10", Offset = "0x3268110", Length = "0x39")]
		[Token(Token = "0x6001E2F")]
		protected ResolvedBackgroundRepeatProperty() { }

	}

	[Token(Token = "0x20003F5")]
	private abstract class ResolvedBackgroundSizeProperty : ResolvedStyleProperty<BackgroundSize>
	{

		[Address(RVA = "0x3268ED0", Offset = "0x32682D0", Length = "0x39")]
		[Token(Token = "0x6001E30")]
		protected ResolvedBackgroundSizeProperty() { }

	}

	[Token(Token = "0x20003E8")]
	private abstract class ResolvedColorProperty : ResolvedStyleProperty<Color>
	{

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001E23")]
		protected ResolvedColorProperty() { }

	}

	[Token(Token = "0x20003E7")]
	private abstract class ResolvedEnumProperty : ResolvedStyleProperty<TValue>
	{

		[Address(RVA = "0xF52F90", Offset = "0xF52390", Length = "0x21")]
		[Token(Token = "0x6001E22")]
		protected ResolvedEnumProperty`1() { }

	}

	[Token(Token = "0x20003EA")]
	private abstract class ResolvedFloatProperty : ResolvedStyleProperty<Single>
	{

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001E25")]
		protected ResolvedFloatProperty() { }

	}

	[Token(Token = "0x20003EE")]
	private abstract class ResolvedFontDefinitionProperty : ResolvedStyleProperty<FontDefinition>
	{

		[Address(RVA = "0x32757F0", Offset = "0x3274BF0", Length = "0x39")]
		[Token(Token = "0x6001E29")]
		protected ResolvedFontDefinitionProperty() { }

	}

	[Token(Token = "0x20003ED")]
	private abstract class ResolvedFontProperty : ResolvedStyleProperty<Font>
	{

		[Address(RVA = "0x3275830", Offset = "0x3274C30", Length = "0x39")]
		[Token(Token = "0x6001E28")]
		protected ResolvedFontProperty() { }

	}

	[Token(Token = "0x20003EF")]
	private abstract class ResolvedIntProperty : ResolvedStyleProperty<Int32>
	{

		[Address(RVA = "0x3275870", Offset = "0x3274C70", Length = "0x39")]
		[Token(Token = "0x6001E2A")]
		protected ResolvedIntProperty() { }

	}

	[Token(Token = "0x20003EC")]
	private abstract class ResolvedListProperty : ResolvedStyleProperty<IEnumerable`1<T>>
	{

		[Address(RVA = "0xF52F90", Offset = "0xF52390", Length = "0x21")]
		[Token(Token = "0x6001E27")]
		protected ResolvedListProperty`1() { }

	}

	[Token(Token = "0x20003F6")]
	private abstract class ResolvedMaterialDefinitionProperty : ResolvedStyleProperty<MaterialDefinition>
	{

		[Address(RVA = "0x32758B0", Offset = "0x3274CB0", Length = "0x39")]
		[Token(Token = "0x6001E31")]
		protected ResolvedMaterialDefinitionProperty() { }

	}

	[Token(Token = "0x20003F7")]
	private abstract class ResolvedRatioProperty : ResolvedStyleProperty<Ratio>
	{

		[Address(RVA = "0x3268340", Offset = "0x3267740", Length = "0x39")]
		[Token(Token = "0x6001E32")]
		protected ResolvedRatioProperty() { }

	}

	[Token(Token = "0x20003F0")]
	private abstract class ResolvedRotateProperty : ResolvedStyleProperty<Rotate>
	{

		[Address(RVA = "0x32758F0", Offset = "0x3274CF0", Length = "0x39")]
		[Token(Token = "0x6001E2B")]
		protected ResolvedRotateProperty() { }

	}

	[Token(Token = "0x20003F1")]
	private abstract class ResolvedScaleProperty : ResolvedStyleProperty<Scale>
	{

		[Address(RVA = "0x3275930", Offset = "0x3274D30", Length = "0x39")]
		[Token(Token = "0x6001E2C")]
		protected ResolvedScaleProperty() { }

	}

	[Token(Token = "0x20003EB")]
	private abstract class ResolvedStyleFloatProperty : ResolvedStyleProperty<StyleFloat>
	{

		[Address(RVA = "0x326B390", Offset = "0x326A790", Length = "0x39")]
		[Token(Token = "0x6001E26")]
		protected ResolvedStyleFloatProperty() { }

	}

	[Token(Token = "0x20003E6")]
	private abstract class ResolvedStyleProperty : Property<ResolvedStyleAccess, TValue>
	{

		[Token(Token = "0x17000896")]
		public abstract string ussName
		{
			[Token(Token = "0x6001E20")]
			 get { } //Length: 0
		}

		[Address(RVA = "0xF52FE0", Offset = "0xF523E0", Length = "0x13")]
		[Token(Token = "0x6001E21")]
		protected ResolvedStyleProperty`1() { }

		[Token(Token = "0x6001E20")]
		public abstract string get_ussName() { }

	}

	[Token(Token = "0x20003F2")]
	private abstract class ResolvedVector3Property : ResolvedStyleProperty<Vector3>
	{

		[Address(RVA = "0x32779C0", Offset = "0x3276DC0", Length = "0x39")]
		[Token(Token = "0x6001E2D")]
		protected ResolvedVector3Property() { }

	}

	[Token(Token = "0x20003C5")]
	private class RightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000835")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D5C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000833")]
		public virtual string Name
		{
			[Address(RVA = "0x3277A90", Offset = "0x3276E90", Length = "0x2C")]
			[Token(Token = "0x6001D5A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000834")]
		public virtual string ussName
		{
			[Address(RVA = "0x3277AC0", Offset = "0x3276EC0", Length = "0x2C")]
			[Token(Token = "0x6001D5B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D5F")]
		public RightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D5C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3277A90", Offset = "0x3276E90", Length = "0x2C")]
		[Token(Token = "0x6001D5A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3277AC0", Offset = "0x3276EC0", Length = "0x2C")]
		[Token(Token = "0x6001D5B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3277A00", Offset = "0x3276E00", Length = "0x48")]
		[Token(Token = "0x6001D5D")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3277A50", Offset = "0x3276E50", Length = "0x3E")]
		[Token(Token = "0x6001D5E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C6")]
	private class RotateProperty : ResolvedRotateProperty
	{

		[Token(Token = "0x17000838")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D62")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000836")]
		public virtual string Name
		{
			[Address(RVA = "0x3277C10", Offset = "0x3277010", Length = "0x2C")]
			[Token(Token = "0x6001D60")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000837")]
		public virtual string ussName
		{
			[Address(RVA = "0x3277C40", Offset = "0x3277040", Length = "0x2C")]
			[Token(Token = "0x6001D61")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32758F0", Offset = "0x3274CF0", Length = "0x39")]
		[Token(Token = "0x6001D65")]
		public RotateProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D62")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3277C10", Offset = "0x3277010", Length = "0x2C")]
		[Token(Token = "0x6001D60")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3277C40", Offset = "0x3277040", Length = "0x2C")]
		[Token(Token = "0x6001D61")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3277AF0", Offset = "0x3276EF0", Length = "0xD9")]
		[Token(Token = "0x6001D63")]
		public virtual Rotate GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3277BD0", Offset = "0x3276FD0", Length = "0x3E")]
		[Token(Token = "0x6001D64")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Rotate value) { }

	}

	[Token(Token = "0x20003C7")]
	private class ScaleProperty : ResolvedScaleProperty
	{

		[Token(Token = "0x1700083B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D68")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000839")]
		public virtual string Name
		{
			[Address(RVA = "0x3278460", Offset = "0x3277860", Length = "0x2C")]
			[Token(Token = "0x6001D66")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700083A")]
		public virtual string ussName
		{
			[Address(RVA = "0x3278490", Offset = "0x3277890", Length = "0x2C")]
			[Token(Token = "0x6001D67")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275930", Offset = "0x3274D30", Length = "0x39")]
		[Token(Token = "0x6001D6B")]
		public ScaleProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D68")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3278460", Offset = "0x3277860", Length = "0x2C")]
		[Token(Token = "0x6001D66")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3278490", Offset = "0x3277890", Length = "0x2C")]
		[Token(Token = "0x6001D67")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3278350", Offset = "0x3277750", Length = "0xCF")]
		[Token(Token = "0x6001D69")]
		public virtual Scale GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3278420", Offset = "0x3277820", Length = "0x3E")]
		[Token(Token = "0x6001D6A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Scale value) { }

	}

	[Token(Token = "0x20003C8")]
	private class TextOverflowProperty : ResolvedEnumProperty<TextOverflow>
	{

		[Token(Token = "0x1700083E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D6E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700083C")]
		public virtual string Name
		{
			[Address(RVA = "0x327E190", Offset = "0x327D590", Length = "0x2C")]
			[Token(Token = "0x6001D6C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700083D")]
		public virtual string ussName
		{
			[Address(RVA = "0x327E1C0", Offset = "0x327D5C0", Length = "0x2C")]
			[Token(Token = "0x6001D6D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x327E150", Offset = "0x327D550", Length = "0x39")]
		[Token(Token = "0x6001D71")]
		public TextOverflowProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D6E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327E190", Offset = "0x327D590", Length = "0x2C")]
		[Token(Token = "0x6001D6C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327E1C0", Offset = "0x327D5C0", Length = "0x2C")]
		[Token(Token = "0x6001D6D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327E0C0", Offset = "0x327D4C0", Length = "0x48")]
		[Token(Token = "0x6001D6F")]
		public virtual TextOverflow GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327E110", Offset = "0x327D510", Length = "0x3E")]
		[Token(Token = "0x6001D70")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflow value) { }

	}

	[Token(Token = "0x20003C9")]
	private class TopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000841")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D74")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700083F")]
		public virtual string Name
		{
			[Address(RVA = "0x327E4C0", Offset = "0x327D8C0", Length = "0x2C")]
			[Token(Token = "0x6001D72")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000840")]
		public virtual string ussName
		{
			[Address(RVA = "0x327E4F0", Offset = "0x327D8F0", Length = "0x2C")]
			[Token(Token = "0x6001D73")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001D77")]
		public TopProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D74")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327E4C0", Offset = "0x327D8C0", Length = "0x2C")]
		[Token(Token = "0x6001D72")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327E4F0", Offset = "0x327D8F0", Length = "0x2C")]
		[Token(Token = "0x6001D73")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327E430", Offset = "0x327D830", Length = "0x48")]
		[Token(Token = "0x6001D75")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327E480", Offset = "0x327D880", Length = "0x3E")]
		[Token(Token = "0x6001D76")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003CA")]
	private class TransformOriginProperty : ResolvedVector3Property
	{

		[Token(Token = "0x17000844")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D7A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000842")]
		public virtual string Name
		{
			[Address(RVA = "0x327EDF0", Offset = "0x327E1F0", Length = "0x2C")]
			[Token(Token = "0x6001D78")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000843")]
		public virtual string ussName
		{
			[Address(RVA = "0x327EE20", Offset = "0x327E220", Length = "0x2C")]
			[Token(Token = "0x6001D79")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32779C0", Offset = "0x3276DC0", Length = "0x39")]
		[Token(Token = "0x6001D7D")]
		public TransformOriginProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D7A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327EDF0", Offset = "0x327E1F0", Length = "0x2C")]
		[Token(Token = "0x6001D78")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327EE20", Offset = "0x327E220", Length = "0x2C")]
		[Token(Token = "0x6001D79")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327ECD0", Offset = "0x327E0D0", Length = "0xD7")]
		[Token(Token = "0x6001D7B")]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327EDB0", Offset = "0x327E1B0", Length = "0x3E")]
		[Token(Token = "0x6001D7C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	[Token(Token = "0x20003CB")]
	private class TransitionDelayProperty : ResolvedListProperty<TimeValue>
	{

		[Token(Token = "0x17000847")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D80")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000845")]
		public virtual string Name
		{
			[Address(RVA = "0x327FA30", Offset = "0x327EE30", Length = "0x2C")]
			[Token(Token = "0x6001D7E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000846")]
		public virtual string ussName
		{
			[Address(RVA = "0x327FA60", Offset = "0x327EE60", Length = "0x2C")]
			[Token(Token = "0x6001D7F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x327F9F0", Offset = "0x327EDF0", Length = "0x39")]
		[Token(Token = "0x6001D83")]
		public TransitionDelayProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D80")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327FA30", Offset = "0x327EE30", Length = "0x2C")]
		[Token(Token = "0x6001D7E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327FA60", Offset = "0x327EE60", Length = "0x2C")]
		[Token(Token = "0x6001D7F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327F960", Offset = "0x327ED60", Length = "0x48")]
		[Token(Token = "0x6001D81")]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327F9B0", Offset = "0x327EDB0", Length = "0x3E")]
		[Token(Token = "0x6001D82")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	[Token(Token = "0x20003CC")]
	private class TransitionDurationProperty : ResolvedListProperty<TimeValue>
	{

		[Token(Token = "0x1700084A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D86")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000848")]
		public virtual string Name
		{
			[Address(RVA = "0x327FB60", Offset = "0x327EF60", Length = "0x2C")]
			[Token(Token = "0x6001D84")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000849")]
		public virtual string ussName
		{
			[Address(RVA = "0x327FB90", Offset = "0x327EF90", Length = "0x2C")]
			[Token(Token = "0x6001D85")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x327FB20", Offset = "0x327EF20", Length = "0x39")]
		[Token(Token = "0x6001D89")]
		public TransitionDurationProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D86")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327FB60", Offset = "0x327EF60", Length = "0x2C")]
		[Token(Token = "0x6001D84")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327FB90", Offset = "0x327EF90", Length = "0x2C")]
		[Token(Token = "0x6001D85")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327FA90", Offset = "0x327EE90", Length = "0x48")]
		[Token(Token = "0x6001D87")]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327FAE0", Offset = "0x327EEE0", Length = "0x3E")]
		[Token(Token = "0x6001D88")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	[Token(Token = "0x20003CD")]
	private class TransitionPropertyProperty : ResolvedListProperty<StylePropertyName>
	{

		[Token(Token = "0x1700084D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D8C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700084B")]
		public virtual string Name
		{
			[Address(RVA = "0x327FC90", Offset = "0x327F090", Length = "0x2C")]
			[Token(Token = "0x6001D8A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700084C")]
		public virtual string ussName
		{
			[Address(RVA = "0x327FCC0", Offset = "0x327F0C0", Length = "0x2C")]
			[Token(Token = "0x6001D8B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x327FC50", Offset = "0x327F050", Length = "0x39")]
		[Token(Token = "0x6001D8F")]
		public TransitionPropertyProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D8C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327FC90", Offset = "0x327F090", Length = "0x2C")]
		[Token(Token = "0x6001D8A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327FCC0", Offset = "0x327F0C0", Length = "0x2C")]
		[Token(Token = "0x6001D8B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327FBC0", Offset = "0x327EFC0", Length = "0x48")]
		[Token(Token = "0x6001D8D")]
		public virtual IEnumerable<StylePropertyName> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327FC10", Offset = "0x327F010", Length = "0x3E")]
		[Token(Token = "0x6001D8E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<StylePropertyName> value) { }

	}

	[Token(Token = "0x20003CE")]
	private class TransitionTimingFunctionProperty : ResolvedListProperty<EasingFunction>
	{

		[Token(Token = "0x17000850")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D92")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700084E")]
		public virtual string Name
		{
			[Address(RVA = "0x327FDC0", Offset = "0x327F1C0", Length = "0x2C")]
			[Token(Token = "0x6001D90")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700084F")]
		public virtual string ussName
		{
			[Address(RVA = "0x327FDF0", Offset = "0x327F1F0", Length = "0x2C")]
			[Token(Token = "0x6001D91")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x327FD80", Offset = "0x327F180", Length = "0x39")]
		[Token(Token = "0x6001D95")]
		public TransitionTimingFunctionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D92")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327FDC0", Offset = "0x327F1C0", Length = "0x2C")]
		[Token(Token = "0x6001D90")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327FDF0", Offset = "0x327F1F0", Length = "0x2C")]
		[Token(Token = "0x6001D91")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327FCF0", Offset = "0x327F0F0", Length = "0x48")]
		[Token(Token = "0x6001D93")]
		public virtual IEnumerable<EasingFunction> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327FD40", Offset = "0x327F140", Length = "0x3E")]
		[Token(Token = "0x6001D94")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<EasingFunction> value) { }

	}

	[Token(Token = "0x20003CF")]
	private class TranslateProperty : ResolvedVector3Property
	{

		[Token(Token = "0x17000853")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D98")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000851")]
		public virtual string Name
		{
			[Address(RVA = "0x327FF40", Offset = "0x327F340", Length = "0x2C")]
			[Token(Token = "0x6001D96")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000852")]
		public virtual string ussName
		{
			[Address(RVA = "0x327FF70", Offset = "0x327F370", Length = "0x2C")]
			[Token(Token = "0x6001D97")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32779C0", Offset = "0x3276DC0", Length = "0x39")]
		[Token(Token = "0x6001D9B")]
		public TranslateProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D98")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x327FF40", Offset = "0x327F340", Length = "0x2C")]
		[Token(Token = "0x6001D96")]
		public virtual string get_Name() { }

		[Address(RVA = "0x327FF70", Offset = "0x327F370", Length = "0x2C")]
		[Token(Token = "0x6001D97")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x327FE20", Offset = "0x327F220", Length = "0xD7")]
		[Token(Token = "0x6001D99")]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x327FF00", Offset = "0x327F300", Length = "0x3E")]
		[Token(Token = "0x6001D9A")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	[Token(Token = "0x20003D0")]
	private class UnityBackgroundImageTintColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x17000856")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001D9E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000854")]
		public virtual string Name
		{
			[Address(RVA = "0x32808E0", Offset = "0x327FCE0", Length = "0x2C")]
			[Token(Token = "0x6001D9C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000855")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280910", Offset = "0x327FD10", Length = "0x2C")]
			[Token(Token = "0x6001D9D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001DA1")]
		public UnityBackgroundImageTintColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001D9E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32808E0", Offset = "0x327FCE0", Length = "0x2C")]
		[Token(Token = "0x6001D9C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280910", Offset = "0x327FD10", Length = "0x2C")]
		[Token(Token = "0x6001D9D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32807D0", Offset = "0x327FBD0", Length = "0xCF")]
		[Token(Token = "0x6001D9F")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32808A0", Offset = "0x327FCA0", Length = "0x3E")]
		[Token(Token = "0x6001DA0")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003D1")]
	private class UnityEditorTextRenderingModeProperty : ResolvedEnumProperty<EditorTextRenderingMode>
	{

		[Token(Token = "0x17000859")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DA4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000857")]
		public virtual string Name
		{
			[Address(RVA = "0x3280A10", Offset = "0x327FE10", Length = "0x2C")]
			[Token(Token = "0x6001DA2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000858")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280A40", Offset = "0x327FE40", Length = "0x2C")]
			[Token(Token = "0x6001DA3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32809D0", Offset = "0x327FDD0", Length = "0x39")]
		[Token(Token = "0x6001DA7")]
		public UnityEditorTextRenderingModeProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DA4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3280A10", Offset = "0x327FE10", Length = "0x2C")]
		[Token(Token = "0x6001DA2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280A40", Offset = "0x327FE40", Length = "0x2C")]
		[Token(Token = "0x6001DA3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280940", Offset = "0x327FD40", Length = "0x48")]
		[Token(Token = "0x6001DA5")]
		public virtual EditorTextRenderingMode GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3280990", Offset = "0x327FD90", Length = "0x3E")]
		[Token(Token = "0x6001DA6")]
		public virtual void SetValue(ref ResolvedStyleAccess container, EditorTextRenderingMode value) { }

	}

	[Token(Token = "0x20003D3")]
	private class UnityFontDefinitionProperty : ResolvedFontDefinitionProperty
	{

		[Token(Token = "0x1700085F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DB0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700085D")]
		public virtual string Name
		{
			[Address(RVA = "0x3280B80", Offset = "0x327FF80", Length = "0x2C")]
			[Token(Token = "0x6001DAE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700085E")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280BB0", Offset = "0x327FFB0", Length = "0x2C")]
			[Token(Token = "0x6001DAF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32757F0", Offset = "0x3274BF0", Length = "0x39")]
		[Token(Token = "0x6001DB3")]
		public UnityFontDefinitionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DB0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3280B80", Offset = "0x327FF80", Length = "0x2C")]
		[Token(Token = "0x6001DAE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280BB0", Offset = "0x327FFB0", Length = "0x2C")]
		[Token(Token = "0x6001DAF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280A70", Offset = "0x327FE70", Length = "0xCF")]
		[Token(Token = "0x6001DB1")]
		public virtual FontDefinition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3280B40", Offset = "0x327FF40", Length = "0x3E")]
		[Token(Token = "0x6001DB2")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontDefinition value) { }

	}

	[Token(Token = "0x20003D2")]
	private class UnityFontProperty : ResolvedFontProperty
	{

		[Token(Token = "0x1700085C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DAA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700085A")]
		public virtual string Name
		{
			[Address(RVA = "0x3280CE0", Offset = "0x32800E0", Length = "0x2C")]
			[Token(Token = "0x6001DA8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700085B")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280D10", Offset = "0x3280110", Length = "0x2C")]
			[Token(Token = "0x6001DA9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275830", Offset = "0x3274C30", Length = "0x39")]
		[Token(Token = "0x6001DAD")]
		public UnityFontProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DAA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3280CE0", Offset = "0x32800E0", Length = "0x2C")]
		[Token(Token = "0x6001DA8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280D10", Offset = "0x3280110", Length = "0x2C")]
		[Token(Token = "0x6001DA9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280BE0", Offset = "0x327FFE0", Length = "0xBC")]
		[Token(Token = "0x6001DAB")]
		public virtual Font GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3280CA0", Offset = "0x32800A0", Length = "0x3E")]
		[Token(Token = "0x6001DAC")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Font value) { }

	}

	[Token(Token = "0x20003D4")]
	private class UnityFontStyleAndWeightProperty : ResolvedEnumProperty<FontStyle>
	{

		[Token(Token = "0x17000862")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DB6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000860")]
		public virtual string Name
		{
			[Address(RVA = "0x3280E10", Offset = "0x3280210", Length = "0x2C")]
			[Token(Token = "0x6001DB4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000861")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280E40", Offset = "0x3280240", Length = "0x2C")]
			[Token(Token = "0x6001DB5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3280DD0", Offset = "0x32801D0", Length = "0x39")]
		[Token(Token = "0x6001DB9")]
		public UnityFontStyleAndWeightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DB6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3280E10", Offset = "0x3280210", Length = "0x2C")]
		[Token(Token = "0x6001DB4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280E40", Offset = "0x3280240", Length = "0x2C")]
		[Token(Token = "0x6001DB5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280D40", Offset = "0x3280140", Length = "0x48")]
		[Token(Token = "0x6001DB7")]
		public virtual FontStyle GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3280D90", Offset = "0x3280190", Length = "0x3E")]
		[Token(Token = "0x6001DB8")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontStyle value) { }

	}

	[Token(Token = "0x20003D5")]
	private class UnityMaterialProperty : ResolvedMaterialDefinitionProperty
	{

		[Token(Token = "0x17000865")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DBC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000863")]
		public virtual string Name
		{
			[Address(RVA = "0x3280F80", Offset = "0x3280380", Length = "0x2C")]
			[Token(Token = "0x6001DBA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000864")]
		public virtual string ussName
		{
			[Address(RVA = "0x3280FB0", Offset = "0x32803B0", Length = "0x2C")]
			[Token(Token = "0x6001DBB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x32758B0", Offset = "0x3274CB0", Length = "0x39")]
		[Token(Token = "0x6001DBF")]
		public UnityMaterialProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DBC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3280F80", Offset = "0x3280380", Length = "0x2C")]
		[Token(Token = "0x6001DBA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3280FB0", Offset = "0x32803B0", Length = "0x2C")]
		[Token(Token = "0x6001DBB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280E70", Offset = "0x3280270", Length = "0xCF")]
		[Token(Token = "0x6001DBD")]
		public virtual MaterialDefinition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3280F40", Offset = "0x3280340", Length = "0x3E")]
		[Token(Token = "0x6001DBE")]
		public virtual void SetValue(ref ResolvedStyleAccess container, MaterialDefinition value) { }

	}

	[Token(Token = "0x20003D6")]
	private class UnityParagraphSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000868")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DC2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000866")]
		public virtual string Name
		{
			[Address(RVA = "0x3281070", Offset = "0x3280470", Length = "0x2C")]
			[Token(Token = "0x6001DC0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000867")]
		public virtual string ussName
		{
			[Address(RVA = "0x32810A0", Offset = "0x32804A0", Length = "0x2C")]
			[Token(Token = "0x6001DC1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001DC5")]
		public UnityParagraphSpacingProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DC2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281070", Offset = "0x3280470", Length = "0x2C")]
		[Token(Token = "0x6001DC0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32810A0", Offset = "0x32804A0", Length = "0x2C")]
		[Token(Token = "0x6001DC1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3280FE0", Offset = "0x32803E0", Length = "0x48")]
		[Token(Token = "0x6001DC3")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281030", Offset = "0x3280430", Length = "0x3E")]
		[Token(Token = "0x6001DC4")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003D7")]
	private class UnitySliceBottomProperty : ResolvedIntProperty
	{

		[Token(Token = "0x1700086B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DC8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000869")]
		public virtual string Name
		{
			[Address(RVA = "0x3281160", Offset = "0x3280560", Length = "0x2C")]
			[Token(Token = "0x6001DC6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700086A")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281190", Offset = "0x3280590", Length = "0x2C")]
			[Token(Token = "0x6001DC7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275870", Offset = "0x3274C70", Length = "0x39")]
		[Token(Token = "0x6001DCB")]
		public UnitySliceBottomProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DC8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281160", Offset = "0x3280560", Length = "0x2C")]
		[Token(Token = "0x6001DC6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281190", Offset = "0x3280590", Length = "0x2C")]
		[Token(Token = "0x6001DC7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32810D0", Offset = "0x32804D0", Length = "0x48")]
		[Token(Token = "0x6001DC9")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281120", Offset = "0x3280520", Length = "0x3E")]
		[Token(Token = "0x6001DCA")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003D8")]
	private class UnitySliceLeftProperty : ResolvedIntProperty
	{

		[Token(Token = "0x1700086E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DCE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700086C")]
		public virtual string Name
		{
			[Address(RVA = "0x3281250", Offset = "0x3280650", Length = "0x2C")]
			[Token(Token = "0x6001DCC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700086D")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281280", Offset = "0x3280680", Length = "0x2C")]
			[Token(Token = "0x6001DCD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275870", Offset = "0x3274C70", Length = "0x39")]
		[Token(Token = "0x6001DD1")]
		public UnitySliceLeftProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DCE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281250", Offset = "0x3280650", Length = "0x2C")]
		[Token(Token = "0x6001DCC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281280", Offset = "0x3280680", Length = "0x2C")]
		[Token(Token = "0x6001DCD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32811C0", Offset = "0x32805C0", Length = "0x48")]
		[Token(Token = "0x6001DCF")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281210", Offset = "0x3280610", Length = "0x3E")]
		[Token(Token = "0x6001DD0")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003D9")]
	private class UnitySliceRightProperty : ResolvedIntProperty
	{

		[Token(Token = "0x17000871")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DD4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700086F")]
		public virtual string Name
		{
			[Address(RVA = "0x3281340", Offset = "0x3280740", Length = "0x2C")]
			[Token(Token = "0x6001DD2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000870")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281370", Offset = "0x3280770", Length = "0x2C")]
			[Token(Token = "0x6001DD3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275870", Offset = "0x3274C70", Length = "0x39")]
		[Token(Token = "0x6001DD7")]
		public UnitySliceRightProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DD4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281340", Offset = "0x3280740", Length = "0x2C")]
		[Token(Token = "0x6001DD2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281370", Offset = "0x3280770", Length = "0x2C")]
		[Token(Token = "0x6001DD3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32812B0", Offset = "0x32806B0", Length = "0x48")]
		[Token(Token = "0x6001DD5")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281300", Offset = "0x3280700", Length = "0x3E")]
		[Token(Token = "0x6001DD6")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003DA")]
	private class UnitySliceScaleProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000874")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DDA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000872")]
		public virtual string Name
		{
			[Address(RVA = "0x3281430", Offset = "0x3280830", Length = "0x2C")]
			[Token(Token = "0x6001DD8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000873")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281460", Offset = "0x3280860", Length = "0x2C")]
			[Token(Token = "0x6001DD9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001DDD")]
		public UnitySliceScaleProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DDA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281430", Offset = "0x3280830", Length = "0x2C")]
		[Token(Token = "0x6001DD8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281460", Offset = "0x3280860", Length = "0x2C")]
		[Token(Token = "0x6001DD9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32813A0", Offset = "0x32807A0", Length = "0x48")]
		[Token(Token = "0x6001DDB")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32813F0", Offset = "0x32807F0", Length = "0x3E")]
		[Token(Token = "0x6001DDC")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003DB")]
	private class UnitySliceTopProperty : ResolvedIntProperty
	{

		[Token(Token = "0x17000877")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DE0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000875")]
		public virtual string Name
		{
			[Address(RVA = "0x3281520", Offset = "0x3280920", Length = "0x2C")]
			[Token(Token = "0x6001DDE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000876")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281550", Offset = "0x3280950", Length = "0x2C")]
			[Token(Token = "0x6001DDF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3275870", Offset = "0x3274C70", Length = "0x39")]
		[Token(Token = "0x6001DE3")]
		public UnitySliceTopProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DE0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281520", Offset = "0x3280920", Length = "0x2C")]
		[Token(Token = "0x6001DDE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281550", Offset = "0x3280950", Length = "0x2C")]
		[Token(Token = "0x6001DDF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3281490", Offset = "0x3280890", Length = "0x48")]
		[Token(Token = "0x6001DE1")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32814E0", Offset = "0x32808E0", Length = "0x3E")]
		[Token(Token = "0x6001DE2")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003DC")]
	private class UnitySliceTypeProperty : ResolvedEnumProperty<SliceType>
	{

		[Token(Token = "0x1700087A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DE6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000878")]
		public virtual string Name
		{
			[Address(RVA = "0x3281650", Offset = "0x3280A50", Length = "0x2C")]
			[Token(Token = "0x6001DE4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000879")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281680", Offset = "0x3280A80", Length = "0x2C")]
			[Token(Token = "0x6001DE5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3281610", Offset = "0x3280A10", Length = "0x39")]
		[Token(Token = "0x6001DE9")]
		public UnitySliceTypeProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DE6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281650", Offset = "0x3280A50", Length = "0x2C")]
		[Token(Token = "0x6001DE4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281680", Offset = "0x3280A80", Length = "0x2C")]
		[Token(Token = "0x6001DE5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3281580", Offset = "0x3280980", Length = "0x48")]
		[Token(Token = "0x6001DE7")]
		public virtual SliceType GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32815D0", Offset = "0x32809D0", Length = "0x3E")]
		[Token(Token = "0x6001DE8")]
		public virtual void SetValue(ref ResolvedStyleAccess container, SliceType value) { }

	}

	[Token(Token = "0x20003DD")]
	private class UnityTextAlignProperty : ResolvedEnumProperty<TextAnchor>
	{

		[Token(Token = "0x1700087D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DEC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700087B")]
		public virtual string Name
		{
			[Address(RVA = "0x3281780", Offset = "0x3280B80", Length = "0x2C")]
			[Token(Token = "0x6001DEA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700087C")]
		public virtual string ussName
		{
			[Address(RVA = "0x32817B0", Offset = "0x3280BB0", Length = "0x2C")]
			[Token(Token = "0x6001DEB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3281740", Offset = "0x3280B40", Length = "0x39")]
		[Token(Token = "0x6001DEF")]
		public UnityTextAlignProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DEC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281780", Offset = "0x3280B80", Length = "0x2C")]
		[Token(Token = "0x6001DEA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32817B0", Offset = "0x3280BB0", Length = "0x2C")]
		[Token(Token = "0x6001DEB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32816B0", Offset = "0x3280AB0", Length = "0x48")]
		[Token(Token = "0x6001DED")]
		public virtual TextAnchor GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281700", Offset = "0x3280B00", Length = "0x3E")]
		[Token(Token = "0x6001DEE")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextAnchor value) { }

	}

	[Token(Token = "0x20003DE")]
	private class UnityTextGeneratorProperty : ResolvedEnumProperty<TextGeneratorType>
	{

		[Token(Token = "0x17000880")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DF2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700087E")]
		public virtual string Name
		{
			[Address(RVA = "0x32818B0", Offset = "0x3280CB0", Length = "0x2C")]
			[Token(Token = "0x6001DF0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700087F")]
		public virtual string ussName
		{
			[Address(RVA = "0x32818E0", Offset = "0x3280CE0", Length = "0x2C")]
			[Token(Token = "0x6001DF1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3281870", Offset = "0x3280C70", Length = "0x39")]
		[Token(Token = "0x6001DF5")]
		public UnityTextGeneratorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DF2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x32818B0", Offset = "0x3280CB0", Length = "0x2C")]
		[Token(Token = "0x6001DF0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x32818E0", Offset = "0x3280CE0", Length = "0x2C")]
		[Token(Token = "0x6001DF1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x32817E0", Offset = "0x3280BE0", Length = "0x48")]
		[Token(Token = "0x6001DF3")]
		public virtual TextGeneratorType GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281830", Offset = "0x3280C30", Length = "0x3E")]
		[Token(Token = "0x6001DF4")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextGeneratorType value) { }

	}

	[Token(Token = "0x20003DF")]
	private class UnityTextOutlineColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x17000883")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DF8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000881")]
		public virtual string Name
		{
			[Address(RVA = "0x3281A20", Offset = "0x3280E20", Length = "0x2C")]
			[Token(Token = "0x6001DF6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000882")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281A50", Offset = "0x3280E50", Length = "0x2C")]
			[Token(Token = "0x6001DF7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3268670", Offset = "0x3267A70", Length = "0x39")]
		[Token(Token = "0x6001DFB")]
		public UnityTextOutlineColorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DF8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281A20", Offset = "0x3280E20", Length = "0x2C")]
		[Token(Token = "0x6001DF6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281A50", Offset = "0x3280E50", Length = "0x2C")]
		[Token(Token = "0x6001DF7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3281910", Offset = "0x3280D10", Length = "0xCF")]
		[Token(Token = "0x6001DF9")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x32819E0", Offset = "0x3280DE0", Length = "0x3E")]
		[Token(Token = "0x6001DFA")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003E0")]
	private class UnityTextOutlineWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000886")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001DFE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000884")]
		public virtual string Name
		{
			[Address(RVA = "0x3281B10", Offset = "0x3280F10", Length = "0x2C")]
			[Token(Token = "0x6001DFC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000885")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281B40", Offset = "0x3280F40", Length = "0x2C")]
			[Token(Token = "0x6001DFD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001E01")]
		public UnityTextOutlineWidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001DFE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281B10", Offset = "0x3280F10", Length = "0x2C")]
		[Token(Token = "0x6001DFC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281B40", Offset = "0x3280F40", Length = "0x2C")]
		[Token(Token = "0x6001DFD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3281A80", Offset = "0x3280E80", Length = "0x48")]
		[Token(Token = "0x6001DFF")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281AD0", Offset = "0x3280ED0", Length = "0x3E")]
		[Token(Token = "0x6001E00")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003E1")]
	private class UnityTextOverflowPositionProperty : ResolvedEnumProperty<TextOverflowPosition>
	{

		[Token(Token = "0x17000889")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001E04")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000887")]
		public virtual string Name
		{
			[Address(RVA = "0x3281C40", Offset = "0x3281040", Length = "0x2C")]
			[Token(Token = "0x6001E02")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000888")]
		public virtual string ussName
		{
			[Address(RVA = "0x3281C70", Offset = "0x3281070", Length = "0x2C")]
			[Token(Token = "0x6001E03")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3281C00", Offset = "0x3281000", Length = "0x39")]
		[Token(Token = "0x6001E07")]
		public UnityTextOverflowPositionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001E04")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3281C40", Offset = "0x3281040", Length = "0x2C")]
		[Token(Token = "0x6001E02")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3281C70", Offset = "0x3281070", Length = "0x2C")]
		[Token(Token = "0x6001E03")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3281B70", Offset = "0x3280F70", Length = "0x48")]
		[Token(Token = "0x6001E05")]
		public virtual TextOverflowPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3281BC0", Offset = "0x3280FC0", Length = "0x3E")]
		[Token(Token = "0x6001E06")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflowPosition value) { }

	}

	[Token(Token = "0x20003E2")]
	private class VisibilityProperty : ResolvedEnumProperty<Visibility>
	{

		[Token(Token = "0x1700088C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001E0A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700088A")]
		public virtual string Name
		{
			[Address(RVA = "0x3282C10", Offset = "0x3282010", Length = "0x2C")]
			[Token(Token = "0x6001E08")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700088B")]
		public virtual string ussName
		{
			[Address(RVA = "0x3282C40", Offset = "0x3282040", Length = "0x2C")]
			[Token(Token = "0x6001E09")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3282BD0", Offset = "0x3281FD0", Length = "0x39")]
		[Token(Token = "0x6001E0D")]
		public VisibilityProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001E0A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3282C10", Offset = "0x3282010", Length = "0x2C")]
		[Token(Token = "0x6001E08")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3282C40", Offset = "0x3282040", Length = "0x2C")]
		[Token(Token = "0x6001E09")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3282B40", Offset = "0x3281F40", Length = "0x48")]
		[Token(Token = "0x6001E0B")]
		public virtual Visibility GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3282B90", Offset = "0x3281F90", Length = "0x3E")]
		[Token(Token = "0x6001E0C")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Visibility value) { }

	}

	[Token(Token = "0x20003E3")]
	private class WhiteSpaceProperty : ResolvedEnumProperty<WhiteSpace>
	{

		[Token(Token = "0x1700088F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001E10")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700088D")]
		public virtual string Name
		{
			[Address(RVA = "0x3284B80", Offset = "0x3283F80", Length = "0x2C")]
			[Token(Token = "0x6001E0E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700088E")]
		public virtual string ussName
		{
			[Address(RVA = "0x3284BB0", Offset = "0x3283FB0", Length = "0x2C")]
			[Token(Token = "0x6001E0F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3284B40", Offset = "0x3283F40", Length = "0x39")]
		[Token(Token = "0x6001E13")]
		public WhiteSpaceProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001E10")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3284B80", Offset = "0x3283F80", Length = "0x2C")]
		[Token(Token = "0x6001E0E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3284BB0", Offset = "0x3283FB0", Length = "0x2C")]
		[Token(Token = "0x6001E0F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3284AB0", Offset = "0x3283EB0", Length = "0x48")]
		[Token(Token = "0x6001E11")]
		public virtual WhiteSpace GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3284B00", Offset = "0x3283F00", Length = "0x3E")]
		[Token(Token = "0x6001E12")]
		public virtual void SetValue(ref ResolvedStyleAccess container, WhiteSpace value) { }

	}

	[Token(Token = "0x20003E4")]
	private class WidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000892")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001E16")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000890")]
		public virtual string Name
		{
			[Address(RVA = "0x3284C70", Offset = "0x3284070", Length = "0x2C")]
			[Token(Token = "0x6001E14")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000891")]
		public virtual string ussName
		{
			[Address(RVA = "0x3284CA0", Offset = "0x32840A0", Length = "0x2C")]
			[Token(Token = "0x6001E15")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001E19")]
		public WidthProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001E16")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3284C70", Offset = "0x3284070", Length = "0x2C")]
		[Token(Token = "0x6001E14")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3284CA0", Offset = "0x32840A0", Length = "0x2C")]
		[Token(Token = "0x6001E15")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3284BE0", Offset = "0x3283FE0", Length = "0x48")]
		[Token(Token = "0x6001E17")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3284C30", Offset = "0x3284030", Length = "0x3E")]
		[Token(Token = "0x6001E18")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003E5")]
	private class WordSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000895")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001E1C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000893")]
		public virtual string Name
		{
			[Address(RVA = "0x3284D60", Offset = "0x3284160", Length = "0x2C")]
			[Token(Token = "0x6001E1A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000894")]
		public virtual string ussName
		{
			[Address(RVA = "0x3284D90", Offset = "0x3284190", Length = "0x2C")]
			[Token(Token = "0x6001E1B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3269990", Offset = "0x3268D90", Length = "0x39")]
		[Token(Token = "0x6001E1F")]
		public WordSpacingProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001E1C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3284D60", Offset = "0x3284160", Length = "0x2C")]
		[Token(Token = "0x6001E1A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3284D90", Offset = "0x3284190", Length = "0x2C")]
		[Token(Token = "0x6001E1B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x3284CD0", Offset = "0x32840D0", Length = "0x48")]
		[Token(Token = "0x6001E1D")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x3284D20", Offset = "0x3284120", Length = "0x3E")]
		[Token(Token = "0x6001E1E")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D24")]
	private readonly List<IProperty`1<ResolvedStyleAccess>> m_PropertiesList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D25")]
	private readonly Dictionary<String, IProperty`1<ResolvedStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[Address(RVA = "0x3275AA0", Offset = "0x3274EA0", Length = "0x1F1D")]
	[Token(Token = "0x6001C29")]
	public ResolvedStyleAccessPropertyBag() { }

	[Address(RVA = "0x8E8A80", Offset = "0x8E7E80", Length = "0x17B")]
	[Token(Token = "0x6001C2A")]
	private void AddProperty(ResolvedStyleProperty<TValue> property) { }

	[Address(RVA = "0x32759D0", Offset = "0x3274DD0", Length = "0x5D")]
	[Token(Token = "0x6001C2B")]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties() { }

	[Address(RVA = "0x3275970", Offset = "0x3274D70", Length = "0x5D")]
	[Token(Token = "0x6001C2C")]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties(ref ResolvedStyleAccess container) { }

	[Address(RVA = "0x3275A30", Offset = "0x3274E30", Length = "0x63")]
	[Token(Token = "0x6001C2D")]
	public override bool TryGetProperty(ref ResolvedStyleAccess container, string name, out IProperty<ResolvedStyleAccess>& property) { }

}

