namespace UnityEngine.UIElements;

[Token(Token = "0x20002F2")]
public struct Background : IEquatable<Background>
{
	[Token(Token = "0x20002F3")]
	public class PropertyBag : ContainerPropertyBag<Background>
	{
		[Token(Token = "0x20002F6")]
		private class RenderTextureProperty : Property<Background, RenderTexture>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BFE")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BFF")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000409")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600149D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000408")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600149C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x32454A0", Offset = "0x32448A0", Length = "0x64")]
			[Token(Token = "0x60014A0")]
			public RenderTextureProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600149D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600149C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3245470", Offset = "0x3244870", Length = "0x7")]
			[Token(Token = "0x600149E")]
			public virtual RenderTexture GetValue(ref Background container) { }

			[Address(RVA = "0x3245480", Offset = "0x3244880", Length = "0x11")]
			[Token(Token = "0x600149F")]
			public virtual void SetValue(ref Background container, RenderTexture value) { }

		}

		[Token(Token = "0x20002F5")]
		private class SpriteProperty : Property<Background, Sprite>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BFC")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BFD")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000407")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001498")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000406")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001497")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3245810", Offset = "0x3244C10", Length = "0x64")]
			[Token(Token = "0x600149B")]
			public SpriteProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001498")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001497")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3237860", Offset = "0x3236C60", Length = "0x7")]
			[Token(Token = "0x6001499")]
			public virtual Sprite GetValue(ref Background container) { }

			[Address(RVA = "0x32457F0", Offset = "0x3244BF0", Length = "0x11")]
			[Token(Token = "0x600149A")]
			public virtual void SetValue(ref Background container, Sprite value) { }

		}

		[Token(Token = "0x20002F4")]
		private class TextureProperty : Property<Background, Texture2D>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BFA")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BFB")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000405")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001493")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000404")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001492")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3245970", Offset = "0x3244D70", Length = "0x64")]
			[Token(Token = "0x6001496")]
			public TextureProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001493")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001492")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3238010", Offset = "0x3237410", Length = "0x6")]
			[Token(Token = "0x6001494")]
			public virtual Texture2D GetValue(ref Background container) { }

			[Address(RVA = "0x3245950", Offset = "0x3244D50", Length = "0x11")]
			[Token(Token = "0x6001495")]
			public virtual void SetValue(ref Background container, Texture2D value) { }

		}

		[Token(Token = "0x20002F7")]
		private class VectorImageProperty : Property<Background, VectorImage>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000C00")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000C01")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700040B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60014A2")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700040A")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60014A1")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3246CF0", Offset = "0x32460F0", Length = "0x57B")]
			[Token(Token = "0x60014A5")]
			public VectorImageProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60014A2")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60014A1")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3246CC0", Offset = "0x32460C0", Length = "0x7")]
			[Token(Token = "0x60014A3")]
			public virtual VectorImage GetValue(ref Background container) { }

			[Address(RVA = "0x3246CD0", Offset = "0x32460D0", Length = "0x11")]
			[Token(Token = "0x60014A4")]
			public virtual void SetValue(ref Background container, VectorImage value) { }

		}


		[Address(RVA = "0x3244DB0", Offset = "0x32441B0", Length = "0x29F")]
		[Token(Token = "0x6001491")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000BF6")]
	private Texture2D m_Texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000BF7")]
	private Sprite m_Sprite; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000BF8")]
	private RenderTexture m_RenderTexture; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000BF9")]
	private VectorImage m_VectorImage; //Field offset: 0x18

	[Token(Token = "0x17000402")]
	public RenderTexture renderTexture
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6001480")]
		 get { } //Length: 7
		[Address(RVA = "0x3231360", Offset = "0x3230760", Length = "0xA9")]
		[Token(Token = "0x6001481")]
		 set { } //Length: 169
	}

	[Token(Token = "0x17000401")]
	public Sprite sprite
	{
		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x600147E")]
		 get { } //Length: 7
		[Address(RVA = "0x3231410", Offset = "0x3230810", Length = "0xA9")]
		[Token(Token = "0x600147F")]
		 set { } //Length: 169
	}

	[Token(Token = "0x17000400")]
	public Texture2D texture
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x600147C")]
		 get { } //Length: 6
		[Address(RVA = "0x32314C0", Offset = "0x32308C0", Length = "0xA8")]
		[Token(Token = "0x600147D")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000403")]
	public VectorImage vectorImage
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6001482")]
		 get { } //Length: 7
		[Address(RVA = "0x3231570", Offset = "0x3230970", Length = "0xA9")]
		[Token(Token = "0x6001483")]
		 set { } //Length: 169
	}

	[Address(RVA = "0x3230490", Offset = "0x322F890", Length = "0x195")]
	[Token(Token = "0x600148E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3230630", Offset = "0x322FA30", Length = "0xFF")]
	[Token(Token = "0x600148D")]
	public override bool Equals(Background other) { }

	[Address(RVA = "0x3230730", Offset = "0x322FB30", Length = "0x392")]
	[Token(Token = "0x6001488")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static Background FromObject(object obj) { }

	[Address(RVA = "0x3230AD0", Offset = "0x322FED0", Length = "0xDC")]
	[Token(Token = "0x6001485")]
	public static Background FromRenderTexture(RenderTexture rt) { }

	[Address(RVA = "0x3230BB0", Offset = "0x322FFB0", Length = "0xDC")]
	[Token(Token = "0x6001486")]
	public static Background FromSprite(Sprite s) { }

	[Address(RVA = "0x3230C90", Offset = "0x3230090", Length = "0xDC")]
	[Token(Token = "0x6001484")]
	public static Background FromTexture2D(Texture2D t) { }

	[Address(RVA = "0x3230D70", Offset = "0x3230170", Length = "0xDC")]
	[Token(Token = "0x6001487")]
	public static Background FromVectorImage(VectorImage vi) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6001480")]
	public RenderTexture get_renderTexture() { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x600147E")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x600147C")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6001482")]
	public VectorImage get_vectorImage() { }

	[Address(RVA = "0x3230E50", Offset = "0x3230250", Length = "0xCA")]
	[Token(Token = "0x600148F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3230F20", Offset = "0x3230320", Length = "0xE8")]
	[Token(Token = "0x6001489")]
	public bool IsEmpty() { }

	[Address(RVA = "0x3231140", Offset = "0x3230540", Length = "0xE6")]
	[Token(Token = "0x600148A")]
	public static bool op_Equality(Background lhs, Background rhs) { }

	[Address(RVA = "0x3231230", Offset = "0x3230630", Length = "0x37")]
	[Token(Token = "0x600148C")]
	public static Background op_Implicit(Texture2D v) { }

	[Address(RVA = "0x3231270", Offset = "0x3230670", Length = "0xEA")]
	[Token(Token = "0x600148B")]
	public static bool op_Inequality(Background lhs, Background rhs) { }

	[Address(RVA = "0x3231360", Offset = "0x3230760", Length = "0xA9")]
	[Token(Token = "0x6001481")]
	public void set_renderTexture(RenderTexture value) { }

	[Address(RVA = "0x3231410", Offset = "0x3230810", Length = "0xA9")]
	[Token(Token = "0x600147F")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x32314C0", Offset = "0x32308C0", Length = "0xA8")]
	[Token(Token = "0x600147D")]
	public void set_texture(Texture2D value) { }

	[Address(RVA = "0x3231570", Offset = "0x3230970", Length = "0xA9")]
	[Token(Token = "0x6001483")]
	public void set_vectorImage(VectorImage value) { }

	[Address(RVA = "0x3231010", Offset = "0x3230410", Length = "0x12F")]
	[Token(Token = "0x6001490")]
	public virtual string ToString() { }

}

