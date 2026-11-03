namespace UnityEngine.UIElements;

[Token(Token = "0x2000183")]
public struct Cursor : IEquatable<Cursor>
{
	[Token(Token = "0x2000184")]
	public class PropertyBag : ContainerPropertyBag<Cursor>
	{
		[Token(Token = "0x2000187")]
		private class DefaultCursorIdProperty : Property<Cursor, Int32>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000777")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000778")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700020B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B9D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700020A")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B9C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x33ACEA0", Offset = "0x33AC2A0", Length = "0x64")]
			[Token(Token = "0x6000BA0")]
			public DefaultCursorIdProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B9D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B9C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x33ACE80", Offset = "0x33AC280", Length = "0x4")]
			[Token(Token = "0x6000B9E")]
			public virtual int GetValue(ref Cursor container) { }

			[Address(RVA = "0x33ACE90", Offset = "0x33AC290", Length = "0x5")]
			[Token(Token = "0x6000B9F")]
			public virtual void SetValue(ref Cursor container, int value) { }

		}

		[Token(Token = "0x2000186")]
		private class HotspotProperty : Property<Cursor, Vector2>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000775")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000776")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000209")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B98")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000208")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B97")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x33AF170", Offset = "0x33AE570", Length = "0x64")]
			[Token(Token = "0x6000B9B")]
			public HotspotProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B98")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B97")]
			public virtual string get_Name() { }

			[Address(RVA = "0x33AF150", Offset = "0x33AE550", Length = "0x13")]
			[Token(Token = "0x6000B99")]
			public virtual Vector2 GetValue(ref Cursor container) { }

			[Address(RVA = "0x3284E40", Offset = "0x3284240", Length = "0x5")]
			[Token(Token = "0x6000B9A")]
			public virtual void SetValue(ref Cursor container, Vector2 value) { }

		}

		[Token(Token = "0x2000185")]
		private class TextureProperty : Property<Cursor, Texture2D>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000773")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000774")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000207")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B93")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000206")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000B92")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x33B93C0", Offset = "0x33B87C0", Length = "0x64")]
			[Token(Token = "0x6000B96")]
			public TextureProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B93")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000B92")]
			public virtual string get_Name() { }

			[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
			[Token(Token = "0x6000B94")]
			public virtual Texture2D GetValue(ref Cursor container) { }

			[Address(RVA = "0x3273BE0", Offset = "0x3272FE0", Length = "0xE")]
			[Token(Token = "0x6000B95")]
			public virtual void SetValue(ref Cursor container, Texture2D value) { }

		}


		[Address(RVA = "0x33B37C0", Offset = "0x33B2BC0", Length = "0x210")]
		[Token(Token = "0x6000B91")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000770")]
	private Texture2D m_Texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000771")]
	private Vector2 m_Hotspot; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000772")]
	private int <defaultCursorId>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000205")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int defaultCursorId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000B8A")]
		internal get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B8B")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000204")]
	public Vector2 hotspot
	{
		[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
		[Token(Token = "0x6000B88")]
		 get { } //Length: 19
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[Token(Token = "0x6000B89")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000203")]
	public Texture2D texture
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000B86")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000B87")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x33AC970", Offset = "0x33ABD70", Length = "0x120")]
	[Token(Token = "0x6000B8C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x33ACAA0", Offset = "0x33ABEA0", Length = "0xA4")]
	[Token(Token = "0x6000B8D")]
	public override bool Equals(Cursor other) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000B8A")]
	internal int get_defaultCursorId() { }

	[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
	[Token(Token = "0x6000B88")]
	public Vector2 get_hotspot() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000B86")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x33ACB50", Offset = "0x33ABF50", Length = "0x1E2")]
	[Token(Token = "0x6000B8E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x33ACDC0", Offset = "0x33AC1C0", Length = "0xBC")]
	[Token(Token = "0x6000B8F")]
	public static bool op_Equality(Cursor style1, Cursor style2) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B8B")]
	internal void set_defaultCursorId(int value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[Token(Token = "0x6000B89")]
	public void set_hotspot(Vector2 value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000B87")]
	public void set_texture(Texture2D value) { }

	[Address(RVA = "0x33ACD40", Offset = "0x33AC140", Length = "0x74")]
	[Token(Token = "0x6000B90")]
	public virtual string ToString() { }

}

