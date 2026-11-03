namespace UnityEngine.UIElements;

[Token(Token = "0x20002ED")]
public struct Angle : IEquatable<Angle>
{
	[Token(Token = "0x20002EF")]
	public class PropertyBag : ContainerPropertyBag<Angle>
	{
		[Token(Token = "0x20002F1")]
		private class UnitProperty : Property<Angle, AngleUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BF4")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BF5")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003FF")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001478")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003FE")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001477")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3246B30", Offset = "0x3245F30", Length = "0x64")]
			[Token(Token = "0x600147B")]
			public UnitProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001478")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001477")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3246A90", Offset = "0x3245E90", Length = "0x43")]
			[Token(Token = "0x6001479")]
			public virtual AngleUnit GetValue(ref Angle container) { }

			[Address(RVA = "0x3246AE0", Offset = "0x3245EE0", Length = "0x4F")]
			[Token(Token = "0x600147A")]
			public virtual void SetValue(ref Angle container, AngleUnit value) { }

		}

		[Token(Token = "0x20002F0")]
		private class ValueProperty : Property<Angle, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BF2")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BF3")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003FD")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001473")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003FC")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001472")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3246C50", Offset = "0x3246050", Length = "0x64")]
			[Token(Token = "0x6001476")]
			public ValueProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001473")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001472")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3246BA0", Offset = "0x3245FA0", Length = "0x44")]
			[Token(Token = "0x6001474")]
			public virtual float GetValue(ref Angle container) { }

			[Address(RVA = "0x3246BF0", Offset = "0x3245FF0", Length = "0x51")]
			[Token(Token = "0x6001475")]
			public virtual void SetValue(ref Angle container, float value) { }

		}


		[Address(RVA = "0x32451E0", Offset = "0x32445E0", Length = "0x181")]
		[Token(Token = "0x6001471")]
		public PropertyBag() { }

	}

	[Token(Token = "0x20002EE")]
	private enum Unit : int
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3,
		None = 4,
	}

	[Token(Token = "0x4000BE9")]
	private static readonly Dictionary<String, AngleUnit> s_AngleUnitLookup; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000BEA")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000BEB")]
	private Unit m_Unit; //Field offset: 0x4

	[Token(Token = "0x170003FB")]
	public AngleUnit unit
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6001463")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001464")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003FA")]
	public float value
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6001461")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6001462")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x322F2F0", Offset = "0x322E6F0", Length = "0x1AB")]
	[Token(Token = "0x6001470")]
	private static Angle() { }

	[Address(RVA = "0x322F4A0", Offset = "0x322E8A0", Length = "0x60")]
	[Token(Token = "0x6001466")]
	public Angle(float value, AngleUnit unit) { }

	[Address(RVA = "0x12F1440", Offset = "0x12F0840", Length = "0x9")]
	[Token(Token = "0x6001467")]
	private Angle(float value, Unit unit) { }

	[Address(RVA = "0x322EEE0", Offset = "0x322E2E0", Length = "0x9E")]
	[Token(Token = "0x600146D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x322EF80", Offset = "0x322E380", Length = "0x85")]
	[Token(Token = "0x600146C")]
	public override bool Equals(Angle other) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6001463")]
	public AngleUnit get_unit() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6001461")]
	public float get_value() { }

	[Address(RVA = "0x322F010", Offset = "0x322E410", Length = "0x1F")]
	[Token(Token = "0x600146E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x322F030", Offset = "0x322E430", Length = "0x8")]
	[Token(Token = "0x6001465")]
	internal bool IsNone() { }

	[Address(RVA = "0x322F040", Offset = "0x322E440", Length = "0x16")]
	[Token(Token = "0x6001460")]
	internal static Angle None() { }

	[Address(RVA = "0x322F500", Offset = "0x322E900", Length = "0x2A")]
	[Token(Token = "0x600146A")]
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	[Address(RVA = "0x322F530", Offset = "0x322E930", Length = "0x5A")]
	[Token(Token = "0x6001469")]
	public static Angle op_Implicit(float value) { }

	[Address(RVA = "0x322F590", Offset = "0x322E990", Length = "0x87")]
	[Token(Token = "0x600146B")]
	public static bool op_Inequality(Angle lhs, Angle rhs) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001464")]
	public void set_unit(AngleUnit value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6001462")]
	public void set_value(float value) { }

	[Address(RVA = "0x322F060", Offset = "0x322E460", Length = "0x56")]
	[Token(Token = "0x6001468")]
	public float ToDegrees() { }

	[Address(RVA = "0x322F0C0", Offset = "0x322E4C0", Length = "0x222")]
	[Token(Token = "0x600146F")]
	public virtual string ToString() { }

}

