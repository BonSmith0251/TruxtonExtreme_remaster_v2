namespace UnityEngine.XR;

[Token(Token = "0x2000007")]
internal enum InputFeatureType : uint
{
	Custom = 0,
	Binary = 1,
	DiscreteStates = 2,
	Axis1D = 3,
	Axis2D = 4,
	Axis3D = 5,
	Rotation = 6,
	Hand = 7,
	Bone = 8,
	Eyes = 9,
	kUnityXRInputFeatureTypeInvalid = 4294967295,
}

