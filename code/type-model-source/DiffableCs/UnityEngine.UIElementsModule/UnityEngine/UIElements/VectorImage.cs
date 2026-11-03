namespace UnityEngine.UIElements;

[Token(Token = "0x2000536")]
public sealed class VectorImage : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400113D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
	internal int version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400113E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule", "UnityEditor.VectorGraphicsModule"})]
	internal Texture2D atlas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400113F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule", "UnityEditor.VectorGraphicsModule"})]
	internal VectorImageVertex[] vertices; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4001140")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
	internal UInt16[] indices; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001141")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
	internal GradientSettings[] settings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4001142")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
	internal Vector2 size; //Field offset: 0x40

	[Token(Token = "0x17000A0F")]
	public float height
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x600268B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000A0E")]
	public float width
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x600268A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x32C6E80", Offset = "0x32C6280", Length = "0x9F")]
	[Token(Token = "0x600268D")]
	public VectorImage() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x600268B")]
	public float get_height() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x600268A")]
	public float get_width() { }

	[Address(RVA = "0x32C6DF0", Offset = "0x32C61F0", Length = "0x8D")]
	[Token(Token = "0x600268C")]
	private void OnDestroy() { }

}

