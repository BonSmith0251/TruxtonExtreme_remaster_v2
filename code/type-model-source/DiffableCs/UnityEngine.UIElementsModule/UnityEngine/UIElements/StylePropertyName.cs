namespace UnityEngine.UIElements;

[Token(Token = "0x2000477")]
public struct StylePropertyName : IEquatable<StylePropertyName>
{
	[Token(Token = "0x2000478")]
	public class PropertyBag : ContainerPropertyBag<StylePropertyName>
	{
		[Token(Token = "0x2000479")]
		private class IdProperty : Property<StylePropertyName, StylePropertyId>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000E9E")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000E9F")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700090B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600219D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700090A")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600219C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3286ED0", Offset = "0x32862D0", Length = "0x64")]
			[Token(Token = "0x60021A0")]
			public IdProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600219D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600219C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
			[Token(Token = "0x600219E")]
			public virtual StylePropertyId GetValue(ref StylePropertyName container) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x600219F")]
			public virtual void SetValue(ref StylePropertyName container, StylePropertyId value) { }

		}

		[Token(Token = "0x200047A")]
		private class NameProperty : Property<StylePropertyName, String>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000EA0")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000EA1")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700090D")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60021A2")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700090C")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60021A1")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3286F40", Offset = "0x3286340", Length = "0x64")]
			[Token(Token = "0x60021A5")]
			public NameProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60021A2")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60021A1")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3284E30", Offset = "0x3284230", Length = "0x5")]
			[Token(Token = "0x60021A3")]
			public virtual string GetValue(ref StylePropertyName container) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x60021A4")]
			public virtual void SetValue(ref StylePropertyName container, string value) { }

		}


		[Address(RVA = "0x32871C0", Offset = "0x32865C0", Length = "0x181")]
		[Token(Token = "0x600219B")]
		public PropertyBag() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E9C")]
	private readonly StylePropertyId <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000E9D")]
	private readonly string <name>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000908")]
	internal StylePropertyId id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600218F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000909")]
	private string name
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002190")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x328A0F0", Offset = "0x32894F0", Length = "0xB7")]
	[Token(Token = "0x6002192")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StylePropertyName(StylePropertyId stylePropertyId) { }

	[Address(RVA = "0x328A020", Offset = "0x3289420", Length = "0xC7")]
	[Token(Token = "0x6002193")]
	public StylePropertyName(string name) { }

	[Address(RVA = "0x3289EE0", Offset = "0x32892E0", Length = "0x83")]
	[Token(Token = "0x6002198")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3289F70", Offset = "0x3289370", Length = "0xA")]
	[Token(Token = "0x6002199")]
	public override bool Equals(StylePropertyName other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600218F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StylePropertyId get_id() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002190")]
	private string get_name() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6002197")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3289F70", Offset = "0x3289370", Length = "0xA")]
	[Token(Token = "0x6002194")]
	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	[Address(RVA = "0x328A1B0", Offset = "0x32895B0", Length = "0x32")]
	[Token(Token = "0x6002196")]
	public static StylePropertyName op_Implicit(string name) { }

	[Address(RVA = "0x328A1F0", Offset = "0x32895F0", Length = "0xA")]
	[Token(Token = "0x6002195")]
	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	[Address(RVA = "0x3289F80", Offset = "0x3289380", Length = "0x97")]
	[Token(Token = "0x6002191")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x600219A")]
	public virtual string ToString() { }

}

