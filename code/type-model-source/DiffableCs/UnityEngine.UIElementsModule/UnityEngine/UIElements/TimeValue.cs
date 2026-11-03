namespace UnityEngine.UIElements;

[Token(Token = "0x2000433")]
public struct TimeValue : IEquatable<TimeValue>
{
	[Token(Token = "0x2000434")]
	public class PropertyBag : ContainerPropertyBag<TimeValue>
	{
		[Token(Token = "0x2000436")]
		private class UnitProperty : Property<TimeValue, TimeUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DE9")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DEA")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008E2")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600203B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008E1")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600203A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32806F0", Offset = "0x327FAF0", Length = "0x64")]
			[Token(Token = "0x600203E")]
			public UnitProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600203B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600203A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
			[Token(Token = "0x600203C")]
			public virtual TimeUnit GetValue(ref TimeValue container) { }

			[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
			[Token(Token = "0x600203D")]
			public virtual void SetValue(ref TimeValue container, TimeUnit value) { }

		}

		[Token(Token = "0x2000435")]
		private class ValueProperty : Property<TimeValue, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DE7")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DE8")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008E0")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002036")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008DF")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002035")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3282A60", Offset = "0x3281E60", Length = "0x64")]
			[Token(Token = "0x6002039")]
			public ValueProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002036")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002035")]
			public virtual string get_Name() { }

			[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
			[Token(Token = "0x6002037")]
			public virtual float GetValue(ref TimeValue container) { }

			[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
			[Token(Token = "0x6002038")]
			public virtual void SetValue(ref TimeValue container, float value) { }

		}


		[Address(RVA = "0x3274EC0", Offset = "0x32742C0", Length = "0x181")]
		[Token(Token = "0x6002034")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DE5")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000DE6")]
	private TimeUnit m_Unit; //Field offset: 0x4

	[Token(Token = "0x170008DE")]
	public TimeUnit unit
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6002029")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x600202A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008DD")]
	public float value
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6002027")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6002028")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x3279F30", Offset = "0x3279330", Length = "0xC")]
	[Token(Token = "0x600202B")]
	public TimeValue(float value) { }

	[Address(RVA = "0x12F1440", Offset = "0x12F0840", Length = "0x9")]
	[Token(Token = "0x600202C")]
	public TimeValue(float value, TimeUnit unit) { }

	[Address(RVA = "0x32721C0", Offset = "0x32715C0", Length = "0x2D")]
	[Token(Token = "0x6002030")]
	public override bool Equals(TimeValue other) { }

	[Address(RVA = "0x327E1F0", Offset = "0x327D5F0", Length = "0xA6")]
	[Token(Token = "0x6002031")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6002029")]
	public TimeUnit get_unit() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6002027")]
	public float get_value() { }

	[Address(RVA = "0x322F010", Offset = "0x322E410", Length = "0x1F")]
	[Token(Token = "0x6002032")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x322F500", Offset = "0x322E900", Length = "0x2A")]
	[Token(Token = "0x600202E")]
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	[Address(RVA = "0x3279F90", Offset = "0x3279390", Length = "0x14")]
	[Token(Token = "0x600202D")]
	public static TimeValue op_Implicit(float value) { }

	[Address(RVA = "0x3272570", Offset = "0x3271970", Length = "0x2A")]
	[Token(Token = "0x600202F")]
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x600202A")]
	public void set_unit(TimeUnit value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6002028")]
	public void set_value(float value) { }

	[Address(RVA = "0x327E2A0", Offset = "0x327D6A0", Length = "0xE0")]
	[Token(Token = "0x6002033")]
	public virtual string ToString() { }

}

