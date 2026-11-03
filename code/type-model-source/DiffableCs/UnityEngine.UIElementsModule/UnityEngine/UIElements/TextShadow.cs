namespace UnityEngine.UIElements;

[Token(Token = "0x20004C0")]
public struct TextShadow : IEquatable<TextShadow>
{
	[Token(Token = "0x20004C1")]
	public class PropertyBag : ContainerPropertyBag<TextShadow>
	{
		[Token(Token = "0x20004C3")]
		private class BlurRadiusProperty : Property<TextShadow, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400101D")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400101E")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170009AB")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002446")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170009AA")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002445")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A00B0", Offset = "0x329F4B0", Length = "0x64")]
			[Token(Token = "0x6002449")]
			public BlurRadiusProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002446")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002445")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
			[Token(Token = "0x6002447")]
			public virtual float GetValue(ref TextShadow container) { }

			[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
			[Token(Token = "0x6002448")]
			public virtual void SetValue(ref TextShadow container, float value) { }

		}

		[Token(Token = "0x20004C4")]
		private class ColorProperty : Property<TextShadow, Color>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400101F")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4001020")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170009AD")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600244B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170009AC")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600244A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A0140", Offset = "0x329F540", Length = "0x64")]
			[Token(Token = "0x600244E")]
			public ColorProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600244B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600244A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x32A0120", Offset = "0x329F520", Length = "0xC")]
			[Token(Token = "0x600244C")]
			public virtual Color GetValue(ref TextShadow container) { }

			[Address(RVA = "0x32A0130", Offset = "0x329F530", Length = "0x9")]
			[Token(Token = "0x600244D")]
			public virtual void SetValue(ref TextShadow container, Color value) { }

		}

		[Token(Token = "0x20004C2")]
		private class OffsetProperty : Property<TextShadow, Vector2>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400101B")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400101C")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170009A9")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002441")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170009A8")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6002440")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32A1A40", Offset = "0x32A0E40", Length = "0x64")]
			[Token(Token = "0x6002444")]
			public OffsetProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002441")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002440")]
			public virtual string get_Name() { }

			[Address(RVA = "0x32A1A20", Offset = "0x32A0E20", Length = "0x12")]
			[Token(Token = "0x6002442")]
			public virtual Vector2 GetValue(ref TextShadow container) { }

			[Address(RVA = "0x32681C0", Offset = "0x32675C0", Length = "0x4")]
			[Token(Token = "0x6002443")]
			public virtual void SetValue(ref TextShadow container, Vector2 value) { }

		}


		[Address(RVA = "0x32A1F70", Offset = "0x32A1370", Length = "0x210")]
		[Token(Token = "0x600243F")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001018")]
	public Vector2 offset; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001019")]
	public float blurRadius; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400101A")]
	public Color color; //Field offset: 0xC

	[Address(RVA = "0x32AE310", Offset = "0x32AD710", Length = "0xA2")]
	[Token(Token = "0x6002438")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32AE3C0", Offset = "0x32AD7C0", Length = "0xBC")]
	[Token(Token = "0x6002439")]
	public override bool Equals(TextShadow other) { }

	[Address(RVA = "0x32AE480", Offset = "0x32AD880", Length = "0xBF")]
	[Token(Token = "0x600243A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32AE540", Offset = "0x32AD940", Length = "0x13D")]
	[Token(Token = "0x600243E")]
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

	[Address(RVA = "0x32AE750", Offset = "0x32ADB50", Length = "0x30")]
	[Token(Token = "0x600243B")]
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	[Address(RVA = "0x32AE780", Offset = "0x32ADB80", Length = "0xB6")]
	[Token(Token = "0x600243C")]
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	[Address(RVA = "0x32AE680", Offset = "0x32ADA80", Length = "0xCB")]
	[Token(Token = "0x600243D")]
	public virtual string ToString() { }

}

