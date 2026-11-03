namespace UnityEngine.UIElements;

[Token(Token = "0x20004B9")]
public struct TextAutoSize : IEquatable<TextAutoSize>
{
	[Token(Token = "0x20004BA")]
	public class PropertyBag : ContainerPropertyBag<TextAutoSize>
	{
		[Token(Token = "0x20004BD")]
		private class MaxSizeProperty : Property<TextAutoSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4001016")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4001017")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700098B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023F9")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700098A")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023F8")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A18D0", Offset = "0x32A0CD0", Length = "0x64")]
			[Token(Token = "0x60023FC")]
			public MaxSizeProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023F9")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023F8")]
			public virtual string get_Name() { }

			[Address(RVA = "0x32A18B0", Offset = "0x32A0CB0", Length = "0x5")]
			[Token(Token = "0x60023FA")]
			public virtual Length GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x32A18C0", Offset = "0x32A0CC0", Length = "0x5")]
			[Token(Token = "0x60023FB")]
			public virtual void SetValue(ref TextAutoSize container, Length value) { }

		}

		[Token(Token = "0x20004BC")]
		private class MinSizeProperty : Property<TextAutoSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4001014")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4001015")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000989")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023F4")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000988")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023F3")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A1940", Offset = "0x32A0D40", Length = "0x64")]
			[Token(Token = "0x60023F7")]
			public MinSizeProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023F4")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023F3")]
			public virtual string get_Name() { }

			[Address(RVA = "0x320F340", Offset = "0x320E740", Length = "0x5")]
			[Token(Token = "0x60023F5")]
			public virtual Length GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x320F350", Offset = "0x320E750", Length = "0x5")]
			[Token(Token = "0x60023F6")]
			public virtual void SetValue(ref TextAutoSize container, Length value) { }

		}

		[Token(Token = "0x20004BB")]
		private class ModeProperty : Property<TextAutoSize, TextAutoSizeMode>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4001012")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4001013")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000987")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023EF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000986")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60023EE")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A19B0", Offset = "0x32A0DB0", Length = "0x64")]
			[Token(Token = "0x60023F2")]
			public ModeProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023EF")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60023EE")]
			public virtual string get_Name() { }

			[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
			[Token(Token = "0x60023F0")]
			public virtual TextAutoSizeMode GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
			[Token(Token = "0x60023F1")]
			public virtual void SetValue(ref TextAutoSize container, TextAutoSizeMode value) { }

		}


		[Address(RVA = "0x32A1D60", Offset = "0x32A1160", Length = "0x204")]
		[Token(Token = "0x60023ED")]
		public PropertyBag() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400100F")]
	private TextAutoSizeMode <mode>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001010")]
	private Length <minSize>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4001011")]
	private Length <maxSize>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x17000985")]
	public Length maxSize
	{
		[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023E5")]
		 get { } //Length: 5
		[Address(RVA = "0x3113320", Offset = "0x3112720", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60023E6")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000984")]
	public Length minSize
	{
		[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023E3")]
		 get { } //Length: 5
		[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60023E4")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000983")]
	public TextAutoSizeMode mode
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60023E1")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60023E2")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x32A2180", Offset = "0x32A1580", Length = "0x66")]
	[Token(Token = "0x60023E8")]
	public override bool Equals(TextAutoSize other) { }

	[Address(RVA = "0x32A21F0", Offset = "0x32A15F0", Length = "0xCD")]
	[Token(Token = "0x60023E9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023E5")]
	public Length get_maxSize() { }

	[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023E3")]
	public Length get_minSize() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60023E1")]
	public TextAutoSizeMode get_mode() { }

	[Address(RVA = "0x32A22C0", Offset = "0x32A16C0", Length = "0x76")]
	[Token(Token = "0x60023EA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32A2340", Offset = "0x32A1740", Length = "0x58")]
	[Token(Token = "0x60023E7")]
	public static TextAutoSize None() { }

	[Address(RVA = "0x32A23A0", Offset = "0x32A17A0", Length = "0x68")]
	[Token(Token = "0x60023EB")]
	public static bool op_Equality(TextAutoSize left, TextAutoSize right) { }

	[Address(RVA = "0x32A2410", Offset = "0x32A1810", Length = "0x7A")]
	[Token(Token = "0x60023EC")]
	public static bool op_Inequality(TextAutoSize left, TextAutoSize right) { }

	[Address(RVA = "0x3113320", Offset = "0x3112720", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60023E6")]
	public void set_maxSize(Length value) { }

	[Address(RVA = "0x20939D0", Offset = "0x2092DD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60023E4")]
	public void set_minSize(Length value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60023E2")]
	public void set_mode(TextAutoSizeMode value) { }

}

