namespace UnityEngine.UIElements;

[Token(Token = "0x2000408")]
public struct MaterialDefinition : IEquatable<MaterialDefinition>
{
	[Token(Token = "0x2000409")]
	public class PropertyBag : ContainerPropertyBag<MaterialDefinition>
	{
		[Token(Token = "0x200040A")]
		private class MaterialProperty : Property<MaterialDefinition, Material>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000D99")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000D9A")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700089F")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E9C")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700089E")]
			public virtual string Name
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6001E9B")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x3273BF0", Offset = "0x3272FF0", Length = "0x64")]
			[Token(Token = "0x6001E9F")]
			public MaterialProperty() { }

			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E9C")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001E9B")]
			public virtual string get_Name() { }

			[Address(RVA = "0x3238010", Offset = "0x3237410", Length = "0x6")]
			[Token(Token = "0x6001E9D")]
			public virtual Material GetValue(ref MaterialDefinition container) { }

			[Address(RVA = "0x3273BE0", Offset = "0x3272FE0", Length = "0xE")]
			[Token(Token = "0x6001E9E")]
			public virtual void SetValue(ref MaterialDefinition container, Material value) { }

		}


		[Address(RVA = "0x32749A0", Offset = "0x3273DA0", Length = "0xF2")]
		[Token(Token = "0x6001E9A")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000D97")]
	private Material m_Material; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000D98")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<MaterialPropertyValue> propertyValues; //Field offset: 0x8

	[Token(Token = "0x1700089D")]
	public Material material
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6001E8D")]
		 get { } //Length: 6
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6001E8E")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x3273350", Offset = "0x3272750", Length = "0xA6")]
	[Token(Token = "0x6001E8F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal MaterialDefinition(MaterialDefinition other) { }

	[Address(RVA = "0x3272A80", Offset = "0x3271E80", Length = "0x328")]
	[Token(Token = "0x6001E92")]
	internal MaterialPropertyBlock BuildPropertyBlock() { }

	[Address(RVA = "0x3272DB0", Offset = "0x32721B0", Length = "0x2B")]
	[Token(Token = "0x6001E96")]
	public override bool Equals(MaterialDefinition other) { }

	[Address(RVA = "0x3272DE0", Offset = "0x32721E0", Length = "0x9A")]
	[Token(Token = "0x6001E97")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3237A00", Offset = "0x3236E00", Length = "0x38")]
	[Token(Token = "0x6001E90")]
	public static MaterialDefinition FromMaterial(Material m) { }

	[Address(RVA = "0x3272E80", Offset = "0x3272280", Length = "0x141")]
	[Token(Token = "0x6001E91")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static MaterialDefinition FromObject(object obj) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001E8D")]
	public Material get_material() { }

	[Address(RVA = "0x3272FD0", Offset = "0x32723D0", Length = "0x1C2")]
	[Token(Token = "0x6001E98")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3273400", Offset = "0x3272800", Length = "0x1BD")]
	[Token(Token = "0x6001E93")]
	public static bool op_Equality(MaterialDefinition lhs, MaterialDefinition rhs) { }

	[Address(RVA = "0x3237A00", Offset = "0x3236E00", Length = "0x38")]
	[Token(Token = "0x6001E95")]
	public static MaterialDefinition op_Implicit(Material m) { }

	[Address(RVA = "0x32735C0", Offset = "0x32729C0", Length = "0x2D")]
	[Token(Token = "0x6001E94")]
	public static bool op_Inequality(MaterialDefinition lhs, MaterialDefinition rhs) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6001E8E")]
	public void set_material(Material value) { }

	[Address(RVA = "0x32731A0", Offset = "0x32725A0", Length = "0x1AC")]
	[Token(Token = "0x6001E99")]
	public virtual string ToString() { }

}

