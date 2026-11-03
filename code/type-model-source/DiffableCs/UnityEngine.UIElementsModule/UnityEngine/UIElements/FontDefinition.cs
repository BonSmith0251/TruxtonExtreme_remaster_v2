namespace UnityEngine.UIElements;

[Token(Token = "0x2000306")]
public struct FontDefinition : IEquatable<FontDefinition>
{
	[Token(Token = "0x2000307")]
	public class PropertyBag : ContainerPropertyBag<FontDefinition>
	{
		[Token(Token = "0x2000309")]
		private class FontAssetProperty : Property<FontDefinition, FontAsset>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C5F")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C60")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000476")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60015AF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000475")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60015AE")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3237890", Offset = "0x3236C90", Length = "0x64")]
			[Token(Token = "0x60015B2")]
			public FontAssetProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60015AF")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60015AE")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3237860", Offset = "0x3236C60", Length = "0x7")]
			[Token(Token = "0x60015B0")]
			public virtual FontAsset GetValue(ref FontDefinition container) { }

			[Address(RVA = "0x3237870", Offset = "0x3236C70", Length = "0x11")]
			[Token(Token = "0x60015B1")]
			public virtual void SetValue(ref FontDefinition container, FontAsset value) { }

		}

		[Token(Token = "0x2000308")]
		private class FontProperty : Property<FontDefinition, Font>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C5D")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C5E")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000474")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60015AA")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000473")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60015A9")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3238040", Offset = "0x3237440", Length = "0x64")]
			[Token(Token = "0x60015AD")]
			public FontProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60015AA")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60015A9")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3238010", Offset = "0x3237410", Length = "0x6")]
			[Token(Token = "0x60015AB")]
			public virtual Font GetValue(ref FontDefinition container) { }

			[Address(RVA = "0x3238020", Offset = "0x3237420", Length = "0x11")]
			[Token(Token = "0x60015AC")]
			public virtual void SetValue(ref FontDefinition container, Font value) { }

		}


		[Address(RVA = "0x3245050", Offset = "0x3244450", Length = "0x181")]
		[Token(Token = "0x60015A8")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000C5B")]
	private Font m_Font; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000C5C")]
	private FontAsset m_FontAsset; //Field offset: 0x8

	[Token(Token = "0x17000471")]
	public Font font
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x600159A")]
		 get { } //Length: 6
		[Address(RVA = "0x3237F20", Offset = "0x3237320", Length = "0xE6")]
		[Token(Token = "0x600159B")]
		 set { } //Length: 230
	}

	[Token(Token = "0x17000472")]
	public FontAsset fontAsset
	{
		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x600159C")]
		 get { } //Length: 7
		[Address(RVA = "0x3237E30", Offset = "0x3237230", Length = "0xE7")]
		[Token(Token = "0x600159D")]
		 set { } //Length: 231
	}

	[Address(RVA = "0x32379B0", Offset = "0x3236DB0", Length = "0x48")]
	[Token(Token = "0x60015A3")]
	public override bool Equals(FontDefinition other) { }

	[Address(RVA = "0x3237900", Offset = "0x3236D00", Length = "0xAD")]
	[Token(Token = "0x60015A4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3237A00", Offset = "0x3236E00", Length = "0x38")]
	[Token(Token = "0x600159E")]
	public static FontDefinition FromFont(Font f) { }

	[Address(RVA = "0x3237A40", Offset = "0x3236E40", Length = "0x149")]
	[Token(Token = "0x60015A0")]
	internal static FontDefinition FromObject(object obj) { }

	[Address(RVA = "0x3237B90", Offset = "0x3236F90", Length = "0x38")]
	[Token(Token = "0x600159F")]
	public static FontDefinition FromSDFFont(FontAsset f) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x600159A")]
	public Font get_font() { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x600159C")]
	public FontAsset get_fontAsset() { }

	[Address(RVA = "0x3237BD0", Offset = "0x3236FD0", Length = "0xEC")]
	[Token(Token = "0x60015A5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3237CC0", Offset = "0x32370C0", Length = "0x8E")]
	[Token(Token = "0x60015A1")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x32379B0", Offset = "0x3236DB0", Length = "0x48")]
	[Token(Token = "0x60015A6")]
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	[Address(RVA = "0x3237DE0", Offset = "0x32371E0", Length = "0x4C")]
	[Token(Token = "0x60015A7")]
	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }

	[Address(RVA = "0x3237F20", Offset = "0x3237320", Length = "0xE6")]
	[Token(Token = "0x600159B")]
	public void set_font(Font value) { }

	[Address(RVA = "0x3237E30", Offset = "0x3237230", Length = "0xE7")]
	[Token(Token = "0x600159D")]
	public void set_fontAsset(FontAsset value) { }

	[Address(RVA = "0x3237D50", Offset = "0x3237150", Length = "0x8F")]
	[Token(Token = "0x60015A2")]
	public virtual string ToString() { }

}

