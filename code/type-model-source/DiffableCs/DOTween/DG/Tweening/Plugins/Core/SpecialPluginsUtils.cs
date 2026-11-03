namespace DG.Tweening.Plugins.Core;

[Token(Token = "0x2000092")]
internal static class SpecialPluginsUtils
{

	[Address(RVA = "0x673090", Offset = "0x672490", Length = "0x2AA")]
	[Token(Token = "0x6000365")]
	internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	[Address(RVA = "0x673340", Offset = "0x672740", Length = "0x1D6")]
	[Token(Token = "0x6000362")]
	internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	[Address(RVA = "0x673520", Offset = "0x672920", Length = "0x14A")]
	[Token(Token = "0x6000363")]
	internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	[Address(RVA = "0x673670", Offset = "0x672A70", Length = "0x38")]
	[Token(Token = "0x6000364")]
	internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

}

