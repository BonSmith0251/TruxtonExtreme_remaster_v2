namespace UnityEngine.UIElements;

[Token(Token = "0x200000E")]
public struct BackgroundPosition : IEquatable<BackgroundPosition>
{
	[Token(Token = "0x200000F")]
	public class PropertyBag : ContainerPropertyBag<BackgroundPosition>
	{
		[Token(Token = "0x2000010")]
		private class KeywordProperty : Property<BackgroundPosition, BackgroundPositionKeyword>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400002B")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400002C")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000010")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600004C")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700000F")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600004B")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x320F2D0", Offset = "0x320E6D0", Length = "0x64")]
			[Token(Token = "0x600004F")]
			public KeywordProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600004C")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600004B")]
			public virtual string get_Name() { }

			[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
			[Token(Token = "0x600004D")]
			public virtual BackgroundPositionKeyword GetValue(ref BackgroundPosition container) { }

			[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
			[Token(Token = "0x600004E")]
			public virtual void SetValue(ref BackgroundPosition container, BackgroundPositionKeyword value) { }

		}

		[Token(Token = "0x2000011")]
		private class OffsetProperty : Property<BackgroundPosition, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400002D")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400002E")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000012")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000051")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000011")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000050")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x320F360", Offset = "0x320E760", Length = "0x64")]
			[Token(Token = "0x6000054")]
			public OffsetProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000051")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000050")]
			public virtual string get_Name() { }

			[Address(RVA = "0x320F340", Offset = "0x320E740", Length = "0x5")]
			[Token(Token = "0x6000052")]
			public virtual Length GetValue(ref BackgroundPosition container) { }

			[Address(RVA = "0x320F350", Offset = "0x320E750", Length = "0x5")]
			[Token(Token = "0x6000053")]
			public virtual void SetValue(ref BackgroundPosition container, Length value) { }

		}


		[Address(RVA = "0x320F550", Offset = "0x320E950", Length = "0x181")]
		[Token(Token = "0x600004A")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000029")]
	public BackgroundPositionKeyword keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400002A")]
	public Length offset; //Field offset: 0x4

	[Address(RVA = "0x31EDC80", Offset = "0x31ED080", Length = "0x33")]
	[Token(Token = "0x6000041")]
	public BackgroundPosition(BackgroundPositionKeyword keyword) { }

	[Address(RVA = "0xAEE4D0", Offset = "0xAED8D0", Length = "0x7")]
	[Token(Token = "0x6000042")]
	public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset) { }

	[Address(RVA = "0x31EDAA0", Offset = "0x31ECEA0", Length = "0xAF")]
	[Token(Token = "0x6000044")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31EDA50", Offset = "0x31ECE50", Length = "0x46")]
	[Token(Token = "0x6000045")]
	public override bool Equals(BackgroundPosition other) { }

	[Address(RVA = "0x31EDB50", Offset = "0x31ECF50", Length = "0x3B")]
	[Token(Token = "0x6000046")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31EDB90", Offset = "0x31ECF90", Length = "0x4E")]
	[Token(Token = "0x6000043")]
	internal static BackgroundPosition Initial() { }

	[Address(RVA = "0x31EDCC0", Offset = "0x31ED0C0", Length = "0x64")]
	[Token(Token = "0x6000047")]
	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	[Address(RVA = "0x31EDD30", Offset = "0x31ED130", Length = "0x67")]
	[Token(Token = "0x6000048")]
	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	[Address(RVA = "0x31EDBE0", Offset = "0x31ECFE0", Length = "0x95")]
	[Token(Token = "0x6000049")]
	public virtual string ToString() { }

}

