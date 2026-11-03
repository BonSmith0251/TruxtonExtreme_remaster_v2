namespace UnityEngine.UIElements;

[Token(Token = "0x20002FF")]
public struct EasingFunction : IEquatable<EasingFunction>
{
	[Token(Token = "0x2000300")]
	public class PropertyBag : ContainerPropertyBag<EasingFunction>
	{
		[Token(Token = "0x2000301")]
		private class ModeProperty : Property<EasingFunction, EasingMode>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C43")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C44")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000469")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001579")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000468")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001578")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3244D40", Offset = "0x3244140", Length = "0x64")]
			[Token(Token = "0x600157C")]
			public ModeProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001579")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001578")]
			public virtual string get_Name() { }

			[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
			[Token(Token = "0x600157A")]
			public virtual EasingMode GetValue(ref EasingFunction container) { }

			[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
			[Token(Token = "0x600157B")]
			public virtual void SetValue(ref EasingFunction container, EasingMode value) { }

		}


		[Address(RVA = "0x3245370", Offset = "0x3244770", Length = "0xF2")]
		[Token(Token = "0x6001577")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C42")]
	private EasingMode m_Mode; //Field offset: 0x0

	[Token(Token = "0x17000467")]
	public EasingMode mode
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600156E")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600156F")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001570")]
	public EasingFunction(EasingMode mode) { }

	[Address(RVA = "0x32357F0", Offset = "0x3234BF0", Length = "0x8")]
	[Token(Token = "0x6001573")]
	public override bool Equals(EasingFunction other) { }

	[Address(RVA = "0x3235760", Offset = "0x3234B60", Length = "0x84")]
	[Token(Token = "0x6001574")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600156E")]
	public EasingMode get_mode() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001576")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x306F930", Offset = "0x306ED30", Length = "0x8")]
	[Token(Token = "0x6001572")]
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x6001571")]
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600156F")]
	public void set_mode(EasingMode value) { }

	[Address(RVA = "0x3235800", Offset = "0x3234C00", Length = "0x52")]
	[Token(Token = "0x6001575")]
	public virtual string ToString() { }

}

