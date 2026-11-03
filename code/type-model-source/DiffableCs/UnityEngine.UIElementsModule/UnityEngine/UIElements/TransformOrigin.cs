namespace UnityEngine.UIElements;

[Token(Token = "0x2000437")]
public struct TransformOrigin : IEquatable<TransformOrigin>
{
	[Token(Token = "0x2000438")]
	public class PropertyBag : ContainerPropertyBag<TransformOrigin>
	{
		[Token(Token = "0x2000439")]
		private class XProperty : Property<TransformOrigin, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DEE")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DEF")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008E7")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002050")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008E6")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600204F")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3284DC0", Offset = "0x32841C0", Length = "0x64")]
			[Token(Token = "0x6002053")]
			public XProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002050")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600204F")]
			public virtual string get_Name() { }

			[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
			[Token(Token = "0x6002051")]
			public virtual Length GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x32681C0", Offset = "0x32675C0", Length = "0x4")]
			[Token(Token = "0x6002052")]
			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		[Token(Token = "0x200043A")]
		private class YProperty : Property<TransformOrigin, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DF0")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DF1")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008E9")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002055")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008E8")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002054")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3284E50", Offset = "0x3284250", Length = "0x64")]
			[Token(Token = "0x6002058")]
			public YProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002055")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002054")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3284E30", Offset = "0x3284230", Length = "0x5")]
			[Token(Token = "0x6002056")]
			public virtual Length GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x3284E40", Offset = "0x3284240", Length = "0x5")]
			[Token(Token = "0x6002057")]
			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		[Token(Token = "0x200043B")]
		private class ZProperty : Property<TransformOrigin, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DF2")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DF3")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008EB")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600205A")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008EA")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002059")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3284EE0", Offset = "0x32842E0", Length = "0xC0")]
			[Token(Token = "0x600205D")]
			public ZProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600205A")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002059")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3284EC0", Offset = "0x32842C0", Length = "0x6")]
			[Token(Token = "0x600205B")]
			public virtual float GetValue(ref TransformOrigin container) { }

			[Address(RVA = "0x3284ED0", Offset = "0x32842D0", Length = "0x6")]
			[Token(Token = "0x600205C")]
			public virtual void SetValue(ref TransformOrigin container, float value) { }

		}


		[Address(RVA = "0x3274790", Offset = "0x3273B90", Length = "0x204")]
		[Token(Token = "0x600204E")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DEB")]
	private Length m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DEC")]
	private Length m_Y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000DED")]
	private float m_Z; //Field offset: 0x10

	[Token(Token = "0x170008E3")]
	public Length x
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6002042")]
		 get { } //Length: 4
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6002043")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008E4")]
	public Length y
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6002044")]
		 get { } //Length: 5
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[Token(Token = "0x6002045")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170008E5")]
	public float z
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6002046")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6002047")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x327F280", Offset = "0x327E680", Length = "0xD")]
	[Token(Token = "0x600203F")]
	public TransformOrigin(Length x, Length y, float z) { }

	[Address(RVA = "0x327F290", Offset = "0x327E690", Length = "0x6B")]
	[Token(Token = "0x6002040")]
	internal TransformOrigin(Vector3 vector) { }

	[Address(RVA = "0x327EE50", Offset = "0x327E250", Length = "0xA0")]
	[Token(Token = "0x600204A")]
	public override bool Equals(TransformOrigin other) { }

	[Address(RVA = "0x327EEF0", Offset = "0x327E2F0", Length = "0x119")]
	[Token(Token = "0x600204B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002042")]
	public Length get_x() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6002044")]
	public Length get_y() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6002046")]
	public float get_z() { }

	[Address(RVA = "0x327F010", Offset = "0x327E410", Length = "0x71")]
	[Token(Token = "0x600204C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327F090", Offset = "0x327E490", Length = "0x7B")]
	[Token(Token = "0x6002041")]
	public static TransformOrigin Initial() { }

	[Address(RVA = "0x327F300", Offset = "0x327E700", Length = "0xA0")]
	[Token(Token = "0x6002048")]
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	[Address(RVA = "0x327F3A0", Offset = "0x327E7A0", Length = "0xA3")]
	[Token(Token = "0x6002049")]
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6002043")]
	public void set_x(Length value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[Token(Token = "0x6002045")]
	public void set_y(Length value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6002047")]
	public void set_z(float value) { }

	[Address(RVA = "0x327F110", Offset = "0x327E510", Length = "0x165")]
	[Token(Token = "0x600204D")]
	public virtual string ToString() { }

}

