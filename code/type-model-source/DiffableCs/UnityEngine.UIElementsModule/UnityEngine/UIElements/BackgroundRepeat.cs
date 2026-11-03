namespace UnityEngine.UIElements;

[Token(Token = "0x2000013")]
public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
{
	[Token(Token = "0x2000014")]
	public class PropertyBag : ContainerPropertyBag<BackgroundRepeat>
	{
		[Token(Token = "0x2000015")]
		private class XProperty : Property<BackgroundRepeat, Repeat>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000031")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000032")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000014")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000063")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000013")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000062")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32124E0", Offset = "0x32118E0", Length = "0x64")]
			[Token(Token = "0x6000066")]
			public XProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000063")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000062")]
			public virtual string get_Name() { }

			[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
			[Token(Token = "0x6000064")]
			public virtual Repeat GetValue(ref BackgroundRepeat container) { }

			[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
			[Token(Token = "0x6000065")]
			public virtual void SetValue(ref BackgroundRepeat container, Repeat value) { }

		}

		[Token(Token = "0x2000016")]
		private class YProperty : Property<BackgroundRepeat, Repeat>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000033")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000034")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000016")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000068")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000015")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000067")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32125E0", Offset = "0x32119E0", Length = "0x159")]
			[Token(Token = "0x600006B")]
			public YProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000068")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000067")]
			public virtual string get_Name() { }

			[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
			[Token(Token = "0x6000069")]
			public virtual Repeat GetValue(ref BackgroundRepeat container) { }

			[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
			[Token(Token = "0x600006A")]
			public virtual void SetValue(ref BackgroundRepeat container, Repeat value) { }

		}


		[Address(RVA = "0x320F3D0", Offset = "0x320E7D0", Length = "0x175")]
		[Token(Token = "0x6000061")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002F")]
	public Repeat x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000030")]
	public Repeat y; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000059")]
	public BackgroundRepeat(Repeat repeatX, Repeat repeatY) { }

	[Address(RVA = "0x31EE220", Offset = "0x31ED620", Length = "0x8B")]
	[Token(Token = "0x600005B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30D7CF0", Offset = "0x30D70F0", Length = "0x12")]
	[Token(Token = "0x600005C")]
	public override bool Equals(BackgroundRepeat other) { }

	[Address(RVA = "0x31EE2B0", Offset = "0x31ED6B0", Length = "0x3B")]
	[Token(Token = "0x600005D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x10CEDF0", Offset = "0x10CE1F0", Length = "0x8")]
	[Token(Token = "0x600005A")]
	internal static BackgroundRepeat Initial() { }

	[Address(RVA = "0x31EE380", Offset = "0x31ED780", Length = "0x15")]
	[Token(Token = "0x600005E")]
	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	[Address(RVA = "0x31EE3A0", Offset = "0x31ED7A0", Length = "0x18")]
	[Token(Token = "0x600005F")]
	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	[Address(RVA = "0x31EE2F0", Offset = "0x31ED6F0", Length = "0x87")]
	[Token(Token = "0x6000060")]
	public virtual string ToString() { }

}

