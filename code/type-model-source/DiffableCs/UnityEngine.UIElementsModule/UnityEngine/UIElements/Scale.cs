namespace UnityEngine.UIElements;

[Token(Token = "0x2000413")]
public struct Scale : IEquatable<Scale>
{
	[Token(Token = "0x2000414")]
	public class PropertyBag : ContainerPropertyBag<Scale>
	{
		[Token(Token = "0x2000415")]
		private class ValueProperty : Property<Scale, Vector3>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DA9")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DAA")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008AD")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EDE")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008AC")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EDD")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3282AD0", Offset = "0x3281ED0", Length = "0x64")]
			[Token(Token = "0x6001EE1")]
			public ValueProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EDE")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EDD")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1BBE240", Offset = "0x1BBD640", Length = "0x14")]
			[Token(Token = "0x6001EDF")]
			public virtual Vector3 GetValue(ref Scale container) { }

			[Address(RVA = "0x3141840", Offset = "0x3140C40", Length = "0x11")]
			[Token(Token = "0x6001EE0")]
			public virtual void SetValue(ref Scale container, Vector3 value) { }

		}


		[Address(RVA = "0x3274DC0", Offset = "0x32741C0", Length = "0xF2")]
		[Token(Token = "0x6001EDC")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DA7")]
	private Vector3 m_Scale; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000DA8")]
	private bool m_IsNone; //Field offset: 0xC

	[Token(Token = "0x170008AB")]
	public Vector3 value
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[Token(Token = "0x6001ED4")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x6001ED5")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x2CAB470", Offset = "0x2CAA870", Length = "0x13")]
	[Token(Token = "0x6001ED1")]
	public Scale(Vector3 scale) { }

	[Address(RVA = "0x32784C0", Offset = "0x32778C0", Length = "0x4E")]
	[Token(Token = "0x6001ED8")]
	public override bool Equals(Scale other) { }

	[Address(RVA = "0x3278510", Offset = "0x3277910", Length = "0xC9")]
	[Token(Token = "0x6001ED9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x6001ED4")]
	public Vector3 get_value() { }

	[Address(RVA = "0x32785E0", Offset = "0x32779E0", Length = "0x57")]
	[Token(Token = "0x6001EDA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3278640", Offset = "0x3277A40", Length = "0x67")]
	[Token(Token = "0x6001ED2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Scale Initial() { }

	[Address(RVA = "0x32786B0", Offset = "0x3277AB0", Length = "0x7C")]
	[Token(Token = "0x6001ED3")]
	public static Scale None() { }

	[Address(RVA = "0x3278740", Offset = "0x3277B40", Length = "0x51")]
	[Token(Token = "0x6001ED6")]
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	[Address(RVA = "0x32787A0", Offset = "0x3277BA0", Length = "0x4E")]
	[Token(Token = "0x6001ED7")]
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x6001ED5")]
	public void set_value(Vector3 value) { }

	[Address(RVA = "0x3278730", Offset = "0x3277B30", Length = "0x9")]
	[Token(Token = "0x6001EDB")]
	public virtual string ToString() { }

}

