namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x20001FB")]
public sealed class VolumeRequiresRendererFeatures : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C09")]
	internal HashSet<Type> TargetFeatureTypes; //Field offset: 0x10

	[Address(RVA = "0x2E18090", Offset = "0x2E17490", Length = "0xD4")]
	[Token(Token = "0x6000ACD")]
	public VolumeRequiresRendererFeatures(Type[] featureTypes) { }

}

