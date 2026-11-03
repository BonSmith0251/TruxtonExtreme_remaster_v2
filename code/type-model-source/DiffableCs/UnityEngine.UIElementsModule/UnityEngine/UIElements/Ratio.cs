namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200040B")]
public struct Ratio : IEquatable<Ratio>
{
	[Token(Token = "0x200040C")]
	public class PropertyBag : ContainerPropertyBag<Ratio>
	{
		[Token(Token = "0x200040E")]
		private class AutoProperty : Property<Ratio, Boolean>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D9E")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D9F")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008A4")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EB2")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A3")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EB1")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3268440", Offset = "0x3267840", Length = "0x64")]
			[Token(Token = "0x6001EB5")]
			public AutoProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EB2")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EB1")]
			public virtual string get_Name() { }

			[Address(RVA = "0x32683E0", Offset = "0x32677E0", Length = "0x11")]
			[Token(Token = "0x6001EB3")]
			public virtual bool GetValue(ref Ratio container) { }

			[Address(RVA = "0x3268400", Offset = "0x3267800", Length = "0x3E")]
			[Token(Token = "0x6001EB4")]
			public virtual void SetValue(ref Ratio container, bool value) { }

		}

		[Token(Token = "0x200040D")]
		private class ValueProperty : Property<Ratio, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D9C")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D9D")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170008A2")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EAD")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170008A1")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001EAC")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32829F0", Offset = "0x3281DF0", Length = "0x64")]
			[Token(Token = "0x6001EB0")]
			public ValueProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EAD")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001EAC")]
			public virtual string get_Name() { }

			[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
			[Token(Token = "0x6001EAE")]
			public virtual float GetValue(ref Ratio container) { }

			[Address(RVA = "0x3282910", Offset = "0x3281D10", Length = "0x3E")]
			[Token(Token = "0x6001EAF")]
			public virtual void SetValue(ref Ratio container, float value) { }

		}


		[Address(RVA = "0x3274C30", Offset = "0x3274030", Length = "0x181")]
		[Token(Token = "0x6001EAB")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D9B")]
	private readonly float m_Value; //Field offset: 0x0

	[Token(Token = "0x170008A0")]
	public float value
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6001EA1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6001EA0")]
	public Ratio(float value) { }

	[Address(RVA = "0x3275640", Offset = "0x3274A40", Length = "0x33")]
	[Token(Token = "0x6001EA7")]
	public override bool Equals(Ratio other) { }

	[Address(RVA = "0x3275590", Offset = "0x3274990", Length = "0xAC")]
	[Token(Token = "0x6001EA8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6001EA1")]
	public float get_value() { }

	[Address(RVA = "0x3275680", Offset = "0x3274A80", Length = "0x16")]
	[Token(Token = "0x6001EA9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32756A0", Offset = "0x3274AA0", Length = "0x11")]
	[Token(Token = "0x6001EA2")]
	public bool IsAuto() { }

	[Address(RVA = "0x3275760", Offset = "0x3274B60", Length = "0x33")]
	[Token(Token = "0x6001EA5")]
	public static bool op_Equality(Ratio lhs, Ratio rhs) { }

	[Address(RVA = "0x32757A0", Offset = "0x3274BA0", Length = "0x7")]
	[Token(Token = "0x6001EA3")]
	public static Ratio op_Implicit(float value) { }

	[Address(RVA = "0x1F8D390", Offset = "0x1F8C790", Length = "0x5")]
	[Token(Token = "0x6001EA4")]
	public static float op_Implicit(Ratio value) { }

	[Address(RVA = "0x32757B0", Offset = "0x3274BB0", Length = "0x36")]
	[Token(Token = "0x6001EA6")]
	public static bool op_Inequality(Ratio lhs, Ratio rhs) { }

	[Address(RVA = "0x32756C0", Offset = "0x3274AC0", Length = "0x94")]
	[Token(Token = "0x6001EAA")]
	public virtual string ToString() { }

}

