namespace UnityEngine.UIElements;

[Token(Token = "0x200040F")]
public struct Rotate : IEquatable<Rotate>
{
	[Token(Token = "0x2000410")]
	public class PropertyBag : ContainerPropertyBag<Rotate>
	{
		[Token(Token = "0x2000411")]
		private class AngleProperty : Property<Rotate, Angle>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DA3")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DA4")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008A8")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EC8")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A7")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EC7")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32681D0", Offset = "0x32675D0", Length = "0x64")]
			[Token(Token = "0x6001ECB")]
			public AngleProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EC8")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EC7")]
			public virtual string get_Name() { }

			[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
			[Token(Token = "0x6001EC9")]
			public virtual Angle GetValue(ref Rotate container) { }

			[Address(RVA = "0x32681C0", Offset = "0x32675C0", Length = "0x4")]
			[Token(Token = "0x6001ECA")]
			public virtual void SetValue(ref Rotate container, Angle value) { }

		}

		[Token(Token = "0x2000412")]
		private class AxisProperty : Property<Rotate, Vector3>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DA5")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DA6")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008AA")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001ECD")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A9")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001ECC")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32684F0", Offset = "0x32678F0", Length = "0x64")]
			[Token(Token = "0x6001ED0")]
			public AxisProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001ECD")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001ECC")]
			public virtual string get_Name() { }

			[Address(RVA = "0x32684B0", Offset = "0x32678B0", Length = "0x15")]
			[Token(Token = "0x6001ECE")]
			public virtual Vector3 GetValue(ref Rotate container) { }

			[Address(RVA = "0x32684D0", Offset = "0x32678D0", Length = "0x12")]
			[Token(Token = "0x6001ECF")]
			public virtual void SetValue(ref Rotate container, Vector3 value) { }

		}


		[Address(RVA = "0x3274AA0", Offset = "0x3273EA0", Length = "0x181")]
		[Token(Token = "0x6001EC6")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DA0")]
	private Angle m_Angle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DA1")]
	private Vector3 m_Axis; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000DA2")]
	private bool m_IsNone; //Field offset: 0x14

	[Token(Token = "0x170008A5")]
	public Angle angle
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001EBB")]
		 get { } //Length: 4
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6001EBC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008A6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Vector3 axis
	{
		[Address(RVA = "0xAEF350", Offset = "0xAEE750", Length = "0x13")]
		[Token(Token = "0x6001EBD")]
		internal get { } //Length: 19
		[Address(RVA = "0x3278340", Offset = "0x3277740", Length = "0x10")]
		[Token(Token = "0x6001EBE")]
		internal set { } //Length: 16
	}

	[Address(RVA = "0x3278160", Offset = "0x3277560", Length = "0x19")]
	[Token(Token = "0x6001EB6")]
	public Rotate(Angle angle, Vector3 axis) { }

	[Address(RVA = "0x3278180", Offset = "0x3277580", Length = "0x50")]
	[Token(Token = "0x6001EB7")]
	public Rotate(Angle angle) { }

	[Address(RVA = "0x32780A0", Offset = "0x32774A0", Length = "0xB5")]
	[Token(Token = "0x6001EB8")]
	public Rotate(Quaternion quaternion) { }

	[Address(RVA = "0x3277D30", Offset = "0x3277130", Length = "0x41")]
	[Token(Token = "0x6001EC1")]
	public override bool Equals(Rotate other) { }

	[Address(RVA = "0x3277C70", Offset = "0x3277070", Length = "0xB0")]
	[Token(Token = "0x6001EC2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001EBB")]
	public Angle get_angle() { }

	[Address(RVA = "0xAEF350", Offset = "0xAEE750", Length = "0x13")]
	[Token(Token = "0x6001EBD")]
	internal Vector3 get_axis() { }

	[Address(RVA = "0x3277D80", Offset = "0x3277180", Length = "0xE2")]
	[Token(Token = "0x6001EC3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3277E70", Offset = "0x3277270", Length = "0xBB")]
	[Token(Token = "0x6001EB9")]
	internal static Rotate Initial() { }

	[Address(RVA = "0x3277F30", Offset = "0x3277330", Length = "0x4B")]
	[Token(Token = "0x6001EBA")]
	public static Rotate None() { }

	[Address(RVA = "0x32781D0", Offset = "0x32775D0", Length = "0x120")]
	[Token(Token = "0x6001EBF")]
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	[Address(RVA = "0x32782F0", Offset = "0x32776F0", Length = "0x43")]
	[Token(Token = "0x6001EC0")]
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001EBC")]
	public void set_angle(Angle value) { }

	[Address(RVA = "0x3278340", Offset = "0x3277740", Length = "0x10")]
	[Token(Token = "0x6001EBE")]
	internal void set_axis(Vector3 value) { }

	[Address(RVA = "0x3277F80", Offset = "0x3277380", Length = "0x8C")]
	[Token(Token = "0x6001EC5")]
	internal Quaternion ToQuaternion() { }

	[Address(RVA = "0x3278010", Offset = "0x3277410", Length = "0x81")]
	[Token(Token = "0x6001EC4")]
	public virtual string ToString() { }

}

