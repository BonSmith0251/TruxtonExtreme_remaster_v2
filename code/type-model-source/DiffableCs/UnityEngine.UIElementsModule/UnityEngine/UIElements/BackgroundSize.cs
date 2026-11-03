namespace UnityEngine.UIElements;

[Token(Token = "0x2000017")]
public struct BackgroundSize : IEquatable<BackgroundSize>
{
	[Token(Token = "0x2000018")]
	public class PropertyBag : ContainerPropertyBag<BackgroundSize>
	{
		[Token(Token = "0x2000019")]
		private class SizeTypeProperty : Property<BackgroundSize, BackgroundSizeType>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000038")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000039")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700001B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600007D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700001A")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600007C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x320F960", Offset = "0x320ED60", Length = "0x64")]
			[Token(Token = "0x6000080")]
			public SizeTypeProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600007D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600007C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x320F8F0", Offset = "0x320ECF0", Length = "0x5")]
			[Token(Token = "0x600007E")]
			public virtual BackgroundSizeType GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x320F900", Offset = "0x320ED00", Length = "0x56")]
			[Token(Token = "0x600007F")]
			public virtual void SetValue(ref BackgroundSize container, BackgroundSizeType value) { }

		}

		[Token(Token = "0x200001A")]
		private class XProperty : Property<BackgroundSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400003A")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400003B")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700001D")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000082")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700001C")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000081")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3212470", Offset = "0x3211870", Length = "0x64")]
			[Token(Token = "0x6000085")]
			public XProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000082")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000081")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3212450", Offset = "0x3211850", Length = "0x7")]
			[Token(Token = "0x6000083")]
			public virtual Length GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x3212460", Offset = "0x3211860", Length = "0xB")]
			[Token(Token = "0x6000084")]
			public virtual void SetValue(ref BackgroundSize container, Length value) { }

		}

		[Token(Token = "0x200001B")]
		private class YProperty : Property<BackgroundSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400003C")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400003D")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700001F")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000087")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700001E")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000086")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3212570", Offset = "0x3211970", Length = "0x64")]
			[Token(Token = "0x600008A")]
			public YProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000087")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000086")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3212550", Offset = "0x3211950", Length = "0x7")]
			[Token(Token = "0x6000088")]
			public virtual Length GetValue(ref BackgroundSize container) { }

			[Address(RVA = "0x3212560", Offset = "0x3211960", Length = "0xB")]
			[Token(Token = "0x6000089")]
			public virtual void SetValue(ref BackgroundSize container, Length value) { }

		}


		[Address(RVA = "0x320F6E0", Offset = "0x320EAE0", Length = "0x204")]
		[Token(Token = "0x600007B")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000035")]
	private BackgroundSizeType m_SizeType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000036")]
	private Length m_X; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private Length m_Y; //Field offset: 0xC

	[Token(Token = "0x17000017")]
	public BackgroundSizeType sizeType
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 5
		[Address(RVA = "0x31EE670", Offset = "0x31EDA70", Length = "0x55")]
		[Token(Token = "0x600006D")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000018")]
	public Length x
	{
		[Address(RVA = "0x20939C0", Offset = "0x2092DC0", Length = "0x7")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 7
		[Address(RVA = "0x31EE7D0", Offset = "0x31EDBD0", Length = "0xB")]
		[Token(Token = "0x600006F")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000019")]
	public Length y
	{
		[Address(RVA = "0x31EE6D0", Offset = "0x31EDAD0", Length = "0x7")]
		[Token(Token = "0x6000070")]
		 get { } //Length: 7
		[Address(RVA = "0x31EE7E0", Offset = "0x31EDBE0", Length = "0xB")]
		[Token(Token = "0x6000071")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x31EE660", Offset = "0x31EDA60", Length = "0xF")]
	[Token(Token = "0x6000072")]
	public BackgroundSize(Length sizeX, Length sizeY) { }

	[Address(RVA = "0x31EE670", Offset = "0x31EDA70", Length = "0x55")]
	[Token(Token = "0x6000073")]
	public BackgroundSize(BackgroundSizeType sizeType) { }

	[Address(RVA = "0x31EE3C0", Offset = "0x31ED7C0", Length = "0xC1")]
	[Token(Token = "0x6000075")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31EE490", Offset = "0x31ED890", Length = "0x57")]
	[Token(Token = "0x6000076")]
	public override bool Equals(BackgroundSize other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x600006C")]
	public BackgroundSizeType get_sizeType() { }

	[Address(RVA = "0x20939C0", Offset = "0x2092DC0", Length = "0x7")]
	[Token(Token = "0x600006E")]
	public Length get_x() { }

	[Address(RVA = "0x31EE6D0", Offset = "0x31EDAD0", Length = "0x7")]
	[Token(Token = "0x6000070")]
	public Length get_y() { }

	[Address(RVA = "0x31EE4F0", Offset = "0x31ED8F0", Length = "0x4E")]
	[Token(Token = "0x6000077")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31EE540", Offset = "0x31ED940", Length = "0x58")]
	[Token(Token = "0x6000074")]
	internal static BackgroundSize Initial() { }

	[Address(RVA = "0x31EE6E0", Offset = "0x31EDAE0", Length = "0x68")]
	[Token(Token = "0x6000078")]
	public static bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	[Address(RVA = "0x31EE750", Offset = "0x31EDB50", Length = "0x79")]
	[Token(Token = "0x6000079")]
	public static bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	[Address(RVA = "0x31EE670", Offset = "0x31EDA70", Length = "0x55")]
	[Token(Token = "0x600006D")]
	public void set_sizeType(BackgroundSizeType value) { }

	[Address(RVA = "0x31EE7D0", Offset = "0x31EDBD0", Length = "0xB")]
	[Token(Token = "0x600006F")]
	public void set_x(Length value) { }

	[Address(RVA = "0x31EE7E0", Offset = "0x31EDBE0", Length = "0xB")]
	[Token(Token = "0x6000071")]
	public void set_y(Length value) { }

	[Address(RVA = "0x31EE5A0", Offset = "0x31ED9A0", Length = "0xB6")]
	[Token(Token = "0x600007A")]
	public virtual string ToString() { }

}

