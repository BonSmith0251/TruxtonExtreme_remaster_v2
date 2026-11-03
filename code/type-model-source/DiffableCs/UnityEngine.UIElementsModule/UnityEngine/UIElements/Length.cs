namespace UnityEngine.UIElements;

[Token(Token = "0x2000401")]
public struct Length : IEquatable<Length>
{
	[Token(Token = "0x2000403")]
	public class PropertyBag : ContainerPropertyBag<Length>
	{
		[Token(Token = "0x2000405")]
		private class UnitProperty : Property<Length, LengthUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D8C")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D8D")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700089C")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E81")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700089B")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E80")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3280760", Offset = "0x327FB60", Length = "0x64")]
			[Token(Token = "0x6001E84")]
			public UnitProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E81")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E80")]
			public virtual string get_Name() { }

			[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
			[Token(Token = "0x6001E82")]
			public virtual LengthUnit GetValue(ref Length container) { }

			[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
			[Token(Token = "0x6001E83")]
			public virtual void SetValue(ref Length container, LengthUnit value) { }

		}

		[Token(Token = "0x2000404")]
		private class ValueProperty : Property<Length, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D8A")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D8B")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700089A")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E7C")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000899")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E7B")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3282980", Offset = "0x3281D80", Length = "0x64")]
			[Token(Token = "0x6001E7F")]
			public ValueProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E7C")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E7B")]
			public virtual string get_Name() { }

			[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
			[Token(Token = "0x6001E7D")]
			public virtual float GetValue(ref Length container) { }

			[Address(RVA = "0x3282950", Offset = "0x3281D50", Length = "0x24")]
			[Token(Token = "0x6001E7E")]
			public virtual void SetValue(ref Length container, float value) { }

		}


		[Address(RVA = "0x3274600", Offset = "0x3273A00", Length = "0x181")]
		[Token(Token = "0x6001E7A")]
		public PropertyBag() { }

	}

	[Token(Token = "0x2000402")]
	private enum Unit : int
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3,
	}

	[Token(Token = "0x4000D82")]
	internal const float k_MaxValue = 8388608; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000D83")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000D84")]
	private Unit m_Unit; //Field offset: 0x4

	[Token(Token = "0x17000898")]
	public LengthUnit unit
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6001E6C")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001E6D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000897")]
	public float value
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6001E6A")]
		 get { } //Length: 5
		[Address(RVA = "0x32725A0", Offset = "0x32719A0", Length = "0x24")]
		[Token(Token = "0x6001E6B")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x3272500", Offset = "0x3271900", Length = "0x2B")]
	[Token(Token = "0x6001E70")]
	public Length(float value) { }

	[Address(RVA = "0x32724D0", Offset = "0x32718D0", Length = "0x28")]
	[Token(Token = "0x6001E71")]
	public Length(float value, LengthUnit unit) { }

	[Address(RVA = "0x32724D0", Offset = "0x32718D0", Length = "0x28")]
	[Token(Token = "0x6001E72")]
	private Length(float value, Unit unit) { }

	[Address(RVA = "0x32721A0", Offset = "0x32715A0", Length = "0x18")]
	[Token(Token = "0x6001E68")]
	public static Length Auto() { }

	[Address(RVA = "0x32721F0", Offset = "0x32715F0", Length = "0xA6")]
	[Token(Token = "0x6001E77")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32721C0", Offset = "0x32715C0", Length = "0x2D")]
	[Token(Token = "0x6001E76")]
	public override bool Equals(Length other) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6001E6C")]
	public LengthUnit get_unit() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6001E6A")]
	public float get_value() { }

	[Address(RVA = "0x322F010", Offset = "0x322E410", Length = "0x1F")]
	[Token(Token = "0x6001E78")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32722A0", Offset = "0x32716A0", Length = "0x8")]
	[Token(Token = "0x6001E6E")]
	public bool IsAuto() { }

	[Address(RVA = "0x32722B0", Offset = "0x32716B0", Length = "0x8")]
	[Token(Token = "0x6001E6F")]
	public bool IsNone() { }

	[Address(RVA = "0x32722C0", Offset = "0x32716C0", Length = "0x18")]
	[Token(Token = "0x6001E69")]
	public static Length None() { }

	[Address(RVA = "0x322F500", Offset = "0x322E900", Length = "0x2A")]
	[Token(Token = "0x6001E74")]
	public static bool op_Equality(Length lhs, Length rhs) { }

	[Address(RVA = "0x3272530", Offset = "0x3271930", Length = "0x31")]
	[Token(Token = "0x6001E73")]
	public static Length op_Implicit(float value) { }

	[Address(RVA = "0x3272570", Offset = "0x3271970", Length = "0x2A")]
	[Token(Token = "0x6001E75")]
	public static bool op_Inequality(Length lhs, Length rhs) { }

	[Address(RVA = "0x32722E0", Offset = "0x32716E0", Length = "0x31")]
	[Token(Token = "0x6001E67")]
	public static Length Percent(float value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001E6D")]
	public void set_unit(LengthUnit value) { }

	[Address(RVA = "0x32725A0", Offset = "0x32719A0", Length = "0x24")]
	[Token(Token = "0x6001E6B")]
	public void set_value(float value) { }

	[Address(RVA = "0x3272320", Offset = "0x3271720", Length = "0x1AA")]
	[Token(Token = "0x6001E79")]
	public virtual string ToString() { }

}

