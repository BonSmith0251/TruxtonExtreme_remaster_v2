namespace UnityEngine.UIElements;

[Token(Token = "0x200043C")]
public struct Translate : IEquatable<Translate>
{
	[Token(Token = "0x200043D")]
	public class PropertyBag : ContainerPropertyBag<Translate>
	{
		[Token(Token = "0x200043E")]
		private class XProperty : Property<Translate, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DF8")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DF9")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008F0")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002070")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008EF")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600206F")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x329D420", Offset = "0x329C820", Length = "0x64")]
			[Token(Token = "0x6002073")]
			public XProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002070")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600206F")]
			public virtual string get_Name() { }

			[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
			[Token(Token = "0x6002071")]
			public virtual Length GetValue(ref Translate container) { }

			[Address(RVA = "0x32681C0", Offset = "0x32675C0", Length = "0x4")]
			[Token(Token = "0x6002072")]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		[Token(Token = "0x200043F")]
		private class YProperty : Property<Translate, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DFA")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DFB")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008F2")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002075")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008F1")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002074")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x329D490", Offset = "0x329C890", Length = "0x64")]
			[Token(Token = "0x6002078")]
			public YProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002075")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002074")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3284E30", Offset = "0x3284230", Length = "0x5")]
			[Token(Token = "0x6002076")]
			public virtual Length GetValue(ref Translate container) { }

			[Address(RVA = "0x3284E40", Offset = "0x3284240", Length = "0x5")]
			[Token(Token = "0x6002077")]
			public virtual void SetValue(ref Translate container, Length value) { }

		}

		[Token(Token = "0x2000440")]
		private class ZProperty : Property<Translate, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000DFC")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000DFD")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008F4")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600207A")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008F3")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002079")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x329D500", Offset = "0x329C900", Length = "0xEB")]
			[Token(Token = "0x600207D")]
			public ZProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600207A")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002079")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3284EC0", Offset = "0x32842C0", Length = "0x6")]
			[Token(Token = "0x600207B")]
			public virtual float GetValue(ref Translate container) { }

			[Address(RVA = "0x3284ED0", Offset = "0x32842D0", Length = "0x6")]
			[Token(Token = "0x600207C")]
			public virtual void SetValue(ref Translate container, float value) { }

		}


		[Address(RVA = "0x3286FB0", Offset = "0x32863B0", Length = "0x204")]
		[Token(Token = "0x600206E")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DF4")]
	private Length m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DF5")]
	private Length m_Y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000DF6")]
	private float m_Z; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000DF7")]
	private bool m_isNone; //Field offset: 0x14

	[Token(Token = "0x170008EC")]
	public Length x
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6002062")]
		 get { } //Length: 4
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6002063")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008ED")]
	public Length y
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6002064")]
		 get { } //Length: 5
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[Token(Token = "0x6002065")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170008EE")]
	public float z
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6002066")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6002067")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x32802C0", Offset = "0x327F6C0", Length = "0x11")]
	[Token(Token = "0x600205E")]
	public Translate(Length x, Length y, float z) { }

	[Address(RVA = "0x3280250", Offset = "0x327F650", Length = "0x6F")]
	[Token(Token = "0x600205F")]
	internal Translate(Vector3 v) { }

	[Address(RVA = "0x327FFA0", Offset = "0x327F3A0", Length = "0x41")]
	[Token(Token = "0x600206A")]
	public override bool Equals(Translate other) { }

	[Address(RVA = "0x327FFF0", Offset = "0x327F3F0", Length = "0xB0")]
	[Token(Token = "0x600206B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002062")]
	public Length get_x() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6002064")]
	public Length get_y() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6002066")]
	public float get_z() { }

	[Address(RVA = "0x327F010", Offset = "0x327E410", Length = "0x71")]
	[Token(Token = "0x600206C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32800B0", Offset = "0x327F4B0", Length = "0x29")]
	[Token(Token = "0x6002061")]
	public static Translate None() { }

	[Address(RVA = "0x32802E0", Offset = "0x327F6E0", Length = "0x104")]
	[Token(Token = "0x6002068")]
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	[Address(RVA = "0x32803F0", Offset = "0x327F7F0", Length = "0xD4")]
	[Token(Token = "0x6002060")]
	public static Translate op_Implicit(Vector3 v) { }

	[Address(RVA = "0x32804D0", Offset = "0x327F8D0", Length = "0x43")]
	[Token(Token = "0x6002069")]
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6002063")]
	public void set_x(Length value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[Token(Token = "0x6002065")]
	public void set_y(Length value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6002067")]
	public void set_z(float value) { }

	[Address(RVA = "0x32800E0", Offset = "0x327F4E0", Length = "0x165")]
	[Token(Token = "0x600206D")]
	public virtual string ToString() { }

}

